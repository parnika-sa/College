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
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Controls.Add(Me.lblWelcome)
        Me.pnlTop.Controls.Add(Me.btnLogout)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(984, 60)
        Me.pnlTop.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(15, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(209, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "COLLEGE ERP SYSTEM"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblWelcome.Location = New System.Drawing.Point(680, 20)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(107, 15)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome, Teacher!"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(885, 13)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(95, 34)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlLeft
        '
        Me.pnlLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.pnlLeft.Controls.Add(Me.lblNavTitle)
        Me.pnlLeft.Controls.Add(Me.btnMyProfile)
        Me.pnlLeft.Controls.Add(Me.btnMyStudents)
        Me.pnlLeft.Controls.Add(Me.btnMarkAttendance)
        Me.pnlLeft.Controls.Add(Me.btnViewAttendance)
        Me.pnlLeft.Controls.Add(Me.btnEnterResults)
        Me.pnlLeft.Location = New System.Drawing.Point(0, 60)
        Me.pnlLeft.Name = "pnlLeft"
        Me.pnlLeft.Size = New System.Drawing.Size(180, 560)
        Me.pnlLeft.TabIndex = 1
        '
        'lblNavTitle
        '
        Me.lblNavTitle.AutoSize = True
        Me.lblNavTitle.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblNavTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblNavTitle.Location = New System.Drawing.Point(18, 18)
        Me.lblNavTitle.Name = "lblNavTitle"
        Me.lblNavTitle.Size = New System.Drawing.Size(67, 12)
        Me.lblNavTitle.TabIndex = 0
        Me.lblNavTitle.Text = "NAVIGATION"
        '
        'btnMyProfile
        '
        Me.btnMyProfile.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnMyProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyProfile.FlatAppearance.BorderSize = 0
        Me.btnMyProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyProfile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnMyProfile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnMyProfile.Location = New System.Drawing.Point(0, 42)
        Me.btnMyProfile.Name = "btnMyProfile"
        Me.btnMyProfile.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnMyProfile.Size = New System.Drawing.Size(180, 46)
        Me.btnMyProfile.TabIndex = 1
        Me.btnMyProfile.Text = "My Profile"
        Me.btnMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMyProfile.UseVisualStyleBackColor = False
        '
        'btnMyStudents
        '
        Me.btnMyStudents.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnMyStudents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMyStudents.FlatAppearance.BorderSize = 0
        Me.btnMyStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnMyStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMyStudents.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnMyStudents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnMyStudents.Location = New System.Drawing.Point(0, 94)
        Me.btnMyStudents.Name = "btnMyStudents"
        Me.btnMyStudents.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnMyStudents.Size = New System.Drawing.Size(180, 46)
        Me.btnMyStudents.TabIndex = 2
        Me.btnMyStudents.Text = "My Students"
        Me.btnMyStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMyStudents.UseVisualStyleBackColor = False
        '
        'btnMarkAttendance
        '
        Me.btnMarkAttendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnMarkAttendance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMarkAttendance.FlatAppearance.BorderSize = 0
        Me.btnMarkAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnMarkAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarkAttendance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnMarkAttendance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnMarkAttendance.Location = New System.Drawing.Point(0, 146)
        Me.btnMarkAttendance.Name = "btnMarkAttendance"
        Me.btnMarkAttendance.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnMarkAttendance.Size = New System.Drawing.Size(180, 46)
        Me.btnMarkAttendance.TabIndex = 3
        Me.btnMarkAttendance.Text = "Mark Attendance"
        Me.btnMarkAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarkAttendance.UseVisualStyleBackColor = False
        '
        'btnViewAttendance
        '
        Me.btnViewAttendance.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnViewAttendance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewAttendance.FlatAppearance.BorderSize = 0
        Me.btnViewAttendance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnViewAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAttendance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewAttendance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnViewAttendance.Location = New System.Drawing.Point(0, 198)
        Me.btnViewAttendance.Name = "btnViewAttendance"
        Me.btnViewAttendance.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnViewAttendance.Size = New System.Drawing.Size(180, 46)
        Me.btnViewAttendance.TabIndex = 4
        Me.btnViewAttendance.Text = "View Attendance"
        Me.btnViewAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewAttendance.UseVisualStyleBackColor = False
        '
        'btnEnterResults
        '
        Me.btnEnterResults.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnEnterResults.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnterResults.FlatAppearance.BorderSize = 0
        Me.btnEnterResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.btnEnterResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnterResults.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnEnterResults.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.btnEnterResults.Location = New System.Drawing.Point(0, 250)
        Me.btnEnterResults.Name = "btnEnterResults"
        Me.btnEnterResults.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
        Me.btnEnterResults.Size = New System.Drawing.Size(180, 46)
        Me.btnEnterResults.TabIndex = 5
        Me.btnEnterResults.Text = "Enter Results"
        Me.btnEnterResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnterResults.UseVisualStyleBackColor = False
        '
        'pnlStats
        '
        Me.pnlStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlStats.Controls.Add(Me.pnlCard1)
        Me.pnlStats.Controls.Add(Me.pnlCard2)
        Me.pnlStats.Controls.Add(Me.pnlCard3)
        Me.pnlStats.Controls.Add(Me.pnlCard4)
        Me.pnlStats.Location = New System.Drawing.Point(185, 65)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(795, 135)
        Me.pnlStats.TabIndex = 2
        '
        'pnlCard1
        '
        Me.pnlCard1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlCard1.Controls.Add(Me.lblCard1Icon)
        Me.pnlCard1.Controls.Add(Me.lblCard1Title)
        Me.pnlCard1.Controls.Add(Me.lblMyStudents)
        Me.pnlCard1.Controls.Add(Me.lblCard1Sub)
        Me.pnlCard1.Location = New System.Drawing.Point(10, 10)
        Me.pnlCard1.Name = "pnlCard1"
        Me.pnlCard1.Size = New System.Drawing.Size(183, 112)
        Me.pnlCard1.TabIndex = 0
        '
        'lblCard1Icon
        '
        Me.lblCard1Icon.AutoSize = True
        Me.lblCard1Icon.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lblCard1Icon.Location = New System.Drawing.Point(145, 8)
        Me.lblCard1Icon.Name = "lblCard1Icon"
        Me.lblCard1Icon.Size = New System.Drawing.Size(25, 30)
        Me.lblCard1Icon.TabIndex = 0
        Me.lblCard1Icon.Text = "S"
        '
        'lblCard1Title
        '
        Me.lblCard1Title.AutoSize = True
        Me.lblCard1Title.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard1Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblCard1Title.Location = New System.Drawing.Point(10, 10)
        Me.lblCard1Title.Name = "lblCard1Title"
        Me.lblCard1Title.Size = New System.Drawing.Size(73, 13)
        Me.lblCard1Title.TabIndex = 1
        Me.lblCard1Title.Text = "My Students"
        '
        'lblMyStudents
        '
        Me.lblMyStudents.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblMyStudents.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblMyStudents.Location = New System.Drawing.Point(10, 35)
        Me.lblMyStudents.Name = "lblMyStudents"
        Me.lblMyStudents.Size = New System.Drawing.Size(165, 40)
        Me.lblMyStudents.TabIndex = 2
        Me.lblMyStudents.Text = "..."
        '
        'lblCard1Sub
        '
        Me.lblCard1Sub.AutoSize = True
        Me.lblCard1Sub.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.lblCard1Sub.ForeColor = System.Drawing.Color.Gray
        Me.lblCard1Sub.Location = New System.Drawing.Point(10, 90)
        Me.lblCard1Sub.Name = "lblCard1Sub"
        Me.lblCard1Sub.Size = New System.Drawing.Size(54, 12)
        Me.lblCard1Sub.TabIndex = 3
        Me.lblCard1Sub.Text = "In my dept"
        '
        'pnlCard2
        '
        Me.pnlCard2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.pnlCard2.Controls.Add(Me.lblCard2Icon)
        Me.pnlCard2.Controls.Add(Me.lblCard2Title)
        Me.pnlCard2.Controls.Add(Me.lblMySubjects)
        Me.pnlCard2.Controls.Add(Me.lblCard2Sub)
        Me.pnlCard2.Location = New System.Drawing.Point(203, 10)
        Me.pnlCard2.Name = "pnlCard2"
        Me.pnlCard2.Size = New System.Drawing.Size(183, 112)
        Me.pnlCard2.TabIndex = 1
        '
        'lblCard2Icon
        '
        Me.lblCard2Icon.AutoSize = True
        Me.lblCard2Icon.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lblCard2Icon.Location = New System.Drawing.Point(145, 8)
        Me.lblCard2Icon.Name = "lblCard2Icon"
        Me.lblCard2Icon.Size = New System.Drawing.Size(26, 30)
        Me.lblCard2Icon.TabIndex = 0
        Me.lblCard2Icon.Text = "B"
        '
        'lblCard2Title
        '
        Me.lblCard2Title.AutoSize = True
        Me.lblCard2Title.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard2Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblCard2Title.Location = New System.Drawing.Point(10, 10)
        Me.lblCard2Title.Name = "lblCard2Title"
        Me.lblCard2Title.Size = New System.Drawing.Size(70, 13)
        Me.lblCard2Title.TabIndex = 1
        Me.lblCard2Title.Text = "My Subjects"
        '
        'lblMySubjects
        '
        Me.lblMySubjects.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblMySubjects.ForeColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblMySubjects.Location = New System.Drawing.Point(10, 35)
        Me.lblMySubjects.Name = "lblMySubjects"
        Me.lblMySubjects.Size = New System.Drawing.Size(165, 40)
        Me.lblMySubjects.TabIndex = 2
        Me.lblMySubjects.Text = "..."
        '
        'lblCard2Sub
        '
        Me.lblCard2Sub.AutoSize = True
        Me.lblCard2Sub.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.lblCard2Sub.ForeColor = System.Drawing.Color.Gray
        Me.lblCard2Sub.Location = New System.Drawing.Point(10, 90)
        Me.lblCard2Sub.Name = "lblCard2Sub"
        Me.lblCard2Sub.Size = New System.Drawing.Size(44, 12)
        Me.lblCard2Sub.TabIndex = 3
        Me.lblCard2Sub.Text = "Assigned"
        '
        'pnlCard3
        '
        Me.pnlCard3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlCard3.Controls.Add(Me.lblCard3Icon)
        Me.pnlCard3.Controls.Add(Me.lblCard3Title)
        Me.pnlCard3.Controls.Add(Me.lblDept)
        Me.pnlCard3.Controls.Add(Me.lblCard3Sub)
        Me.pnlCard3.Location = New System.Drawing.Point(396, 10)
        Me.pnlCard3.Name = "pnlCard3"
        Me.pnlCard3.Size = New System.Drawing.Size(183, 112)
        Me.pnlCard3.TabIndex = 2
        '
        'lblCard3Icon
        '
        Me.lblCard3Icon.AutoSize = True
        Me.lblCard3Icon.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lblCard3Icon.Location = New System.Drawing.Point(145, 8)
        Me.lblCard3Icon.Name = "lblCard3Icon"
        Me.lblCard3Icon.Size = New System.Drawing.Size(28, 30)
        Me.lblCard3Icon.TabIndex = 0
        Me.lblCard3Icon.Text = "D"
        '
        'lblCard3Title
        '
        Me.lblCard3Title.AutoSize = True
        Me.lblCard3Title.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard3Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblCard3Title.Location = New System.Drawing.Point(10, 10)
        Me.lblCard3Title.Name = "lblCard3Title"
        Me.lblCard3Title.Size = New System.Drawing.Size(69, 13)
        Me.lblCard3Title.TabIndex = 1
        Me.lblCard3Title.Text = "Department"
        '
        'lblDept
        '
        Me.lblDept.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lblDept.ForeColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.lblDept.Location = New System.Drawing.Point(10, 35)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(165, 40)
        Me.lblDept.TabIndex = 2
        Me.lblDept.Text = "..."
        '
        'lblCard3Sub
        '
        Me.lblCard3Sub.AutoSize = True
        Me.lblCard3Sub.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.lblCard3Sub.ForeColor = System.Drawing.Color.Gray
        Me.lblCard3Sub.Location = New System.Drawing.Point(10, 90)
        Me.lblCard3Sub.Name = "lblCard3Sub"
        Me.lblCard3Sub.Size = New System.Drawing.Size(42, 12)
        Me.lblCard3Sub.TabIndex = 3
        Me.lblCard3Sub.Text = "My dept"
        '
        'pnlCard4
        '
        Me.pnlCard4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.pnlCard4.Controls.Add(Me.lblCard4Icon)
        Me.pnlCard4.Controls.Add(Me.lblCard4Title)
        Me.pnlCard4.Controls.Add(Me.lblTodayDate)
        Me.pnlCard4.Controls.Add(Me.lblCard4Sub)
        Me.pnlCard4.Location = New System.Drawing.Point(589, 10)
        Me.pnlCard4.Name = "pnlCard4"
        Me.pnlCard4.Size = New System.Drawing.Size(183, 112)
        Me.pnlCard4.TabIndex = 3
        '
        'lblCard4Icon
        '
        Me.lblCard4Icon.AutoSize = True
        Me.lblCard4Icon.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lblCard4Icon.Location = New System.Drawing.Point(145, 8)
        Me.lblCard4Icon.Name = "lblCard4Icon"
        Me.lblCard4Icon.Size = New System.Drawing.Size(25, 30)
        Me.lblCard4Icon.TabIndex = 0
        Me.lblCard4Icon.Text = "T"
        '
        'lblCard4Title
        '
        Me.lblCard4Title.AutoSize = True
        Me.lblCard4Title.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCard4Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.lblCard4Title.Location = New System.Drawing.Point(10, 10)
        Me.lblCard4Title.Name = "lblCard4Title"
        Me.lblCard4Title.Size = New System.Drawing.Size(38, 13)
        Me.lblCard4Title.TabIndex = 1
        Me.lblCard4Title.Text = "Today"
        '
        'lblTodayDate
        '
        Me.lblTodayDate.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTodayDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblTodayDate.Location = New System.Drawing.Point(10, 35)
        Me.lblTodayDate.Name = "lblTodayDate"
        Me.lblTodayDate.Size = New System.Drawing.Size(165, 40)
        Me.lblTodayDate.TabIndex = 2
        Me.lblTodayDate.Text = "..."
        '
        'lblCard4Sub
        '
        Me.lblCard4Sub.AutoSize = True
        Me.lblCard4Sub.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.lblCard4Sub.ForeColor = System.Drawing.Color.Gray
        Me.lblCard4Sub.Location = New System.Drawing.Point(10, 90)
        Me.lblCard4Sub.Name = "lblCard4Sub"
        Me.lblCard4Sub.Size = New System.Drawing.Size(25, 12)
        Me.lblCard4Sub.TabIndex = 3
        Me.lblCard4Sub.Text = "Date"
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.White
        Me.pnlContent.Controls.Add(Me.pnlTitleBar)
        Me.pnlContent.Controls.Add(Me.dgvMain)
        Me.pnlContent.Location = New System.Drawing.Point(185, 208)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(795, 415)
        Me.pnlContent.TabIndex = 3
        '
        'pnlTitleBar
        '
        Me.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.pnlTitleBar.Controls.Add(Me.lblContentTitle)
        Me.pnlTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitleBar.Name = "pnlTitleBar"
        Me.pnlTitleBar.Size = New System.Drawing.Size(795, 40)
        Me.pnlTitleBar.TabIndex = 0
        '
        'lblContentTitle
        '
        Me.lblContentTitle.AutoSize = True
        Me.lblContentTitle.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblContentTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.lblContentTitle.Location = New System.Drawing.Point(5, 8)
        Me.lblContentTitle.Name = "lblContentTitle"
        Me.lblContentTitle.Size = New System.Drawing.Size(105, 20)
        Me.lblContentTitle.TabIndex = 0
        Me.lblContentTitle.Text = "  My Students"
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMain.BackgroundColor = System.Drawing.Color.White
        Me.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMain.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMain.ColumnHeadersHeight = 38
        Me.dgvMain.EnableHeadersVisualStyles = False
        Me.dgvMain.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvMain.GridColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.dgvMain.Location = New System.Drawing.Point(0, 40)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersVisible = False
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(795, 375)
        Me.dgvMain.TabIndex = 1
        '
        'frmTeacherDashboard
        '
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 630)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.pnlContent)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "frmTeacherDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
