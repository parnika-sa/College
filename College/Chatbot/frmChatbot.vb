Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class frmChatbot

    ' ══════════════════════════════════════════
    '  PUBLIC PROPERTIES — set before Show()
    ' ══════════════════════════════════════════
    Public Property UserRole As String = "student"
    Public Property UserId   As Integer = 0
    Public Property UserName As String = "User"

    Private ReadOnly _http  As New HttpClient()
    Private Const SERVER_URL As String = "http://localhost:5000/chat"
    Private Const CLEAR_URL  As String = "http://localhost:5000/clear_history"

    Private _tmr  As New Timer()
    Private _dots As Integer = 0

    ' ── Role colours (indigo palette) ──────────────────────
    Private ReadOnly COL_USER  As Color = Color.FromArgb(99, 102, 241)   ' Indigo
    Private ReadOnly COL_BOT   As Color = Color.FromArgb(16, 185, 129)   ' Emerald
    Private ReadOnly COL_ERR   As Color = Color.FromArgb(239, 68, 68)    ' Red
    Private ReadOnly COL_ADMIN As Color = Color.FromArgb(245, 158, 11)   ' Amber
    Private ReadOnly COL_TEACH As Color = Color.FromArgb(59, 130, 246)   ' Blue

    ' ══════════════════════════════════════════
    '  LOAD
    ' ══════════════════════════════════════════
    Private Sub frmChatbot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _http.Timeout = TimeSpan.FromSeconds(45)

        _tmr.Interval = 450
        AddHandler _tmr.Tick, AddressOf TickTyping

        ' Role badge
        lblRoleBadge.BackColor = GetRoleColor()
        lblRoleBadge.Text      = "  " & UserRole.ToUpper() & "  "

        ShowWelcome()

        ' Initialise placeholder
        txtInput.ForeColor = Color.FromArgb(75, 85, 99)
        txtInput.Text      = PLACEHOLDER
        _placeholderActive = True

        ' Ensure focus lands on input box after form paints
        Me.BeginInvoke(Sub() txtInput.Focus())
    End Sub

    ' Clicking chat area redirects focus to input box
    Private Sub rtbChat_Click(s As Object, e As EventArgs) Handles rtbChat.Click
        txtInput.Focus()
    End Sub

    Private Function GetRoleColor() As Color
        Select Case UserRole.ToLower()
            Case "admin"   : Return COL_ADMIN
            Case "teacher" : Return COL_TEACH
            Case Else      : Return COL_USER
        End Select
    End Function

    Private Sub ShowWelcome()
        Dim welcome As String = $"Hello {UserName}! 👋  I'm your College ERP Assistant." & vbCrLf & vbCrLf
        Select Case UserRole.ToLower()
            Case "admin"
                welcome &= "As ADMIN you can ask me about:" & vbCrLf &
                           "  • Student & teacher records" & vbCrLf &
                           "  • Fee payments & pending amounts" & vbCrLf &
                           "  • Attendance reports" & vbCrLf &
                           "  • Exam results & grades"
            Case "teacher"
                welcome &= "As TEACHER you can ask about:" & vbCrLf &
                           "  • Your department students" & vbCrLf &
                           "  • Attendance records" & vbCrLf &
                           "  • Subject-wise results"
            Case Else
                welcome &= "You can ask me about:" & vbCrLf &
                           "  • Your attendance percentage" & vbCrLf &
                           "  • Fee status & pending amount" & vbCrLf &
                           "  • Your exam results & grades"
        End Select
        welcome &= vbCrLf & vbCrLf & "Tip: Press Enter to send, Shift+Enter for new line."
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
    End Sub

    Private Async Function DoSend() As Task
        Dim msg As String = txtInput.Text.Trim()
        If msg = "" OrElse msg = PLACEHOLDER Then Return

        AppendBubble(UserName, msg, isMine:=True)
        txtInput.Clear()
        btnSend.Enabled = False
        StartTyping()

        Try
            Dim payload As New With {
                .message  = msg,
                .role     = UserRole.ToLower(),
                .user_id  = UserId
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
                "⚠️  Cannot connect to server." & vbCrLf & "Make sure Python server is running:  python app.py",
                isMine:=False, isError:=True)
        Catch ex As Exception
            StopTyping()
            AppendBubble("System", "⚠️  " & ex.Message, isMine:=False, isError:=True)
        Finally
            btnSend.Enabled = True
            txtInput.Focus()
        End Try
    End Function

    ' ══════════════════════════════════════════
    '  BUBBLE RENDERER  — dark-mode styled
    ' ══════════════════════════════════════════
    Private Sub AppendBubble(sender As String, message As String,
                             isMine As Boolean,
                             Optional isError As Boolean = False)

        If rtbChat.InvokeRequired Then
            rtbChat.Invoke(Sub() AppendBubble(sender, message, isMine, isError))
            Return
        End If

        ' Spacing between bubbles
        If rtbChat.TextLength > 0 Then
            Dim spStart As Integer = rtbChat.TextLength
            rtbChat.AppendText(vbCrLf)
            rtbChat.Select(spStart, vbCrLf.Length)
            rtbChat.SelectionBackColor = Color.FromArgb(15, 20, 30)
        End If

        ' ── Choose colours based on sender ────────────────────
        Dim nameColor As Color
        Dim bubbleBg  As Color
        Dim indent    As String

        If isError Then
            nameColor = COL_ERR
            bubbleBg  = Color.FromArgb(40, 15, 15)
            indent    = "  "
        ElseIf isMine Then
            nameColor = GetRoleColor()
            bubbleBg  = Color.FromArgb(30, 32, 60)   ' Dark indigo tint
            indent    = "      "                       ' Right-ish indent
        Else
            nameColor = COL_BOT
            bubbleBg  = Color.FromArgb(18, 40, 35)   ' Dark emerald tint
            indent    = "  "
        End If

        ' ── Sender name ───────────────────────────────────────
        Dim nameStart As Integer = rtbChat.TextLength
        rtbChat.AppendText(indent & sender & vbCrLf)
        rtbChat.Select(nameStart, indent.Length + sender.Length + vbCrLf.Length)
        rtbChat.SelectionFont      = New Font("Segoe UI", 8.5, FontStyle.Bold)
        rtbChat.SelectionColor     = nameColor
        rtbChat.SelectionBackColor = bubbleBg

        ' ── Message body ──────────────────────────────────────
        Dim msgStart As Integer = rtbChat.TextLength
        rtbChat.AppendText(indent & message & vbCrLf)
        Dim msgLen As Integer = indent.Length + message.Length + vbCrLf.Length
        rtbChat.Select(msgStart, msgLen)
        rtbChat.SelectionFont      = New Font("Segoe UI", 10.5)
        rtbChat.SelectionColor     = Color.FromArgb(229, 231, 235)
        rtbChat.SelectionBackColor = bubbleBg

        ' ── Timestamp ─────────────────────────────────────────
        Dim timeStart As Integer = rtbChat.TextLength
        Dim timeStr   As String  = indent & DateTime.Now.ToString("hh:mm tt") & vbCrLf
        rtbChat.AppendText(timeStr)
        rtbChat.Select(timeStart, timeStr.Length)
        rtbChat.SelectionFont      = New Font("Segoe UI", 7.5, FontStyle.Italic)
        rtbChat.SelectionColor     = Color.FromArgb(75, 85, 99)
        rtbChat.SelectionBackColor = bubbleBg

        ' ── Bottom spacer ─────────────────────────────────────
        Dim padStart As Integer = rtbChat.TextLength
        rtbChat.AppendText("  " & vbCrLf)
        rtbChat.Select(padStart, 2 + vbCrLf.Length)
        rtbChat.SelectionBackColor = Color.FromArgb(15, 20, 30)

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
    Private Async Sub btnClear_Click(s As Object, e As EventArgs) Handles btnClear.Click
        If MessageBox.Show("Clear chat and reset conversation memory?", "Confirm Clear",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.Yes Then

            ' Clear server-side history too
            Try
                Dim payload As New With {.role = UserRole.ToLower(), .user_id = UserId}
                Dim json    As String = JsonConvert.SerializeObject(payload)
                Dim content As New StringContent(json, Encoding.UTF8, "application/json")
                Await _http.PostAsync(CLEAR_URL, content)
            Catch
                ' Silently ignore if server is not reachable
            End Try

            rtbChat.Clear()
            ShowWelcome()
        End If
    End Sub

    ' ══════════════════════════════════════════
    '  BUTTON HOVER EFFECTS
    ' ══════════════════════════════════════════
    Private Sub btnSend_MouseEnter(s As Object, e As EventArgs) Handles btnSend.MouseEnter
        btnSend.BackColor = Color.FromArgb(79, 70, 229)
    End Sub
    Private Sub btnSend_MouseLeave(s As Object, e As EventArgs) Handles btnSend.MouseLeave
        btnSend.BackColor = Color.FromArgb(99, 102, 241)
    End Sub
    Private Sub btnClear_MouseEnter(s As Object, e As EventArgs) Handles btnClear.MouseEnter
        btnClear.BackColor = Color.FromArgb(75, 85, 99)
        btnClear.ForeColor = Color.FromArgb(209, 213, 219)
    End Sub
    Private Sub btnClear_MouseLeave(s As Object, e As EventArgs) Handles btnClear.MouseLeave
        btnClear.BackColor = Color.FromArgb(55, 65, 81)
        btnClear.ForeColor = Color.FromArgb(156, 163, 175)
    End Sub

    ' ── Placeholder text for txtInput ──────────────────────────
    Private _placeholderActive As Boolean = False
    Private ReadOnly PLACEHOLDER As String = "Type a message..."

    Private Sub txtInput_Enter(s As Object, e As EventArgs) Handles txtInput.Enter
        If _placeholderActive Then
            txtInput.Text      = ""
            txtInput.ForeColor = Color.FromArgb(229, 231, 235)
            _placeholderActive = False
        End If
    End Sub

    Private Sub txtInput_Leave(s As Object, e As EventArgs) Handles txtInput.Leave
        ' Only show placeholder if focus is NOT going to a button
        If txtInput.Text.Trim() = "" OrElse txtInput.Text = PLACEHOLDER Then
            txtInput.ForeColor = Color.FromArgb(75, 85, 99)
            txtInput.Text      = PLACEHOLDER
            _placeholderActive = True
        End If
    End Sub

End Class