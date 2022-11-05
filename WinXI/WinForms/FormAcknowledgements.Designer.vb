<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAcknowledgements
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAcknowledgements))
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tlpTitleIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.icnMain = New System.Windows.Forms.PictureBox()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.tlpForm = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpImageResources = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpImgLinks = New System.Windows.Forms.TableLayoutPanel()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.pbxError = New System.Windows.Forms.PictureBox()
        Me.lnkError = New System.Windows.Forms.LinkLabel()
        Me.pbxInfo = New System.Windows.Forms.PictureBox()
        Me.pbxWarn = New System.Windows.Forms.PictureBox()
        Me.lnkGraph = New System.Windows.Forms.LinkLabel()
        Me.lnkWarn = New System.Windows.Forms.LinkLabel()
        Me.lnkIcon = New System.Windows.Forms.LinkLabel()
        Me.lblImages = New System.Windows.Forms.Label()
        Me.lblCopyrights = New System.Windows.Forms.Label()
        Me.lnkMicrosoft = New System.Windows.Forms.LinkLabel()
        Me.lblThanks = New System.Windows.Forms.Label()
        Me.lnkCredits = New System.Windows.Forms.LinkLabel()
        Me.pnlTitle.SuspendLayout()
        Me.tlpTitleIcon.SuspendLayout()
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.tlpForm.SuspendLayout()
        Me.tlpImageResources.SuspendLayout()
        Me.tlpImgLinks.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxError, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxWarn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Controls.Add(Me.cmdClose)
        Me.pnlTitle.Controls.Add(Me.tlpTitleIcon)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(1, 1)
        Me.pnlTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(518, 40)
        Me.pnlTitle.TabIndex = 70
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
        Me.lblTitle.Size = New System.Drawing.Size(438, 40)
        Me.lblTitle.TabIndex = 69
        Me.lblTitle.Text = "Acknowledgements"
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
        Me.tlpTitleIcon.TabIndex = 74
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
        Me.pnlSplit.TabIndex = 73
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.tlpForm)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(1, 43)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(9)
        Me.pnlMain.Size = New System.Drawing.Size(518, 476)
        Me.pnlMain.TabIndex = 74
        '
        'tlpForm
        '
        Me.tlpForm.ColumnCount = 1
        Me.tlpForm.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpForm.Controls.Add(Me.tlpImageResources, 0, 6)
        Me.tlpForm.Controls.Add(Me.lblCopyrights, 0, 0)
        Me.tlpForm.Controls.Add(Me.lnkMicrosoft, 0, 1)
        Me.tlpForm.Controls.Add(Me.lblThanks, 0, 3)
        Me.tlpForm.Controls.Add(Me.lnkCredits, 0, 4)
        Me.tlpForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpForm.Location = New System.Drawing.Point(9, 9)
        Me.tlpForm.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpForm.Name = "tlpForm"
        Me.tlpForm.RowCount = 7
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1.0!))
        Me.tlpForm.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175.0!))
        Me.tlpForm.Size = New System.Drawing.Size(500, 458)
        Me.tlpForm.TabIndex = 1
        '
        'tlpImageResources
        '
        Me.tlpImageResources.ColumnCount = 1
        Me.tlpImageResources.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500.0!))
        Me.tlpImageResources.Controls.Add(Me.tlpImgLinks, 0, 1)
        Me.tlpImageResources.Controls.Add(Me.lblImages, 0, 0)
        Me.tlpImageResources.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpImageResources.Location = New System.Drawing.Point(0, 262)
        Me.tlpImageResources.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpImageResources.Name = "tlpImageResources"
        Me.tlpImageResources.RowCount = 2
        Me.tlpImageResources.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpImageResources.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpImageResources.Size = New System.Drawing.Size(500, 196)
        Me.tlpImageResources.TabIndex = 0
        '
        'tlpImgLinks
        '
        Me.tlpImgLinks.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tlpImgLinks.ColumnCount = 2
        Me.tlpImgLinks.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.886264!))
        Me.tlpImgLinks.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.11374!))
        Me.tlpImgLinks.Controls.Add(Me.pbxLogo, 0, 1)
        Me.tlpImgLinks.Controls.Add(Me.pbxError, 0, 4)
        Me.tlpImgLinks.Controls.Add(Me.lnkError, 1, 4)
        Me.tlpImgLinks.Controls.Add(Me.pbxInfo, 0, 2)
        Me.tlpImgLinks.Controls.Add(Me.pbxWarn, 0, 3)
        Me.tlpImgLinks.Controls.Add(Me.lnkGraph, 1, 1)
        Me.tlpImgLinks.Controls.Add(Me.lnkWarn, 1, 3)
        Me.tlpImgLinks.Controls.Add(Me.lnkIcon, 1, 2)
        Me.tlpImgLinks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpImgLinks.Location = New System.Drawing.Point(0, 30)
        Me.tlpImgLinks.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpImgLinks.Name = "tlpImgLinks"
        Me.tlpImgLinks.RowCount = 6
        Me.tlpImgLinks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.tlpImgLinks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpImgLinks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpImgLinks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpImgLinks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpImgLinks.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpImgLinks.Size = New System.Drawing.Size(500, 166)
        Me.tlpImgLinks.TabIndex = 129
        '
        'pbxLogo
        '
        Me.pbxLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxLogo.Image = Global.WinXI.My.Resources.Resources.ImgMainIcon24Px
        Me.pbxLogo.Location = New System.Drawing.Point(9, 9)
        Me.pbxLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(30, 30)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 0
        Me.pbxLogo.TabStop = False
        '
        'pbxError
        '
        Me.pbxError.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxError.Image = Global.WinXI.My.Resources.Resources.ImgError32Px
        Me.pbxError.Location = New System.Drawing.Point(9, 129)
        Me.pbxError.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxError.Name = "pbxError"
        Me.pbxError.Size = New System.Drawing.Size(30, 30)
        Me.pbxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxError.TabIndex = 2
        Me.pbxError.TabStop = False
        '
        'lnkError
        '
        Me.lnkError.ActiveLinkColor = System.Drawing.Color.White
        Me.lnkError.BackColor = System.Drawing.Color.Transparent
        Me.lnkError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnkError.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkError.ForeColor = System.Drawing.Color.White
        Me.lnkError.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.lnkError.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkError.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnkError.Location = New System.Drawing.Point(61, 124)
        Me.lnkError.Margin = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.lnkError.Name = "lnkError"
        Me.lnkError.Size = New System.Drawing.Size(439, 40)
        Me.lnkError.TabIndex = 14
        Me.lnkError.Text = "Error icon by Smashicons from Flaticon."
        Me.lnkError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbxInfo
        '
        Me.pbxInfo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxInfo.Image = Global.WinXI.My.Resources.Resources.ImgInfo32Px
        Me.pbxInfo.Location = New System.Drawing.Point(9, 49)
        Me.pbxInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxInfo.Name = "pbxInfo"
        Me.pbxInfo.Size = New System.Drawing.Size(30, 30)
        Me.pbxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxInfo.TabIndex = 1
        Me.pbxInfo.TabStop = False
        '
        'pbxWarn
        '
        Me.pbxWarn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxWarn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxWarn.Image = Global.WinXI.My.Resources.Resources.ImgWarn32Px
        Me.pbxWarn.Location = New System.Drawing.Point(9, 89)
        Me.pbxWarn.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxWarn.Name = "pbxWarn"
        Me.pbxWarn.Size = New System.Drawing.Size(30, 30)
        Me.pbxWarn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxWarn.TabIndex = 3
        Me.pbxWarn.TabStop = False
        '
        'lnkGraph
        '
        Me.lnkGraph.ActiveLinkColor = System.Drawing.Color.White
        Me.lnkGraph.BackColor = System.Drawing.Color.Transparent
        Me.lnkGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnkGraph.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkGraph.ForeColor = System.Drawing.Color.White
        Me.lnkGraph.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.lnkGraph.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkGraph.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnkGraph.Location = New System.Drawing.Point(61, 4)
        Me.lnkGraph.Margin = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.lnkGraph.Name = "lnkGraph"
        Me.lnkGraph.Size = New System.Drawing.Size(439, 40)
        Me.lnkGraph.TabIndex = 1
        Me.lnkGraph.Text = "Graph icon by Vectors Market from Flaticon."
        Me.lnkGraph.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lnkWarn
        '
        Me.lnkWarn.ActiveLinkColor = System.Drawing.Color.White
        Me.lnkWarn.BackColor = System.Drawing.Color.Transparent
        Me.lnkWarn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnkWarn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkWarn.ForeColor = System.Drawing.Color.White
        Me.lnkWarn.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.lnkWarn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkWarn.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnkWarn.Location = New System.Drawing.Point(61, 84)
        Me.lnkWarn.Margin = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.lnkWarn.Name = "lnkWarn"
        Me.lnkWarn.Size = New System.Drawing.Size(439, 40)
        Me.lnkWarn.TabIndex = 132
        Me.lnkWarn.Text = "Warning icon by Freepik from Flaticon."
        Me.lnkWarn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lnkIcon
        '
        Me.lnkIcon.ActiveLinkColor = System.Drawing.Color.White
        Me.lnkIcon.BackColor = System.Drawing.Color.Transparent
        Me.lnkIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnkIcon.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkIcon.ForeColor = System.Drawing.Color.White
        Me.lnkIcon.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.lnkIcon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkIcon.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnkIcon.Location = New System.Drawing.Point(61, 44)
        Me.lnkIcon.Margin = New System.Windows.Forms.Padding(12, 0, 0, 0)
        Me.lnkIcon.Name = "lnkIcon"
        Me.lnkIcon.Size = New System.Drawing.Size(439, 40)
        Me.lnkIcon.TabIndex = 11
        Me.lnkIcon.Text = "Information icon by Freepik from Flaticon."
        Me.lnkIcon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblImages
        '
        Me.lblImages.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblImages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblImages.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImages.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblImages.Location = New System.Drawing.Point(0, 0)
        Me.lblImages.Margin = New System.Windows.Forms.Padding(0)
        Me.lblImages.Name = "lblImages"
        Me.lblImages.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblImages.Size = New System.Drawing.Size(500, 30)
        Me.lblImages.TabIndex = 127
        Me.lblImages.Text = "Image Resources"
        Me.lblImages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCopyrights
        '
        Me.lblCopyrights.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblCopyrights.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCopyrights.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyrights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblCopyrights.Location = New System.Drawing.Point(0, 0)
        Me.lblCopyrights.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCopyrights.Name = "lblCopyrights"
        Me.lblCopyrights.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblCopyrights.Size = New System.Drawing.Size(500, 30)
        Me.lblCopyrights.TabIndex = 125
        Me.lblCopyrights.Text = "Copyrights"
        Me.lblCopyrights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lnkMicrosoft
        '
        Me.lnkMicrosoft.ActiveLinkColor = System.Drawing.Color.White
        Me.lnkMicrosoft.AutoSize = True
        Me.lnkMicrosoft.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lnkMicrosoft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnkMicrosoft.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkMicrosoft.ForeColor = System.Drawing.Color.White
        Me.lnkMicrosoft.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.lnkMicrosoft.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkMicrosoft.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnkMicrosoft.Location = New System.Drawing.Point(0, 30)
        Me.lnkMicrosoft.Margin = New System.Windows.Forms.Padding(0)
        Me.lnkMicrosoft.Name = "lnkMicrosoft"
        Me.lnkMicrosoft.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.lnkMicrosoft.Size = New System.Drawing.Size(500, 100)
        Me.lnkMicrosoft.TabIndex = 129
        Me.lnkMicrosoft.Text = "Microsoft®, Windows®, and the Windows® Experience Index are either registered tra" &
    "demarks or trademarks of Microsoft Corporation in the United States and/or other" &
    " countries."
        Me.lnkMicrosoft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblThanks
        '
        Me.lblThanks.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.lblThanks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblThanks.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThanks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblThanks.Location = New System.Drawing.Point(0, 131)
        Me.lblThanks.Margin = New System.Windows.Forms.Padding(0)
        Me.lblThanks.Name = "lblThanks"
        Me.lblThanks.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblThanks.Size = New System.Drawing.Size(500, 30)
        Me.lblThanks.TabIndex = 126
        Me.lblThanks.Text = "Thank you"
        Me.lblThanks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lnkCredits
        '
        Me.lnkCredits.ActiveLinkColor = System.Drawing.Color.White
        Me.lnkCredits.AutoSize = True
        Me.lnkCredits.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lnkCredits.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnkCredits.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkCredits.ForeColor = System.Drawing.Color.White
        Me.lnkCredits.LinkArea = New System.Windows.Forms.LinkArea(0, 0)
        Me.lnkCredits.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkCredits.LinkColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lnkCredits.Location = New System.Drawing.Point(0, 161)
        Me.lnkCredits.Margin = New System.Windows.Forms.Padding(0)
        Me.lnkCredits.Name = "lnkCredits"
        Me.lnkCredits.Padding = New System.Windows.Forms.Padding(4, 0, 0, 0)
        Me.lnkCredits.Size = New System.Drawing.Size(500, 100)
        Me.lnkCredits.TabIndex = 130
        Me.lnkCredits.Text = "ItielMaN, Carlos Detweiller, Michaela Joy, Tiger-1, BJ0RN, apologized and GezoeSl" &
    "oog at MyDigitalLife for development help and testing. Majorgeeks and Softpedia " &
    "for hosting my software."
        Me.lnkCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormAcknowledgements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(520, 520)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSplit)
        Me.Controls.Add(Me.pnlTitle)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(520, 520)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(520, 520)
        Me.Name = "FormAcknowledgements"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Acknowledgements"
        Me.pnlTitle.ResumeLayout(False)
        Me.tlpTitleIcon.ResumeLayout(False)
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.tlpForm.ResumeLayout(False)
        Me.tlpForm.PerformLayout()
        Me.tlpImageResources.ResumeLayout(False)
        Me.tlpImgLinks.ResumeLayout(False)
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxError, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxWarn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTitle As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents cmdClose As Button
    Friend WithEvents tlpTitleIcon As TableLayoutPanel
    Friend WithEvents icnMain As PictureBox
    Friend WithEvents pnlSplit As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents tlpImageResources As TableLayoutPanel
    Friend WithEvents tlpForm As TableLayoutPanel
    Friend WithEvents lblCopyrights As Label
    Friend WithEvents lblThanks As Label
    Friend WithEvents lnkMicrosoft As LinkLabel
    Friend WithEvents lnkCredits As LinkLabel
    Friend WithEvents lblImages As Label
    Friend WithEvents tlpImgLinks As TableLayoutPanel
    Friend WithEvents pbxLogo As PictureBox
    Friend WithEvents pbxError As PictureBox
    Friend WithEvents lnkError As LinkLabel
    Friend WithEvents pbxInfo As PictureBox
    Friend WithEvents pbxWarn As PictureBox
    Friend WithEvents lnkGraph As LinkLabel
    Friend WithEvents lnkWarn As LinkLabel
    Friend WithEvents lnkIcon As LinkLabel
End Class
