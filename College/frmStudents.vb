Public Class frmStudents

    Dim selectedStudentId As Integer = 0

    Private Sub frmStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourses()
        LoadStudents()
    End Sub

    Private Sub LoadCourses()
        Dim dt = DatabaseHelper.ExecuteQuery("SELECT course_id, course_name FROM courses")
        cmbCourse.DataSource = dt
        cmbCourse.DisplayMember = "course_name"
        cmbCourse.ValueMember = "course_id"
        cmbCourse.SelectedIndex = -1
    End Sub

    Private Sub LoadStudents()
        Dim query = "SELECT s.student_id, s.roll_no, s.first_name, s.last_name, " &
                    "s.email, s.phone, s.gender, c.course_name, s.semester " &
                    "FROM students s LEFT JOIN courses c ON s.course_id = c.course_id " &
                    "ORDER BY s.student_id DESC"
        Dim dt = DatabaseHelper.ExecuteQuery(query)
        dgvStudents.DataSource = dt

        If dgvStudents.Columns.Count > 0 Then
            dgvStudents.Columns("student_id").Visible = False
            dgvStudents.Columns("roll_no").HeaderText = "Roll No"
            dgvStudents.Columns("first_name").HeaderText = "First Name"
            dgvStudents.Columns("last_name").HeaderText = "Last Name"
            dgvStudents.Columns("email").HeaderText = "Email"
            dgvStudents.Columns("phone").HeaderText = "Phone"
            dgvStudents.Columns("gender").HeaderText = "Gender"
            dgvStudents.Columns("course_name").HeaderText = "Course"
            dgvStudents.Columns("semester").HeaderText = "Semester"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtRollNo.Text.Trim() = "" Or txtFirstName.Text.Trim() = "" Or txtLastName.Text.Trim() = "" Then
            MessageBox.Show("Roll No, First Name aur Last Name zaroori hain!", "Validation",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbCourse.SelectedIndex = -1 Then
            MessageBox.Show("Course select karo!", "Validation",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim defaultPass = GetMD5(txtRollNo.Text.Trim())
            Dim userQuery = "INSERT INTO users (username, password, role) VALUES ('" &
                           txtRollNo.Text.Trim() & "', '" & defaultPass & "', 'student')"
            DatabaseHelper.ExecuteNonQuery(userQuery)
            Dim userId = DatabaseHelper.GetLastInsertId()

            Dim query = "INSERT INTO students (roll_no, first_name, last_name, email, phone, gender, course_id, semester, admission_year, user_id) VALUES ('" &
                       txtRollNo.Text.Trim() & "', '" &
                       txtFirstName.Text.Trim() & "', '" &
                       txtLastName.Text.Trim() & "', '" &
                       txtEmail.Text.Trim() & "', '" &
                       txtPhone.Text.Trim() & "', '" &
                       cmbGender.Text & "', " &
                       cmbCourse.SelectedValue & ", " &
                       If(cmbSemester.Text = "", "1", cmbSemester.Text) & ", " &
                       DateTime.Now.Year & ", " & userId & ")"

            DatabaseHelper.ExecuteNonQuery(query)
            MessageBox.Show("Student successfully save ho gaya!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadStudents()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedStudentId = 0 Then
            MessageBox.Show("Pehle list se student select karo!", "Info",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Dim query = "UPDATE students SET " &
                       "first_name='" & txtFirstName.Text.Trim() & "', " &
                       "last_name='" & txtLastName.Text.Trim() & "', " &
                       "email='" & txtEmail.Text.Trim() & "', " &
                       "phone='" & txtPhone.Text.Trim() & "', " &
                       "gender='" & cmbGender.Text & "', " &
                       "course_id=" & cmbCourse.SelectedValue & ", " &
                       "semester=" & If(cmbSemester.Text = "", "1", cmbSemester.Text) &
                       " WHERE student_id=" & selectedStudentId

            DatabaseHelper.ExecuteNonQuery(query)
            MessageBox.Show("Student update ho gaya!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadStudents()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    ' ✅ Delete Button - Fixed (pehle child records delete karo)
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedStudentId = 0 Then
            MessageBox.Show("Pehle list se student select karo!", "Info",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim confirm = MessageBox.Show("Kya aap sure hain? Student ka attendance, results aur fees bhi delete ho jayega!",
                                     "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.No Then Return

        Try
            ' ✅ Step 1: Pehle child tables se delete karo (FK order mein)
            DatabaseHelper.ExecuteNonQuery("DELETE FROM attendance WHERE student_id=" & selectedStudentId)
            DatabaseHelper.ExecuteNonQuery("DELETE FROM results WHERE student_id=" & selectedStudentId)
            DatabaseHelper.ExecuteNonQuery("DELETE FROM fees WHERE student_id=" & selectedStudentId)

            ' ✅ Step 2: Student ka user_id nikalo
            Dim userDt = DatabaseHelper.ExecuteQuery("SELECT user_id FROM students WHERE student_id=" & selectedStudentId)
            Dim userId As Integer = 0
            If userDt.Rows.Count > 0 AndAlso userDt.Rows(0)("user_id") IsNot DBNull.Value Then
                userId = Convert.ToInt32(userDt.Rows(0)("user_id"))
            End If

            ' ✅ Step 3: Student delete karo
            DatabaseHelper.ExecuteNonQuery("DELETE FROM students WHERE student_id=" & selectedStudentId)

            ' ✅ Step 4: User bhi delete karo (agar tha)
            If userId > 0 Then
                DatabaseHelper.ExecuteNonQuery("DELETE FROM users WHERE user_id=" & userId)
            End If

            MessageBox.Show("Student successfully delete ho gaya!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadStudents()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text.Trim() = "" Then
            LoadStudents()
            Return
        End If

        Dim query = "SELECT s.student_id, s.roll_no, s.first_name, s.last_name, " &
                    "s.email, s.phone, s.gender, c.course_name, s.semester " &
                    "FROM students s LEFT JOIN courses c ON s.course_id = c.course_id " &
                    "WHERE s.roll_no LIKE '%" & txtSearch.Text & "%' " &
                    "OR s.first_name LIKE '%" & txtSearch.Text & "%' " &
                    "OR s.last_name LIKE '%" & txtSearch.Text & "%'"
        Dim dt = DatabaseHelper.ExecuteQuery(query)
        dgvStudents.DataSource = dt

        If dgvStudents.Columns.Count > 0 Then
            dgvStudents.Columns("student_id").Visible = False
        End If
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        txtSearch.Text = ""
        LoadStudents()
    End Sub

    Private Sub dgvStudents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStudents.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvStudents.Rows(e.RowIndex)
            selectedStudentId = Convert.ToInt32(row.Cells("student_id").Value)
            txtRollNo.Text = row.Cells("roll_no").Value.ToString()
            txtRollNo.Enabled = False
            txtFirstName.Text = row.Cells("first_name").Value.ToString()
            txtLastName.Text = row.Cells("last_name").Value.ToString()
            txtEmail.Text = If(row.Cells("email").Value IsNot DBNull.Value, row.Cells("email").Value.ToString(), "")
            txtPhone.Text = If(row.Cells("phone").Value IsNot DBNull.Value, row.Cells("phone").Value.ToString(), "")
            cmbGender.Text = If(row.Cells("gender").Value IsNot DBNull.Value, row.Cells("gender").Value.ToString(), "")
        End If
    End Sub

    Private Sub ClearForm()
        selectedStudentId = 0
        txtRollNo.Text = ""
        txtRollNo.Enabled = True
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        cmbGender.SelectedIndex = -1
        cmbCourse.SelectedIndex = -1
        cmbSemester.SelectedIndex = -1
    End Sub

    Private Function GetMD5(input As String) As String
        Using md5 As New System.Security.Cryptography.MD5CryptoServiceProvider()
            Dim bytes = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input))
            Return BitConverter.ToString(bytes).Replace("-", "").ToLower()
        End Using
    End Function

End Class