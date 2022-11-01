<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSystem))
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.CmdSave = New System.Windows.Forms.Button()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.icnMain = New System.Windows.Forms.PictureBox()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.PanMain = New System.Windows.Forms.Panel()
        Me.TlpGrid = New System.Windows.Forms.TableLayoutPanel()
        Me.LabUsername = New System.Windows.Forms.Label()
        Me.LabWinSystemtem = New System.Windows.Forms.Label()
        Me.LabBitness = New System.Windows.Forms.Label()
        Me.LabServPack = New System.Windows.Forms.Label()
        Me.LabKernel = New System.Windows.Forms.Label()
        Me.LabWinsat = New System.Windows.Forms.Label()
        Me.LabInstDat = New System.Windows.Forms.Label()
        Me.LabUptime = New System.Windows.Forms.Label()
        Me.LabApi = New System.Windows.Forms.Label()
        Me.sUptime = New System.Windows.Forms.Label()
        Me.sInstDat = New System.Windows.Forms.Label()
        Me.sApi = New System.Windows.Forms.Label()
        Me.sWinsat = New System.Windows.Forms.Label()
        Me.sKernel = New System.Windows.Forms.Label()
        Me.sServPack = New System.Windows.Forms.Label()
        Me.sBitness = New System.Windows.Forms.Label()
        Me.sWinSystemtem = New System.Windows.Forms.Label()
        Me.sUsername = New System.Windows.Forms.Label()
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanMain.SuspendLayout()
        Me.TlpGrid.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanHead
        '
        Me.PanHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PanHead.Controls.Add(Me.LabHead)
        Me.PanHead.Controls.Add(Me.CmdSave)
        Me.PanHead.Controls.Add(Me.TlpHeadImage)
        Me.PanHead.Controls.Add(Me.CmdClose)
        Me.PanHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanHead.Location = New System.Drawing.Point(1, 1)
        Me.PanHead.Margin = New System.Windows.Forms.Padding(2)
        Me.PanHead.Name = "PanHead"
        Me.PanHead.Size = New System.Drawing.Size(636, 40)
        Me.PanHead.TabIndex = 0
        '
        'LabHead
        '
        Me.LabHead.BackColor = System.Drawing.Color.Transparent
        Me.LabHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabHead.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHead.ForeColor = System.Drawing.Color.White
        Me.LabHead.Location = New System.Drawing.Point(92, 0)
        Me.LabHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabHead.Name = "LabHead"
        Me.LabHead.Size = New System.Drawing.Size(464, 40)
        Me.LabHead.TabIndex = 70
        Me.LabHead.Text = "System Details"
        Me.LabHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmdSave
        '
        Me.CmdSave.BackColor = System.Drawing.Color.Transparent
        Me.CmdSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.CmdSave.FlatAppearance.BorderSize = 0
        Me.CmdSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.CmdSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSave.Font = New System.Drawing.Font("Segoe MDL2 Assets", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSave.ForeColor = System.Drawing.Color.White
        Me.CmdSave.Location = New System.Drawing.Point(556, 0)
        Me.CmdSave.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdSave.Size = New System.Drawing.Size(40, 40)
        Me.CmdSave.TabIndex = 0
        Me.CmdSave.TabStop = False
        Me.CmdSave.Text = ""
        Me.CmdSave.UseVisualStyleBackColor = False
        '
        'TlpHeadImage
        '
        Me.TlpHeadImage.BackColor = System.Drawing.Color.Transparent
        Me.TlpHeadImage.ColumnCount = 1
        Me.TlpHeadImage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TlpHeadImage.Controls.Add(Me.icnMain, 0, 0)
        Me.TlpHeadImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.TlpHeadImage.Location = New System.Drawing.Point(0, 0)
        Me.TlpHeadImage.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpHeadImage.Name = "TlpHeadImage"
        Me.TlpHeadImage.RowCount = 1
        Me.TlpHeadImage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpHeadImage.Size = New System.Drawing.Size(92, 40)
        Me.TlpHeadImage.TabIndex = 73
        '
        'icnMain
        '
        Me.icnMain.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.icnMain.BackColor = System.Drawing.Color.Transparent
        Me.icnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.icnMain.Image = Global.WinXI.My.Resources.Resources.ImgMainIcon24Px
        Me.icnMain.Location = New System.Drawing.Point(8, 8)
        Me.icnMain.Margin = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.icnMain.Name = "icnMain"
        Me.icnMain.Size = New System.Drawing.Size(24, 24)
        Me.icnMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icnMain.TabIndex = 1
        Me.icnMain.TabStop = False
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Transparent
        Me.CmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.CmdClose.FlatAppearance.BorderSize = 0
        Me.CmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(596, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(40, 40)
        Me.CmdClose.TabIndex = 0
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'PanMain
        '
        Me.PanMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanMain.Controls.Add(Me.TlpGrid)
        Me.PanMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanMain.Location = New System.Drawing.Point(1, 41)
        Me.PanMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PanMain.Name = "PanMain"
        Me.PanMain.Padding = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.PanMain.Size = New System.Drawing.Size(636, 323)
        Me.PanMain.TabIndex = 124
        '
        'TlpGrid
        '
        Me.TlpGrid.ColumnCount = 2
        Me.TlpGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpGrid.Controls.Add(Me.LabUsername, 1, 0)
        Me.TlpGrid.Controls.Add(Me.LabWinSystemtem, 1, 1)
        Me.TlpGrid.Controls.Add(Me.LabBitness, 1, 2)
        Me.TlpGrid.Controls.Add(Me.LabServPack, 1, 3)
        Me.TlpGrid.Controls.Add(Me.LabKernel, 1, 5)
        Me.TlpGrid.Controls.Add(Me.LabWinsat, 1, 6)
        Me.TlpGrid.Controls.Add(Me.LabInstDat, 1, 9)
        Me.TlpGrid.Controls.Add(Me.LabUptime, 1, 10)
        Me.TlpGrid.Controls.Add(Me.LabApi, 1, 7)
        Me.TlpGrid.Controls.Add(Me.sUptime, 0, 10)
        Me.TlpGrid.Controls.Add(Me.sInstDat, 0, 9)
        Me.TlpGrid.Controls.Add(Me.sApi, 0, 7)
        Me.TlpGrid.Controls.Add(Me.sWinsat, 0, 6)
        Me.TlpGrid.Controls.Add(Me.sKernel, 0, 5)
        Me.TlpGrid.Controls.Add(Me.sServPack, 0, 3)
        Me.TlpGrid.Controls.Add(Me.sBitness, 0, 2)
        Me.TlpGrid.Controls.Add(Me.sWinSystemtem, 0, 1)
        Me.TlpGrid.Controls.Add(Me.sUsername, 0, 0)
        Me.TlpGrid.Dock = System.Windows.Forms.DockStyle.Top
        Me.TlpGrid.Location = New System.Drawing.Point(6, 9)
        Me.TlpGrid.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpGrid.Name = "TlpGrid"
        Me.TlpGrid.RowCount = 12
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TlpGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TlpGrid.Size = New System.Drawing.Size(624, 309)
        Me.TlpGrid.TabIndex = 126
        '
        'LabUsername
        '
        Me.LabUsername.AutoEllipsis = True
        Me.LabUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabUsername.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabUsername.Location = New System.Drawing.Point(172, 0)
        Me.LabUsername.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.LabUsername.Name = "LabUsername"
        Me.LabUsername.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabUsername.Size = New System.Drawing.Size(452, 31)
        Me.LabUsername.TabIndex = 77
        Me.LabUsername.Text = "..."
        Me.LabUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabWinSystemtem
        '
        Me.LabWinSystemtem.AutoEllipsis = True
        Me.LabWinSystemtem.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabWinSystemtem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabWinSystemtem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabWinSystemtem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabWinSystemtem.Location = New System.Drawing.Point(172, 32)
        Me.LabWinSystemtem.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.LabWinSystemtem.Name = "LabWinSystemtem"
        Me.LabWinSystemtem.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabWinSystemtem.Size = New System.Drawing.Size(452, 31)
        Me.LabWinSystemtem.TabIndex = 77
        Me.LabWinSystemtem.Text = "..."
        Me.LabWinSystemtem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabBitness
        '
        Me.LabBitness.AutoEllipsis = True
        Me.LabBitness.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabBitness.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabBitness.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabBitness.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabBitness.Location = New System.Drawing.Point(172, 64)
        Me.LabBitness.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.LabBitness.Name = "LabBitness"
        Me.LabBitness.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabBitness.Size = New System.Drawing.Size(452, 31)
        Me.LabBitness.TabIndex = 78
        Me.LabBitness.Text = "..."
        Me.LabBitness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabServPack
        '
        Me.LabServPack.AutoEllipsis = True
        Me.LabServPack.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabServPack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabServPack.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabServPack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabServPack.Location = New System.Drawing.Point(172, 96)
        Me.LabServPack.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.LabServPack.Name = "LabServPack"
        Me.LabServPack.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabServPack.Size = New System.Drawing.Size(452, 31)
        Me.LabServPack.TabIndex = 78
        Me.LabServPack.Text = "..."
        Me.LabServPack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabKernel
        '
        Me.LabKernel.AutoEllipsis = True
        Me.LabKernel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabKernel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabKernel.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabKernel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabKernel.Location = New System.Drawing.Point(172, 136)
        Me.LabKernel.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.LabKernel.Name = "LabKernel"
        Me.LabKernel.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabKernel.Size = New System.Drawing.Size(452, 33)
        Me.LabKernel.TabIndex = 78
        Me.LabKernel.Text = "..."
        Me.LabKernel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabWinsat
        '
        Me.LabWinsat.AutoEllipsis = True
        Me.LabWinsat.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabWinsat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabWinsat.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabWinsat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabWinsat.Location = New System.Drawing.Point(172, 170)
        Me.LabWinsat.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.LabWinsat.Name = "LabWinsat"
        Me.LabWinsat.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabWinsat.Size = New System.Drawing.Size(452, 30)
        Me.LabWinsat.TabIndex = 78
        Me.LabWinsat.Text = "..."
        Me.LabWinsat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabInstDat
        '
        Me.LabInstDat.AutoEllipsis = True
        Me.LabInstDat.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabInstDat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabInstDat.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabInstDat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabInstDat.Location = New System.Drawing.Point(172, 241)
        Me.LabInstDat.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.LabInstDat.Name = "LabInstDat"
        Me.LabInstDat.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabInstDat.Size = New System.Drawing.Size(452, 31)
        Me.LabInstDat.TabIndex = 77
        Me.LabInstDat.Text = "..."
        Me.LabInstDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabUptime
        '
        Me.LabUptime.AutoEllipsis = True
        Me.LabUptime.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabUptime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabUptime.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabUptime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabUptime.Location = New System.Drawing.Point(172, 273)
        Me.LabUptime.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.LabUptime.Name = "LabUptime"
        Me.LabUptime.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabUptime.Size = New System.Drawing.Size(452, 31)
        Me.LabUptime.TabIndex = 79
        Me.LabUptime.Text = "..."
        Me.LabUptime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabApi
        '
        Me.LabApi.AutoEllipsis = True
        Me.LabApi.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabApi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabApi.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabApi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LabApi.Location = New System.Drawing.Point(172, 201)
        Me.LabApi.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.LabApi.Name = "LabApi"
        Me.LabApi.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.LabApi.Size = New System.Drawing.Size(452, 31)
        Me.LabApi.TabIndex = 78
        Me.LabApi.Text = "..."
        Me.LabApi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sUptime
        '
        Me.sUptime.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.sUptime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sUptime.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sUptime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sUptime.Location = New System.Drawing.Point(0, 273)
        Me.sUptime.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.sUptime.Name = "sUptime"
        Me.sUptime.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sUptime.Size = New System.Drawing.Size(171, 31)
        Me.sUptime.TabIndex = 49
        Me.sUptime.Text = "System Uptime"
        Me.sUptime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sInstDat
        '
        Me.sInstDat.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.sInstDat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sInstDat.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sInstDat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sInstDat.Location = New System.Drawing.Point(0, 241)
        Me.sInstDat.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.sInstDat.Name = "sInstDat"
        Me.sInstDat.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sInstDat.Size = New System.Drawing.Size(171, 31)
        Me.sInstDat.TabIndex = 48
        Me.sInstDat.Text = "Install Date"
        Me.sInstDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sApi
        '
        Me.sApi.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.sApi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sApi.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sApi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sApi.Location = New System.Drawing.Point(0, 201)
        Me.sApi.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.sApi.Name = "sApi"
        Me.sApi.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sApi.Size = New System.Drawing.Size(171, 31)
        Me.sApi.TabIndex = 52
        Me.sApi.Text = "WinSAT API Version"
        Me.sApi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sWinsat
        '
        Me.sWinsat.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.sWinsat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sWinsat.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sWinsat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sWinsat.Location = New System.Drawing.Point(0, 170)
        Me.sWinsat.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.sWinsat.Name = "sWinsat"
        Me.sWinsat.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sWinsat.Size = New System.Drawing.Size(171, 30)
        Me.sWinsat.TabIndex = 51
        Me.sWinsat.Text = "WinSAT Version"
        Me.sWinsat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sKernel
        '
        Me.sKernel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.sKernel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sKernel.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sKernel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sKernel.Location = New System.Drawing.Point(0, 136)
        Me.sKernel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.sKernel.Name = "sKernel"
        Me.sKernel.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sKernel.Size = New System.Drawing.Size(171, 33)
        Me.sKernel.TabIndex = 50
        Me.sKernel.Text = "Kernel Version"
        Me.sKernel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sServPack
        '
        Me.sServPack.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.sServPack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sServPack.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sServPack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sServPack.Location = New System.Drawing.Point(0, 96)
        Me.sServPack.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.sServPack.Name = "sServPack"
        Me.sServPack.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sServPack.Size = New System.Drawing.Size(171, 31)
        Me.sServPack.TabIndex = 49
        Me.sServPack.Text = "Service Pack"
        Me.sServPack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sBitness
        '
        Me.sBitness.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.sBitness.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sBitness.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sBitness.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sBitness.Location = New System.Drawing.Point(0, 64)
        Me.sBitness.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.sBitness.Name = "sBitness"
        Me.sBitness.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sBitness.Size = New System.Drawing.Size(171, 31)
        Me.sBitness.TabIndex = 49
        Me.sBitness.Text = "Bitness"
        Me.sBitness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sWinSystemtem
        '
        Me.sWinSystemtem.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.sWinSystemtem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sWinSystemtem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sWinSystemtem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sWinSystemtem.Location = New System.Drawing.Point(0, 32)
        Me.sWinSystemtem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.sWinSystemtem.Name = "sWinSystemtem"
        Me.sWinSystemtem.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sWinSystemtem.Size = New System.Drawing.Size(171, 31)
        Me.sWinSystemtem.TabIndex = 48
        Me.sWinSystemtem.Text = "Operating System"
        Me.sWinSystemtem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sUsername
        '
        Me.sUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.sUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.sUsername.Location = New System.Drawing.Point(0, 0)
        Me.sUsername.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.sUsername.Name = "sUsername"
        Me.sUsername.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.sUsername.Size = New System.Drawing.Size(171, 31)
        Me.sUsername.TabIndex = 48
        Me.sUsername.Text = "Username"
        Me.sUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.ForeColor = System.Drawing.Color.Black
        Me.PanSplit.Location = New System.Drawing.Point(1, 41)
        Me.PanSplit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(636, 2)
        Me.PanSplit.TabIndex = 126
        '
        'FormSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(638, 365)
        Me.Controls.Add(Me.PanSplit)
        Me.Controls.Add(Me.PanMain)
        Me.Controls.Add(Me.PanHead)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(638, 365)
        Me.MinimumSize = New System.Drawing.Size(638, 365)
        Me.Name = "FormSystem"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "System Details"
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanMain.ResumeLayout(False)
        Me.TlpGrid.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanHead As System.Windows.Forms.Panel
    Friend WithEvents LabHead As System.Windows.Forms.Label
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents PanMain As System.Windows.Forms.Panel
    Friend WithEvents TlpHeadImage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents icnMain As System.Windows.Forms.PictureBox
    Friend WithEvents TlpGrid As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents sWinSystemtem As System.Windows.Forms.Label
    Friend WithEvents sBitness As System.Windows.Forms.Label
    Friend WithEvents sServPack As System.Windows.Forms.Label
    Friend WithEvents LabServPack As System.Windows.Forms.Label
    Friend WithEvents LabWinSystemtem As System.Windows.Forms.Label
    Friend WithEvents LabBitness As System.Windows.Forms.Label
    Friend WithEvents sKernel As System.Windows.Forms.Label
    Friend WithEvents LabKernel As System.Windows.Forms.Label
    Friend WithEvents sWinsat As System.Windows.Forms.Label
    Friend WithEvents LabWinsat As System.Windows.Forms.Label
    Friend WithEvents sApi As System.Windows.Forms.Label
    Friend WithEvents LabApi As System.Windows.Forms.Label
    Friend WithEvents LabUptime As System.Windows.Forms.Label
    Friend WithEvents sUsername As Label
    Friend WithEvents LabUsername As Label
    Friend WithEvents sInstDat As Label
    Friend WithEvents LabInstDat As Label
    Friend WithEvents PanSplit As Panel
    Friend WithEvents sUptime As Label
    Friend WithEvents CmdSave As Button
End Class
