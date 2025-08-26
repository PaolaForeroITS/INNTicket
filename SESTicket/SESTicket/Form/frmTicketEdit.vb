Imports System.Configuration
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class frmTicketEdit
    Implements IDisposable

    Dim sFilePathTmp As String = Directory.GetCurrentDirectory().Replace("\app", "\") & "\file\tmp"

    Dim bdconnACCESS As New clsBancoDadosACCESS
    Dim util As New clsUtils
    Public sUsername As String
    Dim nTicketNumber As Integer

    Public sTicketNumberOld As String = ""
    Public sExchangeRate As String
    Public bIsSQLConnect As Boolean = False
    Public bTicketReadOnly As Boolean = False

    Public sCancelDet As String

    Public sWellId As String
    Public sSiteId As String
    Public sContrRepresId As String
    Public sSuperiorSupervisorId As String

    Public bNoInvItem As Boolean

    Dim bShowTabOperReport As Boolean = True
    Dim bShowTabServEvalHSEQ As Boolean = True

#Region "Form Control"

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bdconnACCESS.OpenConnection()
    End Sub

    Protected Overrides Sub Finalize()
        bdconnACCESS.CloseConnection()
        bdconnACCESS.Dispose()
        bdconnACCESS = Nothing

        MyBase.Finalize()
    End Sub

    Private Sub frmTicketEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Added validation to enable the Frontera report print option.

        Dim sql As String
        Dim Customer As String = ""
        Dim ds As New DataSet
        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection()

        sql = "SELECT CUSTOMERID " &
              "FROM TICKET T " &
              "WHERE T.TICKETID = '" & sTicketNumberOld & "' "

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Customer = ds.Tables(0).Rows(i)("CUSTOMERID").ToString
            Next
        End If

        ds.Dispose()
        ds = Nothing
        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing
        'Si el cliente es Frontera visualiza la opción imprimir reporte
        If (Customer = "830126302") Then
            FronteraToolStripMenuItem.Visible = True

            'Si el cliente es diferente a Frontera remueve la Pestaña imprimir reporte
        Else
            FronteraToolStripMenuItem.Visible = False

        End If

        Me.Cursor = Cursors.WaitCursor

        util.DateTimePickerFormat(dtpServiceDate)
        util.DateTimePickerFormat(dtpTimeArrived, True)
        util.DateTimePickerFormat(dtpTimeStarted, True)
        util.DateTimePickerFormat(dtpTimeCompleted, True)

        '--FormUserGrant
        FormUserGrant()

        If sTicketNumberOld = "" Then

            Try
                GetNewTicketNumber()

                dtpServiceDate.Value = Date.Now
                dtpTimeArrived.Value = DateTime.Now
                dtpTimeStarted.Value = DateTime.Now
                dtpTimeCompleted.Value = DateTime.Now

                cbxContract.Text = ""
                cbxCurrency.Text = ""
                cbxServiceType.Text = ""
                cbxTubingPipe.Text = ""
                cbxCasingSize.Text = ""
                txtWellName.Text = ""

                grpServiceType.Visible = False

                TabControl1.TabPages.Remove(tabSalesItem)
                TabControl1.TabPages.Remove(tabOperReport)
                TabControl1.TabPages.Remove(tabEquipments)
                TabControl1.TabPages.Remove(tabWorkers)
                TabControl1.TabPages.Remove(tabServEvalHSEQ)


                mnuCloseTicket.Enabled = False
                mnuPrint.Enabled = False
                mnuAttachment.Enabled = False

                sExchangeRate = 0

                CarregaCbxServiceLine()
                CarregaCbxContract()
                CarregaCbxMoeda()

            Catch ex As Exception
                Me.Cursor = Cursors.Arrow
                MsgBox(ex.Message)
            End Try
        Else
            pnlTicketObjects(False)
            InitEquipment()
            LoadWorkers()
            InitSalesItem()
            If bShowTabOperReport = True Then
                InitOperReport()
            Else
                TabControl1.TabPages.Remove(tabOperReport)
            End If
            If bShowTabServEvalHSEQ = True Then
                InitHSEQServEval()
            Else
                TabControl1.TabPages.Remove(tabServEvalHSEQ)
            End If
            TicketEnable()
            CarregaTicketServiceType()
            LoadTicketOpeHour()

        End If

        Me.Cursor = Cursors.Arrow





    End Sub

    Private Sub pnlTicketObjects(ByVal bEnabled As Boolean)

        If bEnabled = False Then
            lblTicketNumber.Enabled = False
            lblCustomer.Enabled = False
            cbxCustomer.Enabled = False
            lblContract.Enabled = False
            cbxContract.Enabled = False
            lblCurrency.Enabled = False
            cbxCurrency.Enabled = False
            lblServiceLine.Enabled = False
            cbxServiceLine.Enabled = False

        Else
            lblTicketNumber.Enabled = True
            lblCustomer.Enabled = True
            cbxCustomer.Enabled = True
            lblContract.Enabled = True
            cbxContract.Enabled = True
            lblCurrency.Enabled = True
            cbxCurrency.Enabled = True
            lblServiceLine.Enabled = True
            cbxServiceLine.Enabled = True
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Public Sub Init()
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.CASING' table. You can move, or remove it, as needed.
        Me.CASINGTableAdapter.Fill(Me.SESTicketAccessDataSet.CASING)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TUBBING_WEIGHT' table. You can move, or remove it, as needed.
        Me.TUBBING_WEIGHTTableAdapter.Fill(Me.SESTicketAccessDataSet.TUBBING_WEIGHT)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TUBBING_DRILLPIPE' table. You can move, or remove it, as needed.
        Me.TUBBING_DRILLPIPETableAdapter.Fill(Me.SESTicketAccessDataSet.TUBBING_DRILLPIPE)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.CASING_WEIGHT' table. You can move, or remove it, as needed.
        Me.CASING_WEIGHTTableAdapter.Fill(Me.SESTicketAccessDataSet.CASING_WEIGHT)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.CASING_SIZE' table. You can move, or remove it, as needed.
        Me.CASING_SIZETableAdapter.Fill(Me.SESTicketAccessDataSet.CASING_SIZE)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet1.TUBING' table. You can move, or remove it, as needed.
        Me.TUBINGTableAdapter.Fill(Me.SESTicketAccessDataSet.TUBING)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.SERVICETYPE' table. You can move, or remove it, as needed.
        Me.SERVICETYPETableAdapter.Fill(Me.SESTicketAccessDataSet.SERVICETYPE)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.CUSTOMER' table. You can move, or remove it, as needed.
        Me.CUSTOMERTableAdapter.Fill(Me.SESTicketAccessDataSet.CUSTOMER)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet2.SERVLINE_CUST_V' table. You can move, or remove it, as needed.
        Me.SERVLINE_CUST_VTableAdapter.Fill(Me.SESTicketAccessDataSet.SERVLINE_CUST_V)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.CONTRACT' table. You can move, or remove it, as needed.
        Me.CONTRACTTableAdapter.Fill(Me.SESTicketAccessDataSet.CONTRACT)
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.CURRENCY' table. You can move, or remove it, as needed.
        Me.CURRENCYTableAdapter.Fill(Me.SESTicketAccessDataSet.CURRENCY)

        CarregaCbxTubing()
        CarregaCbxCasing()

        cbxServiceLine.Refresh()
        cbxCustomer.Refresh()
        cbxContract.Refresh()
        cbxCurrency.Refresh()

    End Sub

    Private Function CheckHasInfItem() As Boolean
        '--Checking if the Ticket has o hasnot a inventory
        If bNoInvItem = True Then
            Return True
        Else
            Dim sql As String
            Dim ds As New DataSet

            sql = "SELECT COUNT(*) AS QDE FROM [TICKETINVHEADER] WHERE TICKETID = '" & txtTicketNumber.Text & "' "
            bdconnACCESS.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows(0)("QDE") = 0 Then
                Return False
            Else
                Return True
            End If

            ds.Dispose()
            ds = Nothing

        End If
    End Function

    Private Sub btnCancelDet_Click(sender As Object, e As EventArgs) Handles btnCancelDet.Click
        MsgBox(sCancelDet)
    End Sub

    Private Sub TicketSalesItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicketSalesItemToolStripMenuItem.Click

        If dgvTicketServType.RowCount = 0 Then
            MsgBox("Inform the Service Line", vbExclamation)
            Me.Cursor = Cursors.Arrow
            Exit Sub
        End If

        'Checking if the Ticket has Inventory
        If CheckHasInfItem() = False Then
            Dim text As String
            text = "The Inventory Itens is not defined." & Environment.NewLine &
                "For this reason the ticket print is not availlable" & Environment.NewLine &
                "Please, define the Inventory and, after that, return for this option"
            MsgBox(text, vbInformation)
            Exit Sub
        End If

        Dim frm As New frmRPTMain
        With frm
            .sTicketId = txtTicketNumber.Text
            .sContractId = cbxContract.SelectedValue.ToString
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub TicketJobLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuJobLog.Click

        If dgvTicketServType.RowCount = 0 Then
            MsgBox("Inform the Service Line", vbExclamation)
            Me.Cursor = Cursors.Arrow
            Exit Sub
        End If

        Dim frm As New frmRPTTicketJobLogLetterPortrait
        With frm
            .sTicketId = txtTicketNumber.Text
            .Start()
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub ActaInicioYFinalizOperacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuActaIniFimOpe.Click

        If dgvTicketServType.RowCount = 0 Then
            MsgBox("Inform the Service Line", vbExclamation)
            Me.Cursor = Cursors.Arrow
            Exit Sub
        End If

        Dim frm As New frmRPTDocxActStartFinish
        With frm
            .sTicketId = txtTicketNumber.Text
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub btnAddServiceType_Click(sender As Object, e As EventArgs) Handles btnAddServiceType.Click

        If IsNothing(cbxServiceType.SelectedValue) Then
            MsgBox("Choose the Service Type", vbExclamation)
            Exit Sub
        End If

        If cbxServiceType.SelectedValue.ToString = "-1" Then
            MsgBox("Choose the Service Type", vbExclamation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconn.OpenConnection()

        sql = "SELECT COUNT(*) AS QDE FROM TICKETSERVICETYPE " &
            "WHERE SERVICETYPEID=" & cbxServiceType.SelectedValue.ToString & " " &
            "AND TICKETID='" & txtTicketNumber.Text & "' "
        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows(0)("QDE") > 0 Then
            Me.Cursor = Cursors.Arrow
            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing
            ds.Dispose()
            ds = Nothing
            cbxServiceType.SelectedValue = -1
            Exit Sub
        End If
        ds.Dispose()
        ds = Nothing

        Dim seq As New clsSequenceAccess(txtTicketNumber.Text)

        sql = "INSERT INTO [TICKETSERVICETYPE] " &
            "(TICKETSERVICETYPEID, [TICKETID],[SERVICETYPEID]) VALUES ('"

        sql = sql & seq.TicketServiceTypeNextId & "','"
        sql = sql & txtTicketNumber.Text & "',"
        sql = sql & cbxServiceType.SelectedValue.ToString & ")"

        bdconn.ExecuteNonSQL(sql)

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing
        seq = Nothing

        AdjustTicketServiceType()

        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(txtTicketNumber.Text, "ACCESS")
        sync.Dispose()
        sync = Nothing

        CarregaTicketServiceType()

        cbxServiceType.SelectedValue = -1

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub CarregaTicketServiceType()
        'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETSERVICETYPE' table. You can move, or remove it, as needed.
        Me.TICKETSERVICETYPETableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETSERVICETYPE)
        TICKETSERVICETYPEBindingSource.Filter = "TICKETID='" & txtTicketNumber.Text & "'"
        dgvTicketServType.Refresh()
    End Sub

    Private Sub btnDeleteServiceLine_Click(sender As Object, e As EventArgs) Handles btnDeleteServiceLine.Click

        If dgvTicketServType.RowCount > 0 Then

            Me.Cursor = Cursors.WaitCursor

            Dim bdconn As New clsBancoDadosACCESS
            Dim sql As String

            bdconn.OpenConnection()

            sql = "DELETE FROM [TICKETSERVICETYPE] " &
                "WHERE TICKETSERVICETYPEID = '" & dgvTicketServType.CurrentRow.Cells("colTicketServiceTypeId").Value & "'"
            bdconn.ExecuteNonSQL(sql)

            bdconn.CloseConnection()
            bdconn.Dispose()
            bdconn = Nothing

            AdjustTicketServiceType()

            Dim sync As New clsSyncTicket
            sync.UpdateSyncDateTime(txtTicketNumber.Text, "ACCESS")
            sync.Dispose()
            sync = Nothing

            CarregaTicketServiceType()

            Me.Cursor = Cursors.Arrow

        End If

    End Sub

    Private Sub AdjustTicketServiceType()

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String
        Dim ds As New DataSet

        bdconn.OpenConnection()

        Dim sCode As String = ""
        Dim sDesc As String = ""

        sql = "SELECT SERVICETYPE.SERVICETYPECODE as CODE, SERVICETYPE.DESCRIPTION AS DESC1 " &
            "FROM TICKETSERVICETYPE INNER JOIN SERVICETYPE ON TICKETSERVICETYPE.SERVICETYPEID = SERVICETYPE.SERVICETYPEID " &
            "WHERE (((TICKETSERVICETYPE.TICKETID)='" & txtTicketNumber.Text & "'))"

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                If Not IsDBNull(ds.Tables(0).Rows(i)("CODE")) Then
                    If sCode <> "" Then
                        sCode = sCode & ", "
                    End If
                    sCode = sCode & ds.Tables(0).Rows(i)("CODE").ToString
                End If

                If Not IsDBNull(ds.Tables(0).Rows(i)("DESC1")) Then
                    If sDesc <> "" Then
                        sDesc = sDesc & ", "
                    End If
                    sDesc = sDesc & ds.Tables(0).Rows(i)("DESC1").ToString
                End If

            Next

            sql = "UPDATE TICKET SET " &
                "SERVICETYPEGRPCODE = " & util.SQLConvStrNull(sCode, "s") &
                ",SERVICETYPEGRPTEXT = " & util.SQLConvStrNull(sDesc, "s") &
                " WHERE TICKETID = '" & txtTicketNumber.Text & "'"
            bdconn.ExecuteNonSQL(sql)

        Else
            sql = "UPDATE TICKET SET " &
            "SERVICETYPEGRPCODE = NULL " &
            ",SERVICETYPEGRPTEXT = NULL " &
            " WHERE TICKETID = '" & txtTicketNumber.Text & "'"
            bdconn.ExecuteNonSQL(sql)
        End If


        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

    End Sub

    Private Sub btnSearchSite_Click(sender As Object, e As EventArgs) Handles btnSearchSite.Click
        Dim frm As New frmSearchSite
        frm.ShowDialog()

        If frm.sSiteId <> "" Then
            sSiteId = frm.sSiteId
            txtSiteId.Text = frm.sSiteAlias
        End If
        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub cbxServiceLine_LostFocus(sender As Object, e As EventArgs) Handles cbxServiceLine.LostFocus
        If sTicketNumberOld = "" Then
            CarregaCbxContract()
            CarregaCbxMoeda()
        End If

    End Sub

    Private Sub cbxServiceLine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxServiceLine.SelectedIndexChanged
        If sTicketNumberOld = "" Then
            CarregaCbxContract()
            CarregaCbxMoeda()
        End If

    End Sub

    Private Sub btnSearchWell_Click(sender As Object, e As EventArgs) Handles btnSearchWell.Click

        Dim frm As New frmSearchWell
        frm.ShowDialog()

        If frm._WellID <> "" Then
            sWellId = frm._WellID
            txtWellName.Text = frm._WellName
            txtRig.Text = frm._Rig
            If sSiteId = "" Then
                sSiteId = frm._SiteId
                txtSiteId.Text = frm._SiteAlias
            End If
        End If
        frm.Dispose()
        frm = Nothing

    End Sub

    Private Sub btnSearchRig_Click(sender As Object, e As EventArgs) Handles btnSearchRig.Click

        Dim frm As New frmSearchRig
        frm.ShowDialog()

        If frm._RigId <> "" Then
            txtRig.Text = frm._RigId
        End If
        frm.Dispose()
        frm = Nothing

    End Sub


#End Region

#Region "Ticket Detail"

    Private Sub GetNewTicketNumber()

        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT CONSEC, FULLCONSEC FROM CONSEC_NEXT_V WHERE USERNAME = '" & sUsername & "'"
        bdconnACCESS.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                txtTicketNumber.Text = ds.Tables(0).Rows(i)("FULLCONSEC").ToString()
                nTicketNumber = ds.Tables(0).Rows(i)("CONSEC")
            Next
        End If

        ds.Dispose()
        ds = Nothing

    End Sub

    Private Sub UpdateTicketNumber()
        Dim sql As String
        sql = "UPDATE CONSEC SET CONSEC = " & nTicketNumber.ToString & " WHERE USERNAME = '" & sUsername & "'"
        bdconnACCESS.ExecuteNonSQL(sql)
    End Sub

    Private Sub cbxTubingPipe_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cbxTubingPipe_SelectedIndexChanged(sender As Object, e As EventArgs)
        CarregaCbxTubing()
    End Sub

    Private Sub cbxTubingWeight_SelectedIndexChanged(sender As Object, e As EventArgs)
        CarregaCbxTubing()
    End Sub

    Private Sub cbxServiceType_GotFocus(sender As Object, e As EventArgs) Handles cbxServiceType.GotFocus
        CarregaCbxServiceType(True)
    End Sub

    Private Sub cbxServiceType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxServiceType.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxWell_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cbxContrRepres_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub CarregaCbxTubing()
        TUBBINGWEIGHTBindingSource.Filter = "DRILL_PIPE='" & cbxTubingPipe.Text & "'"
        cbxTubingWeight.Refresh()
        TUBINGBindingSource.Filter = "DRILL_PIPE='" & cbxTubingPipe.Text & "' AND WEIGHT='" & cbxTubingWeight.Text & "'"
        cbxTubingGrade.Refresh()
    End Sub

    Private Sub CarregaCbxCasing()
        CASINGWEIGHTBindingSource.Filter = "SIZEINC='" & cbxCasingSize.Text & "'"
        cbxCasingWeight.Refresh()
        CASINGBindingSource.Filter = "SIZEINC='" & cbxCasingSize.Text & "' AND WEIGHTFT='" & cbxCasingWeight.Text & "'"
        cbxCasingGrade.Refresh()

    End Sub

    Private Sub CarregaCbxContract()

        If IsNothing(cbxCustomer.SelectedValue) = True Then
            Exit Sub
        End If

        Dim sFilter As String = ""

        If cbxCustomer.SelectedValue.ToString <> "" Then
            sFilter = "CUSTOMERID='" & cbxCustomer.SelectedValue.ToString & "' "

            If sTicketNumberOld = "" Then

                If cbxServiceLine.Text <> "" Then
                    sFilter = sFilter & "AND SERVICELINEID=" & cbxServiceLine.SelectedValue.ToString & " "
                End If

                sFilter = sFilter & "AND ACTIVE = 'YES' "
                sFilter = sFilter & "AND START_DATE <= " & util.GetDateTime(True) & " "
                sFilter = sFilter & "AND COMPLETION_DATE >= " & util.GetDateTime(True) & " "
            End If

            CONTRACTBindingSource.Filter = sFilter
            cbxContract.Refresh()
            cbxContract.Enabled = True
        Else
            sFilter = "CUSTOMERID='-199'"
            CONTRACTBindingSource.Filter = sFilter
            cbxContract.Refresh()
            cbxContract.Enabled = False
        End If
    End Sub

    Private Sub CarregaCbxServiceType(ByVal bClick As Boolean)

        Dim sFilter As String = ""

        If bClick = True Then
            sFilter = sFilter & "ACTIVE = 'YES' "
        End If

        SERVICETYPEBindingSource.Filter = sFilter
        cbxServiceType.Refresh()

    End Sub

    Private Sub CarregaCbxServiceLine()

        Dim sFilter As String

        If cbxCustomer.Text <> "" Then

            sFilter = "CUSTOMERID='" & cbxCustomer.SelectedValue.ToString & "' "

            If sTicketNumberOld = "" Then
                sFilter = sFilter & "AND ACTIVE = 'YES' "
            End If
            SERVLINECUSTVBindingSource.Filter = sFilter
            cbxServiceLine.Refresh()
            cbxServiceLine.Enabled = True
        Else
            sFilter = "CUSTOMERID='-199'"
            SERVLINECUSTVBindingSource.Filter = sFilter
            cbxServiceLine.Refresh()
            cbxServiceLine.Enabled = False
        End If
    End Sub

    Public Sub CarregaCbxMoeda()

        If IsNothing(cbxContract.SelectedValue) Then
            CURRENCYBindingSource.Filter = "CURRENCYCODE='XXX'"
            cbxCurrency.Refresh()
            Exit Sub
        End If

        If util.TrataDBNull(cbxContract.SelectedValue).ToString <> "" Then

            Dim sql As String
            Dim ds As New DataSet

            sql = "SELECT CURRENCY FROM [CONTRACT] WHERE CONTRACTID = " & cbxContract.SelectedValue.ToString & " "
            bdconnACCESS.ExecuteSQL(sql, ds)

            If ds.Tables(0).Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    CURRENCYBindingSource.Filter = "CURRENCYCODE='" & ds.Tables(0).Rows(i)("CURRENCY").ToString & "'"
                Next
            Else
                CURRENCYBindingSource.Filter = "CURRENCYCODE='XXX'"
            End If
            cbxCurrency.Refresh()
            ds.Dispose()
            ds = Nothing

        Else
            CURRENCYBindingSource.Filter = "CURRENCYCODE='XXX'"
            cbxCurrency.Refresh()
        End If

    End Sub

    Private Sub cbxCasingSize_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub cbxCasingSize_SelectedIndexChanged(sender As Object, e As EventArgs)
        CarregaCbxCasing()
    End Sub

    Private Sub cbxCasingWeight_SelectedIndexChanged(sender As Object, e As EventArgs)
        CarregaCbxCasing()
    End Sub

    Private Sub cbxCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCustomer.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxServiceLine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxServiceLine.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCustomer.SelectedIndexChanged
        If sTicketNumberOld = "" Then
            CarregaCbxServiceLine()
            CarregaCbxContract()
            CarregaCbxMoeda()
        End If
    End Sub

    Private Sub cbxContract_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxContract.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxContract_LostFocus(sender As Object, e As EventArgs) Handles cbxContract.LostFocus
        If sTicketNumberOld = "" Then
            CarregaCbxMoeda()
        End If
    End Sub

    Private Sub cbxContract_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxContract.SelectedIndexChanged
        If sTicketNumberOld = "" Then
            CarregaCbxMoeda()
        End If

    End Sub
    Private Sub mnuInvItem_Click(sender As Object, e As EventArgs) Handles mnuInvItem.Click

        If dgvTicketServType.RowCount = 0 Then
            MsgBox("Inform the Service Line", vbExclamation)
            Me.Cursor = Cursors.Arrow
            Exit Sub
        End If

        Dim frm As New frmTicketInvItemMain

        With frm
            .sTicketID = txtTicketNumber.Text
            .sUsername = Me.sUsername
            .bTicketReadOnly = Me.bTicketReadOnly
            .ShowDialog()
        End With

        bNoInvItem = frm.chkNoInvItem.Checked
        frm.Dispose()
        frm = Nothing

    End Sub

    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuSaveTicket.Click


        If cbxServiceLine.Text = "" Then
            MsgBox("Inform the Service Line", vbExclamation)
            Exit Sub
        End If

        If cbxCustomer.Text = "" Then
            MsgBox("Inform the Customer", vbExclamation)
            Exit Sub
        End If

        If dtpServiceDate.Text = "" Then
            MsgBox("Inform the Service Date", vbExclamation)
            Exit Sub
        End If

        If cbxContract.Text = "" Then
            MsgBox("Inform the Contract", vbExclamation)
            Exit Sub
        End If

        If cbxCurrency.Text = "" Then
            MsgBox("Inform the Currency", vbExclamation)
            Exit Sub
        End If

        If dtpTimeArrived.Text = "" Then
            MsgBox("Inform the Time Arrived", vbExclamation)
            Exit Sub
        End If

        If dtpTimeStarted.Text = "" Then
            MsgBox("Inform the Time Started", vbExclamation)
            Exit Sub
        End If

        If dtpTimeCompleted.Text = "" Then
            MsgBox("Inform the Time Completed", vbExclamation)
            Exit Sub
        End If

        If txtWellName.Text = "" Then
            MsgBox("Inform the Well Type", vbExclamation)
            Exit Sub
        End If

        If txtCustRepres.Text = "" Then
            MsgBox("Inform the Customer Representative", vbExclamation)
            Exit Sub
        End If

        If txtCustRepresPosition.Text = "" Then
            MsgBox("Inform the Customer Representative Position", vbExclamation)
            Exit Sub
        End If

        If sContrRepresId = "" Then
            MsgBox("Inform the Contractor Representative", vbExclamation)
            Exit Sub
        End If

        If sSiteId = "" Then
            MsgBox("Inform the Site", vbExclamation)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim sql As String
        Dim ds As New DataSet

        If sTicketNumberOld = "" Then

            Dim sMsg As String = "The following CUSTOMER and CONTRACT are used by new ticket." & Environment.NewLine &
                "Customer: " & cbxCustomer.Text & Environment.NewLine &
                "Contract: " & cbxContract.Text & Environment.NewLine & Environment.NewLine &
                "This information cannot be change after safe. Continue?"

            If MsgBox(sMsg, vbYesNo) = vbNo Then
                Me.Cursor = Cursors.Arrow
                Exit Sub
            End If

            sql = "INSERT INTO [TICKET] " &
                "([TICKETID],[DATESERVICE],[CUSTOMERID],[CONTRACTID],[CURRENCYID] " &
                ",[WELLID],[TIMEARRIVED],[TIMESTARTED],[TIMECOMPLETED] " &
                ",[CASINGSIZE],[CASINGWEIGHT],[CASINGGRADE],[TUBINGSIZE],[TUBINGWEIGHT] " &
                ",[TUBINGGRADE],[PRESSUREMAX],[DEPTHMAX],[JOBDESCRIPTION],[CUSTREPRES] " &
                ",[CUSTREPRESPOSITION],[CUSTREPRESASSIST],[CUSTREPRESASSISTPOSITION],[CONTRACTORREPRESENTATIVE] " &
                ",[CUSTCOMMENTS],[CONTRACTCOMMENTS],[ADICINFORM],[CREATEDUSER],[CREATEDDATETIME]  " &
                ",[UPDATEDDATETIME],[UPDATEDUSER],[SyncDB],EXCHANGERATE,TICKETSTATUS,SERVICELINEID,RIGID,SUPERIORNUM,DM,JOBNUMBER,SERVICEORDERNUM,SITEID," &
                "HOURTRAVEL,HOUROPERATION,HOURSTANDBY,HOURLOST,HOURQDE,SUPERIORSUPERVISOR) VALUES ("

            sql = sql & util.SQLConvStrNull(txtTicketNumber.Text, "s") & ","
            sql = sql & util.SQLConvStrDate(dtpServiceDate.Value.ToString) & ","
            sql = sql & util.SQLConvStrNull(cbxCustomer.SelectedValue, "s") & ","
            sql = sql & util.SQLConvStrNull(cbxContract.SelectedValue, "n") & ","
            sql = sql & util.SQLConvStrNull(cbxCurrency.SelectedValue, "s") & ","
            sql = sql & util.SQLConvStrNull(sWellId, "s") & ","
            sql = sql & util.SQLConvStrDatetime(dtpTimeArrived.Value.ToString) & ","
            sql = sql & util.SQLConvStrDatetime(dtpTimeStarted.Value.ToString) & ","
            sql = sql & util.SQLConvStrDatetime(dtpTimeCompleted.Value.ToString) & ","
            sql = sql & util.SQLConvStrNull(cbxCasingSize.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(cbxCasingWeight.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(cbxCasingGrade.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(cbxTubingPipe.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(cbxTubingWeight.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(cbxTubingGrade.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtMaxPressure.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtMaxDepth.Text, "n") & ","
            sql = sql & util.SQLConvStrNull(txtJobDescription.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtCustRepres.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtCustRepresPosition.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtCustRepresAssist.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtCustRepresAssistPos.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(sContrRepresId, "s") & ","
            sql = sql & util.SQLConvStrNull(txtCustComments.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtContrComments.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtAdicInform.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(sUsername, "s") & "," & util.GetDateTime() & ",NULL,NULL,0,"

            If cbxCurrency.SelectedValue = "USD" Then
                sql = sql & "0,'Open',"
            Else
                sql = sql & "1,'Open',"
            End If
            sql = sql & util.SQLConvStrNull(cbxServiceLine.SelectedValue, "n") & ","
            sql = sql & util.SQLConvStrNull(txtRig.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSupNum.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtDM.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtJobNumber.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(txtSONumber.Text, "s") & ","
            sql = sql & util.SQLConvStrNull(sSiteId, "s") & ",0,0,0,0,0,"
            sql = sql & util.SQLConvStrNull(sSuperiorSupervisorId, "s") & ")"

            bdconnACCESS.ExecuteNonSQL(sql)

            UpdateTicketNumber()

            TabControl1.TabPages.Add(tabSalesItem)
            If bShowTabOperReport = True Then
                TabControl1.TabPages.Add(tabOperReport)
            End If
            TabControl1.TabPages.Add(tabEquipments)
            TabControl1.TabPages.Add(tabWorkers)
            If bShowTabServEvalHSEQ = True Then
                TabControl1.TabPages.Add(tabServEvalHSEQ)
            End If


            sTicketNumberOld = txtTicketNumber.Text
            pnlTicketObjects(False)
            mnuPrint.Enabled = True
            mnuCloseTicket.Enabled = True
            mnuAttachment.Enabled = True
            grpServiceType.Visible = True

            InitEquipment()
            InitSalesItem()

            If bShowTabOperReport = True Then
                InitOperReport()
            End If

            If bShowTabServEvalHSEQ = True Then
                InitHSEQServEval()
            End If

            LoadTicketOpeHour()
        Else

            If dgvTicketServType.RowCount = 0 Then
                MsgBox("Inform the Service Line", vbExclamation)
                Me.Cursor = Cursors.Arrow
                Exit Sub
            End If

            sql = "UPDATE [TICKET] SET " &
                " [DATESERVICE] = " & util.SQLConvStrDate(dtpServiceDate.Value.ToString) & " " &
                ",[CUSTOMERID] = " & util.SQLConvStrNull(cbxCustomer.SelectedValue, "s") & " " &
                ",[CONTRACTID] = " & util.SQLConvStrNull(cbxContract.SelectedValue, "n") & " " &
                ",[CURRENCYID] = " & util.SQLConvStrNull(cbxCurrency.SelectedValue, "s") & " " &
                ",[WELLID] = " & util.SQLConvStrNull(sWellId, "s") & " " &
                ",[TIMEARRIVED] = " & util.SQLConvStrDatetime(dtpTimeArrived.Value.ToString) & " " &
                ",[TIMESTARTED] = " & util.SQLConvStrDatetime(dtpTimeStarted.Value.ToString) & " " &
                ",[TIMECOMPLETED] = " & util.SQLConvStrDatetime(dtpTimeCompleted.Value.ToString) & " " &
                ",[CASINGSIZE] = " & util.SQLConvStrNull(cbxCasingSize.Text, "s") & " " &
                ",[CASINGWEIGHT] = " & util.SQLConvStrNull(cbxCasingWeight.Text, "s") & " " &
                ",[CASINGGRADE] = " & util.SQLConvStrNull(cbxCasingGrade.Text, "s") & " " &
                ",[TUBINGSIZE] = " & util.SQLConvStrNull(cbxTubingPipe.Text, "s") & " " &
                ",[TUBINGWEIGHT] = " & util.SQLConvStrNull(cbxTubingWeight.Text, "s") & " " &
                ",[TUBINGGRADE] = " & util.SQLConvStrNull(cbxTubingGrade.Text, "s") & " " &
                ",[PRESSUREMAX] = " & util.SQLConvStrNull(txtMaxPressure.Text, "n") & " " &
                ",[DEPTHMAX] = " & util.SQLConvStrNull(txtMaxDepth.Text, "n") & " " &
                ",[JOBDESCRIPTION] = " & util.SQLConvStrNull(txtJobDescription.Text, "s") & " " &
                ",[CUSTREPRES] = " & util.SQLConvStrNull(txtCustRepres.Text, "s") & " " &
                ",[CUSTREPRESPOSITION] = " & util.SQLConvStrNull(txtCustRepresPosition.Text, "s") & " " &
                ",[CUSTREPRESASSIST] = " & util.SQLConvStrNull(txtCustRepresAssist.Text, "s") & " " &
                ",[CUSTREPRESASSISTPOSITION] = " & util.SQLConvStrNull(txtCustRepresAssistPos.Text, "s") & " " &
                ",[CONTRACTORREPRESENTATIVE] = " & util.SQLConvStrNull(sContrRepresId, "s") & " " &
                ",[CUSTCOMMENTS] = " & util.SQLConvStrNull(txtCustComments.Text, "s") & " " &
                ",[CONTRACTCOMMENTS] = " & util.SQLConvStrNull(txtContrComments.Text, "s") & " " &
                ",[UPDATEDDATETIME] = " & util.GetDateTime() & " " &
                ",[UPDATEDUSER] = " & util.SQLConvStrNull(sUsername, "s") & " " &
                ",[ADICINFORM] = " & util.SQLConvStrNull(txtAdicInform.Text, "s") & " " &
                ",[SERVICELINEID] = " & util.SQLConvStrNull(cbxServiceLine.SelectedValue, "n") & " " &
                ",[RIGID] = " & util.SQLConvStrNull(txtRig.Text, "s") & " " &
                ",[SUPERIORNUM] = " & util.SQLConvStrNull(txtSupNum.Text, "s") & " " &
                ",[DM] = " & util.SQLConvStrNull(txtDM.Text, "s") & " " &
                ",[JOBNUMBER] = " & util.SQLConvStrNull(txtJobNumber.Text, "s") & " " &
                ",[SERVICEORDERNUM] = " & util.SQLConvStrNull(txtSONumber.Text, "s") & " " &
                ",[SITEID] = " & util.SQLConvStrNull(sSiteId, "s") & " " &
                ",[SUPERIORSUPERVISOR] = " & util.SQLConvStrNull(sSuperiorSupervisorId, "s") & " " &
                " WHERE " &
                "[TICKETID] = '" & txtTicketNumber.Text & "'"

            bdconnACCESS.ExecuteNonSQL(sql)

        End If

        If cbxCustomer.SelectedValue = "830126302" Then
            FronteraToolStripMenuItem.Visible = True
        End If

        Me.SyncServer()
        Me.Cursor = Cursors.Arrow
        MsgBox("Ticket Saved but not Synchronized", vbInformation)

    End Sub

#End Region

#Region "Sales Item and Inventory"

    Private Sub InitSalesItem()

        Try
            pnlSalesItem.Controls.Clear()
            Dim form As New frmSalesItemL01
            form.TopLevel = False
            form.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            form.sTicketID = txtTicketNumber.Text
            form.sContractId = cbxContract.SelectedValue.ToString
            form.sUsername = Me.sUsername
            form.bTicketReadOnly = Me.bTicketReadOnly
            form.txtExchangeRate.Text = sExchangeRate
            form.Show()
            pnlSalesItem.Controls.Add(form)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

#End Region

#Region "Equipments"

    Private Sub InitEquipment()
        Try
            pnlEquipment.Controls.Clear()
            Dim form As New frmTicketEquipment
            form.TopLevel = False
            form.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            form.sTicketId = txtTicketNumber.Text
            form.bTicketReadOnly = Me.bTicketReadOnly
            form.Show()
            pnlEquipment.Controls.Add(form)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Workers"
    Private Sub LoadWorkers()
        Try
            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETWORKER' table. You can move, or remove it, as needed.
            Me.TICKETWORKERTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETWORKER)

            TICKETWORKERBindingSource.Filter = "TICKETID='" & txtTicketNumber.Text & "'"
            dgvWorker.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnWAdd_Click(sender As Object, e As EventArgs) Handles btnWAdd.Click
        Dim frm As New frmTicketWorkerEdit

        With frm
            .sTicketId = txtTicketNumber.Text
            .txtHourQde.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvTicketOpeHour.CurrentRow.Cells("colOpHourQde").Value))
            .txtHourTravel.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvTicketOpeHour.CurrentRow.Cells("colOpHourTravel").Value))
            .txtHourOperation.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvTicketOpeHour.CurrentRow.Cells("colOpHourOperation").Value))
            .txtHourStandby.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvTicketOpeHour.CurrentRow.Cells("colOpHourStandby").Value))
            .txtHourLost.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvTicketOpeHour.CurrentRow.Cells("colOpHourLost").Value))
            .ShowDialog()
            .Dispose()
        End With
        frm.Dispose()
        frm = Nothing
        LoadWorkers()
    End Sub

    Private Sub dgvWorker_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvWorker.CellDoubleClick
        If bTicketReadOnly = False Then
            Try
                Dim frm As New frmTicketWorkerEdit

                With frm
                    .sTicketWorkerId = util.TrataDBNull(dgvWorker.CurrentRow.Cells("colWTicketWorkerID").Value)
                    .sTicketId = txtTicketNumber.Text
                    .txtFullName.Text = util.TrataDBNull(dgvWorker.CurrentRow.Cells("colWFullName").Value.ToString)
                    .txtAppointment.Text = util.TrataDBNull(dgvWorker.CurrentRow.Cells("colWAppoint").Value)
                    .dtpRegisterDate.Value = util.TrataDBNull(dgvWorker.CurrentRow.Cells("colWRegisterDate").Value)
                    .txtHourQde.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvWorker.CurrentRow.Cells("colWHourQde").Value))

                    .txtHourTravel.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvWorker.CurrentRow.Cells("colHourTravel").Value))
                    .txtHourOperation.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvWorker.CurrentRow.Cells("colHourOperation").Value))
                    .txtHourStandby.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvWorker.CurrentRow.Cells("colHourStandby").Value))
                    .txtHourLost.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvWorker.CurrentRow.Cells("colHourLost").Value))
                    .txtActivityResume.Text = util.TrataDBNull(dgvWorker.CurrentRow.Cells("colResumeActivity").Value)
                    .ShowDialog()
                    .Dispose()
                End With
                frm = Nothing
                LoadWorkers()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub LoadTicketOpeHour()

        Try
            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.TICKETOPEHOUR' table. You can move, or remove it, as needed.
            Me.TICKETOPEHOURTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKETOPEHOUR)

            TICKETOPEHOURBindingSource.Filter = "TICKETID='" & txtTicketNumber.Text & "'"
            dgvTicketOpeHour.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvTicketOpeHour_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTicketOpeHour.CellDoubleClick
        If bTicketReadOnly = False Then
            Try
                Dim frm As New frmTicketOpeHourTotal

                With frm
                    .sTicketId = txtTicketNumber.Text
                    .txtHourQde.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvTicketOpeHour.CurrentRow.Cells("colOpHourQde").Value))
                    .txtHourTravel.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvTicketOpeHour.CurrentRow.Cells("colOpHourTravel").Value))
                    .txtHourOperation.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvTicketOpeHour.CurrentRow.Cells("colOpHourOperation").Value))
                    .txtHourStandby.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvTicketOpeHour.CurrentRow.Cells("colOpHourStandby").Value))
                    .txtHourLost.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvTicketOpeHour.CurrentRow.Cells("colOpHourLost").Value))
                    .ShowDialog()
                    .Dispose()
                End With
                frm = Nothing
                LoadTicketOpeHour()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnSearchWorker_Click(sender As Object, e As EventArgs) Handles btnSearchWorker.Click
        Dim frm As New frmSearchWorker
        With frm
            .ShowDialog()
        End With

        If frm.WorkerId <> "" Then
            sContrRepresId = frm.WorkerId
            txtContrRepres.Text = frm.FullName
        End If

        frm.Dispose()
        frm = Nothing
    End Sub

#End Region

#Region "Operational Report"

    Private Sub InitOperReport()
        Try
            pnlOperReport.Controls.Clear()
            Dim form As New frmTicketOperReport
            form.TopLevel = False
            form.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            form.sTicketID = txtTicketNumber.Text
            form.sUsername = Me.sUsername
            form.bTicketReadOnly = Me.bTicketReadOnly
            form.Show()
            pnlOperReport.Controls.Add(form)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "HSEQ - Service Evaluation"

    Private Sub InitHSEQServEval()
        Try
            pnlHSEQServEval.Controls.Clear()
            Dim form As New frmTicketServEvalHSEQ
            form.TopLevel = False
            form.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            form.sTicketId = txtTicketNumber.Text
            form.bTicketReadOnly = Me.bTicketReadOnly
            form.Show()
            pnlHSEQServEval.Controls.Add(form)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "SyncTicket"
    Private Sub mnuCloseTicket_Click(sender As Object, e As EventArgs) Handles mnuCloseTicket.Click

        If dgvTicketServType.RowCount = 0 Then
            MsgBox("Inform the Service Line", vbExclamation)
            Me.Cursor = Cursors.Arrow
            Exit Sub
        End If

        'Checking if the Ticket has Inventory
        If CheckHasInfItem() = False Then
            Dim text As String
            text = "The Inventory Itens is not defined." & Environment.NewLine &
                "For this reason the ticket print is not availlable" & Environment.NewLine &
                "Please, define the Inventory and, after that, return for this option"
            MsgBox(text, vbInformation)
            Exit Sub
        End If

        If MsgBox("The Ticket will be close and Sync with Server. After that no more changes are allowed. Do you want continue?", vbYesNo) = vbYes Then
            Me.Cursor = Cursors.WaitCursor
            Dim sync As New clsSyncTicket
            sync.sUsername = Me.sUsername
            sync.CloseTicket(txtTicketNumber.Text, "ACCESS")

            If bIsSQLConnect = True Then
                Dim frm As New frmSyncTicket
                frm.sUsername = Me.sUsername
                frm.ShowDialog()
                frm.Dispose()
                frm = Nothing
            End If

            Me.Cursor = Cursors.Arrow

            If bIsSQLConnect = False Then
                MsgBox("The server is offline. The Ticket will be synchronize when the server is online again.")
                sync.Dispose()
                sync = Nothing
                Me.Dispose()
            Else
                sync.Dispose()
                sync = Nothing
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub SyncServer()
        Me.Cursor = Cursors.WaitCursor
        Dim sync As New clsSyncTicket
        sync.UpdateSyncDateTime(txtTicketNumber.Text, "ACCESS")
        sync.Dispose()
        sync = Nothing
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub TicketEnable()

        Dim bEnabled As Boolean
        Dim bReadOnly As Boolean

        If bTicketReadOnly = True Then
            bReadOnly = True
            bEnabled = False
        Else
            bReadOnly = False
            bEnabled = True
        End If

        'Details
        dtpServiceDate.Enabled = bEnabled
        dtpTimeArrived.Enabled = bEnabled
        dtpTimeStarted.Enabled = bEnabled
        dtpTimeCompleted.Enabled = bEnabled
        cbxServiceType.Enabled = bEnabled
        cbxTubingPipe.Enabled = bEnabled
        cbxTubingWeight.Enabled = bEnabled
        cbxTubingGrade.Enabled = bEnabled
        cbxCasingSize.Enabled = bEnabled
        cbxCasingWeight.Enabled = bEnabled
        cbxCasingGrade.Enabled = bEnabled
        txtMaxPressure.Enabled = bEnabled
        txtMaxDepth.Enabled = bEnabled
        txtJobDescription.ReadOnly = bReadOnly
        txtCustRepres.ReadOnly = bReadOnly
        txtCustRepresPosition.ReadOnly = bReadOnly
        txtCustRepresAssist.ReadOnly = bReadOnly
        txtCustRepresAssistPos.ReadOnly = bReadOnly
        txtCustComments.ReadOnly = bReadOnly
        txtContrComments.ReadOnly = bReadOnly
        btnSearchWell.Visible = bEnabled
        btnSearchRig.Visible = bEnabled
        btnSearchSite.Visible = bEnabled
        btnSearchWorker.Visible = bEnabled
        btnSearchSupervisor.Visible = bEnabled

        btnAddServiceType.Visible = bEnabled
        btnDeleteServiceLine.Visible = bEnabled

        'Workers
        btnWAdd.Enabled = bEnabled

        'Adictional Information
        txtAdicInform.Enabled = bEnabled
        txtSupNum.Enabled = bEnabled
        txtDM.Enabled = bEnabled
        txtJobNumber.Enabled = bEnabled
        txtSONumber.Enabled = bEnabled

        'Buttons
        mnuSaveTicket.Enabled = bEnabled
        mnuCloseTicket.Enabled = bEnabled

    End Sub

#End Region

#Region "Attachment"
    Private Sub mnuAttachment_Click(sender As Object, e As EventArgs) Handles mnuAttachment.Click

        If dgvTicketServType.RowCount = 0 Then
            MsgBox("Inform the Service Line", vbExclamation)
            Me.Cursor = Cursors.Arrow
            Exit Sub
        End If

        Dim frm As New frmTicketFile
        With frm
            .sTicketId = txtTicketNumber.Text
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub
#End Region

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
              "and obj.OBJECTFORM = 'frmTicket' " &
              "and usr.USERNAME = '" & Me.sUsername & "'"

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim sObject As String = ""

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                sObject = ds.Tables(0).Rows(i)("OBJECTNAME")

                If sObject = "bShowServiceTicketARG" Then

                ElseIf sObject = "grpAddicInfoARG" Then
                    grpAddicInfoARG.Visible = False
                ElseIf sObject = "tabOperReport" Then
                    bShowTabOperReport = False
                    mnuJobLog.Visible = False
                    ToolStripSeparator1.Visible = False
                ElseIf sObject = "tabServEvalHSEQ" Then
                    bShowTabServEvalHSEQ = False
                ElseIf sObject = "mnuActaIniFimOpe" Then
                    mnuActaIniFimOpe.Visible = False
                End If
            Next

        End If

        ds.Dispose()
        ds = Nothing

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub btnSearchSupervisor_Click(sender As Object, e As EventArgs) Handles btnSearchSupervisor.Click
        Dim frm As New frmSearchWorker
        With frm
            .ShowDialog()
        End With

        If frm.WorkerId <> "" Then
            sSuperiorSupervisorId = frm.WorkerId
            txtSuperiorSupervisor.Text = frm.FullName
        End If

        frm.Dispose()
        frm = Nothing
    End Sub

    Public Sub FronteraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FronteraToolStripMenuItem.Click

        Dim sFilePathTmp As String = Directory.GetCurrentDirectory().Replace("\app", "\") & "\file\tmp"
        Dim sFileOrig As String
        Dim sNewName As String = sFilePathTmp & "\" & Replace(System.Guid.NewGuid.ToString, "-", "") & ".xlsx"

        sFileOrig = "C:\SESTicket\app\Reports\xlsx\ticketFrontera.xlsx"

        If (System.IO.Directory.Exists(sFilePathTmp) = False) Then
            System.IO.Directory.CreateDirectory(sFilePathTmp)
        End If

        System.IO.File.Copy(sFileOrig, sNewName)

        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection()

        Dim sql As String
        Dim ds As New DataSet
        Dim result As Boolean = False

        'Header document
        sql = " SELECT CONTRACT.CURRENCY,TICKET.TICKETID,CONTRACT.CONTRACTNUMBER,WORKER.FULLNAME AS CONTRACTOR_NAME, WORKER.APPOINTMENT AS CONTRACTOR_POSITION, " &
                    " CUSTOMER.NAME AS CUSTOMERNAME ,TICKET.TIMESTARTED,TICKET.TIMECOMPLETED,WELL.NAME AS WELL_NAME,PETRFIELD.DESCRIP AS PETRFIELDDESC " &
                    " ,TICKET.CUSTREPRESPOSITION,TICKET.CUSTREPRES,TICKET.JOBDESCRIPTION, " &
                    " WORKER.EMAIL AS CONTRACTOR_EMAIL, WORKER.PHONE,TICKET.CONTRACTCOMMENTS " &
                    " FROM (((((TICKET INNER JOIN CUSTOMER ON TICKET.CUSTOMERID = CUSTOMER.CUSTOMERID)  " &
                    " INNER JOIN CONTRACT ON TICKET.CONTRACTID = CONTRACT.CONTRACTID) LEFT JOIN WELL ON TICKET.WELLID = WELL.WELLID)  " &
                    " LEFT JOIN WORKER ON TICKET.CONTRACTORREPRESENTATIVE = WORKER.WORKERID) LEFT JOIN REPORTPARAM ON CONTRACT.REPORTPARAMID = REPORTPARAM.REPORTPARAMID) " &
                    " LEFT JOIN PETRFIELD ON WELL.PETRFIELDID = PETRFIELD.PETRFIELDID  " &
                    " WHERE TICKET.TICKETID = '" & txtTicketNumber.Text & "'"

        bdconn.ExecuteSQL(sql, ds)

        Dim xlApp As Excel.Application = Nothing
        Dim xlWorkBooks As Excel.Workbooks = Nothing
        Dim xlWorkBook As Excel.Workbook = Nothing
        Dim xlWorkSheet As Excel.Worksheet = Nothing
        Dim xlWorkSheets As Excel.Sheets = Nothing
        Dim xlCells As Excel.Range = Nothing

        xlApp = New Excel.Application
        xlApp.DisplayAlerts = False
        xlWorkBooks = xlApp.Workbooks
        xlWorkBook = xlWorkBooks.Open(sNewName)
        xlApp.Visible = False
        xlWorkSheets = xlWorkBook.Sheets

        'Open an existing document.  
        xlWorkSheet = CType(xlWorkSheets(1), Excel.Worksheet)

        Dim sValue As Object

        If ds.Tables(0).Rows.Count > 0 Then

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1

                sValue = "'" & util.TrataDBNull(ds.Tables(0).Rows(i)("TICKETID").ToString)
                ReplaceExcelText(xlApp, "!TICKETID", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTNUMBER").ToString)
                ReplaceExcelText(xlApp, "!CONTRACTNUMBER", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTOR_NAME").ToString)
                ReplaceExcelText(xlApp, "!CONTRACTOR_NAME", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTOR_POSITION").ToString)
                ReplaceExcelText(xlApp, "!CONTRACTOR_POSITION", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CUSTOMERNAME").ToString)
                ReplaceExcelText(xlApp, "!CUSTOMERNAME", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("TIMESTARTED").ToString) & " - " & util.TrataDBNull(ds.Tables(0).Rows(i)("TIMECOMPLETED").ToString)
                ReplaceExcelText(xlApp, "!PERIODO", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("TIMECOMPLETED").ToString)
                ReplaceExcelText(xlApp, "!TIMECOMPLETED", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("WELL_NAME").ToString)
                ReplaceExcelText(xlApp, "!WELL_NAME", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("PETRFIELDDESC").ToString)
                ReplaceExcelText(xlApp, "!PETRFIELDDESC", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CUSTREPRESPOSITION").ToString)
                ReplaceExcelText(xlApp, "!CUSTREPRESPOSITION", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CUSTREPRES").ToString)
                ReplaceExcelText(xlApp, "!CUSTREPRES", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("JOBDESCRIPTION").ToString)
                ReplaceExcelText(xlApp, "!JOBDESCRIPTION", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTOR_EMAIL").ToString)
                ReplaceExcelText(xlApp, "!CONTRACTOR_EMAIL", sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("PHONE").ToString)
                ReplaceExcelText(xlApp, "!PHONE", sValue)

                Dim sText As String = util.TrataDBNull(ds.Tables(0).Rows(i)("CONTRACTCOMMENTS").ToString)
                ReplaceExcelTextLarge(xlApp, "!CONTRACTCOMMENTS", sText)

            Next

        End If
        ds.Dispose()
        ds = Nothing

        'LINES
        Dim nCount As Integer = 1
        Dim sField As String = ""
        Dim Sum_Total_antes_IVA As Double = 0
        Dim Sum_Total_con_IVA As Double = 0
        Dim Vl_IVA As Decimal
        Dim Vl_Utility As Decimal
        Dim TypeService As String
        Dim nRowNumber As Decimal = 26 'Begin Row Lines

        ds = New DataSet
        sql = " SELECT " &
                "  SALESITEM_V.TYPE " &
                " ,SALESITEM_V.CUSTCODEITEM AS ITEM " &
                " ,ITEMQTY AS CANTIDAD " &
                " ,UNIT_SALE AS UNIDAD " &
                " ,CURRENCYID AS MONEDA " &
                " ,Left(DESCRIPTION,254) as DESCRIPCION " &
                " ,switch ( TICKET.CURRENCYID ='USD' " &
                " 				,Round(PRICEUNITUSD,PRICEUNITDECIMAL) " &
                " 		, TICKET.CURRENCYID ='COP' " &
                " 				,Round(PRICEUNIT,PRICEUNITDECIMAL) ) AS VALOR_UNITARIO " &
                " ,Round(ITEMDISCVALUEUSD,2) AS VALOR_DESCUENTO " &
                " ,switch ( TICKET.CURRENCYID ='USD' " &
                " 			,round(ITEMAMOUNTUSD,2) " &
                " 		, TICKET.CURRENCYID ='COP' " &
                " 			,Round(ITEMAMOUNTNODISC,2) ) AS VALOR_TOTAL_ANTES_IVA " &
                " ,CStr(SALESITEM_V.SERVICE_IVA_PERC)+ '% (U '+ CStr(SALESITEM_V.SERVICE_UTILITY_PERC) +'%) ' AS IVA " &
                " ,switch ( TICKET.CURRENCYID ='USD' " &
                " 			,Round((round(ITEMAMOUNTUSD,2) + ((round(ITEMAMOUNTUSD,2) * (SERVICE_UTILITY_PERC / 100)) * (SERVICE_IVA_PERC / 100))),2), " &
                " 		TICKET.CURRENCYID ='COP' " &
                " 			,Round((ITEMAMOUNTNODISC + ((ITEMAMOUNTNODISC * (SERVICE_UTILITY_PERC / 100)) * (SERVICE_IVA_PERC / 100))),2) ) AS VALOR_TOTAL_CON_IVA " &
                " ,switch (SALESITEM_V.TYPE='Service' " &
                " 			,SALESITEM_V.SERVICE_IVA_PERC " &
                " 		,SALESITEM_V.TYPE='Material' " &
                " 			,SALESITEM_V.MATERIAL_IVA_PERC) as Vl_IVA " &
                " 			,(SALESITEM_V.SERVICE_UTILITY_PERC) as Vl_UTILITY " &
                " From SALESITEM_V INNER Join TICKET On SALESITEM_V.TICKETID=TICKET.TICKETID " &
                "  Where SALESITEM_V.TICKETID = '" & txtTicketNumber.Text & "'"

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                Dim valor As Double
                Dim resultado As String

                TypeService = util.TrataDBNull(ds.Tables(0).Rows(i)("TYPE"))

                sValue = "'" & util.TrataDBNull(ds.Tables(0).Rows(i)("ITEM"))
                sField = "!ITEM" & nCount.ToString("00")
                ReplaceExcelText(xlApp, sField, sValue)

                sValue = "'" & util.TrataDBNull(ds.Tables(0).Rows(i)("CANTIDAD"))
                sField = "!CANTIDAD" & nCount.ToString("00")
                ReplaceExcelText(xlApp, sField, sValue)


                sValue = "'" & util.TrataDBNull(ds.Tables(0).Rows(i)("UNIDAD"))
                sField = "!UNIDAD" & nCount.ToString("00")
                ReplaceExcelText(xlApp, sField, sValue)

                sValue = "'" & util.TrataDBNull(ds.Tables(0).Rows(i)("MONEDA"))
                sField = "!MONEDA" & nCount.ToString("00")
                ReplaceExcelText(xlApp, sField, sValue)

                sValue = "'" & util.TrataDBNull(ds.Tables(0).Rows(i)("DESCRIPCION"))
                sField = "!DESCRIPCION" & nCount.ToString("00")
                ReplaceExcelText(xlApp, sField, sValue)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("VALOR_UNITARIO"))
                sField = "!VALOR_UNITARIO" & nCount.ToString("00")
                ' Dar formato a los datos
                valor = sValue
                resultado = String.Format("{0:#,0.00}", valor).Replace(",", "X").Replace(".", ",").Replace("X", ".")
                ReplaceExcelText(xlApp, sField, "'$ " & resultado)

                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("VALOR_DESCUENTO"))
                sField = "!VALOR_DESCUENTO" & nCount.ToString("00")
                ' Dar formato a los datos
                valor = sValue
                resultado = String.Format("{0:#,0.00}", valor).Replace(",", "X").Replace(".", ",").Replace("X", ".")
                ReplaceExcelText(xlApp, sField, "'$ " & resultado)

                ' Obtener el valor como cadena y convertirlo a Double
                sValue = util.TrataDBNull(ds.Tables(0).Rows(i)("VALOR_TOTAL_ANTES_IVA"))
                Sum_Total_antes_IVA = Math.Round(sValue + Sum_Total_antes_IVA, 2)
                sField = "!VALOR_TOTAL_ANTES_IVA" & nCount.ToString("00")
                ' Dar formato a los datos
                valor = sValue
                resultado = String.Format("{0:#,0.00}", valor).Replace(",", "X").Replace(".", ",").Replace("X", ".")
                ReplaceExcelText(xlApp, sField, "'$ " & resultado)

                Dim val_total_Ival_por_Linea As Double

                Vl_IVA = util.TrataDBNull(ds.Tables(0).Rows(i)("Vl_IVA")) / 100
                Vl_Utility = util.TrataDBNull(ds.Tables(0).Rows(i)("Vl_UTILITY")) / 100


                If TypeService = "Service" Then
                    sValue = "'" & util.TrataDBNull(ds.Tables(0).Rows(i)("Vl_IVA")) & "% (U " & util.TrataDBNull(ds.Tables(0).Rows(i)("Vl_UTILITY")) & "%)"

                    val_total_Ival_por_Linea = util.TrataDBNull(ds.Tables(0).Rows(i)("VALOR_TOTAL_CON_IVA"))

                Else
                    Dim val As Double = (util.TrataDBNull(ds.Tables(0).Rows(i)("VALOR_TOTAL_ANTES_IVA")))
                    val_total_Ival_por_Linea = (val * Vl_IVA) + val

                    sValue = "'" & util.TrataDBNull(ds.Tables(0).Rows(i)("Vl_IVA")) & "%"
                End If

                sField = "!IVA" & nCount.ToString("00")
                ReplaceExcelText(xlApp, sField, sValue)

                Sum_Total_con_IVA = Math.Round(val_total_Ival_por_Linea + Sum_Total_con_IVA, 2)
                sField = "!VALOR_TOTAL_CON_IVA" & nCount.ToString("00")

                ' Dar formato a los datos
                valor = val_total_Ival_por_Linea
                resultado = String.Format("{0:#,0.00}", valor).Replace(",", "X").Replace(".", ",").Replace("X", ".")
                ReplaceExcelText(xlApp, sField, "'$ " & resultado)

                nCount = nCount + 1
                nRowNumber = nRowNumber + 1

            Next


        End If

        If TypeService = "Service" Then
            Dim valor As Double
            Dim resultado As String

            ' Dar formato a los datos
            valor = Sum_Total_antes_IVA
            resultado = String.Format("{0:#,0.00}", valor).Replace(",", "X").Replace(".", ",").Replace("X", ".")
            ReplaceExcelText(xlApp, "!SUM_TOTAL_ANTES_IVA", "'$ " & resultado)

            ' Dar formato a los datos
            valor = Sum_Total_con_IVA
            resultado = String.Format("{0:#,0.00}", valor).Replace(",", "X").Replace(".", ",").Replace("X", ".")
            ReplaceExcelText(xlApp, "!SUM_TOTAL_CON_IVA", "'$ " & resultado)

            sValue = Math.Round((Sum_Total_antes_IVA * Vl_Utility) * Vl_IVA, 2)
            ' Dar formato a los datos
            valor = sValue
            resultado = String.Format("{0:#,0.00}", valor).Replace(",", "X").Replace(".", ",").Replace("X", ".")
            ' Reemplazar el valor en la hoja de Excel
            sField = "!Sum_IVA"
            ReplaceExcelText(xlApp, sField, "'" & "$ " & resultado)

        Else
            Dim valor As Double
            Dim resultado As String

            ' Dar formato a los datos
            valor = Sum_Total_antes_IVA
            resultado = String.Format("{0:#,0.00}", valor).Replace(",", "X").Replace(".", ",").Replace("X", ".")
            ReplaceExcelText(xlApp, "!SUM_TOTAL_ANTES_IVA", "'$ " & resultado)

            sValue = Math.Round(Sum_Total_antes_IVA * Vl_IVA, 2)
            ' Dar formato a los datos
            valor = sValue
            resultado = String.Format("{0:#,0.00}", valor).Replace(",", "X").Replace(".", ",").Replace("X", ".")
            sField = "!Sum_IVA"
            ReplaceExcelText(xlApp, sField, "'" & "$ " & resultado)


            ' Dar formato a los datos
            valor = Sum_Total_antes_IVA + sValue
            resultado = String.Format("{0:#,0.00}", valor).Replace(",", "X").Replace(".", ",").Replace("X", ".")
            ReplaceExcelText(xlApp, "!SUM_TOTAL_CON_IVA", "'" & "$ " & resultado)

        End If

        For i As Integer = 1 To 30
            sValue = ""

            sField = "!ITEM" & i.ToString("00")
            ReplaceExcelText(xlApp, sField, sValue.ToUpper)

            sField = "!CANTIDAD" & i.ToString("00")
            ReplaceExcelText(xlApp, sField, sValue.ToUpper)

            sField = "!UNIDAD" & i.ToString("00")
            ReplaceExcelText(xlApp, sField, sValue.ToUpper)

            sField = "!MONEDA" & i.ToString("00")
            ReplaceExcelText(xlApp, sField, sValue.ToUpper)

            sField = "!DESCRIPCION" & i.ToString("00")
            ReplaceExcelText(xlApp, sField, sValue.ToUpper)

            sField = "!VALOR_UNITARIO" & i.ToString("00")
            ReplaceExcelText(xlApp, sField, sValue.ToUpper)

            sField = "!VALOR_DESCUENTO" & i.ToString("00")
            ReplaceExcelText(xlApp, sField, sValue.ToUpper)

            sField = "!VALOR_TOTAL_ANTES_IVA" & i.ToString("00")
            ReplaceExcelText(xlApp, sField, sValue.ToUpper)

            sField = "!IVA" & i.ToString("00")
            ReplaceExcelText(xlApp, sField, sValue.ToUpper)

            sField = "!VALOR_TOTAL_CON_IVA" & i.ToString("00")
            ReplaceExcelText(xlApp, sField, sValue.ToUpper)
        Next
        ds.Dispose()
        ds = Nothing

        xlWorkBook.Save()
        xlWorkBook.Close()
        xlApp.UserControl = True
        xlApp.Quit()
        If xlCells IsNot Nothing Then
            ReleaseComObject(xlCells)
        End If
        'ReleaseComObject(xlCells)
        ReleaseComObject(xlWorkSheets)
        ReleaseComObject(xlWorkSheet)
        ReleaseComObject(xlWorkBook)
        ReleaseComObject(xlWorkBooks)
        ReleaseComObject(xlApp)

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        Process.Start(sNewName)

    End Sub

#End Region

    Public Sub ReleaseComObject(ByVal obj As Object)
        Try
            If obj IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            End If
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        End Try
    End Sub
    Public Sub ReplaceExcelText(ByRef xlApp As Excel.Application, FindText As String, ReplaceText As Object)

        Dim currentFind As Excel.Range = Nothing
        Dim firstFind As Excel.Range = Nothing

        Dim xlsRange As Excel.Range = xlApp.Range("A1", "BJ500")
        xlsRange.Replace(FindText, ReplaceText)

    End Sub

    Public Sub ReplaceExcelTextLarge(ByRef xlApp As Excel.Application, FindText As String, ReplaceText As String)
        'Public Sub ReplaceExcelText(ByRef xlApp As Excel.Application, FindText As String, ReplaceText As String)
        Dim maxLength As Integer
        maxLength = 150 ' Longitud máxima de caracteres por celda
        Dim cellRange As Excel.Range
        Dim currentCell As Excel.Range
        Dim remainingText As String
        remainingText = ReplaceText

        ' Definir el rango de celdas donde se realizará el reemplazo
        Dim startCell As Excel.Range
        startCell = xlApp.Range("C50")

        ' Definir el rango de celdas a reemplazar
        Dim numCells As Integer
        numCells = 5 ' Cantidad de celdas a reemplazar

        ' Dividir el texto en partes de 150 caracteres
        For i = 1 To numCells
            ' Obtener la celda correspondiente
            If currentCell Is Nothing Then
                currentCell = startCell
            Else
                currentCell = currentCell.Offset(1)
            End If

            Dim newText As String
            If Len(remainingText) > maxLength Then
                ' Si el texto restante es más largo que la longitud máxima, tomar solo los primeros 150 caracteres
                newText = Mid(remainingText, 1, maxLength) 'Left(remainingText, maxLength)
                remainingText = Mid(remainingText, maxLength + 1)
            Else
                ' Si el texto restante es igual o más corto que la longitud máxima, tomar todo el texto restante
                newText = remainingText
                remainingText = ""
            End If

            ' Realizar el reemplazo en la celda
            currentCell.Value = newText
        Next i

        ' Limpiar el resto de las celdas si queda texto sobrante
        Do While Len(remainingText) > 0
            Dim newText As String
            If currentCell Is Nothing Then
                currentCell = startCell.Offset(numCells)
            Else
                currentCell = currentCell.Offset(1)
            End If

            currentCell.Value = ""
            If Len(remainingText) > maxLength Then
                newText = Mid(remainingText, 1, maxLength) 'Left(remainingText, maxLength)
                remainingText = Mid(remainingText, maxLength + 1)
            Else
                newText = remainingText
                remainingText = ""
            End If
        Loop
    End Sub

End Class