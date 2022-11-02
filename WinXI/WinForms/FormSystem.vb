'   20.09.2019 - DR - Add username, add install date, add tick to uptime and remove refresh button
'   26.09.2019 - DR - Improve threading, edit keydown
'   01.11.2022 - DR - Remove releaseid

Imports System.Threading

Imports WinXI.Core.System

Public Class FormSystem

    Private ReadOnly StringBuildOther As String = WinSystem.GetProductName() & " · " & WinSystem.CurrentBuild()
    Private ReadOnly StringBuildTen As String = WinSystem.GetProductName() & " · Build " & WinSystem.BuildBranch()

    Private Delegate Sub InvokeUptime(Data As String)
    Private ThrTick As Thread
    Private BContinue As Boolean = True

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetCleanupThemeAccent()

        PanHead.BackgroundImage = Settings.SetHeaderGraphic

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

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        StopTick()
        Close()
    End Sub

#End Region

#Region "Load Event Handler"

    Private Sub FormSystem_Load(sender As Object, e As EventArgs) Handles Me.Load

        LabUsername.Text = WinSystem.GetUsername
        LabWinSystemtem.Text = CType(IIf(WinSystem.IsWin10, StringBuildTen, StringBuildOther), String)
        LabBitness.Text = WinSystem.GetWindowsBitness()
        LabServPack.Text = WinSystem.GetWindowsServicePack()

        LabKernel.Text = WinSystem.fviKernelVersion.ProductVersion
        LabWinsat.Text = WinSystem.fviWinsatVersion.ProductVersion
        LabApi.Text = WinSystem.fviWinsatApiVersion.ProductVersion

        LabInstDat.Text = WinSystem.GetWindowsInstallDate
        ThrTick = New Thread(AddressOf TickUptime) With {
            .IsBackground = True
        }
        ThrTick.Start()

    End Sub

#End Region

#Region "Theme"

    Private Sub SetCleanupThemeAccent()

        PanSplit.BackColor = Settings.SetThemeColour
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

#Region "Thread"

    Private Sub TickUptime()

        Do While BContinue
            If InvokeRequired Then
                Invoke(New InvokeUptime(AddressOf InvokeTickUptime), WinSystem.GetWindowsUptime)
            Else
                LabUptime.Text = WinSystem.GetWindowsUptime
            End If
            Thread.Sleep(500)
        Loop

    End Sub
    Private Sub InvokeTickUptime(Data As String)
        LabUptime.Text = Data
    End Sub
    Private Sub StopTick()
        BContinue = False
    End Sub
#End Region

End Class