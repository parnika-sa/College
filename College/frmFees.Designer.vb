<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFees
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.grpAdd = New System.Windows.Forms.GroupBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.cmbStudent = New System.Windows.Forms.ComboBox()
        Me.lblFeeType = New System.Windows.Forms.Label()
        Me.cmbFeeType = New System.Windows.Forms.ComboBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblPaidAmount = New System.Windows.Forms.Label()
        Me.txtPaidAmount = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.lblPaidDate = New System.Windows.Forms.Label()
        Me.dtpPaidDate = New System.Windows.Forms.DateTimePicker()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpView = New System.Windows.Forms.GroupBox()
        Me.lblViewCourse = New System.Windows.Forms.Label()
        Me.cmbViewCourse = New System.Windows.Forms.ComboBox()
        Me.lblViewStudent = New System.Windows.Forms.Label()
        Me.cmbViewStudent = New System.Windows.Forms.ComboBox()
        Me.btnViewFees = New System.Windows.Forms.Button()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.dgvFees = New System.Windows.Forms.DataGridView()

        Me.pnlTop.SuspendLayout()
        Me.grpAdd.SuspendLayout()
        Me.grpView.SuspendLayout()
        CType(Me.dgvFees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' pnlTop
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(31, 73, 125)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Height = 55
        Me.pnlTop.Controls.Add(Me.lblTitle)

        ' lblTitle
        Me.lblTitle.Text = "FEE MANAGEMENT"
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16, System.Drawing.FontStyle.Bold)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(20, 12)

        ' grpAdd
        Me.grpAdd.Text = "Add / Update Fee Record"
        Me.grpAdd.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.grpAdd.Location = New System.Drawing.Point(10, 65)
        Me.grpAdd.Size = New System.Drawing.Size(460, 370)
        Me.grpAdd.Controls.Add(Me.lblCourse)
        Me.grpAdd.Controls.Add(Me.cmbCourse)
        Me.grpAdd.Controls.Add(Me.lblStudent)
        Me.grpAdd.Controls.Add(Me.cmbStudent)
        Me.grpAdd.Controls.Add(Me.lblFeeType)
        Me.grpAdd.Controls.Add(Me.cmbFeeType)
        Me.grpAdd.Controls.Add(Me.lblAmount)
        Me.grpAdd.Controls.Add(Me.txtAmount)
        Me.grpAdd.Controls.Add(Me.lblPaidAmount)
        Me.grpAdd.Controls.Add(Me.txtPaidAmount)
        Me.grpAdd.Controls.Add(Me.lblStatus)
        Me.grpAdd.Controls.Add(Me.cmbStatus)
        Me.grpAdd.Controls.Add(Me.lblDueDate)
        Me.grpAdd.Controls.Add(Me.dtpDueDate)
        Me.grpAdd.Controls.Add(Me.lblPaidDate)
        Me.grpAdd.Controls.Add(Me.dtpPaidDate)
        Me.grpAdd.Controls.Add(Me.lblRemarks)
        Me.grpAdd.Controls.Add(Me.txtRemarks)
        Me.grpAdd.Controls.Add(Me.btnSave)
        Me.grpAdd.Controls.Add(Me.btnUpdate)
        Me.grpAdd.Controls.Add(Me.btnDelete)
        Me.grpAdd.Controls.Add(Me.btnClear)

        ' lblCourse
        Me.lblCourse.Text = "Course:"
        Me.lblCourse.Location = New System.Drawing.Point(15, 30)
        Me.lblCourse.Size = New System.Drawing.Size(65, 20)
        Me.lblCourse.Font = New System.Drawing.Font("Segoe UI", 9)

        ' cmbCourse
        Me.cmbCourse.Location = New System.Drawing.Point(90, 27)
        Me.cmbCourse.Size = New System.Drawing.Size(200, 25)
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.cmbCourse.Name = "cmbCourse"

        ' lblStudent
        Me.lblStudent.Text = "Student:"
        Me.lblStudent.Location = New System.Drawing.Point(15, 65)
        Me.lblStudent.Size = New System.Drawing.Size(65, 20)
        Me.lblStudent.Font = New System.Drawing.Font("Segoe UI", 9)

        ' cmbStudent
        Me.cmbStudent.Location = New System.Drawing.Point(90, 62)
        Me.cmbStudent.Size = New System.Drawing.Size(340, 25)
        Me.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudent.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.cmbStudent.Name = "cmbStudent"

        ' lblFeeType
        Me.lblFeeType.Text = "Fee Type:"
        Me.lblFeeType.Location = New System.Drawing.Point(15, 100)
        Me.lblFeeType.Size = New System.Drawing.Size(65, 20)
        Me.lblFeeType.Font = New System.Drawing.Font("Segoe UI", 9)

        ' cmbFeeType
        Me.cmbFeeType.Location = New System.Drawing.Point(90, 97)
        Me.cmbFeeType.Size = New System.Drawing.Size(180, 25)
        Me.cmbFeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFeeType.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.cmbFeeType.Name = "cmbFeeType"
        Me.cmbFeeType.Items.Add("Tuition Fee")
        Me.cmbFeeType.Items.Add("Exam Fee")
        Me.cmbFeeType.Items.Add("Library Fee")
        Me.cmbFeeType.Items.Add("Other")

        ' lblAmount
        Me.lblAmount.Text = "Total (Rs.):"
        Me.lblAmount.Location = New System.Drawing.Point(15, 135)
        Me.lblAmount.Size = New System.Drawing.Size(70, 20)
        Me.lblAmount.Font = New System.Drawing.Font("Segoe UI", 9)

        ' txtAmount
        Me.txtAmount.Location = New System.Drawing.Point(90, 132)
        Me.txtAmount.Size = New System.Drawing.Size(110, 25)
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.txtAmount.Name = "txtAmount"

        ' lblPaidAmount
        Me.lblPaidAmount.Text = "Paid (Rs.):"
        Me.lblPaidAmount.Location = New System.Drawing.Point(220, 135)
        Me.lblPaidAmount.Size = New System.Drawing.Size(65, 20)
        Me.lblPaidAmount.Font = New System.Drawing.Font("Segoe UI", 9)

        ' txtPaidAmount
        Me.txtPaidAmount.Location = New System.Drawing.Point(290, 132)
        Me.txtPaidAmount.Size = New System.Drawing.Size(110, 25)
        Me.txtPaidAmount.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.txtPaidAmount.Name = "txtPaidAmount"

        ' lblStatus
        Me.lblStatus.Text = "Status:"
        Me.lblStatus.Location = New System.Drawing.Point(15, 170)
        Me.lblStatus.Size = New System.Drawing.Size(65, 20)
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9)

        ' cmbStatus
        Me.cmbStatus.Location = New System.Drawing.Point(90, 167)
        Me.cmbStatus.Size = New System.Drawing.Size(130, 25)
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Items.Add("Pending")
        Me.cmbStatus.Items.Add("Paid")
        Me.cmbStatus.Items.Add("Partial")

        ' lblDueDate
        Me.lblDueDate.Text = "Due Date:"
        Me.lblDueDate.Location = New System.Drawing.Point(15, 205)
        Me.lblDueDate.Size = New System.Drawing.Size(70, 20)
        Me.lblDueDate.Font = New System.Drawing.Font("Segoe UI", 9)

        ' dtpDueDate
        Me.dtpDueDate.Location = New System.Drawing.Point(90, 202)
        Me.dtpDueDate.Size = New System.Drawing.Size(150, 25)
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDueDate.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.dtpDueDate.Name = "dtpDueDate"

        ' lblPaidDate
        Me.lblPaidDate.Text = "Paid Date:"
        Me.lblPaidDate.Location = New System.Drawing.Point(255, 205)
        Me.lblPaidDate.Size = New System.Drawing.Size(70, 20)
        Me.lblPaidDate.Font = New System.Drawing.Font("Segoe UI", 9)

        ' dtpPaidDate
        Me.dtpPaidDate.Location = New System.Drawing.Point(330, 202)
        Me.dtpPaidDate.Size = New System.Drawing.Size(115, 25)
        Me.dtpPaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpPaidDate.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.dtpPaidDate.Name = "dtpPaidDate"

        ' lblRemarks
        Me.lblRemarks.Text = "Remarks:"
        Me.lblRemarks.Location = New System.Drawing.Point(15, 240)
        Me.lblRemarks.Size = New System.Drawing.Size(65, 20)
        Me.lblRemarks.Font = New System.Drawing.Font("Segoe UI", 9)

        ' txtRemarks
        Me.txtRemarks.Location = New System.Drawing.Point(90, 237)
        Me.txtRemarks.Size = New System.Drawing.Size(355, 25)
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.txtRemarks.Name = "txtRemarks"

        ' btnSave
        Me.btnSave.Text = "Save"
        Me.btnSave.Location = New System.Drawing.Point(15, 280)
        Me.btnSave.Size = New System.Drawing.Size(95, 35)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnSave.Name = "btnSave"

        ' btnUpdate
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.Location = New System.Drawing.Point(120, 280)
        Me.btnUpdate.Size = New System.Drawing.Size(95, 35)
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.Name = "btnUpdate"

        ' btnDelete
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.Location = New System.Drawing.Point(225, 280)
        Me.btnDelete.Size = New System.Drawing.Size(95, 35)
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(192, 57, 43)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnDelete.Name = "btnDelete"

        ' btnClear
        Me.btnClear.Text = "Clear"
        Me.btnClear.Location = New System.Drawing.Point(330, 280)
        Me.btnClear.Size = New System.Drawing.Size(95, 35)
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(127, 140, 141)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnClear.Name = "btnClear"

        ' grpView
        Me.grpView.Text = "View Student Fees"
        Me.grpView.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.grpView.Location = New System.Drawing.Point(480, 65)
        Me.grpView.Size = New System.Drawing.Size(460, 100)
        Me.grpView.Controls.Add(Me.lblViewCourse)
        Me.grpView.Controls.Add(Me.cmbViewCourse)
        Me.grpView.Controls.Add(Me.lblViewStudent)
        Me.grpView.Controls.Add(Me.cmbViewStudent)
        Me.grpView.Controls.Add(Me.btnViewFees)
        Me.grpView.Controls.Add(Me.btnShowAll)

        ' lblViewCourse
        Me.lblViewCourse.Text = "Course:"
        Me.lblViewCourse.Location = New System.Drawing.Point(15, 30)
        Me.lblViewCourse.Size = New System.Drawing.Size(55, 20)
        Me.lblViewCourse.Font = New System.Drawing.Font("Segoe UI", 9)

        ' cmbViewCourse
        Me.cmbViewCourse.Location = New System.Drawing.Point(75, 27)
        Me.cmbViewCourse.Size = New System.Drawing.Size(150, 25)
        Me.cmbViewCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbViewCourse.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.cmbViewCourse.Name = "cmbViewCourse"

        ' lblViewStudent
        Me.lblViewStudent.Text = "Student:"
        Me.lblViewStudent.Location = New System.Drawing.Point(15, 62)
        Me.lblViewStudent.Size = New System.Drawing.Size(55, 20)
        Me.lblViewStudent.Font = New System.Drawing.Font("Segoe UI", 9)

        ' cmbViewStudent
        Me.cmbViewStudent.Location = New System.Drawing.Point(75, 59)
        Me.cmbViewStudent.Size = New System.Drawing.Size(200, 25)
        Me.cmbViewStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbViewStudent.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.cmbViewStudent.Name = "cmbViewStudent"

        ' btnViewFees
        Me.btnViewFees.Text = "View"
        Me.btnViewFees.Location = New System.Drawing.Point(285, 57)
        Me.btnViewFees.Size = New System.Drawing.Size(80, 28)
        Me.btnViewFees.BackColor = System.Drawing.Color.FromArgb(31, 73, 125)
        Me.btnViewFees.ForeColor = System.Drawing.Color.White
        Me.btnViewFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewFees.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnViewFees.Name = "btnViewFees"

        ' btnShowAll
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.Location = New System.Drawing.Point(375, 57)
        Me.btnShowAll.Size = New System.Drawing.Size(70, 28)
        Me.btnShowAll.BackColor = System.Drawing.Color.FromArgb(52, 73, 94)
        Me.btnShowAll.ForeColor = System.Drawing.Color.White
        Me.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAll.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnShowAll.Name = "btnShowAll"

        ' dgvFees
        Me.dgvFees.Location = New System.Drawing.Point(10, 450)
        Me.dgvFees.Size = New System.Drawing.Size(960, 260)
        Me.dgvFees.AllowUserToAddRows = False
        Me.dgvFees.ReadOnly = True
        Me.dgvFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFees.BackgroundColor = System.Drawing.Color.White
        Me.dgvFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvFees.RowHeadersVisible = False
        Me.dgvFees.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.dgvFees.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(31, 73, 125)
        Me.dgvFees.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvFees.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.dgvFees.EnableHeadersVisualStyles = False
        Me.dgvFees.Name = "dgvFees"

        ' frmFees
        Me.ClientSize = New System.Drawing.Size(984, 730)
        Me.Text = "College ERP - Fee Management"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.grpAdd)
        Me.Controls.Add(Me.grpView)
        Me.Controls.Add(Me.dgvFees)

        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.grpAdd.ResumeLayout(False)
        Me.grpAdd.PerformLayout()
        Me.grpView.ResumeLayout(False)
        Me.grpView.PerformLayout()
        CType(Me.dgvFees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpAdd As System.Windows.Forms.GroupBox
    Friend WithEvents lblCourse As System.Windows.Forms.Label
    Friend WithEvents cmbCourse As System.Windows.Forms.ComboBox
    Friend WithEvents lblStudent As System.Windows.Forms.Label
    Friend WithEvents cmbStudent As System.Windows.Forms.ComboBox
    Friend WithEvents lblFeeType As System.Windows.Forms.Label
    Friend WithEvents cmbFeeType As System.Windows.Forms.ComboBox
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblPaidAmount As System.Windows.Forms.Label
    Friend WithEvents txtPaidAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblDueDate As System.Windows.Forms.Label
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPaidDate As System.Windows.Forms.Label
    Friend WithEvents dtpPaidDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents grpView As System.Windows.Forms.GroupBox
    Friend WithEvents lblViewCourse As System.Windows.Forms.Label
    Friend WithEvents cmbViewCourse As System.Windows.Forms.ComboBox
    Friend WithEvents lblViewStudent As System.Windows.Forms.Label
    Friend WithEvents cmbViewStudent As System.Windows.Forms.ComboBox
    Friend WithEvents btnViewFees As System.Windows.Forms.Button
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents dgvFees As System.Windows.Forms.DataGridView

End Class