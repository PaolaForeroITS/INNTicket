Public Class frmRemoveTicketGrid

    Public bReloadGrid As Boolean = False
    Dim grd As DataGridView

    Private Sub frmRemoveTicketGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If grd.SelectedRows.Count = 0 Then
            MsgBox("Select Item", vbInformation)
            Me.Dispose()
        End If

        Dim nCount As Integer = 0

        For Each row As DataGridViewRow In grd.SelectedRows
            If row.Cells("colSyncDB").Value = True Then
                nCount = 1
                lstTickets.Items.Add(row.Cells("colTicketID").Value)
            End If
        Next

        If nCount = 0 Then
            MsgBox("The Selected Lines are not Synchronized", vbInformation)
            Me.Dispose()
        End If
    End Sub

    Public Sub LoadGrid(ByRef grd1 As DataGridView)
        grd = grd1
    End Sub


    Private Sub mnuRemoveTicket_Click(sender As Object, e As EventArgs) Handles mnuRemoveTicket.Click

        Dim bError As Boolean = False

        lstTickets.Items.Clear()

        Dim sync As New clsSyncTicket
        Dim sTicketId As String

        Me.Cursor = Cursors.WaitCursor

        For Each row As DataGridViewRow In grd.SelectedRows
            If row.Cells("colSyncDB").Value = True Then

                sTicketId = row.Cells("colTicketID").Value.ToString

                Try
                    sync.DeleteTicket(sTicketId, "ACCESS")
                    lstTickets.Items.Add(sTicketId & " - Ok")
                Catch ex As Exception
                    lstTickets.Items.Add(sTicketId & " - Error - " & ex.Message)
                    bError = True
                End Try

            End If
        Next
        sync.Dispose()
        sync = Nothing

        Me.Cursor = Cursors.Arrow

        bReloadGrid = True

        If bError = True Then
            Me.Cursor = Cursors.Arrow
            MsgBox("Some error happened during the process", vbExclamation)
            mnuRemoveTicket.Enabled = False
        Else
            Me.Dispose()
        End If
    End Sub
End Class