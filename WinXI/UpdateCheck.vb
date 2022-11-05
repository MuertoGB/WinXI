'   30.10.2022 - DR - Nodes
'   02.11.2022 - DR - Update code
'   03.11.2022 - DR - Move file, rename file

Imports System.Net
Imports System.Xml

Imports WinXI.Core.Common
Imports WinXI.Core.System

Friend Class UpdateCheck

    Private Shared xmlDoc As New XmlDocument
    Friend Shared strLocalBuild As String = ""
    Friend Shared strRemoteBuild As String = ""
    Friend Shared strReleaseDate As String = ""
    Friend Shared bHasCheckedThisSession As Boolean = False

    Friend Shared Function IsNewVersionAvailable() As Boolean

        Try

            ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)

            'Pull down xml file
            xmlDoc.Load(Strings.strServerVersionUrl)

            'Remote
            Dim xmlNode As XmlNode = xmlDoc.SelectSingleNode("data/WinXI")
            strRemoteBuild = CStr(xmlNode("VersionString").InnerText)

            'May as well be lazy and load the release date from XML now.
            strReleaseDate = xmlNode("ReleaseDate").InnerText

            'Local
            Dim VersionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(FileOps.GetApplicationImage)
            strLocalBuild = VersionInfo.FileVersion.ToString

            'MessageBox.Show(strRemoteBuild & vbCrLf & strLocalBuild)

            If strRemoteBuild > strLocalBuild Then
                Return True 'Version is outdated
            Else
                If strRemoteBuild <= strLocalBuild Then
                    Return False 'Version is current
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        End Try

        Return False

    End Function

End Class
