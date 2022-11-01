' taken form here https://stackoverflow.com/questions/45870470/check-if-user-is-an-administrator

Imports System.Security.Principal

Namespace Core.Helpers

    NotInheritable Class AdminHelper

        Public Shared Function IsRunAsAdmin() As Boolean
            Return New WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)
        End Function

    End Class

End Namespace
