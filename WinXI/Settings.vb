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

    '[State]
    Friend Shared ResetState As Integer = 0

    'Paths
    Friend Shared ReadOnly SettingsFile As String = Path.Combine(FileOps.GetApplicationPath(), "Settings.ini")
    Friend Shared ReadOnly CompatibilityFile As String = Path.Combine(FileOps.GetApplicationPath(), "Compatibility.ini")
    Friend Shared ReadOnly AppdataPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Xiret")
    Friend Shared ReadOnly AssessmentLogPath As String = Path.Combine(FileOps.GetApplicationPath(), "WinXI.log")
    Friend Shared ReadOnly ImgurUrlsPath As String = Path.Combine(FileOps.GetApplicationPath(), "imgurlinks.log")

    Friend Shared SetThemeColour As Color = Color.FromArgb(120, 180, 0)
    Friend Shared SetHeaderGraphic As Image = Nothing

#Region "Create Settings"

    Friend Shared Sub Create()

        If Not File.Exists(SettingsFile) Then
            File.WriteAllText(SettingsFile, My.Resources.Settings)
        End If

    End Sub

#End Region
#Region "Load Settings"

    Friend Shared Sub Load()

        If File.Exists(SettingsFile) Then

            '[Settings]
            Try
                ShowHardwareOnStartup = CBool(IniFile.Read("Settings", "ShowHardwareOnStartup", SettingsFile))
            Catch
                ShowHardwareOnStartup = False
            End Try

            Try
                UseApiHardwareMode = CBool(IniFile.Read("Settings", "UseApiHardwareMode", SettingsFile))
            Catch
                UseApiHardwareMode = False
            End Try

            Try
                UseVerboseAssessmentMode = CBool(IniFile.Read("Settings", "UseVerboseAssessmentMode", SettingsFile))
            Catch ex As Exception
                UseVerboseAssessmentMode = False
            End Try

            Try
                ThemeColourInteger = CInt(IniFile.Read("Settings", "ThemeColourInteger", SettingsFile))
                If ThemeColourInteger < 0 OrElse ThemeColourInteger > 9 Then
                    ThemeColourInteger = 0
                End If

                Select Case ThemeColourInteger
                    Case 0
                        SetThemeColour = Color.FromArgb(120, 200, 40)
                    Case 1
                        SetThemeColour = Color.FromArgb(0, 191, 255)
                    Case 2
                        SetThemeColour = Color.FromArgb(0, 255, 181)
                    Case 3
                        SetThemeColour = Color.FromArgb(46, 220, 110)
                    Case 4
                        SetThemeColour = Color.FromArgb(255, 70, 255)
                    Case 5
                        SetThemeColour = Color.FromArgb(255, 105, 180)
                    Case 6
                        SetThemeColour = Color.FromArgb(255, 118, 0)
                    Case 7
                        SetThemeColour = Color.FromArgb(205, 219, 18)
                    Case 8
                        SetThemeColour = Color.FromArgb(255, 50, 50)
                    Case 9
                        SetThemeColour = Color.FromArgb(255, 99, 71)
                    Case Else
                        SetThemeColour = Color.FromArgb(120, 200, 40)
                End Select

            Catch
                ThemeColourInteger = 0
            End Try

            Try
                ApplyThemeColourToBorder = CBool(IniFile.Read("Settings", "ApplyThemeColourToBorder", SettingsFile))
            Catch
                ApplyThemeColourToBorder = False
            End Try

            UseCustomImgurApiKey = CBool(IniFile.Read("Settings", "UseCustomImgurApiKey", SettingsFile))
            CustomImgurApiKeyString = IniFile.Read("Settings", "CustomImgurApiKeyString", SettingsFile)

            '[Overrides]
            Try
                UpdateAutoCheck = CBool(IniFile.Read("Overrides", "UpdateAutoCheck", SettingsFile))
            Catch ex As Exception
                UpdateAutoCheck = False
            End Try

            '[State]
            Try
                ResetState = CInt(IniFile.Read("States", "ResetState", SettingsFile))
            Catch ex As Exception
                ResetState = 0
            End Try

        End If

        SetHeaderGraphic = My.Resources.HeaderGraphicDefault

    End Sub

#End Region
#Region "Save Settings"

    Friend Shared Sub Save()

        If File.Exists(SettingsFile) Then
            Dim Ini As New IniFile(SettingsFile)
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
        If File.Exists(SettingsFile) Then
            Dim Ini As New IniFile(SettingsFile)
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
            Frm.BackColor = SetThemeColour
        Else
            Frm.BackColor = Colors.clrBorderStandard
        End If

    End Sub

    Friend Shared Sub CheckDataPath()
        If Not Directory.Exists(AppdataPath) Then
            Directory.CreateDirectory(AppdataPath)
        End If
    End Sub

#End Region

End Class
