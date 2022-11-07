<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHotfix
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHotfix))
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tlpTitleIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.icnMain = New System.Windows.Forms.PictureBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblInfoTwo = New System.Windows.Forms.Label()
        Me.tlpLink = New System.Windows.Forms.TableLayoutPanel()
        Me.lblLink = New System.Windows.Forms.Label()
        Me.lnkHotfix = New System.Windows.Forms.LinkLabel()
        Me.tlpControls = New System.Windows.Forms.TableLayoutPanel()
        Me.lblDownload = New System.Windows.Forms.Label()
        Me.pbxLoading = New System.Windows.Forms.PictureBox()
        Me.tlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdInstall = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.pnlTitle.SuspendLayout()
        Me.tlpTitleIcon.SuspendLayout()
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.tlpLink.SuspendLayout()
        Me.tlpControls.SuspendLayout()
        CType(Me.pbxLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Controls.Add(Me.tlpTitleIcon)
        Me.pnlTitle.Controls.Add(Me.cmdClose)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(1, 1)
        Me.pnlTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(563, 40)
        Me.pnlTitle.TabIndex = 126
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
        Me.lblTitle.Size = New System.Drawing.Size(483, 40)
        Me.lblTitle.TabIndex = 70
        Me.lblTitle.Text = "Application Support"
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
        Me.tlpTitleIcon.TabIndex = 73
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
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Transparent
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdClose.FlatAppearance.BorderSize = 0
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(523, 0)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.cmdClose.Size = New System.Drawing.Size(40, 40)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "✕"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.ForeColor = System.Drawing.Color.Black
        Me.pnlSplit.Location = New System.Drawing.Point(1, 41)
        Me.pnlSplit.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(563, 2)
        Me.pnlSplit.TabIndex = 127
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.lblInfoTwo)
        Me.pnlMain.Controls.Add(Me.tlpLink)
        Me.pnlMain.Controls.Add(Me.tlpControls)
        Me.pnlMain.Controls.Add(Me.lblInfo)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(1, 43)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(563, 296)
        Me.pnlMain.TabIndex = 128
        '
        'lblInfoTwo
        '
        Me.lblInfoTwo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblInfoTwo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoTwo.ForeColor = System.Drawing.Color.White
        Me.lblInfoTwo.Location = New System.Drawing.Point(0, 108)
        Me.lblInfoTwo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfoTwo.Name = "lblInfoTwo"
        Me.lblInfoTwo.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.lblInfoTwo.Size = New System.Drawing.Size(563, 88)
        Me.lblInfoTwo.TabIndex = 132
        Me.lblInfoTwo.Text = "Click 'Install' to patch this system with KB2687862, or 'Cancel' to ignore. For m" &
    "ore details click the link below. Please save any work before you continue as a " &
    "restart may be required."
        Me.lblInfoTwo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpLink
        '
        Me.tlpLink.ColumnCount = 2
        Me.tlpLink.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.749556!))
        Me.tlpLink.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.25044!))
        Me.tlpLink.Controls.Add(Me.lblLink, 0, 0)
        Me.tlpLink.Controls.Add(Me.lnkHotfix, 1, 0)
        Me.tlpLink.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpLink.Location = New System.Drawing.Point(0, 207)
        Me.tlpLink.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpLink.Name = "tlpLink"
        Me.tlpLink.RowCount = 1
        Me.tlpLink.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLink.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLink.Size = New System.Drawing.Size(563, 30)
        Me.tlpLink.TabIndex = 138
        '
        'lblLink
        '
        Me.lblLink.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblLink.AutoSize = True
        Me.lblLink.Font = New System.Drawing.Font("Segoe MDL2 Assets", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLink.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lblLink.Location = New System.Drawing.Point(2, 5)
        Me.lblLink.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.lblLink.Size = New System.Drawing.Size(34, 19)
        Me.lblLink.TabIndex = 137
        Me.lblLink.Text = ""
        '
        'lnkHotfix
        '
        Me.lnkHotfix.ActiveLinkColor = System.Drawing.Color.White
        Me.lnkHotfix.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lnkHotfix.AutoSize = True
        Me.lnkHotfix.BackColor = System.Drawing.Color.Transparent
        Me.lnkHotfix.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkHotfix.ForeColor = System.Drawing.Color.White
        Me.lnkHotfix.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkHotfix.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnkHotfix.Location = New System.Drawing.Point(40, 3)
        Me.lnkHotfix.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnkHotfix.Name = "lnkHotfix"
        Me.lnkHotfix.Size = New System.Drawing.Size(150, 23)
        Me.lnkHotfix.TabIndex = 0
        Me.lnkHotfix.TabStop = True
        Me.lnkHotfix.Text = "Hotfix Information"
        '
        'tlpControls
        '
        Me.tlpControls.ColumnCount = 3
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 345.0!))
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212.0!))
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpControls.Controls.Add(Me.lblDownload, 0, 0)
        Me.tlpControls.Controls.Add(Me.pbxLoading, 1, 0)
        Me.tlpControls.Controls.Add(Me.tlpButtons, 2, 0)
        Me.tlpControls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpControls.Location = New System.Drawing.Point(0, 237)
        Me.tlpControls.Margin = New System.Windows.Forms.Padding(2, 2, 2, 68)
        Me.tlpControls.Name = "tlpControls"
        Me.tlpControls.RowCount = 1
        Me.tlpControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpControls.Size = New System.Drawing.Size(563, 59)
        Me.tlpControls.TabIndex = 136
        '
        'lblDownload
        '
        Me.lblDownload.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblDownload.AutoSize = True
        Me.lblDownload.BackColor = System.Drawing.Color.Transparent
        Me.lblDownload.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownload.ForeColor = System.Drawing.Color.White
        Me.lblDownload.Location = New System.Drawing.Point(2, 18)
        Me.lblDownload.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDownload.Name = "lblDownload"
        Me.lblDownload.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblDownload.Size = New System.Drawing.Size(5, 23)
        Me.lblDownload.TabIndex = 1
        '
        'pbxLoading
        '
        Me.pbxLoading.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.pbxLoading.Location = New System.Drawing.Point(345, 17)
        Me.pbxLoading.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxLoading.Name = "pbxLoading"
        Me.pbxLoading.Size = New System.Drawing.Size(24, 24)
        Me.pbxLoading.TabIndex = 3
        Me.pbxLoading.TabStop = False
        '
        'tlpButtons
        '
        Me.tlpButtons.ColumnCount = 2
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.tlpButtons.Controls.Add(Me.cmdInstall, 1, 0)
        Me.tlpButtons.Controls.Add(Me.cmdCancel, 0, 0)
        Me.tlpButtons.Location = New System.Drawing.Point(377, 2)
        Me.tlpButtons.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 1
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButtons.Size = New System.Drawing.Size(180, 52)
        Me.tlpButtons.TabIndex = 4
        '
        'cmdInstall
        '
        Me.cmdInstall.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdInstall.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.cmdInstall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdInstall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdInstall.FlatAppearance.BorderSize = 0
        Me.cmdInstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdInstall.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInstall.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdInstall.Location = New System.Drawing.Point(94, 7)
        Me.cmdInstall.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdInstall.Name = "cmdInstall"
        Me.cmdInstall.Size = New System.Drawing.Size(82, 38)
        Me.cmdInstall.TabIndex = 2
        Me.cmdInstall.Text = "Install"
        Me.cmdInstall.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.cmdCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdCancel.FlatAppearance.BorderSize = 0
        Me.cmdCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdCancel.Location = New System.Drawing.Point(4, 7)
        Me.cmdCancel.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(82, 38)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblInfo.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(0, 0)
        Me.lblInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Padding = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.lblInfo.Size = New System.Drawing.Size(563, 108)
        Me.lblInfo.TabIndex = 0
        Me.lblInfo.Text = resources.GetString("lblInfo.Text")
        '
        'FormHotfix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(565, 340)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSplit)
        Me.Controls.Add(Me.pnlTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(565, 340)
        Me.MinimumSize = New System.Drawing.Size(565, 340)
        Me.Name = "FormHotfix"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Application Support"
        Me.pnlTitle.ResumeLayout(False)
        Me.tlpTitleIcon.ResumeLayout(False)
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.tlpLink.ResumeLayout(False)
        Me.tlpLink.PerformLayout()
        Me.tlpControls.ResumeLayout(False)
        Me.tlpControls.PerformLayout()
        CType(Me.pbxLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitle As Panel
    Friend WithEvents cmdClose As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents pnlSplit As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblInfo As Label
    Friend WithEvents lnkHotfix As LinkLabel
    Friend WithEvents lblInfoTwo As Label
    Friend WithEvents tlpControls As TableLayoutPanel
    Friend WithEvents cmdInstall As Button
    Friend WithEvents cmdCancel As Button
    Friend WithEvents lblDownload As Label
    Friend WithEvents pbxLoading As PictureBox
    Friend WithEvents tlpTitleIcon As TableLayoutPanel
    Friend WithEvents icnMain As PictureBox
    Friend WithEvents tlpButtons As TableLayoutPanel
    Friend WithEvents lblLink As Label
    Friend WithEvents tlpLink As TableLayoutPanel
End Class
