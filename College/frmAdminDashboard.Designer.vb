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
        ' ── Controls ──
        Me.pnlHeader = New Panel()
        Me.lblSystemName = New Label()
        Me.lblWelcome = New Label()
        Me.btnHamburger = New Button()
        Me.btnLogout = New Button()

        Me.pnlSidebar = New Panel()
        Me.lblMenuTitle = New Label()
        Me.btnStudents = New Button()
        Me.btnTeachers = New Button()
        Me.btnAttendance = New Button()
        Me.btnResults = New Button()
        Me.btnFees = New Button()

        Me.pnlMain = New Panel()

        ' Stat Cards
        Me.pnlCard1 = New Panel()
        Me.lblCard1Icon = New Label()
        Me.lblCard1Title = New Label()
        Me.lblStudentCount = New Label()
        Me.lblCard1Sub = New Label()

        Me.pnlCard2 = New Panel()
        Me.lblCard2Icon = New Label()
        Me.lblCard2Title = New Label()
        Me.lblTeacherCount = New Label()
        Me.lblCard2Sub = New Label()

        Me.pnlCard3 = New Panel()
        Me.lblCard3Icon = New Label()
        Me.lblCard3Title = New Label()
        Me.lblFeesAmount = New Label()
        Me.lblCard3Sub = New Label()

        Me.pnlCard4 = New Panel()
        Me.lblCard4Icon = New Label()
        Me.lblCard4Title = New Label()
        Me.lblPendingAmount = New Label()
        Me.lblCard4Sub = New Label()

        ' ── Search Panel ──
        Me.pnlSearch = New Panel()
        Me.lblSearchTitle = New Label()
        Me.lblSearchStudent = New Label()
        Me.txtStudentId = New TextBox()
        Me.btnSearchStudent = New Button()
        Me.lblSearchTeacher = New Label()
        Me.txtTeacherId = New TextBox()
        Me.btnSearchTeacher = New Button()

        ' ── Info Panel (search result) ──
        Me.pnlInfo = New Panel()
        Me.dgvInfo = New DataGridView()

        Me.pnlHeader.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ══════════════════════════════
        '  HEADER
        ' ══════════════════════════════
        Me.pnlHeader.BackColor = Color.FromArgb(31, 73, 125)
        Me.pnlHeader.Dock = DockStyle.Top
        Me.pnlHeader.Height = 65
        Me.pnlHeader.Controls.AddRange({
            Me.btnHamburger, Me.lblSystemName, Me.lblWelcome, Me.btnLogout
        })

        ' Hamburger Button
        Me.btnHamburger.Text = "☰"
        Me.btnHamburger.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        Me.btnHamburger.ForeColor = Color.White
        Me.btnHamburger.BackColor = Color.Transparent
        Me.btnHamburger.FlatStyle = FlatStyle.Flat
        Me.btnHamburger.FlatAppearance.BorderSize = 0
        Me.btnHamburger.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 55, 100)
        Me.btnHamburger.Location = New Point(8, 12)
        Me.btnHamburger.Size = New Size(45, 40)
        Me.btnHamburger.Cursor = Cursors.Hand
        Me.btnHamburger.Name = "btnHamburger"

        Me.lblSystemName.Text = "COLLEGE ERP SYSTEM"
        Me.lblSystemName.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        Me.lblSystemName.ForeColor = Color.White
        Me.lblSystemName.Location = New Point(60, 18)
        Me.lblSystemName.AutoSize = True

        Me.lblWelcome.Text = "Welcome, Admin!"
        Me.lblWelcome.Font = New Font("Segoe UI", 9)
        Me.lblWelcome.ForeColor = Color.FromArgb(180, 210, 240)
        Me.lblWelcome.Location = New Point(580, 22)
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Name = "lblWelcome"

        Me.btnLogout.Text = "⏻  Logout"
        Me.btnLogout.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnLogout.BackColor = Color.FromArgb(192, 57, 43)
        Me.btnLogout.ForeColor = Color.White
        Me.btnLogout.FlatStyle = FlatStyle.Flat
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.Location = New Point(890, 15)
        Me.btnLogout.Size = New Size(100, 35)
        Me.btnLogout.Cursor = Cursors.Hand
        Me.btnLogout.Name = "btnLogout"

        ' ══════════════════════════════
        '  SIDEBAR (collapsible)
        ' ══════════════════════════════
        Me.pnlSidebar.BackColor = Color.FromArgb(26, 32, 44)
        Me.pnlSidebar.Location = New Point(0, 65)
        Me.pnlSidebar.Size = New Size(200, 635)
        Me.pnlSidebar.Controls.AddRange({
            Me.lblMenuTitle,
            Me.btnStudents, Me.btnTeachers,
            Me.btnAttendance, Me.btnResults, Me.btnFees
        })

        Me.lblMenuTitle.Text = "NAVIGATION"
        Me.lblMenuTitle.Font = New Font("Segoe UI", 7, FontStyle.Bold)
        Me.lblMenuTitle.ForeColor = Color.FromArgb(100, 120, 150)
        Me.lblMenuTitle.Location = New Point(20, 15)
        Me.lblMenuTitle.AutoSize = True
        Me.lblMenuTitle.Name = "lblMenuTitle"

        ' ✅ Fix: Store original emoji icons for collapse/expand use
        Dim sideButtons() As Button = {
            Me.btnStudents, Me.btnTeachers,
            Me.btnAttendance, Me.btnResults, Me.btnFees
        }
        Dim sideTexts() As String = {
            "👨‍🎓   Students", "👨‍🏫   Teachers",
            "📅   Attendance", "📝   Results", "💰   Fees"
        }
        Dim sideNames() As String = {
            "btnStudents", "btnTeachers",
            "btnAttendance", "btnResults", "btnFees"
        }
        For i = 0 To sideButtons.Length - 1
            sideButtons(i).Text = sideTexts(i)
            sideButtons(i).Name = sideNames(i)
            sideButtons(i).Location = New Point(0, 40 + (i * 55))
            sideButtons(i).Size = New Size(200, 48)
            sideButtons(i).BackColor = Color.FromArgb(26, 32, 44)
            sideButtons(i).ForeColor = Color.FromArgb(180, 195, 215)
            sideButtons(i).FlatStyle = FlatStyle.Flat
            sideButtons(i).FlatAppearance.BorderSize = 0
            sideButtons(i).FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 55, 72)
            sideButtons(i).Font = New Font("Segoe UI", 10, FontStyle.Bold)
            sideButtons(i).TextAlign = ContentAlignment.MiddleLeft
            sideButtons(i).Padding = New Padding(18, 0, 0, 0)
            sideButtons(i).Cursor = Cursors.Hand
        Next

        ' ══════════════════════════════
        '  MAIN PANEL
        ' ══════════════════════════════
        Me.pnlMain.BackColor = Color.FromArgb(247, 248, 252)
        Me.pnlMain.Location = New Point(200, 65)
        Me.pnlMain.Size = New Size(800, 635)
        Me.pnlMain.Controls.AddRange({
            Me.pnlCard1, Me.pnlCard2, Me.pnlCard3, Me.pnlCard4,
            Me.pnlSearch, Me.pnlInfo
        })

        ' ── 4 Stat Cards ──
        Dim cards() As Panel = {Me.pnlCard1, Me.pnlCard2, Me.pnlCard3, Me.pnlCard4}
        Dim icons() As Label = {Me.lblCard1Icon, Me.lblCard2Icon, Me.lblCard3Icon, Me.lblCard4Icon}
        Dim titles() As Label = {Me.lblCard1Title, Me.lblCard2Title, Me.lblCard3Title, Me.lblCard4Title}
        Dim values() As Label = {Me.lblStudentCount, Me.lblTeacherCount, Me.lblFeesAmount, Me.lblPendingAmount}
        Dim subs() As Label = {Me.lblCard1Sub, Me.lblCard2Sub, Me.lblCard3Sub, Me.lblCard4Sub}

        Dim iconTexts() As String = {"👨‍🎓", "👨‍🏫", "✅", "⏳"}
        Dim titleTexts() As String = {"Total Students", "Total Teachers", "Fees Collected", "Fees Pending"}
        Dim subTexts() As String = {"Enrolled", "Active", "Amount received", "Amount due"}
        Dim valueNames() As String = {"lblStudentCount", "lblTeacherCount", "lblFeesAmount", "lblPendingAmount"}
        Dim cardBg() As Color = {
            Color.FromArgb(235, 245, 255),
            Color.FromArgb(232, 255, 244),
            Color.FromArgb(232, 250, 235),
            Color.FromArgb(255, 240, 235)
        }
        Dim valColors() As Color = {
            Color.FromArgb(37, 99, 235),
            Color.FromArgb(5, 150, 105),
            Color.FromArgb(22, 130, 60),
            Color.FromArgb(192, 57, 43)
        }

        For i = 0 To 3
            cards(i).BackColor = cardBg(i)
            cards(i).Location = New Point(15 + (i * 193), 15)
            cards(i).Size = New Size(180, 120)
            cards(i).Controls.AddRange({icons(i), titles(i), values(i), subs(i)})

            icons(i).Text = iconTexts(i)
            icons(i).Font = New Font("Segoe UI", 18)
            icons(i).Location = New Point(140, 8)
            icons(i).AutoSize = True

            titles(i).Text = titleTexts(i)
            titles(i).Font = New Font("Segoe UI", 8, FontStyle.Bold)
            titles(i).ForeColor = Color.FromArgb(100, 100, 110)
            titles(i).Location = New Point(10, 10)
            titles(i).Size = New Size(130, 18)

            values(i).Text = "0"
            values(i).Name = valueNames(i)
            values(i).Font = New Font("Segoe UI", 20, FontStyle.Bold)
            values(i).ForeColor = valColors(i)
            values(i).Location = New Point(10, 35)
            values(i).Size = New Size(160, 45)
            values(i).AutoSize = False

            subs(i).Text = subTexts(i)
            subs(i).Font = New Font("Segoe UI", 7)
            subs(i).ForeColor = Color.Gray
            subs(i).Location = New Point(10, 95)
            subs(i).AutoSize = True
        Next

        ' ══════════════════════════════
        '  SEARCH PANEL
        ' ══════════════════════════════
        Me.pnlSearch.BackColor = Color.White
        Me.pnlSearch.Location = New Point(15, 150)
        Me.pnlSearch.Size = New Size(770, 100)
        Me.pnlSearch.Controls.AddRange({
            Me.lblSearchTitle,
            Me.lblSearchStudent, Me.txtStudentId, Me.btnSearchStudent,
            Me.lblSearchTeacher, Me.txtTeacherId, Me.btnSearchTeacher
        })

        Me.lblSearchTitle.Text = "🔍  Quick Search"
        Me.lblSearchTitle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.lblSearchTitle.ForeColor = Color.FromArgb(31, 73, 125)
        Me.lblSearchTitle.Location = New Point(15, 12)
        Me.lblSearchTitle.AutoSize = True

        ' Student Search
        Me.lblSearchStudent.Text = "Student ID:"
        Me.lblSearchStudent.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblSearchStudent.ForeColor = Color.Gray
        Me.lblSearchStudent.Location = New Point(15, 50)
        Me.lblSearchStudent.AutoSize = True

        Me.txtStudentId.Font = New Font("Segoe UI", 10)
        Me.txtStudentId.Location = New Point(100, 47)
        Me.txtStudentId.Size = New Size(120, 28)
        Me.txtStudentId.BorderStyle = BorderStyle.FixedSingle
        Me.txtStudentId.BackColor = Color.FromArgb(245, 247, 250)
        Me.txtStudentId.Name = "txtStudentId"

        Me.btnSearchStudent.Text = "Search Student"
        Me.btnSearchStudent.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnSearchStudent.BackColor = Color.FromArgb(37, 99, 235)
        Me.btnSearchStudent.ForeColor = Color.White
        Me.btnSearchStudent.FlatStyle = FlatStyle.Flat
        Me.btnSearchStudent.FlatAppearance.BorderSize = 0
        Me.btnSearchStudent.Location = New Point(230, 45)
        Me.btnSearchStudent.Size = New Size(130, 32)
        Me.btnSearchStudent.Cursor = Cursors.Hand
        Me.btnSearchStudent.Name = "btnSearchStudent"

        ' Teacher Search
        Me.lblSearchTeacher.Text = "Teacher ID:"
        Me.lblSearchTeacher.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.lblSearchTeacher.ForeColor = Color.Gray
        Me.lblSearchTeacher.Location = New Point(400, 50)
        Me.lblSearchTeacher.AutoSize = True

        Me.txtTeacherId.Font = New Font("Segoe UI", 10)
        Me.txtTeacherId.Location = New Point(485, 47)
        Me.txtTeacherId.Size = New Size(120, 28)
        Me.txtTeacherId.BorderStyle = BorderStyle.FixedSingle
        Me.txtTeacherId.BackColor = Color.FromArgb(245, 247, 250)
        Me.txtTeacherId.Name = "txtTeacherId"

        Me.btnSearchTeacher.Text = "Search Teacher"
        Me.btnSearchTeacher.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnSearchTeacher.BackColor = Color.FromArgb(5, 150, 105)
        Me.btnSearchTeacher.ForeColor = Color.White
        Me.btnSearchTeacher.FlatStyle = FlatStyle.Flat
        Me.btnSearchTeacher.FlatAppearance.BorderSize = 0
        Me.btnSearchTeacher.Location = New Point(615, 45)
        Me.btnSearchTeacher.Size = New Size(130, 32)
        Me.btnSearchTeacher.Cursor = Cursors.Hand
        Me.btnSearchTeacher.Name = "btnSearchTeacher"

        ' ══════════════════════════════
        '  INFO PANEL (search result)
        ' ══════════════════════════════
        Me.pnlInfo.BackColor = Color.White
        Me.pnlInfo.Location = New Point(15, 265)
        Me.pnlInfo.Size = New Size(770, 350)
        Me.pnlInfo.Visible = False
        Me.pnlInfo.Controls.Add(Me.dgvInfo)

        Me.dgvInfo.Location = New Point(5, 5)
        Me.dgvInfo.Size = New Size(758, 338)
        Me.dgvInfo.AllowUserToAddRows = False
        Me.dgvInfo.ReadOnly = True
        Me.dgvInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInfo.BackgroundColor = Color.White
        Me.dgvInfo.RowHeadersVisible = False
        Me.dgvInfo.Font = New Font("Segoe UI", 9)
        Me.dgvInfo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 73, 125)
        Me.dgvInfo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvInfo.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvInfo.EnableHeadersVisualStyles = False
        Me.dgvInfo.Name = "dgvInfo"

        ' ══════════════════════════════
        '  FORM
        ' ══════════════════════════════
        Me.ClientSize = New Size(1000, 700)
        Me.Controls.AddRange({Me.pnlHeader, Me.pnlSidebar, Me.pnlMain})
        Me.BackColor = Color.FromArgb(247, 248, 252)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAdminDashboard"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "College ERP - Admin Dashboard"

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub

    ' ── Declarations ──
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblSystemName As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnHamburger As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents lblMenuTitle As Label
    Friend WithEvents btnStudents As Button
    Friend WithEvents btnTeachers As Button
    Friend WithEvents btnAttendance As Button
    Friend WithEvents btnResults As Button
    Friend WithEvents btnFees As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlCard1 As Panel
    Friend WithEvents lblCard1Icon As Label
    Friend WithEvents lblCard1Title As Label
    Friend WithEvents lblStudentCount As Label
    Friend WithEvents lblCard1Sub As Label
    Friend WithEvents pnlCard2 As Panel
    Friend WithEvents lblCard2Icon As Label
    Friend WithEvents lblCard2Title As Label
    Friend WithEvents lblTeacherCount As Label
    Friend WithEvents lblCard2Sub As Label
    Friend WithEvents pnlCard3 As Panel
    Friend WithEvents lblCard3Icon As Label
    Friend WithEvents lblCard3Title As Label
    Friend WithEvents lblFeesAmount As Label
    Friend WithEvents lblCard3Sub As Label
    Friend WithEvents pnlCard4 As Panel
    Friend WithEvents lblCard4Icon As Label
    Friend WithEvents lblCard4Title As Label
    Friend WithEvents lblPendingAmount As Label
    Friend WithEvents lblCard4Sub As Label
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents lblSearchTitle As Label
    Friend WithEvents lblSearchStudent As Label
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents btnSearchStudent As Button
    Friend WithEvents lblSearchTeacher As Label
    Friend WithEvents txtTeacherId As TextBox
    Friend WithEvents btnSearchTeacher As Button
    Friend WithEvents pnlInfo As Panel
    Friend WithEvents dgvInfo As DataGridView

End Class
