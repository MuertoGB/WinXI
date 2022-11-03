'   20.09.2019 - DR - Add username, add install date, add tick to uptime and remove refresh button
'   26.09.2019 - DR - Improve threading, edit keydown
'   01.11.2022 - DR - Remove releaseid
'   03.11.2022 - DR - Improved code, incorperate export info

Imports System.Text
Imports WinXI.Core.System
Imports System.Threading


Public Class FormSystem

    Private ReadOnly strUsername As String = WinSystem.GetUsername
    Private ReadOnly strBuildOther As String = WinSystem.GetProductName() & " · " & WinSystem.CurrentBuild()
    Private ReadOnly strBuildTen As String = WinSystem.GetProductName() & " · Build " & WinSystem.BuildBranch()
    Private ReadOnly strOs As String = CType(IIf(WinSystem.IsWin10, strBuildTen, strBuildOther), String)
    Private ReadOnly strBitness As String = WinSystem.GetWindowsBitness()
    Private ReadOnly strServicePack As String = WinSystem.GetWindowsServicePack
    Private ReadOnly strKernelVersion As String = WinSystem.fviKernelVersion.ProductVersion
    Private ReadOnly strWinSATVersion As String = WinSystem.fviWinsatVersion.ProductVersion
    Private ReadOnly strWinSATAPIVersion As String = WinSystem.fviWinsatApiVersion.ProductVersion
    Private strSystemUptime As String = WinSystem.GetWindowsUptime
    Private ReadOnly strWinInstallDate As String = WinSystem.GetWindowsInstallDate

    Private Delegate Sub InvokeUptime(Data As String)
    Private thrTick As Thread
    Private bContinue As Boolean = True

#Region "Constructor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetCleanupThemeAccent()

        panTitle.BackgroundImage = Settings.imgHeaderGraphic

    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, icnMain.MouseMove, tlpTitleIcon.MouseMove, lblTitle.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"

    Private Sub FormSystem_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            StopTick()
            Close()
        Else
            If e.Alt And e.KeyCode = Keys.F4 Then
                StopTick()
            End If
        End If
    End Sub

#End Region
#Region "Frame Buttons"

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        StopTick()
        Close()
    End Sub

#End Region

#Region "Load Event Handler"

    Private Sub FormSystem_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblUsername.Text = strUsername
        lblOs.Text = strOs
        lblBitness.Text = strBitness
        lblServicePack.Text = strServicePack

        lblKernelVersion.Text = strKernelVersion
        lblWinSATVersion.Text = strWinSATVersion
        lblWinSATAPIVersion.Text = strWinSATAPIVersion

        thrTick = New Thread(AddressOf TickUptime) With {
            .IsBackground = True
        }
        thrTick.Start()

        lblWinInstallDate.Text = strWinInstallDate

    End Sub

#End Region

#Region "Theme"

    Private Sub SetCleanupThemeAccent()

        pnlSplit.BackColor = Settings.clrSetThemeColour
        Settings.SetBorderColor(Me)

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
#Region "Button Event Handler"

    Private Sub cmdExportInfo_Click(sender As Object, e As EventArgs) Handles cmdExportInfo.Click

        Dim StringDate As String = Now.ToShortDateString & " - " & Now.ToShortTimeString

        Dim Sfd As New SaveFileDialog With {
            .FileName = "System-Info.txt",
            .Filter = "Text File (*.txt)|*.txt",
            .InitialDirectory = Directories.DesktopPath,
            .OverwritePrompt = True
            }

        Dim strBuilder As New StringBuilder()

        With strBuilder
            .AppendLine("System Info - " & StringDate & vbCrLf)
            .AppendLine("Username: " & strUsername)
            .AppendLine("Software: " & strOs)
            .AppendLine("Bitness: " & strBitness)
            .AppendLine("Service Pack: " & strServicePack)
            .AppendLine("Kernel Version: " & strKernelVersion)
            .AppendLine("WinSAT Version: " & strWinSATVersion)
            .AppendLine("WinSAT API Version: " & strWinSATAPIVersion)
            .AppendLine("Install Date: " & strWinInstallDate)
            .AppendLine("System Uptime: " & strSystemUptime)
        End With


        If Sfd.ShowDialog = DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(Sfd.FileName, strBuilder.ToString(), False)
            ToastAlert.Show("System information saved to " & Sfd.FileName, ToastType.Information)
        End If

        'Probably GC will handle this, but still...
        strBuilder = Nothing

    End Sub

#End Region

#Region "Thread"

    Private Sub TickUptime()

        Do While bContinue
            IIf(InvokeRequired, Invoke(New InvokeUptime(AddressOf InvokeTickUptime), WinSystem.GetWindowsUptime), lblSystemUptime.Text = WinSystem.GetWindowsUptime)
            Thread.Sleep(500)
        Loop

    End Sub

    Private Sub InvokeTickUptime(Data As String)
        lblSystemUptime.Text = Data
    End Sub

    Private Sub StopTick()
        bContinue = False
    End Sub

#End Region

End Class