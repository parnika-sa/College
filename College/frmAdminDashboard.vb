Public Class frmAdminDashboard

    Private sidebarExpanded As Boolean = True
    Private _activeBtn As Button = Nothing

    Private ReadOnly collapseIcons() As String = {"👥", "🧑", "📋", "📊", "💰"}
    Private ReadOnly expandTexts() As String = {
        "👥  Students", "🧑‍🏫  Teachers",
        "📋  Attendance", "📊  Results", "💰  Fees"
    }

    ' ══════════════════════════════════════════
    '  LOAD
    ' ══════════════════════════════════════════
    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tag = background colour used by PaintCard
        pnlCard1.Tag = Color.FromArgb(30, 27, 75)
        pnlCard2.Tag = Color.FromArgb(6, 46, 38)
        pnlCard3.Tag = Color.FromArgb(6, 46, 38)
        pnlCard4.Tag = Color.FromArgb(69, 10, 10)

        ' Rounded cards via Paint
        For Each pnl As Panel In {pnlCard1, pnlCard2, pnlCard3, pnlCard4}
            pnl.BackColor = Color.Transparent
            AddHandler pnl.Paint, AddressOf PaintCard
        Next

        ' Data
        LoadDashboardStats()
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
                "SELECT COALESCE(SUM(paid_amount),0) AS collected, " &
                "COALESCE(SUM(amount - paid_amount),0) AS pending FROM fees")
            SetCardValue(lblFeesAmount,    FormatAmount(Convert.ToDecimal(dtFees.Rows(0)("collected"))))
            SetCardValue(lblPendingAmount, FormatAmount(Convert.ToDecimal(dtFees.Rows(0)("pending"))))
        Catch
            SetCardValue(lblFeesAmount,    "Rs.0")
            SetCardValue(lblPendingAmount, "Rs.0")
        End Try
    End Sub

    Private Function FormatAmount(amt As Decimal) As String
        If amt >= 10000000 Then Return "Rs." & Math.Round(amt / 10000000, 1) & "Cr"
        If amt >= 100000   Then Return "Rs." & Math.Round(amt / 100000, 1) & "L"
        If amt >= 1000     Then Return "Rs." & Math.Round(amt / 1000, 1) & "K"
        Return "Rs." & amt.ToString("0")
    End Function

    Private Sub SetCardValue(lbl As Label, text As String)
        lbl.Text = text
        lbl.Font = New Font("Segoe UI", If(text.Length <= 6, 22, If(text.Length <= 9, 17, 13)), FontStyle.Bold)
    End Sub

    ' ══════════════════════════════════════════
    '  PAINT — Rounded Cards
    ' ══════════════════════════════════════════
    Private Sub PaintCard(sender As Object, e As PaintEventArgs)
        Dim pnl    As Panel    = CType(sender, Panel)
        Dim g      As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim rect   As New Rectangle(1, 1, pnl.Width - 2, pnl.Height - 2)
        Dim r      As Integer = 10
        Dim path   As New Drawing2D.GraphicsPath()
        path.AddArc(rect.X, rect.Y, r * 2, r * 2, 180, 90)
        path.AddArc(rect.Right - r * 2, rect.Y, r * 2, r * 2, 270, 90)
        path.AddArc(rect.Right - r * 2, rect.Bottom - r * 2, r * 2, r * 2, 0, 90)
        path.AddArc(rect.X, rect.Bottom - r * 2, r * 2, r * 2, 90, 90)
        path.CloseFigure()
        g.FillPath(New SolidBrush(pnl.Tag), path)
        g.DrawPath(New Pen(Color.FromArgb(40, 255, 255, 255), 1), path)
    End Sub

    ' ══════════════════════════════════════════
    '  HAMBURGER TOGGLE
    ' ══════════════════════════════════════════
    Private Sub btnHamburger_Click(sender As Object, e As EventArgs) Handles btnHamburger.Click
        Dim btns() As Button = {btnStudents, btnTeachers, btnAttendance, btnResults, btnFees}
        If sidebarExpanded Then
            pnlSidebar.Width = 55
            lblMenuTitle.Visible = False
            For i = 0 To btns.Length - 1
                btns(i).Text      = collapseIcons(i)
                btns(i).Font      = New Font("Segoe UI Emoji", 14)
                btns(i).TextAlign = ContentAlignment.MiddleCenter
                btns(i).Padding   = New Padding(0)
            Next
            pnlMain.Location = New Point(55, 71)
            pnlMain.Width    = 945
        Else
            pnlSidebar.Width = 210
            lblMenuTitle.Visible = True
            For i = 0 To btns.Length - 1
                btns(i).Text      = expandTexts(i)
                btns(i).Font      = New Font("Segoe UI", 10)
                btns(i).TextAlign = ContentAlignment.MiddleLeft
                btns(i).Padding   = New Padding(14, 0, 0, 0)
            Next
            pnlMain.Location = New Point(210, 71)
            pnlMain.Width    = 790
        End If
        sidebarExpanded = Not sidebarExpanded
    End Sub

    ' ══════════════════════════════════════════
    '  SIDEBAR ACTIVE STATE
    ' ══════════════════════════════════════════
    Private Sub SetActive(btn As Button)
        If _activeBtn IsNot Nothing Then
            _activeBtn.BackColor = Color.FromArgb(15, 23, 42)
            _activeBtn.ForeColor = Color.FromArgb(148, 163, 184)
        End If
        btn.BackColor = Color.FromArgb(30, 27, 75)
        btn.ForeColor = Color.FromArgb(129, 140, 248)
        _activeBtn = btn
    End Sub

    Private Sub SideBtn_MouseEnter(sender As Object, e As EventArgs) _
        Handles btnStudents.MouseEnter, btnTeachers.MouseEnter,
                btnAttendance.MouseEnter, btnResults.MouseEnter, btnFees.MouseEnter
        Dim b As Button = CType(sender, Button)
        If b IsNot _activeBtn Then b.BackColor = Color.FromArgb(30, 41, 59)
    End Sub

    Private Sub SideBtn_MouseLeave(sender As Object, e As EventArgs) _
        Handles btnStudents.MouseLeave, btnTeachers.MouseLeave,
                btnAttendance.MouseLeave, btnResults.MouseLeave, btnFees.MouseLeave
        Dim b As Button = CType(sender, Button)
        If b IsNot _activeBtn Then
            b.BackColor = Color.FromArgb(15, 23, 42)
            b.ForeColor = Color.FromArgb(148, 163, 184)
        End If
    End Sub

    ' ══════════════════════════════════════════
    '  AI CHATBOT
    ' ══════════════════════════════════════════
    Private Sub btnChatbot_Click(sender As Object, e As EventArgs) Handles btnChatbot.Click
        Dim chat As New frmChatbot()
        chat.UserRole = "admin"
        chat.UserId   = 0
        chat.UserName = "Admin"
        chat.Show()
    End Sub

    Private Sub btnChatbot_MouseEnter(s As Object, e As EventArgs) Handles btnChatbot.MouseEnter
        btnChatbot.BackColor = Color.FromArgb(79, 70, 229)
    End Sub
    Private Sub btnChatbot_MouseLeave(s As Object, e As EventArgs) Handles btnChatbot.MouseLeave
        btnChatbot.BackColor = Color.FromArgb(99, 102, 241)
    End Sub

    ' ══════════════════════════════════════════
    '  SEARCH
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
                        "WHERE s.student_id='" & txtStudentId.Text.Trim() &
                        "' OR s.roll_no='" & txtStudentId.Text.Trim() & "'"
            Dim dt = DatabaseHelper.ExecuteQuery(query)
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No student found.", "Not Found",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                pnlInfo.Visible = False
                Return
            End If
            dgvInfo.DataSource = dt
            pnlInfo.Visible    = True
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
                        "WHERE t.teacher_id='" & txtTeacherId.Text.Trim() &
                        "' OR t.emp_code='" & txtTeacherId.Text.Trim() & "'"
            Dim dt = DatabaseHelper.ExecuteQuery(query)
            If dt.Rows.Count = 0 Then
                MessageBox.Show("No teacher found.", "Not Found",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                pnlInfo.Visible = False
                Return
            End If
            dgvInfo.DataSource = dt
            pnlInfo.Visible    = True
        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtStudentId_KeyDown(s As Object, e As KeyEventArgs) Handles txtStudentId.KeyDown
        If e.KeyCode = Keys.Enter Then btnSearchStudent_Click(s, e)
    End Sub
    Private Sub txtTeacherId_KeyDown(s As Object, e As KeyEventArgs) Handles txtTeacherId.KeyDown
        If e.KeyCode = Keys.Enter Then btnSearchTeacher_Click(s, e)
    End Sub

    ' ══════════════════════════════════════════
    '  LOGOUT
    ' ══════════════════════════════════════════
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim loginForm As New Form1()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnLogout_MouseEnter(s As Object, e As EventArgs) Handles btnLogout.MouseEnter
        btnLogout.BackColor = Color.FromArgb(185, 28, 28)
    End Sub
    Private Sub btnLogout_MouseLeave(s As Object, e As EventArgs) Handles btnLogout.MouseLeave
        btnLogout.BackColor = Color.FromArgb(239, 68, 68)
    End Sub

    ' ══════════════════════════════════════════
    '  SIDEBAR NAV
    ' ══════════════════════════════════════════
    Private Sub btnStudents_Click(s As Object, e As EventArgs) Handles btnStudents.Click
        SetActive(btnStudents)
        Dim f As New frmStudents() : f.Show()
    End Sub
    Private Sub btnTeachers_Click(s As Object, e As EventArgs) Handles btnTeachers.Click
        SetActive(btnTeachers)
        Dim f As New frmTeachers() : f.Show()
    End Sub
    Private Sub btnAttendance_Click(s As Object, e As EventArgs) Handles btnAttendance.Click
        SetActive(btnAttendance)
        Dim f As New frmAttendance() : f.Show()
    End Sub
    Private Sub btnResults_Click(s As Object, e As EventArgs) Handles btnResults.Click
        SetActive(btnResults)
        Dim f As New frmResults() : f.Show()
    End Sub
    Private Sub btnFees_Click(s As Object, e As EventArgs) Handles btnFees.Click
        SetActive(btnFees)
        Dim f As New frmFees() : f.Show()
    End Sub

End Class