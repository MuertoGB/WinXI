'   10.03.2021 - DR - Removed GetIniValue, switched to Core/Helpers/IniFile
'   02.11.2022 - DR - Update variable

Imports System.Globalization
Imports System.IO

Imports WinXI.Core.Common

NotInheritable Class Culture

    Private Shared ReadOnly CompatibilityFile As String = Path.Combine(FileOps.GetApplicationPath(), "Compatibility.ini")

    Friend Shared MediaFoundationStr As String = ""
    Friend Shared ExtendedMediaStr As String = ""
    Friend Shared MediaEncodeStr As String = ""
    Friend Shared MemoryStr As String = ""
    Friend Shared StorageStr As String = ""

#Region "Lang"

    Friend Shared Function SetCultureStrings() As Boolean
        If File.Exists(CompatibilityFile) Then
            SetIniStrings()
            Return True
        Else
            SetDefaultStrings()
            Return False
        End If
    End Function

    Private Shared Sub SetDefaultStrings()
        MediaFoundationStr = "Media Foundation Playback"
        ExtendedMediaStr = "Extended Media Assessment"
        MediaEncodeStr = "Media Decode/Encode"
        MemoryStr = "System memory performance"
        StorageStr = "Storage Assessment"
    End Sub

    Private Shared Sub SetIniStrings()

        MediaFoundationStr = IniFile.Read(GetCultureName, "MediaFound", CompatibilityFile, "Media Foundation Playback")
        ExtendedMediaStr = IniFile.Read(GetCultureName, "MediaExtend", CompatibilityFile, "Extended Media Assessment")
        MediaEncodeStr = IniFile.Read(GetCultureName, "MediaEncode", CompatibilityFile, "Media Decode/Encode")
        MemoryStr = IniFile.Read(GetCultureName, "Memory", CompatibilityFile, "System memory performance")
        StorageStr = IniFile.Read(GetCultureName, "Storage", CompatibilityFile, "Storage Assessment")

    End Sub

#End Region

#Region "Functions"
    Friend Shared Function GetCultureName() As String
        Return CultureInfo.CurrentCulture.Name
    End Function
#End Region

End Class
