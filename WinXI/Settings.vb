'   08.03.2021 - DR - Rewrite
'   01.11.2022 - DR - Omit windows server changes, supress BC42025
'   02.11.2022 - DR - Gain SaveSingleKey()

Imports System.IO
Imports WinXI.Core.Common

Friend Class Settings

    '[Settings]
    Friend Shared ShowHardwareOnStartup As Boolean = False
    Friend Shared UseApiHardwareMode As Boolean = False
    Friend Shared UseVerboseAssessmentMode As Boolean = False
    Friend Shared ThemeColourInteger As Integer = 0
    Friend Shared ApplyThemeColourToBorder As Boolean = False
    Friend Shared UseCustomImgurApiKey As Boolean = False
    Friend Shared CustomImgurApiKeyString As String = ""

    '[Overrides]
    Friend Shared UpdateAutoCheck As Boolean = False

    '[State] For future use
    Friend Shared ResetState As Integer = 0

    'Paths
    Friend Shared ReadOnly strSettingsFile As String = Path.Combine(FileOps.GetApplicationPath(), "Settings.ini")
    Friend Shared ReadOnly strCompatibilityFile As String = Path.Combine(FileOps.GetApplicationPath(), "Compatibility.ini")
    Friend Shared ReadOnly strOldAppdataPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Xiret")
    Friend Shared ReadOnly strAssessmentLogPath As String = Path.Combine(FileOps.GetApplicationPath(), "WinXI.log")
    Friend Shared ReadOnly strImgurUrlsPath As String = Path.Combine(FileOps.GetApplicationPath(), "imgurlinks.log")

    Friend Shared clrSetThemeColour As Color = Color.FromArgb(120, 180, 0)
    Friend Shared imgHeaderGraphic As Image = Nothing

#Region "Create Settings"

    Friend Shared Sub Create()

        If Not File.Exists(strSettingsFile) Then
            File.WriteAllText(strSettingsFile, My.Resources.Settings)
        End If

    End Sub

#End Region
#Region "Load Settings"

    Friend Shared Sub Load()

        If File.Exists(strSettingsFile) Then

            '[Settings]
            Try
                ShowHardwareOnStartup = CBool(IniFile.Read("Settings", "ShowHardwareOnStartup", strSettingsFile))
            Catch
                ShowHardwareOnStartup = False
            End Try

            Try
                UseApiHardwareMode = CBool(IniFile.Read("Settings", "UseApiHardwareMode", strSettingsFile))
            Catch
                UseApiHardwareMode = False
            End Try

            Try
                UseVerboseAssessmentMode = CBool(IniFile.Read("Settings", "UseVerboseAssessmentMode", strSettingsFile))
            Catch ex As Exception
                UseVerboseAssessmentMode = False
            End Try

            Try
                ThemeColourInteger = CInt(IniFile.Read("Settings", "ThemeColourInteger", strSettingsFile))
                If ThemeColourInteger < 0 OrElse ThemeColourInteger > 9 Then
                    ThemeColourInteger = 0
                End If

                Select Case ThemeColourInteger
                    Case 0
                        clrSetThemeColour = Color.FromArgb(120, 200, 40)
                    Case 1
                        clrSetThemeColour = Color.FromArgb(0, 191, 255)
                    Case 2
                        clrSetThemeColour = Color.FromArgb(0, 255, 181)
                    Case 3
                        clrSetThemeColour = Color.FromArgb(46, 220, 110)
                    Case 4
                        clrSetThemeColour = Color.FromArgb(255, 70, 255)
                    Case 5
                        clrSetThemeColour = Color.FromArgb(255, 105, 180)
                    Case 6
                        clrSetThemeColour = Color.FromArgb(255, 118, 0)
                    Case 7
                        clrSetThemeColour = Color.FromArgb(205, 219, 18)
                    Case 8
                        clrSetThemeColour = Color.FromArgb(255, 50, 50)
                    Case 9
                        clrSetThemeColour = Color.FromArgb(255, 99, 71)
                    Case Else
                        clrSetThemeColour = Color.FromArgb(120, 200, 40)
                End Select

            Catch
                ThemeColourInteger = 0
            End Try

            Try
                ApplyThemeColourToBorder = CBool(IniFile.Read("Settings", "ApplyThemeColourToBorder", strSettingsFile))
            Catch
                ApplyThemeColourToBorder = False
            End Try

            UseCustomImgurApiKey = CBool(IniFile.Read("Settings", "UseCustomImgurApiKey", strSettingsFile))
            CustomImgurApiKeyString = IniFile.Read("Settings", "CustomImgurApiKeyString", strSettingsFile)

            '[Overrides]
            Try
                UpdateAutoCheck = CBool(IniFile.Read("Overrides", "UpdateAutoCheck", strSettingsFile))
            Catch ex As Exception
                UpdateAutoCheck = False
            End Try

            '[State]
            Try
                ResetState = CInt(IniFile.Read("States", "ResetState", strSettingsFile))
            Catch ex As Exception
                ResetState = 0
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
            Ini.Write("ShowHardwareOnStartup", CStr(ShowHardwareOnStartup), "Settings")
            Ini.Write("UseApiHardwareMode", CStr(UseApiHardwareMode), "Settings")
            Ini.Write("UseVerboseAssessmentMode", CStr(UseVerboseAssessmentMode), "Settings")
            Ini.Write("ThemeColourInteger", CStr(ThemeColourInteger), "Settings")
            Ini.Write("ApplyThemeColourToBorder", CStr(ApplyThemeColourToBorder), "Settings")
            Ini.Write("UseCustomImgurApiKey", CStr(UseCustomImgurApiKey), "Settings")
            Ini.Write("CustomImgurApiKeyString", CustomImgurApiKeyString, "Settings")
            Ini.Write("UpdateAutoCheck", CStr(UpdateAutoCheck), "Overrides")
            Ini.Write("ResetState", CStr(ResetState), "States")
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

#Region "Migrate XML settings"

    'Tumbleweeds, so many of them.

#End Region

#Region "Functions"

    Friend Shared Sub SetBorderColor(Frm As Form)

        If ApplyThemeColourToBorder Then
            Frm.BackColor = clrSetThemeColour
        Else
            Frm.BackColor = Colors.clrBorderStandard
        End If

    End Sub

#End Region

End Class
