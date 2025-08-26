Public Class frmRPTExcel

    Public sTicketId As String
    Public bIsServEval As Boolean = False
    Public dServiceDate As Date
    Public sServiceDesc As String
    Private Sub frmRPTExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmRPTMain.Close()
        Me.BringToFront()

        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.REPORTPARAM' table. You can move, or remove it, as needed.
        Me.REPORTPARAMTableAdapter.Fill(Me.SESTicketAccessDataSet.REPORTPARAM)
        cbxRepParam.Refresh()

    End Sub

    Private Sub cbxExcelLayout_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxExcelLayout.KeyPress
        e.Handled = True
    End Sub
    Private Sub cbxRepParam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxRepParam.KeyPress
        e.Handled = True
    End Sub
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        If bIsServEval = True Then

            Me.Cursor = Cursors.WaitCursor
            Dim cls As New clsRPTXlsx
            cls.GenerateEcopetrolServEval(sTicketId, dServiceDate, sServiceDesc, cbxRepParam.SelectedValue)
            cls.Dispose()

        Else
            If cbxExcelLayout.Text = "" Then
                MsgBox("Select the Excel Layout", vbInformation)
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor



            Dim IsService As Boolean = False
            If InStr(cbxExcelLayout.Text, "Service") > 0 Then
                IsService = True
            End If

            Dim cls As New clsRPTXlsx
            cls.GenerateEcopetrolTicket(sTicketId, cbxRepParam.SelectedValue, IsService)
            cls.Dispose()

        End If

        Me.Cursor = Cursors.Arrow

    End Sub
End Class