'   01.02.2020 - CA - Revert settings var CreateFilepath, enhanced deletion of config files
'   01.11.2022 - DR - Impliment elevation changes
'   06.11.2022 - DR - Add compatibility.ini to deletion list

Imports System.IO
Imports WinXI.Core

Public Class FormReset

#Region "Ctor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetCleanupThemeAccent()

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

    Private Sub FormCleanup_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub FormCleanup_Load(sender As Object, e As EventArgs) Handles Me.Load

        lblWarning.Visible = False

        'If not elevated, we cannot touch WinSAT config files
        If Not Elevation.bIsElevated Then
            lblWinSAT.Text &= " (Requires elevation)"
            cbAgreeWinsat.Enabled = False
        End If

    End Sub

#End Region

#Region "Theme"

    Private Sub SetCleanupThemeAccent()

        Dim TC As Color = Settings.clrThemeColour

        pnlSplit.BackColor = TC
        cbAgreeWinsat.CheckedColor = TC
        cbAgreeApplication.CheckedColor = TC
        cmdDelete.ForeColor = TC

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub CmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click

        Try
            If cbAgreeWinsat.Checked Then
                'Delete system scores
                BatchRemoveFiles("*.xml", Directories.WinsatDatastorePath)
                'Delete winsat log
                BatchRemoveFiles("*.log", Directories.WinsatPath)
            End If

            If cbAgreeApplication.Checked Then

                'Enumerate configs + storage files
                Dim HS As New List(Of String) From {
                Settings.strSettingsFile,          'Settings (Local)
                Settings.strAssessmentLogPath,     'Log file
                Settings.strImgurUrlsPath,         'Imgur URL storage
                Settings.strCompatibilityFile      'Compatibility file
                }

                'Delete files in list ^
                For Each Hit As String In HS
                    If File.Exists(Hit) Then
                        File.Delete(Hit)
                    End If
                Next

                'Delete old application data directory
                If Directory.Exists(Settings.strOldAppdataPath) Then
                    Directory.Delete(Settings.strOldAppdataPath)
                End If

                Application.Exit()

            Else
                Application.Restart()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured during deletion:" & vbCrLf & ex.Message, "CmdDelete.Click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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
#Region "Checkbox Event Handlers"

    Private Sub Checkboxes_CheckedChanged(sender As Object, e As EventArgs) Handles cbAgreeApplication.CheckedChanged, cbAgreeWinsat.CheckedChanged

        If cbAgreeWinsat.Checked Or cbAgreeApplication.Checked Then
            cmdDelete.Enabled = True
            lblWarning.Visible = True
        Else
            cmdDelete.Enabled = False
            lblWarning.Visible = False
        End If

    End Sub

#End Region

#Region "Routines"

    Private Sub BatchRemoveFiles(Flags As String, DirPath As String)

        Dim Array() As String = Directory.GetFileSystemEntries(DirPath, Flags)
        For Each Hit As String In Array
            If Not Directory.Exists(Hit) Then
                File.Delete(Path.Combine(DirPath, Path.GetFileName(Hit)))
            End If
        Next

    End Sub

#End Region

End Class