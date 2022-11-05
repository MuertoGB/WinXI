<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormScoreData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormScoreData))
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tlpTitleIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.icnMain = New System.Windows.Forms.PictureBox()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.rtbData = New System.Windows.Forms.RichTextBox()
        Me.tlpMenuControls = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdProgramInfo = New System.Windows.Forms.Button()
        Me.cmdSystemEnvironment = New System.Windows.Forms.Button()
        Me.cmdWinSPR = New System.Windows.Forms.Button()
        Me.cmdMetrics = New System.Windows.Forms.Button()
        Me.cmdOSVersion = New System.Windows.Forms.Button()
        Me.cmdGraphics = New System.Windows.Forms.Button()
        Me.cmdMemory = New System.Windows.Forms.Button()
        Me.cmdProcessor = New System.Windows.Forms.Button()
        Me.cmdSystem = New System.Windows.Forms.Button()
        Me.cmdDisk = New System.Windows.Forms.Button()
        Me.cmdDwm = New System.Windows.Forms.Button()
        Me.cmdD3d = New System.Windows.Forms.Button()
        Me.PbxProgramInfo = New System.Windows.Forms.PictureBox()
        Me.pbxSystemEnvironmentSelected = New System.Windows.Forms.PictureBox()
        Me.pbxWinSPRSelected = New System.Windows.Forms.PictureBox()
        Me.pbxMetricsSelected = New System.Windows.Forms.PictureBox()
        Me.pbxOSSelected = New System.Windows.Forms.PictureBox()
        Me.PbxSystem = New System.Windows.Forms.PictureBox()
        Me.PbxProcessor = New System.Windows.Forms.PictureBox()
        Me.pbxMemorySelected = New System.Windows.Forms.PictureBox()
        Me.pbxGraphicsSelected = New System.Windows.Forms.PictureBox()
        Me.pbxDiskSelected = New System.Windows.Forms.PictureBox()
        Me.pbxDwmSelected = New System.Windows.Forms.PictureBox()
        Me.pbxD3dSelected = New System.Windows.Forms.PictureBox()
        Me.pnlTitle.SuspendLayout()
        Me.tlpTitleIcon.SuspendLayout()
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.tlpMain.SuspendLayout()
        Me.tlpMenuControls.SuspendLayout()
        CType(Me.PbxProgramInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSystemEnvironmentSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxWinSPRSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMetricsSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxOSSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxSystem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxProcessor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxMemorySelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGraphicsSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDiskSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDwmSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxD3dSelected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.Location = New System.Drawing.Point(1, 41)
        Me.pnlSplit.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(998, 2)
        Me.pnlSplit.TabIndex = 74
        '
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pnlTitle.Controls.Add(Me.lblTitle)
        Me.pnlTitle.Controls.Add(Me.cmdClose)
        Me.pnlTitle.Controls.Add(Me.tlpTitleIcon)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTitle.Location = New System.Drawing.Point(1, 1)
        Me.pnlTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(998, 40)
        Me.pnlTitle.TabIndex = 73
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
        Me.lblTitle.Size = New System.Drawing.Size(918, 40)
        Me.lblTitle.TabIndex = 96
        Me.lblTitle.Text = "WinSAT Score Data"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Transparent
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdClose.FlatAppearance.BorderSize = 0
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(958, 0)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.cmdClose.Size = New System.Drawing.Size(40, 40)
        Me.cmdClose.TabIndex = 95
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "✕"
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
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.tlpMain)
        Me.pnlMain.Controls.Add(Me.tlpMenuControls)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(1, 43)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(998, 556)
        Me.pnlMain.TabIndex = 75
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.Controls.Add(Me.rtbData, 0, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(198, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.Padding = New System.Windows.Forms.Padding(4, 9, 4, 9)
        Me.tlpMain.RowCount = 1
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.Size = New System.Drawing.Size(800, 556)
        Me.tlpMain.TabIndex = 2
        '
        'rtbData
        '
        Me.rtbData.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rtbData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbData.DetectUrls = False
        Me.rtbData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbData.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbData.ForeColor = System.Drawing.Color.White
        Me.rtbData.Location = New System.Drawing.Point(6, 11)
        Me.rtbData.Margin = New System.Windows.Forms.Padding(2)
        Me.rtbData.Name = "rtbData"
        Me.rtbData.ReadOnly = True
        Me.rtbData.Size = New System.Drawing.Size(788, 534)
        Me.rtbData.TabIndex = 0
        Me.rtbData.TabStop = False
        Me.rtbData.Text = ""
        '
        'tlpMenuControls
        '
        Me.tlpMenuControls.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tlpMenuControls.ColumnCount = 2
        Me.tlpMenuControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMenuControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2.0!))
        Me.tlpMenuControls.Controls.Add(Me.cmdProgramInfo, 0, 1)
        Me.tlpMenuControls.Controls.Add(Me.cmdSystemEnvironment, 0, 2)
        Me.tlpMenuControls.Controls.Add(Me.cmdWinSPR, 0, 3)
        Me.tlpMenuControls.Controls.Add(Me.cmdMetrics, 0, 4)
        Me.tlpMenuControls.Controls.Add(Me.cmdOSVersion, 0, 5)
        Me.tlpMenuControls.Controls.Add(Me.cmdGraphics, 0, 9)
        Me.tlpMenuControls.Controls.Add(Me.cmdMemory, 0, 8)
        Me.tlpMenuControls.Controls.Add(Me.cmdProcessor, 0, 7)
        Me.tlpMenuControls.Controls.Add(Me.cmdSystem, 0, 6)
        Me.tlpMenuControls.Controls.Add(Me.cmdDisk, 0, 10)
        Me.tlpMenuControls.Controls.Add(Me.cmdDwm, 0, 11)
        Me.tlpMenuControls.Controls.Add(Me.cmdD3d, 0, 12)
        Me.tlpMenuControls.Controls.Add(Me.PbxProgramInfo, 1, 1)
        Me.tlpMenuControls.Controls.Add(Me.pbxSystemEnvironmentSelected, 1, 2)
        Me.tlpMenuControls.Controls.Add(Me.pbxWinSPRSelected, 1, 3)
        Me.tlpMenuControls.Controls.Add(Me.pbxMetricsSelected, 1, 4)
        Me.tlpMenuControls.Controls.Add(Me.pbxOSSelected, 1, 5)
        Me.tlpMenuControls.Controls.Add(Me.PbxSystem, 1, 6)
        Me.tlpMenuControls.Controls.Add(Me.PbxProcessor, 1, 7)
        Me.tlpMenuControls.Controls.Add(Me.pbxMemorySelected, 1, 8)
        Me.tlpMenuControls.Controls.Add(Me.pbxGraphicsSelected, 1, 9)
        Me.tlpMenuControls.Controls.Add(Me.pbxDiskSelected, 1, 10)
        Me.tlpMenuControls.Controls.Add(Me.pbxDwmSelected, 1, 11)
        Me.tlpMenuControls.Controls.Add(Me.pbxD3dSelected, 1, 12)
        Me.tlpMenuControls.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlpMenuControls.Location = New System.Drawing.Point(0, 0)
        Me.tlpMenuControls.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpMenuControls.Name = "tlpMenuControls"
        Me.tlpMenuControls.RowCount = 14
        Me.tlpMenuControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpMenuControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenuControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenuControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenuControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenuControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenuControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenuControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenuControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenuControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenuControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenuControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenuControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenuControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMenuControls.Size = New System.Drawing.Size(198, 556)
        Me.tlpMenuControls.TabIndex = 0
        '
        'cmdProgramInfo
        '
        Me.cmdProgramInfo.BackColor = System.Drawing.Color.Transparent
        Me.cmdProgramInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdProgramInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdProgramInfo.FlatAppearance.BorderSize = 0
        Me.cmdProgramInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdProgramInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdProgramInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdProgramInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProgramInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdProgramInfo.Location = New System.Drawing.Point(0, 10)
        Me.cmdProgramInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdProgramInfo.Name = "cmdProgramInfo"
        Me.cmdProgramInfo.Size = New System.Drawing.Size(196, 36)
        Me.cmdProgramInfo.TabIndex = 0
        Me.cmdProgramInfo.Text = "  ProgramInfo"
        Me.cmdProgramInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdProgramInfo.UseVisualStyleBackColor = False
        '
        'cmdSystemEnvironment
        '
        Me.cmdSystemEnvironment.BackColor = System.Drawing.Color.Transparent
        Me.cmdSystemEnvironment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdSystemEnvironment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdSystemEnvironment.FlatAppearance.BorderSize = 0
        Me.cmdSystemEnvironment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdSystemEnvironment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdSystemEnvironment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSystemEnvironment.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSystemEnvironment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdSystemEnvironment.Location = New System.Drawing.Point(0, 46)
        Me.cmdSystemEnvironment.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdSystemEnvironment.Name = "cmdSystemEnvironment"
        Me.cmdSystemEnvironment.Size = New System.Drawing.Size(196, 36)
        Me.cmdSystemEnvironment.TabIndex = 1
        Me.cmdSystemEnvironment.Text = "  SystemEnvironment"
        Me.cmdSystemEnvironment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSystemEnvironment.UseVisualStyleBackColor = False
        '
        'cmdWinSPR
        '
        Me.cmdWinSPR.BackColor = System.Drawing.Color.Transparent
        Me.cmdWinSPR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdWinSPR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdWinSPR.FlatAppearance.BorderSize = 0
        Me.cmdWinSPR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdWinSPR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdWinSPR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdWinSPR.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWinSPR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdWinSPR.Location = New System.Drawing.Point(0, 82)
        Me.cmdWinSPR.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdWinSPR.Name = "cmdWinSPR"
        Me.cmdWinSPR.Size = New System.Drawing.Size(196, 36)
        Me.cmdWinSPR.TabIndex = 2
        Me.cmdWinSPR.Text = "  WinSPR"
        Me.cmdWinSPR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdWinSPR.UseVisualStyleBackColor = False
        '
        'cmdMetrics
        '
        Me.cmdMetrics.BackColor = System.Drawing.Color.Transparent
        Me.cmdMetrics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdMetrics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdMetrics.FlatAppearance.BorderSize = 0
        Me.cmdMetrics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdMetrics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdMetrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMetrics.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMetrics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdMetrics.Location = New System.Drawing.Point(0, 118)
        Me.cmdMetrics.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdMetrics.Name = "cmdMetrics"
        Me.cmdMetrics.Size = New System.Drawing.Size(196, 36)
        Me.cmdMetrics.TabIndex = 3
        Me.cmdMetrics.Text = "  Metrics"
        Me.cmdMetrics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdMetrics.UseVisualStyleBackColor = False
        '
        'cmdOSVersion
        '
        Me.cmdOSVersion.BackColor = System.Drawing.Color.Transparent
        Me.cmdOSVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdOSVersion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdOSVersion.FlatAppearance.BorderSize = 0
        Me.cmdOSVersion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdOSVersion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdOSVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOSVersion.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOSVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdOSVersion.Location = New System.Drawing.Point(0, 154)
        Me.cmdOSVersion.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOSVersion.Name = "cmdOSVersion"
        Me.cmdOSVersion.Size = New System.Drawing.Size(196, 36)
        Me.cmdOSVersion.TabIndex = 4
        Me.cmdOSVersion.Text = "  OSVersion"
        Me.cmdOSVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOSVersion.UseVisualStyleBackColor = False
        '
        'cmdGraphics
        '
        Me.cmdGraphics.BackColor = System.Drawing.Color.Transparent
        Me.cmdGraphics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdGraphics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdGraphics.FlatAppearance.BorderSize = 0
        Me.cmdGraphics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdGraphics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGraphics.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGraphics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdGraphics.Location = New System.Drawing.Point(0, 298)
        Me.cmdGraphics.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdGraphics.Name = "cmdGraphics"
        Me.cmdGraphics.Size = New System.Drawing.Size(196, 36)
        Me.cmdGraphics.TabIndex = 8
        Me.cmdGraphics.Text = "  Graphics"
        Me.cmdGraphics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGraphics.UseVisualStyleBackColor = False
        '
        'cmdMemory
        '
        Me.cmdMemory.BackColor = System.Drawing.Color.Transparent
        Me.cmdMemory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdMemory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdMemory.FlatAppearance.BorderSize = 0
        Me.cmdMemory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdMemory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMemory.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMemory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdMemory.Location = New System.Drawing.Point(0, 262)
        Me.cmdMemory.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdMemory.Name = "cmdMemory"
        Me.cmdMemory.Size = New System.Drawing.Size(196, 36)
        Me.cmdMemory.TabIndex = 7
        Me.cmdMemory.Text = "  Memory (RAM)"
        Me.cmdMemory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdMemory.UseVisualStyleBackColor = False
        '
        'cmdProcessor
        '
        Me.cmdProcessor.BackColor = System.Drawing.Color.Transparent
        Me.cmdProcessor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdProcessor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdProcessor.FlatAppearance.BorderSize = 0
        Me.cmdProcessor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdProcessor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdProcessor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdProcessor.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdProcessor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdProcessor.Location = New System.Drawing.Point(0, 226)
        Me.cmdProcessor.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdProcessor.Name = "cmdProcessor"
        Me.cmdProcessor.Size = New System.Drawing.Size(196, 36)
        Me.cmdProcessor.TabIndex = 6
        Me.cmdProcessor.Text = "  Processor"
        Me.cmdProcessor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdProcessor.UseVisualStyleBackColor = False
        '
        'cmdSystem
        '
        Me.cmdSystem.BackColor = System.Drawing.Color.Transparent
        Me.cmdSystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdSystem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdSystem.FlatAppearance.BorderSize = 0
        Me.cmdSystem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdSystem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSystem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSystem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdSystem.Location = New System.Drawing.Point(0, 190)
        Me.cmdSystem.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdSystem.Name = "cmdSystem"
        Me.cmdSystem.Size = New System.Drawing.Size(196, 36)
        Me.cmdSystem.TabIndex = 5
        Me.cmdSystem.Text = "  System"
        Me.cmdSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSystem.UseVisualStyleBackColor = False
        '
        'cmdDisk
        '
        Me.cmdDisk.BackColor = System.Drawing.Color.Transparent
        Me.cmdDisk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdDisk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdDisk.FlatAppearance.BorderSize = 0
        Me.cmdDisk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdDisk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdDisk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDisk.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDisk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdDisk.Location = New System.Drawing.Point(0, 334)
        Me.cmdDisk.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdDisk.Name = "cmdDisk"
        Me.cmdDisk.Size = New System.Drawing.Size(196, 36)
        Me.cmdDisk.TabIndex = 9
        Me.cmdDisk.Text = "  Disk"
        Me.cmdDisk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDisk.UseVisualStyleBackColor = False
        '
        'cmdDwm
        '
        Me.cmdDwm.BackColor = System.Drawing.Color.Transparent
        Me.cmdDwm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdDwm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdDwm.FlatAppearance.BorderSize = 0
        Me.cmdDwm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdDwm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdDwm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDwm.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDwm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdDwm.Location = New System.Drawing.Point(0, 370)
        Me.cmdDwm.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdDwm.Name = "cmdDwm"
        Me.cmdDwm.Size = New System.Drawing.Size(196, 36)
        Me.cmdDwm.TabIndex = 10
        Me.cmdDwm.Text = "  DWMAssessment"
        Me.cmdDwm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDwm.UseVisualStyleBackColor = False
        '
        'cmdD3d
        '
        Me.cmdD3d.BackColor = System.Drawing.Color.Transparent
        Me.cmdD3d.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdD3d.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdD3d.FlatAppearance.BorderSize = 0
        Me.cmdD3d.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.cmdD3d.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdD3d.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdD3d.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdD3d.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdD3d.Location = New System.Drawing.Point(0, 406)
        Me.cmdD3d.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdD3d.Name = "cmdD3d"
        Me.cmdD3d.Size = New System.Drawing.Size(196, 36)
        Me.cmdD3d.TabIndex = 11
        Me.cmdD3d.Text = "  D3DAssessment"
        Me.cmdD3d.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdD3d.UseVisualStyleBackColor = False
        '
        'PbxProgramInfo
        '
        Me.PbxProgramInfo.BackColor = System.Drawing.Color.Transparent
        Me.PbxProgramInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxProgramInfo.Location = New System.Drawing.Point(196, 10)
        Me.PbxProgramInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxProgramInfo.Name = "PbxProgramInfo"
        Me.PbxProgramInfo.Size = New System.Drawing.Size(2, 36)
        Me.PbxProgramInfo.TabIndex = 12
        Me.PbxProgramInfo.TabStop = False
        '
        'pbxSystemEnvironmentSelected
        '
        Me.pbxSystemEnvironmentSelected.BackColor = System.Drawing.Color.Transparent
        Me.pbxSystemEnvironmentSelected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxSystemEnvironmentSelected.Location = New System.Drawing.Point(196, 46)
        Me.pbxSystemEnvironmentSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxSystemEnvironmentSelected.Name = "pbxSystemEnvironmentSelected"
        Me.pbxSystemEnvironmentSelected.Size = New System.Drawing.Size(2, 36)
        Me.pbxSystemEnvironmentSelected.TabIndex = 13
        Me.pbxSystemEnvironmentSelected.TabStop = False
        '
        'pbxWinSPRSelected
        '
        Me.pbxWinSPRSelected.BackColor = System.Drawing.Color.Transparent
        Me.pbxWinSPRSelected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxWinSPRSelected.Location = New System.Drawing.Point(196, 82)
        Me.pbxWinSPRSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxWinSPRSelected.Name = "pbxWinSPRSelected"
        Me.pbxWinSPRSelected.Size = New System.Drawing.Size(2, 36)
        Me.pbxWinSPRSelected.TabIndex = 14
        Me.pbxWinSPRSelected.TabStop = False
        '
        'pbxMetricsSelected
        '
        Me.pbxMetricsSelected.BackColor = System.Drawing.Color.Transparent
        Me.pbxMetricsSelected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxMetricsSelected.Location = New System.Drawing.Point(196, 118)
        Me.pbxMetricsSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxMetricsSelected.Name = "pbxMetricsSelected"
        Me.pbxMetricsSelected.Size = New System.Drawing.Size(2, 36)
        Me.pbxMetricsSelected.TabIndex = 15
        Me.pbxMetricsSelected.TabStop = False
        '
        'pbxOSSelected
        '
        Me.pbxOSSelected.BackColor = System.Drawing.Color.Transparent
        Me.pbxOSSelected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxOSSelected.Location = New System.Drawing.Point(196, 154)
        Me.pbxOSSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxOSSelected.Name = "pbxOSSelected"
        Me.pbxOSSelected.Size = New System.Drawing.Size(2, 36)
        Me.pbxOSSelected.TabIndex = 16
        Me.pbxOSSelected.TabStop = False
        '
        'PbxSystem
        '
        Me.PbxSystem.BackColor = System.Drawing.Color.Transparent
        Me.PbxSystem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxSystem.Location = New System.Drawing.Point(196, 190)
        Me.PbxSystem.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxSystem.Name = "PbxSystem"
        Me.PbxSystem.Size = New System.Drawing.Size(2, 36)
        Me.PbxSystem.TabIndex = 17
        Me.PbxSystem.TabStop = False
        '
        'PbxProcessor
        '
        Me.PbxProcessor.BackColor = System.Drawing.Color.Transparent
        Me.PbxProcessor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PbxProcessor.Location = New System.Drawing.Point(196, 226)
        Me.PbxProcessor.Margin = New System.Windows.Forms.Padding(0)
        Me.PbxProcessor.Name = "PbxProcessor"
        Me.PbxProcessor.Size = New System.Drawing.Size(2, 36)
        Me.PbxProcessor.TabIndex = 18
        Me.PbxProcessor.TabStop = False
        '
        'pbxMemorySelected
        '
        Me.pbxMemorySelected.BackColor = System.Drawing.Color.Transparent
        Me.pbxMemorySelected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxMemorySelected.Location = New System.Drawing.Point(196, 262)
        Me.pbxMemorySelected.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxMemorySelected.Name = "pbxMemorySelected"
        Me.pbxMemorySelected.Size = New System.Drawing.Size(2, 36)
        Me.pbxMemorySelected.TabIndex = 19
        Me.pbxMemorySelected.TabStop = False
        '
        'pbxGraphicsSelected
        '
        Me.pbxGraphicsSelected.BackColor = System.Drawing.Color.Transparent
        Me.pbxGraphicsSelected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxGraphicsSelected.Location = New System.Drawing.Point(196, 298)
        Me.pbxGraphicsSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxGraphicsSelected.Name = "pbxGraphicsSelected"
        Me.pbxGraphicsSelected.Size = New System.Drawing.Size(2, 36)
        Me.pbxGraphicsSelected.TabIndex = 20
        Me.pbxGraphicsSelected.TabStop = False
        '
        'pbxDiskSelected
        '
        Me.pbxDiskSelected.BackColor = System.Drawing.Color.Transparent
        Me.pbxDiskSelected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxDiskSelected.Location = New System.Drawing.Point(196, 334)
        Me.pbxDiskSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxDiskSelected.Name = "pbxDiskSelected"
        Me.pbxDiskSelected.Size = New System.Drawing.Size(2, 36)
        Me.pbxDiskSelected.TabIndex = 21
        Me.pbxDiskSelected.TabStop = False
        '
        'pbxDwmSelected
        '
        Me.pbxDwmSelected.BackColor = System.Drawing.Color.Transparent
        Me.pbxDwmSelected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxDwmSelected.Location = New System.Drawing.Point(196, 370)
        Me.pbxDwmSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxDwmSelected.Name = "pbxDwmSelected"
        Me.pbxDwmSelected.Size = New System.Drawing.Size(2, 36)
        Me.pbxDwmSelected.TabIndex = 22
        Me.pbxDwmSelected.TabStop = False
        '
        'pbxD3dSelected
        '
        Me.pbxD3dSelected.BackColor = System.Drawing.Color.Transparent
        Me.pbxD3dSelected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbxD3dSelected.Location = New System.Drawing.Point(196, 406)
        Me.pbxD3dSelected.Margin = New System.Windows.Forms.Padding(0)
        Me.pbxD3dSelected.Name = "pbxD3dSelected"
        Me.pbxD3dSelected.Size = New System.Drawing.Size(2, 36)
        Me.pbxD3dSelected.TabIndex = 23
        Me.pbxD3dSelected.TabStop = False
        '
        'FormScoreData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSplit)
        Me.Controls.Add(Me.pnlTitle)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "FormScoreData"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "WinSAT Score Data"
        Me.pnlTitle.ResumeLayout(False)
        Me.tlpTitleIcon.ResumeLayout(False)
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.tlpMain.ResumeLayout(False)
        Me.tlpMenuControls.ResumeLayout(False)
        CType(Me.PbxProgramInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSystemEnvironmentSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxWinSPRSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMetricsSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxOSSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxSystem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxProcessor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxMemorySelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGraphicsSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDiskSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDwmSelected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxD3dSelected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSplit As Panel
    Friend WithEvents pnlTitle As Panel
    Friend WithEvents cmdClose As Button
    Friend WithEvents tlpTitleIcon As TableLayoutPanel
    Friend WithEvents icnMain As PictureBox
    Friend WithEvents pnlMain As Panel
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents rtbData As RichTextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents tlpMenuControls As TableLayoutPanel
    Friend WithEvents cmdProgramInfo As Button
    Friend WithEvents cmdSystemEnvironment As Button
    Friend WithEvents cmdWinSPR As Button
    Friend WithEvents cmdMetrics As Button
    Friend WithEvents cmdOSVersion As Button
    Friend WithEvents cmdGraphics As Button
    Friend WithEvents cmdMemory As Button
    Friend WithEvents cmdProcessor As Button
    Friend WithEvents cmdSystem As Button
    Friend WithEvents cmdDisk As Button
    Friend WithEvents cmdDwm As Button
    Friend WithEvents cmdD3d As Button
    Friend WithEvents PbxProgramInfo As PictureBox
    Friend WithEvents pbxSystemEnvironmentSelected As PictureBox
    Friend WithEvents pbxWinSPRSelected As PictureBox
    Friend WithEvents pbxMetricsSelected As PictureBox
    Friend WithEvents pbxOSSelected As PictureBox
    Friend WithEvents PbxSystem As PictureBox
    Friend WithEvents PbxProcessor As PictureBox
    Friend WithEvents pbxMemorySelected As PictureBox
    Friend WithEvents pbxGraphicsSelected As PictureBox
    Friend WithEvents pbxDiskSelected As PictureBox
    Friend WithEvents pbxDwmSelected As PictureBox
    Friend WithEvents pbxD3dSelected As PictureBox
End Class
