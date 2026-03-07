<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.pnlLeft = New System.Windows.Forms.Panel()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.lblTagline = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()

        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblDivider = New System.Windows.Forms.Label()

        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblFooter = New System.Windows.Forms.Label()

        Me.pnlLeft.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.SuspendLayout()

        ' ══════════════════════════════
        '  pnlLeft — Blue Side
        ' ══════════════════════════════
        Me.pnlLeft.BackColor = Color.FromArgb(31, 73, 125)
        Me.pnlLeft.Location = New Point(0, 0)
        Me.pnlLeft.Size = New Size(220, 480)
        Me.pnlLeft.Controls.AddRange({Me.lblAppName, Me.lblTagline, Me.lblVersion})

        ' College Name
        Me.lblAppName.Text = "COLLEGE" & vbNewLine & "ERP" & vbNewLine & "SYSTEM"
        Me.lblAppName.Font = New Font("Segoe UI", 22, FontStyle.Bold)
        Me.lblAppName.ForeColor = Color.White
        Me.lblAppName.Location = New Point(20, 140)
        Me.lblAppName.Size = New Size(180, 130)
        Me.lblAppName.TextAlign = ContentAlignment.MiddleCenter

        ' Tagline
        Me.lblTagline.Text = "━━━━━━━━━━━━" & vbNewLine & "Manage. Track. Grow."
        Me.lblTagline.Font = New Font("Segoe UI", 8, FontStyle.Italic)
        Me.lblTagline.ForeColor = Color.FromArgb(180, 210, 240)
        Me.lblTagline.Location = New Point(20, 280)
        Me.lblTagline.Size = New Size(180, 50)
        Me.lblTagline.TextAlign = ContentAlignment.MiddleCenter

        ' Version
        Me.lblVersion.Text = "v1.0"
        Me.lblVersion.Font = New Font("Segoe UI", 8)
        Me.lblVersion.ForeColor = Color.FromArgb(150, 190, 230)
        Me.lblVersion.Location = New Point(20, 445)
        Me.lblVersion.Size = New Size(180, 20)
        Me.lblVersion.TextAlign = ContentAlignment.MiddleCenter

        ' ══════════════════════════════
        '  pnlRight — White Side
        ' ══════════════════════════════
        Me.pnlRight.BackColor = Color.White
        Me.pnlRight.Location = New Point(220, 0)
        Me.pnlRight.Size = New Size(330, 480)
        Me.pnlRight.Controls.AddRange({
            Me.lblWelcome, Me.lblSubtitle, Me.lblDivider,
            Me.lblUsername, Me.txtUsername,
            Me.lblPassword, Me.txtPassword,
            Me.btnLogin, Me.lblFooter
        })

        ' Welcome
        Me.lblWelcome.Text = "Welcome Back!"
        Me.lblWelcome.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        Me.lblWelcome.ForeColor = Color.FromArgb(31, 73, 125)
        Me.lblWelcome.Location = New Point(25, 55)
        Me.lblWelcome.Size = New Size(280, 35)

        ' Subtitle
        Me.lblSubtitle.Text = "Sign in to your account"
        Me.lblSubtitle.Font = New Font("Segoe UI", 9)
        Me.lblSubtitle.ForeColor = Color.Gray
        Me.lblSubtitle.Location = New Point(25, 93)
        Me.lblSubtitle.Size = New Size(280, 20)

        ' Divider line
        Me.lblDivider.BackColor = Color.FromArgb(220, 220, 220)
        Me.lblDivider.Location = New Point(25, 120)
        Me.lblDivider.Size = New Size(280, 1)

        ' Username Label
        Me.lblUsername.Text = "USERNAME"
        Me.lblUsername.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        Me.lblUsername.ForeColor = Color.FromArgb(100, 100, 100)
        Me.lblUsername.Location = New Point(25, 140)
        Me.lblUsername.Size = New Size(280, 18)

        ' Username TextBox
        Me.txtUsername.Font = New Font("Segoe UI", 11)
        Me.txtUsername.Location = New Point(25, 161)
        Me.txtUsername.Size = New Size(280, 30)
        Me.txtUsername.BorderStyle = BorderStyle.FixedSingle
        Me.txtUsername.BackColor = Color.FromArgb(245, 247, 250)
        Me.txtUsername.Name = "txtUsername"

        ' Password Label
        Me.lblPassword.Text = "PASSWORD"
        Me.lblPassword.Font = New Font("Segoe UI", 8, FontStyle.Bold)
        Me.lblPassword.ForeColor = Color.FromArgb(100, 100, 100)
        Me.lblPassword.Location = New Point(25, 210)
        Me.lblPassword.Size = New Size(280, 18)

        ' Password TextBox
        Me.txtPassword.Font = New Font("Segoe UI", 11)
        Me.txtPassword.Location = New Point(25, 231)
        Me.txtPassword.Size = New Size(280, 30)
        Me.txtPassword.BorderStyle = BorderStyle.FixedSingle
        Me.txtPassword.BackColor = Color.FromArgb(245, 247, 250)
        Me.txtPassword.PasswordChar = "●"c
        Me.txtPassword.Name = "txtPassword"

        ' Login Button
        Me.btnLogin.Text = "SIGN IN  →"
        Me.btnLogin.Font = New Font("Segoe UI", 11, FontStyle.Bold)
        Me.btnLogin.BackColor = Color.FromArgb(31, 73, 125)
        Me.btnLogin.ForeColor = Color.White
        Me.btnLogin.FlatStyle = FlatStyle.Flat
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.Location = New Point(25, 290)
        Me.btnLogin.Size = New Size(280, 45)
        Me.btnLogin.Cursor = Cursors.Hand
        Me.btnLogin.Name = "btnLogin"

        ' Footer
        Me.lblFooter.Text = "© 2025 College ERP. All rights reserved."
        Me.lblFooter.Font = New Font("Segoe UI", 7)
        Me.lblFooter.ForeColor = Color.LightGray
        Me.lblFooter.Location = New Point(25, 450)
        Me.lblFooter.Size = New Size(280, 18)
        Me.lblFooter.TextAlign = ContentAlignment.MiddleCenter

        ' ══════════════════════════════
        '  Form
        ' ══════════════════════════════
        Me.ClientSize = New Size(550, 480)
        Me.Controls.Add(Me.pnlLeft)
        Me.Controls.Add(Me.pnlRight)
        Me.BackColor = Color.White
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "College ERP - Login"
        Me.Name = "Form1"

        Me.pnlLeft.ResumeLayout(False)
        Me.pnlRight.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    ' ── Declarations ──
    Friend WithEvents pnlLeft As Panel
    Friend WithEvents lblAppName As Label
    Friend WithEvents lblTagline As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents pnlRight As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblDivider As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblFooter As Label

End Class