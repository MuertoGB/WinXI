<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAbout))
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tlptitleIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.icnMain = New System.Windows.Forms.PictureBox()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lnkLinks = New System.Windows.Forms.LinkLabel()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.TlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpLabels = New System.Windows.Forms.TableLayoutPanel()
        Me.lblBuild = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.pnlTitle.SuspendLayout()
        Me.tlptitleIcon.SuspendLayout()
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.TlpTop.SuspendLayout()
        Me.tlpLabels.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Controls.Add(Me.cmdClose)
        Me.pnlTitle.Controls.Add(Me.tlptitleIcon)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(1, 1)
        Me.pnlTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(518, 40)
        Me.pnlTitle.TabIndex = 69
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(40, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(438, 40)
        Me.lblTitle.TabIndex = 69
        Me.lblTitle.Text = "About"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Transparent
        Me.cmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdClose.FlatAppearance.BorderSize = 0
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(478, 0)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.cmdClose.Size = New System.Drawing.Size(40, 40)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "✕"
        Me.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'tlptitleIcon
        '
        Me.tlptitleIcon.BackColor = System.Drawing.Color.Transparent
        Me.tlptitleIcon.ColumnCount = 1
        Me.tlptitleIcon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.tlptitleIcon.Controls.Add(Me.icnMain, 0, 0)
        Me.tlptitleIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlptitleIcon.Location = New System.Drawing.Point(0, 0)
        Me.tlptitleIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.tlptitleIcon.Name = "tlptitleIcon"
        Me.tlptitleIcon.RowCount = 1
        Me.tlptitleIcon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlptitleIcon.Size = New System.Drawing.Size(40, 40)
        Me.tlptitleIcon.TabIndex = 74
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
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.Location = New System.Drawing.Point(1, 41)
        Me.pnlSplit.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(518, 2)
        Me.pnlSplit.TabIndex = 72
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.lblText)
        Me.pnlMain.Controls.Add(Me.lnkLinks)
        Me.pnlMain.Controls.Add(Me.lblCopyright)
        Me.pnlMain.Controls.Add(Me.TlpTop)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(1, 43)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(518, 266)
        Me.pnlMain.TabIndex = 0
        '
        'lblText
        '
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblText.Location = New System.Drawing.Point(0, 142)
        Me.lblText.Name = "lblText"
        Me.lblText.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblText.Size = New System.Drawing.Size(518, 74)
        Me.lblText.TabIndex = 7
        Me.lblText.Text = "This software was created by, and is the intellectual property of David R, aka Mu" &
    "erto, so don't eat it. The 'Muerto' avatar was hand crafted by Hammi."
        '
        'lnkLinks
        '
        Me.lnkLinks.ActiveLinkColor = System.Drawing.Color.White
        Me.lnkLinks.BackColor = System.Drawing.Color.Transparent
        Me.lnkLinks.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lnkLinks.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkLinks.ForeColor = System.Drawing.Color.White
        Me.lnkLinks.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.lnkLinks.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkLinks.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnkLinks.Location = New System.Drawing.Point(0, 216)
        Me.lnkLinks.Margin = New System.Windows.Forms.Padding(0)
        Me.lnkLinks.Name = "lnkLinks"
        Me.lnkLinks.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lnkLinks.Size = New System.Drawing.Size(518, 50)
        Me.lnkLinks.TabIndex = 6
        Me.lnkLinks.Text = "Email Me · Source Code"
        Me.lnkLinks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCopyright
        '
        Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
        Me.lblCopyright.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCopyright.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblCopyright.Location = New System.Drawing.Point(0, 90)
        Me.lblCopyright.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblCopyright.Size = New System.Drawing.Size(518, 52)
        Me.lblCopyright.TabIndex = 0
        Me.lblCopyright.Text = "© David R 2016-2022."
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TlpTop
        '
        Me.TlpTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TlpTop.ColumnCount = 2
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TlpTop.Controls.Add(Me.tlpLabels, 1, 0)
        Me.TlpTop.Controls.Add(Me.pbxLogo, 0, 0)
        Me.TlpTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.TlpTop.Location = New System.Drawing.Point(0, 0)
        Me.TlpTop.Margin = New System.Windows.Forms.Padding(2)
        Me.TlpTop.Name = "TlpTop"
        Me.TlpTop.RowCount = 1
        Me.TlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpTop.Size = New System.Drawing.Size(518, 90)
        Me.TlpTop.TabIndex = 0
        '
        'tlpLabels
        '
        Me.tlpLabels.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tlpLabels.BackColor = System.Drawing.Color.Transparent
        Me.tlpLabels.ColumnCount = 1
        Me.tlpLabels.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLabels.Controls.Add(Me.lblBuild, 0, 1)
        Me.tlpLabels.Controls.Add(Me.lblName, 0, 0)
        Me.tlpLabels.Location = New System.Drawing.Point(96, 19)
        Me.tlpLabels.Margin = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.tlpLabels.Name = "tlpLabels"
        Me.tlpLabels.RowCount = 2
        Me.tlpLabels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlpLabels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.tlpLabels.Size = New System.Drawing.Size(311, 52)
        Me.tlpLabels.TabIndex = 86
        '
        'lblBuild
        '
        Me.lblBuild.AutoSize = True
        Me.lblBuild.BackColor = System.Drawing.Color.Transparent
        Me.lblBuild.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBuild.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuild.ForeColor = System.Drawing.Color.White
        Me.lblBuild.Location = New System.Drawing.Point(0, 26)
        Me.lblBuild.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBuild.Name = "lblBuild"
        Me.lblBuild.Size = New System.Drawing.Size(311, 26)
        Me.lblBuild.TabIndex = 78
        Me.lblBuild.Text = "..."
        Me.lblBuild.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(0, 0)
        Me.lblName.Margin = New System.Windows.Forms.Padding(0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(311, 26)
        Me.lblName.TabIndex = 75
        Me.lblName.Text = "WinXI"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxLogo
        '
        Me.pbxLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbxLogo.Image = Global.WinXI.My.Resources.Resources.imgMuerto
        Me.pbxLogo.Location = New System.Drawing.Point(13, 13)
        Me.pbxLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(64, 64)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 85
        Me.pbxLogo.TabStop = False
        '
        'FormAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(520, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSplit)
        Me.Controls.Add(Me.pnlTitle)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(520, 310)
        Me.MinimumSize = New System.Drawing.Size(520, 310)
        Me.Name = "FormAbout"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.pnlTitle.ResumeLayout(False)
        Me.tlptitleIcon.ResumeLayout(False)
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.TlpTop.ResumeLayout(False)
        Me.tlpLabels.ResumeLayout(False)
        Me.tlpLabels.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents pnlSplit As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents cmdClose As Button
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents tlpLabels As TableLayoutPanel
    Friend WithEvents lblName As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblBuild As Label
    Friend WithEvents TlpTop As TableLayoutPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents tlptitleIcon As TableLayoutPanel
    Friend WithEvents icnMain As PictureBox
    Friend WithEvents lnkLinks As LinkLabel
    Friend WithEvents lblText As Label
End Class
