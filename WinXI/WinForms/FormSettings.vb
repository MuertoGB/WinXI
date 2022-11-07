'   02.01.2020 - DR - UI improvements, switch controls to Gambol components
'   09.03.2021 - DR - Remove portability mode, cleanup
'   03.11.2022 - DR - Finalized auto update check, UI changes
'   07.11.2022 - DR - Implement hide notifications, implement load defaults, improve code

Imports WinXI.Core.Common
Imports WinXI.Gambol.Controls

Public Class FormSettings

#Region "Constructor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetOptionsThemeAccent()

        pnlTitle.BackgroundImage = Settings.imgHeaderGraphic

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

    Private Sub FormSettings_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

#End Region
#Region "Frame Buttons"

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Close()
    End Sub

#End Region

#Region "Load Event Handler"

    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Check current settings and set controls state
        SetControlStates()

        'Focus for scroll
        tlpMain.Select()

    End Sub

#End Region

#Region "Theme"

    Private Sub SetOptionsThemeAccent()

        pnlSplit.BackColor = Settings.clrThemeColour
        tbxClientId.ForeColor = Settings.clrThemeColour

        For Each Ctrl As Control In tlpShowHardwareControls.Controls
            If TypeOf Ctrl Is GambolCheckbox Then DirectCast(Ctrl, GambolCheckbox).CheckedColor = Settings.clrThemeColour
        Next

        For Each Ctrl As Control In tlpHardwareModeControls.Controls
            If TypeOf Ctrl Is GambolCheckbox Then DirectCast(Ctrl, GambolCheckbox).CheckedColor = Settings.clrThemeColour
        Next

        For Each Ctrl As Control In tlpAssessmentModeControls.Controls
            If TypeOf Ctrl Is GambolCheckbox Then DirectCast(Ctrl, GambolCheckbox).CheckedColor = Settings.clrThemeColour
        Next

        For Each Ctrl As Control In tlpThemeColorControls.Controls
            If TypeOf Ctrl Is GambolCheckbox Then DirectCast(Ctrl, GambolCheckbox).CheckedColor = Settings.clrThemeColour
        Next

        For Each Ctrl As Control In tlpImgurControls.Controls
            If TypeOf Ctrl Is GambolCheckbox Then DirectCast(Ctrl, GambolCheckbox).CheckedColor = Settings.clrThemeColour
        Next

        For Each Ctrl As Control In tlpOverrides.Controls
            If TypeOf Ctrl Is GambolCheckbox Then DirectCast(Ctrl, GambolCheckbox).CheckedColor = Settings.clrThemeColour
        Next

        For Each Ctrl As Control In pnlMain.Controls
            If TypeOf Ctrl Is Button And Not Ctrl.Text = "Load Defaults" Then DirectCast(Ctrl, Button).ForeColor = Settings.clrThemeColour
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub cmdOkay_Click(sender As Object, e As EventArgs) Handles cmdOkay.Click

        SetCustomClientId()

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

    Private Sub cmdApply_Click(sender As Object, e As EventArgs) Handles cmdApply.Click

        SetCustomClientId()

        'Update stored settings variables
        LoadSettingsValues()

        'Save new user settings
        Settings.Save()

        'Load new settings
        Settings.Load()

        'Uppdate some stuff so an app restart is not needed
        SetOptionsThemeAccent()
        FormMain.SetMainThemeAccent()
        FormMain.UpdateControls()

        ToastAlert.Show("Application settings updated.", ToastType.Information)

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles CmdCancel.Click
        Close()
    End Sub

    Private Sub cmdLoadDefaultSettings_Click(sender As Object, e As EventArgs) Handles cmdLoadDefaultSettings.Click
        cbxShowHardwareOnStartup.Checked = False
        cbxApiHardwareMode.Checked = False
        cbxInDepthAssessment.Checked = False
        rbnDefault0.Checked = True
        cbxApplyToBorder.Checked = False
        cbxImgurID.Checked = False
        cbxAutoUpdateCheck.Checked = False
        cbxHideNotifications.Checked = False
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

        cbxShowHardwareOnStartup.Checked = CBool(IIf(Settings.bShowHardwareOnStartup, True, False))

        cbxApiHardwareMode.Checked = CBool(IIf(Settings.bUseApiHardwareMode, True, False))

        cbxInDepthAssessment.Checked = CBool(IIf(Settings.bUseVerboseAssessmentMode, True, False))

        Select Case Settings.intThemeColourInteger
            Case 0
                rbnDefault0.Checked = True
            Case 1
                rbnSky1.Checked = True
            Case 2
                rbnTurquoise2.Checked = True
            Case 3
                rbnEmerald3.Checked = True
            Case 4
                rbnMegenta4.Checked = True
            Case 5
                rbnPink5.Checked = True
            Case 6
                rbnCarrot6.Checked = True
            Case 7
                rbnYellow7.Checked = True
            Case 8
                rbnAlazarin8.Checked = True
            Case 9
                rbnTomato9.Checked = True
            Case Else
                rbnDefault0.Checked = True
        End Select

        cbxApplyToBorder.Checked = CBool(IIf(Settings.bApplyThemeColourToBorder, True, False))

        cbxImgurID.Checked = CBool(IIf(Settings.bUseCustomImgurApiKey, True, False))
        If cbxImgurID.Checked Then
            tlpCustomIDControls.Show()
            tbxClientId.Text = Settings.strCustomImgurApiKeyString
        Else
            tlpCustomIDControls.Hide()
        End If

        cbxAutoUpdateCheck.Checked = CBool(IIf(Settings.bAutoUpdateCheck, True, False))

        cbxHideNotifications.Checked = CBool(IIf(Settings.bHideNotifications, True, False))

    End Sub

    Private Sub LoadSettingsValues()

        'Show hardware on startup
        Settings.bShowHardwareOnStartup = CBool(IIf(cbxShowHardwareOnStartup.Checked, True, False))

        'Hardware mode
        Settings.bUseApiHardwareMode = CBool(IIf(cbxApiHardwareMode.Checked, True, False))

        'Assessment Mode
        Settings.bUseVerboseAssessmentMode = CBool(IIf(cbxInDepthAssessment.Checked, True, False))

        'Theme color
        If rbnDefault0.Checked Then
            Settings.intThemeColourInteger = 0
        End If
        If rbnSky1.Checked Then
            Settings.intThemeColourInteger = 1
        End If
        If rbnTurquoise2.Checked Then
            Settings.intThemeColourInteger = 2
        End If
        If rbnEmerald3.Checked Then
            Settings.intThemeColourInteger = 3
        End If
        If rbnMegenta4.Checked Then
            Settings.intThemeColourInteger = 4
        End If
        If rbnPink5.Checked Then
            Settings.intThemeColourInteger = 5
        End If
        If rbnCarrot6.Checked Then
            Settings.intThemeColourInteger = 6
        End If
        If rbnYellow7.Checked Then
            Settings.intThemeColourInteger = 7
        End If
        If rbnAlazarin8.Checked Then
            Settings.intThemeColourInteger = 8
        End If
        If rbnTomato9.Checked Then
            Settings.intThemeColourInteger = 9
        End If

        'Apply theme to border
        Settings.bApplyThemeColourToBorder = CBool(IIf(cbxApplyToBorder.Checked, True, False))

        'Custom Imgur Client ID
        If cbxImgurID.Checked And tbxClientId.Text = "" Then
            Settings.bUseCustomImgurApiKey = False
        Else
            Settings.bUseCustomImgurApiKey = CBool(IIf(cbxImgurID.Checked, True, False))
        End If

        'Automatic Update Check
        Settings.bAutoUpdateCheck = CBool(IIf(cbxAutoUpdateCheck.Checked, True, False))

        'Hide notifications
        Settings.bHideNotifications = CBool(IIf(cbxHideNotifications.Checked, True, False))

    End Sub

    Private Sub SetCustomClientId()

        If Not cbxImgurID.Checked Then
            Settings.strCustomImgurApiKeyString = ""
        Else
            Settings.strCustomImgurApiKeyString = tbxClientId.Text
        End If

    End Sub

    Private Sub cbxImgurID_CheckedChanged(sender As Object, e As EventArgs) Handles cbxImgurID.CheckedChanged

        If CType(sender, GambolCheckbox).Checked Then
            tlpCustomIDControls.Show()
            CueText.SetCueText(tbxClientId, "Enter your Client ID...")
        Else
            tlpCustomIDControls.Hide()
        End If

    End Sub

#End Region

End Class