Imports WinXI.Gambol.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.icnMain = New System.Windows.Forms.PictureBox()
        Me.CmsExplorer = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetPositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartElevatedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.lblScale = New System.Windows.Forms.Label()
        Me.lblDiskScore = New System.Windows.Forms.Label()
        Me.lblGamingScore = New System.Windows.Forms.Label()
        Me.lblGraphicsScore = New System.Windows.Forms.Label()
        Me.lblMemoryScore = New System.Windows.Forms.Label()
        Me.lblProcessorScore = New System.Windows.Forms.Label()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblRated = New System.Windows.Forms.Label()
        Me.lblComponent = New System.Windows.Forms.Label()
        Me.lblProcessor = New System.Windows.Forms.Label()
        Me.lblDisk = New System.Windows.Forms.Label()
        Me.lblGaming = New System.Windows.Forms.Label()
        Me.lblGraphics = New System.Windows.Forms.Label()
        Me.lblMemory = New System.Windows.Forms.Label()
        Me.lblGamingR = New System.Windows.Forms.Label()
        Me.lblProcessorR = New System.Windows.Forms.Label()
        Me.lblDiskR = New System.Windows.Forms.Label()
        Me.lblMemoryR = New System.Windows.Forms.Label()
        Me.lblGraphicsR = New System.Windows.Forms.Label()
        Me.PanHead = New System.Windows.Forms.Panel()
        Me.cmdElevate = New System.Windows.Forms.Button()
        Me.CmdSettings = New System.Windows.Forms.Button()
        Me.TlpHeadSplit = New System.Windows.Forms.TableLayoutPanel()
        Me.PanHeadSplit = New System.Windows.Forms.Panel()
        Me.CmdMinimize = New System.Windows.Forms.Button()
        Me.CmdClose = New System.Windows.Forms.Button()
        Me.TlpHeadImage = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAppVersion = New System.Windows.Forms.Label()
        Me.lblLastAssessed = New System.Windows.Forms.Label()
        Me.lblLastAssessedString = New System.Windows.Forms.Label()
        Me.lblWinVerString = New System.Windows.Forms.Label()
        Me.lblWinVer = New System.Windows.Forms.Label()
        Me.lblValidityString = New System.Windows.Forms.Label()
        Me.CmdTools = New System.Windows.Forms.Button()
        Me.CmdExport = New System.Windows.Forms.Button()
        Me.CmdOptions = New System.Windows.Forms.Button()
        Me.CmdHelp = New System.Windows.Forms.Button()
        Me.PanCapture = New System.Windows.Forms.Panel()
        Me.PanSplit = New System.Windows.Forms.Panel()
        Me.TlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.CmdAssess = New System.Windows.Forms.Button()
        Me.TlpGridScore = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TlpComponent = New System.Windows.Forms.TableLayoutPanel()
        Me.TlpRated = New System.Windows.Forms.TableLayoutPanel()
        Me.TlpSubscore = New System.Windows.Forms.TableLayoutPanel()
        Me.TlpScore = New System.Windows.Forms.TableLayoutPanel()
        Me.PanBasescore = New System.Windows.Forms.Panel()
        Me.lblBasescore = New System.Windows.Forms.Label()
        Me.lblLowestSub = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PanBottom = New System.Windows.Forms.Panel()
        Me.PanSplitCenter = New System.Windows.Forms.Panel()
        Me.TlpBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.PanShowHardware2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.swHardware = New WinXI.Gambol.Controls.GambolSwitch()
        Me.lblShowHToggle = New System.Windows.Forms.Label()
        Me.CmdRunInDepth = New System.Windows.Forms.Button()
        Me.PanValidity = New System.Windows.Forms.Panel()
        Me.PanValidityState = New System.Windows.Forms.Panel()
        Me.lblValidity = New System.Windows.Forms.Label()
        Me.lblAssessmentDepth = New System.Windows.Forms.Label()
        Me.cmdMetrics = New System.Windows.Forms.Button()
        Me.lblShowMetrics = New System.Windows.Forms.Label()
        Me.lblShowHardware = New System.Windows.Forms.Label()
        Me.BMPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JPGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PNGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TXTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmsExport = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImgurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmsOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewImgurLinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewWinSATLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshScoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CreateCompatibilityiniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateSettingsiniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveResourcesToDiskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolstripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmsTools = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSystemDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunVerboseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsHelp = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MediaFeaturePackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TroubleshootingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.HotfixAvailableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateAvailableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangelogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcknowledgementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BMACToolstripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TlpMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdDebug = New System.Windows.Forms.Button()
        Me.TlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.cmsDebug = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ThrowUnhandledExceptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowToastInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToastWarningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToastErrorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenElevationWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsExplorer.SuspendLayout()
        Me.PanHead.SuspendLayout()
        Me.TlpHeadSplit.SuspendLayout()
        Me.TlpHeadImage.SuspendLayout()
        Me.PanCapture.SuspendLayout()
        Me.TlpTop.SuspendLayout()
        Me.TlpGridScore.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TlpComponent.SuspendLayout()
        Me.TlpRated.SuspendLayout()
        Me.TlpSubscore.SuspendLayout()
        Me.TlpScore.SuspendLayout()
        Me.PanBasescore.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.PanBottom.SuspendLayout()
        Me.TlpBottom.SuspendLayout()
        Me.PanShowHardware2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.PanValidity.SuspendLayout()
        Me.CmsExport.SuspendLayout()
        Me.CmsOptions.SuspendLayout()
        Me.CmsTools.SuspendLayout()
        Me.cmsHelp.SuspendLayout()
        Me.TlpMenu.SuspendLayout()
        Me.TlpMain.SuspendLayout()
        Me.cmsDebug.SuspendLayout()
        Me.SuspendLayout()
        '
        'icnMain
        '
        Me.icnMain.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.icnMain.BackColor = System.Drawing.Color.Transparent
        Me.icnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.icnMain.ContextMenuStrip = Me.CmsExplorer
        Me.icnMain.Image = Global.WinXI.My.Resources.Resources.ImgMainIcon24Px
        Me.icnMain.Location = New System.Drawing.Point(10, 10)
        Me.icnMain.Margin = New System.Windows.Forms.Padding(10, 0, 0, 6)
        Me.icnMain.Name = "icnMain"
        Me.icnMain.Size = New System.Drawing.Size(24, 24)
        Me.icnMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icnMain.TabIndex = 1
        Me.icnMain.TabStop = False
        '
        'CmsExplorer
        '
        Me.CmsExplorer.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CmsExplorer.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmsExplorer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinimizeToolStripMenuItem, Me.ResetPositionToolStripMenuItem, Me.RestartApplicationToolStripMenuItem, Me.RestartElevatedToolStripMenuItem, Me.ToolStripSeparator8, Me.CloseToolStripMenuItem, Me.ToolStripSeparator9, Me.AboutToolStripMenuItem1})
        Me.CmsExplorer.Name = "cmsExplorer"
        Me.CmsExplorer.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.CmsExplorer.ShowImageMargin = False
        Me.CmsExplorer.Size = New System.Drawing.Size(199, 184)
        '
        'MinimizeToolStripMenuItem
        '
        Me.MinimizeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimizeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MinimizeToolStripMenuItem.Name = "MinimizeToolStripMenuItem"
        Me.MinimizeToolStripMenuItem.Size = New System.Drawing.Size(198, 28)
        Me.MinimizeToolStripMenuItem.Text = "Minimize"
        '
        'ResetPositionToolStripMenuItem
        '
        Me.ResetPositionToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetPositionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ResetPositionToolStripMenuItem.Name = "ResetPositionToolStripMenuItem"
        Me.ResetPositionToolStripMenuItem.Size = New System.Drawing.Size(198, 28)
        Me.ResetPositionToolStripMenuItem.Text = "Reset Position"
        '
        'RestartApplicationToolStripMenuItem
        '
        Me.RestartApplicationToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartApplicationToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RestartApplicationToolStripMenuItem.Name = "RestartApplicationToolStripMenuItem"
        Me.RestartApplicationToolStripMenuItem.Size = New System.Drawing.Size(198, 28)
        Me.RestartApplicationToolStripMenuItem.Text = "Restart Application"
        '
        'RestartElevatedToolStripMenuItem
        '
        Me.RestartElevatedToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartElevatedToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.RestartElevatedToolStripMenuItem.Name = "RestartElevatedToolStripMenuItem"
        Me.RestartElevatedToolStripMenuItem.Size = New System.Drawing.Size(198, 28)
        Me.RestartElevatedToolStripMenuItem.Text = "Restart Elevated"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(195, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(198, 28)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(195, 6)
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(198, 28)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'lblHead
        '
        Me.lblHead.BackColor = System.Drawing.Color.Transparent
        Me.lblHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHead.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead.ForeColor = System.Drawing.Color.White
        Me.lblHead.Location = New System.Drawing.Point(0, 0)
        Me.lblHead.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(923, 50)
        Me.lblHead.TabIndex = 1
        Me.lblHead.Text = "WinXI - Experience Index Tool"
        Me.lblHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScale
        '
        Me.lblScale.AutoEllipsis = True
        Me.lblScale.BackColor = System.Drawing.Color.Transparent
        Me.lblScale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblScale.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.lblScale.Location = New System.Drawing.Point(4, 0)
        Me.lblScale.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScale.Name = "lblScale"
        Me.lblScale.Size = New System.Drawing.Size(690, 38)
        Me.lblScale.TabIndex = 27
        Me.lblScale.Text = "..."
        Me.lblScale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiskScore
        '
        Me.lblDiskScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblDiskScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDiskScore.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiskScore.ForeColor = System.Drawing.Color.White
        Me.lblDiskScore.Location = New System.Drawing.Point(0, 152)
        Me.lblDiskScore.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblDiskScore.Name = "lblDiskScore"
        Me.lblDiskScore.Size = New System.Drawing.Size(99, 37)
        Me.lblDiskScore.TabIndex = 24
        Me.lblDiskScore.Text = "..."
        Me.lblDiskScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGamingScore
        '
        Me.lblGamingScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblGamingScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGamingScore.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGamingScore.ForeColor = System.Drawing.Color.White
        Me.lblGamingScore.Location = New System.Drawing.Point(0, 114)
        Me.lblGamingScore.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblGamingScore.Name = "lblGamingScore"
        Me.lblGamingScore.Size = New System.Drawing.Size(99, 37)
        Me.lblGamingScore.TabIndex = 23
        Me.lblGamingScore.Text = "..."
        Me.lblGamingScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGraphicsScore
        '
        Me.lblGraphicsScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblGraphicsScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGraphicsScore.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraphicsScore.ForeColor = System.Drawing.Color.White
        Me.lblGraphicsScore.Location = New System.Drawing.Point(0, 76)
        Me.lblGraphicsScore.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblGraphicsScore.Name = "lblGraphicsScore"
        Me.lblGraphicsScore.Size = New System.Drawing.Size(99, 37)
        Me.lblGraphicsScore.TabIndex = 24
        Me.lblGraphicsScore.Text = "..."
        Me.lblGraphicsScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMemoryScore
        '
        Me.lblMemoryScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblMemoryScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMemoryScore.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemoryScore.ForeColor = System.Drawing.Color.White
        Me.lblMemoryScore.Location = New System.Drawing.Point(0, 38)
        Me.lblMemoryScore.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblMemoryScore.Name = "lblMemoryScore"
        Me.lblMemoryScore.Size = New System.Drawing.Size(99, 37)
        Me.lblMemoryScore.TabIndex = 23
        Me.lblMemoryScore.Text = "..."
        Me.lblMemoryScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProcessorScore
        '
        Me.lblProcessorScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblProcessorScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProcessorScore.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessorScore.ForeColor = System.Drawing.Color.White
        Me.lblProcessorScore.Location = New System.Drawing.Point(0, 0)
        Me.lblProcessorScore.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblProcessorScore.Name = "lblProcessorScore"
        Me.lblProcessorScore.Size = New System.Drawing.Size(99, 37)
        Me.lblProcessorScore.TabIndex = 22
        Me.lblProcessorScore.Text = "..."
        Me.lblProcessorScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.BackColor = System.Drawing.Color.Transparent
        Me.lblBase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBase.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblBase.Location = New System.Drawing.Point(703, 0)
        Me.lblBase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(184, 37)
        Me.lblBase.TabIndex = 4
        Me.lblBase.Text = "Base score"
        Me.lblBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.BackColor = System.Drawing.Color.Transparent
        Me.lblSub.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSub.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblSub.Location = New System.Drawing.Point(603, 0)
        Me.lblSub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(92, 37)
        Me.lblSub.TabIndex = 3
        Me.lblSub.Text = "Subscore"
        Me.lblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRated
        '
        Me.lblRated.BackColor = System.Drawing.Color.Transparent
        Me.lblRated.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRated.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRated.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblRated.Location = New System.Drawing.Point(193, 0)
        Me.lblRated.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRated.Name = "lblRated"
        Me.lblRated.Size = New System.Drawing.Size(402, 37)
        Me.lblRated.TabIndex = 2
        Me.lblRated.Text = "What is Rated?"
        Me.lblRated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblComponent
        '
        Me.lblComponent.BackColor = System.Drawing.Color.Transparent
        Me.lblComponent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblComponent.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComponent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblComponent.Location = New System.Drawing.Point(4, 0)
        Me.lblComponent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblComponent.Name = "lblComponent"
        Me.lblComponent.Size = New System.Drawing.Size(181, 37)
        Me.lblComponent.TabIndex = 1
        Me.lblComponent.Text = "Component"
        Me.lblComponent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProcessor
        '
        Me.lblProcessor.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblProcessor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProcessor.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblProcessor.Location = New System.Drawing.Point(0, 0)
        Me.lblProcessor.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblProcessor.Name = "lblProcessor"
        Me.lblProcessor.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblProcessor.Size = New System.Drawing.Size(189, 37)
        Me.lblProcessor.TabIndex = 13
        Me.lblProcessor.Text = "Processor"
        Me.lblProcessor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisk
        '
        Me.lblDisk.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblDisk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDisk.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblDisk.Location = New System.Drawing.Point(0, 152)
        Me.lblDisk.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblDisk.Name = "lblDisk"
        Me.lblDisk.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblDisk.Size = New System.Drawing.Size(189, 37)
        Me.lblDisk.TabIndex = 13
        Me.lblDisk.Text = "Primary Hard Disk"
        Me.lblDisk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGaming
        '
        Me.lblGaming.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblGaming.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGaming.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGaming.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblGaming.Location = New System.Drawing.Point(0, 114)
        Me.lblGaming.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblGaming.Name = "lblGaming"
        Me.lblGaming.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblGaming.Size = New System.Drawing.Size(189, 37)
        Me.lblGaming.TabIndex = 13
        Me.lblGaming.Text = "Gaming Graphics"
        Me.lblGaming.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGraphics
        '
        Me.lblGraphics.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblGraphics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGraphics.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraphics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblGraphics.Location = New System.Drawing.Point(0, 76)
        Me.lblGraphics.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblGraphics.Name = "lblGraphics"
        Me.lblGraphics.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblGraphics.Size = New System.Drawing.Size(189, 37)
        Me.lblGraphics.TabIndex = 3
        Me.lblGraphics.Text = "Graphics"
        Me.lblGraphics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMemory
        '
        Me.lblMemory.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblMemory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMemory.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblMemory.Location = New System.Drawing.Point(0, 38)
        Me.lblMemory.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblMemory.Name = "lblMemory"
        Me.lblMemory.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblMemory.Size = New System.Drawing.Size(189, 37)
        Me.lblMemory.TabIndex = 2
        Me.lblMemory.Text = "Memory (RAM)"
        Me.lblMemory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGamingR
        '
        Me.lblGamingR.AutoEllipsis = True
        Me.lblGamingR.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblGamingR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGamingR.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGamingR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.lblGamingR.Location = New System.Drawing.Point(0, 114)
        Me.lblGamingR.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblGamingR.Name = "lblGamingR"
        Me.lblGamingR.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblGamingR.Size = New System.Drawing.Size(409, 37)
        Me.lblGamingR.TabIndex = 30
        Me.lblGamingR.Text = "3D business and gaming graphics performance"
        Me.lblGamingR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProcessorR
        '
        Me.lblProcessorR.AutoEllipsis = True
        Me.lblProcessorR.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblProcessorR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProcessorR.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessorR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.lblProcessorR.Location = New System.Drawing.Point(0, 0)
        Me.lblProcessorR.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblProcessorR.Name = "lblProcessorR"
        Me.lblProcessorR.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblProcessorR.Size = New System.Drawing.Size(409, 37)
        Me.lblProcessorR.TabIndex = 27
        Me.lblProcessorR.Text = "Calculations per second"
        Me.lblProcessorR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiskR
        '
        Me.lblDiskR.AutoEllipsis = True
        Me.lblDiskR.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblDiskR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDiskR.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiskR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.lblDiskR.Location = New System.Drawing.Point(0, 152)
        Me.lblDiskR.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblDiskR.Name = "lblDiskR"
        Me.lblDiskR.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblDiskR.Size = New System.Drawing.Size(409, 37)
        Me.lblDiskR.TabIndex = 31
        Me.lblDiskR.Text = "Disk data transfer rate"
        Me.lblDiskR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMemoryR
        '
        Me.lblMemoryR.AutoEllipsis = True
        Me.lblMemoryR.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblMemoryR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMemoryR.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemoryR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.lblMemoryR.Location = New System.Drawing.Point(0, 38)
        Me.lblMemoryR.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblMemoryR.Name = "lblMemoryR"
        Me.lblMemoryR.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblMemoryR.Size = New System.Drawing.Size(409, 37)
        Me.lblMemoryR.TabIndex = 28
        Me.lblMemoryR.Text = "Memory operations per second"
        Me.lblMemoryR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGraphicsR
        '
        Me.lblGraphicsR.AutoEllipsis = True
        Me.lblGraphicsR.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lblGraphicsR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGraphicsR.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraphicsR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.lblGraphicsR.Location = New System.Drawing.Point(0, 76)
        Me.lblGraphicsR.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblGraphicsR.Name = "lblGraphicsR"
        Me.lblGraphicsR.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblGraphicsR.Size = New System.Drawing.Size(409, 37)
        Me.lblGraphicsR.TabIndex = 29
        Me.lblGraphicsR.Text = "Desktop graphics performance"
        Me.lblGraphicsR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanHead
        '
        Me.PanHead.BackColor = System.Drawing.Color.Transparent
        Me.PanHead.Controls.Add(Me.cmdElevate)
        Me.PanHead.Controls.Add(Me.CmdSettings)
        Me.PanHead.Controls.Add(Me.TlpHeadSplit)
        Me.PanHead.Controls.Add(Me.CmdMinimize)
        Me.PanHead.Controls.Add(Me.CmdClose)
        Me.PanHead.Controls.Add(Me.TlpHeadImage)
        Me.PanHead.Controls.Add(Me.lblHead)
        Me.PanHead.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanHead.Location = New System.Drawing.Point(0, 0)
        Me.PanHead.Margin = New System.Windows.Forms.Padding(0)
        Me.PanHead.Name = "PanHead"
        Me.PanHead.Size = New System.Drawing.Size(923, 50)
        Me.PanHead.TabIndex = 59
        '
        'cmdElevate
        '
        Me.cmdElevate.BackColor = System.Drawing.Color.Transparent
        Me.cmdElevate.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdElevate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdElevate.FlatAppearance.BorderSize = 0
        Me.cmdElevate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmdElevate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.cmdElevate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdElevate.Font = New System.Drawing.Font("Segoe MDL2 Assets", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdElevate.ForeColor = System.Drawing.Color.White
        Me.cmdElevate.Location = New System.Drawing.Point(707, 0)
        Me.cmdElevate.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdElevate.Name = "cmdElevate"
        Me.cmdElevate.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.cmdElevate.Size = New System.Drawing.Size(50, 50)
        Me.cmdElevate.TabIndex = 11
        Me.cmdElevate.TabStop = False
        Me.cmdElevate.Text = ""
        Me.cmdElevate.UseVisualStyleBackColor = False
        '
        'CmdSettings
        '
        Me.CmdSettings.BackColor = System.Drawing.Color.Transparent
        Me.CmdSettings.Dock = System.Windows.Forms.DockStyle.Right
        Me.CmdSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdSettings.FlatAppearance.BorderSize = 0
        Me.CmdSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.CmdSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.CmdSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSettings.Font = New System.Drawing.Font("Segoe MDL2 Assets", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSettings.ForeColor = System.Drawing.Color.White
        Me.CmdSettings.Location = New System.Drawing.Point(757, 0)
        Me.CmdSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdSettings.Name = "CmdSettings"
        Me.CmdSettings.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.CmdSettings.Size = New System.Drawing.Size(50, 50)
        Me.CmdSettings.TabIndex = 0
        Me.CmdSettings.TabStop = False
        Me.CmdSettings.Text = ""
        Me.CmdSettings.UseVisualStyleBackColor = False
        '
        'TlpHeadSplit
        '
        Me.TlpHeadSplit.BackColor = System.Drawing.Color.Transparent
        Me.TlpHeadSplit.ColumnCount = 1
        Me.TlpHeadSplit.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpHeadSplit.Controls.Add(Me.PanHeadSplit, 0, 0)
        Me.TlpHeadSplit.Dock = System.Windows.Forms.DockStyle.Right
        Me.TlpHeadSplit.Location = New System.Drawing.Point(807, 0)
        Me.TlpHeadSplit.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpHeadSplit.Name = "TlpHeadSplit"
        Me.TlpHeadSplit.RowCount = 1
        Me.TlpHeadSplit.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpHeadSplit.Size = New System.Drawing.Size(16, 50)
        Me.TlpHeadSplit.TabIndex = 10
        '
        'PanHeadSplit
        '
        Me.PanHeadSplit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanHeadSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.PanHeadSplit.Location = New System.Drawing.Point(7, 8)
        Me.PanHeadSplit.Margin = New System.Windows.Forms.Padding(0)
        Me.PanHeadSplit.Name = "PanHeadSplit"
        Me.PanHeadSplit.Size = New System.Drawing.Size(2, 34)
        Me.PanHeadSplit.TabIndex = 0
        '
        'CmdMinimize
        '
        Me.CmdMinimize.BackColor = System.Drawing.Color.Transparent
        Me.CmdMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.CmdMinimize.FlatAppearance.BorderSize = 0
        Me.CmdMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.CmdMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.CmdMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdMinimize.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdMinimize.ForeColor = System.Drawing.Color.White
        Me.CmdMinimize.Location = New System.Drawing.Point(823, 0)
        Me.CmdMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdMinimize.Name = "CmdMinimize"
        Me.CmdMinimize.Padding = New System.Windows.Forms.Padding(2, 0, 0, 1)
        Me.CmdMinimize.Size = New System.Drawing.Size(50, 50)
        Me.CmdMinimize.TabIndex = 0
        Me.CmdMinimize.TabStop = False
        Me.CmdMinimize.Text = "—"
        Me.CmdMinimize.UseVisualStyleBackColor = False
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Transparent
        Me.CmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.CmdClose.FlatAppearance.BorderSize = 0
        Me.CmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(873, 0)
        Me.CmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 1)
        Me.CmdClose.Size = New System.Drawing.Size(50, 50)
        Me.CmdClose.TabIndex = 0
        Me.CmdClose.TabStop = False
        Me.CmdClose.Text = "✕"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'TlpHeadImage
        '
        Me.TlpHeadImage.BackColor = System.Drawing.Color.Transparent
        Me.TlpHeadImage.ColumnCount = 1
        Me.TlpHeadImage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        Me.TlpHeadImage.Controls.Add(Me.icnMain, 0, 0)
        Me.TlpHeadImage.Dock = System.Windows.Forms.DockStyle.Left
        Me.TlpHeadImage.Location = New System.Drawing.Point(0, 0)
        Me.TlpHeadImage.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpHeadImage.Name = "TlpHeadImage"
        Me.TlpHeadImage.RowCount = 1
        Me.TlpHeadImage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpHeadImage.Size = New System.Drawing.Size(166, 50)
        Me.TlpHeadImage.TabIndex = 8
        '
        'lblAppVersion
        '
        Me.lblAppVersion.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAppVersion.AutoSize = True
        Me.lblAppVersion.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.lblAppVersion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAppVersion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppVersion.ForeColor = System.Drawing.Color.White
        Me.lblAppVersion.Location = New System.Drawing.Point(891, 10)
        Me.lblAppVersion.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.lblAppVersion.Name = "lblAppVersion"
        Me.lblAppVersion.Size = New System.Drawing.Size(21, 20)
        Me.lblAppVersion.TabIndex = 8
        Me.lblAppVersion.Text = "..."
        Me.lblAppVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLastAssessed
        '
        Me.lblLastAssessed.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblLastAssessed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLastAssessed.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastAssessed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblLastAssessed.Location = New System.Drawing.Point(0, 38)
        Me.lblLastAssessed.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblLastAssessed.Name = "lblLastAssessed"
        Me.lblLastAssessed.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.lblLastAssessed.Size = New System.Drawing.Size(190, 37)
        Me.lblLastAssessed.TabIndex = 67
        Me.lblLastAssessed.Text = "Last Assessment"
        Me.lblLastAssessed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLastAssessedString
        '
        Me.lblLastAssessedString.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblLastAssessedString.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLastAssessedString.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastAssessedString.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.lblLastAssessedString.Location = New System.Drawing.Point(191, 38)
        Me.lblLastAssessedString.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblLastAssessedString.Name = "lblLastAssessedString"
        Me.lblLastAssessedString.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblLastAssessedString.Size = New System.Drawing.Size(408, 37)
        Me.lblLastAssessedString.TabIndex = 70
        Me.lblLastAssessedString.Text = "..."
        Me.lblLastAssessedString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWinVerString
        '
        Me.lblWinVerString.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblWinVerString.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWinVerString.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinVerString.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.lblWinVerString.Location = New System.Drawing.Point(191, 76)
        Me.lblWinVerString.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblWinVerString.Name = "lblWinVerString"
        Me.lblWinVerString.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblWinVerString.Size = New System.Drawing.Size(408, 37)
        Me.lblWinVerString.TabIndex = 71
        Me.lblWinVerString.Text = "..."
        Me.lblWinVerString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWinVer
        '
        Me.lblWinVer.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblWinVer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblWinVer.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinVer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblWinVer.Location = New System.Drawing.Point(0, 76)
        Me.lblWinVer.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblWinVer.Name = "lblWinVer"
        Me.lblWinVer.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.lblWinVer.Size = New System.Drawing.Size(190, 37)
        Me.lblWinVer.TabIndex = 67
        Me.lblWinVer.Text = "Operating System"
        Me.lblWinVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblValidityString
        '
        Me.lblValidityString.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblValidityString.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblValidityString.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidityString.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.lblValidityString.Location = New System.Drawing.Point(191, 0)
        Me.lblValidityString.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblValidityString.Name = "lblValidityString"
        Me.lblValidityString.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblValidityString.Size = New System.Drawing.Size(408, 37)
        Me.lblValidityString.TabIndex = 78
        Me.lblValidityString.Text = "..."
        Me.lblValidityString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdTools
        '
        Me.CmdTools.BackColor = System.Drawing.Color.Transparent
        Me.CmdTools.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdTools.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdTools.FlatAppearance.BorderSize = 0
        Me.CmdTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CmdTools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CmdTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdTools.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdTools.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdTools.Location = New System.Drawing.Point(152, 0)
        Me.CmdTools.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdTools.Name = "CmdTools"
        Me.CmdTools.Size = New System.Drawing.Size(76, 40)
        Me.CmdTools.TabIndex = 2
        Me.CmdTools.Text = "Tools"
        Me.CmdTools.UseVisualStyleBackColor = False
        '
        'CmdExport
        '
        Me.CmdExport.BackColor = System.Drawing.Color.Transparent
        Me.CmdExport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdExport.FlatAppearance.BorderSize = 0
        Me.CmdExport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CmdExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CmdExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdExport.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdExport.Location = New System.Drawing.Point(0, 0)
        Me.CmdExport.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdExport.Name = "CmdExport"
        Me.CmdExport.Size = New System.Drawing.Size(76, 40)
        Me.CmdExport.TabIndex = 0
        Me.CmdExport.Text = "Export"
        Me.CmdExport.UseVisualStyleBackColor = False
        '
        'CmdOptions
        '
        Me.CmdOptions.BackColor = System.Drawing.Color.Transparent
        Me.CmdOptions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdOptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdOptions.FlatAppearance.BorderSize = 0
        Me.CmdOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CmdOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CmdOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdOptions.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdOptions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdOptions.Location = New System.Drawing.Point(76, 0)
        Me.CmdOptions.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdOptions.Name = "CmdOptions"
        Me.CmdOptions.Size = New System.Drawing.Size(76, 40)
        Me.CmdOptions.TabIndex = 1
        Me.CmdOptions.Text = "Options"
        Me.CmdOptions.UseVisualStyleBackColor = False
        '
        'CmdHelp
        '
        Me.CmdHelp.BackColor = System.Drawing.Color.Transparent
        Me.CmdHelp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.CmdHelp.FlatAppearance.BorderSize = 0
        Me.CmdHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CmdHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.CmdHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdHelp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CmdHelp.Location = New System.Drawing.Point(228, 0)
        Me.CmdHelp.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdHelp.Name = "CmdHelp"
        Me.CmdHelp.Size = New System.Drawing.Size(76, 40)
        Me.CmdHelp.TabIndex = 3
        Me.CmdHelp.Text = "Help"
        Me.CmdHelp.UseVisualStyleBackColor = False
        '
        'PanCapture
        '
        Me.PanCapture.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanCapture.Controls.Add(Me.PanSplit)
        Me.PanCapture.Controls.Add(Me.TlpTop)
        Me.PanCapture.Controls.Add(Me.TlpGridScore)
        Me.PanCapture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanCapture.Location = New System.Drawing.Point(1, 91)
        Me.PanCapture.Margin = New System.Windows.Forms.Padding(2)
        Me.PanCapture.Name = "PanCapture"
        Me.PanCapture.Size = New System.Drawing.Size(923, 311)
        Me.PanCapture.TabIndex = 86
        '
        'PanSplit
        '
        Me.PanSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanSplit.ForeColor = System.Drawing.Color.Black
        Me.PanSplit.Location = New System.Drawing.Point(0, 0)
        Me.PanSplit.Margin = New System.Windows.Forms.Padding(4)
        Me.PanSplit.Name = "PanSplit"
        Me.PanSplit.Size = New System.Drawing.Size(923, 2)
        Me.PanSplit.TabIndex = 88
        '
        'TlpTop
        '
        Me.TlpTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.TlpTop.ColumnCount = 2
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.36323!))
        Me.TlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.63677!))
        Me.TlpTop.Controls.Add(Me.lblScale, 0, 0)
        Me.TlpTop.Controls.Add(Me.CmdAssess, 1, 0)
        Me.TlpTop.Location = New System.Drawing.Point(16, 19)
        Me.TlpTop.Margin = New System.Windows.Forms.Padding(2)
        Me.TlpTop.Name = "TlpTop"
        Me.TlpTop.RowCount = 1
        Me.TlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpTop.Size = New System.Drawing.Size(891, 38)
        Me.TlpTop.TabIndex = 87
        '
        'CmdAssess
        '
        Me.CmdAssess.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdAssess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdAssess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.CmdAssess.FlatAppearance.BorderSize = 0
        Me.CmdAssess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdAssess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdAssess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAssess.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAssess.ForeColor = System.Drawing.Color.White
        Me.CmdAssess.Location = New System.Drawing.Point(698, 0)
        Me.CmdAssess.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdAssess.Name = "CmdAssess"
        Me.CmdAssess.Size = New System.Drawing.Size(193, 38)
        Me.CmdAssess.TabIndex = 6
        Me.CmdAssess.Text = "..."
        Me.CmdAssess.UseVisualStyleBackColor = False
        '
        'TlpGridScore
        '
        Me.TlpGridScore.ColumnCount = 1
        Me.TlpGridScore.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 891.0!))
        Me.TlpGridScore.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TlpGridScore.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TlpGridScore.Location = New System.Drawing.Point(16, 71)
        Me.TlpGridScore.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpGridScore.Name = "TlpGridScore"
        Me.TlpGridScore.RowCount = 2
        Me.TlpGridScore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpGridScore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.TlpGridScore.Size = New System.Drawing.Size(891, 228)
        Me.TlpGridScore.TabIndex = 86
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 4
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 410.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TlpComponent, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TlpRated, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TlpSubscore, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TlpScore, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 38)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(891, 190)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TlpComponent
        '
        Me.TlpComponent.ColumnCount = 1
        Me.TlpComponent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
        Me.TlpComponent.Controls.Add(Me.lblProcessor, 0, 0)
        Me.TlpComponent.Controls.Add(Me.lblMemory, 0, 1)
        Me.TlpComponent.Controls.Add(Me.lblGraphics, 0, 2)
        Me.TlpComponent.Controls.Add(Me.lblDisk, 0, 4)
        Me.TlpComponent.Controls.Add(Me.lblGaming, 0, 3)
        Me.TlpComponent.Dock = System.Windows.Forms.DockStyle.Left
        Me.TlpComponent.Location = New System.Drawing.Point(0, 0)
        Me.TlpComponent.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpComponent.Name = "TlpComponent"
        Me.TlpComponent.RowCount = 5
        Me.TlpComponent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpComponent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpComponent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpComponent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpComponent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpComponent.Size = New System.Drawing.Size(190, 190)
        Me.TlpComponent.TabIndex = 0
        '
        'TlpRated
        '
        Me.TlpRated.ColumnCount = 1
        Me.TlpRated.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpRated.Controls.Add(Me.lblProcessorR, 0, 0)
        Me.TlpRated.Controls.Add(Me.lblMemoryR, 0, 1)
        Me.TlpRated.Controls.Add(Me.lblGraphicsR, 0, 2)
        Me.TlpRated.Controls.Add(Me.lblDiskR, 0, 4)
        Me.TlpRated.Controls.Add(Me.lblGamingR, 0, 3)
        Me.TlpRated.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpRated.Location = New System.Drawing.Point(190, 0)
        Me.TlpRated.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpRated.Name = "TlpRated"
        Me.TlpRated.RowCount = 5
        Me.TlpRated.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpRated.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpRated.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpRated.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpRated.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpRated.Size = New System.Drawing.Size(410, 190)
        Me.TlpRated.TabIndex = 1
        '
        'TlpSubscore
        '
        Me.TlpSubscore.ColumnCount = 1
        Me.TlpSubscore.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpSubscore.Controls.Add(Me.lblDiskScore, 0, 4)
        Me.TlpSubscore.Controls.Add(Me.lblProcessorScore, 0, 0)
        Me.TlpSubscore.Controls.Add(Me.lblMemoryScore, 0, 1)
        Me.TlpSubscore.Controls.Add(Me.lblGamingScore, 0, 3)
        Me.TlpSubscore.Controls.Add(Me.lblGraphicsScore, 0, 2)
        Me.TlpSubscore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpSubscore.Location = New System.Drawing.Point(600, 0)
        Me.TlpSubscore.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpSubscore.Name = "TlpSubscore"
        Me.TlpSubscore.RowCount = 5
        Me.TlpSubscore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpSubscore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpSubscore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpSubscore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpSubscore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpSubscore.Size = New System.Drawing.Size(100, 190)
        Me.TlpSubscore.TabIndex = 70
        '
        'TlpScore
        '
        Me.TlpScore.ColumnCount = 1
        Me.TlpScore.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpScore.Controls.Add(Me.PanBasescore, 0, 0)
        Me.TlpScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TlpScore.Location = New System.Drawing.Point(700, 0)
        Me.TlpScore.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpScore.Name = "TlpScore"
        Me.TlpScore.RowCount = 1
        Me.TlpScore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpScore.Size = New System.Drawing.Size(192, 190)
        Me.TlpScore.TabIndex = 71
        '
        'PanBasescore
        '
        Me.PanBasescore.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.PanBasescore.Controls.Add(Me.lblBasescore)
        Me.PanBasescore.Controls.Add(Me.lblLowestSub)
        Me.PanBasescore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanBasescore.Location = New System.Drawing.Point(0, 0)
        Me.PanBasescore.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PanBasescore.Name = "PanBasescore"
        Me.PanBasescore.Size = New System.Drawing.Size(192, 189)
        Me.PanBasescore.TabIndex = 71
        '
        'lblBasescore
        '
        Me.lblBasescore.BackColor = System.Drawing.Color.Transparent
        Me.lblBasescore.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblBasescore.Font = New System.Drawing.Font("Segoe UI", 34.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBasescore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBasescore.Location = New System.Drawing.Point(0, 0)
        Me.lblBasescore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBasescore.Name = "lblBasescore"
        Me.lblBasescore.Size = New System.Drawing.Size(192, 110)
        Me.lblBasescore.TabIndex = 23
        Me.lblBasescore.Text = "..."
        Me.lblBasescore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLowestSub
        '
        Me.lblLowestSub.BackColor = System.Drawing.Color.Transparent
        Me.lblLowestSub.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblLowestSub.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowestSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblLowestSub.Location = New System.Drawing.Point(0, 127)
        Me.lblLowestSub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 1)
        Me.lblLowestSub.Name = "lblLowestSub"
        Me.lblLowestSub.Size = New System.Drawing.Size(192, 62)
        Me.lblLowestSub.TabIndex = 22
        Me.lblLowestSub.Text = "Based on the lowest" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "subscore"
        Me.lblLowestSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 410.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblBase, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblComponent, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblSub, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblRated, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(891, 37)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'PanBottom
        '
        Me.PanBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.PanBottom.Controls.Add(Me.PanSplitCenter)
        Me.PanBottom.Controls.Add(Me.TlpBottom)
        Me.PanBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanBottom.Location = New System.Drawing.Point(1, 402)
        Me.PanBottom.Margin = New System.Windows.Forms.Padding(2)
        Me.PanBottom.Name = "PanBottom"
        Me.PanBottom.Size = New System.Drawing.Size(923, 162)
        Me.PanBottom.TabIndex = 87
        '
        'PanSplitCenter
        '
        Me.PanSplitCenter.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanSplitCenter.Location = New System.Drawing.Point(16, 10)
        Me.PanSplitCenter.Margin = New System.Windows.Forms.Padding(2)
        Me.PanSplitCenter.Name = "PanSplitCenter"
        Me.PanSplitCenter.Size = New System.Drawing.Size(891, 1)
        Me.PanSplitCenter.TabIndex = 81
        '
        'TlpBottom
        '
        Me.TlpBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TlpBottom.ColumnCount = 4
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191.0!))
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 409.0!))
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185.0!))
        Me.TlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpBottom.Controls.Add(Me.PanShowHardware2, 3, 0)
        Me.TlpBottom.Controls.Add(Me.CmdRunInDepth, 3, 2)
        Me.TlpBottom.Controls.Add(Me.PanValidity, 0, 0)
        Me.TlpBottom.Controls.Add(Me.lblAssessmentDepth, 2, 2)
        Me.TlpBottom.Controls.Add(Me.cmdMetrics, 3, 1)
        Me.TlpBottom.Controls.Add(Me.lblLastAssessed, 0, 1)
        Me.TlpBottom.Controls.Add(Me.lblShowMetrics, 2, 1)
        Me.TlpBottom.Controls.Add(Me.lblWinVer, 0, 2)
        Me.TlpBottom.Controls.Add(Me.lblValidityString, 1, 0)
        Me.TlpBottom.Controls.Add(Me.lblShowHardware, 2, 0)
        Me.TlpBottom.Controls.Add(Me.lblLastAssessedString, 1, 1)
        Me.TlpBottom.Controls.Add(Me.lblWinVerString, 1, 2)
        Me.TlpBottom.Location = New System.Drawing.Point(16, 32)
        Me.TlpBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpBottom.Name = "TlpBottom"
        Me.TlpBottom.RowCount = 3
        Me.TlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpBottom.Size = New System.Drawing.Size(891, 114)
        Me.TlpBottom.TabIndex = 80
        '
        'PanShowHardware2
        '
        Me.PanShowHardware2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanShowHardware2.Controls.Add(Me.TableLayoutPanel1)
        Me.PanShowHardware2.Controls.Add(Me.lblShowHToggle)
        Me.PanShowHardware2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanShowHardware2.Location = New System.Drawing.Point(785, 0)
        Me.PanShowHardware2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.PanShowHardware2.Name = "PanShowHardware2"
        Me.PanShowHardware2.Size = New System.Drawing.Size(106, 37)
        Me.PanShowHardware2.TabIndex = 75
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.swHardware, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(56, 37)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'swHardware
        '
        Me.swHardware.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.swHardware.BackColor = System.Drawing.Color.Black
        Me.swHardware.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.swHardware.BorderColorActive = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.swHardware.CheckedColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.swHardware.ClientColorActive = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.swHardware.Location = New System.Drawing.Point(9, 8)
        Me.swHardware.Margin = New System.Windows.Forms.Padding(4)
        Me.swHardware.Name = "swHardware"
        Me.swHardware.Size = New System.Drawing.Size(38, 21)
        Me.swHardware.SwitchHeadColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.swHardware.TabIndex = 1
        '
        'lblShowHToggle
        '
        Me.lblShowHToggle.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.lblShowHToggle.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblShowHToggle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowHToggle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.lblShowHToggle.Location = New System.Drawing.Point(56, 0)
        Me.lblShowHToggle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblShowHToggle.Name = "lblShowHToggle"
        Me.lblShowHToggle.Size = New System.Drawing.Size(50, 37)
        Me.lblShowHToggle.TabIndex = 0
        Me.lblShowHToggle.Text = "..."
        Me.lblShowHToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmdRunInDepth
        '
        Me.CmdRunInDepth.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.CmdRunInDepth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CmdRunInDepth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.CmdRunInDepth.FlatAppearance.BorderSize = 0
        Me.CmdRunInDepth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdRunInDepth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.CmdRunInDepth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdRunInDepth.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdRunInDepth.ForeColor = System.Drawing.Color.White
        Me.CmdRunInDepth.Location = New System.Drawing.Point(785, 76)
        Me.CmdRunInDepth.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.CmdRunInDepth.Name = "CmdRunInDepth"
        Me.CmdRunInDepth.Size = New System.Drawing.Size(106, 37)
        Me.CmdRunInDepth.TabIndex = 6
        Me.CmdRunInDepth.Text = "Run"
        Me.CmdRunInDepth.UseVisualStyleBackColor = False
        '
        'PanValidity
        '
        Me.PanValidity.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.PanValidity.Controls.Add(Me.PanValidityState)
        Me.PanValidity.Controls.Add(Me.lblValidity)
        Me.PanValidity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanValidity.Location = New System.Drawing.Point(0, 0)
        Me.PanValidity.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.PanValidity.Name = "PanValidity"
        Me.PanValidity.Padding = New System.Windows.Forms.Padding(1)
        Me.PanValidity.Size = New System.Drawing.Size(190, 37)
        Me.PanValidity.TabIndex = 73
        '
        'PanValidityState
        '
        Me.PanValidityState.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanValidityState.Location = New System.Drawing.Point(187, 1)
        Me.PanValidityState.Margin = New System.Windows.Forms.Padding(2)
        Me.PanValidityState.Name = "PanValidityState"
        Me.PanValidityState.Size = New System.Drawing.Size(2, 35)
        Me.PanValidityState.TabIndex = 68
        '
        'lblValidity
        '
        Me.lblValidity.BackColor = System.Drawing.Color.Transparent
        Me.lblValidity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblValidity.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblValidity.Location = New System.Drawing.Point(1, 1)
        Me.lblValidity.Margin = New System.Windows.Forms.Padding(0)
        Me.lblValidity.Name = "lblValidity"
        Me.lblValidity.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.lblValidity.Size = New System.Drawing.Size(188, 35)
        Me.lblValidity.TabIndex = 67
        Me.lblValidity.Text = "Score Validity"
        Me.lblValidity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAssessmentDepth
        '
        Me.lblAssessmentDepth.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblAssessmentDepth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAssessmentDepth.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssessmentDepth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblAssessmentDepth.Location = New System.Drawing.Point(600, 76)
        Me.lblAssessmentDepth.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblAssessmentDepth.Name = "lblAssessmentDepth"
        Me.lblAssessmentDepth.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.lblAssessmentDepth.Size = New System.Drawing.Size(184, 37)
        Me.lblAssessmentDepth.TabIndex = 67
        Me.lblAssessmentDepth.Text = "In-depth Assessment"
        Me.lblAssessmentDepth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdMetrics
        '
        Me.cmdMetrics.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.cmdMetrics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdMetrics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdMetrics.FlatAppearance.BorderSize = 0
        Me.cmdMetrics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdMetrics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdMetrics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMetrics.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMetrics.ForeColor = System.Drawing.Color.White
        Me.cmdMetrics.Location = New System.Drawing.Point(785, 38)
        Me.cmdMetrics.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.cmdMetrics.Name = "cmdMetrics"
        Me.cmdMetrics.Size = New System.Drawing.Size(106, 37)
        Me.cmdMetrics.TabIndex = 5
        Me.cmdMetrics.Text = "View"
        Me.cmdMetrics.UseVisualStyleBackColor = False
        '
        'lblShowMetrics
        '
        Me.lblShowMetrics.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblShowMetrics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblShowMetrics.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowMetrics.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblShowMetrics.Location = New System.Drawing.Point(600, 38)
        Me.lblShowMetrics.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblShowMetrics.Name = "lblShowMetrics"
        Me.lblShowMetrics.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.lblShowMetrics.Size = New System.Drawing.Size(184, 37)
        Me.lblShowMetrics.TabIndex = 67
        Me.lblShowMetrics.Text = "Score Metrics"
        Me.lblShowMetrics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblShowHardware
        '
        Me.lblShowHardware.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblShowHardware.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblShowHardware.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowHardware.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblShowHardware.Location = New System.Drawing.Point(600, 0)
        Me.lblShowHardware.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblShowHardware.Name = "lblShowHardware"
        Me.lblShowHardware.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.lblShowHardware.Size = New System.Drawing.Size(184, 37)
        Me.lblShowHardware.TabIndex = 67
        Me.lblShowHardware.Text = "Show Hardware"
        Me.lblShowHardware.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BMPToolStripMenuItem
        '
        Me.BMPToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BMPToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.BMPToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BMPToolStripMenuItem.Name = "BMPToolStripMenuItem"
        Me.BMPToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.BMPToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BMPToolStripMenuItem.Size = New System.Drawing.Size(324, 28)
        Me.BMPToolStripMenuItem.Text = "Save Scores as BMP (High)"
        '
        'JPGToolStripMenuItem
        '
        Me.JPGToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.JPGToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.JPGToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.JPGToolStripMenuItem.Name = "JPGToolStripMenuItem"
        Me.JPGToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.JPGToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.JPGToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.JPGToolStripMenuItem.Size = New System.Drawing.Size(324, 28)
        Me.JPGToolStripMenuItem.Text = "Save Scores as JPG (Low)"
        '
        'PNGToolStripMenuItem
        '
        Me.PNGToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PNGToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PNGToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PNGToolStripMenuItem.Name = "PNGToolStripMenuItem"
        Me.PNGToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.PNGToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PNGToolStripMenuItem.Size = New System.Drawing.Size(324, 28)
        Me.PNGToolStripMenuItem.Text = "Save Scores as PNG (Med)"
        '
        'TXTToolStripMenuItem
        '
        Me.TXTToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TXTToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TXTToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTToolStripMenuItem.Name = "TXTToolStripMenuItem"
        Me.TXTToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.TXTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TXTToolStripMenuItem.Size = New System.Drawing.Size(324, 28)
        Me.TXTToolStripMenuItem.Text = "Save Scores to a Text File"
        '
        'CmsExport
        '
        Me.CmsExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CmsExport.DropShadowEnabled = False
        Me.CmsExport.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmsExport.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JPGToolStripMenuItem, Me.PNGToolStripMenuItem, Me.BMPToolStripMenuItem, Me.ToolStripSeparator4, Me.TXTToolStripMenuItem, Me.ToolStripSeparator1, Me.ImgurToolStripMenuItem})
        Me.CmsExport.Name = "ContextMenuStrip1"
        Me.CmsExport.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.CmsExport.ShowImageMargin = False
        Me.CmsExport.Size = New System.Drawing.Size(325, 156)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(321, 6)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(321, 6)
        '
        'ImgurToolStripMenuItem
        '
        Me.ImgurToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ImgurToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ImgurToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ImgurToolStripMenuItem.Name = "ImgurToolStripMenuItem"
        Me.ImgurToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ImgurToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ImgurToolStripMenuItem.Size = New System.Drawing.Size(324, 28)
        Me.ImgurToolStripMenuItem.Text = "Upload Screenshot to Imgur"
        '
        'CmsOptions
        '
        Me.CmsOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CmsOptions.DropShadowEnabled = False
        Me.CmsOptions.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmsOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewImgurLinksToolStripMenuItem, Me.ViewLogToolStripMenuItem, Me.ViewWinSATLogToolStripMenuItem, Me.ToolStripSeparator5, Me.RefreshScoresToolStripMenuItem, Me.ToolStripSeparator2, Me.CreateCompatibilityiniToolStripMenuItem, Me.CreateSettingsiniToolStripMenuItem, Me.SaveResourcesToDiskToolStripMenuItem, Me.ToolStripSeparator7, Me.SettingsToolstripMenuItem})
        Me.CmsOptions.Name = "ContextMenuStrip1"
        Me.CmsOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.CmsOptions.ShowImageMargin = False
        Me.CmsOptions.Size = New System.Drawing.Size(326, 246)
        '
        'ViewImgurLinksToolStripMenuItem
        '
        Me.ViewImgurLinksToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ViewImgurLinksToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ViewImgurLinksToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ViewImgurLinksToolStripMenuItem.Name = "ViewImgurLinksToolStripMenuItem"
        Me.ViewImgurLinksToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ViewImgurLinksToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ViewImgurLinksToolStripMenuItem.Size = New System.Drawing.Size(325, 28)
        Me.ViewImgurLinksToolStripMenuItem.Text = "View Imgur Links"
        '
        'ViewLogToolStripMenuItem
        '
        Me.ViewLogToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ViewLogToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ViewLogToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ViewLogToolStripMenuItem.Name = "ViewLogToolStripMenuItem"
        Me.ViewLogToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ViewLogToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ViewLogToolStripMenuItem.Size = New System.Drawing.Size(325, 28)
        Me.ViewLogToolStripMenuItem.Text = "View Assessment Log"
        '
        'ViewWinSATLogToolStripMenuItem
        '
        Me.ViewWinSATLogToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ViewWinSATLogToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ViewWinSATLogToolStripMenuItem.Name = "ViewWinSATLogToolStripMenuItem"
        Me.ViewWinSATLogToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ViewWinSATLogToolStripMenuItem.Size = New System.Drawing.Size(325, 28)
        Me.ViewWinSATLogToolStripMenuItem.Text = "View Winsat Log"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(322, 6)
        '
        'RefreshScoresToolStripMenuItem
        '
        Me.RefreshScoresToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RefreshScoresToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.RefreshScoresToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RefreshScoresToolStripMenuItem.Name = "RefreshScoresToolStripMenuItem"
        Me.RefreshScoresToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.RefreshScoresToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RefreshScoresToolStripMenuItem.Size = New System.Drawing.Size(325, 28)
        Me.RefreshScoresToolStripMenuItem.Text = "Refresh Scores"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(322, 6)
        '
        'CreateCompatibilityiniToolStripMenuItem
        '
        Me.CreateCompatibilityiniToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.CreateCompatibilityiniToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CreateCompatibilityiniToolStripMenuItem.Name = "CreateCompatibilityiniToolStripMenuItem"
        Me.CreateCompatibilityiniToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CreateCompatibilityiniToolStripMenuItem.Size = New System.Drawing.Size(325, 28)
        Me.CreateCompatibilityiniToolStripMenuItem.Text = "Create Compatibility.ini"
        '
        'CreateSettingsiniToolStripMenuItem
        '
        Me.CreateSettingsiniToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.CreateSettingsiniToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CreateSettingsiniToolStripMenuItem.Name = "CreateSettingsiniToolStripMenuItem"
        Me.CreateSettingsiniToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.CreateSettingsiniToolStripMenuItem.Size = New System.Drawing.Size(325, 28)
        Me.CreateSettingsiniToolStripMenuItem.Text = "Create Settings.ini"
        '
        'SaveResourcesToDiskToolStripMenuItem
        '
        Me.SaveResourcesToDiskToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SaveResourcesToDiskToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveResourcesToDiskToolStripMenuItem.Name = "SaveResourcesToDiskToolStripMenuItem"
        Me.SaveResourcesToDiskToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.SaveResourcesToDiskToolStripMenuItem.Size = New System.Drawing.Size(325, 28)
        Me.SaveResourcesToDiskToolStripMenuItem.Text = "Save Resources to Disk"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(322, 6)
        '
        'SettingsToolstripMenuItem
        '
        Me.SettingsToolstripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SettingsToolstripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SettingsToolstripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SettingsToolstripMenuItem.Name = "SettingsToolstripMenuItem"
        Me.SettingsToolstripMenuItem.ShortcutKeyDisplayString = ""
        Me.SettingsToolstripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SettingsToolstripMenuItem.Size = New System.Drawing.Size(325, 28)
        Me.SettingsToolstripMenuItem.Text = "Settings"
        '
        'CmsTools
        '
        Me.CmsTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.CmsTools.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CmsTools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ViewSystemDetailsToolStripMenuItem, Me.ToolStripSeparator6, Me.RunToolStripMenuItem, Me.RunVerboseToolStripMenuItem})
        Me.CmsTools.Name = "ContextMenuStrip1"
        Me.CmsTools.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.CmsTools.ShowImageMargin = False
        Me.CmsTools.Size = New System.Drawing.Size(304, 122)
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ResetToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ResetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(303, 28)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'ViewSystemDetailsToolStripMenuItem
        '
        Me.ViewSystemDetailsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewSystemDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ViewSystemDetailsToolStripMenuItem.Name = "ViewSystemDetailsToolStripMenuItem"
        Me.ViewSystemDetailsToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ViewSystemDetailsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ViewSystemDetailsToolStripMenuItem.Size = New System.Drawing.Size(303, 28)
        Me.ViewSystemDetailsToolStripMenuItem.Text = "View System Details"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(300, 6)
        '
        'RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RunToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.RunToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(303, 28)
        Me.RunToolStripMenuItem.Text = "Run Normal Assessment"
        '
        'RunVerboseToolStripMenuItem
        '
        Me.RunVerboseToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.RunVerboseToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunVerboseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RunVerboseToolStripMenuItem.Name = "RunVerboseToolStripMenuItem"
        Me.RunVerboseToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.RunVerboseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.RunVerboseToolStripMenuItem.Size = New System.Drawing.Size(303, 28)
        Me.RunVerboseToolStripMenuItem.Text = "Run In-depth Assessment"
        '
        'cmsHelp
        '
        Me.cmsHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmsHelp.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsHelp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MediaFeaturePackToolStripMenuItem, Me.TroubleshootingToolStripMenuItem, Me.ToolStripSeparator3, Me.HotfixAvailableToolStripMenuItem, Me.UpdateAvailableToolStripMenuItem, Me.ChangelogToolStripMenuItem, Me.ToolStripSeparator10, Me.AboutToolStripMenuItem, Me.AcknowledgementsToolStripMenuItem, Me.BMACToolstripMenuItem, Me.LicenseToolStripMenuItem})
        Me.cmsHelp.Name = "cmsHelp"
        Me.cmsHelp.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.cmsHelp.ShowImageMargin = False
        Me.cmsHelp.Size = New System.Drawing.Size(267, 268)
        '
        'MediaFeaturePackToolStripMenuItem
        '
        Me.MediaFeaturePackToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MediaFeaturePackToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MediaFeaturePackToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MediaFeaturePackToolStripMenuItem.Name = "MediaFeaturePackToolStripMenuItem"
        Me.MediaFeaturePackToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.MediaFeaturePackToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MediaFeaturePackToolStripMenuItem.Size = New System.Drawing.Size(266, 28)
        Me.MediaFeaturePackToolStripMenuItem.Text = "Media Feature Pack"
        '
        'TroubleshootingToolStripMenuItem
        '
        Me.TroubleshootingToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TroubleshootingToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TroubleshootingToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TroubleshootingToolStripMenuItem.Name = "TroubleshootingToolStripMenuItem"
        Me.TroubleshootingToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.TroubleshootingToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TroubleshootingToolStripMenuItem.Size = New System.Drawing.Size(266, 28)
        Me.TroubleshootingToolStripMenuItem.Text = "Troubleshooting"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(263, 6)
        '
        'HotfixAvailableToolStripMenuItem
        '
        Me.HotfixAvailableToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HotfixAvailableToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HotfixAvailableToolStripMenuItem.Name = "HotfixAvailableToolStripMenuItem"
        Me.HotfixAvailableToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HotfixAvailableToolStripMenuItem.Size = New System.Drawing.Size(266, 28)
        Me.HotfixAvailableToolStripMenuItem.Text = "Hotfix Available"
        '
        'UpdateAvailableToolStripMenuItem
        '
        Me.UpdateAvailableToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.UpdateAvailableToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateAvailableToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UpdateAvailableToolStripMenuItem.Name = "UpdateAvailableToolStripMenuItem"
        Me.UpdateAvailableToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.UpdateAvailableToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UpdateAvailableToolStripMenuItem.Size = New System.Drawing.Size(266, 28)
        Me.UpdateAvailableToolStripMenuItem.Text = "Check for Update"
        '
        'ChangelogToolStripMenuItem
        '
        Me.ChangelogToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangelogToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChangelogToolStripMenuItem.Name = "ChangelogToolStripMenuItem"
        Me.ChangelogToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ChangelogToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ChangelogToolStripMenuItem.Size = New System.Drawing.Size(266, 28)
        Me.ChangelogToolStripMenuItem.Text = "Changelog"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(263, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(266, 28)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AcknowledgementsToolStripMenuItem
        '
        Me.AcknowledgementsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcknowledgementsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AcknowledgementsToolStripMenuItem.Name = "AcknowledgementsToolStripMenuItem"
        Me.AcknowledgementsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.AcknowledgementsToolStripMenuItem.Size = New System.Drawing.Size(266, 28)
        Me.AcknowledgementsToolStripMenuItem.Text = "Acknowledgements"
        '
        'BMACToolstripMenuItem
        '
        Me.BMACToolstripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BMACToolstripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMACToolstripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BMACToolstripMenuItem.Name = "BMACToolstripMenuItem"
        Me.BMACToolstripMenuItem.ShortcutKeyDisplayString = ""
        Me.BMACToolstripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.BMACToolstripMenuItem.Size = New System.Drawing.Size(266, 28)
        Me.BMACToolstripMenuItem.Text = "Buy me a Coffee"
        '
        'LicenseToolStripMenuItem
        '
        Me.LicenseToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.LicenseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LicenseToolStripMenuItem.Name = "LicenseToolStripMenuItem"
        Me.LicenseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.LicenseToolStripMenuItem.Size = New System.Drawing.Size(266, 28)
        Me.LicenseToolStripMenuItem.Text = "License"
        '
        'TlpMenu
        '
        Me.TlpMenu.BackColor = System.Drawing.Color.Transparent
        Me.TlpMenu.ColumnCount = 6
        Me.TlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TlpMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TlpMenu.Controls.Add(Me.CmdTools, 2, 0)
        Me.TlpMenu.Controls.Add(Me.CmdExport, 0, 0)
        Me.TlpMenu.Controls.Add(Me.CmdOptions, 1, 0)
        Me.TlpMenu.Controls.Add(Me.CmdHelp, 3, 0)
        Me.TlpMenu.Controls.Add(Me.lblAppVersion, 5, 0)
        Me.TlpMenu.Controls.Add(Me.cmdDebug, 4, 0)
        Me.TlpMenu.Location = New System.Drawing.Point(0, 50)
        Me.TlpMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpMenu.Name = "TlpMenu"
        Me.TlpMenu.RowCount = 1
        Me.TlpMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpMenu.Size = New System.Drawing.Size(922, 40)
        Me.TlpMenu.TabIndex = 88
        '
        'cmdDebug
        '
        Me.cmdDebug.BackColor = System.Drawing.Color.Transparent
        Me.cmdDebug.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdDebug.FlatAppearance.BorderSize = 0
        Me.cmdDebug.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.cmdDebug.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.cmdDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDebug.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDebug.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdDebug.Location = New System.Drawing.Point(304, 0)
        Me.cmdDebug.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdDebug.Name = "cmdDebug"
        Me.cmdDebug.Size = New System.Drawing.Size(76, 40)
        Me.cmdDebug.TabIndex = 9
        Me.cmdDebug.Text = "Debug"
        Me.cmdDebug.UseVisualStyleBackColor = False
        '
        'TlpMain
        '
        Me.TlpMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.TlpMain.ColumnCount = 1
        Me.TlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpMain.Controls.Add(Me.TlpMenu, 0, 1)
        Me.TlpMain.Controls.Add(Me.PanHead, 0, 0)
        Me.TlpMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.TlpMain.Location = New System.Drawing.Point(1, 1)
        Me.TlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.TlpMain.Name = "TlpMain"
        Me.TlpMain.RowCount = 2
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TlpMain.Size = New System.Drawing.Size(923, 90)
        Me.TlpMain.TabIndex = 89
        '
        'cmsDebug
        '
        Me.cmsDebug.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmsDebug.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsDebug.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThrowUnhandledExceptionToolStripMenuItem, Me.ToolStripSeparator11, Me.ShowToastInfoToolStripMenuItem, Me.ShowToastWarningToolStripMenuItem, Me.ShowToastErrorToolStripMenuItem, Me.ToolStripSeparator12, Me.OpenElevationWindowToolStripMenuItem})
        Me.cmsDebug.Name = "cmsDebug"
        Me.cmsDebug.ShowImageMargin = False
        Me.cmsDebug.Size = New System.Drawing.Size(270, 184)
        '
        'ThrowUnhandledExceptionToolStripMenuItem
        '
        Me.ThrowUnhandledExceptionToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThrowUnhandledExceptionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ThrowUnhandledExceptionToolStripMenuItem.Name = "ThrowUnhandledExceptionToolStripMenuItem"
        Me.ThrowUnhandledExceptionToolStripMenuItem.Size = New System.Drawing.Size(269, 28)
        Me.ThrowUnhandledExceptionToolStripMenuItem.Text = "Throw Unhandled Exception"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(266, 6)
        '
        'ShowToastInfoToolStripMenuItem
        '
        Me.ShowToastInfoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowToastInfoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowToastInfoToolStripMenuItem.Name = "ShowToastInfoToolStripMenuItem"
        Me.ShowToastInfoToolStripMenuItem.Size = New System.Drawing.Size(269, 28)
        Me.ShowToastInfoToolStripMenuItem.Text = "Show Toast (Info)"
        '
        'ShowToastWarningToolStripMenuItem
        '
        Me.ShowToastWarningToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowToastWarningToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowToastWarningToolStripMenuItem.Name = "ShowToastWarningToolStripMenuItem"
        Me.ShowToastWarningToolStripMenuItem.Size = New System.Drawing.Size(269, 28)
        Me.ShowToastWarningToolStripMenuItem.Text = "Show Toast (Warning)"
        '
        'ShowToastErrorToolStripMenuItem
        '
        Me.ShowToastErrorToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowToastErrorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowToastErrorToolStripMenuItem.Name = "ShowToastErrorToolStripMenuItem"
        Me.ShowToastErrorToolStripMenuItem.Size = New System.Drawing.Size(269, 28)
        Me.ShowToastErrorToolStripMenuItem.Text = "Show Toast (Error)"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(266, 6)
        '
        'OpenElevationWindowToolStripMenuItem
        '
        Me.OpenElevationWindowToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenElevationWindowToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OpenElevationWindowToolStripMenuItem.Name = "OpenElevationWindowToolStripMenuItem"
        Me.OpenElevationWindowToolStripMenuItem.Size = New System.Drawing.Size(269, 28)
        Me.OpenElevationWindowToolStripMenuItem.Text = "Open Elevation Window"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(925, 565)
        Me.Controls.Add(Me.PanCapture)
        Me.Controls.Add(Me.TlpMain)
        Me.Controls.Add(Me.PanBottom)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(925, 565)
        Me.MinimumSize = New System.Drawing.Size(925, 565)
        Me.Name = "FormMain"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WinXI - Experience Index Tool"
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsExplorer.ResumeLayout(False)
        Me.PanHead.ResumeLayout(False)
        Me.TlpHeadSplit.ResumeLayout(False)
        Me.TlpHeadImage.ResumeLayout(False)
        Me.PanCapture.ResumeLayout(False)
        Me.TlpTop.ResumeLayout(False)
        Me.TlpGridScore.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TlpComponent.ResumeLayout(False)
        Me.TlpRated.ResumeLayout(False)
        Me.TlpSubscore.ResumeLayout(False)
        Me.TlpScore.ResumeLayout(False)
        Me.PanBasescore.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.PanBottom.ResumeLayout(False)
        Me.TlpBottom.ResumeLayout(False)
        Me.PanShowHardware2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.PanValidity.ResumeLayout(False)
        Me.CmsExport.ResumeLayout(False)
        Me.CmsOptions.ResumeLayout(False)
        Me.CmsTools.ResumeLayout(False)
        Me.cmsHelp.ResumeLayout(False)
        Me.TlpMenu.ResumeLayout(False)
        Me.TlpMenu.PerformLayout()
        Me.TlpMain.ResumeLayout(False)
        Me.cmsDebug.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents icnMain As System.Windows.Forms.PictureBox
    Friend WithEvents lblHead As System.Windows.Forms.Label
    Friend WithEvents lblValidityString As System.Windows.Forms.Label
    Friend WithEvents lblWinVerString As System.Windows.Forms.Label
    Friend WithEvents lblBasescore As System.Windows.Forms.Label
    Friend WithEvents lblLowestSub As System.Windows.Forms.Label
    Friend WithEvents lblBase As System.Windows.Forms.Label
    Friend WithEvents lblSub As System.Windows.Forms.Label
    Friend WithEvents lblRated As System.Windows.Forms.Label
    Friend WithEvents lblComponent As System.Windows.Forms.Label
    Friend WithEvents lblLastAssessedString As System.Windows.Forms.Label
    Friend WithEvents PanHead As System.Windows.Forms.Panel
    Friend WithEvents lblWinVer As System.Windows.Forms.Label
    Friend WithEvents lblLastAssessed As System.Windows.Forms.Label
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents CmdMinimize As System.Windows.Forms.Button
    Friend WithEvents lblDiskScore As System.Windows.Forms.Label
    Friend WithEvents lblGamingScore As System.Windows.Forms.Label
    Friend WithEvents lblGraphicsScore As System.Windows.Forms.Label
    Friend WithEvents lblMemoryScore As System.Windows.Forms.Label
    Friend WithEvents lblProcessorScore As System.Windows.Forms.Label
    Friend WithEvents lblProcessor As System.Windows.Forms.Label
    Friend WithEvents lblDisk As System.Windows.Forms.Label
    Friend WithEvents lblGaming As System.Windows.Forms.Label
    Friend WithEvents lblGraphics As System.Windows.Forms.Label
    Friend WithEvents lblMemory As System.Windows.Forms.Label
    Friend WithEvents lblScale As System.Windows.Forms.Label
    Friend WithEvents CmdOptions As System.Windows.Forms.Button
    Friend WithEvents CmdHelp As System.Windows.Forms.Button
    Friend WithEvents CmdExport As System.Windows.Forms.Button
    Friend WithEvents PanCapture As System.Windows.Forms.Panel
    Friend WithEvents PanBottom As System.Windows.Forms.Panel
    Friend WithEvents CmdAssess As System.Windows.Forms.Button
    Friend WithEvents lblShowHardware As System.Windows.Forms.Label
    Friend WithEvents PanShowHardware2 As System.Windows.Forms.Panel
    Friend WithEvents lblProcessorR As System.Windows.Forms.Label
    Friend WithEvents lblDiskR As System.Windows.Forms.Label
    Friend WithEvents lblMemoryR As System.Windows.Forms.Label
    Friend WithEvents lblGraphicsR As System.Windows.Forms.Label
    Friend WithEvents lblGamingR As System.Windows.Forms.Label
    Friend WithEvents cmdMetrics As System.Windows.Forms.Button
    Friend WithEvents lblShowMetrics As System.Windows.Forms.Label
    Friend WithEvents BMPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JPGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PNGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TXTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CmsExport As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CmsOptions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SettingsToolstripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImgurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TlpBottom As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanValidity As System.Windows.Forms.Panel
    Friend WithEvents PanValidityState As System.Windows.Forms.Panel
    Friend WithEvents lblValidity As System.Windows.Forms.Label
    Friend WithEvents TlpGridScore As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TlpSubscore As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TlpHeadImage As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TlpTop As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PanBasescore As System.Windows.Forms.Panel
    Friend WithEvents ViewLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshScoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmdTools As System.Windows.Forms.Button
    Friend WithEvents CmsTools As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunVerboseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsHelp As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TroubleshootingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateAvailableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MediaFeaturePackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ViewImgurLinksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ViewSystemDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangelogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanSplitCenter As Panel
    Friend WithEvents CmsExplorer As ContextMenuStrip
    Friend WithEvents MinimizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HotfixAvailableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetPositionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanSplit As Panel
    Friend WithEvents CmdRunInDepth As Button
    Friend WithEvents lblAssessmentDepth As Label
    Friend WithEvents lblShowHToggle As Label
    Friend WithEvents ViewWinSATLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CmdSettings As Button
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents SaveResourcesToDiskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents AcknowledgementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TlpHeadSplit As TableLayoutPanel
    Friend WithEvents PanHeadSplit As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TlpComponent As TableLayoutPanel
    Friend WithEvents TlpRated As TableLayoutPanel
    Friend WithEvents TlpScore As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblAppVersion As Label
    Friend WithEvents TlpMenu As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents swHardware As GambolSwitch
    Friend WithEvents BMACToolstripMenuItem As ToolStripMenuItem
    Friend WithEvents LicenseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TlpMain As TableLayoutPanel
    Friend WithEvents CreateCompatibilityiniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateSettingsiniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartElevatedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdDebug As Button
    Friend WithEvents cmdElevate As Button
    Friend WithEvents cmsDebug As ContextMenuStrip
    Friend WithEvents ThrowUnhandledExceptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ShowToastInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowToastWarningToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowToastErrorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents OpenElevationWindowToolStripMenuItem As ToolStripMenuItem
End Class
