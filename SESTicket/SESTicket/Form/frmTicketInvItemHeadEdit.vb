Public Class frmTicketInvItemHeadEdit

    Dim util As New clsUtils
    Public sUsername As String
    Public sTicketInvHeadId As String
    Public sTicketId As String
    Public bUpdated As Boolean = False
    Public bTicketReadOnly As Boolean = False

    Private Sub frmTicketInvItemHeadEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bTicketReadOnly = True Then
            mnuSave.Enabled = False
        End If
    End Sub

    Private Sub txtDespatched_TextChanged(sender As Object, e As EventArgs) Handles txtDespatched.TextChanged
        util.TextBoxMoeda(txtDespatched)
        CalcReturned()
    End Sub

    Private Sub txtConsumption_TextChanged(sender As Object, e As EventArgs) Handles txtConsumption.TextChanged
        util.TextBoxMoeda(txtConsumption)
    End Sub

    Private Sub txtReturned_TextChanged(sender As Object, e As EventArgs) Handles txtReturned.TextChanged
        util.TextBoxMoeda(txtReturned)
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        Me.Cursor = Cursors.WaitCursor

        Dim bdconn As New clsBancoDadosACCESS()
        Dim sql As String
        Dim ds As New DataSet

        bdconn.OpenConnection()


        sql = "UPDATE [TICKETINVHEADER] SET " &
            " [LOTE]            = " & util.SQLConvStrNull(txtLote.Text, "s") & " " &
            ",[DESPATCHED]      = " & util.SQLConvStrNull(txtDespatched.Text, "n") & " " &
            ",[CONSUMPTION]     = " & util.SQLConvStrNull(txtConsumption.Text, "n") & " " &
            ",[RETURNED]        = " & util.SQLConvStrNull(txtReturned.Text, "n") & " " &
            ",[COMMENTS]        = " & util.SQLConvStrNull(txtComments.Text, "s") & " " &
            ",[UPDATEDDATETIME] = " & util.GetDateTime() & " " &
            ",[UPDATEDUSER]     = " & util.SQLConvStrNull(sUsername, "s") & " " &
            "WHERE [TICKETINVHEADERID] = '" & sTicketInvHeadId & "'"

        bdconn.ExecuteNonSQL(sql)


        bdconn.CloseConnection()
        bdconn.Dispose()
        ds.Dispose()
        bdconn = Nothing
        ds = Nothing

        bUpdated = True

        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketId, "ACCESS")
        sync.Dispose()
        sync = Nothing

        Me.Cursor = Cursors.Arrow

        Me.Dispose()

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        bUpdated = False
        Me.Dispose()
    End Sub

    Private Sub CalcReturned()

        Dim Dispached As Double = 0
        Dim Comsumption As Double = 0
        Dim Returned As Double = 0

        Dispached = CDbl(IIf(txtDespatched.Text = "", 0, txtDespatched.Text))
        Comsumption = CDbl(IIf(txtConsumption.Text = "", 0, txtConsumption.Text))
        Returned = Dispached - Comsumption

        If Returned < 0 Then
            Returned = 0
        End If

        txtReturned.Text = Returned.ToString("n2")

    End Sub


End Class