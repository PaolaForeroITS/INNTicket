Public Class frmTicketFileLog

    Private Sub frmTicketFileLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETFILELOG' table. You can move, or remove it, as needed.
        Me.TICKETFILELOGTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETFILELOG)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETFILELOG' table. You can move, or remove it, as needed.
        Me.TICKETFILELOGTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETFILELOG)

    End Sub
End Class