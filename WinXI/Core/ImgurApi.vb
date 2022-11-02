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

                Dim nvcKeys As New Specialized.NameValueCollection From {{"image", Convert.ToBase64String(File.ReadAllBytes(ImageLocation))}}
                Dim bByte As Byte() = Client.UploadValues("https://api.imgur.com/3/image", nvcKeys)
                Dim strBytes As String = Encoding.ASCII.GetString(bByte)
                Dim reRegex As New RegularExpressions.Regex("link"":""(.*?)""")
                Dim Match As RegularExpressions.Match = reRegex.Match(strBytes)
                Dim strAddress As String = Match.ToString().Replace("link"":""", "").Replace("""", "").Replace("\/", "/")

                'Open uploaded image in main browser.
                If ShowInBrowser Then
                    Process.Start(strAddress)
                End If

                'Save uploaded image address to link file.
                If LogUpload Then
                    My.Computer.FileSystem.WriteAllText(LogLocation, Date.Now & " - " & strAddress & vbCrLf, True)
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

            Dim tsTimeout As New TimeSpan(0, 0, 5) 'Five seconds should be enough to wait for image creation.
            Dim swTimeout As Stopwatch = Stopwatch.StartNew

            'This is whilst we wait for WinXI to save the capture, we cannot upload something that doesn't exist.
            Do
                If File.Exists(ImageLocation) Then
                    Exit Do
                End If
            Loop While Not File.Exists(ImageLocation) OrElse swTimeout.Elapsed < tsTimeout

            '02.11.2022 - Return unsuccessful as the image was not created or detected.
            If swTimeout.Elapsed >= tsTimeout Then
                MessageBox.Show("Image wait timeout.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            Return True

        End Function

    End Class


End Namespace

