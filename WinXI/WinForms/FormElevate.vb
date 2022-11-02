'   01.11.2022 - DR - Create FormElevate.vb, set KeyPreview true

Imports WinXI.Core

Public Class FormElevate

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetEnvironmentThemeAccent()

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

    Private Sub FormEnvironment_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

#End Region

#Region "Theme"
    Private Sub SetEnvironmentThemeAccent()

        Dim TC As Color = Settings.SetThemeColour

        PanSplit.BackColor = TC
        cmdDecline.ForeColor = TC
        cmdElevate.ForeColor = TC

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Picturebox Event Handler"

    Private Sub icnMain_Click(sender As Object, e As EventArgs) Handles icnMain.DoubleClick
        If Not WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Normal
        End If
        CenterToScreen()
    End Sub

#End Region
#Region "Button Event Handlers"

    Private Sub cmdElevate_Click(sender As Object, e As EventArgs) Handles cmdElevate.Click
        Elevation.RestartElevated()
    End Sub

    Private Sub cmdDecline_Click(sender As Object, e As EventArgs) Handles cmdDecline.Click
        Close()
    End Sub

#End Region

End Class