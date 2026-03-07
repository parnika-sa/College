Public Class frmFees

    Dim selectedFeeId As Integer = 0

    ' ========== FORM LOAD ==========
    Private Sub frmFees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourses()
        LoadViewCourses()
        LoadAllFees()
        ' Fee type dropdown
        cmbFeeType.Items.AddRange({"Tuition Fee", "Exam Fee", "Library Fee",
                                   "Sports Fee", "Lab Fee", "Other"})
        cmbFeeType.SelectedIndex = -1
        ' Due date default = aaj
        dtpDueDate.Value = DateTime.Now
        dtpPaidDate.Value = DateTime.Now
    End Sub

    ' ========== HELPER ==========
    Private Function GetComboValue(cmb As ComboBox) As Integer
        If cmb.SelectedIndex = -1 OrElse cmb.SelectedValue Is Nothing Then Return -1
        Dim val = cmb.SelectedValue
        If TypeOf val Is DataRowView Then
            Return Convert.ToInt32(CType(val, DataRowView).Row(0))
        End If
        Return Convert.ToInt32(val)
    End Function

    ' ========== LOAD COURSES ==========
    Private Sub LoadCourses()
        Dim dt = DatabaseHelper.ExecuteQuery("SELECT course_id, course_name FROM courses")
        cmbCourse.DataSource = dt
        cmbCourse.DisplayMember = "course_name"
        cmbCourse.ValueMember = "course_id"
        cmbCourse.SelectedIndex = -1
    End Sub

    Private Sub LoadViewCourses()
        Dim dt = DatabaseHelper.ExecuteQuery("SELECT course_id, course_name FROM courses")
        cmbViewCourse.DataSource = dt
        cmbViewCourse.DisplayMember = "course_name"
        cmbViewCourse.ValueMember = "course_id"
        cmbViewCourse.SelectedIndex = -1
    End Sub

    ' ========== COURSE CHANGE - STUDENTS LOAD ==========
    Private Sub cmbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCourse.SelectedIndexChanged
        If cmbCourse.SelectedIndex = -1 Then Return
        Dim courseId = GetComboValue(cmbCourse)
        If courseId = -1 Then Return
        LoadStudentsForCourse(cmbStudent, courseId)
    End Sub

    Private Sub cmbViewCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbViewCourse.SelectedIndexChanged
        If cmbViewCourse.SelectedIndex = -1 Then Return
        Dim courseId = GetComboValue(cmbViewCourse)
        If courseId = -1 Then Return
        LoadStudentsForCourse(cmbViewStudent, courseId)
    End Sub

    Private Sub LoadStudentsForCourse(cmb As ComboBox, courseId As Integer)
        Dim dt = DatabaseHelper.ExecuteQuery(
            "SELECT student_id, CONCAT(roll_no, ' - ', first_name, ' ', last_name) AS name " &
            "FROM students WHERE course_id=" & courseId)
        cmb.DataSource = dt
        cmb.DisplayMember = "name"
        cmb.ValueMember = "student_id"
        cmb.SelectedIndex = -1
    End Sub

    ' ========== PAID AMOUNT CHANGE - STATUS AUTO SET ==========
    Private Sub txtPaidAmount_TextChanged(sender As Object, e As EventArgs) Handles txtPaidAmount.TextChanged
        Try
            If txtAmount.Text = "" Or txtPaidAmount.Text = "" Then Return
            Dim total = Convert.ToDecimal(txtAmount.Text)
            Dim paid = Convert.ToDecimal(txtPaidAmount.Text)
            If paid = 0 Then
                cmbStatus.Text = "Pending"
            ElseIf paid >= total Then
                cmbStatus.Text = "Paid"
                paid = total ' paid amount total se zyada nahi ho sakta
            Else
                cmbStatus.Text = "Partial"
            End If
        Catch
        End Try
    End Sub

    ' ========== SAVE FEE ==========
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validation
        If cmbCourse.SelectedIndex = -1 Or cmbStudent.SelectedIndex = -1 Then
            MessageBox.Show("Course aur Student select karo!", "Validation",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cmbFeeType.SelectedIndex = -1 Then
            MessageBox.Show("Fee Type select karo!", "Validation",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtAmount.Text.Trim() = "" Then
            MessageBox.Show("Amount daalo!", "Validation",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim studentId = GetComboValue(cmbStudent)
            Dim paidAmt = If(txtPaidAmount.Text = "", "0", txtPaidAmount.Text)
            Dim paidDate = If(cmbStatus.Text = "Pending", "NULL",
                            "'" & dtpPaidDate.Value.ToString("yyyy-MM-dd") & "'")
            Dim status = If(cmbStatus.Text = "", "Pending", cmbStatus.Text)

            Dim query = "INSERT INTO fees (student_id, fee_type, amount, paid_amount, due_date, paid_date, status, remarks) " &
                       "VALUES (" & studentId & ", '" & cmbFeeType.Text & "', " &
                       txtAmount.Text & ", " & paidAmt & ", '" &
                       dtpDueDate.Value.ToString("yyyy-MM-dd") & "', " &
                       paidDate & ", '" & status & "', '" & txtRemarks.Text.Trim() & "')"

            DatabaseHelper.ExecuteNonQuery(query)
            MessageBox.Show("Fee record save ho gaya!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadAllFees()
            UpdateDashboardStats()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ========== UPDATE FEE ==========
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedFeeId = 0 Then
            MessageBox.Show("Pehle list se record select karo!", "Info",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Try
            Dim paidAmt = If(txtPaidAmount.Text = "", "0", txtPaidAmount.Text)
            Dim paidDate = If(cmbStatus.Text = "Pending", "NULL",
                            "'" & dtpPaidDate.Value.ToString("yyyy-MM-dd") & "'")

            Dim query = "UPDATE fees SET " &
                       "fee_type='" & cmbFeeType.Text & "', " &
                       "amount=" & txtAmount.Text & ", " &
                       "paid_amount=" & paidAmt & ", " &
                       "due_date='" & dtpDueDate.Value.ToString("yyyy-MM-dd") & "', " &
                       "paid_date=" & paidDate & ", " &
                       "status='" & cmbStatus.Text & "', " &
                       "remarks='" & txtRemarks.Text.Trim() & "' " &
                       "WHERE fee_id=" & selectedFeeId

            DatabaseHelper.ExecuteNonQuery(query)
            MessageBox.Show("Fee record update ho gaya!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadAllFees()
            UpdateDashboardStats()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ========== DELETE FEE ==========
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedFeeId = 0 Then
            MessageBox.Show("Pehle list se record select karo!", "Info",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim confirm = MessageBox.Show("Ye fee record delete karna chahte ho?",
                                     "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confirm = DialogResult.No Then Return

        Try
            DatabaseHelper.ExecuteNonQuery("DELETE FROM fees WHERE fee_id=" & selectedFeeId)
            MessageBox.Show("Record delete ho gaya!", "Success",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearForm()
            LoadAllFees()
            UpdateDashboardStats()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ========== LOAD ALL FEES ==========
    Private Sub LoadAllFees()
        Dim query = "SELECT f.fee_id, CONCAT(s.roll_no, ' - ', s.first_name, ' ', s.last_name) AS Student, " &
                    "f.fee_type AS FeeType, f.amount AS Amount, f.paid_amount AS Paid, " &
                    "(f.amount - f.paid_amount) AS Pending, f.due_date AS DueDate, " &
                    "f.status AS Status " &
                    "FROM fees f JOIN students s ON f.student_id = s.student_id " &
                    "ORDER BY f.fee_id DESC"
        Dim dt = DatabaseHelper.ExecuteQuery(query)
        dgvFees.DataSource = dt

        If dgvFees.Columns.Count > 0 Then
            dgvFees.Columns("fee_id").Visible = False
            dgvFees.Columns("Student").Width = 180
            dgvFees.Columns("FeeType").HeaderText = "Fee Type"
            dgvFees.Columns("Amount").HeaderText = "Total (₹)"
            dgvFees.Columns("Paid").HeaderText = "Paid (₹)"
            dgvFees.Columns("Pending").HeaderText = "Pending (₹)"
            dgvFees.Columns("DueDate").HeaderText = "Due Date"
        End If

        ColorStatusRows()
    End Sub

    ' ========== STATUS ROWS COLOR ==========
    Private Sub ColorStatusRows()
        For Each row As DataGridViewRow In dgvFees.Rows
            If row.Cells("Status").Value IsNot Nothing Then
                Select Case row.Cells("Status").Value.ToString()
                    Case "Paid"
                        row.DefaultCellStyle.BackColor = Color.LightGreen
                    Case "Pending"
                        row.DefaultCellStyle.BackColor = Color.LightCoral
                    Case "Partial"
                        row.DefaultCellStyle.BackColor = Color.LightYellow
                End Select
            End If
        Next
    End Sub

    ' ========== VIEW STUDENT FEES ==========
    Private Sub btnViewFees_Click(sender As Object, e As EventArgs) Handles btnViewFees.Click
        If cmbViewStudent.SelectedIndex = -1 Then
            MessageBox.Show("Student select karo!", "Validation",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim studentId = GetComboValue(cmbViewStudent)
        Dim query = "SELECT f.fee_type AS FeeType, f.amount AS Total, " &
                    "f.paid_amount AS Paid, (f.amount - f.paid_amount) AS Pending, " &
                    "f.due_date AS DueDate, f.paid_date AS PaidDate, f.status AS Status " &
                    "FROM fees f WHERE f.student_id=" & studentId &
                    " ORDER BY f.fee_id DESC"
        Dim dt = DatabaseHelper.ExecuteQuery(query)
        dgvFees.DataSource = dt

        ' Summary
        If dt.Rows.Count > 0 Then
            Dim totalAmt As Decimal = 0
            Dim paidAmt As Decimal = 0
            For Each r As DataRow In dt.Rows
                totalAmt += Convert.ToDecimal(r("Total"))
                paidAmt += Convert.ToDecimal(r("Paid"))
            Next
            MessageBox.Show(
                "Total Fee: ₹" & totalAmt & vbNewLine &
                "Paid: ₹" & paidAmt & vbNewLine &
                "Pending: ₹" & (totalAmt - paidAmt),
                "Fee Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Is student ki koi fee record nahi hai!", "Info",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' ========== ROW CLICK - FORM FILL ==========
    Private Sub dgvFees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFees.CellClick
        If e.RowIndex < 0 Then Return
        Dim row = dgvFees.Rows(e.RowIndex)
        If row.Cells("fee_id").Value Is Nothing Then Return

        selectedFeeId = Convert.ToInt32(row.Cells("fee_id").Value)
        cmbFeeType.Text = row.Cells("FeeType").Value.ToString()
        txtAmount.Text = row.Cells("Amount").Value.ToString()
        txtPaidAmount.Text = row.Cells("Paid").Value.ToString()
        cmbStatus.Text = row.Cells("Status").Value.ToString()
        If row.Cells("DueDate").Value IsNot DBNull.Value Then
            dtpDueDate.Value = Convert.ToDateTime(row.Cells("DueDate").Value)
        End If
    End Sub

    ' ========== CLEAR FORM ==========
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        selectedFeeId = 0
        cmbCourse.SelectedIndex = -1
        cmbStudent.SelectedIndex = -1
        cmbFeeType.SelectedIndex = -1
        txtAmount.Text = ""
        txtPaidAmount.Text = ""
        cmbStatus.Text = "Pending"
        dtpDueDate.Value = DateTime.Now
        dtpPaidDate.Value = DateTime.Now
        txtRemarks.Text = ""
    End Sub

    ' ========== DASHBOARD STATS UPDATE ==========
    Private Sub UpdateDashboardStats()
        Try
            ' frmAdminDashboard already open hai to uska label update karo
            For Each frm As Form In Application.OpenForms
                If TypeOf frm Is frmAdminDashboard Then
                    CType(frm, frmAdminDashboard).RefreshFeeStats()
                End If
            Next
        Catch
        End Try
    End Sub

End Class