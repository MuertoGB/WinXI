﻿'   07.08.2019 - DR - Add constructor, update theme, update WndProc
'   21.01.2020 - DR - Update GetXMLInfoWinsat to notify of empty sections and XML data
'   02.11.2022 - DR - Remove unsused var

'  The GetWinsatXmlInfo code is terrible, I understand that. But it works. IT WORKS. NOW GET OUT.

Imports System.Linq
Imports System.Xml
Imports WinXI.Winsat

Public Class FormMetrics

    Private ReadOnly Blacklist() As String = {"Signature", "L1Cache", "L2Cache", "L3Cache", "LogicalProcessorInfo"}
    Private RtfProgramInfo As New RichTextBox
    Private RtbSystemEnvironment As New RichTextBox
    Private RtfWinspr As New RichTextBox
    Private RtfMetrics As New RichTextBox
    Private RtfWinSystem As New RichTextBox
    Private RtfSystem As New RichTextBox
    Private RtfProcessor As New RichTextBox
    Private RtfMemory As New RichTextBox
    Private RtfGraphics As New RichTextBox
    Private RtfDisk As New RichTextBox
    Private RtfDwm As New RichTextBox
    Private RtfD3d As New RichTextBox

#Region "Constructor"

    Public Sub New()

        InitializeComponent()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)

        SetMetricsThemeAccent()

        PanHead.BackgroundImage = Settings.SetHeaderGraphic

    End Sub

#End Region

#Region "WndProc"

    Private Sub Frame_Move(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, icnMain.MouseMove, TlpHeadImage.MouseMove, LabHead.MouseMove

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

    Private Sub CmdClose_Click(sender As Object, e As EventArgs) Handles CmdClose.Click
        Close()
    End Sub

#End Region

#Region "Load Event Handler"

    Private Sub FormMetrics_Load(sender As Object, e As EventArgs) Handles Me.Load

        ResetActivate(PbxProgramInfo, CmdProgramInfo)
        GetWinsatXmlInfo("ProgramInfo", False)

    End Sub

#End Region

#Region "Theme"

    Private Sub SetMetricsThemeAccent()

        Dim TC As Color = Settings.SetThemeColour

        PanSplit.BackColor = TC

        For Each Ctrl As Control In TlpMenu.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).ForeColor = TC
        Next

        Settings.SetBorderColor(Me)

    End Sub

#End Region

#Region "Button Event Handlers"

    Private Sub CmdProgramInfo_Click(sender As Object, e As EventArgs) Handles CmdProgramInfo.Click

        ResetActivate(PbxProgramInfo, CType(sender, Button))
        Cls(RtbData)

        If RtfProgramInfo.Text.Length <= 0 Then
            GetWinsatXmlInfo("ProgramInfo", False)
            RtfProgramInfo.Rtf = RtbData.Rtf
        Else
            RtbData.Rtf = RtfProgramInfo.Rtf
        End If

    End Sub

    Private Sub CmdSysEnviron_Click(sender As Object, e As EventArgs) Handles CmdSysEnviron.Click

        ResetActivate(PbxSystemEnvironment, CType(sender, Button))
        Cls(RtbData)

        If RtbSystemEnvironment.Text.Length <= 0 Then
            GetWinsatXmlInfo("SystemEnvironment", False)
            RtbSystemEnvironment.Rtf = RtbData.Rtf
        Else
            RtbData.Rtf = RtbSystemEnvironment.Rtf
        End If

    End Sub

    Private Sub CmdWinSpr_Click(sender As Object, e As EventArgs) Handles CmdWinSpr.Click

        ResetActivate(PbxWinSPR, CType(sender, Button))
        Cls(RtbData)

        If RtfWinspr.Text.Length <= 0 Then
            GetWinsatXmlInfo("WinSPR", False)
            RtfWinspr.Rtf = RtbData.Rtf
        Else
            RtbData.Rtf = RtfWinspr.Rtf
        End If

    End Sub

    Private Sub CmdMetrics_Click(sender As Object, e As EventArgs) Handles CmdMetrics.Click

        ResetActivate(PbxMetrics, CType(sender, Button))
        Cls(RtbData)

        If RtfMetrics.Text.Length <= 0 Then
            GetWinsatXmlInfo("Metrics", False)
            RtfMetrics.Rtf = RtbData.Rtf
        Else
            RtbData.Rtf = RtfMetrics.Rtf
        End If

    End Sub

    Private Sub CmdOS_Click(sender As Object, e As EventArgs) Handles CmdOS.Click

        ResetActivate(PbxOSVersion, CType(sender, Button))
        Cls(RtbData)

        If RtfWinSystem.Text.Length <= 0 Then
            GetWinsatXmlInfo("OSVersion", False)
            GetWinsatXmlInfo("Platform", False)
            RtfWinSystem.Rtf = RtbData.Rtf
        Else
            RtbData.Rtf = RtfWinSystem.Rtf
        End If

    End Sub

    Private Sub CmdSystem_Click(sender As Object, e As EventArgs) Handles CmdSystem.Click

        ResetActivate(PbxSystem, CType(sender, Button))
        Cls(RtbData)

        If RtfSystem.Text.Length <= 0 Then
            GetWinsatXmlInfo("MotherBoard", False)
            GetWinsatXmlInfo("BIOS", False)
            GetWinsatXmlInfo("Machine", False)
            RtfSystem.Rtf = RtbData.Rtf
        Else
            RtbData.Rtf = RtfSystem.Rtf
        End If

    End Sub

    Private Sub CmdProcessor_Click(sender As Object, e As EventArgs) Handles CmdProcessor.Click

        ResetActivate(PbxProcessor, CType(sender, Button))
        Cls(RtbData)

        If RtfProcessor.Text.Length <= 0 Then
            GetWinsatXmlInfo("Processor", False)
            GetWinsatXmlInfo("Signature", True)
            GetWinsatXmlInfo("L1Cache", True)
            GetWinsatXmlInfo("L2Cache", True)
            GetWinsatXmlInfo("L3Cache", True)
            GetWinsatXmlInfo("LogicalProcessorInfo", True)
            RtfProcessor.Rtf = RtbData.Rtf
        Else
            RtbData.Rtf = RtfProcessor.Rtf
        End If

    End Sub

    Private Sub CmdMemory_Click(sender As Object, e As EventArgs) Handles CmdMemory.Click

        ResetActivate(PbxMemory, CType(sender, Button))
        Cls(RtbData)

        If RtfMemory.Text.Length <= 0 Then
            GetWinsatXmlInfo("Memory", False)
            RtfMemory.Rtf = RtbData.Rtf
        Else
            RtbData.Rtf = RtfMemory.Rtf
        End If

    End Sub

    Private Sub CmdGraphics_Click(sender As Object, e As EventArgs) Handles CmdGraphics.Click

        ResetActivate(PbxGraphics, CType(sender, Button))
        Cls(RtbData)

        If RtfGraphics.Text.Length <= 0 Then
            GetWinsatXmlInfo("Graphics", False)
            GetWinsatXmlInfo("Monitors", False)
            RtfGraphics.Rtf = RtbData.Rtf
        Else
            RtbData.Rtf = RtfGraphics.Rtf
        End If

    End Sub

    Private Sub CmdDisk_Click(sender As Object, e As EventArgs) Handles CmdDisk.Click

        ResetActivate(PbxDisk, CType(sender, Button))
        Cls(RtbData)

        If RtfDisk.Text.Length <= 0 Then
            GetWinsatXmlInfo("SystemDisk", False)
            RtfDisk.Rtf = RtbData.Rtf
        Else
            RtbData.Rtf = RtfDisk.Rtf
        End If

    End Sub

    Private Sub CmdDwm_Click(sender As Object, e As EventArgs) Handles CmdDwm.Click

        ResetActivate(PbxDwm, CType(sender, Button))
        Cls(RtbData)

        If RtfDwm.Text.Length <= 0 Then
            GetWinsatXmlInfo("DWMAssessment", False)
            RtfDwm.Rtf = RtbData.Rtf
        Else
            RtbData.Rtf = RtfDwm.Rtf
        End If

    End Sub

    Private Sub CmdD3D_Click(sender As Object, e As EventArgs) Handles CmdD3D.Click

        ResetActivate(PbxD3d, CType(sender, Button))
        Cls(RtbData)

        If RtfD3d.Text.Length <= 0 Then
            GetWinsatXmlInfo("D3DAssessment", False)
            RtfD3d.Rtf = RtbData.Rtf
        Else
            RtbData.Rtf = RtfD3d.Rtf
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

        RtbData.AppendText(vbCrLf)

        Dim Doc As New XmlDocument
        Dim MainNodeList As XmlNodeList

        Doc.Load(WinsatReader.strLatestFormalXml)
        MainNodeList = Doc.GetElementsByTagName(LookIn)

        Dim Attribs As String = ""

        If MainNodeList.Count = 0 Then
            Format("", "  - XML section empty", Color.LightCoral, Color.White)
            RtbData.AppendText(vbCrLf)
        End If

        For Each MainNode As XmlNode In MainNodeList
            For Each BaseNode As XmlNode In MainNode
                If BaseNode.Attributes IsNot Nothing Then
                    For Each atr As XmlAttribute In BaseNode.Attributes
                        Attribs += atr.Name & ": " & atr.Value & " "
                    Next
                End If

                Format(" " & BaseNode.Name & " ", Attribs, Color.LightSkyBlue, Color.FromArgb(250, 236, 133))
                Attribs = ""

                If BaseNode.ChildNodes.Count = 0 Then
                    Format("", "  - No data found", Color.LightCoral, Color.Tomato)
                End If

                For Each Node As XmlNode In BaseNode

                    If Not Blacklist.Any(Function(Str) Node.Name.IndexOf(Str, StringComparison.CurrentCultureIgnoreCase) >= 0) Then 'Ignore blacklisted nodes

                        If Not Node.InnerText.Length = 0 Or Node.InnerXml.Length = 0 Then
                            Format("  - " & Node.Name.Replace("#cdata-section", "CData").Replace("#text", "Text") & ": ", CType(IIf(Node.InnerText.Length = 0, "No Data", Node.InnerText), String), Color.LightSeaGreen, Color.White)
                        Else
                            Format("  - " & Node.Name & ": ", "No Data", Color.LightCoral, Color.Tomato)
                        End If
                    Else
                        Format("  - " & Node.Name & ": ", "See below data", Color.MediumOrchid, Color.White)
                    End If

                Next
                RtbData.AppendText(vbCrLf)
            Next
        Next

        Doc = Nothing
        MainNodeList = Nothing

        RtbData.SelectionStart = 0
        RtbData.ScrollToCaret()

    End Sub
    Private Sub Format(ByVal StringNode As String, ByVal StringData As String, ByVal StringNodeColor As Color, StringDataColor As Color)

        Dim InString As String = StringNode

        On Error Resume Next

        RtbData.AppendText(InString)
        RtbData.Select(RtbData.TextLength - InString.Length, InString.Length)
        RtbData.SelectionColor = StringNodeColor
        RtbData.SelectionFont = New Font("Consolas", 10)
        RtbData.Select(RtbData.TextLength, StringData.Length)
        RtbData.SelectionColor = StringDataColor
        RtbData.AppendText(StringData)
        RtbData.AppendText(vbCrLf)
        RtbData.ScrollToCaret()

    End Sub
    Private Sub Cls(Control As RichTextBox)
        Control.Text = ""
    End Sub
    Private Sub ResetActivate(PbxControl As PictureBox, CmdControl As Button)

        Dim Trans As Color = Color.Transparent

        For Each Ctrl As Control In TlpMenu.Controls
            If TypeOf Ctrl Is PictureBox Then DirectCast(Ctrl, PictureBox).BackColor = Trans
        Next

        PbxControl.BackColor = Settings.SetThemeColour

        For Each Ctrl As Control In TlpMenu.Controls
            If TypeOf Ctrl Is Button Then DirectCast(Ctrl, Button).BackColor = Trans
        Next

        CmdControl.BackColor = Color.FromArgb(15, 15, 15)

    End Sub

    Private Sub FormMetrics_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        For Each Rtb As Control In Controls
            If TypeOf Rtb Is RichTextBox Then
                Rtb.Dispose()
            End If
        Next

    End Sub

#End Region

End Class