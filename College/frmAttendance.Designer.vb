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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.cmbSubject = New System.Windows.Forms.ComboBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnLoadStudents = New System.Windows.Forms.Button()
        Me.btnSaveAttendance = New System.Windows.Forms.Button()
        Me.btnMarkAllPresent = New System.Windows.Forms.Button()
        Me.btnMarkAllAbsent = New System.Windows.Forms.Button()
        Me.dgvAttendance = New System.Windows.Forms.DataGridView()
        Me.pnlReport = New System.Windows.Forms.Panel()
        Me.lblReportTitle = New System.Windows.Forms.Label()
        Me.lblReportCourse = New System.Windows.Forms.Label()
        Me.cmbReportCourse = New System.Windows.Forms.ComboBox()
        Me.lblReportStudent = New System.Windows.Forms.Label()
        Me.cmbReportStudent = New System.Windows.Forms.ComboBox()
        Me.btnViewReport = New System.Windows.Forms.Button()
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.pnlHeader.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        Me.pnlReport.SuspendLayout()
        CType(Me.dgvAttendance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Text = "📅 Attendance Management"

        'pnlTop
        Me.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Location = New System.Drawing.Point(10, 60)
        Me.pnlTop.Size = New System.Drawing.Size(530, 220)
        Me.pnlTop.Controls.Add(Me.lblCourse)
        Me.pnlTop.Controls.Add(Me.cmbCourse)
        Me.pnlTop.Controls.Add(Me.lblSubject)
        Me.pnlTop.Controls.Add(Me.cmbSubject)
        Me.pnlTop.Controls.Add(Me.lblDate)
        Me.pnlTop.Controls.Add(Me.dtpDate)
        Me.pnlTop.Controls.Add(Me.btnLoadStudents)
        Me.pnlTop.Controls.Add(Me.btnSaveAttendance)
        Me.pnlTop.Controls.Add(Me.btnMarkAllPresent)
        Me.pnlTop.Controls.Add(Me.btnMarkAllAbsent)

        'lblCourse
        Me.lblCourse.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblCourse.Location = New System.Drawing.Point(10, 15)
        Me.lblCourse.Size = New System.Drawing.Size(100, 18)
        Me.lblCourse.Text = "Course :"

        'cmbCourse
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.Font = New System.Drawing.Font("Arial", 10)
        Me.cmbCourse.Location = New System.Drawing.Point(10, 35)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(250, 25)

        'lblSubject
        Me.lblSubject.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblSubject.Location = New System.Drawing.Point(10, 68)
        Me.lblSubject.Size = New System.Drawing.Size(100, 18)
        Me.lblSubject.Text = "Subject :"

        'cmbSubject
        Me.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubject.Font = New System.Drawing.Font("Arial", 10)
        Me.cmbSubject.Location = New System.Drawing.Point(10, 88)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(250, 25)

        'lblDate
        Me.lblDate.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblDate.Location = New System.Drawing.Point(10, 121)
        Me.lblDate.Size = New System.Drawing.Size(100, 18)
        Me.lblDate.Text = "Date :"

        'dtpDate
        Me.dtpDate.Font = New System.Drawing.Font("Arial", 10)
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDate.Location = New System.Drawing.Point(10, 141)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(250, 25)

        'btnLoadStudents
        Me.btnLoadStudents.BackColor = System.Drawing.Color.FromArgb(31, 73, 125)
        Me.btnLoadStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadStudents.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnLoadStudents.ForeColor = System.Drawing.Color.White
        Me.btnLoadStudents.Location = New System.Drawing.Point(270, 35)
        Me.btnLoadStudents.Name = "btnLoadStudents"
        Me.btnLoadStudents.Size = New System.Drawing.Size(245, 35)
        Me.btnLoadStudents.Text = "📋 Load Students"

        'btnMarkAllPresent
        Me.btnMarkAllPresent.BackColor = System.Drawing.Color.FromArgb(0, 176, 80)
        Me.btnMarkAllPresent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarkAllPresent.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.btnMarkAllPresent.ForeColor = System.Drawing.Color.White
        Me.btnMarkAllPresent.Location = New System.Drawing.Point(10, 175)
        Me.btnMarkAllPresent.Name = "btnMarkAllPresent"
        Me.btnMarkAllPresent.Size = New System.Drawing.Size(160, 35)
        Me.btnMarkAllPresent.Text = "✅ All Present"

        'btnMarkAllAbsent
        Me.btnMarkAllAbsent.BackColor = System.Drawing.Color.FromArgb(192, 0, 0)
        Me.btnMarkAllAbsent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarkAllAbsent.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.btnMarkAllAbsent.ForeColor = System.Drawing.Color.White
        Me.btnMarkAllAbsent.Location = New System.Drawing.Point(180, 175)
        Me.btnMarkAllAbsent.Name = "btnMarkAllAbsent"
        Me.btnMarkAllAbsent.Size = New System.Drawing.Size(160, 35)
        Me.btnMarkAllAbsent.Text = "❌ All Absent"

        'btnSaveAttendance
        Me.btnSaveAttendance.BackColor = System.Drawing.Color.FromArgb(0, 122, 204)
        Me.btnSaveAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAttendance.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnSaveAttendance.ForeColor = System.Drawing.Color.White
        Me.btnSaveAttendance.Location = New System.Drawing.Point(350, 175)
        Me.btnSaveAttendance.Name = "btnSaveAttendance"
        Me.btnSaveAttendance.Size = New System.Drawing.Size(165, 35)
        Me.btnSaveAttendance.Text = "💾 Save Attendance"

        'dgvAttendance
        Me.dgvAttendance.AllowUserToAddRows = False
        Me.dgvAttendance.AllowUserToDeleteRows = False
        Me.dgvAttendance.BackgroundColor = System.Drawing.Color.White
        Me.dgvAttendance.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(31, 73, 125)
        Me.dgvAttendance.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvAttendance.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.dgvAttendance.ColumnHeadersHeight = 35
        Me.dgvAttendance.Font = New System.Drawing.Font("Arial", 9)
        Me.dgvAttendance.Location = New System.Drawing.Point(10, 290)
        Me.dgvAttendance.Name = "dgvAttendance"
        Me.dgvAttendance.RowHeadersVisible = False
        Me.dgvAttendance.RowTemplate.Height = 28
        Me.dgvAttendance.Size = New System.Drawing.Size(530, 320)

        'pnlReport
        Me.pnlReport.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlReport.Location = New System.Drawing.Point(555, 60)
        Me.pnlReport.Size = New System.Drawing.Size(530, 130)
        Me.pnlReport.Controls.Add(Me.lblReportTitle)
        Me.pnlReport.Controls.Add(Me.lblReportCourse)
        Me.pnlReport.Controls.Add(Me.cmbReportCourse)
        Me.pnlReport.Controls.Add(Me.lblReportStudent)
        Me.pnlReport.Controls.Add(Me.cmbReportStudent)
        Me.pnlReport.Controls.Add(Me.btnViewReport)

        'lblReportTitle
        Me.lblReportTitle.Font = New System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold)
        Me.lblReportTitle.ForeColor = System.Drawing.Color.FromArgb(31, 73, 125)
        Me.lblReportTitle.Location = New System.Drawing.Point(10, 10)
        Me.lblReportTitle.Size = New System.Drawing.Size(300, 22)
        Me.lblReportTitle.Text = "📊 View Attendance Report"

        'lblReportCourse
        Me.lblReportCourse.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblReportCourse.Location = New System.Drawing.Point(10, 40)
        Me.lblReportCourse.Size = New System.Drawing.Size(100, 18)
        Me.lblReportCourse.Text = "Course :"

        'cmbReportCourse
        Me.cmbReportCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportCourse.Font = New System.Drawing.Font("Arial", 10)
        Me.cmbReportCourse.Location = New System.Drawing.Point(10, 60)
        Me.cmbReportCourse.Name = "cmbReportCourse"
        Me.cmbReportCourse.Size = New System.Drawing.Size(200, 25)

        'lblReportStudent
        Me.lblReportStudent.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblReportStudent.Location = New System.Drawing.Point(220, 40)
        Me.lblReportStudent.Size = New System.Drawing.Size(100, 18)
        Me.lblReportStudent.Text = "Student :"

        'cmbReportStudent
        Me.cmbReportStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportStudent.Font = New System.Drawing.Font("Arial", 10)
        Me.cmbReportStudent.Location = New System.Drawing.Point(220, 60)
        Me.cmbReportStudent.Name = "cmbReportStudent"
        Me.cmbReportStudent.Size = New System.Drawing.Size(200, 25)

        'btnViewReport
        Me.btnViewReport.BackColor = System.Drawing.Color.FromArgb(31, 73, 125)
        Me.btnViewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewReport.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnViewReport.ForeColor = System.Drawing.Color.White
        Me.btnViewReport.Location = New System.Drawing.Point(430, 55)
        Me.btnViewReport.Name = "btnViewReport"
        Me.btnViewReport.Size = New System.Drawing.Size(85, 35)
        Me.btnViewReport.Text = "View"

        'dgvReport
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.AllowUserToDeleteRows = False
        Me.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReport.BackgroundColor = System.Drawing.Color.White
        Me.dgvReport.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(31, 73, 125)
        Me.dgvReport.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvReport.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.dgvReport.ColumnHeadersHeight = 35
        Me.dgvReport.Font = New System.Drawing.Font("Arial", 9)
        Me.dgvReport.Location = New System.Drawing.Point(555, 200)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.ReadOnly = True
        Me.dgvReport.RowHeadersVisible = False
        Me.dgvReport.RowTemplate.Height = 28
        Me.dgvReport.Size = New System.Drawing.Size(530, 410)

        'frmAttendance
        Me.ClientSize = New System.Drawing.Size(1100, 630)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.dgvAttendance)
        Me.Controls.Add(Me.pnlReport)
        Me.Controls.Add(Me.dgvReport)
        Me.BackColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College ERP - Attendance Management"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        Me.pnlReport.ResumeLayout(False)
        CType(Me.dgvAttendance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblCourse As Label
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents lblSubject As Label
    Friend WithEvents cmbSubject As ComboBox
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents btnLoadStudents As Button
    Friend WithEvents btnSaveAttendance As Button
    Friend WithEvents btnMarkAllPresent As Button
    Friend WithEvents btnMarkAllAbsent As Button
    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents pnlReport As Panel
    Friend WithEvents lblReportTitle As Label
    Friend WithEvents lblReportCourse As Label
    Friend WithEvents cmbReportCourse As ComboBox
    Friend WithEvents lblReportStudent As Label
    Friend WithEvents cmbReportStudent As ComboBox
    Friend WithEvents btnViewReport As Button
    Friend WithEvents dgvReport As DataGridView

End Class