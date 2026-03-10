Public Class frmStudents

    Dim selectedStudentId As Integer = 0

    Enum FormMode
        Idle
        Adding
        Editing
    End Enum

    Dim currentMode As FormMode = FormMode.Idle

    ' ══════════════════════════════════════════════════════════════
    '  LOAD
    ' ══════════════════════════════════════════════════════════════
    Private Sub frmStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourses()
        LoadStudents()
        SetMode(FormMode.Idle)
        txtAdmissionYear.Text = DateTime.Now.Year.ToString()
    End Sub

    ' ══════════════════════════════════════════════════════════════
    '  MODE MANAGEMENT
    ' ══════════════════════════════════════════════════════════════
    Private Sub SetMode(mode As FormMode)
        currentMode = mode
        Select Case mode
            Case FormMode.Idle
                btnNew.Visible    = True
                btnSave.Visible   = False
                btnUpdate.Visible = False
                btnDelete.Visible = False
                btnClear.Visible  = False
                LockForm(True)
                SetStatus("Select a student from the list, or click 'Add New Student'.")

            Case FormMode.Adding
                btnNew.Visible    = False
                btnSave.Visible   = True
                btnUpdate.Visible = False
                btnDelete.Visible = False
                btnClear.Visible  = True
                LockForm(False)
                txtRollNo.Enabled = True
                SetStatus("Fill in the student details and click SAVE.")

            Case FormMode.Editing
                btnNew.Visible    = False
                btnSave.Visible   = False
                btnUpdate.Visible = True
                btnDelete.Visible = True
                btnClear.Visible  = True
                LockForm(False)
                txtRollNo.Enabled = False
                SetStatus("Editing student record. Click UPDATE to save or DELETE to remove.")
        End Select
    End Sub

    Private Sub LockForm(locked As Boolean)
        txtRollNo.Enabled        = Not locked
        txtFirstName.Enabled     = Not locked
        txtLastName.Enabled      = Not locked
        txtEmail.Enabled         = Not locked
        txtPhone.Enabled         = Not locked
        dtpDOB.Enabled           = Not locked
        txtAddress.Enabled       = Not locked
        txtAdmissionYear.Enabled = Not locked
        cmbGender.Enabled        = Not locked
        cmbCourse.Enabled        = Not locked
        cmbSemester.Enabled      = Not locked
    End Sub

    Private Sub SetStatus(msg As String)
        lblStatus.Text = msg
    End Sub

    ' ══════════════════════════════════════════════════════════════
    '  DATA LOADING
    ' ══════════════════════════════════════════════════════════════
    Private Sub LoadCourses()
        Dim dt = DatabaseHelper.ExecuteQuery("SELECT course_id, course_name FROM courses ORDER BY course_name")
        cmbCourse.DataSource    = dt
        cmbCourse.DisplayMember = "course_name"
        cmbCourse.ValueMember   = "course_id"
        cmbCourse.SelectedIndex = -1
    End Sub

    Private Sub LoadStudents()
        Dim query = "SELECT s.student_id, s.roll_no, s.first_name, s.last_name, " &
                    "s.email, s.phone, s.gender, c.course_name, s.semester, " &
                    "s.admission_year, s.dob " &
                    "FROM students s LEFT JOIN courses c ON s.course_id = c.course_id " &
                    "ORDER BY s.student_id DESC"
        Dim dt = DatabaseHelper.ExecuteQuery(query)
        dgvStudents.DataSource = dt

        If dgvStudents.Columns.Count > 0 Then
            dgvStudents.Columns("student_id").Visible     = False
            dgvStudents.Columns("roll_no").HeaderText     = "Roll No"
            dgvStudents.Columns("first_name").HeaderText  = "First Name"
            dgvStudents.Columns("last_name").HeaderText   = "Last Name"
            dgvStudents.Columns("email").HeaderText       = "Email"
            dgvStudents.Columns("phone").HeaderText       = "Phone"
            dgvStudents.Columns("gender").HeaderText      = "Gender"
            dgvStudents.Columns("course_name").HeaderText = "Course"
            dgvStudents.Columns("semester").HeaderText    = "Sem"
            dgvStudents.Columns("admission_year").HeaderText = "Adm. Year"
            dgvStudents.Columns("dob").HeaderText         = "Date of Birth"
        End If

        lblRecordCount.Text = "Total Records: " & dt.Rows.Count
    End Sub

    ' ══════════════════════════════════════════════════════════════
    '  BUTTONS
    ' ══════════════════════════════════════════════════════════════

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearForm()
        SetMode(FormMode.Adding)
        txtRollNo.Focus()
    End Sub

    ' ── SAVE ─────────────────────────────────────────────────────
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateForm(False) Then Return

        Try
            Dim roll = EscSQL(txtRollNo.Text.Trim())

            ' ── Guard: check if Roll No already exists ──────────────
            Dim userExists    = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM users    WHERE username='" & roll & "'")
            Dim studentExists = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM students WHERE roll_no='"  & roll & "'")

            If userExists > 0 OrElse studentExists > 0 Then
                ShowWarning("Roll Number '" & roll & "' already exists." & vbCrLf &
                            "Please use a different Roll Number, or select the existing student from the list to edit.")
                txtRollNo.Focus()
                Return
            End If

            ' ── Collect values ──────────────────────────────────────
            Dim fname    = EscSQL(txtFirstName.Text.Trim())
            Dim lname    = EscSQL(txtLastName.Text.Trim())
            Dim email    = EscSQL(txtEmail.Text.Trim())
            Dim phone    = EscSQL(txtPhone.Text.Trim())
            Dim gender   = EscSQL(cmbGender.Text)
            Dim addr     = EscSQL(txtAddress.Text.Trim())
            Dim dob      = dtpDOB.Value.ToString("yyyy-MM-dd")
            Dim admYear  = If(txtAdmissionYear.Text.Trim() = "", CStr(DateTime.Now.Year), txtAdmissionYear.Text.Trim())
            Dim sem      = If(cmbSemester.Text = "", "1", cmbSemester.Text)
            Dim courseId = CInt(cmbCourse.SelectedValue)

            ' ── Insert user account ─────────────────────────────────
            Dim defaultPass = GetMD5(txtRollNo.Text.Trim())
            DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO users (username, password, role) VALUES ('" & roll & "', '" & defaultPass & "', 'student')")
            Dim userId = DatabaseHelper.GetLastInsertId()

            ' ── Insert student (rollback user if this fails) ────────
            Try
                DatabaseHelper.ExecuteNonQuery(
                    "INSERT INTO students (roll_no, first_name, last_name, email, phone, gender, " &
                    "course_id, semester, admission_year, dob, address, user_id) VALUES ('" &
                    roll & "', '" & fname & "', '" & lname & "', '" &
                    email & "', '" & phone & "', '" & gender & "', " &
                    courseId & ", " & sem & ", " & admYear & ", '" &
                    dob & "', '" & addr & "', " & userId & ")")
            Catch exInner As Exception
                ' Clean up orphan user record
                If userId > 0 Then DatabaseHelper.ExecuteNonQuery("DELETE FROM users WHERE user_id=" & userId)
                Throw
            End Try

            ShowSuccess("Student record saved successfully." & vbCrLf &
                        "Default login password: " & txtRollNo.Text.Trim())
            ClearForm()
            LoadStudents()
            SetMode(FormMode.Idle)

        Catch ex As Exception
            ShowError("Failed to save student." & vbCrLf & ex.Message)
        End Try
    End Sub

    ' ── UPDATE ───────────────────────────────────────────────────
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedStudentId = 0 Then Return
        If Not ValidateForm(True) Then Return

        If MessageBox.Show("Save changes to this student record?", "Confirm Update",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Return

        Try
            Dim fname    = EscSQL(txtFirstName.Text.Trim())
            Dim lname    = EscSQL(txtLastName.Text.Trim())
            Dim email    = EscSQL(txtEmail.Text.Trim())
            Dim phone    = EscSQL(txtPhone.Text.Trim())
            Dim gender   = EscSQL(cmbGender.Text)
            Dim addr     = EscSQL(txtAddress.Text.Trim())
            Dim dob      = dtpDOB.Value.ToString("yyyy-MM-dd")
            Dim admYear  = If(txtAdmissionYear.Text.Trim() = "", CStr(DateTime.Now.Year), txtAdmissionYear.Text.Trim())
            Dim sem      = If(cmbSemester.Text = "", "1", cmbSemester.Text)
            Dim courseId = CInt(cmbCourse.SelectedValue)

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE students SET " &
                "first_name='" & fname & "', last_name='" & lname & "', " &
                "email='" & email & "', phone='" & phone & "', gender='" & gender & "', " &
                "course_id=" & courseId & ", semester=" & sem & ", " &
                "admission_year=" & admYear & ", dob='" & dob & "', address='" & addr & "' " &
                "WHERE student_id=" & selectedStudentId)

            ShowSuccess("Student record updated successfully.")
            ClearForm()
            LoadStudents()
            SetMode(FormMode.Idle)

        Catch ex As Exception
            ShowError("Failed to update student." & vbCrLf & ex.Message)
        End Try
    End Sub

    ' ── DELETE ───────────────────────────────────────────────────
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedStudentId = 0 Then Return

        If MessageBox.Show(
            "Are you sure you want to delete this student?" & vbCrLf &
            "All attendance, result and fee records will also be removed.",
            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Return

        Try
            DatabaseHelper.ExecuteNonQuery("DELETE FROM attendance WHERE student_id=" & selectedStudentId)
            DatabaseHelper.ExecuteNonQuery("DELETE FROM results   WHERE student_id=" & selectedStudentId)
            DatabaseHelper.ExecuteNonQuery("DELETE FROM fees      WHERE student_id=" & selectedStudentId)

            Dim userDt = DatabaseHelper.ExecuteQuery("SELECT user_id FROM students WHERE student_id=" & selectedStudentId)
            Dim userId As Integer = 0
            If userDt.Rows.Count > 0 AndAlso userDt.Rows(0)("user_id") IsNot DBNull.Value Then
                userId = Convert.ToInt32(userDt.Rows(0)("user_id"))
            End If

            DatabaseHelper.ExecuteNonQuery("DELETE FROM students WHERE student_id=" & selectedStudentId)
            If userId > 0 Then DatabaseHelper.ExecuteNonQuery("DELETE FROM users WHERE user_id=" & userId)

            ShowSuccess("Student record deleted successfully.")
            ClearForm()
            LoadStudents()
            SetMode(FormMode.Idle)

        Catch ex As Exception
            ShowError("Failed to delete student." & vbCrLf & ex.Message)
        End Try
    End Sub

    ' ── CANCEL / CLEAR ───────────────────────────────────────────
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
        SetMode(FormMode.Idle)
    End Sub

    ' ── SEARCH ───────────────────────────────────────────────────
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text.Trim() = "" Then
            LoadStudents()
            Return
        End If

        Dim t = EscSQL(txtSearch.Text.Trim())
        Dim query = "SELECT s.student_id, s.roll_no, s.first_name, s.last_name, " &
                    "s.email, s.phone, s.gender, c.course_name, s.semester, " &
                    "s.admission_year, s.dob " &
                    "FROM students s LEFT JOIN courses c ON s.course_id = c.course_id " &
                    "WHERE s.roll_no    LIKE '%" & t & "%' " &
                    "OR s.first_name   LIKE '%" & t & "%' " &
                    "OR s.last_name    LIKE '%" & t & "%' " &
                    "OR s.email        LIKE '%" & t & "%' " &
                    "OR s.phone        LIKE '%" & t & "%'"

        Dim dt = DatabaseHelper.ExecuteQuery(query)
        dgvStudents.DataSource = dt
        If dgvStudents.Columns.Count > 0 Then dgvStudents.Columns("student_id").Visible = False

        lblRecordCount.Text = "Records Found: " & dt.Rows.Count
        SetStatus("Search results for: '" & txtSearch.Text.Trim() & "'")
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        txtSearch.Text = ""
        LoadStudents()
        SetStatus("Showing all student records.")
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then btnSearch_Click(Nothing, Nothing)
    End Sub

    ' ══════════════════════════════════════════════════════════════
    '  GRID ROW CLICK
    ' ══════════════════════════════════════════════════════════════
    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        If e.RowIndex < 0 Then Return

        Dim row = dgvStudents.Rows(e.RowIndex)
        selectedStudentId = Convert.ToInt32(row.Cells("student_id").Value)

        Dim dt = DatabaseHelper.ExecuteQuery("SELECT * FROM students WHERE student_id=" & selectedStudentId)
        If dt.Rows.Count = 0 Then Return
        Dim r = dt.Rows(0)

        txtRollNo.Text        = SafeStr(r, "roll_no")
        txtFirstName.Text     = SafeStr(r, "first_name")
        txtLastName.Text      = SafeStr(r, "last_name")
        txtEmail.Text         = SafeStr(r, "email")
        txtPhone.Text         = SafeStr(r, "phone")
        txtAddress.Text       = SafeStr(r, "address")
        txtAdmissionYear.Text = SafeStr(r, "admission_year")
        cmbGender.Text        = SafeStr(r, "gender")
        cmbSemester.Text      = SafeStr(r, "semester")

        If r("dob") IsNot DBNull.Value Then
            dtpDOB.Value = Convert.ToDateTime(r("dob"))
        End If
        If r("course_id") IsNot DBNull.Value Then
            cmbCourse.SelectedValue = r("course_id")
        End If

        SetMode(FormMode.Editing)
    End Sub

    ' ══════════════════════════════════════════════════════════════
    '  HELPERS
    ' ══════════════════════════════════════════════════════════════

    Private Function EscSQL(input As String) As String
        If input Is Nothing Then Return ""
        Return input.Replace("'", "''")
    End Function

    Private Function SafeStr(row As System.Data.DataRow, col As String) As String
        If row.Table.Columns.Contains(col) AndAlso row(col) IsNot DBNull.Value Then
            Return row(col).ToString()
        End If
        Return ""
    End Function

    Private Function ValidateForm(isUpdate As Boolean) As Boolean
        If Not isUpdate AndAlso txtRollNo.Text.Trim() = "" Then
            ShowWarning("Roll Number is required.")
            txtRollNo.Focus() : Return False
        End If
        If txtFirstName.Text.Trim() = "" Then
            ShowWarning("First Name is required.")
            txtFirstName.Focus() : Return False
        End If
        If txtLastName.Text.Trim() = "" Then
            ShowWarning("Last Name is required.")
            txtLastName.Focus() : Return False
        End If
        If cmbCourse.SelectedIndex = -1 Then
            ShowWarning("Please select a Course.")
            cmbCourse.Focus() : Return False
        End If
        Return True
    End Function

    Private Sub ClearForm()
        selectedStudentId         = 0
        txtRollNo.Text            = ""
        txtFirstName.Text         = ""
        txtLastName.Text          = ""
        txtEmail.Text             = ""
        txtPhone.Text             = ""
        txtAddress.Text           = ""
        txtAdmissionYear.Text     = DateTime.Now.Year.ToString()
        dtpDOB.Value              = DateTime.Today.AddYears(-18)
        cmbGender.SelectedIndex   = -1
        cmbCourse.SelectedIndex   = -1
        cmbSemester.SelectedIndex = -1
    End Sub

    Private Sub ShowSuccess(msg As String)
        MessageBox.Show(msg, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub ShowError(msg As String)
        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Sub ShowWarning(msg As String)
        MessageBox.Show(msg, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Function GetMD5(input As String) As String
        Using md5 As New System.Security.Cryptography.MD5CryptoServiceProvider()
            Dim bytes = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input))
            Return BitConverter.ToString(bytes).Replace("-", "").ToLower()
        End Using
    End Function

End Class