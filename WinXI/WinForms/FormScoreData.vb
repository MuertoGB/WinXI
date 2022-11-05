'   07.08.2019 - DR - Add constructor, update theme, update WndProc
'   21.01.2020 - DR - Update GetXMLInfoWinsat to notify of empty sections and XML data
'   02.11.2022 - DR - Remove unsused var

'  The GetWinsatXmlInfo code is terrible, I understand that. But it works. IT WORKS. NOW GET OUT.

Imports System.Linq
Imports System.Xml
Imports WinXI.Winsat

Public Class FormScoreData

    Private ReadOnly arrBlacklist() As String = {"Signature", "L1Cache", "L2Cache", "L3Cache", "LogicalProcessorInfo"}
    Private rtfProgramInfo As New RichTextBox
    Private rtbSystemEnvironment As New RichTextBox
    Private rtfWinspr As New RichTextBox
    Private rtfMetrics As New RichTextBox
    Private rtfWinSystem As New RichTextBox
    Private rtfSystem As New RichTextBox
    Private rtfProcessor As New RichTextBox
    Private rtfMemory As New RichTextBox
    Private rtfGraphics As New RichTextBox
    Private rtfDisk As New RichTextBox
    Private rtfDwm As New RichTextBox
    Private rtfD3d As New RichTextBox

#Region "Constructor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetMetricsThemeAccent()

        pnlTitle.BackgroundImage = Settings.imgHeaderGraphic

    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, icnMain.MouseMove, tlpTitleIcon.MouseMove, lblTitle.MouseMove

        If e.Button = MouseButtons.Left Then
            DirectCast(sender, Control).Capture = False
            WndProc(Message.Create(Handle, Integers.WM_NCLBUTTONDOWN, CType(Integers.HT_CAPTION, IntPtr), IntPtr.Zero))
        End If

    End Sub

#End Region
#Region "KeyDown Events"

    Private Sub FormMetrics_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub FormMetrics_Load(sender As Object, e As EventArgs) Handles Me.Load

        ResetActivate(PbxProgramInfo, cmdProgramInfo)
        GetWinsatXmlInfo("ProgramInfo", False)

    End Sub

#End Region

#Region "Theme"

    Private Sub SetMetricsThemeAccent()

        Dim TC As Color = Settings.clrThemeColour

        pnlSplit.BackColor = TC

        For Each Ctrl As Control In tlpMenuControls.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = TC
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub CmdProgramInfo_Click(sender As Object, e As EventArgs) Handles cmdProgramInfo.Click

        ResetActivate(PbxProgramInfo, CType(sender, Button))
        ClearRichTextBoxData(rtbData)

        If rtfProgramInfo.Text.Length <= 0 Then
            GetWinsatXmlInfo("ProgramInfo", False)
            rtfProgramInfo.Rtf = rtbData.Rtf
        Else
            rtbData.Rtf = rtfProgramInfo.Rtf
        End If

    End Sub

    Private Sub CmdSysEnviron_Click(sender As Object, e As EventArgs) Handles cmdSystemEnvironment.Click

        ResetActivate(pbxSystemEnvironmentSelected, CType(sender, Button))
        ClearRichTextBoxData(rtbData)

        If rtbSystemEnvironment.Text.Length <= 0 Then
            GetWinsatXmlInfo("SystemEnvironment", False)
            rtbSystemEnvironment.Rtf = rtbData.Rtf
        Else
            rtbData.Rtf = rtbSystemEnvironment.Rtf
        End If

    End Sub

    Private Sub CmdWinSpr_Click(sender As Object, e As EventArgs) Handles cmdWinSPR.Click

        ResetActivate(pbxWinSPRSelected, CType(sender, Button))
        ClearRichTextBoxData(rtbData)

        If rtfWinspr.Text.Length <= 0 Then
            GetWinsatXmlInfo("WinSPR", False)
            rtfWinspr.Rtf = rtbData.Rtf
        Else
            rtbData.Rtf = rtfWinspr.Rtf
        End If

    End Sub

    Private Sub CmdMetrics_Click(sender As Object, e As EventArgs) Handles cmdMetrics.Click

        ResetActivate(pbxMetricsSelected, CType(sender, Button))
        ClearRichTextBoxData(rtbData)

        If rtfMetrics.Text.Length <= 0 Then
            GetWinsatXmlInfo("Metrics", False)
            rtfMetrics.Rtf = rtbData.Rtf
        Else
            rtbData.Rtf = rtfMetrics.Rtf
        End If

    End Sub

    Private Sub CmdOS_Click(sender As Object, e As EventArgs) Handles cmdOSVersion.Click

        ResetActivate(pbxOSSelected, CType(sender, Button))
        ClearRichTextBoxData(rtbData)

        If rtfWinSystem.Text.Length <= 0 Then
            GetWinsatXmlInfo("OSVersion", False)
            GetWinsatXmlInfo("Platform", False)
            rtfWinSystem.Rtf = rtbData.Rtf
        Else
            rtbData.Rtf = rtfWinSystem.Rtf
        End If

    End Sub

    Private Sub CmdSystem_Click(sender As Object, e As EventArgs) Handles cmdSystem.Click

        ResetActivate(PbxSystem, CType(sender, Button))
        ClearRichTextBoxData(rtbData)

        If rtfSystem.Text.Length <= 0 Then
            GetWinsatXmlInfo("MotherBoard", False)
            GetWinsatXmlInfo("BIOS", False)
            GetWinsatXmlInfo("Machine", False)
            rtfSystem.Rtf = rtbData.Rtf
        Else
            rtbData.Rtf = rtfSystem.Rtf
        End If

    End Sub

    Private Sub CmdProcessor_Click(sender As Object, e As EventArgs) Handles cmdProcessor.Click

        ResetActivate(PbxProcessor, CType(sender, Button))
        ClearRichTextBoxData(rtbData)

        If rtfProcessor.Text.Length <= 0 Then
            GetWinsatXmlInfo("Processor", False)
            GetWinsatXmlInfo("Signature", True)
            GetWinsatXmlInfo("L1Cache", True)
            GetWinsatXmlInfo("L2Cache", True)
            GetWinsatXmlInfo("L3Cache", True)
            GetWinsatXmlInfo("LogicalProcessorInfo", True)
            rtfProcessor.Rtf = rtbData.Rtf
        Else
            rtbData.Rtf = rtfProcessor.Rtf
        End If

    End Sub

    Private Sub CmdMemory_Click(sender As Object, e As EventArgs) Handles cmdMemory.Click

        ResetActivate(pbxMemorySelected, CType(sender, Button))
        ClearRichTextBoxData(rtbData)

        If rtfMemory.Text.Length <= 0 Then
            GetWinsatXmlInfo("Memory", False)
            rtfMemory.Rtf = rtbData.Rtf
        Else
            rtbData.Rtf = rtfMemory.Rtf
        End If

    End Sub

    Private Sub CmdGraphics_Click(sender As Object, e As EventArgs) Handles cmdGraphics.Click

        ResetActivate(pbxGraphicsSelected, CType(sender, Button))
        ClearRichTextBoxData(rtbData)

        If rtfGraphics.Text.Length <= 0 Then
            GetWinsatXmlInfo("Graphics", False)
            GetWinsatXmlInfo("Monitors", False)
            rtfGraphics.Rtf = rtbData.Rtf
        Else
            rtbData.Rtf = rtfGraphics.Rtf
        End If

    End Sub

    Private Sub CmdDisk_Click(sender As Object, e As EventArgs) Handles cmdDisk.Click

        ResetActivate(pbxDiskSelected, CType(sender, Button))
        ClearRichTextBoxData(rtbData)

        If rtfDisk.Text.Length <= 0 Then
            GetWinsatXmlInfo("SystemDisk", False)
            rtfDisk.Rtf = rtbData.Rtf
        Else
            rtbData.Rtf = rtfDisk.Rtf
        End If

    End Sub

    Private Sub CmdDwm_Click(sender As Object, e As EventArgs) Handles cmdDwm.Click

        ResetActivate(pbxDwmSelected, CType(sender, Button))
        ClearRichTextBoxData(rtbData)

        If rtfDwm.Text.Length <= 0 Then
            GetWinsatXmlInfo("DWMAssessment", False)
            rtfDwm.Rtf = rtbData.Rtf
        Else
            rtbData.Rtf = rtfDwm.Rtf
        End If

    End Sub

    Private Sub CmdD3D_Click(sender As Object, e As EventArgs) Handles cmdD3d.Click

        ResetActivate(pbxD3dSelected, CType(sender, Button))
        ClearRichTextBoxData(rtbData)

        If rtfD3d.Text.Length <= 0 Then
            GetWinsatXmlInfo("D3DAssessment", False)
            rtfD3d.Rtf = rtbData.Rtf
        Else
            rtbData.Rtf = rtfD3d.Rtf
        End If

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

    Private Sub GetWinsatXmlInfo(LookIn As String, IsInnerNode As Boolean)

        If IsInnerNode Then
            Format("Output from " & LookIn, "", Color.MediumOrchid, Color.White)
        Else
            Format("> " & LookIn, "", Color.LightSalmon, Color.White)
        End If

        rtbData.AppendText(vbCrLf)

        Dim xmlDoc As New XmlDocument
        Dim xmlList As XmlNodeList

        xmlDoc.Load(WinsatReader.strLatestFormalXml)
        xmlList = xmlDoc.GetElementsByTagName(LookIn)

        Dim strAttribs As String = ""

        If xmlList.Count = 0 Then
            Format("", "  - XML section empty", Color.LightCoral, Color.White)
            rtbData.AppendText(vbCrLf)
        End If

        For Each xmNode As XmlNode In xmlList
            For Each xmBaseNode As XmlNode In xmNode
                If xmBaseNode.Attributes IsNot Nothing Then
                    For Each xmlAttrib As XmlAttribute In xmBaseNode.Attributes
                        strAttribs += xmlAttrib.Name & ": " & xmlAttrib.Value & " "
                    Next
                End If

                Format(" " & xmBaseNode.Name & " ", strAttribs, Color.LightSkyBlue, Color.FromArgb(250, 236, 133))
                strAttribs = ""

                If xmBaseNode.ChildNodes.Count = 0 Then
                    Format("", "  - No data found", Color.LightCoral, Color.Tomato)
                End If

                For Each xmlBlacklistNode As XmlNode In xmBaseNode

                    If Not arrBlacklist.Any(Function(Str) xmlBlacklistNode.Name.IndexOf(Str, StringComparison.CurrentCultureIgnoreCase) >= 0) Then 'Ignore blacklisted nodes

                        If Not xmlBlacklistNode.InnerText.Length = 0 Or xmlBlacklistNode.InnerXml.Length = 0 Then
                            Format("  - " & xmlBlacklistNode.Name.Replace("#cdata-section", "CData").Replace("#text", "Text") & ": ", CType(IIf(xmlBlacklistNode.InnerText.Length = 0, "No Data", xmlBlacklistNode.InnerText), String), Color.LightSeaGreen, Color.White)
                        Else
                            Format("  - " & xmlBlacklistNode.Name & ": ", "No Data", Color.LightCoral, Color.Tomato)
                        End If
                    Else
                        Format("  - " & xmlBlacklistNode.Name & ": ", "See below data", Color.MediumOrchid, Color.White)
                    End If

                Next
                rtbData.AppendText(vbCrLf)
            Next
        Next

        xmlDoc = Nothing
        xmlList = Nothing

        rtbData.SelectionStart = 0
        rtbData.ScrollToCaret()

    End Sub
    Private Sub Format(ByVal StringNode As String, ByVal StringData As String, ByVal StringNodeColor As Color, StringDataColor As Color)

        Dim strIn As String = StringNode

        rtbData.AppendText(strIn)
        rtbData.Select(rtbData.TextLength - strIn.Length, strIn.Length)
        rtbData.SelectionColor = StringNodeColor
        rtbData.SelectionFont = New Font("Consolas", 10)
        rtbData.Select(rtbData.TextLength, StringData.Length)
        rtbData.SelectionColor = StringDataColor
        rtbData.AppendText(StringData)
        rtbData.AppendText(vbCrLf)
        rtbData.ScrollToCaret()

    End Sub
    Private Sub ClearRichTextBoxData(Control As RichTextBox)
        Control.Text = ""
    End Sub
    Private Sub ResetActivate(pbxControl As PictureBox, cmdControl As Button)

        Dim clrTrans As Color = Color.Transparent

        For Each ctrl As Control In tlpMenuControls.Controls
            If TypeOf ctrl Is PictureBox Then DirectCast(ctrl, PictureBox).BackColor = clrTrans
        Next

        pbxControl.BackColor = Settings.clrThemeColour

        For Each ctrl As Control In tlpMenuControls.Controls
            If TypeOf ctrl Is Button Then DirectCast(ctrl, Button).BackColor = clrTrans
        Next

        cmdControl.BackColor = Color.FromArgb(15, 15, 15)

    End Sub

    Private Sub FormMetrics_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        For Each ctrl As Control In Controls
            If TypeOf ctrl Is RichTextBox Then
                ctrl.Dispose()
            End If
        Next

    End Sub

#End Region

End Class