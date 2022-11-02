'   30.10.2022 - DR - Update URLs.
'   02.11.2022 - DR - Update variable names, moved strRegistryHKLM to /Core/System/WinSystem

Friend Class Strings

    Friend Const strHomeUrl As String = "https://github.com/MuertoGB/WinXI"
    Friend Const strChangelogUrl As String = "https://github.com/MuertoGB/WinXI/blob/main/Resources/winxi/changelog.txt"
    Friend Const strIssueUrl As String = "https://github.com/MuertoGB/WinXI/issues"
    Friend Const strImgurUrl As String = "http://www.imgur.com"
    Friend Const strServerVersionUrl As String = "https://raw.githubusercontent.com/MuertoGB/WinXI/main/Resources/winxi/version.xml"
    Friend Const strMediaFeatureUrl As String = "http://windows.microsoft.com/en-gb/windows/download-windows-media-player"

    Friend Const strProcessorText As String = "Calculation per second"
    Friend Const strMemoryText As String = "Memory operations per second"
    Friend Const strGraphicsText As String = "Desktop graphics performance"
    Friend Const strD3dText As String = "3D business and gaming graphics performance"
    Friend Const strDiskText As String = "Disk data transfer rate"

    Friend Shared strBaseScore As String = Nothing
    Friend Shared strProcessorScore As String = Nothing
    Friend Shared strMemoryScore As String = Nothing
    Friend Shared strGraphicsScore As String = Nothing
    Friend Shared strD3dScore As String = Nothing
    Friend Shared strDiskScore As String = Nothing
    Friend Shared strLastAssessDate As String = Nothing

    Friend Shared strProcessorHardware As String = ""
    Friend Shared strMemoryHardware As String = ""
    Friend Shared strGraphicsHardware As String = ""
    Friend Shared strD3dHardware As String = ""
    Friend Shared strDiskHardware As String = ""

    Friend Const strImgurClientID As String = "35e23362c1eb67c"

End Class
