'   02.01.2020 - DR - Fixed decimal seperator.
'   20.01.2020 - DR - Add GetExitCode(), Add GetExitCodeString(), cleanup.

Imports System.IO
Imports System.Linq
Imports System.Xml

Imports WinXI.Core
Imports WinXI.Core.Common
Imports WinXI.Core.System

Imports WinXI.WinsatAPI

Namespace WinSAT

    Friend Class WinsatReader

        Friend Shared ReadOnly strSeperator As String = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator
        Friend Shared strLatestFormalXml As String = ""

#Region "WinSPR"

        Friend Shared Sub GetWinsatSPR()

            Try
                If CDbl(WinsatAPI.GetWinsatBaseScore()) = 0 Then
                    Strings.strBaseScore = "0"
                    Strings.strProcessorScore = "Unrated"
                    Strings.strMemoryScore = "Unrated"
                    Strings.strGraphicsScore = "Unrated"
                    Strings.strD3dScore = "Unrated"
                    Strings.strDiskScore = "Unrated"
                    FormMain.UpdateControls()
                Else
                    Try
                        Strings.strBaseScore = CType(WinsatAPI.GetWinsatBaseScore(), String)
                        'Append if length is 1
                        If Strings.strBaseScore.Length = 1 Then
                            Strings.strBaseScore &= strSeperator & "0"
                        Else
                            'Remove extra byte
                            If Strings.strBaseScore.Length > 3 Then
                                Strings.strBaseScore = Strings.strBaseScore.Substring(0, Strings.strBaseScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.strBaseScore = "..."
                    End Try

                    '// Processor Score
                    Try
                        Strings.strProcessorScore = WinsatAPI.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_CPU, INFO_TYPE.Score)
                        'Append if length is 1
                        If Strings.strProcessorScore.Length = 1 Then
                            Strings.strProcessorScore &= strSeperator & "0"
                        Else
                            'Remove extra byte
                            If Strings.strProcessorScore.Length > 3 Then
                                Strings.strProcessorScore = Strings.strProcessorScore.Substring(0, Strings.strProcessorScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.strProcessorScore = "..."
                    End Try

                    '// Memory Score
                    Try
                        Strings.strMemoryScore = WinsatAPI.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_MEMORY, INFO_TYPE.Score)
                        'Append if length is 1
                        If Strings.strMemoryScore.Length = 1 Then
                            Strings.strMemoryScore &= strSeperator & "0"
                        Else
                            'Remove extra byte
                            If Strings.strMemoryScore.Length > 3 Then
                                Strings.strMemoryScore = Strings.strMemoryScore.Substring(0, Strings.strMemoryScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.strMemoryScore = "..."
                    End Try

                    '// Graphics Score
                    Try
                        Strings.strGraphicsScore = WinsatAPI.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_GRAPHICS, INFO_TYPE.Score)
                        'Append if length is 1
                        If Strings.strGraphicsScore.Length = 1 Then
                            Strings.strGraphicsScore &= strSeperator & "0"
                        Else
                            'Remove extra byte
                            If Strings.strGraphicsScore.Length > 3 Then
                                Strings.strGraphicsScore = Strings.strGraphicsScore.Substring(0, Strings.strGraphicsScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.strGraphicsScore = "..."
                    End Try

                    '// Gaming Graphics Score
                    Try
                        Strings.strD3dScore = WinsatAPI.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_D3D, INFO_TYPE.Score)
                        'Append if length is 1
                        If Strings.strD3dScore.Length = 1 Then
                            Strings.strD3dScore &= strSeperator & "0"
                        Else
                            'Remove extra byte
                            If Strings.strD3dScore.Length > 3 Then
                                Strings.strD3dScore = Strings.strD3dScore.Substring(0, Strings.strD3dScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.strD3dScore = "..."
                    End Try

                    '// Disk Score
                    Try
                        Strings.strDiskScore = WinsatAPI.GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_DISK, INFO_TYPE.Score)
                        'Append is length is 1
                        If Strings.strDiskScore.Length = 1 Then
                            Strings.strDiskScore &= strSeperator & "0"
                        Else
                            'Remove extra byte
                            If Strings.strDiskScore.Length > 3 Then
                                Strings.strDiskScore = Strings.strDiskScore.Substring(0, Strings.strDiskScore.Length - 1)
                            End If
                        End If
                    Catch
                        Strings.strDiskScore = "..."
                    End Try

                    If Settings.bUseApiHardwareMode = True Then
                        ReadAPIHardware()
                    Else
                        ReadXMLHardware()
                    End If

                End If

            Catch ex As Exception
                Strings.strBaseScore = "0"
                Strings.strProcessorScore = "Unrated"
                Strings.strMemoryScore = "Unrated"
                Strings.strGraphicsScore = "Unrated"
                Strings.strD3dScore = "Unrated"
                Strings.strDiskScore = "Unrated"
                FormMain.UpdateControls()
                MessageBox.Show(ex.ToString, "WSR.GetWinsatSPR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End Sub

#End Region
#Region "Hardware (XML)"

        Friend Shared Sub ReadXMLHardware()

            If Not GetAssessmentValidityInt() = 3 Then 'Block attempts to load hardware on unrated systems
                Strings.strProcessorHardware = XMLGetProcessor()
                Strings.strMemoryHardware = XMLGetMemoryType() & " " & XMLGetMemorySize()
                Strings.strGraphicsHardware = XMLGetGraphicsName()
                Strings.strD3dHardware = XMLGetGraphicsSize()
                Strings.strDiskHardware = XMLGetDisk()
            End If

        End Sub

        Private Shared Function XMLGetProcessor() As String

            Dim Str As String = GetWinsatXMLInfo("WinSAT/SystemConfig/Processor/Instance", "ProcessorName")
            If Str.Length = 0 Then
                Return "Unknown Processor"
            Else
                Return Str.Replace("@", "·")
            End If

        End Function

        Private Shared Function XMLGetMemoryType() As String

            Dim Str As String = MemoryType.ConvertToMemoryType(GetWinsatXMLInfo("WinSAT/SystemConfig/Memory/DIMM", "MemoryType"))
            If Str.Length = 0 Then
                Return "Unknown Memory"
            Else
                Return Str
            End If

        End Function

        Private Shared Function XMLGetMemorySize() As String

            Dim Str As String = FileOps.ConvertToSize(CDbl(GetWinsatXMLInfo("WinSAT/SystemConfig/Memory/TotalPhysical", "Bytes")))
            If Str.Length = 0 Then
                Return "Unknown Size"
            Else
                Return Str
            End If

        End Function

        Private Shared Function XMLGetGraphicsName() As String

            Dim Str As String = GetWinsatXMLInfo("WinSAT/SystemConfig/Graphics", "AdapterDescription")
            If Str.Length = 0 Then
                Return "Unknown Adapter"
            Else
                Return Str
            End If

        End Function

        Private Shared Function XMLGetGraphicsSize() As String

            Dim Str As String = FileOps.ConvertToSquared(CDbl(GetWinsatXMLInfo("WinSAT/SystemConfig/Graphics", "DedicatedVideoMemory"))) & " MB total VRAM"
            If Str.Length = 0 Then
                Return "Unknown Adapter Size"
            Else
                Return Str
            End If

        End Function

        Private Shared Function XMLGetDisk() As String

            Dim Str As String = GetWinsatXMLInfo("WinSAT/SystemConfig/Disk/SystemDisk", "Model")
            If Str.Length = 0 Then
                Return "Unknown Disk"
            Else
                Return Str
            End If

        End Function

#End Region
#Region "Hardware (API)"

        Friend Shared Sub ReadAPIHardware()

            If Not WinsatAPI.GetAssessmentValidityInt() = 3 Then 'Block attempts to load hardware on unrated systems
                Strings.strProcessorHardware = APIGetProcessor()
                Strings.strMemoryHardware = APIGetMemorySize()
                Strings.strGraphicsHardware = APIGetGraphicsName()
                Strings.strD3dHardware = APIGetGraphicsSize()
                Strings.strDiskHardware = APIGetDisk()
            End If

        End Sub

        Private Shared Function APIGetProcessor() As String

            Dim Str As String = GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_CPU, INFO_TYPE.Description)
            If Str.Length = 0 Then
                Return "Unknown Processor"
            Else
                Return Str.Replace("@", "·")
            End If

        End Function

        Private Shared Function APIGetMemorySize() As String

            Dim Str As String = GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_MEMORY, INFO_TYPE.Description)
            If Str.Length = 0 Then
                Return "Unknown Memory"
            Else
                Return Str
            End If

        End Function

        Private Shared Function APIGetGraphicsName() As String

            Dim Str As String = GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_GRAPHICS, INFO_TYPE.Description)
            If Str.Length = 0 Then
                Return "Unknown Adapter"
            Else
                Return Str
            End If

        End Function

        Private Shared Function APIGetGraphicsSize() As String

            Dim Str As String = GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_D3D, INFO_TYPE.Description)
            If Str.Length = 0 Then
                Return "Unknown Shared Memory"
            Else
                Return Str
            End If

        End Function

        Private Shared Function APIGetDisk() As String

            Dim Str As String = GetWinsatHardwareAPIInfo(WINSATLib.WINSAT_ASSESSMENT_TYPE.WINSAT_ASSESSMENT_DISK, INFO_TYPE.Description)
            If Str.Length = 0 Then
                Return "Unknown Disk"
            Else
                Return Str
            End If

        End Function

#End Region
#Region "Read XML"

        Friend Shared Function GetWinsatXMLInfo(ByVal Node As String, ByVal Inner As String) As String

            Try
                Dim XMLDoc As New XmlDocument
                Dim XMLDocNode As XmlNode
                If Not GetLatestFormalXML() = strLatestFormalXml Then
                    XMLDoc.Load(GetLatestFormalXML())
                Else
                    XMLDoc.Load(strLatestFormalXml)
                End If

                XMLDocNode = XMLDoc.SelectSingleNode(Node)

                Return XMLDocNode(Inner).InnerText

            Catch
                Return ""
            End Try

        End Function

#End Region
#Region "Get Formal"

        Friend Shared Function GetLatestFormalXML() As String

            Dim Watch As New Stopwatch()
            Dim NewestFile As FileInfo = Nothing
            Dim Datastore As New DirectoryInfo(Directories.WinsatDatastorePath)

            Watch.Start()

            For Each Item As FileInfo In Datastore.EnumerateFiles("*Formal*.xml", SearchOption.TopDirectoryOnly)
                If NewestFile Is Nothing OrElse Item.LastWriteTime >= NewestFile.LastWriteTime Then
                    NewestFile = Item
                End If
            Next

            Watch.Stop()

            If (NewestFile Is Nothing) And WinSystem.IsWinVista() Then 'Vista is a little different, check for one Initial file

                For Each Item As FileInfo In Datastore.EnumerateFiles("*Initial*.xml", SearchOption.TopDirectoryOnly)
                    If NewestFile Is Nothing OrElse Item.LastWriteTime >= NewestFile.LastWriteTime Then
                        NewestFile = Item
                    End If
                Next

                If NewestFile Is Nothing Then
                    strLatestFormalXml = ""
                    Return ""
                Else
                    strLatestFormalXml = NewestFile.FullName
                    Return NewestFile.FullName
                End If

            Else
                strLatestFormalXml = NewestFile.FullName
                Return NewestFile.FullName
            End If

        End Function

#End Region
#Region "Exit Code"

        Friend Shared Function GetExitCode() As Integer

            Try
                Dim SList As String() = File.ReadAllLines(Directories.WinsatPath & "\winsat.log")
                Dim Code As String = SList.Last
                If Code.Contains("exit value = ") Then
                    Return CInt(Code.Substring(Code.Length - 2, 1))
                End If

                Return -1

            Catch ex As Exception
                Return -1
            End Try

        End Function

        Friend Shared Function GetExitCodeString(ExitCode As Integer) As String

            Select Case ExitCode
                Case 0
                    Return "The assessment completed successfully."
                Case 1
                    Return "The assessment did not complete due to an error. Please click 'Export Session' and save the log for more details."
                Case 2
                    Return "The assessment did not complete due to interference. Please click 'Export Session' and save the log for more details."
                Case 3
                    Return "The assessment was cancelled by the user."
                Case 4
                    Return "The command given to WinSAT was invalid."
                Case 5
                    Return "WinSAT was not run with administrator privilages."
                Case 6
                    Return "Another instance of WinSAT is already running."
                Case 7
                    Return "WinSAT cannot run individual assessments on Remote Desktop server."
                Case 8
                    Return "WinSAT cannot run on battery power."
                Case 9
                    Return "WinSAT cannot run a formal assessment on Remote Desktop server."
                Case 10
                    Return "No multimedia support was detected, so the assessment cannot run."
                Case 11
                    Return "WinSAT cannot run on Windows XP."
                Case 12
                    Return "The WinSAT watchdog timer timed out, indicating something is causing the tests to run unusually slowly."
                Case 13
                    Return "Cannot run the formal assessment on a Virtual Machine."
                Case Else
                    Return "An unknown WinSAT exit code was returned. Please click 'Export Session' and save the log for more details."
            End Select

        End Function

#End Region

    End Class

End Namespace

