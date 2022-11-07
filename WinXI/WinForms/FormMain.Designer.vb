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
        Me.cmsExplorerMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MinimizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetPositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartElevatedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItemExplorer = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.pnlTitle = New System.Windows.Forms.Panel()
        Me.cmdOpenSettingsTitle = New System.Windows.Forms.Button()
        Me.tlpSeperatorTitle = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlTitleSeperator = New System.Windows.Forms.Panel()
        Me.cmdMinimize = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tlpTitleIcon = New System.Windows.Forms.TableLayoutPanel()
        Me.lblAppVersion = New System.Windows.Forms.Label()
        Me.lblLastAssessed = New System.Windows.Forms.Label()
        Me.lblLastAssessedString = New System.Windows.Forms.Label()
        Me.lblWinVerString = New System.Windows.Forms.Label()
        Me.lblWinVer = New System.Windows.Forms.Label()
        Me.lblValidityString = New System.Windows.Forms.Label()
        Me.cmdOpenToolsMenu = New System.Windows.Forms.Button()
        Me.cmdOpenExportMenu = New System.Windows.Forms.Button()
        Me.cmdOpenOptionsMenu = New System.Windows.Forms.Button()
        Me.cmdOpenHelpMenu = New System.Windows.Forms.Button()
        Me.pnlCapture = New System.Windows.Forms.Panel()
        Me.pnlSplit = New System.Windows.Forms.Panel()
        Me.tlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdRunAssessmentMain = New System.Windows.Forms.Button()
        Me.tlpWEIMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpWEI = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpComponent = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpWhatIsRated = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpSubscores = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpBaseScore = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlBaseScore = New System.Windows.Forms.Panel()
        Me.lblBasescore = New System.Windows.Forms.Label()
        Me.lblLowestSub = New System.Windows.Forms.Label()
        Me.tlpWEITitles = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.PanSplitCenter = New System.Windows.Forms.Panel()
        Me.tlpBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlShowHardware = New System.Windows.Forms.Panel()
        Me.tlpHardwareSwitch = New System.Windows.Forms.TableLayoutPanel()
        Me.swHardware = New WinXI.Gambol.Controls.GambolSwitch()
        Me.lblShowHToggle = New System.Windows.Forms.Label()
        Me.cmdRunInDepth = New System.Windows.Forms.Button()
        Me.pnlValidity = New System.Windows.Forms.Panel()
        Me.pnlValidityStateColor = New System.Windows.Forms.Panel()
        Me.lblValidity = New System.Windows.Forms.Label()
        Me.lblAssessmentDepth = New System.Windows.Forms.Label()
        Me.cmdMetrics = New System.Windows.Forms.Button()
        Me.lblScoreData = New System.Windows.Forms.Label()
        Me.lblShowHardware = New System.Windows.Forms.Label()
        Me.BMPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JPGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PNGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TXTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsExportMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImgurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsOptionsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewImgurLinksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewWinSATLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.RefreshScoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveResourcesToDiskToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolstripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdToolsMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSystemDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunVerboseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsHelpMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
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
        Me.tlpFormMenu = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdOpenDebugMenu = New System.Windows.Forms.Button()
        Me.tlpTitle = New System.Windows.Forms.TableLayoutPanel()
        Me.cmsDebugMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ThrowUnhandledExceptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowToastInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToastWarningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToastErrorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenElevationWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenHotfixWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenStartupMessageWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.icnMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsExplorerMenu.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        Me.tlpSeperatorTitle.SuspendLayout()
        Me.tlpTitleIcon.SuspendLayout()
        Me.pnlCapture.SuspendLayout()
        Me.tlpTop.SuspendLayout()
        Me.tlpWEIMain.SuspendLayout()
        Me.tlpWEI.SuspendLayout()
        Me.tlpComponent.SuspendLayout()
        Me.tlpWhatIsRated.SuspendLayout()
        Me.tlpSubscores.SuspendLayout()
        Me.tlpBaseScore.SuspendLayout()
        Me.pnlBaseScore.SuspendLayout()
        Me.tlpWEITitles.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.tlpBottom.SuspendLayout()
        Me.pnlShowHardware.SuspendLayout()
        Me.tlpHardwareSwitch.SuspendLayout()
        Me.pnlValidity.SuspendLayout()
        Me.cmsExportMenu.SuspendLayout()
        Me.cmsOptionsMenu.SuspendLayout()
        Me.cmdToolsMenu.SuspendLayout()
        Me.cmsHelpMenu.SuspendLayout()
        Me.tlpFormMenu.SuspendLayout()
        Me.tlpTitle.SuspendLayout()
        Me.cmsDebugMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'icnMain
        '
        Me.icnMain.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.icnMain.BackColor = System.Drawing.Color.Transparent
        Me.icnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.icnMain.ContextMenuStrip = Me.cmsExplorerMenu
        Me.icnMain.Image = Global.WinXI.My.Resources.Resources.ImgMainIcon24Px
        Me.icnMain.Location = New System.Drawing.Point(10, 10)
        Me.icnMain.Margin = New System.Windows.Forms.Padding(10, 0, 0, 6)
        Me.icnMain.Name = "icnMain"
        Me.icnMain.Size = New System.Drawing.Size(24, 24)
        Me.icnMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icnMain.TabIndex = 1
        Me.icnMain.TabStop = False
        '
        'cmsExplorerMenu
        '
        Me.cmsExplorerMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmsExplorerMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsExplorerMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MinimizeToolStripMenuItem, Me.ResetPositionToolStripMenuItem, Me.RestartApplicationToolStripMenuItem, Me.RestartElevatedToolStripMenuItem, Me.ToolStripSeparator8, Me.CloseToolStripMenuItem, Me.ToolStripSeparator9, Me.AboutToolStripMenuItemExplorer})
        Me.cmsExplorerMenu.Name = "cmsExplorer"
        Me.cmsExplorerMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.cmsExplorerMenu.ShowImageMargin = False
        Me.cmsExplorerMenu.Size = New System.Drawing.Size(199, 184)
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
        'AboutToolStripMenuItemExplorer
        '
        Me.AboutToolStripMenuItemExplorer.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItemExplorer.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItemExplorer.Name = "AboutToolStripMenuItemExplorer"
        Me.AboutToolStripMenuItemExplorer.Size = New System.Drawing.Size(198, 28)
        Me.AboutToolStripMenuItemExplorer.Text = "About"
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
        'pnlTitle
        '
        Me.pnlTitle.BackColor = System.Drawing.Color.Transparent
        Me.pnlTitle.Controls.Add(Me.cmdOpenSettingsTitle)
        Me.pnlTitle.Controls.Add(Me.tlpSeperatorTitle)
        Me.pnlTitle.Controls.Add(Me.cmdMinimize)
        Me.pnlTitle.Controls.Add(Me.cmdClose)
        Me.pnlTitle.Controls.Add(Me.tlpTitleIcon)
        Me.pnlTitle.Controls.Add(Me.lblHead)
        Me.pnlTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlTitle.Name = "pnlTitle"
        Me.pnlTitle.Size = New System.Drawing.Size(923, 50)
        Me.pnlTitle.TabIndex = 59
        '
        'cmdOpenSettingsTitle
        '
        Me.cmdOpenSettingsTitle.BackColor = System.Drawing.Color.Transparent
        Me.cmdOpenSettingsTitle.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdOpenSettingsTitle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdOpenSettingsTitle.FlatAppearance.BorderSize = 0
        Me.cmdOpenSettingsTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.cmdOpenSettingsTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.cmdOpenSettingsTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOpenSettingsTitle.Font = New System.Drawing.Font("Segoe MDL2 Assets", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenSettingsTitle.ForeColor = System.Drawing.Color.White
        Me.cmdOpenSettingsTitle.Location = New System.Drawing.Point(757, 0)
        Me.cmdOpenSettingsTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOpenSettingsTitle.Name = "cmdOpenSettingsTitle"
        Me.cmdOpenSettingsTitle.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.cmdOpenSettingsTitle.Size = New System.Drawing.Size(50, 50)
        Me.cmdOpenSettingsTitle.TabIndex = 0
        Me.cmdOpenSettingsTitle.TabStop = False
        Me.cmdOpenSettingsTitle.Text = ""
        Me.cmdOpenSettingsTitle.UseVisualStyleBackColor = False
        '
        'tlpSeperatorTitle
        '
        Me.tlpSeperatorTitle.BackColor = System.Drawing.Color.Transparent
        Me.tlpSeperatorTitle.ColumnCount = 1
        Me.tlpSeperatorTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSeperatorTitle.Controls.Add(Me.pnlTitleSeperator, 0, 0)
        Me.tlpSeperatorTitle.Dock = System.Windows.Forms.DockStyle.Right
        Me.tlpSeperatorTitle.Location = New System.Drawing.Point(807, 0)
        Me.tlpSeperatorTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpSeperatorTitle.Name = "tlpSeperatorTitle"
        Me.tlpSeperatorTitle.RowCount = 1
        Me.tlpSeperatorTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpSeperatorTitle.Size = New System.Drawing.Size(16, 50)
        Me.tlpSeperatorTitle.TabIndex = 10
        '
        'pnlTitleSeperator
        '
        Me.pnlTitleSeperator.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlTitleSeperator.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.pnlTitleSeperator.Location = New System.Drawing.Point(7, 8)
        Me.pnlTitleSeperator.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlTitleSeperator.Name = "pnlTitleSeperator"
        Me.pnlTitleSeperator.Size = New System.Drawing.Size(2, 34)
        Me.pnlTitleSeperator.TabIndex = 0
        '
        'cmdMinimize
        '
        Me.cmdMinimize.BackColor = System.Drawing.Color.Transparent
        Me.cmdMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdMinimize.FlatAppearance.BorderSize = 0
        Me.cmdMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.cmdMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.cmdMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdMinimize.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMinimize.ForeColor = System.Drawing.Color.White
        Me.cmdMinimize.Location = New System.Drawing.Point(823, 0)
        Me.cmdMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdMinimize.Name = "cmdMinimize"
        Me.cmdMinimize.Padding = New System.Windows.Forms.Padding(2, 0, 0, 1)
        Me.cmdMinimize.Size = New System.Drawing.Size(50, 50)
        Me.cmdMinimize.TabIndex = 0
        Me.cmdMinimize.TabStop = False
        Me.cmdMinimize.Text = "—"
        Me.cmdMinimize.UseVisualStyleBackColor = False
        '
        'cmdClose
        '
        Me.cmdClose.BackColor = System.Drawing.Color.Transparent
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdClose.FlatAppearance.BorderSize = 0
        Me.cmdClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ForeColor = System.Drawing.Color.White
        Me.cmdClose.Location = New System.Drawing.Point(873, 0)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Padding = New System.Windows.Forms.Padding(2, 0, 0, 1)
        Me.cmdClose.Size = New System.Drawing.Size(50, 50)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.TabStop = False
        Me.cmdClose.Text = "✕"
        Me.cmdClose.UseVisualStyleBackColor = False
        '
        'tlpTitleIcon
        '
        Me.tlpTitleIcon.BackColor = System.Drawing.Color.Transparent
        Me.tlpTitleIcon.ColumnCount = 1
        Me.tlpTitleIcon.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166.0!))
        Me.tlpTitleIcon.Controls.Add(Me.icnMain, 0, 0)
        Me.tlpTitleIcon.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlpTitleIcon.Location = New System.Drawing.Point(0, 0)
        Me.tlpTitleIcon.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpTitleIcon.Name = "tlpTitleIcon"
        Me.tlpTitleIcon.RowCount = 1
        Me.tlpTitleIcon.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTitleIcon.Size = New System.Drawing.Size(166, 50)
        Me.tlpTitleIcon.TabIndex = 8
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
        'cmdOpenToolsMenu
        '
        Me.cmdOpenToolsMenu.BackColor = System.Drawing.Color.Transparent
        Me.cmdOpenToolsMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdOpenToolsMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdOpenToolsMenu.FlatAppearance.BorderSize = 0
        Me.cmdOpenToolsMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.cmdOpenToolsMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.cmdOpenToolsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOpenToolsMenu.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenToolsMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdOpenToolsMenu.Location = New System.Drawing.Point(152, 0)
        Me.cmdOpenToolsMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOpenToolsMenu.Name = "cmdOpenToolsMenu"
        Me.cmdOpenToolsMenu.Size = New System.Drawing.Size(76, 40)
        Me.cmdOpenToolsMenu.TabIndex = 2
        Me.cmdOpenToolsMenu.Text = "Tools"
        Me.cmdOpenToolsMenu.UseVisualStyleBackColor = False
        '
        'cmdOpenExportMenu
        '
        Me.cmdOpenExportMenu.BackColor = System.Drawing.Color.Transparent
        Me.cmdOpenExportMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdOpenExportMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdOpenExportMenu.FlatAppearance.BorderSize = 0
        Me.cmdOpenExportMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.cmdOpenExportMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.cmdOpenExportMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOpenExportMenu.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenExportMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdOpenExportMenu.Location = New System.Drawing.Point(0, 0)
        Me.cmdOpenExportMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOpenExportMenu.Name = "cmdOpenExportMenu"
        Me.cmdOpenExportMenu.Size = New System.Drawing.Size(76, 40)
        Me.cmdOpenExportMenu.TabIndex = 0
        Me.cmdOpenExportMenu.Text = "Export"
        Me.cmdOpenExportMenu.UseVisualStyleBackColor = False
        '
        'cmdOpenOptionsMenu
        '
        Me.cmdOpenOptionsMenu.BackColor = System.Drawing.Color.Transparent
        Me.cmdOpenOptionsMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdOpenOptionsMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdOpenOptionsMenu.FlatAppearance.BorderSize = 0
        Me.cmdOpenOptionsMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.cmdOpenOptionsMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.cmdOpenOptionsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOpenOptionsMenu.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenOptionsMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdOpenOptionsMenu.Location = New System.Drawing.Point(76, 0)
        Me.cmdOpenOptionsMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOpenOptionsMenu.Name = "cmdOpenOptionsMenu"
        Me.cmdOpenOptionsMenu.Size = New System.Drawing.Size(76, 40)
        Me.cmdOpenOptionsMenu.TabIndex = 1
        Me.cmdOpenOptionsMenu.Text = "Options"
        Me.cmdOpenOptionsMenu.UseVisualStyleBackColor = False
        '
        'cmdOpenHelpMenu
        '
        Me.cmdOpenHelpMenu.BackColor = System.Drawing.Color.Transparent
        Me.cmdOpenHelpMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdOpenHelpMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdOpenHelpMenu.FlatAppearance.BorderSize = 0
        Me.cmdOpenHelpMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.cmdOpenHelpMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.cmdOpenHelpMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOpenHelpMenu.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenHelpMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdOpenHelpMenu.Location = New System.Drawing.Point(228, 0)
        Me.cmdOpenHelpMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOpenHelpMenu.Name = "cmdOpenHelpMenu"
        Me.cmdOpenHelpMenu.Size = New System.Drawing.Size(76, 40)
        Me.cmdOpenHelpMenu.TabIndex = 3
        Me.cmdOpenHelpMenu.Text = "Help"
        Me.cmdOpenHelpMenu.UseVisualStyleBackColor = False
        '
        'pnlCapture
        '
        Me.pnlCapture.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlCapture.Controls.Add(Me.pnlSplit)
        Me.pnlCapture.Controls.Add(Me.tlpTop)
        Me.pnlCapture.Controls.Add(Me.tlpWEIMain)
        Me.pnlCapture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCapture.Location = New System.Drawing.Point(1, 91)
        Me.pnlCapture.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlCapture.Name = "pnlCapture"
        Me.pnlCapture.Size = New System.Drawing.Size(923, 311)
        Me.pnlCapture.TabIndex = 86
        '
        'pnlSplit
        '
        Me.pnlSplit.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pnlSplit.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSplit.ForeColor = System.Drawing.Color.Black
        Me.pnlSplit.Location = New System.Drawing.Point(0, 0)
        Me.pnlSplit.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlSplit.Name = "pnlSplit"
        Me.pnlSplit.Size = New System.Drawing.Size(923, 2)
        Me.pnlSplit.TabIndex = 88
        '
        'tlpTop
        '
        Me.tlpTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.tlpTop.ColumnCount = 2
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.36323!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.63677!))
        Me.tlpTop.Controls.Add(Me.lblScale, 0, 0)
        Me.tlpTop.Controls.Add(Me.cmdRunAssessmentMain, 1, 0)
        Me.tlpTop.Location = New System.Drawing.Point(16, 19)
        Me.tlpTop.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpTop.Name = "tlpTop"
        Me.tlpTop.RowCount = 1
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.Size = New System.Drawing.Size(891, 38)
        Me.tlpTop.TabIndex = 87
        '
        'cmdRunAssessmentMain
        '
        Me.cmdRunAssessmentMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.cmdRunAssessmentMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdRunAssessmentMain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdRunAssessmentMain.FlatAppearance.BorderSize = 0
        Me.cmdRunAssessmentMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdRunAssessmentMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdRunAssessmentMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRunAssessmentMain.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRunAssessmentMain.ForeColor = System.Drawing.Color.White
        Me.cmdRunAssessmentMain.Location = New System.Drawing.Point(698, 0)
        Me.cmdRunAssessmentMain.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdRunAssessmentMain.Name = "cmdRunAssessmentMain"
        Me.cmdRunAssessmentMain.Size = New System.Drawing.Size(193, 38)
        Me.cmdRunAssessmentMain.TabIndex = 6
        Me.cmdRunAssessmentMain.Text = "..."
        Me.cmdRunAssessmentMain.UseVisualStyleBackColor = False
        '
        'tlpWEIMain
        '
        Me.tlpWEIMain.ColumnCount = 1
        Me.tlpWEIMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 891.0!))
        Me.tlpWEIMain.Controls.Add(Me.tlpWEI, 0, 1)
        Me.tlpWEIMain.Controls.Add(Me.tlpWEITitles, 0, 0)
        Me.tlpWEIMain.Location = New System.Drawing.Point(16, 71)
        Me.tlpWEIMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpWEIMain.Name = "tlpWEIMain"
        Me.tlpWEIMain.RowCount = 2
        Me.tlpWEIMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpWEIMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.tlpWEIMain.Size = New System.Drawing.Size(891, 228)
        Me.tlpWEIMain.TabIndex = 86
        '
        'tlpWEI
        '
        Me.tlpWEI.ColumnCount = 4
        Me.tlpWEI.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
        Me.tlpWEI.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 410.0!))
        Me.tlpWEI.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpWEI.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192.0!))
        Me.tlpWEI.Controls.Add(Me.tlpComponent, 0, 0)
        Me.tlpWEI.Controls.Add(Me.tlpWhatIsRated, 1, 0)
        Me.tlpWEI.Controls.Add(Me.tlpSubscores, 2, 0)
        Me.tlpWEI.Controls.Add(Me.tlpBaseScore, 3, 0)
        Me.tlpWEI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpWEI.Location = New System.Drawing.Point(0, 38)
        Me.tlpWEI.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpWEI.Name = "tlpWEI"
        Me.tlpWEI.RowCount = 1
        Me.tlpWEI.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpWEI.Size = New System.Drawing.Size(891, 190)
        Me.tlpWEI.TabIndex = 0
        '
        'tlpComponent
        '
        Me.tlpComponent.ColumnCount = 1
        Me.tlpComponent.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
        Me.tlpComponent.Controls.Add(Me.lblProcessor, 0, 0)
        Me.tlpComponent.Controls.Add(Me.lblMemory, 0, 1)
        Me.tlpComponent.Controls.Add(Me.lblGraphics, 0, 2)
        Me.tlpComponent.Controls.Add(Me.lblDisk, 0, 4)
        Me.tlpComponent.Controls.Add(Me.lblGaming, 0, 3)
        Me.tlpComponent.Dock = System.Windows.Forms.DockStyle.Left
        Me.tlpComponent.Location = New System.Drawing.Point(0, 0)
        Me.tlpComponent.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpComponent.Name = "tlpComponent"
        Me.tlpComponent.RowCount = 5
        Me.tlpComponent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpComponent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpComponent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpComponent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpComponent.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpComponent.Size = New System.Drawing.Size(190, 190)
        Me.tlpComponent.TabIndex = 0
        '
        'tlpWhatIsRated
        '
        Me.tlpWhatIsRated.ColumnCount = 1
        Me.tlpWhatIsRated.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpWhatIsRated.Controls.Add(Me.lblProcessorR, 0, 0)
        Me.tlpWhatIsRated.Controls.Add(Me.lblMemoryR, 0, 1)
        Me.tlpWhatIsRated.Controls.Add(Me.lblGraphicsR, 0, 2)
        Me.tlpWhatIsRated.Controls.Add(Me.lblDiskR, 0, 4)
        Me.tlpWhatIsRated.Controls.Add(Me.lblGamingR, 0, 3)
        Me.tlpWhatIsRated.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpWhatIsRated.Location = New System.Drawing.Point(190, 0)
        Me.tlpWhatIsRated.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpWhatIsRated.Name = "tlpWhatIsRated"
        Me.tlpWhatIsRated.RowCount = 5
        Me.tlpWhatIsRated.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpWhatIsRated.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpWhatIsRated.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpWhatIsRated.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpWhatIsRated.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpWhatIsRated.Size = New System.Drawing.Size(410, 190)
        Me.tlpWhatIsRated.TabIndex = 1
        '
        'tlpSubscores
        '
        Me.tlpSubscores.ColumnCount = 1
        Me.tlpSubscores.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSubscores.Controls.Add(Me.lblDiskScore, 0, 4)
        Me.tlpSubscores.Controls.Add(Me.lblProcessorScore, 0, 0)
        Me.tlpSubscores.Controls.Add(Me.lblMemoryScore, 0, 1)
        Me.tlpSubscores.Controls.Add(Me.lblGamingScore, 0, 3)
        Me.tlpSubscores.Controls.Add(Me.lblGraphicsScore, 0, 2)
        Me.tlpSubscores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpSubscores.Location = New System.Drawing.Point(600, 0)
        Me.tlpSubscores.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpSubscores.Name = "tlpSubscores"
        Me.tlpSubscores.RowCount = 5
        Me.tlpSubscores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpSubscores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpSubscores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpSubscores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpSubscores.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpSubscores.Size = New System.Drawing.Size(100, 190)
        Me.tlpSubscores.TabIndex = 70
        '
        'tlpBaseScore
        '
        Me.tlpBaseScore.ColumnCount = 1
        Me.tlpBaseScore.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBaseScore.Controls.Add(Me.pnlBaseScore, 0, 0)
        Me.tlpBaseScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBaseScore.Location = New System.Drawing.Point(700, 0)
        Me.tlpBaseScore.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpBaseScore.Name = "tlpBaseScore"
        Me.tlpBaseScore.RowCount = 1
        Me.tlpBaseScore.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBaseScore.Size = New System.Drawing.Size(192, 190)
        Me.tlpBaseScore.TabIndex = 71
        '
        'pnlBaseScore
        '
        Me.pnlBaseScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlBaseScore.Controls.Add(Me.lblBasescore)
        Me.pnlBaseScore.Controls.Add(Me.lblLowestSub)
        Me.pnlBaseScore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBaseScore.Location = New System.Drawing.Point(0, 0)
        Me.pnlBaseScore.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.pnlBaseScore.Name = "pnlBaseScore"
        Me.pnlBaseScore.Size = New System.Drawing.Size(192, 189)
        Me.pnlBaseScore.TabIndex = 71
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
        'tlpWEITitles
        '
        Me.tlpWEITitles.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.tlpWEITitles.ColumnCount = 4
        Me.tlpWEITitles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpWEITitles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 410.0!))
        Me.tlpWEITitles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpWEITitles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 192.0!))
        Me.tlpWEITitles.Controls.Add(Me.lblBase, 3, 0)
        Me.tlpWEITitles.Controls.Add(Me.lblComponent, 0, 0)
        Me.tlpWEITitles.Controls.Add(Me.lblSub, 2, 0)
        Me.tlpWEITitles.Controls.Add(Me.lblRated, 1, 0)
        Me.tlpWEITitles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpWEITitles.Location = New System.Drawing.Point(0, 0)
        Me.tlpWEITitles.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.tlpWEITitles.Name = "tlpWEITitles"
        Me.tlpWEITitles.RowCount = 1
        Me.tlpWEITitles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpWEITitles.Size = New System.Drawing.Size(891, 37)
        Me.tlpWEITitles.TabIndex = 1
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.pnlBottom.Controls.Add(Me.PanSplitCenter)
        Me.pnlBottom.Controls.Add(Me.tlpBottom)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(1, 402)
        Me.pnlBottom.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(923, 162)
        Me.pnlBottom.TabIndex = 87
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
        'tlpBottom
        '
        Me.tlpBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.tlpBottom.ColumnCount = 4
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 409.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 185.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpBottom.Controls.Add(Me.pnlShowHardware, 3, 0)
        Me.tlpBottom.Controls.Add(Me.cmdRunInDepth, 3, 2)
        Me.tlpBottom.Controls.Add(Me.pnlValidity, 0, 0)
        Me.tlpBottom.Controls.Add(Me.lblAssessmentDepth, 2, 2)
        Me.tlpBottom.Controls.Add(Me.cmdMetrics, 3, 1)
        Me.tlpBottom.Controls.Add(Me.lblLastAssessed, 0, 1)
        Me.tlpBottom.Controls.Add(Me.lblScoreData, 2, 1)
        Me.tlpBottom.Controls.Add(Me.lblWinVer, 0, 2)
        Me.tlpBottom.Controls.Add(Me.lblValidityString, 1, 0)
        Me.tlpBottom.Controls.Add(Me.lblShowHardware, 2, 0)
        Me.tlpBottom.Controls.Add(Me.lblLastAssessedString, 1, 1)
        Me.tlpBottom.Controls.Add(Me.lblWinVerString, 1, 2)
        Me.tlpBottom.Location = New System.Drawing.Point(16, 32)
        Me.tlpBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpBottom.Name = "tlpBottom"
        Me.tlpBottom.RowCount = 3
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.tlpBottom.Size = New System.Drawing.Size(891, 114)
        Me.tlpBottom.TabIndex = 80
        '
        'pnlShowHardware
        '
        Me.pnlShowHardware.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.pnlShowHardware.Controls.Add(Me.tlpHardwareSwitch)
        Me.pnlShowHardware.Controls.Add(Me.lblShowHToggle)
        Me.pnlShowHardware.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlShowHardware.Location = New System.Drawing.Point(785, 0)
        Me.pnlShowHardware.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.pnlShowHardware.Name = "pnlShowHardware"
        Me.pnlShowHardware.Size = New System.Drawing.Size(106, 37)
        Me.pnlShowHardware.TabIndex = 75
        '
        'tlpHardwareSwitch
        '
        Me.tlpHardwareSwitch.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.tlpHardwareSwitch.ColumnCount = 1
        Me.tlpHardwareSwitch.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHardwareSwitch.Controls.Add(Me.swHardware, 0, 0)
        Me.tlpHardwareSwitch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpHardwareSwitch.Location = New System.Drawing.Point(0, 0)
        Me.tlpHardwareSwitch.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpHardwareSwitch.Name = "tlpHardwareSwitch"
        Me.tlpHardwareSwitch.RowCount = 1
        Me.tlpHardwareSwitch.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpHardwareSwitch.Size = New System.Drawing.Size(56, 37)
        Me.tlpHardwareSwitch.TabIndex = 1
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
        'cmdRunInDepth
        '
        Me.cmdRunInDepth.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.cmdRunInDepth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdRunInDepth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.cmdRunInDepth.FlatAppearance.BorderSize = 0
        Me.cmdRunInDepth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdRunInDepth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.cmdRunInDepth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRunInDepth.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRunInDepth.ForeColor = System.Drawing.Color.White
        Me.cmdRunInDepth.Location = New System.Drawing.Point(785, 76)
        Me.cmdRunInDepth.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.cmdRunInDepth.Name = "cmdRunInDepth"
        Me.cmdRunInDepth.Size = New System.Drawing.Size(106, 37)
        Me.cmdRunInDepth.TabIndex = 6
        Me.cmdRunInDepth.Text = "Run"
        Me.cmdRunInDepth.UseVisualStyleBackColor = False
        '
        'pnlValidity
        '
        Me.pnlValidity.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.pnlValidity.Controls.Add(Me.pnlValidityStateColor)
        Me.pnlValidity.Controls.Add(Me.lblValidity)
        Me.pnlValidity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlValidity.Location = New System.Drawing.Point(0, 0)
        Me.pnlValidity.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.pnlValidity.Name = "pnlValidity"
        Me.pnlValidity.Padding = New System.Windows.Forms.Padding(1)
        Me.pnlValidity.Size = New System.Drawing.Size(190, 37)
        Me.pnlValidity.TabIndex = 73
        '
        'pnlValidityStateColor
        '
        Me.pnlValidityStateColor.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlValidityStateColor.Location = New System.Drawing.Point(187, 1)
        Me.pnlValidityStateColor.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlValidityStateColor.Name = "pnlValidityStateColor"
        Me.pnlValidityStateColor.Size = New System.Drawing.Size(2, 35)
        Me.pnlValidityStateColor.TabIndex = 68
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
        'lblScoreData
        '
        Me.lblScoreData.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblScoreData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblScoreData.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.lblScoreData.Location = New System.Drawing.Point(600, 38)
        Me.lblScoreData.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
        Me.lblScoreData.Name = "lblScoreData"
        Me.lblScoreData.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.lblScoreData.Size = New System.Drawing.Size(184, 37)
        Me.lblScoreData.TabIndex = 67
        Me.lblScoreData.Text = "Score Data"
        Me.lblScoreData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.BMPToolStripMenuItem.Size = New System.Drawing.Size(388, 28)
        Me.BMPToolStripMenuItem.Text = "Save Scores as BMP (Higher Quality)"
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
        Me.JPGToolStripMenuItem.Size = New System.Drawing.Size(388, 28)
        Me.JPGToolStripMenuItem.Text = "Save Scores as JPG (Lower Quality)"
        '
        'PNGToolStripMenuItem
        '
        Me.PNGToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PNGToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.PNGToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PNGToolStripMenuItem.Name = "PNGToolStripMenuItem"
        Me.PNGToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.PNGToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PNGToolStripMenuItem.Size = New System.Drawing.Size(388, 28)
        Me.PNGToolStripMenuItem.Text = "Save Scores as PNG (Better Quality)"
        '
        'TXTToolStripMenuItem
        '
        Me.TXTToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TXTToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TXTToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TXTToolStripMenuItem.Name = "TXTToolStripMenuItem"
        Me.TXTToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.TXTToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TXTToolStripMenuItem.Size = New System.Drawing.Size(388, 28)
        Me.TXTToolStripMenuItem.Text = "Save Scores to a Text File"
        '
        'cmsExportMenu
        '
        Me.cmsExportMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmsExportMenu.DropShadowEnabled = False
        Me.cmsExportMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsExportMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JPGToolStripMenuItem, Me.PNGToolStripMenuItem, Me.BMPToolStripMenuItem, Me.ToolStripSeparator4, Me.TXTToolStripMenuItem, Me.ToolStripSeparator1, Me.ImgurToolStripMenuItem})
        Me.cmsExportMenu.Name = "ContextMenuStrip1"
        Me.cmsExportMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.cmsExportMenu.ShowImageMargin = False
        Me.cmsExportMenu.Size = New System.Drawing.Size(389, 156)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(385, 6)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(385, 6)
        '
        'ImgurToolStripMenuItem
        '
        Me.ImgurToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ImgurToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ImgurToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ImgurToolStripMenuItem.Name = "ImgurToolStripMenuItem"
        Me.ImgurToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ImgurToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ImgurToolStripMenuItem.Size = New System.Drawing.Size(388, 28)
        Me.ImgurToolStripMenuItem.Text = "Upload Screenshot to Imgur"
        '
        'cmsOptionsMenu
        '
        Me.cmsOptionsMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmsOptionsMenu.DropShadowEnabled = False
        Me.cmsOptionsMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsOptionsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewImgurLinksToolStripMenuItem, Me.ViewLogToolStripMenuItem, Me.ViewWinSATLogToolStripMenuItem, Me.ToolStripSeparator5, Me.RefreshScoresToolStripMenuItem, Me.ToolStripSeparator2, Me.SaveResourcesToDiskToolStripMenuItem, Me.ToolStripSeparator7, Me.SettingsToolstripMenuItem})
        Me.cmsOptionsMenu.Name = "ContextMenuStrip1"
        Me.cmsOptionsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.cmsOptionsMenu.ShowImageMargin = False
        Me.cmsOptionsMenu.Size = New System.Drawing.Size(281, 190)
        '
        'ViewImgurLinksToolStripMenuItem
        '
        Me.ViewImgurLinksToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ViewImgurLinksToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ViewImgurLinksToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ViewImgurLinksToolStripMenuItem.Name = "ViewImgurLinksToolStripMenuItem"
        Me.ViewImgurLinksToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ViewImgurLinksToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.ViewImgurLinksToolStripMenuItem.Size = New System.Drawing.Size(280, 28)
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
        Me.ViewLogToolStripMenuItem.Size = New System.Drawing.Size(280, 28)
        Me.ViewLogToolStripMenuItem.Text = "View Assessment Log"
        '
        'ViewWinSATLogToolStripMenuItem
        '
        Me.ViewWinSATLogToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.ViewWinSATLogToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ViewWinSATLogToolStripMenuItem.Name = "ViewWinSATLogToolStripMenuItem"
        Me.ViewWinSATLogToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ViewWinSATLogToolStripMenuItem.Size = New System.Drawing.Size(280, 28)
        Me.ViewWinSATLogToolStripMenuItem.Text = "View Winsat Log"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(277, 6)
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
        Me.RefreshScoresToolStripMenuItem.Size = New System.Drawing.Size(280, 28)
        Me.RefreshScoresToolStripMenuItem.Text = "Refresh Scores"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(277, 6)
        '
        'SaveResourcesToDiskToolStripMenuItem
        '
        Me.SaveResourcesToDiskToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SaveResourcesToDiskToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveResourcesToDiskToolStripMenuItem.Name = "SaveResourcesToDiskToolStripMenuItem"
        Me.SaveResourcesToDiskToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.SaveResourcesToDiskToolStripMenuItem.Size = New System.Drawing.Size(280, 28)
        Me.SaveResourcesToDiskToolStripMenuItem.Text = "Save Resources to Disk"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(277, 6)
        '
        'SettingsToolstripMenuItem
        '
        Me.SettingsToolstripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SettingsToolstripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.SettingsToolstripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SettingsToolstripMenuItem.Name = "SettingsToolstripMenuItem"
        Me.SettingsToolstripMenuItem.ShortcutKeyDisplayString = ""
        Me.SettingsToolstripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SettingsToolstripMenuItem.Size = New System.Drawing.Size(280, 28)
        Me.SettingsToolstripMenuItem.Text = "Settings"
        '
        'cmdToolsMenu
        '
        Me.cmdToolsMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmdToolsMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmdToolsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ViewSystemDetailsToolStripMenuItem, Me.ToolStripSeparator6, Me.RunToolStripMenuItem, Me.RunVerboseToolStripMenuItem})
        Me.cmdToolsMenu.Name = "ContextMenuStrip1"
        Me.cmdToolsMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.cmdToolsMenu.ShowImageMargin = False
        Me.cmdToolsMenu.Size = New System.Drawing.Size(304, 122)
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
        'cmsHelpMenu
        '
        Me.cmsHelpMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmsHelpMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsHelpMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MediaFeaturePackToolStripMenuItem, Me.TroubleshootingToolStripMenuItem, Me.ToolStripSeparator3, Me.HotfixAvailableToolStripMenuItem, Me.UpdateAvailableToolStripMenuItem, Me.ChangelogToolStripMenuItem, Me.ToolStripSeparator10, Me.AboutToolStripMenuItem, Me.AcknowledgementsToolStripMenuItem, Me.BMACToolstripMenuItem, Me.LicenseToolStripMenuItem})
        Me.cmsHelpMenu.Name = "cmsHelp"
        Me.cmsHelpMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.cmsHelpMenu.ShowImageMargin = False
        Me.cmsHelpMenu.Size = New System.Drawing.Size(267, 268)
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
        'tlpFormMenu
        '
        Me.tlpFormMenu.BackColor = System.Drawing.Color.Transparent
        Me.tlpFormMenu.ColumnCount = 6
        Me.tlpFormMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.tlpFormMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.tlpFormMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.tlpFormMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.tlpFormMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.tlpFormMenu.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpFormMenu.Controls.Add(Me.cmdOpenToolsMenu, 2, 0)
        Me.tlpFormMenu.Controls.Add(Me.cmdOpenExportMenu, 0, 0)
        Me.tlpFormMenu.Controls.Add(Me.cmdOpenOptionsMenu, 1, 0)
        Me.tlpFormMenu.Controls.Add(Me.cmdOpenHelpMenu, 3, 0)
        Me.tlpFormMenu.Controls.Add(Me.cmdOpenDebugMenu, 4, 0)
        Me.tlpFormMenu.Controls.Add(Me.lblAppVersion, 5, 0)
        Me.tlpFormMenu.Location = New System.Drawing.Point(0, 50)
        Me.tlpFormMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpFormMenu.Name = "tlpFormMenu"
        Me.tlpFormMenu.RowCount = 1
        Me.tlpFormMenu.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFormMenu.Size = New System.Drawing.Size(922, 40)
        Me.tlpFormMenu.TabIndex = 88
        '
        'cmdOpenDebugMenu
        '
        Me.cmdOpenDebugMenu.BackColor = System.Drawing.Color.Transparent
        Me.cmdOpenDebugMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdOpenDebugMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.cmdOpenDebugMenu.FlatAppearance.BorderSize = 0
        Me.cmdOpenDebugMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.cmdOpenDebugMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.cmdOpenDebugMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdOpenDebugMenu.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenDebugMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdOpenDebugMenu.Location = New System.Drawing.Point(304, 0)
        Me.cmdOpenDebugMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdOpenDebugMenu.Name = "cmdOpenDebugMenu"
        Me.cmdOpenDebugMenu.Size = New System.Drawing.Size(76, 40)
        Me.cmdOpenDebugMenu.TabIndex = 9
        Me.cmdOpenDebugMenu.Text = "Debug"
        Me.cmdOpenDebugMenu.UseVisualStyleBackColor = False
        '
        'tlpTitle
        '
        Me.tlpTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.tlpTitle.ColumnCount = 1
        Me.tlpTitle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTitle.Controls.Add(Me.tlpFormMenu, 0, 1)
        Me.tlpTitle.Controls.Add(Me.pnlTitle, 0, 0)
        Me.tlpTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpTitle.Location = New System.Drawing.Point(1, 1)
        Me.tlpTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpTitle.Name = "tlpTitle"
        Me.tlpTitle.RowCount = 2
        Me.tlpTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpTitle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpTitle.Size = New System.Drawing.Size(923, 90)
        Me.tlpTitle.TabIndex = 89
        '
        'cmsDebugMenu
        '
        Me.cmsDebugMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.cmsDebugMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsDebugMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThrowUnhandledExceptionToolStripMenuItem, Me.ToolStripSeparator11, Me.ShowToastInfoToolStripMenuItem, Me.ShowToastWarningToolStripMenuItem, Me.ShowToastErrorToolStripMenuItem, Me.ToolStripSeparator12, Me.OpenElevationWindowToolStripMenuItem, Me.OpenHotfixWindowToolStripMenuItem, Me.OpenStartupMessageWindowToolStripMenuItem})
        Me.cmsDebugMenu.Name = "cmsDebug"
        Me.cmsDebugMenu.ShowImageMargin = False
        Me.cmsDebugMenu.Size = New System.Drawing.Size(295, 212)
        '
        'ThrowUnhandledExceptionToolStripMenuItem
        '
        Me.ThrowUnhandledExceptionToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThrowUnhandledExceptionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ThrowUnhandledExceptionToolStripMenuItem.Name = "ThrowUnhandledExceptionToolStripMenuItem"
        Me.ThrowUnhandledExceptionToolStripMenuItem.Size = New System.Drawing.Size(294, 28)
        Me.ThrowUnhandledExceptionToolStripMenuItem.Text = "Throw Unhandled Exception"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(291, 6)
        '
        'ShowToastInfoToolStripMenuItem
        '
        Me.ShowToastInfoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowToastInfoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowToastInfoToolStripMenuItem.Name = "ShowToastInfoToolStripMenuItem"
        Me.ShowToastInfoToolStripMenuItem.Size = New System.Drawing.Size(294, 28)
        Me.ShowToastInfoToolStripMenuItem.Text = "Show Toast (Info)"
        '
        'ShowToastWarningToolStripMenuItem
        '
        Me.ShowToastWarningToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowToastWarningToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowToastWarningToolStripMenuItem.Name = "ShowToastWarningToolStripMenuItem"
        Me.ShowToastWarningToolStripMenuItem.Size = New System.Drawing.Size(294, 28)
        Me.ShowToastWarningToolStripMenuItem.Text = "Show Toast (Warning)"
        '
        'ShowToastErrorToolStripMenuItem
        '
        Me.ShowToastErrorToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowToastErrorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ShowToastErrorToolStripMenuItem.Name = "ShowToastErrorToolStripMenuItem"
        Me.ShowToastErrorToolStripMenuItem.Size = New System.Drawing.Size(294, 28)
        Me.ShowToastErrorToolStripMenuItem.Text = "Show Toast (Error)"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(291, 6)
        '
        'OpenElevationWindowToolStripMenuItem
        '
        Me.OpenElevationWindowToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenElevationWindowToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OpenElevationWindowToolStripMenuItem.Name = "OpenElevationWindowToolStripMenuItem"
        Me.OpenElevationWindowToolStripMenuItem.Size = New System.Drawing.Size(294, 28)
        Me.OpenElevationWindowToolStripMenuItem.Text = "Open Elevation Window"
        '
        'OpenHotfixWindowToolStripMenuItem
        '
        Me.OpenHotfixWindowToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenHotfixWindowToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OpenHotfixWindowToolStripMenuItem.Name = "OpenHotfixWindowToolStripMenuItem"
        Me.OpenHotfixWindowToolStripMenuItem.Size = New System.Drawing.Size(294, 28)
        Me.OpenHotfixWindowToolStripMenuItem.Text = "Open Hotfix Window"
        '
        'OpenStartupMessageWindowToolStripMenuItem
        '
        Me.OpenStartupMessageWindowToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenStartupMessageWindowToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OpenStartupMessageWindowToolStripMenuItem.Name = "OpenStartupMessageWindowToolStripMenuItem"
        Me.OpenStartupMessageWindowToolStripMenuItem.Size = New System.Drawing.Size(294, 28)
        Me.OpenStartupMessageWindowToolStripMenuItem.Text = "Open Startup Message Window"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(925, 565)
        Me.Controls.Add(Me.pnlCapture)
        Me.Controls.Add(Me.tlpTitle)
        Me.Controls.Add(Me.pnlBottom)
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
        Me.cmsExplorerMenu.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        Me.tlpSeperatorTitle.ResumeLayout(False)
        Me.tlpTitleIcon.ResumeLayout(False)
        Me.pnlCapture.ResumeLayout(False)
        Me.tlpTop.ResumeLayout(False)
        Me.tlpWEIMain.ResumeLayout(False)
        Me.tlpWEI.ResumeLayout(False)
        Me.tlpComponent.ResumeLayout(False)
        Me.tlpWhatIsRated.ResumeLayout(False)
        Me.tlpSubscores.ResumeLayout(False)
        Me.tlpBaseScore.ResumeLayout(False)
        Me.pnlBaseScore.ResumeLayout(False)
        Me.tlpWEITitles.ResumeLayout(False)
        Me.tlpWEITitles.PerformLayout()
        Me.pnlBottom.ResumeLayout(False)
        Me.tlpBottom.ResumeLayout(False)
        Me.pnlShowHardware.ResumeLayout(False)
        Me.tlpHardwareSwitch.ResumeLayout(False)
        Me.pnlValidity.ResumeLayout(False)
        Me.cmsExportMenu.ResumeLayout(False)
        Me.cmsOptionsMenu.ResumeLayout(False)
        Me.cmdToolsMenu.ResumeLayout(False)
        Me.cmsHelpMenu.ResumeLayout(False)
        Me.tlpFormMenu.ResumeLayout(False)
        Me.tlpFormMenu.PerformLayout()
        Me.tlpTitle.ResumeLayout(False)
        Me.cmsDebugMenu.ResumeLayout(False)
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
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblWinVer As System.Windows.Forms.Label
    Friend WithEvents lblLastAssessed As System.Windows.Forms.Label
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdMinimize As System.Windows.Forms.Button
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
    Friend WithEvents cmdOpenOptionsMenu As System.Windows.Forms.Button
    Friend WithEvents cmdOpenHelpMenu As System.Windows.Forms.Button
    Friend WithEvents cmdOpenExportMenu As System.Windows.Forms.Button
    Friend WithEvents pnlCapture As System.Windows.Forms.Panel
    Friend WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents cmdRunAssessmentMain As System.Windows.Forms.Button
    Friend WithEvents lblShowHardware As System.Windows.Forms.Label
    Friend WithEvents pnlShowHardware As System.Windows.Forms.Panel
    Friend WithEvents lblProcessorR As System.Windows.Forms.Label
    Friend WithEvents lblDiskR As System.Windows.Forms.Label
    Friend WithEvents lblMemoryR As System.Windows.Forms.Label
    Friend WithEvents lblGraphicsR As System.Windows.Forms.Label
    Friend WithEvents lblGamingR As System.Windows.Forms.Label
    Friend WithEvents cmdMetrics As System.Windows.Forms.Button
    Friend WithEvents lblScoreData As System.Windows.Forms.Label
    Friend WithEvents BMPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JPGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PNGToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TXTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsExportMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmsOptionsMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SettingsToolstripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImgurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tlpBottom As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlValidity As System.Windows.Forms.Panel
    Friend WithEvents pnlValidityStateColor As System.Windows.Forms.Panel
    Friend WithEvents lblValidity As System.Windows.Forms.Label
    Friend WithEvents tlpWEIMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpSubscores As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpTitleIcon As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlpTop As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlBaseScore As System.Windows.Forms.Panel
    Friend WithEvents ViewLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshScoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdOpenToolsMenu As System.Windows.Forms.Button
    Friend WithEvents cmdToolsMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunVerboseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsHelpMenu As System.Windows.Forms.ContextMenuStrip
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
    Friend WithEvents cmsExplorerMenu As ContextMenuStrip
    Friend WithEvents MinimizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItemExplorer As ToolStripMenuItem
    Friend WithEvents HotfixAvailableToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetPositionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlSplit As Panel
    Friend WithEvents cmdRunInDepth As Button
    Friend WithEvents lblAssessmentDepth As Label
    Friend WithEvents lblShowHToggle As Label
    Friend WithEvents ViewWinSATLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdOpenSettingsTitle As Button
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents SaveResourcesToDiskToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents AcknowledgementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tlpSeperatorTitle As TableLayoutPanel
    Friend WithEvents pnlTitleSeperator As Panel
    Friend WithEvents tlpWEI As TableLayoutPanel
    Friend WithEvents tlpComponent As TableLayoutPanel
    Friend WithEvents tlpWhatIsRated As TableLayoutPanel
    Friend WithEvents tlpBaseScore As TableLayoutPanel
    Friend WithEvents tlpWEITitles As TableLayoutPanel
    Friend WithEvents lblAppVersion As Label
    Friend WithEvents tlpFormMenu As TableLayoutPanel
    Friend WithEvents tlpHardwareSwitch As TableLayoutPanel
    Friend WithEvents swHardware As GambolSwitch
    Friend WithEvents BMACToolstripMenuItem As ToolStripMenuItem
    Friend WithEvents LicenseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tlpTitle As TableLayoutPanel
    Friend WithEvents RestartElevatedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdOpenDebugMenu As Button
    Friend WithEvents cmsDebugMenu As ContextMenuStrip
    Friend WithEvents ThrowUnhandledExceptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ShowToastInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowToastWarningToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowToastErrorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents OpenElevationWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenHotfixWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenStartupMessageWindowToolStripMenuItem As ToolStripMenuItem
End Class
