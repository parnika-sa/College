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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlEntry = New System.Windows.Forms.Panel()
        Me.lblEntryCourse = New System.Windows.Forms.Label()
        Me.cmbCourse = New System.Windows.Forms.ComboBox()
        Me.lblEntryStudent = New System.Windows.Forms.Label()
        Me.cmbStudent = New System.Windows.Forms.ComboBox()
        Me.lblEntrySubject = New System.Windows.Forms.Label()
        Me.cmbSubject = New System.Windows.Forms.ComboBox()
        Me.lblSemester = New System.Windows.Forms.Label()
        Me.cmbSemester = New System.Windows.Forms.ComboBox()
        Me.lblAcYear = New System.Windows.Forms.Label()
        Me.txtAcYear = New System.Windows.Forms.TextBox()
        Me.lblInternal = New System.Windows.Forms.Label()
        Me.txtInternal = New System.Windows.Forms.TextBox()
        Me.lblExternal = New System.Windows.Forms.Label()
        Me.txtExternal = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.btnSaveResult = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.pnlView = New System.Windows.Forms.Panel()
        Me.lblViewTitle = New System.Windows.Forms.Label()
        Me.lblViewCourse = New System.Windows.Forms.Label()
        Me.cmbViewCourse = New System.Windows.Forms.ComboBox()
        Me.lblViewStudent = New System.Windows.Forms.Label()
        Me.cmbViewStudent = New System.Windows.Forms.ComboBox()
        Me.btnViewResult = New System.Windows.Forms.Button()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.pnlHeader.SuspendLayout()
        Me.pnlEntry.SuspendLayout()
        Me.pnlView.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Text = "📝 Result Management"

        'pnlEntry
        Me.pnlEntry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEntry.Location = New System.Drawing.Point(10, 60)
        Me.pnlEntry.Size = New System.Drawing.Size(380, 550)
        Me.pnlEntry.Controls.Add(Me.lblEntryCourse)
        Me.pnlEntry.Controls.Add(Me.cmbCourse)
        Me.pnlEntry.Controls.Add(Me.lblEntryStudent)
        Me.pnlEntry.Controls.Add(Me.cmbStudent)
        Me.pnlEntry.Controls.Add(Me.lblEntrySubject)
        Me.pnlEntry.Controls.Add(Me.cmbSubject)
        Me.pnlEntry.Controls.Add(Me.lblSemester)
        Me.pnlEntry.Controls.Add(Me.cmbSemester)
        Me.pnlEntry.Controls.Add(Me.lblAcYear)
        Me.pnlEntry.Controls.Add(Me.txtAcYear)
        Me.pnlEntry.Controls.Add(Me.lblInternal)
        Me.pnlEntry.Controls.Add(Me.txtInternal)
        Me.pnlEntry.Controls.Add(Me.lblExternal)
        Me.pnlEntry.Controls.Add(Me.txtExternal)
        Me.pnlEntry.Controls.Add(Me.lblTotal)
        Me.pnlEntry.Controls.Add(Me.txtTotal)
        Me.pnlEntry.Controls.Add(Me.lblGrade)
        Me.pnlEntry.Controls.Add(Me.txtGrade)
        Me.pnlEntry.Controls.Add(Me.btnSaveResult)
        Me.pnlEntry.Controls.Add(Me.btnClear)

        'lblEntryCourse
        Me.lblEntryCourse.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblEntryCourse.Location = New System.Drawing.Point(10, 15)
        Me.lblEntryCourse.Size = New System.Drawing.Size(100, 18)
        Me.lblEntryCourse.Text = "Course :"

        'cmbCourse
        Me.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCourse.Font = New System.Drawing.Font("Arial", 10)
        Me.cmbCourse.Location = New System.Drawing.Point(10, 35)
        Me.cmbCourse.Name = "cmbCourse"
        Me.cmbCourse.Size = New System.Drawing.Size(355, 25)

        'lblEntryStudent
        Me.lblEntryStudent.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblEntryStudent.Location = New System.Drawing.Point(10, 68)
        Me.lblEntryStudent.Size = New System.Drawing.Size(100, 18)
        Me.lblEntryStudent.Text = "Student :"

        'cmbStudent
        Me.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudent.Font = New System.Drawing.Font("Arial", 10)
        Me.cmbStudent.Location = New System.Drawing.Point(10, 88)
        Me.cmbStudent.Name = "cmbStudent"
        Me.cmbStudent.Size = New System.Drawing.Size(355, 25)

        'lblEntrySubject
        Me.lblEntrySubject.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblEntrySubject.Location = New System.Drawing.Point(10, 121)
        Me.lblEntrySubject.Size = New System.Drawing.Size(100, 18)
        Me.lblEntrySubject.Text = "Subject :"

        'cmbSubject
        Me.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSubject.Font = New System.Drawing.Font("Arial", 10)
        Me.cmbSubject.Location = New System.Drawing.Point(10, 141)
        Me.cmbSubject.Name = "cmbSubject"
        Me.cmbSubject.Size = New System.Drawing.Size(355, 25)

        'lblSemester
        Me.lblSemester.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblSemester.Location = New System.Drawing.Point(10, 174)
        Me.lblSemester.Size = New System.Drawing.Size(100, 18)
        Me.lblSemester.Text = "Semester :"

        'cmbSemester
        Me.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSemester.Font = New System.Drawing.Font("Arial", 10)
        Me.cmbSemester.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cmbSemester.Location = New System.Drawing.Point(10, 194)
        Me.cmbSemester.Name = "cmbSemester"
        Me.cmbSemester.Size = New System.Drawing.Size(170, 25)

        'lblAcYear
        Me.lblAcYear.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblAcYear.Location = New System.Drawing.Point(195, 174)
        Me.lblAcYear.Size = New System.Drawing.Size(120, 18)
        Me.lblAcYear.Text = "Academic Year :"

        'txtAcYear
        Me.txtAcYear.Font = New System.Drawing.Font("Arial", 10)
        Me.txtAcYear.Location = New System.Drawing.Point(195, 194)
        Me.txtAcYear.Name = "txtAcYear"
        Me.txtAcYear.Size = New System.Drawing.Size(170, 25)
        Me.txtAcYear.Text = "2025-26"

        'lblInternal
        Me.lblInternal.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblInternal.Location = New System.Drawing.Point(10, 227)
        Me.lblInternal.Size = New System.Drawing.Size(150, 18)
        Me.lblInternal.Text = "Internal Marks (30) :"

        'txtInternal
        Me.txtInternal.Font = New System.Drawing.Font("Arial", 10)
        Me.txtInternal.Location = New System.Drawing.Point(10, 247)
        Me.txtInternal.Name = "txtInternal"
        Me.txtInternal.Size = New System.Drawing.Size(170, 25)

        'lblExternal
        Me.lblExternal.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblExternal.Location = New System.Drawing.Point(195, 227)
        Me.lblExternal.Size = New System.Drawing.Size(150, 18)
        Me.lblExternal.Text = "External Marks (70) :"

        'txtExternal
        Me.txtExternal.Font = New System.Drawing.Font("Arial", 10)
        Me.txtExternal.Location = New System.Drawing.Point(195, 247)
        Me.txtExternal.Name = "txtExternal"
        Me.txtExternal.Size = New System.Drawing.Size(170, 25)

        'lblTotal
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(10, 280)
        Me.lblTotal.Size = New System.Drawing.Size(100, 18)
        Me.lblTotal.Text = "Total Marks :"

        'txtTotal
        Me.txtTotal.BackColor = System.Drawing.Color.LightYellow
        Me.txtTotal.Font = New System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Location = New System.Drawing.Point(10, 300)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(170, 27)

        'lblGrade
        Me.lblGrade.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblGrade.Location = New System.Drawing.Point(195, 280)
        Me.lblGrade.Size = New System.Drawing.Size(100, 18)
        Me.lblGrade.Text = "Grade :"

        'txtGrade
        Me.txtGrade.BackColor = System.Drawing.Color.LightYellow
        Me.txtGrade.Font = New System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold)
        Me.txtGrade.Location = New System.Drawing.Point(195, 300)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.ReadOnly = True
        Me.txtGrade.Size = New System.Drawing.Size(170, 27)

        'btnSaveResult
        Me.btnSaveResult.BackColor = System.Drawing.Color.FromArgb(0, 176, 80)
        Me.btnSaveResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveResult.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnSaveResult.ForeColor = System.Drawing.Color.White
        Me.btnSaveResult.Location = New System.Drawing.Point(10, 350)
        Me.btnSaveResult.Name = "btnSaveResult"
        Me.btnSaveResult.Size = New System.Drawing.Size(170, 40)
        Me.btnSaveResult.Text = "💾 SAVE RESULT"

        'btnClear
        Me.btnClear.BackColor = System.Drawing.Color.Gray
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(195, 350)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(170, 40)
        Me.btnClear.Text = "🔄 CLEAR"

        'pnlView
        Me.pnlView.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlView.Location = New System.Drawing.Point(405, 60)
        Me.pnlView.Size = New System.Drawing.Size(680, 80)
        Me.pnlView.Controls.Add(Me.lblViewTitle)
        Me.pnlView.Controls.Add(Me.lblViewCourse)
        Me.pnlView.Controls.Add(Me.cmbViewCourse)
        Me.pnlView.Controls.Add(Me.lblViewStudent)
        Me.pnlView.Controls.Add(Me.cmbViewStudent)
        Me.pnlView.Controls.Add(Me.btnViewResult)

        'lblViewTitle
        Me.lblViewTitle.Font = New System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold)
        Me.lblViewTitle.ForeColor = System.Drawing.Color.FromArgb(31, 73, 125)
        Me.lblViewTitle.Location = New System.Drawing.Point(10, 8)
        Me.lblViewTitle.Size = New System.Drawing.Size(200, 22)
        Me.lblViewTitle.Text = "📊 View Results"

        'lblViewCourse
        Me.lblViewCourse.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblViewCourse.Location = New System.Drawing.Point(10, 35)
        Me.lblViewCourse.Size = New System.Drawing.Size(60, 18)
        Me.lblViewCourse.Text = "Course:"

        'cmbViewCourse
        Me.cmbViewCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbViewCourse.Font = New System.Drawing.Font("Arial", 10)
        Me.cmbViewCourse.Location = New System.Drawing.Point(75, 32)
        Me.cmbViewCourse.Name = "cmbViewCourse"
        Me.cmbViewCourse.Size = New System.Drawing.Size(180, 25)

        'lblViewStudent
        Me.lblViewStudent.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.lblViewStudent.Location = New System.Drawing.Point(265, 35)
        Me.lblViewStudent.Size = New System.Drawing.Size(65, 18)
        Me.lblViewStudent.Text = "Student:"

        'cmbViewStudent
        Me.cmbViewStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbViewStudent.Font = New System.Drawing.Font("Arial", 10)
        Me.cmbViewStudent.Location = New System.Drawing.Point(335, 32)
        Me.cmbViewStudent.Name = "cmbViewStudent"
        Me.cmbViewStudent.Size = New System.Drawing.Size(210, 25)

        'btnViewResult
        Me.btnViewResult.BackColor = System.Drawing.Color.FromArgb(31, 73, 125)
        Me.btnViewResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewResult.Font = New System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold)
        Me.btnViewResult.ForeColor = System.Drawing.Color.White
        Me.btnViewResult.Location = New System.Drawing.Point(555, 30)
        Me.btnViewResult.Name = "btnViewResult"
        Me.btnViewResult.Size = New System.Drawing.Size(110, 32)
        Me.btnViewResult.Text = "🔍 View"

        'dgvResults
        Me.dgvResults.AllowUserToAddRows = False
        Me.dgvResults.AllowUserToDeleteRows = False
        Me.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResults.BackgroundColor = System.Drawing.Color.White
        Me.dgvResults.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(31, 73, 125)
        Me.dgvResults.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvResults.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold)
        Me.dgvResults.ColumnHeadersHeight = 35
        Me.dgvResults.Font = New System.Drawing.Font("Arial", 9)
        Me.dgvResults.Location = New System.Drawing.Point(405, 150)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.ReadOnly = True
        Me.dgvResults.RowHeadersVisible = False
        Me.dgvResults.RowTemplate.Height = 28
        Me.dgvResults.Size = New System.Drawing.Size(680, 460)

        'frmResults
        Me.ClientSize = New System.Drawing.Size(1100, 630)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlEntry)
        Me.Controls.Add(Me.pnlView)
        Me.Controls.Add(Me.dgvResults)
        Me.BackColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmResults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "College ERP - Result Management"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlEntry.ResumeLayout(False)
        Me.pnlView.ResumeLayout(False)
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlEntry As Panel
    Friend WithEvents lblEntryCourse As Label
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents lblEntryStudent As Label
    Friend WithEvents cmbStudent As ComboBox
    Friend WithEvents lblEntrySubject As Label
    Friend WithEvents cmbSubject As ComboBox
    Friend WithEvents lblSemester As Label
    Friend WithEvents cmbSemester As ComboBox
    Friend WithEvents lblAcYear As Label
    Friend WithEvents txtAcYear As TextBox
    Friend WithEvents lblInternal As Label
    Friend WithEvents txtInternal As TextBox
    Friend WithEvents lblExternal As Label
    Friend WithEvents txtExternal As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblGrade As Label
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents btnSaveResult As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents pnlView As Panel
    Friend WithEvents lblViewTitle As Label
    Friend WithEvents lblViewCourse As Label
    Friend WithEvents cmbViewCourse As ComboBox
    Friend WithEvents lblViewStudent As Label
    Friend WithEvents cmbViewStudent As ComboBox
    Friend WithEvents btnViewResult As Button
    Friend WithEvents dgvResults As DataGridView

End Class