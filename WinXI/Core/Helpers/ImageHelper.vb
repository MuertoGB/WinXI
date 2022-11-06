'   16.10.2019 - DR - Update imports
'   Checked for WinXI on 30.10.2022

Namespace Core.Helpers

    NotInheritable Class ImageHelper

        Public Shared Sub CaptureControl(SaveAs As String, Control As Control)

            Using imgBitmap As New Bitmap(Control.Width, Control.Height)
                Control.DrawToBitmap(imgBitmap, New Rectangle(0, 0, Control.Width, Control.Height))
                imgBitmap.Save(SaveAs, Imaging.ImageFormat.Png)
            End Using

        End Sub

    End Class

End Namespace


