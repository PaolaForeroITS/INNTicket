Public Class frmInvItemList

    Dim util As New clsUtils
    Public sUsername As String

    Dim bPermitInsUpd As Boolean = True


    Private Sub frmInvItemList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.INVENTORYITEM' table. You can move, or remove it, as needed.
        Me.INVENTORYITEMTableAdapter.Fill(Me.SESTicketSQLDataSet.INVENTORYITEM)
        Filter()

        'User Grants
        FormUserGrant()

    End Sub

    Private Sub dgvInvItem_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvItem.CellDoubleClick

        If bPermitInsUpd = False Then
            Exit Sub
        End If

        Dim frm As New frmInvItemEdit

        With frm
            .CarregaCbx()
            .txtInvItemID.Text = dgvInvItem.CurrentRow.Cells("colInventoryItemID").Value
            .cbxActive.Text = dgvInvItem.CurrentRow.Cells("colActive").Value
            .txtDescription.Text = util.TrataDBNull(dgvInvItem.CurrentRow.Cells("colDescription").Value)
            .cbxInventoryClass.SelectedValue = dgvInvItem.CurrentRow.Cells("colInventoryClassID").Value
            .cbxDefaultSite.SelectedValue = dgvInvItem.CurrentRow.Cells("colDefaultSiteID").Value
            .txtLastCost.Text = util.ConcatDecimalStr(dgvInvItem.CurrentRow.Cells("colLastCost").Value)
            .txtMinOnHand.Text = util.ConcatDecimalStr(dgvInvItem.CurrentRow.Cells("colMinOnHand").Value)
            .txtAvgCost.Text = util.ConcatDecimalStr(dgvInvItem.CurrentRow.Cells("colAverageCost").Value)
            .txtMaxOnHand.Text = util.ConcatDecimalStr(dgvInvItem.CurrentRow.Cells("colMaxOnHand").Value)
            .txtListPrice.Text = util.ConcatDecimalStr(dgvInvItem.CurrentRow.Cells("colListPrice").Value)
            .txtSalesUnit.Text = dgvInvItem.CurrentRow.Cells("colDefaultSalesUnit").Value
            .txtPurchaseUnit.Text = dgvInvItem.CurrentRow.Cells("colDefaultPurchaseUnit").Value
            .cbxStorageUnit.Text = dgvInvItem.CurrentRow.Cells("colStorageUnit").Value
            .txtGoodAccount.Text = util.TrataDBNull(dgvInvItem.CurrentRow.Cells("colCostOfGoodsAccount").Value)
            .txtGoodsSubAccount.Text = util.TrataDBNull(dgvInvItem.CurrentRow.Cells("colCostOfGoodsSubAccount").Value)
            .txtInvAccount.Text = util.TrataDBNull(dgvInvItem.CurrentRow.Cells("colInventoryAccount").Value)
            .txtInvSubAccount.Text = util.TrataDBNull(dgvInvItem.CurrentRow.Cells("colInventorySubAccount").Value)
            .txtSalesAccount.Text = util.TrataDBNull(dgvInvItem.CurrentRow.Cells("colSalesAccount").Value)
            .txtSalesSubAccount.Text = util.TrataDBNull(dgvInvItem.CurrentRow.Cells("colSalesSubAccount").Value)
            .txtSalesAccountAIU.Text = util.TrataDBNull(dgvInvItem.CurrentRow.Cells("colSalesAccountAIU").Value)
            .txtSalesAccountUBR.Text = util.TrataDBNull(dgvInvItem.CurrentRow.Cells("colSalesAccountUBR").Value)
            .txtSalesAccountUBRAIU.Text = util.TrataDBNull(dgvInvItem.CurrentRow.Cells("colSalesAccountUBRAIU").Value)
            .txtAbbrev.Text = util.TrataDBNull(dgvInvItem.CurrentRow.Cells("colAbbreviation").Value)

            .txtVendorId.Text = util.TrataDBNull(dgvInvItem.CurrentRow.Cells("colVendorId").Value)
            .txtVendor.Text = util.TrataDBNull(dgvInvItem.CurrentRow.Cells("colVendor").Value)
            .txtBrand.Text = util.TrataDBNull(dgvInvItem.CurrentRow.Cells("colBrand").Value)

            .cbxStorageUnit.Enabled = False
        End With
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing

        Me.INVENTORYITEMTableAdapter.Fill(Me.SESTicketSQLDataSet.INVENTORYITEM)
        Filter()
    End Sub

    Private Sub dgvInvItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvItem.CellContentClick

    End Sub

    Private Sub mnuNewItem_Click(sender As Object, e As EventArgs) Handles mnuNewItem.Click

        Dim frm As New frmInvItemEdit
        With frm
            .CarregaCbx()
            .txtAvgCost.Text = "0"
            .txtMaxOnHand.Text = "0"
            .txtMinOnHand.Text = "0"
            .txtLastCost.Text = "0"
            .txtListPrice.Text = "0"
            .cbxStorageUnit.Enabled = True
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing

        Me.INVENTORYITEMTableAdapter.Fill(Me.SESTicketSQLDataSet.INVENTORYITEM)
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

        INVENTORYITEMBindingSource.Filter = sfilter
        dgvInvItem.Refresh()

        ChangeColorGrid()
    End Sub

    Private Sub ChangeColorGrid()
        For i = 0 To dgvInvItem.Rows.Count - 1
            If dgvInvItem.Rows(i).Cells("colActive").Value = "YES" Then
                With dgvInvItem.Rows(i)
                    .DefaultCellStyle.ForeColor = Color.Blue
                End With
            Else
                With dgvInvItem.Rows(i)
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

    Private Sub mnuExportData_Click(sender As Object, e As EventArgs) Handles mnuExportData.Click
        Dim frm As New frmDataExpLayout
        frm.sLayoutType = "INVENTORYITEM"
        frm.Size = New Size(401, 95)
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub mnuImportData_Click(sender As Object, e As EventArgs) Handles mnuImportData.Click
        Dim frm As New frmDataImp
        frm.sLayoutType = "INVENTORYITEM"
        frm.sUsername = Me.sUsername
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
        Me.INVENTORYITEMTableAdapter.Fill(Me.SESTicketSQLDataSet.INVENTORYITEM)
        Filter()
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
              "and obj.OBJECTFORM = 'frmInvItemList' " &
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