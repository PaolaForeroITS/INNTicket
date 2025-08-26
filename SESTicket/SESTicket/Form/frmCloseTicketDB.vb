Public Class frmCloseTicketDB

    Public sUsername As String
    Public bReloadGrid As Boolean = False
    Public sSource As String
    Dim grd As DataGridView

    Public bIsSQLConnect As Boolean

    Public Sub LoadGrid(ByRef grd1 As DataGridView, Optional Source As String = "")
        grd = grd1
        sSource = Source
    End Sub


    Private Sub frmCloseTicketDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If grd.SelectedRows.Count = 0 Then
            MsgBox("Select Item", vbInformation)
            Me.Dispose()
            Exit Sub
        End If

        '--Form Grant
        FormUserGrant()

        Dim sOrigin As String = IIf(sSource = "SQL", "zSQL_", "")

        Me.Cursor = Cursors.WaitCursor

        Dim nCount As Integer = 0

        Dim sql As String
        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection()


        sql = "DELETE FROM TMP_TICKETCLOSE"
        bdconn.ExecuteNonSQL(sql)

        For Each row As DataGridViewRow In grd.SelectedRows
            If row.Cells("colTicketStatus").Value = "Open" Then
                nCount = 1

                sql = "INSERT INTO TMP_TICKETCLOSE ( TICKETID, SUPERIORNUM, HASINVENTORY, HASSERVICETYPE ) " &
                    "SELECT TICKETID, SUPERIORNUM, HASINVENTORY, HASSERVICETYPE " &
                    "FROM " & sOrigin & "TICKETCLOSE_V " &
                    "WHERE TICKETID = '" & row.Cells("colTicketId").Value & "'"
                bdconn.ExecuteNonSQL(sql)

            End If
        Next

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        LoadGrid()

        Me.Cursor = Cursors.Arrow

        If nCount = 0 Then
            MsgBox("The Tickets are not in Open Status", vbInformation)
            Me.Dispose()
            Exit Sub
        End If

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub

    Private Sub LoadGrid()
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TMP_TICKETCLOSE' table. You can move, or remove it, as needed.
        Me.TMP_TICKETCLOSETableAdapter.Fill(Me.SESTicketAccessDataSet.TMP_TICKETCLOSE)
    End Sub

    Private Sub mnuCloseTicket_Click(sender As Object, e As EventArgs) Handles mnuCloseTicket.Click

        If MsgBox("The Ticket will be close and Sync with Server. After that no more changes are allowed. Do you want continue?", vbYesNo) = vbNo Then
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor

        Dim sTicketId As String
        Dim bCloseTicket As String
        Dim bSyncTicket As Boolean

        Dim sResult As String = ""

        For i As Integer = 0 To Me.dgvTicketClose.RowCount - 1
            sTicketId = dgvTicketClose.Rows(i).Cells("colTicketId").Value

            If dgvTicketClose.Rows(i).Cells("colHasServiceType").Value = "NO" Then
                bCloseTicket = False
                UpdateResultStatus(sTicketId, "Canceled: The Ticket without ServiceType")

            ElseIf chkTicketNoInventory.Checked = False And dgvTicketClose.Rows(i).Cells("colHasInvItem").Value = "NO" Then
                bCloseTicket = False
                UpdateResultStatus(sTicketId, "Canceled: The Inventory Item should be informed")

            ElseIf chkTicketNoInventory.Checked = True And dgvTicketClose.Rows(i).Cells("colHasInvItem").Value = "NO" Then
                bCloseTicket = True
                TicketWithNoInvItem(sTicketId)
            Else
                bCloseTicket = True
            End If

            If bCloseTicket = True Then

                If bSyncTicket = False Then
                    bSyncTicket = True
                End If

                Dim sync As New clsSyncTicket
                sync.sUsername = Me.sUsername
                sync.CloseTicket(sTicketId, sSource)
                sync.Dispose()
                sync = Nothing

                UpdateResultStatus(sTicketId, "Ok: Ticket Closed")

                bReloadGrid = True

            End If

        Next

        LoadGrid()

        Me.Cursor = Cursors.Arrow

        If bIsSQLConnect = True And bSyncTicket = True Then
            Dim frm As New frmSyncTicket
            frm.sUsername = Me.sUsername
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing
        ElseIf bSyncTicket = True Then
            MsgBox("The server is offline. The Ticket will be synchronize when the server is online again.")
        End If

    End Sub

    Private Sub TicketWithNoInvItem(ByVal sTicketId As String)
        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String

        bdconn.OpenConnection()

        Me.Cursor = Cursors.WaitCursor

        sql = "UPDATE TICKET SET " &
              "NOINVITEM    = 1 " &
              "WHERE TICKETID = '" & sTicketId & "'"
        bdconn.ExecuteNonSQL(sql)

        sql = "DELETE FROM TICKETINVLINE WHERE TICKETINVHEADERID IN " &
              "(SELECT TICKETINVHEADERID FROM TICKETINVHEADER WHERE TICKETID='" & sTicketId & "') "
        bdconn.ExecuteNonSQL(sql)

        sql = "DELETE FROM TICKETINVHEADER WHERE TICKETID='" & sTicketId & "' "
        bdconn.ExecuteNonSQL(sql)


        If sSource = "SQL" Then

            sql = "UPDATE zSQL_TICKET SET " &
                  "NOINVITEM    = 1 " &
                  "WHERE TICKETID = '" & sTicketId & "'"
            bdconn.ExecuteNonSQL(sql)

            sql = "DELETE FROM zSQL_TICKETINVLINE WHERE TICKETINVHEADERID IN " &
                  "(SELECT TICKETINVHEADERID FROM zSQL_TICKETINVHEADER WHERE TICKETID='" & sTicketId & "') "
            bdconn.ExecuteNonSQL(sql)

            sql = "DELETE FROM zSQL_TICKETINVHEADER WHERE TICKETID='" & sTicketId & "' "
            bdconn.ExecuteNonSQL(sql)

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub UpdateResultStatus(ByVal sTicketId As String, ByVal sResult As String)
        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String

        bdconn.OpenConnection()

        Me.Cursor = Cursors.WaitCursor

        sql = "UPDATE TMP_TICKETCLOSE SET " &
              "RESULT    = '" & sResult & "' " &
              "WHERE TICKETID = '" & sTicketId & "'"
        bdconn.ExecuteNonSQL(sql)

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Me.Cursor = Cursors.Arrow

    End Sub

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
              "and obj.OBJECTFORM = 'frmTicket' " &
              "and obj.OBJECTNAME = 'bShowServiceTicketARG' " &
              "and usr.USERNAME = '" & Me.sUsername & "' "

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim sObject As String = ""

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                sObject = ds.Tables(0).Rows(i)("OBJECTNAME")

                If sObject = "bShowServiceTicketARG" Then
                    If ds.Tables(0).Rows(i)("ENABLE") = "YES" Then
                        dgvTicketClose.Columns("colServiceTicket").Visible = True
                    Else
                        dgvTicketClose.Columns("colServiceTicket").Visible = False
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