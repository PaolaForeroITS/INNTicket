Public Class frmSearchWorker

    Dim sFilter As String

    Dim _WorkerId As String
    Dim _FullName As String
    Dim _Appointment As String

    Private Sub frmSearchWorker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Init()
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SearchItem()
    End Sub

    Public Property WorkerId() As String
        Get
            Return _WorkerId
        End Get
        Set(ByVal Value As String)
            _WorkerId = Value
        End Set
    End Property

    Public Property FullName() As String
        Get
            Return _FullName
        End Get
        Set(ByVal Value As String)
            _FullName = Value
        End Set
    End Property

    Public Property Appointment() As String
        Get
            Return _Appointment
        End Get
        Set(ByVal Value As String)
            _Appointment = Value
        End Set
    End Property

    Private Sub dgvWorker_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWorker.CellDoubleClick
        If dgvWorker.RowCount > 0 Then
            _WorkerId = dgvWorker.CurrentRow.Cells("colWorkerId").Value
            _FullName = dgvWorker.CurrentRow.Cells("colFullName").Value
            _Appointment = dgvWorker.CurrentRow.Cells("colAppointment").Value
            Me.Dispose()
        End If
    End Sub

    Private Sub Init()
        Try
            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.INVENTORYITEMCONTRACT' table. You can move, or remove it, as needed.
            Me.WORKERTableAdapter.Fill(Me.SESTicketAccessDataSet.WORKER)

            sFilter = "ACTIVE = 'YES' "
            WORKERBindingSource.Filter = sFilter
            dgvWorker.Refresh()
            FormatGrid()

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

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            SearchItem()
        End If
    End Sub

    Private Sub SearchItem()
        Dim sField As String = ""

        If cbxSearch.Text = "Full Name" Then
            sField = "FULLNAME"
        ElseIf cbxSearch.Text = "Appointment" Then
            sField = "APPOINTMENT"
        End If

        sFilter = "ACTIVE='YES' AND " & sField & " LIKE '%" & txtSearch.Text & "%'"
        WORKERBindingSource.Filter = sFilter
        dgvWorker.Refresh()
        FormatGrid()
    End Sub

    Private Sub FormatGrid()
        For l As Integer = 0 To Me.dgvWorker.RowCount - 1
            With dgvWorker.Rows(l)
                .DefaultCellStyle.ForeColor = Color.Blue
            End With
        Next
    End Sub

End Class