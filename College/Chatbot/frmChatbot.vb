Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class frmChatbot

    ' ══════════════════════════════════════════
    '  PROPERTIES — Set karo jab form open karo
    ' ══════════════════════════════════════════
    Public Property UserRole As String = "student"   ' "admin" / "teacher" / "student"
    Public Property UserId As Integer = 0
    Public Property UserName As String = "User"

    Private ReadOnly client As New HttpClient()
    Private Const SERVER_URL As String = "http://localhost:5000/chat"
    Private tmrTyping As New Timer()
    Private _typingDots As Integer = 0

    ' ══════════════════════════════════════════
    '  FORM LOAD
    ' ══════════════════════════════════════════
    Private Sub frmChatbot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        client.Timeout = TimeSpan.FromSeconds(30)

        ' Typing animation timer
        tmrTyping.Interval = 500
        AddHandler tmrTyping.Tick, AddressOf TypingAnimation

        ' Welcome message
        AppendMessage("ERP Assistant",
            $"Hello {UserName}! 👋 I'm your College ERP Assistant." & vbNewLine &
            GetRoleWelcome(),
            Color.FromArgb(31, 73, 125), Color.FromArgb(235, 242, 255))

        txtMessage.Focus()
    End Sub

    Private Function GetRoleWelcome() As String
        Select Case UserRole.ToLower()
            Case "admin"
                Return "You can ask me about:" & vbNewLine &
                       "• Total students & courses" & vbNewLine &
                       "• Pending fee records" & vbNewLine &
                       "• Students with low attendance" & vbNewLine &
                       "• Any college stats"
            Case "teacher"
                Return "You can ask me about:" & vbNewLine &
                       "• Your class attendance" & vbNewLine &
                       "• Student performance" & vbNewLine &
                       "• Subject-wise results"
            Case "student"
                Return "You can ask me about:" & vbNewLine &
                       "• Your attendance percentage" & vbNewLine &
                       "• Your fee status" & vbNewLine &
                       "• Your exam results" & vbNewLine &
                       "• Any college related queries"
            Case Else
                Return "How can I help you today?"
        End Select
    End Function

    ' ══════════════════════════════════════════
    '  SEND MESSAGE
    ' ══════════════════════════════════════════
    Private Async Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Await SendMessage()
    End Sub

    Private Async Sub txtMessage_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMessage.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Not e.Shift Then
            e.SuppressKeyPress = True
            Await SendMessage()
        End If
    End Sub

    Private Async Function SendMessage() As Task
        Dim msg As String = txtMessage.Text.Trim()
        If msg = "" Then Return

        ' Show user message
        AppendMessage("You", msg, Color.FromArgb(50, 50, 50), Color.FromArgb(220, 230, 245))
        txtMessage.Clear()

        ' Disable send + show typing
        btnSend.Enabled = False
        StartTyping()

        Try
            ' Build JSON payload
            Dim payload = New With {
                .message = msg,
                .role = UserRole.ToLower(),
                .user_id = UserId
            }
            Dim json As String = JsonConvert.SerializeObject(payload)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            ' Call Python server
            Dim response = Await client.PostAsync(SERVER_URL, content)
            Dim responseJson As String = Await response.Content.ReadAsStringAsync()

            Dim result = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(responseJson)
            Dim reply As String = result("reply")

            StopTyping()
            AppendMessage("ERP Assistant", reply, Color.FromArgb(31, 73, 125), Color.FromArgb(235, 242, 255))

        Catch ex As HttpRequestException
            StopTyping()
            AppendMessage("System",
                "⚠️ Cannot connect to chatbot server." & vbNewLine &
                "Please run: python app.py",
                Color.DarkRed, Color.FromArgb(255, 240, 240))

        Catch ex As Exception
            StopTyping()
            AppendMessage("System", "Error: " & ex.Message, Color.DarkRed, Color.FromArgb(255, 240, 240))
        Finally
            btnSend.Enabled = True
            txtMessage.Focus()
        End Try
    End Function

    ' ══════════════════════════════════════════
    '  CHAT BUBBLE RENDERER
    ' ══════════════════════════════════════════
    Private Sub AppendMessage(sender As String, message As String, nameColor As Color, bgColor As Color)
        If lstChat.InvokeRequired Then
            lstChat.Invoke(Sub() AppendMessage(sender, message, nameColor, bgColor))
            Return
        End If

        ' Separator line before each message (except first)
        If lstChat.TextLength > 0 Then
            lstChat.AppendText(vbNewLine)
        End If

        ' Sender name
        Dim startLen As Integer = lstChat.TextLength
        lstChat.AppendText($"  {sender}  " & vbNewLine)
        lstChat.Select(startLen, $"  {sender}  ".Length)
        lstChat.SelectionColor = nameColor
        lstChat.SelectionFont = New Font("Segoe UI", 9, FontStyle.Bold)
        lstChat.SelectionBackColor = bgColor

        ' Message body
        Dim msgStart As Integer = lstChat.TextLength
        lstChat.AppendText($"  {message}" & vbNewLine)
        lstChat.Select(msgStart, $"  {message}".Length)
        lstChat.SelectionColor = Color.FromArgb(40, 40, 40)
        lstChat.SelectionFont = New Font("Segoe UI", 10)
        lstChat.SelectionBackColor = bgColor

        ' Timestamp
        Dim timeStart As Integer = lstChat.TextLength
        lstChat.AppendText($"  {DateTime.Now:hh:mm tt}" & vbNewLine)
        lstChat.Select(timeStart, $"  {DateTime.Now:hh:mm tt}".Length)
        lstChat.SelectionColor = Color.LightGray
        lstChat.SelectionFont = New Font("Segoe UI", 7)
        lstChat.SelectionBackColor = bgColor

        ' Scroll to bottom
        lstChat.SelectionStart = lstChat.TextLength
        lstChat.ScrollToCaret()
    End Sub

    ' ══════════════════════════════════════════
    '  TYPING ANIMATION
    ' ══════════════════════════════════════════
    Private Sub StartTyping()
        _typingDots = 0
        lblTyping.Text = "  ERP Assistant is typing."
        tmrTyping.Start()
    End Sub

    Private Sub StopTyping()
        tmrTyping.Stop()
        lblTyping.Text = ""
    End Sub

    Private Sub TypingAnimation(sender As Object, e As EventArgs)
        _typingDots = (_typingDots + 1) Mod 4
        lblTyping.Text = "  ERP Assistant is typing" & New String("."c, _typingDots)
    End Sub

    ' ══════════════════════════════════════════
    '  CLEAR CHAT
    ' ══════════════════════════════════════════
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim confirm = MessageBox.Show("Clear chat history?", "Confirm",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            lstChat.Clear()
            AppendMessage("ERP Assistant", "Chat cleared. How can I help you?",
                         Color.FromArgb(31, 73, 125), Color.FromArgb(235, 242, 255))
        End If
    End Sub

    ' ══════════════════════════════════════════
    '  HOVER EFFECTS
    ' ══════════════════════════════════════════
    Private Sub btnSend_MouseEnter(sender As Object, e As EventArgs) Handles btnSend.MouseEnter
        btnSend.BackColor = Color.FromArgb(20, 55, 100)
    End Sub
    Private Sub btnSend_MouseLeave(sender As Object, e As EventArgs) Handles btnSend.MouseLeave
        btnSend.BackColor = Color.FromArgb(31, 73, 125)
    End Sub

End Class