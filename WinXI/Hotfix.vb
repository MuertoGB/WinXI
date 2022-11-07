'   07.11.2022 - DR - Create Hotfix.vb

'   Simply trying to find a hotfix was flawed from the start, now we look for affected
'   WinSAT versions instead and go from there.

'  ExecTask and InstallMsu are original content by DavidXanatos and are
'  licensed under the GNU General Public License v3.0. See the license
'  terms here:
'  https://github.com/DavidXanatos/wumgr/blob/master/LICENSE

'  Code converted to VB.NET by Muerto which is being disclosed per the
'  license terms. Apart from the conversion no code was changed in these
'  routines apart from some simplifications.

Imports System.Linq
Imports WinXI.Core.System

Public Class Hotfix

    'List of affected WinSAT versions (Failed to properly assess the disk. The parameter is incorrect.)
    Friend Shared strListOfAffectedWinsat() As String = {"6.1.7600.16976", "6.1.7600.21167", "6.1.7601.17793", "6.1.7601.21940"}
    Friend Shared bIsWinSATAffected As Boolean = False

    Friend Shared Function IsWinSATAffected() As Boolean

        'We only need to check on Windows 7 (6.1).
        If WinSystem.IsWin7 Then
            'Get the current winsat executable version.
            Dim fviWinsatExecutable As String = FileVersionInfo.GetVersionInfo(Files.WinsatExe).ProductVersion
            'Check the list of affected versions against the current executable.
            If strListOfAffectedWinsat.Contains(fviWinsatExecutable) Then
                Return True 'A bugged version was found.
            End If
        End If

        Return False 'A bugged version was not found.

    End Function

#Region "Install MSU"
    Public Shared Function InstallMsu(ByVal FileName As String) As Integer
        Dim psiInfo As ProcessStartInfo = New ProcessStartInfo With {
                .FileName = "%SystemRoot%\System32\wusa.exe",
                .Arguments = """" & FileName & """ /quiet /norestart"
            }
        Return ExecTask(psiInfo)
    End Function

    Public Shared Function ExecTask(ByVal StartInfo As ProcessStartInfo, ByVal Optional SilentInstall As Boolean = True) As Integer

        StartInfo.FileName = Environment.ExpandEnvironmentVariables(StartInfo.FileName)

        If SilentInstall Then
            With StartInfo
                .RedirectStandardOutput = True
                .RedirectStandardError = True
                .UseShellExecute = False
                .CreateNoWindow = True
            End With
        End If

        Dim pNew As Process = New Process With {
                .StartInfo = StartInfo,
                .EnableRaisingEvents = True
            }

        pNew.Start()
        pNew.WaitForExit()

        Return pNew.ExitCode

    End Function

#End Region

End Class
