Public Class frmChangeTicketClosedDate

    Public sUsername As String
    Public bReloadGrid As Boolean = False
    Dim grd As DataGridView

    Public Sub LoadGrid(ByRef grd1 As DataGridView)
        grd = grd1
    End Sub

    Private Sub frmChangeTicketClosedDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTicketClosedDate.Value = Date.Now

        If grd.SelectedRows.Count = 0 Then
            MsgBox("Select Item", vbInformation)
            Me.Dispose()
            Exit Sub
        End If

        Dim nCount As Integer = 0

        For Each row As DataGridViewRow In grd.SelectedRows
            If row.Cells("colTicketStatus").Value = "Closed" Then
                nCount = 1
                lstTickets.Items.Add(row.Cells("colTicketId").Value)
            End If
        Next

        If nCount = 0 Then
            MsgBox("The Selected Lines are not Ticked Status Closed", vbInformation)
            Me.Dispose()
            Exit Sub
        End If

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub

    Private Sub mnuChangeDate_Click(sender As Object, e As EventArgs) Handles mnuChangeDate.Click

        If MsgBox("Do you want change Closed Date of these Tickets?", vbYesNo) = vbNo Then
            Exit Sub
        End If

        Dim bError As Boolean = False

        lstTickets.Items.Clear()

        Dim sTicketId As String

        Dim bSync As Boolean = False

        Me.Cursor = Cursors.WaitCursor

        For Each row As DataGridViewRow In grd.SelectedRows
            If row.Cells("colTicketStatus").Value = "Closed" Then

                sTicketId = row.Cells("colTicketID").Value.ToString

                Try
                    Dim sResult As String
                    sResult = Me.ChangeTicketClosedDate(sTicketId)

                    If sResult.Contains("Ok:") And bSync = False Then
                        bSync = True
                    End If

                    If sResult.Contains("Canceled") And bError = False Then
                        bError = True
                    End If

                    lstTickets.Items.Add(sResult)
                Catch ex As Exception
                    lstTickets.Items.Add(sTicketId & " - Error - " & ex.Message)
                    bError = True
                End Try

            End If
        Next

        If bSync = True Then
            Dim frm As New frmSyncTicket
            frm.sUsername = Me.sUsername
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing
        End If

        Me.Cursor = Cursors.Arrow

        bReloadGrid = True

        If bError = True Then
            Me.Cursor = Cursors.Arrow
            MsgBox("Some error happened during the process", vbExclamation)
        Else
            Me.Dispose()
        End If

    End Sub

    Public Function ChangeTicketClosedDate(ByVal sTicketId As String) As String

        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection()

        Dim util As New clsUtils

        Dim sql As String
        Dim ds As New DataSet

        Dim sReturn As String = ""

        '--Checking if the Date is equal or hight the created date.
        sql = "SELECT DATESERVICE, #" & dtpTicketClosedDate.Value.ToString("yyyy-MM-dd") & "# AS NEWDATE " &
              "FROM zSQL_TICKET " &
              "WHERE TICKETID = '" & sTicketId & "'"
        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If ds.Tables(0).Rows(i)("NEWDATE") < ds.Tables(0).Rows(i)("DATESERVICE") Then
                    sReturn = sTicketId & " - Canceled: The New Date is shorter than Service Date"
                Else

                    sql = "UPDATE zSQL_TICKET SET SYNCDATETIME = " & util.GetDateTimeUTC() & " " &
                          ",CLOSEDUSER='" & sUsername.ToLower & "' " &
                          ",CLOSEDDATE= #" & dtpTicketClosedDate.Value.ToString("yyyy-MM-dd") & "#  " &
                          ",[UPDATEDDATETIME] = " & util.GetDateTime() & " " &
                          ",[UPDATEDUSER] = '" & sUsername.ToLower & "' " &
                          "WHERE TICKETID = '" & sTicketId & "'"

                    bdconn.ExecuteNonSQL(sql)

                    sReturn = sTicketId & " - Ok: Ticket Closed Date updated"

                End If
            Next
        End If

        ds.Dispose()
        ds = Nothing

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Return sReturn

    End Function



End Class