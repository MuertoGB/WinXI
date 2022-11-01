'   DR - Created at some point in the past (shrugs)
'   Checked for WinXI on 30.10.2022

Namespace Core.System

    NotInheritable Class Power

        Friend Shared Function IsAdapterPluggedIn() As Boolean

            Dim Status As PowerStatus = SystemInformation.PowerStatus

            Select Case Status.PowerLineStatus
                Case PowerLineStatus.Offline 'Return false
                    Return False
                Case PowerLineStatus.Online 'Return true
                    Return True
                Case PowerLineStatus.Unknown 'Let winsat handle it
                    Return True
                Case Else
                    Return True 'Let winsat handle it
            End Select

        End Function

    End Class

End Namespace


