<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentDashboard
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()

        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblNavTitle = New System.Windows.Forms.Label()
        Me.btnMyProfile = New System.Windows.Forms.Button()
        Me.btnMyAttendance = New System.Windows.Forms.Button()
        Me.btnMyResults = New System.Windows.Forms.Button()
        Me.btnMyFees = New System.Windows.Forms.Button()

        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.pnlCard1 = New System.Windows.Forms.Panel()
        Me.lblCard1Icon = New System.Windows.Forms.Label()
        Me.lblCard1Title = New System.Windows.Forms.Label()
        Me.lblAttPercent = New System.Windows.Forms.Label()
        Me.lblCard1Sub = New System.Windows.Forms.Label()

        Me.pnlCard2 = New System.Windows.Forms.Panel()
        Me.lblCard2Icon = New System.Windows.Forms.Label()
        Me.lblCard2Title = New System.Windows.Forms.Label()
        Me.lblTotalSubjects = New System.Windows.Forms.Label()
        Me.lblCard2Sub = New System.Windows.Forms.Label()

        Me.pnlCard3 = New System.Windows.Forms.Panel()
        Me.lblCard3Icon = New System.Windows.Forms.Label()
        Me.lblCard3Title = New System.Windows.Forms.Label()
        Me.lblFeesPending = New System.Windows.Forms.Label()
        Me.lblCard3Sub = New System.Windows.Forms.Label()

        Me.pnlCard4 = New System.Windows.Forms.Panel()
        Me.lblCard4Icon = New System.Windows.Forms.Label()
        Me.lblCard4Title = New System.Windows.Forms.Label()
        Me.lblCurrentSem = New System.Windows.Forms.Label()
        Me.lblCard4Sub = New System.Windows.Forms.Label()

        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlContentTitle = New System.Windows.Forms.Panel()
        Me.lblContentTitle = New System.Windows.Forms.Label()
        Me.dgvMain = New System.Windows.Forms.DataGridView()

        Me.pnlTop.SuspendLayout()
        Me.pnlLeft.SuspendLayout()
        Me.pnlStats.SuspendLayout()
        Me.pnlContent.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ══════════════════════════════
        '  HEADER
        ' ══════════════════════════════
        Me.pnlTop.BackColor = Color.FromArgb(31, 73, 125)
        Me.pnlTop.Dock = DockStyle.Top
        Me.pnlTop.Height = 60
        Me.pnlTop.Controls.AddRange({Me.lblTitle, Me.lblWelcome, Me.btnLogout})

        Me.lblTitle.Text = "🎓  COLLEGE ERP SYSTEM"
        Me.lblTitle.ForeColor = Color.White
        Me.lblTitle.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New Point(15, 16)

        Me.lblWelcome.Text = "Welcome, Student!"
        Me.lblWelcome.ForeColor = Color.FromArgb(180, 210, 240)
        Me.lblWelcome.Font = New Font("Segoe UI", 9)
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New Point(680, 20)
        Me.lblWelcome.Name = "lblWelcome"

        Me.btnLogout.Text = "⏻  Logout"
        Me.btnLogout.Location = New Point(885, 13)
        Me.btnLogout.Size = New Size(95, 34)
        Me.btnLogout.BackColor = Color.FromArgb(192, 57, 43)
        Me.btnLogout.ForeColor = Color.White
        Me.btnLogout.FlatStyle = FlatStyle.Flat
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnLogout.Cursor = Cursors.Hand
        Me.btnLogout.Name = "btnLogout"

        ' ══════════════════════════════
        '  LEFT SIDEBAR
        ' ══════════════════════════════
        Me.pnlLeft.BackColor = Color.FromArgb(26, 32, 44)
        Me.pnlLeft.Location = New Point(0, 60)
        Me.pnlLeft.Size = New Size(180, 560)
        Me.pnlLeft.Controls.AddRange({
            Me.lblNavTitle,
            Me.btnMyProfile, Me.btnMyAttendance,
            Me.btnMyResults, Me.btnMyFees
        })

        Me.lblNavTitle.Text = "NAVIGATION"
        Me.lblNavTitle.Font = New Font("Segoe UI", 7, FontStyle.Bold)
        Me.lblNavTitle.ForeColor = Color.FromArgb(100, 120, 150)
        Me.lblNavTitle.Location = New Point(18, 18)
        Me.lblNavTitle.AutoSize = True

        ' Sidebar Buttons
        Dim sideButtons() As Button = {
            Me.btnMyProfile, Me.btnMyAttendance,
            Me.btnMyResults, Me.btnMyFees
        }
        Dim sideTxts() As String = {
            "👤   My Profile", "📅   My Attendance",
            "📝   My Results", "💰   My Fees"
        }
        Dim sideNms() As String = {
            "btnMyProfile", "btnMyAttendance",
            "btnMyResults", "btnMyFees"
        }
        For i = 0 To sideButtons.Length - 1
            sideButtons(i).Text = sideTxts(i)
            sideButtons(i).Name = sideNms(i)
            sideButtons(i).Location = New Point(0, 42 + (i * 55))
            sideButtons(i).Size = New Size(180, 48)
            sideButtons(i).BackColor = Color.FromArgb(52, 73, 94)
            sideButtons(i).ForeColor = Color.FromArgb(180, 195, 215)
            sideButtons(i).FlatStyle = FlatStyle.Flat
            sideButtons(i).FlatAppearance.BorderSize = 0
            sideButtons(i).FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 90, 115)
            sideButtons(i).Font = New Font("Segoe UI", 10, FontStyle.Bold)
            sideButtons(i).TextAlign = ContentAlignment.MiddleLeft
            sideButtons(i).Padding = New Padding(15, 0, 0, 0)
            sideButtons(i).Cursor = Cursors.Hand
        Next

        ' ══════════════════════════════
        '  STATS PANEL
        ' ══════════════════════════════
        Me.pnlStats.BackColor = Color.FromArgb(245, 247, 252)
        Me.pnlStats.Location = New Point(185, 65)
        Me.pnlStats.Size = New Size(795, 135)

        ' Card setup
        Dim cards() As Panel = {Me.pnlCard1, Me.pnlCard2, Me.pnlCard3, Me.pnlCard4}
        Dim cardIcons() As Label = {Me.lblCard1Icon, Me.lblCard2Icon, Me.lblCard3Icon, Me.lblCard4Icon}
        Dim cardTitles() As Label = {Me.lblCard1Title, Me.lblCard2Title, Me.lblCard3Title, Me.lblCard4Title}
        Dim cardValues() As Label = {Me.lblAttPercent, Me.lblTotalSubjects, Me.lblFeesPending, Me.lblCurrentSem}
        Dim cardSubs() As Label = {Me.lblCard1Sub, Me.lblCard2Sub, Me.lblCard3Sub, Me.lblCard4Sub}

        Dim cIcons() As String = {"📊", "📚", "💰", "🎓"}
        Dim cTitles() As String = {"Attendance %", "Total Subjects", "Fees Pending", "Semester"}
        Dim cSubs() As String = {"This semester", "Enrolled", "Amount due", "Current"}
        Dim cVals() As String = {"lblAttPercent", "lblTotalSubjects", "lblFeesPending", "lblCurrentSem"}
        Dim cBg() As Color = {
            Color.FromArgb(235, 245, 255),
            Color.FromArgb(232, 255, 244),
            Color.FromArgb(255, 240, 235),
            Color.FromArgb(245, 235, 255)
        }
        Dim cFg() As Color = {
            Color.FromArgb(37, 99, 235),
            Color.FromArgb(5, 150, 105),
            Color.FromArgb(192, 57, 43),
            Color.FromArgb(142, 68, 173)
        }

        For i = 0 To 3
            cards(i).BackColor = cBg(i)
            cards(i).Location = New Point(10 + (i * 195), 10)
            cards(i).Size = New Size(183, 112)
            cards(i).BorderStyle = BorderStyle.None
            Me.pnlStats.Controls.Add(cards(i))
            cards(i).Controls.AddRange({cardIcons(i), cardTitles(i), cardValues(i), cardSubs(i)})

            cardIcons(i).Text = cIcons(i)
            cardIcons(i).Font = New Font("Segoe UI", 16)
            cardIcons(i).Location = New Point(145, 8)
            cardIcons(i).AutoSize = True

            cardTitles(i).Text = cTitles(i)
            cardTitles(i).Font = New Font("Segoe UI", 8, FontStyle.Bold)
            cardTitles(i).ForeColor = Color.FromArgb(100, 100, 110)
            cardTitles(i).Location = New Point(10, 10)
            cardTitles(i).AutoSize = True

            ' ✅ Fix: AutoSize OFF + fixed size taaki text card se bahar na jaye
            cardValues(i).Text = "..."
            cardValues(i).Name = cVals(i)
            cardValues(i).Font = New Font("Segoe UI", 20, FontStyle.Bold)
            cardValues(i).ForeColor = cFg(i)
            cardValues(i).Location = New Point(10, 35)
            cardValues(i).Size = New Size(165, 40)
            cardValues(i).AutoSize = False

            cardSubs(i).Text = cSubs(i)
            cardSubs(i).Font = New Font("Segoe UI", 7)
            cardSubs(i).ForeColor = Color.Gray
            cardSubs(i).Location = New Point(10, 90)
            cardSubs(i).AutoSize = True
        Next

        ' ══════════════════════════════
        '  CONTENT PANEL
        ' ══════════════════════════════
        Me.pnlContent.BackColor = Color.White
        Me.pnlContent.Location = New Point(185, 208)
        Me.pnlContent.Size = New Size(795, 415)
        Me.pnlContent.Controls.AddRange({Me.pnlContentTitle, Me.dgvMain})

        ' Content Title Bar
        Me.pnlContentTitle.BackColor = Color.FromArgb(245, 247, 252)
        Me.pnlContentTitle.Location = New Point(0, 0)
        Me.pnlContentTitle.Size = New Size(795, 40)
        Me.pnlContentTitle.Name = "pnlContentTitle"

        Me.lblContentTitle.Text = "  📅  My Attendance"
        Me.lblContentTitle.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.lblContentTitle.ForeColor = Color.FromArgb(31, 73, 125)
        Me.lblContentTitle.Location = New Point(5, 8)
        Me.lblContentTitle.AutoSize = True
        Me.pnlContentTitle.Controls.Add(Me.lblContentTitle)

        ' DataGridView
        Me.dgvMain.Location = New Point(0, 40)
        Me.dgvMain.Size = New Size(795, 375)
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMain.BackgroundColor = Color.White
        Me.dgvMain.RowHeadersVisible = False
        Me.dgvMain.BorderStyle = BorderStyle.None
        Me.dgvMain.Font = New Font("Segoe UI", 9)
        Me.dgvMain.ColumnHeadersHeight = 38
        Me.dgvMain.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 73, 125)
        Me.dgvMain.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgvMain.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.dgvMain.EnableHeadersVisualStyles = False
        Me.dgvMain.GridColor = Color.FromArgb(220, 225, 235)
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right

        ' ══════════════════════════════
        '  FORM
        ' ══════════════════════════════
        Me.ClientSize = New Size(984, 630)
        Me.Text = "College ERP - Student Dashboard"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(245, 247, 252)
        Me.Font = New Font("Segoe UI", 9)
        Me.MinimumSize = New Size(900, 600)
        Me.Controls.AddRange({Me.pnlTop, Me.pnlLeft, Me.pnlStats, Me.pnlContent})

        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlLeft.ResumeLayout(False)
        Me.pnlStats.ResumeLayout(False)
        Me.pnlContent.ResumeLayout(False)
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
    Friend WithEvents btnMyAttendance As Button
    Friend WithEvents btnMyResults As Button
    Friend WithEvents btnMyFees As Button
    Friend WithEvents pnlStats As Panel
    Friend WithEvents pnlCard1 As Panel
    Friend WithEvents lblCard1Icon As Label
    Friend WithEvents lblCard1Title As Label
    Friend WithEvents lblAttPercent As Label
    Friend WithEvents lblCard1Sub As Label
    Friend WithEvents pnlCard2 As Panel
    Friend WithEvents lblCard2Icon As Label
    Friend WithEvents lblCard2Title As Label
    Friend WithEvents lblTotalSubjects As Label
    Friend WithEvents lblCard2Sub As Label
    Friend WithEvents pnlCard3 As Panel
    Friend WithEvents lblCard3Icon As Label
    Friend WithEvents lblCard3Title As Label
    Friend WithEvents lblFeesPending As Label
    Friend WithEvents lblCard3Sub As Label
    Friend WithEvents pnlCard4 As Panel
    Friend WithEvents lblCard4Icon As Label
    Friend WithEvents lblCard4Title As Label
    Friend WithEvents lblCurrentSem As Label
    Friend WithEvents lblCard4Sub As Label
    Friend WithEvents pnlContent As Panel
    Friend WithEvents pnlContentTitle As Panel
    Friend WithEvents lblContentTitle As Label
    Friend WithEvents dgvMain As DataGridView

End Class
