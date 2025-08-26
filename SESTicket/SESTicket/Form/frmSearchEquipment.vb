Public Class frmSearchEquipment

    Dim sFilter As String

    Public sTicketId As String

    Private Sub frmSearchEquipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.EQUIPMENT' table. You can move, or remove it, as needed.
        Me.EQUIPMENTTableAdapter.Fill(Me.SESTicketAccessDataSet.EQUIPMENT)
        sFilter = "ACTIVE = 'YES'"
        EQUIPMENTBindingSource.Filter = sFilter
        dgvEquipment.Refresh()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchItem()
    End Sub


    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchItem()
        End If
    End Sub

    Private Sub SearchItem()
        sFilter = "ACTIVE='YES' AND SEARCHOP LIKE '%" & txtSearch.Text & "%'"
        EQUIPMENTBindingSource.Filter = sFilter
        dgvEquipment.Refresh()

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        InsertTicketEquipment()
    End Sub

    Private Sub InsertTicketEquipment()

        If dgvEquipment.SelectedRows.Count = 0 Then
            MsgBox("Select Line", vbInformation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        For Each row As DataGridViewRow In dgvEquipment.SelectedRows

            Dim bdconn As New clsBancoDadosACCESS
            Dim sql As String

            bdconn.OpenConnection()

            Dim seq As New clsSequenceAccess(sTicketId)

            sql = "INSERT INTO [TICKETEQUIPMENT] (TICKETEQUIPMENTID, [TICKETID],[EQUIPMENTID],[CONSUMPTION]) VALUES ("
            sql = sql & " '" & seq.TicketEquipmentNextId & "',"
            sql = sql & " '" & sTicketId & "',"
            sql = sql & " '" & row.Cells("colEquipmentId").Value & "',"
            sql = sql & " 0)"

            bdconn.ExecuteNonSQL(sql)

            seq.Dispose()
            seq = Nothing

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

        Next


        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketId, "ACCESS")
        sync.Dispose()
        sync = Nothing

        Me.Cursor = Cursors.Arrow
        Me.Dispose()

    End Sub

    Private Sub dgvEquipment_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEquipment.CellDoubleClick
        InsertTicketEquipment()
    End Sub

    Private Sub mnuContextOk_Click(sender As Object, e As EventArgs) Handles mnuContextOk.Click
        InsertTicketEquipment()
    End Sub
End Class