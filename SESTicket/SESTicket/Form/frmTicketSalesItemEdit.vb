
Public Class frmTicketSalesItemEdit


    Public sUsername As String
    Public sTicketId As String
    Public sContractId As String
    Public sTicketSalesItemID As String = ""
    Public sContractPriceList As String
    Public nExchangeTaxRate As Double
    Public sCurrency As String = ""
    Public sLayout As String = ""
    Public sEnableDisc As String = ""

    Public sDiscType As String = ""

    Dim bPermitCalc As Boolean = True

    Public sSalesPrice As Double = 0
    Public nPriceUnit As Double = 0
    Public nQde As Double = 0
    Public nTotalNoDisc As Double = 0

    Public nDiscPct As Double = 0
    Public nDiscValue As Double = 0
    Public nTotal As Double = 0


    Dim PermitNegative As Boolean = False

    Dim util As New clsUtils

    Public nPriceUnitDecimal As Integer = 2
    Public nSalesPriceDecimal As Integer = 2

#Region "Default Methods"


    Private Sub frmTicketSalesItemEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtCurrency.Text = sCurrency

        If sEnableDisc = "NO" Then
            txtDiscount.Enabled = False
            txtDiscountValue.Enabled = False
            chkDiscType.Enabled = False
        Else
            If sDiscType = "PCT" Or sDiscType = "" Then
                chkDiscType.Checked = True
                txtDiscount.Enabled = True
                txtDiscountValue.Enabled = False
            Else
                chkDiscType.Checked = False
                txtDiscount.Enabled = False
                txtDiscountValue.Enabled = True
            End If
        End If

        If sTicketSalesItemID = "" Then
            nPriceUnit = 0
            nQde = 0
            nTotalNoDisc = 0
            nDiscPct = 0
            nDiscValue = 0
            nTotal = 0

            btnCancelDelete.Text = "Cancel"
            txtPriceUnit.Enabled = False
            txtQuantity.Enabled = False
            txtDiscount.Enabled = False
            txtDiscountValue.Enabled = False

        Else
            btnCancelDelete.Text = "Delete"
        End If

        bPermitCalc = False

        nSalesPriceDecimal = util.GetNumberDecimal(sSalesPrice, 2)
        txtSalesPrice.Text = util.ConcatDecimalStr(sSalesPrice, nSalesPriceDecimal)

        nPriceUnitDecimal = util.GetNumberDecimal(nPriceUnit, 2)
        txtPriceUnit.Text = util.ConcatDecimalStr(nPriceUnit, nPriceUnitDecimal)
        txtQuantity.Text = util.ConcatDecimalStr(nQde, 4)
        txtTotalNoDisc.Text = util.ConcatDecimalStr(nTotalNoDisc)
        txtDiscount.Text = util.ConcatDecimalStr(nDiscPct)
        txtDiscountValue.Text = util.ConcatDecimalStr(nDiscValue)
        txtTotal.Text = util.ConcatDecimalStr(nTotal)
        bPermitCalc = True

        ContractPriceListGrants()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click


        Dim frm As New frmSearchSalesItem
        With frm
            .sContract = sContractId
            .ShowDialog()
        End With

        If frm.ContractPriceList <> "" Then

            sContractPriceList = frm.ContractPriceList
            txtItem.Text = frm.CustCodeItem
            txtDescription.Text = frm.Description

            nPriceUnitDecimal = util.GetNumberDecimal(frm.SalesPrice, 2)
            nSalesPriceDecimal = util.GetNumberDecimal(frm.SalesPrice, 2)

            txtSalesPrice.Text = util.ConcatDecimalStr(frm.SalesPrice, nPriceUnitDecimal)
            txtUnit.Text = frm.UnitSale
            txtTabGroup.Text = frm.TabGroup
            
            nPriceUnit = frm.SalesPrice
            nQde = 1
            nTotalNoDisc = 0
            nDiscPct = 0
            nDiscValue = 0
            nTotal = 0

            txtPriceUnit.Enabled = True
            txtQuantity.Enabled = True

            If sEnableDisc = "NO" Then
                txtDiscount.Enabled = False
                txtDiscountValue.Enabled = False
                chkDiscType.Enabled = False
            Else
                txtDiscount.Enabled = True
                txtDiscountValue.Enabled = False
                chkDiscType.Checked = True
            End If

            txtSalesPrice.Text = util.ConcatDecimalStr(nPriceUnit, nSalesPriceDecimal)
            txtPriceUnit.Text = util.ConcatDecimalStr(nPriceUnit, nPriceUnitDecimal)
            txtQuantity.Text = util.ConcatDecimalStr(nQde, 4)
            txtTotalNoDisc.Text = util.ConcatDecimalStr(nTotalNoDisc)
            txtDiscount.Text = util.ConcatDecimalStr(nDiscPct)
            txtDiscountValue.Text = util.ConcatDecimalStr(nDiscValue)
            txtTotal.Text = util.ConcatDecimalStr(nTotal)

            ContractPriceListGrants()

        End If
        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub txtSalesPrice_TextChanged(sender As Object, e As EventArgs) Handles txtSalesPrice.TextChanged
        util.TextBoxMoeda(txtSalesPrice, nSalesPriceDecimal, True)
    End Sub

    Private Sub txtPriceUnit_TextChanged(sender As Object, e As EventArgs) Handles txtPriceUnit.TextChanged
        util.TextBoxMoeda(txtPriceUnit, nPriceUnitDecimal, True)
        If bPermitCalc = True Then
            nPriceUnit = util.StrToNumber(txtPriceUnit.Text)
            CalcTotalNoDisc()

        End If
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        util.TextBoxMoeda(txtQuantity, 4, False)
        If bPermitCalc = True Then
            nQde = util.StrToNumber(txtQuantity.Text)
            CalcTotalNoDisc()
        End If
    End Sub

    Private Sub txtDiscount_TextChanged(sender As Object, e As EventArgs) Handles txtDiscount.TextChanged
        util.TextBoxMoeda(txtDiscount, 2, True)
        If bPermitCalc = True Then
            nDiscPct = util.StrToNumber(txtDiscount.Text)
            If chkDiscType.Checked = True Then
                CalcDiscValue()
            End If
        End If
    End Sub

    Private Sub txtDiscountValue_TextChanged(sender As Object, e As EventArgs) Handles txtDiscountValue.TextChanged
        util.TextBoxMoeda(txtDiscountValue, 2, True)
        If bPermitCalc = True Then
            nDiscValue = util.StrToNumber(txtDiscountValue.Text)
            If chkDiscType.Checked = False Then
                CalcDiscPct()
            End If
        End If
    End Sub

    Private Sub txtTotalNoDisc_TextChanged(sender As Object, e As EventArgs) Handles txtTotalNoDisc.TextChanged
        util.TextBoxMoeda(txtTotalNoDisc, 2, True)
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged
        util.TextBoxMoeda(txtTotal, 2, True)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtPriceUnit.Text = "" Then
            MsgBox("Inform Price Unit", vbExclamation)
            Exit Sub
        End If

        If txtQuantity.Text = "" Then
            MsgBox("Inform Quantity", vbExclamation)
            Exit Sub

        Else
            If CDbl(txtQuantity.Text.Replace(",", "").Replace(" ", "")) <= 0 Then
                MsgBox("The Quantitity must be increase of zero", vbExclamation)
                Exit Sub
            End If
        End If


        Me.Cursor = Cursors.WaitCursor

        Dim bdconnAccess As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconnAccess.OpenConnection()

        If sTicketSalesItemID = "" Then

            sql = "SELECT 1 FROM TICKETSALESITEM WHERE TICKETID='" & sTicketId & "' " & _
                  "AND CONTRACTPRICELISTID = " & sContractPriceList & " " & _
                  "AND CUSTCODEITEM = '" & txtItem.Text & "' "

            bdconnAccess.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Me.Cursor = Cursors.Arrow
                If MsgBox("The Sales is already in use. Continue?", vbYesNo) = vbNo Then
                    ds.Dispose()
                    ds = Nothing
                    bdconnAccess.CloseConnection()
                    bdconnAccess.Dispose()
                    bdconnAccess = Nothing
                    Exit Sub
                End If
            End If

            ds.Dispose()
            ds = Nothing

            Dim seq As New clsSequenceAccess(sTicketId)

            sql = "INSERT INTO [TICKETSALESITEM] " & _
            "(TICKETSALESITEMID, [TICKETID],[CONTRACTPRICELISTID],[CUSTCODEITEM],[DESCRIPTION] " & _
            ",[SALES_PRICE],[UNIT_SALE],[PRICEUNIT],[ITEMQTY],[ITEMDISC] " & _
            ",[ITEMAMOUNT],[CREATEDUSER],[CREATEDDATETIME],PRICEUNITUSD,ITEMAMOUNTUSD,ITEMAMOUNTNODISC," & _
            "ITEMAMOUNTNODISCUSD,DISCVALUE,DISCVALUEUSD,DISCTYPE) VALUES ('"

            sql = sql & seq.TicketSalesItemNextId & "','"
            sql = sql & sTicketId & "',"
            sql = sql & sContractPriceList & ",'"
            sql = sql & txtItem.Text & "',"
            sql = sql & util.SQLConvStrNull(txtDescription.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSalesPrice.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtUnit.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(CalcPriceUnitCOP(), "n") & ","
            sql = sql & util.SQLConvStrNull(txtQuantity.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtDiscount.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(CalcAmountCOP, "n") & ","
            sql = sql & util.SQLConvStrNull(sUsername, "s") & ","
            sql = sql & util.GetDateTime() & ","
            sql = sql & util.SQLConvStrNull(CalcPriceUnitUSD(), "n") & ","
            sql = sql & util.SQLConvStrNull(CalcAmountUSD(), "n") & ", "
            sql = sql & util.SQLConvStrNull(CalcAmountNoDiscCOP(), "n") & ","
            sql = sql & util.SQLConvStrNull(CalcAmountNoDiscUSD(), "n") & ","
            sql = sql & util.SQLConvStrNull(CalcDiscValueCOP(), "n") & ","
            sql = sql & util.SQLConvStrNull(CalcDiscValueUSD(), "n") & ","
            sql = sql & IIf(chkDiscType.Checked = True, "'PCT'", "'VLR'") & ")"

            bdconnAccess.ExecuteNonSQL(sql)

            seq.Dispose()
            seq = Nothing

        Else

            sql = "UPDATE [TICKETSALESITEM] SET " &
                " [PRICEUNIT] =  " & util.SQLConvStrNull(CalcPriceUnitCOP(), "n") & " " &
                ",[ITEMQTY] =   " & util.SQLConvStrNull(txtQuantity.Text, "n") & " " &
                ",[ITEMDISC] =  " & util.SQLConvStrNull(txtDiscount.Text, "n") & " " &
                ",[ITEMAMOUNT] =  " & util.SQLConvStrNull(CalcAmountCOP(), "n") & " " &
                ",[UPDATEDDATETIME] =  " & util.GetDateTime() & " " &
                ",[UPDATEDUSER] = " & util.SQLConvStrNull(sUsername, "s") & " " &
                ",[PRICEUNITUSD] =  " & util.SQLConvStrNull(CalcPriceUnitUSD(), "n") & " " &
                ",[ITEMAMOUNTUSD] =  " & util.SQLConvStrNull(CalcAmountUSD(), "n") & " " &
                ",ITEMAMOUNTNODISC     = " & util.SQLConvStrNull(CalcAmountNoDiscCOP(), "n") & " " &
                ",ITEMAMOUNTNODISCUSD  = " & util.SQLConvStrNull(CalcAmountNoDiscUSD(), "n") & " " &
                ",DISCVALUE            = " & util.SQLConvStrNull(CalcDiscValueCOP(), "n") & " " &
                ",DISCVALUEUSD         = " & util.SQLConvStrNull(CalcDiscValueUSD(), "n") & " " &
                ",DISCTYPE             = " & IIf(chkDiscType.Checked = True, "'PCT'", "'VLR'") & " " &
                "WHERE " &
                "[TICKETSALESITEMID] = '" & sTicketSalesItemID & "' "

            bdconnAccess.ExecuteNonSQL(sql)

        End If

        bdconnAccess.CloseConnection()
        bdconnAccess.Dispose()
        bdconnAccess = Nothing

        Dim cls As New clsSalesItemTotal
        cls.UpdateTotal(sTicketId, sLayout)
        cls.Dispose()
        cls = Nothing

        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketId, "ACCESS")
        sync.Dispose()
        sync = Nothing

        Me.Dispose()

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub btnCancelDelete_Click(sender As Object, e As EventArgs) Handles btnCancelDelete.Click

        If btnCancelDelete.Text = "Cancel" Then
            Me.Dispose()
        Else
            If MsgBox("Are you want DELETE this item? This action is Irreversivel", MsgBoxStyle.YesNo) = vbYes Then

                Me.Cursor = Cursors.WaitCursor

                Dim clsInv As New clsTicketInvItem
                clsInv.DeleteInvItemLineSales(sTicketId, sTicketSalesItemID)
                clsInv.Dispose()
                clsInv = Nothing

                Dim bdconnAccess As New clsBancoDadosACCESS
                Dim sql As String

                bdconnAccess.OpenConnection()

                sql = "DELETE FROM [TICKETINVENTORY] " & _
                "WHERE [TICKETSALESITEMID] = '" & sTicketSalesItemID & "' "
                bdconnAccess.ExecuteNonSQL(sql)

                sql = "DELETE FROM [TICKETSALESITEM] " & _
                "WHERE [TICKETSALESITEMID] = '" & sTicketSalesItemID & "' "
                bdconnAccess.ExecuteNonSQL(sql)

                bdconnAccess.CloseConnection()
                bdconnAccess.Dispose()
                bdconnAccess = Nothing

                Dim cls As New clsSalesItemTotal
                cls.UpdateTotal(sTicketId, sLayout)
                cls.Dispose()
                cls = Nothing

                Dim sync As New clsSyncTicket
                sync.UpdateSyncDateTime(sTicketId, "ACCESS")
                sync.Dispose()
                sync = Nothing

                Me.Dispose()

                Me.Cursor = Cursors.Arrow

            Else
                Exit Sub
            End If
        End If


    End Sub

#End Region

#Region "New Calc"

    Private Sub CalcTotalNoDisc()
        nTotalNoDisc = nPriceUnit * nQde
        txtTotalNoDisc.Text = nTotalNoDisc.ToString("n2")

        If chkDiscType.Checked = True Then
            CalcDiscValue()
        Else
            CalcDiscPct()
        End If

        CalcTotal()
    End Sub

    Private Sub CalcDiscValue()
        nDiscValue = nTotalNoDisc * (nDiscPct / 100)
        txtDiscountValue.Text = nDiscValue.ToString("n2")

        CalcTotal()
    End Sub

    Private Sub CalcDiscPct()
        nDiscPct = (nDiscValue / nTotalNoDisc) * 100
        txtDiscount.Text = nDiscPct.ToString("n2")

        CalcTotal()
    End Sub

    Private Sub CalcTotal()
        nTotal = nTotalNoDisc - nDiscValue
        txtTotal.Text = nTotal.ToString("n2")
    End Sub

    Private Sub chkDiscType_CheckedChanged(sender As Object, e As EventArgs) Handles chkDiscType.CheckedChanged
        If chkDiscType.Checked = True Then
            txtDiscount.Enabled = True
            txtDiscountValue.Enabled = False
        Else
            txtDiscount.Enabled = False
            txtDiscountValue.Enabled = True
        End If
    End Sub

#End Region

#Region "Converting Values"

    Private Function CalcPriceUnitCOP() As String
        If sCurrency <> "USD" Then
            Return nPriceUnit.ToString("n5")
        Else
            Dim nCOP As Double
            nCOP = (nPriceUnit * nExchangeTaxRate)
            Return nCOP.ToString("n5")
        End If

    End Function

    Private Function CalcPriceUnitUSD() As String
        If sCurrency = "USD" Then
            Return nPriceUnit.ToString("n5")
        Else
            Dim nUSD As Double
            nUSD = (nPriceUnit / nExchangeTaxRate)
            Return nUSD.ToString("n5")
        End If
    End Function

    Private Function CalcAmountNoDiscCOP() As String
        If sCurrency <> "USD" Then
            Return nTotalNoDisc.ToString("n4")
        Else
            Dim nCOB As Double
            nCOB = CDbl(CalcPriceUnitCOP()) * nQde
            Return nCOB.ToString("n4")
        End If
    End Function

    Private Function CalcAmountNoDiscUSD() As String
        If sCurrency = "USD" Then
            Return nTotalNoDisc.ToString("n4")
        Else
            Dim nUSD As Double
            nUSD = CDbl(CalcPriceUnitUSD()) * nQde
            Return nUSD.ToString("n4")
        End If
    End Function

    Private Function CalcAmountCOP() As String
        If sCurrency <> "USD" Then
            Return nTotal.ToString("n4")
        Else
            Dim nCOP As Double
            nCOP = (nTotal * nExchangeTaxRate)
            Return nCOP.ToString("n4")
        End If
    End Function

    Private Function CalcAmountUSD() As String
        If sCurrency = "USD" Then
            Return nTotal.ToString("n4")
        Else
            Dim nUSD As Double
            nUSD = (nTotal / nExchangeTaxRate)
            Return nUSD.ToString("n4")
        End If
    End Function

    Private Function CalcDiscValueCOP() As String
        If sCurrency <> "USD" Then
            Return nDiscValue.ToString("n4")
        Else
            Dim nCOP As Double
            Dim nAmountNoDiscN As Double = CDbl(CalcAmountNoDiscCOP())
            Dim nAmountDiscN As Double = CDbl(CalcAmountCOP())
            nCOP = nAmountNoDiscN - nAmountDiscN
            Return nCOP.ToString("n4")
        End If
    End Function

    Private Function CalcDiscValueUSD() As String
        If sCurrency = "USD" Then
            Return nDiscValue.ToString("n4")
        Else
            Dim nUSD As Double
            Dim nAmountNoDiscN As Double = CDbl(CalcAmountNoDiscUSD())
            Dim nAmountDiscN As Double = CDbl(CalcAmountUSD())
            nUSD = nAmountNoDiscN - nAmountDiscN
            Return nUSD.ToString("n4")
        End If
    End Function

    Private Sub txtPriceUnit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPriceUnit.KeyPress
        If IsNumber(e, PermitNegative) = False Then
            e.Handled = True
        End If
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

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If IsNumber(e, False) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscount.KeyPress
        If IsNumber(e, False) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtDiscountValue_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiscountValue.KeyPress
        If IsNumber(e, True) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub ContractPriceListGrants()

        If sContractPriceList = "" Then
            Exit Sub
        End If

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        Try

            bdconn.OpenConnection("BaseData")

            sql = "SELECT PERMITUPDATEDESCRIP,PERMITUPDATEPRICEUNIT,PERMITNEGATIVE " &
                  "FROM CONTRACTPRICELISTTMP " &
                  "WHERE CONTRACTPRICELISTID = " & sContractPriceList & ""

            bdconn.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    If ds.Tables(0).Rows(i)("PERMITUPDATEDESCRIP") = "YES" Then txtDescription.ReadOnly = False Else txtDescription.ReadOnly = True
                    If ds.Tables(0).Rows(i)("PERMITUPDATEPRICEUNIT") = "YES" Then txtPriceUnit.ReadOnly = False Else txtPriceUnit.ReadOnly = True
                    If ds.Tables(0).Rows(i)("PERMITNEGATIVE") = "YES" Then PermitNegative = True Else PermitNegative = False
                Next
            End If

            ds.Dispose()
            ds = Nothing
            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

        Catch ex As Exception
            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing
            MsgBox(ex.Message, vbInformation)
        End Try

    End Sub

#End Region





End Class