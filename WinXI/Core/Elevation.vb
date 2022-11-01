'   30.11.2022 - DR - Create AdminHelper

Imports System.Security.Principal

Namespace Core

    NotInheritable Class Elevation

        Public Shared Function IsElevated() As Boolean
            Return New WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)
        End Function

    End Class

End Namespace
