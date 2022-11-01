'   Updated on 31.07.2019 - DS (Cleanup)
'   Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)
'   01.11.2022 - DR - Add capaability changes, change support link text and URL

Public Class FormEnvironment

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetEnvironmentThemeAccent()

        PanHead.BackgroundImage = Settings.SetHeaderGraphic

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
        CmdOkay.ForeColor = TC
        lnkIssue.LinkColor = TC

        Settings.SetBorderColor(Me)

    End Sub
#End Region

#Region "Button Event Handlers"

    Private Sub CmdOkay_Click(sender As Object, e As EventArgs) Handles CmdOkay.Click
        Close()
    End Sub

#End Region
#Region "Linklabel Event Handlers"

    Private Sub lnkIssue_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkIssue.LinkClicked
        Process.Start(Strings.strIssueUrl)
    End Sub

#End Region
#Region "Picturebox Event Handler"

    Private Sub PbxHead_Click(sender As Object, e As EventArgs) Handles PbxHead.DoubleClick
        If Not WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Normal
        End If
        CenterToScreen()
    End Sub

    Private Sub FormEnvironment_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Booleans.bIncapableOfWinsat Then
            lblMessage.Text = "This Operating is missing vital WinSAT files. The application will now exit."
        Else
            lblMessage.Text = "This program requires Windows Vista or later. The application will now exit."
        End If

    End Sub

#End Region

End Class