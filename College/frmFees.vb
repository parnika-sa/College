Public Class frmFees

    Dim selectedFeeId As Integer = 0

    ' ══════════════════════════════════════════
    '  FORM LOAD
    ' ══════════════════════════════════════════
    Private Sub frmFees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourses()
        LoadViewCourses()

        cmbFeeType.Items.Clear()
        cmbFeeType.Items.AddRange(New Object() {
            "Tuition Fee", "Exam Fee", "Library Fee",
            "Sports Fee", "Lab Fee", "Other"})
        cmbFeeType.SelectedIndex = -1
        cmbStatus.SelectedIndex  = -1

        dtpDueDate.Value  = DateTime.Now
        dtpPaidDate.Value = DateTime.Now

        LoadAllFees()
        lblStatusBar.Text = "Ready — click a row in the grid to edit, or fill the form to add a new fee record."
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
    '  LOAD COURSES
    ' ══════════════════════════════════════════
    Private Sub LoadCourses()
        Dim dt = DatabaseHelper.ExecuteQuery(
            "SELECT course_id, course_name FROM courses ORDER BY course_name")
        cmbCourse.DataSource    = dt
        cmbCourse.DisplayMember = "course_name"
        cmbCourse.ValueMember   = "course_id"
        cmbCourse.SelectedIndex = -1
    End Sub

    Private Sub LoadViewCourses()
        Dim dt = DatabaseHelper.ExecuteQuery(
            "SELECT course_id, course_name FROM courses ORDER BY course_name")
        cmbViewCourse.DataSource    = dt
        cmbViewCourse.DisplayMember = "course_name"
        cmbViewCourse.ValueMember   = "course_id"
        cmbViewCourse.SelectedIndex = -1
    End Sub

    ' ══════════════════════════════════════════
    '  COURSE → LOAD STUDENTS
    ' ══════════════════════════════════════════
    Private Sub cmbCourse_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cmbCourse.SelectedIndexChanged
        If cmbCourse.SelectedIndex = -1 Then Return
        Dim courseId = GetComboValue(cmbCourse)
        If courseId = -1 Then Return
        LoadStudentsForCourse(cmbStudent, courseId)
    End Sub

    Private Sub cmbViewCourse_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cmbViewCourse.SelectedIndexChanged
        If cmbViewCourse.SelectedIndex = -1 Then Return
        Dim courseId = GetComboValue(cmbViewCourse)
        If courseId = -1 Then Return
        LoadStudentsForCourse(cmbViewStudent, courseId)
    End Sub

    Private Sub LoadStudentsForCourse(cmb As ComboBox, courseId As Integer)
        Dim dt = DatabaseHelper.ExecuteQuery(
            "SELECT student_id, CONCAT(roll_no, ' - ', first_name, ' ', last_name) AS name " &
            "FROM students WHERE course_id=" & courseId & " ORDER BY roll_no")
        cmb.DataSource    = dt
        cmb.DisplayMember = "name"
        cmb.ValueMember   = "student_id"
        cmb.SelectedIndex = -1
    End Sub

    ' ══════════════════════════════════════════
    '  PAID AMOUNT → AUTO STATUS
    ' ══════════════════════════════════════════
    Private Sub txtPaidAmount_TextChanged(sender As Object, e As EventArgs) _
        Handles txtPaidAmount.TextChanged
        Try
            If txtAmount.Text.Trim() = "" OrElse txtPaidAmount.Text.Trim() = "" Then Return
            Dim total As Decimal = Convert.ToDecimal(txtAmount.Text)
            Dim paid  As Decimal = Convert.ToDecimal(txtPaidAmount.Text)
            If paid <= 0 Then
                cmbStatus.Text = "Pending"
            ElseIf paid >= total Then
                cmbStatus.Text = "Paid"
            Else
                cmbStatus.Text = "Partial"
            End If
        Catch
        End Try
    End Sub

    ' ══════════════════════════════════════════
    '  ★ DUPLICATE CHECK HELPER
    '  Returns True if same student + fee_type
    '  already exists (optionally excluding a fee_id)
    ' ══════════════════════════════════════════
    Private Function DuplicateFeeExists(studentId As Integer,
                                        feeType   As String,
                                        excludeId As Integer) As Boolean
        Dim escapedType = feeType.Replace("'", "''")
        Dim query As String

        If excludeId > 0 Then
            ' UPDATE mode — ignore the record being edited
            query = "SELECT COUNT(*) FROM fees " &
                    "WHERE student_id=" & studentId &
                    " AND fee_type='" & escapedType & "'" &
                    " AND fee_id <> " & excludeId
        Else
            ' INSERT mode — check all records
            query = "SELECT COUNT(*) FROM fees " &
                    "WHERE student_id=" & studentId &
                    " AND fee_type='" & escapedType & "'"
        End If

        Return DatabaseHelper.ExecuteScalar(query) > 0
    End Function

    ' ══════════════════════════════════════════
    '  SAVE FEE RECORD
    ' ══════════════════════════════════════════
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbCourse.SelectedIndex = -1 OrElse cmbStudent.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Course and Student.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cmbFeeType.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Fee Type.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtAmount.Text.Trim() = "" Then
            MessageBox.Show("Please enter the Total Amount.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' ★ DUPLICATE BLOCK
        Dim studentId As Integer = GetComboValue(cmbStudent)
        If DuplicateFeeExists(studentId, cmbFeeType.Text, 0) Then
            MessageBox.Show(
                "This student already has a '" & cmbFeeType.Text & "' record." & vbCrLf &
                vbCrLf &
                "To update the existing record, select it from the grid first, " &
                "then click UPDATE.",
                "Duplicate Fee Record",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim paidAmt  As String = If(txtPaidAmount.Text.Trim() = "", "0", txtPaidAmount.Text)
            Dim status   As String = If(cmbStatus.Text = "", "Pending", cmbStatus.Text)
            Dim paidDate As String = If(status = "Pending", "NULL",
                                        "'" & dtpPaidDate.Value.ToString("yyyy-MM-dd") & "'")

            DatabaseHelper.ExecuteNonQuery(
                "INSERT INTO fees (student_id, fee_type, amount, paid_amount, " &
                "due_date, paid_date, status, remarks) VALUES (" &
                studentId & ", '" & cmbFeeType.Text & "', " &
                txtAmount.Text & ", " & paidAmt & ", '" &
                dtpDueDate.Value.ToString("yyyy-MM-dd") & "', " &
                paidDate & ", '" & status & "', '" &
                txtRemarks.Text.Trim().Replace("'", "''") & "')")

            MessageBox.Show("Fee record saved successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblStatusBar.Text = "Fee record saved — Status: " & status
            ClearForm()
            LoadAllFees()
            UpdateDashboardStats()

        Catch ex As Exception
            MessageBox.Show("Error saving record: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════
    '  UPDATE FEE RECORD
    ' ══════════════════════════════════════════
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedFeeId = 0 Then
            MessageBox.Show("Please select a record from the grid first.", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' ★ DUPLICATE BLOCK for Update
        ' (check if another record has same student + fee_type,
        '  but ignore the record currently being edited)
        If cmbFeeType.SelectedIndex >= 0 Then
            ' Get student_id from the DB record being edited
            Dim feeDt = DatabaseHelper.ExecuteQuery(
                "SELECT student_id FROM fees WHERE fee_id=" & selectedFeeId)
            If feeDt.Rows.Count > 0 Then
                Dim sid = Convert.ToInt32(feeDt.Rows(0)("student_id"))
                If DuplicateFeeExists(sid, cmbFeeType.Text, selectedFeeId) Then
                    MessageBox.Show(
                        "Another '" & cmbFeeType.Text & "' record already exists for this student." & vbCrLf &
                        "Please choose a different Fee Type.",
                        "Duplicate Fee Record",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End If
        End If

        Try
            Dim paidAmt  As String = If(txtPaidAmount.Text.Trim() = "", "0", txtPaidAmount.Text)
            Dim status   As String = If(cmbStatus.Text = "", "Pending", cmbStatus.Text)
            Dim paidDate As String = If(status = "Pending", "NULL",
                                        "'" & dtpPaidDate.Value.ToString("yyyy-MM-dd") & "'")

            DatabaseHelper.ExecuteNonQuery(
                "UPDATE fees SET " &
                "fee_type='"  & cmbFeeType.Text.Replace("'", "''") & "', " &
                "amount="     & txtAmount.Text & ", " &
                "paid_amount=" & paidAmt & ", " &
                "due_date='"  & dtpDueDate.Value.ToString("yyyy-MM-dd") & "', " &
                "paid_date="  & paidDate & ", " &
                "status='"    & status & "', " &
                "remarks='"   & txtRemarks.Text.Trim().Replace("'", "''") & "' " &
                "WHERE fee_id=" & selectedFeeId)

            MessageBox.Show("Fee record updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblStatusBar.Text = "Record updated — Fee ID: " & selectedFeeId & "  |  Status: " & status
            ClearForm()
            LoadAllFees()
            UpdateDashboardStats()

        Catch ex As Exception
            MessageBox.Show("Error updating record: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════
    '  DELETE FEE RECORD
    ' ══════════════════════════════════════════
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedFeeId = 0 Then
            MessageBox.Show("Please select a record from the grid first.", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this fee record?" & vbNewLine &
                           "This action cannot be undone.",
                           "Confirm Delete",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Return

        Try
            DatabaseHelper.ExecuteNonQuery("DELETE FROM fees WHERE fee_id=" & selectedFeeId)
            MessageBox.Show("Fee record deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblStatusBar.Text = "Record deleted."
            ClearForm()
            LoadAllFees()
            UpdateDashboardStats()
        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ══════════════════════════════════════════
    '  LOAD ALL FEES INTO GRID
    ' ══════════════════════════════════════════
    Private Sub LoadAllFees()
        Dim query = "SELECT f.fee_id, " &
                    "CONCAT(s.roll_no, ' - ', s.first_name, ' ', s.last_name) AS Student, " &
                    "f.fee_type AS FeeType, f.amount AS Amount, f.paid_amount AS Paid, " &
                    "(f.amount - f.paid_amount) AS Pending, " &
                    "f.due_date AS DueDate, f.status AS Status " &
                    "FROM fees f JOIN students s ON f.student_id = s.student_id " &
                    "ORDER BY f.fee_id DESC"
        Dim dt = DatabaseHelper.ExecuteQuery(query)
        dgvFees.DataSource = dt

        If dgvFees.Columns.Count > 0 Then
            dgvFees.Columns("fee_id").Visible      = False
            dgvFees.Columns("FeeType").HeaderText  = "Fee Type"
            dgvFees.Columns("Amount").HeaderText   = "Total (₹)"
            dgvFees.Columns("Paid").HeaderText     = "Paid (₹)"
            dgvFees.Columns("Pending").HeaderText  = "Pending (₹)"
            dgvFees.Columns("DueDate").HeaderText  = "Due Date"
        End If

        ColorStatusRows()
        lblStatusBar.Text = "Showing all fee records — Total: " & dgvFees.Rows.Count
    End Sub

    ' ══════════════════════════════════════════
    '  COLOUR CODE STATUS ROWS
    ' ══════════════════════════════════════════
    Private Sub ColorStatusRows()
        For Each row As DataGridViewRow In dgvFees.Rows
            If row.Cells("Status").Value Is Nothing Then Continue For
            Select Case row.Cells("Status").Value.ToString()
                Case "Paid"
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(220, 245, 220)
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(27, 100, 50)
                Case "Pending"
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 235, 235)
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(160, 30, 30)
                Case "Partial"
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 250, 215)
                    row.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(130, 90, 0)
            End Select
        Next
    End Sub

    ' ══════════════════════════════════════════
    '  VIEW STUDENT FEES
    ' ══════════════════════════════════════════
    Private Sub btnViewFees_Click(sender As Object, e As EventArgs) Handles btnViewFees.Click
        If cmbViewStudent.SelectedIndex = -1 Then
            MessageBox.Show("Please select a Student to view their fees.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim studentId = GetComboValue(cmbViewStudent)
        Dim dt = DatabaseHelper.ExecuteQuery(
            "SELECT f.fee_id, f.fee_type AS FeeType, f.amount AS Amount, " &
            "f.paid_amount AS Paid, (f.amount - f.paid_amount) AS Pending, " &
            "f.due_date AS DueDate, f.paid_date AS PaidDate, f.status AS Status " &
            "FROM fees f WHERE f.student_id=" & studentId & " ORDER BY f.fee_id DESC")

        dgvFees.DataSource = dt
        If dgvFees.Columns.Contains("fee_id") Then dgvFees.Columns("fee_id").Visible = False
        ColorStatusRows()

        If dt.Rows.Count > 0 Then
            Dim totalAmt As Decimal = 0
            Dim paidAmt  As Decimal = 0
            For Each r As DataRow In dt.Rows
                totalAmt += Convert.ToDecimal(r("Amount"))
                paidAmt  += Convert.ToDecimal(r("Paid"))
            Next
            Dim pending As Decimal = totalAmt - paidAmt
            lblStatusBar.Text = "Student fees — Total: ₹" & totalAmt &
                                "  |  Paid: ₹" & paidAmt &
                                "  |  Pending: ₹" & pending
        Else
            MessageBox.Show("No fee records found for this student.", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblStatusBar.Text = "No fee records found for the selected student."
        End If
    End Sub

    ' ══════════════════════════════════════════
    '  SHOW ALL
    ' ══════════════════════════════════════════
    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        cmbViewCourse.SelectedIndex  = -1
        cmbViewStudent.SelectedIndex = -1
        LoadAllFees()
    End Sub

    ' ══════════════════════════════════════════
    '  GRID ROW CLICK
    ' ══════════════════════════════════════════
    Private Sub dgvFees_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvFees.CellClick

        If e.RowIndex < 0 Then Return
        Dim row = dgvFees.Rows(e.RowIndex)
        If Not dgvFees.Columns.Contains("fee_id") Then Return
        If row.Cells("fee_id").Value Is Nothing Then Return

        selectedFeeId      = Convert.ToInt32(row.Cells("fee_id").Value)
        cmbFeeType.Text    = row.Cells("FeeType").Value.ToString()
        txtAmount.Text     = row.Cells("Amount").Value.ToString()
        txtPaidAmount.Text = row.Cells("Paid").Value.ToString()
        cmbStatus.Text     = row.Cells("Status").Value.ToString()

        If row.Cells("DueDate").Value IsNot DBNull.Value AndAlso
           row.Cells("DueDate").Value IsNot Nothing Then
            dtpDueDate.Value = Convert.ToDateTime(row.Cells("DueDate").Value)
        End If

        lblStatusBar.Text = "Record selected — Fee ID: " & selectedFeeId &
                            "  |  Edit fields and click UPDATE, or DELETE to remove."
    End Sub

    ' ══════════════════════════════════════════
    '  CLEAR FORM
    ' ══════════════════════════════════════════
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        selectedFeeId             = 0
        cmbCourse.SelectedIndex   = -1
        cmbStudent.SelectedIndex  = -1
        cmbFeeType.SelectedIndex  = -1
        txtAmount.Text            = ""
        txtPaidAmount.Text        = ""
        cmbStatus.Text            = "Pending"
        dtpDueDate.Value          = DateTime.Now
        dtpPaidDate.Value         = DateTime.Now
        txtRemarks.Text           = ""
        lblStatusBar.Text         = "Form cleared — ready to add a new fee record."
    End Sub

    ' ══════════════════════════════════════════
    '  UPDATE DASHBOARD STATS
    ' ══════════════════════════════════════════
    Private Sub UpdateDashboardStats()
        Try
            For Each frm As Form In Application.OpenForms
                If TypeOf frm Is frmAdminDashboard Then
                    CType(frm, frmAdminDashboard).RefreshFeeStats()
                End If
            Next
        Catch
        End Try
    End Sub

    ' ══════════════════════════════════════════
    '  TEXTBOX FOCUS HIGHLIGHT
    ' ══════════════════════════════════════════
    Private Sub TextBox_Enter(sender As Object, e As EventArgs) _
        Handles txtAmount.Enter, txtPaidAmount.Enter, txtRemarks.Enter
        CType(sender, TextBox).BackColor =
            System.Drawing.Color.FromArgb(235, 245, 255)
    End Sub

    Private Sub TextBox_Leave(sender As Object, e As EventArgs) _
        Handles txtAmount.Leave, txtPaidAmount.Leave, txtRemarks.Leave
        CType(sender, TextBox).BackColor = System.Drawing.Color.White
    End Sub

End Class