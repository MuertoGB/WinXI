'   23.09.2019 - DR - Changed checksum generation to SHA256
'   09.03.2021 - DR - Remove MoveSafely()
'   Checked for WinXI on 30.10.2022
'   01.11.2022 - DR - Remove unused var, cleanup
'   07.11.2022 - DR - Move ExecTask and InstallMsu in preperation for Hotfix.vb

Imports System.IO
Imports System.Text

Namespace Core.Common

    NotInheritable Class FileOps

        Public Shared Function GetApplicationImage() As String

            Dim strBuilder As New StringBuilder(255)
            NativeMethods.GetModuleFileName(IntPtr.Zero, strBuilder, strBuilder.Capacity)
            Return strBuilder.ToString

        End Function

        Public Shared Function GetApplicationPath() As String
            Dim strBuilder As New StringBuilder(255)
            NativeMethods.GetModuleFileName(IntPtr.Zero, strBuilder, strBuilder.Capacity)
            Dim Info As New FileInfo(strBuilder.ToString())
            Return Info.Directory.FullName
        End Function

#Region "Stringbuilder"

        Public Shared Function GenerateRandomString(LengthOfString As Integer, Optional UpperCase As Boolean = False) As String

            Dim strChars As String = "abcdefghijklmnopqrstuvwxyz1234567890"
            Dim ranChar As New Random
            Dim strBuilder As New StringBuilder
            For intLength As Integer = 1 To LengthOfString
                Dim intNext As Integer = ranChar.Next(0, 35)
                strBuilder.Append(strChars.Substring(intNext, 1))
            Next

            Return CType(IIf(UpperCase, strBuilder.ToString.ToUpper(), strBuilder.ToString()), String)

        End Function

#End Region

#Region "File Size Conversions"

        Public Shared Function ConvertToSize(intBytes As Double) As String

            Dim Dbl As Double

            Try
                Select Case intBytes
                    Case Is >= 1099511627776
                        Dbl = intBytes / 1099511627776 'TB
                        Return FormatNumber(Dbl, 2) & " TB"
                    Case 1073741824 To 1099511627775
                        Dbl = intBytes / 1073741824 'GB
                        Return FormatNumber(Dbl, 2) & " GB"
                        'Return Format(Dbl, "########0") & " GB"
                    Case 1048576 To 1073741823
                        Dbl = intBytes / 1048576 'MB
                        Return FormatNumber(Dbl, 2) & " MB"
                    Case 1024 To 1048575
                        Dbl = intBytes / 1024 'KB
                        Return FormatNumber(Dbl, 2) & " KB"
                    Case 0 To 1023
                        Dbl = intBytes
                        Return FormatNumber(Dbl, 2) & " bytes"
                    Case Else
                        Return "0 bytes"
                End Select
            Catch
                Return ""
            End Try

        End Function

        Public Shared Function ConvertToSquared(SizeIn As Double) As String

            Dim dblOut As Double = SizeIn / Math.Pow(1024, 2)
            Return Format(dblOut, "########0.00")

        End Function

    End Class

#End Region

End Namespace


