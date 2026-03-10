<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResults
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
        Me.pnlHeader       = New System.Windows.Forms.Panel()
        Me.lblTitle        = New System.Windows.Forms.Label()
        Me.lblSubtitle     = New System.Windows.Forms.Label()

        Me.pnlLeft         = New System.Windows.Forms.Panel()

        Me.pnlEntrySection = New System.Windows.Forms.Panel()
        Me.lblEntryTitle   = New System.Windows.Forms.Label()
        Me.lblEntryDivider = New System.Windows.Forms.Label()

        Me.lblEntryCourse  = New System.Windows.Forms.Label()
        Me.cmbCourse       = New System.Windows.Forms.ComboBox()
        Me.lblEntryStudent = New System.Windows.Forms.Label()
        Me.cmbStudent      = New System.Windows.Forms.ComboBox()
        Me.lblEntrySubject = New System.Windows.Forms.Label()
        Me.cmbSubject      = New System.Windows.Forms.ComboBox()
        Me.lblSemester     = New System.Windows.Forms.Label()
        Me.cmbSemester     = New System.Windows.Forms.ComboBox()
        Me.lblAcYear       = New System.Windows.Forms.Label()
        Me.txtAcYear       = New System.Windows.Forms.TextBox()
        Me.lblInternal     = New System.Windows.Forms.Label()
        Me.txtInternal     = New System.Windows.Forms.TextBox()
        Me.lblExternal     = New System.Windows.Forms.Label()
        Me.txtExternal     = New System.Windows.Forms.TextBox()

        Me.pnlResult       = New System.Windows.Forms.Panel()
        Me.lblTotalLbl     = New System.Windows.Forms.Label()
        Me.txtTotal        = New System.Windows.Forms.TextBox()
        Me.lblGradeLbl     = New System.Windows.Forms.Label()
        Me.txtGrade        = New System.Windows.Forms.TextBox()

        Me.pnlButtons      = New System.Windows.Forms.Panel()
        Me.btnSaveResult   = New System.Windows.Forms.Button()
        Me.btnClear        = New System.Windows.Forms.Button()

        Me.pnlRight        = New System.Windows.Forms.Panel()

        Me.pnlViewSection  = New System.Windows.Forms.Panel()
        Me.lblViewTitle    = New System.Windows.Forms.Label()
        Me.lblViewDivider  = New System.Windows.Forms.Label()
        Me.lblViewCourse   = New System.Windows.Forms.Label()
        Me.cmbViewCourse   = New System.Windows.Forms.ComboBox()
        Me.lblViewStudent  = New System.Windows.Forms.Label()
        Me.cmbViewStudent  = New System.Windows.Forms.ComboBox()
        Me.btnViewResult   = New System.Windows.Forms.Button()

        Me.dgvResults      = New System.Windows.Forms.DataGridView()

        Me.pnlStatus       = New System.Windows.Forms.Panel()
        Me.lblStatus       = New System.Windows.Forms.Label()

        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlEntrySection.SuspendLayout()
        Me.pnlResult.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.pnlViewSection.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Text = "Result Management"

        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230)
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 38)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubtitle.Text = "Enter and view student examination results"

        ' ══════════════════════════════════════════════
        '  LEFT PANEL  (Enter Result)
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
        Me.pnlEntrySection.Size = New System.Drawing.Size(388, 460)

        Me.lblEntryTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.lblEntryTitle.ForeColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.lblEntryTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblEntryTitle.Name = "lblEntryTitle"
        Me.lblEntryTitle.Size = New System.Drawing.Size(300, 22)
        Me.lblEntryTitle.Text = "Enter Result"

        Me.lblEntryDivider.BackColor = System.Drawing.Color.FromArgb(210, 220, 240)
        Me.lblEntryDivider.Location = New System.Drawing.Point(15, 38)
        Me.lblEntryDivider.Name = "lblEntryDivider"
        Me.lblEntryDivider.Size = New System.Drawing.Size(356, 1)

        ' Course
        Me.lblEntryCourse.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblEntryCourse.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblEntryCourse.Location = New System.Drawing.Point(15, 48)
        Me.lblEntryCourse.Name = "lblEntryCourse"
        Me.lblEntryCourse.Size = New System.Drawing.Size(356, 16)
        Me.lblEntryCourse.Text = "COURSE  *"

        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCourse.Location = New System.Drawing.Point(15, 66)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(356, 26)

        ' Student
        Me.lblEntryStudent.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblEntryStudent.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblEntryStudent.Location = New System.Drawing.Point(15, 101)
        Me.lblEntryStudent.Name = "lblEntryStudent"
        Me.lblEntryStudent.Size = New System.Drawing.Size(356, 16)
        Me.lblEntryStudent.Text = "STUDENT  *"

        Me.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbStudent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbStudent.Location = New System.Drawing.Point(15, 119)
        Me.cmbStudent.Name = "cmbStudent"
        Me.cmbStudent.Size = New System.Drawing.Size(356, 26)

        ' Subject
        Me.lblEntrySubject.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblEntrySubject.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblEntrySubject.Location = New System.Drawing.Point(15, 154)
        Me.lblEntrySubject.Name = "lblEntrySubject"
        Me.lblEntrySubject.Size = New System.Drawing.Size(356, 16)
        Me.lblEntrySubject.Text = "SUBJECT  *"

        Me.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSubject.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSubject.Location = New System.Drawing.Point(15, 172)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(356, 26)

        ' Semester / Academic Year (side by side)
        Me.lblSemester.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblSemester.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblSemester.Location = New System.Drawing.Point(15, 207)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(168, 16)
        Me.lblSemester.Text = "SEMESTER  *"

        Me.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemester.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSemester.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSemester.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbSemester.Location = New System.Drawing.Point(15, 225)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(168, 26)

        Me.lblAcYear.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblAcYear.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblAcYear.Location = New System.Drawing.Point(203, 207)
        Me.lblAcYear.Name = "lblAcYear"
        Me.lblAcYear.Size = New System.Drawing.Size(168, 16)
        Me.lblAcYear.Text = "ACADEMIC YEAR"

        Me.txtAcYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAcYear.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtAcYear.Location = New System.Drawing.Point(203, 225)
        Me.txtAcYear.Name = "txtAcYear"
        Me.txtAcYear.Size = New System.Drawing.Size(168, 26)
        Me.txtAcYear.Text = "2025-26"

        ' Internal / External marks (side by side)
        Me.lblInternal.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblInternal.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblInternal.Location = New System.Drawing.Point(15, 260)
        Me.lblInternal.Name = "lblInternal"
        Me.lblInternal.Size = New System.Drawing.Size(168, 16)
        Me.lblInternal.Text = "INTERNAL MARKS (30)"

        Me.txtInternal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInternal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtInternal.Location = New System.Drawing.Point(15, 278)
        Me.txtInternal.Name = "txtInternal"
        Me.txtInternal.Size = New System.Drawing.Size(168, 26)

        Me.lblExternal.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblExternal.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblExternal.Location = New System.Drawing.Point(203, 260)
        Me.lblExternal.Name = "lblExternal"
        Me.lblExternal.Size = New System.Drawing.Size(168, 16)
        Me.lblExternal.Text = "EXTERNAL MARKS (70)"

        Me.txtExternal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExternal.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.txtExternal.Location = New System.Drawing.Point(203, 278)
        Me.txtExternal.Name = "txtExternal"
        Me.txtExternal.Size = New System.Drawing.Size(168, 26)

        ' Total / Grade result card
        Me.pnlResult.BackColor = System.Drawing.Color.FromArgb(235, 238, 248)
        Me.pnlResult.Location = New System.Drawing.Point(15, 318)
        Me.pnlResult.Name = "pnlResult"
        Me.pnlResult.Size = New System.Drawing.Size(356, 70)

        Me.lblTotalLbl.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblTotalLbl.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblTotalLbl.Location = New System.Drawing.Point(12, 8)
        Me.lblTotalLbl.Name = "lblTotalLbl"
        Me.lblTotalLbl.Size = New System.Drawing.Size(158, 16)
        Me.lblTotalLbl.Text = "TOTAL MARKS"

        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.txtTotal.Location = New System.Drawing.Point(12, 27)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(158, 32)
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center

        Me.lblGradeLbl.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblGradeLbl.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblGradeLbl.Location = New System.Drawing.Point(186, 8)
        Me.lblGradeLbl.Name = "lblGradeLbl"
        Me.lblGradeLbl.Size = New System.Drawing.Size(158, 16)
        Me.lblGradeLbl.Text = "GRADE"

        Me.txtGrade.BackColor = System.Drawing.Color.White
        Me.txtGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrade.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.txtGrade.ForeColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.txtGrade.Location = New System.Drawing.Point(186, 27)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.ReadOnly = True
        Me.txtGrade.Size = New System.Drawing.Size(158, 32)
        Me.txtGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center

        Me.pnlResult.Controls.Add(Me.lblTotalLbl)
        Me.pnlResult.Controls.Add(Me.txtTotal)
        Me.pnlResult.Controls.Add(Me.lblGradeLbl)
        Me.pnlResult.Controls.Add(Me.txtGrade)

        Me.pnlEntrySection.Controls.Add(Me.lblEntryTitle)
        Me.pnlEntrySection.Controls.Add(Me.lblEntryDivider)
        Me.pnlEntrySection.Controls.Add(Me.lblEntryCourse)
        Me.pnlEntrySection.Controls.Add(Me.cmbCourse)
        Me.pnlEntrySection.Controls.Add(Me.lblEntryStudent)
        Me.pnlEntrySection.Controls.Add(Me.cmbStudent)
        Me.pnlEntrySection.Controls.Add(Me.lblEntrySubject)
        Me.pnlEntrySection.Controls.Add(Me.cmbSubject)
        Me.pnlEntrySection.Controls.Add(Me.lblSemester)
        Me.pnlEntrySection.Controls.Add(Me.cmbSemester)
        Me.pnlEntrySection.Controls.Add(Me.lblAcYear)
        Me.pnlEntrySection.Controls.Add(Me.txtAcYear)
        Me.pnlEntrySection.Controls.Add(Me.lblInternal)
        Me.pnlEntrySection.Controls.Add(Me.txtInternal)
        Me.pnlEntrySection.Controls.Add(Me.lblExternal)
        Me.pnlEntrySection.Controls.Add(Me.txtExternal)
        Me.pnlEntrySection.Controls.Add(Me.pnlResult)

        ' ── Button Panel ──
        Me.pnlButtons.BackColor = System.Drawing.Color.FromArgb(235, 238, 248)
        Me.pnlButtons.Location = New System.Drawing.Point(15, 482)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(388, 90)
        Me.pnlButtons.Padding = New System.Windows.Forms.Padding(15, 12, 15, 12)

        Me.btnSaveResult.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.btnSaveResult.FlatAppearance.BorderSize = 0
        Me.btnSaveResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveResult.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnSaveResult.ForeColor = System.Drawing.Color.White
        Me.btnSaveResult.Location = New System.Drawing.Point(15, 12)
        Me.btnSaveResult.Name = "btnSaveResult"
        Me.btnSaveResult.Size = New System.Drawing.Size(172, 40)
        Me.btnSaveResult.Text = "SAVE RESULT"
        Me.btnSaveResult.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(127, 140, 141)
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(201, 12)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(172, 40)
        Me.btnClear.Text = "CLEAR FORM"
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand

        Me.pnlButtons.Controls.Add(Me.btnSaveResult)
        Me.pnlButtons.Controls.Add(Me.btnClear)

        Me.pnlLeft.Controls.Add(Me.pnlEntrySection)
        Me.pnlLeft.Controls.Add(Me.pnlButtons)

        ' ══════════════════════════════════════════════
        '  RIGHT PANEL  (View Results)
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
        Me.pnlViewSection.Size = New System.Drawing.Size(735, 120)

        Me.lblViewTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.lblViewTitle.ForeColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.lblViewTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblViewTitle.Name = "lblViewTitle"
        Me.lblViewTitle.Size = New System.Drawing.Size(300, 22)
        Me.lblViewTitle.Text = "View Student Results"

        Me.lblViewDivider.BackColor = System.Drawing.Color.FromArgb(210, 220, 240)
        Me.lblViewDivider.Location = New System.Drawing.Point(15, 38)
        Me.lblViewDivider.Name = "lblViewDivider"
        Me.lblViewDivider.Size = New System.Drawing.Size(703, 1)

        ' View Course
        Me.lblViewCourse.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblViewCourse.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblViewCourse.Location = New System.Drawing.Point(15, 48)
        Me.lblViewCourse.Name = "lblViewCourse"
        Me.lblViewCourse.Size = New System.Drawing.Size(260, 16)
        Me.lblViewCourse.Text = "COURSE"

        Me.cmbViewCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbViewCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbViewCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbViewCourse.Location = New System.Drawing.Point(15, 66)
        Me.cmbViewCourse.Name = "cmbViewCourse"
        Me.cmbViewCourse.Size = New System.Drawing.Size(260, 26)

        ' View Student
        Me.lblViewStudent.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblViewStudent.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblViewStudent.Location = New System.Drawing.Point(290, 48)
        Me.lblViewStudent.Name = "lblViewStudent"
        Me.lblViewStudent.Size = New System.Drawing.Size(300, 16)
        Me.lblViewStudent.Text = "STUDENT"

        Me.cmbViewStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbViewStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbViewStudent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbViewStudent.Location = New System.Drawing.Point(290, 66)
        Me.cmbViewStudent.Name = "cmbViewStudent"
        Me.cmbViewStudent.Size = New System.Drawing.Size(300, 26)

        ' View Result Button
        Me.btnViewResult.BackColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.btnViewResult.FlatAppearance.BorderSize = 0
        Me.btnViewResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewResult.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnViewResult.ForeColor = System.Drawing.Color.White
        Me.btnViewResult.Location = New System.Drawing.Point(606, 58)
        Me.btnViewResult.Name = "btnViewResult"
        Me.btnViewResult.Size = New System.Drawing.Size(112, 36)
        Me.btnViewResult.Text = "View Results"
        Me.btnViewResult.Cursor = System.Windows.Forms.Cursors.Hand

        Me.pnlViewSection.Controls.Add(Me.lblViewTitle)
        Me.pnlViewSection.Controls.Add(Me.lblViewDivider)
        Me.pnlViewSection.Controls.Add(Me.lblViewCourse)
        Me.pnlViewSection.Controls.Add(Me.cmbViewCourse)
        Me.pnlViewSection.Controls.Add(Me.lblViewStudent)
        Me.pnlViewSection.Controls.Add(Me.cmbViewStudent)
        Me.pnlViewSection.Controls.Add(Me.btnViewResult)

        ' ── Results DataGridView ──
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

        Me.dgvResults.AllowUserToAddRows = False
        Me.dgvResults.AllowUserToDeleteRows = False
        Me.dgvResults.AllowUserToResizeRows = False
        Me.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResults.BackgroundColor = System.Drawing.Color.White
        Me.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvResults.ColumnHeadersDefaultCellStyle = DgvHeaderStyle
        Me.dgvResults.ColumnHeadersHeight = 38
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvResults.DefaultCellStyle = DgvCellStyle
        Me.dgvResults.EnableHeadersVisualStyles = False
        Me.dgvResults.GridColor = System.Drawing.Color.FromArgb(220, 225, 235)
        Me.dgvResults.Location = New System.Drawing.Point(15, 142)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.ReadOnly = True
        Me.dgvResults.RowHeadersVisible = False
        Me.dgvResults.RowTemplate.Height = 32
        Me.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResults.Size = New System.Drawing.Size(735, 518)

        Me.pnlRight.Controls.Add(Me.pnlViewSection)
        Me.pnlRight.Controls.Add(Me.dgvResults)

        ' ── Status Bar ──
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(1200, 30)

        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230)
        Me.lblStatus.Location = New System.Drawing.Point(10, 6)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(900, 18)
        Me.lblStatus.Text = "Ready — select Course and Student to enter or view results."
        Me.pnlStatus.Controls.Add(Me.lblStatus)

        ' ══════════════════════════════════════════════
        '  FORM SETTINGS
        ' ══════════════════════════════════════════════
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 760)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlStatus)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = True
        Me.Name = "frmResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College ERP — Result Management"

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlEntrySection.ResumeLayout(False)
        Me.pnlEntrySection.PerformLayout()
        Me.pnlResult.ResumeLayout(False)
        Me.pnlResult.PerformLayout()
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlRight.ResumeLayout(False)
        Me.pnlViewSection.ResumeLayout(False)
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblEntryCourse  As Label
    Friend WithEvents cmbCourse       As ComboBox
    Friend WithEvents lblEntryStudent As Label
    Friend WithEvents cmbStudent      As ComboBox
    Friend WithEvents lblEntrySubject As Label
    Friend WithEvents cmbSubject      As ComboBox
    Friend WithEvents lblSemester     As Label
    Friend WithEvents cmbSemester     As ComboBox
    Friend WithEvents lblAcYear       As Label
    Friend WithEvents txtAcYear       As TextBox
    Friend WithEvents lblInternal     As Label
    Friend WithEvents txtInternal     As TextBox
    Friend WithEvents lblExternal     As Label
    Friend WithEvents txtExternal     As TextBox

    Friend WithEvents pnlResult   As Panel
    Friend WithEvents lblTotalLbl As Label
    Friend WithEvents txtTotal    As TextBox
    Friend WithEvents lblGradeLbl As Label
    Friend WithEvents txtGrade    As TextBox

    Friend WithEvents pnlButtons    As Panel
    Friend WithEvents btnSaveResult As Button
    Friend WithEvents btnClear      As Button

    Friend WithEvents pnlRight        As Panel
    Friend WithEvents pnlViewSection  As Panel
    Friend WithEvents lblViewTitle    As Label
    Friend WithEvents lblViewDivider  As Label
    Friend WithEvents lblViewCourse   As Label
    Friend WithEvents cmbViewCourse   As ComboBox
    Friend WithEvents lblViewStudent  As Label
    Friend WithEvents cmbViewStudent  As ComboBox
    Friend WithEvents btnViewResult   As Button
    Friend WithEvents dgvResults      As DataGridView

    Friend WithEvents pnlStatus As Panel
    Friend WithEvents lblStatus As Label

End Class