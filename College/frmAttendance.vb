Public Class frmAttendance

    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourses()
    End Sub

    ' ══════════════════════════════════════════
    '  DATA LOADING
    ' ══════════════════════════════════════════
    Private Sub LoadCourses()
        Dim dt = DatabaseHelper.ExecuteQuery("SELECT course_id, course_name FROM courses ORDER BY course_name")
        cmbCourse.DataSource = dt
        cmbCourse.DisplayMember = "course_name"
        cmbCourse.ValueMember = "course_id"
        cmbCourse.SelectedIndex = -1

        Dim dt2 = DatabaseHelper.ExecuteQuery("SELECT course_id, course_name FROM courses ORDER BY course_name")
        cmbReportCourse.DataSource = dt2
        cmbReportCourse.DisplayMember = "course_name"
        cmbReportCourse.ValueMember = "course_id"
        cmbReportCourse.SelectedIndex = -1
    End Sub

    ' ══════════════════════════════════════════
    '  HELPER — safely read ComboBox value
    ' ══════════════════════════════════════════
    Private Function GetComboValue(cmb As ComboBox) As Integer
        If cmb.SelectedIndex = -1 OrElse cmb.SelectedValue Is Nothing Then Return -1
        Dim val = cmb.SelectedValue
        If TypeOf val Is DataRowView Then
            Return Convert.ToInt32(CType(val, DataRowView).Row(0))
        End If
        Return Convert.ToInt32(val)
    End Function

    ' ══════════════════════════════════════════
    '  COURSE → LOAD SUBJECTS
    ' ══════════════════════════════════════════
    Private Sub cmbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCourse.SelectedIndexChanged
        If cmbCourse.SelectedIndex = -1 Then Return
        Dim courseId = GetComboValue(cmbCourse)
        If courseId = -1 Then Return

        Dim dt = DatabaseHelper.ExecuteQuery(
            "SELECT subject_id, subject_name FROM subjects WHERE course_id=" & courseId)
        cmbSubject.DataSource = dt
        cmbSubject.DisplayMember = "subject_name"
        cmbSubject.ValueMember = "subject_id"
        cmbSubject.SelectedIndex = -1
        lblStatus.Text = "Course selected — now choose a Subject and Date, then click Load Students."
    End Sub

    ' ══════════════════════════════════════════
    '  REPORT COURSE → LOAD STUDENTS
    ' ══════════════════════════════════════════
    Private Sub cmbReportCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReportCourse.SelectedIndexChanged
        If cmbReportCourse.SelectedIndex = -1 Then Return
        Dim courseId = GetComboValue(cmbReportCourse)
        If courseId = -1 Then Return

        Dim dt = DatabaseHelper.ExecuteQuery(
            "SELECT student_id, CONCAT(roll_no, ' - ', first_name, ' ', last_name) AS name " &
            "FROM students WHERE course_id=" & courseId & " ORDER BY roll_no")
        cmbReportStudent.DataSource = dt
        cmbReportStudent.DisplayMember = "name"
        cmbReportStudent.ValueMember = "student_id"
        cmbReportStudent.SelectedIndex = -1
    End Sub

    ' ══════════════════════════════════════════
    '  LOAD STUDENTS INTO ATTENDANCE GRID
    ' ══════════════════════════════════════════
    Private Sub btnLoadStudents_Click(sender As Object, e As EventArgs) Handles btnLoadStudents.Click
        If cmbCourse.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Course first.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cmbSubject.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Subject first.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim courseId = GetComboValue(cmbCourse)
        Dim dt = DatabaseHelper.ExecuteQuery(
            "SELECT student_id, roll_no, CONCAT(first_name, ' ', last_name) AS name " &
            "FROM students WHERE course_id=" & courseId & " ORDER BY roll_no")

        dgvAttendance.Rows.Clear()
        dgvAttendance.Columns.Clear()

        dgvAttendance.Columns.Add("student_id", "ID")
        dgvAttendance.Columns("student_id").Visible = False

        Dim colRoll As New DataGridViewTextBoxColumn()
        colRoll.Name = "roll_no"
        colRoll.HeaderText = "Roll No"
        colRoll.Width = 100
        colRoll.ReadOnly = True
        dgvAttendance.Columns.Add(colRoll)

        Dim colName As New DataGridViewTextBoxColumn()
        colName.Name = "name"
        colName.HeaderText = "Student Name"
        colName.Width = 220
        colName.ReadOnly = True
        dgvAttendance.Columns.Add(colName)

        Dim statusCol As New DataGridViewComboBoxColumn()
        statusCol.Name = "status"
        statusCol.HeaderText = "Status"
        statusCol.Items.AddRange("Present", "Absent", "Leave")
        statusCol.Width = 130
        dgvAttendance.Columns.Add(statusCol)

        For Each row As DataRow In dt.Rows
            dgvAttendance.Rows.Add(row("student_id"), row("roll_no"), row("name"), "Present")
        Next

        lblStatus.Text = dt.Rows.Count & " student(s) loaded — mark attendance and click Save Attendance."
    End Sub

    ' ══════════════════════════════════════════
    '  MARK ALL PRESENT / ABSENT
    ' ══════════════════════════════════════════
    Private Sub btnMarkAllPresent_Click(sender As Object, e As EventArgs) Handles btnMarkAllPresent.Click
        For Each row As DataGridViewRow In dgvAttendance.Rows
            row.Cells("status").Value = "Present"
        Next
        lblStatus.Text = "All students marked Present."
    End Sub

    Private Sub btnMarkAllAbsent_Click(sender As Object, e As EventArgs) Handles btnMarkAllAbsent.Click
        For Each row As DataGridViewRow In dgvAttendance.Rows
            row.Cells("status").Value = "Absent"
        Next
        lblStatus.Text = "All students marked Absent."
    End Sub

    ' ══════════════════════════════════════════
    '  SAVE ATTENDANCE
    ' ══════════════════════════════════════════
    Private Sub btnSaveAttendance_Click(sender As Object, e As EventArgs) Handles btnSaveAttendance.Click
        If dgvAttendance.Rows.Count = 0 Then
            MessageBox.Show("Please load students before saving attendance.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cmbSubject.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Subject first.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim dateStr    As String  = dtpDate.Value.ToString("yyyy-MM-dd")
            Dim subjectId  As Integer = GetComboValue(cmbSubject)

            ' Check if attendance already exists for this date + subject
            Dim checkDt = DatabaseHelper.ExecuteQuery(
                "SELECT COUNT(*) AS cnt FROM attendance WHERE subject_id=" & subjectId &
                " AND att_date='" & dateStr & "'")

            If Convert.ToInt32(checkDt.Rows(0)("cnt")) > 0 Then
                Dim confirm = MessageBox.Show(
                    "Attendance for this subject on " & dtpDate.Value.ToString("dd MMM yyyy") &
                    " already exists." & vbNewLine & "Do you want to overwrite it?",
                    "Confirm Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = DialogResult.No Then Return

                DatabaseHelper.ExecuteNonQuery(
                    "DELETE FROM attendance WHERE subject_id=" & subjectId &
                    " AND att_date='" & dateStr & "'")
            End If

            For Each row As DataGridViewRow In dgvAttendance.Rows
                Dim studentId As Object = row.Cells("student_id").Value
                Dim status    As String = If(row.Cells("status").Value IsNot Nothing,
                                             row.Cells("status").Value.ToString(), "Absent")
                DatabaseHelper.ExecuteNonQuery(
                    "INSERT INTO attendance (student_id, subject_id, att_date, status) VALUES (" &
                    studentId & ", " & subjectId & ", '" & dateStr & "', '" & status & "')")
            Next

            MessageBox.Show("Attendance saved successfully for " & dtpDate.Value.ToString("dd MMM yyyy") & "!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblStatus.Text = "Attendance saved for " & dtpDate.Value.ToString("dd MMM yyyy") & "."

        Catch ex As Exception
            MessageBox.Show("Error saving attendance: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════
    '  VIEW ATTENDANCE REPORT
    ' ══════════════════════════════════════════
    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        If cmbReportStudent.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Student to view their report.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim studentId = GetComboValue(cmbReportStudent)
        Dim query = "SELECT a.att_date AS att_date, sub.subject_name AS subject_name, a.status AS status " &
                    "FROM attendance a " &
                    "JOIN subjects sub ON a.subject_id = sub.subject_id " &
                    "WHERE a.student_id=" & studentId &
                    " ORDER BY a.att_date DESC"

        Dim dt = DatabaseHelper.ExecuteQuery(query)

        ' Rename columns for display before binding
        If dt.Columns.Contains("att_date") Then dt.Columns("att_date").ColumnName = "Date"
        If dt.Columns.Contains("subject_name") Then dt.Columns("subject_name").ColumnName = "Subject"
        If dt.Columns.Contains("status") Then dt.Columns("status").ColumnName = "Status"

        dgvReport.DataSource = dt

        ' Colour-code status rows
        For Each row As DataGridViewRow In dgvReport.Rows
            Dim status As String = If(row.Cells("Status").Value IsNot Nothing,
                                      row.Cells("Status").Value.ToString(), "")
            Select Case status
                Case "Present"
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(27, 128, 62)
                Case "Absent"
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43)
                Case "Leave"
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(130, 90, 0)
            End Select
        Next

        ' Summary
        Dim total      As Integer = dt.Rows.Count
        Dim present    As Integer = dt.Select("Status = 'Present'").Length
        Dim absent     As Integer = dt.Select("Status = 'Absent'").Length
        Dim leave      As Integer = dt.Select("Status = 'Leave'").Length
        Dim percentage As Double  = If(total > 0, Math.Round((present / total) * 100, 2), 0)

        lblStatus.Text = "Report loaded — Total: " & total & "  |  Present: " & present &
                         "  |  Absent: " & absent & "  |  Leave: " & leave &
                         "  |  Attendance: " & percentage & "%"
    End Sub

End Class