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
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.lblText = New System.Windows.Forms.Label()
        Me.lnkLinks = New System.Windows.Forms.LinkLabel()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.TlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxLogo = New System.Windows.Forms.PictureBox()
        Me.TlpLabels = New System.Windows.Forms.TableLayoutPanel()
        Me.lblBuild = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.TlpTop.SuspendLayout()
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TlpLabels.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanHead
        '
        Me.PanHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PanHead.Controls.Add(Me.LabHead)
        Me.PanHead.Controls.Add(Me.CmdClose)
        Me.PanHead.Controls.Add(Me.TlpHeadImage)
        Me.PanHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanHead.Location = New System.Drawing.Point(1, 1)
        Me.PanHead.Margin = New System.Windows.Forms.Padding(0)
        Me.PanHead.Name = "PanHead"
        Me.PanHead.Size = New System.Drawing.Size(518, 40)
        Me.PanHead.TabIndex = 69
        '
        'LabHead
        '
        Me.LabHead.BackColor = System.Drawing.Color.Transparent
        Me.LabHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabHead.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHead.ForeColor = System.Drawing.Color.White
        Me.LabHead.Location = New System.Drawing.Point(40, 0)
        Me.LabHead.Margin = New System.Windows.Forms.Padding(0)
        Me.LabHead.Name = "LabHead"
        Me.LabHead.Size = New System.Drawing.Size(438, 40)
        Me.LabHead.TabIndex = 69
        Me.LabHead.Text = "About"
        Me.LabHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Transparent
        Me.CmdClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.CmdClose.FlatAppearance.BorderSize = 0
        Me.CmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(478, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(40, 40)
        Me.CmdClose.TabIndex = 0
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
        Me.CmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'TlpHeadImage
        '
        Me.TlpHeadImage.BackColor = System.Drawing.Color.Transparent
        Me.TlpHeadImage.ColumnCount = 1
        Me.TlpHeadImage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TlpHeadImage.Controls.Add(Me.PbxHead, 0, 0)
        Me.TlpHeadImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.TlpHeadImage.Location = New System.Drawing.Point(0, 0)
        Me.TlpHeadImage.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpHeadImage.Name = "TlpHeadImage"
        Me.TlpHeadImage.RowCount = 1
        Me.TlpHeadImage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpHeadImage.Size = New System.Drawing.Size(40, 40)
        Me.TlpHeadImage.TabIndex = 74
        '
        'PbxHead
        '
        Me.PbxHead.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PbxHead.BackColor = System.Drawing.Color.Transparent
        Me.PbxHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PbxHead.Image = Global.WinXI.My.Resources.Resources.ImgMainIcon24Px
        Me.PbxHead.Location = New System.Drawing.Point(9, 8)
        Me.PbxHead.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.PbxHead.Name = "PbxHead"
        Me.PbxHead.Size = New System.Drawing.Size(24, 24)
        Me.PbxHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxHead.TabIndex = 1
        Me.PbxHead.TabStop = False
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.Location = New System.Drawing.Point(1, 41)
        Me.PanSplit.Margin = New System.Windows.Forms.Padding(2)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(518, 2)
        Me.PanSplit.TabIndex = 72
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanMain.Controls.Add(Me.lblText)
        Me.PanMain.Controls.Add(Me.lnkLinks)
        Me.PanMain.Controls.Add(Me.lblCopyright)
        Me.PanMain.Controls.Add(Me.TlpTop)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 43)
        Me.PanMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Size = New System.Drawing.Size(518, 266)
        Me.PanMain.TabIndex = 0
        '
        'lblText
        '
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblText.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblText.Location = New System.Drawing.Point(0, 142)
        Me.lblText.Name = "lblText"
        Me.lblText.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblText.Size = New System.Drawing.Size(518, 66)
        Me.lblText.TabIndex = 7
        Me.lblText.Text = "This software was created by, and is the intellectual property of David R, aka Mu" &
    "erto. So don't eat it."
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
        Me.lnkLinks.Location = New System.Drawing.Point(0, 208)
        Me.lnkLinks.Margin = New System.Windows.Forms.Padding(0)
        Me.lnkLinks.Name = "lnkLinks"
        Me.lnkLinks.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lnkLinks.Size = New System.Drawing.Size(518, 58)
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
        Me.TlpTop.ColumnCount = 3
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.TlpTop.Controls.Add(Me.PbxLogo, 0, 0)
        Me.TlpTop.Controls.Add(Me.TlpLabels, 1, 0)
        Me.TlpTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.TlpTop.Location = New System.Drawing.Point(0, 0)
        Me.TlpTop.Margin = New System.Windows.Forms.Padding(2)
        Me.TlpTop.Name = "TlpTop"
        Me.TlpTop.RowCount = 1
        Me.TlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpTop.Size = New System.Drawing.Size(518, 90)
        Me.TlpTop.TabIndex = 0
        '
        'PbxLogo
        '
        Me.PbxLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbxLogo.Cursor = System.Windows.Forms.Cursors.Default
        Me.PbxLogo.Image = Global.WinXI.My.Resources.Resources.ImgMainIcon64Px
        Me.PbxLogo.Location = New System.Drawing.Point(13, 13)
        Me.PbxLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxLogo.Name = "PbxLogo"
        Me.PbxLogo.Size = New System.Drawing.Size(64, 64)
        Me.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbxLogo.TabIndex = 85
        Me.PbxLogo.TabStop = False
        '
        'TlpLabels
        '
        Me.TlpLabels.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TlpLabels.BackColor = System.Drawing.Color.Transparent
        Me.TlpLabels.ColumnCount = 1
        Me.TlpLabels.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpLabels.Controls.Add(Me.lblBuild, 0, 1)
        Me.TlpLabels.Controls.Add(Me.lblName, 0, 0)
        Me.TlpLabels.Location = New System.Drawing.Point(96, 19)
        Me.TlpLabels.Margin = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.TlpLabels.Name = "TlpLabels"
        Me.TlpLabels.RowCount = 2
        Me.TlpLabels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TlpLabels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TlpLabels.Size = New System.Drawing.Size(311, 52)
        Me.TlpLabels.TabIndex = 86
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
        'FormAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(520, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanSplit)
        Me.Controls.Add(Me.PanHead)
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
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.TlpTop.ResumeLayout(False)
        CType(Me.PbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TlpLabels.ResumeLayout(False)
        Me.TlpLabels.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanHead As System.Windows.Forms.Panel
    Friend WithEvents PanSplit As System.Windows.Forms.Panel
    Friend WithEvents PanMain As System.Windows.Forms.Panel
    Friend WithEvents CmdClose As Button
    Friend WithEvents PbxLogo As PictureBox
    Friend WithEvents TlpLabels As TableLayoutPanel
    Friend WithEvents lblName As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblBuild As Label
    Friend WithEvents TlpTop As TableLayoutPanel
    Friend WithEvents LabHead As Label
    Friend WithEvents TlpHeadImage As TableLayoutPanel
    Friend WithEvents PbxHead As PictureBox
    Friend WithEvents lnkLinks As LinkLabel
    Friend WithEvents lblText As Label
End Class
