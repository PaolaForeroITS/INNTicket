Public Class frmSearchTicketSalesItem

    Public sTicketId As String = ""
    Public sTicketSalesItemId As String = ""
    Public sCustCodeItem As String = ""
    Public sDescription As String = ""

    Private Sub frmSearchTicketSalesItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim n As Integer
        n = 0
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.SALESITEM_V' table. You can move, or remove it, as needed.
        Me.SALESITEM_VTableAdapter.Fill(Me.SESTicketAccessDataSet.SALESITEM_V)
        n = 0
        ResetSearch()
    End Sub

    Private Sub ResetSearch()
        SALESITEMVBindingSource.Filter = "TICKETID = '" & sTicketId & "' "
        dgvSalesItem.Refresh()
    End Sub

    Private Sub SearchItem()
        Dim sField As String = ""
        Dim sFilter As String = ""

        If cbxSearch.Text = "Item" Then
            sField = "CUSTCODEITEM"
        ElseIf cbxSearch.Text = "Description" Then
            sField = "DESCRIPTION"
        End If

        sFilter = "TICKETID = '" & sTicketId & "' " & sFilter & " AND " & sField & " LIKE '%" & txtSearch.Text & "%' "
        SALESITEMVBindingSource.Filter = sFilter
        dgvSalesItem.Refresh()

    End Sub

    Private Sub cbxSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxSearch.KeyPress
        e.Handled = True
    End Sub
    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchItem()
        End If
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetSearch()
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchItem()
    End Sub

    Private Sub dgvSalesItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesItem.CellContentClick

    End Sub

    Private Sub dgvSalesItem_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSalesItem.CellFormatting
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

    Private Sub dgvSalesItem_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesItem.CellDoubleClick
        If dgvSalesItem.RowCount > 0 Then
            Dim util As New clsUtils

            sTicketSalesItemId = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSITicketSalesItemId").Value)
            sCustCodeItem = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSICustCodeItem").Value)
            sDescription = util.TrataDBNull(dgvSalesItem.CurrentRow.Cells("colSIDescription").Value)
            util.Dispose()
            util = Nothing

            Me.Dispose()

        End If
    End Sub
End Class