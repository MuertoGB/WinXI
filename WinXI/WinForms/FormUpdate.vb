'  Updated on 29.07.2019 - DS (Migrating to new system)
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)

Imports System.IO
Imports System.Net

Imports WinXI.Core.System

Public Class FormUpdate

    Private Shared DLPath As String = ""


#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetThemeAccent()

        PanHead.BackgroundImage = Settings.imgHeaderGraphic

    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, icnMain.MouseMove, TlpHeadImage.MouseMove, LabHead.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"

    Private Sub FormUpdate_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

#End Region
#Region "Frame Buttons"

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Close()
    End Sub

#End Region

#Region "Load Event Handler"

    Private Sub FormUpdate_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Not UpdateCheck.bHasCheckedThisSession Then
            If Not Settings.bAutoUpdateCheck Then 'we need to check for an update
                If UpdateCheck.IsNewVersionAvailable() Then
                    Booleans.bMissingUpdate = True
                End If
            End If
            UpdateCheck.bHasCheckedThisSession = True
        End If

        Invoke(DirectCast(Sub() OnFinishedInvokeUI(), MethodInvoker))

    End Sub

    Private Sub OnFinishedInvokeUI()

        If Booleans.bMissingUpdate Then
            LabInfo.Text = "An update is ready to download."
            CmdDownload.Enabled = True
        Else
            LabInfo.Text = "No updates are available."
            CmdDownload.Enabled = False
        End If

        LabCurrent.Text = UpdateCheck.strLocalBuild & " · " & Program.ReleaseDate
        LabServer.Text = UpdateCheck.strRemoteBuild & " · " & UpdateCheck.strReleaseDate

    End Sub

#End Region

#Region "Theme"

    Private Sub SetThemeAccent()

        Dim TC As Color = Settings.clrThemeColour

        PanSplit.BackColor = TC
        LnkChangelog.LinkColor = TC

        For Each Ctrl As Control In TlpBottom.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = TC
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Close()
    End Sub

#End Region
#Region "Linklabel Event Handlers"

    Private Sub LnkChangelog_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkChangelog.LinkClicked
        Process.Start(Strings.strChangelogUrl)
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

#Region "WebClient"

    Private Sub CmdDownload_Click(sender As Object, e As EventArgs) Handles CmdDownload.Click

        If Network.IsWebsiteAvailable(Strings.strHomeUrl) = True Then

            Dim FBD As New FolderBrowserDialog With {
            .ShowNewFolderButton = True,
               .Description = "Select a path..."
            }

            If FBD.ShowDialog = Windows.Forms.DialogResult.OK Then

                CType(sender, Button).Enabled = False

                Dim WClient As New WebClient
                AddHandler WClient.DownloadProgressChanged, AddressOf WClient_ProgressChanged
                AddHandler WClient.DownloadFileCompleted, AddressOf WClient_DownloadCompleted

                DLPath = Path.Combine(FBD.SelectedPath, "WinXI.zip")

                WClient.DownloadFileAsync(New Uri("ENTER NEW DOWNLOAD URL"), DLPath)
                WClient.Dispose()

            End If

            FBD.Dispose()

        Else
            ToastAlert.Show("Could not reach server.", ToastType.Warning)
        End If

    End Sub

    Private Sub WClient_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)

        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100

        LabDownload.Text = "Downloading: " & Integer.Parse(Math.Truncate(percentage).ToString()) & "%"

        'PbrUpdate.Value = Int32.Parse(Math.Truncate(percentage).ToString())
        'PbrUpdate.Refresh()

    End Sub

    Private Sub WClient_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)

        CmdDownload.Enabled = True
        LabDownload.Text = ""
        'PbrUpdate.Value = 0
        'PbrUpdate.Hide()

        If File.Exists(DLPath) = True Then
            Process.Start(DLPath)
        End If

        Application.Exit()

    End Sub

#End Region

End Class