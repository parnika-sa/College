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

        ' ── Controls ──────────────────────────────────────
        Me.pnlHeader    = New Panel()
        Me.pnlHeaderTop = New Panel()
        Me.lblDot       = New Label()
        Me.lblTitle     = New Label()
        Me.lblSubtitle  = New Label()
        Me.lblRoleBadge = New Label()
        Me.pnlBody      = New Panel()
        Me.rtbChat      = New RichTextBox()
        Me.pnlTyping    = New Panel()
        Me.lblTyping    = New Label()
        Me.pnlSep       = New Panel()
        Me.pnlInput     = New Panel()
        Me.pnlInputInner= New Panel()
        Me.txtInput     = New RichTextBox()
        Me.btnSend      = New Button()
        Me.btnClear     = New Button()

        Me.pnlHeader.SuspendLayout()
        Me.pnlHeaderTop.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.pnlInputInner.SuspendLayout()
        Me.SuspendLayout()

        ' ════════════════════════════════════════
        '  HEADER TOP  (dark blue stripe)
        ' ════════════════════════════════════════
        Me.pnlHeaderTop.BackColor = Color.FromArgb(15, 45, 90)
        Me.pnlHeaderTop.Dock      = DockStyle.Top
        Me.pnlHeaderTop.Height    = 4

        ' ════════════════════════════════════════
        '  HEADER PANEL
        ' ════════════════════════════════════════
        Me.pnlHeader.BackColor = Color.FromArgb(31, 73, 125)
        Me.pnlHeader.Dock      = DockStyle.Top
        Me.pnlHeader.Height    = 70
        Me.pnlHeader.Padding   = New Padding(12, 0, 12, 0)
        Me.pnlHeader.Controls.AddRange(New Control() {
            Me.pnlHeaderTop, Me.lblDot, Me.lblTitle, Me.lblSubtitle, Me.lblRoleBadge
        })

        ' Green status dot
        Me.lblDot.Text      = "●"
        Me.lblDot.ForeColor = Color.FromArgb(50, 210, 120)
        Me.lblDot.Font      = New Font("Segoe UI", 11)
        Me.lblDot.Location  = New Point(14, 24)
        Me.lblDot.Size      = New Size(20, 22)
        Me.lblDot.Name      = "lblDot"

        ' Title
        Me.lblTitle.Text      = "ERP Assistant"
        Me.lblTitle.Font      = New Font("Segoe UI Semibold", 14, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.White
        Me.lblTitle.Location  = New Point(38, 12)
        Me.lblTitle.Size      = New Size(200, 26)
        Me.lblTitle.Name      = "lblTitle"

        ' Subtitle
        Me.lblSubtitle.Text      = "College ERP — AI Powered"
        Me.lblSubtitle.Font      = New Font("Segoe UI", 8)
        Me.lblSubtitle.ForeColor = Color.FromArgb(170, 200, 235)
        Me.lblSubtitle.Location  = New Point(39, 38)
        Me.lblSubtitle.Size      = New Size(200, 16)
        Me.lblSubtitle.Name      = "lblSubtitle"

        ' Role badge (top-right)
        Me.lblRoleBadge.Text      = "  ROLE  "
        Me.lblRoleBadge.Font      = New Font("Segoe UI", 8, FontStyle.Bold)
        Me.lblRoleBadge.ForeColor = Color.White
        Me.lblRoleBadge.BackColor = Color.FromArgb(180, 60, 60)
        Me.lblRoleBadge.Location  = New Point(370, 24)
        Me.lblRoleBadge.Size      = New Size(80, 22)
        Me.lblRoleBadge.TextAlign = ContentAlignment.MiddleCenter
        Me.lblRoleBadge.Name      = "lblRoleBadge"

        ' ════════════════════════════════════════
        '  BODY PANEL  (chat area)
        ' ════════════════════════════════════════
        Me.pnlBody.Dock      = DockStyle.Fill
        Me.pnlBody.BackColor = Color.FromArgb(238, 244, 252)
        Me.pnlBody.Padding   = New Padding(8, 8, 8, 0)
        Me.pnlBody.Controls.Add(Me.rtbChat)

        ' RichTextBox for chat
        Me.rtbChat.Dock            = DockStyle.Fill
        Me.rtbChat.BackColor       = Color.FromArgb(238, 244, 252)
        Me.rtbChat.BorderStyle     = BorderStyle.None
        Me.rtbChat.Font            = New Font("Segoe UI", 10)
        Me.rtbChat.ReadOnly        = True
        Me.rtbChat.ScrollBars      = RichTextBoxScrollBars.Vertical
        Me.rtbChat.DetectUrls      = False
        Me.rtbChat.Name            = "rtbChat"

        ' ════════════════════════════════════════
        '  TYPING INDICATOR
        ' ════════════════════════════════════════
        Me.pnlTyping.BackColor = Color.FromArgb(238, 244, 252)
        Me.pnlTyping.Dock      = DockStyle.Bottom
        Me.pnlTyping.Height    = 22
        Me.pnlTyping.Controls.Add(Me.lblTyping)

        Me.lblTyping.Dock      = DockStyle.Fill
        Me.lblTyping.Font      = New Font("Segoe UI", 8, FontStyle.Italic)
        Me.lblTyping.ForeColor = Color.FromArgb(100, 130, 170)
        Me.lblTyping.TextAlign = ContentAlignment.MiddleLeft
        Me.lblTyping.Padding   = New Padding(8, 0, 0, 0)
        Me.lblTyping.Text      = ""
        Me.lblTyping.Name      = "lblTyping"

        ' Separator
        Me.pnlSep.BackColor = Color.FromArgb(180, 205, 235)
        Me.pnlSep.Dock      = DockStyle.Bottom
        Me.pnlSep.Height    = 1

        ' ════════════════════════════════════════
        '  INPUT PANEL
        ' ════════════════════════════════════════
        Me.pnlInput.BackColor = Color.FromArgb(245, 249, 255)
        Me.pnlInput.Dock      = DockStyle.Bottom
        Me.pnlInput.Height    = 90
        Me.pnlInput.Padding   = New Padding(10, 8, 10, 10)
        Me.pnlInput.Controls.Add(Me.pnlInputInner)

        ' Inner container with border effect
        Me.pnlInputInner.BackColor  = Color.White
        Me.pnlInputInner.Dock       = DockStyle.Fill
        Me.pnlInputInner.Padding    = New Padding(2)

        ' RichTextBox for input (supports Shift+Enter)
        Me.txtInput.BackColor    = Color.White
        Me.txtInput.BorderStyle  = BorderStyle.None
        Me.txtInput.Font         = New Font("Segoe UI", 10)
        Me.txtInput.Location     = New Point(8, 8)
        Me.txtInput.Size         = New Size(330, 56)
        Me.txtInput.ScrollBars   = RichTextBoxScrollBars.None
        Me.txtInput.Multiline    = True
        Me.txtInput.WordWrap     = True
        Me.txtInput.Name         = "txtInput"

        ' Send button
        Me.btnSend.Text           = "Send ➤"
        Me.btnSend.Font           = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnSend.BackColor      = Color.FromArgb(31, 73, 125)
        Me.btnSend.ForeColor      = Color.White
        Me.btnSend.FlatStyle      = FlatStyle.Flat
        Me.btnSend.FlatAppearance.BorderSize  = 0
        Me.btnSend.Location       = New Point(350, 8)
        Me.btnSend.Size           = New Size(95, 32)
        Me.btnSend.Cursor         = Cursors.Hand
        Me.btnSend.Name           = "btnSend"

        ' Clear button
        Me.btnClear.Text          = "🗑 Clear"
        Me.btnClear.Font          = New Font("Segoe UI", 8)
        Me.btnClear.BackColor     = Color.FromArgb(215, 215, 215)
        Me.btnClear.ForeColor     = Color.FromArgb(70, 70, 70)
        Me.btnClear.FlatStyle     = FlatStyle.Flat
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.Location      = New Point(350, 46)
        Me.btnClear.Size          = New Size(95, 26)
        Me.btnClear.Cursor        = Cursors.Hand
        Me.btnClear.Name          = "btnClear"

        Me.pnlInputInner.Controls.AddRange(New Control() {
            Me.txtInput, Me.btnSend, Me.btnClear
        })

        ' ════════════════════════════════════════
        '  FORM
        ' ════════════════════════════════════════
        Me.ClientSize         = New Size(480, 600)
        Me.MinimumSize        = New Size(480, 500)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.pnlTyping)
        Me.Controls.Add(Me.pnlSep)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlHeaderTop)
        Me.BackColor          = Color.FromArgb(31, 73, 125)
        Me.FormBorderStyle    = FormBorderStyle.Sizable
        Me.MaximizeBox        = True
        Me.StartPosition      = FormStartPosition.CenterScreen
        Me.Text               = "ERP Assistant"
        Me.Name               = "frmChatbot"

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeaderTop.ResumeLayout(False)
        Me.pnlBody.ResumeLayout(False)
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInputInner.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    ' ── Declarations ──────────────────────────────────────
    Friend WithEvents pnlHeaderTop  As Panel
    Friend WithEvents pnlHeader     As Panel
    Friend WithEvents lblDot        As Label
    Friend WithEvents lblTitle      As Label
    Friend WithEvents lblSubtitle   As Label
    Friend WithEvents lblRoleBadge  As Label
    Friend WithEvents pnlBody       As Panel
    Friend WithEvents rtbChat       As RichTextBox
    Friend WithEvents pnlTyping     As Panel
    Friend WithEvents lblTyping     As Label
    Friend WithEvents pnlSep        As Panel
    Friend WithEvents pnlInput      As Panel
    Friend WithEvents pnlInputInner As Panel
    Friend WithEvents txtInput      As RichTextBox
    Friend WithEvents btnSend       As Button
    Friend WithEvents btnClear      As Button

End Class