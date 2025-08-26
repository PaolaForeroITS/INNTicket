Public Class frmRPTDocxActStartFinish

    Public sTicketId As String

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub

    Private Sub cbxActaType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxActaType.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Me.Cursor = Cursors.WaitCursor

        Dim sReport As String

        If cbxActaType.Text = "Inicio" Then
            sReport = "ActStart"
        Else
            sReport = "ActFinish"
        End If

        Dim cls As New clsRPTDocx
        cls.ActStartFinishOpe(sReport, sTicketId)
        cls.Dispose()

        Me.Cursor = Cursors.Arrow

    End Sub
End Class