'   08.03.2021 - DR - Create IniFile
'   02.11.2022 - DR - Update variable

Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Text

Namespace Core.Common
    Friend Class IniFile

        Friend Shared strPath As String
        Friend Shared ReadOnly strExecutable As String = FileOps.GetApplicationImage()

        Friend Sub New(Optional IniPath As String = Nothing)
            strPath = New FileInfo(If(IniPath, strExecutable & ".ini")).FullName.ToString(CultureInfo.CurrentCulture)
        End Sub

        Friend Shared Function Read(Section As String, Key As String, Path As String, Optional DefaultString As String = "") As String
            Dim strBuilder As New StringBuilder(500)
            If NativeMethods.GetPrivateProfileString(Section, Key, DefaultString, strBuilder, strBuilder.Capacity, Path) > 0 Then
                Return strBuilder.ToString()
            End If
            Return DefaultString
        End Function

        Friend Shared Sub Write(Key As String, Value As String, Optional Section As String = Nothing)
            NativeMethods.WritePrivateProfileString(If(Section, strExecutable), Key, Value, strPath)
        End Sub

        Friend Shared Sub DeleteKey(Key As String, Optional Section As String = Nothing)
            Write(Key, Nothing, If(Section, strExecutable))
        End Sub

        Friend Shared Sub DeleteSection(Optional Section As String = Nothing)
            Write(Nothing, Nothing, If(Section, strExecutable))
        End Sub

        Friend Shared Function KeyExists(Key As String, Optional Section As String = Nothing) As Boolean
            Return Read(Section, Key, strPath).Length > 0
        End Function

    End Class

End Namespace


