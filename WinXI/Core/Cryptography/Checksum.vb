'   23.01.2020 - DR - Switch from SHA512 to SHA256
'   11.03.2021 - DR - Removed Base64ToImage()
'   Checked for WinXI on 30.10.2022

Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Namespace Core.Cryptography

    NotInheritable Class Checksum

        Public Shared Function GetSha256Digest(FilePath As String, Optional UpperCase As Boolean = False) As String

            Dim strBuilder As New StringBuilder()
            Dim shaHash As SHA256 = SHA256.Create()

            Using fsData As FileStream = File.OpenRead(FilePath)
                For Each bComputeHash As Byte In shaHash.ComputeHash(fsData)
                    If Not UpperCase Then
                        strBuilder.Append(bComputeHash.ToString("x2").ToLower())
                    Else
                        strBuilder.Append(bComputeHash.ToString("x2").ToUpper())
                    End If
                Next
            End Using

            shaHash.Dispose()
            Return strBuilder.ToString()

        End Function

    End Class

End Namespace


