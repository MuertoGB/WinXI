﻿'   06.11.2022 - DR - Update LogTypetext string

NotInheritable Class Logger

    Friend Shared Sub Log(ByVal StringReceived As String, TypeReceived As LogType, Control As RichTextBox)

        Dim LogTypeText As String = ""
        Dim LogTypeColor As Color

        Select Case TypeReceived
            Case LogType.WinXILog
                LogTypeText = "[WXI]: "
                LogTypeColor = LogColor.WinXI
            Case LogType.WinsatLog
                LogTypeText = "[WEI]: "
                LogTypeColor = LogColor.Winsat
            Case LogType.InfoLog
                LogTypeText = "[INF]: "
                LogTypeColor = LogColor.Information
            Case LogType.OkayLog
                LogTypeText = "[OKY]: "
                LogTypeColor = LogColor.Okay
            Case LogType.WarningLog
                LogTypeText = "[WRN]: "
                LogTypeColor = LogColor.Warning
            Case LogType.ErrorLog
                LogTypeText = "[ERR]: "
                LogTypeColor = LogColor.ErrorRed
        End Select

        With Control
            .AppendText(LogTypeText)
            .Select(Control.TextLength - LogTypeText.Length, LogTypeText.Length - 1)
            .SelectionColor = LogTypeColor
            .AppendText(StringReceived)
            .AppendText(vbCrLf)
            .ScrollToCaret() 'ScrollToCarrot
        End With

        My.Computer.FileSystem.WriteAllText(Settings.strAssessmentLogPath, StringReceived & vbCrLf, True)

    End Sub

End Class