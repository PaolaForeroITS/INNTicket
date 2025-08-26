Public Class frmTicketInvConsumptionLetterLandscape
    Public sTicketId As String = ""

    Private Sub rptTicketInvConsumptionLetterLandscape_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        Me.Text = "SESTicket - Inventory Consumption - Ticket: " & sTicketId

        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.REPORTHEADER_V' table. You can move, or remove it, as needed.
        Me.REPORTHEADER_VTableAdapter.Fill(Me.SESTicketAccessDataSet.REPORTHEADER_V)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.REPORTINVLINE_V' table. You can move, or remove it, as needed.
        Me.REPORTINVLINE_VTableAdapter.Fill(Me.SESTicketAccessDataSet.REPORTINVLINE_V)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.REPORTPARAM' table. You can move, or remove it, as needed.
        Me.REPORTPARAMTableAdapter.Fill(Me.SESTicketAccessDataSet.REPORTPARAM)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.REPORTPARAM' table. You can move, or remove it, as needed.
        Me.TICKETINVADICTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETINVADIC)

        Me.Cursor = Cursors.Arrow

        LoadReport()



    End Sub

    Private Sub LoadReport()

        If IsNothing(cbxRepParam.SelectedValue) Then
            Exit Sub
        End If

        Dim sFilter As String

        sFilter = "TICKETID='" & sTicketId & "'"
        REPORTHEADER_VBindingSource.Filter = sFilter
        REPORTINVLINE_VBindingSource.Filter = sFilter
        TICKETINVADICBindingSource.Filter = sFilter
        REPORTPARAMBindingSource.Filter = "REPORTPARAMID=" & cbxRepParam.SelectedValue.ToString & ""

        ReportViewer1.LocalReport.EnableExternalImages = True

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub cbxRepParam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxRepParam.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxRepParam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRepParam.SelectedIndexChanged
        LoadReport()
    End Sub
End Class