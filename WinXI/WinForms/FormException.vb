'   23.09.2019 - DR - Remove ability to send reports, add ability to save report, ui changes, general changes, add links.
'   11.03.2021 - DR - Bugfix string for crypto digest.
'   01.11.2022 - DR - Update links and urls.

Imports System.Text
Imports System.Threading

Imports WinXI.Core.Cryptography
Imports WinXI.Core.System

Imports WinXI.Main.Support

Public Class FormException

    Private strSystemData As String
    Private ReadOnly prCurrentProcess As Process = Process.GetCurrentProcess

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetExceptionThemeAccent()

    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, PbxHead.MouseMove, TlpHeadImage.MouseMove, LabHead.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormException_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
#End Region

#Region "Theme"
    Private Sub SetExceptionThemeAccent()

        Dim TC As Color = Settings.SetThemeColour

        PanSplit.BackColor = TC

        For Each Ctrl As Control In TlpButtons.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = TC
        Next
        For Each Ctrl As Control In PanLinks.Controls
            If TypeOf Ctrl Is LinkLabel Then DirectCast(Ctrl, LinkLabel).LinkColor = TC
        Next

        Settings.SetBorderColor(Me)

    End Sub
#End Region

#Region "Load Event Handler"

    Private Sub FormException_Load(sender As Object, e As EventArgs) Handles Me.Load

        LabError.Text = ApplicationSupport.StringException
        LabHead.Text = "Generating report, please wait..."
        Dim T As New Thread(AddressOf LoadData) With {
            .IsBackground = True
        }
        T.Start()

    End Sub

#End Region
#Region "Shown Event Handler"
    Private Sub FormException_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
    End Sub
#End Region
#Region "Button Event Handlers"

    Private Sub CmdContinue_Click(sender As Object, e As EventArgs) Handles CmdContinue.Click
        Close()
    End Sub
    Private Sub CmdForceQuit_Click(sender As Object, e As EventArgs) Handles CmdForceQuit.Click
        Environment.Exit(0)
    End Sub

    Private Sub CmdSaveLog_Click(sender As Object, e As EventArgs) Handles CmdSaveLog.Click

        Dim Sfd As New SaveFileDialog With {
            .FileName = "Error-Report.txt",
            .Filter = "Text File (*.txt)|*.txt",
            .InitialDirectory = Directories.DesktopPath,
            .OverwritePrompt = True
            }

        If Sfd.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(Sfd.FileName, strSystemData, False)
        End If

    End Sub

#End Region
#Region "LinkLabel Event Handlers"

    Private Sub LnkEmail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkEmail.LinkClicked
        Process.Start("mailto:qbug@tuta.io?subject=" & "WinXI Unhandled Exception report" & "&body=" &
                      "Please include a brief description of what happened. Emails are deleted after they have been read and reports are retained until the issue has been fixed.")
    End Sub

    Private Sub LnkForum_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkForum.LinkClicked
        Process.Start(Strings.strIssueUrl)
    End Sub

#End Region
#Region "Picturebox Event Handler"

    Private Sub PbxMain_Click(sender As Object, e As EventArgs) Handles PbxHead.DoubleClick
        If Not WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Normal
        End If
        CenterToParent()
    End Sub

#End Region

#Region "Routines"

    Private Function GenerateSystemData() As String

        Dim SBuilder As New StringBuilder
        Dim StringDate As String = Now.ToShortDateString & " at " & Now.ToShortTimeString
        Dim StringName As String = Application.ProductName
        Dim StringPath As String = AppDomain.CurrentDomain.FriendlyName
        Dim StringVersion As String = Application.ProductVersion

        With SBuilder
            .AppendLine("# // Unhandled exception caught - " & StringDate & vbCrLf)
            .AppendLine("<-- Application -->" & vbCrLf)
            .AppendLine("Name: " & StringName)
            .AppendLine("Version: " & StringVersion)
            .AppendLine("Channel: " & Program.X_Channel)
            .AppendLine("Elevated: " & CStr(Booleans.bIsElevated))
            .AppendLine("SHA256: " & Checksum.GetSha256Digest(StringPath) & vbCrLf)
            .AppendLine("<-- Operating System -->" & vbCrLf)
            .AppendLine("Name: " & WinSystem.GetWindowsName())
            .AppendLine("Bitness: " & WinSystem.GetWindowsBitness)
            .AppendLine("Kernel: " & WinSystem.KernelVersion.ProductVersion())
            .AppendLine("Build: " & WinSystem.GetWindowsBuildLab() & vbCrLf)
            .AppendLine("<-- WinSAT -->" & vbCrLf)
            .AppendLine("Executable Version: " & WinSystem.WinsatVersion.ProductVersion)
            .AppendLine("API Version: " & WinSystem.WinsatApiVersion.ProductVersion & vbCrLf)
            .AppendLine("<-- Exception -->" & vbCrLf)
            .AppendLine(ApplicationSupport.StringException & vbCrLf)
            .AppendLine("<-- Message -->" & vbCrLf)
            .AppendLine(ApplicationSupport.StringExceptionMessage & vbCrLf)
            .AppendLine("<-- Loaded Modules -->" & vbCrLf)
            .AppendLine(GenerateModuleData)
            .AppendLine("# // End of file")
        End With

        Return SBuilder.ToString

    End Function
    Private Function GenerateModuleData() As String

        Dim SBuilder As New StringBuilder
        Dim IntModuleNumber As Integer = 0

        For Each LoadedModule As ProcessModule In prCurrentProcess.Modules

            On Error Resume Next

            IntModuleNumber += 1

            With SBuilder
                .AppendLine("------------------------------------------------------------------------" & vbCrLf)
                .AppendLine("  Module #" & IntModuleNumber & " -> " & "'" & LoadedModule.ModuleName & "'" & vbCrLf)
                .AppendLine("Path: " & LoadedModule.FileName)
                .AppendLine("Version: " & LoadedModule.FileVersionInfo.FileVersion)
                .AppendLine("Description: " & LoadedModule.FileVersionInfo.FileDescription)
                .AppendLine("SHA256: " & Checksum.GetSha256Digest(LoadedModule.FileName))
                .AppendLine("Size (Bytes): " & Convert.ToString(LoadedModule.ModuleMemorySize))
                .AppendLine("Base Address: " & Convert.ToString(LoadedModule.BaseAddress))
                .AppendLine("Entry Point: " & Convert.ToString(LoadedModule.EntryPointAddress) & vbCrLf)
            End With
        Next

        Return SBuilder.ToString

    End Function

#End Region
#Region "Delegate Routines"

    Private Sub LoadData()
        If InvokeRequired Then
            Invoke(New DataDelegate(AddressOf InvokeData), GenerateSystemData)
        Else
            strSystemData = GenerateSystemData()
            CmdContinue.Enabled = True
            CmdSaveLog.Enabled = True
            LabHead.Text = "Exception Handler"
        End If
    End Sub
    Private Delegate Sub DataDelegate(Data As String)
    Private Sub InvokeData(Data As String)
        strSystemData = Data
        CmdContinue.Enabled = True
        CmdSaveLog.Enabled = True
        LabHead.Text = "Exception Handler"
    End Sub

#End Region

End Class