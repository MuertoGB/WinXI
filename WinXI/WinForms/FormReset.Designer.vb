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
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.PbxHead = New System.Windows.Forms.PictureBox()
        Me.TlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.PanPurge = New System.Windows.Forms.Panel()
        Me.lblApplicationInf = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblApplication = New System.Windows.Forms.Label()
        Me.PanReset = New System.Windows.Forms.Panel()
        Me.lblWinsatInf = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblWinSAT = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.LabNotRecover = New System.Windows.Forms.Label()
        Me.CmdDelete = New System.Windows.Forms.Button()
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.cbAgreeApplication = New WinXI.Gambol.Controls.GambolCheckbox()
        Me.cbAgreeWinsat = New WinXI.Gambol.Controls.GambolCheckbox()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TlpMain.SuspendLayout()
        Me.PanPurge.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanReset.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
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
        Me.PanHead.Margin = New System.Windows.Forms.Padding(2)
        Me.PanHead.Name = "PanHead"
        Me.PanHead.Size = New System.Drawing.Size(512, 40)
        Me.PanHead.TabIndex = 0
        '
        'LabHead
        '
        Me.LabHead.BackColor = System.Drawing.Color.Transparent
        Me.LabHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabHead.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHead.ForeColor = System.Drawing.Color.White
        Me.LabHead.Location = New System.Drawing.Point(40, 0)
        Me.LabHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabHead.Name = "LabHead"
        Me.LabHead.Size = New System.Drawing.Size(432, 40)
        Me.LabHead.TabIndex = 70
        Me.LabHead.Text = "Reset"
        Me.LabHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Transparent
        Me.CmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.CmdClose.FlatAppearance.BorderSize = 0
        Me.CmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdClose.Font = New System.Drawing.Font("Segoe UI", 10.8!)
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(472, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.CmdClose.Size = New System.Drawing.Size(40, 40)
        Me.CmdClose.TabIndex = 0
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
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
        Me.TlpHeadImage.TabIndex = 73
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
        'TlpMain
        '
        Me.TlpMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TlpMain.ColumnCount = 1
        Me.TlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpMain.Controls.Add(Me.PanPurge, 0, 1)
        Me.TlpMain.Controls.Add(Me.PanReset, 0, 0)
        Me.TlpMain.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpMain.Location = New System.Drawing.Point(1, 43)
        Me.TlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpMain.Name = "TlpMain"
        Me.TlpMain.RowCount = 4
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TlpMain.Size = New System.Drawing.Size(512, 246)
        Me.TlpMain.TabIndex = 127
        '
        'PanPurge
        '
        Me.PanPurge.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanPurge.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanPurge.Controls.Add(Me.lblApplicationInf)
        Me.PanPurge.Controls.Add(Me.TableLayoutPanel1)
        Me.PanPurge.Controls.Add(Me.lblApplication)
        Me.PanPurge.Location = New System.Drawing.Point(6, 101)
        Me.PanPurge.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.PanPurge.Name = "PanPurge"
        Me.PanPurge.Size = New System.Drawing.Size(500, 90)
        Me.PanPurge.TabIndex = 128
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
        Me.lblApplicationInf.Text = " · Deletes all WinXI files, folders and logs permanenetly."
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cbAgreeApplication, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 56)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(500, 34)
        Me.TableLayoutPanel1.TabIndex = 131
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
        Me.lblApplication.Text = "Application"
        Me.lblApplication.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanReset
        '
        Me.PanReset.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PanReset.Controls.Add(Me.lblWinsatInf)
        Me.PanReset.Controls.Add(Me.TableLayoutPanel2)
        Me.PanReset.Controls.Add(Me.lblWinSAT)
        Me.PanReset.Location = New System.Drawing.Point(6, 6)
        Me.PanReset.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.PanReset.Name = "PanReset"
        Me.PanReset.Size = New System.Drawing.Size(500, 90)
        Me.PanReset.TabIndex = 129
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
        Me.lblWinsatInf.Text = " · Deletes all system scores and the log file permanently."
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.cbAgreeWinsat, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 56)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(500, 34)
        Me.TableLayoutPanel2.TabIndex = 132
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
        Me.lblWinSAT.Text = "WinSAT"
        Me.lblWinSAT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.49606!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.50394!))
        Me.TableLayoutPanel3.Controls.Add(Me.LabNotRecover, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.CmdDelete, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 196)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(512, 49)
        Me.TableLayoutPanel3.TabIndex = 130
        '
        'LabNotRecover
        '
        Me.LabNotRecover.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabNotRecover.AutoSize = True
        Me.LabNotRecover.BackColor = System.Drawing.Color.Transparent
        Me.LabNotRecover.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNotRecover.ForeColor = System.Drawing.Color.Tomato
        Me.LabNotRecover.Location = New System.Drawing.Point(0, 13)
        Me.LabNotRecover.Margin = New System.Windows.Forms.Padding(0)
        Me.LabNotRecover.Name = "LabNotRecover"
        Me.LabNotRecover.Size = New System.Drawing.Size(246, 23)
        Me.LabNotRecover.TabIndex = 115
        Me.LabNotRecover.Text = " ··· Files will not be recoverable!"
        Me.LabNotRecover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdDelete
        '
        Me.CmdDelete.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CmdDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdDelete.Enabled = False
        Me.CmdDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdDelete.FlatAppearance.BorderSize = 0
        Me.CmdDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdDelete.Location = New System.Drawing.Point(310, 7)
        Me.CmdDelete.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.CmdDelete.Name = "CmdDelete"
        Me.CmdDelete.Size = New System.Drawing.Size(196, 35)
        Me.CmdDelete.TabIndex = 131
        Me.CmdDelete.Text = "DELETE SELECTED FILES"
        Me.CmdDelete.UseVisualStyleBackColor = False
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.ForeColor = System.Drawing.Color.Black
        Me.PanSplit.Location = New System.Drawing.Point(1, 41)
        Me.PanSplit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(512, 2)
        Me.PanSplit.TabIndex = 126
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
        'FormReset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(514, 290)
        Me.Controls.Add(Me.TlpMain)
        Me.Controls.Add(Me.PanSplit)
        Me.Controls.Add(Me.PanHead)
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
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        CType(Me.PbxHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TlpMain.ResumeLayout(False)
        Me.PanPurge.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanReset.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanHead As System.Windows.Forms.Panel
    Friend WithEvents LabHead As System.Windows.Forms.Label
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents TlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TlpHeadImage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PbxHead As System.Windows.Forms.PictureBox
    Friend WithEvents PanSplit As Panel
    Friend WithEvents PanPurge As Panel
    Friend WithEvents lblApplicationInf As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cbAgreeApplication As GambolCheckbox
    Friend WithEvents lblApplication As Label
    Friend WithEvents PanReset As Panel
    Friend WithEvents lblWinsatInf As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents cbAgreeWinsat As GambolCheckbox
    Friend WithEvents lblWinSAT As Label
    Friend WithEvents LabNotRecover As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents CmdDelete As Button
End Class
