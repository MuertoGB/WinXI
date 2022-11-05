﻿'   02.01.2020 - DR - UI improvements, switch controls to Gambol components
'   09.03.2021 - DR - Remove portability mode, cleanup
'   03.11.2022 - DR - Finalized auto update check, UI changes

Imports WinXI.Core.Common
Imports WinXI.Gambol.Controls

Public Class FormSettings

#Region "Constructor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetOptionsThemeAccent()

        PanHead.BackgroundImage = Settings.imgHeaderGraphic

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

        'Focus for scroll
        TlpMain.Select()

    End Sub

#End Region

#Region "Theme"

    Private Sub SetOptionsThemeAccent()

        PanSplit.BackColor = Settings.clrThemeColour
        tbClientId.ForeColor = Settings.clrThemeColour

        For Each Ctrl As Control In TlpShowHardwareCtrls.Controls
            If TypeOf Ctrl Is GambolCheckbox Then DirectCast(Ctrl, GambolCheckbox).CheckedColor = Settings.clrThemeColour
        Next

        For Each Ctrl As Control In TlpHardwareModeCtrls.Controls
            If TypeOf Ctrl Is GambolRadioButton Then DirectCast(Ctrl, GambolRadioButton).CheckedColor = Settings.clrThemeColour
        Next

        For Each Ctrl As Control In TlpAssessmentModeCtrls.Controls
            If TypeOf Ctrl Is GambolCheckbox Then DirectCast(Ctrl, GambolCheckbox).CheckedColor = Settings.clrThemeColour
        Next

        For Each Ctrl As Control In TlpThemeColorsCtrls.Controls
            If TypeOf Ctrl Is GambolCheckbox Then DirectCast(Ctrl, GambolCheckbox).CheckedColor = Settings.clrThemeColour
        Next

        For Each Ctrl As Control In TlpLabImgurClientIDCtrls.Controls
            If TypeOf Ctrl Is GambolCheckbox Then DirectCast(Ctrl, GambolCheckbox).CheckedColor = Settings.clrThemeColour
        Next

        For Each Ctrl As Control In PanMain.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = Settings.clrThemeColour
        Next

        For Each Ctrl As Control In tlpOverrides.Controls
            If TypeOf Ctrl Is GambolCheckbox Then DirectCast(Ctrl, GambolCheckbox).CheckedColor = Settings.clrThemeColour
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

        If Settings.bShowHardwareOnStartup Then
            cbxHardwareOnStartup.Checked = True
        Else
            cbxHardwareOnStartup.Checked = False
        End If

        If Settings.bUseApiHardwareMode Then
            rbnHardwareModeApi.Checked = True
        Else
            rbnHardwareModeXml.Checked = True
        End If

        If Settings.bUseVerboseAssessmentMode Then
            cbxInDepthAssessment.Checked = True
        Else
            cbxInDepthAssessment.Checked = False
        End If

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

        If Settings.bApplyThemeColourToBorder Then
            cbxApplyToBorder.Checked = True
        Else
            cbxApplyToBorder.Checked = False
        End If

        If Settings.bUseCustomImgurApiKey Then
            cbxImgurID.Checked = True
        Else
            cbxImgurID.Checked = False
        End If

        If cbxImgurID.Checked Then
            TlpCustomID.Show()
            tbClientId.Text = Settings.strCustomImgurApiKeyString
        Else
            TlpCustomID.Hide()
        End If

        If Settings.bAutoUpdateCheck Then
            cbxAutoUpdateCheck.Checked = True
        Else
            cbxAutoUpdateCheck.Checked = False
        End If

    End Sub

    Private Sub LoadSettingsValues()

        '// Show hardware on startup
        If cbxHardwareOnStartup.Checked Then
            Settings.bShowHardwareOnStartup = True
        Else
            Settings.bShowHardwareOnStartup = False
        End If

        '// Hardware mode
        If rbnHardwareModeXml.Checked Then
            Settings.bUseApiHardwareMode = False
        Else
            Settings.bUseApiHardwareMode = True
        End If

        '// Assessment Mode
        If cbxInDepthAssessment.Checked Then
            Settings.bUseVerboseAssessmentMode = True
        Else
            Settings.bUseVerboseAssessmentMode = False
        End If

        '// Theme
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
        If Not cbxApplyToBorder.Checked Then
            Settings.bApplyThemeColourToBorder = False
        Else
            Settings.bApplyThemeColourToBorder = True
        End If

        'Custom Imgur Client ID
        If Not cbxImgurID.Checked Then
            Settings.bUseCustomImgurApiKey = False
        Else
            If cbxImgurID.Checked And tbClientId.Text.Length = 0 Then
                Settings.bUseCustomImgurApiKey = False
            Else
                Settings.bUseCustomImgurApiKey = True
            End If
        End If

        'Automatic Update Check
        If Not cbxAutoUpdateCheck.Checked Then
            Settings.bAutoUpdateCheck = False
        Else
            Settings.bAutoUpdateCheck = True
        End If

    End Sub

    Private Sub WriteClientID()

        If Not cbxImgurID.Checked Then
            Settings.strCustomImgurApiKeyString = ""
        Else
            Settings.strCustomImgurApiKeyString = tbClientId.Text
        End If

    End Sub

    Private Sub GcbImgurID_CheckedChanged(sender As Object, e As EventArgs) Handles cbxImgurID.CheckedChanged

        If Not CType(sender, GambolCheckbox).Checked Then
            'Custom ID disabled
            TlpCustomID.Hide()
        Else
            TlpCustomID.Show()
            'Custom ID enabled
            CueText.SetCueText(tbClientId, "Enter Client ID")
        End If

    End Sub

#End Region

End Class