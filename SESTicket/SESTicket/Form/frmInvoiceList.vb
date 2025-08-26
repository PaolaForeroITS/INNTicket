Public Class frmInvoiceList

    Public sUsername As String = "fmelo"
    Public bReloadGrid As Boolean = False
    Dim bPermitCancelTicket As Boolean = True
    Dim bPermitReopenTicket As Boolean = True
    Dim bShowServiceTicketARG As Boolean = True
    Dim util As New clsUtils

#Region "Default Methods"
    Private Sub frmTicketInvoiceList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.cbxCustomer' table. You can move, or remove it, as needed.
        Me.CbxCustomerTableAdapter.Fill(Me.SESTicketAccessDataSet.cbxCustomer)
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.cbxTicketStatus' table. You can move, or remove it, as needed.
        Me.CbxTicketStatusTableAdapter.Fill(Me.SESTicketSQLDataSet.cbxTicketStatus)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.cbxSite' table. You can move, or remove it, as needed.
        Me.CbxSiteTableAdapter.Fill(Me.SESTicketAccessDataSet.cbxSite)
        'TODO: This line of code loads data into the 'SESTicketSQLDataSet.cbxServiceLine' table. You can move, or remove it, as needed.
        Me.CbxServiceLineTableAdapter.Fill(Me.SESTicketSQLDataSet.cbxServiceLine)

        util.DateTimePickerFormat(dtpServiceDateBegin)
        util.DateTimePickerFormat(dtpServiceDateEnd)

        dtpServiceDateBegin.Value = DateSerial(Year(Now), Month(Now), 1)
        dtpServiceDateEnd.Value = DateSerial(Year(Now), Month(Now) + 1, 0)

        '--Remove duplicated
        RemoveTicketInvoiceDuplicated()

        LoadTickets()

        '--User Grants
        FormUserGrant()

    End Sub

    Private Sub dgvInvoice_Sorted(sender As Object, e As EventArgs) Handles dgvInvoice.Sorted
        ForeColorGrid()
    End Sub

    Private Sub cbxServiceLine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxServiceLine.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxSite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxSite.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCustomer.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxTicket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTicket.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxTicketStatus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTicketStatus.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxDate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxDate.KeyPress
        e.Handled = True
    End Sub

    Private Sub RemoveTicketInvoiceDuplicated()
        'Its a temporary solution for the bug

        Dim sql As String
        Dim bdconn As New clsBancoDadosSQL

        bdconn.OpenConnection()

        sql = "DELETE " &
            "FROM TICKETINVOICE " &
            "WHERE TICKETINVOICEID NOT IN ( " &
            "SELECT TICKETINVOICEID " &
            "FROM TICKETINVOICELINE  " &
            "WHERE TICKETID In ( " &
            "SELECT TICKETID " &
            "FROM TICKETINVOICE " &
            "GROUP BY TICKETID " &
            "HAVING COUNT(*) > 1)) " &
            "AND " &
            "TICKETID IN (SELECT TICKETID " &
            "FROM TICKETINVOICE " &
            "GROUP BY TICKETID " &
            "HAVING COUNT(*) > 1) "

        bdconn.ExecuteNonSQL(sql)

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

    End Sub


#End Region

#Region "Grid Methods"

    Private Sub LoadTickets()
        Try

            Me.Cursor = Cursors.WaitCursor

            Dim sInvoiceStatus As String = ""
            If chkNoInvoice.Checked = True Then
                sInvoiceStatus = "No Invoiced"
            End If
            If chkParcially.Checked = True Then
                If sInvoiceStatus <> "" Then
                    sInvoiceStatus = sInvoiceStatus + ",Parcially Invoiced"
                Else
                    sInvoiceStatus = "Parcially Invoiced"
                End If

            End If
            If chkCompleted.Checked = True Then
                If sInvoiceStatus <> "" Then
                    sInvoiceStatus = sInvoiceStatus + ",Completed"
                Else
                    sInvoiceStatus = "Completed"
                End If

            End If

            Dim sTicketId As String = ""
            Dim sSuperiorNum As String = ""
            Dim sInvoiceNumber As String = ""

            If cbxTicket.Text = "Ticket ID" Then
                sTicketId = txtTicketId.Text
                sSuperiorNum = ""
                sInvoiceNumber = ""
            ElseIf cbxTicket.Text = "Proforma Val." Then
                sTicketId = ""
                sSuperiorNum = txtTicketId.Text
                sInvoiceNumber = ""
            ElseIf cbxTicket.Text = "Invoice Number" Then
                sTicketId = ""
                sSuperiorNum = ""
                sInvoiceNumber = txtTicketId.Text
            End If


            Me.Sp_TicketInvoiceTableAdapter.Fill(Me.SESTicketSQLDataSet.sp_TicketInvoice, cbxDate.Text, dtpServiceDateBegin.Value, dtpServiceDateEnd.Value,
                                                 sTicketId, sSuperiorNum, cbxTicketStatus.Text,
                                                 sInvoiceStatus, sInvoiceNumber, cbxServiceLine.SelectedValue.ToString,
                                                 cbxCustomer.SelectedValue.ToString, cbxSite.SelectedValue.ToString)


            CalculateTotals()
            ForeColorGrid()

            Me.Cursor = Cursors.Arrow

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadTickets()
    End Sub

    Private Sub CalculateTotals()

        Dim nTicketTotal As Double = 0
        Dim nInvoiceTotal As Double = 0
        Dim nDif As Double = 0

        For index As Integer = 0 To dgvInvoice.Rows.Count - 1
            If IsNothing(dgvInvoice.Rows(index).Cells("colTicketTotal").Value) = False Then
                If dgvInvoice.Rows(index).Cells("colTicketTotal").Value.ToString <> "" Then
                    nTicketTotal = nTicketTotal + dgvInvoice.Rows(index).Cells("colTicketTotal").Value
                End If
            End If
            If IsNothing(dgvInvoice.Rows(index).Cells("colInvoiceTotal").Value) = False Then
                If dgvInvoice.Rows(index).Cells("colInvoiceTotal").Value.ToString <> "" Then
                    nInvoiceTotal = nInvoiceTotal + dgvInvoice.Rows(index).Cells("colInvoiceTotal").Value
                End If
            End If
            If IsNothing(dgvInvoice.Rows(index).Cells("colDif").Value) = False Then
                If dgvInvoice.Rows(index).Cells("colDif").Value.ToString <> "" Then
                    nDif = nDif + dgvInvoice.Rows(index).Cells("colDif").Value
                End If
            End If

        Next

        txtTicketTotal.Text = String.Format("{0:n}", nTicketTotal, Nothing)
        txtInvoicedTotal.Text = String.Format("{0:n}", nInvoiceTotal, Nothing)
        txtDif.Text = String.Format("{0:n}", nDif, Nothing)

    End Sub

    Private Sub ForeColorGrid()
        For i As Integer = 0 To Me.dgvInvoice.Rows.Count - 1
            If Me.dgvInvoice.Rows(i).Cells("colDif").Value < 0 Then
                Me.dgvInvoice.Rows(i).Cells("colDif").Style.ForeColor = Color.Red
            Else
                Me.dgvInvoice.Rows(i).Cells("colDif").Style.ForeColor = Color.Blue
            End If

            If Me.dgvInvoice.Rows(i).Cells("colTicketTotal").Value < 0 Then
                Me.dgvInvoice.Rows(i).Cells("colTicketTotal").Style.ForeColor = Color.Red
            Else
                Me.dgvInvoice.Rows(i).Cells("colTicketTotal").Style.ForeColor = Color.Blue
            End If

            If dgvInvoice.Rows(i).Cells("colTicketStatus").Value = "Canceled" Then
                With dgvInvoice.Rows(i)
                    .Cells("colTicketStatus").Style.ForeColor = Color.Red
                End With
            ElseIf dgvInvoice.Rows(i).Cells("colTicketStatus").Value = "Closed" Then
                With dgvInvoice.Rows(i)
                    .Cells("colTicketStatus").Style.ForeColor = Color.Blue
                End With
            ElseIf dgvInvoice.Rows(i).Cells("colTicketStatus").Value = "Open" Then
                With dgvInvoice.Rows(i)
                    .Cells("colTicketStatus").Style.ForeColor = Color.DarkGreen
                End With
            End If


            If Me.dgvInvoice.Rows(i).Cells("colInvoiceStatus").Value = "No Invoiced" Then
                Me.dgvInvoice.Rows(i).Cells("colInvoiceStatus").Style.ForeColor = Color.Red
            Else
                Me.dgvInvoice.Rows(i).Cells("colInvoiceStatus").Style.ForeColor = Color.Blue
            End If

        Next
    End Sub

    Private Sub dgvInvoice_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvoice.CellContentClick

    End Sub

    Private Sub dgvInvoice_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvoice.CellDoubleClick
        Dim frm As New frmInvoiceEdit
        With frm
            .sUsername = Me.sUsername
            .sTicketID = dgvInvoice.CurrentRow.Cells("colTicketID").Value.ToString
            .sTicketInvoiceId = dgvInvoice.CurrentRow.Cells("colTicketInvoiceId").Value.ToString
            .sLineType = dgvInvoice.CurrentRow.Cells("colLineType").Value.ToString
            .ShowDialog()
        End With

        '--Remove duplicated
        RemoveTicketInvoiceDuplicated()

        If frm.bReloadGrid = True Then
            LoadTickets()
        End If

        frm.Dispose()
        frm = Nothing

    End Sub

#End Region

#Region "Context Menu"

    Private Sub cmnuImportTicket_Click(sender As Object, e As EventArgs) Handles cmnuImportTicket.Click
        Dim frm As New frmImportTicket
        With frm
            .sUsername = Me.sUsername
            .LoadGrid(dgvInvoice)
            .ShowDialog()
        End With

        If frm.bReloadGrid = True Then
            If Me.bReloadGrid = False Then
                Me.bReloadGrid = True
            End If
        End If

        frm.Dispose()
        frm = Nothing

    End Sub

    Private Sub cmnuReOpenTicket_Click(sender As Object, e As EventArgs) Handles cmnuReOpenTicket.Click

        If bPermitReopenTicket = False Then
            MsgBox("You don´t have permission for this action", vbInformation)
            Exit Sub
        End If

        Dim frm As New frmTicketReopen
        With frm
            .sUsername = Me.sUsername
            .LoadGrid(dgvInvoice)
            .ShowDialog()
        End With

        If frm.bReloadGrid = True Then
            LoadTickets()

            If Me.bReloadGrid = False Then
                Me.bReloadGrid = True
            End If
        End If

        frm.Dispose()
        frm = Nothing

    End Sub

    Private Sub cmnuCancelTicket_Click(sender As Object, e As EventArgs) Handles cmnuCancelTicket.Click

        If bPermitCancelTicket = False Then
            MsgBox("You don´t have permission for this action", vbInformation)
            Exit Sub
        End If

        Dim frm As New frmCancelTicket
        With frm
            .sUsername = Me.sUsername
            .LoadGrid(dgvInvoice)
            .ShowDialog()
        End With

        If frm.bReloadGrid = True Then
            LoadTickets()

            If Me.bReloadGrid = False Then
                Me.bReloadGrid = True
            End If

        End If

        frm.Dispose()
        frm = Nothing

    End Sub

    Private Sub mnuExportExcel_Click(sender As Object, e As EventArgs) Handles mnuExportExcel.Click

        If dgvInvoice.Rows.Count = 0 Then
            MsgBox("No Rows to Export", vbInformation)
            Exit Sub
        End If

        Dim sLayoutType As String = "frmInvoiceList"

        'abre uma caixa de diálogo
        SaveFileDialog1.FileName = sLayoutType
        SaveFileDialog1.ShowDialog()

        If SaveFileDialog1.FileName <> sLayoutType Then

            'Copy the File to Destiny
            Me.Cursor = Cursors.WaitCursor

            Dim cls As New clsDataExp
            Try
                cls.ExpLayout(sLayoutType, SaveFileDialog1.FileName)
                cls.frmInvoiceList(SaveFileDialog1.FileName, dgvInvoice, bShowServiceTicketARG)

                cls.Dispose()
                cls = Nothing

                Me.Cursor = Cursors.Arrow
                If MsgBox("Exported to " & SaveFileDialog1.FileName & Environment.NewLine & "Do you want open the file?", vbYesNo) = vbYes Then
                    Process.Start(SaveFileDialog1.FileName)
                End If

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                cls.Dispose()
                cls = Nothing
                MsgBox(ex.Message, vbExclamation)
            End Try
        End If

    End Sub

    Private Sub cmnuChangeTicketClosedDate_Click(sender As Object, e As EventArgs) Handles cmnuChangeTicketClosedDate.Click

        Dim frm As New frmChangeTicketClosedDate
        With frm
            .sUsername = Me.sUsername
            .LoadGrid(dgvInvoice)
            .ShowDialog()
        End With

        If frm.bReloadGrid = True Then
            LoadTickets()

            If Me.bReloadGrid = False Then
                Me.bReloadGrid = True
            End If
        End If

        frm.Dispose()
        frm = Nothing


    End Sub



#End Region

#Region "FormUserGrants"

    Private Sub FormUserGrant()

        Me.Cursor = Cursors.WaitCursor

        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection("AccBase")

        Dim sql As String
        Dim ds As New DataSet


        sql = "SELECT obj.OBJECTNAME, obj.OBJECTTYPE,usr.ENABLE  " &
              "FROM OBJECTGROUPITEMUSER usr, OBJECTGROUPITEM obj " &
              "WHERE usr.OBJECTGROUPITEMID = obj.OBJECTGROUPITEMID " &
              "and usr.ENABLE = 'NO'  " &
              "and obj.OBJECTFORM = 'frmInvoiceList' " &
              "and usr.USERNAME = '" & Me.sUsername & "' " &
              "UNION ALL " &
              "SELECT obj.OBJECTNAME, obj.OBJECTTYPE,usr.ENABLE " &
              "FROM OBJECTGROUPITEMUSER usr, OBJECTGROUPITEM obj " &
              "WHERE usr.OBJECTGROUPITEMID = obj.OBJECTGROUPITEMID " &
              "and obj.OBJECTFORM = 'frmTicket' " &
              "and obj.OBJECTNAME = 'bShowServiceTicketARG' " &
              "and usr.USERNAME = '" & Me.sUsername & "' "

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim sObject As String = ""

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                sObject = ds.Tables(0).Rows(i)("OBJECTNAME")

                If sObject = "bPermitCancelTicket" Then
                    bPermitCancelTicket = False
                ElseIf sObject = "bPermitReopenTicket" Then
                    bPermitReopenTicket = False

                ElseIf sObject = "bShowServiceTicketARG" Then
                    If ds.Tables(0).Rows(i)("ENABLE") = "YES" Then
                        dgvInvoice.Columns("colSuperiorNum").Visible = True
                        cbxTicket.Visible = True
                        cbxTicket.Text = "Ticket ID"
                        lblTicketID.Visible = False
                        bShowServiceTicketARG = True
                    Else
                        dgvInvoice.Columns("colSuperiorNum").Visible = False
                        cbxTicket.Visible = False
                        cbxTicket.Text = "Ticket ID"
                        lblTicketID.Visible = True
                        bShowServiceTicketARG = False
                    End If
                ElseIf sObject = "bPermitChangeTicketClosedDate" Then
                    If ds.Tables(0).Rows(i)("ENABLE") = "YES" Then
                        cmnuSep02.Visible = True
                        cmnuChangeTicketClosedDate.Visible = True
                    Else
                        cmnuSep02.Visible = False
                        cmnuChangeTicketClosedDate.Visible = False
                    End If

                End If
            Next

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Me.Cursor = Cursors.Arrow

    End Sub


#End Region


End Class