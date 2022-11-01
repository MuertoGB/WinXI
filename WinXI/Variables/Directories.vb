Imports System.IO

Imports WinXI.Core.Common

Friend Class Directories

    Friend Shared ReadOnly WindowsPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Windows)
    Friend Shared ReadOnly DesktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Friend Shared ReadOnly AppPath As String = FileOps.GetApplicationPath()
    Friend Shared ReadOnly TempFilesPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Temp")
    Friend Shared ReadOnly WinsatDatastorePath As String = Path.Combine(WindowsPath, "Performance\WinSAT\DataStore")
    Friend Shared ReadOnly WinsatPath As String = Path.Combine(WindowsPath, "Performance\WinSAT")
    Friend Shared ReadOnly System32Path As String = Environment.GetFolderPath(Environment.SpecialFolder.System)


End Class
