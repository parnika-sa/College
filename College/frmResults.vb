Public Class frmResults

    Private Sub frmResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourses()
    End Sub

    Private Sub LoadCourses()
        Dim dt = DatabaseHelper.ExecuteQuery("SELECT course_id, course_name FROM courses")
        cmbCourse.DataSource = dt
        cmbCourse.DisplayMember = "course_name"
        cmbCourse.ValueMember = "course_id"
        cmbCourse.SelectedIndex = -1

        Dim dt2 = DatabaseHelper.ExecuteQuery("SELECT course_id, course_name FROM courses")
        cmbViewCourse.DataSource = dt2
        cmbViewCourse.DisplayMember = "course_name"
        cmbViewCourse.ValueMember = "course_id"
        cmbViewCourse.SelectedIndex = -1
    End Sub

    ' ✅ Helper Function - SelectedValue se safely integer nikalo
    Private Function GetComboValue(cmb As ComboBox) As Integer
        If cmb.SelectedIndex = -1 OrElse cmb.SelectedValue Is Nothing Then Return -1
        Dim val = cmb.SelectedValue
        If TypeOf val Is DataRowView Then
            Dim drv = CType(val, DataRowView)
            Return Convert.ToInt32(drv.Row(0))
        End If
        Return Convert.ToInt32(val)
    End Function

    ' Course change - students load karo
    Private Sub cmbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCourse.SelectedIndexChanged
        If cmbCourse.SelectedIndex = -1 Then Return
        Dim courseId = GetComboValue(cmbCourse)
        If courseId = -1 Then Return

        Dim query = "SELECT student_id, CONCAT(roll_no, ' - ', first_name, ' ', last_name) AS name " &
                    "FROM students WHERE course_id=" & courseId
        Dim dt = DatabaseHelper.ExecuteQuery(query)
        cmbStudent.DataSource = dt
        cmbStudent.DisplayMember = "name"
        cmbStudent.ValueMember = "student_id"
        cmbStudent.SelectedIndex = -1

        ' Subjects bhi load karo
        Dim query2 = "SELECT subject_id, subject_name FROM subjects WHERE course_id=" & courseId
        Dim dt2 = DatabaseHelper.ExecuteQuery(query2)
        cmbSubject.DataSource = dt2
        cmbSubject.DisplayMember = "subject_name"
        cmbSubject.ValueMember = "subject_id"
        cmbSubject.SelectedIndex = -1
    End Sub

    ' View Course change - students load karo
    Private Sub cmbViewCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbViewCourse.SelectedIndexChanged
        If cmbViewCourse.SelectedIndex = -1 Then Return
        Dim courseId = GetComboValue(cmbViewCourse)
        If courseId = -1 Then Return

        Dim query = "SELECT student_id, CONCAT(roll_no, ' - ', first_name, ' ', last_name) AS name " &
                    "FROM students WHERE course_id=" & courseId
        Dim dt = DatabaseHelper.ExecuteQuery(query)
        cmbViewStudent.DataSource = dt
        cmbViewStudent.DisplayMember = "name"
        cmbViewStudent.ValueMember = "student_id"
        cmbViewStudent.SelectedIndex = -1
    End Sub

    ' Marks change hone pe auto calculate
    Private Sub txtInternal_TextChanged(sender As Object, e As EventArgs) Handles txtInternal.TextChanged
        CalculateTotal()
    End Sub

    Private Sub txtExternal_TextChanged(sender As Object, e As EventArgs) Handles txtExternal.TextChanged
        CalculateTotal()
    End Sub

    Private Sub CalculateTotal()
        Try
            Dim internal As Decimal = If(txtInternal.Text = "", 0, Convert.ToDecimal(txtInternal.Text))
            Dim external As Decimal = If(txtExternal.Text = "", 0, Convert.ToDecimal(txtExternal.Text))
            Dim total As Decimal = internal + external
            txtTotal.Text = total.ToString()
            txtGrade.Text = GetGrade(total)
        Catch
            txtTotal.Text = ""
            txtGrade.Text = ""
        End Try
    End Sub

    ' Grade calculate karo
    Private Function GetGrade(total As Decimal) As String
        If total >= 90 Then Return "A+"
        If total >= 80 Then Return "A"
        If total >= 70 Then Return "B+"
        If total >= 60 Then Return "B"
        If total >= 50 Then Return "C"
        If total >= 40 Then Return "D"
        Return "F"
    End Function

    ' Save Result
    Private Sub btnSaveResult_Click(sender As Object, e As EventArgs) Handles btnSaveResult.Click
        If cmbCourse.SelectedIndex = -1 Or cmbStudent.SelectedIndex = -1 Or cmbSubject.SelectedIndex = -1 Then
            MessageBox.Show("Course, Student aur Subject select karo!", "Validation",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtInternal.Text = "" Or txtExternal.Text = "" Then
            MessageBox.Show("Internal aur External marks daalo!", "Validation",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbSemester.SelectedIndex = -1 Then
            MessageBox.Show("Semester select karo!", "Validation",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim studentId = GetComboValue(cmbStudent)
            Dim subjectId = GetComboValue(cmbSubject)
            Dim semester = cmbSemester.Text
            Dim acYear = txtAcYear.Text.Trim()

            Dim checkQuery = "SELECT result_id FROM results WHERE student_id=" & studentId &
                            " AND subject_id=" & subjectId & " AND semester=" & semester &
                            " AND academic_year='" & acYear & "'"
            Dim checkDt = DatabaseHelper.ExecuteQuery(checkQuery)

            If checkDt.Rows.Count > 0 Then
                Dim updateQuery = "UPDATE results SET internal_marks=" & txtInternal.Text &
                                 ", external_marks=" & txtExternal.Text &
                                 ", total_marks=" & txtTotal.Text &
                                 ", grade='" & txtGrade.Text & "'" &
                                 " WHERE student_id=" & studentId &
                                 " AND subject_id=" & subjectId &
                                 " AND semester=" & semester &
                                 " AND academic_year='" & acYear & "'"
                DatabaseHelper.ExecuteNonQuery(updateQuery)
                MessageBox.Show("Result update ho gaya!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim query = "INSERT INTO results (student_id, subject_id, semester, internal_marks, external_marks, total_marks, grade, academic_year) VALUES (" &
                           studentId & ", " & subjectId & ", " & semester & ", " &
                           txtInternal.Text & ", " & txtExternal.Text & ", " &
                           txtTotal.Text & ", '" & txtGrade.Text & "', '" & acYear & "')"
                DatabaseHelper.ExecuteNonQuery(query)
                MessageBox.Show("Result save ho gaya!", "Success",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' View Result
    Private Sub btnViewResult_Click(sender As Object, e As EventArgs) Handles btnViewResult.Click
        If cmbViewStudent.SelectedIndex = -1 Then
            MessageBox.Show("Student select karo!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim studentId = GetComboValue(cmbViewStudent)
        Dim query = "SELECT sub.subject_name AS Subject, r.semester AS Semester, " &
                    "r.internal_marks AS Internal, r.external_marks AS External, " &
                    "r.total_marks AS Total, r.grade AS Grade, r.academic_year AS Year " &
                    "FROM results r " &
                    "JOIN subjects sub ON r.subject_id = sub.subject_id " &
                    "WHERE r.student_id=" & studentId &
                    " ORDER BY r.semester, sub.subject_name"

        Dim dt = DatabaseHelper.ExecuteQuery(query)
        dgvResults.DataSource = dt

        If dt.Rows.Count = 0 Then
            MessageBox.Show("Is student ka koi result nahi mila!", "Info",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim totalMarks As Decimal = 0
            For Each row As DataRow In dt.Rows
                totalMarks += Convert.ToDecimal(row("Total"))
            Next
            Dim avg = Math.Round(totalMarks / dt.Rows.Count, 2)
            MessageBox.Show("Total Subjects: " & dt.Rows.Count & vbNewLine &
                           "Average Marks: " & avg & vbNewLine &
                           "Overall Grade: " & GetGrade(avg),
                           "Result Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        cmbCourse.SelectedIndex = -1
        cmbStudent.SelectedIndex = -1
        cmbSubject.SelectedIndex = -1
        cmbSemester.SelectedIndex = -1
        txtInternal.Text = ""
        txtExternal.Text = ""
        txtTotal.Text = ""
        txtGrade.Text = ""
        txtAcYear.Text = "2025-26"
    End Sub

End Class