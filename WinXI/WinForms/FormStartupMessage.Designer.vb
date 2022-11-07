<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStartupMessage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStartupMessage))
        Me.cmdOkay = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tlpCloseButton = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpTitleIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.icnMain = New System.Windows.Forms.PictureBox()
        Me.lnkIssue = New System.Windows.Forms.LinkLabel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.tlpControls = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlTitle.SuspendLayout()
        Me.tlpTitleIcon.SuspendLayout()
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.tlpControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOkay
        '
        Me.cmdOkay.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdOkay.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.cmdOkay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdOkay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdOkay.FlatAppearance.BorderSize = 0
        Me.cmdOkay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdOkay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOkay.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOkay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdOkay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOkay.Location = New System.Drawing.Point(345, 8)
        Me.cmdOkay.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
        Me.cmdOkay.Name = "cmdOkay"
        Me.cmdOkay.Size = New System.Drawing.Size(75, 35)
        Me.cmdOkay.TabIndex = 1
        Me.cmdOkay.Text = "OK"
        Me.cmdOkay.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMessage.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.White
        Me.lblMessage.Location = New System.Drawing.Point(0, 2)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Padding = New System.Windows.Forms.Padding(9)
        Me.lblMessage.Size = New System.Drawing.Size(428, 115)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "No startup message was set."
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Controls.Add(Me.tlpCloseButton)
        Me.pnlTitle.Controls.Add(Me.tlpTitleIcon)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(1, 1)
        Me.pnlTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(428, 40)
        Me.pnlTitle.TabIndex = 1
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(40, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(348, 40)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Application Support"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpCloseButton
        '
        Me.tlpCloseButton.BackColor = System.Drawing.Color.Transparent
        Me.tlpCloseButton.ColumnCount = 1
        Me.tlpCloseButton.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCloseButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.tlpCloseButton.Location = New System.Drawing.Point(388, 0)
        Me.tlpCloseButton.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpCloseButton.Name = "tlpCloseButton"
        Me.tlpCloseButton.RowCount = 1
        Me.tlpCloseButton.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpCloseButton.Size = New System.Drawing.Size(40, 40)
        Me.tlpCloseButton.TabIndex = 11
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
        Me.tlpTitleIcon.TabIndex = 10
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
        'lnkIssue
        '
        Me.lnkIssue.ActiveLinkColor = System.Drawing.Color.White
        Me.lnkIssue.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lnkIssue.AutoSize = True
        Me.lnkIssue.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkIssue.ForeColor = System.Drawing.Color.White
        Me.lnkIssue.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkIssue.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnkIssue.Location = New System.Drawing.Point(8, 14)
        Me.lnkIssue.Margin = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.lnkIssue.Name = "lnkIssue"
        Me.lnkIssue.Size = New System.Drawing.Size(119, 23)
        Me.lnkIssue.TabIndex = 0
        Me.lnkIssue.TabStop = True
        Me.lnkIssue.Text = "Open an Issue"
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.lblMessage)
        Me.pnlMain.Controls.Add(Me.tlpControls)
        Me.pnlMain.Controls.Add(Me.pnlSplit)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(1, 41)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(428, 168)
        Me.pnlMain.TabIndex = 7
        '
        'tlpControls
        '
        Me.tlpControls.ColumnCount = 2
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpControls.Controls.Add(Me.lnkIssue, 0, 0)
        Me.tlpControls.Controls.Add(Me.cmdOkay, 1, 0)
        Me.tlpControls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpControls.Location = New System.Drawing.Point(0, 117)
        Me.tlpControls.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpControls.Name = "tlpControls"
        Me.tlpControls.RowCount = 1
        Me.tlpControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpControls.Size = New System.Drawing.Size(428, 51)
        Me.tlpControls.TabIndex = 74
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.Location = New System.Drawing.Point(0, 0)
        Me.pnlSplit.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(428, 2)
        Me.pnlSplit.TabIndex = 73
        '
        'FormStartupMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 210)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(430, 210)
        Me.MinimumSize = New System.Drawing.Size(430, 210)
        Me.Name = "FormStartupMessage"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application Support (Unsupported OS)"
        Me.pnlTitle.ResumeLayout(False)
        Me.tlpTitleIcon.ResumeLayout(False)
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.tlpControls.ResumeLayout(False)
        Me.tlpControls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents cmdOkay As System.Windows.Forms.Button
    Friend WithEvents lnkIssue As System.Windows.Forms.LinkLabel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlSplit As System.Windows.Forms.Panel
    Friend WithEvents tlpTitleIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents icnMain As System.Windows.Forms.PictureBox
    Friend WithEvents tlpControls As TableLayoutPanel
    Friend WithEvents tlpCloseButton As TableLayoutPanel
End Class
