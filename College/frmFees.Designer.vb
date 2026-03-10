<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFees
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
        Dim DgvHeaderStyle As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DgvCellStyle   As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()

        ' ── Declare all controls ──────────────────────────────────
        Me.pnlHeader        = New System.Windows.Forms.Panel()
        Me.lblTitle         = New System.Windows.Forms.Label()
        Me.lblSubtitle      = New System.Windows.Forms.Label()

        Me.pnlLeft          = New System.Windows.Forms.Panel()
        Me.pnlEntrySection  = New System.Windows.Forms.Panel()
        Me.lblEntryTitle    = New System.Windows.Forms.Label()
        Me.lblEntryDivider  = New System.Windows.Forms.Label()

        Me.lblCourse        = New System.Windows.Forms.Label()
        Me.cmbCourse        = New System.Windows.Forms.ComboBox()
        Me.lblStudent       = New System.Windows.Forms.Label()
        Me.cmbStudent       = New System.Windows.Forms.ComboBox()
        Me.lblFeeType       = New System.Windows.Forms.Label()
        Me.cmbFeeType       = New System.Windows.Forms.ComboBox()
        Me.lblAmount        = New System.Windows.Forms.Label()
        Me.txtAmount        = New System.Windows.Forms.TextBox()
        Me.lblPaidAmount    = New System.Windows.Forms.Label()
        Me.txtPaidAmount    = New System.Windows.Forms.TextBox()
        Me.lblFeeStatus     = New System.Windows.Forms.Label()
        Me.cmbStatus        = New System.Windows.Forms.ComboBox()
        Me.lblDueDate       = New System.Windows.Forms.Label()
        Me.dtpDueDate       = New System.Windows.Forms.DateTimePicker()
        Me.lblPaidDate      = New System.Windows.Forms.Label()
        Me.dtpPaidDate      = New System.Windows.Forms.DateTimePicker()
        Me.lblRemarks       = New System.Windows.Forms.Label()
        Me.txtRemarks       = New System.Windows.Forms.TextBox()

        Me.pnlButtons       = New System.Windows.Forms.Panel()
        Me.btnSave          = New System.Windows.Forms.Button()
        Me.btnUpdate        = New System.Windows.Forms.Button()
        Me.btnDelete        = New System.Windows.Forms.Button()
        Me.btnClear         = New System.Windows.Forms.Button()

        Me.pnlRight         = New System.Windows.Forms.Panel()
        Me.pnlViewSection   = New System.Windows.Forms.Panel()
        Me.lblViewTitle     = New System.Windows.Forms.Label()
        Me.lblViewDivider   = New System.Windows.Forms.Label()
        Me.lblViewCourse    = New System.Windows.Forms.Label()
        Me.cmbViewCourse    = New System.Windows.Forms.ComboBox()
        Me.lblViewStudent   = New System.Windows.Forms.Label()
        Me.cmbViewStudent   = New System.Windows.Forms.ComboBox()
        Me.btnViewFees      = New System.Windows.Forms.Button()
        Me.btnShowAll       = New System.Windows.Forms.Button()

        Me.dgvFees          = New System.Windows.Forms.DataGridView()

        Me.pnlStatusBar     = New System.Windows.Forms.Panel()
        Me.lblStatusBar     = New System.Windows.Forms.Label()

        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlEntrySection.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.pnlViewSection.SuspendLayout()
        CType(Me.dgvFees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ══════════════════════════════════════════════
        '  HEADER
        ' ══════════════════════════════════════════════
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblSubtitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1200, 65)

        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(20, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(500, 30)
        Me.lblTitle.Text = "Fee Management"

        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230)
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 38)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubtitle.Text = "Add, update and track student fee records"

        ' ══════════════════════════════════════════════
        '  LEFT PANEL  (Entry Form)
        ' ══════════════════════════════════════════════
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(245, 247, 252)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 65)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(420, 695)

        ' ── Entry Section Card ──
        Me.pnlEntrySection.BackColor = System.Drawing.Color.White
        Me.pnlEntrySection.Location = New System.Drawing.Point(15, 12)
        Me.pnlEntrySection.Name = "pnlEntrySection"
        Me.pnlEntrySection.Size = New System.Drawing.Size(388, 520)

        Me.lblEntryTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.lblEntryTitle.ForeColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.lblEntryTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblEntryTitle.Name = "lblEntryTitle"
        Me.lblEntryTitle.Size = New System.Drawing.Size(300, 22)
        Me.lblEntryTitle.Text = "Fee Record Details"

        Me.lblEntryDivider.BackColor = System.Drawing.Color.FromArgb(210, 220, 240)
        Me.lblEntryDivider.Location = New System.Drawing.Point(15, 38)
        Me.lblEntryDivider.Name = "lblEntryDivider"
        Me.lblEntryDivider.Size = New System.Drawing.Size(356, 1)

        ' Course
        Me.lblCourse.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblCourse.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblCourse.Location = New System.Drawing.Point(15, 48)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(356, 16)
        Me.lblCourse.Text = "COURSE  *"

        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCourse.Location = New System.Drawing.Point(15, 66)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(356, 26)

        ' Student
        Me.lblStudent.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblStudent.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblStudent.Location = New System.Drawing.Point(15, 101)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(356, 16)
        Me.lblStudent.Text = "STUDENT  *"

        Me.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStudent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStudent.Location = New System.Drawing.Point(15, 119)
        Me.cmbStudent.Name = "cmbStudent"
        Me.cmbStudent.Size = New System.Drawing.Size(356, 26)

        ' Fee Type
        Me.lblFeeType.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblFeeType.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblFeeType.Location = New System.Drawing.Point(15, 154)
        Me.lblFeeType.Name = "lblFeeType"
        Me.lblFeeType.Size = New System.Drawing.Size(356, 16)
        Me.lblFeeType.Text = "FEE TYPE  *"

        Me.cmbFeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFeeType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbFeeType.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbFeeType.Location = New System.Drawing.Point(15, 172)
        Me.cmbFeeType.Name = "cmbFeeType"
        Me.cmbFeeType.Size = New System.Drawing.Size(356, 26)

        ' Amount / Paid Amount (side by side)
        Me.lblAmount.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblAmount.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblAmount.Location = New System.Drawing.Point(15, 207)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(168, 16)
        Me.lblAmount.Text = "TOTAL AMOUNT (₹)  *"

        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAmount.Location = New System.Drawing.Point(15, 225)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(168, 26)

        Me.lblPaidAmount.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblPaidAmount.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblPaidAmount.Location = New System.Drawing.Point(203, 207)
        Me.lblPaidAmount.Name = "lblPaidAmount"
        Me.lblPaidAmount.Size = New System.Drawing.Size(168, 16)
        Me.lblPaidAmount.Text = "PAID AMOUNT (₹)"

        Me.txtPaidAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaidAmount.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtPaidAmount.Location = New System.Drawing.Point(203, 225)
        Me.txtPaidAmount.Name = "txtPaidAmount"
        Me.txtPaidAmount.Size = New System.Drawing.Size(168, 26)

        ' Status
        Me.lblFeeStatus.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblFeeStatus.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblFeeStatus.Location = New System.Drawing.Point(15, 260)
        Me.lblFeeStatus.Name = "lblFeeStatus"
        Me.lblFeeStatus.Size = New System.Drawing.Size(356, 16)
        Me.lblFeeStatus.Text = "PAYMENT STATUS"

        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStatus.Items.AddRange(New Object() {"Pending", "Paid", "Partial"})
        Me.cmbStatus.Location = New System.Drawing.Point(15, 278)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(168, 26)

        ' Due Date / Paid Date (side by side)
        Me.lblDueDate.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblDueDate.Location = New System.Drawing.Point(15, 313)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(168, 16)
        Me.lblDueDate.Text = "DUE DATE"

        Me.dtpDueDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDueDate.Location = New System.Drawing.Point(15, 331)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(168, 26)

        Me.lblPaidDate.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblPaidDate.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblPaidDate.Location = New System.Drawing.Point(203, 313)
        Me.lblPaidDate.Name = "lblPaidDate"
        Me.lblPaidDate.Size = New System.Drawing.Size(168, 16)
        Me.lblPaidDate.Text = "PAID DATE"

        Me.dtpPaidDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtpPaidDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpPaidDate.Location = New System.Drawing.Point(203, 331)
        Me.dtpPaidDate.Name = "dtpPaidDate"
        Me.dtpPaidDate.Size = New System.Drawing.Size(168, 26)

        ' Remarks
        Me.lblRemarks.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblRemarks.Location = New System.Drawing.Point(15, 366)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(356, 16)
        Me.lblRemarks.Text = "REMARKS"

        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRemarks.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtRemarks.Location = New System.Drawing.Point(15, 384)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(356, 50)

        Me.pnlEntrySection.Controls.Add(Me.lblEntryTitle)
        Me.pnlEntrySection.Controls.Add(Me.lblEntryDivider)
        Me.pnlEntrySection.Controls.Add(Me.lblCourse)
        Me.pnlEntrySection.Controls.Add(Me.cmbCourse)
        Me.pnlEntrySection.Controls.Add(Me.lblStudent)
        Me.pnlEntrySection.Controls.Add(Me.cmbStudent)
        Me.pnlEntrySection.Controls.Add(Me.lblFeeType)
        Me.pnlEntrySection.Controls.Add(Me.cmbFeeType)
        Me.pnlEntrySection.Controls.Add(Me.lblAmount)
        Me.pnlEntrySection.Controls.Add(Me.txtAmount)
        Me.pnlEntrySection.Controls.Add(Me.lblPaidAmount)
        Me.pnlEntrySection.Controls.Add(Me.txtPaidAmount)
        Me.pnlEntrySection.Controls.Add(Me.lblFeeStatus)
        Me.pnlEntrySection.Controls.Add(Me.cmbStatus)
        Me.pnlEntrySection.Controls.Add(Me.lblDueDate)
        Me.pnlEntrySection.Controls.Add(Me.dtpDueDate)
        Me.pnlEntrySection.Controls.Add(Me.lblPaidDate)
        Me.pnlEntrySection.Controls.Add(Me.dtpPaidDate)
        Me.pnlEntrySection.Controls.Add(Me.lblRemarks)
        Me.pnlEntrySection.Controls.Add(Me.txtRemarks)

        ' ── Button Panel ──
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(235, 238, 248)
        Me.pnlButtons.Location = New System.Drawing.Point(15, 542)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(388, 100)
        Me.pnlButtons.Padding = New System.Windows.Forms.Padding(15, 10, 15, 10)

        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(15, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(170, 36)
        Me.btnSave.Text = "SAVE RECORD"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(200, 10)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(170, 36)
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(192, 57, 43)
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(15, 54)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(170, 36)
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(127, 140, 141)
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(200, 54)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(170, 36)
        Me.btnClear.Text = "CLEAR FORM"
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand

        Me.pnlButtons.Controls.Add(Me.btnSave)
        Me.pnlButtons.Controls.Add(Me.btnUpdate)
        Me.pnlButtons.Controls.Add(Me.btnDelete)
        Me.pnlButtons.Controls.Add(Me.btnClear)

        Me.pnlLeft.Controls.Add(Me.pnlEntrySection)
        Me.pnlLeft.Controls.Add(Me.pnlButtons)

        ' ══════════════════════════════════════════════
        '  RIGHT PANEL  (View / Grid)
        ' ══════════════════════════════════════════════
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(420, 65)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Padding = New System.Windows.Forms.Padding(15, 12, 15, 10)

        ' ── View Section Card ──
        Me.pnlViewSection.BackColor = System.Drawing.Color.FromArgb(245, 247, 252)
        Me.pnlViewSection.Location = New System.Drawing.Point(15, 12)
        Me.pnlViewSection.Name = "pnlViewSection"
        Me.pnlViewSection.Size = New System.Drawing.Size(745, 120)

        Me.lblViewTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.lblViewTitle.ForeColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.lblViewTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblViewTitle.Name = "lblViewTitle"
        Me.lblViewTitle.Size = New System.Drawing.Size(300, 22)
        Me.lblViewTitle.Text = "Search Fee Records"

        Me.lblViewDivider.BackColor = System.Drawing.Color.FromArgb(210, 220, 240)
        Me.lblViewDivider.Location = New System.Drawing.Point(15, 38)
        Me.lblViewDivider.Name = "lblViewDivider"
        Me.lblViewDivider.Size = New System.Drawing.Size(713, 1)

        ' View Course
        Me.lblViewCourse.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblViewCourse.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblViewCourse.Location = New System.Drawing.Point(15, 48)
        Me.lblViewCourse.Name = "lblViewCourse"
        Me.lblViewCourse.Size = New System.Drawing.Size(200, 16)
        Me.lblViewCourse.Text = "COURSE"

        Me.cmbViewCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbViewCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbViewCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbViewCourse.Location = New System.Drawing.Point(15, 66)
        Me.cmbViewCourse.Name = "cmbViewCourse"
        Me.cmbViewCourse.Size = New System.Drawing.Size(200, 26)

        ' View Student
        Me.lblViewStudent.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblViewStudent.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblViewStudent.Location = New System.Drawing.Point(228, 48)
        Me.lblViewStudent.Name = "lblViewStudent"
        Me.lblViewStudent.Size = New System.Drawing.Size(260, 16)
        Me.lblViewStudent.Text = "STUDENT"

        Me.cmbViewStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbViewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbViewStudent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbViewStudent.Location = New System.Drawing.Point(228, 66)
        Me.cmbViewStudent.Name = "cmbViewStudent"
        Me.cmbViewStudent.Size = New System.Drawing.Size(260, 26)

        ' View Fees Button
        Me.btnViewFees.BackColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.btnViewFees.FlatAppearance.BorderSize = 0
        Me.btnViewFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewFees.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnViewFees.ForeColor = System.Drawing.Color.White
        Me.btnViewFees.Location = New System.Drawing.Point(502, 58)
        Me.btnViewFees.Name = "btnViewFees"
        Me.btnViewFees.Size = New System.Drawing.Size(110, 36)
        Me.btnViewFees.Text = "View Fees"
        Me.btnViewFees.Cursor = System.Windows.Forms.Cursors.Hand

        ' Show All Button
        Me.btnShowAll.BackColor = System.Drawing.Color.FromArgb(52, 73, 94)
        Me.btnShowAll.FlatAppearance.BorderSize = 0
        Me.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowAll.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnShowAll.ForeColor = System.Drawing.Color.White
        Me.btnShowAll.Location = New System.Drawing.Point(626, 58)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(103, 36)
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.Cursor = System.Windows.Forms.Cursors.Hand

        Me.pnlViewSection.Controls.Add(Me.lblViewTitle)
        Me.pnlViewSection.Controls.Add(Me.lblViewDivider)
        Me.pnlViewSection.Controls.Add(Me.lblViewCourse)
        Me.pnlViewSection.Controls.Add(Me.cmbViewCourse)
        Me.pnlViewSection.Controls.Add(Me.lblViewStudent)
        Me.pnlViewSection.Controls.Add(Me.cmbViewStudent)
        Me.pnlViewSection.Controls.Add(Me.btnViewFees)
        Me.pnlViewSection.Controls.Add(Me.btnShowAll)

        ' ── Fees DataGridView ──
        DgvHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(22, 50, 92)
        DgvHeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DgvHeaderStyle.ForeColor = System.Drawing.Color.White
        DgvHeaderStyle.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)

        DgvCellStyle.BackColor = System.Drawing.Color.White
        DgvCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DgvCellStyle.ForeColor = System.Drawing.Color.FromArgb(50, 60, 80)
        DgvCellStyle.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        DgvCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(210, 225, 245)
        DgvCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(22, 50, 92)

        Me.dgvFees.AllowUserToAddRows = False
        Me.dgvFees.AllowUserToDeleteRows = False
        Me.dgvFees.AllowUserToResizeRows = False
        Me.dgvFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFees.BackgroundColor = System.Drawing.Color.White
        Me.dgvFees.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFees.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvFees.ColumnHeadersDefaultCellStyle = DgvHeaderStyle
        Me.dgvFees.ColumnHeadersHeight = 38
        Me.dgvFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvFees.DefaultCellStyle = DgvCellStyle
        Me.dgvFees.EnableHeadersVisualStyles = False
        Me.dgvFees.GridColor = System.Drawing.Color.FromArgb(220, 225, 235)
        Me.dgvFees.Location = New System.Drawing.Point(15, 142)
        Me.dgvFees.Name = "dgvFees"
        Me.dgvFees.ReadOnly = True
        Me.dgvFees.RowHeadersVisible = False
        Me.dgvFees.RowTemplate.Height = 32
        Me.dgvFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFees.Size = New System.Drawing.Size(745, 518)

        Me.pnlRight.Controls.Add(Me.pnlViewSection)
        Me.pnlRight.Controls.Add(Me.dgvFees)

        ' ── Status Bar ──
        Me.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.pnlStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatusBar.Name = "pnlStatusBar"
        Me.pnlStatusBar.Size = New System.Drawing.Size(1200, 30)

        Me.lblStatusBar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatusBar.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230)
        Me.lblStatusBar.Location = New System.Drawing.Point(10, 6)
        Me.lblStatusBar.Name = "lblStatusBar"
        Me.lblStatusBar.Size = New System.Drawing.Size(900, 18)
        Me.lblStatusBar.Text = "Ready — click a row in the grid to edit, or fill the form to add a new fee record."
        Me.pnlStatusBar.Controls.Add(Me.lblStatusBar)

        ' ══════════════════════════════════════════════
        '  FORM SETTINGS
        ' ══════════════════════════════════════════════
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 760)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlStatusBar)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = True
        Me.Name = "frmFees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College ERP — Fee Management"

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlEntrySection.ResumeLayout(False)
        Me.pnlEntrySection.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlRight.ResumeLayout(False)
        Me.pnlViewSection.ResumeLayout(False)
        CType(Me.dgvFees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    ' ── Control Declarations ──────────────────────────────────────
    Friend WithEvents pnlHeader       As Panel
    Friend WithEvents lblTitle        As Label
    Friend WithEvents lblSubtitle     As Label

    Friend WithEvents pnlLeft         As Panel
    Friend WithEvents pnlEntrySection As Panel
    Friend WithEvents lblEntryTitle   As Label
    Friend WithEvents lblEntryDivider As Label
    Friend WithEvents lblCourse       As Label
    Friend WithEvents cmbCourse       As ComboBox
    Friend WithEvents lblStudent      As Label
    Friend WithEvents cmbStudent      As ComboBox
    Friend WithEvents lblFeeType      As Label
    Friend WithEvents cmbFeeType      As ComboBox
    Friend WithEvents lblAmount       As Label
    Friend WithEvents txtAmount       As TextBox
    Friend WithEvents lblPaidAmount   As Label
    Friend WithEvents txtPaidAmount   As TextBox
    Friend WithEvents lblFeeStatus    As Label
    Friend WithEvents cmbStatus       As ComboBox
    Friend WithEvents lblDueDate      As Label
    Friend WithEvents dtpDueDate      As DateTimePicker
    Friend WithEvents lblPaidDate     As Label
    Friend WithEvents dtpPaidDate     As DateTimePicker
    Friend WithEvents lblRemarks      As Label
    Friend WithEvents txtRemarks      As TextBox

    Friend WithEvents pnlButtons  As Panel
    Friend WithEvents btnSave     As Button
    Friend WithEvents btnUpdate   As Button
    Friend WithEvents btnDelete   As Button
    Friend WithEvents btnClear    As Button

    Friend WithEvents pnlRight       As Panel
    Friend WithEvents pnlViewSection As Panel
    Friend WithEvents lblViewTitle   As Label
    Friend WithEvents lblViewDivider As Label
    Friend WithEvents lblViewCourse  As Label
    Friend WithEvents cmbViewCourse  As ComboBox
    Friend WithEvents lblViewStudent As Label
    Friend WithEvents cmbViewStudent As ComboBox
    Friend WithEvents btnViewFees    As Button
    Friend WithEvents btnShowAll     As Button
    Friend WithEvents dgvFees        As DataGridView

    Friend WithEvents pnlStatusBar As Panel
    Friend WithEvents lblStatusBar As Label

End Class