'   23.01.2020 - DR - Switch from SHA512 to SHA256
'   11.03.2021 - DR - Removed Base64ToImage()
'   Checked for WinXI on 30.10.2022

Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Namespace Core.Cryptography

    NotInheritable Class Checksum

        Public Shared Function GetSha256Digest(FilePath As String, Optional UpperCase As Boolean = False) As String

            Dim Builder As New StringBuilder()
            Dim HashType As SHA256 = SHA256.Create()

            Using Stream As FileStream = File.OpenRead(FilePath)
                For Each HByte As Byte In HashType.ComputeHash(Stream)
                    If Not UpperCase Then
                        Builder.Append(HByte.ToString("x2").ToLower())
                    Else
                        Builder.Append(HByte.ToString("x2").ToUpper())
                    End If
                Next
            End Using

            HashType.Dispose()
            Return Builder.ToString()

        End Function

    End Class

End Namespace


