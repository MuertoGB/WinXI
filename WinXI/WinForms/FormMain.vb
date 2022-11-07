﻿'   Some ContextMenu settings are overriden by Gambol\UI\GambolToolstripRenderer like background color, etc
'   Thanks to https://www.transparenttextures.com/ for the title bar graphics.

'   01.11.2022 - DR - Start to implement elevation changes, UI changes, add debug menu
'   02.11.2022 - DR - Simplify object creation
'   05.11.2022 - DR - Update changelog URL

Imports System.Text
Imports System.Threading.Tasks
Imports System.IO

Imports WinXI.Core
Imports WinXI.Core.Animation
Imports WinXI.Core.Common
Imports WinXI.Core.Helpers
Imports WinXI.Core.System
Imports WinXI.Gambol.Controls
Imports WinXI.Gambol.UI
Imports WinXI.Winsat

Public Class FormMain

#Region "Constructor"

    Public Sub New()

        InitializeComponent()

        SetMainThemeAccent()

        cmsExportMenu.Renderer = New GambolToolstripRenderer
        cmsOptionsMenu.Renderer = New GambolToolstripRenderer
        cmdToolsMenu.Renderer = New GambolToolstripRenderer
        cmsHelpMenu.Renderer = New GambolToolstripRenderer
#If DEBUG Then
        cmsDebugMenu.Renderer = New GambolToolstripRenderer
#End If
        cmsExplorerMenu.Renderer = New GambolToolstripRenderer

        tlpTitle.BackgroundImage = Settings.imgHeaderGraphic

    End Sub

#End Region

#Region "Overriden Properties"

    Const WS_MINIMIZEBOX As Integer = &H20000
    Const CS_DBLCLKS As Integer = &H8
    Const CS_DROP As Integer = &H20000
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim Params As CreateParams = MyBase.CreateParams
            Params.Style = Params.Style Or WS_MINIMIZEBOX
            Params.ClassStyle = Params.ClassStyle Or CS_DBLCLKS Or CS_DROP
            Return Params
        End Get
    End Property

#End Region
#Region "WndProc"

    Private Sub Frame_Move(Sender As Object, e As MouseEventArgs) Handles Me.MouseMove, icnMain.MouseMove, tlpTitleIcon.MouseMove, lblHead.MouseMove, pnlTitle.MouseMove

        If e.Button = MouseButtons.Left Then
            DirectCast(Sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "Frame Buttons"

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Application.Exit()
    End Sub

    Private Sub CmdMinimize_Click(sender As Object, e As EventArgs) Handles cmdMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub CmdSettings_Click(sender As Object, e As EventArgs) Handles cmdOpenSettingsTitle.Click
        Fade.FadeBehindChild(Me)
        Dim F As New FormSettings
        AddHandler F.FormClosing, AddressOf ChildFormClosedNoRefresh
        F.ShowDialog()
    End Sub

#End Region
#Region "KeyDown Events"

    Private Sub FormMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'EXPORT MENU

        'Save as JPG
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.J Then
            JPGToolStripMenuItem.PerformClick()
        End If

        'Save as PNG
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.P Then
            PNGToolStripMenuItem.PerformClick()
        End If

        'Save as BMP
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.B Then
            BMPToolStripMenuItem.PerformClick()
        End If

        'Save as text
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.T Then
            TXTToolStripMenuItem.PerformClick()
        End If

        'Upload Imgur
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.I Then
            ImgurToolStripMenuItem.PerformClick()
        End If
        '------------------------

        'OPTIONS MENU

        'View Imgur Links
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.L Then
            ViewImgurLinksToolStripMenuItem.PerformClick()
        End If

        'View Imgur Links
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.X Then
            ViewLogToolStripMenuItem.PerformClick()
        End If

        'View Imgur Links
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.W Then
            ViewWinSATLogToolStripMenuItem.PerformClick()
        End If

        'Refresh scores
        If My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.ShiftKeyDown And e.KeyCode = Keys.R Then
            RefreshScoresToolStripMenuItem.PerformClick()
        End If

        'Save res
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.R Then
            SaveResourcesToDiskToolStripMenuItem.PerformClick()
        End If

        'Settings
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.S Then
            SettingsToolstripMenuItem.PerformClick()
        End If
        '------------------------

        'TOOLS MENU

        'Cleanup
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.C Then
            ResetToolStripMenuItem.PerformClick()
        End If

        'View System Details
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.D Then
            ViewSystemDetailsToolStripMenuItem.PerformClick()
        End If

        'Rate Normal
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.N Then
            RunToolStripMenuItem.PerformClick()
        End If

        'Rate Verbose
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.V Then
            RunVerboseToolStripMenuItem.PerformClick()
        End If
        '------------------------

        'HELP MENU

        'Media Feature Pack
        If My.Computer.Keyboard.CtrlKeyDown And e.KeyCode = Keys.M Then
            MediaFeaturePackToolStripMenuItem.PerformClick()
        End If

        'Troubleshooting
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.T Then
            TroubleshootingToolStripMenuItem.PerformClick()
        End If

        'Hotfix available
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.H Then
            HotfixAvailableToolStripMenuItem.PerformClick()
        End If

        'Update available
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.U Then
            UpdateAvailableToolStripMenuItem.PerformClick()
        End If

        'Changelog
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.L Then
            ChangelogToolStripMenuItem.PerformClick()
        End If

        'About
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.A Then
            AboutToolStripMenuItem.PerformClick()
        End If

        'Acknowledgements
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.K Then
            AcknowledgementsToolStripMenuItem.PerformClick()
        End If

        'Donate
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.X Then
            BMACToolstripMenuItem.PerformClick()
        End If

        'License
        If My.Computer.Keyboard.AltKeyDown And e.KeyCode = Keys.Z Then
            LicenseToolStripMenuItem.PerformClick()
        End If

    End Sub

#End Region

#Region "Load Event Handler"

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load

#If DEBUG Then
        lblHead.Text &= " (Debug)"
#Else
        cmdDebug.Hide()
#End If

        If Elevation.bIsElevated Then
            RestartElevatedToolStripMenuItem.Dispose()
        End If

        'Hide items that are only shown when needed
        HotfixAvailableToolStripMenuItem.Visible = False

        'Load data to labels
        lblAppVersion.Text = Application.ProductVersion

        Dim strVersion As String = CStr(IIf(WinSystem.IsWin10, WinSystem.BuildBranch, WinSystem.CurrentBuild))
        lblWinVerString.Text = WinSystem.GetProductName & " " & strVersion & " " & WinSystem.GetWindowsBitness

        lblScale.Text = DetermineScaleOf()

        'Load scores
        WinsatReader.GetWinsatSPR()

        'Show hardware
        If Settings.bShowHardwareOnStartup = True Then
            swHardware.Checked = True
        End If

        'UI Update
        UpdateControls()

        'Check notifications
        Task.Factory.StartNew(Sub() CheckNotifications())

    End Sub

    Private Sub CheckNotifications()

        If Settings.bAutoUpdateCheck Then
            If UpdateCheck.IsNewVersionAvailable() Then
                Booleans.bMissingUpdate = True
            End If
        End If

        Invoke(DirectCast(Sub() OnFinishedCheckNotifications(), MethodInvoker))

    End Sub

    Private Sub OnFinishedCheckNotifications()

        If Hotfix.bIsWinSATAffected Then
            Integers.intNotificationCount += 1
            UpdateToolstripHotfixItem()
        End If

        If Booleans.bMissingUpdate Then
            lblAppVersion.BackColor = Color.FromArgb(100, 255, 185, 0)
            Integers.intNotificationCount += 1
            UpdateToolstripUpdateItem()
        End If

        If Not Integers.intNotificationCount = 0 Then
            cmdOpenHelpMenu.ForeColor = Color.White
            cmdOpenHelpMenu.Text += " · " & Integers.intNotificationCount
        End If

    End Sub

#End Region
#Region "Closed Event Handler"

    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Fade.FadeOut(Me)
    End Sub

#End Region

#Region "Theme"
    Friend Sub SetMainThemeAccent()

        Dim TC As Color = Settings.clrThemeColour

        pnlSplit.BackColor = TC

        lblBasescore.ForeColor = TC
        swHardware.CheckedColor = TC

        'Change buttons
        For Each Ctrl As Control In tlpFormMenu.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = TC
        Next

        'Export Menu
        For Each Item As ToolStripItem In cmsExportMenu.Items
            Item.ForeColor = TC
        Next

        'Options Menu
        For Each Item As ToolStripItem In cmsOptionsMenu.Items
            Item.ForeColor = TC
        Next

        'Tools Menu
        For Each Item As ToolStripItem In cmdToolsMenu.Items
            Item.ForeColor = TC
        Next

        'Help Menu
        For Each Item As ToolStripItem In cmsHelpMenu.Items
            Item.ForeColor = TC
        Next

        'Debug Menu
        For Each Item As ToolStripItem In cmsDebugMenu.Items
            Item.ForeColor = TC
        Next

        'Reverse changes to cmsHelp.items if notifications are available
        If Booleans.bMissingHotfix Then
            UpdateToolstripHotfixItem()
        End If
        If Booleans.bMissingUpdate Then
            UpdateToolstripUpdateItem()
        End If

        Settings.SetBorderColor(Me)

    End Sub
#End Region

#Region "Button Event Handlers"
    Private Sub BtnRun_Click(sender As Object, e As EventArgs) Handles cmdRunAssessmentMain.Click
        If Not Power.IsAdapterPluggedIn() Then
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.Warning)
        Else
            If Not Elevation.bIsElevated Then
                RequestElevation()
            Else
                If Settings.bUseVerboseAssessmentMode = True Then
                    Booleans.bAssessmentVerbose = True
                Else
                    Booleans.bAssessmentVerbose = False
                End If

                Fade.FadeBehindChild(Me)
                Dim Frm As New FormAssess
                AddHandler Frm.FormClosed, AddressOf ChildFormClosedRefreshUI
                Frm.ShowDialog()
            End If
        End If

    End Sub
    Private Sub CmdMetrics_Click(sender As Object, e As EventArgs) Handles cmdMetrics.Click

        If WinsatAPI.GetAssessmentValidityInt() = 3 Then
            ToastAlert.Show("The system must be rated to use this feature.", ToastType.Warning)
        Else
            Fade.FadeBehindChild(Me)
            Dim Frm As New FormScoreData
            AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
            Frm.ShowDialog()
        End If

    End Sub
    Private Sub CmdRunInDepth_Click(sender As Object, e As EventArgs) Handles cmdRunInDepth.Click

        If Not Power.IsAdapterPluggedIn() Then
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.Warning)
        Else
            If Not Elevation.bIsElevated Then
                RequestElevation()
            Else
                'Override settings
                Booleans.bAssessmentVerbose = True

                Fade.FadeBehindChild(Me)
                Dim Frm As New FormAssess
                AddHandler Frm.FormClosed, AddressOf ChildFormClosedRefreshUI
                Frm.ShowDialog()
            End If
        End If

    End Sub
#End Region
#Region "Menu Button Event Handlers"

    Private Sub CmdExport_Click(sender As Object, e As EventArgs) Handles cmdOpenExportMenu.Click

        If CDbl(Strings.strBaseScore) = 0 Then
            ToastAlert.Show("The system must be rated to use these features.", ToastType.Warning)
        Else
            Dim ptLowerLeft As New Point(-1, CType(sender, Button).Height)
            ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
            cmsExportMenu.Show(ptLowerLeft)
        End If

    End Sub

    Private Sub CmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOpenOptionsMenu.Click

        Dim ptLowerLeft As New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        cmsOptionsMenu.Show(ptLowerLeft)

    End Sub

    Private Sub CmdTools_Click(sender As Object, e As EventArgs) Handles cmdOpenToolsMenu.Click

        Dim ptLowerLeft As New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        cmdToolsMenu.Show(ptLowerLeft)

    End Sub

    Private Sub CmdHelp_Click(sender As Object, e As EventArgs) Handles cmdOpenHelpMenu.Click

        Dim ptLowerLeft As New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        cmsHelpMenu.Show(ptLowerLeft)

    End Sub

    Private Sub cmdDebug_Click(sender As Object, e As EventArgs) Handles cmdOpenDebugMenu.Click

        Dim ptLowerLeft As New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        cmsDebugMenu.Show(ptLowerLeft)

    End Sub

#End Region
#Region "Gambol Switch Event Handlers"

    Private Sub GswHardware_CheckedChanged(sender As Object, e As EventArgs) Handles swHardware.CheckedChanged
        If CType(sender, GambolSwitch).Checked Then
            lblShowHToggle.Text = "On"
            lblRated.Text = "What is Rated? · System Hardware"
        Else
            lblShowHToggle.Text = "Off"
            lblRated.Text = "What is Rated?"
        End If
        SetHW()
    End Sub

#End Region
#Region "Picturebox Event Handlers"

    Private Sub icnMain_DoubleClick(sender As Object, e As EventArgs) Handles icnMain.DoubleClick
        If Not WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Normal
        End If
        CenterToScreen()
    End Sub

#End Region
#Region "Label Event Handlers"

    Private Sub LabHeadVersion_Click(sender As Object, e As EventArgs) Handles lblAppVersion.Click

        UpdateAvailableToolStripMenuItem.PerformClick()

    End Sub

#End Region

#Region "Context Menu (Export)"

    Private Sub JPGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JPGToolStripMenuItem.Click

        If CDbl(Strings.strBaseScore) = 0 Then
            ToastAlert.Show("You must rate your system first.", ToastType.Warning)
        Else
            EnterPrintMode()
            Dim Sfd As New SaveFileDialog With {
                .FileName = "WinXI-JPG",
                .Filter = "JPEG (*.jpg)|*.jpg",
                .InitialDirectory = Directories.DesktopPath,
                .OverwritePrompt = True
            }
            Try
                If Sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Using Bmap As New Bitmap(pnlCapture.Width, pnlCapture.Height)
                        pnlCapture.DrawToBitmap(Bmap, New Rectangle(Point.Empty, Bmap.Size))
                        Bmap.Save(Sfd.FileName, Imaging.ImageFormat.Jpeg)
                    End Using
                    If File.Exists(Sfd.FileName) Then
                        ToastAlert.Show("Image saved To " & Sfd.FileName, ToastType.Information)
                    End If
                End If
            Catch
                ToastAlert.Show("The image could Not be saved To disk.", ToastType.Critical)
            Finally
                Sfd.Dispose()
            End Try
        End If

        ExitPrintMode()

    End Sub
    Private Sub PNGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PNGToolStripMenuItem.Click

        If CDbl(Strings.strBaseScore) = 0 Then
            ToastAlert.Show("You must rate your system first.", ToastType.Warning)
        Else
            EnterPrintMode()

            Dim Sfd As New SaveFileDialog With {
                   .FileName = "WinXI-PNG",
                   .Filter = "Portable Network Graphics (*.png)|*.png",
                   .InitialDirectory = Directories.DesktopPath,
                   .OverwritePrompt = True
                }

            Try
                If Sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Using Bmap As New Bitmap(pnlCapture.Width, pnlCapture.Height)
                        pnlCapture.DrawToBitmap(Bmap, New Rectangle(Point.Empty, Bmap.Size))
                        Bmap.Save(Sfd.FileName, Imaging.ImageFormat.Png)
                    End Using
                    If File.Exists(Sfd.FileName) Then
                        ToastAlert.Show("Image saved To " & Sfd.FileName, ToastType.Information)
                    End If
                End If
            Catch
                ToastAlert.Show("The image could Not be saved To disk.", ToastType.Critical)
            Finally
                Sfd.Dispose()
            End Try
        End If

        ExitPrintMode()

    End Sub
    Private Sub BMPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BMPToolStripMenuItem.Click

        If CDbl(Strings.strBaseScore) = 0 Then
            ToastAlert.Show("You must rate your system first.", ToastType.Warning)
        Else
            EnterPrintMode()

            Dim Sfd As New SaveFileDialog With {
                .FileName = "WinXI-BMP",
                .Filter = "Bitmap Image File (*.bmp)|*.bmp",
                .InitialDirectory = Directories.DesktopPath,
                .OverwritePrompt = True
            }

            Try
                If Sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Using Bmap As New Bitmap(pnlCapture.Width, pnlCapture.Height)
                        pnlCapture.DrawToBitmap(Bmap, New Rectangle(Point.Empty, Bmap.Size))
                        Bmap.Save(Sfd.FileName, Imaging.ImageFormat.Bmp)
                    End Using
                    If File.Exists(Sfd.FileName) Then
                        ToastAlert.Show("Image saved To " & Sfd.FileName, ToastType.Information)
                    End If
                End If
            Catch
                ToastAlert.Show("The image could Not be saved To disk.", ToastType.Critical)
            Finally
                Sfd.Dispose()
            End Try
        End If

        ExitPrintMode()

    End Sub
    Private Sub TXTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TXTToolStripMenuItem.Click

        If CDbl(Strings.strBaseScore) = 0 Then
            ToastAlert.Show("You must rate your system first.", ToastType.Warning)
        Else
            Dim SBuilder As New StringBuilder
            SBuilder.Append("Windows Experience Index scores generated by WinXI On " & Date.Today & "." & vbNewLine & vbNewLine)
            SBuilder.Append("Base Score: " & lblBasescore.Text & vbNewLine & vbNewLine)

            If Strings.strProcessorScore = Strings.strBaseScore Then
                SBuilder.Append("Processor Score:  " & lblProcessorScore.Text & " (*)" & vbNewLine)
            Else
                SBuilder.Append("Processor Score:  " & lblProcessorScore.Text & vbNewLine)
            End If

            If Strings.strMemoryScore = Strings.strBaseScore Then
                SBuilder.Append("Memory Score:     " & lblMemoryScore.Text & " (*)" & vbNewLine)
            Else
                SBuilder.Append("Memory Score:     " & lblMemoryScore.Text & vbNewLine)
            End If

            If Strings.strGraphicsScore = Strings.strBaseScore Then
                SBuilder.Append("Graphics Score:   " & lblGraphicsScore.Text & " (*)" & vbNewLine)
            Else
                SBuilder.Append("Graphics Score:   " & lblGraphicsScore.Text & vbNewLine)
            End If

            If Strings.strD3dScore = Strings.strBaseScore Then
                SBuilder.Append("Gaming Score:     " & lblGamingScore.Text & " (*)" & vbNewLine)
            Else
                SBuilder.Append("Gaming Score:     " & lblGamingScore.Text & vbNewLine)
            End If

            If Strings.strDiskScore = Strings.strBaseScore Then
                SBuilder.Append("Disk Score:       " & lblDiskScore.Text & " (*)" & vbCrLf & vbCrLf)
            Else
                SBuilder.Append("Disk Score:       " & lblDiskScore.Text & vbCrLf & vbCrLf)
            End If

            SBuilder.Append("(*) - Lowest subscore")

            Dim Sfd As New SaveFileDialog With {
                .FileName = "WinXI-Scores",
                .Filter = "Text File (*.txt)|*.txt",
                .InitialDirectory = Directories.DesktopPath,
                .OverwritePrompt = True
            }

            Try
                If Sfd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    My.Computer.FileSystem.WriteAllText(Sfd.FileName, SBuilder.ToString, False)
                    If File.Exists(Sfd.FileName) Then
                        ToastAlert.Show("File saved to " & Sfd.FileName.ToString, ToastType.Information)
                    End If
                End If
            Catch Ex As Exception
                ToastAlert.Show("Could not save scores to a text file.", ToastType.Warning)
                Throw
            Finally
                Sfd.Dispose()
            End Try

        End If

    End Sub
    Private Sub ImgurToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImgurToolStripMenuItem.Click

        CType(sender, ToolStripMenuItem).Enabled = False

        If Strings.strImgurClientID.Length = 0 Then
            ToastAlert.Show("Imgur API client key needed.", ToastType.Warning)
        Else
            If CDbl(Strings.strBaseScore) = 0 Then 'Unrated system
                ToastAlert.Show("You must rate your system first.", ToastType.Warning)
            Else 'Check imgur is online
                If Network.IsWebsiteAvailable(Strings.strImgurUrl) Then

                    'Enter printscreen mode
                    EnterPrintMode()

                    'Capture image to upload
                    ImageHelper.CaptureControl(Files.TemporaryImgurFile, pnlCapture)

                    ' // Imgur Api moved to Core\Helpers\ImageHelper > PostToImgur
                    If Settings.bUseCustomImgurApiKey = True Then
                        UploadCustomClient()
                    Else
                        UploadNormalClient()
                    End If

                Else 'No connection to Imgur
                    ToastAlert.Show("Could not connect to Imgur. The service may be unavailable.", ToastType.Warning)
                End If
            End If
        End If

        'Finish up
        ExitPrintMode()

        CType(sender, ToolStripMenuItem).Enabled = True

    End Sub

    Private Sub UploadCustomClient()

        Dim exitCode As Integer = ImgurApi.UploadToImgur(Files.TemporaryImgurFile, Settings.strImgurUrlsPath, Settings.strCustomImgurApiKeyString, True, True, True)

        If exitCode = 1 Then
            ToastAlert.Show("File uploaded to Imgur.", ToastType.Information)
        Else
            ToastAlert.Show("Could not upload image to Imgur's database. If you're using a custom Client ID it may be incorrect.", ToastType.Critical)
        End If

    End Sub

    Private Sub UploadNormalClient()

        Dim exitCode As Integer = ImgurApi.UploadToImgur(Files.TemporaryImgurFile, Settings.strImgurUrlsPath, Strings.strImgurClientID, True, True, True)

        If exitCode = 1 Then
            ToastAlert.Show("File uploaded to Imgur.", ToastType.Information)
        Else
            ToastAlert.Show("Could not upload image to Imgur's database. If you're using a custom Client ID it may be incorrect.", ToastType.Critical)
        End If

    End Sub

#End Region
#Region "Context Menu (Options)"

    Private Sub ViewLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLogToolStripMenuItem.Click

        Try
            If File.Exists(Settings.strAssessmentLogPath) Then
                Process.Start(Settings.strAssessmentLogPath)
            Else
                ToastAlert.Show("The assessment log file has not been created. It will be available after rating your system at least once.", ToastType.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub ViewImgurLinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewImgurLinksToolStripMenuItem.Click

        Try
            If File.Exists(Settings.strImgurUrlsPath) Then
                Process.Start(Settings.strImgurUrlsPath)
            Else
                ToastAlert.Show("The Imgur link file has not been created. It will be available after you upload a valid system rating.", ToastType.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub ViewWinSATLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewWinSATLogToolStripMenuItem.Click

        Try
            If File.Exists(Files.WinsatLog) Then
                Process.Start(Files.WinsatLog)
            Else
                ToastAlert.Show("The winsat.log file does not exist.", ToastType.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub RefreshScoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshScoresToolStripMenuItem.Click

        If WinsatAPI.GetAssessmentValidityInt() = 3 Then
            ToastAlert.Show("The system must be rated to use this option.", ToastType.Warning)
        Else
            WinsatReader.GetWinsatSPR()
            UpdateControls()
            ToastAlert.Show("System scores reloaded.", ToastType.Information)
        End If

    End Sub

    Private Sub SaveResourcesToDIskToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveResourcesToDiskToolStripMenuItem.Click

        Dim FBD As New FolderBrowserDialog With {
        .RootFolder = Environment.SpecialFolder.Desktop,
        .ShowNewFolderButton = True,
        .Description = "Choose a path..."
        }

        If FBD.ShowDialog = DialogResult.OK Then
            File.WriteAllBytes(Path.Combine(FBD.SelectedPath, "Windows6_1_KB2687862_x86.msu"), My.Resources.Windows6_1_KB2687862_x86)
            File.WriteAllBytes(Path.Combine(FBD.SelectedPath, "Windows6_1_KB2687862_x64.msu"), My.Resources.Windows6_1_KB2687862_x64)
            File.WriteAllBytes(Path.Combine(FBD.SelectedPath, "segoeui.ttf"), My.Resources.segoeui)
            File.WriteAllBytes(Path.Combine(FBD.SelectedPath, "segoeuib.ttf"), My.Resources.segoeuib)
            File.WriteAllBytes(Path.Combine(FBD.SelectedPath, "seguisb.ttf"), My.Resources.seguisb)
            File.WriteAllBytes(Path.Combine(FBD.SelectedPath, "segmdl2.ttf"), My.Resources.segmdl2)
            ToastAlert.Show("Resources saved to " & FBD.SelectedPath & ".", ToastType.Information)
        End If

    End Sub

    Private Sub SettingsToolstripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolstripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim Frm As New FormSettings
        AddHandler Frm.FormClosing, AddressOf ChildFormClosedNoRefresh
        Frm.ShowDialog()

    End Sub

#End Region
#Region "Context Menu (Tools)"

    Private Sub CleanupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim F As New FormReset
        AddHandler F.FormClosing, AddressOf ChildFormClosedNoRefresh
        F.ShowDialog()

    End Sub

    Private Sub ViewSystemDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSystemDetailsToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim F As New FormSystem
        AddHandler F.FormClosing, AddressOf ChildFormClosedNoRefresh
        F.ShowDialog()

    End Sub

    Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunToolStripMenuItem.Click

        If Not Power.IsAdapterPluggedIn() Then
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.Warning)
        Else
            If Not Elevation.bIsElevated Then
                RequestElevation()
            Else
                'Override settings
                Booleans.bAssessmentVerbose = False

                Fade.FadeBehindChild(Me)
                Dim Frm As New FormAssess
                AddHandler Frm.FormClosed, AddressOf ChildFormClosedRefreshUI
                Frm.ShowDialog()
            End If
        End If

    End Sub

    Private Sub RunVerboseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunVerboseToolStripMenuItem.Click

        If Not Power.IsAdapterPluggedIn() Then
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.Warning)
        Else
            If Not Elevation.bIsElevated Then
                RequestElevation()
            Else
                'Override settings
                Booleans.bAssessmentVerbose = True

                Fade.FadeBehindChild(Me)
                Dim Frm As New FormAssess
                AddHandler Frm.FormClosed, AddressOf ChildFormClosedRefreshUI
                Frm.ShowDialog()
            End If
        End If

    End Sub

#End Region
#Region "Context Menu (Help)"

    Private Sub MediaFeaturePackToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MediaFeaturePackToolStripMenuItem.Click
        Process.Start(Strings.strMediaFeatureUrl)
    End Sub

    Private Sub TroubleshootingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TroubleshootingToolStripMenuItem.Click

        MessageBox.Show("Troubleshooting todo.")

    End Sub

    Private Sub HotfixAvaiableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HotfixAvailableToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim Frm As New FormHotfix
        AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
        Frm.ShowDialog()

    End Sub

    Private Sub CheckForUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAvailableToolStripMenuItem.Click

        If Network.IsWebsiteAvailable(Strings.strHomeUrl) Then
            Fade.FadeBehindChild(Me)

            Dim Frm As New FormUpdate
            AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
            Frm.ShowDialog()
        Else
            ToastAlert.Show("Network disconnected, or Github could not be reached.", ToastType.Critical)
        End If

    End Sub

    Private Sub ChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click

        Process.Start(Strings.strChangelogUrl)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim Frm As New FormAbout
        AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
        Frm.ShowDialog()

    End Sub

    Private Sub AcknowledgementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcknowledgementsToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim Frm As New FormAcknowledgements
        AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
        Frm.ShowDialog()

    End Sub

    Private Sub DonatoToolstripMenuItem_Click(sender As Object, e As EventArgs) Handles BMACToolstripMenuItem.Click

        Process.Start("https://buymeacoffee.com/Muerto")

    End Sub

    Private Sub LicenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LicenseToolStripMenuItem.Click

        Process.Start("https://github.com/MuertoGB/WinXI/blob/main/LICENSE")

    End Sub

#End Region
#Region "Context Menu (Debug)"

    Private Sub ThrowUnhandledExceptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThrowUnhandledExceptionToolStripMenuItem.Click
        Process.Start("sohowdoyouplanonsavingtheworld?")
    End Sub

    Private Sub ShowToastInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToastInfoToolStripMenuItem.Click
        ToastAlert.Show("This is an informational message", ToastType.Information)
    End Sub

    Private Sub ShowToastWarningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToastWarningToolStripMenuItem.Click
        ToastAlert.Show("This is a warning message", ToastType.Warning)
    End Sub

    Private Sub ShowToastErrorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToastErrorToolStripMenuItem.Click
        ToastAlert.Show("This is an error message", ToastType.Critical)
    End Sub

    Private Sub OpenElevationWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenElevationWindowToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim F As New FormElevate
        AddHandler F.FormClosing, AddressOf ChildFormClosedNoRefresh
        F.ShowDialog()

    End Sub

    Private Sub OpenHotfixWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenHotfixWindowToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim F As New FormHotfix
        AddHandler F.FormClosing, AddressOf ChildFormClosedNoRefresh
        F.ShowDialog()

    End Sub

    Private Sub OpenStartupMessageWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenStartupMessageWindowToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim F As New FormStartupMessage
        AddHandler F.FormClosing, AddressOf ChildFormClosedNoRefresh
        F.ShowDialog()

    End Sub

#End Region
#Region "Context Menu (Application)"

    Private Sub MinimizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizeToolStripMenuItem.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ResetPositionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetPositionToolStripMenuItem.Click
        CenterToScreen()
    End Sub

    Private Sub ResetApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartApplicationToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub RestartElevatedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartElevatedToolStripMenuItem.Click
        Elevation.RestartElevated()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItemExplorer_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItemExplorer.Click

        Fade.FadeBehindChild(Me)

        Dim Frm As New FormAbout
        AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
        Frm.ShowDialog()

    End Sub

#End Region

#Region "Routines"

    Friend Shared Function DetermineScaleOf() As String

        Dim strDefault As String = "The Experience Index assesses key system components."

        Select Case WinSystem.fviKernelVersion.ProductMajorPart
            Case 6
                If WinSystem.fviKernelVersion.ProductMinorPart = 0 Then : Return "The Experience Index assesses key system components on a scale of 1.0 to 5.9." : End If 'Vista
                If WinSystem.fviKernelVersion.ProductMinorPart = 1 Then : Return "The Experience Index assesses key system components on a scale of 1.0 to 7.9." : End If '7
                If WinSystem.fviKernelVersion.ProductMinorPart > 1 Then : Return "The Experience Index assesses key system components on a scale of 1.0 to 9.9." : End If '8, 8.1
            Case 10
                Return "The Experience Index assesses key system components on a scale of 1.0 to 9.9." '10
            Case Else
                Return strDefault
        End Select

        Return strDefault

    End Function

    Private Sub EnterPrintMode()

        cmdRunAssessmentMain.Hide()

        If WinSystem.IsWin10 Then
            lblScale.Text = "WinXI v" & Application.ProductVersion & " on " & WinSystem.GetProductName() & " · " & WinSystem.CurrentBuild() & " · " _
                & WinSystem.BuildBranch() & " · " & WinSystem.GetWindowsBitness
        Else
            lblScale.Text = "WinXI v" & Application.ProductVersion & " on " & WinSystem.GetProductName() & " · " _
                & WinSystem.GetWindowsBuildLab() & " · " & WinSystem.GetWindowsBitness()
        End If

    End Sub

    Private Sub ExitPrintMode()
        cmdRunAssessmentMain.Show()
        lblScale.Text = DetermineScaleOf()
    End Sub

    Private Sub ChildFormClosedRefreshUI(ByVal sender As Object, ByVal e As EventArgs)
        Fade.RefadeIn(Me)
        WinsatReader.GetWinsatSPR()
        UpdateControls()
    End Sub

    Private Sub ChildFormClosedNoRefresh(ByVal sender As Object, e As EventArgs)
        Fade.RefadeIn(Me)
    End Sub

    Friend Sub UpdateControls()

        'Check assessment validity
        lblValidityString.Text = WinsatState.ConvertAssessmentState(WinsatAPI.GetAssessmentValidityInt())
        cmdRunAssessmentMain.Text = WinsatState.GenerateRunStateText

        If WinsatAPI.GetAssessmentValidityInt() = 1 Then : lblBasescore.ForeColor = Settings.clrThemeColour : pnlValidityStateColor.BackColor = Colors.clrValid
        Else : lblBasescore.ForeColor = Colors.clrBaseScoreUnrated : pnlValidityStateColor.BackColor = Colors.clrInvalid
        End If

        'Check CPU score against Base score
        If Strings.strProcessorScore = Strings.strBaseScore Then : lblProcessorScore.BackColor = Colors.clrPanelActive : lblProcessorScore.ForeColor = Settings.clrThemeColour
        Else : lblProcessorScore.BackColor = Colors.clrPanelNormal : lblProcessorScore.ForeColor = Color.White
        End If

        'Check Memory score against Base score
        If Strings.strMemoryScore = Strings.strBaseScore Then : lblMemoryScore.BackColor = Colors.clrPanelActive : lblMemoryScore.ForeColor = Settings.clrThemeColour
        Else : lblMemoryScore.BackColor = Colors.clrPanelNormal : lblMemoryScore.ForeColor = Color.White
        End If

        'Check Graphics Score against Base score
        If Strings.strGraphicsScore = Strings.strBaseScore Then : lblGraphicsScore.BackColor = Colors.clrPanelActive : lblGraphicsScore.ForeColor = Settings.clrThemeColour
        Else : lblGraphicsScore.BackColor = Colors.clrPanelNormal : lblGraphicsScore.ForeColor = Color.White
        End If

        'Check Gaming score against Base score
        If Strings.strD3dScore = Strings.strBaseScore Then : lblGamingScore.BackColor = Colors.clrPanelActive : lblGamingScore.ForeColor = Settings.clrThemeColour
        Else : lblGamingScore.BackColor = Colors.clrPanelNormal : lblGamingScore.ForeColor = Color.White
        End If

        'Check Disk score against Base score
        If Strings.strDiskScore = Strings.strBaseScore Then : lblDiskScore.BackColor = Colors.clrPanelActive : lblDiskScore.ForeColor = Settings.clrThemeColour
        Else : lblDiskScore.BackColor = Colors.clrPanelNormal : lblDiskScore.ForeColor = Color.White
        End If

        'Determine last assessment date
        Strings.strLastAssessDate = Format(WinsatAPI.GetWinsatLastUpdateDate(), "dddd, MMM d yyyy hh:mm tt")
        If (Strings.strLastAssessDate.Length = 0) Or Strings.strLastAssessDate.Contains("1999") Then
            lblLastAssessedString.Text = "Never"
        Else
            lblLastAssessedString.Text = Strings.strLastAssessDate
        End If

        'Hardware switch
        If swHardware.Checked Then
            lblShowHToggle.Text = "On"
        Else
            lblShowHToggle.Text = "Off"
        End If

        'Pass score strings to UI
        lblBasescore.Text = Strings.strBaseScore
        lblProcessorScore.Text = Strings.strProcessorScore
        lblMemoryScore.Text = Strings.strMemoryScore
        lblGraphicsScore.Text = Strings.strGraphicsScore
        lblGamingScore.Text = Strings.strD3dScore
        lblDiskScore.Text = Strings.strDiskScore

        If Strings.strBaseScore = "0" Or Strings.strBaseScore = Nothing Then
            lblBasescore.Text = "0.0"
        End If

        SetSwitchState()
        LoadHardwareStrings()

    End Sub

    Private Sub SetSwitchState()
        If Not WinsatAPI.GetAssessmentValidityInt() = 3 Then
            swHardware.Enabled = True
        Else
            swHardware.Checked = False : swHardware.Enabled = False
        End If
    End Sub

    Public Shared Sub LoadHardwareStrings()
        If Settings.bUseApiHardwareMode = True Then
            WinsatReader.ReadAPIHardware()
        Else
            WinsatReader.ReadXMLHardware()
        End If
    End Sub

    Public Sub SetHW()

        LoadHardwareStrings()

        If swHardware.Checked Then
            lblProcessorR.Text = Strings.strProcessorHardware.Replace("(R)", "®").Replace("(TM)", "™")
            lblMemoryR.Text = Strings.strMemoryHardware
            lblGraphicsR.Text = Strings.strGraphicsHardware.Replace("(R)", "®").Replace("(TM)", "™")
            lblGamingR.Text = Strings.strD3dHardware
            lblDiskR.Text = Strings.strDiskHardware
        Else
            lblProcessorR.Text = Strings.strProcessorText
            lblMemoryR.Text = Strings.strMemoryText
            lblGraphicsR.Text = Strings.strGraphicsText
            lblGamingR.Text = Strings.strD3dText
            lblDiskR.Text = Strings.strDiskText
        End If

    End Sub

    Private Sub UpdateToolstripHotfixItem()
        HotfixAvailableToolStripMenuItem.Visible = True
        HotfixAvailableToolStripMenuItem.ForeColor = Color.White
        HotfixAvailableToolStripMenuItem.Text = "Hotfix Available"
        HotfixAvailableToolStripMenuItem.Font = New Font("Segoe UI Semibold", 10) 'Cannot call SemiBold from FontStyle, be explicit.
    End Sub

    Private Sub UpdateToolstripUpdateItem()
        UpdateAvailableToolStripMenuItem.Visible = True
        UpdateAvailableToolStripMenuItem.ForeColor = Color.White
        UpdateAvailableToolStripMenuItem.Text = "Download Update"
        UpdateAvailableToolStripMenuItem.Font = New Font("Segoe UI Semibold", 10) 'Cannot call SemiBold from FontStyle, be explicit.
    End Sub

    Friend Sub HotfixWasInstalled()

        HotfixAvailableToolStripMenuItem.Visible = False

        Integers.intNotificationCount -= 1

        If Not Integers.intNotificationCount = 0 Then
            cmdOpenHelpMenu.Text = "Help · " & Integers.intNotificationCount
        Else
            cmdOpenHelpMenu.ForeColor = Color.White
            cmdOpenHelpMenu.Text = "Help"
        End If

    End Sub

    Private Sub RequestElevation()

        If Not Elevation.bIsElevated Then
            Fade.FadeBehindChild(Me)
            Dim Frm As New FormElevate
            AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
            Frm.ShowDialog()
        End If

    End Sub

#End Region
#Region "Misc design"

    Private Sub GSwitchHardware_MouseEnter(sender As Object, e As EventArgs) Handles swHardware.MouseEnter
        lblShowHToggle.BackColor = Colors.clrCtrlHovered
    End Sub

    Private Sub GSwitchHardware_MouseLeave(sender As Object, e As EventArgs) Handles swHardware.MouseLeave
        lblShowHToggle.BackColor = Colors.clrCtrlLeave
    End Sub

    Private Sub FormMain_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Dim Clr As Color = Colors.clrFormDeactivated
        lblHead.ForeColor = Clr
        cmdOpenSettingsTitle.ForeColor = Clr
        cmdMinimize.ForeColor = Clr
        cmdClose.ForeColor = Clr
    End Sub

    Private Sub FormActivate_GotFocus(sender As Object, e As EventArgs) Handles Me.Activated
        Dim Clr As Color = Colors.clrFormActivated
        lblHead.ForeColor = Color.White
        cmdOpenSettingsTitle.ForeColor = Clr
        cmdMinimize.ForeColor = Clr
        cmdClose.ForeColor = Clr
    End Sub

#End Region

End Class