
Public Class frmTicketEquipment

    Dim util As New clsUtils
    Dim sUsername As String

    Public sTicketId As String
    Public bTicketReadOnly As Boolean = True

    Private Sub frmTicketEquipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        If bTicketReadOnly = True Then
            mnuConsDelete.Enabled = False
            btnAdd.Enabled = False
            dgvEquip.Columns("colConsumptionAux").ReadOnly = True
        End If
    End Sub

    Private Sub LoadGrid()


        Me.Cursor = Cursors.WaitCursor

        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETEQUIPMENT_V' table. You can move, or remove it, as needed.
        Me.TICKETEQUIPMENT_VTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETEQUIPMENT_V)

        TICKETEQUIPMENT_VBindingSource.Filter = "TICKETID = '" & sTicketId & "'"
        dgvEquip.Refresh()

        LoadConsumption()

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim frm As New frmSearchEquipment
        With frm
            .sTicketId = Me.sTicketId
            .ShowDialog()
        End With
        frm.Dispose()
        frm = Nothing

        LoadGrid()

    End Sub

    Private Sub dgvEquip_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEquip.CellContentClick

    End Sub

    Private Sub dgvEquip_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvEquip.CellBeginEdit
        If e.ColumnIndex = 6 Then
            With dgvEquip.Rows(e.RowIndex).Cells("colConsumptionAux")
                .Style.BackColor = Color.Yellow
            End With
        End If
    End Sub

    Private Sub dgvEquip_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEquip.CellEndEdit
        If e.ColumnIndex = 6 Then
            With dgvEquip.Rows(e.RowIndex).Cells("colConsumptionAux")
                .Style.BackColor = Color.White
            End With

            Dim strCons As String = ""

            Try
                strCons = util.SQLConvStrNull(dgvEquip.Rows(e.RowIndex).Cells("colConsumptionAux").Value, "n")
                If strCons = "NULL" Then strCons = "0"
            Catch ex As Exception
                MsgBox("Invalid Number", vbInformation)
                LoadConsumption()
                Exit Sub
            End Try

            Me.Cursor = Cursors.WaitCursor

            Dim bdconn As New clsBancoDadosACCESS
            Dim sql As String

            bdconn.OpenConnection()

            sql = "UPDATE [TICKETEQUIPMENT] SET CONSUMPTION = " & strCons & " " &
                  "WHERE TICKETEQUIPMENTID = '" & dgvEquip.Rows(e.RowIndex).Cells("colTicketEquipmentId").Value & "'"
            bdconn.ExecuteNonSQL(sql)

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

            Dim sync As New clsSyncTicket
            sync.UpdateSyncDateTime(sTicketId, "ACCESS")
            sync.Dispose()
            sync = Nothing

            LoadGrid()

            Me.Cursor = Cursors.Arrow

        End If
    End Sub

    Private Sub LoadConsumption()
        For l As Integer = 0 To Me.dgvEquip.RowCount - 1
            dgvEquip.Rows(l).Cells("colConsumptionAux").Value = dgvEquip.Rows(l).Cells("colConsumption").Value
        Next
    End Sub


    Private Sub dgvEquip_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvEquip.EditingControlShowing
        If dgvEquip.CurrentCell.ColumnIndex = 6 Then
            AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress_DECIMAL
        End If
    End Sub

    Private Sub TextBox_keyPress_DECIMAL(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If dgvEquip.CurrentCell.ColumnIndex = 6 Then
            If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = "." Or e.KeyChar = ChrW(8)) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub mnuConsDelete_Click(sender As Object, e As EventArgs) Handles mnuConsDelete.Click
        If dgvEquip.SelectedRows.Count = 0 Then
            MsgBox("Select Line", vbInformation)
            Exit Sub
        End If

        If MsgBox("Do you want DELETE this lines?", vbYesNo) = vbNo Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        For Each row As DataGridViewRow In dgvEquip.SelectedRows

            Dim bdconn As New clsBancoDadosACCESS
            Dim sql As String

            bdconn.OpenConnection()

            sql = "DELETE FROM [TICKETEQUIPMENT] WHERE TICKETEQUIPMENTID = '" & row.Cells("colTicketEquipmentId").Value & "'"
            bdconn.ExecuteNonSQL(sql)

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

        Next

        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketId, "ACCESS")
        sync.Dispose()
        sync = Nothing

        LoadGrid()

        Me.Cursor = Cursors.Arrow

    End Sub

End Class