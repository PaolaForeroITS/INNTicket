Public Class frmWellEdit

    Dim sWellIdOld As String
    Dim util As New clsUtils

    Public Sub CarregaCbx()

        Try
            ChargeDatasets()
        Catch ex As Exception
            If ex.Message = "Not valid password" Then
                ChargeDatasets()
            Else
                MsgBox(ex.Message, vbInformation)
            End If
        End Try


    End Sub

    Private Sub ChargeDatasets()
        'TODO: This line of code loads data into table. You can move, or remove it, as needed.
        Me.PETRFIELDTableAdapter.Fill(Me.SESTicketSQLDataSet.PETRFIELD)
        'TODO: This line of code loads data into table. You can move, or remove it, as needed.
        Me.RIGTableAdapter.Fill(Me.SESTicketSQLDataSet.RIG)
        'TODO: This line of code loads data into table. You can move, or remove it, as needed.
        Me.COUNTRYTableAdapter.Fill(Me.SESTicketSQLDataSet.COUNTRY)
        'TODO: This line of code loads data into table. You can move, or remove it, as needed.
        Me.SITESTableAdapter.Fill(Me.SESTicketSQLDataSet.SITES)
        'TODO: This line of code loads data into table. You can move, or remove it, as needed.
        Me.STATETableAdapter.Fill(Me.SESTicketSQLDataSet.STATE)
        STATEBindingSource.Filter = "COUNTRYID=169"
        cbxState.Refresh()
        'TODO: This line of code loads data into table. You can move, or remove it, as needed.
        Me.CITYTableAdapter.Fill(Me.SESTicketSQLDataSet.CITY)
        CITYBindingSource.Filter = "STATEID=91"
        cbxCity.Refresh()
    End Sub

    Private Sub frmWellEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sWellIdOld = txtWellID.Text

        If sWellIdOld = "" Then
            CarregaCbx()
        Else
            txtWellID.Enabled = False
        End If

    End Sub

    Private Sub cbxCountry_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCountry.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCountry.SelectedIndexChanged
        Me.STATETableAdapter.Fill(Me.SESTicketSQLDataSet.STATE)
        If Not IsNothing(cbxCountry.SelectedValue) Then
            STATEBindingSource.Filter = "COUNTRYID= " & cbxCountry.SelectedValue & " "
            cbxState.Refresh()
        End If
    End Sub

    Private Sub cbxState_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxState.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxState.SelectedIndexChanged
        Me.CITYTableAdapter.Fill(Me.SESTicketSQLDataSet.CITY)
        If Not IsNothing(cbxState.SelectedValue) Then
            CITYBindingSource.Filter = "STATEID=" & cbxState.SelectedValue & ""
            cbxCity.Refresh()
        End If
    End Sub

    Private Sub cbxActive_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxActive.KeyPress
        e.Handled = False
    End Sub

    Private Sub cbxField_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxField.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxSite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxSite.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxCity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCity.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxRig_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxRig.KeyPress
        e.Handled = True
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        If txtWellID.Text = "" Then
            MsgBox("Inform the Well ID", vbExclamation)
            Exit Sub
        End If

        If txtName.Text = "" Then
            MsgBox("Inform the Name", vbExclamation)
            Exit Sub
        End If

        If cbxField.Text = "" Then
            MsgBox("Inform the Field", vbExclamation)
            Exit Sub
        End If

        If cbxSite.Text = "" Then
            MsgBox("Inform the Site", vbExclamation)
            Exit Sub
        End If

        If cbxCountry.Text = "" Then
            MsgBox("Inform the Country", vbExclamation)
            Exit Sub
        End If

        If cbxState.Text = "" Then
            MsgBox("Inform the State", vbExclamation)
            Exit Sub
        End If

        If cbxCity.Text = "" Then
            MsgBox("Inform the City", vbExclamation)
            Exit Sub
        End If


        Me.Cursor = Cursors.WaitCursor

        Dim bdconn As New clsBancoDadosACCESS()
        Dim sql As String
        Dim ds As New DataSet

        bdconn.OpenConnection("AccBaseData")

        If sWellIdOld = "" Then

            sql = "SELECT 1 AS QDE FROM zSQL_WELL WHERE [WELLID]= '" & txtWellID.Text & "'"
            bdconn.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Me.Cursor = Cursors.Arrow

                MsgBox("The Well ID is being used by another one.", vbExclamation)
                ds.Dispose()
                ds = Nothing
                bdconn.CloseConnection()
                bdconn.Dispose()
                bdconn = Nothing
                Exit Sub
            End If

            sql = "INSERT INTO zSQL_WELL " & _
                "([WELLID],[NAME],[PETRFIELDID] " & _
                ",[COUNTRY],[STATE],[CITY],[SITEID],[ACTIVE],[RIGID]) VALUES ('"

            sql = sql & txtWellID.Text & "','"
            sql = sql & txtName.Text & "',"
            sql = sql & cbxField.SelectedValue.ToString & ",'"
            sql = sql & cbxCountry.Text & "','"
            sql = sql & cbxState.Text & "','"
            sql = sql & cbxCity.Text & "','"
            sql = sql & cbxSite.SelectedValue.ToString & "','"
            sql = sql & cbxActive.Text & "',"
            sql = sql & util.SQLConvStrNull(cbxRig.SelectedValue, "s") & ")"

            bdconn.ExecuteNonSQL(sql)

        Else

            sql = "UPDATE zSQL_WELL SET " &
                " [NAME]        = '" & txtName.Text & "' " &
                ",[PETRFIELDID] = " & cbxField.SelectedValue.ToString & " " &
                ",[COUNTRY]     = '" & cbxCountry.Text & "' " &
                ",[STATE]       = '" & cbxState.Text & "' " &
                ",[CITY]        = '" & cbxCity.Text & "' " &
                ",[SITEID]      = '" & cbxSite.SelectedValue.ToString & "' " &
                ",[ACTIVE]      = '" & cbxActive.Text & "' " &
                ",[RIGID]       =  " & util.SQLConvStrNull(cbxRig.SelectedValue, "s") & " "

            sql = sql & "WHERE [WELLID] = '" & txtWellID.Text & "'"

            bdconn.ExecuteNonSQL(sql)

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        ds.Dispose()
        bdconn = Nothing
        ds = Nothing

        Dim syn As New clsSyncBaseData
        syn.UpdateVersionBaseSQL("WELL")
        syn.Dispose()
        syn = Nothing

        '------
        'Me.Hide()

        Me.Cursor = Cursors.Arrow

        If MsgBox("Done. You should be synchronize the information. Do you want proceed it now?", vbYesNo) = vbYes Then
            Dim frm As New frmSyncBaseData
            frm.ShowDialog()
            frm.Dispose()
            frm = Nothing
        End If
        frmCancelTicket = Nothing

        Me.Dispose()

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub




End Class