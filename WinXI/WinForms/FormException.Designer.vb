<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormException
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormException))
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tlpTitleIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.icnMain = New System.Windows.Forms.PictureBox()
        Me.tlpCloseButton = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdContinue = New System.Windows.Forms.Button()
        Me.cmdForceQuit = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.tlpControls = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdSaveLog = New System.Windows.Forms.Button()
        Me.pnlLinks = New System.Windows.Forms.Panel()
        Me.lnkOpenIssue = New System.Windows.Forms.LinkLabel()
        Me.lnkEmail = New System.Windows.Forms.LinkLabel()
        Me.pnlTitle.SuspendLayout()
        Me.tlpTitleIcon.SuspendLayout()
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.tlpControls.SuspendLayout()
        Me.tlpButtons.SuspendLayout()
        Me.pnlLinks.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Controls.Add(Me.tlpTitleIcon)
        Me.pnlTitle.Controls.Add(Me.tlpCloseButton)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(1, 1)
        Me.pnlTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(588, 40)
        Me.pnlTitle.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(40, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(508, 40)
        Me.lblTitle.TabIndex = 15
        Me.lblTitle.Text = "Exception Handler"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpTitleIcon
        '
        Me.tlpTitleIcon.BackColor = System.Drawing.Color.Transparent
        Me.tlpTitleIcon.ColumnCount = 1
        Me.tlpTitleIcon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.tlpTitleIcon.Controls.Add(Me.icnMain, 0, 0)
        Me.tlpTitleIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlpTitleIcon.Location = New System.Drawing.Point(0, 0)
        Me.tlpTitleIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpTitleIcon.Name = "tlpTitleIcon"
        Me.tlpTitleIcon.RowCount = 1
        Me.tlpTitleIcon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTitleIcon.Size = New System.Drawing.Size(40, 40)
        Me.tlpTitleIcon.TabIndex = 16
        '
        'icnMain
        '
        Me.icnMain.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.icnMain.BackColor = System.Drawing.Color.Transparent
        Me.icnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.icnMain.Image = Global.WinXI.My.Resources.Resources.ImgMainIcon24Px
        Me.icnMain.Location = New System.Drawing.Point(9, 8)
        Me.icnMain.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.icnMain.Name = "icnMain"
        Me.icnMain.Size = New System.Drawing.Size(24, 24)
        Me.icnMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icnMain.TabIndex = 1
        Me.icnMain.TabStop = False
        '
        'tlpCloseButton
        '
        Me.tlpCloseButton.BackColor = System.Drawing.Color.Transparent
        Me.tlpCloseButton.ColumnCount = 1
        Me.tlpCloseButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCloseButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.tlpCloseButton.Location = New System.Drawing.Point(548, 0)
        Me.tlpCloseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpCloseButton.Name = "tlpCloseButton"
        Me.tlpCloseButton.RowCount = 1
        Me.tlpCloseButton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCloseButton.Size = New System.Drawing.Size(40, 40)
        Me.tlpCloseButton.TabIndex = 17
        '
        'cmdContinue
        '
        Me.cmdContinue.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.cmdContinue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdContinue.Enabled = False
        Me.cmdContinue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdContinue.FlatAppearance.BorderSize = 0
        Me.cmdContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdContinue.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdContinue.Location = New System.Drawing.Point(236, 0)
        Me.cmdContinue.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdContinue.Name = "cmdContinue"
        Me.cmdContinue.Size = New System.Drawing.Size(110, 35)
        Me.cmdContinue.TabIndex = 3
        Me.cmdContinue.TabStop = False
        Me.cmdContinue.Text = "Continue"
        Me.cmdContinue.UseVisualStyleBackColor = False
        '
        'cmdForceQuit
        '
        Me.cmdForceQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.cmdForceQuit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdForceQuit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdForceQuit.FlatAppearance.BorderSize = 0
        Me.cmdForceQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdForceQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdForceQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdForceQuit.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdForceQuit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdForceQuit.Location = New System.Drawing.Point(118, 0)
        Me.cmdForceQuit.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdForceQuit.Name = "cmdForceQuit"
        Me.cmdForceQuit.Size = New System.Drawing.Size(110, 35)
        Me.cmdForceQuit.TabIndex = 2
        Me.cmdForceQuit.TabStop = False
        Me.cmdForceQuit.Text = "Force Quit"
        Me.cmdForceQuit.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.lblInfo.Location = New System.Drawing.Point(0, 122)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(588, 127)
        Me.lblInfo.TabIndex = 7
        Me.lblInfo.Text = resources.GetString("lblInfo.Text")
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblErrorMessage.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblErrorMessage.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMessage.ForeColor = System.Drawing.Color.Tomato
        Me.lblErrorMessage.Location = New System.Drawing.Point(0, 0)
        Me.lblErrorMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(588, 122)
        Me.lblErrorMessage.TabIndex = 6
        Me.lblErrorMessage.Text = "..."
        Me.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.Location = New System.Drawing.Point(1, 41)
        Me.pnlSplit.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(588, 2)
        Me.pnlSplit.TabIndex = 73
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.lblInfo)
        Me.pnlMain.Controls.Add(Me.tlpControls)
        Me.pnlMain.Controls.Add(Me.lblErrorMessage)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(1, 43)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(588, 301)
        Me.pnlMain.TabIndex = 74
        '
        'tlpControls
        '
        Me.tlpControls.ColumnCount = 2
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.50085!))
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.49915!))
        Me.tlpControls.Controls.Add(Me.tlpButtons, 1, 0)
        Me.tlpControls.Controls.Add(Me.pnlLinks, 0, 0)
        Me.tlpControls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpControls.Location = New System.Drawing.Point(0, 249)
        Me.tlpControls.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpControls.Name = "tlpControls"
        Me.tlpControls.RowCount = 1
        Me.tlpControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpControls.Size = New System.Drawing.Size(588, 52)
        Me.tlpControls.TabIndex = 13
        '
        'tlpButtons
        '
        Me.tlpButtons.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.tlpButtons.ColumnCount = 5
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.tlpButtons.Controls.Add(Me.cmdForceQuit, 2, 0)
        Me.tlpButtons.Controls.Add(Me.cmdContinue, 4, 0)
        Me.tlpButtons.Controls.Add(Me.cmdSaveLog, 0, 0)
        Me.tlpButtons.Location = New System.Drawing.Point(236, 8)
        Me.tlpButtons.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 1
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButtons.Size = New System.Drawing.Size(344, 35)
        Me.tlpButtons.TabIndex = 12
        '
        'cmdSaveLog
        '
        Me.cmdSaveLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.cmdSaveLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdSaveLog.Enabled = False
        Me.cmdSaveLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdSaveLog.FlatAppearance.BorderSize = 0
        Me.cmdSaveLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdSaveLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdSaveLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSaveLog.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSaveLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdSaveLog.Location = New System.Drawing.Point(0, 0)
        Me.cmdSaveLog.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdSaveLog.Name = "cmdSaveLog"
        Me.cmdSaveLog.Size = New System.Drawing.Size(110, 35)
        Me.cmdSaveLog.TabIndex = 4
        Me.cmdSaveLog.TabStop = False
        Me.cmdSaveLog.Text = "Save Log"
        Me.cmdSaveLog.UseVisualStyleBackColor = False
        '
        'pnlLinks
        '
        Me.pnlLinks.Controls.Add(Me.lnkOpenIssue)
        Me.pnlLinks.Controls.Add(Me.lnkEmail)
        Me.pnlLinks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLinks.Location = New System.Drawing.Point(0, 0)
        Me.pnlLinks.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlLinks.Name = "pnlLinks"
        Me.pnlLinks.Size = New System.Drawing.Size(226, 52)
        Me.pnlLinks.TabIndex = 13
        '
        'lnkOpenIssue
        '
        Me.lnkOpenIssue.ActiveLinkColor = System.Drawing.Color.White
        Me.lnkOpenIssue.AutoSize = True
        Me.lnkOpenIssue.BackColor = System.Drawing.Color.Transparent
        Me.lnkOpenIssue.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkOpenIssue.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkOpenIssue.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnkOpenIssue.Location = New System.Drawing.Point(15, 14)
        Me.lnkOpenIssue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnkOpenIssue.Name = "lnkOpenIssue"
        Me.lnkOpenIssue.Size = New System.Drawing.Size(119, 23)
        Me.lnkOpenIssue.TabIndex = 0
        Me.lnkOpenIssue.TabStop = True
        Me.lnkOpenIssue.Text = "Open an Issue"
        '
        'lnkEmail
        '
        Me.lnkEmail.ActiveLinkColor = System.Drawing.Color.White
        Me.lnkEmail.AutoSize = True
        Me.lnkEmail.BackColor = System.Drawing.Color.Transparent
        Me.lnkEmail.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkEmail.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkEmail.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnkEmail.Location = New System.Drawing.Point(155, 14)
        Me.lnkEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnkEmail.Name = "lnkEmail"
        Me.lnkEmail.Size = New System.Drawing.Size(51, 23)
        Me.lnkEmail.TabIndex = 1
        Me.lnkEmail.TabStop = True
        Me.lnkEmail.Text = "Email"
        '
        'FormException
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(590, 345)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSplit)
        Me.Controls.Add(Me.pnlTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(590, 345)
        Me.MinimumSize = New System.Drawing.Size(590, 345)
        Me.Name = "FormException"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exception Handler"
        Me.pnlTitle.ResumeLayout(False)
        Me.tlpTitleIcon.ResumeLayout(False)
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.tlpControls.ResumeLayout(False)
        Me.tlpButtons.ResumeLayout(False)
        Me.pnlLinks.ResumeLayout(False)
        Me.pnlLinks.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents lblErrorMessage As System.Windows.Forms.Label
    Friend WithEvents cmdContinue As System.Windows.Forms.Button
    Friend WithEvents cmdForceQuit As System.Windows.Forms.Button
    Friend WithEvents pnlSplit As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents tlpButtons As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmdSaveLog As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents tlpTitleIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents icnMain As System.Windows.Forms.PictureBox
    Friend WithEvents lnkEmail As LinkLabel
    Friend WithEvents lnkOpenIssue As LinkLabel
    Friend WithEvents tlpCloseButton As TableLayoutPanel
    Friend WithEvents tlpControls As TableLayoutPanel
    Friend WithEvents pnlLinks As Panel
End Class
