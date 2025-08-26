Public Class frmContractList

    Dim util As New clsUtils

    Public sUsername As String

    Dim bPermitInsUpd As Boolean = True

    Private Sub Init()
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.SESTicketSQLDataSet.CUSTOMER)
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CONTRACT' table. You can move, or remove it, as needed.
        Me.CONTRACTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACT, cbxCustomer.SelectedValue)

        ChangeColorGrid()

        'User Grants
        FormUserGrant()

    End Sub

    Private Sub frmContractList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
    End Sub

    Private Sub cbxCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCustomer.SelectedIndexChanged
        If cbxCustomer.SelectedIndex > 0 Then
            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CONTRACT' table. You can move, or remove it, as needed.
            Me.CONTRACTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACT, cbxCustomer.SelectedValue.ToString)
            ChangeColorGrid()
        End If
    End Sub

    Private Sub dgvContract_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContract.CellDoubleClick

        If bPermitInsUpd = False Then
            Exit Sub
        End If

        Dim frm As New frmContractEdit

        With frm
            .sContractId = dgvContract.CurrentRow.Cells("colContractID").Value
            .Init()
            .cbxCustomer.SelectedValue = dgvContract.CurrentRow.Cells("colCustomerID").Value
            .txtContractNumber.Text = dgvContract.CurrentRow.Cells("colContractNumber").Value
            .txtName.Text = dgvContract.CurrentRow.Cells("colName").Value
            .txtDescription.Text = dgvContract.CurrentRow.Cells("colDescription").Value
            .dtpStartDate.Text = dgvContract.CurrentRow.Cells("colStartDate").Value
            .dtpDueDate.Text = dgvContract.CurrentRow.Cells("colCompletionDate").Value
            .cbxCurrency.SelectedValue = dgvContract.CurrentRow.Cells("colCurrency").Value

            .txtSalesAccount.Text = util.TrataDBNull(dgvContract.CurrentRow.Cells("colSalesAccount").Value)
            .txtSalesSubAccount.Text = util.TrataDBNull(dgvContract.CurrentRow.Cells("colSalesSubAccount").Value)
            .txtGoodAccount.Text = util.TrataDBNull(dgvContract.CurrentRow.Cells("colGoodsAccount").Value)
            .txtGoodsSubAccount.Text = util.TrataDBNull(dgvContract.CurrentRow.Cells("colGoodsSubAccount").Value)
            .cbxActive.Text = util.TrataDBNull(dgvContract.CurrentRow.Cells("colActive").Value)

            .chkServiceUtility.Checked = dgvContract.CurrentRow.Cells("colServiceUtility").Value
            .txtServiceUtilityPerc.Text = util.ConcatDecimalStr(dgvContract.CurrentRow.Cells("colServiceUtilityPerc").Value)
            .txtServiceIVAPerc.Text = util.ConcatDecimalStr(dgvContract.CurrentRow.Cells("colServiceIVAPerc").Value)
            .txtMaterialIVAPerc.Text = util.ConcatDecimalStr(dgvContract.CurrentRow.Cells("colMaterialIVAPerc").Value)

            .txtPortionCOP.Text = util.ConcatDecimalStr(dgvContract.CurrentRow.Cells("colPortionCOP").Value)
            .txtPortionUSD.Text = util.ConcatDecimalStr(dgvContract.CurrentRow.Cells("colPortionUSD").Value)

            .cbxLayoutType.SelectedValue = dgvContract.CurrentRow.Cells("colLayoutType").Value

            .txtExchangeRate.Text = util.ConcatDecimalStr(dgvContract.CurrentRow.Cells("colExchangeRate").Value)
            .cbxEnableExcRate.Text = dgvContract.CurrentRow.Cells("colEnableExcRate").Value
            .cbxEnableDisc.Text = dgvContract.CurrentRow.Cells("colEnableDisc").Value

            .cbxInvSplitAmount.Text = dgvContract.CurrentRow.Cells("colSplitAmountMatServ").Value

            .cbxServiceLine.SelectedValue = dgvContract.CurrentRow.Cells("colServiceLineId").Value
            .sReportParamId = util.TrataDBNull(dgvContract.CurrentRow.Cells("colReportParamId").Value)
            .txtRepParam.Text = dgvContract.CurrentRow.Cells("colReportParamDesc").Value

        End With
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing

        Me.CONTRACTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACT, cbxCustomer.SelectedValue)

        ChangeColorGrid()
    End Sub


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CONTRACTBindingNavigator_RefreshItems(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvContract_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContract.CellContentClick

    End Sub

    Private Sub mnuNewItem_Click(sender As Object, e As EventArgs) Handles mnuNewItem.Click
        With frmContractEdit
            .sContractId = ""
            .Init()
            .cbxCustomer.SelectedValue = Me.cbxCustomer.SelectedValue
            .ShowDialog()
            .Dispose()
        End With
        Me.CONTRACTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACT, cbxCustomer.SelectedValue)
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

        CONTRACTBindingSource.Filter = sfilter
        dgvContract.Refresh()

        ChangeColorGrid()
    End Sub

    Private Sub ChangeColorGrid()
        For i = 0 To dgvContract.Rows.Count - 1
            If dgvContract.Rows(i).Cells("colActive").Value = "YES" Then
                With dgvContract.Rows(i)
                    .DefaultCellStyle.ForeColor = Color.Blue
                End With
            Else
                With dgvContract.Rows(i)
                    .DefaultCellStyle.ForeColor = Color.Red
                End With
            End If
        Next
    End Sub

    Private Sub chkYes_CheckedChanged(sender As Object, e As EventArgs) Handles chkYes.CheckedChanged
        Filter()
    End Sub

    Private Sub chkNo_CheckedChanged(sender As Object, e As EventArgs) Handles chkNo.CheckedChanged
        Filter()
    End Sub

    Private Sub dgvContract_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvContract.CellFormatting
        ChangeColorGrid()
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
              "and obj.OBJECTFORM = 'frmContractList' " &
              "and usr.USERNAME = '" & Me.sUsername & "'"

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim sObject As String = ""

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                sObject = ds.Tables(0).Rows(i)("OBJECTNAME")

                If sObject = "bPermitInsUpd" Then
                    mnuNewItem.Enabled = False
                    bPermitInsUpd = False
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