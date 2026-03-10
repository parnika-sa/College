Public Class frmTeachers

    Dim selectedTeacherId As Integer = 0

    Private Sub frmTeachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDepartments()
        LoadTeachers()
        SetMode("view")
    End Sub

    ' ══════════════════════════════════════════
    '  MODE SWITCHER  (view / add / edit)
    ' ══════════════════════════════════════════
    Private Sub SetMode(mode As String)
        Select Case mode
            Case "view"
                btnNew.Visible    = True
                btnSave.Visible   = False
                btnUpdate.Visible = False
                btnDelete.Visible = False
                btnClear.Visible  = False
                lblStatus.Text    = "Ready — select a record to edit, or click Add New Teacher."

            Case "add"
                btnNew.Visible    = False
                btnSave.Visible   = True
                btnUpdate.Visible = False
                btnDelete.Visible = False
                btnClear.Visible  = True
                lblStatus.Text    = "Fill in the details and click Save Teacher."
                ClearForm()
                txtEmpCode.Enabled = True
                txtEmpCode.Focus()

            Case "edit"
                btnNew.Visible    = False
                btnSave.Visible   = False
                btnUpdate.Visible = True
                btnDelete.Visible = True
                btnClear.Visible  = True
                lblStatus.Text    = "Edit the details and click Update, or click Delete to remove."
                txtEmpCode.Enabled = False
        End Select
    End Sub

    ' ══════════════════════════════════════════
    '  DATA LOADING
    ' ══════════════════════════════════════════
    Private Sub LoadDepartments()
        Dim dt = DatabaseHelper.ExecuteQuery("SELECT dept_id, dept_name FROM departments ORDER BY dept_name")
        cmbDept.DataSource    = dt
        cmbDept.DisplayMember = "dept_name"
        cmbDept.ValueMember   = "dept_id"
        cmbDept.SelectedIndex = -1
    End Sub

    Private Sub LoadTeachers()
        Dim query = "SELECT t.teacher_id, t.emp_code, t.first_name, t.last_name, " &
                    "t.email, t.phone, d.dept_name, t.joining_date " &
                    "FROM teachers t LEFT JOIN departments d ON t.dept_id = d.dept_id " &
                    "ORDER BY t.teacher_id DESC"
        Dim dt = DatabaseHelper.ExecuteQuery(query)
        dgvTeachers.DataSource = dt
        ApplyGridHeaders()
        lblRecordCount.Text = "Total Records: " & dgvTeachers.Rows.Count
    End Sub

    Private Sub ApplyGridHeaders()
        If dgvTeachers.Columns.Count = 0 Then Return
        dgvTeachers.Columns("teacher_id").Visible  = False
        dgvTeachers.Columns("emp_code").HeaderText    = "Emp Code"
        dgvTeachers.Columns("first_name").HeaderText  = "First Name"
        dgvTeachers.Columns("last_name").HeaderText   = "Last Name"
        dgvTeachers.Columns("email").HeaderText       = "Email"
        dgvTeachers.Columns("phone").HeaderText       = "Phone"
        dgvTeachers.Columns("dept_name").HeaderText   = "Department"
        dgvTeachers.Columns("joining_date").HeaderText = "Joining Date"
    End Sub

    ' ══════════════════════════════════════════
    '  BUTTON EVENTS
    ' ══════════════════════════════════════════
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        SetMode("add")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateForm() Then Return

        Try
            ' Create user account with default password = emp code
            Dim defaultPass As String = GetMD5(txtEmpCode.Text.Trim())
            Dim userQuery As String = "INSERT INTO users (username, password, role) VALUES ('" &
                                      txtEmpCode.Text.Trim() & "', '" & defaultPass & "', 'teacher')"
            DatabaseHelper.ExecuteNonQuery(userQuery)
            Dim userId As Integer = DatabaseHelper.GetLastInsertId()

            Dim query As String = "INSERT INTO teachers (emp_code, first_name, last_name, email, phone, dept_id, joining_date, user_id) VALUES ('" &
                                  txtEmpCode.Text.Trim() & "', '" &
                                  txtFirstName.Text.Trim() & "', '" &
                                  txtLastName.Text.Trim() & "', '" &
                                  txtEmail.Text.Trim() & "', '" &
                                  txtPhone.Text.Trim() & "', " &
                                  cmbDept.SelectedValue & ", '" &
                                  dtpJoining.Value.ToString("yyyy-MM-dd") & "', " & userId & ")"

            DatabaseHelper.ExecuteNonQuery(query)
            MessageBox.Show("Teacher saved successfully!" & vbNewLine &
                            "Default login password: " & txtEmpCode.Text.Trim(),
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadTeachers()
            SetMode("view")

        Catch ex As Exception
            MessageBox.Show("Error saving teacher: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedTeacherId = 0 Then
            MessageBox.Show("Please select a teacher from the list first.", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If Not ValidateForm() Then Return

        Try
            Dim query As String = "UPDATE teachers SET " &
                                  "first_name='" & txtFirstName.Text.Trim() & "', " &
                                  "last_name='"  & txtLastName.Text.Trim()  & "', " &
                                  "email='"      & txtEmail.Text.Trim()     & "', " &
                                  "phone='"      & txtPhone.Text.Trim()     & "', " &
                                  "dept_id="     & cmbDept.SelectedValue   & ", " &
                                  "joining_date='" & dtpJoining.Value.ToString("yyyy-MM-dd") & "'" &
                                  " WHERE teacher_id=" & selectedTeacherId

            DatabaseHelper.ExecuteNonQuery(query)
            MessageBox.Show("Teacher updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadTeachers()
            SetMode("view")

        Catch ex As Exception
            MessageBox.Show("Error updating teacher: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedTeacherId = 0 Then
            MessageBox.Show("Please select a teacher from the list first.", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim confirm = MessageBox.Show("Are you sure you want to delete this teacher?" & vbNewLine &
                                      "This action cannot be undone.",
                                      "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.No Then Return

        Try
            Dim userDt = DatabaseHelper.ExecuteQuery(
                "SELECT user_id FROM teachers WHERE teacher_id=" & selectedTeacherId)
            Dim userId As Integer = 0
            If userDt.Rows.Count > 0 AndAlso userDt.Rows(0)("user_id") IsNot DBNull.Value Then
                userId = Convert.ToInt32(userDt.Rows(0)("user_id"))
            End If

            DatabaseHelper.ExecuteNonQuery("DELETE FROM teachers WHERE teacher_id=" & selectedTeacherId)
            If userId > 0 Then
                DatabaseHelper.ExecuteNonQuery("DELETE FROM users WHERE user_id=" & userId)
            End If

            MessageBox.Show("Teacher deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadTeachers()
            SetMode("view")

        Catch ex As Exception
            MessageBox.Show("Error deleting teacher: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        SetMode("view")
    End Sub

    ' ══════════════════════════════════════════
    '  SEARCH
    ' ══════════════════════════════════════════
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text.Trim() = "" Then
            LoadTeachers()
            Return
        End If

        Dim query = "SELECT t.teacher_id, t.emp_code, t.first_name, t.last_name, " &
                    "t.email, t.phone, d.dept_name, t.joining_date " &
                    "FROM teachers t LEFT JOIN departments d ON t.dept_id = d.dept_id " &
                    "WHERE t.emp_code LIKE '%" & txtSearch.Text & "%' " &
                    "OR t.first_name LIKE '%" & txtSearch.Text & "%' " &
                    "OR t.last_name  LIKE '%" & txtSearch.Text & "%' " &
                    "OR d.dept_name  LIKE '%" & txtSearch.Text & "%'"
        Dim dt = DatabaseHelper.ExecuteQuery(query)
        dgvTeachers.DataSource = dt
        ApplyGridHeaders()
        lblRecordCount.Text = "Results: " & dgvTeachers.Rows.Count
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        txtSearch.Text = ""
        LoadTeachers()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then btnSearch_Click(sender, e)
    End Sub

    ' ══════════════════════════════════════════
    '  GRID ROW CLICK — POPULATE FORM
    ' ══════════════════════════════════════════
    Private Sub dgvTeachers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTeachers.CellClick
        If e.RowIndex < 0 Then Return
        Dim row = dgvTeachers.Rows(e.RowIndex)

        selectedTeacherId  = Convert.ToInt32(row.Cells("teacher_id").Value)
        txtEmpCode.Text    = row.Cells("emp_code").Value.ToString()
        txtFirstName.Text  = row.Cells("first_name").Value.ToString()
        txtLastName.Text   = row.Cells("last_name").Value.ToString()
        txtEmail.Text      = If(row.Cells("email").Value IsNot DBNull.Value, row.Cells("email").Value.ToString(), "")
        txtPhone.Text      = If(row.Cells("phone").Value IsNot DBNull.Value, row.Cells("phone").Value.ToString(), "")

        ' Set department dropdown
        If row.Cells("dept_name").Value IsNot DBNull.Value Then
            Dim deptDt = DatabaseHelper.ExecuteQuery(
                "SELECT dept_id FROM departments WHERE dept_name='" &
                row.Cells("dept_name").Value.ToString() & "'")
            If deptDt.Rows.Count > 0 Then
                cmbDept.SelectedValue = Convert.ToInt32(deptDt.Rows(0)("dept_id"))
            End If
        End If

        If row.Cells("joining_date").Value IsNot DBNull.Value Then
            dtpJoining.Value = Convert.ToDateTime(row.Cells("joining_date").Value)
        End If

        SetMode("edit")
    End Sub

    ' ══════════════════════════════════════════
    '  HELPERS
    ' ══════════════════════════════════════════
    Private Function ValidateForm() As Boolean
        If txtEmpCode.Text.Trim() = "" OrElse
           txtFirstName.Text.Trim() = "" OrElse
           txtLastName.Text.Trim() = "" Then
            MessageBox.Show("Employee Code, First Name and Last Name are required.",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If cmbDept.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Department.",
                            "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub ClearForm()
        selectedTeacherId = 0
        txtEmpCode.Text   = ""
        txtFirstName.Text = ""
        txtLastName.Text  = ""
        txtEmail.Text     = ""
        txtPhone.Text     = ""
        cmbDept.SelectedIndex = -1
        dtpJoining.Value  = DateTime.Now
    End Sub

    Private Function GetMD5(input As String) As String
        Using md5 As New System.Security.Cryptography.MD5CryptoServiceProvider()
            Dim bytes = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input))
            Return BitConverter.ToString(bytes).Replace("-", "").ToLower()
        End Using
    End Function

    ' ══════════════════════════════════════════
    '  TEXTBOX FOCUS HIGHLIGHT
    ' ══════════════════════════════════════════
    Private Sub TextBox_Enter(sender As Object, e As EventArgs) _
        Handles txtEmpCode.Enter, txtFirstName.Enter, txtLastName.Enter,
                txtEmail.Enter, txtPhone.Enter
        CType(sender, TextBox).BackColor = System.Drawing.Color.FromArgb(235, 245, 255)
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) _
        Handles txtEmpCode.Leave, txtFirstName.Leave, txtLastName.Leave,
                txtEmail.Leave, txtPhone.Leave
        CType(sender, TextBox).BackColor = System.Drawing.Color.White
    End Sub

End Class