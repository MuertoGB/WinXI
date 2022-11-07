﻿'   18.07.2019 - DR - Cleanup.
'   Checked for WinXI on 30.10.2022, rename file

Friend Class WinsatState

    Friend Shared Function ConvertAssessmentState(Data As Integer) As String

        Select Case Data
            Case 0
                Return "Could not retrieve Experience Index state"
            Case 1
                Return "Experience Index scores are valid"
            Case 2
                Return "Incoherent with hardware"
            Case 3
                Return "Experience Index has not yet been established"
            Case 4
                Return "Experience Index scores are outdated or invalid"
            Case Else
                Return "Could not retrieve Experience Index state"
        End Select

    End Function

    Friend Shared Function GenerateRunStateText() As String

        Select Case WinsatAPI.GetAssessmentValidityInt
            Case 0
                Return "Run Assessment"
            Case 1
                Return "Repeat Assessment"
            Case 2
                Return "Update Assessment"
            Case 3
                Return "Run Assessment"
            Case 4
                Return "Update Assessment"
            Case Else
                Return "Run Assessment"
        End Select

    End Function

End Class





