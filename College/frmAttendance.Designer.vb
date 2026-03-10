<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAttendance
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
        Dim DgvHeaderStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DgvCellStyle1   As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DgvHeaderStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DgvCellStyle2   As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()

        ' ── Declare all controls ──────────────────────────────────
        Me.pnlHeader         = New System.Windows.Forms.Panel()
        Me.lblTitle          = New System.Windows.Forms.Label()
        Me.lblSubtitle       = New System.Windows.Forms.Label()

        Me.pnlLeft           = New System.Windows.Forms.Panel()

        Me.pnlMarkSection    = New System.Windows.Forms.Panel()
        Me.lblMarkTitle      = New System.Windows.Forms.Label()
        Me.lblMarkDivider    = New System.Windows.Forms.Label()
        Me.lblCourse         = New System.Windows.Forms.Label()
        Me.cmbCourse         = New System.Windows.Forms.ComboBox()
        Me.lblSubject        = New System.Windows.Forms.Label()
        Me.cmbSubject        = New System.Windows.Forms.ComboBox()
        Me.lblDate           = New System.Windows.Forms.Label()
        Me.dtpDate           = New System.Windows.Forms.DateTimePicker()
        Me.btnLoadStudents   = New System.Windows.Forms.Button()
        Me.pnlMarkActions    = New System.Windows.Forms.Panel()
        Me.btnMarkAllPresent = New System.Windows.Forms.Button()
        Me.btnMarkAllAbsent  = New System.Windows.Forms.Button()
        Me.btnSaveAttendance = New System.Windows.Forms.Button()

        Me.dgvAttendance     = New System.Windows.Forms.DataGridView()

        Me.pnlRight          = New System.Windows.Forms.Panel()

        Me.pnlReportSection  = New System.Windows.Forms.Panel()
        Me.lblReportTitle    = New System.Windows.Forms.Label()
        Me.lblReportDivider  = New System.Windows.Forms.Label()
        Me.lblReportCourse   = New System.Windows.Forms.Label()
        Me.cmbReportCourse   = New System.Windows.Forms.ComboBox()
        Me.lblReportStudent  = New System.Windows.Forms.Label()
        Me.cmbReportStudent  = New System.Windows.Forms.ComboBox()
        Me.btnViewReport     = New System.Windows.Forms.Button()

        Me.dgvReport         = New System.Windows.Forms.DataGridView()

        Me.pnlStatus         = New System.Windows.Forms.Panel()
        Me.lblStatus         = New System.Windows.Forms.Label()

        Me.pnlHeader.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlMarkSection.SuspendLayout()
        Me.pnlMarkActions.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.pnlReportSection.SuspendLayout()
        CType(Me.dgvAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Text = "Attendance Management"

        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230)
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 38)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(500, 18)
        Me.lblSubtitle.Text = "Mark and view student attendance records"

        ' ══════════════════════════════════════════════
        '  LEFT PANEL  (Mark Attendance)
        ' ══════════════════════════════════════════════
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(245, 247, 252)
        Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlLeft.Location = New System.Drawing.Point(0, 65)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(560, 695)
        Me.pnlLeft.Padding = New System.Windows.Forms.Padding(15, 12, 15, 10)

        ' ── Mark Section Card ──
        Me.pnlMarkSection.BackColor = System.Drawing.Color.White
        Me.pnlMarkSection.Location = New System.Drawing.Point(15, 12)
        Me.pnlMarkSection.Name = "pnlMarkSection"
        Me.pnlMarkSection.Size = New System.Drawing.Size(528, 230)
        Me.pnlMarkSection.Padding = New System.Windows.Forms.Padding(15, 12, 15, 10)

        Me.lblMarkTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.lblMarkTitle.ForeColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.lblMarkTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblMarkTitle.Name = "lblMarkTitle"
        Me.lblMarkTitle.Size = New System.Drawing.Size(300, 22)
        Me.lblMarkTitle.Text = "Mark Attendance"

        Me.lblMarkDivider.BackColor = System.Drawing.Color.FromArgb(210, 220, 240)
        Me.lblMarkDivider.Location = New System.Drawing.Point(15, 38)
        Me.lblMarkDivider.Name = "lblMarkDivider"
        Me.lblMarkDivider.Size = New System.Drawing.Size(496, 1)

        ' Course
        Me.lblCourse.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblCourse.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblCourse.Location = New System.Drawing.Point(15, 48)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(230, 16)
        Me.lblCourse.Text = "COURSE  *"

        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbCourse.Location = New System.Drawing.Point(15, 66)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(230, 26)

        ' Subject
        Me.lblSubject.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblSubject.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblSubject.Location = New System.Drawing.Point(260, 48)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(250, 16)
        Me.lblSubject.Text = "SUBJECT  *"

        Me.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSubject.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbSubject.Location = New System.Drawing.Point(260, 66)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(250, 26)

        ' Date
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblDate.Location = New System.Drawing.Point(15, 102)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(230, 16)
        Me.lblDate.Text = "ATTENDANCE DATE"

        Me.dtpDate.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDate.Location = New System.Drawing.Point(15, 120)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(230, 26)

        ' Load Students Button
        Me.btnLoadStudents.BackColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.btnLoadStudents.FlatAppearance.BorderSize = 0
        Me.btnLoadStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadStudents.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnLoadStudents.ForeColor = System.Drawing.Color.White
        Me.btnLoadStudents.Location = New System.Drawing.Point(260, 113)
        Me.btnLoadStudents.Name = "btnLoadStudents"
        Me.btnLoadStudents.Size = New System.Drawing.Size(250, 36)
        Me.btnLoadStudents.Text = "Load Students"
        Me.btnLoadStudents.Cursor = System.Windows.Forms.Cursors.Hand

        ' Actions sub-panel
        Me.pnlMarkActions.BackColor = System.Drawing.Color.FromArgb(235, 238, 248)
        Me.pnlMarkActions.Location = New System.Drawing.Point(15, 160)
        Me.pnlMarkActions.Name = "pnlMarkActions"
        Me.pnlMarkActions.Size = New System.Drawing.Size(496, 55)
        Me.pnlMarkActions.Padding = New System.Windows.Forms.Padding(8, 8, 8, 8)

        Me.btnMarkAllPresent.BackColor = System.Drawing.Color.FromArgb(39, 174, 96)
        Me.btnMarkAllPresent.FlatAppearance.BorderSize = 0
        Me.btnMarkAllPresent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarkAllPresent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnMarkAllPresent.ForeColor = System.Drawing.Color.White
        Me.btnMarkAllPresent.Location = New System.Drawing.Point(8, 8)
        Me.btnMarkAllPresent.Name = "btnMarkAllPresent"
        Me.btnMarkAllPresent.Size = New System.Drawing.Size(148, 36)
        Me.btnMarkAllPresent.Text = "✅  All Present"
        Me.btnMarkAllPresent.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnMarkAllAbsent.BackColor = System.Drawing.Color.FromArgb(192, 57, 43)
        Me.btnMarkAllAbsent.FlatAppearance.BorderSize = 0
        Me.btnMarkAllAbsent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarkAllAbsent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnMarkAllAbsent.ForeColor = System.Drawing.Color.White
        Me.btnMarkAllAbsent.Location = New System.Drawing.Point(164, 8)
        Me.btnMarkAllAbsent.Name = "btnMarkAllAbsent"
        Me.btnMarkAllAbsent.Size = New System.Drawing.Size(148, 36)
        Me.btnMarkAllAbsent.Text = "❌  All Absent"
        Me.btnMarkAllAbsent.Cursor = System.Windows.Forms.Cursors.Hand

        Me.btnSaveAttendance.BackColor = System.Drawing.Color.FromArgb(41, 128, 185)
        Me.btnSaveAttendance.FlatAppearance.BorderSize = 0
        Me.btnSaveAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAttendance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSaveAttendance.ForeColor = System.Drawing.Color.White
        Me.btnSaveAttendance.Location = New System.Drawing.Point(320, 8)
        Me.btnSaveAttendance.Name = "btnSaveAttendance"
        Me.btnSaveAttendance.Size = New System.Drawing.Size(168, 36)
        Me.btnSaveAttendance.Text = "💾  Save Attendance"
        Me.btnSaveAttendance.Cursor = System.Windows.Forms.Cursors.Hand

        Me.pnlMarkActions.Controls.Add(Me.btnMarkAllPresent)
        Me.pnlMarkActions.Controls.Add(Me.btnMarkAllAbsent)
        Me.pnlMarkActions.Controls.Add(Me.btnSaveAttendance)

        Me.pnlMarkSection.Controls.Add(Me.lblMarkTitle)
        Me.pnlMarkSection.Controls.Add(Me.lblMarkDivider)
        Me.pnlMarkSection.Controls.Add(Me.lblCourse)
        Me.pnlMarkSection.Controls.Add(Me.cmbCourse)
        Me.pnlMarkSection.Controls.Add(Me.lblSubject)
        Me.pnlMarkSection.Controls.Add(Me.cmbSubject)
        Me.pnlMarkSection.Controls.Add(Me.lblDate)
        Me.pnlMarkSection.Controls.Add(Me.dtpDate)
        Me.pnlMarkSection.Controls.Add(Me.btnLoadStudents)
        Me.pnlMarkSection.Controls.Add(Me.pnlMarkActions)

        ' ── Attendance DataGridView ──
        DgvHeaderStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DgvHeaderStyle1.BackColor = System.Drawing.Color.FromArgb(22, 50, 92)
        DgvHeaderStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DgvHeaderStyle1.ForeColor = System.Drawing.Color.White
        DgvHeaderStyle1.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)

        DgvCellStyle1.BackColor = System.Drawing.Color.White
        DgvCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DgvCellStyle1.ForeColor = System.Drawing.Color.FromArgb(50, 60, 80)
        DgvCellStyle1.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        DgvCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(210, 225, 245)
        DgvCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(22, 50, 92)

        Me.dgvAttendance.AllowUserToAddRows = False
        Me.dgvAttendance.AllowUserToDeleteRows = False
        Me.dgvAttendance.BackgroundColor = System.Drawing.Color.White
        Me.dgvAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAttendance.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvAttendance.ColumnHeadersDefaultCellStyle = DgvHeaderStyle1
        Me.dgvAttendance.ColumnHeadersHeight = 38
        Me.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAttendance.DefaultCellStyle = DgvCellStyle1
        Me.dgvAttendance.EnableHeadersVisualStyles = False
        Me.dgvAttendance.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dgvAttendance.GridColor = System.Drawing.Color.FromArgb(220, 225, 235)
        Me.dgvAttendance.Location = New System.Drawing.Point(15, 252)
        Me.dgvAttendance.Name = "dgvAttendance"
        Me.dgvAttendance.RowHeadersVisible = False
        Me.dgvAttendance.RowTemplate.Height = 32
        Me.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAttendance.Size = New System.Drawing.Size(528, 408)

        Me.pnlLeft.Controls.Add(Me.pnlMarkSection)
        Me.pnlLeft.Controls.Add(Me.dgvAttendance)

        ' ══════════════════════════════════════════════
        '  RIGHT PANEL  (Attendance Report)
        ' ══════════════════════════════════════════════
        Me.pnlRight.BackColor = System.Drawing.Color.White
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlRight.Location = New System.Drawing.Point(560, 65)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Padding = New System.Windows.Forms.Padding(15, 12, 15, 10)

        ' ── Report Section Card ──
        Me.pnlReportSection.BackColor = System.Drawing.Color.FromArgb(245, 247, 252)
        Me.pnlReportSection.Location = New System.Drawing.Point(15, 12)
        Me.pnlReportSection.Name = "pnlReportSection"
        Me.pnlReportSection.Size = New System.Drawing.Size(598, 145)

        Me.lblReportTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.5!)
        Me.lblReportTitle.ForeColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.lblReportTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblReportTitle.Name = "lblReportTitle"
        Me.lblReportTitle.Size = New System.Drawing.Size(300, 22)
        Me.lblReportTitle.Text = "View Attendance Report"

        Me.lblReportDivider.BackColor = System.Drawing.Color.FromArgb(210, 220, 240)
        Me.lblReportDivider.Location = New System.Drawing.Point(15, 38)
        Me.lblReportDivider.Name = "lblReportDivider"
        Me.lblReportDivider.Size = New System.Drawing.Size(566, 1)

        ' Report Course
        Me.lblReportCourse.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblReportCourse.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblReportCourse.Location = New System.Drawing.Point(15, 48)
        Me.lblReportCourse.Name = "lblReportCourse"
        Me.lblReportCourse.Size = New System.Drawing.Size(220, 16)
        Me.lblReportCourse.Text = "COURSE"

        Me.cmbReportCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbReportCourse.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbReportCourse.Location = New System.Drawing.Point(15, 66)
        Me.cmbReportCourse.Name = "cmbReportCourse"
        Me.cmbReportCourse.Size = New System.Drawing.Size(220, 26)

        ' Report Student
        Me.lblReportStudent.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblReportStudent.ForeColor = System.Drawing.Color.FromArgb(80, 90, 110)
        Me.lblReportStudent.Location = New System.Drawing.Point(248, 48)
        Me.lblReportStudent.Name = "lblReportStudent"
        Me.lblReportStudent.Size = New System.Drawing.Size(220, 16)
        Me.lblReportStudent.Text = "STUDENT"

        Me.cmbReportStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbReportStudent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbReportStudent.Location = New System.Drawing.Point(248, 66)
        Me.cmbReportStudent.Name = "cmbReportStudent"
        Me.cmbReportStudent.Size = New System.Drawing.Size(220, 26)

        ' View Report Button
        Me.btnViewReport.BackColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.btnViewReport.FlatAppearance.BorderSize = 0
        Me.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewReport.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.btnViewReport.ForeColor = System.Drawing.Color.White
        Me.btnViewReport.Location = New System.Drawing.Point(482, 58)
        Me.btnViewReport.Name = "btnViewReport"
        Me.btnViewReport.Size = New System.Drawing.Size(100, 36)
        Me.btnViewReport.Text = "View Report"
        Me.btnViewReport.Cursor = System.Windows.Forms.Cursors.Hand

        Me.pnlReportSection.Controls.Add(Me.lblReportTitle)
        Me.pnlReportSection.Controls.Add(Me.lblReportDivider)
        Me.pnlReportSection.Controls.Add(Me.lblReportCourse)
        Me.pnlReportSection.Controls.Add(Me.cmbReportCourse)
        Me.pnlReportSection.Controls.Add(Me.lblReportStudent)
        Me.pnlReportSection.Controls.Add(Me.cmbReportStudent)
        Me.pnlReportSection.Controls.Add(Me.btnViewReport)

        ' ── Report DataGridView ──
        DgvHeaderStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DgvHeaderStyle2.BackColor = System.Drawing.Color.FromArgb(22, 50, 92)
        DgvHeaderStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DgvHeaderStyle2.ForeColor = System.Drawing.Color.White
        DgvHeaderStyle2.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)

        DgvCellStyle2.BackColor = System.Drawing.Color.White
        DgvCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        DgvCellStyle2.ForeColor = System.Drawing.Color.FromArgb(50, 60, 80)
        DgvCellStyle2.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        DgvCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(210, 225, 245)
        DgvCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(22, 50, 92)

        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.AllowUserToDeleteRows = False
        Me.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReport.BackgroundColor = System.Drawing.Color.White
        Me.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvReport.ColumnHeadersDefaultCellStyle = DgvHeaderStyle2
        Me.dgvReport.ColumnHeadersHeight = 38
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvReport.DefaultCellStyle = DgvCellStyle2
        Me.dgvReport.EnableHeadersVisualStyles = False
        Me.dgvReport.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.dgvReport.GridColor = System.Drawing.Color.FromArgb(220, 225, 235)
        Me.dgvReport.Location = New System.Drawing.Point(15, 167)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.ReadOnly = True
        Me.dgvReport.RowHeadersVisible = False
        Me.dgvReport.RowTemplate.Height = 32
        Me.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReport.Size = New System.Drawing.Size(598, 493)

        Me.pnlRight.Controls.Add(Me.pnlReportSection)
        Me.pnlRight.Controls.Add(Me.dgvReport)

        ' ── Status Bar ──
        Me.pnlStatus.BackColor = System.Drawing.Color.FromArgb(22, 50, 92)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(1200, 30)

        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(180, 200, 230)
        Me.lblStatus.Location = New System.Drawing.Point(10, 6)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(800, 18)
        Me.lblStatus.Text = "Ready — select Course and Subject, then click Load Students."
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
        Me.Name = "frmAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College ERP — Attendance Management"

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlMarkSection.ResumeLayout(False)
        Me.pnlMarkActions.ResumeLayout(False)
        Me.pnlRight.ResumeLayout(False)
        Me.pnlReportSection.ResumeLayout(False)
        CType(Me.dgvAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    ' ── Control Declarations ──────────────────────────────────────
    Friend WithEvents pnlHeader        As Panel
    Friend WithEvents lblTitle         As Label
    Friend WithEvents lblSubtitle      As Label

    Friend WithEvents pnlLeft          As Panel
    Friend WithEvents pnlMarkSection   As Panel
    Friend WithEvents lblMarkTitle     As Label
    Friend WithEvents lblMarkDivider   As Label
    Friend WithEvents lblCourse        As Label
    Friend WithEvents cmbCourse        As ComboBox
    Friend WithEvents lblSubject       As Label
    Friend WithEvents cmbSubject       As ComboBox
    Friend WithEvents lblDate          As Label
    Friend WithEvents dtpDate          As DateTimePicker
    Friend WithEvents btnLoadStudents  As Button
    Friend WithEvents pnlMarkActions   As Panel
    Friend WithEvents btnMarkAllPresent As Button
    Friend WithEvents btnMarkAllAbsent  As Button
    Friend WithEvents btnSaveAttendance As Button
    Friend WithEvents dgvAttendance    As DataGridView

    Friend WithEvents pnlRight         As Panel
    Friend WithEvents pnlReportSection As Panel
    Friend WithEvents lblReportTitle   As Label
    Friend WithEvents lblReportDivider As Label
    Friend WithEvents lblReportCourse  As Label
    Friend WithEvents cmbReportCourse  As ComboBox
    Friend WithEvents lblReportStudent As Label
    Friend WithEvents cmbReportStudent As ComboBox
    Friend WithEvents btnViewReport    As Button
    Friend WithEvents dgvReport        As DataGridView

    Friend WithEvents pnlStatus As Panel
    Friend WithEvents lblStatus As Label

End Class