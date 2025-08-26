Public Class frmRPTMain

    Public sTicketId As String
    Public sContractId As String

    Private Sub cbxTicketLayout_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTicketLayout.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxTicketLayout_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTicketLayout.SelectedIndexChanged
        LoadReport()

    End Sub

    Private Sub frmRPTMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor

        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.CONTRACTREPLAYOUT' table. You can move, or remove it, as needed.
        Me.CONTRACTREPLAYOUTTableAdapter.Fill(Me.SESTicketAccessDataSet.CONTRACTREPLAYOUT)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.REPORTTICKETLIST' table. You can move, or remove it, as needed.
        Me.CONTRACTREPLAYOUTTableAdapter.Fill(Me.SESTicketAccessDataSet.CONTRACTREPLAYOUT)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.COUNTRY' table. You can move, or remove it, as needed.
        Me.COUNTRYTableAdapter.Fill(Me.SESTicketAccessDataSet.COUNTRY)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.REPORTPARAM' table. You can move, or remove it, as needed.
        Me.REPORTPARAMTableAdapter.Fill(Me.SESTicketAccessDataSet.REPORTPARAM)
        cbxRepParam.Refresh()

        FilterReport()

        'Loading Default Parameters
        LoadDefaultRepParam()

        'Loading Report
        LoadReport()

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub LoadDefaultRepParam()

        Dim sql As String
        Dim ds As New DataSet
        Dim bdconn As New clsBancoDadosACCESS

        bdconn.OpenConnection()

        sql = "SELECT REPORTPARAMID " &
              "FROM CONTRACT C " &
              "INNER JOIN TICKET T ON (C.CONTRACTID = T.CONTRACTID) " &
              "WHERE T.TICKETID = '" & sTicketId & "' " &
              "AND REPORTPARAMID IS NOT NULL "
        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                cbxRepParam.SelectedValue = ds.Tables(0).Rows(i)("REPORTPARAMID").ToString
            Next
        End If

        ds.Dispose()
        ds = Nothing
        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing
    End Sub

    Private Sub LoadReport()

        pnlReport.Controls.Clear()

        If cbxTicketLayout.Text.ToString = "" Then
            Exit Sub
        End If

        If cbxTicketLayout.Text = "Excel Tool" Then
            Me.Close()
            Exit Sub
        End If

        If cbxTicketLayout.Text = "Pacific Metapetroleum" Or cbxTicketLayout.Text = "Model 01 - No Discount and Portion" Or cbxTicketLayout.Text = "Model 02 - Price Base and Utility Calculated" Or Strings.Left(cbxTicketLayout.Text.ToString, 8) = "Model 03" Or Strings.Left(cbxTicketLayout.Text.ToString, 8) = "Model 04" Then
            cbxOrientation.Visible = True
            lblOrientation.Visible = True
        Else
            cbxOrientation.Visible = False
            lblOrientation.Visible = False
        End If

        If Strings.Left(cbxTicketLayout.Text.ToString, 8) = "Model 04" Then
            chkPageBreak.Visible = False
            chkPageBreak.Checked = False
        Else
            chkPageBreak.Visible = True
        End If

        If chkPageBreak.Checked = False Then
            If cbxTicketLayout.Text = "Pacific Metapetroleum" And cbxOrientation.Text = "Landscape" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTPacificMetapetroleumLetterLandscape
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Pacific Metapetroleum" And cbxOrientation.Text = "Portrait" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTPacificMetapetroleumLetterPortrait
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 01 - No Discount and Portion" And cbxOrientation.Text = "Landscape" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTDefault01LetterLandscape
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 01 - No Discount and Portion" And cbxOrientation.Text = "Portrait" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTDefault01LetterPortrait
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)


            ElseIf cbxTicketLayout.Text = "Ecopetrol - Service" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTEcopetrolServiceLetter
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Ecopetrol - Material" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTEcopetrolMaterialLetter
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 02 - Price Base and Utility Calculated" And cbxOrientation.Text = "Landscape" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTModel02LetterLandscape
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)


            ElseIf cbxTicketLayout.Text = "Model 02 - Price Base and Utility Calculated" And cbxOrientation.Text = "Portrait" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTModel02LetterPortrait
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 03 - No Discount and Portion - Service" And cbxOrientation.Text = "Landscape" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTModel03LetterLandscape
                With form
                    .sItemType = "Service"
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 03 - No Discount and Portion - Material" And cbxOrientation.Text = "Landscape" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTModel03LetterLandscape
                With form
                    .sItemType = "Material"
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 03 - No Discount and Portion - Service" And cbxOrientation.Text = "Portrait" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTModel03LetterPortrait
                With form
                    .sItemType = "Service"
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 03 - No Discount and Portion - Material" And cbxOrientation.Text = "Portrait" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTModel03LetterPortrait
                With form
                    .sItemType = "Material"
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 04 - Standard" And cbxOrientation.Text = "Portrait" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTModel04LetterPortrait
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 04 - Standard" And cbxOrientation.Text = "Landscape" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTModel04LetterLandscape
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)


            End If



        Else

            If cbxTicketLayout.Text = "Pacific Metapetroleum" And cbxOrientation.Text = "Landscape" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTPacificMetapetroleumLetterLandscapePageBreak
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Pacific Metapetroleum" And cbxOrientation.Text = "Portrait" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTPacificMetapetroleumLetterPortraitPageBreak
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 01 - No Discount and Portion" And cbxOrientation.Text = "Landscape" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTDefault01LetterLandscapePageBreak
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 01 - No Discount and Portion" And cbxOrientation.Text = "Portrait" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTDefault01LetterPortraitPageBreak
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Ecopetrol - Service" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTEcopetrolServiceLetterPageBreak
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Ecopetrol - Material" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTEcopetrolMaterialLetterPageBreak
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 02 - Price Base and Utility Calculated" And cbxOrientation.Text = "Landscape" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTModel02LetterLandscapePageBreak
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 02 - Price Base and Utility Calculated" And cbxOrientation.Text = "Portrait" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTModel02LetterPortraitPageBreak
                With form
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 03 - No Discount and Portion - Service" And cbxOrientation.Text = "Landscape" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTModel03LetterLandscapePageBreak
                With form
                    .sItemType = "Service"
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 03 - No Discount and Portion - Material" And cbxOrientation.Text = "Landscape" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTModel03LetterLandscapePageBreak
                With form
                    .sItemType = "Material"
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 03 - No Discount and Portion - Service" And cbxOrientation.Text = "Portrait" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTModel03LetterPortraitPageBreak
                With form
                    .sItemType = "Service"
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            ElseIf cbxTicketLayout.Text = "Model 03 - No Discount and Portion - Material" And cbxOrientation.Text = "Portrait" Then
                pnlReport.Controls.Clear()
                Dim form As New frmRPTModel03LetterPortraitPageBreak
                With form
                    .sItemType = "Material"
                    .TopLevel = False
                    .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    .sTicketId = Me.sTicketId
                    .sReportParamId = cbxRepParam.SelectedValue
                    .Show()
                End With
                pnlReport.Controls.Add(form)

            End If


        End If

    End Sub

    Private Sub cbxPaper_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cbxPaper_SelectedIndexChanged(sender As Object, e As EventArgs)
        LoadReport()
    End Sub

    Private Sub cbxOrientation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxOrientation.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxOrientation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOrientation.SelectedIndexChanged
        LoadReport()
    End Sub

    Private Sub chkPageBreak_CheckedChanged(sender As Object, e As EventArgs) Handles chkPageBreak.CheckedChanged
        LoadReport()
    End Sub

    Private Sub cbxRepParam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxRepParam.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxRepParam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRepParam.SelectedIndexChanged
        LoadReport()
    End Sub

    Private Sub cbxCountry_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCountry.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCountry.SelectedIndexChanged
        FilterReport()
        LoadReport()
    End Sub

    Private Sub FilterReport()
        Dim sFilter As String
        sFilter = "COUNTRYCODE='" & cbxCountry.SelectedValue & "' AND CONTRACTID=" & sContractId & ""
        CONTRACTREPLAYOUTBindingSource.Filter = sFilter
    End Sub

    Private Sub frmRPTMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If cbxTicketLayout.Text = "Excel Tool" Then
            Dim frm As New frmRPTExcel
            frm.sTicketId = Me.sTicketId
            frm.ShowDialog()
        End If
    End Sub

End Class