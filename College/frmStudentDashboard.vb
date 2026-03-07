Public Class frmStudentDashboard

    Public Property StudentId As Integer = 0
    Public Property StudentName As String = ""

    Private Sub frmStudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & StudentName & "!"
        LoadStats()
        ShowAttendance()
        btnMyAttendance.BackColor = Color.FromArgb(31, 73, 125)
    End Sub

    ' ══════════════════════════════════════════
    '  RESIZE — Controls adjust karo
    ' ══════════════════════════════════════════
    Private Sub frmStudentDashboard_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim w = Me.ClientSize.Width
        Dim h = Me.ClientSize.Height

        ' Header full width
        pnlTop.Width = w

        ' Welcome label right side pe
        lblWelcome.Location = New Point(w - 300, 18)
        btnLogout.Location = New Point(w - 115, 14)

        ' Left sidebar height
        pnlLeft.Height = h - 60

        ' Stats panel width
        pnlStats.Width = w - 195
        Dim cardW = (pnlStats.Width - 50) \ 4
        pnlCard1.Width = cardW
        pnlCard2.Width = cardW
        pnlCard2.Location = New Point(15 + cardW + 10, 10)
        pnlCard3.Width = cardW
        pnlCard3.Location = New Point(15 + (cardW + 10) * 2, 10)
        pnlCard4.Width = cardW
        pnlCard4.Location = New Point(15 + (cardW + 10) * 3, 10)

        ' Content panel
        pnlContent.Width = w - 195
        pnlContent.Height = h - 230
        dgvMain.Width = pnlContent.Width - 10
        dgvMain.Height = pnlContent.Height - 10
    End Sub

    ' ══════════════════════════════════════════
    '  STATS - 4 Cards
    ' ══════════════════════════════════════════
    Private Sub LoadStats()
        Try
            ' Card 1 - Attendance %
            Dim dtAtt = DatabaseHelper.ExecuteQuery(
                "SELECT COUNT(*) AS total, " &
                "SUM(CASE WHEN status='Present' THEN 1 ELSE 0 END) AS present " &
                "FROM attendance WHERE student_id=" & StudentId)
            If dtAtt.Rows.Count > 0 Then
                Dim total = Convert.ToInt32(dtAtt.Rows(0)("total"))
                Dim present = Convert.ToInt32(dtAtt.Rows(0)("present"))
                Dim pct = If(total > 0, Math.Round((present / total) * 100, 0), 0)
                lblAttPercent.Text = pct & "%"
                lblAttPercent.ForeColor = If(pct >= 75,
                    Color.FromArgb(39, 174, 96), Color.FromArgb(192, 57, 43))
            End If

            ' Card 2 - Total Subjects
            Dim dtSub = DatabaseHelper.ExecuteQuery(
                "SELECT COUNT(DISTINCT subject_id) AS total FROM results WHERE student_id=" & StudentId)
            lblTotalSubjects.Text = dtSub.Rows(0)("total").ToString()

            ' Card 3 - Fees Pending  ✅ Fix: backticks removed, simple column names
            Dim dtFee = DatabaseHelper.ExecuteQuery(
                "SELECT COALESCE(SUM(amount - paid_amount), 0) AS pending " &
                "FROM fees WHERE student_id=" & StudentId)
            Dim pending = Convert.ToDecimal(dtFee.Rows(0)("pending"))
            ' ✅ Fix: Short format so it fits in card
            If pending >= 100000 Then
                lblFeesPending.Text = "Rs." & Math.Round(pending / 100000, 1) & "L"
            ElseIf pending >= 1000 Then
                lblFeesPending.Text = "Rs." & Math.Round(pending / 1000, 1) & "K"
            Else
                lblFeesPending.Text = "Rs." & pending.ToString("0")
            End If

            ' Card 4 - Semester
            Dim dtSem = DatabaseHelper.ExecuteQuery(
                "SELECT semester FROM students WHERE student_id=" & StudentId)
            lblCurrentSem.Text = "Sem " & dtSem.Rows(0)("semester").ToString()

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

    Private Sub btnMyAttendance_Click(sender As Object, e As EventArgs) Handles btnMyAttendance.Click
        ResetButtonColors()
        btnMyAttendance.BackColor = Color.FromArgb(31, 73, 125)
        ShowAttendance()
    End Sub

    Private Sub btnMyResults_Click(sender As Object, e As EventArgs) Handles btnMyResults.Click
        ResetButtonColors()
        btnMyResults.BackColor = Color.FromArgb(31, 73, 125)
        ShowResults()
    End Sub

    Private Sub btnMyFees_Click(sender As Object, e As EventArgs) Handles btnMyFees.Click
        ResetButtonColors()
        btnMyFees.BackColor = Color.FromArgb(31, 73, 125)
        ShowFees()
    End Sub

    Private Sub ResetButtonColors()
        For Each btn As Button In pnlLeft.Controls.OfType(Of Button)()
            btn.BackColor = Color.FromArgb(52, 73, 94)
        Next
    End Sub

    ' Hover effects
    Private Sub SideBtn_MouseEnter(sender As Object, e As EventArgs) _
        Handles btnMyProfile.MouseEnter, btnMyAttendance.MouseEnter,
                btnMyResults.MouseEnter, btnMyFees.MouseEnter
        Dim btn = CType(sender, Button)
        If btn.BackColor <> Color.FromArgb(31, 73, 125) Then
            btn.BackColor = Color.FromArgb(65, 90, 115)
        End If
    End Sub

    Private Sub SideBtn_MouseLeave(sender As Object, e As EventArgs) _
        Handles btnMyProfile.MouseLeave, btnMyAttendance.MouseLeave,
                btnMyResults.MouseLeave, btnMyFees.MouseLeave
        Dim btn = CType(sender, Button)
        If btn.BackColor <> Color.FromArgb(31, 73, 125) Then
            btn.BackColor = Color.FromArgb(52, 73, 94)
        End If
    End Sub

    ' ══════════════════════════════════════════
    '  PROFILE
    ' ══════════════════════════════════════════
    Private Sub ShowProfile()
        pnlContentTitle.Text = "  👤  My Profile"
        Try
            Dim query = "SELECT s.roll_no AS `Roll No`, s.first_name AS `First Name`, " &
                        "s.last_name AS `Last Name`, s.email AS `Email`, " &
                        "s.phone AS `Phone`, s.gender AS `Gender`, " &
                        "c.course_name AS `Course`, s.semester AS `Semester`, " &
                        "s.admission_year AS `Admission Year` " &
                        "FROM students s LEFT JOIN courses c ON s.course_id = c.course_id " &
                        "WHERE s.student_id=" & StudentId
            Dim dt = DatabaseHelper.ExecuteQuery(query)
            dgvMain.DataSource = dt
            StyleGrid()
        Catch ex As Exception
            MessageBox.Show("Profile error: " & ex.Message)
        End Try
    End Sub

    ' ══════════════════════════════════════════
    '  ATTENDANCE  ✅ Fix: backticks use kiye
    ' ══════════════════════════════════════════
    Private Sub ShowAttendance()
        pnlContentTitle.Text = "  📅  My Attendance"
        Try
            Dim query = "SELECT a.att_date AS `Date`, sub.subject_name AS `Subject`, " &
                        "a.status AS `Status` " &
                        "FROM attendance a " &
                        "JOIN subjects sub ON a.subject_id = sub.subject_id " &
                        "WHERE a.student_id=" & StudentId &
                        " ORDER BY a.att_date DESC"
            Dim dt = DatabaseHelper.ExecuteQuery(query)
            dgvMain.DataSource = dt
            StyleGrid()

            ' Color rows
            For Each row As DataGridViewRow In dgvMain.Rows
                If row.Cells("Status").Value IsNot Nothing Then
                    Select Case row.Cells("Status").Value.ToString()
                        Case "Present"
                            row.DefaultCellStyle.BackColor = Color.FromArgb(212, 239, 223)
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(30, 130, 76)
                        Case "Absent"
                            row.DefaultCellStyle.BackColor = Color.FromArgb(250, 219, 216)
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(150, 40, 27)
                        Case "Leave"
                            row.DefaultCellStyle.BackColor = Color.FromArgb(254, 249, 231)
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(180, 130, 20)
                    End Select
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Attendance error: " & ex.Message)
        End Try
    End Sub

    ' ══════════════════════════════════════════
    '  RESULTS  ✅ Fix: [Academic Year] → backtick
    ' ══════════════════════════════════════════
    Private Sub ShowResults()
        pnlContentTitle.Text = "  📝  My Results"
        Try
            Dim query = "SELECT sub.subject_name AS `Subject`, r.semester AS `Semester`, " &
                        "r.internal_marks AS `Internal`, r.external_marks AS `External`, " &
                        "r.total_marks AS `Total Marks`, r.grade AS `Grade`, " &
                        "r.academic_year AS `Academic Year` " &
                        "FROM results r " &
                        "JOIN subjects sub ON r.subject_id = sub.subject_id " &
                        "WHERE r.student_id=" & StudentId &
                        " ORDER BY r.semester, sub.subject_name"
            Dim dt = DatabaseHelper.ExecuteQuery(query)
            dgvMain.DataSource = dt
            StyleGrid()

            ' Grade color
            For Each row As DataGridViewRow In dgvMain.Rows
                If row.Cells("Grade").Value IsNot Nothing Then
                    Select Case row.Cells("Grade").Value.ToString().ToUpper()
                        Case "A+", "A"
                            row.DefaultCellStyle.BackColor = Color.FromArgb(212, 239, 223)
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(30, 130, 76)
                        Case "B+", "B"
                            row.DefaultCellStyle.BackColor = Color.FromArgb(235, 245, 255)
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(37, 99, 200)
                        Case "C", "D"
                            row.DefaultCellStyle.BackColor = Color.FromArgb(254, 249, 231)
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(180, 130, 20)
                        Case "F"
                            row.DefaultCellStyle.BackColor = Color.FromArgb(250, 219, 216)
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(150, 40, 27)
                    End Select
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Results error: " & ex.Message)
        End Try
    End Sub

    ' ══════════════════════════════════════════
    '  FEES  ✅ Fix: [Fee Type] etc. → backticks
    ' ══════════════════════════════════════════
    Private Sub ShowFees()
        pnlContentTitle.Text = "  💰  My Fees"
        Try
            Dim query = "SELECT fee_type AS `Fee Type`, amount AS `Total (Rs.)`, " &
                        "paid_amount AS `Paid (Rs.)`, " &
                        "(amount - paid_amount) AS `Pending (Rs.)`, " &
                        "due_date AS `Due Date`, status AS `Status` " &
                        "FROM fees WHERE student_id=" & StudentId &
                        " ORDER BY fee_id DESC"
            Dim dt = DatabaseHelper.ExecuteQuery(query)
            dgvMain.DataSource = dt
            StyleGrid()

            ' Color rows
            For Each row As DataGridViewRow In dgvMain.Rows
                If row.Cells("Status").Value IsNot Nothing Then
                    Select Case row.Cells("Status").Value.ToString()
                        Case "Paid"
                            row.DefaultCellStyle.BackColor = Color.FromArgb(212, 239, 223)
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(30, 130, 76)
                        Case "Pending"
                            row.DefaultCellStyle.BackColor = Color.FromArgb(250, 219, 216)
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(150, 40, 27)
                        Case "Partial"
                            row.DefaultCellStyle.BackColor = Color.FromArgb(254, 249, 231)
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(180, 130, 20)
                    End Select
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Fees error: " & ex.Message)
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

End Class
