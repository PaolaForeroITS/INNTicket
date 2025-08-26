
Public Class frmSalesItemL01

    Dim util As New clsUtils

    Public sTicketID As String
    Public sContractId As String
    Public sUsername As String
    Public bTicketReadOnly As Boolean

    Dim sCurrency As String = ""
    Dim sLayout As String = ""
    Dim sPortionUSD As String = ""
    Dim sPortionCOP As String = ""

    Dim sEnableDisc As String = ""

    Private Sub frmSalesItemL01_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            LoadContrPriceTmp()
            TicketEnable()
            GetParameters()
            ReloadSalesItem()
            ReloadTotals(True)
            LayoutGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TicketEnable()
        If bTicketReadOnly = True Then
            txtExchangeRate.Enabled = False
            txtSalesItemDisc.ReadOnly = True
            btnNewSalesItem.Enabled = False
            btnApplyDisc.Enabled = False
            btnNewInvItem.Enabled = False
        End If

    End Sub

    Private Sub GetParameters()
        Try
            Dim sql As String
            Dim ds As New DataSet
            Dim bdconn As New clsBancoDadosACCESS

            bdconn.OpenConnection()

            sql = "SELECT LAYOUTTYPE, CURRENCY, PORTIONUSD, PORTIONCOP, EXCHANGERATE, ENABLEEXCHANGERATE, ENABLEDISCOUNT " & _
                  "FROM CONTRACT " & _
                  "WHERE CONTRACTID = " & sContractId & " "

            bdconn.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    sLayout = util.TrataDBNull(ds.Tables(0).Rows(i)("LAYOUTTYPE").ToString)
                    sCurrency = util.TrataDBNull(ds.Tables(0).Rows(i)("CURRENCY"))
                    sPortionUSD = util.TrataDBNull(ds.Tables(0).Rows(i)("PORTIONUSD").ToString)
                    sPortionCOP = util.TrataDBNull(ds.Tables(0).Rows(i)("PORTIONCOP").ToString)

                    If CDbl(txtExchangeRate.Text) = 0 Then
                        txtExchangeRate.Text = util.ConcatDecimalStr(util.TrataDBNull(util.TrataDBNull(ds.Tables(0).Rows(i)("EXCHANGERATE").ToString())))
                    End If

                    If ds.Tables(0).Rows(i)("ENABLEEXCHANGERATE").ToString = "NO" Then
                        txtExchangeRate.Enabled = False
                    End If
                    If ds.Tables(0).Rows(i)("ENABLEDISCOUNT").ToString = "NO" Then
                        txtSalesItemDisc.Enabled = False
                        btnApplyDisc.Enabled = False
                    End If
                    sEnableDisc = ds.Tables(0).Rows(i)("ENABLEDISCOUNT").ToString
                Next
            End If

            bdconn.CloseConnection()
            bdconn.Dispose()
            ds.Dispose()
            bdconn = Nothing
            ds = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub LayoutGrid()

        If sLayout = "L01" Then
            With dgvSalesItem
                .Columns("colPriceUnitUSD").Visible = True
                .Columns("colItemAmountUSD").Visible = True
                .Columns("colItemAmountUSD").HeaderText = "Total" + Environment.NewLine + "(USD)"
                .Columns("colPortionValueUSD").Visible = True
                .Columns("colPortionValueCOP").Visible = True
                .Columns("colPortionValueUSD").HeaderText = "Portion USD " & Environment.NewLine & "        " & sPortionUSD & "%"
                .Columns("colPortionValueCOP").HeaderText = "Portion COP " & Environment.NewLine & "        " & sPortionCOP & "%"
            End With

            txtSalesItemDisc.Enabled = False
            btnApplyDisc.Enabled = False

            dgvSalesItemTotalL01.Visible = True
            tabL02.Visible = False

        ElseIf sLayout = "L02" Then

            If sCurrency = "USD" Then
                With dgvSalesItem
                    .Columns("colItemAmountUSD").HeaderText = "Total" + Environment.NewLine + "(USD)"
                    .Columns("colSIDescription").Width = 440
                    .Columns("colPriceUnitUSD").Visible = True
                    .Columns("colItemAmountNoDiscUSD").Visible = True
                    .Columns("colItemAmountUSD").Visible = True
                End With

                With dgvSalesItemTotalL02Mat
                    .Columns("colAmountUSD").Visible = True
                    .Columns("colAmountCOP").Visible = False
                End With

                With dgvSalesItemTotalL02Serv
                    .Columns("colAmountUSD2").Visible = True
                    .Columns("colAmountCOP2").Visible = False
                End With
            Else
                With dgvSalesItem
                    .Columns("colItemAmount").HeaderText = "Total" + Environment.NewLine + "(COP)"
                    .Columns("colSIDescription").Width = 440
                    .Columns("colPriceUnit").Visible = True
                    .Columns("colItemAmountNoDisc").Visible = True
                    .Columns("colItemAmount").Visible = True
                End With

                With dgvSalesItemTotalL02Mat
                    .Columns("colAmountUSD").Visible = False
                    .Columns("colAmountCOP").Visible = True
                End With

                With dgvSalesItemTotalL02Serv
                    .Columns("colAmountUSD2").Visible = False
                    .Columns("colAmountCOP2").Visible = True
                End With
            End If

            'txtSalesItemDisc.Enabled = True
            'btnApplyDisc.Enabled = True

            dgvSalesItemTotalL01.Visible = False
            tabL02.Visible = True

        End If

    End Sub
    Private Sub ForeColorGridTotals()

        For l As Integer = 0 To Me.dgvSalesItemTotalL02Serv.RowCount - 1
            If Me.dgvSalesItemTotalL02Serv.Rows(l).Cells("colAmountCOP2").Value < 0 Then
                Me.dgvSalesItemTotalL02Serv.Rows(l).Cells("colAmountCOP2").Style.ForeColor = Color.FromArgb(192, 0, 0)
            End If
            If Me.dgvSalesItemTotalL02Serv.Rows(l).Cells("colAmountUSD2").Value < 0 Then
                Me.dgvSalesItemTotalL02Serv.Rows(l).Cells("colAmountUSD2").Style.ForeColor = Color.FromArgb(192, 0, 0)
            End If
        Next

        For l As Integer = 0 To Me.dgvSalesItemTotalL02Mat.RowCount - 1
            If Me.dgvSalesItemTotalL02Mat.Rows(l).Cells("colAmountCOP").Value < 0 Then
                Me.dgvSalesItemTotalL02Mat.Rows(l).Cells("colAmountCOP").Style.ForeColor = Color.FromArgb(192, 0, 0)
            End If
            If Me.dgvSalesItemTotalL02Mat.Rows(l).Cells("colAmountUSD").Value < 0 Then
                Me.dgvSalesItemTotalL02Mat.Rows(l).Cells("colAmountUSD").Style.ForeColor = Color.FromArgb(192, 0, 0)
            End If
        Next

        For l As Integer = 0 To Me.dgvSalesItemTotalL01.RowCount - 1
            If Me.dgvSalesItemTotalL01.Rows(l).Cells("colAmountUSD3").Value < 0 Then
                Me.dgvSalesItemTotalL01.Rows(l).Cells("colAmountUSD3").Style.ForeColor = Color.FromArgb(192, 0, 0)
            End If
            If Me.dgvSalesItemTotalL01.Rows(l).Cells("colPortionValueUSD3").Value < 0 Then
                Me.dgvSalesItemTotalL01.Rows(l).Cells("colPortionValueUSD3").Style.ForeColor = Color.FromArgb(192, 0, 0)
            End If
            If Me.dgvSalesItemTotalL01.Rows(l).Cells("colPortionValueCOP3").Value < 0 Then
                Me.dgvSalesItemTotalL01.Rows(l).Cells("colPortionValueCOP3").Style.ForeColor = Color.FromArgb(192, 0, 0)
            End If
        Next

    End Sub


    Private Sub ForeColorGridSalesItem()
        For l As Integer = 0 To Me.dgvSalesItem.RowCount - 1
            If dgvSalesItem.Rows(l).Cells("colType").Value = "Material" Then
                With dgvSalesItem.Rows(l)
                    .DefaultCellStyle.ForeColor = Color.DarkGreen
                End With
            ElseIf dgvSalesItem.Rows(l).Cells("colType").Value = "Service" Then
                With dgvSalesItem.Rows(l)
                    .DefaultCellStyle.ForeColor = Color.Blue
                End With
            End If

            If Me.dgvSalesItem.Rows(l).Cells("colPriceUnit").Value < 0 Then
                Me.dgvSalesItem.Rows(l).Cells("colPriceUnit").Style.ForeColor = Color.FromArgb(192, 0, 0)
            Else
                Me.dgvSalesItem.Rows(l).Cells("colPriceUnit").Style.ForeColor = Color.Black
            End If

            If Me.dgvSalesItem.Rows(l).Cells("colPriceUnitUSD").Value < 0 Then
                Me.dgvSalesItem.Rows(l).Cells("colPriceUnitUSD").Style.ForeColor = Color.FromArgb(192, 0, 0)
            Else
                Me.dgvSalesItem.Rows(l).Cells("colPriceUnitUSD").Style.ForeColor = Color.Black
            End If

            If Me.dgvSalesItem.Rows(l).Cells("colItemAmountNoDisc").Value < 0 Then
                Me.dgvSalesItem.Rows(l).Cells("colItemAmountNoDisc").Style.ForeColor = Color.FromArgb(192, 0, 0)
            Else
                Me.dgvSalesItem.Rows(l).Cells("colItemAmountNoDisc").Style.ForeColor = Color.Black
            End If

            If Me.dgvSalesItem.Rows(l).Cells("colItemAmountNoDiscUSD").Value < 0 Then
                Me.dgvSalesItem.Rows(l).Cells("colItemAmountNoDiscUSD").Style.ForeColor = Color.FromArgb(192, 0, 0)
            Else
                Me.dgvSalesItem.Rows(l).Cells("colItemAmountNoDiscUSD").Style.ForeColor = Color.Black
            End If

            If Me.dgvSalesItem.Rows(l).Cells("colItemAmountUSD").Value < 0 Then
                Me.dgvSalesItem.Rows(l).Cells("colItemAmountUSD").Style.ForeColor = Color.FromArgb(192, 0, 0)
            Else
                Me.dgvSalesItem.Rows(l).Cells("colItemAmountUSD").Style.ForeColor = Color.Black
            End If

            If Me.dgvSalesItem.Rows(l).Cells("colItemAmount").Value < 0 Then
                Me.dgvSalesItem.Rows(l).Cells("colItemAmount").Style.ForeColor = Color.FromArgb(192, 0, 0)
            Else
                Me.dgvSalesItem.Rows(l).Cells("colItemAmount").Style.ForeColor = Color.Black
            End If

            If Me.dgvSalesItem.Rows(l).Cells("colPortionValueUSD").Value < 0 Then
                Me.dgvSalesItem.Rows(l).Cells("colPortionValueUSD").Style.ForeColor = Color.FromArgb(192, 0, 0)
            Else
                Me.dgvSalesItem.Rows(l).Cells("colPortionValueUSD").Style.ForeColor = Color.Black
            End If

            If Me.dgvSalesItem.Rows(l).Cells("colSIItemQty").Value < 0 Then
                Me.dgvSalesItem.Rows(l).Cells("colSIItemQty").Style.ForeColor = Color.FromArgb(192, 0, 0)
            Else
                Me.dgvSalesItem.Rows(l).Cells("colSIItemQty").Style.ForeColor = Color.Black
            End If

            If Me.dgvSalesItem.Rows(l).Cells("colSIItemDisc").Value < 0 Then
                Me.dgvSalesItem.Rows(l).Cells("colSIItemDisc").Style.ForeColor = Color.FromArgb(192, 0, 0)
            Else
                Me.dgvSalesItem.Rows(l).Cells("colSIItemDisc").Style.ForeColor = Color.Black
            End If

        Next

    End Sub

    Private Sub txtExchangeRate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtExchangeRate.KeyDown
        If e.KeyCode = Keys.Enter Then
            SalesItemExchangeRate()
        End If
    End Sub

    Private Sub txtExchangeRate_LostFocus(sender As Object, e As EventArgs) Handles txtExchangeRate.LostFocus
        SalesItemExchangeRate()
    End Sub

    Private Sub txtExchangeRate_TextChanged(sender As Object, e As EventArgs) Handles txtExchangeRate.TextChanged
        util.TextBoxMoeda(txtExchangeRate)
    End Sub

    Private Sub txtSalesItemDisc_TextChanged(sender As Object, e As EventArgs) Handles txtSalesItemDisc.TextChanged
        util.TextBoxMoeda(txtSalesItemDisc)
    End Sub

#Region "SalesItem"

    Private Sub btnApplyDisc_Click(sender As Object, e As EventArgs) Handles btnApplyDisc.Click
        If txtSalesItemDisc.Text = "" Then
            MsgBox("Inform the Discount Value", vbInformation)
            Exit Sub
        End If
        If MsgBox("Do you have apply the discount for all lines?", vbYesNo) = vbYes Then
            Me.Cursor = Cursors.WaitCursor
            SalesItemRecalcDesc()
            Me.Cursor = Cursors.Arrow
        End If

    End Sub

    Private Sub dgvSalesItemChangeLine()

        If dgvSalesItem.RowCount > 0 Then
            If IsNothing(util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSIDescription").Value)) = False Then
                txtDescription.Text = dgvSalesItem.CurrentRow.Cells("colSIDescription").Value.ToString
                txtUnitSale.Text = dgvSalesItem.CurrentRow.Cells("colSIUnitSale").Value.ToString
            Else
                txtDescription.Text = ""
                txtUnitSale.Text = ""
            End If
        Else
            txtDescription.Text = ""
            txtUnitSale.Text = ""
        End If

        ReloadSalesItemInventory()
    End Sub

    Private Sub ReloadTotals(Optional ByVal bGetNewData As Boolean = False)
        Try
            If bGetNewData = True Then
                Dim cls As New clsSalesItemTotal
                cls.UpdateTotal(sTicketID, sLayout)
                cls.Dispose()
                cls = Nothing
            End If

            Me.SALESITEM_TOTAL_L01TableAdapter.Fill(Me.SESTicketAccessDataSet.SALESITEM_TOTAL_L01)
            Me.SALESITEM_TOTAL_L02_SERVTableAdapter.Fill(Me.SESTicketAccessDataSet.SALESITEM_TOTAL_L02_SERV)
            Me.SALESITEM_TOTAL_L02_MATTableAdapter.Fill(Me.SESTicketAccessDataSet.SALESITEM_TOTAL_L02_MAT)
            SALESITEM_TOTAL_L01BindingSource.Filter = "TICKETID='" & sTicketID & "' "
            dgvSalesItemTotalL01.Refresh()
            SALESITEMTOTALL02MATBindingSource.Filter = "TICKETID='" & sTicketID & "' "
            dgvSalesItemTotalL01.Refresh()
            SALESITEMTOTALL02SERVBindingSource.Filter = "TICKETID='" & sTicketID & "' "
            dgvSalesItemTotalL01.Refresh()

            ForeColorGridTotals()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ReloadSalesItem()

        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETSALESITEM' table. You can move, or remove it, as needed.
        Me.SALESITEM_VTableAdapter.Fill(Me.SESTicketAccessDataSet.SALESITEM_V)

        SALESITEMVBindingSource.Filter = "TICKETID='" & sTicketID & "' "
        dgvSalesItem.Refresh()

        If dgvSalesItem.RowCount > 0 Then
            ReloadTotals()
            ReloadSalesItemInventory()
        End If

    End Sub

    Private Sub SalesItemExchangeRate()

        Dim nExchangeRate As Double = CDbl(txtExchangeRate.Text)

        If nExchangeRate <= 0 Then
            MsgBox("The Exchange Rate must be greater than zero", vbExclamation)
            txtExchangeRate.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim sql As String
        Dim ds As New DataSet
        Dim bdconnAccess As New clsBancoDadosACCESS

        bdconnAccess.OpenConnection()

        sql = "UPDATE [TICKET] SET " &
             "[EXCHANGERATE] = " & util.SQLConvStrNull(nExchangeRate, "n") & " " &
             " WHERE " &
             "[TICKETID] = '" & sTicketID & "'"

        bdconnAccess.ExecuteNonSQL(sql)

        sql = "SELECT " & _
            "TICKETSALESITEMID " & _
            ",ITEMQTY " & _
            ",PRICEUNIT " & _
            ",ITEMAMOUNT " & _
            ",PRICEUNITUSD " & _
            ",ITEMAMOUNTUSD " & _
            "from TICKETSALESITEM " & _
            "WHERE " & _
            "TICKETID = '" & sTicketID & "' "

        bdconnAccess.ExecuteSQL(sql, ds)

        Dim nQty As Double = 0
        Dim nPriceUnit As Double = 0
        Dim nItemAmountNoDisc As Double = 0
        Dim nItemAmount As Double = 0
        Dim nDiscValue As Double = 0

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                If sCurrency = "COP" Then
                    nQty = ds.Tables(0).Rows(i)("ITEMQTY")
                    nPriceUnit = Math.Round((ds.Tables(0).Rows(i)("PRICEUNIT") / nExchangeRate), 5)
                    nItemAmountNoDisc = Math.Round((nPriceUnit * nQty), 4)
                    nItemAmount = (ds.Tables(0).Rows(i)("ITEMAMOUNT") / nExchangeRate)
                    nDiscValue = Math.Round((nItemAmountNoDisc - nItemAmount), 4)

                    sql = "UPDATE TICKETSALESITEM SET " &
                          "PRICEUNITUSD         = " & util.SQLConvStrNull(nPriceUnit, "n") & " " &
                          ",ITEMAMOUNTNODISCUSD = " & util.SQLConvStrNull(nItemAmountNoDisc, "n") & " " &
                          ",ITEMAMOUNTUSD       = " & util.SQLConvStrNull(nItemAmount, "n") & " " &
                          ",DISCVALUEUSD        = " & util.SQLConvStrNull(nDiscValue, "n") & " " &
                          "WHERE " &
                          "TICKETSALESITEMID = '" & ds.Tables(0).Rows(i)("TICKETSALESITEMID").ToString & "' "
                Else
                    nQty = ds.Tables(0).Rows(i)("ITEMQTY")
                    nPriceUnit = Math.Round((ds.Tables(0).Rows(i)("PRICEUNITUSD") * nExchangeRate), 5)
                    nItemAmountNoDisc = Math.Round((nPriceUnit * nQty), 4)
                    nItemAmount = (ds.Tables(0).Rows(i)("ITEMAMOUNTUSD") * nExchangeRate)
                    nDiscValue = Math.Round((nItemAmountNoDisc - nItemAmount), 4)

                    sql = "UPDATE TICKETSALESITEM SET " &
                          "PRICEUNIT         = " & util.SQLConvStrNull(nPriceUnit, "n") & " " &
                          ",ITEMAMOUNTNODISC = " & util.SQLConvStrNull(nItemAmountNoDisc, "n") & " " &
                          ",ITEMAMOUNT       = " & util.SQLConvStrNull(nItemAmount, "n") & " " &
                          ",DISCVALUE        = " & util.SQLConvStrNull(nDiscValue, "n") & " " &
                          "WHERE " &
                          "TICKETSALESITEMID = '" & ds.Tables(0).Rows(i)("TICKETSALESITEMID").ToString & "' "
                End If

                bdconnAccess.ExecuteNonSQL(sql)

            Next
        End If

        ds.Dispose()
        ds = Nothing
        bdconnAccess.CloseConnection()
        bdconnAccess.Dispose()
        bdconnAccess = Nothing


        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketID, "ACCESS")
        sync.Dispose()
        sync = Nothing

        ReloadSalesItem()
        ReloadTotals(True)

        Me.Cursor = Cursors.Arrow


    End Sub

    Private Sub SalesItemRecalcDesc()

        'Fazer
        Dim nDiscount As Double = CDbl(txtSalesItemDisc.Text)
        Dim nExchangeRate As Double = CDbl(txtExchangeRate.Text)

        Dim sql As String
        Dim ds As New DataSet
        Dim bdconnAccess As New clsBancoDadosACCESS

        bdconnAccess.OpenConnection()

        Dim sTicketSalesItemId As String
        Dim nItemAmountNoDisc As Double
        Dim nItemAmountNoDiscUSD As Double

        Dim nDiscValue As Double
        Dim nDiscValueUSD As Double

        Dim nItemAmount As Double
        Dim nItemAmountUSD As Double


        sql = "SELECT " & _
            " TICKETSALESITEMID " & _
            ",ITEMAMOUNTNODISC  " & _
            ",ITEMAMOUNTNODISCUSD " & _
            "FROM TICKETSALESITEM " & _
            "WHERE " & _
            "TICKETID = '" & sTicketID & "' "

        bdconnAccess.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                sTicketSalesItemId = ds.Tables(0).Rows(i)("TICKETSALESITEMID").ToString

                If sCurrency = "USD" Then
                    nItemAmountNoDiscUSD = ds.Tables(0).Rows(i)("ITEMAMOUNTNODISCUSD")
                    nItemAmountUSD = (nItemAmountNoDiscUSD) - Math.Round(((nItemAmountNoDiscUSD) * (nDiscount / 100)), 4)
                    nDiscValueUSD = nItemAmountNoDiscUSD - nItemAmountUSD

                    nItemAmountNoDisc = ds.Tables(0).Rows(i)("ITEMAMOUNTNODISC")
                    nItemAmount = Math.Round(nItemAmountUSD * nExchangeRate, 4)
                    nDiscValue = nItemAmountNoDisc - nItemAmount

                Else
                    nItemAmountNoDisc = ds.Tables(0).Rows(i)("ITEMAMOUNTNODISC")
                    nItemAmount = (nItemAmountNoDiscUSD) - Math.Round(((nItemAmountNoDisc) * (nDiscount / 100)), 4)
                    nDiscValue = nItemAmountNoDisc - nItemAmount

                    nItemAmountNoDiscUSD = ds.Tables(0).Rows(i)("ITEMAMOUNTNODISCUSD")
                    nItemAmountUSD = Math.Round(nItemAmount / nExchangeRate, 4)
                    nDiscValueUSD = nItemAmountNoDiscUSD - nItemAmountUSD

                End If

                sql = "UPDATE TICKETSALESITEM SET " &
                      "ITEMDISC        = " & util.SQLConvStrNull(nDiscount, "n") & " " &
                      ",ITEMAMOUNT     = " & util.SQLConvStrNull(nItemAmount, "n") & " " &
                      ",ITEMAMOUNTUSD  = " & util.SQLConvStrNull(nItemAmountUSD, "n") & " " &
                      ",DISCVALUE      = " & util.SQLConvStrNull(nDiscValue, "n") & " " &
                      ",DISCVALUEUSD   = " & util.SQLConvStrNull(nDiscValueUSD, "n") & " " &
                      ",DISCTYPE       = 'PCT' " &
                      "WHERE " &
                      "TICKETSALESITEMID = '" & sTicketSalesItemId & "' "

                bdconnAccess.ExecuteNonSQL(sql)

            Next
        End If

        ds.Dispose()
        bdconnAccess.CloseConnection()
        bdconnAccess.Dispose()
        bdconnAccess = Nothing

        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketID, "ACCESS")
        sync.Dispose()
        sync = Nothing

        ReloadSalesItem()
        ReloadTotals(True)

        MsgBox("Discount Applied", vbInformation)

    End Sub

    Private Sub btnNewSalesItem_Click(sender As Object, e As EventArgs) Handles btnNewSalesItem.Click
        If CDbl(txtExchangeRate.Text) <= 0 Then
            MsgBox("The Exchange Rate must be greater than zero", vbExclamation)
            txtExchangeRate.Focus()
            Exit Sub
        End If

        Dim nExchangeTaxRate As Double = CDbl(txtExchangeRate.Text)

        Dim frm As New frmTicketSalesItemEdit
        With frm
            .sTicketId = sTicketID
            .sContractId = sContractId
            .sCurrency = sCurrency
            .sUsername = sUsername
            .nExchangeTaxRate = nExchangeTaxRate
            .txtDiscount.Enabled = txtSalesItemDisc.Enabled
            .txtDiscountValue.Enabled = txtSalesItemDisc.Enabled
            .chkDiscType.Enabled = txtSalesItemDisc.Enabled
            .sEnableDisc = Me.sEnableDisc
            .sLayout = Me.sLayout
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing

        ReloadSalesItem()
        ReloadTotals()

    End Sub

    Private Sub dgvSalesItem_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesItem.CellDoubleClick
        If bTicketReadOnly = False And dgvSalesItem.RowCount > 0 Then

            Dim nExchangeTaxRate As Double = CDbl(txtExchangeRate.Text)

            Dim frm As New frmTicketSalesItemEdit
            With frm
                .sTicketId = sTicketID
                .sContractId = sContractId
                .sCurrency = sCurrency
                .sUsername = Me.sUsername
                .btnSearch.Enabled = False
                .txtDescription.Enabled = False
                .txtDiscount.Enabled = txtSalesItemDisc.Enabled
                .txtDiscountValue.Enabled = txtSalesItemDisc.Enabled
                .chkDiscType.Enabled = txtSalesItemDisc.Enabled
                .txtTabGroup.Text = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colTabGroup").Value)
                .sTicketSalesItemID = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSITicketSalesItemId").Value)
                .sContractPriceList = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSIContractPriceListId").Value)
                .txtItem.Text = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSICustCodeItem").Value)
                .txtDescription.Text = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSIDescription").Value)
                .txtUnit.Text = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSIUnitSale").Value)

                .sDiscType = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colDiscType").Value)
                .sSalesPrice = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSISalesPrice").Value)
                .nPriceUnit = util.TrataDBNull(SalesItemPriceUnit())
                .nQde = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSIItemQty").Value)
                .nTotalNoDisc = util.TrataDBNull(SalesItemTotalNoDisc())
                .nDiscPct = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSIItemDisc").Value.ToString)
                .nDiscValue = util.TrataDBNull(SalesItemDiscValue())
                .nTotal = util.TrataDBNull(SalesItemTotal())

                .sEnableDisc = Me.sEnableDisc
                .nExchangeTaxRate = nExchangeTaxRate
                .sLayout = Me.sLayout
                .ShowDialog()
                .Dispose()
            End With
            frm = Nothing

            ReloadSalesItem()
            ReloadTotals()

        End If
    End Sub

    Private Function SalesItemPriceUnit() As Double
        If dgvSalesItem.RowCount > 0 Then
            If sCurrency = "COP" Then
                Return util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colPriceUnit").Value)
                Exit Function
            Else
                Return util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colPriceUnitUSD").Value)
                Exit Function
            End If
        End If
        Return Nothing
    End Function

    Private Function SalesItemTotalNoDisc() As Double
        If dgvSalesItem.RowCount > 0 Then
            If sCurrency = "COP" Then
                Return util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colItemAmountNoDisc").Value)
                Exit Function
            Else
                Return util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colItemAmountNoDiscUSD").Value)
                Exit Function
            End If
        End If
        Return Nothing
    End Function

    Private Function SalesItemDiscValue() As Double
        If dgvSalesItem.RowCount > 0 Then
            If sCurrency = "COP" Then
                Return util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colItemDiscValue").Value)
                Exit Function
            Else
                Return util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colItemDiscValueUSD").Value)
                Exit Function
            End If
        End If
        Return Nothing
    End Function

    Private Function SalesItemTotal() As Double
        If dgvSalesItem.RowCount > 0 Then
            If sCurrency = "COP" Then
                Return util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colItemAmount").Value)
                Exit Function
            Else
                Return util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colItemAmountUSD").Value)
                Exit Function
            End If
        End If
        Return Nothing
    End Function

    Private Sub dgvSalesItem_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSalesItem.CellFormatting
        If e.RowIndex >= 0 Then
            ForeColorGridSalesItem()
        End If
    End Sub

    Private Sub dgvSalesItem_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSalesItem.SelectionChanged
        dgvSalesItemChangeLine()
    End Sub

#End Region

#Region "InventoryItem"

    Private Sub ReloadSalesItemInventory()
        If dgvSalesItem.RowCount > 0 Then
            If IsNothing(util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSITicketSalesItemId").Value)) = False Then

                Try
                    'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETINVLINESALES_V' table. You can move, or remove it, as needed.
                    Me.TICKETINVLINESALES_VTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETINVLINESALES_V)

                    TICKETINVLINESALESVBindingSource.Filter = "TICKETSALESITEMID='" & util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSITicketSalesItemId").Value) & "' "
                    dgvInventory.Refresh()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        End If
    End Sub

    Private Sub btnNewInvItem_Click(sender As Object, e As EventArgs) Handles btnNewInvItem.Click
        If dgvSalesItem.RowCount > 0 Then

            Dim frm As New frmTicketInvItemLineEdit

            With frm
                .sFormName = "frmSalesItemL01"
                .sUsername = Me.sUsername
                .sTicketId = Me.sTicketID
                .bTicketReadOnly = Me.bTicketReadOnly
                .sTicketSalesItemId = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSITicketSalesItemId").Value)
                .txtCustCodeItem.Text = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSICustCodeItem").Value)
                .txtSalesItemDescrip.Text = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSIDescription").Value)
                .btnSearchSalesItem.Visible = False
            End With

            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing

            ReloadSalesItemInventory()

        Else
            MsgBox("Select the Sales Item", vbExclamation)
            Exit Sub
        End If
    End Sub

    Private Sub dgvInventory_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellDoubleClick
        If bTicketReadOnly = False Then

            Dim frm As New frmTicketInvItemLineEdit

            With frm
                .sFormName = "frmSalesItemL01"
                .sUsername = Me.sUsername
                .sTicketId = Me.sTicketID
                .bTicketReadOnly = Me.bTicketReadOnly
                .sTicketSalesItemId = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSITicketSalesItemId").Value)
                .sInventoryItemId = util.TrataDBNull(dgvInventory.CurrentRow.Cells("colIInventoryItem").Value)
                .txtCustCodeItem.Text = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSICustCodeItem").Value)
                .txtSalesItemDescrip.Text = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSIDescription").Value)
                .sTicketInvLineId = util.TrataDBNull(dgvInventory.CurrentRow.Cells("colTicketInvLineId").Value)
                .txtInvItemId.Text = util.TrataDBNull(dgvInventory.CurrentRow.Cells("colIInventoryItem").Value)
                .txtDescrip.Text = util.TrataDBNull(dgvInventory.CurrentRow.Cells("colIDescription").Value)
                .txtUnit.Text = util.TrataDBNull(dgvInventory.CurrentRow.Cells("colIUnit").Value)
                .txtQuantity.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvInventory.CurrentRow.Cells("colIItemQty").Value))
                .btnSearchInvItem.Visible = False
                .btnSearchSalesItem.Visible = False
            End With

            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing

            ReloadSalesItemInventory()
        End If

    End Sub

#End Region

    Private Sub LoadContrPriceTmp()

        Dim sql As String
        Dim bdconn As New clsBancoDadosACCESS()

        bdconn.OpenConnection("BaseData")

        sql = "DELETE FROM CONTRACTPRICELISTTMP "
        bdconn.ExecuteNonSQL(sql)

        sql = "INSERT INTO CONTRACTPRICELISTTMP ( CONTRACTPRICELISTID, CONTRACTID, TYPE, TABGROUP, CUSTCODEITEM, " &
            "DESCRIPTION, SALES_PRICE, UNIT_SALE, INVENTORYCLASSID, CONTRACTED_QTY, ACTIVE, ISHEADER, EXIBITONREPORT, GROUPORDER, " &
            "PERMITUPDATEDESCRIP, PERMITUPDATEPRICEUNIT, PERMITNEGATIVE,PRICEUNITDECIMAL)  " &
            "SELECT CONTRACTPRICELIST_V.CONTRACTPRICELISTID, CONTRACTPRICELIST_V.CONTRACTID, CONTRACTPRICELIST_V.TYPE, " &
            "CONTRACTPRICELIST_V.TABGROUP, CONTRACTPRICELIST_V.CUSTCODEITEM, CONTRACTPRICELIST_V.DESCRIPTION, " &
            "CONTRACTPRICELIST_V.SALES_PRICE, CONTRACTPRICELIST_V.UNIT_SALE, CONTRACTPRICELIST_V.INVENTORYCLASSID, " &
            "CONTRACTPRICELIST_V.CONTRACTED_QTY, CONTRACTPRICELIST_V.ACTIVE, CONTRACTPRICELIST_V.ISHEADER, " &
            "CONTRACTPRICELIST_V.EXIBITONREPORT, CONTRACTPRICELIST_V.GROUPORDER, " &
            "CONTRACTPRICELIST_V.PERMITUPDATEDESCRIP ,CONTRACTPRICELIST_V.PERMITUPDATEPRICEUNIT ,CONTRACTPRICELIST_V.PERMITNEGATIVE,PRICEUNITDECIMAL " &
            "FROM CONTRACTPRICELIST_V " &
            "WHERE CONTRACTID=" & sContractId & " and ACTIVE = 'YES'"
        bdconn.ExecuteNonSQL(sql)

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

    End Sub

    Private Sub dgvSalesItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesItem.CellContentClick

    End Sub

    Private Sub dgvSalesItemTotalL01_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesItemTotalL01.CellContentClick

    End Sub
End Class