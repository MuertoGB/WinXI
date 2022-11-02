'   08.03.2021 - DR - Create IniFile
'   Checked for WinXI on 30.10.2022

Imports System.Globalization
Imports System.IO
Imports System.Reflection
Imports System.Text

Namespace Core.Common
    Friend Class IniFile

        Friend Shared Path As String
        Friend Shared ReadOnly Executable As String = Assembly.GetExecutingAssembly().GetName().Name

        Friend Sub New(Optional IniPath As String = Nothing)
            Path = New FileInfo(If(IniPath, Executable & ".ini")).FullName.ToString(CultureInfo.CurrentCulture)
        End Sub

        Friend Shared Function Read(Section As String, Key As String, Path As String, Optional DefaultStr As String = "") As String
            Dim Builder As New StringBuilder(500)
            If NativeMethods.GetPrivateProfileString(Section, Key, DefaultStr, Builder, Builder.Capacity, Path) > 0 Then
                Return Builder.ToString()
            End If
            Return DefaultStr
        End Function

        Friend Shared Sub Write(Key As String, Value As String, Optional Section As String = Nothing)
            NativeMethods.WritePrivateProfileString(If(Section, Executable), Key, Value, Path)
        End Sub

        Friend Shared Sub DeleteKey(Key As String, Optional Section As String = Nothing)
            Write(Key, Nothing, If(Section, Executable))
        End Sub

        Friend Shared Sub DeleteSection(Optional Section As String = Nothing)
            Write(Nothing, Nothing, If(Section, Executable))
        End Sub

        Friend Shared Function KeyExists(Key As String, Optional Section As String = Nothing) As Boolean
            Return Read(Section, Key, Path).Length > 0
        End Function

    End Class

End Namespace


