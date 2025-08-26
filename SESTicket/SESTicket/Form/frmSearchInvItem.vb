Public Class frmSearchInvItem

    Public sContractPriceListId As String
    Dim sFilter As String

    Dim _InventoryItemId As String
    Dim _StorageUnit As String
    Dim _Description As String
    Dim _Abbreviation As String

    Private Sub frmSearchInvItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init()
        ChangeColorGrid()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchItem()
    End Sub
    Private Sub ChangeColorGrid()
        For i = 0 To dgvInvItem.Rows.Count - 1
            With dgvInvItem.Rows(i)
                .DefaultCellStyle.ForeColor = Color.Blue
            End With
        Next
    End Sub

    Public Property InventoryItemId() As String
        Get
            Return _InventoryItemId
        End Get
        Set(ByVal Value As String)
            _InventoryItemId = Value
        End Set
    End Property

    Public Property StorageUnit() As String
        Get
            Return _StorageUnit
        End Get
        Set(ByVal Value As String)
            _StorageUnit = Value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return _Description
        End Get
        Set(ByVal Value As String)
            _Description = Value
        End Set
    End Property

    Public Property Abbreviation() As String
        Get
            Return _Abbreviation
        End Get
        Set(ByVal Value As String)
            _Abbreviation = Value
        End Set
    End Property

    Private Sub dgvInvItem_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvItem.CellDoubleClick
        If dgvInvItem.RowCount > 0 Then

            Dim util As New clsUtils

            _InventoryItemId = dgvInvItem.CurrentRow.Cells("colInventoryItemId").Value
            _StorageUnit = dgvInvItem.CurrentRow.Cells("colStorageUnit").Value
            _Description = util.TrataDBNull(dgvInvItem.CurrentRow.Cells("colDescription").Value)
            _Abbreviation = util.TrataDBNull(dgvInvItem.CurrentRow.Cells("colAbbrev").Value)
            Me.Dispose()
        End If
    End Sub

    Private Sub Init()
        Try
            Dim n As Integer
            n = 0
            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.INVENTORYITEMCONTRACT' table. You can move, or remove it, as needed.
            Me.INVENTORYITEMCONTRACTTableAdapter.Fill(Me.SESTicketAccessDataSet.INVENTORYITEMCONTRACT)
            n = 1
            INVENTORYITEMCONTRACTBindingSource.Filter = ""
            dgvInvItem.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Init()
    End Sub

    Private Sub cbxSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxSearch.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSearch.SelectedIndexChanged

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchItem()
        End If
    End Sub

    Private Sub SearchItem()
        Dim sField As String = ""

        If cbxSearch.Text = "Item" Then
            sField = "INVENTORYITEMID"
        ElseIf cbxSearch.Text = "Description" Then
            sField = "DESCRIPTION"
        ElseIf cbxSearch.Text = "Abbreviation" Then
            sField = "ABBREVIATION"
        End If

        sFilter = sField & " LIKE '%" & txtSearch.Text & "%' "
        INVENTORYITEMCONTRACTBindingSource.Filter = sFilter
        dgvInvItem.Refresh()
        ChangeColorGrid()
    End Sub


    Private Sub dgvInvItem_Sorted(sender As Object, e As EventArgs) Handles dgvInvItem.Sorted
        ChangeColorGrid()
    End Sub
End Class