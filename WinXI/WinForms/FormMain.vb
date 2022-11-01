'   Some ContextMenu settings are overriden by Gambol\UI\GambolToolstripRenderer like background color, etc
'   15.04.2020 - DR - Add assessment overrides based on selection
'   29.05.2020 - DR - Fixed Win32Exceptions
'   04.04.2021 - DR - Cleaned up system info string on export of scores as image, switch os info buildid to buildlab
'   01.11.2022 - DR - Start to implement elevation changes, UI changes, add debug menu

'  Thanks to https://www.transparenttextures.com/ for the title bar graphics.

Imports System.Text
Imports System.Threading.Tasks
Imports System.IO

Imports WinXI.Core.Animation
Imports WinXI.Core.Common
Imports WinXI.Core.Helpers
Imports WinXI.Core.System
Imports WinXI.Gambol.Controls
Imports WinXI.Gambol.UI
Imports WinXI.Winsat
Imports WinXI.Core

Public Class FormMain

    Public Sub New()

        InitializeComponent()

        SetMainThemeAccent()

        CmsExport.Renderer = New GambolToolstripRenderer
        CmsOptions.Renderer = New GambolToolstripRenderer
        CmsTools.Renderer = New GambolToolstripRenderer
        cmsHelp.Renderer = New GambolToolstripRenderer
#If DEBUG Then
        cmsDebug.Renderer = New GambolToolstripRenderer
#End If
        CmsExplorer.Renderer = New GambolToolstripRenderer

        TlpMain.BackgroundImage = Settings.SetHeaderGraphic

    End Sub

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

    Private Sub Frame_Move(Sender As Object, e As MouseEventArgs) Handles Me.MouseMove, icnMain.MouseMove, TlpHeadImage.MouseMove, lblHead.MouseMove, PanHead.MouseMove

        If e.Button = MouseButtons.Left Then
            DirectCast(Sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "Frame Buttons"

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Application.Exit()
    End Sub

    Private Sub CmdMinimize_Click(sender As Object, e As EventArgs) Handles CmdMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub CmdSettings_Click(sender As Object, e As EventArgs) Handles CmdSettings.Click
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
        'Donate
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

        If Booleans.bIsElevated Then
            cmdElevate.Hide()
            RestartElevatedToolStripMenuItem.Dispose()
        End If

        'Hide items that are only shown when needed
        HotfixAvailableToolStripMenuItem.Visible = False

        'Load data to labels
        lblAppVersion.Text = Program.X_Version

        Dim strVersion As String = CStr(IIf(WinSystem.IsWin10, WinSystem.BuildBranch, WinSystem.CurrentBuild))
        lblWinVerString.Text = WinSystem.GetName & " " & strVersion & " " & WinSystem.GetWindowsBitness

        lblScale.Text = DetermineScaleOf()

        'Load scores
        WinsatReader.GetWinsatSPR()

        'Show hardware
        If Settings.ShowHardwareOnStartup = True Then
            swHardware.Checked = True
        End If

        'UI Update
        UpdateControls()

        'Check notifications
        Task.Factory.StartNew(Sub() CheckNotifications())

    End Sub

    Private Sub CheckNotifications()

        'Updated 07.10.2019
        'All hotfixes are loaded from WMI into a data array which can be referenced 3x faster with less overhead.
        'This means we're not iterating through every hotfix in WMI multiple times. Good news for slower processors.
        Dim ListOfUpdates As HashSet(Of String) = Knowledgebase.EnumerateHotfixes

        'Moved from Program.vb. Holds back spawn time on Win7.
        If WinSystem.IsWin7() Then
            'Check convenience rollup KB3125574
            If Not ListOfUpdates.Contains("KB3125574") Then 'Rollup missing, so...
                'Check for older patch KB2687862
                If Not ListOfUpdates.Contains("KB2687862") Then
                    Booleans.bMissingHotfix = True 'Still missing
                Else
                    Booleans.bMissingHotfix = False 'Installed
                End If
            Else
                Booleans.bMissingHotfix = False 'Installed
            End If
        End If

        If Settings.UpdateAutoCheck Then
            If CheckForUpdate.IsNewVersionAvailable() Then
                Booleans.bMissingUpdate = True
            End If
        End If

        Invoke(DirectCast(Sub() OnFinishedCheckNotifications(), MethodInvoker))

    End Sub

    Private Sub OnFinishedCheckNotifications()

        If Booleans.bMissingHotfix Then
            Integers.NotificationCount += 1
            UpdateToolstripHotfixItem()
        End If

        If Booleans.bMissingUpdate Then
            lblAppVersion.BackColor = Color.FromArgb(100, 255, 185, 0)
            Integers.NotificationCount += 1
            UpdateToolstripUpdateItem()
        End If

        If Not Integers.NotificationCount = 0 Then
            CmdHelp.ForeColor = Color.White
            CmdHelp.Text += " · " & Integers.NotificationCount
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

        Dim TC As Color = Settings.SetThemeColour

        PanSplit.BackColor = TC

        lblBasescore.ForeColor = TC
        swHardware.CheckedColor = TC

        'Change buttons
        For Each Ctrl As Control In TlpMenu.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = TC
        Next

        'Export Menu
        For Each Item As ToolStripItem In CmsExport.Items
            Item.ForeColor = TC
        Next

        'Options Menu
        For Each Item As ToolStripItem In CmsOptions.Items
            Item.ForeColor = TC
        Next

        'Tools Menu
        For Each Item As ToolStripItem In CmsTools.Items
            Item.ForeColor = TC
        Next

        'Help Menu
        For Each Item As ToolStripItem In cmsHelp.Items
            Item.ForeColor = TC
        Next

        'Debug Menu
        For Each Item As ToolStripItem In cmsDebug.Items
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
    Private Sub BtnRun_Click(sender As Object, e As EventArgs) Handles CmdAssess.Click
        If Not Power.IsAdapterPluggedIn() Then
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.Warning)
        Else
            If Not Booleans.bIsElevated Then
                RequestElevation()
            Else
                If Settings.UseVerboseAssessmentMode = True Then
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
            Dim Frm As New FormMetrics
            AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
            Frm.ShowDialog()
        End If

    End Sub
    Private Sub CmdRunInDepth_Click(sender As Object, e As EventArgs) Handles CmdRunInDepth.Click



        If Not Power.IsAdapterPluggedIn() Then
            ToastAlert.Show("WinSAT cannot run on battery power. Insert your power adapter to continue.", ToastType.Warning)
        Else
            If Not Booleans.bIsElevated Then
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
    Private Sub CmdExport_Click(sender As Object, e As EventArgs) Handles CmdExport.Click

        If CDbl(Strings.BaseScore) = 0 Then
            ToastAlert.Show("The system must be rated to use these features.", ToastType.Warning)
        Else
            Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
            ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
            CmsExport.Show(ptLowerLeft)
        End If

    End Sub
    Private Sub CmdOptions_Click(sender As Object, e As EventArgs) Handles CmdOptions.Click

        Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        CmsOptions.Show(ptLowerLeft)

    End Sub
    Private Sub CmdTools_Click(sender As Object, e As EventArgs) Handles CmdTools.Click

        Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        CmsTools.Show(ptLowerLeft)

    End Sub
    Private Sub CmdHelp_Click(sender As Object, e As EventArgs) Handles CmdHelp.Click

        Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        cmsHelp.Show(ptLowerLeft)

    End Sub
    Private Sub cmdDebug_Click(sender As Object, e As EventArgs) Handles cmdDebug.Click

        Dim ptLowerLeft As Point = New Point(-1, CType(sender, Button).Height)
        ptLowerLeft = CType(sender, Button).PointToScreen(ptLowerLeft)
        cmsDebug.Show(ptLowerLeft)

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

        If Booleans.bMissingUpdate Then
            Fade.FadeBehindChild(Me)

            Dim FUpdate As New FormUpdate
            AddHandler FUpdate.FormClosed, AddressOf ChildFormClosedNoRefresh
            FUpdate.ShowDialog()
        Else
            Booleans.bShowLicense = False
            Fade.FadeBehindChild(Me)

            Dim Frm As New FormTextDialog
            AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
            Frm.ShowDialog()
        End If

    End Sub

#End Region

#Region "Context Menu (Export)"

    Private Sub JPGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JPGToolStripMenuItem.Click

        If CDbl(Strings.BaseScore) = 0 Then
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
                    Using Bmap As New Bitmap(PanCapture.Width, PanCapture.Height)
                        PanCapture.DrawToBitmap(Bmap, New Rectangle(Point.Empty, Bmap.Size))
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

        If CDbl(Strings.BaseScore) = 0 Then
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
                    Using Bmap As New Bitmap(PanCapture.Width, PanCapture.Height)
                        PanCapture.DrawToBitmap(Bmap, New Rectangle(Point.Empty, Bmap.Size))
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

        If CDbl(Strings.BaseScore) = 0 Then
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
                    Using Bmap As New Bitmap(PanCapture.Width, PanCapture.Height)
                        PanCapture.DrawToBitmap(Bmap, New Rectangle(Point.Empty, Bmap.Size))
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

        If CDbl(Strings.BaseScore) = 0 Then
            ToastAlert.Show("You must rate your system first.", ToastType.Warning)
        Else
            Dim SBuilder As New StringBuilder
            SBuilder.Append("Windows Experience Index scores generated by WinXI On " & Date.Today & "." & vbNewLine & vbNewLine)
            SBuilder.Append("Base Score: " & lblBasescore.Text & vbNewLine & vbNewLine)

            If Strings.ProcessorScore = Strings.BaseScore Then
                SBuilder.Append("Processor Score:  " & lblProcessorScore.Text & " (*)" & vbNewLine)
            Else
                SBuilder.Append("Processor Score:  " & lblProcessorScore.Text & vbNewLine)
            End If

            If Strings.MemoryScore = Strings.BaseScore Then
                SBuilder.Append("Memory Score:     " & lblMemoryScore.Text & " (*)" & vbNewLine)
            Else
                SBuilder.Append("Memory Score:     " & lblMemoryScore.Text & vbNewLine)
            End If

            If Strings.GraphicsScore = Strings.BaseScore Then
                SBuilder.Append("Graphics Score:   " & lblGraphicsScore.Text & " (*)" & vbNewLine)
            Else
                SBuilder.Append("Graphics Score:   " & lblGraphicsScore.Text & vbNewLine)
            End If

            If Strings.D3DScore = Strings.BaseScore Then
                SBuilder.Append("Gaming Score:     " & lblGamingScore.Text & " (*)" & vbNewLine)
            Else
                SBuilder.Append("Gaming Score:     " & lblGamingScore.Text & vbNewLine)
            End If

            If Strings.DiskScore = Strings.BaseScore Then
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

        If Strings.ImgurClientID.Length = 0 Then
            ToastAlert.Show("Imgur API client key needed.", ToastType.Warning)
        Else
            If CDbl(Strings.BaseScore) = 0 Then 'Unrated system
                ToastAlert.Show("You must rate your system first.", ToastType.Warning)
            Else 'Check imgur is online
                If Network.IsWebsiteAvailable(Strings.ImgurUrl) Then

                    'Enter printscreen mode
                    EnterPrintMode()

                    'Capture image to upload
                    ImageHelper.CaptureControl(Files.TemporaryImgurFile, PanCapture)

                    ' // Imgur Api moved to Core\Helpers\ImageHelper > PostToImgur
                    If Settings.UseCustomImgurApiKey = True Then
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

        Dim exitCode As Integer = ImgurApi.PostToImgur(Files.TemporaryImgurFile, Settings.ImgurUrlsPath, Settings.CustomImgurApiKeyString, True, True, True)

        If exitCode = 1 Then
            ToastAlert.Show("File uploaded to Imgur.", ToastType.Information)
        Else
            ToastAlert.Show("Could not upload image to Imgur's database. If you're using a custom Client ID it may be incorrect.", ToastType.Critical)
        End If

    End Sub

    Private Sub UploadNormalClient()

        Dim exitCode As Integer = ImgurApi.PostToImgur(Files.TemporaryImgurFile, Settings.ImgurUrlsPath, Strings.ImgurClientID, True, True, True)

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
            If File.Exists(Settings.AssessmentLogPath) Then
                Process.Start(Settings.AssessmentLogPath)
            Else
                ToastAlert.Show("The assessment log file has not been created. It will be available after rating your system at least once.", ToastType.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub
    Private Sub ViewImgurLinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewImgurLinksToolStripMenuItem.Click

        Try
            If File.Exists(Settings.ImgurUrlsPath) Then
                Process.Start(Settings.ImgurUrlsPath)
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
            If Not Booleans.bIsElevated Then
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
            If Not Booleans.bIsElevated Then
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
        Process.Start(Strings.MediaFeatureUrl)
    End Sub
    Private Sub TroubleshootingToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TroubleshootingToolStripMenuItem.Click

        Try
            Dim Proc As New Process
            Dim TempFile As String = Directories.TempFilesPath & "\Troubleshooting.rtf"

            Dim Buffer As Byte() = Encoding.UTF8.GetBytes(My.Resources.troubleshooting)

            File.WriteAllBytes(TempFile, Buffer)

            If File.Exists(TempFile) = True Then
                With Proc.StartInfo
                    .FileName = TempFile
                    .UseShellExecute = True
                    .WindowStyle = ProcessWindowStyle.Maximized
                End With
                Proc.Start()
            End If
        Catch ex As IOException
            ToastAlert.Show("Troubleshooting is already open.", ToastType.Information)
        End Try

    End Sub
    Private Sub HotfixAvaiableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HotfixAvailableToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim Frm As New FormHotfix
        AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
        Frm.ShowDialog()

    End Sub
    Private Sub CheckForUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateAvailableToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim Frm As New FormUpdate
        AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
        Frm.ShowDialog()

    End Sub
    Private Sub ChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click

        Booleans.bShowLicense = False

        Fade.FadeBehindChild(Me)

        Dim Frm As New FormTextDialog
        AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
        Frm.ShowDialog()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim Frm As New FormAbout
        AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
        Frm.ShowDialog()

    End Sub

    Private Sub AcknowledgementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcknowledgementsToolStripMenuItem.Click

        Fade.FadeBehindChild(Me)

        Dim Frm As New FormAckn
        AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
        Frm.ShowDialog()

    End Sub

    Private Sub DonatoToolstripMenuItem_Click(sender As Object, e As EventArgs) Handles BMACToolstripMenuItem.Click

        Process.Start("https://buymeacoffee.com/Muerto")

    End Sub
    Private Sub LicenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LicenseToolStripMenuItem.Click

        Booleans.bShowLicense = True

        Fade.FadeBehindChild(Me)

        Dim Frm As New FormTextDialog
        AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
        Frm.ShowDialog()

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

    Private Sub AboutToolStripMenuItemExplorer_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click

        Fade.FadeBehindChild(Me)

        Dim Frm As New FormAbout
        AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
        Frm.ShowDialog()

    End Sub

#End Region

    Private Sub RequestElevation()

        If Not Booleans.bIsElevated Then
            Fade.FadeBehindChild(Me)
            Dim Frm As New FormElevate
            AddHandler Frm.FormClosed, AddressOf ChildFormClosedNoRefresh
            Frm.ShowDialog()
        End If

    End Sub

#Region "Routines"
    Friend Shared Function DetermineScaleOf() As String

        Dim strDefault As String = "The Experience Index assesses key system components."

        Select Case WinSystem.KernelVersion.ProductMajorPart
            Case 6
                If WinSystem.KernelVersion.ProductMinorPart = 0 Then : Return "The Experience Index assesses key system components on a scale of 1.0 to 5.9." : End If 'Vista
                If WinSystem.KernelVersion.ProductMinorPart = 1 Then : Return "The Experience Index assesses key system components on a scale of 1.0 to 7.9." : End If '7
                If WinSystem.KernelVersion.ProductMinorPart > 1 Then : Return "The Experience Index assesses key system components on a scale of 1.0 to 9.9." : End If '8, 8.1
            Case 10
                Return "The Experience Index assesses key system components on a scale of 1.0 to 9.9." '10
            Case Else
                Return strDefault
        End Select

        Return strDefault

    End Function
    Private Sub EnterPrintMode()

        CmdAssess.Hide()

        If WinSystem.IsWin10 Then
            lblScale.Text = "WinXI v" & Application.ProductVersion & " on " & WinSystem.GetName() & " · " & WinSystem.CurrentBuild() & " · " _
                & WinSystem.BuildBranch() & " · " & WinSystem.GetWindowsBitness
        Else
            lblScale.Text = "WinXI v" & Application.ProductVersion & " on " & WinSystem.GetName() & " · " _
                & WinSystem.GetWindowsBuildLab() & " · " & WinSystem.GetWindowsBitness()
        End If

    End Sub
    Private Sub ExitPrintMode()
        CmdAssess.Show()
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
        CmdAssess.Text = WinsatState.GenerateRunStateText

        If WinsatAPI.GetAssessmentValidityInt() = 1 Then : lblBasescore.ForeColor = Settings.SetThemeColour : PanValidityState.BackColor = Colors.clrValid
        Else : lblBasescore.ForeColor = Colors.clrBaseScoreUnrated : PanValidityState.BackColor = Colors.clrInvalid
        End If

        'Check CPU score against Base score
        If Strings.ProcessorScore = Strings.BaseScore Then : lblProcessorScore.BackColor = Colors.clrPanelActive : lblProcessorScore.ForeColor = Settings.SetThemeColour
        Else : lblProcessorScore.BackColor = Colors.clrPanelNormal : lblProcessorScore.ForeColor = Color.White
        End If

        'Check Memory score against Base score
        If Strings.MemoryScore = Strings.BaseScore Then : lblMemoryScore.BackColor = Colors.clrPanelActive : lblMemoryScore.ForeColor = Settings.SetThemeColour
        Else : lblMemoryScore.BackColor = Colors.clrPanelNormal : lblMemoryScore.ForeColor = Color.White
        End If

        'Check Graphics Score against Base score
        If Strings.GraphicsScore = Strings.BaseScore Then : lblGraphicsScore.BackColor = Colors.clrPanelActive : lblGraphicsScore.ForeColor = Settings.SetThemeColour
        Else : lblGraphicsScore.BackColor = Colors.clrPanelNormal : lblGraphicsScore.ForeColor = Color.White
        End If

        'Check Gaming score against Base score
        If Strings.D3DScore = Strings.BaseScore Then : lblGamingScore.BackColor = Colors.clrPanelActive : lblGamingScore.ForeColor = Settings.SetThemeColour
        Else : lblGamingScore.BackColor = Colors.clrPanelNormal : lblGamingScore.ForeColor = Color.White
        End If

        'Check Disk score against Base score
        If Strings.DiskScore = Strings.BaseScore Then : lblDiskScore.BackColor = Colors.clrPanelActive : lblDiskScore.ForeColor = Settings.SetThemeColour
        Else : lblDiskScore.BackColor = Colors.clrPanelNormal : lblDiskScore.ForeColor = Color.White
        End If

        'Determine last assessment date
        Strings.AssessDate = Format(WinsatAPI.GetWinsatLastUpdateDate(), "dddd, MMM d yyyy hh:mm tt")
        If (Strings.AssessDate.Length = 0) Or Strings.AssessDate.Contains("1999") Then
            lblLastAssessedString.Text = "Never"
        Else
            lblLastAssessedString.Text = Strings.AssessDate
        End If

        'Hardware switch
        If swHardware.Checked Then
            lblShowHToggle.Text = "On"
        Else
            lblShowHToggle.Text = "Off"
        End If

        'Pass score strings to UI
        lblBasescore.Text = Strings.BaseScore
        lblProcessorScore.Text = Strings.ProcessorScore
        lblMemoryScore.Text = Strings.MemoryScore
        lblGraphicsScore.Text = Strings.GraphicsScore
        lblGamingScore.Text = Strings.D3DScore
        lblDiskScore.Text = Strings.DiskScore

        If Strings.BaseScore = "0" Or Strings.BaseScore = Nothing Then
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
        If Settings.UseApiHardwareMode = True Then
            WinsatReader.ReadAPIHardware()
        Else
            WinsatReader.ReadXMLHardware()
        End If
    End Sub
    Public Sub SetHW()

        LoadHardwareStrings()

        If swHardware.Checked Then
            lblProcessorR.Text = Strings.ProcessorHW.Replace("(R)", "®").Replace("(TM)", "™")
            lblMemoryR.Text = Strings.MemoryHW
            lblGraphicsR.Text = Strings.GraphicsHW.Replace("(R)", "®").Replace("(TM)", "™")
            lblGamingR.Text = Strings.D3DHW
            lblDiskR.Text = Strings.DiskHW
        Else
            lblProcessorR.Text = Strings.ProcessorRO
            lblMemoryR.Text = Strings.MemoryRO
            lblGraphicsR.Text = Strings.GraphicsRO
            lblGamingR.Text = Strings.D3DRO
            lblDiskR.Text = Strings.DiskRO
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

        Integers.NotificationCount -= 1

        If Not Integers.NotificationCount = 0 Then
            CmdHelp.Text = "Help · " & Integers.NotificationCount
        Else
            CmdHelp.ForeColor = Color.White
            CmdHelp.Text = "Help"
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
        cmdElevate.ForeColor = Clr
        CmdSettings.ForeColor = Clr
        CmdMinimize.ForeColor = Clr
        CmdClose.ForeColor = Clr
    End Sub
    Private Sub FormActivate_GotFocus(sender As Object, e As EventArgs) Handles Me.Activated
        Dim Clr As Color = Colors.clrFormActivated
        lblHead.ForeColor = Color.White
        cmdElevate.ForeColor = Clr
        CmdSettings.ForeColor = Clr
        CmdMinimize.ForeColor = Clr
        CmdClose.ForeColor = Clr
    End Sub

#End Region

End Class
