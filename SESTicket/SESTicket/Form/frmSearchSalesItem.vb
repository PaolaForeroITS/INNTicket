
Public Class frmSearchSalesItem

    Public sContract As String

    Dim sFilter As String

    Dim _ContractPriceList As String
    Dim _CustCodeItem As String
    Dim _Description As String
    Dim _SalesPrice As String
    Dim _UnitSale As String
    Dim _TabGroup As String

    Public nPriceUnitDecimal As Integer = 2

    Private Sub frmSearchSalesItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Init()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchItem()
    End Sub

    Public Property ContractPriceList() As String
        Get
            Return _ContractPriceList
        End Get
        Set(ByVal Value As String)
            _ContractPriceList = Value
        End Set
    End Property

    Public Property CustCodeItem() As String
        Get
            Return _CustCodeItem
        End Get
        Set(ByVal Value As String)
            _CustCodeItem = Value
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

    Public Property SalesPrice() As String
        Get
            Return _SalesPrice
        End Get
        Set(ByVal Value As String)
            _SalesPrice = Value
        End Set
    End Property

    Public Property UnitSale() As String
        Get
            Return _UnitSale
        End Get
        Set(ByVal Value As String)
            _UnitSale = Value
        End Set
    End Property

    Public Property TabGroup() As String
        Get
            Return _TabGroup
        End Get
        Set(ByVal Value As String)
            _TabGroup = Value
        End Set
    End Property


    Private Sub dgvSalesItemSearch_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesItemSearch.CellDoubleClick

        If dgvSalesItemSearch.RowCount > 0 Then
            If dgvSalesItemSearch.CurrentRow.Cells("colIsHeader").Value.ToString = "YES" Then
                MsgBox("This item is a Header. Choose another one", vbExclamation)
                Exit Sub
            End If

            Dim util As New clsUtils

            _ContractPriceList = dgvSalesItemSearch.CurrentRow.Cells("colContractPriceList").Value
            _CustCodeItem = dgvSalesItemSearch.CurrentRow.Cells("colCustCodeItem").Value
            _Description = util.TrataDBNull(dgvSalesItemSearch.CurrentRow.Cells("colDescription").Value)
            _SalesPrice = util.TrataDBNull(dgvSalesItemSearch.CurrentRow.Cells("colSalesPrice").Value)
            _UnitSale = util.TrataDBNull(dgvSalesItemSearch.CurrentRow.Cells("colUnitSale").Value)
            _TabGroup = util.TrataDBNull(dgvSalesItemSearch.CurrentRow.Cells("colTabGroup").Value)
            nPriceUnitDecimal = util.TrataDBNull(dgvSalesItemSearch.CurrentRow.Cells("colPriceUnitDecimal").Value)

            Me.Dispose()
        End If
    End Sub

    Private Sub ChangeColorGrid()
        For i = 0 To dgvSalesItemSearch.Rows.Count - 1
            If dgvSalesItemSearch.Rows(i).Cells("colIsHeader").Value = "YES" Then
                dgvSalesItemSearch.Rows(i).DefaultCellStyle.BackColor = Color.LightGray
            End If
            If dgvSalesItemSearch.Rows(i).Cells("colType").Value = "Material" Then
                With dgvSalesItemSearch.Rows(i)
                    .DefaultCellStyle.ForeColor = Color.DarkGreen
                End With
            ElseIf dgvSalesItemSearch.Rows(i).Cells("colType").Value = "Service" Then
                With dgvSalesItemSearch.Rows(i)
                    .DefaultCellStyle.ForeColor = Color.Blue
                End With
            End If

            If Me.dgvSalesItemSearch.Rows(i).Cells("colSalesPrice").Value < 0 Then
                Me.dgvSalesItemSearch.Rows(i).Cells("colSalesPrice").Style.ForeColor = Color.FromArgb(192, 0, 0)
            End If
        Next
    End Sub

    Private Sub cbxSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxSearch.KeyPress
        e.Handled = True
    End Sub

    Private Sub Init()

        chkMaterial.Checked = True
        chkService.Checked = True

        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.CONTRACTPRICELISTTMP' table. You can move, or remove it, as needed.
        Me.CONTRACTPRICELISTTMPTableAdapter.Fill(Me.SESTicketAccessDataSet.CONTRACTPRICELISTTMP)

        dgvSalesItemSearch.Refresh()
        ChangeColorGrid()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Init()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchItem()
        End If

    End Sub

    Private Sub SearchItem()

        If sContract <> "" Then

            Dim sField As String = ""

            If cbxSearch.Text = "Group" Then
                sField = "TABGROUP"
            ElseIf cbxSearch.Text = "Item" Then
                sField = "CUSTCODEITEM"
            ElseIf cbxSearch.Text = "Description" Then
                sField = "DESCRIPTION"
            End If
            sFilter = "CONTRACTID=" & sContract & " AND " & sField & " LIKE '%" & txtSearch.Text & "%'"

            Dim sType As String = ""

            If chkMaterial.Checked = True Then
                sType = "'Material'"
            End If
            If chkService.Checked = True Then
                If sType <> "" Then
                    sType = "'Material','Service'"
                Else
                    sType = "'Service'"
                End If
            End If
            If chkMaterial.Checked = False And chkService.Checked = False Then
                sType = "AND TYPE IN (1)"
            Else
                sFilter = sFilter & " AND TYPE IN (" & sType & ") "
            End If

            CONTRACTPRICELISTTMPBindingSource.Filter = sFilter
            dgvSalesItemSearch.Refresh()
            ChangeColorGrid()

        End If
    End Sub

    Private Sub chkService_CheckedChanged(sender As Object, e As EventArgs) Handles chkService.CheckedChanged
        SearchItem()
    End Sub

    Private Sub chkMaterial_CheckedChanged(sender As Object, e As EventArgs) Handles chkMaterial.CheckedChanged
        SearchItem()
    End Sub

    Private Sub dgvSalesItemSearch_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSalesItemSearch.CellContentClick

    End Sub
End Class