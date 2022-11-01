'  Updated on 20.01.2020 - DS (Add StringReader, clean imports)
'  Updated on 07.03.2021 - DS (Adapted to display License and Changelog)

Imports System.IO

Imports WinXI.Core.Helpers

Public Class FormTextDialog

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetChangelogThemeAccent()

        PanHead.BackgroundImage = Settings.SetHeaderGraphic

    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, PbxHead.MouseMove, TlpHeadImage.MouseMove, LabHead.MouseMove

        If e.Button = MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormChangelog_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub FormChangelog_Load(sender As Object, e As EventArgs) Handles Me.Load

        If Booleans.bShowLicense Then
            LabHead.Text = "License"
            Using Reader As New StringReader(My.Resources.LICENSE)
                RtbChanges.Text = Reader.ReadToEnd
            End Using
            'RtbChanges.Select()
        Else
            LabHead.Text = "Changelog"
            Using Reader As New StringReader(My.Resources.CHANGELOG)
                RtbChanges.Rtf = Reader.ReadToEnd
            End Using
            'RtbChanges.Select()
        End If

    End Sub

#End Region

#Region "Theme"
    Private Sub SetChangelogThemeAccent()

        PanSplit.BackColor = Settings.SetThemeColour
        Settings.SetBorderColor(Me)

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