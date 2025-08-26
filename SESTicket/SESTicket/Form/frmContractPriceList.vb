Public Class frmContractPriceList
    Dim util As New clsUtils
    Public sUsername As String

    Dim bPermitInsUpd As Boolean = True

    Private Sub frmContractPriceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        Try
            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            Me.CUSTOMERTableAdapter.Fill(Me.SESTicketSQLDataSet.CUSTOMER)
            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CONTRACTPRICELIST' table. You can move, or remove it, as needed.
            Me.CONTRACTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACT, cbxCustomer.SelectedValue.ToString)
            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CONTRACTPRICELIST' table. You can move, or remove it, as needed.
            Me.CONTRACTPRICELISTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACTPRICELIST, cbxContract.SelectedValue)
            ChangeColorGrid()

            'User Grants
            FormUserGrant()

            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
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
                'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CONTRACTPRICELIST' table. You can move, or remove it, as needed.
                Me.CONTRACTPRICELISTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACTPRICELIST, cbxContract.SelectedValue)
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
                'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CONTRACTPRICELIST' table. You can move, or remove it, as needed.
                Me.CONTRACTPRICELISTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACTPRICELIST, cbxContract.SelectedValue)
                Filter()
            End If
        End If
    End Sub

    Private Sub dgvContractPriceList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContractPriceList.CellDoubleClick

        If bPermitInsUpd = False Then
            Exit Sub
        End If

        Dim frm As New frmContractPriceEdit

        With frm
            .sContractID = cbxContract.SelectedValue
            .nQdeDecimal = dgvContractPriceList.CurrentRow.Cells("colPriceUnitDecimal").Value

            .Init()

            .cbxPermUpdDescrip.Text = dgvContractPriceList.CurrentRow.Cells("colPermUpdDescrip").Value
            .cbxPermUpdPriceUnit.Text = dgvContractPriceList.CurrentRow.Cells("colPermUpdPriceUnit").Value
            .cbxPermNegative.Text = dgvContractPriceList.CurrentRow.Cells("colPermNegative").Value

            .ContractPriceListID = dgvContractPriceList.CurrentRow.Cells("colContractPriceListID").Value
            .txtCustomer.Text = cbxCustomer.Text
            .txtContract.Text = cbxContract.Text
            .txtCustomerItemCode.Text = dgvContractPriceList.CurrentRow.Cells("colCodeItem").Value
            .txtDescription.Text = util.TrataDBNull(dgvContractPriceList.CurrentRow.Cells("colDescription").Value)
            .txtSalesUnit.Text = util.TrataDBNull(dgvContractPriceList.CurrentRow.Cells("colUnit").Value)
            .txtContractedQuantity.Text = util.ConcatDecimalStr(dgvContractPriceList.CurrentRow.Cells("colQty").Value)
            .cbxInventoryClass.SelectedValue = dgvContractPriceList.CurrentRow.Cells("colClass").Value
            .txtSalesPrice.Text = util.ConcatDecimalStr(dgvContractPriceList.CurrentRow.Cells("colSalesPrice").Value, dgvContractPriceList.CurrentRow.Cells("colPriceUnitDecimal").Value)
            .cbxHeaderGroup.Text = dgvContractPriceList.CurrentRow.Cells("colIsHeader").Value
            .cbxExibitonReport.Text = dgvContractPriceList.CurrentRow.Cells("colExibitonReport").Value
            .txtTabGroup.Text = dgvContractPriceList.CurrentRow.Cells("colTabGroup").Value
            .cbxShowCustCodeRpt.Text = dgvContractPriceList.CurrentRow.Cells("colShowCustItemRep").Value
            .txtInventoryClassType.Text = dgvContractPriceList.CurrentRow.Cells("colInvClassType").Value.ToString
            .cbxActive.Text = dgvContractPriceList.CurrentRow.Cells("colActive").Value.ToString
            .txtGroupOrder.Text = util.ConcatDecimalStr(dgvContractPriceList.CurrentRow.Cells("colGroupOrder").Value)
            .txtPriceBase.Text = util.ConcatDecimalStr(dgvContractPriceList.CurrentRow.Cells("colPriceBase").Value)
            .txtPriceUtility.Text = util.ConcatDecimalStr(dgvContractPriceList.CurrentRow.Cells("colPriceUtility").Value)

            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()

        End With
        frm = Nothing
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CONTRACTPRICELIST' table. You can move, or remove it, as needed.
        Me.CONTRACTPRICELISTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACTPRICELIST, cbxContract.SelectedValue)
        Filter()
    End Sub

    Private Sub dgvContractPriceList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContractPriceList.CellContentClick

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChangeColorGrid()
        For i = 0 To dgvContractPriceList.Rows.Count - 1
            If dgvContractPriceList.Rows(i).Cells("colActive").Value = "YES" Then

                If dgvContractPriceList.Rows(i).Cells("colIsHeader").Value = "YES" Then
                    dgvContractPriceList.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
                End If
                If dgvContractPriceList.Rows(i).Cells("colInvClassType").Value = "Material" Then
                    With dgvContractPriceList.Rows(i)
                        .DefaultCellStyle.ForeColor = Color.DarkGreen
                    End With
                ElseIf dgvContractPriceList.Rows(i).Cells("colInvClassType").Value = "Service" Then
                    With dgvContractPriceList.Rows(i)
                        .DefaultCellStyle.ForeColor = Color.Blue
                    End With
                End If
            Else
                With dgvContractPriceList.Rows(i)
                    .DefaultCellStyle.ForeColor = Color.Red
                End With
            End If

            If Me.dgvContractPriceList.Rows(i).Cells("colSalesPrice").Value < 0 Then
                Me.dgvContractPriceList.Rows(i).Cells("colSalesPrice").Style.ForeColor = Color.FromArgb(192, 0, 0)
            End If

        Next
    End Sub

    Private Sub mnuNewItem_Click(sender As Object, e As EventArgs) Handles mnuNewItem.Click
        Dim frm As New frmContractPriceEdit

        With frm
            .ContractID = cbxContract.SelectedValue
            .txtCustomer.Text = cbxCustomer.Text
            .txtContract.Text = cbxContract.Text
            .Init()
            .txtContractedQuantity.Text = 0
            .txtSalesPrice.Text = 0
            .txtPriceBase.Text = 0
            .txtPriceUtility.Text = 0
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CONTRACTPRICELIST' table. You can move, or remove it, as needed.
        Me.CONTRACTPRICELISTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACTPRICELIST, cbxContract.SelectedValue)
        Filter()
    End Sub

    Private Sub chkYes_CheckedChanged(sender As Object, e As EventArgs) Handles chkYes.CheckedChanged
        Filter()
    End Sub
    Private Sub chkNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkNo.CheckedChanged
        Filter()
    End Sub

    Private Sub Filter()
        Dim sfilter As String = ""
        Dim sActive As String = ""

        If chkYes.Checked = True Then
            sActive = "'YES'"
        End If

        If chkNo.Checked = True Then
            If sActive <> "" Then
                sActive = sActive & ","
            End If
            sActive = sActive & "'NO'"
        End If

        If sActive <> "" Then
            sfilter = sfilter & "ACTIVE IN (" & sActive & ")"
        Else
            sfilter = sfilter & "ACTIVE IN ('NOTHING')"
        End If

        CONTRACTPRICELISTBindingSource.Filter = sfilter
        dgvContractPriceList.Refresh()

        ChangeColorGrid()
    End Sub


    Private Sub mnuExportData_Click(sender As Object, e As EventArgs) Handles mnuExportData.Click
        Dim frm As New frmDataExpLayout
        frm.sLayoutType = "CONTRACTPRICELIST"
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing

    End Sub

    Private Sub mnuImportData_Click(sender As Object, e As EventArgs) Handles mnuImportData.Click
        Dim frm As New frmDataImp
        frm.sLayoutType = "CONTRACTPRICELIST"
        frm.sUsername = Me.sUsername
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing

        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CONTRACTPRICELIST' table. You can move, or remove it, as needed.
        Me.CONTRACTPRICELISTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACTPRICELIST, cbxContract.SelectedValue)
        Filter()
    End Sub

    Private Sub mnuUpdateTicket_Click(sender As Object, e As EventArgs) Handles mnuUpdateTicket.Click
        Dim frm As New frmContractPriceRefreshTicket
        frm.sUsername = Me.sUsername
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing

    End Sub

#Region "FormUserGrants"

    Private Sub FormUserGrant()

        Me.Cursor = Cursors.WaitCursor

        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection("AccBase")

        Dim sql As String
        Dim ds As New DataSet


        sql = "SELECT obj.OBJECTNAME, obj.OBJECTTYPE " &
              "FROM OBJECTGROUPITEMUSER usr, OBJECTGROUPITEM obj " &
              "WHERE usr.OBJECTGROUPITEMID = obj.OBJECTGROUPITEMID " &
              "and usr.ENABLE = 'NO'  " &
              "and obj.OBJECTFORM = 'frmContractPriceList' " &
              "and usr.USERNAME = '" & Me.sUsername & "'"

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim sObject As String = ""

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                sObject = ds.Tables(0).Rows(i)("OBJECTNAME")

                If sObject = "bPermitInsUpd" Then
                    mnuNewItem.Enabled = False
                    bPermitInsUpd = False
                ElseIf sObject = "bPermitExpImpData" Then
                    mnuExportData.Enabled = False
                    mnuImportData.Enabled = False
                ElseIf sObject = "bPermitUpdTickets" Then
                    mnuUpdateTicket.Enabled = False
                End If
            Next

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Me.Cursor = Cursors.Arrow

    End Sub


#End Region

End Class