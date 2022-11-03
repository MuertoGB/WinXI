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
        Me.panTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmdExportInfo = New System.Windows.Forms.Button()
        Me.tlpTitleIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.icnMain = New System.Windows.Forms.PictureBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.tlpItems = New System.Windows.Forms.TableLayoutPanel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblOs = New System.Windows.Forms.Label()
        Me.lblBitness = New System.Windows.Forms.Label()
        Me.lblServicePack = New System.Windows.Forms.Label()
        Me.lblKernelVersion = New System.Windows.Forms.Label()
        Me.lblWinSATVersion = New System.Windows.Forms.Label()
        Me.lblWinInstallDate = New System.Windows.Forms.Label()
        Me.lblSystemUptime = New System.Windows.Forms.Label()
        Me.lblWinSATAPIVersion = New System.Windows.Forms.Label()
        Me.lblSystemUptimeText = New System.Windows.Forms.Label()
        Me.lblWinInstallDateText = New System.Windows.Forms.Label()
        Me.lblWinSATAPIVersionText = New System.Windows.Forms.Label()
        Me.lblWinSATVersionText = New System.Windows.Forms.Label()
        Me.lblKernelVersionText = New System.Windows.Forms.Label()
        Me.lblServicePackText = New System.Windows.Forms.Label()
        Me.lblBitnessText = New System.Windows.Forms.Label()
        Me.lblOsText = New System.Windows.Forms.Label()
        Me.lblUsernameText = New System.Windows.Forms.Label()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.panTitle.SuspendLayout()
        Me.tlpTitleIcon.SuspendLayout()
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        Me.tlpItems.SuspendLayout()
        Me.SuspendLayout()
        '
        'panTitle
        '
        Me.panTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.panTitle.Controls.Add(Me.lblTitle)
        Me.panTitle.Controls.Add(Me.cmdExportInfo)
        Me.panTitle.Controls.Add(Me.tlpTitleIcon)
        Me.panTitle.Controls.Add(Me.cmdClose)
        Me.panTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.panTitle.Location = New System.Drawing.Point(1, 1)
        Me.panTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.panTitle.Name = "panTitle"
        Me.panTitle.Size = New System.Drawing.Size(636, 40)
        Me.panTitle.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(92, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(464, 40)
        Me.lblTitle.TabIndex = 70
        Me.lblTitle.Text = "System Details"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdExportInfo
        '
        Me.cmdExportInfo.BackColor = System.Drawing.Color.Transparent
        Me.cmdExportInfo.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdExportInfo.FlatAppearance.BorderSize = 0
        Me.cmdExportInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmdExportInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmdExportInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExportInfo.Font = New System.Drawing.Font("Segoe MDL2 Assets", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExportInfo.ForeColor = System.Drawing.Color.White
        Me.cmdExportInfo.Location = New System.Drawing.Point(556, 0)
        Me.cmdExportInfo.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdExportInfo.Name = "cmdExportInfo"
        Me.cmdExportInfo.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.cmdExportInfo.Size = New System.Drawing.Size(40, 40)
        Me.cmdExportInfo.TabIndex = 0
        Me.cmdExportInfo.TabStop = False
        Me.cmdExportInfo.Text = ""
        Me.cmdExportInfo.UseVisualStyleBackColor = False
        '
        'tlpTitleIcon
        '
        Me.tlpTitleIcon.BackColor = System.Drawing.Color.Transparent
        Me.tlpTitleIcon.ColumnCount = 1
        Me.tlpTitleIcon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.tlpTitleIcon.Controls.Add(Me.icnMain, 0, 0)
        Me.tlpTitleIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlpTitleIcon.Location = New System.Drawing.Point(0, 0)
        Me.tlpTitleIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpTitleIcon.Name = "tlpTitleIcon"
        Me.tlpTitleIcon.RowCount = 1
        Me.tlpTitleIcon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTitleIcon.Size = New System.Drawing.Size(92, 40)
        Me.tlpTitleIcon.TabIndex = 73
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
        Me.cmdClose.Location = New System.Drawing.Point(596, 0)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.cmdClose.Size = New System.Drawing.Size(40, 40)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "✕"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.tlpItems)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(1, 41)
        Me.pnlMain.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(6, 9, 6, 9)
        Me.pnlMain.Size = New System.Drawing.Size(636, 320)
        Me.pnlMain.TabIndex = 124
        '
        'tlpItems
        '
        Me.tlpItems.ColumnCount = 2
        Me.tlpItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpItems.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpItems.Controls.Add(Me.lblUsername, 1, 0)
        Me.tlpItems.Controls.Add(Me.lblOs, 1, 1)
        Me.tlpItems.Controls.Add(Me.lblBitness, 1, 2)
        Me.tlpItems.Controls.Add(Me.lblServicePack, 1, 3)
        Me.tlpItems.Controls.Add(Me.lblKernelVersion, 1, 5)
        Me.tlpItems.Controls.Add(Me.lblWinSATVersion, 1, 6)
        Me.tlpItems.Controls.Add(Me.lblWinInstallDate, 1, 9)
        Me.tlpItems.Controls.Add(Me.lblSystemUptime, 1, 10)
        Me.tlpItems.Controls.Add(Me.lblWinSATAPIVersion, 1, 7)
        Me.tlpItems.Controls.Add(Me.lblSystemUptimeText, 0, 10)
        Me.tlpItems.Controls.Add(Me.lblWinInstallDateText, 0, 9)
        Me.tlpItems.Controls.Add(Me.lblWinSATAPIVersionText, 0, 7)
        Me.tlpItems.Controls.Add(Me.lblWinSATVersionText, 0, 6)
        Me.tlpItems.Controls.Add(Me.lblKernelVersionText, 0, 5)
        Me.tlpItems.Controls.Add(Me.lblServicePackText, 0, 3)
        Me.tlpItems.Controls.Add(Me.lblBitnessText, 0, 2)
        Me.tlpItems.Controls.Add(Me.lblOsText, 0, 1)
        Me.tlpItems.Controls.Add(Me.lblUsernameText, 0, 0)
        Me.tlpItems.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpItems.Location = New System.Drawing.Point(6, 9)
        Me.tlpItems.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpItems.Name = "tlpItems"
        Me.tlpItems.RowCount = 12
        Me.tlpItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlpItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlpItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpItems.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpItems.Size = New System.Drawing.Size(624, 309)
        Me.tlpItems.TabIndex = 126
        '
        'lblUsername
        '
        Me.lblUsername.AutoEllipsis = True
        Me.lblUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(172, 0)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblUsername.Size = New System.Drawing.Size(452, 31)
        Me.lblUsername.TabIndex = 77
        Me.lblUsername.Text = "..."
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOs
        '
        Me.lblOs.AutoEllipsis = True
        Me.lblOs.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblOs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOs.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblOs.Location = New System.Drawing.Point(172, 32)
        Me.lblOs.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.lblOs.Name = "lblOs"
        Me.lblOs.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblOs.Size = New System.Drawing.Size(452, 31)
        Me.lblOs.TabIndex = 77
        Me.lblOs.Text = "..."
        Me.lblOs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBitness
        '
        Me.lblBitness.AutoEllipsis = True
        Me.lblBitness.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblBitness.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBitness.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBitness.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblBitness.Location = New System.Drawing.Point(172, 64)
        Me.lblBitness.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.lblBitness.Name = "lblBitness"
        Me.lblBitness.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblBitness.Size = New System.Drawing.Size(452, 31)
        Me.lblBitness.TabIndex = 78
        Me.lblBitness.Text = "..."
        Me.lblBitness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServicePack
        '
        Me.lblServicePack.AutoEllipsis = True
        Me.lblServicePack.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblServicePack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblServicePack.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicePack.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblServicePack.Location = New System.Drawing.Point(172, 96)
        Me.lblServicePack.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.lblServicePack.Name = "lblServicePack"
        Me.lblServicePack.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblServicePack.Size = New System.Drawing.Size(452, 31)
        Me.lblServicePack.TabIndex = 78
        Me.lblServicePack.Text = "..."
        Me.lblServicePack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblKernelVersion
        '
        Me.lblKernelVersion.AutoEllipsis = True
        Me.lblKernelVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblKernelVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKernelVersion.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKernelVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblKernelVersion.Location = New System.Drawing.Point(172, 136)
        Me.lblKernelVersion.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.lblKernelVersion.Name = "lblKernelVersion"
        Me.lblKernelVersion.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblKernelVersion.Size = New System.Drawing.Size(452, 33)
        Me.lblKernelVersion.TabIndex = 78
        Me.lblKernelVersion.Text = "..."
        Me.lblKernelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWinSATVersion
        '
        Me.lblWinSATVersion.AutoEllipsis = True
        Me.lblWinSATVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblWinSATVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWinSATVersion.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinSATVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblWinSATVersion.Location = New System.Drawing.Point(172, 170)
        Me.lblWinSATVersion.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.lblWinSATVersion.Name = "lblWinSATVersion"
        Me.lblWinSATVersion.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblWinSATVersion.Size = New System.Drawing.Size(452, 30)
        Me.lblWinSATVersion.TabIndex = 78
        Me.lblWinSATVersion.Text = "..."
        Me.lblWinSATVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWinInstallDate
        '
        Me.lblWinInstallDate.AutoEllipsis = True
        Me.lblWinInstallDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblWinInstallDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWinInstallDate.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinInstallDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblWinInstallDate.Location = New System.Drawing.Point(172, 241)
        Me.lblWinInstallDate.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.lblWinInstallDate.Name = "lblWinInstallDate"
        Me.lblWinInstallDate.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblWinInstallDate.Size = New System.Drawing.Size(452, 31)
        Me.lblWinInstallDate.TabIndex = 77
        Me.lblWinInstallDate.Text = "..."
        Me.lblWinInstallDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSystemUptime
        '
        Me.lblSystemUptime.AutoEllipsis = True
        Me.lblSystemUptime.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblSystemUptime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSystemUptime.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemUptime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblSystemUptime.Location = New System.Drawing.Point(172, 273)
        Me.lblSystemUptime.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.lblSystemUptime.Name = "lblSystemUptime"
        Me.lblSystemUptime.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblSystemUptime.Size = New System.Drawing.Size(452, 31)
        Me.lblSystemUptime.TabIndex = 79
        Me.lblSystemUptime.Text = "..."
        Me.lblSystemUptime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWinSATAPIVersion
        '
        Me.lblWinSATAPIVersion.AutoEllipsis = True
        Me.lblWinSATAPIVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblWinSATAPIVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWinSATAPIVersion.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinSATAPIVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.lblWinSATAPIVersion.Location = New System.Drawing.Point(172, 201)
        Me.lblWinSATAPIVersion.Margin = New System.Windows.Forms.Padding(1, 0, 0, 1)
        Me.lblWinSATAPIVersion.Name = "lblWinSATAPIVersion"
        Me.lblWinSATAPIVersion.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblWinSATAPIVersion.Size = New System.Drawing.Size(452, 31)
        Me.lblWinSATAPIVersion.TabIndex = 78
        Me.lblWinSATAPIVersion.Text = "..."
        Me.lblWinSATAPIVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSystemUptimeText
        '
        Me.lblSystemUptimeText.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblSystemUptimeText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSystemUptimeText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemUptimeText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblSystemUptimeText.Location = New System.Drawing.Point(0, 273)
        Me.lblSystemUptimeText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblSystemUptimeText.Name = "lblSystemUptimeText"
        Me.lblSystemUptimeText.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblSystemUptimeText.Size = New System.Drawing.Size(171, 31)
        Me.lblSystemUptimeText.TabIndex = 49
        Me.lblSystemUptimeText.Text = "System Uptime"
        Me.lblSystemUptimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWinInstallDateText
        '
        Me.lblWinInstallDateText.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblWinInstallDateText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWinInstallDateText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinInstallDateText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblWinInstallDateText.Location = New System.Drawing.Point(0, 241)
        Me.lblWinInstallDateText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblWinInstallDateText.Name = "lblWinInstallDateText"
        Me.lblWinInstallDateText.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblWinInstallDateText.Size = New System.Drawing.Size(171, 31)
        Me.lblWinInstallDateText.TabIndex = 48
        Me.lblWinInstallDateText.Text = "Install Date"
        Me.lblWinInstallDateText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWinSATAPIVersionText
        '
        Me.lblWinSATAPIVersionText.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblWinSATAPIVersionText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWinSATAPIVersionText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinSATAPIVersionText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblWinSATAPIVersionText.Location = New System.Drawing.Point(0, 201)
        Me.lblWinSATAPIVersionText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblWinSATAPIVersionText.Name = "lblWinSATAPIVersionText"
        Me.lblWinSATAPIVersionText.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblWinSATAPIVersionText.Size = New System.Drawing.Size(171, 31)
        Me.lblWinSATAPIVersionText.TabIndex = 52
        Me.lblWinSATAPIVersionText.Text = "WinSAT API Version"
        Me.lblWinSATAPIVersionText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWinSATVersionText
        '
        Me.lblWinSATVersionText.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblWinSATVersionText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWinSATVersionText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinSATVersionText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblWinSATVersionText.Location = New System.Drawing.Point(0, 170)
        Me.lblWinSATVersionText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblWinSATVersionText.Name = "lblWinSATVersionText"
        Me.lblWinSATVersionText.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblWinSATVersionText.Size = New System.Drawing.Size(171, 30)
        Me.lblWinSATVersionText.TabIndex = 51
        Me.lblWinSATVersionText.Text = "WinSAT Version"
        Me.lblWinSATVersionText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKernelVersionText
        '
        Me.lblKernelVersionText.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblKernelVersionText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblKernelVersionText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKernelVersionText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblKernelVersionText.Location = New System.Drawing.Point(0, 136)
        Me.lblKernelVersionText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblKernelVersionText.Name = "lblKernelVersionText"
        Me.lblKernelVersionText.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblKernelVersionText.Size = New System.Drawing.Size(171, 33)
        Me.lblKernelVersionText.TabIndex = 50
        Me.lblKernelVersionText.Text = "Kernel Version"
        Me.lblKernelVersionText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblServicePackText
        '
        Me.lblServicePackText.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblServicePackText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblServicePackText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicePackText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblServicePackText.Location = New System.Drawing.Point(0, 96)
        Me.lblServicePackText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblServicePackText.Name = "lblServicePackText"
        Me.lblServicePackText.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblServicePackText.Size = New System.Drawing.Size(171, 31)
        Me.lblServicePackText.TabIndex = 49
        Me.lblServicePackText.Text = "Service Pack"
        Me.lblServicePackText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblBitnessText
        '
        Me.lblBitnessText.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblBitnessText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBitnessText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBitnessText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblBitnessText.Location = New System.Drawing.Point(0, 64)
        Me.lblBitnessText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblBitnessText.Name = "lblBitnessText"
        Me.lblBitnessText.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblBitnessText.Size = New System.Drawing.Size(171, 31)
        Me.lblBitnessText.TabIndex = 49
        Me.lblBitnessText.Text = "Bitness"
        Me.lblBitnessText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblOsText
        '
        Me.lblOsText.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblOsText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblOsText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOsText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblOsText.Location = New System.Drawing.Point(0, 32)
        Me.lblOsText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblOsText.Name = "lblOsText"
        Me.lblOsText.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblOsText.Size = New System.Drawing.Size(171, 31)
        Me.lblOsText.TabIndex = 48
        Me.lblOsText.Text = "Operating System"
        Me.lblOsText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUsernameText
        '
        Me.lblUsernameText.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblUsernameText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUsernameText.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsernameText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblUsernameText.Location = New System.Drawing.Point(0, 0)
        Me.lblUsernameText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.lblUsernameText.Name = "lblUsernameText"
        Me.lblUsernameText.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.lblUsernameText.Size = New System.Drawing.Size(171, 31)
        Me.lblUsernameText.TabIndex = 48
        Me.lblUsernameText.Text = "Username"
        Me.lblUsernameText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.ForeColor = System.Drawing.Color.Black
        Me.pnlSplit.Location = New System.Drawing.Point(1, 41)
        Me.pnlSplit.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(636, 2)
        Me.pnlSplit.TabIndex = 126
        '
        'FormSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(638, 362)
        Me.Controls.Add(Me.pnlSplit)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.panTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(638, 362)
        Me.MinimumSize = New System.Drawing.Size(638, 362)
        Me.Name = "FormSystem"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "System Details"
        Me.panTitle.ResumeLayout(False)
        Me.tlpTitleIcon.ResumeLayout(False)
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        Me.tlpItems.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents tlpTitleIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents icnMain As System.Windows.Forms.PictureBox
    Friend WithEvents tlpItems As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblOsText As System.Windows.Forms.Label
    Friend WithEvents lblBitnessText As System.Windows.Forms.Label
    Friend WithEvents lblServicePackText As System.Windows.Forms.Label
    Friend WithEvents lblServicePack As System.Windows.Forms.Label
    Friend WithEvents lblOs As System.Windows.Forms.Label
    Friend WithEvents lblBitness As System.Windows.Forms.Label
    Friend WithEvents lblKernelVersionText As System.Windows.Forms.Label
    Friend WithEvents lblKernelVersion As System.Windows.Forms.Label
    Friend WithEvents lblWinSATVersionText As System.Windows.Forms.Label
    Friend WithEvents lblWinSATVersion As System.Windows.Forms.Label
    Friend WithEvents lblWinSATAPIVersionText As System.Windows.Forms.Label
    Friend WithEvents lblWinSATAPIVersion As System.Windows.Forms.Label
    Friend WithEvents lblSystemUptime As System.Windows.Forms.Label
    Friend WithEvents lblUsernameText As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblWinInstallDateText As Label
    Friend WithEvents lblWinInstallDate As Label
    Friend WithEvents pnlSplit As Panel
    Friend WithEvents lblSystemUptimeText As Label
    Friend WithEvents cmdExportInfo As Button
End Class
