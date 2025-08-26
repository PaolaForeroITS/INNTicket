Imports System.Configuration
Imports System.Globalization
Imports System.Threading

Public Class frmMain

    Dim util As New clsUtils
    Public sUsername As String = ""
    Public sFullName As String = ""
    Public sUserLang As String = "en-US"

    Public bIsSQLConnect As Boolean

    Dim bLoadForm As Boolean = True

    Dim imgBlank As System.Drawing.Image
    Dim imgAttach As System.Drawing.Image

    Dim grdIndex As Integer = 0

    Dim bPermitChangeSuperiorSupervisor As Boolean = True

#Region "Form"

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim str As String = ""

        Try

            '--Image Attach
            imgBlank = Image.FromFile("C:\SESTicket\app\Image\blank.bmp")
            imgAttach = Image.FromFile("C:\SESTicket\app\Image\attachicon.bmp")

            CheckAppIsOpen()

            InitForm()

            Dim frm As New frmLogin
            With frm
                .bIsSQLConnect = Me.bIsSQLConnect
                .ShowDialog()
            End With

            If frm.sFullName = "" Then
                End
            End If

            '--Setting Username and FullName from frmLogin
            sUsername = frm.sUsername.ToUpper
            sFullName = frm.sFullName.ToUpper
            sUserLang = frm.sUserLang

            '--Setting CultureInfo
            Thread.CurrentThread.CurrentCulture = New CultureInfo(sUserLang)
            Thread.CurrentThread.CurrentUICulture = New CultureInfo(sUserLang)

            frm.Dispose()
            frm = Nothing

            CheckVersion()

            ToolStripLogin.Text = "Login: " & Me.sUsername
            ToolStripFullName.Text = "Name: " & Me.sFullName

            Dim synTicket As New clsSyncTicket
            synTicket.UpdateConsecLocal()
            synTicket.Dispose()
            synTicket = Nothing

            If bIsSQLConnect = True Then

                Dim sync As New clsSyncBaseData
                sync.Consec(sUsername)

                If sync.IsBaseDataUpToDate = False Then
                    MsgBox("The BaseData is Out-to-Date. The Synchronization is Mandatory.", vbCritical)
                    SyncBaseDataOpt()
                End If

                sync.Dispose()
                sync = Nothing

                'Sync Tickets
                SyncClosedTickets()

                'StartAttachSync
                Dim syncAtt As New clsSyncTicketAttach
                syncAtt.StartSync()
                syncAtt.Dispose()
                syncAtt = Nothing

            End If

            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.cbxSite' table. You can move, or remove it, as needed.
            Me.CbxSiteTableAdapter.Fill(Me.SESTicketAccessDataSet.cbxSite)
            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.cbxCustomer' table. You can move, or remove it, as needed.
            Me.CbxCustomerTableAdapter.Fill(Me.SESTicketAccessDataSet.cbxCustomer)
            'TODO: This line of code loads data into the 'SESTicketAccessDataSet.cbxServiceLine' table. You can move, or remove it, as needed.
            Me.CbxServiceLineTableAdapter.Fill(Me.SESTicketAccessDataSet.cbxServiceLine)

            LoadTickets()

            '--User Grant
            FormUserGrant()

            bLoadForm = False

        Catch ex As Exception
            MsgBox(ex.Message + " - " + str)
            Me.Dispose()
        End Try

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Kill the synchronizacion tool
        Dim syncAtt As New clsSyncTicketAttach
        syncAtt.StopSync()
        syncAtt.Dispose()
        syncAtt = Nothing
    End Sub

#End Region

#Region "Load Tickets and Search"

    Private Sub LoadTickets()

        Dim str As String = ""

        Try
            Me.Cursor = Cursors.WaitCursor

            str = "Load Tickets - ChargeTmpTicketMain"
            ChargeTmpTicketMain()

            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            MsgBox(ex.Message + " - " + str)
            Me.Dispose()
        End Try

    End Sub

    Private Sub ChargeTmpTicketMain()

        Dim sfilter As String = ""

        'TICKET STATUS
        Dim sTicketStatus As String = ""
        If chkCanceled.Checked = True Then
            sTicketStatus = "'Canceled'"
        End If
        If chkClosed.Checked = True Then
            If sTicketStatus <> "" Then
                sTicketStatus = sTicketStatus & ","
            End If
            sTicketStatus = sTicketStatus & "'Closed'"
        End If
        If chkOpen.Checked = True Then
            If sTicketStatus <> "" Then
                sTicketStatus = sTicketStatus & ","
            End If
            sTicketStatus = sTicketStatus & "'Open'"
        End If
        If sfilter <> "" Then
            sfilter = sfilter & "AND "
        End If
        If sTicketStatus <> "" Then
            sfilter = sfilter & "TICKETSTATUS IN (" & sTicketStatus & ")"
        Else
            sfilter = sfilter & "TICKETSTATUS IN ('NOTHING')"
        End If

        'SERVICELINE
        If cbxServiceLine.SelectedValue <> -1 Then
            sfilter = sfilter & " AND SERVICELINEID = " & cbxServiceLine.SelectedValue.ToString & ""
        End If

        'CUSTOMER
        If cbxCustomer.SelectedValue <> -1 Then
            sfilter = sfilter & " AND CUSTOMERID = '" & cbxCustomer.SelectedValue.ToString & "'"
        End If

        'SITE
        If cbxSite.SelectedValue.ToString <> "-1" Then
            sfilter = sfilter & " AND SITEID = '" & cbxSite.SelectedValue.ToString & "'"
        End If


        If txtTicketId.Text.Trim <> "" Then
            If cbxTicket.Text = "Ticket ID" Then
                sfilter = sfilter & " AND TICKETID LIKE '%" & txtTicketId.Text.Trim & "%'"
            ElseIf cbxTicket.Text = "Proforma Val." Then
                sfilter = sfilter & " AND SUPERIORNUM LIKE '%" & txtTicketId.Text.Trim & "%'"
            End If
        End If

        Dim bdconn As New clsBancoDadosACCESS
        Dim sql As String

        bdconn.OpenConnection()

        sql = "DELETE FROM TMP_TICKETMAIN"
        bdconn.ExecuteNonSQL(sql)

        sql = "INSERT INTO TMP_TICKETMAIN SELECT * FROM TICKET_V WHERE " & sfilter
        bdconn.ExecuteNonSQL(sql)

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing

        'LOAD TABLE ADAPTER
        Me.TICKET_VTableAdapter.Fill(Me.SESTicketAccessDataSet.TICKET_V)

        'COLOR
        ForeColorGrid()

        'CLEAR SELECTION
        dgvTicketAccess.ClearSelection()

        'CONTEXT MENU
        ContextMenuItem(False)


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadTickets()
    End Sub

#End Region

#Region "Complementary Methods"

    Private Sub InitForm()
        Dim frm As New frmCheckConnection

        Try
            frm.ShowDialog()
            Me.bIsSQLConnect = frm.bIsSQLConnect
            frm.Dispose()
            frm = Nothing

            If bIsSQLConnect = True Then
                ToolStripSQL.Text = "SQL Connected: YES"
                ToolStripSQL.ForeColor = Color.Blue

            Else
                ToolStripSQL.Text = "SQL Connected: NO"
                ToolStripSQL.ForeColor = Color.Red
            End If

        Catch ex As Exception
            frm.Dispose()
            frm = Nothing
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub SyncBaseDataOpt()
        Dim frm As New frmSyncBaseData
        frmSyncBaseData.sUsername = Me.sUsername
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub SyncClosedTickets()
        Dim frm As New frmSyncTicket
        frm.sUsername = Me.sUsername
        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub CheckVersion()

        Dim sysVer As New clsSystemVersion
        sysVer.sUsername = Me.sUsername
        sysVer.isSQLConnect = Me.bIsSQLConnect

        Me.Text = "SESTicket - Version " & sysVer.SystemVersion

        sysVer.UpdateAppVersionUpdate()

        If sysVer.isAccBaseDataUpdated = False Then
            MsgBox("The BaseData version is not same of the application." & Chr(10) & "The update is strongly recomended." & Chr(10) & "Contact the Administrator.", vbInformation)
            sysVer.Dispose()
            End
        End If

        If sysVer.isAccTicketUpdated = False Then
            MsgBox("The TicketDB version is not same of the application." & Chr(10) & "The update is strongly recomended." & Chr(10) & "Contact the Administrator.", vbInformation)
            sysVer.Dispose()
            End
        End If

        sysVer.Dispose()
        sysVer = Nothing

    End Sub

    Private Sub CheckAppIsOpen()

        Dim objMutex As System.Threading.Mutex

        objMutex = New System.Threading.Mutex(False, "SINGLE_INSTANCE_APP_MUTEX")

        If objMutex.WaitOne(0, False) = False Then
            objMutex.Close()
            objMutex = Nothing
            MessageBox.Show("The App is already opened.")
            End
        End If
        objMutex.Close()
        objMutex.Dispose()
        objMutex = Nothing

    End Sub

    Private Sub cbxServiceLine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxServiceLine.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxSite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxSite.KeyPress
        e.Handled = True
    End Sub

    Private Sub cbxCustomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCustomer.KeyPress
        e.Handled = True
    End Sub

#End Region

#Region "Grid Methods"

    Private Sub OpenTicket(ByVal grdIndex As Integer)

        Me.Cursor = Cursors.WaitCursor

        Dim frm As New frmTicketEdit

        With frm
            .Init()
            .sUsername = Me.sUsername
            .sTicketNumberOld = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colTicketID").Value)
            .txtTicketNumber.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colTicketID").Value)
            .dtpServiceDate.Value = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colDateService").Value)
            .cbxCustomer.SelectedValue = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colCustomerID").Value)
            .cbxServiceLine.SelectedValue = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colServiceLineId").Value)
            .cbxContract.SelectedValue = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colContractID").Value)
            .cbxCurrency.SelectedValue = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colCurrencyID").Value)
            .dtpTimeArrived.Value = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colTimeArrivedID").Value)
            .dtpTimeStarted.Value = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colTimeStarted").Value)
            .dtpTimeCompleted.Value = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colTimeCompleted").Value)
            .sWellId = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colWellID").Value)
            .txtWellName.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colWellName").Value)
            .txtRig.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colRig").Value)
            .txtJobDescription.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colJobDescription").Value)
            .txtCustRepres.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colCustRepRes").Value)
            .txtCustRepresPosition.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colCustRepResPosition").Value)
            .txtCustRepresAssist.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colCustRepResAssist").Value)
            .txtCustRepresAssistPos.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colCustRepresAssistPos").Value)
            .txtCustComments.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colCustComments").Value)
            .sContrRepresId = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colContractorRepresentative").Value.ToString)
            .txtContrComments.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colContractComments").Value)
            .cbxTubingPipe.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colTubingSize").Value)
            .cbxTubingWeight.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colTubingWeight").Value)
            .cbxTubingGrade.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colTubingGrade").Value)
            .cbxCasingSize.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colCasingSize").Value)
            .cbxCasingWeight.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colCasingWeight").Value)
            .cbxCasingGrade.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colCasingGrade").Value)
            .txtMaxPressure.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colPressureMax").Value))
            .txtMaxDepth.Text = util.ConcatDecimalStr(util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colDepthMax").Value))
            .sExchangeRate = util.ConcatDecimalStr(util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colExchangeRate").Value))
            .txtAdicInform.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colAdicInform").Value.ToString)
            .txtSupNum.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colSuperiorNum").Value.ToString)
            .txtDM.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colDM").Value.ToString)
            .bIsSQLConnect = Me.bIsSQLConnect
            .bNoInvItem = dgvTicketAccess.Rows(grdIndex).Cells("colNoInvItem").Value
            .sSiteId = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colSiteId").Value.ToString)
            .txtSiteId.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colSite").Value.ToString)
            .txtSONumber.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colServiceOrderNum").Value.ToString)
            .txtJobNumber.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colJobNumber").Value.ToString)
            .txtContrRepres.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colContrRepresName").Value.ToString)

            .sSuperiorSupervisorId = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colSuperiorSupervisor").Value.ToString)
            .txtSuperiorSupervisor.Text = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colSuperiorSupName").Value.ToString.ToUpper)

        End With

        If dgvTicketAccess.Rows(grdIndex).Cells("colTicketStatus").Value.ToString <> "Open" Then
            frm.bTicketReadOnly = True
        End If

        If dgvTicketAccess.Rows(grdIndex).Cells("colTicketStatus").Value.ToString = "Canceled" Then
            frm.lblTicketCancelDet.Visible = True
            Dim dDatCanc As DateTime = util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colCancelDateTime").Value)

            frm.sCancelDet = "Canceled by: " & util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colCancelUser").Value) & Environment.NewLine
            frm.sCancelDet = frm.sCancelDet & "Date: " & dDatCanc.ToString("dd/MMM/yyyy HH:mm:ss") & Environment.NewLine
            frm.sCancelDet = frm.sCancelDet & "Reason: " & util.TrataDBNull(dgvTicketAccess.Rows(grdIndex).Cells("colCancelReason").Value.ToString)
        Else
            frm.pnlTicketCanceled.Visible = False
        End If

        Me.Cursor = Cursors.Arrow

        frm.ShowDialog()
        frm.Dispose()
        frm = Nothing

        LoadTickets()

    End Sub

    Private Sub dgvTicketAccess_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTicketAccess.CellDoubleClick
        If dgvTicketAccess.RowCount > 0 Then
            OpenTicket(e.RowIndex)
        End If
    End Sub

    Private Sub ForeColorGrid()

        For l As Integer = 0 To Me.dgvTicketAccess.RowCount - 1

            If dgvTicketAccess.Rows(l).Cells("colTicketStatus").Value = "Canceled" Then
                With dgvTicketAccess.Rows(l)
                    .Cells("colTicketStatus").Style.ForeColor = Color.Red
                End With
            ElseIf dgvTicketAccess.Rows(l).Cells("colTicketStatus").Value = "Closed" Then
                With dgvTicketAccess.Rows(l)
                    .Cells("colTicketStatus").Style.ForeColor = Color.Blue
                End With
            ElseIf dgvTicketAccess.Rows(l).Cells("colTicketStatus").Value = "Open" Then
                With dgvTicketAccess.Rows(l)
                    .Cells("colTicketStatus").Style.ForeColor = Color.DarkGreen
                End With
            End If

            If dgvTicketAccess.Rows(l).Cells("colHasAttach").Value > 0 Then
                dgvTicketAccess.Rows(l).Cells("colAttach").Value = imgAttach
            Else
                dgvTicketAccess.Rows(l).Cells("colAttach").Value = imgBlank
            End If

            If Me.dgvTicketAccess.Rows(l).Cells("colItemAmount").Value < 0 Then
                Me.dgvTicketAccess.Rows(l).Cells("colItemAmount").Style.ForeColor = Color.FromArgb(192, 0, 0)
            Else
                Me.dgvTicketAccess.Rows(l).Cells("colItemAmount").Style.ForeColor = Color.Blue
            End If


        Next
    End Sub

    Private Sub dgvTicketAccess_Sorted(sender As Object, e As EventArgs) Handles dgvTicketAccess.Sorted
        ForeColorGrid()
    End Sub


#End Region

#Region "Main Menu"

    Private Sub mnuUpdateBaseData_Click(sender As Object, e As EventArgs) Handles mnuUpdateBaseData.Click
        SyncBaseDataOpt()
        FormUserGrant()
    End Sub

    Private Sub mnuSystemUsers_Click(sender As Object, e As EventArgs) Handles mnuSystemUsers.Click
        Dim frm As New frmUserList
        With frm
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
        FormUserGrant()
    End Sub

    Private Sub mnuResourceEquipment_Click(sender As Object, e As EventArgs) Handles mnuResourceEquipment.Click
        Dim frm As New frmEquipmentList
        With frm
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub mnuResourceWorker_Click(sender As Object, e As EventArgs) Handles mnuResourceWorker.Click
        Dim frm As New frmWorkerList
        With frm
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub mnuInventoryItem_Click(sender As Object, e As EventArgs) Handles mnuInventoryItem.Click
        Dim frm As New frmInvItemList
        With frm
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub mnuInventoryClass_Click(sender As Object, e As EventArgs) Handles mnuInventoryClass.Click
        Dim frm As New frmInvClassList
        With frm
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub mnuCustomerList_Click(sender As Object, e As EventArgs) Handles mnuCustomerList.Click
        Dim frm As New frmCustomerList
        With frm
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub mnuContractHeader_Click(sender As Object, e As EventArgs) Handles mnuContractHeader.Click
        Dim frm As New frmContractList
        With frm
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub mnuContractPriceList_Click(sender As Object, e As EventArgs) Handles mnuContractPriceList.Click
        Dim frm As New frmContractPriceList
        With frm
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub mnuOperSites_Click(sender As Object, e As EventArgs) Handles mnuOperSites.Click
        Dim frm As New frmSiteList
        With frm
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub mnuOperPetrFields_Click(sender As Object, e As EventArgs) Handles mnuOperPetrFields.Click
        Dim frm As New frmPetrFieldList
        With frm
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub mnuOperRig_Click(sender As Object, e As EventArgs) Handles mnuOperRig.Click
        Dim frm As New frmRigList
        With frm
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub mnuOperWell_Click(sender As Object, e As EventArgs) Handles mnuOperWell.Click
        Dim frm As New frmWellList
        With frm
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub mnuOperServiceLine_Click(sender As Object, e As EventArgs) Handles mnuOperServiceLine.Click
        Dim frm As New frmServiceLineList
        With frm
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub mnuOperServiceType_Click(sender As Object, e As EventArgs) Handles mnuOperServiceType.Click
        Dim frm As New frmServiceTypeList
        With frm
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub mnuReportParameter_Click(sender As Object, e As EventArgs) Handles mnuReportParameter.Click
        Dim frm As New frmRPTParameter
        With frm
            .sUsername = Me.sUsername
            .isSearch = False
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
    End Sub

    Private Sub mnuTicketDatabase_Click(sender As Object, e As EventArgs) Handles mnuTicketDatabase.Click
        Dim frm As New frmTicketDB
        With frm
            .sUsername = Me.sUsername
            .ShowDialog()
        End With

        If frm.bReloadGrid = True Then
            LoadTickets()
        End If
        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub mnuInvControl_Click(sender As Object, e As EventArgs) Handles mnuInvControl.Click
        Dim frm As New frmInvoiceList
        With frm
            .sUsername = Me.sUsername
            .ShowDialog()
        End With

        If frm.bReloadGrid = True Then
            LoadTickets()
        End If
        frm.Dispose()
        frm = Nothing
    End Sub


    Private Sub mnuSyncTicket_Click(sender As Object, e As EventArgs) Handles mnuSyncTicket.Click
        SyncClosedTickets()
        LoadTickets()
    End Sub

    Private Sub mnuNewTicket_Click(sender As Object, e As EventArgs) Handles mnuNewTicket.Click
        Dim frm As New frmTicketEdit
        With frm
            .sUsername = LCase(Me.sUsername)
            .pnlTicketCanceled.Visible = False
            .bIsSQLConnect = Me.bIsSQLConnect
            .Init()
            .ShowDialog()
            .Dispose()
        End With
        frm = Nothing
        LoadTickets()
    End Sub

    Private Sub mnuReport_Click(sender As Object, e As EventArgs) Handles mnuReport.Click
        Process.Start(ConfigurationManager.AppSettings("SESTicketReport"))
    End Sub


    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Dispose()
    End Sub



#End Region

#Region "Context Menu"

    Private Sub ContextMenuItem(ByVal Multiline As Boolean)

        If dgvTicketAccess.RowCount = 0 Or dgvTicketAccess.SelectedRows.Count = 0 Then
            cmnuOpenTicket.Enabled = False
            cmnuCloneTicket.Enabled = False
            cmnuAttachment.Enabled = False
            cmnuRemoveTicketList.Enabled = False
            cmnuSep00.Enabled = False
            mnuCloseTickets.Enabled = False

            If bPermitChangeSuperiorSupervisor = True Then
                mnuChangeSupSupervisor.Enabled = False
            Else
                mnuChangeSupSupervisor.Visible = False
            End If

        Else
            cmnuOpenTicket.Enabled = True
            cmnuCloneTicket.Enabled = True
            cmnuAttachment.Enabled = True
            cmnuRemoveTicketList.Enabled = True
            cmnuSep00.Enabled = True
            mnuCloseTickets.Enabled = True

            If bPermitChangeSuperiorSupervisor = True Then
                mnuChangeSupSupervisor.Enabled = True
            Else
                mnuChangeSupSupervisor.Visible = False
            End If

        End If

        If Multiline = True Then
            cmnuOpenTicket.Visible = False
            cmnuCloneTicket.Visible = False
            cmnuAttachment.Visible = False
            mnuCloseTickets.Visible = True
            cmnuRemoveTicketList.Visible = True
            cmnuSep00.Visible = False
            If bPermitChangeSuperiorSupervisor = True Then
                mnuChangeSupSupervisor.Visible = True
            Else
                mnuChangeSupSupervisor.Visible = False
            End If
        Else
            cmnuOpenTicket.Visible = True
            cmnuCloneTicket.Visible = True
            cmnuAttachment.Visible = True
            cmnuRemoveTicketList.Visible = True
            cmnuSep00.Visible = True
            mnuCloseTickets.Visible = True
            If bPermitChangeSuperiorSupervisor = True Then
                mnuChangeSupSupervisor.Visible = True
            Else
                mnuChangeSupSupervisor.Visible = False
            End If
        End If

    End Sub

    Private Sub cmnuOpenTicket_Click(sender As Object, e As EventArgs) Handles cmnuOpenTicket.Click
        OpenTicket(grdIndex)
    End Sub

    Private Sub cmnuAttachment_Click(sender As Object, e As EventArgs) Handles cmnuAttachment.Click
        If dgvTicketAccess.RowCount = 0 Then
            MsgBox("No Ticket to Open", vbExclamation)
            Exit Sub
        End If

        Dim frm As New frmTicketFile
        With frm
            .sTicketId = dgvTicketAccess.Rows(grdIndex).Cells("colTicketID").Value.ToString()
            .sUsername = Me.sUsername
            .ShowDialog()
            .Dispose()
        End With

        frm = Nothing
    End Sub

    Private Sub cmnuCloneTicket_Click(sender As Object, e As EventArgs) Handles cmnuCloneTicket.Click
        If dgvTicketAccess.RowCount = 0 Then
            MsgBox("No lines to Clone", vbExclamation)
            Exit Sub
        End If

        Dim sTicketOrigin As String
        sTicketOrigin = dgvTicketAccess.Rows(grdIndex).Cells("colTicketID").Value.ToString()

        If MsgBox("Do you want clone the Ticket " & sTicketOrigin & "?", vbYesNo) = vbYes Then

            Me.Cursor = Cursors.WaitCursor

            Dim sTicketNew As String
            Dim syn As New clsSyncTicket
            sTicketNew = syn.CloneTicket(sTicketOrigin, LCase(Me.sUsername), Date.Now)
            syn.Dispose()
            syn = Nothing

            Me.Cursor = Cursors.Arrow
            MsgBox("Ticket Number " & sTicketNew & " created.", vbInformation)

            LoadTickets()

        End If
    End Sub

    Private Sub mnuCloseTickets_Click(sender As Object, e As EventArgs) Handles mnuCloseTickets.Click
        Dim frm As New frmCloseTicketDB
        With frm
            .sUsername = Me.sUsername
            .LoadGrid(dgvTicketAccess, "ACCESS")
            .bIsSQLConnect = Me.bIsSQLConnect
            .ShowDialog()
        End With

        If frm.bReloadGrid = True Then
            LoadTickets()
        End If
        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub cmnuRemoveTicketList_Click(sender As Object, e As EventArgs) Handles cmnuRemoveTicketList.Click
        Dim frm As New frmRemoveTicketGrid
        With frm
            .LoadGrid(dgvTicketAccess)
            .ShowDialog()
        End With

        If frm.bReloadGrid = True Then
            LoadTickets()
        End If
        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub mnuChangeSupSupervisor_Click(sender As Object, e As EventArgs) Handles mnuChangeSupSupervisor.Click
        Dim frm As New frmChangeSupSupervisor
        With frm
            .sUsername = Me.sUsername
            .LoadGrid(dgvTicketAccess, "ACCESS")
            .bIsSQLConnect = True
            .ShowDialog()
        End With

        If frm.bReloadGrid = True Then
            LoadTickets()
        End If
        frm.Dispose()
        frm = Nothing
    End Sub

    Private Sub dgvTicketAccess_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTicketAccess.CellMouseDown
        If e.Button = MouseButtons.Right Then
            If e.RowIndex <> -1 Then
                If dgvTicketAccess.SelectedRows.Count > 1 Then
                    ContextMenuItem(True)
                Else
                    ContextMenuItem(False)
                End If
            End If
            grdIndex = e.RowIndex
        End If
    End Sub

#End Region

#Region "FormUserGrants"

    Private Sub FormUserGrant()

        Me.Cursor = Cursors.WaitCursor

        mnuInvControl.Enabled = True
        mnuReport.Enabled = True
        mnuTicketDatabase.Enabled = True
        mnuSystemUsers.Enabled = True
        mnuResourceEquipment.Enabled = True
        mnuResourceWorker.Enabled = True
        mnuInventoryItem.Enabled = True
        mnuInventoryClass.Enabled = True
        mnuCustomerList.Enabled = True
        mnuContractHeader.Enabled = True
        mnuContractPriceList.Enabled = True
        mnuOperSites.Enabled = True
        mnuOperPetrFields.Enabled = True
        mnuOperRig.Enabled = True
        mnuOperWell.Enabled = True
        mnuOperServiceLine.Enabled = True
        mnuOperServiceType.Enabled = True
        mnuReportParameter.Enabled = True

        bPermitChangeSuperiorSupervisor = True

        Dim bdconn As New clsBancoDadosACCESS
        bdconn.OpenConnection("AccBase")

        Dim sql As String
        Dim ds As New DataSet

        sql = "SELECT obj.OBJECTNAME, obj.OBJECTTYPE,usr.ENABLE " &
              "FROM OBJECTGROUPITEMUSER usr, OBJECTGROUPITEM obj " &
              "WHERE usr.OBJECTGROUPITEMID = obj.OBJECTGROUPITEMID " &
              "and usr.ENABLE = 'NO'  " &
              "and obj.OBJECTFORM = 'frmMain' " &
              "and usr.USERNAME = '" & Me.sUsername & "' " &
              "UNION ALL " &
              "SELECT obj.OBJECTNAME, obj.OBJECTTYPE,usr.ENABLE " &
              "FROM OBJECTGROUPITEMUSER usr, OBJECTGROUPITEM obj " &
              "WHERE usr.OBJECTGROUPITEMID = obj.OBJECTGROUPITEMID " &
              "and obj.OBJECTFORM = 'frmTicket' " &
              "and obj.OBJECTNAME in ('bShowServiceTicketARG','bPermitChangeSuperiorSupervisor') " &
              "and usr.USERNAME = '" & Me.sUsername & "' "

        bdconn.ExecuteSQL(sql, ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim sObject As String = ""

            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                sObject = ds.Tables(0).Rows(i)("OBJECTNAME")

                If sObject = "mnuInvControl" Then
                    mnuInvControl.Enabled = False
                ElseIf sObject = "mnuReport" Then
                    mnuReport.Enabled = False
                ElseIf sObject = "mnuTicketDatabase" Then
                    mnuTicketDatabase.Enabled = False
                ElseIf sObject = "mnuSystemUsers" Then
                    mnuSystemUsers.Enabled = False
                ElseIf sObject = "mnuResourceEquipment" Then
                    mnuResourceEquipment.Enabled = False
                ElseIf sObject = "mnuResourceWorker" Then
                    mnuResourceWorker.Enabled = False
                ElseIf sObject = "mnuInventoryItem" Then
                    mnuInventoryItem.Enabled = False
                ElseIf sObject = "mnuInventoryClass" Then
                    mnuInventoryClass.Enabled = False
                ElseIf sObject = "mnuCustomerList" Then
                    mnuCustomerList.Enabled = False
                ElseIf sObject = "mnuContractHeader" Then
                    mnuContractHeader.Enabled = False
                ElseIf sObject = "mnuContractPriceList" Then
                    mnuContractPriceList.Enabled = False
                ElseIf sObject = "mnuOperSites" Then
                    mnuOperSites.Enabled = False
                ElseIf sObject = "mnuOperPetrFields" Then
                    mnuOperPetrFields.Enabled = False
                ElseIf sObject = "mnuOperRig" Then
                    mnuOperRig.Enabled = False
                ElseIf sObject = "mnuOperWell" Then
                    mnuOperWell.Enabled = False
                ElseIf sObject = "mnuOperServiceLine" Then
                    mnuOperServiceLine.Enabled = False
                ElseIf sObject = "mnuOperServiceType" Then
                    mnuOperServiceType.Enabled = False
                ElseIf sObject = "mnuReportParameter" Then
                    mnuReportParameter.Enabled = False
                ElseIf sObject = "bPermitChangeSuperiorSupervisor" Then
                    If ds.Tables(0).Rows(i)("ENABLE") = "YES" Then
                        mnuChangeSupSupervisor.Visible = True
                        bPermitChangeSuperiorSupervisor = True
                    Else
                        mnuChangeSupSupervisor.Visible = False
                        bPermitChangeSuperiorSupervisor = False
                    End If
                ElseIf sObject = "bShowServiceTicketARG" Then
                    If ds.Tables(0).Rows(i)("ENABLE") = "YES" Then
                        dgvTicketAccess.Columns("colSuperiorNum").Visible = True
                        dgvTicketAccess.Columns("colSuperiorSupName").Visible = True
                        dgvTicketAccess.Columns("colDM").Visible = True
                        dgvTicketAccess.Columns("colCustomerName").Width = 120
                        cbxTicket.Visible = True
                        cbxTicket.Text = "Ticket ID"
                        lblTicketID.Visible = False
                    Else
                        dgvTicketAccess.Columns("colDM").Visible = False
                        dgvTicketAccess.Columns("colSuperiorNum").Visible = False
                        dgvTicketAccess.Columns("colSuperiorSupName").Visible = False
                        dgvTicketAccess.Columns("colCustomerName").Width = 240
                        cbxTicket.Visible = False
                        cbxTicket.Text = "Ticket ID"
                        lblTicketID.Visible = True
                    End If
                End If
            Next

        End If

        ds.Dispose()
        ds = Nothing

        bdconn.CloseConnection()
        bdconn.Dispose()
        bdconn = Nothing


        'Enabling Menu Based in the Connection
        mnuBaseData.Enabled = IIf((bIsSQLConnect = True And mnuBaseData.Enabled = True), True, False)
        mnuTicketDatabase.Enabled = IIf((bIsSQLConnect = True And mnuTicketDatabase.Enabled = True), True, False)
        mnuInvControl.Enabled = IIf((bIsSQLConnect = True And mnuInvControl.Enabled = True), True, False)
        mnuReport.Enabled = IIf((bIsSQLConnect = True And mnuReport.Enabled = True), True, False)
        mnuSyncTicket.Enabled = IIf((bIsSQLConnect = True And mnuSyncTicket.Enabled = True), True, False)

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub dgvTicketAccess_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTicketAccess.CellContentClick

    End Sub



#End Region



End Class
