Public Class frmInvClassEdit
    Dim util As New clsUtils
    Dim sInvClassIDold As String = ""

    Private Sub frmInvClassEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sInvClassIDold = txtInvClassID.Text
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtInvClassID.Text = "" Then
            MsgBox("Inform the Inventory Class ID", vbExclamation)
            Exit Sub
        End If

        If txtDescription.Text = "" Then
            MsgBox("Inform the Description", vbExclamation)
            Exit Sub
        End If

        If cbxType.Text = "" Then
            MsgBox("Inform the Type", vbExclamation)
            Exit Sub
        End If

        Dim bdconnSQL As New clsBancoDadosSQL
        Dim sql As String
        Dim ds As New DataSet

        bdconnSQL.OpenConnection()

        If sInvClassIDold = "" Then

            sql = "SELECT 1 AS QDE FROM [INVENTORYCLASS] WHERE INVENTORYCLASSID = '" & txtInvClassID.Text & "'"
            bdconnSQL.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("The Inventory Class ID is being used by another Inventory Class.", vbExclamation)
                ds.Dispose()
                bdconnSQL.CloseConnection()
                bdconnSQL.Dispose()
                Exit Sub
            End If

            sql = "INSERT INTO [INVENTORYCLASS]  " & _
                "([INVENTORYCLASSID],[TYPE],[DESCRIPTION] " & _
                ",[COSTOFGOODSACCOUNT],[COSTOFGOODSSUBACCOUNT],[SALESACCOUNT] " & _
                ",[SALESACCOUNTAIU],[SALESACCOUNTUBR],[SALESACCOUNTUBRAIU],[SALESSUBACCOUNT]  " & _
                ",[INVENTORYACCOUNT],[INVENTORYSUBACCOUNT]) VALUES ('"

            sql = sql & txtInvClassID.Text & "','"
            sql = sql & cbxType.Text & "','"
            sql = sql & txtDescription.Text & "',"
            sql = sql & util.SQLConvStrNull(txtGoodAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtGoodsSubAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesAccountAIU.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesAccountUBR.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesAccountUBRAIU.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesSubAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtInvAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtInvSubAccount.Text, "s") & ")"

            bdconnSQL.ExecuteNonSQL(sql)

        Else

            If sInvClassIDold <> txtInvClassID.Text Then

                sql = "SELECT 1 AS QDE FROM [INVENTORYCLASS] WHERE INVENTORYCLASSID = '" & txtInvClassID.Text & "'"
                bdconnSQL.ExecuteSQL(sql, ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    MsgBox("The Inventory Class ID is being used by another Inventory Class.", vbExclamation)
                    ds.Dispose()
                    bdconnSQL.CloseConnection()
                    bdconnSQL.Dispose()
                    Exit Sub
                End If

            End If

            sql = "UPDATE [INVENTORYCLASS] SET " & _
                " [INVENTORYCLASSID] = '" & txtInvClassID.Text & "' " & _
                ",[DESCRIPTION] = " & util.SQLConvStrNull(txtDescription.Text, "s") & " " & _
                ",[TYPE] = '" & cbxType.Text & "' " & _
                ",[COSTOFGOODSACCOUNT] = " & util.SQLConvStrNull(txtGoodAccount.Text, "s") & " " & _
                ",[COSTOFGOODSSUBACCOUNT] = " & util.SQLConvStrNull(txtGoodsSubAccount.Text, "s") & " " & _
                ",[SALESACCOUNT] = " & util.SQLConvStrNull(txtSalesAccount.Text, "s") & " " & _
                ",[SALESACCOUNTAIU] = " & util.SQLConvStrNull(txtSalesAccountAIU.Text, "s") & " " & _
                ",[SALESACCOUNTUBR] = " & util.SQLConvStrNull(txtSalesAccountUBR.Text, "s") & " " & _
                ",[SALESACCOUNTUBRAIU] = " & util.SQLConvStrNull(txtSalesAccountUBRAIU.Text, "s") & " " & _
                ",[SALESSUBACCOUNT] = " & util.SQLConvStrNull(txtSalesSubAccount.Text, "s") & " " & _
                ",[INVENTORYACCOUNT] = " & util.SQLConvStrNull(txtInvAccount.Text, "s") & " " & _
                ",[INVENTORYSUBACCOUNT] = " & util.SQLConvStrNull(txtInvSubAccount.Text, "s") & " "

            If sInvClassIDold <> "" Then
                sql = sql & "WHERE [INVENTORYCLASSID] = '" & sInvClassIDold & "'"
            Else
                sql = sql & "WHERE [INVENTORYCLASSID] = '" & txtInvClassID.Text & "'"
            End If

            bdconnSQL.ExecuteNonSQL(sql)

        End If

        bdconnSQL.CloseConnection()
        bdconnSQL.Dispose()
        bdconnSQL = Nothing
        ds.Dispose()
        ds = Nothing

        Dim syn As New clsSyncBaseData
        syn.UpdateVersionBaseSQL("INVENTORYCLASS")
        syn.Dispose()
        syn = Nothing

        '------
        Me.Hide()

        If MsgBox("Done. You should be synchronize the information. Do you want proceed it now?", vbYesNo) = vbYes Then
            Dim frm As New frmSyncBaseData
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing
        End If

        Me.Dispose()

    End Sub
End Class