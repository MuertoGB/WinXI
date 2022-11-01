'   01.11.2022 - DR - Fixed bad loop implimentation

Imports System.IO
Imports System.Net
Imports System.Text

Namespace Core

    NotInheritable Class ImgurApi

        Public Shared Function PostToImgur(ImageLocation As String, LogLocation As String, ClientID As String, ShowInBrowser As Boolean,
                    LogUpload As Boolean, DeleteTempFile As Boolean) As Integer

            Try
                Dim Client As New WebClient()
                Client.Headers.Add("Authorization", Convert.ToString("Client-ID ") & ClientID)

                Dim sWatch As Stopwatch = Stopwatch.StartNew
                Dim timeOut As TimeSpan = New TimeSpan(0, 0, 10) 'Ten seconds should be enough to wait for image creation.

                Do
                    If File.Exists(ImageLocation) Then
                        Exit Do
                    End If
                Loop While Not File.Exists(ImageLocation) OrElse swatch.Elapsed < timeOut

                Dim Keys As New Specialized.NameValueCollection From
                    {{"image", Convert.ToBase64String(File.ReadAllBytes(ImageLocation))}}
                Dim CBytes As Byte() = Client.UploadValues("https://api.imgur.com/3/image", Keys)
                Dim Str As String = Encoding.ASCII.GetString(CBytes)
                Dim REx As New RegularExpressions.Regex("link"":""(.*?)""")
                Dim Match As RegularExpressions.Match = REx.Match(Str)
                Dim Address As String = Match.ToString().Replace("link"":""", "").Replace("""", "").Replace("\/", "/")

                If ShowInBrowser Then
                    Process.Start(Address)
                End If

                If LogUpload Then
                    My.Computer.FileSystem.WriteAllText(LogLocation, Date.Now & " - " & Address & vbCrLf, True)
                End If

                If DeleteTempFile Then
                    If File.Exists(ImageLocation) Then
                        File.Delete(ImageLocation)
                    End If
                End If

                Return 1

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Return 0
            End Try

            'PostToImgur returns integers, e.g. Dim Int As Integer = ImageHelper.PostToImgur(Args)
            '0 - Error
            '1 - Successful

        End Function

    End Class


End Namespace

