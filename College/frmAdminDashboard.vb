Public Class frmAdminDashboard

    Private sidebarExpanded As Boolean = True

    ' ✅ Fix: Emoji arrays stored at class level for collapse/expand
    Private ReadOnly collapseIcons() As String = {"👨‍🎓", "👨‍🏫", "📅", "📝", "💰"}
    Private ReadOnly expandTexts() As String = {
        "👨‍🎓   Students", "👨‍🏫   Teachers",
        "📅   Attendance", "📝   Results", "💰   Fees"
    }

    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboardStats()
        ' Setup transparent backgrounds so painting shows
        pnlCard1.BackColor = Color.Transparent
        pnlCard2.BackColor = Color.Transparent
        pnlCard3.BackColor = Color.Transparent
        pnlCard4.BackColor = Color.Transparent
        pnlInfo.BackColor = Color.Transparent
        ' Setup rounded panel layouts
        pnlCard1.Padding = New Padding(5)
        pnlCard2.Padding = New Padding(5)
        pnlCard3.Padding = New Padding(5)
        pnlCard4.Padding = New Padding(5)
        ' Attach paint handlers dynamically
        AddHandler pnlCard1.Paint, AddressOf pnlCard1_Paint
        AddHandler pnlCard2.Paint, AddressOf pnlCard1_Paint
        AddHandler pnlCard3.Paint, AddressOf pnlCard1_Paint
        AddHandler pnlCard4.Paint, AddressOf pnlCard1_Paint

        If pnlInfo IsNot Nothing Then
            AddHandler pnlInfo.Paint, AddressOf pnlCard1_Paint
        End If
    End Sub

    ' ══════════════════════════════════════════
    '  STATS
    ' ══════════════════════════════════════════
    Private Sub LoadDashboardStats()
        Try
            Dim dtStudents = DatabaseHelper.ExecuteQuery("SELECT COUNT(*) AS total FROM students")
            SetCardValue(lblStudentCount, dtStudents.Rows(0)("total").ToString())

            Dim dtTeachers = DatabaseHelper.ExecuteQuery("SELECT COUNT(*) AS total FROM teachers")
            SetCardValue(lblTeacherCount, dtTeachers.Rows(0)("total").ToString())

            RefreshFeeStats()

        Catch ex As Exception
            MessageBox.Show("Error loading stats: " & ex.Message)
        End Try
    End Sub

    Public Sub RefreshFeeStats()
        Try
            Dim dtFees = DatabaseHelper.ExecuteQuery(
                "SELECT COALESCE(SUM(paid_amount), 0) AS collected, " &
                "COALESCE(SUM(amount - paid_amount), 0) AS pending FROM fees")

            Dim collected = Convert.ToDecimal(dtFees.Rows(0)("collected"))
            Dim pending = Convert.ToDecimal(dtFees.Rows(0)("pending"))

            SetCardValue(lblFeesAmount, FormatAmount(collected))
            SetCardValue(lblPendingAmount, FormatAmount(pending))

        Catch
            SetCardValue(lblFeesAmount, "Rs.0")
            SetCardValue(lblPendingAmount, "Rs.0")
        End Try
    End Sub

    Private Function FormatAmount(amt As Decimal) As String
        If amt >= 10000000 Then
            Return "Rs." & Math.Round(amt / 10000000, 1) & "Cr"
        ElseIf amt >= 100000 Then
            Return "Rs." & Math.Round(amt / 100000, 1) & "L"
        ElseIf amt >= 1000 Then
            Return "Rs." & Math.Round(amt / 1000, 1) & "K"
        Else
            Return "Rs." & amt.ToString("0")
        End If
    End Function

    Private Sub SetCardValue(lbl As Label, text As String)
        lbl.Text = text
        If text.Length <= 6 Then
            lbl.Font = New Font("Segoe UI", 20, FontStyle.Bold)
        ElseIf text.Length <= 9 Then
            lbl.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Else
            lbl.Font = New Font("Segoe UI", 13, FontStyle.Bold)
        End If
    End Sub

    ' ══════════════════════════════════════════
    '  HAMBURGER MENU TOGGLE
    ' ══════════════════════════════════════════
    Private Sub btnHamburger_Click(sender As Object, e As EventArgs) Handles btnHamburger.Click
        ' ✅ Fix: Use fixed arrays instead of Substring (emojis are surrogate pairs)
        Dim buttons() As Button = {btnStudents, btnTeachers, btnAttendance, btnResults, btnFees}

        If sidebarExpanded Then
            ' ── Collapse ──
            pnlSidebar.Width = 55
            lblMenuTitle.Visible = False

            For idx As Integer = 0 To buttons.Length - 1
                buttons(idx).Text = collapseIcons(idx)           ' ✅ Direct emoji assign
                buttons(idx).Font = New Font("Segoe UI Emoji", 14)
                buttons(idx).TextAlign = ContentAlignment.MiddleCenter
                buttons(idx).Padding = New Padding(0)
            Next

            pnlMain.Location = New Point(55, 65)
            pnlMain.Width = 945
        Else
            ' ── Expand ──
            pnlSidebar.Width = 200
            lblMenuTitle.Visible = True

            For idx As Integer = 0 To buttons.Length - 1
                buttons(idx).Text = expandTexts(idx)             ' ✅ Full text with emoji
                buttons(idx).Font = New Font("Segoe UI", 10, FontStyle.Bold)
                buttons(idx).TextAlign = ContentAlignment.MiddleLeft
                buttons(idx).Padding = New Padding(18, 0, 0, 0)
            Next

            pnlMain.Location = New Point(200, 65)
            pnlMain.Width = 800
        End If

        sidebarExpanded = Not sidebarExpanded
    End Sub

    ' ══════════════════════════════════════════
    '  SEARCH BY ID
    ' ══════════════════════════════════════════
    Private Sub btnSearchStudent_Click(sender As Object, e As EventArgs) Handles btnSearchStudent.Click
        If txtStudentId.Text.Trim() = "" Then
            MessageBox.Show("Please enter a Student ID.", "Validation",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim query = "SELECT s.student_id AS `ID`, s.roll_no AS `Roll No`, " &
                        "s.first_name AS `First Name`, s.last_name AS `Last Name`, " &
                        "s.email AS `Email`, s.phone AS `Phone`, s.gender AS `Gender`, " &
                        "c.course_name AS `Course`, s.semester AS `Semester`, " &
                        "s.admission_year AS `Admission Year` " &
                        "FROM students s LEFT JOIN courses c ON s.course_id = c.course_id " &
                        "WHERE s.student_id='" & txtStudentId.Text.Trim() & "' OR s.roll_no='" & txtStudentId.Text.Trim() & "'"

            Dim dt = DatabaseHelper.ExecuteQuery(query)
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No student found with ID: " & txtStudentId.Text.Trim(),
                               "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                pnlInfo.Visible = False
                Return
            End If

            dgvInfo.DataSource = dt
            pnlInfo.Visible = True

        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSearchTeacher_Click(sender As Object, e As EventArgs) Handles btnSearchTeacher.Click
        If txtTeacherId.Text.Trim() = "" Then
            MessageBox.Show("Please enter a Teacher ID.", "Validation",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim query = "SELECT t.teacher_id AS `ID`, t.emp_code AS `Emp Code`, " &
                        "t.first_name AS `First Name`, t.last_name AS `Last Name`, " &
                        "t.email AS `Email`, t.phone AS `Phone`, " &
                        "d.dept_name AS `Department`, t.joining_date AS `Joining Date` " &
                        "FROM teachers t LEFT JOIN departments d ON t.dept_id = d.dept_id " &
                        "WHERE t.teacher_id='" & txtTeacherId.Text.Trim() & "' OR t.emp_code='" & txtTeacherId.Text.Trim() & "'"

            Dim dt = DatabaseHelper.ExecuteQuery(query)
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No teacher found with ID: " & txtTeacherId.Text.Trim(),
                               "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                pnlInfo.Visible = False
                Return
            End If

            dgvInfo.DataSource = dt
            pnlInfo.Visible = True

        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Enter key se bhi search ho
    Private Sub txtStudentId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStudentId.KeyDown
        If e.KeyCode = Keys.Enter Then btnSearchStudent_Click(sender, e)
    End Sub

    Private Sub txtTeacherId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTeacherId.KeyDown
        If e.KeyCode = Keys.Enter Then btnSearchTeacher_Click(sender, e)
    End Sub

    ' ══════════════════════════════════════════
    '  UI Enhancements (Rounded Corners)
    ' ══════════════════════════════════════════
    Private Sub DrawRoundedPanel(pnl As Panel, e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        Dim rect As New Rectangle(0, 0, pnl.Width - 1, pnl.Height - 1)
        Dim radius As Integer = 8
        Dim path As New Drawing2D.GraphicsPath()

        path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
        path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90)
        path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90)
        path.CloseFigure()

        g.FillPath(New SolidBrush(Color.White), path)
        g.DrawPath(New Pen(Color.FromArgb(226, 232, 240), 1), path)
    End Sub

    Private Sub pnlCard1_Paint(sender As Object, e As PaintEventArgs)
        DrawRoundedPanel(CType(sender, Panel), e)
    End Sub

    ' ══════════════════════════════════════════
    '  SIDEBAR HOVER
    ' ══════════════════════════════════════════
    Private Sub SideBtn_MouseEnter(sender As Object, e As EventArgs) _
        Handles btnStudents.MouseEnter, btnTeachers.MouseEnter,
                btnAttendance.MouseEnter, btnResults.MouseEnter, btnFees.MouseEnter
        CType(sender, Button).BackColor = Color.FromArgb(45, 55, 72)
        CType(sender, Button).ForeColor = Color.White
    End Sub

    Private Sub SideBtn_MouseLeave(sender As Object, e As EventArgs) _
        Handles btnStudents.MouseLeave, btnTeachers.MouseLeave,
                btnAttendance.MouseLeave, btnResults.MouseLeave, btnFees.MouseLeave
        CType(sender, Button).BackColor = Color.FromArgb(26, 32, 44)
        CType(sender, Button).ForeColor = Color.FromArgb(180, 195, 215)
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

    ' ══════════════════════════════════════════
    '  SIDEBAR NAV
    ' ══════════════════════════════════════════
    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        Dim f As New frmStudents() : f.Show()
    End Sub

    Private Sub btnTeachers_Click(sender As Object, e As EventArgs) Handles btnTeachers.Click
        Dim f As New frmTeachers() : f.Show()
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        Dim f As New frmAttendance() : f.Show()
    End Sub

    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click
        Dim f As New frmResults() : f.Show()
    End Sub

    Private Sub btnFees_Click(sender As Object, e As EventArgs) Handles btnFees.Click
        Dim f As New frmFees() : f.Show()
    End Sub

End Class
