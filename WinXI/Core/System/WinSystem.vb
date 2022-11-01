'   04.04.2021 - DR - New versioning methods, update GetWindowsUptime(), bugfixing.
'   30.10.2022 - DR - Update GetWindowsName() as MS did not update the registry from 10 > 11, omit windows server changes, remove win releaseid
'   Checked for WinXI on 30.10.2022
'   01.11.2022 - DR - Add WinSAT capability changes

Imports System.IO
Imports Microsoft.Win32

Namespace Core.System

    NotInheritable Class WinSystem

        Private Shared ReadOnly SystemDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.System)

        Friend Shared ReadOnly KernelVersion As FileVersionInfo = FileVersionInfo.GetVersionInfo(Path.Combine(SystemDirectory, "kernel32.dll"))
        Friend Shared ReadOnly WinsatVersion As FileVersionInfo = FileVersionInfo.GetVersionInfo(Path.Combine(SystemDirectory, "winsat.exe"))
        Friend Shared ReadOnly WinsatApiVersion As FileVersionInfo = FileVersionInfo.GetVersionInfo(Path.Combine(SystemDirectory, "winsatapi.dll"))

        Friend Shared Function IsWinSATCapable() As Boolean

            If Not File.Exists(Files.WinsatApi) Then
                Return False
            End If

            If Not File.Exists(Files.WinsatApi) Then
                Return False
            End If

            Return True

        End Function

#Region "Bools"
        Friend Shared Function IsWinVista() As Boolean
            If (KernelVersion.ProductMajorPart = 6) And (KernelVersion.ProductMinorPart = 0) Then
                Return True 'Vista, ret true.
            End If
            Return False
        End Function
        Friend Shared Function IsWin7() As Boolean
            If (KernelVersion.ProductMajorPart = 6) And (KernelVersion.ProductMinorPart = 1) Then
                Return True 'W7, ret true.
            End If
            Return False
        End Function
        Friend Shared Function IsWin8() As Boolean
            If (KernelVersion.ProductMajorPart = 6) And (KernelVersion.ProductMinorPart = 2) Then
                Return True 'W8 ret true.
            End If
            Return False
        End Function
        Friend Shared Function IsWin81() As Boolean

            If (KernelVersion.ProductMajorPart = 6) And (KernelVersion.ProductMinorPart = 3) Then
                Return True 'W8.1 ret true
            End If
            Return False
        End Function
        Friend Shared Function IsWin10() As Boolean
            If (KernelVersion.ProductMajorPart = 10) And (KernelVersion.ProductMinorPart = 0) Then
                Return True 'W10, ret true.
            End If
            Return False
        End Function

        'Friend Shared Function IsWinServer() As Boolean

        '    Using Searcher As New ManagementObjectSearcher("SELECT ProductType FROM Win32_OperatingSystem")
        '        For Each MObj As ManagementObject In Searcher.Get()
        '            Dim Int As UInteger = CUInt(MObj.GetPropertyValue("ProductType"))
        '            Return Int <> 1 'Server build, ret true.
        '        Next
        '    End Using

        '    Return False 'Ret false, not server.

        'End Function
#End Region
#Region "Name"

        Public Shared Function GetName() As String

            Try
                'Return Registry.GetValue(Strings.HKLMCV, "ProductName", Nothing).ToString().Replace(" (TM)", "™")
                Return My.Computer.Info.OSFullName.Replace("Microsoft ", "")
            Catch
                Return "Windows"
            End Try

        End Function

#End Region
#Region "Architecture"
        Public Shared Function GetWindowsBitness(Optional ShortArc As Boolean = False) As String

            If Environment.Is64BitOperatingSystem Then
                If ShortArc Then
                    Return "x64"
                Else
                    Return "64-Bit"
                End If
            Else
                If ShortArc Then
                    Return "x86"
                Else
                    Return "32-Bit"
                End If
            End If

        End Function
        Public Shared Function IsWindows64Bit() As Boolean

            If Environment.Is64BitOperatingSystem Then
                Return True  'x64
            Else
                Return False 'x86
            End If

        End Function

#End Region
#Region "Service Pack"

        Public Shared Function GetWindowsServicePack() As String

            Dim strServicePack As String = Environment.OSVersion.ServicePack

            If strServicePack.Length = 0 Then
                Return "N/A"
            Else
                Return strServicePack
            End If

        End Function

#End Region
#Region "Uptime"

        Public Shared Function GetWindowsUptime() As String

            Try
                Dim Int As Integer = CInt(NativeMethods.GetTickCount() / 1000)
                Return Format$(Int \ 3600 \ 24, "0") & "d, " & Format$((Int \ 3600) Mod 24, "00") & "h, " _
                     & Format$((Int Mod 3600) \ 60, "00") & "m, " & Format$(Int Mod 60, "00") & "s"
            Catch
                Return "Unknown"
            End Try

        End Function

#End Region
#Region "Install Date"

        Public Shared Function GetWindowsInstallDate() As String

            Dim Reg As String = CStr(Registry.GetValue(Strings.HKLMCV, "InstallDate", Nothing))

            Try
                If Not Reg.Length = 0 Then
                    Dim DawnOfTime As Date 'Not funny
                    Dim Lng As Long
                    DawnOfTime = New DateTime(1970, 1, 1, 0, 0, 0).ToLocalTime
                    Lng = Convert.ToInt64(Reg.ToString())
                    Return CStr(DawnOfTime.AddSeconds(Lng))
                End If
                Return Date.MinValue & " (Error)"
            Catch
                Return Date.MinValue & " (Error)"
            End Try

        End Function

#End Region
#Region "Versioning"

        Friend Shared Function CurrentBuild() As Integer

            Dim Val As Integer = CInt(Registry.GetValue(Strings.HKLMCV, "CurrentBuild", Nothing))

            If Val = 0 Or Nothing Then
                Return 0
            Else
                Return Val
            End If

        End Function
        Friend Shared Function BuildBranch() As String

            Select Case CurrentBuild()
                Case 10240
                    Return "TH1"
                Case 10586
                    Return "TH2"
                Case 14393
                    Return "RS1"
                Case 15063
                    Return "RS2"
                Case 16299
                    Return "RS3"
                Case 17134
                    Return "RS4"
                Case 17763
                    Return "RS5"
                Case 18362
                    Return "19H1"
                Case 18363
                    Return "19H2"
                Case 19041
                    Return "20H1"
                Case 19042
                    Return "20H2"
                Case 19043
                    Return "21H1"
                Case 22622
                    Return "22H2"
                Case Else
                    Return "Not Set"
            End Select

        End Function
        'Friend Shared Function ReleaseId() As String

        '    Select Case CurrentBuild()
        '        Case 10240
        '            Return "1507"
        '        Case 10586
        '            Return "1511"
        '        Case 14393
        '            Return "1607"
        '        Case 15063
        '            Return "1703"
        '        Case 16299
        '            Return "1709"
        '        Case 17134
        '            Return "1803"
        '        Case 17763
        '            Return "1809"
        '        Case 18362
        '            Return "1903"
        '        Case 18363
        '            Return "1909"
        '        Case 19041
        '            Return "2004"
        '        Case 19042
        '            Return "2009"
        '        Case 19043
        '            Return "Not Set (21H1)"
        '        Case Else
        '            Return "Not Set"
        '    End Select

        'End Function
#End Region
#Region "Build Lab"

        Public Shared Function GetWindowsBuildLab() As String

            Try
                Return CStr(Registry.GetValue(Strings.HKLMCV, "BuildLab", Nothing))
            Catch
                Return "Not found"
            End Try

        End Function

#End Region
#Region "Username"
        Public Shared Function GetUsername() As String
            Return Environment.UserName
        End Function
#End Region

    End Class

End Namespace


