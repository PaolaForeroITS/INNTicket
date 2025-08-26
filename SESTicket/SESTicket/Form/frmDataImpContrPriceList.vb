Public Class frmDataImpContrPriceList

    Public sCustomerName As String = ""
    Public sContractNumber As String = ""
    Public sContractId As String = ""

    Private Sub frmDataImpContrPriceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.SESTicketSQLDataSet.CUSTOMER)

        If IsNothing(cbxCustomer.SelectedValue) = False Then
            If IsDBNull(cbxCustomer.SelectedValue) = False Then
                'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CONTRACTPRICELIST' table. You can move, or remove it, as needed.
                Me.CONTRACTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACT, cbxCustomer.SelectedValue.ToString)
            End If
        End If

    End Sub

    Private Sub cbxCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCustomer.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCustomer.SelectedIndexChanged
        If IsNothing(cbxCustomer.SelectedValue) = False Then
            If IsDBNull(cbxCustomer.SelectedValue) = False Then
                'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CONTRACTPRICELIST' table. You can move, or remove it, as needed.
                Me.CONTRACTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACT, cbxCustomer.SelectedValue.ToString)
            End If
        End If
    End Sub

    Private Sub cbxContract_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxContract.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxContract_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxContract.SelectedIndexChanged

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        If cbxContract.Text = "" Then
            MsgBox("Choose the Contract", vbInformation)
            Exit Sub
        End If

        sCustomerName = cbxCustomer.Text
        sContractNumber = cbxContract.Text
        sContractId = cbxContract.SelectedValue

        Me.Dispose()

    End Sub
End Class