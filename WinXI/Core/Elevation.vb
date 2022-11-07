﻿'   30.11.2022 - DR - Create Elevation.vb
'   01.11.2022 - DR - Gain RestartElevated()
'   05.11.2022 - DR - Moved some vars into RestartElevated()

Imports System.Security.Principal
Imports WinXI.Core.Common

Namespace Core

    NotInheritable Class Elevation

        Friend Shared bIsElevated As Boolean = False

        Friend Shared Function IsElevated() As Boolean
            Return New WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)
        End Function

        Friend Shared Sub RestartElevated()

            Dim psiInfo As ProcessStartInfo
            Dim pNewWinXI As Process
            'Sometimes previous instance hangs around for a moment, need to figure why.
            If Not bIsElevated Then
                Try
                    psiInfo = New ProcessStartInfo() With {
                        .UseShellExecute = True,
                        .WorkingDirectory = FileOps.GetApplicationPath(),
                        .FileName = FileOps.GetApplicationImage(),
                        .Verb = "runas"}

                    pNewWinXI = New Process() With {.StartInfo = psiInfo}
                    pNewWinXI.Start()
                    Environment.Exit(-101)
                Catch ex As Exception
                    MessageBox.Show("Could not perform elevated restart." & vbCrLf & ex.ToString, "ApplicationSupport.RestartElevated()", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        End Sub

    End Class

End Namespace