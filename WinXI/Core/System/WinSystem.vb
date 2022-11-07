﻿'   30.10.2022 - DR - Update GetWindowsName() as MS did not update the registry from 10 > 11, omit windows server changes, remove win releaseid
'   Checked for WinXI on 30.10.2022
'   01.11.2022 - DR - Add WinSAT capability changes

Imports System.IO
Imports Microsoft.Win32

Namespace Core.System

    NotInheritable Class WinSystem

        Private Shared ReadOnly strSystemDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.System)

        Friend Shared bIsWinsatCapable As Boolean = False

        Friend Shared ReadOnly fviKernelVersion As FileVersionInfo = FileVersionInfo.GetVersionInfo(Path.Combine(strSystemDirectory, "kernel32.dll"))
        Friend Shared ReadOnly fviWinsatVersion As FileVersionInfo = FileVersionInfo.GetVersionInfo(Path.Combine(strSystemDirectory, "winsat.exe"))
        Friend Shared ReadOnly fviWinsatApiVersion As FileVersionInfo = FileVersionInfo.GetVersionInfo(Path.Combine(strSystemDirectory, "winsatapi.dll"))

        Private Const strRegistryHKLM As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion"

        Friend Shared Function IsWinSATCapable() As Boolean

            If Not File.Exists(Files.WinsatApi) Then
                Return False
            End If

            If Not File.Exists(Files.WinsatApi) Then
                Return False
            End If

            Return True

        End Function

#Region "Booleans"

        Friend Shared Function IsWinVista() As Boolean
            If (fviKernelVersion.ProductMajorPart = 6) And (fviKernelVersion.ProductMinorPart = 0) Then
                Return True
            End If
            Return False
        End Function

        Friend Shared Function IsWin7() As Boolean
            If (fviKernelVersion.ProductMajorPart = 6) And (fviKernelVersion.ProductMinorPart = 1) Then
                Return True
            End If
            Return False
        End Function

        Friend Shared Function IsWin8() As Boolean
            If (fviKernelVersion.ProductMajorPart = 6) And (fviKernelVersion.ProductMinorPart = 2) Then
                Return True
            End If
            Return False
        End Function

        Friend Shared Function IsWin81() As Boolean
            If (fviKernelVersion.ProductMajorPart = 6) And (fviKernelVersion.ProductMinorPart = 3) Then
                Return True
            End If
            Return False
        End Function

        Friend Shared Function IsWin10() As Boolean
            If (fviKernelVersion.ProductMajorPart = 10) And (fviKernelVersion.ProductMinorPart = 0) Then
                Return True
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

        Public Shared Function GetProductName() As String

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
            Return CStr(IIf(CInt(strServicePack.Length) = 0, "N/A", strServicePack))

        End Function

#End Region
#Region "Uptime"

        Public Shared Function GetWindowsUptime() As String

            Try
                Dim intTick As Integer = CInt(NativeMethods.GetTickCount() / 1000)
                Return Format$(intTick \ 3600 \ 24, "0") & "d, " & Format$((intTick \ 3600) Mod 24, "00") & "h, " _
                     & Format$((intTick Mod 3600) \ 60, "00") & "m, " & Format$(intTick Mod 60, "00") & "s"
            Catch
                Return "Unknown"
            End Try

        End Function

#End Region
#Region "Install Date"

        Public Shared Function GetWindowsInstallDate() As String

            Dim strRegKey As String = CStr(Registry.GetValue(strRegistryHKLM, "InstallDate", Nothing))

            Try
                If Not strRegKey.Length = 0 Then
                    Dim dDate As Date 'Not funny
                    Dim lLong As Long
                    dDate = New DateTime(1970, 1, 1, 0, 0, 0).ToLocalTime
                    lLong = Convert.ToInt64(strRegKey.ToString())
                    Return CStr(dDate.AddSeconds(lLong))
                End If
            Catch
                Return Date.MinValue & " (Error)"
            End Try

            Return CStr(Date.MinValue)

        End Function

#End Region
#Region "Versioning"

        Friend Shared Function CurrentBuild() As Integer

            Dim intValue As Integer = CInt(Registry.GetValue(strRegistryHKLM, "CurrentBuild", Nothing))

            'If intValue = 0 Or Nothing Then
            '    Return 0
            'Else
            '    Return intValue
            'End If

            Return CInt(IIf(intValue = 0 Or Nothing, 0, intValue))

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
                Return CStr(Registry.GetValue(strRegistryHKLM, "BuildLab", Nothing))
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

