
Public Class frmInvoiceEdit

    Dim util As New clsUtils

    Public sTicketID As String = ""
    Public sTicketInvoiceId As String = ""
    Dim sTicketInvLineId As String = ""
    Public sLineType As String = ""
    Public sUsername As String = ""

    Public bReloadGrid As Boolean = False

    Private Sub frmInvoiceEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        Try
            CheckTicketInvoice()
            RefreshHeader()
            RefreshgrdInvLine()
            ReloadSalesItem()

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub CheckTicketInvoice()
        Try

            If sTicketInvoiceId = "" Then

                Dim sql As String
                Dim bdconn As New clsBancoDadosSQL

                bdconn.OpenConnection()

                sql = "INSERT INTO [TICKETINVOICE] ([TICKETID],[LINETYPE],[INVOICESTATUS]) VALUES ("
                sql = sql & "'" & sTicketID & "',"
                sql = sql & "'" & sLineType & "',"
                sql = sql & "'No Invoiced')"

                bdconn.ExecuteNonSQL(sql)

                Dim ds As New DataSet

                sql = "SELECT TICKETINVOICEID FROM TICKETINVOICE WHERE TICKETID = '" & sTicketID & "' " & _
                      "AND LINETYPE = '" & sLineType & "'"

                bdconn.ExecuteSQL(sql, ds)

                If ds.Tables(0).Rows.Count > 0 Then
                    For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                        sTicketInvoiceId = util.TrataDBNull(ds.Tables(0).Rows(i)("TICKETINVOICEID").ToString)
                    Next
                End If
                ds.Dispose()

                ds = Nothing

                bdconn.CloseConnection()
                bdconn.Dispose()
                bdconn = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub RefreshHeader()

        Try

            txtTicketNumber.Text = sTicketID

            Dim sql As String
            Dim bdconn As New clsBancoDadosSQL
            Dim ds As New DataSet

            bdconn.OpenConnection()

            sql = "SELECT " & _
            "SERVICELINE  " & _
            ",CUSTOMER  " & _
            ",CONTRACTNUMBER  " & _
            ",WELLID  " & _
            ",CURRENCY  " & _
            ",LINETYPE  " & _
            ",INVOICESTATUS  " & _
            ",CREATEDBY  " & _
            ",SERVICETYPE  " & _
            ",JOBDESCRIPTION  " & _
            ",SITE  " & _
            "FROM [INVOICE_TICKET_TOTAL_V] " & _
            "WHERE TICKETID = '" & sTicketID & "' " & _
            "AND LINETYPE = '" & sLineType & "' "

            bdconn.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    txtServiceLine.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("SERVICELINE").ToString)
                    txtCustomer.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("CUSTOMER").ToString)
                    txtContract.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTNUMBER").ToString)
                    txtWell.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("WELLID").ToString)
                    txtCurrency.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("CURRENCY").ToString)
                    txtLineType.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("LINETYPE").ToString)
                    cbxInvoiceStatus.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("INVOICESTATUS").ToString)
                    txtCreatedBy.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("CREATEDBY").ToString)
                    txtJobDescription.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("JOBDESCRIPTION").ToString)
                    txtServiceType.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("SERVICETYPE").ToString)
                    txtSite.Text = util.TrataDBNull(ds.Tables(0).Rows(i)("SITE").ToString)

                    If util.TrataDBNull(ds.Tables(0).Rows(i)("INVOICESTATUS").ToString) = "No Invoiced" Then
                        cbxInvoiceStatus.Enabled = False
                    Else
                        cbxInvoiceStatus.Enabled = True
                    End If

                Next
            End If
            ds.Dispose()
            ds = Nothing

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub RefreshTotals()

        Try

            Dim sql As String
            Dim bdconn As New clsBancoDadosSQL
            Dim ds As New DataSet

            bdconn.OpenConnection()

            sql = "SELECT " & _
            "TICKETTOTAL  " & _
            ",INVOICETOTAL  " & _
            ",DIF  " & _
            "FROM [INVOICE_V] " & _
            "WHERE TICKETID = '" & sTicketID & "' " & _
            "AND LINETYPE = '" & sLineType & "' "

            bdconn.ExecuteSQL(sql, ds)


            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                    txtTicketTotal.Text = util.FormatNumber(util.TrataDBNull(ds.Tables(0).Rows(i)("TICKETTOTAL")))
                    txtInvoicedTotal.Text = util.FormatNumber(util.TrataDBNull(ds.Tables(0).Rows(i)("INVOICETOTAL")))
                    txtDif.Text = util.FormatNumber(util.TrataDBNull(ds.Tables(0).Rows(i)("DIF")))

                Next
            End If
            ds.Dispose()
            ds = Nothing

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        Try

            Dim sql As String
            Dim bdconn As New clsBancoDadosSQL

            bdconn.OpenConnection()

            sql = "INSERT INTO TICKETINVOICELINE (TICKETINVOICEID, TICKETID, CREATEDUSER,CREATEDDATETIME,ACTIVE,[INVOICEAMOUNT],[INVOICEDATE]) VALUES ("
            sql = sql & "" & sTicketInvoiceId & ","
            sql = sql & "'" & sTicketID & "',"
            sql = sql & "'" & sUsername & "',"
            sql = sql & "" & util.GetDateTime() & ",'YES',0," & util.GetDateTime() & ")"

            bdconn.ExecuteNonSQL(sql)

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

            UpdateInvoiceStatus("Parcially Invoiced")
            cbxInvoiceStatus.Text = "Parcially Invoiced"
            cbxInvoiceStatus.Enabled = True

            RefreshgrdInvLine()

            bReloadGrid = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub RefreshgrdInvLine()

        Try

            'TODO: This line of code loads data into the 'SESTicketSQLDataSet.TICKETINVOICELINE' table. You can move, or remove it, as needed.
            Me.TICKETINVOICELINETableAdapter.Fill(Me.SESTicketSQLDataSet.TICKETINVOICELINE)

            'Filter
            TICKETINVOICELINEBindingSource.Filter = "ACTIVE='YES' AND TICKETINVOICEID = " & sTicketInvoiceId & ""
            dgvTicketInvLine.Refresh()

            RefreshTotals()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub UpdateInvoiceLine(ByVal sTicketInvoiceLineId As String, ByVal sInvoiceNumber As String, _
                                  ByVal sInvoiceDate As Date, ByVal sAXGPNumber As String, _
                                  ByVal InvoiceAmount As Double, ByVal sComment As String)
        Try

            Dim bdconn As New clsBancoDadosSQL
            bdconn.OpenConnection()

            Dim sql As String

            sql = "UPDATE [TICKETINVOICELINE] " &
            "SET [INVOICEDATE]  = " & util.SQLConvStrDate(sInvoiceDate) & " " &
            ",[INVOICENUMBER]   = " & util.SQLConvStrNull(sInvoiceNumber, "s") & " " &
            ",[INVOICEAMOUNT]   = " & util.SQLConvStrNull(InvoiceAmount, "n") & " " &
            ",[AX_GP_NUMBER]    = " & util.SQLConvStrNull(sAXGPNumber, "s") & " " &
            ",[COMMENT]         = " & util.SQLConvStrNull(sComment, "s") & " " &
            ",[UPDATEDUSER]     = " & util.SQLConvStrNull(sUsername, "s") & " " &
            ",[UPDATEDDATETIME] = " & util.GetDateTime() & " " &
            "WHERE TICKETINVOICELINEID = " & sTicketInvoiceLineId & " "

            bdconn.ExecuteNonSQL(sql)

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing


            RefreshTotals()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub dgvTicketInvLine_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvTicketInvLine.CellBeginEdit
        With dgvTicketInvLine.Rows(e.RowIndex).Cells(e.ColumnIndex)
            .Style.BackColor = Color.Yellow
        End With
    End Sub

    Private Sub dgvTicketInvLine_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTicketInvLine.CellEndEdit

        Me.UpdateInvoiceLine(dgvTicketInvLine.CurrentRow.Cells("colTicketInvLineId").Value.ToString, _
                             dgvTicketInvLine.CurrentRow.Cells("colInvoiceNumber").Value.ToString, _
                             IIf(IsDBNull(dgvTicketInvLine.CurrentRow.Cells("colInvoiceDate").Value) = True, Nothing, dgvTicketInvLine.CurrentRow.Cells("colInvoiceDate").Value), _
                             dgvTicketInvLine.CurrentRow.Cells("colAxGpNumber").Value.ToString, _
                             IIf(IsDBNull(dgvTicketInvLine.CurrentRow.Cells("colInvoiceAmount").Value) = True, Nothing, dgvTicketInvLine.CurrentRow.Cells("colInvoiceAmount").Value), _
                             dgvTicketInvLine.CurrentRow.Cells("colComment").Value.ToString)

        RefreshgrdInvLine()

    End Sub

    Private Sub dgvTicketInvLine_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvTicketInvLine.CellFormatting
        For l As Integer = 0 To Me.dgvTicketInvLine.RowCount - 1
            With dgvTicketInvLine.Rows(l)
                .DefaultCellStyle.ForeColor = Color.Blue
            End With
        Next
    End Sub

    Private Sub dgvTicketInvLine_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvTicketInvLine.DataError
        e.Cancel = True
    End Sub

    Private Sub dgvTicketInvLine_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvTicketInvLine.EditingControlShowing
        AddHandler CType(e.Control, TextBox).KeyPress, AddressOf TextBox_keyPress_DECIMAL
    End Sub

    Private Sub TextBox_keyPress_DECIMAL(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If dgvTicketInvLine.CurrentCell.ColumnIndex = 3 Then
            If Not (Char.IsDigit(CChar(CStr(e.KeyChar))) Or e.KeyChar = Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator Or e.KeyChar = "-" Or e.KeyChar = ChrW(8)) Then
                e.Handled = True
            Else
                e.Handled = False
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Try

            If dgvTicketInvLine.RowCount > 0 Then

                If sTicketInvLineId = "" Then
                    MsgBox("Select the item", vbInformation)
                    Exit Sub
                End If

                Dim sql As String
                Dim bdconn As New clsBancoDadosSQL

                bdconn.OpenConnection()

                sql = "UPDATE TICKETINVOICELINE SET " &
                      " [UPDATEDUSER]     = " & util.SQLConvStrNull(sUsername, "s") & " " &
                      ",[UPDATEDDATETIME] = " & util.GetDateTime() & " " &
                      ",ACTIVE = 'NO' " &
                      "WHERE TICKETINVOICELINEID = " & sTicketInvLineId & ""

                bdconn.ExecuteNonSQL(sql)

                bdconn.CloseConnection()
                bdconn.Dispose()
                bdconn = Nothing

            End If

            RefreshgrdInvLine()

            If dgvTicketInvLine.RowCount <= 0 Then
                UpdateInvoiceStatus("No Invoiced")
                cbxInvoiceStatus.Text = "No Invoiced"
                cbxInvoiceStatus.Enabled = False
            End If

            RefreshTotals()

            bReloadGrid = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgvTicketInvLine_SelectionChanged(sender As Object, e As EventArgs) Handles dgvTicketInvLine.SelectionChanged
        dgvTicketInvLineChangeLine()
    End Sub

    Private Sub dgvTicketInvLineChangeLine()
        If dgvTicketInvLine.RowCount > 0 Then
            If IsNothing(util.TrataDBNull(dgvTicketInvLine.CurrentRow.Cells("colTicketInvLineId").Value)) = False Then
                sTicketInvLineId = dgvTicketInvLine.CurrentRow.Cells("colTicketInvLineId").Value.ToString
            Else
                sTicketInvLineId = ""
            End If
        End If
    End Sub

    Private Sub cbxInvoiceStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxInvoiceStatus.SelectedIndexChanged
        UpdateInvoiceStatus(cbxInvoiceStatus.Text)
    End Sub

    Private Sub UpdateInvoiceStatus(ByVal sStatus As String)

        Try

            Dim sql As String
            Dim bdconn As New clsBancoDadosSQL

            bdconn.OpenConnection()

            sql = "UPDATE TICKETINVOICE SET " & _
                  " [INVOICESTATUS]     = '" & sStatus & "' " & _
                  "WHERE TICKETINVOICEID = " & sTicketInvoiceId & ""

            bdconn.ExecuteNonSQL(sql)

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

            RefreshTotals()

            bReloadGrid = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ReloadSalesItem()

        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.SALESITEM_V' table. You can move, or remove it, as needed.
        Me.SALESITEM_VTableAdapter.Fill(Me.SESTicketSQLDataSet.SALESITEM_V)

        Dim sFilter As String = "TICKETID='" & sTicketID & "' "

        If sLineType = "Service" Then
            sFilter = sFilter & "AND [TYPE] = 'Service' "
        ElseIf sLineType = "Material" Then
            sFilter = sFilter & "AND [TYPE] = 'Material' "
        End If

        SALESITEM_VBindingSource.Filter = sFilter
        dgvSalesItem.Refresh()

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
        Next

    End Sub

    Private Sub dgvSalesItem_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSalesItem.CellFormatting
        If e.RowIndex >= 0 Then
            ForeColorGridSalesItem()
        End If
    End Sub

    Private Sub dgvSalesItem_SelectionChanged(sender As Object, e As EventArgs) Handles dgvSalesItem.SelectionChanged
        dgvSalesItemChangeLine()
    End Sub

End Class