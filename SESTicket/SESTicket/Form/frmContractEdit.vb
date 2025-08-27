Public Class frmContractEdit

    Public sContractId As String = ""
    Dim sContractNumberOld As String = ""
    Dim util As New clsUtils

    Public sReportParamId As String = ""

    Private Sub frmContractEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        util.DateTimePickerFormat(dtpStartDate)
        util.DateTimePickerFormat(dtpDueDate)

        sContractNumberOld = txtContractNumber.Text

        If sContractNumberOld = "" Then
            cbxLayoutType.SelectedValue = "L02"
            cbxCurrency.SelectedValue = "USD"
            cbxEnableExcRate.Text = "YES"
            cbxEnableDisc.Text = "YES"
            cbxInvSplitAmount.Text = "NO"

            txtExchangeRate.Text = "0"
            txtServiceUtilityPerc.Text = "0"
            txtServiceIVAPerc.Text = "0"
            txtMaterialIVAPerc.Text = "0"
            txtPortionUSD.Text = "0"
            txtPortionCOP.Text = "0"

            chkServiceUtility.Checked = True

        End If

        ReloadTicketLayout()

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub ReloadTicketLayout()
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CONTRACTREPLAYOUT' table. You can move, or remove it, as needed.
        Me.CONTRACTREPLAYOUTTableAdapter.Fill(Me.SESTicketSQLDataSet.CONTRACTREPLAYOUT)

        Dim Filter As String
        If sContractId = "" Then
            Filter = "CONTRACTID='-1'"
        Else
            Filter = "CONTRACTID='" & sContractId & "'"
        End If

        CONTRACTREPLAYOUTBindingSource.Filter = Filter
        dgvReportLayout.Refresh()

    End Sub

    Public Sub Init()
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.AIUTable' table. You can move, or remove it, as needed.
        Me.AIUTableTableAdapter.Fill(Me.SESTicketSQLDataSet.AIUTable)
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.SESTicketSQLDataSet.CUSTOMER)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.CURRENCY' table. You can move, or remove it, as needed.
        Me.CURRENCYTableAdapter.Fill(Me.SESTicketAccessDataSet.CURRENCY)
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.LAYOUTTYPE' table. You can move, or remove it, as needed.
        Me.LAYOUTTYPETableAdapter.Fill(Me.SESTicketSQLDataSet.LAYOUTTYPE)
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.SERVICELINE' table. You can move, or remove it, as needed.
        Me.SERVICELINETableAdapter.Fill(Me.SESTicketSQLDataSet.SERVICELINE)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.COUNTRY' table. You can move, or remove it, as needed.
        Me.COUNTRYTableAdapter.Fill(Me.SESTicketAccessDataSet.COUNTRY)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.REPORTTICKETLIST' table. You can move, or remove it, as needed.
        Me.REPORTTICKETLISTTableAdapter.Fill(Me.SESTicketAccessDataSet.REPORTTICKETLIST)


        CarregaListGroup()
        FilterReport()


    End Sub

    Private Sub CarregaListGroup()

        chkAIUApplication.Items.Clear()

        Dim bdconnSQL As New clsBancoDadosSQL
        Dim sql As String
        Dim ds As New DataSet
        Dim checked As Boolean

        bdconnSQL.OpenConnection()

        sql = "SELECT IC.DESCRIPTION, " &
              "(SELECT COUNT(*) FROM CONTRACTAIUINVENTORYCLASS CL " &
              "WHERE IC.INVENTORYCLASSID = CL.INVENTORYCLASSID " &
              "AND CL.CONTRACTID = '" & sContractId & "' " &
              ") AS QTD " &
              "FROM INVENTORYCLASS IC " &
              "ORDER BY IC.DESCRIPTION "

        bdconnSQL.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                If ds.Tables(0).Rows(i)("QTD") = 0 Then
                    checked = False
                Else
                    checked = True
                End If

                chkAIUApplication.Items.Add(util.TrataDBNull(ds.Tables(0).Rows(i)("DESCRIPTION")), checked)
            Next
        End If

        bdconnSQL.CloseConnection()
        bdconnSQL.Dispose()
        bdconnSQL = Nothing
        ds.Dispose()
        ds = Nothing

    End Sub

    Private Sub SalvaListGroup()

        Dim bdconnSQL As New clsBancoDadosSQL
        Dim sql As String
        Dim ds As New DataSet

        Dim ContractID As String = ""

        bdconnSQL.OpenConnection()

        '------------------
        'Get the CONTRACTID
        '------------------
        sql = "SELECT CONTRACTID FROM CONTRACT WHERE CONTRACTNUMBER='" & txtContractNumber.Text & "' "

        bdconnSQL.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                ContractID = ds.Tables(0).Rows(i)("CONTRACTID")
            Next
        End If
        ds.Dispose()

        ds = New DataSet()

        '-----------------------------------------------
        'Clear the table [CONTRACTAIUINVENTORYCLASS]
        '-----------------------------------------------
        sql = "DELETE FROM [CONTRACTAIUINVENTORYCLASS]  " &
              "WHERE CONTRACTID = " & ContractID & " "

        bdconnSQL.ExecuteNonSQL(sql)

        '-----------------------------------------------
        'List all CheckedListGroup with Status "CHECKED"
        '-----------------------------------------------
        For Each item As Object In chkAIUApplication.CheckedItems

            sql = "INSERT INTO [CONTRACTAIUINVENTORYCLASS] (CONTRACTID,INVENTORYCLASSID) VALUES (" &
                  ContractID & "," &
                  "(SELECT INVENTORYCLASSID FROM INVENTORYCLASS WHERE DESCRIPTION = '" & item.ToString() & "'))"

            bdconnSQL.ExecuteNonSQL(sql)

        Next

        bdconnSQL.CloseConnection()
        bdconnSQL.Dispose()
        bdconnSQL = Nothing

        ds.Dispose()
        ds = Nothing

    End Sub

    Private Sub chkServiceUtility_CheckStateChanged(sender As Object, e As EventArgs) Handles chkServiceUtility.CheckStateChanged
        If chkServiceUtility.Checked = True Then
            txtServiceUtilityPerc.Enabled = False
            txtServiceUtilityPerc.Text = 0
        Else
            txtServiceUtilityPerc.Enabled = True
            txtServiceUtilityPerc.Text = 0
        End If
    End Sub

    Private Sub txtServiceUtilityPerc_TextChanged(sender As Object, e As EventArgs) Handles txtServiceUtilityPerc.TextChanged
        util.TextBoxMoeda(txtServiceUtilityPerc)
    End Sub

    Private Sub txtServiceIVAPerc_TextChanged(sender As Object, e As EventArgs) Handles txtServiceIVAPerc.TextChanged
        util.TextBoxMoeda(txtServiceIVAPerc)
    End Sub

    Private Sub txtMaterialIVAPerc_TextChanged(sender As Object, e As EventArgs) Handles txtMaterialIVAPerc.TextChanged
        util.TextBoxMoeda(txtMaterialIVAPerc)
    End Sub

    Private Sub txtPortionUSD_TextChanged(sender As Object, e As EventArgs) Handles txtPortionUSD.TextChanged
        util.TextBoxMoeda(txtPortionUSD)
    End Sub

    Private Sub txtPortionCOP_TextChanged(sender As Object, e As EventArgs) Handles txtPortionCOP.TextChanged
        util.TextBoxMoeda(txtPortionCOP)
    End Sub

    Private Sub txtExchangeRate_TextChanged(sender As Object, e As EventArgs) Handles txtExchangeRate.TextChanged
        util.TextBoxMoeda(txtExchangeRate)
    End Sub

    Private Sub cbxCurrency_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCurrency.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxActive_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxActive.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCustomer.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxLayoutType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxLayoutType.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxLayoutType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxLayoutType.SelectedIndexChanged
        If cbxLayoutType.SelectedValue = "L01" Then
            grpPortion.Enabled = True
            cbxInvSplitAmount.Text = "NO"
            cbxInvSplitAmount.Enabled = False
        Else
            grpPortion.Enabled = False
            cbxInvSplitAmount.Enabled = True
        End If
    End Sub

    Private Sub cbxPermitDisc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEnableDisc.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxEnableExcRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxEnableExcRate.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxInvSplitAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxInvSplitAmount.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxServiceLine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxServiceLine.KeyPress
        e.Handled = True
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        If cbxServiceLine.Text = "" Then
            MsgBox("Inform the Service Line", vbExclamation)
            Exit Sub
        End If

        If cbxCustomer.Text = "" Then
            MsgBox("Inform the Customer", vbExclamation)
            Exit Sub
        End If

        If txtContractNumber.Text = "" Then
            MsgBox("Inform the Contract Number", vbExclamation)
            Exit Sub
        End If

        If txtName.Text = "" Then
            MsgBox("Inform the Contract Name", vbExclamation)
            Exit Sub
        End If

        If txtDescription.Text = "" Then
            MsgBox("Inform the Contract Description", vbExclamation)
            Exit Sub
        End If

        If cbxCurrency.Text = "" Then
            MsgBox("Inform the Currency", vbExclamation)
            Exit Sub
        End If

        If cbxLayoutType.SelectedValue <> "L01" And cbxLayoutType.SelectedValue <> "L02" Then
            MsgBox("Inform Layout Type")
            Exit Sub
        End If

        If txtExchangeRate.Text = "" Then
            MsgBox("The Exchange Rate must be greater than zero", vbExclamation)
            txtExchangeRate.Focus()
            Exit Sub
        End If

        If CDbl(txtExchangeRate.Text.Replace(",", "")) <= 0 Then
            MsgBox("The Exchange Rate must be greater than zero", vbExclamation)
            txtExchangeRate.Focus()
            Exit Sub
        End If

        If chkServiceUtility.Checked = False Then
            If txtServiceUtilityPerc.Text = "" Then
                MsgBox("The Service Utility PCT must be increase 0", vbExclamation)
                Exit Sub
            ElseIf CDbl(txtServiceUtilityPerc.Text.Replace(",", "")) = 0 Then
                MsgBox("The Service Utility PCT must be increase 0", vbExclamation)
                Exit Sub
            End If
        End If

        If txtServiceIVAPerc.Text = "" Then
            MsgBox("The Service IVA Perc must be increase 0", vbExclamation)
            Exit Sub
        ElseIf CDbl(txtServiceIVAPerc.Text.Replace(",", "")) = 0 Then
            MsgBox("The Service IVA Perc must be increase 0", vbExclamation)
            Exit Sub
        End If

        If txtMaterialIVAPerc.Text = "" Then
            MsgBox("The Material IVA Perc must be increase 0", vbExclamation)
            Exit Sub
        ElseIf CDbl(txtMaterialIVAPerc.Text.Replace(",", "")) = 0 Then
            MsgBox("The Material IVA Perc must be increase 0", vbExclamation)
            Exit Sub
        End If

        Dim sPortionUSD As String = "0"
        Dim sPortionCOP As String = "0"

        If cbxLayoutType.SelectedValue = "L01" Then
            If txtPortionUSD.Text = "" Then
                MsgBox("The Portion USD Perc must be fill in", vbExclamation)
                Exit Sub
            End If
            If txtPortionCOP.Text = "" Then
                MsgBox("The Portion COP Perc must be fill in", vbExclamation)
                Exit Sub
            End If

            sPortionUSD = txtPortionUSD.Text
            sPortionCOP = txtPortionCOP.Text

        End If

        If sContractNumberOld <> "" And MsgBox("Change items will impact the all Tickets. Do you want continue?", vbYesNo) = vbNo Then
            Exit Sub
        End If

        Dim sServiceUtility As String

        If chkServiceUtility.Checked = True Then
            sServiceUtility = 1
        Else
            sServiceUtility = 0
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim bdconnSQL As New clsBancoDadosSQL
        Dim sql As String
        Dim ds As New DataSet

        bdconnSQL.OpenConnection()

        If sContractNumberOld = "" Then

            sql = "SELECT 1 AS QDE FROM [CONTRACT] WHERE [CONTRACTNUMBER]= '" & txtContractNumber.Text & "'"
            bdconnSQL.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("The Contract Number is being used by another Contract.", vbExclamation)
                ds.Dispose()
                ds = Nothing
                bdconnSQL.CloseConnection()
                bdconnSQL.Dispose()
                bdconnSQL = Nothing
                Exit Sub
            End If

            sql = "INSERT INTO [CONTRACT] " &
                "([CONTRACTNUMBER],[NAME],[DESCRIPTION],[CUSTOMERID] " &
                ",[START_DATE],[COMPLETION_DATE],[CURRENCY] " &
                ",[SALESACCOUNT],[SALESSUBACCOUNT],[COSTOFGOODSACCOUNT] " &
                ",[COSTOFGOODSSUBACCOUNT],[ACTIVE],SERVICE_UTILITY,SERVICE_UTILITY_PERC,SERVICE_IVA_PERC,MATERIAL_IVA_PERC" &
                ",PORTIONUSD,PORTIONCOP,LAYOUTTYPE,[EXCHANGERATE],ENABLEEXCHANGERATE,ENABLEDISCOUNT,SPLITAMOUNTMATSERV, SERVICELINEID,REPORTPARAMID) VALUES ('"

            sql = sql & txtContractNumber.Text & "','"
            sql = sql & txtName.Text & "','"
            sql = sql & txtDescription.Text & "','"
            sql = sql & cbxCustomer.SelectedValue & "','"
            sql = sql & dtpStartDate.Value.ToString("yyyy-MM-dd") & "','"
            sql = sql & dtpDueDate.Value.ToString("yyyy-MM-dd") & "','"
            sql = sql & cbxCurrency.SelectedValue & "',"
            sql = sql & util.SQLConvStrNull(txtSalesAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesSubAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtGoodAccount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtGoodsSubAccount.Text, "s") & ",'"
            sql = sql & cbxActive.Text & "',"
            sql = sql & util.SQLConvStrNull(sServiceUtility, "n") & ","
            sql = sql & util.SQLConvStrNull(txtServiceUtilityPerc.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtServiceIVAPerc.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtMaterialIVAPerc.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(sPortionUSD, "n") & ","
            sql = sql & util.SQLConvStrNull(sPortionCOP, "n") & ","
            sql = sql & util.SQLConvStrNull(cbxLayoutType.SelectedValue, "s") & ","
            sql = sql & util.SQLConvStrNull(txtExchangeRate.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(cbxEnableExcRate.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(cbxEnableDisc.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(cbxInvSplitAmount.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(cbxServiceLine.SelectedValue, "n") & ","
            sql = sql & util.SQLConvStrNull(sReportParamId, "s") & ")"

            bdconnSQL.ExecuteNonSQL(sql)

        Else

            If sContractNumberOld <> txtContractNumber.Text Then

                sql = "SELECT 1 AS QDE FROM [CONTRACT] WHERE [CONTRACTNUMBER]= '" & txtContractNumber.Text & "'"
                bdconnSQL.ExecuteSQL(sql, ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    MsgBox("The Contract Number is being used by another Contract.", vbExclamation)
                    ds.Dispose()
                    ds = Nothing
                    bdconnSQL.CloseConnection()
                    bdconnSQL.Dispose()
                    bdconnSQL = Nothing
                    Exit Sub
                End If

            End If

            sql = "UPDATE [CONTRACT] SET " &
                " [CONTRACTNUMBER]  = '" & txtContractNumber.Text & "' " &
                ",[NAME]            = '" & txtName.Text & "' " &
                ",[DESCRIPTION]     = '" & txtDescription.Text & "' " &
                ",[CUSTOMERID]      = '" & cbxCustomer.SelectedValue & "' " &
                ",[START_DATE]      = " & util.SQLConvStrDate(dtpStartDate.Value.ToString) & " " &
                ",[COMPLETION_DATE] = " & util.SQLConvStrDate(dtpDueDate.Value.ToString) & " " &
                ",[CURRENCY]        = '" & cbxCurrency.SelectedValue & "' " &
                ",[SALESACCOUNT]    = " & util.SQLConvStrNull(txtSalesAccount.Text, "s") & " " &
                ",[SALESSUBACCOUNT] = " & util.SQLConvStrNull(txtSalesSubAccount.Text, "s") & " " &
                ",[COSTOFGOODSACCOUNT] = " & util.SQLConvStrNull(txtGoodAccount.Text, "s") & " " &
                ",[COSTOFGOODSSUBACCOUNT] = " & util.SQLConvStrNull(txtGoodsSubAccount.Text, "s") & " " &
                ",SERVICE_UTILITY      =" & util.SQLConvStrNull(sServiceUtility, "n") & " " &
                ",SERVICE_UTILITY_PERC =" & util.SQLConvStrNull(txtServiceUtilityPerc.Text, "n") & " " &
                ",SERVICE_IVA_PERC     =" & util.SQLConvStrNull(txtServiceIVAPerc.Text, "n") & " " &
                ",MATERIAL_IVA_PERC    =" & util.SQLConvStrNull(txtMaterialIVAPerc.Text, "n") & " " &
                ",PORTIONUSD    =" & util.SQLConvStrNull(sPortionUSD, "n") & " " &
                ",PORTIONCOP    =" & util.SQLConvStrNull(sPortionCOP, "n") & " " &
                ",ACTIVE        ='" & cbxActive.Text & "' " &
                ",LAYOUTTYPE    =" & util.SQLConvStrNull(cbxLayoutType.SelectedValue, "s") & " " &
                ",[EXCHANGERATE] = " & util.SQLConvStrNull(txtExchangeRate.Text, "n") & " " &
                ",ENABLEEXCHANGERATE  = " & util.SQLConvStrNull(cbxEnableExcRate.Text, "s") & " " &
                ",ENABLEDISCOUNT  = " & util.SQLConvStrNull(cbxEnableDisc.Text, "s") & " " &
                ",SPLITAMOUNTMATSERV  = " & util.SQLConvStrNull(cbxInvSplitAmount.Text, "s") & " " &
                ",SERVICELINEID  = " & util.SQLConvStrNull(cbxServiceLine.SelectedValue, "N") & " " &
                ",REPORTPARAMID  = " & util.SQLConvStrNull(sReportParamId, "s") & " "

            If sContractNumberOld <> "" Then
                sql = sql & "WHERE [CONTRACTNUMBER] = '" & sContractNumberOld & "'"
            Else
                sql = sql & "WHERE [CONTRACTNUMBER] = '" & txtContractNumber.Text & "'"
            End If

            bdconnSQL.ExecuteNonSQL(sql)

        End If

        bdconnSQL.CloseConnection()
        bdconnSQL.Dispose()
        bdconnSQL = Nothing

        ds.Dispose()
        ds = Nothing

        SalvaListGroup()

        Dim syn As New clsSyncBaseData
        syn.UpdateVersionBaseSQL("CONTRACT")
        syn.UpdateVersionBaseSQL("CONTRACTAIUINVENTORYCLASS")
        syn.UpdateVersionBaseSQL("CONTRACTREPLAYOUT")
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

    Private Sub txtRepParam_DoubleClick(sender As Object, e As EventArgs) Handles txtRepParam.DoubleClick

        Dim frm As New frmRPTParameter()
        With frm
            .isSearch = True
            .ShowDialog()
        End With
        frm.Dispose()
        frm = Nothing


    End Sub

    Private Sub cbxCountry_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCountry.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCountry.SelectedIndexChanged
        FilterReport()
    End Sub

    Private Sub FilterReport()
        Dim sFilter As String
        sFilter = "COUNTRYCODE='" & IIf(cbxCountry.Text = "", "COL", cbxCountry.Text) & "'"
        REPORTTICKETLISTBindingSource.Filter = sFilter
        cbxTicketLayout.Refresh()
    End Sub

    Private Sub btnAddTicketLayout_Click(sender As Object, e As EventArgs) Handles btnAddTicketLayout.Click

        If sContractNumberOld = "" Then
            MsgBox("Save the Contract before add a new Ticket Layout", vbInformation)
            Exit Sub
        End If

        If cbxTicketLayout.Text = "" Then
            MsgBox("Select the Ticket Layout", vbInformation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim bdconnSQL As New clsBancoDadosSQL
        Dim sql As String
        Dim ds As New DataSet

        bdconnSQL.OpenConnection()

        sql = "SELECT COUNT(*) AS QDE FROM [CONTRACTREPLAYOUT] " &
              "WHERE [CONTRACTID]= " & sContractId & " AND REPORTCODE = '" & cbxTicketLayout.SelectedValue & "'"
        bdconnSQL.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows(0)("QDE") > 0 Then
            ds.Dispose()
            ds = Nothing
            bdconnSQL.CloseConnection()
            bdconnSQL.Dispose()
            bdconnSQL = Nothing
            Me.Cursor = Cursors.Arrow
            Exit Sub
        End If

        ds.Dispose()
        ds = Nothing

        sql = "INSERT INTO CONTRACTREPLAYOUT VALUES (" & sContractId & ",'" & cbxTicketLayout.SelectedValue & "')"
        bdconnSQL.ExecuteNonSQL(sql)

        bdconnSQL.CloseConnection()
        bdconnSQL.Dispose()
        bdconnSQL = Nothing

        Dim syn As New clsSyncBaseData
        syn.UpdateVersionBaseSQL("CONTRACT")
        syn.UpdateVersionBaseSQL("CONTRACTAIUINVENTORYCLASS")
        syn.UpdateVersionBaseSQL("CONTRACTREPLAYOUT")
        syn.Dispose()
        syn = Nothing

        Me.Cursor = Cursors.Arrow

        If MsgBox("Done. You should be synchronize the information. Do you want proceed it now?", vbYesNo) = vbYes Then
            Dim frm As New frmSyncBaseData
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing
            Me.Dispose()
        Else
            Me.Cursor = Cursors.WaitCursor
            ReloadTicketLayout()
            Me.Cursor = Cursors.Arrow
        End If


    End Sub

    Private Sub btnDeleteTicketLayout_Click(sender As Object, e As EventArgs) Handles btnDeleteTicketLayout.Click
        If sContractNumberOld = "" Then
            MsgBox("Save the Contract before delete a Ticket Layout", vbInformation)
            Exit Sub
        End If

        If dgvReportLayout.RowCount > 0 Then

            Me.Cursor = Cursors.WaitCursor

            Dim bdconnSQL As New clsBancoDadosSQL
            Dim sql As String
            Dim ds As New DataSet

            bdconnSQL.OpenConnection()

            sql = "DELETE FROM CONTRACTREPLAYOUT WHERE CONTRACTREPLAYOUT =" & dgvReportLayout.CurrentRow.Cells("colContractRepLayout").Value & ""
            bdconnSQL.ExecuteNonSQL(sql)

            bdconnSQL.CloseConnection()
            bdconnSQL.Dispose()
            bdconnSQL = Nothing

            Dim syn As New clsSyncBaseData
            syn.UpdateVersionBaseSQL("CONTRACT")
            syn.UpdateVersionBaseSQL("CONTRACTAIUINVENTORYCLASS")
            syn.UpdateVersionBaseSQL("CONTRACTREPLAYOUT")
            syn.Dispose()
            syn = Nothing

            Me.Cursor = Cursors.Arrow

            If MsgBox("Done. You should be synchronize the information. Do you want proceed it now?", vbYesNo) = vbYes Then
                Dim frm As New frmSyncBaseData
                frm.ShowDialog()
                frm.Dispose()
                frm = Nothing
                Me.Dispose()
            Else
                Me.Cursor = Cursors.WaitCursor
                ReloadTicketLayout()
                Me.Cursor = Cursors.Arrow
            End If


        End If

    End Sub
End Class