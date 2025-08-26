Public Class frmTicketOpeHourTotal
    Dim util As New clsUtils
    Public sTicketId As String

    Private Sub frmTicketOpeHourTotal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtHourQde.Text = "" Then
            txtHourQde.Text = 0
            txtHourTravel.Text = 0
            txtHourOperation.Text = 0
            txtHourStandby.Text = 0
            txtHourLost.Text = 0
        End If
    End Sub

    Private Sub txtHourQde_TextChanged(sender As Object, e As EventArgs) Handles txtHourQde.TextChanged
        util.TextBoxMoeda(txtHourQde)
    End Sub

    Private Sub txtHourTravel_TextChanged(sender As Object, e As EventArgs) Handles txtHourTravel.TextChanged
        util.TextBoxMoeda(txtHourTravel)
        CalcTotalHours()
    End Sub

    Private Sub txtHourOperation_TextChanged(sender As Object, e As EventArgs) Handles txtHourOperation.TextChanged
        util.TextBoxMoeda(txtHourOperation)
        CalcTotalHours()
    End Sub

    Private Sub txtHourStandby_TextChanged(sender As Object, e As EventArgs) Handles txtHourStandby.TextChanged
        util.TextBoxMoeda(txtHourStandby)
        CalcTotalHours()
    End Sub

    Private Sub txtHourLost_TextChanged(sender As Object, e As EventArgs) Handles txtHourLost.TextChanged
        util.TextBoxMoeda(txtHourLost)
        CalcTotalHours()
    End Sub

    Private Sub txtHourQde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHourQde.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHourTravel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHourTravel.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHourOperation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHourOperation.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHourStandby_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHourStandby.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHourLost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHourLost.KeyPress
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CalcTotalHours()

        Dim HourTravel As Double = 0
        Dim HourOperation As Double = 0
        Dim HourStandby As Double = 0
        Dim HourLost As Double = 0


        If txtHourTravel.Text <> "" Then
            HourTravel = CDbl(txtHourTravel.Text)
        End If
        If txtHourOperation.Text <> "" Then
            HourOperation = CDbl(txtHourOperation.Text)
        End If
        If txtHourStandby.Text <> "" Then
            HourStandby = CDbl(txtHourStandby.Text)
        End If
        If txtHourLost.Text <> "" Then
            HourLost = CDbl(txtHourLost.Text)
        End If

        txtHourQde.Text = util.ConcatDecimalStr(HourTravel + HourOperation + HourStandby + HourLost)

    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        Dim sql As String = ""
        Dim bdconnACCESS As New clsBancoDadosACCESS

        bdconnACCESS.OpenConnection()


        sql = "UPDATE TICKET SET " &
                "HOURQDE = " & util.SQLConvStrNull(txtHourQde.Text, "n") & " " &
                ",HOURTRAVEL = " & util.SQLConvStrNull(txtHourTravel.Text, "n") & " " &
                ",HOUROPERATION = " & util.SQLConvStrNull(txtHourOperation.Text, "n") & " " &
                ",HOURSTANDBY = " & util.SQLConvStrNull(txtHourStandby.Text, "n") & " " &
                ",HOURLOST = " & util.SQLConvStrNull(txtHourLost.Text, "n") & " " &
                "WHERE TICKETID = '" & sTicketId & "'"

        bdconnACCESS.ExecuteNonSQL(sql)
        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(sTicketId, "ACCESS")
        sync.Dispose()
        sync = Nothing

        MsgBox("Done")

        Me.Dispose()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub
End Class