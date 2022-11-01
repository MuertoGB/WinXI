'   30.10.2022 - DR - Update URLs.

Friend Class Strings

    Friend Const strHomeUrl As String = "https://github.com/MuertoGB/WinXI"
    Friend Const WinXIZipUrl As String = "https://bitmight.uk/software/WinXI/download/WinXI.zip"
    Friend Const strChangelogUrl As String = "https://github.com/MuertoGB/WinXI/blob/main/Resources/winxi/changelog.txt"
    Friend Const strIssueUrl As String = "https://github.com/MuertoGB/WinXI/issues"
    Friend Const ImgurUrl As String = "http://www.imgur.com"
    Friend Const ServerVersionUrl As String = "https://raw.githubusercontent.com/MuertoGB/WinXI/main/Resources/winxi/version.xml"
    Friend Const MediaFeatureUrl As String = "http://windows.microsoft.com/en-gb/windows/download-windows-media-player"

    Friend Const ProcessorRO As String = "Calculation per second"
    Friend Const MemoryRO As String = "Memory operations per second"
    Friend Const GraphicsRO As String = "Desktop graphics performance"
    Friend Const D3DRO As String = "3D business and gaming graphics performance"
    Friend Const DiskRO As String = "Disk data transfer rate"

    Friend Const ImgurClientID As String = "35e23362c1eb67c"

    Friend Shared BaseScore As String = Nothing
    Friend Shared ProcessorScore As String = Nothing
    Friend Shared MemoryScore As String = Nothing
    Friend Shared GraphicsScore As String = Nothing
    Friend Shared D3DScore As String = Nothing
    Friend Shared DiskScore As String = Nothing
    Friend Shared AssessDate As String = Nothing

    Friend Shared ProcessorHW As String = ""
    Friend Shared MemoryHW As String = ""
    Friend Shared GraphicsHW As String = ""
    Friend Shared D3DHW As String = ""
    Friend Shared DiskHW As String = ""

    Friend Const HKLMCV As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion"

End Class
