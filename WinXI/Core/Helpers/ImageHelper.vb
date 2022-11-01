'   16.10.2019 - DR - Update imports
'   Checked for WinXI on 30.10.2022

Namespace Core.Helpers

    NotInheritable Class ImageHelper

        Public Shared Sub CaptureControl(SaveAs As String, Control As Control)

            Using Bmap As New Bitmap(Control.Width, Control.Height)
                Control.DrawToBitmap(Bmap, New Rectangle(0, 0, Control.Width, Control.Height))
                Bmap.Save(SaveAs, Imaging.ImageFormat.Png)
            End Using

        End Sub

    End Class

End Namespace


