Public Class frmContractPriceEdit

    Public sContractID As String
    Dim sContractPriceListID As String = ""
    Dim util As New clsUtils

    Public sUsername As String
    Public nQdeDecimal As Double = 2

    Public Sub Init()
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.INVENTORYCLASS' table. You can move, or remove it, as needed.
        Me.INVENTORYCLASS_PRICETableAdapter.Fill(Me.SESTicketSQLDataSet.INVENTORYCLASS_PRICE, sContractID)

    End Sub

    Public Property ContractID() As String
        Get
            Return sContractID
        End Get
        Set(ByVal Value As String)
            sContractID = Value
        End Set
    End Property

    Public Property ContractPriceListID() As String
        Get
            Return sContractPriceListID
        End Get
        Set(ByVal Value As String)
            sContractPriceListID = Value
        End Set
    End Property

    Private Sub txtContractedQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtContractedQuantity.TextChanged
        util.TextBoxMoeda(txtContractedQuantity)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtCustomerItemCode.Text = "" Then
            MsgBox("Inform the Customer Item Code", vbExclamation)
            Exit Sub
        End If

        If cbxInventoryClass.Text = "" Then
            MsgBox("Inform the Inventory Class", vbExclamation)
            Exit Sub
        End If

        If txtSalesPrice.Text = "" Then
            MsgBox("Inform the Sales Price", vbExclamation)
            Exit Sub
        End If

        If txtContractedQuantity.Text = "" Then
            MsgBox("Inform the Contract Quantity", vbExclamation)
            Exit Sub
        End If

        If txtTabGroup.Text = "" Then
            MsgBox("Inform the Tab Group", vbExclamation)
            Exit Sub
        End If

        If cbxExibitonReport.Text = "" Then
            MsgBox("Inform the Exibit on Report", vbExclamation)
            Exit Sub
        End If

        If cbxShowCustCodeRpt.Text = "" Then
            MsgBox("Inform the Exibit Cust Code on Report", vbExclamation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim bdconnSQL As New clsBancoDadosSQL
        Dim sql As String
        Dim ds As New DataSet

        bdconnSQL.OpenConnection()

        If sContractPriceListID = "" Then

            sql = "INSERT INTO [CONTRACTPRICELIST]  " &
                    "([CONTRACTID],[CUSTCODEITEM],[DESCRIPTION],[SALES_PRICE] " &
                    ",[UNIT_SALE],[INVENTORYCLASSID],[CONTRACTED_QTY],[ACTIVE],ISHEADER,EXIBITONREPORT,TABGROUP,SHOWCUSTITEMREPORT," &
                    "CREATEDUSER,CREATEDDATETIME,GROUPORDER, PRICEBASE,PRICEUTILITY,PERMITUPDATEDESCRIP,PERMITUPDATEPRICEUNIT,PERMITNEGATIVE,PRICEUNITDECIMAL) VALUES  ("

            sql = sql & sContractID & ",'"
            sql = sql & txtCustomerItemCode.Text & "',"
            sql = sql & util.SQLConvStrNull(txtDescription.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesPrice.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtSalesUnit.Text, "s") & ",'"
            sql = sql & cbxInventoryClass.SelectedValue & "',"
            sql = sql & util.SQLConvStrNull(txtContractedQuantity.Text, "n") & ",'"
            sql = sql & cbxActive.Text & "','"
            sql = sql & cbxHeaderGroup.Text & "','"
            sql = sql & cbxExibitonReport.Text & "','"
            sql = sql & txtTabGroup.Text & "','"
            sql = sql & cbxShowCustCodeRpt.Text & "','"
            sql = sql & sUsername.ToLower & "'," & util.GetDateTime() & ","
            sql = sql & util.SQLConvStrNull(txtGroupOrder.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtPriceBase.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtPriceUtility.Text, "n") & ",'"
            sql = sql & cbxPermUpdDescrip.Text & "','"
            sql = sql & cbxPermUpdPriceUnit.Text & "','"
            sql = sql & cbxPermNegative.Text & "',"
            sql = sql & util.SQLConvStrNull(nQdeDecimal, "n") & ")"

            bdconnSQL.ExecuteNonSQL(sql)

        Else

            sql = "UPDATE [CONTRACTPRICELIST] SET " &
                " [CUSTCODEITEM]     = '" & txtCustomerItemCode.Text & "' " &
                ",[DESCRIPTION]      = " & util.SQLConvStrNull(txtDescription.Text, "s") & " " &
                ",[SALES_PRICE]      = " & util.SQLConvStrNull(txtSalesPrice.Text, "n") & " " &
                ",[UNIT_SALE]        = " & util.SQLConvStrNull(txtSalesUnit.Text, "s") & " " &
                ",[INVENTORYCLASSID] = '" & cbxInventoryClass.SelectedValue & "' " &
                ",[CONTRACTED_QTY]   = " & util.SQLConvStrNull(txtContractedQuantity.Text, "n") & " " &
                ",ISHEADER           = '" & cbxHeaderGroup.Text & "' " &
                ",EXIBITONREPORT     = '" & cbxExibitonReport.Text & "' " &
                ",TABGROUP           = '" & txtTabGroup.Text & "' " &
                ",SHOWCUSTITEMREPORT = '" & cbxShowCustCodeRpt.Text & "' " &
                ",ACTIVE             = '" & cbxActive.Text & "' " &
                ",UPDATEDUSER        = '" & sUsername.ToLower & "' " &
                ",UPDATEDDATETIME    = " & util.GetDateTime() & " " &
                ",[GROUPORDER]      = " & util.SQLConvStrNull(txtGroupOrder.Text, "n") & " " &
                ",[PRICEBASE]      = " & util.SQLConvStrNull(txtPriceBase.Text, "n") & " " &
                ",[PRICEUTILITY]      = " & util.SQLConvStrNull(txtPriceUtility.Text, "n") & " " &
                ",PERMITUPDATEDESCRIP   = '" & cbxPermUpdDescrip.Text & "' " &
                ",PERMITUPDATEPRICEUNIT = '" & cbxPermUpdPriceUnit.Text & "' " &
                ",PERMITNEGATIVE        = '" & cbxPermNegative.Text & "' " &
                ",[PRICEUNITDECIMAL]   = " & util.SQLConvStrNull(nQdeDecimal, "n") & " " &
                " WHERE [CONTRACTID] = '" & sContractID & "' " &
                " AND CONTRACTPRICELISTID = " & sContractPriceListID & " "

            bdconnSQL.ExecuteNonSQL(sql)

            'Updating the CUSTCODEITEM in the Tickets
            sql = "UPDATE TICKETSALESITEM " & _
                  "SET TICKETSALESITEM.CUSTCODEITEM = '" & txtCustomerItemCode.Text & "' " & _
                  "WHERE TICKETSALESITEM.CONTRACTPRICELISTID = " & sContractPriceListID & " "

            bdconnSQL.ExecuteNonSQL(sql)

        End If

        bdconnSQL.CloseConnection()
        bdconnSQL.Dispose()
        bdconnSQL = Nothing
        ds.Dispose()
        ds = Nothing

        Dim syn As New clsSyncBaseData
        syn.UpdateVersionBaseSQL("CONTRACTPRICELIST")
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

    Private Sub txtSalesPrice_TextChanged(sender As Object, e As EventArgs) Handles txtSalesPrice.TextChanged
        util.TextBoxMoeda(txtSalesPrice, nQdeDecimal, True)
    End Sub

    Private Sub frmContractPriceEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbxInventoryClass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxInventoryClass.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxInventoryClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxInventoryClass.SelectedIndexChanged
        If cbxInventoryClass.Text <> "" Then
            getInventoryClassType(cbxInventoryClass.SelectedValue)
        End If

    End Sub

    Private Sub getInventoryClassType(sInventoryClassId As String)

        Dim bdconnSQL As New clsBancoDadosSQL
        bdconnSQL.OpenConnection()

        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT [TYPE] FROM INVENTORYCLASS " & _
              "WHERE INVENTORYCLASSID = '" & sInventoryClassId & "'"

        bdconnSQL.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                txtInventoryClassType.Text = ds.Tables(0).Rows(i)("TYPE").ToString
            Next
        Else
            txtInventoryClassType.Text = ""
        End If

        ds.Dispose()
        bdconnSQL.CloseConnection()
        bdconnSQL.Dispose()

    End Sub

    Private Sub cbxShowCustCodeRpt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxShowCustCodeRpt.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxExibitonReport_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxExibitonReport.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxHeaderGroup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxHeaderGroup.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxActive_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxActive.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxActive_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxActive.SelectedIndexChanged

    End Sub

    Private Sub txtGroupOrder_TextChanged(sender As Object, e As EventArgs) Handles txtGroupOrder.TextChanged
        util.TextBoxMoeda(txtGroupOrder)
    End Sub

    Private Sub txtPriceBase_TextChanged(sender As Object, e As EventArgs) Handles txtPriceBase.TextChanged
        util.TextBoxMoeda(txtPriceBase, 2, True)
    End Sub

    Private Sub txtPriceUtility_TextChanged(sender As Object, e As EventArgs) Handles txtPriceUtility.TextChanged
        util.TextBoxMoeda(txtPriceUtility, 2, True)
    End Sub
    Private Function IsNumber(ByVal e As System.Windows.Forms.KeyPressEventArgs, Optional PermitNegative As Boolean = True) As Boolean
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            If PermitNegative = True And e.KeyChar = "-" Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function

    Private Sub txtContractedQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContractedQuantity.KeyPress
        If IsNumber(e, False) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSalesPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSalesPrice.KeyPress

        Dim bPermNeg As Boolean
        If cbxPermNegative.Text = "YES" Then bPermNeg = True Else bPermNeg = False

        If IsNumber(e, bPermNeg) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPriceUtility_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceUtility.KeyPress

        Dim bPermNeg As Boolean
        If cbxPermNegative.Text = "YES" Then bPermNeg = True Else bPermNeg = False

        If IsNumber(e, bPermNeg) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtPriceBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceBase.KeyPress

        Dim bPermNeg As Boolean
        If cbxPermNegative.Text = "YES" Then bPermNeg = True Else bPermNeg = False

        If IsNumber(e, bPermNeg) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub cbxPermNegative_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPermNegative.SelectedIndexChanged
        If cbxPermNegative.Text = "NO" Then
            If txtSalesPrice.Text.Contains("-") Then
                txtSalesPrice.Text = txtSalesPrice.Text.Replace("-", "").Replace(" ", "")
            End If
            If txtPriceBase.Text.Contains("-") Then
                txtPriceBase.Text = txtPriceBase.Text.Replace("-", "").Replace(" ", "")
            End If
            If txtPriceUtility.Text.Contains("-") Then
                txtPriceUtility.Text = txtPriceUtility.Text.Replace("-", "").Replace(" ", "")
            End If
        End If
    End Sub

    Private Sub txtGroupOrder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGroupOrder.KeyPress
        If IsNumber(e, False) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub IncreaseDecimalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncreaseDecimalToolStripMenuItem.Click
        If nQdeDecimal < 5 Then
            nQdeDecimal = nQdeDecimal + 1
            txtSalesPrice.Text = txtSalesPrice.Text & "0"
        End If
    End Sub

    Private Sub DecreaseDecimalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DecreaseDecimalToolStripMenuItem.Click
        If nQdeDecimal <> 2 Then
            nQdeDecimal = nQdeDecimal - 1
            txtSalesPrice.Text = Strings.Left(txtSalesPrice.Text, txtSalesPrice.Text.Length - 1)
        End If
    End Sub
End Class