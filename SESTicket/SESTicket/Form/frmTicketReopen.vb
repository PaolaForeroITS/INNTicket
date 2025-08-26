Public Class frmTicketReopen

    Public sUsername As String
    Public bReloadGrid As Boolean = False
    Dim grd As DataGridView

    Public Sub LoadGrid(ByRef grd1 As DataGridView)
        grd = grd1
    End Sub

    Private Sub frmTicketReopen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            MsgBox("The Tickets should be Closed to Re-Open", vbInformation)
            Me.Dispose()
            Exit Sub
        End If

    End Sub

    Private Sub mnuReOpenTicket_Click(sender As Object, e As EventArgs) Handles mnuReOpenTicket.Click

        If txtAuthBy.Text.Trim = "" Then
            MsgBox("Inform Who is Authorized Re-Open", vbInformation)
            Exit Sub
        End If

        If MsgBox("Do you want Re-Open the Tickets?", vbYesNo) = vbNo Then
            Exit Sub
        End If

        Dim bError As Boolean = False

        lstTickets.Items.Clear()

        Dim sync As New clsSyncTicket
        Dim sTicketId As String

        sync.sUsername = Me.sUsername

        Me.Cursor = Cursors.WaitCursor

        For Each row As DataGridViewRow In grd.SelectedRows
            If row.Cells("colTicketStatus").Value = "Closed" Then

                sTicketId = row.Cells("colTicketID").Value.ToString

                Try
                    sync.TicketReopenSQL(sTicketId, Me.sUsername, txtAuthBy.Text, txtComment.Text)
                    lstTickets.Items.Add(sTicketId & " - Ok")
                Catch ex As Exception
                    lstTickets.Items.Add(sTicketId & " - Error - " & ex.Message)
                    bError = True
                End Try

            End If
        Next
        sync.Dispose()
        sync = Nothing

        Dim frm As New frmSyncTicket
        frm.sUsername = Me.sUsername
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing

        Me.Cursor = Cursors.Arrow

        bReloadGrid = True

        If bError = True Then
            Me.Cursor = Cursors.Arrow
            MsgBox("Some error happened during the process", vbExclamation)
            mnuReOpenTicket.Enabled = False
        Else
            Me.Dispose()
        End If

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub
End Class