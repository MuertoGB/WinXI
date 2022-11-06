'   07.08.2019 - DR - Cleanup
'   30.10.2022 - DR - Set security protocol, lowered timeout form 10s to 5s
'   Checked for WinXI on 30.10.2022

Imports System.Net

Namespace Core.System

    NotInheritable Class Network
        Friend Shared Function IsWebsiteAvailable(WebAddress As String) As Boolean

            ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)

            Try
                Dim wRequest As WebRequest
                Dim wResponse As WebResponse
                wRequest = WebRequest.Create(WebAddress)
                wRequest.Timeout = 10000
                wResponse = wRequest.GetResponse()
                Return True
            Catch
                Return False
            End Try

        End Function

    End Class

End Namespace


