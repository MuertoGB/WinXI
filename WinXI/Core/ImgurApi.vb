'   01.11.2022 - DR - Fixed bad loop implimentation, could have become stuck indefinitely
'   02.11.2022 - DR - Image creation wait handled better

Imports System.IO
Imports System.Net
Imports System.Text

Namespace Core

    NotInheritable Class ImgurApi

        Public Shared Function UploadToImgur(ImageLocation As String, LogLocation As String, ClientID As String, ShowInBrowser As Boolean,
                    LogUpload As Boolean, DeleteTempFile As Boolean) As Integer

            Try
                Dim Client As New WebClient()
                Client.Headers.Add("Authorization", Convert.ToString("Client-ID ") & ClientID)

                'Waits for creation of temporary file.
                If Not WaitForImageCreation(ImageLocation) Then
                    Return 0 'Routine will now return and exit execution of this function.
                End If

                Dim Keys As New Specialized.NameValueCollection From
                    {{"image", Convert.ToBase64String(File.ReadAllBytes(ImageLocation))}}
                Dim CBytes As Byte() = Client.UploadValues("https://api.imgur.com/3/image", Keys)
                Dim Str As String = Encoding.ASCII.GetString(CBytes)
                Dim REx As New RegularExpressions.Regex("link"":""(.*?)""")
                Dim Match As RegularExpressions.Match = REx.Match(Str)
                Dim Address As String = Match.ToString().Replace("link"":""", "").Replace("""", "").Replace("\/", "/")

                'Open uploaded image in main browser.
                If ShowInBrowser Then
                    Process.Start(Address)
                End If

                'Save uploaded image address to link file.
                If LogUpload Then
                    My.Computer.FileSystem.WriteAllText(LogLocation, Date.Now & " - " & Address & vbCrLf, True)
                End If

                'Delete temporary image file
                If DeleteTempFile Then
                    If File.Exists(ImageLocation) Then
                        File.Delete(ImageLocation)
                    End If
                End If

                'If we reached here, the upload was probably successful.
                Return 1

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Return 0
            End Try

            'PostToImgur returns integers, e.g. Dim Int As Integer = ImageHelper.PostToImgur(Args)
            '0 - Error
            '1 - Successful

        End Function

        Friend Shared Function WaitForImageCreation(ImageLocation As String) As Boolean

            Dim sWatch As Stopwatch = Stopwatch.StartNew
            Dim timeOut As New TimeSpan(0, 0, 5) 'Five seconds should be enough to wait for image creation.

            'This is whilst we wait for WinXI to save the capture, we cannot upload something that doesn't exist.
            Do
                If File.Exists(ImageLocation) Then
                    Exit Do
                End If
            Loop While Not File.Exists(ImageLocation) OrElse sWatch.Elapsed < timeOut

            '02.11.2022 - Return unsuccessful as the image was not created or detected.
            If sWatch.Elapsed >= timeOut Then
                MessageBox.Show("Image wait timeout.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Return True

        End Function

    End Class


End Namespace

