<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminDashboard
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

        ' ── Controls ─────────────────────────────────────────────────
        Me.pnlAccent      = New Panel()
        Me.pnlHeader      = New Panel()
        Me.pnlLogoWrap    = New Panel()
        Me.lblLogoIcon    = New Label()
        Me.lblSystemName  = New Label()
        Me.lblSystemSub   = New Label()
        Me.lblWelcome     = New Label()
        Me.btnChatbot     = New Button()
        Me.btnHamburger   = New Button()
        Me.btnLogout      = New Button()

        Me.pnlSidebar     = New Panel()
        Me.lblMenuTitle   = New Label()
        Me.btnStudents    = New Button()
        Me.btnTeachers    = New Button()
        Me.btnAttendance  = New Button()
        Me.btnResults     = New Button()
        Me.btnFees        = New Button()

        Me.pnlMain        = New Panel()

        Me.pnlCard1       = New Panel()
        Me.lblCard1Icon   = New Label()
        Me.lblCard1Title  = New Label()
        Me.lblStudentCount = New Label()
        Me.lblCard1Sub    = New Label()

        Me.pnlCard2       = New Panel()
        Me.lblCard2Icon   = New Label()
        Me.lblCard2Title  = New Label()
        Me.lblTeacherCount = New Label()
        Me.lblCard2Sub    = New Label()

        Me.pnlCard3       = New Panel()
        Me.lblCard3Icon   = New Label()
        Me.lblCard3Title  = New Label()
        Me.lblFeesAmount  = New Label()
        Me.lblCard3Sub    = New Label()

        Me.pnlCard4       = New Panel()
        Me.lblCard4Icon   = New Label()
        Me.lblCard4Title  = New Label()
        Me.lblPendingAmount = New Label()
        Me.lblCard4Sub    = New Label()

        Me.pnlSearch      = New Panel()
        Me.lblSearchTitle = New Label()
        Me.lblSearchStudent = New Label()
        Me.txtStudentId   = New TextBox()
        Me.btnSearchStudent = New Button()
        Me.lblSearchTeacher = New Label()
        Me.txtTeacherId   = New TextBox()
        Me.btnSearchTeacher = New Button()

        Me.pnlInfo        = New Panel()
        Me.dgvInfo        = New DataGridView()

        Me.pnlHeader.SuspendLayout()
        Me.pnlLogoWrap.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ════════════════════════════════════════════════════════════
        '  ACCENT STRIP (indigo top bar)
        ' ════════════════════════════════════════════════════════════
        Me.pnlAccent.BackColor = Color.FromArgb(99, 102, 241)
        Me.pnlAccent.Dock      = DockStyle.Top
        Me.pnlAccent.Height    = 3

        ' ════════════════════════════════════════════════════════════
        '  HEADER  — deep slate
        ' ════════════════════════════════════════════════════════════
        Me.pnlHeader.BackColor = Color.FromArgb(15, 23, 42)
        Me.pnlHeader.Dock      = DockStyle.Top
        Me.pnlHeader.Height    = 68
        Me.pnlHeader.Controls.AddRange(New Control() {
            Me.pnlAccent, Me.btnHamburger, Me.pnlLogoWrap,
            Me.lblWelcome, Me.btnChatbot, Me.btnLogout
        })

        ' Hamburger
        Me.btnHamburger.Text                          = "☰"
        Me.btnHamburger.Font                          = New Font("Segoe UI", 15, FontStyle.Bold)
        Me.btnHamburger.ForeColor                     = Color.FromArgb(148, 163, 184)
        Me.btnHamburger.BackColor                     = Color.Transparent
        Me.btnHamburger.FlatStyle                     = FlatStyle.Flat
        Me.btnHamburger.FlatAppearance.BorderSize     = 0
        Me.btnHamburger.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59)
        Me.btnHamburger.Location                      = New Point(8, 14)
        Me.btnHamburger.Size                          = New Size(42, 38)
        Me.btnHamburger.Cursor                        = Cursors.Hand
        Me.btnHamburger.Name                          = "btnHamburger"

        ' Logo wrapper
        Me.pnlLogoWrap.BackColor  = Color.Transparent
        Me.pnlLogoWrap.Location   = New Point(56, 10)
        Me.pnlLogoWrap.Size       = New Size(320, 46)
        Me.pnlLogoWrap.Controls.AddRange(New Control() {Me.lblLogoIcon, Me.lblSystemName, Me.lblSystemSub})

        Me.lblLogoIcon.Text      = "🎓"
        Me.lblLogoIcon.Font      = New Font("Segoe UI Emoji", 20)
        Me.lblLogoIcon.Location  = New Point(0, 4)
        Me.lblLogoIcon.Size      = New Size(38, 36)
        Me.lblLogoIcon.TextAlign = ContentAlignment.MiddleCenter
        Me.lblLogoIcon.BackColor = Color.Transparent

        Me.lblSystemName.Text      = "College ERP"
        Me.lblSystemName.Font      = New Font("Segoe UI", 14, FontStyle.Bold)
        Me.lblSystemName.ForeColor = Color.White
        Me.lblSystemName.Location  = New Point(44, 6)
        Me.lblSystemName.Size      = New Size(250, 24)
        Me.lblSystemName.BackColor = Color.Transparent

        Me.lblSystemSub.Text      = "Admin Dashboard"
        Me.lblSystemSub.Font      = New Font("Segoe UI", 8)
        Me.lblSystemSub.ForeColor = Color.FromArgb(99, 102, 241)
        Me.lblSystemSub.Location  = New Point(46, 30)
        Me.lblSystemSub.Size      = New Size(200, 14)
        Me.lblSystemSub.BackColor = Color.Transparent

        ' Welcome label (centre-right area)
        Me.lblWelcome.Text      = "Welcome, Admin!"
        Me.lblWelcome.Font      = New Font("Segoe UI", 9)
        Me.lblWelcome.ForeColor = Color.FromArgb(100, 116, 139)
        Me.lblWelcome.Location  = New Point(500, 26)
        Me.lblWelcome.AutoSize  = True
        Me.lblWelcome.BackColor = Color.Transparent
        Me.lblWelcome.Name      = "lblWelcome"

        ' AI Chatbot button
        Me.btnChatbot.Text                          = "🤖  AI Assistant"
        Me.btnChatbot.Font                          = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnChatbot.BackColor                     = Color.FromArgb(99, 102, 241)
        Me.btnChatbot.ForeColor                     = Color.White
        Me.btnChatbot.FlatStyle                     = FlatStyle.Flat
        Me.btnChatbot.FlatAppearance.BorderSize     = 0
        Me.btnChatbot.FlatAppearance.MouseOverBackColor = Color.FromArgb(79, 70, 229)
        Me.btnChatbot.Location                      = New Point(740, 16)
        Me.btnChatbot.Size                          = New Size(140, 36)
        Me.btnChatbot.Cursor                        = Cursors.Hand
        Me.btnChatbot.Name                          = "btnChatbot"

        ' Logout button
        Me.btnLogout.Text                           = "Logout"
        Me.btnLogout.Font                           = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnLogout.BackColor                      = Color.FromArgb(239, 68, 68)
        Me.btnLogout.ForeColor                      = Color.White
        Me.btnLogout.FlatStyle                      = FlatStyle.Flat
        Me.btnLogout.FlatAppearance.BorderSize      = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(185, 28, 28)
        Me.btnLogout.Location                       = New Point(892, 16)
        Me.btnLogout.Size                           = New Size(95, 36)
        Me.btnLogout.Cursor                         = Cursors.Hand
        Me.btnLogout.Name                           = "btnLogout"

        ' ════════════════════════════════════════════════════════════
        '  SIDEBAR  — dark slate with emoji nav icons
        ' ════════════════════════════════════════════════════════════
        Me.pnlSidebar.BackColor = Color.FromArgb(15, 23, 42)
        Me.pnlSidebar.Location  = New Point(0, 71)
        Me.pnlSidebar.Size      = New Size(210, 629)
        Me.pnlSidebar.Controls.AddRange(New Control() {
            Me.lblMenuTitle,
            Me.btnStudents, Me.btnTeachers,
            Me.btnAttendance, Me.btnResults, Me.btnFees
        })

        Me.lblMenuTitle.Text      = "  MENU"
        Me.lblMenuTitle.Font      = New Font("Segoe UI", 7, FontStyle.Bold)
        Me.lblMenuTitle.ForeColor = Color.FromArgb(71, 85, 105)
        Me.lblMenuTitle.Location  = New Point(0, 14)
        Me.lblMenuTitle.Size      = New Size(210, 18)
        Me.lblMenuTitle.Name      = "lblMenuTitle"

        Dim sideButtons() As Button = {
            Me.btnStudents, Me.btnTeachers,
            Me.btnAttendance, Me.btnResults, Me.btnFees
        }
        Dim sideTexts() As String = {
            "👥  Students", "🧑‍🏫  Teachers",
            "📋  Attendance", "📊  Results", "💰  Fees"
        }
        Dim sideNames() As String = {
            "btnStudents", "btnTeachers",
            "btnAttendance", "btnResults", "btnFees"
        }
        For i = 0 To sideButtons.Length - 1
            sideButtons(i).Text      = sideTexts(i)
            sideButtons(i).Name      = sideNames(i)
            sideButtons(i).Location  = New Point(0, 38 + (i * 52))
            sideButtons(i).Size      = New Size(210, 48)
            sideButtons(i).BackColor = Color.FromArgb(15, 23, 42)
            sideButtons(i).ForeColor = Color.FromArgb(148, 163, 184)
            sideButtons(i).FlatStyle = FlatStyle.Flat
            sideButtons(i).FlatAppearance.BorderSize = 0
            sideButtons(i).FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 41, 59)
            sideButtons(i).Font      = New Font("Segoe UI", 10)
            sideButtons(i).TextAlign = ContentAlignment.MiddleLeft
            sideButtons(i).Padding   = New Padding(14, 0, 0, 0)
            sideButtons(i).Cursor    = Cursors.Hand
        Next

        ' ════════════════════════════════════════════════════════════
        '  MAIN PANEL
        ' ════════════════════════════════════════════════════════════
        Me.pnlMain.BackColor = Color.FromArgb(15, 23, 42)
        Me.pnlMain.Location  = New Point(210, 71)
        Me.pnlMain.Size      = New Size(790, 629)
        Me.pnlMain.Controls.AddRange(New Control() {
            Me.pnlCard1, Me.pnlCard2, Me.pnlCard3, Me.pnlCard4,
            Me.pnlSearch, Me.pnlInfo
        })

        ' ── Stat Cards ────────────────────────────────────────────
        Dim cards()  As Panel  = {Me.pnlCard1, Me.pnlCard2, Me.pnlCard3, Me.pnlCard4}
        Dim icons()  As Label  = {Me.lblCard1Icon,  Me.lblCard2Icon,  Me.lblCard3Icon,  Me.lblCard4Icon}
        Dim titles() As Label  = {Me.lblCard1Title, Me.lblCard2Title, Me.lblCard3Title, Me.lblCard4Title}
        Dim values() As Label  = {Me.lblStudentCount, Me.lblTeacherCount, Me.lblFeesAmount, Me.lblPendingAmount}
        Dim subs()   As Label  = {Me.lblCard1Sub,   Me.lblCard2Sub,   Me.lblCard3Sub,   Me.lblCard4Sub}

        Dim iconTexts()   As String = {"👥", "🧑‍🏫", "💵", "⏳"}
        Dim titleTexts()  As String = {"Total Students", "Total Teachers", "Fees Collected", "Fees Pending"}
        Dim subTexts()    As String = {"Enrolled students", "Active staff", "Amount received", "Amount due"}
        Dim valueNames()  As String = {"lblStudentCount", "lblTeacherCount", "lblFeesAmount", "lblPendingAmount"}

        Dim cardBg() As Color = {
            Color.FromArgb(30, 27, 75),
            Color.FromArgb(6, 46, 38),
            Color.FromArgb(6, 46, 38),
            Color.FromArgb(69, 10, 10)
        }
        Dim accentColors() As Color = {
            Color.FromArgb(129, 140, 248),
            Color.FromArgb(52, 211, 153),
            Color.FromArgb(52, 211, 153),
            Color.FromArgb(252, 165, 165)
        }

        For i = 0 To 3
            cards(i).BackColor = cardBg(i)
            cards(i).Location  = New Point(14 + (i * 190), 16)
            cards(i).Size      = New Size(178, 118)
            cards(i).Controls.AddRange(New Control() {icons(i), titles(i), values(i), subs(i)})

            icons(i).Text      = iconTexts(i)
            icons(i).Font      = New Font("Segoe UI Emoji", 18)
            icons(i).Location  = New Point(130, 10)
            icons(i).Size      = New Size(40, 36)
            icons(i).TextAlign = ContentAlignment.MiddleCenter
            icons(i).BackColor = Color.Transparent

            titles(i).Text      = titleTexts(i)
            titles(i).Font      = New Font("Segoe UI", 8, FontStyle.Bold)
            titles(i).ForeColor = accentColors(i)
            titles(i).Location  = New Point(12, 12)
            titles(i).Size      = New Size(155, 16)
            titles(i).BackColor = Color.Transparent

            values(i).Text      = "0"
            values(i).Name      = valueNames(i)
            values(i).Font      = New Font("Segoe UI", 22, FontStyle.Bold)
            values(i).ForeColor = Color.White
            values(i).Location  = New Point(12, 34)
            values(i).Size      = New Size(155, 44)
            values(i).AutoSize  = False
            values(i).BackColor = Color.Transparent

            subs(i).Text      = subTexts(i)
            subs(i).Font      = New Font("Segoe UI", 7.5)
            subs(i).ForeColor = Color.FromArgb(100, 116, 139)
            subs(i).Location  = New Point(12, 88)
            subs(i).Size      = New Size(155, 16)
            subs(i).BackColor = Color.Transparent
        Next

        ' ════════════════════════════════════════════════════════════
        '  SEARCH PANEL
        ' ════════════════════════════════════════════════════════════
        Me.pnlSearch.BackColor = Color.FromArgb(22, 33, 55)
        Me.pnlSearch.Location  = New Point(14, 148)
        Me.pnlSearch.Size      = New Size(762, 90)
        Me.pnlSearch.Controls.AddRange(New Control() {
            Me.lblSearchTitle,
            Me.lblSearchStudent, Me.txtStudentId, Me.btnSearchStudent,
            Me.lblSearchTeacher, Me.txtTeacherId, Me.btnSearchTeacher
        })

        Me.lblSearchTitle.Text      = "🔍  Quick Search"
        Me.lblSearchTitle.Font      = New Font("Segoe UI", 10, FontStyle.Bold)
        Me.lblSearchTitle.ForeColor = Color.FromArgb(148, 163, 184)
        Me.lblSearchTitle.Location  = New Point(14, 10)
        Me.lblSearchTitle.AutoSize  = True
        Me.lblSearchTitle.BackColor = Color.Transparent

        Me.lblSearchStudent.Text      = "Student ID / Roll No"
        Me.lblSearchStudent.Font      = New Font("Segoe UI", 8, FontStyle.Bold)
        Me.lblSearchStudent.ForeColor = Color.FromArgb(100, 116, 139)
        Me.lblSearchStudent.Location  = New Point(14, 46)
        Me.lblSearchStudent.AutoSize  = True
        Me.lblSearchStudent.BackColor = Color.Transparent

        Me.txtStudentId.Font        = New Font("Segoe UI", 10)
        Me.txtStudentId.Location    = New Point(155, 43)
        Me.txtStudentId.Size        = New Size(130, 28)
        Me.txtStudentId.BorderStyle = BorderStyle.FixedSingle
        Me.txtStudentId.BackColor   = Color.FromArgb(30, 41, 59)
        Me.txtStudentId.ForeColor   = Color.White
        Me.txtStudentId.Name        = "txtStudentId"

        Me.btnSearchStudent.Text                         = "Search Student"
        Me.btnSearchStudent.Font                         = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnSearchStudent.BackColor                    = Color.FromArgb(99, 102, 241)
        Me.btnSearchStudent.ForeColor                    = Color.White
        Me.btnSearchStudent.FlatStyle                    = FlatStyle.Flat
        Me.btnSearchStudent.FlatAppearance.BorderSize    = 0
        Me.btnSearchStudent.FlatAppearance.MouseOverBackColor = Color.FromArgb(79, 70, 229)
        Me.btnSearchStudent.Location                     = New Point(295, 41)
        Me.btnSearchStudent.Size                         = New Size(130, 32)
        Me.btnSearchStudent.Cursor                       = Cursors.Hand
        Me.btnSearchStudent.Name                         = "btnSearchStudent"

        Me.lblSearchTeacher.Text      = "Teacher ID / Emp Code"
        Me.lblSearchTeacher.Font      = New Font("Segoe UI", 8, FontStyle.Bold)
        Me.lblSearchTeacher.ForeColor = Color.FromArgb(100, 116, 139)
        Me.lblSearchTeacher.Location  = New Point(440, 46)
        Me.lblSearchTeacher.AutoSize  = True
        Me.lblSearchTeacher.BackColor = Color.Transparent

        Me.txtTeacherId.Font        = New Font("Segoe UI", 10)
        Me.txtTeacherId.Location    = New Point(595, 43)
        Me.txtTeacherId.Size        = New Size(130, 28)
        Me.txtTeacherId.BorderStyle = BorderStyle.FixedSingle
        Me.txtTeacherId.BackColor   = Color.FromArgb(30, 41, 59)
        Me.txtTeacherId.ForeColor   = Color.White
        Me.txtTeacherId.Name        = "txtTeacherId"

        Me.btnSearchTeacher.Text                         = "Search Teacher"
        Me.btnSearchTeacher.Font                         = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnSearchTeacher.BackColor                    = Color.FromArgb(16, 185, 129)
        Me.btnSearchTeacher.ForeColor                    = Color.White
        Me.btnSearchTeacher.FlatStyle                    = FlatStyle.Flat
        Me.btnSearchTeacher.FlatAppearance.BorderSize    = 0
        Me.btnSearchTeacher.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 150, 105)
        Me.btnSearchTeacher.Location                     = New Point(735, 41)
        Me.btnSearchTeacher.Size                         = New Size(0, 32)   ' hidden — placed at edge
        Me.btnSearchTeacher.Cursor                       = Cursors.Hand
        Me.btnSearchTeacher.Name                         = "btnSearchTeacher"

        ' Reposition teacher search button to fit inside panel
        Me.btnSearchTeacher.Location = New Point(606, 41) ' overwrite
        Me.btnSearchTeacher.Size     = New Size(138, 32)
        Me.btnSearchTeacher.Location = New Point(600, 41)

        ' ════════════════════════════════════════════════════════════
        '  INFO / RESULTS PANEL
        ' ════════════════════════════════════════════════════════════
        Me.pnlInfo.BackColor = Color.FromArgb(22, 33, 55)
        Me.pnlInfo.Location  = New Point(14, 252)
        Me.pnlInfo.Size      = New Size(762, 360)
        Me.pnlInfo.Visible   = False
        Me.pnlInfo.Controls.Add(Me.dgvInfo)

        Me.dgvInfo.Location  = New Point(0, 0)
        Me.dgvInfo.Size      = New Size(762, 360)
        Me.dgvInfo.AllowUserToAddRows  = False
        Me.dgvInfo.ReadOnly            = True
        Me.dgvInfo.SelectionMode       = DataGridViewSelectionMode.FullRowSelect
        Me.dgvInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInfo.BackgroundColor     = Color.FromArgb(22, 33, 55)
        Me.dgvInfo.GridColor           = Color.FromArgb(30, 41, 59)
        Me.dgvInfo.RowHeadersVisible   = False
        Me.dgvInfo.BorderStyle         = BorderStyle.None
        Me.dgvInfo.Font                = New Font("Segoe UI", 9)
        Me.dgvInfo.ForeColor           = Color.FromArgb(226, 232, 240)
        Me.dgvInfo.RowsDefaultCellStyle.BackColor           = Color.FromArgb(22, 33, 55)
        Me.dgvInfo.RowsDefaultCellStyle.ForeColor           = Color.FromArgb(226, 232, 240)
        Me.dgvInfo.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59)
        Me.dgvInfo.ColumnHeadersDefaultCellStyle.BackColor  = Color.FromArgb(99, 102, 241)
        Me.dgvInfo.ColumnHeadersDefaultCellStyle.ForeColor  = Color.White
        Me.dgvInfo.ColumnHeadersDefaultCellStyle.Font       = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvInfo.ColumnHeadersHeight        = 36
        Me.dgvInfo.RowTemplate.Height         = 32
        Me.dgvInfo.EnableHeadersVisualStyles  = False
        Me.dgvInfo.Name                       = "dgvInfo"

        ' ════════════════════════════════════════════════════════════
        '  FORM
        ' ════════════════════════════════════════════════════════════
        Me.ClientSize      = New Size(1000, 700)
        Me.BackColor       = Color.FromArgb(15, 23, 42)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlAccent)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Controls.Add(Me.pnlMain)
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.MaximizeBox     = True
        Me.MinimumSize     = New Size(1000, 680)
        Me.Name            = "frmAdminDashboard"
        Me.StartPosition   = FormStartPosition.CenterScreen
        Me.Text            = "College ERP — Admin Dashboard"

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlLogoWrap.ResumeLayout(False)
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    ' ── Declarations ─────────────────────────────────────────────
    Friend WithEvents pnlAccent       As Panel
    Friend WithEvents pnlHeader       As Panel
    Friend WithEvents pnlLogoWrap     As Panel
    Friend WithEvents lblLogoIcon     As Label
    Friend WithEvents lblSystemName   As Label
    Friend WithEvents lblSystemSub    As Label
    Friend WithEvents lblWelcome      As Label
    Friend WithEvents btnHamburger    As Button
    Friend WithEvents btnChatbot      As Button
    Friend WithEvents btnLogout       As Button
    Friend WithEvents pnlSidebar      As Panel
    Friend WithEvents lblMenuTitle    As Label
    Friend WithEvents btnStudents     As Button
    Friend WithEvents btnTeachers     As Button
    Friend WithEvents btnAttendance   As Button
    Friend WithEvents btnResults      As Button
    Friend WithEvents btnFees         As Button
    Friend WithEvents pnlMain         As Panel
    Friend WithEvents pnlCard1        As Panel
    Friend WithEvents lblCard1Icon    As Label
    Friend WithEvents lblCard1Title   As Label
    Friend WithEvents lblStudentCount As Label
    Friend WithEvents lblCard1Sub     As Label
    Friend WithEvents pnlCard2        As Panel
    Friend WithEvents lblCard2Icon    As Label
    Friend WithEvents lblCard2Title   As Label
    Friend WithEvents lblTeacherCount As Label
    Friend WithEvents lblCard2Sub     As Label
    Friend WithEvents pnlCard3        As Panel
    Friend WithEvents lblCard3Icon    As Label
    Friend WithEvents lblCard3Title   As Label
    Friend WithEvents lblFeesAmount   As Label
    Friend WithEvents lblCard3Sub     As Label
    Friend WithEvents pnlCard4        As Panel
    Friend WithEvents lblCard4Icon    As Label
    Friend WithEvents lblCard4Title   As Label
    Friend WithEvents lblPendingAmount As Label
    Friend WithEvents lblCard4Sub     As Label
    Friend WithEvents pnlSearch       As Panel
    Friend WithEvents lblSearchTitle  As Label
    Friend WithEvents lblSearchStudent As Label
    Friend WithEvents txtStudentId    As TextBox
    Friend WithEvents btnSearchStudent As Button
    Friend WithEvents lblSearchTeacher As Label
    Friend WithEvents txtTeacherId    As TextBox
    Friend WithEvents btnSearchTeacher As Button
    Friend WithEvents pnlInfo         As Panel
    Friend WithEvents dgvInfo         As DataGridView

End Class