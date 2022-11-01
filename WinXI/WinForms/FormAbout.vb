﻿'   01.11.2022 - DR - Update urls, UI changes, removed irrelevant links, removed tribute out of respect.

Friend Class FormAbout

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetAboutThemeAccent()
        PanHead.BackgroundImage = Settings.SetHeaderGraphic

    End Sub

#End Region

#Region "WndProc"
    Private Sub Frame_Move(sender As Object, e As MouseEventArgs) Handles Me.MouseMove, PbxHead.MouseMove, TlpHeadImage.MouseMove, LabHead.MouseMove
        If e.Button = MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If
    End Sub
#End Region
#Region "KeyDown Events"
    Private Sub FormAbout_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

#Region "Theme"
    Private Sub SetAboutThemeAccent()

        Dim TC As Color = Settings.SetThemeColour

        PanSplit.BackColor = TC

        For Each Ctrl As Control In PanMain.Controls
            If TypeOf Ctrl Is LinkLabel Then DirectCast(Ctrl, LinkLabel).LinkColor = TC
        Next

        Settings.SetBorderColor(Me)

    End Sub
#End Region

#Region "Load Event Handler"
    Private Sub FormAbout_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblName.Text &= " " & Application.ProductVersion & " · " & Program.X_Channel
        lblBuild.Text = "Build " & Program.X_Build

        FormatLinks()

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
#Region "Linklabel Event Handlers"

    Private Sub LnkLinks_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLinks.LinkClicked
        Process.Start(e.Link.LinkData.ToString)
    End Sub

#End Region

#Region "Format Links"

    Private Sub FormatLinks()

        Dim str As String = "WinXI build: " & Program.X_Build
        lnkLinks.Links.Clear()
        lnkLinks.Links.Add(0, 8, "mailto:qbug@tuta.io?subject=" & "Software enquiry or bug report&body=" & vbCrLf & str)
        lnkLinks.Links.Add(11, 11, "https://github.com/MuertoGB")

    End Sub

#End Region

End Class