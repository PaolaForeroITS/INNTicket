Public Class frmSiteEdit

    Dim util As New clsUtils
    Dim sSiteIDOld As String

    Public Sub CarregaCbx()
        Me.COUNTRYTableAdapter.Fill(Me.SESTicketSQLDataSet.COUNTRY)

        Me.STATETableAdapter.Fill(Me.SESTicketSQLDataSet.STATE)
        STATEBindingSource.Filter = "COUNTRYID=169"
        cbxState.Refresh()
        Me.CITYTableAdapter.Fill(Me.SESTicketSQLDataSet.CITY)
        CITYBindingSource.Filter = "STATEID=91"
        cbxCity.Refresh()

    End Sub

    Private Sub frmSiteEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sSiteIDOld = txtSiteID.Text

        If sSiteIDOld = "" Then
            CarregaCbx()
        End If

    End Sub

    Private Sub cbxCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCountry.SelectedIndexChanged
        Me.STATETableAdapter.Fill(Me.SESTicketSQLDataSet.STATE)
        If Not IsNothing(cbxCountry.SelectedValue) Then
            STATEBindingSource.Filter = "COUNTRYID= " & cbxCountry.SelectedValue & " "
            cbxState.Refresh()
        End If

    End Sub

    Private Sub cbxState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxState.SelectedIndexChanged
        Me.CITYTableAdapter.Fill(Me.SESTicketSQLDataSet.CITY)
        If Not IsNothing(cbxState.SelectedValue) Then
            CITYBindingSource.Filter = "STATEID=" & cbxState.SelectedValue & ""
            cbxCity.Refresh()
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtSiteID.Text = "" Then
            MsgBox("Inform the Site ID", vbExclamation)
            Exit Sub
        End If

        If txtAlias.Text = "" Then
            MsgBox("Inform the Alias", vbExclamation)
            Exit Sub
        End If

        If txtName.Text = "" Then
            MsgBox("Inform the Name", vbExclamation)
            Exit Sub
        End If

        If txtAddress.Text = "" Then
            MsgBox("Inform the Address", vbExclamation)
            Exit Sub
        End If

        If cbxCountry.Text = "" Then
            MsgBox("Inform the Country", vbExclamation)
            Exit Sub
        End If

        If cbxState.Text = "" Then
            MsgBox("Inform the State", vbExclamation)
            Exit Sub
        End If

        Dim bdconnSQL As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconnSQL.OpenConnection("AccBaseData")

        If sSiteIDOld = "" Then

            sql = "SELECT 1 AS QDE FROM zSQL_SITE WHERE [SITEID]= '" & txtSiteID.Text & "'"
            bdconnSQL.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("The Site ID is being used by another Site.", vbExclamation)
                ds.Dispose()
                bdconnSQL.CloseConnection()
                bdconnSQL.Dispose()
                Exit Sub
            End If

            sql = "INSERT INTO zSQL_SITE " & _
                "([SITEID],[NAME],[DESCRIPTION],[ADDRESS] " & _
                ",[ATENTION],[CITY],[COUNTRY],[PHONE],[FAX] " & _
                ",[EMAIL],[COSTOFGOODSACCOUNT],[COSTOFGOODSSUBACCOUNT] " & _
                ",[SALESACCOUNT],[SALESSUBACCOUNT],[INVENTORYACCOUNT] " & _
                ",[INVENTORYSUBACCOUNT],STATE, ALIAS) VALUES ('"

            sql = sql & txtSiteID.Text & "','"
            sql = sql & txtName.Text & "',"
            sql = sql & util.SQLConvStrNull(txtDescription.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtAddress.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtAttention.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(cbxCity.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(cbxCountry.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtPhone.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtFax.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtEmail.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtGoodAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtGoodsSubAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesSubAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtInvAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtInvSubAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(cbxState.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtAlias.Text, "s") & ")"

            bdconnSQL.ExecuteNonSQL(sql)

        Else

            If sSiteIDOld <> txtSiteID.Text Then

                sql = "SELECT 1 AS QDE FROM zSQL_SITE WHERE [SITEID]= '" & txtSiteID.Text & "'"
                bdconnSQL.ExecuteSQL(sql, ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    MsgBox("The Site ID is being used by another Site.", vbExclamation)
                    ds.Dispose()
                    bdconnSQL.CloseConnection()
                    bdconnSQL.Dispose()
                    Exit Sub
                End If

            End If

            sql = "UPDATE zSQL_SITE SET " & _
                        " [SITEID] = '" & txtSiteID.Text & "' " & _
                        ",[NAME] =  '" & txtName.Text & "' " & _
                        ",[DESCRIPTION] =  " & util.SQLConvStrNull(txtDescription.Text, "s") & " " & _
                        ",[ADDRESS] = " & util.SQLConvStrNull(txtAddress.Text, "s") & " " & _
                        ",[ATENTION] =  " & util.SQLConvStrNull(txtAttention.Text, "s") & " " & _
                        ",[CITY] =  " & util.SQLConvStrNull(cbxCity.Text, "s") & " " & _
                        ",[COUNTRY] =  " & util.SQLConvStrNull(cbxCountry.Text, "s") & " " & _
                        ",[PHONE] =  " & util.SQLConvStrNull(txtPhone.Text, "s") & " " & _
                        ",[FAX] =  " & util.SQLConvStrNull(txtFax.Text, "s") & " " & _
                        ",[EMAIL] =  " & util.SQLConvStrNull(txtEmail.Text, "s") & " " & _
                        ",[COSTOFGOODSACCOUNT] =  " & util.SQLConvStrNull(txtGoodAccount.Text, "s") & " " & _
                        ",[COSTOFGOODSSUBACCOUNT] =  " & util.SQLConvStrNull(txtGoodsSubAccount.Text, "s") & " " & _
                        ",[SALESACCOUNT] =  " & util.SQLConvStrNull(txtSalesAccount.Text, "s") & " " & _
                        ",[SALESSUBACCOUNT] =  " & util.SQLConvStrNull(txtSalesSubAccount.Text, "s") & " " & _
                        ",[INVENTORYACCOUNT] =  " & util.SQLConvStrNull(txtInvAccount.Text, "s") & " " & _
                        ",[INVENTORYSUBACCOUNT] =  " & util.SQLConvStrNull(txtInvSubAccount.Text, "s") & " " & _
                        ",[STATE] =  " & util.SQLConvStrNull(cbxState.Text, "s") & " " & _
                        ",[ALIAS] =  " & util.SQLConvStrNull(txtAlias.Text, "s") & " "

            If sSiteIDOld <> "" Then
                sql = sql & "WHERE [SITEID] = '" & sSiteIDOld & "'"
            Else
                sql = sql & "WHERE [SITEID] = '" & txtSiteID.Text & "'"
            End If

            bdconnSQL.ExecuteNonSQL(sql)

        End If

        bdconnSQL.CloseConnection()
        bdconnSQL.Dispose()
        ds.Dispose()
        ds = Nothing
        bdconnSQL = Nothing

        Dim syn As New clsSyncBaseData
        syn.UpdateVersionBaseSQL("SITE")
        syn.Dispose()
        syn = Nothing

        '------
        'Me.Hide()

        If MsgBox("Done. You should be synchronize the information. Do you want proceed it now?", vbYesNo) = vbYes Then
            Dim frm As New frmSyncBaseData
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing
        End If

        Me.Dispose()

    End Sub
End Class