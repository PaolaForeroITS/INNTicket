<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripLogin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripFullName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripSQL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgvTicketAccess = New System.Windows.Forms.DataGridView()
        Me.cmnuGridPrincip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuOpenTicket = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuAttachment = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuCloneTicket = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuSep00 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCloseTickets = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChangeSupSupervisor = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuSep01 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmnuRemoveTicketList = New System.Windows.Forms.ToolStripMenuItem()
        Me.TICKET_VBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuBaseData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdateBaseData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep02 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSystemUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResource = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResourceEquipment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuResourceWorker = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInventoryItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInventoryClass = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustomer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustomerList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContractHeader = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContractPriceList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOperational = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOperSites = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOperSep00 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOperPetrFields = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOperRig = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOperWell = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOperSep01 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuOperServiceLine = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOperServiceType = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep03 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuReportParameter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTicketDatabase = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInvControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep00 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSyncTicket = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSepMain00 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewTicket = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSep01 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTicketID = New System.Windows.Forms.Label()
        Me.cbxTicket = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cbxCustomer = New System.Windows.Forms.ComboBox()
        Me.CbxCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTicketId = New System.Windows.Forms.TextBox()
        Me.chkCanceled = New System.Windows.Forms.CheckBox()
        Me.chkClosed = New System.Windows.Forms.CheckBox()
        Me.chkOpen = New System.Windows.Forms.CheckBox()
        Me.cbxSite = New System.Windows.Forms.ComboBox()
        Me.CbxSiteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxServiceLine = New System.Windows.Forms.ComboBox()
        Me.CbxServiceLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TICKET_VTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TICKET_VTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager()
        Me.CbxServiceLineTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.cbxServiceLineTableAdapter()
        Me.CbxCustomerTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.cbxCustomerTableAdapter()
        Me.CbxSiteTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.cbxSiteTableAdapter()
        Me.colAttach = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colTicketID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSuperiorNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSuperiorSupName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFullUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDateService = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWellID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCurrency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSyncDB = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colSyncDatetime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceLineId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContractID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCurrencyID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceTypeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTimeArrivedID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTimeStarted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTimeCompleted = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCasingSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCasingWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCasingGrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTubingSize = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTubingWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTubingGrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPressureMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDepthMax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJobDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustRepRes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustRepResPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustRepResAssist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContractorRepresentative = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustComments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContractComments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRig = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExchangeRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCancelDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCancelUser = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCancelReason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustRepresAssistPos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvoiceNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAdicInform = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWellName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNoInvItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHasAttach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJobNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSiteId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContrRepresName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceOrderNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSuperiorSupervisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvTicketAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmnuGridPrincip.SuspendLayout()
        CType(Me.TICKET_VBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMain.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.CbxCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbxSiteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbxServiceLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLogin, Me.ToolStripFullName, Me.ToolStripSQL})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 627)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1191, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripLogin
        '
        Me.ToolStripLogin.Name = "ToolStripLogin"
        Me.ToolStripLogin.Size = New System.Drawing.Size(81, 17)
        Me.ToolStripLogin.Text = "Login: FMELO"
        '
        'ToolStripFullName
        '
        Me.ToolStripFullName.Name = "ToolStripFullName"
        Me.ToolStripFullName.Size = New System.Drawing.Size(547, 17)
        Me.ToolStripFullName.Spring = True
        Me.ToolStripFullName.Text = "Name: MELO, FERNANDO"
        '
        'ToolStripSQL
        '
        Me.ToolStripSQL.Name = "ToolStripSQL"
        Me.ToolStripSQL.Size = New System.Drawing.Size(547, 17)
        Me.ToolStripSQL.Spring = True
        Me.ToolStripSQL.Text = "SQL Connected: YES"
        '
        'dgvTicketAccess
        '
        Me.dgvTicketAccess.AllowUserToAddRows = False
        Me.dgvTicketAccess.AllowUserToDeleteRows = False
        Me.dgvTicketAccess.AutoGenerateColumns = False
        Me.dgvTicketAccess.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgvTicketAccess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTicketAccess.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAttach, Me.colTicketID, Me.colSuperiorNum, Me.colDM, Me.colSuperiorSupName, Me.colFullUserName, Me.colTicketStatus, Me.colDateService, Me.colServiceLine, Me.colCustomerName, Me.colSite, Me.colWellID, Me.colCurrency, Me.colItemAmount, Me.colSyncDB, Me.colSyncDatetime, Me.colCustomerID, Me.colServiceLineId, Me.colContractID, Me.colCurrencyID, Me.colServiceTypeID, Me.colTimeArrivedID, Me.colTimeStarted, Me.colTimeCompleted, Me.colCasingSize, Me.colCasingWeight, Me.colCasingGrade, Me.colTubingSize, Me.colTubingWeight, Me.colTubingGrade, Me.colPressureMax, Me.colDepthMax, Me.colJobDescription, Me.colCustRepRes, Me.colCustRepResPosition, Me.colCustRepResAssist, Me.colContractorRepresentative, Me.colCustComments, Me.colContractComments, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.colRig, Me.colExchangeRate, Me.colCancelDateTime, Me.colCancelUser, Me.colCancelReason, Me.colCustRepresAssistPos, Me.colInvoiceNumber, Me.colAdicInform, Me.colWellName, Me.colNoInvItem, Me.colHasAttach, Me.colJobNumber, Me.colSiteId, Me.colContrRepresName, Me.colServiceOrderNum, Me.colSuperiorSupervisor})
        Me.dgvTicketAccess.ContextMenuStrip = Me.cmnuGridPrincip
        Me.dgvTicketAccess.DataSource = Me.TICKET_VBindingSource
        Me.dgvTicketAccess.Location = New System.Drawing.Point(10, 127)
        Me.dgvTicketAccess.Name = "dgvTicketAccess"
        Me.dgvTicketAccess.RowHeadersWidth = 20
        Me.dgvTicketAccess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTicketAccess.Size = New System.Drawing.Size(1169, 497)
        Me.dgvTicketAccess.TabIndex = 0
        '
        'cmnuGridPrincip
        '
        Me.cmnuGridPrincip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuOpenTicket, Me.cmnuAttachment, Me.cmnuCloneTicket, Me.cmnuSep00, Me.mnuCloseTickets, Me.mnuChangeSupSupervisor, Me.cmnuSep01, Me.cmnuRemoveTicketList})
        Me.cmnuGridPrincip.Name = "cmnuGridPrincip"
        Me.cmnuGridPrincip.Size = New System.Drawing.Size(205, 148)
        '
        'cmnuOpenTicket
        '
        Me.cmnuOpenTicket.Image = CType(resources.GetObject("cmnuOpenTicket.Image"), System.Drawing.Image)
        Me.cmnuOpenTicket.Name = "cmnuOpenTicket"
        Me.cmnuOpenTicket.Size = New System.Drawing.Size(204, 22)
        Me.cmnuOpenTicket.Text = "Open Ticket"
        '
        'cmnuAttachment
        '
        Me.cmnuAttachment.Image = CType(resources.GetObject("cmnuAttachment.Image"), System.Drawing.Image)
        Me.cmnuAttachment.Name = "cmnuAttachment"
        Me.cmnuAttachment.Size = New System.Drawing.Size(204, 22)
        Me.cmnuAttachment.Text = "Attachment"
        '
        'cmnuCloneTicket
        '
        Me.cmnuCloneTicket.Image = CType(resources.GetObject("cmnuCloneTicket.Image"), System.Drawing.Image)
        Me.cmnuCloneTicket.Name = "cmnuCloneTicket"
        Me.cmnuCloneTicket.Size = New System.Drawing.Size(204, 22)
        Me.cmnuCloneTicket.Text = "Clone Ticket"
        '
        'cmnuSep00
        '
        Me.cmnuSep00.Name = "cmnuSep00"
        Me.cmnuSep00.Size = New System.Drawing.Size(201, 6)
        '
        'mnuCloseTickets
        '
        Me.mnuCloseTickets.Image = CType(resources.GetObject("mnuCloseTickets.Image"), System.Drawing.Image)
        Me.mnuCloseTickets.Name = "mnuCloseTickets"
        Me.mnuCloseTickets.Size = New System.Drawing.Size(204, 22)
        Me.mnuCloseTickets.Text = "Close Ticket"
        '
        'mnuChangeSupSupervisor
        '
        Me.mnuChangeSupSupervisor.Image = CType(resources.GetObject("mnuChangeSupSupervisor.Image"), System.Drawing.Image)
        Me.mnuChangeSupSupervisor.Name = "mnuChangeSupSupervisor"
        Me.mnuChangeSupSupervisor.Size = New System.Drawing.Size(204, 22)
        Me.mnuChangeSupSupervisor.Text = "Change Supervisor"
        '
        'cmnuSep01
        '
        Me.cmnuSep01.Name = "cmnuSep01"
        Me.cmnuSep01.Size = New System.Drawing.Size(201, 6)
        '
        'cmnuRemoveTicketList
        '
        Me.cmnuRemoveTicketList.Image = CType(resources.GetObject("cmnuRemoveTicketList.Image"), System.Drawing.Image)
        Me.cmnuRemoveTicketList.Name = "cmnuRemoveTicketList"
        Me.cmnuRemoveTicketList.Size = New System.Drawing.Size(204, 22)
        Me.cmnuRemoveTicketList.Text = "Remove Ticket From List"
        '
        'TICKET_VBindingSource
        '
        Me.TICKET_VBindingSource.DataMember = "TICKET_V"
        Me.TICKET_VBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "INVOICENUMBER"
        Me.DataGridViewTextBoxColumn1.HeaderText = "INVOICENUMBER"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'mnuMain
        '
        Me.mnuMain.AutoSize = False
        Me.mnuMain.BackColor = System.Drawing.SystemColors.Control
        Me.mnuMain.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBaseData, Me.mnuTicketDatabase, Me.mnuInvControl, Me.mnuReport, Me.mnuSep00, Me.mnuSyncTicket, Me.mnuSepMain00, Me.mnuNewTicket, Me.mnuSep01, Me.mnuExit})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(1191, 42)
        Me.mnuMain.TabIndex = 45
        Me.mnuMain.Text = "MenuStrip2"
        '
        'mnuBaseData
        '
        Me.mnuBaseData.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUpdateBaseData, Me.mnuSep02, Me.mnuSystem, Me.mnuResource, Me.mnuInventory, Me.mnuCustomer, Me.mnuOperational, Me.mnuSep03, Me.mnuReportParameter})
        Me.mnuBaseData.Image = CType(resources.GetObject("mnuBaseData.Image"), System.Drawing.Image)
        Me.mnuBaseData.Name = "mnuBaseData"
        Me.mnuBaseData.Size = New System.Drawing.Size(94, 38)
        Me.mnuBaseData.Text = "Base Data"
        '
        'mnuUpdateBaseData
        '
        Me.mnuUpdateBaseData.Name = "mnuUpdateBaseData"
        Me.mnuUpdateBaseData.Size = New System.Drawing.Size(166, 22)
        Me.mnuUpdateBaseData.Text = "Update Base Data"
        '
        'mnuSep02
        '
        Me.mnuSep02.Name = "mnuSep02"
        Me.mnuSep02.Size = New System.Drawing.Size(163, 6)
        '
        'mnuSystem
        '
        Me.mnuSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSystemUsers})
        Me.mnuSystem.Name = "mnuSystem"
        Me.mnuSystem.Size = New System.Drawing.Size(166, 22)
        Me.mnuSystem.Text = "System"
        '
        'mnuSystemUsers
        '
        Me.mnuSystemUsers.Name = "mnuSystemUsers"
        Me.mnuSystemUsers.Size = New System.Drawing.Size(102, 22)
        Me.mnuSystemUsers.Text = "Users"
        '
        'mnuResource
        '
        Me.mnuResource.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuResourceEquipment, Me.mnuResourceWorker})
        Me.mnuResource.Name = "mnuResource"
        Me.mnuResource.Size = New System.Drawing.Size(166, 22)
        Me.mnuResource.Text = "Resource"
        '
        'mnuResourceEquipment
        '
        Me.mnuResourceEquipment.Name = "mnuResourceEquipment"
        Me.mnuResourceEquipment.Size = New System.Drawing.Size(132, 22)
        Me.mnuResourceEquipment.Text = "Equipment"
        '
        'mnuResourceWorker
        '
        Me.mnuResourceWorker.Name = "mnuResourceWorker"
        Me.mnuResourceWorker.Size = New System.Drawing.Size(132, 22)
        Me.mnuResourceWorker.Text = "Worker"
        '
        'mnuInventory
        '
        Me.mnuInventory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInventoryItem, Me.mnuInventoryClass})
        Me.mnuInventory.Name = "mnuInventory"
        Me.mnuInventory.Size = New System.Drawing.Size(166, 22)
        Me.mnuInventory.Text = "Inventory"
        '
        'mnuInventoryItem
        '
        Me.mnuInventoryItem.Name = "mnuInventoryItem"
        Me.mnuInventoryItem.Size = New System.Drawing.Size(101, 22)
        Me.mnuInventoryItem.Text = "Item"
        '
        'mnuInventoryClass
        '
        Me.mnuInventoryClass.Name = "mnuInventoryClass"
        Me.mnuInventoryClass.Size = New System.Drawing.Size(101, 22)
        Me.mnuInventoryClass.Text = "Class"
        '
        'mnuCustomer
        '
        Me.mnuCustomer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCustomerList, Me.mnuContractHeader, Me.mnuContractPriceList})
        Me.mnuCustomer.Name = "mnuCustomer"
        Me.mnuCustomer.Size = New System.Drawing.Size(166, 22)
        Me.mnuCustomer.Text = "Customer"
        '
        'mnuCustomerList
        '
        Me.mnuCustomerList.Name = "mnuCustomerList"
        Me.mnuCustomerList.Size = New System.Drawing.Size(170, 22)
        Me.mnuCustomerList.Text = "Customer List"
        '
        'mnuContractHeader
        '
        Me.mnuContractHeader.Name = "mnuContractHeader"
        Me.mnuContractHeader.Size = New System.Drawing.Size(170, 22)
        Me.mnuContractHeader.Text = "Contract Header"
        '
        'mnuContractPriceList
        '
        Me.mnuContractPriceList.Name = "mnuContractPriceList"
        Me.mnuContractPriceList.Size = New System.Drawing.Size(170, 22)
        Me.mnuContractPriceList.Text = "Contract Price List"
        '
        'mnuOperational
        '
        Me.mnuOperational.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOperSites, Me.mnuOperSep00, Me.mnuOperPetrFields, Me.mnuOperRig, Me.mnuOperWell, Me.mnuOperSep01, Me.mnuOperServiceLine, Me.mnuOperServiceType})
        Me.mnuOperational.Name = "mnuOperational"
        Me.mnuOperational.Size = New System.Drawing.Size(166, 22)
        Me.mnuOperational.Text = "Operational"
        '
        'mnuOperSites
        '
        Me.mnuOperSites.Name = "mnuOperSites"
        Me.mnuOperSites.Size = New System.Drawing.Size(162, 22)
        Me.mnuOperSites.Text = "Sites"
        '
        'mnuOperSep00
        '
        Me.mnuOperSep00.Name = "mnuOperSep00"
        Me.mnuOperSep00.Size = New System.Drawing.Size(159, 6)
        '
        'mnuOperPetrFields
        '
        Me.mnuOperPetrFields.Name = "mnuOperPetrFields"
        Me.mnuOperPetrFields.Size = New System.Drawing.Size(162, 22)
        Me.mnuOperPetrFields.Text = "Petroleum Fields"
        '
        'mnuOperRig
        '
        Me.mnuOperRig.Name = "mnuOperRig"
        Me.mnuOperRig.Size = New System.Drawing.Size(162, 22)
        Me.mnuOperRig.Text = "Rig"
        '
        'mnuOperWell
        '
        Me.mnuOperWell.Name = "mnuOperWell"
        Me.mnuOperWell.Size = New System.Drawing.Size(162, 22)
        Me.mnuOperWell.Text = "Well"
        '
        'mnuOperSep01
        '
        Me.mnuOperSep01.Name = "mnuOperSep01"
        Me.mnuOperSep01.Size = New System.Drawing.Size(159, 6)
        '
        'mnuOperServiceLine
        '
        Me.mnuOperServiceLine.Name = "mnuOperServiceLine"
        Me.mnuOperServiceLine.Size = New System.Drawing.Size(162, 22)
        Me.mnuOperServiceLine.Text = "Service Line"
        '
        'mnuOperServiceType
        '
        Me.mnuOperServiceType.Name = "mnuOperServiceType"
        Me.mnuOperServiceType.Size = New System.Drawing.Size(162, 22)
        Me.mnuOperServiceType.Text = "Service Type"
        '
        'mnuSep03
        '
        Me.mnuSep03.Name = "mnuSep03"
        Me.mnuSep03.Size = New System.Drawing.Size(163, 6)
        '
        'mnuReportParameter
        '
        Me.mnuReportParameter.Name = "mnuReportParameter"
        Me.mnuReportParameter.Size = New System.Drawing.Size(166, 22)
        Me.mnuReportParameter.Text = "Report Parameter"
        '
        'mnuTicketDatabase
        '
        Me.mnuTicketDatabase.Image = CType(resources.GetObject("mnuTicketDatabase.Image"), System.Drawing.Image)
        Me.mnuTicketDatabase.Name = "mnuTicketDatabase"
        Me.mnuTicketDatabase.Size = New System.Drawing.Size(126, 38)
        Me.mnuTicketDatabase.Text = "Ticket Database"
        '
        'mnuInvControl
        '
        Me.mnuInvControl.Image = CType(resources.GetObject("mnuInvControl.Image"), System.Drawing.Image)
        Me.mnuInvControl.Name = "mnuInvControl"
        Me.mnuInvControl.Size = New System.Drawing.Size(124, 38)
        Me.mnuInvControl.Text = "Invoice Control"
        '
        'mnuReport
        '
        Me.mnuReport.Image = CType(resources.GetObject("mnuReport.Image"), System.Drawing.Image)
        Me.mnuReport.Name = "mnuReport"
        Me.mnuReport.Size = New System.Drawing.Size(78, 38)
        Me.mnuReport.Text = "Report"
        '
        'mnuSep00
        '
        Me.mnuSep00.Enabled = False
        Me.mnuSep00.Name = "mnuSep00"
        Me.mnuSep00.Size = New System.Drawing.Size(22, 38)
        Me.mnuSep00.Text = "|"
        '
        'mnuSyncTicket
        '
        Me.mnuSyncTicket.Image = CType(resources.GetObject("mnuSyncTicket.Image"), System.Drawing.Image)
        Me.mnuSyncTicket.Name = "mnuSyncTicket"
        Me.mnuSyncTicket.Size = New System.Drawing.Size(142, 38)
        Me.mnuSyncTicket.Text = "Synchronize Ticket"
        '
        'mnuSepMain00
        '
        Me.mnuSepMain00.Name = "mnuSepMain00"
        Me.mnuSepMain00.Size = New System.Drawing.Size(22, 38)
        Me.mnuSepMain00.Text = "|"
        '
        'mnuNewTicket
        '
        Me.mnuNewTicket.Image = CType(resources.GetObject("mnuNewTicket.Image"), System.Drawing.Image)
        Me.mnuNewTicket.Name = "mnuNewTicket"
        Me.mnuNewTicket.Size = New System.Drawing.Size(102, 38)
        Me.mnuNewTicket.Text = "New Ticket"
        '
        'mnuSep01
        '
        Me.mnuSep01.Enabled = False
        Me.mnuSep01.Name = "mnuSep01"
        Me.mnuSep01.Size = New System.Drawing.Size(22, 38)
        Me.mnuSep01.Text = "|"
        '
        'mnuExit
        '
        Me.mnuExit.Image = CType(resources.GetObject("mnuExit.Image"), System.Drawing.Image)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(61, 38)
        Me.mnuExit.Text = "Exit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTicketID)
        Me.GroupBox2.Controls.Add(Me.cbxTicket)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.cbxCustomer)
        Me.GroupBox2.Controls.Add(Me.txtTicketId)
        Me.GroupBox2.Controls.Add(Me.chkCanceled)
        Me.GroupBox2.Controls.Add(Me.chkClosed)
        Me.GroupBox2.Controls.Add(Me.chkOpen)
        Me.GroupBox2.Controls.Add(Me.cbxSite)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cbxServiceLine)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(882, 67)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        '
        'lblTicketID
        '
        Me.lblTicketID.AutoSize = True
        Me.lblTicketID.Location = New System.Drawing.Point(300, 40)
        Me.lblTicketID.Name = "lblTicketID"
        Me.lblTicketID.Size = New System.Drawing.Size(51, 13)
        Me.lblTicketID.TabIndex = 58
        Me.lblTicketID.Text = "TicketID:"
        '
        'cbxTicket
        '
        Me.cbxTicket.FormattingEnabled = True
        Me.cbxTicket.Items.AddRange(New Object() {"Ticket ID", "Proforma Val."})
        Me.cbxTicket.Location = New System.Drawing.Point(303, 36)
        Me.cbxTicket.Name = "cbxTicket"
        Me.cbxTicket.Size = New System.Drawing.Size(101, 21)
        Me.cbxTicket.TabIndex = 57
        Me.cbxTicket.Text = "Ticket ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(300, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Customer:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(770, 19)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(86, 34)
        Me.btnSearch.TabIndex = 36
        Me.btnSearch.Text = "Ok"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cbxCustomer
        '
        Me.cbxCustomer.DataSource = Me.CbxCustomerBindingSource
        Me.cbxCustomer.DisplayMember = "NAME"
        Me.cbxCustomer.FormattingEnabled = True
        Me.cbxCustomer.Location = New System.Drawing.Point(410, 13)
        Me.cbxCustomer.Name = "cbxCustomer"
        Me.cbxCustomer.Size = New System.Drawing.Size(162, 21)
        Me.cbxCustomer.TabIndex = 56
        Me.cbxCustomer.ValueMember = "CUSTOMERID"
        '
        'CbxCustomerBindingSource
        '
        Me.CbxCustomerBindingSource.DataMember = "cbxCustomer"
        Me.CbxCustomerBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'txtTicketId
        '
        Me.txtTicketId.Location = New System.Drawing.Point(410, 37)
        Me.txtTicketId.Name = "txtTicketId"
        Me.txtTicketId.Size = New System.Drawing.Size(162, 20)
        Me.txtTicketId.TabIndex = 55
        '
        'chkCanceled
        '
        Me.chkCanceled.AutoSize = True
        Me.chkCanceled.Checked = True
        Me.chkCanceled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCanceled.Location = New System.Drawing.Point(673, 44)
        Me.chkCanceled.Name = "chkCanceled"
        Me.chkCanceled.Size = New System.Drawing.Size(71, 17)
        Me.chkCanceled.TabIndex = 39
        Me.chkCanceled.Text = "Canceled"
        Me.chkCanceled.UseVisualStyleBackColor = True
        '
        'chkClosed
        '
        Me.chkClosed.AutoSize = True
        Me.chkClosed.Checked = True
        Me.chkClosed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkClosed.Location = New System.Drawing.Point(673, 29)
        Me.chkClosed.Name = "chkClosed"
        Me.chkClosed.Size = New System.Drawing.Size(58, 17)
        Me.chkClosed.TabIndex = 38
        Me.chkClosed.Text = "Closed"
        Me.chkClosed.UseVisualStyleBackColor = True
        '
        'chkOpen
        '
        Me.chkOpen.AutoSize = True
        Me.chkOpen.Checked = True
        Me.chkOpen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOpen.Location = New System.Drawing.Point(673, 14)
        Me.chkOpen.Name = "chkOpen"
        Me.chkOpen.Size = New System.Drawing.Size(52, 17)
        Me.chkOpen.TabIndex = 37
        Me.chkOpen.Text = "Open"
        Me.chkOpen.UseVisualStyleBackColor = True
        '
        'cbxSite
        '
        Me.cbxSite.DataSource = Me.CbxSiteBindingSource
        Me.cbxSite.DisplayMember = "NAME"
        Me.cbxSite.FormattingEnabled = True
        Me.cbxSite.Location = New System.Drawing.Point(98, 37)
        Me.cbxSite.Name = "cbxSite"
        Me.cbxSite.Size = New System.Drawing.Size(185, 21)
        Me.cbxSite.TabIndex = 47
        Me.cbxSite.ValueMember = "SITEID"
        '
        'CbxSiteBindingSource
        '
        Me.CbxSiteBindingSource.DataMember = "cbxSite"
        Me.CbxSiteBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Site:"
        '
        'cbxServiceLine
        '
        Me.cbxServiceLine.DataSource = Me.CbxServiceLineBindingSource
        Me.cbxServiceLine.DisplayMember = "NAME"
        Me.cbxServiceLine.FormattingEnabled = True
        Me.cbxServiceLine.Location = New System.Drawing.Point(98, 13)
        Me.cbxServiceLine.Name = "cbxServiceLine"
        Me.cbxServiceLine.Size = New System.Drawing.Size(185, 21)
        Me.cbxServiceLine.TabIndex = 45
        Me.cbxServiceLine.ValueMember = "SERVICELINEID"
        '
        'CbxServiceLineBindingSource
        '
        Me.CbxServiceLineBindingSource.DataMember = "cbxServiceLine"
        Me.CbxServiceLineBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Service Line:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(594, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ticket Status:"
        '
        'TICKET_VTableAdapter
        '
        Me.TICKET_VTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CASINGTableAdapter = Nothing
        Me.TableAdapterManager.CITYTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CONTRACTTableAdapter = Nothing
        Me.TableAdapterManager.COUNTRYTableAdapter = Nothing
        Me.TableAdapterManager.CURRENCYTableAdapter = Nothing
        Me.TableAdapterManager.CUSTOMERTableAdapter = Nothing
        Me.TableAdapterManager.EQUIPMENTTableAdapter = Nothing
        Me.TableAdapterManager.HSEQ_ANSWERSTableAdapter = Nothing
        Me.TableAdapterManager.INVENTORYCLASSTableAdapter = Nothing
        Me.TableAdapterManager.INVENTORYITEMTableAdapter = Nothing
        Me.TableAdapterManager.INVENTORYUNITTableAdapter = Nothing
        Me.TableAdapterManager.PETRFIELDTableAdapter = Nothing
        Me.TableAdapterManager.REPORTTICKETLISTTableAdapter = Nothing
        Me.TableAdapterManager.RIGTableAdapter = Nothing
        Me.TableAdapterManager.SALESITEM_TOTAL_L01TableAdapter = Nothing
        Me.TableAdapterManager.SALESITEM_TOTAL_L02_MATTableAdapter = Nothing
        Me.TableAdapterManager.SALESITEM_TOTAL_L02_SERVTableAdapter = Nothing
        Me.TableAdapterManager.SERVICELINETableAdapter = Nothing
        Me.TableAdapterManager.SITESTableAdapter = Nothing
        Me.TableAdapterManager.STATETableAdapter = Nothing
        Me.TableAdapterManager.TICKETFILELOGTableAdapter = Nothing
        Me.TableAdapterManager.TICKETOPEREPACTTableAdapter = Nothing
        Me.TableAdapterManager.TICKETOPEREPTableAdapter = Nothing
        Me.TableAdapterManager.TICKETTableAdapter = Nothing
        Me.TableAdapterManager.TMP_RPT_TICKETSERVEVALSERVTableAdapter = Nothing
        Me.TableAdapterManager.TMP_TICKETCLOSETableAdapter = Nothing
        Me.TableAdapterManager.TUBINGTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Nothing
        Me.TableAdapterManager.WELLTableAdapter = Nothing
        Me.TableAdapterManager.WORKERTableAdapter = Nothing
        '
        'CbxServiceLineTableAdapter
        '
        Me.CbxServiceLineTableAdapter.ClearBeforeFill = True
        '
        'CbxCustomerTableAdapter
        '
        Me.CbxCustomerTableAdapter.ClearBeforeFill = True
        '
        'CbxSiteTableAdapter
        '
        Me.CbxSiteTableAdapter.ClearBeforeFill = True
        '
        'colAttach
        '
        Me.colAttach.HeaderText = ""
        Me.colAttach.Name = "colAttach"
        Me.colAttach.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colAttach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colAttach.Width = 20
        '
        'colTicketID
        '
        Me.colTicketID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTicketID.DataPropertyName = "TICKETID"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.colTicketID.DefaultCellStyle = DataGridViewCellStyle1
        Me.colTicketID.HeaderText = "Ticket"
        Me.colTicketID.Name = "colTicketID"
        Me.colTicketID.ReadOnly = True
        Me.colTicketID.Width = 62
        '
        'colSuperiorNum
        '
        Me.colSuperiorNum.DataPropertyName = "SUPERIORNUM"
        Me.colSuperiorNum.HeaderText = "Proforma Val Field Tickets"
        Me.colSuperiorNum.Name = "colSuperiorNum"
        Me.colSuperiorNum.ReadOnly = True
        '
        'colDM
        '
        Me.colDM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colDM.DataPropertyName = "DM"
        Me.colDM.HeaderText = "DM/CERTOP"
        Me.colDM.Name = "colDM"
        Me.colDM.ReadOnly = True
        Me.colDM.Width = 98
        '
        'colSuperiorSupName
        '
        Me.colSuperiorSupName.DataPropertyName = "SUPERIORSUPNAME"
        Me.colSuperiorSupName.HeaderText = "Superior´s Supervisor"
        Me.colSuperiorSupName.Name = "colSuperiorSupName"
        Me.colSuperiorSupName.ReadOnly = True
        Me.colSuperiorSupName.Width = 120
        '
        'colFullUserName
        '
        Me.colFullUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colFullUserName.DataPropertyName = "FULLUSERNAME"
        Me.colFullUserName.HeaderText = "Created By"
        Me.colFullUserName.Name = "colFullUserName"
        Me.colFullUserName.ReadOnly = True
        Me.colFullUserName.Width = 78
        '
        'colTicketStatus
        '
        Me.colTicketStatus.DataPropertyName = "TICKETSTATUS"
        Me.colTicketStatus.HeaderText = "Status"
        Me.colTicketStatus.Name = "colTicketStatus"
        Me.colTicketStatus.ReadOnly = True
        Me.colTicketStatus.Width = 68
        '
        'colDateService
        '
        Me.colDateService.DataPropertyName = "DATESERVICE"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colDateService.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDateService.HeaderText = "ServiceDate"
        Me.colDateService.Name = "colDateService"
        Me.colDateService.ReadOnly = True
        Me.colDateService.Width = 72
        '
        'colServiceLine
        '
        Me.colServiceLine.DataPropertyName = "SERVICELINE"
        Me.colServiceLine.HeaderText = "Service Line"
        Me.colServiceLine.Name = "colServiceLine"
        Me.colServiceLine.ReadOnly = True
        Me.colServiceLine.Width = 150
        '
        'colCustomerName
        '
        Me.colCustomerName.DataPropertyName = "CUSTOMERNAME"
        Me.colCustomerName.HeaderText = "Customer"
        Me.colCustomerName.Name = "colCustomerName"
        Me.colCustomerName.ReadOnly = True
        Me.colCustomerName.Width = 140
        '
        'colSite
        '
        Me.colSite.DataPropertyName = "SITE"
        Me.colSite.HeaderText = "Site"
        Me.colSite.Name = "colSite"
        Me.colSite.ReadOnly = True
        Me.colSite.Width = 45
        '
        'colWellID
        '
        Me.colWellID.DataPropertyName = "WELLID"
        Me.colWellID.HeaderText = "Well"
        Me.colWellID.Name = "colWellID"
        Me.colWellID.ReadOnly = True
        '
        'colCurrency
        '
        Me.colCurrency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCurrency.DataPropertyName = "Currency"
        Me.colCurrency.HeaderText = ""
        Me.colCurrency.Name = "colCurrency"
        Me.colCurrency.ReadOnly = True
        Me.colCurrency.Width = 19
        '
        'colItemAmount
        '
        Me.colItemAmount.DataPropertyName = "ITEMAMOUNT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "n2"
        Me.colItemAmount.DefaultCellStyle = DataGridViewCellStyle3
        Me.colItemAmount.HeaderText = "Amount"
        Me.colItemAmount.Name = "colItemAmount"
        Me.colItemAmount.ReadOnly = True
        '
        'colSyncDB
        '
        Me.colSyncDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSyncDB.DataPropertyName = "SyncDB"
        Me.colSyncDB.HeaderText = "Sync"
        Me.colSyncDB.Name = "colSyncDB"
        Me.colSyncDB.ReadOnly = True
        Me.colSyncDB.Width = 37
        '
        'colSyncDatetime
        '
        Me.colSyncDatetime.DataPropertyName = "SYNCDATETIME"
        DataGridViewCellStyle4.Format = "dd/MM/yyyy HH:mm:ss tt"
        Me.colSyncDatetime.DefaultCellStyle = DataGridViewCellStyle4
        Me.colSyncDatetime.HeaderText = "Sync Date"
        Me.colSyncDatetime.Name = "colSyncDatetime"
        Me.colSyncDatetime.ReadOnly = True
        Me.colSyncDatetime.Visible = False
        Me.colSyncDatetime.Width = 135
        '
        'colCustomerID
        '
        Me.colCustomerID.DataPropertyName = "CUSTOMERID"
        Me.colCustomerID.HeaderText = "CUSTOMERID"
        Me.colCustomerID.Name = "colCustomerID"
        Me.colCustomerID.Visible = False
        '
        'colServiceLineId
        '
        Me.colServiceLineId.DataPropertyName = "SERVICELINEID"
        Me.colServiceLineId.HeaderText = "SERVICELINEID"
        Me.colServiceLineId.Name = "colServiceLineId"
        Me.colServiceLineId.Visible = False
        '
        'colContractID
        '
        Me.colContractID.DataPropertyName = "CONTRACTID"
        Me.colContractID.HeaderText = "CONTRACTID"
        Me.colContractID.Name = "colContractID"
        Me.colContractID.Visible = False
        '
        'colCurrencyID
        '
        Me.colCurrencyID.DataPropertyName = "CURRENCYID"
        Me.colCurrencyID.HeaderText = "CURRENCYID"
        Me.colCurrencyID.Name = "colCurrencyID"
        Me.colCurrencyID.Visible = False
        '
        'colServiceTypeID
        '
        Me.colServiceTypeID.DataPropertyName = "SERVICETYPEID"
        Me.colServiceTypeID.HeaderText = "SERVICETYPEID"
        Me.colServiceTypeID.Name = "colServiceTypeID"
        Me.colServiceTypeID.Visible = False
        '
        'colTimeArrivedID
        '
        Me.colTimeArrivedID.DataPropertyName = "TIMEARRIVED"
        Me.colTimeArrivedID.HeaderText = "TIMEARRIVED"
        Me.colTimeArrivedID.Name = "colTimeArrivedID"
        Me.colTimeArrivedID.Visible = False
        '
        'colTimeStarted
        '
        Me.colTimeStarted.DataPropertyName = "TIMESTARTED"
        Me.colTimeStarted.HeaderText = "TIMESTARTED"
        Me.colTimeStarted.Name = "colTimeStarted"
        Me.colTimeStarted.Visible = False
        '
        'colTimeCompleted
        '
        Me.colTimeCompleted.DataPropertyName = "TIMECOMPLETED"
        Me.colTimeCompleted.HeaderText = "TIMECOMPLETED"
        Me.colTimeCompleted.Name = "colTimeCompleted"
        Me.colTimeCompleted.Visible = False
        '
        'colCasingSize
        '
        Me.colCasingSize.DataPropertyName = "CASINGSIZE"
        Me.colCasingSize.HeaderText = "CASINGSIZE"
        Me.colCasingSize.Name = "colCasingSize"
        Me.colCasingSize.Visible = False
        '
        'colCasingWeight
        '
        Me.colCasingWeight.DataPropertyName = "CASINGWEIGHT"
        Me.colCasingWeight.HeaderText = "CASINGWEIGHT"
        Me.colCasingWeight.Name = "colCasingWeight"
        Me.colCasingWeight.Visible = False
        '
        'colCasingGrade
        '
        Me.colCasingGrade.DataPropertyName = "CASINGGRADE"
        Me.colCasingGrade.HeaderText = "CASINGGRADE"
        Me.colCasingGrade.Name = "colCasingGrade"
        Me.colCasingGrade.Visible = False
        '
        'colTubingSize
        '
        Me.colTubingSize.DataPropertyName = "TUBINGSIZE"
        Me.colTubingSize.HeaderText = "TUBINGSIZE"
        Me.colTubingSize.Name = "colTubingSize"
        Me.colTubingSize.Visible = False
        '
        'colTubingWeight
        '
        Me.colTubingWeight.DataPropertyName = "TUBINGWEIGHT"
        Me.colTubingWeight.HeaderText = "TUBINGWEIGHT"
        Me.colTubingWeight.Name = "colTubingWeight"
        Me.colTubingWeight.Visible = False
        '
        'colTubingGrade
        '
        Me.colTubingGrade.DataPropertyName = "TUBINGGRADE"
        Me.colTubingGrade.HeaderText = "TUBINGGRADE"
        Me.colTubingGrade.Name = "colTubingGrade"
        Me.colTubingGrade.Visible = False
        '
        'colPressureMax
        '
        Me.colPressureMax.DataPropertyName = "PRESSUREMAX"
        Me.colPressureMax.HeaderText = "PRESSUREMAX"
        Me.colPressureMax.Name = "colPressureMax"
        Me.colPressureMax.Visible = False
        '
        'colDepthMax
        '
        Me.colDepthMax.DataPropertyName = "DEPTHMAX"
        Me.colDepthMax.HeaderText = "DEPTHMAX"
        Me.colDepthMax.Name = "colDepthMax"
        Me.colDepthMax.Visible = False
        '
        'colJobDescription
        '
        Me.colJobDescription.DataPropertyName = "JOBDESCRIPTION"
        Me.colJobDescription.HeaderText = "JOBDESCRIPTION"
        Me.colJobDescription.Name = "colJobDescription"
        Me.colJobDescription.Visible = False
        '
        'colCustRepRes
        '
        Me.colCustRepRes.DataPropertyName = "CUSTREPRES"
        Me.colCustRepRes.HeaderText = "CUSTREPRES"
        Me.colCustRepRes.Name = "colCustRepRes"
        Me.colCustRepRes.Visible = False
        '
        'colCustRepResPosition
        '
        Me.colCustRepResPosition.DataPropertyName = "CUSTREPRESPOSITION"
        Me.colCustRepResPosition.HeaderText = "CUSTREPRESPOSITION"
        Me.colCustRepResPosition.Name = "colCustRepResPosition"
        Me.colCustRepResPosition.Visible = False
        '
        'colCustRepResAssist
        '
        Me.colCustRepResAssist.DataPropertyName = "CUSTREPRESASSIST"
        Me.colCustRepResAssist.HeaderText = "CUSTREPRESASSIST"
        Me.colCustRepResAssist.Name = "colCustRepResAssist"
        Me.colCustRepResAssist.Visible = False
        '
        'colContractorRepresentative
        '
        Me.colContractorRepresentative.DataPropertyName = "CONTRACTORREPRESENTATIVE"
        Me.colContractorRepresentative.HeaderText = "CONTRACTORREPRESENTATIVE"
        Me.colContractorRepresentative.Name = "colContractorRepresentative"
        Me.colContractorRepresentative.Visible = False
        '
        'colCustComments
        '
        Me.colCustComments.DataPropertyName = "CUSTCOMMENTS"
        Me.colCustComments.HeaderText = "CUSTCOMMENTS"
        Me.colCustComments.Name = "colCustComments"
        Me.colCustComments.Visible = False
        '
        'colContractComments
        '
        Me.colContractComments.DataPropertyName = "CONTRACTCOMMENTS"
        Me.colContractComments.HeaderText = "CONTRACTCOMMENTS"
        Me.colContractComments.Name = "colContractComments"
        Me.colContractComments.Visible = False
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "CREATEDUSER"
        Me.DataGridViewTextBoxColumn27.HeaderText = "CREATEDUSER"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "CREATEDDATETIME"
        Me.DataGridViewTextBoxColumn28.HeaderText = "CREATEDDATETIME"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Visible = False
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "UPDATEDDATETIME"
        Me.DataGridViewTextBoxColumn29.HeaderText = "UPDATEDDATETIME"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "UPDATEDUSER"
        Me.DataGridViewTextBoxColumn30.HeaderText = "UPDATEDUSER"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Visible = False
        '
        'colRig
        '
        Me.colRig.DataPropertyName = "RIG"
        Me.colRig.HeaderText = "RIG"
        Me.colRig.Name = "colRig"
        Me.colRig.Visible = False
        '
        'colExchangeRate
        '
        Me.colExchangeRate.DataPropertyName = "EXCHANGERATE"
        Me.colExchangeRate.HeaderText = "EXCHANGERATE"
        Me.colExchangeRate.Name = "colExchangeRate"
        Me.colExchangeRate.Visible = False
        '
        'colCancelDateTime
        '
        Me.colCancelDateTime.DataPropertyName = "CANCELDATETIME"
        Me.colCancelDateTime.HeaderText = "CANCELDATETIME"
        Me.colCancelDateTime.Name = "colCancelDateTime"
        Me.colCancelDateTime.Visible = False
        '
        'colCancelUser
        '
        Me.colCancelUser.DataPropertyName = "CANCELUSER"
        Me.colCancelUser.HeaderText = "CANCELUSER"
        Me.colCancelUser.Name = "colCancelUser"
        Me.colCancelUser.Visible = False
        '
        'colCancelReason
        '
        Me.colCancelReason.DataPropertyName = "CANCELREASON"
        Me.colCancelReason.HeaderText = "CANCELREASON"
        Me.colCancelReason.Name = "colCancelReason"
        Me.colCancelReason.Visible = False
        '
        'colCustRepresAssistPos
        '
        Me.colCustRepresAssistPos.DataPropertyName = "CUSTREPRESASSISTPOSITION"
        Me.colCustRepresAssistPos.HeaderText = "CUSTREPRESASSISTPOSITION"
        Me.colCustRepresAssistPos.Name = "colCustRepresAssistPos"
        Me.colCustRepresAssistPos.Visible = False
        '
        'colInvoiceNumber
        '
        Me.colInvoiceNumber.DataPropertyName = "INVOICENUMBER"
        Me.colInvoiceNumber.HeaderText = "INVOICENUMBER"
        Me.colInvoiceNumber.Name = "colInvoiceNumber"
        Me.colInvoiceNumber.Visible = False
        '
        'colAdicInform
        '
        Me.colAdicInform.DataPropertyName = "ADICINFORM"
        Me.colAdicInform.HeaderText = "ADICINFORM"
        Me.colAdicInform.Name = "colAdicInform"
        Me.colAdicInform.Visible = False
        '
        'colWellName
        '
        Me.colWellName.DataPropertyName = "WELLNAME"
        Me.colWellName.HeaderText = "WELLNAME"
        Me.colWellName.Name = "colWellName"
        Me.colWellName.Visible = False
        '
        'colNoInvItem
        '
        Me.colNoInvItem.DataPropertyName = "NOINVITEM"
        Me.colNoInvItem.HeaderText = "NOINVITEM"
        Me.colNoInvItem.Name = "colNoInvItem"
        Me.colNoInvItem.Visible = False
        '
        'colHasAttach
        '
        Me.colHasAttach.DataPropertyName = "HASATTACH"
        Me.colHasAttach.HeaderText = "HASATTACH"
        Me.colHasAttach.Name = "colHasAttach"
        Me.colHasAttach.Visible = False
        '
        'colJobNumber
        '
        Me.colJobNumber.DataPropertyName = "JOBNUMBER"
        Me.colJobNumber.HeaderText = "JOBNUMBER"
        Me.colJobNumber.Name = "colJobNumber"
        Me.colJobNumber.Visible = False
        '
        'colSiteId
        '
        Me.colSiteId.DataPropertyName = "SITEID"
        Me.colSiteId.HeaderText = "SITEID"
        Me.colSiteId.Name = "colSiteId"
        Me.colSiteId.Visible = False
        '
        'colContrRepresName
        '
        Me.colContrRepresName.DataPropertyName = "CONTRREPRESNAME"
        Me.colContrRepresName.HeaderText = "CONTRREPRESNAME"
        Me.colContrRepresName.Name = "colContrRepresName"
        Me.colContrRepresName.ReadOnly = True
        Me.colContrRepresName.Visible = False
        '
        'colServiceOrderNum
        '
        Me.colServiceOrderNum.DataPropertyName = "SERVICEORDERNUM"
        Me.colServiceOrderNum.HeaderText = "Service Order"
        Me.colServiceOrderNum.Name = "colServiceOrderNum"
        Me.colServiceOrderNum.Visible = False
        '
        'colSuperiorSupervisor
        '
        Me.colSuperiorSupervisor.DataPropertyName = "SUPERIORSUPERVISOR"
        Me.colSuperiorSupervisor.HeaderText = "SUPERIORSUPERVISOR"
        Me.colSuperiorSupervisor.Name = "colSuperiorSupervisor"
        Me.colSuperiorSupervisor.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1191, 649)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvTicketAccess)
        Me.Controls.Add(Me.mnuMain)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTicket - Version 1.1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvTicketAccess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmnuGridPrincip.ResumeLayout(False)
        CType(Me.TICKET_VBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.CbxCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbxSiteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbxServiceLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripLogin As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripFullName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSQL As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SESTicketAccessDataSet As SESTicket.SESTicketAccessDataSet
    Friend WithEvents TICKET_VBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TICKET_VTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.TICKET_VTableAdapter
    Friend WithEvents dgvTicketAccess As System.Windows.Forms.DataGridView
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuBaseData As ToolStripMenuItem
    Friend WithEvents mnuNewTicket As ToolStripMenuItem
    Friend WithEvents mnuSyncTicket As ToolStripMenuItem
    Friend WithEvents mnuTicketDatabase As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuReport As ToolStripMenuItem
    Friend WithEvents mnuInvControl As ToolStripMenuItem
    Friend WithEvents mnuUpdateBaseData As ToolStripMenuItem
    Friend WithEvents mnuSep02 As ToolStripSeparator
    Friend WithEvents mnuSystem As ToolStripMenuItem
    Friend WithEvents mnuSystemUsers As ToolStripMenuItem
    Friend WithEvents mnuResource As ToolStripMenuItem
    Friend WithEvents mnuResourceEquipment As ToolStripMenuItem
    Friend WithEvents mnuResourceWorker As ToolStripMenuItem
    Friend WithEvents mnuInventory As ToolStripMenuItem
    Friend WithEvents mnuInventoryItem As ToolStripMenuItem
    Friend WithEvents mnuInventoryClass As ToolStripMenuItem
    Friend WithEvents mnuCustomer As ToolStripMenuItem
    Friend WithEvents mnuCustomerList As ToolStripMenuItem
    Friend WithEvents mnuContractHeader As ToolStripMenuItem
    Friend WithEvents mnuContractPriceList As ToolStripMenuItem
    Friend WithEvents mnuOperational As ToolStripMenuItem
    Friend WithEvents mnuOperSites As ToolStripMenuItem
    Friend WithEvents mnuOperSep00 As ToolStripSeparator
    Friend WithEvents mnuOperPetrFields As ToolStripMenuItem
    Friend WithEvents mnuOperRig As ToolStripMenuItem
    Friend WithEvents mnuOperWell As ToolStripMenuItem
    Friend WithEvents mnuOperSep01 As ToolStripSeparator
    Friend WithEvents mnuOperServiceLine As ToolStripMenuItem
    Friend WithEvents mnuOperServiceType As ToolStripMenuItem
    Friend WithEvents mnuSep03 As ToolStripSeparator
    Friend WithEvents mnuReportParameter As ToolStripMenuItem
    Friend WithEvents mnuSep00 As ToolStripMenuItem
    Friend WithEvents mnuSep01 As ToolStripMenuItem
    Friend WithEvents mnuSepMain00 As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents cbxCustomer As ComboBox
    Friend WithEvents txtTicketId As TextBox
    Friend WithEvents chkCanceled As CheckBox
    Friend WithEvents chkClosed As CheckBox
    Friend WithEvents chkOpen As CheckBox
    Friend WithEvents cbxSite As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxServiceLine As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CbxServiceLineBindingSource As BindingSource
    Friend WithEvents CbxServiceLineTableAdapter As SESTicketAccessDataSetTableAdapters.cbxServiceLineTableAdapter
    Friend WithEvents CbxCustomerBindingSource As BindingSource
    Friend WithEvents CbxCustomerTableAdapter As SESTicketAccessDataSetTableAdapters.cbxCustomerTableAdapter
    Friend WithEvents CbxSiteBindingSource As BindingSource
    Friend WithEvents CbxSiteTableAdapter As SESTicketAccessDataSetTableAdapters.cbxSiteTableAdapter
    Friend WithEvents cmnuGridPrincip As ContextMenuStrip
    Friend WithEvents cmnuOpenTicket As ToolStripMenuItem
    Friend WithEvents cmnuCloneTicket As ToolStripMenuItem
    Friend WithEvents cmnuAttachment As ToolStripMenuItem
    Friend WithEvents cmnuRemoveTicketList As ToolStripMenuItem
    Friend WithEvents cmnuSep00 As ToolStripSeparator
    Friend WithEvents cbxTicket As ComboBox
    Friend WithEvents lblTicketID As Label
    Friend WithEvents mnuCloseTickets As ToolStripMenuItem
    Friend WithEvents cmnuSep01 As ToolStripSeparator
    Friend WithEvents mnuChangeSupSupervisor As ToolStripMenuItem
    Friend WithEvents colAttach As DataGridViewImageColumn
    Friend WithEvents colTicketID As DataGridViewTextBoxColumn
    Friend WithEvents colSuperiorNum As DataGridViewTextBoxColumn
    Friend WithEvents colDM As DataGridViewTextBoxColumn
    Friend WithEvents colSuperiorSupName As DataGridViewTextBoxColumn
    Friend WithEvents colFullUserName As DataGridViewTextBoxColumn
    Friend WithEvents colTicketStatus As DataGridViewTextBoxColumn
    Friend WithEvents colDateService As DataGridViewTextBoxColumn
    Friend WithEvents colServiceLine As DataGridViewTextBoxColumn
    Friend WithEvents colCustomerName As DataGridViewTextBoxColumn
    Friend WithEvents colSite As DataGridViewTextBoxColumn
    Friend WithEvents colWellID As DataGridViewTextBoxColumn
    Friend WithEvents colCurrency As DataGridViewTextBoxColumn
    Friend WithEvents colItemAmount As DataGridViewTextBoxColumn
    Friend WithEvents colSyncDB As DataGridViewCheckBoxColumn
    Friend WithEvents colSyncDatetime As DataGridViewTextBoxColumn
    Friend WithEvents colCustomerID As DataGridViewTextBoxColumn
    Friend WithEvents colServiceLineId As DataGridViewTextBoxColumn
    Friend WithEvents colContractID As DataGridViewTextBoxColumn
    Friend WithEvents colCurrencyID As DataGridViewTextBoxColumn
    Friend WithEvents colServiceTypeID As DataGridViewTextBoxColumn
    Friend WithEvents colTimeArrivedID As DataGridViewTextBoxColumn
    Friend WithEvents colTimeStarted As DataGridViewTextBoxColumn
    Friend WithEvents colTimeCompleted As DataGridViewTextBoxColumn
    Friend WithEvents colCasingSize As DataGridViewTextBoxColumn
    Friend WithEvents colCasingWeight As DataGridViewTextBoxColumn
    Friend WithEvents colCasingGrade As DataGridViewTextBoxColumn
    Friend WithEvents colTubingSize As DataGridViewTextBoxColumn
    Friend WithEvents colTubingWeight As DataGridViewTextBoxColumn
    Friend WithEvents colTubingGrade As DataGridViewTextBoxColumn
    Friend WithEvents colPressureMax As DataGridViewTextBoxColumn
    Friend WithEvents colDepthMax As DataGridViewTextBoxColumn
    Friend WithEvents colJobDescription As DataGridViewTextBoxColumn
    Friend WithEvents colCustRepRes As DataGridViewTextBoxColumn
    Friend WithEvents colCustRepResPosition As DataGridViewTextBoxColumn
    Friend WithEvents colCustRepResAssist As DataGridViewTextBoxColumn
    Friend WithEvents colContractorRepresentative As DataGridViewTextBoxColumn
    Friend WithEvents colCustComments As DataGridViewTextBoxColumn
    Friend WithEvents colContractComments As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents colRig As DataGridViewTextBoxColumn
    Friend WithEvents colExchangeRate As DataGridViewTextBoxColumn
    Friend WithEvents colCancelDateTime As DataGridViewTextBoxColumn
    Friend WithEvents colCancelUser As DataGridViewTextBoxColumn
    Friend WithEvents colCancelReason As DataGridViewTextBoxColumn
    Friend WithEvents colCustRepresAssistPos As DataGridViewTextBoxColumn
    Friend WithEvents colInvoiceNumber As DataGridViewTextBoxColumn
    Friend WithEvents colAdicInform As DataGridViewTextBoxColumn
    Friend WithEvents colWellName As DataGridViewTextBoxColumn
    Friend WithEvents colNoInvItem As DataGridViewTextBoxColumn
    Friend WithEvents colHasAttach As DataGridViewTextBoxColumn
    Friend WithEvents colJobNumber As DataGridViewTextBoxColumn
    Friend WithEvents colSiteId As DataGridViewTextBoxColumn
    Friend WithEvents colContrRepresName As DataGridViewTextBoxColumn
    Friend WithEvents colServiceOrderNum As DataGridViewTextBoxColumn
    Friend WithEvents colSuperiorSupervisor As DataGridViewTextBoxColumn
End Class
