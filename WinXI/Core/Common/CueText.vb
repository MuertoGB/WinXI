'   23.09.2019 - DR - Remove unnecessary cast
'   Checked for WinXI on 30.10.2022

Namespace Core.Common

    NotInheritable Class CueText

        Public Shared Sub SetCueText(Textbox As Control, Text As String)
            NativeMethods.SendMessage(Textbox.Handle, &H1501, 0, Text)
        End Sub

    End Class

End Namespace


