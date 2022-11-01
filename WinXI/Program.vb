' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' '
'                                                                                                           '           
'  WinXI - Win Experience Index UI. A portable replacement for the Windows Experience Index                 '
'  Created by David R aka Muerto on 24.03.2016.                                                             '
'  This software is copyright and released under the GNU GPL v3.0 license.                                  '
'  https://github.com/MuertoGB                                                                              '
'                                                                                                           '
' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' ' '

'   01.11.2022 - DR - Impliment elevation changes, omit windows server changes, add capability check for WinSAT

Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Runtime.CompilerServices

Imports WinXI.Main.Support
Imports WinXI.Core.Common
Imports WinXI.Core.System

Friend Class Program
    Inherits Signing

    ' // FILL BEFORE RELEASE
    Friend Shared ReadOnly X_Version As String = Application.ProductVersion
    Friend Const X_Build As String = "221011.220.034"
    Friend Const X_Channel As String = "Alpha"
    Friend Const X_ReleaseDate As String = "Not set"

    ' Main entry point
    <STAThread()>
    Friend Shared Sub Main(Args() As String)

        'Set DPI scaling.
        NativeMethods.SetProcessDPIAware()

        'Signature validation
        RuntimeHelpers.RunClassConstructor(GetType(Signing).TypeHandle)

        'Settings
        Settings.Create() 'Performs a check, creates file if missing.
        Settings.Load()

        If Not WinSystem.IsWin10 Then 'Windows 10 already ships with all required fonts
            CheckFonts() 'Moved here on 23.10.2019 (Before text rendering is set)
        End If

        If Not WinSystem.IsWinSATCapable Then
            Booleans.bIncapableOfWinsat = True
        End If

        'Framework
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Booleans.bIsElevated = CBool(IIf(Core.Elevation.IsElevated, True, False))

        Dim Startup As New ApplicationSupport(FormMain, Args)

    End Sub

#Region "Functions"

    Private Shared Function DoesFontExist(Font_Family As String, Font_Style As FontStyle) As Boolean

        Try
            Using FF As FontFamily = New FontFamily(Font_Family)
                Return FF.IsStyleAvailable(Font_Style)
            End Using
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Shared Sub CheckFonts()

        Dim DidInstall As Boolean = False

        If Not DoesFontExist("Segoe UI", FontStyle.Regular) Then
            Dim i As Integer = FontInstaller.InstallFont(FontInstaller.SystemFontSegoeUI, My.Resources.segoeui, "Segoe UI")
            If i = 1 Then
                DidInstall = True
            End If
        End If

        If Not DoesFontExist("Segoe UI", FontStyle.Bold) Then
            Dim i As Integer = FontInstaller.InstallFont(FontInstaller.SystemFontSegoeUIBold, My.Resources.segoeuib, "Segoe UI Bold")
            If i = 1 Then
                DidInstall = True
            End If
        End If

        If Not DoesFontExist("Segoe UI Semibold", FontStyle.Regular) Then
            Dim i As Integer = FontInstaller.InstallFont(FontInstaller.SystemFontSegoeUISemibold, My.Resources.seguisb, "Segoe UI Semibold")
            If i = 1 Then
                DidInstall = True
            End If
        End If

        If Not DoesFontExist("Segoe MDL2 Assets", FontStyle.Regular) Then
            Dim i As Integer = FontInstaller.InstallFont(FontInstaller.SystemFontSegoeAssets, My.Resources.segmdl2, "Segoe MDL2 Assets")
            If i = 1 Then
                DidInstall = True
            End If
        End If

        If DidInstall Then
            MessageBox.Show("One or more fonts from the Segoe family were installed for proper functionality. The font(s) may take a few moments to register on slower systems." & vbCrLf & vbCrLf & "Please restart the application.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Environment.Exit(0)
        End If

    End Sub
#End Region

End Class
Namespace Main.Support

    Friend Class ApplicationSupport
        Inherits WindowsFormsApplicationBase

        Friend Shared StartInfo As ProcessStartInfo
        Friend Shared RunElevated As Process

        Friend Sub New(MainForm As Form, Args() As String)

            MyBase.MainForm = MainForm
            EnableVisualStyles = True
            ShutdownStyle = ShutdownMode.AfterMainFormCloses
            IsSingleInstance = True
            Run(Args)

        End Sub

#Region "Application Startup"
        Private ReadOnly FEnvironment As New FormEnvironment
        Private Sub ApplicationSupport_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup

            AddHandler FEnvironment.FormClosed, AddressOf Wait

            If WinSystem.KernelVersion.ProductMajorPart < 6 Then
                FEnvironment.ShowDialog()
            End If

            If Booleans.bIncapableOfWinsat Then
                FEnvironment.ShowDialog()
            End If

        End Sub

        Private Sub Wait(sender As Object, e As EventArgs)
            Environment.Exit(0)
        End Sub

#End Region
#Region "Application Shutdown"

        Friend Shared Sub ApplicationSupport_Shutdown() Handles Me.Shutdown

            ' Tumbleweed

        End Sub

#End Region
#Region "Application Next Instance"

        Private Sub ApplicationSupport_StartupNextInstance(sender As Object, e As StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            e.BringToForeground = True
        End Sub

#End Region
#Region "Unhandled Exception"

        Friend Shared StringException As String
        Friend Shared StringExceptionMessage As String


        Private Sub ApplicationSupport_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException

            StringException = e.Exception.Message
            StringExceptionMessage = Convert.ToString(e.Exception)

            Dim FException As New FormException

            With FException
                .ShowDialog()
                .BringToFront()
            End With

            e.ExitApplication = False

        End Sub

#End Region
#Region "Elevation"

        Friend Shared Sub RestartElevated()

            'Sometimes previous instance hangs around for a moment, need to figure why.
            If Not Booleans.bIsElevated Then
                Try
                    StartInfo = New ProcessStartInfo() With {
                        .UseShellExecute = True,
                        .WorkingDirectory = FileOps.GetApplicationPath(),
                        .FileName = FileOps.GetApplicationImage(),
                        .Verb = "runas"}

                    RunElevated = New Process() With {.StartInfo = StartInfo}
                    RunElevated.Start()
                    Environment.Exit(-101)
                Catch ex As Exception
                    MessageBox.Show("Could not perform elevated restart." & vbCrLf & ex.ToString, "ApplicationSupport.RestartElevated()", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If

        End Sub

#End Region

    End Class

End Namespace