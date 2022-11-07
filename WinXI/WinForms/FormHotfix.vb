'  Updated on 21.10.2019 - DS (Stability improvements, quality of life changes, threading changes, better error output)

Imports System.IO
Imports System.Threading.Tasks

Imports WinXI.Core.Common
Imports WinXI.Core.System

Public Class FormHotfix

    Private ReadOnly strTempPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp\Windows6.1-KB2687862.msu")
    Private ReadOnly FileHotfix86 As Byte() = My.Resources.Windows6_1_KB2687862_x86
    Private ReadOnly FileHotfix64 As Byte() = My.Resources.Windows6_1_KB2687862_x64

    Private intExitCode As Integer = -1

    Private bRestartWin As Boolean = False
    Private bInstallFailed As Boolean = False

#Region "Constructor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetHotfixThemeAccent()

        pnlTitle.BackgroundImage = Settings.imgHeaderGraphic
        pbxLoading.Image = My.Resources.ImgBusy24Px

    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, icnMain.MouseMove, tlpTitleIcon.MouseMove, lblTitle.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If
    End Sub

#End Region
#Region "KeyDown Events"

    Private Sub FormHotfix_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

#End Region
#Region "Frame Buttons"

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

#End Region

#Region "Load Event Handler"

    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles Me.Load

        pbxLoading.Hide()

        If WinSystem.IsWin7 Then
            cmdInstall.Enabled = True
        Else
            lblTitle.Text &= " (Unsupported System)"
            cmdInstall.Enabled = False
        End If

    End Sub

#End Region

#Region "Theme"
    Private Sub SetHotfixThemeAccent()

        Dim TC As Color = Settings.clrThemeColour

        pnlSplit.BackColor = TC
        lnkHotfix.LinkColor = TC

        For Each Ctrl As Control In tlpButtons.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = TC
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub CmdInstall_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdInstall.Click

        pbxLoading.Show()

        If bRestartWin Then
            Process.Start("shutdown", "-r -t 00")
        Else
            cmdInstall.Enabled = False
            cmdClose.Enabled = False
            cmdCancel.Enabled = False

            lblDownload.Text = "Saving hotfix to disk..."

            'Determine bitness for appropriate hotfix and save it to disk
            If WinSystem.IsWindows64Bit() Then
                File.WriteAllBytes(strTempPath, FileHotfix64)
            Else
                File.WriteAllBytes(strTempPath, FileHotfix86)
            End If

            If File.Exists(strTempPath) Then
                'Spawn task and install hotfix to the machine
                lblDownload.Text = "Installing KB2687862..."
                Task.Factory.StartNew(Sub() InstallHotfix())
            Else
                'File did not copy
                'Set error, set failure and call finished as we have nothing to install
                intExitCode = -1
                bInstallFailed = True
                OnInstallFinished()
            End If
        End If

    End Sub

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

#End Region
#Region "LinkLabel Event Handlers"

    Private Sub LnkHotfix_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkHotfix.LinkClicked
        Process.Start("https://support.microsoft.com/help/2687862")
    End Sub

#End Region
#Region "Picturebox Event Handler"

    Private Sub icnMain_Click(sender As Object, e As EventArgs) Handles icnMain.DoubleClick
        If Not WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Normal
        End If
        CenterToParent()
    End Sub

#End Region

#Region "Routines"

    Private Sub InstallHotfix()

        intExitCode = Hotfix.InstallMsu(strTempPath)
        Invoke(DirectCast(Sub() OnInstallFinished(), MethodInvoker))

    End Sub

    Private Sub OnInstallFinished()

        pbxLoading.Hide()

        If bInstallFailed Then
            bRestartWin = False
            bInstallFailed = False
            cmdCancel.Enabled = True
            cmdClose.Enabled = True
            cmdInstall.Enabled = True
            cmdInstall.Text = "Retry"
            lblDownload.Text = "Install failed (" & intExitCode & "), click 'Retry' to try again."
        Else
            Select Case intExitCode
                Case 0 To 1
                    bRestartWin = False
                    lblDownload.Text = "Hotfixed installed successfully (" & intExitCode & ")"
                    cmdClose.Enabled = True
                    cmdCancel.Enabled = True
                    cmdCancel.Text = "Close"
                    FormMain.HotfixWasInstalled() 'Notify main form to remove hotfix available from the menu and negate one from notification count
                Case Else
                    bRestartWin = True
                    lblDownload.Text = "Hotfixed installed. System restart required (" & intExitCode & ")"
                    cmdClose.Enabled = True
                    cmdCancel.Enabled = True
                    cmdCancel.Text = "Ignore"
                    cmdInstall.Enabled = True
                    cmdInstall.Text = "Restart"
                    FormMain.HotfixWasInstalled() 'Notify main form to remove hotfix available from the menu and negate one from notification count
            End Select
        End If

    End Sub

#End Region

End Class