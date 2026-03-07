Public Class frmAttendance

    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourses()
        LoadReportCourses()
    End Sub

    Private Sub LoadCourses()
        Dim dt = DatabaseHelper.ExecuteQuery("SELECT course_id, course_name FROM courses")
        cmbCourse.DataSource = dt
        cmbCourse.DisplayMember = "course_name"
        cmbCourse.ValueMember = "course_id"
        cmbCourse.SelectedIndex = -1

        Dim dt2 = DatabaseHelper.ExecuteQuery("SELECT course_id, course_name FROM courses")
        cmbReportCourse.DataSource = dt2
        cmbReportCourse.DisplayMember = "course_name"
        cmbReportCourse.ValueMember = "course_id"
        cmbReportCourse.SelectedIndex = -1
    End Sub

    Private Sub LoadReportCourses()
        ' Already loaded in LoadCourses
    End Sub

    ' ✅ Helper Function - SelectedValue se safely integer nikalo
    Private Function GetComboValue(cmb As ComboBox) As Integer
        If cmb.SelectedIndex = -1 OrElse cmb.SelectedValue Is Nothing Then Return -1
        Dim val = cmb.SelectedValue
        ' Agar DataRowView aa jaye to first column (index 0) se value lo
        ' ValueMember empty ho sakta hai at this point, isliye column name mat use karo
        If TypeOf val Is DataRowView Then
            Dim drv = CType(val, DataRowView)
            Return Convert.ToInt32(drv.Row(0)) ' First column = ID column
        End If
        Return Convert.ToInt32(val)
    End Function

    ' Course change hone pe subjects load karo
    Private Sub cmbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCourse.SelectedIndexChanged
        If cmbCourse.SelectedIndex = -1 Then Return
        Dim courseId = GetComboValue(cmbCourse)
        If courseId = -1 Then Return

        Dim query = "SELECT subject_id, subject_name FROM subjects WHERE course_id=" & courseId
        Dim dt = DatabaseHelper.ExecuteQuery(query)
        cmbSubject.DataSource = dt
        cmbSubject.DisplayMember = "subject_name"
        cmbSubject.ValueMember = "subject_id"
        cmbSubject.SelectedIndex = -1
    End Sub

    ' Report course change pe students load karo
    Private Sub cmbReportCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbReportCourse.SelectedIndexChanged
        If cmbReportCourse.SelectedIndex = -1 Then Return
        Dim courseId = GetComboValue(cmbReportCourse)
        If courseId = -1 Then Return

        Dim query = "SELECT student_id, CONCAT(roll_no, ' - ', first_name, ' ', last_name) AS name FROM students WHERE course_id=" & courseId
        Dim dt = DatabaseHelper.ExecuteQuery(query)
        cmbReportStudent.DataSource = dt
        cmbReportStudent.DisplayMember = "name"
        cmbReportStudent.ValueMember = "student_id"
        cmbReportStudent.SelectedIndex = -1
    End Sub

    ' Students load karo attendance ke liye
    Private Sub btnLoadStudents_Click(sender As Object, e As EventArgs) Handles btnLoadStudents.Click
        If cmbCourse.SelectedIndex = -1 Then
            MessageBox.Show("Course select karo!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbSubject.SelectedIndex = -1 Then
            MessageBox.Show("Subject select karo!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim courseId = GetComboValue(cmbCourse)
        Dim query = "SELECT student_id, roll_no, CONCAT(first_name, ' ', last_name) AS name " &
                    "FROM students WHERE course_id=" & courseId

        Dim dt = DatabaseHelper.ExecuteQuery(query)

        ' DataGridView setup
        dgvAttendance.Rows.Clear()
        dgvAttendance.Columns.Clear()

        dgvAttendance.Columns.Add("student_id", "ID")
        dgvAttendance.Columns("student_id").Visible = False

        dgvAttendance.Columns.Add("roll_no", "Roll No")
        dgvAttendance.Columns("roll_no").Width = 100

        dgvAttendance.Columns.Add("name", "Student Name")
        dgvAttendance.Columns("name").Width = 200

        ' Status column - ComboBox
        Dim statusCol As New DataGridViewComboBoxColumn()
        statusCol.Name = "status"
        statusCol.HeaderText = "Status"
        statusCol.Items.AddRange("Present", "Absent", "Leave")
        statusCol.Width = 120
        dgvAttendance.Columns.Add(statusCol)

        ' Data add karo
        For Each row As DataRow In dt.Rows
            dgvAttendance.Rows.Add(row("student_id"), row("roll_no"), row("name"), "Present")
        Next

        MessageBox.Show(dt.Rows.Count & " students load ho gaye!", "Success",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' All Present mark karo
    Private Sub btnMarkAllPresent_Click(sender As Object, e As EventArgs) Handles btnMarkAllPresent.Click
        For Each row As DataGridViewRow In dgvAttendance.Rows
            row.Cells("status").Value = "Present"
        Next
    End Sub

    ' All Absent mark karo
    Private Sub btnMarkAllAbsent_Click(sender As Object, e As EventArgs) Handles btnMarkAllAbsent.Click
        For Each row As DataGridViewRow In dgvAttendance.Rows
            row.Cells("status").Value = "Absent"
        Next
    End Sub

    ' Attendance Save karo
    Private Sub btnSaveAttendance_Click(sender As Object, e As EventArgs) Handles btnSaveAttendance.Click
        If dgvAttendance.Rows.Count = 0 Then
            MessageBox.Show("Pehle students load karo!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbSubject.SelectedIndex = -1 Then
            MessageBox.Show("Subject select karo!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim dateStr = dtpDate.Value.ToString("yyyy-MM-dd")
            Dim subjectId = GetComboValue(cmbSubject)

            ' Pehle check karo - is date pe already attendance hai?
            Dim checkQuery = "SELECT COUNT(*) AS cnt FROM attendance WHERE subject_id=" & subjectId &
                            " AND att_date='" & dateStr & "'"
            Dim checkDt = DatabaseHelper.ExecuteQuery(checkQuery)
            If Convert.ToInt32(checkDt.Rows(0)("cnt")) > 0 Then
                Dim confirm = MessageBox.Show("Is date pe already attendance save hai. Overwrite karo?",
                                             "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If confirm = DialogResult.No Then Return

                ' Delete old attendance
                DatabaseHelper.ExecuteNonQuery("DELETE FROM attendance WHERE subject_id=" & subjectId &
                                              " AND att_date='" & dateStr & "'")
            End If

            ' Save karo
            For Each row As DataGridViewRow In dgvAttendance.Rows
                Dim studentId = row.Cells("student_id").Value
                Dim status = If(row.Cells("status").Value IsNot Nothing, row.Cells("status").Value.ToString(), "Absent")

                Dim query = "INSERT INTO attendance (student_id, subject_id, att_date, status) VALUES (" &
                           studentId & ", " & subjectId & ", '" & dateStr & "', '" & status & "')"
                DatabaseHelper.ExecuteNonQuery(query)
            Next

            MessageBox.Show("Attendance successfully save ho gayi!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Attendance Report dekho
    Private Sub btnViewReport_Click(sender As Object, e As EventArgs) Handles btnViewReport.Click
        If cmbReportStudent.SelectedIndex = -1 Then
            MessageBox.Show("Student select karo!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim studentId = GetComboValue(cmbReportStudent)
        Dim query = "SELECT a.att_date AS Date, sub.subject_name AS Subject, a.status AS Status " &
                    "FROM attendance a " &
                    "JOIN subjects sub ON a.subject_id = sub.subject_id " &
                    "WHERE a.student_id=" & studentId &
                    " ORDER BY a.att_date DESC"

        Dim dt = DatabaseHelper.ExecuteQuery(query)
        dgvReport.DataSource = dt

        ' Summary show karo
        Dim total = dt.Rows.Count
        Dim present = dt.Select("Status = 'Present'").Length
        Dim percentage = If(total > 0, Math.Round((present / total) * 100, 2), 0)

        MessageBox.Show("Total Classes: " & total & vbNewLine &
                       "Present: " & present & vbNewLine &
                       "Absent: " & (total - present) & vbNewLine &
                       "Attendance %: " & percentage & "%",
                       "Attendance Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class