<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChatbot
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

        ' ── Controls ──────────────────────────────────────────
        Me.pnlAccentBar  = New Panel()
        Me.pnlHeader     = New Panel()
        Me.pnlAvatarBot  = New Panel()
        Me.lblAvatarIcon = New Label()
        Me.lblTitle      = New Label()
        Me.lblSubtitle   = New Label()
        Me.lblRoleBadge  = New Label()
        Me.pnlBody       = New Panel()
        Me.rtbChat       = New RichTextBox()
        Me.pnlTypingBar  = New Panel()
        Me.lblTyping     = New Label()
        Me.pnlDivider    = New Panel()
        Me.pnlInput      = New Panel()
        Me.pnlInputBox   = New Panel()
        Me.txtInput      = New RichTextBox()
        Me.pnlButtons    = New Panel()
        Me.btnSend       = New Button()
        Me.btnClear      = New Button()

        Me.pnlHeader.SuspendLayout()
        Me.pnlAvatarBot.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.pnlTypingBar.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.pnlInputBox.SuspendLayout()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()

        ' ════════════════════════════════════════
        '  ACCENT TOP BAR (gradient feel via thin strip)
        ' ════════════════════════════════════════
        Me.pnlAccentBar.BackColor = Color.FromArgb(99, 102, 241)   ' Indigo
        Me.pnlAccentBar.Dock      = DockStyle.Top
        Me.pnlAccentBar.Height    = 3

        ' ════════════════════════════════════════
        '  HEADER PANEL — Dark slate
        ' ════════════════════════════════════════
        Me.pnlHeader.BackColor = Color.FromArgb(17, 24, 39)
        Me.pnlHeader.Dock      = DockStyle.Top
        Me.pnlHeader.Height    = 72
        Me.pnlHeader.Padding   = New Padding(16, 0, 16, 0)
        Me.pnlHeader.Controls.AddRange(New Control() {
            Me.pnlAccentBar, Me.pnlAvatarBot, Me.lblTitle, Me.lblSubtitle, Me.lblRoleBadge
        })

        ' ── Bot avatar circle ──────────────────
        Me.pnlAvatarBot.BackColor  = Color.FromArgb(99, 102, 241)
        Me.pnlAvatarBot.Size       = New Size(40, 40)
        Me.pnlAvatarBot.Location   = New Point(16, 16)
        Me.pnlAvatarBot.Controls.Add(Me.lblAvatarIcon)

        Me.lblAvatarIcon.Text      = "🤖"
        Me.lblAvatarIcon.Font      = New Font("Segoe UI Emoji", 16)
        Me.lblAvatarIcon.Dock      = DockStyle.Fill
        Me.lblAvatarIcon.TextAlign = ContentAlignment.MiddleCenter
        Me.lblAvatarIcon.BackColor = Color.Transparent
        Me.lblAvatarIcon.Name      = "lblAvatarIcon"

        ' ── Title ──────────────────────────────
        Me.lblTitle.Text      = "ERP Assistant"
        Me.lblTitle.Font      = New Font("Segoe UI", 12, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.White
        Me.lblTitle.Location  = New Point(64, 14)
        Me.lblTitle.Size      = New Size(220, 22)
        Me.lblTitle.Name      = "lblTitle"
        Me.lblTitle.BackColor = Color.Transparent

        ' ── Subtitle ───────────────────────────
        Me.lblSubtitle.Text      = "● Online · AI Powered"
        Me.lblSubtitle.Font      = New Font("Segoe UI", 8)
        Me.lblSubtitle.ForeColor = Color.FromArgb(99, 102, 241)
        Me.lblSubtitle.Location  = New Point(65, 37)
        Me.lblSubtitle.Size      = New Size(210, 16)
        Me.lblSubtitle.Name      = "lblSubtitle"
        Me.lblSubtitle.BackColor = Color.Transparent

        ' ── Role pill badge ────────────────────
        Me.lblRoleBadge.Text      = "  ROLE  "
        Me.lblRoleBadge.Font      = New Font("Segoe UI", 8, FontStyle.Bold)
        Me.lblRoleBadge.ForeColor = Color.White
        Me.lblRoleBadge.BackColor = Color.FromArgb(99, 102, 241)
        Me.lblRoleBadge.Location  = New Point(370, 24)
        Me.lblRoleBadge.Size      = New Size(82, 24)
        Me.lblRoleBadge.TextAlign = ContentAlignment.MiddleCenter
        Me.lblRoleBadge.Name      = "lblRoleBadge"

        ' ════════════════════════════════════════
        '  BODY — chat display area
        ' ════════════════════════════════════════
        Me.pnlBody.BackColor = Color.FromArgb(15, 20, 30)
        Me.pnlBody.Dock      = DockStyle.Fill
        Me.pnlBody.Padding   = New Padding(10, 10, 10, 4)
        Me.pnlBody.Controls.Add(Me.rtbChat)

        Me.rtbChat.Dock          = DockStyle.Fill
        Me.rtbChat.BackColor     = Color.FromArgb(15, 20, 30)
        Me.rtbChat.BorderStyle   = BorderStyle.None
        Me.rtbChat.Font          = New Font("Segoe UI", 10.5)
        Me.rtbChat.ForeColor     = Color.FromArgb(229, 231, 235)
        Me.rtbChat.ReadOnly      = True
        Me.rtbChat.ScrollBars    = RichTextBoxScrollBars.Vertical
        Me.rtbChat.DetectUrls    = False
        Me.rtbChat.WordWrap      = True
        Me.rtbChat.TabStop       = False
        Me.rtbChat.Cursor        = Cursors.Default
        Me.rtbChat.Name          = "rtbChat"

        ' ════════════════════════════════════════
        '  TYPING BAR
        ' ════════════════════════════════════════
        Me.pnlTypingBar.BackColor = Color.FromArgb(17, 24, 39)
        Me.pnlTypingBar.Dock      = DockStyle.Bottom
        Me.pnlTypingBar.Height    = 24
        Me.pnlTypingBar.Controls.Add(Me.lblTyping)

        Me.lblTyping.Dock      = DockStyle.Fill
        Me.lblTyping.Font      = New Font("Segoe UI", 8, FontStyle.Italic)
        Me.lblTyping.ForeColor = Color.FromArgb(99, 102, 241)
        Me.lblTyping.TextAlign = ContentAlignment.MiddleLeft
        Me.lblTyping.Padding   = New Padding(12, 0, 0, 0)
        Me.lblTyping.Text      = ""
        Me.lblTyping.Name      = "lblTyping"

        ' ════════════════════════════════════════
        '  DIVIDER
        ' ════════════════════════════════════════
        Me.pnlDivider.BackColor = Color.FromArgb(31, 41, 55)
        Me.pnlDivider.Dock      = DockStyle.Bottom
        Me.pnlDivider.Height    = 1

        ' ════════════════════════════════════════
        '  INPUT PANEL
        ' ════════════════════════════════════════
        Me.pnlInput.BackColor = Color.FromArgb(17, 24, 39)
        Me.pnlInput.Dock      = DockStyle.Bottom
        Me.pnlInput.Height    = 80
        Me.pnlInput.Padding   = New Padding(12, 10, 12, 10)
        Me.pnlInput.Controls.Add(Me.pnlInputBox)
        Me.pnlInput.Controls.Add(Me.pnlButtons)

        ' ── Input box with rounded border feel ─
        Me.pnlInputBox.BackColor  = Color.FromArgb(31, 41, 55)
        Me.pnlInputBox.Location   = New Point(12, 10)
        Me.pnlInputBox.Size       = New Size(340, 58)
        Me.pnlInputBox.Padding    = New Padding(4)
        Me.pnlInputBox.Controls.Add(Me.txtInput)

        Me.txtInput.BackColor    = Color.FromArgb(31, 41, 55)
        Me.txtInput.BorderStyle  = BorderStyle.None
        Me.txtInput.Font         = New Font("Segoe UI", 10.5)
        Me.txtInput.ForeColor    = Color.FromArgb(229, 231, 235)
        Me.txtInput.Dock         = DockStyle.Fill
        Me.txtInput.ScrollBars   = RichTextBoxScrollBars.None
        Me.txtInput.Multiline    = True
        Me.txtInput.WordWrap     = True
        Me.txtInput.Name         = "txtInput"

        ' ── Button stack ───────────────────────
        Me.pnlButtons.BackColor = Color.FromArgb(17, 24, 39)
        Me.pnlButtons.Location  = New Point(360, 10)
        Me.pnlButtons.Size      = New Size(100, 58)
        Me.pnlButtons.Controls.AddRange(New Control(){Me.btnSend, Me.btnClear})

        ' Send button
        Me.btnSend.Text                          = "Send  ➤"
        Me.btnSend.Font                          = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnSend.BackColor                     = Color.FromArgb(99, 102, 241)
        Me.btnSend.ForeColor                     = Color.White
        Me.btnSend.FlatStyle                     = FlatStyle.Flat
        Me.btnSend.FlatAppearance.BorderSize     = 0
        Me.btnSend.FlatAppearance.MouseOverBackColor = Color.FromArgb(79, 70, 229)
        Me.btnSend.Location                      = New Point(0, 0)
        Me.btnSend.Size                          = New Size(100, 34)
        Me.btnSend.Cursor                        = Cursors.Hand
        Me.btnSend.Name                          = "btnSend"

        ' Clear button
        Me.btnClear.Text                         = "🗑  Clear"
        Me.btnClear.Font                         = New Font("Segoe UI", 8)
        Me.btnClear.BackColor                    = Color.FromArgb(55, 65, 81)
        Me.btnClear.ForeColor                    = Color.FromArgb(156, 163, 175)
        Me.btnClear.FlatStyle                    = FlatStyle.Flat
        Me.btnClear.FlatAppearance.BorderSize    = 0
        Me.btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 85, 99)
        Me.btnClear.Location                     = New Point(0, 38)
        Me.btnClear.Size                         = New Size(100, 22)
        Me.btnClear.Cursor                       = Cursors.Hand
        Me.btnClear.Name                         = "btnClear"

        ' ════════════════════════════════════════
        '  FORM
        ' ════════════════════════════════════════
        Me.ClientSize      = New Size(480, 640)
        Me.MinimumSize     = New Size(460, 520)
        Me.BackColor       = Color.FromArgb(15, 20, 30)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlTypingBar)
        Me.Controls.Add(Me.pnlDivider)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlAccentBar)
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.MaximizeBox     = True
        Me.StartPosition   = FormStartPosition.CenterScreen
        Me.Text            = "ERP Assistant"
        Me.Name            = "frmChatbot"

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlAvatarBot.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlTypingBar.ResumeLayout(False)
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInputBox.ResumeLayout(False)
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    ' ── Declarations ──────────────────────────────────────────
    Friend WithEvents pnlAccentBar  As Panel
    Friend WithEvents pnlHeader     As Panel
    Friend WithEvents pnlAvatarBot  As Panel
    Friend WithEvents lblAvatarIcon As Label
    Friend WithEvents lblTitle      As Label
    Friend WithEvents lblSubtitle   As Label
    Friend WithEvents lblRoleBadge  As Label
    Friend WithEvents pnlBody       As Panel
    Friend WithEvents rtbChat       As RichTextBox
    Friend WithEvents pnlTypingBar  As Panel
    Friend WithEvents lblTyping     As Label
    Friend WithEvents pnlDivider    As Panel
    Friend WithEvents pnlInput      As Panel
    Friend WithEvents pnlInputBox   As Panel
    Friend WithEvents txtInput      As RichTextBox
    Friend WithEvents pnlButtons    As Panel
    Friend WithEvents btnSend       As Button
    Friend WithEvents btnClear      As Button

End Class