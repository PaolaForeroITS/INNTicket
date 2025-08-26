Public Class frmImportTicket

    Public sUsername As String
    Public bReloadGrid As Boolean = False
    Dim grd As DataGridView

    Public Sub LoadGrid(ByRef grd1 As DataGridView)
        grd = grd1
    End Sub

    Private Sub frmImportTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If grd.SelectedRows.Count = 0 Then
            MsgBox("Select Item", vbInformation)
            Me.Dispose()
        End If

        For Each row As DataGridViewRow In grd.SelectedRows
            lstTickets.Items.Add(row.Cells("colTicketId").Value)
        Next

    End Sub

    Private Sub mnuImportTicket_Click(sender As Object, e As EventArgs) Handles mnuImportTicket.Click

        If MsgBox("Do you want Import the Tickets?", vbYesNo) = vbNo Then
            Exit Sub
        End If

        Dim bError As Boolean = False

        lstTickets.Items.Clear()

        Dim imp As New clsSyncTicket
        Dim sTicketId As String

        imp.sUsername = Me.sUsername

        Me.Cursor = Cursors.WaitCursor

        For Each row As DataGridViewRow In grd.SelectedRows

            sTicketId = row.Cells("colTicketID").Value.ToString

            Try

                Me.Cursor = Cursors.WaitCursor

                If imp.IsTicketExistsAccess(sTicketId) = True Then
                    Me.Cursor = Cursors.Arrow
                    If MsgBox("The Ticket " & sTicketId & " exists in Local Area. Overwrite?", vbYesNo) = vbYes Then
                        Me.Cursor = Cursors.WaitCursor
                        ImportTicket(sTicketId)
                        lstTickets.Items.Add(sTicketId & " - Ok")
                    Else
                        lstTickets.Items.Add(sTicketId & " - Canceled")
                    End If
                Else
                    ImportTicket(sTicketId)
                    lstTickets.Items.Add(sTicketId & " - Ok")
                    Me.Cursor = Cursors.Arrow
                End If


            Catch ex As Exception
                lstTickets.Items.Add(sTicketId & " - Error - " & ex.Message)
                bError = True
            End Try

        Next
        imp.Dispose()
        imp = Nothing

        Me.Cursor = Cursors.Arrow

        bReloadGrid = True

        MsgBox("Tickets imported successfully.", vbInformation)

        If bError = True Then
            Me.Cursor = Cursors.Arrow
            MsgBox("Some error happened during the process", vbExclamation)
            mnuImportTicket.Enabled = False
        Else
            Me.Dispose()
        End If

    End Sub

    Private Sub ImportTicket(sTicketId As String)
        Dim imp As New clsSyncTicket
        imp.DeleteTicket(sTicketId, "ACCESS")
        imp.SendTicket(sTicketId, "ACCESS")
        imp.Dispose()
        imp = Nothing
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub

End Class