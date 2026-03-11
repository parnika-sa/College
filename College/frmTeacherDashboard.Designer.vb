<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTeacherDashboard
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnChatbot = New System.Windows.Forms.Button()       ' ← NEW
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblNavTitle = New System.Windows.Forms.Label()
        Me.btnMyProfile = New System.Windows.Forms.Button()
        Me.btnMyStudents = New System.Windows.Forms.Button()
        Me.btnMarkAttendance = New System.Windows.Forms.Button()
        Me.btnViewAttendance = New System.Windows.Forms.Button()
        Me.btnEnterResults = New System.Windows.Forms.Button()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.pnlCard1 = New System.Windows.Forms.Panel()
        Me.lblCard1Icon = New System.Windows.Forms.Label()
        Me.lblCard1Title = New System.Windows.Forms.Label()
        Me.lblMyStudents = New System.Windows.Forms.Label()
        Me.lblCard1Sub = New System.Windows.Forms.Label()
        Me.pnlCard2 = New System.Windows.Forms.Panel()
        Me.lblCard2Icon = New System.Windows.Forms.Label()
        Me.lblCard2Title = New System.Windows.Forms.Label()
        Me.lblMySubjects = New System.Windows.Forms.Label()
        Me.lblCard2Sub = New System.Windows.Forms.Label()
        Me.pnlCard3 = New System.Windows.Forms.Panel()
        Me.lblCard3Icon = New System.Windows.Forms.Label()
        Me.lblCard3Title = New System.Windows.Forms.Label()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.lblCard3Sub = New System.Windows.Forms.Label()
        Me.pnlCard4 = New System.Windows.Forms.Panel()
        Me.lblCard4Icon = New System.Windows.Forms.Label()
        Me.lblCard4Title = New System.Windows.Forms.Label()
        Me.lblTodayDate = New System.Windows.Forms.Label()
        Me.lblCard4Sub = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlTitleBar = New System.Windows.Forms.Panel()
        Me.lblContentTitle = New System.Windows.Forms.Label()
        Me.dgvMain = New System.Windows.Forms.DataGridView()

        Me.pnlTop.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlStats.SuspendLayout()
        Me.pnlCard1.SuspendLayout()
        Me.pnlCard2.SuspendLayout()
        Me.pnlCard3.SuspendLayout()
        Me.pnlCard4.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        Me.pnlTitleBar.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ══════════════════════════════
        '  HEADER
        ' ══════════════════════════════
        Me.pnlTop.BackColor = Color.FromArgb(31, 73, 125)
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Controls.Add(Me.lblWelcome)
        Me.pnlTop.Controls.Add(Me.btnChatbot)      ' ← NEW
        Me.pnlTop.Controls.Add(Me.btnLogout)
        Me.pnlTop.Dock = DockStyle.Top
        Me.pnlTop.Location = New Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New Size(984, 60)

        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.White
        Me.lblTitle.Location = New Point(15, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Text = "COLLEGE ERP SYSTEM"

        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New Font("Segoe UI", 9)
        Me.lblWelcome.ForeColor = Color.FromArgb(180, 210, 240)
        Me.lblWelcome.Location = New Point(580, 20)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Text = "Welcome, Teacher!"

        ' ── AI Assistant Button ──
        Me.btnChatbot.Text = "AI Assistant"
        Me.btnChatbot.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnChatbot.BackColor = Color.FromArgb(20, 100, 60)
        Me.btnChatbot.ForeColor = Color.White
        Me.btnChatbot.FlatStyle = FlatStyle.Flat
        Me.btnChatbot.FlatAppearance.BorderSize = 0
        Me.btnChatbot.FlatAppearance.MouseOverBackColor = Color.FromArgb(10, 80, 45)
        Me.btnChatbot.Location = New Point(755, 13)
        Me.btnChatbot.Size = New Size(120, 34)
        Me.btnChatbot.Cursor = Cursors.Hand
        Me.btnChatbot.Name = "btnChatbot"

        Me.btnLogout.BackColor = Color.FromArgb(192, 57, 43)
        Me.btnLogout.Cursor = Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = FlatStyle.Flat
        Me.btnLogout.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnLogout.ForeColor = Color.White
        Me.btnLogout.Location = New Point(885, 13)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New Size(95, 34)
        Me.btnLogout.Text = "Logout"

        ' ══════════════════════════════
        '  LEFT SIDEBAR
        ' ══════════════════════════════
        Me.pnlLeft.BackColor = Color.FromArgb(26, 32, 44)
        Me.pnlLeft.Controls.Add(Me.lblNavTitle)
        Me.pnlLeft.Controls.Add(Me.btnMyProfile)
        Me.pnlLeft.Controls.Add(Me.btnMyStudents)
        Me.pnlLeft.Controls.Add(Me.btnMarkAttendance)
        Me.pnlLeft.Controls.Add(Me.btnViewAttendance)
        Me.pnlLeft.Controls.Add(Me.btnEnterResults)
        Me.pnlLeft.Location = New Point(0, 60)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New Size(180, 560)

        Me.lblNavTitle.AutoSize = True
        Me.lblNavTitle.Font = New Font("Segoe UI", 7, FontStyle.Bold)
        Me.lblNavTitle.ForeColor = Color.FromArgb(100, 120, 150)
        Me.lblNavTitle.Location = New Point(18, 18)
        Me.lblNavTitle.Name = "lblNavTitle"
        Me.lblNavTitle.Text = "NAVIGATION"

        ' Sidebar buttons
        Dim sideButtons() As Button = {
            Me.btnMyProfile, Me.btnMyStudents, Me.btnMarkAttendance,
            Me.btnViewAttendance, Me.btnEnterResults
        }
        Dim sideTxts() As String = {
            "My Profile", "My Students", "Mark Attendance",
            "View Attendance", "Enter Results"
        }
        Dim sideNms() As String = {
            "btnMyProfile", "btnMyStudents", "btnMarkAttendance",
            "btnViewAttendance", "btnEnterResults"
        }
        For i = 0 To sideButtons.Length - 1
            sideButtons(i).Text = sideTxts(i)
            sideButtons(i).Name = sideNms(i)
            sideButtons(i).Location = New Point(0, 42 + (i * 48))
            sideButtons(i).Size = New Size(180, 46)
            sideButtons(i).BackColor = Color.FromArgb(52, 73, 94)
            sideButtons(i).ForeColor = Color.FromArgb(180, 195, 215)
            sideButtons(i).FlatStyle = FlatStyle.Flat
            sideButtons(i).FlatAppearance.BorderSize = 0
            sideButtons(i).FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 90, 115)
            sideButtons(i).Font = New Font("Segoe UI", 9, FontStyle.Bold)
            sideButtons(i).TextAlign = ContentAlignment.MiddleLeft
            sideButtons(i).Padding = New Padding(14, 0, 0, 0)
            sideButtons(i).Cursor = Cursors.Hand
        Next

        ' ══════════════════════════════
        '  STATS PANEL
        ' ══════════════════════════════
        Me.pnlStats.BackColor = Color.FromArgb(245, 247, 252)
        Me.pnlStats.Controls.Add(Me.pnlCard1)
        Me.pnlStats.Controls.Add(Me.pnlCard2)
        Me.pnlStats.Controls.Add(Me.pnlCard3)
        Me.pnlStats.Controls.Add(Me.pnlCard4)
        Me.pnlStats.Location = New Point(185, 65)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New Size(795, 135)

        ' Card 1 — My Students
        Me.pnlCard1.BackColor = Color.FromArgb(235, 245, 255)
        Me.pnlCard1.Controls.Add(Me.lblCard1Icon)
        Me.pnlCard1.Controls.Add(Me.lblCard1Title)
        Me.pnlCard1.Controls.Add(Me.lblMyStudents)
        Me.pnlCard1.Controls.Add(Me.lblCard1Sub)
        Me.pnlCard1.Location = New Point(10, 10)
        Me.pnlCard1.Name = "pnlCard1"
        Me.pnlCard1.Size = New Size(183, 112)

        Me.lblCard1Icon.AutoSize = True
        Me.lblCard1Icon.Font = New Font("Segoe UI", 16)
        Me.lblCard1Icon.Location = New Point(145, 8)
        Me.lblCard1Icon.Name = "lblCard1Icon"
        Me.lblCard1Icon.Text = "S"

        Me.lblCard1Title.AutoSize = True
        Me.lblCard1Title.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        Me.lblCard1Title.ForeColor = Color.FromArgb(100, 100, 110)
        Me.lblCard1Title.Location = New Point(10, 10)
        Me.lblCard1Title.Name = "lblCard1Title"
        Me.lblCard1Title.Text = "My Students"

        Me.lblMyStudents.Font = New Font("Segoe UI", 20, FontStyle.Bold)
        Me.lblMyStudents.ForeColor = Color.FromArgb(37, 99, 235)
        Me.lblMyStudents.Location = New Point(10, 35)
        Me.lblMyStudents.Name = "lblMyStudents"
        Me.lblMyStudents.Size = New Size(165, 40)
        Me.lblMyStudents.Text = "..."

        Me.lblCard1Sub.AutoSize = True
        Me.lblCard1Sub.Font = New Font("Segoe UI", 7)
        Me.lblCard1Sub.ForeColor = Color.Gray
        Me.lblCard1Sub.Location = New Point(10, 90)
        Me.lblCard1Sub.Name = "lblCard1Sub"
        Me.lblCard1Sub.Text = "In my dept"

        ' Card 2 — My Subjects
        Me.pnlCard2.BackColor = Color.FromArgb(232, 255, 244)
        Me.pnlCard2.Controls.Add(Me.lblCard2Icon)
        Me.pnlCard2.Controls.Add(Me.lblCard2Title)
        Me.pnlCard2.Controls.Add(Me.lblMySubjects)
        Me.pnlCard2.Controls.Add(Me.lblCard2Sub)
        Me.pnlCard2.Location = New Point(203, 10)
        Me.pnlCard2.Name = "pnlCard2"
        Me.pnlCard2.Size = New Size(183, 112)

        Me.lblCard2Icon.AutoSize = True
        Me.lblCard2Icon.Font = New Font("Segoe UI", 16)
        Me.lblCard2Icon.Location = New Point(145, 8)
        Me.lblCard2Icon.Name = "lblCard2Icon"
        Me.lblCard2Icon.Text = "B"

        Me.lblCard2Title.AutoSize = True
        Me.lblCard2Title.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        Me.lblCard2Title.ForeColor = Color.FromArgb(100, 100, 110)
        Me.lblCard2Title.Location = New Point(10, 10)
        Me.lblCard2Title.Name = "lblCard2Title"
        Me.lblCard2Title.Text = "My Subjects"

        Me.lblMySubjects.Font = New Font("Segoe UI", 20, FontStyle.Bold)
        Me.lblMySubjects.ForeColor = Color.FromArgb(5, 150, 105)
        Me.lblMySubjects.Location = New Point(10, 35)
        Me.lblMySubjects.Name = "lblMySubjects"
        Me.lblMySubjects.Size = New Size(165, 40)
        Me.lblMySubjects.Text = "..."

        Me.lblCard2Sub.AutoSize = True
        Me.lblCard2Sub.Font = New Font("Segoe UI", 7)
        Me.lblCard2Sub.ForeColor = Color.Gray
        Me.lblCard2Sub.Location = New Point(10, 90)
        Me.lblCard2Sub.Name = "lblCard2Sub"
        Me.lblCard2Sub.Text = "Assigned"

        ' Card 3 — Department
        Me.pnlCard3.BackColor = Color.FromArgb(245, 235, 255)
        Me.pnlCard3.Controls.Add(Me.lblCard3Icon)
        Me.pnlCard3.Controls.Add(Me.lblCard3Title)
        Me.pnlCard3.Controls.Add(Me.lblDept)
        Me.pnlCard3.Controls.Add(Me.lblCard3Sub)
        Me.pnlCard3.Location = New Point(396, 10)
        Me.pnlCard3.Name = "pnlCard3"
        Me.pnlCard3.Size = New Size(183, 112)

        Me.lblCard3Icon.AutoSize = True
        Me.lblCard3Icon.Font = New Font("Segoe UI", 16)
        Me.lblCard3Icon.Location = New Point(145, 8)
        Me.lblCard3Icon.Name = "lblCard3Icon"
        Me.lblCard3Icon.Text = "D"

        Me.lblCard3Title.AutoSize = True
        Me.lblCard3Title.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        Me.lblCard3Title.ForeColor = Color.FromArgb(100, 100, 110)
        Me.lblCard3Title.Location = New Point(10, 10)
        Me.lblCard3Title.Name = "lblCard3Title"
        Me.lblCard3Title.Text = "Department"

        Me.lblDept.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.lblDept.ForeColor = Color.FromArgb(142, 68, 173)
        Me.lblDept.Location = New Point(10, 35)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New Size(165, 40)
        Me.lblDept.Text = "..."

        Me.lblCard3Sub.AutoSize = True
        Me.lblCard3Sub.Font = New Font("Segoe UI", 7)
        Me.lblCard3Sub.ForeColor = Color.Gray
        Me.lblCard3Sub.Location = New Point(10, 90)
        Me.lblCard3Sub.Name = "lblCard3Sub"
        Me.lblCard3Sub.Text = "My dept"

        ' Card 4 — Today
        Me.pnlCard4.BackColor = Color.FromArgb(255, 248, 230)
        Me.pnlCard4.Controls.Add(Me.lblCard4Icon)
        Me.pnlCard4.Controls.Add(Me.lblCard4Title)
        Me.pnlCard4.Controls.Add(Me.lblTodayDate)
        Me.pnlCard4.Controls.Add(Me.lblCard4Sub)
        Me.pnlCard4.Location = New Point(589, 10)
        Me.pnlCard4.Name = "pnlCard4"
        Me.pnlCard4.Size = New Size(183, 112)

        Me.lblCard4Icon.AutoSize = True
        Me.lblCard4Icon.Font = New Font("Segoe UI", 16)
        Me.lblCard4Icon.Location = New Point(145, 8)
        Me.lblCard4Icon.Name = "lblCard4Icon"
        Me.lblCard4Icon.Text = "T"

        Me.lblCard4Title.AutoSize = True
        Me.lblCard4Title.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        Me.lblCard4Title.ForeColor = Color.FromArgb(100, 100, 110)
        Me.lblCard4Title.Location = New Point(10, 10)
        Me.lblCard4Title.Name = "lblCard4Title"
        Me.lblCard4Title.Text = "Today"

        Me.lblTodayDate.Font = New Font("Segoe UI", 20, FontStyle.Bold)
        Me.lblTodayDate.ForeColor = Color.FromArgb(31, 73, 125)
        Me.lblTodayDate.Location = New Point(10, 35)
        Me.lblTodayDate.Name = "lblTodayDate"
        Me.lblTodayDate.Size = New Size(165, 40)
        Me.lblTodayDate.Text = "..."

        Me.lblCard4Sub.AutoSize = True
        Me.lblCard4Sub.Font = New Font("Segoe UI", 7)
        Me.lblCard4Sub.ForeColor = Color.Gray
        Me.lblCard4Sub.Location = New Point(10, 90)
        Me.lblCard4Sub.Name = "lblCard4Sub"
        Me.lblCard4Sub.Text = "Date"

        ' ══════════════════════════════
        '  CONTENT PANEL
        ' ══════════════════════════════
        Me.pnlContent.BackColor = Color.White
        Me.pnlContent.Controls.Add(Me.pnlTitleBar)
        Me.pnlContent.Controls.Add(Me.dgvMain)
        Me.pnlContent.Location = New Point(185, 208)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New Size(795, 415)

        Me.pnlTitleBar.BackColor = Color.FromArgb(245, 247, 252)
        Me.pnlTitleBar.Controls.Add(Me.lblContentTitle)
        Me.pnlTitleBar.Location = New Point(0, 0)
        Me.pnlTitleBar.Name = "pnlTitleBar"
        Me.pnlTitleBar.Size = New Size(795, 40)

        Me.lblContentTitle.AutoSize = True
        Me.lblContentTitle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.lblContentTitle.ForeColor = Color.FromArgb(31, 73, 125)
        Me.lblContentTitle.Location = New Point(5, 8)
        Me.lblContentTitle.Name = "lblContentTitle"
        Me.lblContentTitle.Text = "  My Students"

        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMain.BackgroundColor = Color.White
        Me.dgvMain.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.BackColor = Color.FromArgb(31, 73, 125)
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        Me.dgvMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMain.ColumnHeadersHeight = 38
        Me.dgvMain.EnableHeadersVisualStyles = False
        Me.dgvMain.Font = New Font("Segoe UI", 9)
        Me.dgvMain.GridColor = Color.FromArgb(220, 225, 235)
        Me.dgvMain.Location = New Point(0, 40)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersVisible = False
        Me.dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New Size(795, 375)

        ' ══════════════════════════════
        '  FORM
        ' ══════════════════════════════
        Me.BackColor = Color.FromArgb(245, 247, 252)
        Me.ClientSize = New Size(984, 630)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.pnlContent)
        Me.Font = New Font("Segoe UI", 9)
        Me.MinimumSize = New Size(900, 600)
        Me.Name = "frmTeacherDashboard"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "College ERP - Teacher Dashboard"

        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlLeft.PerformLayout()
        Me.pnlStats.ResumeLayout(False)
        Me.pnlCard1.ResumeLayout(False)
        Me.pnlCard1.PerformLayout()
        Me.pnlCard2.ResumeLayout(False)
        Me.pnlCard2.PerformLayout()
        Me.pnlCard3.ResumeLayout(False)
        Me.pnlCard3.PerformLayout()
        Me.pnlCard4.ResumeLayout(False)
        Me.pnlCard4.PerformLayout()
        Me.pnlContent.ResumeLayout(False)
        Me.pnlTitleBar.ResumeLayout(False)
        Me.pnlTitleBar.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnChatbot As Button          ' ← NEW
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents lblNavTitle As Label
    Friend WithEvents btnMyProfile As Button
    Friend WithEvents btnMyStudents As Button
    Friend WithEvents btnMarkAttendance As Button
    Friend WithEvents btnViewAttendance As Button
    Friend WithEvents btnEnterResults As Button
    Friend WithEvents pnlStats As Panel
    Friend WithEvents pnlCard1 As Panel
    Friend WithEvents lblCard1Icon As Label
    Friend WithEvents lblCard1Title As Label
    Friend WithEvents lblMyStudents As Label
    Friend WithEvents lblCard1Sub As Label
    Friend WithEvents pnlCard2 As Panel
    Friend WithEvents lblCard2Icon As Label
    Friend WithEvents lblCard2Title As Label
    Friend WithEvents lblMySubjects As Label
    Friend WithEvents lblCard2Sub As Label
    Friend WithEvents pnlCard3 As Panel
    Friend WithEvents lblCard3Icon As Label
    Friend WithEvents lblCard3Title As Label
    Friend WithEvents lblDept As Label
    Friend WithEvents lblCard3Sub As Label
    Friend WithEvents pnlCard4 As Panel
    Friend WithEvents lblCard4Icon As Label
    Friend WithEvents lblCard4Title As Label
    Friend WithEvents lblTodayDate As Label
    Friend WithEvents lblCard4Sub As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlTitleBar As Panel
    Friend WithEvents lblContentTitle As Label
    Friend WithEvents dgvMain As DataGridView

End Class