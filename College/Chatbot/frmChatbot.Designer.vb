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
        Me.pnlHeader  = New System.Windows.Forms.Panel()
        Me.lblTitle   = New System.Windows.Forms.Label()
        Me.lblStatus  = New System.Windows.Forms.Label()
        Me.lblDot     = New System.Windows.Forms.Label()
        Me.pnlChat    = New System.Windows.Forms.Panel()
        Me.lstChat    = New System.Windows.Forms.RichTextBox()
        Me.lblTyping  = New System.Windows.Forms.Label()
        Me.pnlInput   = New System.Windows.Forms.Panel()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnSend    = New System.Windows.Forms.Button()
        Me.btnClear   = New System.Windows.Forms.Button()

        Me.pnlHeader.SuspendLayout()
        Me.pnlChat.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        Me.SuspendLayout()

        ' ══════════════════════════════
        '  Header Panel
        ' ══════════════════════════════
        Me.pnlHeader.BackColor = Color.FromArgb(31, 73, 125)
        Me.pnlHeader.Dock = DockStyle.Top
        Me.pnlHeader.Height = 60
        Me.pnlHeader.Controls.Add(Me.lblDot)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Controls.Add(Me.lblStatus)

        Me.lblDot.Text = "●"
        Me.lblDot.ForeColor = Color.FromArgb(0, 200, 100)
        Me.lblDot.Font = New Font("Segoe UI", 12)
        Me.lblDot.Location = New Point(15, 20)
        Me.lblDot.Size = New Size(20, 25)

        Me.lblTitle.Text = "ERP Assistant"
        Me.lblTitle.Font = New Font("Segoe UI", 14, FontStyle.Bold)
        Me.lblTitle.ForeColor = Color.White
        Me.lblTitle.Location = New Point(40, 10)
        Me.lblTitle.Size = New Size(200, 28)

        Me.lblStatus.Text = "Powered by Gemini AI"
        Me.lblStatus.Font = New Font("Segoe UI", 8)
        Me.lblStatus.ForeColor = Color.FromArgb(180, 210, 240)
        Me.lblStatus.Location = New Point(41, 35)
        Me.lblStatus.Size = New Size(200, 18)

        ' ══════════════════════════════
        '  Chat Display Panel
        ' ══════════════════════════════
        Me.pnlChat.Dock = DockStyle.Fill
        Me.pnlChat.BackColor = Color.FromArgb(245, 247, 250)
        Me.pnlChat.Padding = New Padding(10)
        Me.pnlChat.Controls.Add(Me.lstChat)

        Me.lstChat.Dock = DockStyle.Fill
        Me.lstChat.BackColor = Color.FromArgb(245, 247, 250)
        Me.lstChat.BorderStyle = BorderStyle.None
        Me.lstChat.Font = New Font("Segoe UI", 10)
        Me.lstChat.ReadOnly = True
        Me.lstChat.ScrollBars = RichTextBoxScrollBars.Vertical
        Me.lstChat.Name = "lstChat"

        ' ══════════════════════════════
        '  Typing Indicator
        ' ══════════════════════════════
        Me.lblTyping.Text = ""
        Me.lblTyping.Font = New Font("Segoe UI", 8, FontStyle.Italic)
        Me.lblTyping.ForeColor = Color.Gray
        Me.lblTyping.Dock = DockStyle.Bottom
        Me.lblTyping.Height = 20
        Me.lblTyping.TextAlign = ContentAlignment.MiddleLeft
        Me.lblTyping.Padding = New Padding(10, 0, 0, 0)
        Me.lblTyping.BackColor = Color.FromArgb(245, 247, 250)
        Me.lblTyping.Name = "lblTyping"

        ' ══════════════════════════════
        '  Input Panel
        ' ══════════════════════════════
        Me.pnlInput.BackColor = Color.White
        Me.pnlInput.Dock = DockStyle.Bottom
        Me.pnlInput.Height = 65
        Me.pnlInput.Padding = New Padding(10, 10, 10, 10)
        Me.pnlInput.Controls.Add(Me.txtMessage)
        Me.pnlInput.Controls.Add(Me.btnSend)
        Me.pnlInput.Controls.Add(Me.btnClear)

        Me.txtMessage.Font = New Font("Segoe UI", 10)
        Me.txtMessage.Location = New Point(10, 15)
        Me.txtMessage.Size = New Size(310, 35)
        Me.txtMessage.BorderStyle = BorderStyle.FixedSingle
        Me.txtMessage.BackColor = Color.FromArgb(245, 247, 250)
        Me.txtMessage.Name = "txtMessage"

        Me.btnSend.Text = "Send"
        Me.btnSend.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        Me.btnSend.BackColor = Color.FromArgb(31, 73, 125)
        Me.btnSend.ForeColor = Color.White
        Me.btnSend.FlatStyle = FlatStyle.Flat
        Me.btnSend.FlatAppearance.BorderSize = 0
        Me.btnSend.Location = New Point(330, 12)
        Me.btnSend.Size = New Size(80, 38)
        Me.btnSend.Cursor = Cursors.Hand
        Me.btnSend.Name = "btnSend"

        Me.btnClear.Text = "Clear"
        Me.btnClear.Font = New Font("Segoe UI", 9)
        Me.btnClear.BackColor = Color.FromArgb(220, 220, 220)
        Me.btnClear.ForeColor = Color.DimGray
        Me.btnClear.FlatStyle = FlatStyle.Flat
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.Location = New Point(420, 12)
        Me.btnClear.Size = New Size(55, 38)
        Me.btnClear.Cursor = Cursors.Hand
        Me.btnClear.Name = "btnClear"

        ' ══════════════════════════════
        '  Form
        ' ══════════════════════════════
        Me.ClientSize = New Size(480, 550)
        Me.Controls.Add(Me.pnlChat)
        Me.Controls.Add(Me.lblTyping)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.pnlHeader)
        Me.BackColor = Color.White
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "ERP Assistant"
        Me.Name = "frmChatbot"

        Me.pnlHeader.ResumeLayout(False)
        Me.pnlChat.ResumeLayout(False)
        Me.pnlInput.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader   As Panel
    Friend WithEvents lblTitle    As Label
    Friend WithEvents lblStatus   As Label
    Friend WithEvents lblDot      As Label
    Friend WithEvents pnlChat     As Panel
    Friend WithEvents lstChat     As RichTextBox
    Friend WithEvents lblTyping   As Label
    Friend WithEvents pnlInput    As Panel
    Friend WithEvents txtMessage  As TextBox
    Friend WithEvents btnSend     As Button
    Friend WithEvents btnClear    As Button

End Class