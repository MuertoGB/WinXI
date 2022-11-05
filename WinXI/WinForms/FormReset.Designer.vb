Imports WinXI.Gambol.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReset))
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tlpTitleIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.icnMain = New System.Windows.Forms.PictureBox()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlWinXI = New System.Windows.Forms.Panel()
        Me.lblApplicationInf = New System.Windows.Forms.Label()
        Me.tlpWinXIControls = New System.Windows.Forms.TableLayoutPanel()
        Me.cbAgreeApplication = New WinXI.Gambol.Controls.GambolCheckbox()
        Me.lblApplication = New System.Windows.Forms.Label()
        Me.pnlWEI = New System.Windows.Forms.Panel()
        Me.lblWinsatInf = New System.Windows.Forms.Label()
        Me.tlpWEICOntrols = New System.Windows.Forms.TableLayoutPanel()
        Me.cbAgreeWinsat = New WinXI.Gambol.Controls.GambolCheckbox()
        Me.lblWinSAT = New System.Windows.Forms.Label()
        Me.tlpControls = New System.Windows.Forms.TableLayoutPanel()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.pnlTitle.SuspendLayout()
        Me.tlpTitleIcon.SuspendLayout()
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMain.SuspendLayout()
        Me.pnlWinXI.SuspendLayout()
        Me.tlpWinXIControls.SuspendLayout()
        Me.pnlWEI.SuspendLayout()
        Me.tlpWEICOntrols.SuspendLayout()
        Me.tlpControls.SuspendLayout()
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
        Me.pnlTitle.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(512, 40)
        Me.pnlTitle.TabIndex = 0
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
        Me.lblTitle.Size = New System.Drawing.Size(432, 40)
        Me.lblTitle.TabIndex = 70
        Me.lblTitle.Text = "Reset"
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
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(472, 0)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.cmdClose.Size = New System.Drawing.Size(40, 40)
        Me.cmdClose.TabIndex = 0
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
        'tlpMain
        '
        Me.tlpMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.pnlWinXI, 0, 1)
        Me.tlpMain.Controls.Add(Me.pnlWEI, 0, 0)
        Me.tlpMain.Controls.Add(Me.tlpControls, 0, 2)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(1, 43)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 4
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.tlpMain.Size = New System.Drawing.Size(512, 246)
        Me.tlpMain.TabIndex = 127
        '
        'pnlWinXI
        '
        Me.pnlWinXI.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlWinXI.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlWinXI.Controls.Add(Me.lblApplicationInf)
        Me.pnlWinXI.Controls.Add(Me.tlpWinXIControls)
        Me.pnlWinXI.Controls.Add(Me.lblApplication)
        Me.pnlWinXI.Location = New System.Drawing.Point(6, 101)
        Me.pnlWinXI.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.pnlWinXI.Name = "pnlWinXI"
        Me.pnlWinXI.Size = New System.Drawing.Size(500, 90)
        Me.pnlWinXI.TabIndex = 128
        '
        'lblApplicationInf
        '
        Me.lblApplicationInf.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lblApplicationInf.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblApplicationInf.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplicationInf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lblApplicationInf.Location = New System.Drawing.Point(0, 28)
        Me.lblApplicationInf.Margin = New System.Windows.Forms.Padding(0)
        Me.lblApplicationInf.Name = "lblApplicationInf"
        Me.lblApplicationInf.Size = New System.Drawing.Size(500, 22)
        Me.lblApplicationInf.TabIndex = 114
        Me.lblApplicationInf.Text = " · Permanently deletes all application files and folders."
        '
        'tlpWinXIControls
        '
        Me.tlpWinXIControls.ColumnCount = 1
        Me.tlpWinXIControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.tlpWinXIControls.Controls.Add(Me.cbAgreeApplication, 0, 0)
        Me.tlpWinXIControls.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpWinXIControls.Location = New System.Drawing.Point(0, 56)
        Me.tlpWinXIControls.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpWinXIControls.Name = "tlpWinXIControls"
        Me.tlpWinXIControls.RowCount = 1
        Me.tlpWinXIControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpWinXIControls.Size = New System.Drawing.Size(500, 34)
        Me.tlpWinXIControls.TabIndex = 131
        '
        'cbAgreeApplication
        '
        Me.cbAgreeApplication.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbAgreeApplication.BackColor = System.Drawing.Color.Transparent
        Me.cbAgreeApplication.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.cbAgreeApplication.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.cbAgreeApplication.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbAgreeApplication.ClientColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cbAgreeApplication.ClientColorActive = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cbAgreeApplication.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAgreeApplication.ForeColor = System.Drawing.Color.White
        Me.cbAgreeApplication.Location = New System.Drawing.Point(8, 6)
        Me.cbAgreeApplication.Margin = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cbAgreeApplication.Name = "cbAgreeApplication"
        Me.cbAgreeApplication.Size = New System.Drawing.Size(92, 22)
        Me.cbAgreeApplication.TabIndex = 2
        Me.cbAgreeApplication.Text = "I agree"
        '
        'lblApplication
        '
        Me.lblApplication.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblApplication.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblApplication.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplication.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblApplication.Location = New System.Drawing.Point(0, 0)
        Me.lblApplication.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApplication.Name = "lblApplication"
        Me.lblApplication.Size = New System.Drawing.Size(500, 28)
        Me.lblApplication.TabIndex = 130
        Me.lblApplication.Text = "WinXI"
        Me.lblApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlWEI
        '
        Me.pnlWEI.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlWEI.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pnlWEI.Controls.Add(Me.lblWinsatInf)
        Me.pnlWEI.Controls.Add(Me.tlpWEICOntrols)
        Me.pnlWEI.Controls.Add(Me.lblWinSAT)
        Me.pnlWEI.Location = New System.Drawing.Point(6, 6)
        Me.pnlWEI.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.pnlWEI.Name = "pnlWEI"
        Me.pnlWEI.Size = New System.Drawing.Size(500, 90)
        Me.pnlWEI.TabIndex = 129
        '
        'lblWinsatInf
        '
        Me.lblWinsatInf.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lblWinsatInf.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblWinsatInf.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinsatInf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lblWinsatInf.Location = New System.Drawing.Point(0, 28)
        Me.lblWinsatInf.Margin = New System.Windows.Forms.Padding(0)
        Me.lblWinsatInf.Name = "lblWinsatInf"
        Me.lblWinsatInf.Size = New System.Drawing.Size(500, 22)
        Me.lblWinsatInf.TabIndex = 114
        Me.lblWinsatInf.Text = " · Permanently deletes all system scores and the log file."
        '
        'tlpWEICOntrols
        '
        Me.tlpWEICOntrols.ColumnCount = 1
        Me.tlpWEICOntrols.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.tlpWEICOntrols.Controls.Add(Me.cbAgreeWinsat, 0, 0)
        Me.tlpWEICOntrols.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tlpWEICOntrols.Location = New System.Drawing.Point(0, 56)
        Me.tlpWEICOntrols.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpWEICOntrols.Name = "tlpWEICOntrols"
        Me.tlpWEICOntrols.RowCount = 1
        Me.tlpWEICOntrols.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpWEICOntrols.Size = New System.Drawing.Size(500, 34)
        Me.tlpWEICOntrols.TabIndex = 132
        '
        'cbAgreeWinsat
        '
        Me.cbAgreeWinsat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbAgreeWinsat.BackColor = System.Drawing.Color.Transparent
        Me.cbAgreeWinsat.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.cbAgreeWinsat.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.cbAgreeWinsat.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbAgreeWinsat.ClientColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cbAgreeWinsat.ClientColorActive = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cbAgreeWinsat.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAgreeWinsat.ForeColor = System.Drawing.Color.White
        Me.cbAgreeWinsat.Location = New System.Drawing.Point(8, 6)
        Me.cbAgreeWinsat.Margin = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.cbAgreeWinsat.Name = "cbAgreeWinsat"
        Me.cbAgreeWinsat.Size = New System.Drawing.Size(92, 22)
        Me.cbAgreeWinsat.TabIndex = 0
        Me.cbAgreeWinsat.Text = "I agree"
        '
        'lblWinSAT
        '
        Me.lblWinSAT.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lblWinSAT.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblWinSAT.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinSAT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblWinSAT.Location = New System.Drawing.Point(0, 0)
        Me.lblWinSAT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWinSAT.Name = "lblWinSAT"
        Me.lblWinSAT.Size = New System.Drawing.Size(500, 28)
        Me.lblWinSAT.TabIndex = 107
        Me.lblWinSAT.Text = "Windows Experience Index"
        Me.lblWinSAT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpControls
        '
        Me.tlpControls.ColumnCount = 2
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.49606!))
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.50394!))
        Me.tlpControls.Controls.Add(Me.lblWarning, 0, 0)
        Me.tlpControls.Controls.Add(Me.cmdDelete, 1, 0)
        Me.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpControls.Location = New System.Drawing.Point(0, 196)
        Me.tlpControls.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpControls.Name = "tlpControls"
        Me.tlpControls.RowCount = 1
        Me.tlpControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpControls.Size = New System.Drawing.Size(512, 49)
        Me.tlpControls.TabIndex = 130
        '
        'lblWarning
        '
        Me.lblWarning.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblWarning.AutoSize = True
        Me.lblWarning.BackColor = System.Drawing.Color.Transparent
        Me.lblWarning.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWarning.ForeColor = System.Drawing.Color.Tomato
        Me.lblWarning.Location = New System.Drawing.Point(0, 13)
        Me.lblWarning.Margin = New System.Windows.Forms.Padding(0)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(246, 23)
        Me.lblWarning.TabIndex = 115
        Me.lblWarning.Text = " ··· Files will not be recoverable!"
        Me.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.cmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdDelete.FlatAppearance.BorderSize = 0
        Me.cmdDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdDelete.Location = New System.Drawing.Point(310, 7)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(196, 35)
        Me.cmdDelete.TabIndex = 131
        Me.cmdDelete.Text = "DELETE SELECTED FILES"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.ForeColor = System.Drawing.Color.Black
        Me.pnlSplit.Location = New System.Drawing.Point(1, 41)
        Me.pnlSplit.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(512, 2)
        Me.pnlSplit.TabIndex = 126
        '
        'FormReset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(514, 290)
        Me.Controls.Add(Me.tlpMain)
        Me.Controls.Add(Me.pnlSplit)
        Me.Controls.Add(Me.pnlTitle)
        Me.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(514, 290)
        Me.MinimumSize = New System.Drawing.Size(514, 290)
        Me.Name = "FormReset"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cleanup"
        Me.pnlTitle.ResumeLayout(False)
        Me.tlpTitleIcon.ResumeLayout(False)
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMain.ResumeLayout(False)
        Me.pnlWinXI.ResumeLayout(False)
        Me.tlpWinXIControls.ResumeLayout(False)
        Me.pnlWEI.ResumeLayout(False)
        Me.tlpWEICOntrols.ResumeLayout(False)
        Me.tlpControls.ResumeLayout(False)
        Me.tlpControls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpTitleIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents icnMain As System.Windows.Forms.PictureBox
    Friend WithEvents pnlSplit As Panel
    Friend WithEvents pnlWinXI As Panel
    Friend WithEvents lblApplicationInf As Label
    Friend WithEvents tlpWinXIControls As TableLayoutPanel
    Friend WithEvents cbAgreeApplication As GambolCheckbox
    Friend WithEvents lblApplication As Label
    Friend WithEvents pnlWEI As Panel
    Friend WithEvents lblWinsatInf As Label
    Friend WithEvents tlpWEICOntrols As TableLayoutPanel
    Friend WithEvents cbAgreeWinsat As GambolCheckbox
    Friend WithEvents lblWinSAT As Label
    Friend WithEvents lblWarning As Label
    Friend WithEvents tlpControls As TableLayoutPanel
    Friend WithEvents cmdDelete As Button
End Class
