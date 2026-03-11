Imports System.Security.Cryptography
Imports System.Text

Public Class Form1

    ' ══════════════════════════════════════════
    '  ANIMATION TIMERS
    ' ══════════════════════════════════════════
    Private tmrFade As New Timer()
    Private tmrSlide As New Timer()
    Private _opacity As Double = 0
    Private _slideX As Integer = 80   ' pnlRight starts 80px to the right

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ── Database check ──
        If Not DatabaseHelper.TestConnection() Then
            MessageBox.Show("Unable to connect to the database. Please ensure MySQL is running.",
                           "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' ── Start animations ──
        StartAnimations()
    End Sub

    ' ══════════════════════════════════════════
    '  ANIMATIONS
    ' ══════════════════════════════════════════
    Private Sub StartAnimations()
        ' Form Fade-In
        Me.Opacity = 0
        _opacity = 0
        tmrFade.Interval = 15
        AddHandler tmrFade.Tick, AddressOf FadeIn
        tmrFade.Start()

        ' Right panel slide-in from right
        pnlRight.Left = 220 + _slideX   ' shifted right initially
        tmrSlide.Interval = 10
        AddHandler tmrSlide.Tick, AddressOf SlideIn
        tmrSlide.Start()
    End Sub

    Private Sub FadeIn(sender As Object, e As EventArgs)
        _opacity += 0.05
        If _opacity >= 1 Then
            _opacity = 1
            tmrFade.Stop()
        End If
        Me.Opacity = _opacity
    End Sub

    Private Sub SlideIn(sender As Object, e As EventArgs)
        Dim targetX As Integer = 220
        If pnlRight.Left > targetX Then
            pnlRight.Left -= 5
        Else
            pnlRight.Left = targetX
            tmrSlide.Stop()
        End If
    End Sub

    ' ══════════════════════════════════════════
    '  BUTTON HOVER EFFECT
    ' ══════════════════════════════════════════
    Private Sub btnLogin_MouseEnter(sender As Object, e As EventArgs) Handles btnLogin.MouseEnter
        btnLogin.BackColor = Color.FromArgb(20, 55, 100)
    End Sub

    Private Sub btnLogin_MouseLeave(sender As Object, e As EventArgs) Handles btnLogin.MouseLeave
        btnLogin.BackColor = Color.FromArgb(31, 73, 125)
    End Sub

    ' TextBox focus highlight
    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        txtUsername.BackColor = Color.White
    End Sub
    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        txtUsername.BackColor = Color.FromArgb(245, 247, 250)
    End Sub
    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        txtPassword.BackColor = Color.White
    End Sub
    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        txtPassword.BackColor = Color.FromArgb(245, 247, 250)
    End Sub

    ' ══════════════════════════════════════════
    '  LOGIN
    ' ══════════════════════════════════════════
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' ── Validation ──
        If txtUsername.Text.Trim() = "" Then
            MessageBox.Show("Please enter your username.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return
        End If

        If txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Please enter your password.", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

        ' ── Button loading state ──
        btnLogin.Text = "Signing in..."
        btnLogin.Enabled = False
        Application.DoEvents()

        Try
            Dim encPassword As String = GetMD5(txtPassword.Text.Trim())

            Dim query As String =
                "SELECT u.user_id, u.username, u.role, " &
                "COALESCE(s.student_id, 0) AS student_id, " &
                "COALESCE(t.teacher_id, 0) AS teacher_id, " &
                "COALESCE(s.first_name, t.first_name, u.username) AS first_name, " &
                "COALESCE(s.last_name, t.last_name, '') AS last_name " &
                "FROM users u " &
                "LEFT JOIN students s ON s.user_id = u.user_id " &
                "LEFT JOIN teachers t ON t.user_id = u.user_id " &
                "WHERE u.username='" & txtUsername.Text.Trim() & "' " &
                "AND u.password='" & encPassword & "' " &
                "AND u.is_active=1"

            Dim dt As DataTable = DatabaseHelper.ExecuteQuery(query)

            If dt.Rows.Count > 0 Then
                Dim role As String = dt.Rows(0)("role").ToString()
                Dim fullName As String = (dt.Rows(0)("first_name").ToString() &
                                         " " & dt.Rows(0)("last_name").ToString()).Trim()

                Select Case role
                    Case "admin"
                        Dim f As New frmAdminDashboard()
                        f.Show()
                        Me.Hide()

                    Case "student"
                        Dim f As New frmStudentDashboard()
                        f.StudentId = Convert.ToInt32(dt.Rows(0)("student_id"))
                        f.StudentName = fullName
                        f.Show()
                        Me.Hide()

                    Case "teacher"
                        Dim f As New frmTeacherDashboard()
                        f.TeacherId = Convert.ToInt32(dt.Rows(0)("teacher_id"))
                        f.TeacherName = fullName
                        f.Show()
                        Me.Hide()
                End Select
            Else
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed",
                               MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Clear()
                txtPassword.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred during login: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' ── Restore button ──
            btnLogin.Text = "SIGN IN  →"
            btnLogin.Enabled = True
        End Try
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Function GetMD5(input As String) As String
        Using md5 As New MD5CryptoServiceProvider()
            Dim bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(input))
            Return BitConverter.ToString(bytes).Replace("-", "").ToLower()
        End Using
    End Function

End Class