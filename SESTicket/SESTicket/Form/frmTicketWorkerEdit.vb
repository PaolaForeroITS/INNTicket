Public Class frmTicketWorkerEdit

    Dim util As New clsUtils

    Public sTicketWorkerId As String
    Public sTicketId As String
    Public sWorkerId As String

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim frm As New frmSearchWorker
        With frm
            .ShowDialog()
        End With

        If frm.WorkerId <> "" Then
            sWorkerId = frm.WorkerId
            txtFullName.Text = frm.FullName
            txtAppointment.Text = frm.Appointment

            'txtHourQde.Text = "0"
            'txtHourTravel.Text = "0"
            'txtHourOperation.Text = "0"
            'txtHourStandby.Text = "0"
            'txtHourLost.Text = "0"

            dtpRegisterDate.Enabled = True
            txtHourTravel.Enabled = True
            txtHourOperation.Enabled = True
            txtHourStandby.Enabled = True
            txtHourLost.Enabled = True
            txtActivityResume.Enabled = True

        Else
            dtpRegisterDate.Enabled = False
            txtHourTravel.Enabled = False
            txtHourOperation.Enabled = False
            txtHourStandby.Enabled = False
            txtHourLost.Enabled = False
        End If

        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtFullName.Text = "" Then
            MsgBox("Choose the Worker", vbExclamation)
            Exit Sub
        End If


        Dim sql As String = ""
        Dim bdconnACCESS As New clsBancoDadosACCESS

        bdconnACCESS.OpenConnection()

        If sTicketWorkerId = "" Then

            Dim seq As New clsSequenceAccess(sTicketId)

            sql = "INSERT INTO TICKETWORKER " &
                  "(TICKETWORKERID,TICKETID,WORKERID " &
                  ",REGISTERDATE,HOURQDE,HOURTRAVEL,HOUROPERATION,HOURSTANDBY,HOURLOST,RESUMEACTIVITY)  VALUES ('"

            sql = sql & seq.TicketWorkerNextId & "','"
            sql = sql & sTicketId & "','"
            sql = sql & sWorkerId & "',"
            sql = sql & "#" & dtpRegisterDate.Value.ToString("yyyy-MM-dd") & "#,"
            sql = sql & util.SQLConvStrNull(txtHourQde.Text, "n") & ","

            sql = sql & util.SQLConvStrNull(txtHourTravel.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtHourOperation.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtHourStandby.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtHourLost.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtActivityResume.Text, "s") & ")"

        Else
            sql = "UPDATE TICKETWORKER SET " &
                " REGISTERDATE = #" & dtpRegisterDate.Value.ToString("yyyy-MM-dd") & "# " &
                ",HOURQDE = " & util.SQLConvStrNull(txtHourQde.Text, "n") & " " &
                ",HOURTRAVEL = " & util.SQLConvStrNull(txtHourTravel.Text, "n") & " " &
                ",HOUROPERATION = " & util.SQLConvStrNull(txtHourOperation.Text, "n") & " " &
                ",HOURSTANDBY = " & util.SQLConvStrNull(txtHourStandby.Text, "n") & " " &
                ",HOURLOST = " & util.SQLConvStrNull(txtHourLost.Text, "n") & " " &
                ",RESUMEACTIVITY = " & util.SQLConvStrNull(txtActivityResume.Text, "s") & " " &
                "WHERE " &
                "TICKETWORKERID = '" & sTicketWorkerId & "'"

        End If

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

    Private Sub btnCancelDelete_Click(sender As Object, e As EventArgs) Handles btnCancelDelete.Click
        If btnCancelDelete.Text = "Cancel" Then
            Me.Dispose()
        Else
            Dim sql As String = ""
            Dim bdconnACCESS As New clsBancoDadosACCESS

            bdconnACCESS.OpenConnection()

            If MsgBox("Are you want DELETE this item? This action is Irreversivel", MsgBoxStyle.YesNo) = vbYes Then

                sql = "DELETE FROM TICKETWORKER  " & _
                    "WHERE " & _
                    "TICKETWORKERID = '" & sTicketWorkerId & "'"

                bdconnACCESS.ExecuteNonSQL(sql)

                MsgBox("Deleted")

                bdconnACCESS.CloseConnection()
                bdconnACCESS.Dispose()
                bdconnACCESS = Nothing
                Dim sync As New clsSyncTicket
                sync.UpdateSyncDateTime(sTicketId, "ACCESS")
                sync.Dispose()
                sync = Nothing

                Me.Dispose()

            End If
        End If
    End Sub

    Private Sub frmTicketWorkerEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        util.DateTimePickerFormat(dtpRegisterDate)

        If sTicketWorkerId = "" Then
            btnCancelDelete.Text = "Cancel"
            btnSearch.Enabled = True
            dtpRegisterDate.Value = DateTime.Now

            dtpRegisterDate.Enabled = False
            txtHourTravel.Enabled = False
            txtHourOperation.Enabled = False
            txtHourStandby.Enabled = False
            txtHourLost.Enabled = False
            txtActivityResume.Enabled = False

        Else
            btnCancelDelete.Text = "Delete"
            btnSearch.Enabled = False

            dtpRegisterDate.Enabled = True
            txtHourTravel.Enabled = True
            txtHourOperation.Enabled = True
            txtHourStandby.Enabled = True
            txtHourLost.Enabled = True
            txtActivityResume.Enabled = True

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


End Class