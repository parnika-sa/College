Public Class frmResults

    Private Sub frmResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourses()
        lblStatus.Text = "Ready — select Course and Student to enter or view results."
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
        cmbViewCourse.DataSource = dt2
        cmbViewCourse.DisplayMember = "course_name"
        cmbViewCourse.ValueMember = "course_id"
        cmbViewCourse.SelectedIndex = -1
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
    '  ENTRY COURSE → LOAD STUDENTS + SUBJECTS
    ' ══════════════════════════════════════════
    Private Sub cmbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCourse.SelectedIndexChanged
        If cmbCourse.SelectedIndex = -1 Then Return
        Dim courseId = GetComboValue(cmbCourse)
        If courseId = -1 Then Return

        Dim dt = DatabaseHelper.ExecuteQuery(
            "SELECT student_id, CONCAT(roll_no, ' - ', first_name, ' ', last_name) AS name " &
            "FROM students WHERE course_id=" & courseId & " ORDER BY roll_no")
        cmbStudent.DataSource = dt
        cmbStudent.DisplayMember = "name"
        cmbStudent.ValueMember = "student_id"
        cmbStudent.SelectedIndex = -1

        Dim dt2 = DatabaseHelper.ExecuteQuery(
            "SELECT subject_id, subject_name FROM subjects WHERE course_id=" & courseId & " ORDER BY subject_name")
        cmbSubject.DataSource = dt2
        cmbSubject.DisplayMember = "subject_name"
        cmbSubject.ValueMember = "subject_id"
        cmbSubject.SelectedIndex = -1

        lblStatus.Text = "Course selected — choose Student, Subject, Semester and enter marks."
    End Sub

    ' ══════════════════════════════════════════
    '  VIEW COURSE → LOAD STUDENTS
    ' ══════════════════════════════════════════
    Private Sub cmbViewCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbViewCourse.SelectedIndexChanged
        If cmbViewCourse.SelectedIndex = -1 Then Return
        Dim courseId = GetComboValue(cmbViewCourse)
        If courseId = -1 Then Return

        Dim dt = DatabaseHelper.ExecuteQuery(
            "SELECT student_id, CONCAT(roll_no, ' - ', first_name, ' ', last_name) AS name " &
            "FROM students WHERE course_id=" & courseId & " ORDER BY roll_no")
        cmbViewStudent.DataSource = dt
        cmbViewStudent.DisplayMember = "name"
        cmbViewStudent.ValueMember = "student_id"
        cmbViewStudent.SelectedIndex = -1
    End Sub

    ' ══════════════════════════════════════════
    '  AUTO CALCULATE TOTAL + GRADE
    ' ══════════════════════════════════════════
    Private Sub txtInternal_TextChanged(sender As Object, e As EventArgs) Handles txtInternal.TextChanged
        CalculateTotal()
    End Sub

    Private Sub txtExternal_TextChanged(sender As Object, e As EventArgs) Handles txtExternal.TextChanged
        CalculateTotal()
    End Sub

    Private Sub CalculateTotal()
        Try
            Dim internal As Decimal = If(txtInternal.Text.Trim() = "", 0, Convert.ToDecimal(txtInternal.Text))
            Dim external As Decimal = If(txtExternal.Text.Trim() = "", 0, Convert.ToDecimal(txtExternal.Text))
            Dim total    As Decimal = internal + external
            txtTotal.Text = total.ToString()
            txtGrade.Text = GetGrade(total)

            ' Colour the grade
            Select Case txtGrade.Text
                Case "A+", "A"
                    txtGrade.ForeColor = System.Drawing.Color.FromArgb(27, 128, 62)
                Case "B+", "B"
                    txtGrade.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185)
                Case "C", "D"
                    txtGrade.ForeColor = System.Drawing.Color.FromArgb(130, 90, 0)
                Case "F"
                    txtGrade.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43)
            End Select
        Catch
            txtTotal.Text = ""
            txtGrade.Text = ""
        End Try
    End Sub

    Private Function GetGrade(total As Decimal) As String
        If total >= 90 Then Return "A+"
        If total >= 80 Then Return "A"
        If total >= 70 Then Return "B+"
        If total >= 60 Then Return "B"
        If total >= 50 Then Return "C"
        If total >= 40 Then Return "D"
        Return "F"
    End Function

    ' ══════════════════════════════════════════
    '  SAVE RESULT
    ' ══════════════════════════════════════════
    Private Sub btnSaveResult_Click(sender As Object, e As EventArgs) Handles btnSaveResult.Click
        If cmbCourse.SelectedIndex = -1 OrElse
           cmbStudent.SelectedIndex = -1 OrElse
           cmbSubject.SelectedIndex = -1 Then
            MessageBox.Show("Please select Course, Student and Subject.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtInternal.Text.Trim() = "" OrElse txtExternal.Text.Trim() = "" Then
            MessageBox.Show("Please enter Internal and External marks.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cmbSemester.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Semester.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim studentId As Integer = GetComboValue(cmbStudent)
            Dim subjectId As Integer = GetComboValue(cmbSubject)
            Dim semester  As String  = cmbSemester.Text
            Dim acYear    As String  = txtAcYear.Text.Trim()

            ' Check if result already exists (upsert)
            Dim checkDt = DatabaseHelper.ExecuteQuery(
                "SELECT result_id FROM results WHERE student_id=" & studentId &
                " AND subject_id=" & subjectId &
                " AND semester=" & semester &
                " AND academic_year='" & acYear & "'")

            If checkDt.Rows.Count > 0 Then
                DatabaseHelper.ExecuteNonQuery(
                    "UPDATE results SET " &
                    "internal_marks=" & txtInternal.Text &
                    ", external_marks=" & txtExternal.Text &
                    ", total_marks=" & txtTotal.Text &
                    ", grade='" & txtGrade.Text & "'" &
                    " WHERE student_id=" & studentId &
                    " AND subject_id=" & subjectId &
                    " AND semester=" & semester &
                    " AND academic_year='" & acYear & "'")
                MessageBox.Show("Result updated successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                lblStatus.Text = "Result updated for the selected student and subject."
            Else
                DatabaseHelper.ExecuteNonQuery(
                    "INSERT INTO results (student_id, subject_id, semester, internal_marks, external_marks, total_marks, grade, academic_year) VALUES (" &
                    studentId & ", " & subjectId & ", " & semester & ", " &
                    txtInternal.Text & ", " & txtExternal.Text & ", " &
                    txtTotal.Text & ", '" & txtGrade.Text & "', '" & acYear & "')")
                MessageBox.Show("Result saved successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                lblStatus.Text = "Result saved — Grade: " & txtGrade.Text & "  |  Total: " & txtTotal.Text
            End If

            ClearForm()

        Catch ex As Exception
            MessageBox.Show("Error saving result: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════
    '  VIEW RESULTS
    ' ══════════════════════════════════════════
    Private Sub btnViewResult_Click(sender As Object, e As EventArgs) Handles btnViewResult.Click
        If cmbViewStudent.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Student to view results.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim studentId = GetComboValue(cmbViewStudent)

        ' MySQL-safe query — no square bracket aliases
        Dim query = "SELECT sub.subject_name AS subject_name, r.semester AS semester, " &
                    "r.internal_marks AS internal_marks, r.external_marks AS external_marks, " &
                    "r.total_marks AS total_marks, r.grade AS grade, r.academic_year AS academic_year " &
                    "FROM results r " &
                    "JOIN subjects sub ON r.subject_id = sub.subject_id " &
                    "WHERE r.student_id=" & studentId &
                    " ORDER BY r.semester, sub.subject_name"

        Dim dt = DatabaseHelper.ExecuteQuery(query)

        ' Rename columns for clean display headers
        If dt.Columns.Contains("subject_name")    Then dt.Columns("subject_name").ColumnName    = "Subject"
        If dt.Columns.Contains("semester")        Then dt.Columns("semester").ColumnName        = "Semester"
        If dt.Columns.Contains("internal_marks")  Then dt.Columns("internal_marks").ColumnName  = "Internal"
        If dt.Columns.Contains("external_marks")  Then dt.Columns("external_marks").ColumnName  = "External"
        If dt.Columns.Contains("total_marks")     Then dt.Columns("total_marks").ColumnName     = "Total"
        If dt.Columns.Contains("grade")           Then dt.Columns("grade").ColumnName           = "Grade"
        If dt.Columns.Contains("academic_year")   Then dt.Columns("academic_year").ColumnName   = "Ac. Year"

        dgvResults.DataSource = dt

        ' Colour-code grade cells
        For Each row As DataGridViewRow In dgvResults.Rows
            Dim grade As String = If(row.Cells("Grade").Value IsNot Nothing,
                                     row.Cells("Grade").Value.ToString(), "")
            Select Case grade
                Case "A+", "A"
                    row.Cells("Grade").Style.ForeColor = System.Drawing.Color.FromArgb(27, 128, 62)
                    row.Cells("Grade").Style.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
                Case "B+", "B"
                    row.Cells("Grade").Style.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185)
                    row.Cells("Grade").Style.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
                Case "C", "D"
                    row.Cells("Grade").Style.ForeColor = System.Drawing.Color.FromArgb(130, 90, 0)
                Case "F"
                    row.Cells("Grade").Style.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43)
                    row.Cells("Grade").Style.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
            End Select
        Next

        If dt.Rows.Count = 0 Then
            MessageBox.Show("No results found for this student.", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblStatus.Text = "No results found for the selected student."
        Else
            Dim totalMarks As Decimal = 0
            For Each row As DataRow In dt.Rows
                totalMarks += Convert.ToDecimal(row("Total"))
            Next
            Dim avg As Double = Math.Round(totalMarks / dt.Rows.Count, 2)
            lblStatus.Text = "Results loaded — Subjects: " & dt.Rows.Count &
                             "  |  Average: " & avg &
                             "  |  Overall Grade: " & GetGrade(avg)
        End If
    End Sub

    ' ══════════════════════════════════════════
    '  CLEAR / CANCEL
    ' ══════════════════════════════════════════
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        cmbCourse.SelectedIndex   = -1
        cmbStudent.SelectedIndex  = -1
        cmbSubject.SelectedIndex  = -1
        cmbSemester.SelectedIndex = -1
        txtInternal.Text = ""
        txtExternal.Text = ""
        txtTotal.Text    = ""
        txtGrade.Text    = ""
        txtAcYear.Text   = "2025-26"
        lblStatus.Text   = "Form cleared — ready to enter a new result."
    End Sub

    ' ══════════════════════════════════════════
    '  TEXTBOX FOCUS HIGHLIGHT
    ' ══════════════════════════════════════════
    Private Sub TextBox_Enter(sender As Object, e As EventArgs) _
        Handles txtInternal.Enter, txtExternal.Enter, txtAcYear.Enter
        CType(sender, TextBox).BackColor = System.Drawing.Color.FromArgb(235, 245, 255)
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) _
        Handles txtInternal.Leave, txtExternal.Leave, txtAcYear.Leave
        CType(sender, TextBox).BackColor = System.Drawing.Color.White
    End Sub

End Class