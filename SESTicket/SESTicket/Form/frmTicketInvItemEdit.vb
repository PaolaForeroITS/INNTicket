Imports System

Public Class frmTicketInvItemEdit

    Public sTicketSalesItemId As String
    Public sContractPriceListId As String
    Public sTicketInventoryId As String
    Public sUsername As String

    Public sTicketId As String

    Dim util As New clsUtils

    Private Sub btnSearch_Click_1(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim frm As New frmSearchInvItem
        With frm
            .sContractPriceListId = Me.sContractPriceListId
            .ShowDialog()
        End With

        If frm.InventoryItemId <> "" Then
            txtInventoryItemId.Text = frm.InventoryItemId
            txtDescription.Text = frm.Description
            txtUnit.Text = frm.StorageUnit
            txtAbbrev.Text = frm.Abbreviation
        End If
        frm.Dispose()
        frm = Nothing

    End Sub

    Private Sub frmTicketInvItemEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sTicketInventoryId = "" Then
            txtQuantity.Text = 0
            btnCancelDelete.Text = "Cancel"
        Else
            txtDescription.Enabled = False
            btnCancelDelete.Text = "Delete"
        End If
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs)
        util.TextBoxMoeda(txtQuantity)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtQuantity.Text = "" Then
            MsgBox("Inform Quantity", vbExclamation)
            Exit Sub

        Else
            If CDbl(txtQuantity.Text.Replace(",", "")) <= 0 Then
                MsgBox("The Quantitity must be increase of zero", vbExclamation)
                Exit Sub
            End If
        End If

        Dim bdconnAccess As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconnAccess.OpenConnection()

        If sTicketInventoryId = "" Then

            sql = "SELECT 1 FROM TICKETINVENTORY WHERE TICKETSALESITEMID= '" & sTicketSalesItemId & "' " & _
                 "AND INVENTORYITEMID = '" & txtInventoryItemId.Text & "' "

            bdconnAccess.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                MsgBox("The Item is already in use.", vbExclamation)
                ds.Dispose()
                bdconnAccess.CloseConnection()
                bdconnAccess.Dispose()
                Exit Sub
            Else
                ds.Dispose()
                ds = Nothing
            End If

            Dim seq As New clsSequenceAccess(sTicketId)

            sql = "INSERT INTO [TICKETINVENTORY] " & _
                "(TICKETINVENTORYID,[TICKETSALESITEMID],[INVENTORYITEMID],[ITEMQTY] " & _
                ",[UNIT],[DESCRIPTION],[CREATEDUSER],[CREATEDDATETIME],[COMMENTS]) VALUES ('"

            sql = sql & seq.TicketInventoryNextId & "','"
            sql = sql & sTicketSalesItemId & "','"
            sql = sql & txtInventoryItemId.Text & "',"
            sql = sql & util.SQLConvStrNull(txtQuantity.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtUnit.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtDescription.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(sUsername, "s") & ","
            sql = sql & "" & util.GetDateTime() & ","
            sql = sql & util.SQLConvStrNull(txtComments.Text, "s") & ")"

            bdconnAccess.ExecuteNonSQL(sql)

            seq.Dispose()
            seq = Nothing

        Else

            sql = "UPDATE [TICKETINVENTORY] SET " &
                  " [ITEMQTY] = " & util.SQLConvStrNull(txtQuantity.Text, "n") & " " &
                  ",[UPDATEDDATETIME] = " & util.GetDateTime() & " " &
                  ",[UPDATEDUSER] = " & util.SQLConvStrNull(sUsername, "s") & " " &
                  ",[COMMENTS] = " & util.SQLConvStrNull(txtComments.Text, "s") & " " &
                  "WHERE [TICKETINVENTORYID] = '" & sTicketInventoryId & "' "

            bdconnAccess.ExecuteNonSQL(sql)
        End If

        sql = "UPDATE TICKET SET NOINVITEM=0 WHERE TICKETID='" & sTicketId & "'"
        bdconnAccess.ExecuteNonSQL(sql)

        bdconnAccess.CloseConnection()
        bdconnAccess.Dispose()
        bdconnAccess = Nothing

        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketId, "ACCESS")
        sync.Dispose()
        sync = Nothing

        Me.Dispose()

    End Sub

    Private Sub btnCancelDelete_Click(sender As Object, e As EventArgs) Handles btnCancelDelete.Click

        If btnCancelDelete.Text = "Cancel" Then
            Me.Dispose()
        Else
            If MsgBox("Are you want DELETE this item? This action is Irreversivel", MsgBoxStyle.YesNo) = vbYes Then

                Dim bdconnAccess As New clsBancoDadosACCESS
                Dim sql As String

                bdconnAccess.OpenConnection()

                sql = "DELETE FROM [TICKETINVENTORY] " & _
                "WHERE [TICKETINVENTORYID] = '" & sTicketInventoryId & "' "

                bdconnAccess.ExecuteNonSQL(sql)

                sql = "UPDATE TICKET SET NOINVITEM=0 WHERE TICKETID='" & sTicketId & "'"
                bdconnAccess.ExecuteNonSQL(sql)

                bdconnAccess.CloseConnection()
                bdconnAccess.Dispose()
                bdconnAccess = Nothing

                Dim sync As New clsSyncTicket
                sync.UpdateSyncDateTime(sTicketId, "ACCESS")
                sync.Dispose()
                sync = Nothing

                Me.Dispose()

            Else
                Exit Sub
            End If
        End If
    End Sub


End Class