
Public Class frmTicketInvItemLineEdit
    Public sTicketId As String
    Public sUsername As String
    Public bTicketReadOnly As Boolean = False
    Public sTicketInvLineId As String = ""
    Public sTicketSalesItemId As String = ""
    Public sInventoryItemId As String = ""
    Public sFormName As String = ""
    Public bUpdated As Boolean = False
    Public sQdeInv As Integer
    Dim util As New clsUtils

    Private Sub frmTicketInvItemLineEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sTicketInvLineId = "" Then
            txtQuantity.Text = 0
            mnuDelete.Visible = False
            sQdeInv = 0
        Else
            If sFormName = "frmTicketInvItemMainEDIT" Then
                btnSearchInvItem.Visible = False
                btnSearchSalesItem.Visible = False
            End If
        End If

        If sFormName = "frmTicketInvItemMainNEW" Or sFormName = "frmTicketInvItemMainEDIT" Then
            grpSalesItem.Location = New Point(12, 180)
            grvInvItem.Location = New Point(12, 45)
        End If

        If bTicketReadOnly = True Then
            mnuSave.Enabled = False
            mnuDelete.Enabled = False
            btnSearchInvItem.Visible = False
            btnSearchSalesItem.Visible = False
        End If

    End Sub

    Private Sub btnSearchInvItem_Click(sender As Object, e As EventArgs) Handles btnSearchInvItem.Click

        Dim SearchInvItem As New frmSearchInvItem

        With SearchInvItem
            .ShowDialog()
        End With

        If SearchInvItem.InventoryItemId <> "" Then
            sInventoryItemId = SearchInvItem.InventoryItemId
            txtInvItemId.Text = SearchInvItem.InventoryItemId
            txtDescrip.Text = SearchInvItem.Description
            txtUnit.Text = SearchInvItem.StorageUnit
            txtAbbrev.Text = SearchInvItem.Abbreviation
        End If
        SearchInvItem.Dispose()
        SearchInvItem = Nothing

    End Sub

    Private Sub btnSearchSalesItem_Click(sender As Object, e As EventArgs) Handles btnSearchSalesItem.Click

        Dim SearchSalesItem As New frmSearchTicketSalesItem

        With SearchSalesItem
            .sTicketId = Me.sTicketId
            .ShowDialog()
        End With

        If SearchSalesItem.sTicketSalesItemId <> "" Then
            sTicketSalesItemId = SearchSalesItem.sTicketSalesItemId
            txtCustCodeItem.Text = SearchSalesItem.sCustCodeItem
            txtSalesItemDescrip.Text = SearchSalesItem.sDescription
        End If
        SearchSalesItem.Dispose()
        SearchSalesItem = Nothing

    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        util.TextBoxMoeda(txtQuantity)
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        If sTicketSalesItemId = "" Then
            MsgBox("Choose the Sales Item", vbInformation)
            Exit Sub
        End If

        If sInventoryItemId = "" Then
            MsgBox("Choose the Inventory Item", vbInformation)
            Exit Sub
        End If

        If txtQuantity.Text = "0.00" Then
            MsgBox("The Quantity cannot be zero", vbInformation)
            Exit Sub
        End If

        '--Checking if Header is already created.
        Me.Cursor = Cursors.WaitCursor

        Dim sTicketInvHeaderId As String

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconn.OpenConnection()

        sql = "SELECT TICKETINVHEADERID FROM [TICKETINVHEADER] " &
              "WHERE TICKETID = '" & sTicketId & "' AND INVENTORYITEMID = '" & sInventoryItemId & "' "
        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count = 0 Then
            Dim seq As New clsSequenceAccess(Me.sTicketId)
            sTicketInvHeaderId = seq.TicketInvItemHeadNextId
            seq.Dispose()
            seq = Nothing

            sql = "INSERT INTO TICKETINVHEADER (TICKETINVHEADERID,TICKETID,INVENTORYITEMID," &
                "DESCRIPTION,CREATEDUSER,CREATEDDATETIME) VALUES (" &
                "'" & sTicketInvHeaderId & "'," &
                "'" & sTicketId & "'," &
                "'" & sInventoryItemId & "'," &
                "" & util.SQLConvStrNull(txtDescrip.Text, "s") & "," &
                "'" & sUsername & "'," & util.GetDateTime() & ")"
            bdconn.ExecuteNonSQL(sql)

        Else
            sTicketInvHeaderId = ds.Tables(0).Rows(0)("TICKETINVHEADERID").ToString()
        End If
        ds.Dispose()
        ds = Nothing

        '--Verifing if the item is already in use
        ds = New DataSet

        sql = "SELECT TICKETINVLINEID  " &
              "FROM TICKETINVLINE WHERE TICKETSALESITEMID = '" & sTicketSalesItemId & "' " &
              "AND TICKETINVHEADERID = '" & sTicketInvHeaderId & "' "
        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            sTicketInvLineId = ds.Tables(0).Rows(0)("TICKETINVLINEID").ToString()
        End If
        ds.Dispose()
        ds = Nothing

        If sTicketInvLineId = "" Then

            Dim seq As New clsSequenceAccess(Me.sTicketId)
            sTicketInvLineId = seq.TicketInvItemLineNextId
            seq.Dispose()
            seq = Nothing

            sql = "INSERT INTO TICKETINVLINE (TICKETINVLINEID,TICKETINVHEADERID,TICKETSALESITEMID, " &
                "ITEMQTY,CREATEDUSER,CREATEDDATETIME) VALUES (" &
                "'" & sTicketInvLineId & "'," &
                "'" & sTicketInvHeaderId & "'," &
                "'" & sTicketSalesItemId & "'," &
                "" & util.SQLConvStrNull(txtQuantity.Text, "n") & "," &
                "'" & sUsername & "'," & util.GetDateTime() & ")"
            bdconn.ExecuteNonSQL(sql)

        Else

            sql = "UPDATE TICKETINVLINE SET " &
                "ITEMQTY = " & util.SQLConvStrNull(txtQuantity.Text, "n") & " " &
                ",UPDATEDDATETIME = " & util.GetDateTime() & " " &
                ",CREATEDUSER = '" & sUsername & "' " &
                "WHERE TICKETINVLINEID = '" & sTicketInvLineId & "' "
            bdconn.ExecuteNonSQL(sql)

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        bUpdated = True

        sQdeInv = 1

        'Refresh Header values
        RefreshHead(sTicketInvHeaderId)


        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketId, "ACCESS")
        sync.Dispose()
        sync = Nothing

        Me.Cursor = Cursors.Arrow

        Me.Dispose()

    End Sub

    Private Sub RefreshHead(ByVal sTicketInvHeaderId As String)

        Dim qde As Double = 0

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconn.OpenConnection()

        sql = "SELECT SUM(ITEMQTY) as QDE " &
            "FROM TICKETINVLINE " &
            "WHERE TICKETINVHEADERID = '" & sTicketInvHeaderId & "'"
        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            qde = util.TrataDBNull(ds.Tables(0).Rows(0)("QDE"))
        End If
        ds.Dispose()
        ds = Nothing

        If qde > 0 Then
            sql = "UPDATE TICKETINVHEADER SET " &
            "CONSUMPTION = " & util.SQLConvStrNull(qde, "n") & " " &
            ",RETURNED = DESPATCHED - " & util.SQLConvStrNull(qde, "n") & " " &
            "WHERE TICKETINVHEADERID = '" & sTicketInvHeaderId & "' "
            bdconn.ExecuteNonSQL(sql)

            sql = "UPDATE TICKETINVHEADER SET RETURNED = 0 " &
            "WHERE TICKETINVHEADERID = '" & sTicketInvHeaderId & "' AND  RETURNED < 0 "
            bdconn.ExecuteNonSQL(sql)

        Else
            sql = "DELETE FROM TICKETINVHEADER WHERE TICKETINVHEADERID = '" & sTicketInvHeaderId & "'"
            bdconn.ExecuteNonSQL(sql)
        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

    End Sub

    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click

        If MsgBox("Do you delete this item? The Action is irreversible. Continue?", vbYesNo) = vbNo Then
            Exit Sub
        End If


        '--Checking if Header is already created.
        Me.Cursor = Cursors.WaitCursor

        Dim sTicketInvHeaderId As String

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconn.OpenConnection()

        sql = "SELECT TICKETINVHEADERID FROM [TICKETINVHEADER] " &
              "WHERE TICKETID = '" & sTicketId & "' AND INVENTORYITEMID = '" & sInventoryItemId & "' "
        bdconn.ExecuteSQL(sql, ds)

        sTicketInvHeaderId = ds.Tables(0).Rows(0)("TICKETINVHEADERID").ToString()

        ds.Dispose()
        ds = Nothing

        sql = "DELETE FROM TICKETINVLINE WHERE TICKETINVLINEID = '" & sTicketInvLineId & "' "
        bdconn.ExecuteNonSQL(sql)

        ds = New DataSet

        sql = "SELECT COUNT(*) AS QDE FROM [TICKETINVHEADER] " &
              "WHERE TICKETID = '" & sTicketId & "'"
        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows(0)("QDE") = 0 Then
            sQdeInv = 0
            sql = "UPDATE TICKET SET NOINVITEM=0 WHERE TICKETID='" & sTicketId & "'"
            bdconn.ExecuteNonSQL(sql)
        Else
            sQdeInv = 1
        End If
        ds.Dispose()
        ds = Nothing

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        bUpdated = True

        'Refresh Header values
        RefreshHead(sTicketInvHeaderId)

        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketId, "ACCESS")
        sync.Dispose()
        sync = Nothing

        Me.Cursor = Cursors.Arrow

        Me.Dispose()

    End Sub
End Class