Public Class frmSESTicketUpd

    Private Sub frmSESTicketUpd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Kill the process
        Dim SESTicketSyncAttach() As Process = Process.GetProcessesByName("SESTicketSyncAttach")
        For Each Process1 As Process In SESTicketSyncAttach
            Process1.Kill()
        Next

        'Kill the process
        Dim SESTicket() As Process = Process.GetProcessesByName("SESTicket")
        For Each Process2 As Process In SESTicket
            Process2.Kill()
        Next

        Me.Show()
        Dim cls As New clsSESTicketUpd()
        cls.Start()
        cls.Dispose()
        cls = Nothing
    End Sub

End Class
