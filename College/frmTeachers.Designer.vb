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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()

        ' ── Controls ──────────────────────────────────────────────
        Me.pnlHeader   = New System.Windows.Forms.Panel()
        Me.lblTitle    = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()

        Me.pnlSidebar  = New System.Windows.Forms.Panel()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.lblDivider  = New System.Windows.Forms.Label()

        Me.lblEmpCode   = New System.Windows.Forms.Label()
        Me.txtEmpCode   = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName  = New System.Windows.Forms.Label()
        Me.txtLastName  = New System.Windows.Forms.TextBox()
        Me.lblEmail     = New System.Windows.Forms.Label()
        Me.txtEmail     = New System.Windows.Forms.TextBox()
        Me.lblPhone     = New System.Windows.Forms.Label()
        Me.txtPhone     = New System.Windows.Forms.TextBox()
        Me.lblDept      = New System.Windows.Forms.Label()
        Me.cmbDept      = New System.Windows.Forms.ComboBox()
        Me.lblJoining   = New System.Windows.Forms.Label()
        Me.dtpJoining   = New System.Windows.Forms.DateTimePicker()

        Me.pnlButtons  = New System.Windows.Forms.Panel()
        Me.btnNew      = New System.Windows.Forms.Button()
        Me.btnSave     = New System.Windows.Forms.Button()
        Me.btnUpdate   = New System.Windows.Forms.Button()
        Me.btnDelete   = New System.Windows.Forms.Button()
        Me.btnClear    = New System.Windows.Forms.Button()

        Me.pnlMain     = New System.Windows.Forms.Panel()
        Me.pnlSearch   = New System.Windows.Forms.Panel()
        Me.lblSearchIcon  = New System.Windows.Forms.Label()
        Me.txtSearch      = New System.Windows.Forms.TextBox()
        Me.btnSearch      = New System.Windows.Forms.Button()
        Me.btnShowAll     = New System.Windows.Forms.Button()
        Me.lblRecordCount = New System.Windows.Forms.Label()
        Me.dgvTeachers    = New System.Windows.Forms.DataGridView()
        Me.pnlStatus   = New System.Windows.Forms.Panel()
        Me.lblStatus   = New System.Windows.Forms.Label()

        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        CType(Me.dgvTeachers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ══════════════════════════════════════════════
        '  HEADER PANEL
        ' ══════════════════════════════════════════════
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1180, 65)
        Me.pnlHeader.TabIndex = 0

        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(400, 30)
        Me.lblTitle.Text = "Teacher Management"

        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230)
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 38)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(400, 18)
        Me.lblSubtitle.Text = "Add, edit and manage teacher records"

        ' ══════════════════════════════════════════════
        '  SIDEBAR (LEFT FORM PANEL)
        ' ══════════════════════════════════════════════
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(245, 247, 252)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 65)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Padding = New System.Windows.Forms.Padding(18, 14, 18, 10)
        Me.pnlSidebar.Size = New System.Drawing.Size(310, 665)
        Me.pnlSidebar.TabIndex = 1

        ' Form Title inside sidebar
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.lblFormTitle.Location = New System.Drawing.Point(18, 14)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(270, 22)
        Me.lblFormTitle.Text = "Teacher Details"

        Me.lblDivider.BackColor = System.Drawing.Color.FromArgb(210, 220, 240)
        Me.lblDivider.Location = New System.Drawing.Point(18, 40)
        Me.lblDivider.Name = "lblDivider"
        Me.lblDivider.Size = New System.Drawing.Size(270, 1)

        ' ── Employee Code ──
        Me.lblEmpCode.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblEmpCode.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblEmpCode.Location = New System.Drawing.Point(18, 50)
        Me.lblEmpCode.Name = "lblEmpCode"
        Me.lblEmpCode.Size = New System.Drawing.Size(270, 16)
        Me.lblEmpCode.Text = "EMPLOYEE CODE  *"

        Me.txtEmpCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpCode.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEmpCode.Location = New System.Drawing.Point(18, 68)
        Me.txtEmpCode.Name = "txtEmpCode"
        Me.txtEmpCode.Size = New System.Drawing.Size(270, 26)

        ' ── First / Last Name ──
        Me.lblFirstName.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblFirstName.Location = New System.Drawing.Point(18, 103)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(125, 16)
        Me.lblFirstName.Text = "FIRST NAME  *"

        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(18, 121)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(125, 26)

        Me.lblLastName.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblLastName.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblLastName.Location = New System.Drawing.Point(160, 103)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(128, 16)
        Me.lblLastName.Text = "LAST NAME  *"

        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtLastName.Location = New System.Drawing.Point(160, 121)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(128, 26)

        ' ── Email ──
        Me.lblEmail.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblEmail.Location = New System.Drawing.Point(18, 156)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(270, 16)
        Me.lblEmail.Text = "EMAIL ADDRESS"

        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtEmail.Location = New System.Drawing.Point(18, 174)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(270, 26)

        ' ── Phone ──
        Me.lblPhone.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblPhone.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblPhone.Location = New System.Drawing.Point(18, 209)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(270, 16)
        Me.lblPhone.Text = "PHONE NUMBER"

        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPhone.Location = New System.Drawing.Point(18, 227)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(270, 26)

        ' ── Department ──
        Me.lblDept.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblDept.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblDept.Location = New System.Drawing.Point(18, 262)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(270, 16)
        Me.lblDept.Text = "DEPARTMENT  *"

        Me.cmbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDept.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbDept.Location = New System.Drawing.Point(18, 280)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(270, 26)

        ' ── Joining Date ──
        Me.lblJoining.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblJoining.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblJoining.Location = New System.Drawing.Point(18, 315)
        Me.lblJoining.Name = "lblJoining"
        Me.lblJoining.Size = New System.Drawing.Size(270, 16)
        Me.lblJoining.Text = "JOINING DATE"

        Me.dtpJoining.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtpJoining.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpJoining.Location = New System.Drawing.Point(18, 333)
        Me.dtpJoining.Name = "dtpJoining"
        Me.dtpJoining.Size = New System.Drawing.Size(270, 26)

        ' ── Button Panel ──
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(235, 238, 248)
        Me.pnlButtons.Location = New System.Drawing.Point(0, 390)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Padding = New System.Windows.Forms.Padding(18, 10, 18, 10)
        Me.pnlButtons.Size = New System.Drawing.Size(310, 210)

        ' NEW Button
        Me.btnNew.BackColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.btnNew.FlatAppearance.BorderSize = 0
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.Location = New System.Drawing.Point(18, 10)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(270, 36)
        Me.btnNew.Text = "+ ADD NEW TEACHER"
        Me.btnNew.Cursor = System.Windows.Forms.Cursors.Hand

        ' SAVE Button
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(18, 54)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(270, 36)
        Me.btnSave.Text = "SAVE TEACHER"
        Me.btnSave.Visible = False
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand

        ' UPDATE Button
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(18, 54)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(130, 36)
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.Visible = False
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand

        ' DELETE Button
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(192, 57, 43)
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(158, 54)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(130, 36)
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.Visible = False
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand

        ' CLEAR Button
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(127, 140, 141)
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(18, 100)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(270, 32)
        Me.btnClear.Text = "CANCEL / CLEAR FORM"
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand

        Me.pnlButtons.Controls.Add(Me.btnNew)
        Me.pnlButtons.Controls.Add(Me.btnSave)
        Me.pnlButtons.Controls.Add(Me.btnUpdate)
        Me.pnlButtons.Controls.Add(Me.btnDelete)
        Me.pnlButtons.Controls.Add(Me.btnClear)

        ' Add all controls to sidebar
        Me.pnlSidebar.Controls.Add(Me.lblFormTitle)
        Me.pnlSidebar.Controls.Add(Me.lblDivider)
        Me.pnlSidebar.Controls.Add(Me.lblEmpCode)
        Me.pnlSidebar.Controls.Add(Me.txtEmpCode)
        Me.pnlSidebar.Controls.Add(Me.lblFirstName)
        Me.pnlSidebar.Controls.Add(Me.txtFirstName)
        Me.pnlSidebar.Controls.Add(Me.lblLastName)
        Me.pnlSidebar.Controls.Add(Me.txtLastName)
        Me.pnlSidebar.Controls.Add(Me.lblEmail)
        Me.pnlSidebar.Controls.Add(Me.txtEmail)
        Me.pnlSidebar.Controls.Add(Me.lblPhone)
        Me.pnlSidebar.Controls.Add(Me.txtPhone)
        Me.pnlSidebar.Controls.Add(Me.lblDept)
        Me.pnlSidebar.Controls.Add(Me.cmbDept)
        Me.pnlSidebar.Controls.Add(Me.lblJoining)
        Me.pnlSidebar.Controls.Add(Me.dtpJoining)
        Me.pnlSidebar.Controls.Add(Me.pnlButtons)

        ' ══════════════════════════════════════════════
        '  MAIN RIGHT PANEL
        ' ══════════════════════════════════════════════
        Me.pnlMain.BackColor = System.Drawing.Color.White
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(310, 65)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(15, 12, 15, 10)
        Me.pnlMain.Size = New System.Drawing.Size(870, 665)

        ' ── Search Panel ──
        Me.pnlSearch.BackColor = System.Drawing.Color.FromArgb(245, 247, 252)
        Me.pnlSearch.Location = New System.Drawing.Point(15, 12)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(840, 50)

        Me.lblSearchIcon.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSearchIcon.ForeColor = System.Drawing.Color.FromArgb(120, 130, 150)
        Me.lblSearchIcon.Location = New System.Drawing.Point(8, 14)
        Me.lblSearchIcon.Name = "lblSearchIcon"
        Me.lblSearchIcon.Size = New System.Drawing.Size(22, 22)
        Me.lblSearchIcon.Text = "🔍"

        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.txtSearch.Location = New System.Drawing.Point(34, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(340, 26)

        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(382, 10)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(110, 30)
        Me.btnSearch.Text = "Search"
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnShowAll.BackColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.btnShowAll.FlatAppearance.BorderSize = 0
        Me.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAll.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnShowAll.ForeColor = System.Drawing.Color.White
        Me.btnShowAll.Location = New System.Drawing.Point(500, 10)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(110, 30)
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand

        Me.lblRecordCount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(100, 110, 130)
        Me.lblRecordCount.Location = New System.Drawing.Point(622, 14)
        Me.lblRecordCount.Name = "lblRecordCount"
        Me.lblRecordCount.Size = New System.Drawing.Size(200, 22)
        Me.lblRecordCount.Text = "Total Records: 0"
        Me.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight

        Me.pnlSearch.Controls.Add(Me.lblSearchIcon)
        Me.pnlSearch.Controls.Add(Me.txtSearch)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.btnShowAll)
        Me.pnlSearch.Controls.Add(Me.lblRecordCount)

        ' ── DataGridView ──
        Me.dgvTeachers.AllowUserToAddRows = False
        Me.dgvTeachers.AllowUserToDeleteRows = False
        Me.dgvTeachers.AllowUserToResizeRows = False
        Me.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTeachers.BackgroundColor = System.Drawing.Color.White
        Me.dgvTeachers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTeachers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal

        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(22, 50, 92)
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.dgvTeachers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTeachers.ColumnHeadersHeight = 38
        Me.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvTeachers.EnableHeadersVisualStyles = False

        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(50, 60, 80)
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(210, 225, 245)
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.dgvTeachers.DefaultCellStyle = DataGridViewCellStyle2

        Me.dgvTeachers.GridColor = System.Drawing.Color.FromArgb(220, 225, 235)
        Me.dgvTeachers.Location = New System.Drawing.Point(15, 70)
        Me.dgvTeachers.Name = "dgvTeachers"
        Me.dgvTeachers.ReadOnly = True
        Me.dgvTeachers.RowHeadersVisible = False
        Me.dgvTeachers.RowTemplate.Height = 32
        Me.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTeachers.Size = New System.Drawing.Size(840, 560)

        ' ── Status Bar ──
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(310, 700)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(870, 30)

        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230)
        Me.lblStatus.Location = New System.Drawing.Point(10, 6)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(600, 18)
        Me.lblStatus.Text = "Ready"
        Me.pnlStatus.Controls.Add(Me.lblStatus)

        Me.pnlMain.Controls.Add(Me.pnlSearch)
        Me.pnlMain.Controls.Add(Me.dgvTeachers)
        Me.pnlMain.Controls.Add(Me.pnlStatus)

        ' ══════════════════════════════════════════════
        '  FORM SETTINGS
        ' ══════════════════════════════════════════════
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1180, 730)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = True
        Me.Name = "frmTeachers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College ERP — Teacher Management"

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        CType(Me.dgvTeachers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    ' ── Control Declarations ──────────────────────────────────────
    Friend WithEvents pnlHeader   As Panel
    Friend WithEvents lblTitle    As Label
    Friend WithEvents lblSubtitle As Label

    Friend WithEvents pnlSidebar   As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents lblDivider   As Label

    Friend WithEvents lblEmpCode   As Label
    Friend WithEvents txtEmpCode   As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblLastName  As Label
    Friend WithEvents txtLastName  As TextBox
    Friend WithEvents lblEmail     As Label
    Friend WithEvents txtEmail     As TextBox
    Friend WithEvents lblPhone     As Label
    Friend WithEvents txtPhone     As TextBox
    Friend WithEvents lblDept      As Label
    Friend WithEvents cmbDept      As ComboBox
    Friend WithEvents lblJoining   As Label
    Friend WithEvents dtpJoining   As DateTimePicker

    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnNew     As Button
    Friend WithEvents btnSave    As Button
    Friend WithEvents btnUpdate  As Button
    Friend WithEvents btnDelete  As Button
    Friend WithEvents btnClear   As Button

    Friend WithEvents pnlMain        As Panel
    Friend WithEvents pnlSearch      As Panel
    Friend WithEvents lblSearchIcon  As Label
    Friend WithEvents txtSearch      As TextBox
    Friend WithEvents btnSearch      As Button
    Friend WithEvents btnShowAll     As Button
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents dgvTeachers    As DataGridView
    Friend WithEvents pnlStatus      As Panel
    Friend WithEvents lblStatus      As Label

End Class