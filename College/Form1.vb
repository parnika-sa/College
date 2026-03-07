Imports System.Security.Cryptography
Imports System.Text

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not DatabaseHelper.TestConnection() Then
            MessageBox.Show("Database connect nahi ho raha! MySQL chalu hai?",
                           "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    ' ══════════════════════════════════════════
    '  LOGIN
    ' ══════════════════════════════════════════
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text.Trim() = "" Then
            MessageBox.Show("Username daalo!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return
        End If

        If txtPassword.Text.Trim() = "" Then
            MessageBox.Show("Password daalo!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

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
                MessageBox.Show("Username ya Password galat hai!", "Login Failed",
                               MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Clear()
                txtPassword.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Login error: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
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