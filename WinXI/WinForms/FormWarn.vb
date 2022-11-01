'  Updated on 31.07.2019 - DS (Cleanup)
'  Updated on 07.08.2019 - DS (Add constructor, update theme, update WndProc)

'// TO be repurposed for settings migration 

Imports WinXI.Core.Helpers

Public Class FormWarn

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetWarnThemeAccent()

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
    Private Sub FormWarn_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
#End Region

#Region "Theme"
    Private Sub SetWarnThemeAccent()

        Dim TC As Color = Settings.SetThemeColour

        PanSplit.BackColor = TC
        CmdOkay.ForeColor = TC
        LnkForum.LinkColor = TC

        Settings.SetBorderColor(Me)

    End Sub
#End Region

#Region "Button Event Handlers"

    Private Sub CmdOkay_Click(sender As Object, e As EventArgs) Handles CmdOkay.Click
        Close()
    End Sub

#End Region
#Region "Linklabel Event Handlers"

    Private Sub LnkForum_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkForum.LinkClicked
        Process.Start("https://forums.mydigitallife.net/threads/WinXI-experience-index-returns.68890/")
    End Sub

#End Region
#Region "Picturebox Event Handler"

    Private Sub PbxHead_Click(sender As Object, e As EventArgs) Handles PbxHead.DoubleClick
        If Not WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Normal
        End If
        CenterToParent()
    End Sub

#End Region

End Class