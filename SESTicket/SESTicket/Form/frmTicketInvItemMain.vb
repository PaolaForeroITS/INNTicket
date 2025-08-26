
Public Class frmTicketInvItemMain

    Dim util As New clsUtils

    Public sTicketID As String = ""
    Public sUsername As String = ""
    Public bTicketReadOnly As Boolean = False

    Dim sTicketInvAdicId As String = ""
    Dim bLoadForm As Boolean = True

    Private Sub frmTicketInvItemMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "SESTicket - Inventory Itens - TICKETID: " & sTicketID

        util.DateTimePickerFormat(dtpDateDispatched)
        util.DateTimePickerFormat(dtpDateReturned)

        LoadInvItemInfo()

        ReloadTableAdap()
        LoadCategory()
        LoadHeader()

        bLoadForm = False

        If bTicketReadOnly = True Then
            btnNewInvItem.Visible = False
            btnSave.Enabled = False
            chkNoInvItem.Enabled = False
        End If

        If dgvInvItemHead.RowCount = 0 Then
            chkNoInvItem.Visible = True
            txtCode.Text = ""
            txtDescrip.Text = ""
        Else
            chkNoInvItem.Visible = False
        End If

    End Sub

    Private Sub LoadCategory()
        TICKETINVGROUPBindingSource.Filter = "TICKETID = '" & sTicketID & "'"
    End Sub

    Private Sub LoadHeader()

        Dim Filter As String = "TICKETID = '" & sTicketID & "'"

        If cbxCategory.SelectedValue <> "ALL" Then
            Filter = Filter + " AND INVENTORYCLASSID = '" & cbxCategory.SelectedValue & "'"
        End If

        TICKETINVHEADBindingSource.Filter = Filter

    End Sub

    Private Sub LoadLine()


        Dim Filter As String

        Try

            If dgvInvItemHead.RowCount() > 0 Then
                Filter = "TICKETINVHEADERID='" & dgvInvItemHead.CurrentRow.Cells("colTicketInvHeadId").Value.ToString() & "'"
            Else
                Filter = "TICKETINVHEADERID='-1'"
            End If

            TICKETINVLINEBindingSource.Filter = Filter


            If dgvInvItemHead.RowCount > 0 Then
                txtCode.Text = dgvInvItemHead.CurrentRow.Cells("colHeadInvItemId").Value.ToString()
                txtDescrip.Text = dgvInvItemHead.CurrentRow.Cells("colHeadDescrip").Value.ToString()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dgvInvItemHead_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvItemHead.CellClick
        LoadLine()
    End Sub

    Private Sub dgvInvItemHead_SelectionChanged(sender As Object, e As EventArgs) Handles dgvInvItemHead.SelectionChanged
        LoadLine()

    End Sub


    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        LoadHeader()
    End Sub

    Private Sub dgvInvItemHead_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvItemHead.CellDoubleClick
        If dgvInvItemHead.RowCount > 0 Then


            Dim frm As New frmTicketInvItemHeadEdit

            With frm
                .sUsername = Me.sUsername
                .sTicketId = Me.sTicketID
                .bTicketReadOnly = Me.bTicketReadOnly
                .sTicketInvHeadId = dgvInvItemHead.CurrentRow.Cells("colTicketInvHeadId").Value.ToString()
                .txtInvItemId.Text = dgvInvItemHead.CurrentRow.Cells("colHeadInvItemId").Value.ToString()
                .txtAbbrev.Text = dgvInvItemHead.CurrentRow.Cells("colHeadAbbrev").Value.ToString()
                .txtDescrip.Text = dgvInvItemHead.CurrentRow.Cells("colHeadDescrip").Value.ToString()
                .txtLote.Text = dgvInvItemHead.CurrentRow.Cells("colHeadLote").Value.ToString()
                .txtUnit.Text = dgvInvItemHead.CurrentRow.Cells("colHeadUnit").Value.ToString()
                .txtDespatched.Text = util.ConcatDecimalStr(dgvInvItemHead.CurrentRow.Cells("colHeadDespatched").Value.ToString())
                .txtConsumption.Text = util.ConcatDecimalStr(dgvInvItemHead.CurrentRow.Cells("colHeadConsumption").Value.ToString())
                .txtReturned.Text = util.ConcatDecimalStr(dgvInvItemHead.CurrentRow.Cells("colHeadReturned").Value.ToString())
                .txtComments.Text = dgvInvItemHead.CurrentRow.Cells("colHeadComments").Value.ToString()
                .ShowDialog()
            End With

            If frm.bUpdated = True Then
                Me.Cursor = Cursors.WaitCursor

                Dim sql As String
                Dim ds As New DataSet
                Dim bdconn As New clsBancoDadosACCESS

                bdconn.OpenConnection()

                sql = "SELECT COUNT(*) AS QDE FROM [TICKETINVHEADER] " &
                       "WHERE TICKETID = '" & sTicketID & "'"
                bdconn.ExecuteSQL(sql, ds)

                If ds.Tables(0).Rows(0)("QDE") = 0 Then
                    chkNoInvItem.Checked = False
                End If
                ds.Dispose()
                ds = Nothing

                bdconn.CloseConnection()
                bdconn.Dispose()
                bdconn = Nothing

                ReloadTableAdap()
                LoadHeader()
                'LoadLine()
                dgvInvItemHead.Refresh()
                Me.Cursor = Cursors.Arrow
            End If
            frm.Dispose()
            frm = Nothing

        End If


    End Sub

    Private Sub btnNewInvItem_Click(sender As Object, e As EventArgs) Handles btnNewInvItem.Click

        Dim frm As New frmTicketInvItemLineEdit

        With frm
            .sFormName = "frmTicketInvItemMainNEW"
            .sUsername = Me.sUsername
            .sTicketId = Me.sTicketID
        End With

        If dgvInvItemHead.RowCount() > 0 Then
            With frm
                .sInventoryItemId = dgvInvItemHead.CurrentRow.Cells("colHeadInvItemId").Value.ToString()
                .txtInvItemId.Text = dgvInvItemHead.CurrentRow.Cells("colHeadInvItemId").Value.ToString()
                .txtAbbrev.Text = dgvInvItemHead.CurrentRow.Cells("colHeadAbbrev").Value.ToString()
                .txtDescrip.Text = dgvInvItemHead.CurrentRow.Cells("colHeadDescrip").Value.ToString()
                .txtUnit.Text = dgvInvItemHead.CurrentRow.Cells("colHeadUnit").Value.ToString()
            End With
        End If

        frm.ShowDialog()

        If frm.bUpdated = True Then

            Me.Cursor = Cursors.WaitCursor

            ReloadTableAdap()

            LoadCategory()
            LoadHeader()

            dgvInvItemHead.Refresh()

            Me.Cursor = Cursors.Arrow

        End If

        frm.Dispose()
        frm = Nothing


        If dgvInvItemHead.RowCount = 0 Then
            chkNoInvItem.Visible = True
            txtCode.Text = ""
            txtDescrip.Text = ""
        Else
            chkNoInvItem.Visible = False
        End If

    End Sub

    Private Sub dgvInvItemHead_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvItemHead.CellContentClick

    End Sub
    Private Sub ReloadTableAdap()
        Dim n As Integer

        Try
            n = 1
            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETINVGROUP' table. You can move, or remove it, as needed.
            Me.TICKETINVGROUPTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETINVGROUP)
            n = 2
            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETINVHEAD' table. You can move, or remove it, as needed.
            Me.TICKETINVHEADTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETINVHEAD)
            n = 3
            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETINVLINE' table. You can move, or remove it, as needed.
            Me.TICKETINVLINETableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETINVLINE)
            n = 4

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dgvInvItemLine_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvItemLine.CellDoubleClick

        Dim frm As New frmTicketInvItemLineEdit

        With frm
            .sFormName = "frmTicketInvItemMainEDIT"
            .sUsername = Me.sUsername
            .sTicketId = Me.sTicketID
            .bTicketReadOnly = Me.bTicketReadOnly
        End With

        If dgvInvItemHead.RowCount() > 0 Then
            With frm
                .sInventoryItemId = dgvInvItemHead.CurrentRow.Cells("colHeadInvItemId").Value.ToString()
                .txtInvItemId.Text = dgvInvItemHead.CurrentRow.Cells("colHeadInvItemId").Value.ToString()
                .txtAbbrev.Text = dgvInvItemHead.CurrentRow.Cells("colHeadAbbrev").Value.ToString()
                .txtDescrip.Text = dgvInvItemHead.CurrentRow.Cells("colHeadDescrip").Value.ToString()
                .txtUnit.Text = dgvInvItemHead.CurrentRow.Cells("colHeadUnit").Value.ToString()
            End With
        End If

        If dgvInvItemLine.RowCount() > 0 Then

            With frm
                .sTicketSalesItemId = dgvInvItemLine.CurrentRow.Cells("colTicketSalesItemId").Value.ToString()
                .sTicketInvLineId = dgvInvItemLine.CurrentRow.Cells("colTicketInvLineId").Value.ToString()
                .txtCustCodeItem.Text = dgvInvItemLine.CurrentRow.Cells("colCustCodeItem").Value.ToString()
                .txtSalesItemDescrip.Text = dgvInvItemLine.CurrentRow.Cells("colDescription").Value.ToString()
                .txtQuantity.Text = util.ConcatDecimalStr(dgvInvItemLine.CurrentRow.Cells("colLineQty").Value.ToString())
            End With

        End If

        frm.ShowDialog()

        If frm.bUpdated = True Then

            Me.Cursor = Cursors.WaitCursor

            ReloadTableAdap()

            LoadCategory()
            LoadHeader()

            dgvInvItemHead.Refresh()

            Me.Cursor = Cursors.Arrow

        End If

        frm.Dispose()
        frm = Nothing

        If dgvInvItemHead.RowCount = 0 Then
            chkNoInvItem.Visible = True
            chkNoInvItem.Checked = False
            txtCode.Text = ""
            txtDescrip.Text = ""
        Else
            chkNoInvItem.Visible = False
        End If

    End Sub

    Private Sub dgvInvItemLine_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvItemLine.CellContentClick

    End Sub

    Private Sub LoadInvItemInfo()

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconn.OpenConnection()

        sql = "SELECT * FROM [TICKETINVADIC] " &
              "WHERE TICKETID = '" & sTicketID & "'"
        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count = 0 Then
            Dim seq As New clsSequenceAccess(Me.sTicketID)
            sTicketInvAdicId = seq.TicketInvAdicNextId
            seq.Dispose()
            seq = Nothing

            '--Reseting Date Values
            dtpDateDispatched.Value = Date.Now
            dtpDateReturned.Value = Date.Now

            sql = "INSERT INTO TICKETINVADIC (TICKETINVADICID,TICKETID,DISPATCHED,RETURNED " &
                  ",TRANSPCOMPANY,DRIVER,WAREHOUSERESP,OPERATIONRESP " &
                  ",ENGENEERRESP,COMMENTS) VALUES (" &
                "'" & sTicketInvAdicId & "'," &
                "'" & sTicketID & "'," &
                "" & util.SQLConvStrDatetime(dtpDateDispatched.Value.ToString) & "," &
                "" & util.SQLConvStrDatetime(dtpDateReturned.Value.ToString) & "," &
                "" & util.SQLConvStrNull(txtTranspCompany.Text, "s") & "," &
                "" & util.SQLConvStrNull(txtDriver.Text, "s") & "," &
                "" & util.SQLConvStrNull(txtWarehouseResp.Text, "s") & "," &
                "" & util.SQLConvStrNull(txtOperResp.Text, "s") & "," &
                "" & util.SQLConvStrNull(txtEngResp.Text, "s") & "," &
                "" & util.SQLConvStrNull(txtComments.Text, "s") & ")"

            bdconn.ExecuteNonSQL(sql)

            Dim sync As New clsSyncTicket
            sync.UpdateSyncDateTime(sTicketID, "ACCESS")
            sync.Dispose()
            sync = Nothing

            ds.Dispose()
            ds = Nothing

        Else
            sTicketInvAdicId = ds.Tables(0).Rows(0)("TICKETINVADICID").ToString()

            dtpDateDispatched.Value = util.TrataDBNull(ds.Tables(0).Rows(0)("DISPATCHED"))
            dtpDateReturned.Value = util.TrataDBNull(ds.Tables(0).Rows(0)("RETURNED"))
            txtTranspCompany.Text = util.TrataDBNull(ds.Tables(0).Rows(0)("TRANSPCOMPANY"))
            txtDriver.Text = util.TrataDBNull(ds.Tables(0).Rows(0)("DRIVER"))
            txtWarehouseResp.Text = util.TrataDBNull(ds.Tables(0).Rows(0)("WAREHOUSERESP"))
            txtOperResp.Text = util.TrataDBNull(ds.Tables(0).Rows(0)("OPERATIONRESP"))
            txtEngResp.Text = util.TrataDBNull(ds.Tables(0).Rows(0)("ENGENEERRESP"))
            txtComments.Text = util.TrataDBNull(ds.Tables(0).Rows(0)("COMMENTS"))

            ds.Dispose()
            ds = Nothing

            ds = New DataSet

            sql = "SELECT NOINVITEM FROM TICKET WHERE TICKETID = '" & sTicketID & "'"
            bdconn.ExecuteSQL(sql, ds)

            If util.TrataDBNull(ds.Tables(0).Rows(0)("NOINVITEM")) = 1 Then
                chkNoInvItem.Checked = True
            End If

            ds.Dispose()
            ds = Nothing

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing


        If dgvInvItemHead.RowCount = 0 Then
            chkNoInvItem.Visible = True
            txtCode.Text = ""
            txtDescrip.Text = ""
        Else
            chkNoInvItem.Visible = False
        End If

    End Sub

    Private Sub UpdateTicketInfAdic()

        If bLoadForm = True Then
            Exit Sub
        End If

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String

        bdconn.OpenConnection()

        Me.Cursor = Cursors.WaitCursor

        sql = "UPDATE TICKETINVADIC SET " &
             "DISPATCHED    = " & util.SQLConvStrDatetime(dtpDateDispatched.Value.ToString) & " " &
             ",RETURNED      = " & util.SQLConvStrDatetime(dtpDateReturned.Value.ToString) & " " &
             ",TRANSPCOMPANY = " & util.SQLConvStrNull(txtTranspCompany.Text, "s") & " " &
             ",DRIVER        = " & util.SQLConvStrNull(txtDriver.Text, "s") & " " &
             ",WAREHOUSERESP = " & util.SQLConvStrNull(txtWarehouseResp.Text, "s") & " " &
             ",OPERATIONRESP = " & util.SQLConvStrNull(txtOperResp.Text, "s") & " " &
             ",ENGENEERRESP  = " & util.SQLConvStrNull(txtEngResp.Text, "s") & " " &
             ",COMMENTS      = " & util.SQLConvStrNull(txtComments.Text, "s") & " " &
             "WHERE TICKETINVADICID = '" & sTicketInvAdicId & "'"

        bdconn.ExecuteNonSQL(sql)

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketID, "ACCESS")
        sync.Dispose()
        sync = Nothing

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub chkNoInvItem_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoInvItem.CheckedChanged

        If bLoadForm = True Then
            Exit Sub
        End If

        If chkNoInvItem.Checked = True Then
            If MsgBox("Reporting that you have no inventory will affect the controls. Continue? ", vbYesNo) = vbNo Then
                chkNoInvItem.Checked = False
                Exit Sub
            End If
        End If

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String

        bdconn.OpenConnection()

        Me.Cursor = Cursors.WaitCursor

        sql = "UPDATE TICKET SET " &
              "NOINVITEM    = " & IIf(chkNoInvItem.Checked = True, 1, 0) & " " &
              "WHERE TICKETID = '" & sTicketID & "'"
        bdconn.ExecuteNonSQL(sql)

        sql = "DELETE FROM TICKETINVLINE WHERE TICKETINVHEADERID IN " &
              "(SELECT TICKETINVHEADERID FROM TICKETINVHEADER WHERE TICKETID='" & sTicketID & "') "
        bdconn.ExecuteNonSQL(sql)

        sql = "DELETE FROM TICKETINVHEADER WHERE TICKETID='" & sTicketID & "' "
        bdconn.ExecuteNonSQL(sql)

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketID, "ACCESS")
        sync.Dispose()
        sync = Nothing

        Me.Cursor = Cursors.Arrow


    End Sub

    Private Sub cbxCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCategory.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        UpdateTicketInfAdic()
        MsgBox("Saved", vbInformation)
    End Sub

    Private Sub mnuInvCons_Click(sender As Object, e As EventArgs) Handles mnuInvCons.Click
        Dim frm As New frmTicketInvConsumptionLetterLandscape
        frm.sTicketId = Me.sTicketID
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub
End Class