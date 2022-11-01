'  Updated on 02.01.2020 - DS (UI improvements, switch controls to Gambol components)
'  Updated on 09.03.2021 - DS (Remove portability mode, cleanup)

Imports WinXI.Core.Common
Imports WinXI.Gambol.Controls

Public Class FormSettings

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetOptionsThemeAccent()

        PanHead.BackgroundImage = Settings.SetHeaderGraphic

    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, icnMain.MouseMove, TlpHeadImage.MouseMove, LabHead.MouseMove

        If e.Button = Windows.Forms.MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"
    Private Sub FormSettings_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Check current settings and set controls state
        SetControlStates()

        'Fix scroll
        TlpMain.Select()

    End Sub

#End Region

#Region "Theme"
    Private Sub SetOptionsThemeAccent()

        PanSplit.BackColor = Settings.SetThemeColour
        TbxClientId.ForeColor = Settings.SetThemeColour

        For Each Ctrl As Control In TlpShowHardwareCtrls.Controls
            If TypeOf Ctrl Is GambolCheckbox Then DirectCast(Ctrl, GambolCheckbox).CheckedColor = Settings.SetThemeColour
        Next

        For Each Ctrl As Control In TlpHardwareModeCtrls.Controls
            If TypeOf Ctrl Is GambolRadioButton Then DirectCast(Ctrl, GambolRadioButton).CheckedColor = Settings.SetThemeColour
        Next

        For Each Ctrl As Control In TlpAssessmentModeCtrls.Controls
            If TypeOf Ctrl Is GambolCheckbox Then DirectCast(Ctrl, GambolCheckbox).CheckedColor = Settings.SetThemeColour
        Next

        For Each Ctrl As Control In TlpThemeColorsCtrls.Controls
            If TypeOf Ctrl Is GambolCheckbox Then DirectCast(Ctrl, GambolCheckbox).CheckedColor = Settings.SetThemeColour
        Next

        For Each Ctrl As Control In TlpLabImgurClientIDCtrls.Controls
            If TypeOf Ctrl Is GambolCheckbox Then DirectCast(Ctrl, GambolCheckbox).CheckedColor = Settings.SetThemeColour
        Next

        For Each Ctrl As Control In PanMain.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = Settings.SetThemeColour
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"
    Private Sub CmdOkay_Click(sender As Object, e As EventArgs) Handles CmdOkay.Click

        WriteClientID()

        'Update background integers
        LoadSettingsValues()

        'Save new user settings
        Settings.Save()

        'Load new settings to memory
        Settings.Load()

        If FormMain.swHardware.Checked Then
            FormMain.SetHW()
        End If

        'Set theme
        SetOptionsThemeAccent()
        FormMain.SetMainThemeAccent()
        FormMain.UpdateControls()

        'Done
        Close()

    End Sub
    Private Sub CmdApply_Click(sender As Object, e As EventArgs) Handles CmdApply.Click

        WriteClientID()

        'Update stored settings variables
        LoadSettingsValues()

        'Save new user settings
        Settings.Save()

        'Load new settings to memory
        Settings.Load()

        'Set theme
        SetOptionsThemeAccent()
        FormMain.SetMainThemeAccent()
        FormMain.UpdateControls()

        ToastAlert.Show("Settings updated.", ToastType.Information)

    End Sub
    Private Sub CmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Close()
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

    Private Sub SetControlStates()

        If Settings.ShowHardwareOnStartup Then
            GcbHardwareOnStartup.Checked = True
        Else
            GcbHardwareOnStartup.Checked = False
        End If

        If Settings.UseApiHardwareMode Then
            RadHardwareModeApi.Checked = True
        Else
            RadHardwareModeXml.Checked = True
        End If

        If Settings.UseVerboseAssessmentMode Then
            GcbInDepthAssessment.Checked = True
        Else
            GcbInDepthAssessment.Checked = False
        End If

        Select Case Settings.ThemeColourInteger
            Case 0
                RadDefault0.Checked = True
            Case 1
                RadSky1.Checked = True
            Case 2
                RadTurquoise2.Checked = True
            Case 3
                RadEmerald3.Checked = True
            Case 4
                RadMegenta4.Checked = True
            Case 5
                RadPink5.Checked = True
            Case 6
                RadCarrot6.Checked = True
            Case 7
                RadYellow7.Checked = True
            Case 8
                RadAlazarin8.Checked = True
            Case 9
                RadTomato9.Checked = True
            Case Else
                RadDefault0.Checked = True
        End Select

        If Settings.ApplyThemeColourToBorder Then
            CbxApplyToBorder.Checked = True
        Else
            CbxApplyToBorder.Checked = False
        End If

        If Settings.UseCustomImgurApiKey Then
            GcbImgurID.Checked = True
        Else
            GcbImgurID.Checked = False
        End If

        If GcbImgurID.Checked Then
            TlpCustomID.Show()
            TbxClientId.Text = Settings.CustomImgurApiKeyString
        Else
            TlpCustomID.Hide()
        End If

    End Sub

    Private Sub LoadSettingsValues()

        '// Show hardware on startup
        If GcbHardwareOnStartup.Checked Then
            Settings.ShowHardwareOnStartup = True
        Else
            Settings.ShowHardwareOnStartup = False
        End If

        '// Hardware mode
        If RadHardwareModeXml.Checked Then
            Settings.UseApiHardwareMode = False
        Else
            Settings.UseApiHardwareMode = True
        End If

        '// Assessment Mode
        If GcbInDepthAssessment.Checked Then
            Settings.UseVerboseAssessmentMode = True
        Else
            Settings.UseVerboseAssessmentMode = False
        End If

        '// Theme
        If RadDefault0.Checked Then
            Settings.ThemeColourInteger = 0
        End If
        If RadSky1.Checked Then
            Settings.ThemeColourInteger = 1
        End If
        If RadTurquoise2.Checked Then
            Settings.ThemeColourInteger = 2
        End If
        If RadEmerald3.Checked Then
            Settings.ThemeColourInteger = 3
        End If
        If RadMegenta4.Checked Then
            Settings.ThemeColourInteger = 4
        End If
        If RadPink5.Checked Then
            Settings.ThemeColourInteger = 5
        End If
        If RadCarrot6.Checked Then
            Settings.ThemeColourInteger = 6
        End If
        If RadYellow7.Checked Then
            Settings.ThemeColourInteger = 7
        End If
        If RadAlazarin8.Checked Then
            Settings.ThemeColourInteger = 8
        End If
        If RadTomato9.Checked Then
            Settings.ThemeColourInteger = 9
        End If
        'Apply theme to border
        If Not CbxApplyToBorder.Checked Then
            Settings.ApplyThemeColourToBorder = False
        Else
            Settings.ApplyThemeColourToBorder = True
        End If

        'Custom Imgur Client ID
        If Not GcbImgurID.Checked Then
            Settings.UseCustomImgurApiKey = False
        Else
            If GcbImgurID.Checked And TbxClientId.Text.Length = 0 Then
                Settings.UseCustomImgurApiKey = False
            Else
                Settings.UseCustomImgurApiKey = True
            End If
        End If

    End Sub

    Private Sub WriteClientID()

        If Not GcbImgurID.Checked Then
            Settings.CustomImgurApiKeyString = ""
        Else
            Settings.CustomImgurApiKeyString = TbxClientId.Text
        End If

    End Sub

    Private Sub GcbImgurID_CheckedChanged(sender As Object, e As EventArgs) Handles GcbImgurID.CheckedChanged

        If Not CType(sender, GambolCheckbox).Checked Then
            'Custom ID disabled
            TlpCustomID.Hide()
        Else
            TlpCustomID.Show()
            'Custom ID enabled
            CueText.SetCueText(TbxClientId, "Enter Client ID")
        End If

    End Sub

#End Region

#Region "Scroll Events"
    Private Sub TlpMain_Scroll(sender As Object, e As ScrollEventArgs) Handles TlpMain.Scroll
        LabHead.Text = "Settings"
    End Sub
    Private Sub TlpMain_MouseWheel(sender As Object, e As MouseEventArgs) Handles TlpMain.MouseWheel
        LabHead.Text = "Settings"
    End Sub
#End Region

End Class