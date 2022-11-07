'   23.09.2019 - DR - Remove ability to send reports, add ability to save report, ui changes, general changes, add links.
'   11.03.2021 - DR - Bugfix string for crypto digest.
'   01.11.2022 - DR - Update links and urls.
'   06.11.2022 - DR - Add program build to log generation, remove single use variable

Imports System.Text
Imports System.Threading
Imports WinXI.Core
Imports WinXI.Core.Common
Imports WinXI.Core.Cryptography
Imports WinXI.Core.System

Imports WinXI.Startup.Support

Public Class FormException

    Private strSystemData As String = String.Empty

#Region "Constructor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetExceptionThemeAccent()

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

    Private Sub FormException_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

#End Region

#Region "Theme"
    Private Sub SetExceptionThemeAccent()

        Dim clrThemeColor As Color = Settings.clrThemeColour

        pnlSplit.BackColor = clrThemeColor

        For Each Ctrl As Control In tlpButtons.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = clrThemeColor
        Next
        For Each Ctrl As Control In pnlLinks.Controls
            If TypeOf Ctrl Is LinkLabel Then DirectCast(Ctrl, LinkLabel).LinkColor = clrThemeColor
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Load Event Handler"

    Private Sub FormException_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblErrorMessage.Text = ApplicationSupport.strException
        lblTitle.Text = "Generating report, please wait..."
        Dim tLoadData As New Thread(AddressOf LoadData) With {
            .IsBackground = True
        }
        tLoadData.Start()

    End Sub

#End Region
#Region "Shown Event Handler"

    Private Sub FormException_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
    End Sub

#End Region
#Region "Button Event Handlers"

    Private Sub cmdContinue_Click(sender As Object, e As EventArgs) Handles cmdContinue.Click
        Close()
    End Sub

    Private Sub cmdForceQuit_Click(sender As Object, e As EventArgs) Handles cmdForceQuit.Click
        Environment.Exit(0)
    End Sub

    Private Sub cmdSaveLog_Click(sender As Object, e As EventArgs) Handles cmdSaveLog.Click

        Dim sfdLog As New SaveFileDialog With {
            .FileName = "Error-Report.txt",
            .Filter = "Text File (*.txt)|*.txt",
            .InitialDirectory = Directories.DesktopPath,
            .OverwritePrompt = True
            }

        If sfdLog.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(sfdLog.FileName, strSystemData, False)
        End If

    End Sub

#End Region
#Region "LinkLabel Event Handlers"

    Private Sub lnkEmail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkEmail.LinkClicked
        Process.Start("mailto:qbug@tuta.io?subject=" & "WinXI Unhandled Exception Report" & "&body=" &
                      "Please include a brief description of what happened, and attach the error log.")
    End Sub

    Private Sub lnkForum_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkOpenIssue.LinkClicked
        Process.Start(Strings.strIssueUrl)
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

    Private Function GenerateSystemData() As String

        Dim strBuilder As New StringBuilder
        Dim strDate As String = Now.ToShortDateString & " at " & Now.ToShortTimeString

        With strBuilder
            .AppendLine("# // Unhandled exception caught - " & strDate & vbCrLf)
            .AppendLine("<-- Application -->" & vbCrLf)
            .AppendLine("Name: " & Application.ProductName)
            .AppendLine("Version: " & Application.ProductVersion)
            .AppendLine("Build: " & Program.Build)
            .AppendLine("Channel: " & Program.Channel)
            .AppendLine("Elevated: " & CStr(Elevation.bIsElevated))
            .AppendLine("SHA256: " & Checksum.GetSha256Digest(FileOps.GetApplicationImage) & vbCrLf)
            .AppendLine("<-- Operating System -->" & vbCrLf)
            .AppendLine("Name: " & WinSystem.GetProductName())
            .AppendLine("Bitness: " & WinSystem.GetWindowsBitness)
            .AppendLine("Kernel: " & WinSystem.fviKernelVersion.ProductVersion())
            .AppendLine("Build: " & WinSystem.GetWindowsBuildLab() & vbCrLf)
            .AppendLine("<-- WinSAT -->" & vbCrLf)
            .AppendLine("Executable Version: " & WinSystem.fviWinsatVersion.ProductVersion)
            .AppendLine("API Version: " & WinSystem.fviWinsatApiVersion.ProductVersion & vbCrLf)
            .AppendLine("<-- Exception -->" & vbCrLf)
            .AppendLine(ApplicationSupport.strException & vbCrLf)
            .AppendLine("<-- Message -->" & vbCrLf)
            .AppendLine(ApplicationSupport.strExceptionMessage & vbCrLf)
            .AppendLine("<-- Loaded Modules -->" & vbCrLf)
            .AppendLine(GenerateModuleData)
            .AppendLine("# // End of file")
        End With

        Return strBuilder.ToString

    End Function

    Private Function GenerateModuleData() As String

        Dim strBuilder As New StringBuilder
        Dim intModuleNumber As Integer = 0

        For Each pmModules As ProcessModule In Process.GetCurrentProcess.Modules

            On Error Resume Next

            intModuleNumber += 1

            With strBuilder
                .AppendLine("------------------------------------------------------------------------" & vbCrLf)
                .AppendLine("  Module #" & intModuleNumber & " -> " & "'" & pmModules.ModuleName & "'" & vbCrLf)
                .AppendLine("Path: " & pmModules.FileName)
                .AppendLine("Version: " & pmModules.FileVersionInfo.FileVersion)
                .AppendLine("Description: " & pmModules.FileVersionInfo.FileDescription)
                .AppendLine("SHA256: " & Checksum.GetSha256Digest(pmModules.FileName))
                .AppendLine("Size (Bytes): " & Convert.ToString(pmModules.ModuleMemorySize))
                .AppendLine("Base Address: " & Convert.ToString(pmModules.BaseAddress))
                .AppendLine("Entry Point: " & Convert.ToString(pmModules.EntryPointAddress) & vbCrLf)
            End With
        Next

        Return strBuilder.ToString

    End Function

#End Region
#Region "Delegate Routines"

    Private Sub LoadData()
        If InvokeRequired Then
            Invoke(New DataDelegate(AddressOf InvokeData), GenerateSystemData)
        Else
            strSystemData = GenerateSystemData()
            cmdContinue.Enabled = True
            cmdSaveLog.Enabled = True
            lblTitle.Text = "Exception Handler"
        End If
    End Sub

    Private Delegate Sub DataDelegate(Data As String)

    Private Sub InvokeData(Data As String)
        strSystemData = Data
        cmdContinue.Enabled = True
        cmdSaveLog.Enabled = True
        lblTitle.Text = "Exception Handler"
    End Sub

#End Region

End Class