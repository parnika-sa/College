<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudents
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.lblRollNo = New System.Windows.Forms.Label()
        Me.txtRollNo = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.dgvStudents = New System.Windows.Forms.DataGridView()
        Me.pnlHeader.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1100, 50)
        Me.pnlHeader.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(400, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "👨‍🎓 Student Management"
        '
        'pnlForm
        '
        Me.pnlForm.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlForm.Controls.Add(Me.lblRollNo)
        Me.pnlForm.Controls.Add(Me.txtRollNo)
        Me.pnlForm.Controls.Add(Me.lblFirstName)
        Me.pnlForm.Controls.Add(Me.txtFirstName)
        Me.pnlForm.Controls.Add(Me.lblLastName)
        Me.pnlForm.Controls.Add(Me.txtLastName)
        Me.pnlForm.Controls.Add(Me.lblEmail)
        Me.pnlForm.Controls.Add(Me.txtEmail)
        Me.pnlForm.Controls.Add(Me.lblPhone)
        Me.pnlForm.Controls.Add(Me.txtPhone)
        Me.pnlForm.Controls.Add(Me.lblGender)
        Me.pnlForm.Controls.Add(Me.cmbGender)
        Me.pnlForm.Controls.Add(Me.lblCourse)
        Me.pnlForm.Controls.Add(Me.cmbCourse)
        Me.pnlForm.Controls.Add(Me.lblSemester)
        Me.pnlForm.Controls.Add(Me.cmbSemester)
        Me.pnlForm.Controls.Add(Me.btnSave)
        Me.pnlForm.Controls.Add(Me.btnUpdate)
        Me.pnlForm.Controls.Add(Me.btnDelete)
        Me.pnlForm.Controls.Add(Me.btnClear)
        Me.pnlForm.Location = New System.Drawing.Point(10, 60)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(380, 500)
        Me.pnlForm.TabIndex = 1
        '
        'lblRollNo
        '
        Me.lblRollNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblRollNo.Location = New System.Drawing.Point(10, 15)
        Me.lblRollNo.Name = "lblRollNo"
        Me.lblRollNo.Size = New System.Drawing.Size(100, 18)
        Me.lblRollNo.TabIndex = 0
        Me.lblRollNo.Text = "Roll No *"
        '
        'txtRollNo
        '
        Me.txtRollNo.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtRollNo.Location = New System.Drawing.Point(10, 35)
        Me.txtRollNo.Name = "txtRollNo"
        Me.txtRollNo.Size = New System.Drawing.Size(355, 23)
        Me.txtRollNo.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblFirstName.Location = New System.Drawing.Point(10, 68)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(100, 18)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name *"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(10, 88)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(170, 23)
        Me.txtFirstName.TabIndex = 3
        '
        'lblLastName
        '
        Me.lblLastName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastName.Location = New System.Drawing.Point(195, 68)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(100, 18)
        Me.lblLastName.TabIndex = 4
        Me.lblLastName.Text = "Last Name *"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtLastName.Location = New System.Drawing.Point(195, 88)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(170, 23)
        Me.txtLastName.TabIndex = 5
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.Location = New System.Drawing.Point(10, 121)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(100, 18)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtEmail.Location = New System.Drawing.Point(10, 141)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(355, 23)
        Me.txtEmail.TabIndex = 7
        '
        'lblPhone
        '
        Me.lblPhone.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblPhone.Location = New System.Drawing.Point(10, 174)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(100, 18)
        Me.lblPhone.TabIndex = 8
        Me.lblPhone.Text = "Phone"
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtPhone.Location = New System.Drawing.Point(10, 194)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(355, 23)
        Me.txtPhone.TabIndex = 9
        '
        'lblGender
        '
        Me.lblGender.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblGender.Location = New System.Drawing.Point(10, 227)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(100, 18)
        Me.lblGender.TabIndex = 10
        Me.lblGender.Text = "Gender"
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cmbGender.Location = New System.Drawing.Point(10, 247)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(170, 24)
        Me.cmbGender.TabIndex = 11
        '
        'lblCourse
        '
        Me.lblCourse.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblCourse.Location = New System.Drawing.Point(195, 227)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(100, 18)
        Me.lblCourse.TabIndex = 12
        Me.lblCourse.Text = "Course *"
        '
        'cmbCourse
        '
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbCourse.Location = New System.Drawing.Point(195, 247)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(170, 24)
        Me.cmbCourse.TabIndex = 13
        '
        'lblSemester
        '
        Me.lblSemester.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSemester.Location = New System.Drawing.Point(10, 280)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(100, 18)
        Me.lblSemester.TabIndex = 14
        Me.lblSemester.Text = "Semester"
        '
        'cmbSemester
        '
        Me.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemester.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cmbSemester.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbSemester.Location = New System.Drawing.Point(10, 300)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(170, 24)
        Me.cmbSemester.TabIndex = 15
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(10, 345)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(170, 40)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "💾 SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(195, 345)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(170, 40)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "✏️ UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(10, 400)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(170, 40)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "🗑️ DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Gray
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(195, 400)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(170, 40)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "🔄 CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'pnlSearch
        '
        Me.pnlSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearch.Controls.Add(Me.lblSearch)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.btnShowAll)
        Me.pnlSearch.Location = New System.Drawing.Point(405, 60)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(680, 50)
        Me.pnlSearch.TabIndex = 2
        '
        'lblSearch
        '
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearch.Location = New System.Drawing.Point(10, 15)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(60, 20)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Search:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSearch.Location = New System.Drawing.Point(70, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(300, 23)
        Me.txtSearch.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(380, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(120, 30)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "🔍 SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnShowAll
        '
        Me.btnShowAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAll.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnShowAll.ForeColor = System.Drawing.Color.White
        Me.btnShowAll.Location = New System.Drawing.Point(510, 10)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(120, 30)
        Me.btnShowAll.TabIndex = 3
        Me.btnShowAll.Text = "📋 SHOW ALL"
        Me.btnShowAll.UseVisualStyleBackColor = False
        '
        'dgvStudents
        '
        Me.dgvStudents.AllowUserToAddRows = False
        Me.dgvStudents.AllowUserToDeleteRows = False
        Me.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStudents.BackgroundColor = System.Drawing.Color.White
        Me.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStudents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStudents.ColumnHeadersHeight = 35
        Me.dgvStudents.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.dgvStudents.Location = New System.Drawing.Point(405, 120)
        Me.dgvStudents.Name = "dgvStudents"
        Me.dgvStudents.ReadOnly = True
        Me.dgvStudents.RowHeadersVisible = False
        Me.dgvStudents.RowTemplate.Height = 28
        Me.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStudents.Size = New System.Drawing.Size(680, 440)
        Me.dgvStudents.TabIndex = 3
        '
        'frmStudents
        '
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 580)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.dgvStudents)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmStudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College ERP - Student Management"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        CType(Me.dgvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlForm As Panel
    Friend WithEvents lblRollNo As Label
    Friend WithEvents txtRollNo As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents lblSemester As Label
    Friend WithEvents cmbSemester As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnShowAll As Button
    Friend WithEvents dgvStudents As DataGridView

End Class