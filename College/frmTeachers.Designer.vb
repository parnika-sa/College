<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTeachers
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.lblEmpCode = New System.Windows.Forms.Label()
        Me.txtEmpCode = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.cmbDept = New System.Windows.Forms.ComboBox()
        Me.lblJoining = New System.Windows.Forms.Label()
        Me.dtpJoining = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.dgvTeachers = New System.Windows.Forms.DataGridView()
        Me.pnlHeader.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        CType(Me.dgvTeachers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        'pnlHeader
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(31, 73, 125)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Size = New System.Drawing.Size(1100, 50)

        'lblTitle
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblTitle.Size = New System.Drawing.Size(400, 30)
        Me.lblTitle.Text = "👨‍🏫 Teacher Management"

        'pnlForm
        Me.pnlForm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlForm.Location = New System.Drawing.Point(10, 60)
        Me.pnlForm.Size = New System.Drawing.Size(380, 500)
        Me.pnlForm.Controls.Add(Me.lblEmpCode)
        Me.pnlForm.Controls.Add(Me.txtEmpCode)
        Me.pnlForm.Controls.Add(Me.lblFirstName)
        Me.pnlForm.Controls.Add(Me.txtFirstName)
        Me.pnlForm.Controls.Add(Me.lblLastName)
        Me.pnlForm.Controls.Add(Me.txtLastName)
        Me.pnlForm.Controls.Add(Me.lblEmail)
        Me.pnlForm.Controls.Add(Me.txtEmail)
        Me.pnlForm.Controls.Add(Me.lblPhone)
        Me.pnlForm.Controls.Add(Me.txtPhone)
        Me.pnlForm.Controls.Add(Me.lblDept)
        Me.pnlForm.Controls.Add(Me.cmbDept)
        Me.pnlForm.Controls.Add(Me.lblJoining)
        Me.pnlForm.Controls.Add(Me.dtpJoining)
        Me.pnlForm.Controls.Add(Me.btnSave)
        Me.pnlForm.Controls.Add(Me.btnUpdate)
        Me.pnlForm.Controls.Add(Me.btnDelete)
        Me.pnlForm.Controls.Add(Me.btnClear)

        'lblEmpCode
        Me.lblEmpCode.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblEmpCode.Location = New System.Drawing.Point(10, 15)
        Me.lblEmpCode.Size = New System.Drawing.Size(150, 18)
        Me.lblEmpCode.Text = "Employee Code *"

        'txtEmpCode
        Me.txtEmpCode.Font = New System.Drawing.Font("Arial", 10)
        Me.txtEmpCode.Location = New System.Drawing.Point(10, 35)
        Me.txtEmpCode.Name = "txtEmpCode"
        Me.txtEmpCode.Size = New System.Drawing.Size(355, 25)

        'lblFirstName
        Me.lblFirstName.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblFirstName.Location = New System.Drawing.Point(10, 68)
        Me.lblFirstName.Size = New System.Drawing.Size(100, 18)
        Me.lblFirstName.Text = "First Name *"

        'txtFirstName
        Me.txtFirstName.Font = New System.Drawing.Font("Arial", 10)
        Me.txtFirstName.Location = New System.Drawing.Point(10, 88)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(170, 25)

        'lblLastName
        Me.lblLastName.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblLastName.Location = New System.Drawing.Point(195, 68)
        Me.lblLastName.Size = New System.Drawing.Size(100, 18)
        Me.lblLastName.Text = "Last Name *"

        'txtLastName
        Me.txtLastName.Font = New System.Drawing.Font("Arial", 10)
        Me.txtLastName.Location = New System.Drawing.Point(195, 88)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(170, 25)

        'lblEmail
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblEmail.Location = New System.Drawing.Point(10, 121)
        Me.lblEmail.Size = New System.Drawing.Size(100, 18)
        Me.lblEmail.Text = "Email"

        'txtEmail
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 10)
        Me.txtEmail.Location = New System.Drawing.Point(10, 141)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(355, 25)

        'lblPhone
        Me.lblPhone.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblPhone.Location = New System.Drawing.Point(10, 174)
        Me.lblPhone.Size = New System.Drawing.Size(100, 18)
        Me.lblPhone.Text = "Phone"

        'txtPhone
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 10)
        Me.txtPhone.Location = New System.Drawing.Point(10, 194)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(355, 25)

        'lblDept
        Me.lblDept.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblDept.Location = New System.Drawing.Point(10, 227)
        Me.lblDept.Size = New System.Drawing.Size(150, 18)
        Me.lblDept.Text = "Department *"

        'cmbDept
        Me.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDept.Font = New System.Drawing.Font("Arial", 10)
        Me.cmbDept.Location = New System.Drawing.Point(10, 247)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(355, 25)

        'lblJoining
        Me.lblJoining.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblJoining.Location = New System.Drawing.Point(10, 280)
        Me.lblJoining.Size = New System.Drawing.Size(150, 18)
        Me.lblJoining.Text = "Joining Date"

        'dtpJoining
        Me.dtpJoining.Font = New System.Drawing.Font("Arial", 10)
        Me.dtpJoining.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpJoining.Location = New System.Drawing.Point(10, 300)
        Me.dtpJoining.Name = "dtpJoining"
        Me.dtpJoining.Size = New System.Drawing.Size(355, 25)

        'btnSave
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(0, 176, 80)
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(10, 345)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(170, 40)
        Me.btnSave.Text = "💾 SAVE"

        'btnUpdate
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(0, 122, 204)
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(195, 345)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(170, 40)
        Me.btnUpdate.Text = "✏️ UPDATE"

        'btnDelete
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(192, 0, 0)
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(10, 400)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(170, 40)
        Me.btnDelete.Text = "🗑️ DELETE"

        'btnClear
        Me.btnClear.BackColor = System.Drawing.Color.Gray
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(195, 400)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(170, 40)
        Me.btnClear.Text = "🔄 CLEAR"

        'pnlSearch
        Me.pnlSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearch.Location = New System.Drawing.Point(405, 60)
        Me.pnlSearch.Size = New System.Drawing.Size(680, 50)
        Me.pnlSearch.Controls.Add(Me.lblSearch)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.btnShowAll)

        'lblSearch
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblSearch.Location = New System.Drawing.Point(10, 15)
        Me.lblSearch.Size = New System.Drawing.Size(60, 20)
        Me.lblSearch.Text = "Search:"

        'txtSearch
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 10)
        Me.txtSearch.Location = New System.Drawing.Point(70, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(300, 25)

        'btnSearch
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(31, 73, 125)
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(380, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(120, 30)
        Me.btnSearch.Text = "🔍 SEARCH"

        'btnShowAll
        Me.btnShowAll.BackColor = System.Drawing.Color.FromArgb(0, 122, 204)
        Me.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAll.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.btnShowAll.ForeColor = System.Drawing.Color.White
        Me.btnShowAll.Location = New System.Drawing.Point(510, 10)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(120, 30)
        Me.btnShowAll.Text = "📋 SHOW ALL"

        'dgvTeachers
        Me.dgvTeachers.AllowUserToAddRows = False
        Me.dgvTeachers.AllowUserToDeleteRows = False
        Me.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTeachers.BackgroundColor = System.Drawing.Color.White
        Me.dgvTeachers.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(31, 73, 125)
        Me.dgvTeachers.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvTeachers.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.dgvTeachers.ColumnHeadersHeight = 35
        Me.dgvTeachers.Font = New System.Drawing.Font("Arial", 9)
        Me.dgvTeachers.Location = New System.Drawing.Point(405, 120)
        Me.dgvTeachers.Name = "dgvTeachers"
        Me.dgvTeachers.ReadOnly = True
        Me.dgvTeachers.RowHeadersVisible = False
        Me.dgvTeachers.RowTemplate.Height = 28
        Me.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTeachers.Size = New System.Drawing.Size(680, 440)

        'frmTeachers
        Me.ClientSize = New System.Drawing.Size(1100, 580)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.dgvTeachers)
        Me.BackColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmTeachers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College ERP - Teacher Management"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlForm.ResumeLayout(False)
        Me.pnlSearch.ResumeLayout(False)
        CType(Me.dgvTeachers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlForm As Panel
    Friend WithEvents lblEmpCode As Label
    Friend WithEvents txtEmpCode As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblDept As Label
    Friend WithEvents cmbDept As ComboBox
    Friend WithEvents lblJoining As Label
    Friend WithEvents dtpJoining As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnShowAll As Button
    Friend WithEvents dgvTeachers As DataGridView

End Class