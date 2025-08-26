Public Class frmInvItemEdit

    Dim util As New clsUtils
    Dim sInvItemIDold As String = ""

    Private Sub frmInvItemEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sInvItemIDold = txtInvItemID.Text
    End Sub

    Public Sub CarregaCbx()
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.SITES' table. You can move, or remove it, as needed.
        Me.SITESTableAdapter.Fill(Me.SESTicketSQLDataSet.SITES)
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.INVENTORYCLASS' table. You can move, or remove it, as needed.
        Me.INVENTORYCLASSTableAdapter.Fill(Me.SESTicketSQLDataSet.INVENTORYCLASS)
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.INVENTORYUNIT' table. You can move, or remove it, as needed.
        Me.INVENTORYUNITTableAdapter.Fill(Me.SESTicketSQLDataSet.INVENTORYUNIT)
    End Sub

    Private Sub txtLastCost_TextChanged(sender As Object, e As EventArgs) Handles txtLastCost.TextChanged
        util.TextBoxMoeda(txtLastCost)
    End Sub

    Private Sub txtMinOnHand_TextChanged(sender As Object, e As EventArgs) Handles txtMinOnHand.TextChanged
        util.TextBoxMoeda(txtMinOnHand)
    End Sub

    Private Sub txtAvgCost_TextChanged(sender As Object, e As EventArgs) Handles txtAvgCost.TextChanged
        util.TextBoxMoeda(txtAvgCost)
    End Sub

    Private Sub txtMaxOnHand_TextChanged(sender As Object, e As EventArgs) Handles txtMaxOnHand.TextChanged
        util.TextBoxMoeda(txtMaxOnHand)
    End Sub

    Private Sub txtListPrice_TextChanged(sender As Object, e As EventArgs) Handles txtListPrice.TextChanged
        util.TextBoxMoeda(txtListPrice)
    End Sub

    Private Sub cbxInventoryClass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxInventoryClass.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxInventoryClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxInventoryClass.SelectedIndexChanged

        If cbxInventoryClass.SelectedIndex >= 0 Then

            Dim bdconnSQL As New clsBancoDadosSQL
            Dim sql As String
            Dim ds As New DataSet

            bdconnSQL.OpenConnection()

            sql = "SELECT " & _
                "[INVENTORYCLASSID] " & _
                ",[TYPE] " & _
                ",[DESCRIPTION] " & _
                ",[COSTOFGOODSACCOUNT] " & _
                ",[COSTOFGOODSSUBACCOUNT] " & _
                ",[SALESACCOUNT] " & _
                ",[SALESACCOUNTAIU] " & _
                ",[SALESACCOUNTUBR] " & _
                ",[SALESACCOUNTUBRAIU] " & _
                ",[SALESSUBACCOUNT] " & _
                ",[INVENTORYACCOUNT] " & _
                ",[INVENTORYSUBACCOUNT] " & _
                "FROM [INVENTORYCLASS] " & _
                "WHERE [INVENTORYCLASSID] = '" & cbxInventoryClass.SelectedValue & "'"

            bdconnSQL.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    txtGoodAccount.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("COSTOFGOODSACCOUNT"))
                    txtGoodsSubAccount.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("COSTOFGOODSSUBACCOUNT"))
                    txtSalesAccount.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("SALESACCOUNT"))
                    txtSalesAccountAIU.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("SALESACCOUNTAIU"))
                    txtSalesAccountUBR.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("SALESACCOUNTUBR"))
                    txtSalesAccountUBRAIU.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("SALESACCOUNTUBRAIU"))
                    txtSalesSubAccount.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("SALESSUBACCOUNT"))
                    txtInvAccount.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("INVENTORYACCOUNT"))
                    txtInvSubAccount.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("INVENTORYSUBACCOUNT"))
                Next
            End If

            bdconnSQL.CloseConnection()
            bdconnSQL.Dispose()
            bdconnSQL = Nothing
            ds.Dispose()
            ds = Nothing

        End If

    End Sub

    Private Sub cbxStorageUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxStorageUnit.SelectedIndexChanged
        If cbxStorageUnit.SelectedIndex >= 0 Then
            txtPurchaseUnit.Text = cbxStorageUnit.Text
            txtSalesUnit.Text = cbxStorageUnit.Text
        End If
    End Sub


    Private Sub cbxActive_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxActive.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxDefaultSite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxDefaultSite.KeyPress
        e.Handled = True
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        If txtInvItemID.Text = "" Then
            MsgBox("Inform the Inventory Item ID", vbExclamation)
            Exit Sub
        End If

        If cbxInventoryClass.Text = "" Then
            MsgBox("Inform the Inventory Class", vbExclamation)
            Exit Sub
        End If

        If cbxDefaultSite.Text = "" Then
            MsgBox("Inform the Default Site", vbExclamation)
            Exit Sub
        End If

        If cbxStorageUnit.Text = "" Then
            MsgBox("Inform the Storage Unit", vbExclamation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim bdconnSQL As New clsBancoDadosSQL
        Dim sql As String
        Dim ds As New DataSet

        bdconnSQL.OpenConnection()

        If sInvItemIDold = "" Then

            sql = "SELECT 1 AS QDE FROM [INVENTORYITEM] WHERE INVENTORYITEMID = '" & txtInvItemID.Text & "'"
            bdconnSQL.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("The Inventory Item ID is being used by another Inventory Item.", vbExclamation)
                ds.Dispose()
                ds = Nothing
                bdconnSQL.CloseConnection()
                bdconnSQL.Dispose()
                bdconnSQL = Nothing
                Exit Sub
            End If

            sql = "INSERT INTO [INVENTORYITEM]  " &
                "([INVENTORYITEMID],[DESCRIPTION],[INVENTORYCLASSID],[LASTCOST]  " &
                ",[AVERAGECOST],[LISTPRICE],[DEFAULTSITEID],[STORAGEUNIT],[DEFAULTSALESUNIT]  " &
                ",[DEFAULTPURCHASEUNIT],[COSTOFGOODSACCOUNT],[COSTOFGOODSSUBACCOUNT],[SALESACCOUNT] " &
                ",[SALESACCOUNTAIU],[SALESACCOUNTUBR],[SALESACCOUNTUBRAIU],[SALESSUBACCOUNT]  " &
                ",[INVENTORYACCOUNT],[INVENTORYSUBACCOUNT],[MINONHAND],[MAXONHAND],[ABBREVIATION],[ACTIVE],VENDOR,BRAND,VENDORID) VALUES ('"

            sql = sql & txtInvItemID.Text & "',"
            sql = sql & util.SQLConvStrNull(txtDescription.Text, "s") & ",'"
            sql = sql & cbxInventoryClass.SelectedValue & "',"
            sql = sql & util.SQLConvStrNull(txtLastCost.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtAvgCost.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtListPrice.Text, "n") & ",'"
            sql = sql & cbxDefaultSite.SelectedValue & "','"
            sql = sql & cbxStorageUnit.Text & "','"
            sql = sql & txtSalesUnit.Text & "','"
            sql = sql & txtPurchaseUnit.Text & "',"
            sql = sql & util.SQLConvStrNull(txtGoodAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtGoodsSubAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesAccountAIU.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesAccountUBR.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesAccountUBRAIU.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesSubAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtInvAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtInvSubAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtMinOnHand.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtMaxOnHand.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtAbbrev.Text, "s") & ",'"
            sql = sql & cbxActive.Text & "',"
            sql = sql & util.SQLConvStrNull(txtVendor.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtBrand.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtVendorId.Text, "s") & ")"
            bdconnSQL.ExecuteNonSQL(sql)

        Else

            If sInvItemIDold <> txtInvItemID.Text Then

                sql = "SELECT 1 AS QDE FROM [INVENTORYITEM] WHERE INVENTORYITEMID = '" & txtInvItemID.Text & "'"
                bdconnSQL.ExecuteSQL(sql, ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    MsgBox("The Inventory Item ID is being used by another Inventory Item.", vbExclamation)
                    ds.Dispose()
                    bdconnSQL.CloseConnection()
                    bdconnSQL.Dispose()
                    bdconnSQL = Nothing
                    ds = Nothing
                    Exit Sub
                End If

            End If

            sql = "UPDATE [INVENTORYITEM] SET " &
                " [INVENTORYITEMID] = '" & txtInvItemID.Text & "' " &
                ",[DESCRIPTION] = " & util.SQLConvStrNull(txtDescription.Text, "s") & " " &
                ",[INVENTORYCLASSID] = '" & cbxInventoryClass.SelectedValue & "' " &
                ",[LASTCOST] = " & util.SQLConvStrNull(txtLastCost.Text, "n") & " " &
                ",[AVERAGECOST] = " & util.SQLConvStrNull(txtAvgCost.Text, "n") & " " &
                ",[LISTPRICE] = " & util.SQLConvStrNull(txtListPrice.Text, "n") & " " &
                ",[DEFAULTSITEID] = '" & cbxDefaultSite.SelectedValue & "' " &
                ",[STORAGEUNIT] = '" & cbxStorageUnit.Text & "' " &
                ",[DEFAULTSALESUNIT] = '" & txtSalesUnit.Text & "' " &
                ",[DEFAULTPURCHASEUNIT] = '" & txtPurchaseUnit.Text & "' " &
                ",[COSTOFGOODSACCOUNT] = " & util.SQLConvStrNull(txtGoodAccount.Text, "s") & " " &
                ",[COSTOFGOODSSUBACCOUNT] = " & util.SQLConvStrNull(txtGoodsSubAccount.Text, "s") & " " &
                ",[SALESACCOUNT] = " & util.SQLConvStrNull(txtSalesAccount.Text, "s") & " " &
                ",[SALESACCOUNTAIU] = " & util.SQLConvStrNull(txtSalesAccountAIU.Text, "s") & " " &
                ",[SALESACCOUNTUBR] = " & util.SQLConvStrNull(txtSalesAccountUBR.Text, "s") & " " &
                ",[SALESACCOUNTUBRAIU] = " & util.SQLConvStrNull(txtSalesAccountUBRAIU.Text, "s") & " " &
                ",[SALESSUBACCOUNT] = " & util.SQLConvStrNull(txtSalesSubAccount.Text, "s") & " " &
                ",[INVENTORYACCOUNT] = " & util.SQLConvStrNull(txtInvAccount.Text, "s") & " " &
                ",[INVENTORYSUBACCOUNT] = " & util.SQLConvStrNull(txtInvSubAccount.Text, "s") & " " &
                ",[MINONHAND] = " & util.SQLConvStrNull(txtMinOnHand.Text, "n") & " " &
                ",[MAXONHAND] = " & util.SQLConvStrNull(txtMaxOnHand.Text, "n") & " " &
                ",[ABBREVIATION] = " & util.SQLConvStrNull(txtAbbrev.Text, "s") & " " &
                ",[ACTIVE] = '" & cbxActive.Text & "' " &
                ",[VENDOR] = " & util.SQLConvStrNull(txtVendor.Text, "s") & " " &
                ",[BRAND] = " & util.SQLConvStrNull(txtBrand.Text, "s") & " " &
                ",[VENDORID] = " & util.SQLConvStrNull(txtVendorId.Text, "s") & " "

            If sInvItemIDold <> "" Then
                sql = sql & "WHERE [INVENTORYITEMID] = '" & sInvItemIDold & "'"
            Else
                sql = sql & "WHERE [INVENTORYITEMID] = '" & txtInvItemID.Text & "'"
            End If

            bdconnSQL.ExecuteNonSQL(sql)

        End If

        bdconnSQL.CloseConnection()
        bdconnSQL.Dispose()
        bdconnSQL = Nothing
        ds.Dispose()
        ds = Nothing

        Dim syn As New clsSyncBaseData
        syn.UpdateVersionBaseSQL("INVENTORYITEM")
        syn.Dispose()
        syn = Nothing

        '------
        'Me.Hide()

        Me.Cursor = Cursors.Arrow

        If MsgBox("Done. You should be synchronize the information. Do you want proceed it now?", vbYesNo) = vbYes Then
            Dim frm As New frmSyncBaseData
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing
        End If

        Me.Dispose()

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub
End Class