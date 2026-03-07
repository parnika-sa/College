Public Class frmTeacherDashboard

    Public Property TeacherId As Integer = 0
    Public Property TeacherName As String = ""
    Private TeacherDeptId As Integer = 0

    Private Sub frmTeacherDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & TeacherName & "!"
        LoadTeacherDeptId()
        LoadStats()
        ShowMyStudents()
        btnMyStudents.BackColor = Color.FromArgb(31, 73, 125)
    End Sub

    ' ══════════════════════════════════════════
    '  RESIZE
    ' ══════════════════════════════════════════
    Private Sub frmTeacherDashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim w = Me.ClientSize.Width
        Dim h = Me.ClientSize.Height

        pnlTop.Width = w
        lblWelcome.Location = New Point(w - 300, 18)
        btnLogout.Location = New Point(w - 115, 14)
        pnlLeft.Height = h - 60
        pnlStats.Width = w - 195

        Dim cardW = (pnlStats.Width - 50) \ 4
        pnlCard1.Width = cardW
        pnlCard2.Width = cardW
        pnlCard2.Location = New Point(15 + cardW + 10, 10)
        pnlCard3.Width = cardW
        pnlCard3.Location = New Point(15 + (cardW + 10) * 2, 10)
        pnlCard4.Width = cardW
        pnlCard4.Location = New Point(15 + (cardW + 10) * 3, 10)

        pnlContent.Width = w - 195
        pnlContent.Height = h - 230
        dgvMain.Width = pnlContent.Width - 10
        dgvMain.Height = pnlContent.Height - 50
    End Sub

    ' ══════════════════════════════════════════
    '  Get Teacher's Dept ID first
    ' ══════════════════════════════════════════
    Private Sub LoadTeacherDeptId()
        Try
            Dim dt = DatabaseHelper.ExecuteQuery(
                "SELECT dept_id FROM teachers WHERE teacher_id=" & TeacherId)
            If dt.Rows.Count > 0 AndAlso dt.Rows(0)("dept_id") IsNot DBNull.Value Then
                TeacherDeptId = Convert.ToInt32(dt.Rows(0)("dept_id"))
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading teacher info: " & ex.Message)
        End Try
    End Sub

    ' ══════════════════════════════════════════
    '  STATS
    ' ══════════════════════════════════════════
    Private Sub LoadStats()
        Try
            ' Card 1 - My Students (only same dept)
            Dim dtS = DatabaseHelper.ExecuteQuery(
                "SELECT COUNT(DISTINCT s.student_id) AS total " &
                "FROM students s " &
                "JOIN courses c ON s.course_id = c.course_id " &
                "WHERE c.dept_id=" & TeacherDeptId)
            lblMyStudents.Text = dtS.Rows(0)("total").ToString()

            ' Card 2 - My Subjects (only same dept)
            Dim dtSub = DatabaseHelper.ExecuteQuery(
                "SELECT COUNT(*) AS total FROM subjects s " &
                "JOIN courses c ON s.course_id = c.course_id " &
                "WHERE c.dept_id=" & TeacherDeptId)
            lblMySubjects.Text = dtSub.Rows(0)("total").ToString()

            ' Card 3 - Department name
            Dim dtD = DatabaseHelper.ExecuteQuery(
                "SELECT dept_name FROM departments WHERE dept_id=" & TeacherDeptId)
            If dtD.Rows.Count > 0 Then
                Dim dept = dtD.Rows(0)("dept_name").ToString()
                lblDept.Text = If(dept.Length > 10, dept.Substring(0, 10) & "..", dept)
                lblDept.Font = New Font("Segoe UI", 14, FontStyle.Bold)
            End If

            ' Card 4 - Today
            lblTodayDate.Text = DateTime.Now.ToString("dd MMM")
            lblTodayDate.Font = New Font("Segoe UI", 16, FontStyle.Bold)

        Catch ex As Exception
            MessageBox.Show("Stats error: " & ex.Message)
        End Try
    End Sub

    ' ══════════════════════════════════════════
    '  SIDEBAR BUTTONS
    ' ══════════════════════════════════════════
    Private Sub btnMyProfile_Click(sender As Object, e As EventArgs) Handles btnMyProfile.Click
        ResetButtonColors()
        btnMyProfile.BackColor = Color.FromArgb(31, 73, 125)
        ShowProfile()
    End Sub

    Private Sub btnMyStudents_Click(sender As Object, e As EventArgs) Handles btnMyStudents.Click
        ResetButtonColors()
        btnMyStudents.BackColor = Color.FromArgb(31, 73, 125)
        ShowMyStudents()
    End Sub

    Private Sub btnMarkAttendance_Click(sender As Object, e As EventArgs) Handles btnMarkAttendance.Click
        ResetButtonColors()
        btnMarkAttendance.BackColor = Color.FromArgb(31, 73, 125)
        Dim f As New frmAttendance()
        f.Show()
    End Sub

    Private Sub btnViewAttendance_Click(sender As Object, e As EventArgs) Handles btnViewAttendance.Click
        ResetButtonColors()
        btnViewAttendance.BackColor = Color.FromArgb(31, 73, 125)
        ShowAttendanceSummary()
    End Sub

    Private Sub btnEnterResults_Click(sender As Object, e As EventArgs) Handles btnEnterResults.Click
        ResetButtonColors()
        btnEnterResults.BackColor = Color.FromArgb(31, 73, 125)
        Dim f As New frmResults()
        f.Show()
    End Sub

    Private Sub ResetButtonColors()
        For Each btn As Button In pnlLeft.Controls.OfType(Of Button)()
            btn.BackColor = Color.FromArgb(52, 73, 94)
        Next
    End Sub

    ' Hover effects
    Private Sub SideBtn_MouseEnter(sender As Object, e As EventArgs) _
        Handles btnMyProfile.MouseEnter, btnMyStudents.MouseEnter,
                btnMarkAttendance.MouseEnter, btnViewAttendance.MouseEnter,
                btnEnterResults.MouseEnter
        Dim btn = CType(sender, Button)
        If btn.BackColor <> Color.FromArgb(31, 73, 125) Then
            btn.BackColor = Color.FromArgb(65, 90, 115)
        End If
    End Sub

    Private Sub SideBtn_MouseLeave(sender As Object, e As EventArgs) _
        Handles btnMyProfile.MouseLeave, btnMyStudents.MouseLeave,
                btnMarkAttendance.MouseLeave, btnViewAttendance.MouseLeave,
                btnEnterResults.MouseLeave
        Dim btn = CType(sender, Button)
        If btn.BackColor <> Color.FromArgb(31, 73, 125) Then
            btn.BackColor = Color.FromArgb(52, 73, 94)
        End If
    End Sub

    ' ══════════════════════════════════════════
    '  PROFILE  ✅ Fix: backticks instead of []
    ' ══════════════════════════════════════════
    Private Sub ShowProfile()
        lblContentTitle.Text = "  👤  My Profile"
        Try
            Dim query = "SELECT t.emp_code AS `Emp Code`, t.first_name AS `First Name`, " &
                        "t.last_name AS `Last Name`, t.email AS `Email`, " &
                        "t.phone AS `Phone`, d.dept_name AS `Department`, " &
                        "t.joining_date AS `Joining Date` " &
                        "FROM teachers t LEFT JOIN departments d ON t.dept_id = d.dept_id " &
                        "WHERE t.teacher_id=" & TeacherId
            Dim dt = DatabaseHelper.ExecuteQuery(query)
            dgvMain.DataSource = dt
            StyleGrid()
        Catch ex As Exception
            MessageBox.Show("Profile error: " & ex.Message)
        End Try
    End Sub

    ' ══════════════════════════════════════════
    '  MY STUDENTS ✅ Fix: backticks + dept filter
    ' ══════════════════════════════════════════
    Private Sub ShowMyStudents()
        lblContentTitle.Text = "  👨‍🎓  My Students"
        Try
            Dim query = "SELECT s.roll_no AS `Roll No`, " &
                        "CONCAT(s.first_name, ' ', s.last_name) AS `Student Name`, " &
                        "c.course_name AS `Course`, s.semester AS `Semester`, " &
                        "s.email AS `Email`, s.phone AS `Phone` " &
                        "FROM students s " &
                        "JOIN courses c ON s.course_id = c.course_id " &
                        "WHERE c.dept_id=" & TeacherDeptId &
                        " ORDER BY c.course_name, s.roll_no"
            Dim dt = DatabaseHelper.ExecuteQuery(query)
            dgvMain.DataSource = dt
            StyleGrid()
        Catch ex As Exception
            MessageBox.Show("Students error: " & ex.Message)
        End Try
    End Sub

    ' ══════════════════════════════════════════
    '  ATTENDANCE SUMMARY ✅ Fix: backticks + dept
    ' ══════════════════════════════════════════
    Private Sub ShowAttendanceSummary()
        lblContentTitle.Text = "  📅  Attendance Summary"
        Try
            Dim query = "SELECT CONCAT(s.roll_no, ' - ', s.first_name, ' ', s.last_name) AS `Student`, " &
                        "sub.subject_name AS `Subject`, " &
                        "COUNT(*) AS `Total Classes`, " &
                        "SUM(CASE WHEN a.status='Present' THEN 1 ELSE 0 END) AS `Present`, " &
                        "SUM(CASE WHEN a.status='Absent' THEN 1 ELSE 0 END) AS `Absent`, " &
                        "CONCAT(ROUND(SUM(CASE WHEN a.status='Present' THEN 1 ELSE 0 END) * 100.0 / COUNT(*), 1), '%') AS `Att %` " &
                        "FROM attendance a " &
                        "JOIN students s ON a.student_id = s.student_id " &
                        "JOIN subjects sub ON a.subject_id = sub.subject_id " &
                        "JOIN courses c ON s.course_id = c.course_id " &
                        "WHERE c.dept_id=" & TeacherDeptId &
                        " GROUP BY s.student_id, sub.subject_id " &
                        " ORDER BY s.roll_no, sub.subject_name"
            Dim dt = DatabaseHelper.ExecuteQuery(query)
            dgvMain.DataSource = dt
            StyleGrid()

            ' Color low attendance rows
            For Each row As DataGridViewRow In dgvMain.Rows
                If row.Cells("Att %").Value IsNot Nothing Then
                    Dim attStr = row.Cells("Att %").Value.ToString().Replace("%", "")
                    Dim attVal As Double = 0
                    If Double.TryParse(attStr, attVal) Then
                        If attVal < 75 Then
                            row.DefaultCellStyle.BackColor = Color.FromArgb(250, 219, 216)
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(150, 40, 27)
                        ElseIf attVal >= 90 Then
                            row.DefaultCellStyle.BackColor = Color.FromArgb(212, 239, 223)
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(30, 130, 76)
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Attendance error: " & ex.Message)
        End Try
    End Sub

    ' ══════════════════════════════════════════
    '  GRID STYLING
    ' ══════════════════════════════════════════
    Private Sub StyleGrid()
        dgvMain.EnableHeadersVisualStyles = False
        dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 73, 125)
        dgvMain.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvMain.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgvMain.ColumnHeadersDefaultCellStyle.Padding = New Padding(5, 0, 0, 0)
        dgvMain.RowTemplate.Height = 32
        dgvMain.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252)
        dgvMain.DefaultCellStyle.SelectionBackColor = Color.FromArgb(31, 73, 125)
        dgvMain.DefaultCellStyle.SelectionForeColor = Color.White
        dgvMain.DefaultCellStyle.Padding = New Padding(5, 0, 0, 0)
        dgvMain.GridColor = Color.FromArgb(220, 225, 235)
    End Sub

    ' ══════════════════════════════════════════
    '  LOGOUT
    ' ══════════════════════════════════════════
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim confirm = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Dim loginForm As New Form1()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnLogout_MouseEnter(sender As Object, e As EventArgs) Handles btnLogout.MouseEnter
        btnLogout.BackColor = Color.FromArgb(160, 40, 30)
    End Sub

    Private Sub btnLogout_MouseLeave(sender As Object, e As EventArgs) Handles btnLogout.MouseLeave
        btnLogout.BackColor = Color.FromArgb(192, 57, 43)
    End Sub

    Private Sub lblCard2Icon_Click(sender As Object, e As EventArgs) Handles lblCard2Icon.Click

    End Sub
End Class
