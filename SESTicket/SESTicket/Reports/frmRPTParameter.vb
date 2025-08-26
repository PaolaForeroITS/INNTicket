Imports System.IO
Imports System.Configuration

Public Class frmRPTParameter

    Public sUsername As String
    Dim bPermitInsUpd As Boolean = True

    Public isSearch As Boolean = False
    Dim sReportParamId As String = ""
    Dim sReportParamDesc As String = ""

    Dim sSESLogoFile As String = ""
    Dim sAUXLogoFile As String = ""
    Dim sSESLogoFullFile As String = ""
    Dim sAUXLogoFullFile As String = ""

    Dim sReportFilesRemote As String = ConfigurationManager.AppSettings("RemoteAttachFolder").ToString & "\ReportFiles\"
    Dim sReportFilesLocal As String = ConfigurationManager.AppSettings("ReportFilesLocal").ToString & "\"

    Dim util As New clsUtils

    Private Sub frmRPTParameter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        EditMode(False)

        If isSearch = True Then
            mnuNew.Visible = False
            mnuSave.Visible = False
            mnuEdit.Visible = False
            mnuDelete.Visible = False
            mnuCancel.Visible = False
        End If

        'User Grants
        FormUserGrant()

    End Sub

    Private Sub RefreshGrid()
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.REPORTPARAM' table. You can move, or remove it, as needed.
        Me.REPORTPARAMTableAdapter.Fill(Me.SESTicketAccessDataSet.REPORTPARAM)
        dgvParam.Refresh()

    End Sub

    Private Sub picSESLogo_DoubleClick(sender As Object, e As EventArgs) Handles picSESLogo.DoubleClick
        If isSearch = False And mnuCancel.Visible = True Then
            OpenFileDialog1.ShowDialog()
            picSESLogo.ImageLocation = OpenFileDialog1.FileName
            sSESLogoFile = OpenFileDialog1.SafeFileName
            sSESLogoFullFile = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub picAUXLogo_DoubleClick(sender As Object, e As EventArgs) Handles picAUXLogo.DoubleClick
        If isSearch = False And mnuCancel.Visible = True Then
            OpenFileDialog1.ShowDialog()
            picAUXLogo.ImageLocation = OpenFileDialog1.FileName
            sAUXLogoFile = OpenFileDialog1.SafeFileName
            sAUXLogoFullFile = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub EditMode(Optional ByVal Edit As Boolean = True)

        If Edit = True Then
            mnuSave.Visible = True
            mnuDelete.Visible = False
            mnuNew.Visible = False
            mnuExit.Visible = False
            mnuCancel.Visible = True
            mnuEdit.Visible = False

            txtParamDescrip.ReadOnly = False
            txtHEAD1.ReadOnly = False
            txtHEAD2.ReadOnly = False

            gpbLogo.Text = "Logo - Double Click in the Box to Select"

            lblName.ForeColor = Color.Red
            grpHeaderText.ForeColor = Color.Red

        Else
            mnuSave.Visible = False
            mnuDelete.Visible = False
            mnuNew.Visible = True
            mnuExit.Visible = True
            mnuCancel.Visible = False
            mnuEdit.Visible = True

            txtParamDescrip.ReadOnly = True
            txtHEAD1.ReadOnly = True
            txtHEAD2.ReadOnly = True

            gpbLogo.Text = "Logo"

            lblName.ForeColor = Color.Black
            grpHeaderText.ForeColor = Color.Black

        End If

    End Sub

    Private Sub mnuEdit_Click(sender As Object, e As EventArgs) Handles mnuEdit.Click
        EditMode(True)
    End Sub

    Private Sub mnuCancel_Click(sender As Object, e As EventArgs) Handles mnuCancel.Click
        Reset()
    End Sub

    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        Reset()
        EditMode(True)

        'New File
        sReportParamId = ""

    End Sub

    Private Sub SyncBaseData(Optional ByVal sOperation As String = "")
        Dim syn As New clsSyncBaseData

        syn.UpdateVersionBaseSQL("REPORTPARAM")
        If sOperation.ToUpper = "DELETE" Then
            syn.UpdateVersionBaseSQL("CONTRACT")
            syn.UpdateVersionBaseSQL("CONTRACTAIUINVENTORYCLASS")
        End If
        syn.Dispose()

        Dim frm As New frmSyncBaseData
        frm.ShowDialog()
        frm.Dispose()

    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        If txtParamDescrip.Text.Trim = "" Then
            MsgBox("Inform the Name", vbExclamation)
            Exit Sub
        End If

        If txtHEAD1.Text.Trim = "" Then
            MsgBox("Inform the Header Text #1", vbExclamation)
            Exit Sub
        End If

        If txtHEAD2.Text.Trim = "" Then
            MsgBox("Inform the Header Text #2", vbExclamation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        'Copy the Files to Image folder
        Dim sFullFileRemote As String
        If sSESLogoFile <> "" Then
            If picSESLogo.ImageLocation.ToString.Contains(sReportFilesRemote) = False Then
                sFullFileRemote = sReportFilesRemote & sSESLogoFile
                picSESLogo.ImageLocation = ""
                System.IO.File.Copy(sSESLogoFullFile, sFullFileRemote, True)
            End If
        End If

        If sAUXLogoFile <> "" Then
            If picAUXLogo.ImageLocation.ToString.Contains(sReportFilesRemote) = False Then
                sFullFileRemote = sReportFilesRemote & sAUXLogoFile
                picAUXLogo.ImageLocation = ""
                System.IO.File.Copy(sAUXLogoFullFile, sFullFileRemote, True)
            End If
        End If

        Dim sql As String = ""

        If sReportParamId = "" Then
            sql = "INSERT INTO REPORTPARAM (DESCRIP,HEAD1,HEAD2,SESLOGO,AUXLOGO) VALUES ("
            sql = sql & "'" & txtParamDescrip.Text & "',"
            sql = sql & "'" & txtHEAD1.Text & "',"
            sql = sql & "'" & txtHEAD2.Text & "',"
            sql = sql & "" & util.SQLConvStrNull(sSESLogoFile, "s") & ","
            sql = sql & "" & util.SQLConvStrNull(sAUXLogoFile, "s") & ")"
        Else
            sql = "UPDATE REPORTPARAM SET "
            sql = sql & "DESCRIP = '" & txtParamDescrip.Text & "' "
            sql = sql & ",HEAD1 = '" & txtHEAD1.Text & "' "
            sql = sql & ",HEAD2 = '" & txtHEAD2.Text & "' "
            sql = sql & ",SESLOGO = " & util.SQLConvStrNull(sSESLogoFile, "s") & " "
            sql = sql & ",AUXLOGO = " & util.SQLConvStrNull(sAUXLogoFile, "s") & " "
            sql = sql & "WHERE REPORTPARAMID = " & sReportParamId & ""
        End If

        Dim bdconn As New clsBancoDadosSQL
        bdconn.OpenConnection()
        bdconn.ExecuteNonSQL(sql)
        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Reset()

        'SyncBaseData
        SyncBaseData()

        'Refresh Grid
        RefreshGrid()
        Me.Cursor = Cursors.Arrow

        MsgBox("Saved", vbInformation)

    End Sub

    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click

        If sReportParamId <> "" Then

            If MsgBox("Are you want DELETE the registry?", vbYesNo) = vbYes Then

                Me.Cursor = Cursors.WaitCursor

                Dim sql As String = ""
                Dim bdconn As New clsBancoDadosSQL
                bdconn.OpenConnection()

                sql = "DELETE REPORTPARAM WHERE REPORTPARAMID = " & sReportParamId & ""
                bdconn.ExecuteNonSQL(sql)

                sql = "UPDATE CONTRACT SET REPORTPARAMID = NULL WHERE REPORTPARAMID = " & sReportParamId & ""
                bdconn.ExecuteNonSQL(sql)

                bdconn.CloseConnection()
                bdconn.Dispose()
                bdconn = Nothing

                Reset()

                'SyncBaseData
                SyncBaseData("DELETE")

                'Refresh Grid
                RefreshGrid()
                Me.Cursor = Cursors.Arrow

                MsgBox("Deleted", vbInformation)

            End If

        End If


    End Sub

    Private Sub Reset()
        '--Disable Edit Mode
        EditMode(False)

        '--Start Objects
        sSESLogoFile = ""
        sAUXLogoFile = ""
        txtParamDescrip.Text = ""
        txtHEAD1.Text = ""
        txtHEAD2.Text = ""
        picSESLogo.ImageLocation = ""
        picAUXLogo.ImageLocation = ""

    End Sub

    Private Sub LocalParam()
        If dgvParam.RowCount > 0 Then

            sReportParamId = dgvParam.CurrentRow.Cells("colReportParamId").Value
            sReportParamDesc = dgvParam.CurrentRow.Cells("colDescrip").Value

            txtParamDescrip.Text = dgvParam.CurrentRow.Cells("colDescrip").Value

            sSESLogoFile = util.TrataDBNull(dgvParam.CurrentRow.Cells("colSESLogo").Value)

            If sSESLogoFile <> "" Then
                picSESLogo.ImageLocation = IIf(isSearch = True, sReportFilesLocal, sReportFilesRemote) & sSESLogoFile
            Else
                picSESLogo.ImageLocation = ""
            End If

            sAUXLogoFile = util.TrataDBNull(dgvParam.CurrentRow.Cells("colAuxLogo").Value)
            If sAUXLogoFile <> "" Then
                picAUXLogo.ImageLocation = IIf(isSearch = True, sReportFilesLocal, sReportFilesRemote) & sAUXLogoFile
            Else
                picAUXLogo.ImageLocation = ""
            End If

            txtHEAD1.Text = dgvParam.CurrentRow.Cells("colHead1").Value
            txtHEAD2.Text = dgvParam.CurrentRow.Cells("colHead2").Value

            If bPermitInsUpd = False Then
                Exit Sub
            End If

            If isSearch = True Then
                mnuNew.Visible = False
                mnuSave.Visible = False
                mnuEdit.Visible = False
                mnuDelete.Visible = False
                mnuCancel.Visible = False
            Else
                mnuDelete.Visible = True
            End If

        End If
    End Sub

    Private Sub dgvParam_Click(sender As Object, e As EventArgs) Handles dgvParam.Click
        LocalParam()
    End Sub

    Private Sub dgvParam_SelectionChanged(sender As Object, e As EventArgs) Handles dgvParam.SelectionChanged
        LocalParam()
    End Sub

    Private Sub dgvParam_DoubleClick(sender As Object, e As EventArgs) Handles dgvParam.DoubleClick
        If dgvParam.RowCount > 0 And isSearch = True Then
            frmContractEdit.sReportParamId = Me.sReportParamId
            frmContractEdit.txtRepParam.Text = Me.sReportParamDesc
            Me.Dispose()
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub

    Private Sub dgvParam_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParam.CellContentClick

    End Sub

#Region "FormUserGrants"

    Private Sub FormUserGrant()

        Me.Cursor = Cursors.WaitCursor

        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection("AccBase")

        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT obj.OBJECTNAME, obj.OBJECTTYPE " &
              "FROM OBJECTGROUPITEMUSER usr, OBJECTGROUPITEM obj " &
              "WHERE usr.OBJECTGROUPITEMID = obj.OBJECTGROUPITEMID " &
              "and usr.ENABLE = 'NO'  " &
              "and obj.OBJECTFORM = 'frmRPTParameter' " &
              "and usr.USERNAME = '" & Me.sUsername & "'"

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim sObject As String = ""

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                sObject = ds.Tables(0).Rows(i)("OBJECTNAME")

                If sObject = "bPermitInsUpd" Then
                    bPermitInsUpd = False
                    mnuNew.Enabled = False
                    mnuSave.Enabled = False
                    mnuEdit.Enabled = False
                    mnuDelete.Enabled = False
                    mnuCancel.Enabled = False
                End If
            Next

        End If

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Me.Cursor = Cursors.Arrow

    End Sub

#End Region

End Class