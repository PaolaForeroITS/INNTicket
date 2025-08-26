Public Class frmRPTPacificMetapetroleumLetterPortraitPageBreak
    Public sTicketId As String
    Public sReportParamId As String

    Private Sub frmRPTPacificMetapetroleumLetterPortraitPageBreak_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If IsNothing(sReportParamId) = False Then

            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.REPORTPARAM' table. You can move, or remove it, as needed.
            Me.REPORTPARAMTableAdapter.Fill(Me.SESTicketAccessDataSet.REPORTPARAM)
            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.REPORTHEADER_V' table. You can move, or remove it, as needed.
            Me.REPORTHEADER_VTableAdapter.Fill(Me.SESTicketAccessDataSet.REPORTHEADER_V)
            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.REPORTLINE_V' table. You can move, or remove it, as needed.
            Me.REPORTLINE_VTableAdapter.Fill(Me.SESTicketAccessDataSet.REPORTLINE_V)

            Dim sFilter As String

            sFilter = "TICKETID='" & sTicketId & "'"
            REPORTHEADER_VBindingSource.Filter = sFilter
            REPORTLINE_VBindingSource.Filter = sFilter
            REPORTPARAMBindingSource.Filter = "REPORTPARAMID=" & sReportParamId & ""

            Me.ReportViewer1.RefreshReport()
        End If


    End Sub
End Class