'   30.10.2022 - DR - Nodes

Imports System.Net
Imports System.Xml

Imports WinXI.Core.Common
Imports WinXI.Core.System

Friend Class CheckForUpdate

    Private Shared xmlDoc As New XmlDocument
    Friend Shared strLocal As String = ""
    Friend Shared strServer As String = ""
    Friend Shared strReleaseDate As String = ""

    Friend Shared Function IsNewVersionAvailable() As Boolean

        Try
            If Network.IsWebsiteAvailable(Strings.strHomeUrl) Then

                ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)

                'Pull down xml
                xmlDoc.Load(Strings.ServerVersionUrl)

                'Remote
                Dim xmlNode As XmlNode = xmlDoc.SelectSingleNode("data/WinXI")
                Dim MajBuildServer As Integer = CInt(xmlNode("Maj").InnerText)
                Dim MinBuidServer As Integer = CInt(xmlNode("Min").InnerText)
                Dim RevBuildServer As Integer = CInt(xmlNode("Rev").InnerText)
                strServer = MajBuildServer & "." & MinBuidServer & "." & RevBuildServer

                'Local
                Dim VersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(FileOps.GetApplicationImage)
                Dim MajBuildLocal As Integer = VersionInfo.FileMajorPart
                Dim MinBuildLocal As Integer = VersionInfo.FileMinorPart
                Dim RevBuildLocal As Integer = VersionInfo.FileBuildPart
                strLocal = MajBuildLocal & "." & MinBuildLocal & "." & RevBuildLocal

                'May as well be lazy and load the release date from XML now.
                strReleaseDate = xmlNode("ReleaseDate").InnerText

                '// Let GC handle XML stuff? not sure, will leave this here.
                xmlNode = Nothing
                xmlDoc = Nothing

                If strServer > strLocal Then
                    'Update available
                    Return True
                Else
                    If strServer <= strLocal Then
                        'Current version installed
                        Return False
                    End If
                End If
            Else
                'Network unavailable, ohnoooooooooooo.
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try

        Return False

    End Function

End Class
