Public Class frmContractPriceRefreshTicket

    Public sUsername As String

    Private Sub frmContractPriceRefreshTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.SESTicketSQLDataSet.CUSTOMER)
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.TICKET_V' table. You can move, or remove it, as needed.
        Me.TICKET_VTableAdapter.Fill(Me.SESTicketSQLDataSet.TICKET_V)
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CONTRACTPRICELIST' table. You can move, or remove it, as needed.
        Me.CONTRACTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACT, cbxCustomer.SelectedValue.ToString)

        Filter()

    End Sub

    Private Sub dgvTicket_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvTicket.CellFormatting
        For l As Integer = 0 To Me.dgvTicket.RowCount - 1
            If dgvTicket.Rows(l).Cells("colTicketStatus").Value = "Canceled" Then
                With dgvTicket.Rows(l)
                    .DefaultCellStyle.ForeColor = Color.Red
                End With
            ElseIf dgvTicket.Rows(l).Cells("colTicketStatus").Value = "Closed" Then
                With dgvTicket.Rows(l)
                    .DefaultCellStyle.ForeColor = Color.Blue
                End With
            ElseIf dgvTicket.Rows(l).Cells("colTicketStatus").Value = "Open" Then
                With dgvTicket.Rows(l)
                    .DefaultCellStyle.ForeColor = Color.DarkGreen
                End With
            End If
        Next
    End Sub

    Private Sub Filter()
        Dim sfilter As String = ""

        Dim sTicketStatus As String = "'Open'"

        If chkShowClosed.Checked = True Then
            If sTicketStatus <> "" Then
                sTicketStatus = sTicketStatus & ","
            End If
            sTicketStatus = sTicketStatus & "'Closed'"
        End If

        sfilter = "TICKETSTATUS IN (" & sTicketStatus & ")"

        If IsDBNull(cbxContract.SelectedValue) = False Then
            If IsNothing(cbxContract.SelectedValue) = False Then
                sfilter = sfilter + "AND CONTRACTID = " & cbxContract.SelectedValue & ""
            Else
                sfilter = sfilter + "AND CONTRACTID = -1 "
            End If
        Else
            sfilter = sfilter + "AND CONTRACTID = -1 "
        End If

        TICKET_VBindingSource.Filter = sfilter
        dgvTicket.Refresh()

    End Sub

    Private Sub chkShowClosed_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowClosed.CheckedChanged
        Filter()
    End Sub

    Private Sub chkCheckAllLines_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheckAllLines.CheckedChanged
        For l As Integer = 0 To Me.dgvTicket.RowCount - 1
            dgvTicket.Rows(l).Cells("colChecked").Value = chkCheckAllLines.Checked
        Next
    End Sub

    Private Sub cbxCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCustomer.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCustomer.SelectedIndexChanged
        If IsDBNull(cbxCustomer.SelectedValue) = False Then
            If IsNothing(cbxCustomer.SelectedValue) = False Then
                'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CONTRACTPRICELIST' table. You can move, or remove it, as needed.
                Me.CONTRACTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACT, cbxCustomer.SelectedValue.ToString)
                Filter()
            End If
        End If
    End Sub

    Private Sub cbxContract_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxContract.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxContract_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxContract.SelectedIndexChanged
        If IsDBNull(cbxContract.SelectedValue) = False Then
            If IsNothing(cbxContract.SelectedValue) = False Then
                Filter()
            End If
        End If
    End Sub

    Private Sub dgvTicket_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTicket.CellDoubleClick
        If dgvTicket.CurrentRow.Cells("colChecked").Value = True Then
            dgvTicket.CurrentRow.Cells("colChecked").Value = False
        Else
            dgvTicket.CurrentRow.Cells("colChecked").Value = True
        End If
    End Sub

    Private Sub btnRefreshPrices_Click(sender As Object, e As EventArgs) Handles btnRefreshPrices.Click

        Dim sMsg As String = "Do you want refresh all prices in the Ticket?" + Environment.NewLine + "This action is irreversible"

        If MsgBox(sMsg, vbYesNo) = vbYes Then

            Me.Cursor = Cursors.WaitCursor

            Dim clsRefresh As New clsUpdSalesItemTicket
            Dim bEntry As Boolean = False

            For l As Integer = 0 To Me.dgvTicket.RowCount - 1
                If dgvTicket.Rows(l).Cells("colChecked").Value = True Then
                    bEntry = True
                    With clsRefresh
                        .sTicketId = dgvTicket.Rows(l).Cells("colTicketID").Value
                        .sUsername = Me.sUsername
                        .Refresh()
                    End With
                End If
            Next
            clsRefresh.Dispose()

            Me.Cursor = Cursors.Arrow

            If bEntry = True Then
                Dim frm As New frmSyncTicket
                frm.sUsername = Me.sUsername
                frm.ShowDialog()
                frm.Dispose()
                frm = Nothing
            Else
                MsgBox("No Tickets Selected.", vbInformation)
            End If

        End If
    End Sub
End Class