﻿'   31.07.2019 - DR - Better error handling
'   30.10.2022 - DR - Merge enums
'   Checked for WinXI on 30.10.2022


Imports WINSATLib
Imports WINSATLib.WINSAT_BITMAP_SIZE
Imports System.Runtime.InteropServices

Friend Class WinsatAPI

#Region "Enums"
    Friend Enum INFO_TYPE
        Description
        Score
        Title
    End Enum
    Friend Enum VISUAL_SIZE
        Small
        Normal
    End Enum
#End Region
#Region "Functions"

    Friend Shared Function GetAssessmentValidityInt() As Integer

        Dim cQuery As New CQueryWinSAT()

        Try
            Return cQuery.Info.AssessmentState
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WinsatApi.GetAssessmentValidityInt", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try

    End Function

    Friend Shared Function GetWinsatHardwareAPIInfo(WinType As WINSAT_ASSESSMENT_TYPE, InfType As INFO_TYPE) As String

        Dim cQuery As New CQueryWinSAT()
        Dim cQueryInf As IProvideWinSATAssessmentInfo = cQuery.Info.GetAssessmentInfo(WinType)

        Try
            Select Case InfType
                Case INFO_TYPE.Description
                    Return cQueryInf.Description
                Case INFO_TYPE.Score
                    Return CStr(cQueryInf.Score)
                Case INFO_TYPE.Title
                    Return cQueryInf.Title
                Case Else
                    Return Nothing
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WinsatApi.GetWinsatHardwareAPIInfo", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "Unknown"
        End Try

    End Function

    Friend Shared Function GetWinsatBaseScore() As Single

        Dim cQuery As New CQueryWinSAT()

        Try
            Return cQuery.Info.SystemRating
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WinsatApi.GetWinsatBaseScore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0.0
        End Try

    End Function

    Friend Shared Function GetWinsatLastUpdateDate() As Date

        Dim cQuery As New CQueryWinSAT()

        Try
            Return CDate(cQuery.Info.AssessmentDateTime)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WinsatApi.GetWinsatLastUpdateDate", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function

    Friend Shared Function GetWinsatVisual(Optional SizeMode As VISUAL_SIZE = VISUAL_SIZE.Small) As Bitmap

        'This function is used to retrieve the winsat visual bitmap
        'Usage ExamplePicturebox.Image = GetWinsatVisual(VisualSize.Normal)
        'VisualSize.Small returns the small image seen in Control Panel > All > System (Up to Windows 8)
        'VisualSize.Large returns the large image seen in the graph in Control Panel > All > Performance Information and Tools (Up to Windows 8)

        Dim cQuery As New CQueryWinSAT()
        Dim bBuffer(3) As Byte
        Dim hdlGc As GCHandle = GCHandle.Alloc(bBuffer, GCHandleType.Pinned)
        Dim Pointer As IntPtr = hdlGc.AddrOfPinnedObject()
        Dim queryVisual As New CProvideWinSATVisuals()

        Try
            If SizeMode = VISUAL_SIZE.Small Then
                queryVisual.get_Bitmap(WINSAT_BITMAP_SIZE_SMALL, cQuery.Info.AssessmentState, cQuery.Info.SystemRating, Pointer)
            Else
                queryVisual.get_Bitmap(WINSAT_BITMAP_SIZE_NORMAL, cQuery.Info.AssessmentState, cQuery.Info.SystemRating, Pointer)
            End If

            hdlGc.Free()

            If BitConverter.ToInt32(bBuffer, 0) <> 0 Then
                Dim imgBitmap As Bitmap = Image.FromHbitmap(New IntPtr(BitConverter.ToInt32(bBuffer, 0)))
                Return imgBitmap
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WinsatApi.GetWinsatVisual", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try

    End Function

#End Region

End Class





