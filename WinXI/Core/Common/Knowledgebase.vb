'   Updated on 14.04.2020 - DR - Switch List<T> to HashSet<T>, lose CheckFor()
'   Checked for WinXI on 30.10.2022

Imports System.Management

Namespace Core.Common

    NotInheritable Class Knowledgebase

        Friend Shared Function EnumerateHotfixes() As HashSet(Of String)

            Dim mosSearcher As New ManagementObjectSearcher("root\CIMV2", "SELECT HotFixID FROM Win32_QuickFixEngineering")
            Dim hsUpdates As New HashSet(Of String)()

            Try
                For Each objSearcher As ManagementObject In mosSearcher.Get() 'Shuffle through items in QuickFixEngineering
                    Dim strProperty As String = objSearcher.GetPropertyValue("HotFixID").ToString
                    hsUpdates.Add(strProperty)
                Next
                mosSearcher.Dispose()
                Return hsUpdates
            Catch ex As Exception
                MessageBox.Show("Error whilst accessing WMI:" & vbCrLf & ex.Message, "Knowldgebase.ListAllHotfixes()", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End Try

        End Function

    End Class

End Namespace

