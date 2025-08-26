Public Class frmCustomerEdit

    Dim util As New clsUtils
    Dim sCustomerIDold As String

    Public Sub CarregaCbx()
        Me.COUNTRYTableAdapter.Fill(Me.SESTicketSQLDataSet.COUNTRY)
        Me.STATETableAdapter.Fill(Me.SESTicketSQLDataSet.STATE)
        STATEBindingSource.Filter = "COUNTRYID=169"
        cbxState.Refresh()
        Me.CITYTableAdapter.Fill(Me.SESTicketSQLDataSet.CITY)
        CITYBindingSource.Filter = "STATEID=91"
        cbxCity.Refresh()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub frmCustomerEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sCustomerIDold = txtCustomerID.Text

        If sCustomerIDold = "" Then
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

        If txtCustomerID.Text = "" Then
            MsgBox("Inform the Customer ID", vbExclamation)
            Exit Sub
        End If

        If txtName.Text = "" Then
            MsgBox("Inform the Name", vbExclamation)
            Exit Sub
        End If

        If txtAddress1.Text = "" Then
            MsgBox("Inform the Address1", vbExclamation)
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

        If sCustomerIDold = "" Then

            sql = "SELECT 1 AS QDE FROM zSQL_CUSTOMER WHERE [CUSTOMERID]= '" & txtCustomerID.Text & "'"
            bdconnSQL.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("The Customer Item ID is being used by another Customer.", vbExclamation)
                ds.Dispose()
                bdconnSQL.CloseConnection()
                bdconnSQL.Dispose()
                Exit Sub
            End If

            sql = "INSERT INTO zSQL_CUSTOMER " & _
                  "([CUSTOMERID],[NAME],[ADDRESS1],[ADDRESS2],[CITY] " & _
                  ",[STATE],[COUNTRY],[PHONE],[FAX],[EMAIL],[OBS]" & _
                  ",[SALESACCOUNT],[SALESSUBACCOUNT],[ARACCOUNT],[ARSUBACCOUNT]) VALUES ('"

            sql = sql & txtCustomerID.Text & "','"
            sql = sql & txtName.Text & "','"
            sql = sql & txtAddress1.Text & "',"
            sql = sql & util.SQLConvStrNull(txtAddress2.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(cbxCity.Text, "s") & ",'"
            sql = sql & cbxState.Text & "','"
            sql = sql & cbxCountry.Text & "',"
            sql = sql & util.SQLConvStrNull(txtPhone.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtFax.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtEmail.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtObs.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesSubAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtARAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtARSubAccount.Text, "s") & ")"

            bdconnSQL.ExecuteNonSQL(sql)

        Else

            If sCustomerIDold <> txtCustomerID.Text Then

                sql = "SELECT 1 AS QDE FROM zSQL_CUSTOMER WHERE [CUSTOMERID] = '" & txtCustomerID.Text & "'"
                bdconnSQL.ExecuteSQL(sql, ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    MsgBox("The Customer Item ID is being used by another Customer.", vbExclamation)
                    ds.Dispose()
                    bdconnSQL.CloseConnection()
                    bdconnSQL.Dispose()
                    Exit Sub
                End If

            End If

            sql = "UPDATE zSQL_CUSTOMER SET " & _
                        "[CUSTOMERID] = '" & txtCustomerID.Text & "' " & _
                        ",[NAME] =  '" & txtName.Text & "' " & _
                        ",[ADDRESS1] =  '" & txtAddress1.Text & "' " & _
                        ",[ADDRESS2] = " & util.SQLConvStrNull(txtAddress2.Text, "s") & " " & _
                        ",[CITY] =  " & util.SQLConvStrNull(cbxCity.Text, "s") & " " & _
                        ",[STATE] =  '" & cbxState.Text & "' " & _
                        ",[COUNTRY] =  '" & cbxCountry.Text & "' " & _
                        ",[PHONE] =  " & util.SQLConvStrNull(txtPhone.Text, "s") & " " & _
                        ",[FAX] =  " & util.SQLConvStrNull(txtFax.Text, "s") & " " & _
                        ",[EMAIL] =  " & util.SQLConvStrNull(txtEmail.Text, "s") & " " & _
                        ",[OBS] =  " & util.SQLConvStrNull(txtObs.Text, "s") & " " & _
                        ",[SALESACCOUNT] =  " & util.SQLConvStrNull(txtSalesAccount.Text, "s") & " " & _
                        ",[SALESSUBACCOUNT] =  " & util.SQLConvStrNull(txtSalesSubAccount.Text, "s") & " " & _
                        ",[ARACCOUNT] =  " & util.SQLConvStrNull(txtARAccount.Text, "s") & " " & _
                        ",[ARSUBACCOUNT] =  " & util.SQLConvStrNull(txtARSubAccount.Text, "s") & " "

            If sCustomerIDold <> "" Then
                sql = sql & "WHERE [CUSTOMERID] = '" & sCustomerIDold & "'"
            Else
                sql = sql & "WHERE [CUSTOMERID] = '" & txtCustomerID.Text & "'"
            End If

            bdconnSQL.ExecuteNonSQL(sql)

        End If

        bdconnSQL.CloseConnection()
        bdconnSQL.Dispose()
        ds.Dispose()
        bdconnSQL = Nothing
        ds = Nothing

        Dim syn As New clsSyncBaseData
        syn.UpdateVersionBaseSQL("CUSTOMER")
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