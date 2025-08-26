
Public Class frmDataExpLayout

    Public sLayoutType As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If sLayoutType = "CONTRACTPRICELIST" Then
            If optExpDataYes.Checked = True Then
                If cbxContract.Text = "" Then
                    MsgBox("Select the Contract", vbInformation)
                    Exit Sub
                End If
            End If
        End If

        'abre uma caixa de diálogo
        SaveFileDialog1.FileName = sLayoutType
        SaveFileDialog1.ShowDialog()

        If SaveFileDialog1.FileName <> sLayoutType Then

            'Copy the File to Destiny
            Me.Cursor = Cursors.WaitCursor

            Dim cls As New clsDataExp
            cls.ExpLayout(sLayoutType, SaveFileDialog1.FileName)
            If sLayoutType = "CONTRACTPRICELIST" And optExpDataYes.Checked = True Then
                cls.ContractPriceList(SaveFileDialog1.FileName, IIf(optExpInacLineYes.Checked, True, False), cbxContract.SelectedValue)
            End If
            If sLayoutType = "EQUIPMENT" And optExpDataYes.Checked = True Then
                cls.Equipment(SaveFileDialog1.FileName, IIf(optExpInacLineYes.Checked, True, False))
            End If
            If sLayoutType = "WORKER" And optExpDataYes.Checked = True Then
                cls.Worker(SaveFileDialog1.FileName, IIf(optExpInacLineYes.Checked, True, False))
            End If
            If sLayoutType = "INVENTORYITEM" And optExpDataYes.Checked = True Then
                cls.InventoryItem(SaveFileDialog1.FileName, IIf(optExpInacLineYes.Checked, True, False))
            End If
            If sLayoutType = "WELL" And optExpDataYes.Checked = True Then
                cls.Well(SaveFileDialog1.FileName, IIf(optExpInacLineYes.Checked, True, False))
            End If

            cls.Dispose()
            cls = Nothing

            Me.Cursor = Cursors.Arrow
            MsgBox("Exported to " & SaveFileDialog1.FileName)

        End If

    End Sub

    Private Sub frmDataExpLayout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            Me.CUSTOMERTableAdapter.Fill(Me.SESTicketSQLDataSet.CUSTOMER)
            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CONTRACTPRICELIST' table. You can move, or remove it, as needed.
            Me.CONTRACTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACT, cbxCustomer.SelectedValue.ToString)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cbxCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCustomer.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCustomer.SelectedIndexChanged
        If IsDBNull(cbxCustomer.SelectedValue) = False Then
            If IsNothing(cbxCustomer.SelectedValue) = False Then
                'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CONTRACTPRICELIST' table. You can move, or remove it, as needed.
                Me.CONTRACTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACT, cbxCustomer.SelectedValue.ToString)
            End If
        End If
    End Sub

    Private Sub cbxContract_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxContract.KeyPress
        e.Handled = True
    End Sub

    Private Sub optExpDataNo_CheckedChanged(sender As Object, e As EventArgs) Handles optExpDataNo.CheckedChanged
        TabControl1.Enabled = False
    End Sub

    Private Sub optExpDataYes_CheckedChanged(sender As Object, e As EventArgs) Handles optExpDataYes.CheckedChanged
        TabControl1.Enabled = True
    End Sub
End Class