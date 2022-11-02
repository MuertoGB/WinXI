'   24.05.2020 - DR - Fixed image scaling

Public Class FormAcknowledgements

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetAcknThemeAccent()

        PanHead.BackgroundImage = Settings.SetHeaderGraphic

    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, icnMain.MouseMove, TlpHeadImage.MouseMove, LabHead.MouseMove
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

    Private Sub SetAcknThemeAccent()

        Dim TC As Color = Settings.SetThemeColour

        PanSplit.BackColor = TC

        For Each Ctrl As Control In TlpTop.Controls
            If TypeOf Ctrl Is LinkLabel Then DirectCast(Ctrl, LinkLabel).LinkColor = TC
        Next

        For Each Ctrl As Control In TlpImgLinks.Controls
            If TypeOf Ctrl Is LinkLabel Then DirectCast(Ctrl, LinkLabel).LinkColor = TC
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Load Event Handler"

    Private Sub FormAckn_Load(sender As Object, e As EventArgs) Handles Me.Load

        FormatMicrosoftLink()
        FormatCreditsLink()
        FormatGraphLink()
        FormatIconLink()
        FormatWarnLink()
        FormatErrorLink()

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
#Region "Links, top"

    Private Sub LnkMicrosoft_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkMicrosoft.LinkClicked
        Process.Start(e.Link.LinkData.ToString)
    End Sub
    Private Sub LnkCredits_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkCredits.LinkClicked
        Process.Start(e.Link.LinkData.ToString)
    End Sub

#End Region
#Region "Links, bottom"

    Private Sub LnkGraph_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkGraph.LinkClicked
        Process.Start(e.Link.LinkData.ToString)
    End Sub
    Private Sub LnkIcon_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkIcon.LinkClicked
        Process.Start(e.Link.LinkData.ToString)
    End Sub
    Private Sub LnkWarn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkWarn.LinkClicked
        Process.Start(e.Link.LinkData.ToString)
    End Sub
    Private Sub LnkError_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LnkError.LinkClicked
        Process.Start(e.Link.LinkData.ToString)
    End Sub

#End Region

#Region "Link Formatting"
    Private Sub FormatMicrosoftLink()
        LnkMicrosoft.Links.Clear()
        LnkMicrosoft.Links.Add(106, 21, "https://www.microsoft.com")
    End Sub
    Private Sub FormatCreditsLink()
        LnkCredits.Links.Clear()
        LnkCredits.Links.Add(88, 13, "https://forums.mydigitallife.net/")
        LnkCredits.Links.Add(136, 10, "https://www.majorgeeks.com/")
        LnkCredits.Links.Add(151, 9, "https://www.softpedia.com/")
    End Sub
    Private Sub FormatGraphLink()
        LnkGraph.Links.Clear()
        LnkGraph.Links.Add(14, 14, "https://www.flaticon.com/free-icon/bar-chart_235172").Enabled = True
        LnkGraph.Links.Add(34, 8, "https://www.flaticon.com").Enabled = True
    End Sub
    Private Sub FormatIconLink()
        LnkIcon.Links.Clear()
        LnkIcon.Links.Add(20, 7, "https://www.flaticon.com/free-icon/info-button_64494")
        LnkIcon.Links.Add(33, 8, "https://www.flaticon.com")
    End Sub
    Private Sub FormatWarnLink()
        LnkWarn.Links.Clear()
        LnkWarn.Links.Add(16, 7, "https://www.flaticon.com/free-icon/danger_272289")
        LnkWarn.Links.Add(29, 8, "https://www.flaticon.com")
    End Sub
    Private Sub FormatErrorLink()
        LnkError.Links.Clear()
        LnkError.Links.Add(14, 10, "https://www.flaticon.com/free-icon/error_149690")
        LnkError.Links.Add(30, 8, "https://www.flaticon.com")
    End Sub

#End Region

End Class