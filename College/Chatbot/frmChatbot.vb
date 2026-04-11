Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class frmChatbot

    ' ══════════════════════════════════════════
    '  PUBLIC PROPERTIES — set before Show()
    ' ══════════════════════════════════════════
    Public Property UserRole As String = "student"
    Public Property UserId As Integer = 0
    Public Property UserName As String = "User"

    Private ReadOnly _http As New HttpClient()
    Private Const SERVER_URL As String = "http://localhost:5000/chat"
    Private _sessionId As String = Guid.NewGuid().ToString("N").Substring(0, 12)
    Private _tmr As New Timer()
    Private _dots As Integer = 0

    ' ══════════════════════════════════════════
    '  LOAD
    ' ══════════════════════════════════════════
    Private Sub frmChatbot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _http.Timeout = TimeSpan.FromSeconds(30)

        _tmr.Interval = 400
        AddHandler _tmr.Tick, AddressOf TickTyping

        ' Role badge colour
        Dim roleColor As Color = GetRoleColor()
        lblRoleBadge.BackColor = roleColor
        lblRoleBadge.Text = "  " & UserRole.ToUpper() & "  "

        ShowWelcome()
        txtInput.Focus()
    End Sub

    Private Function GetRoleColor() As Color
        Select Case UserRole.ToLower()
            Case "admin"   : Return Color.FromArgb(180, 60, 60)
            Case "teacher" : Return Color.FromArgb(60, 130, 60)
            Case Else      : Return Color.FromArgb(30, 100, 160)
        End Select
    End Function

    Private Sub ShowWelcome()
        Dim welcome As String = $"Hello {UserName}! 👋  I'm your College ERP Assistant." & vbCrLf & vbCrLf
        Select Case UserRole.ToLower()
            Case "admin"
                welcome &= "As ADMIN you can ask me to:" & vbCrLf &
                           "  • Add / Remove students or teachers" & vbCrLf &
                           "  • Update fee payments" & vbCrLf &
                           "  • Mark attendance" & vbCrLf &
                           "  • Enter exam results" & vbCrLf &
                           "  • View any stats or reports"
            Case "teacher"
                welcome &= "As TEACHER you can:" & vbCrLf &
                           "  • Mark / view attendance" & vbCrLf &
                           "  • Enter / update results" & vbCrLf &
                           "  • View your department students"
            Case Else
                welcome &= "You can ask me about:" & vbCrLf &
                           "  • Your attendance percentage" & vbCrLf &
                           "  • Fee status & pending amount" & vbCrLf &
                           "  • Your exam results"
        End Select
        welcome &= vbCrLf & vbCrLf & "Tip: Press Shift+Enter for new line, Enter to send."
        AppendBubble("ERP Assistant", welcome, isMine:=False)
    End Sub

    ' ══════════════════════════════════════════
    '  SEND
    ' ══════════════════════════════════════════
    Private Async Sub btnSend_Click(s As Object, e As EventArgs) Handles btnSend.Click
        Await DoSend()
    End Sub

    Private Async Sub txtInput_KeyDown(s As Object, e As KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Not e.Shift Then
            e.SuppressKeyPress = True
            Await DoSend()
        End If
        ' Shift+Enter = new line (RichTextBox handles this naturally)
    End Sub

    Private Async Function DoSend() As Task
        Dim msg As String = txtInput.Text.Trim()
        If msg = "" Then Return

        AppendBubble(UserName, msg, isMine:=True)
        txtInput.Clear()
        btnSend.Enabled = False
        StartTyping()

        Try
            Dim payload As New With {
                .message   = msg,
                .role      = UserRole.ToLower(),
                .user_id   = UserId,
                .session_id = _sessionId
            }
            Dim json    As String = JsonConvert.SerializeObject(payload)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim resp    = Await _http.PostAsync(SERVER_URL, content)
            Dim raw     As String = Await resp.Content.ReadAsStringAsync()
            Dim result  = JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(raw)
            Dim reply   As String = result("reply")

            StopTyping()
            AppendBubble("ERP Assistant", reply, isMine:=False)

        Catch ex As HttpRequestException
            StopTyping()
            AppendBubble("System",
                "⚠️ Cannot connect to server." & vbCrLf & "Run: python app.py",
                isMine:=False, isError:=True)
        Catch ex As Exception
            StopTyping()
            AppendBubble("System", "Error: " & ex.Message, isMine:=False, isError:=True)
        Finally
            btnSend.Enabled = True
            txtInput.Focus()
        End Try
    End Function

    ' ══════════════════════════════════════════
    '  BUBBLE RENDERER
    ' ══════════════════════════════════════════
    Private Sub AppendBubble(sender As String, message As String,
                             isMine As Boolean,
                             Optional isError As Boolean = False)
        If rtbChat.InvokeRequired Then
            rtbChat.Invoke(Sub() AppendBubble(sender, message, isMine, isError))
            Return
        End If

        If rtbChat.TextLength > 0 Then rtbChat.AppendText(vbCrLf)

        ' ── Name ──────────────────────────────────────────
        Dim nameColor As Color
        If isError Then
            nameColor = Color.FromArgb(200, 50, 50)
        ElseIf isMine Then
            nameColor = Color.FromArgb(30, 80, 140)
        Else
            nameColor = GetRoleColor()
        End If

        Dim nameStart As Integer = rtbChat.TextLength
        rtbChat.AppendText("  " & sender & vbCrLf)
        rtbChat.Select(nameStart, 2 + sender.Length)
        rtbChat.SelectionFont  = New Font("Segoe UI", 9, FontStyle.Bold)
        rtbChat.SelectionColor = nameColor
        If isMine Then
            rtbChat.SelectionBackColor = Color.FromArgb(220, 232, 250)
        ElseIf isError Then
            rtbChat.SelectionBackColor = Color.FromArgb(255, 235, 235)
        Else
            rtbChat.SelectionBackColor = Color.FromArgb(232, 241, 255)
        End If

        ' ── Message ───────────────────────────────────────
        Dim msgBg As Color = If(isMine, Color.FromArgb(220, 232, 250),
                             If(isError, Color.FromArgb(255, 235, 235),
                                Color.FromArgb(232, 241, 255)))

        Dim msgStart As Integer = rtbChat.TextLength
        rtbChat.AppendText("  " & message & vbCrLf)
        Dim msgLen As Integer = 2 + message.Length
        rtbChat.Select(msgStart, msgLen)
        rtbChat.SelectionFont      = New Font("Consolas", 9.5)
        rtbChat.SelectionColor     = Color.FromArgb(25, 25, 25)
        rtbChat.SelectionBackColor = msgBg

        ' ── Time ──────────────────────────────────────────
        Dim timeStart As Integer = rtbChat.TextLength
        rtbChat.AppendText("  " & DateTime.Now.ToString("hh:mm tt") & vbCrLf)
        rtbChat.Select(timeStart, 2 + 8)
        rtbChat.SelectionFont      = New Font("Segoe UI", 7, FontStyle.Italic)
        rtbChat.SelectionColor     = Color.FromArgb(160, 160, 160)
        rtbChat.SelectionBackColor = msgBg

        rtbChat.SelectionStart = rtbChat.TextLength
        rtbChat.ScrollToCaret()
    End Sub

    ' ══════════════════════════════════════════
    '  TYPING ANIMATION
    ' ══════════════════════════════════════════
    Private Sub StartTyping()
        _dots = 0
        lblTyping.Text = "  ERP Assistant is thinking."
        _tmr.Start()
    End Sub
    Private Sub StopTyping()
        _tmr.Stop()
        lblTyping.Text = ""
    End Sub
    Private Sub TickTyping(s As Object, e As EventArgs)
        _dots = (_dots + 1) Mod 4
        lblTyping.Text = "  ERP Assistant is thinking" & New String("."c, _dots)
    End Sub

    ' ══════════════════════════════════════════
    '  CLEAR
    ' ══════════════════════════════════════════
    Private Sub btnClear_Click(s As Object, e As EventArgs) Handles btnClear.Click
        If MessageBox.Show("Clear chat?", "Confirm",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then
            rtbChat.Clear()
            _sessionId = Guid.NewGuid().ToString("N").Substring(0, 12)
            ShowWelcome()
        End If
    End Sub

    ' ══════════════════════════════════════════
    '  BUTTON HOVER
    ' ══════════════════════════════════════════
    Private Sub btnSend_MouseEnter(s As Object, e As EventArgs) Handles btnSend.MouseEnter
        btnSend.BackColor = Color.FromArgb(15, 55, 110)
    End Sub
    Private Sub btnSend_MouseLeave(s As Object, e As EventArgs) Handles btnSend.MouseLeave
        btnSend.BackColor = Color.FromArgb(31, 73, 125)
    End Sub
    Private Sub btnClear_MouseEnter(s As Object, e As EventArgs) Handles btnClear.MouseEnter
        btnClear.BackColor = Color.FromArgb(190, 190, 190)
    End Sub
    Private Sub btnClear_MouseLeave(s As Object, e As EventArgs) Handles btnClear.MouseLeave
        btnClear.BackColor = Color.FromArgb(215, 215, 215)
    End Sub

End Class