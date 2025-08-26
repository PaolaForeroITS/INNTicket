Public Class frmTicketDB

    Dim imgBlank As System.Drawing.Image
    Dim imgAttach As System.Drawing.Image

    Public sUsername As String
    Public bReloadGrid As Boolean = False

    Dim bPermitCancelTicket As Boolean = True
    Dim bPermitReopenTicket As Boolean = True

    Dim util As New clsUtils

#Region "Default Methods"

    Private Sub frmTicketDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '--Image Attach
        imgBlank = Image.FromFile("C:\SESTicket\app\Image\blank.bmp")
        imgAttach = Image.FromFile("C:\SESTicket\app\Image\attachicon.bmp")

        util.DateTimePickerFormat(dtpServiceDateBegin)
        util.DateTimePickerFormat(dtpServiceDateEnd)

        dtpServiceDateBegin.Value = DateSerial(Year(Now), 1, 1)
        dtpServiceDateEnd.Value = DateSerial(Year(Now), 12, 1)

        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.cbxSite' table. You can move, or remove it, as needed.
        Me.CbxSiteTableAdapter.Fill(Me.SESTicketAccessDataSet.cbxSite)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.cbxCustomer' table. You can move, or remove it, as needed.
        Me.CbxCustomerTableAdapter.Fill(Me.SESTicketAccessDataSet.cbxCustomer)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.cbxServiceLine' table. You can move, or remove it, as needed.
        Me.CbxServiceLineTableAdapter.Fill(Me.SESTicketAccessDataSet.cbxServiceLine)

        dtpServiceDateBegin.Value = DateSerial(Year(Now), 1, 1)
        dtpServiceDateEnd.Value = DateSerial(Year(Now), 12, 1)

        LoadTickets()

        'User Grants
        FormUserGrant()

    End Sub

    Private Sub LoadTickets()
        Try

            Me.Cursor = Cursors.WaitCursor

            Dim sTicketStatus As String = ""

            If chkCanceled.Checked = True Then
                sTicketStatus = "Canceled"
            End If

            If chkClosed.Checked = True Then
                If sTicketStatus <> "" Then
                    sTicketStatus = sTicketStatus & ","
                End If
                sTicketStatus = sTicketStatus & "Closed"
            End If

            If chkOpen.Checked = True Then
                If sTicketStatus <> "" Then
                    sTicketStatus = sTicketStatus & ","
                End If
                sTicketStatus = sTicketStatus & "Open"
            End If

            Dim sTicketId As String
            Dim sProformaVal As String

            If cbxTicket.Text = "Ticket ID" Then
                sTicketId = txtTicketId.Text
                sProformaVal = ""
            Else
                sTicketId = ""
                sProformaVal = txtTicketId.Text
            End If

            Me.Sp_TicketDBTableAdapter1.Fill(Me.SESTicketSQLDataSet.sp_TicketDB, sUsername, dtpServiceDateBegin.Value, dtpServiceDateEnd.Value, sTicketId, sProformaVal, sTicketStatus, cbxServiceLine.SelectedValue.ToString, cbxCustomer.SelectedValue.ToString, cbxSite.SelectedValue.ToString)

            ForeColorGrid()

            Me.Cursor = Cursors.Arrow

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadTickets()
    End Sub

    Private Sub ForeColorGrid()
        For l As Integer = 0 To Me.dgvTicket.RowCount - 1
            If dgvTicket.Rows(l).Cells("colTicketStatus").Value = "Canceled" Then
                Me.dgvTicket.Rows(l).Cells("colTicketStatus").Style.ForeColor = Color.Red
            ElseIf dgvTicket.Rows(l).Cells("colTicketStatus").Value = "Closed" Then
                Me.dgvTicket.Rows(l).Cells("colTicketStatus").Style.ForeColor = Color.Blue
            ElseIf dgvTicket.Rows(l).Cells("colTicketStatus").Value = "Open" Then
                Me.dgvTicket.Rows(l).Cells("colTicketStatus").Style.ForeColor = Color.DarkGreen
            End If

            If Me.dgvTicket.Rows(l).Cells("colItemAmount").Value < 0 Then
                Me.dgvTicket.Rows(l).Cells("colItemAmount").Style.ForeColor = Color.Red
            Else
                Me.dgvTicket.Rows(l).Cells("colItemAmount").Style.ForeColor = Color.Blue
            End If

            If dgvTicket.Rows(l).Cells("colHasAttach").Value > 0 Then
                dgvTicket.Rows(l).Cells("colAttach").Value = imgAttach
            Else
                dgvTicket.Rows(l).Cells("colAttach").Value = imgBlank
            End If

        Next
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

#End Region

#Region "Context Menu"

    Private Sub dgvTicket_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTicket.CellContentClick

    End Sub

    Private Sub cmnuImportTicket_Click(sender As Object, e As EventArgs) Handles cmnuImportTicket.Click
        Dim frm As New frmImportTicket
        With frm
            .sUsername = Me.sUsername
            .LoadGrid(dgvTicket)
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
            .LoadGrid(dgvTicket)
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
            .LoadGrid(dgvTicket)
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

    Private Sub mnuCloseTickets_Click(sender As Object, e As EventArgs) Handles mnuCloseTickets.Click
        Dim frm As New frmCloseTicketDB
        With frm
            .sUsername = Me.sUsername
            .LoadGrid(dgvTicket, "SQL")
            .bIsSQLConnect = True
            .ShowDialog()
        End With

        If frm.bReloadGrid = True Then
            If Me.bReloadGrid = False Then
                Me.bReloadGrid = True
            End If
            LoadTickets()
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

        sql = "SELECT obj.OBJECTNAME, obj.OBJECTTYPE,usr.ENABLE " &
              "FROM OBJECTGROUPITEMUSER usr, OBJECTGROUPITEM obj " &
              "WHERE usr.OBJECTGROUPITEMID = obj.OBJECTGROUPITEMID " &
              "and usr.ENABLE = 'NO'  " &
              "and obj.OBJECTFORM = 'frmTicketDB' " &
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
                ElseIf sObject = "bPermitCloseTicket" Then
                    mnuCloseTickets.Visible = False
                    cmnuSep00.Visible = False
                ElseIf sObject = "bShowServiceTicketARG" Then
                    If ds.Tables(0).Rows(i)("ENABLE") = "YES" Then
                        dgvTicket.Columns("colServiceTicket").Visible = True
                        dgvTicket.Columns("colSuperiorSupervisor").Visible = True
                        cbxTicket.Visible = True
                        cbxTicket.Text = "Ticket ID"
                        lblTicketID.Visible = False
                    Else
                        dgvTicket.Columns("colServiceTicket").Visible = False
                        dgvTicket.Columns("colSuperiorSupervisor").Visible = False
                        cbxTicket.Visible = False
                        cbxTicket.Text = "Ticket ID"
                        lblTicketID.Visible = True
                    End If
                End If

            Next

        End If

        ds.Dispose()
        ds = Nothing

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub dgvTicket_Sorted(sender As Object, e As EventArgs) Handles dgvTicket.Sorted
        ForeColorGrid()
    End Sub

    Private Sub mnuChangeSupSupervisor_Click(sender As Object, e As EventArgs) Handles mnuChangeSupSupervisor.Click
        Dim frm As New frmChangeSupSupervisor
        With frm
            .sUsername = Me.sUsername
            .LoadGrid(dgvTicket, "SQL")
            .bIsSQLConnect = True
            .ShowDialog()
        End With

        If frm.bReloadGrid = True Then
            If Me.bReloadGrid = False Then
                Me.bReloadGrid = True
            End If
            LoadTickets()
        End If
        frm.Dispose()
        frm = Nothing
    End Sub



#End Region

End Class