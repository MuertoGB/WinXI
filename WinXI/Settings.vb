'   08.03.2021 - DR - Rewrite
'   01.11.2022 - DR - Omit windows server changes, supress BC42025
'   02.11.2022 - DR - Gain SaveSingleKey()
'   06.11.2022 - DR - Fixed incorrect key names in Load()
'   07.11.2022 - DR - Implement hide notifications

Imports System.IO
Imports WinXI.Core.Common

Friend Class Settings

    '[Settings]
    Friend Shared bShowHardwareOnStartup As Boolean = False
    Friend Shared bUseApiHardwareMode As Boolean = False
    Friend Shared bUseVerboseAssessmentMode As Boolean = False
    Friend Shared intThemeColourInteger As Integer = 0
    Friend Shared bApplyThemeColourToBorder As Boolean = False
    Friend Shared bUseCustomImgurApiKey As Boolean = False
    Friend Shared strCustomImgurApiKeyString As String = ""

    '[Overrides]
    Friend Shared bAutoUpdateCheck As Boolean = False
    Friend Shared bHideNotifications As Boolean = False

    '[State] Reserved for future use
    'NORMAL = 0
    'ASSESSMENT = 1
    'FONTINSTALLER = 2
    Friend Shared intStartState As Integer = 0

    'Paths
    Friend Shared ReadOnly strSettingsFile As String = Path.Combine(FileOps.GetApplicationPath(), "Settings.ini")
    Friend Shared ReadOnly strCompatibilityFile As String = Path.Combine(FileOps.GetApplicationPath(), "Compatibility.ini")
    Friend Shared ReadOnly strOldAppdataPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Xiret")
    Friend Shared ReadOnly strAssessmentLogPath As String = Path.Combine(FileOps.GetApplicationPath(), "WinXI.log")
    Friend Shared ReadOnly strImgurUrlsPath As String = Path.Combine(FileOps.GetApplicationPath(), "imgurlinks.log")

    Friend Shared clrThemeColour As Color = Color.FromArgb(120, 180, 0)
    Friend Shared imgHeaderGraphic As Image = Nothing

#Region "Create Settings"

    Friend Shared Sub Create()

        If Not File.Exists(strSettingsFile) Then
            File.WriteAllText(strSettingsFile, My.Resources.Settings)
        End If

        If Not File.Exists(strCompatibilityFile) Then
            File.WriteAllText(strCompatibilityFile, My.Resources.Compatibility)
        End If

    End Sub

#End Region
#Region "Load Settings"

    Friend Shared Sub Load()

        If File.Exists(strSettingsFile) Then

            '[Settings]
            Try
                bShowHardwareOnStartup = CBool(IniFile.Read("Settings", "ShowHardwareOnStartup", strSettingsFile))
            Catch
                bShowHardwareOnStartup = False
            End Try

            Try
                bUseApiHardwareMode = CBool(IniFile.Read("Settings", "UseApiHardwareMode", strSettingsFile))
            Catch
                bUseApiHardwareMode = False
            End Try

            Try
                bUseVerboseAssessmentMode = CBool(IniFile.Read("Settings", "UseVerboseAssessmentMode", strSettingsFile))
            Catch ex As Exception
                bUseVerboseAssessmentMode = False
            End Try

            Try
                intThemeColourInteger = CInt(IniFile.Read("Settings", "ThemeColourInteger", strSettingsFile))
                If intThemeColourInteger < 0 OrElse intThemeColourInteger > 9 Then
                    intThemeColourInteger = 0
                End If

                Select Case intThemeColourInteger
                    Case 0
                        clrThemeColour = Color.FromArgb(120, 200, 40)
                    Case 1
                        clrThemeColour = Color.FromArgb(0, 191, 255)
                    Case 2
                        clrThemeColour = Color.FromArgb(0, 255, 181)
                    Case 3
                        clrThemeColour = Color.FromArgb(46, 220, 110)
                    Case 4
                        clrThemeColour = Color.FromArgb(255, 70, 255)
                    Case 5
                        clrThemeColour = Color.FromArgb(255, 105, 180)
                    Case 6
                        clrThemeColour = Color.FromArgb(255, 118, 0)
                    Case 7
                        clrThemeColour = Color.FromArgb(205, 219, 18)
                    Case 8
                        clrThemeColour = Color.FromArgb(255, 50, 50)
                    Case 9
                        clrThemeColour = Color.FromArgb(255, 99, 71)
                    Case Else
                        clrThemeColour = Color.FromArgb(120, 200, 40)
                End Select

            Catch
                intThemeColourInteger = 0
            End Try

            Try
                bApplyThemeColourToBorder = CBool(IniFile.Read("Settings", "ApplyThemeColourToBorder", strSettingsFile))
            Catch
                bApplyThemeColourToBorder = False
            End Try

            Try
                bUseCustomImgurApiKey = CBool(IniFile.Read("Settings", "UseCustomImgurApiKey", strSettingsFile))
                strCustomImgurApiKeyString = IniFile.Read("Settings", "CustomImgurApiKeyString", strSettingsFile)
            Catch
                bUseCustomImgurApiKey = False
            End Try

            '[Overrides]
            Try
                bAutoUpdateCheck = CBool(IniFile.Read("Overrides", "UpdateAutoCheck", strSettingsFile))
            Catch
                bAutoUpdateCheck = False
            End Try

            Try
                bHideNotifications = CBool(IniFile.Read("Overrides", "HideNotifications", strSettingsFile))
            Catch
                bHideNotifications = False
            End Try

            '[State]
            Try
                intStartState = CInt(IniFile.Read("States", "StartState", strSettingsFile))
            Catch
                intStartState = 0
            End Try

        End If

        imgHeaderGraphic = My.Resources.HeaderGraphicDefault

    End Sub

#End Region
#Region "Save Settings"

    Friend Shared Sub Save()

        If File.Exists(strSettingsFile) Then
            Dim Ini As New IniFile(strSettingsFile)
#Disable Warning BC42025
            Ini.Write("ShowHardwareOnStartup", CStr(bShowHardwareOnStartup), "Settings")
            Ini.Write("UseApiHardwareMode", CStr(bUseApiHardwareMode), "Settings")
            Ini.Write("UseVerboseAssessmentMode", CStr(bUseVerboseAssessmentMode), "Settings")
            Ini.Write("ThemeColourInteger", CStr(intThemeColourInteger), "Settings")
            Ini.Write("ApplyThemeColourToBorder", CStr(bApplyThemeColourToBorder), "Settings")
            Ini.Write("UseCustomImgurApiKey", CStr(bUseCustomImgurApiKey), "Settings")
            Ini.Write("CustomImgurApiKeyString", strCustomImgurApiKeyString, "Settings")
            Ini.Write("UpdateAutoCheck", CStr(bAutoUpdateCheck), "Overrides")
            Ini.Write("HideNotifications", CStr(bHideNotifications), "Overrides")
            Ini.Write("StartState", CStr(intStartState), "States")
#Enable Warning BC42025
        End If

    End Sub

    Friend Shared Sub SaveSingleKey(Section As String, Key As String, value As String)
        If File.Exists(strSettingsFile) Then
            Dim Ini As New IniFile(strSettingsFile)
#Disable Warning BC42025
            Ini.Write(Key, value, Section)
#Enable Warning BC42025
        End If
    End Sub

#End Region

#Region "Functions"

    Friend Shared Sub SetBorderColor(Frm As Form)

        If bApplyThemeColourToBorder Then
            Frm.BackColor = clrThemeColour
        Else
            Frm.BackColor = Colors.clrBorderStandard
        End If

    End Sub

#End Region

End Class
