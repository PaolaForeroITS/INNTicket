<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoiceList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvInvoice = New System.Windows.Forms.DataGridView()
        Me.cmnuGridPrincip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuImportTicket = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuReOpenTicket = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuSep00 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExportExcel = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuSep02 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmnuChangeTicketClosedDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuSep01 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmnuCancelTicket = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpTicketInvoiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTicketID = New System.Windows.Forms.Label()
        Me.cbxDate = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxCustomer = New System.Windows.Forms.ComboBox()
        Me.CbxCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.cbxTicket = New System.Windows.Forms.ComboBox()
        Me.txtTicketId = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.chkCompleted = New System.Windows.Forms.CheckBox()
        Me.chkParcially = New System.Windows.Forms.CheckBox()
        Me.chkNoInvoice = New System.Windows.Forms.CheckBox()
        Me.cbxSite = New System.Windows.Forms.ComboBox()
        Me.CbxSiteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxServiceLine = New System.Windows.Forms.ComboBox()
        Me.CbxServiceLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxTicketStatus = New System.Windows.Forms.ComboBox()
        Me.CbxTicketStatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtpServiceDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpServiceDateBegin = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDif = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtInvoicedTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTicketTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Sp_TicketInvoiceTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.sp_TicketInvoiceTableAdapter()
        Me.CbxServiceLineTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.cbxServiceLineTableAdapter()
        Me.CbxSiteTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.cbxSiteTableAdapter()
        Me.CbxTicketStatusTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.cbxTicketStatusTableAdapter()
        Me.CbxCustomerTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.cbxCustomerTableAdapter()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.colTicketId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colClosedDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSuperiorNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLineType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvoiceStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvoiceDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContract = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWell = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCurrency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiscount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvoiceTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketInvoiceId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvoiceDetail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceTypeGrpCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJobNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceOrderNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSuperiorSupervName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmnuGridPrincip.SuspendLayout()
        CType(Me.SpTicketInvoiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CbxCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbxSiteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbxServiceLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbxTicketStatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvInvoice
        '
        Me.dgvInvoice.AllowUserToAddRows = False
        Me.dgvInvoice.AllowUserToDeleteRows = False
        Me.dgvInvoice.AutoGenerateColumns = False
        Me.dgvInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTicketId, Me.colServiceDate, Me.colClosedDate, Me.colSuperiorNum, Me.colLineType, Me.colCreatedBy, Me.colTicketStatus, Me.colInvoiceStatus, Me.colInvoiceDate, Me.colServiceLine, Me.colCustomer, Me.colContract, Me.colSite, Me.colWell, Me.colCurrency, Me.colSubTotal, Me.colDiscount, Me.colTicketTotal, Me.colInvoiceTotal, Me.colDif, Me.colTicketInvoiceId, Me.colInvoiceDetail, Me.colServiceTypeGrpCode, Me.colServiceType, Me.colDM, Me.colJobNumber, Me.colServiceOrderNum, Me.colSuperiorSupervName})
        Me.dgvInvoice.ContextMenuStrip = Me.cmnuGridPrincip
        Me.dgvInvoice.DataSource = Me.SpTicketInvoiceBindingSource
        Me.dgvInvoice.Location = New System.Drawing.Point(5, 84)
        Me.dgvInvoice.Name = "dgvInvoice"
        Me.dgvInvoice.ReadOnly = True
        Me.dgvInvoice.RowHeadersWidth = 12
        Me.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvoice.Size = New System.Drawing.Size(1187, 489)
        Me.dgvInvoice.TabIndex = 1
        '
        'cmnuGridPrincip
        '
        Me.cmnuGridPrincip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuImportTicket, Me.cmnuReOpenTicket, Me.cmnuSep00, Me.mnuExportExcel, Me.cmnuSep02, Me.cmnuChangeTicketClosedDate, Me.cmnuSep01, Me.cmnuCancelTicket})
        Me.cmnuGridPrincip.Name = "cmnuGridPrincip"
        Me.cmnuGridPrincip.Size = New System.Drawing.Size(217, 132)
        '
        'cmnuImportTicket
        '
        Me.cmnuImportTicket.Image = CType(resources.GetObject("cmnuImportTicket.Image"), System.Drawing.Image)
        Me.cmnuImportTicket.Name = "cmnuImportTicket"
        Me.cmnuImportTicket.Size = New System.Drawing.Size(216, 22)
        Me.cmnuImportTicket.Text = "Import Ticket"
        '
        'cmnuReOpenTicket
        '
        Me.cmnuReOpenTicket.Image = CType(resources.GetObject("cmnuReOpenTicket.Image"), System.Drawing.Image)
        Me.cmnuReOpenTicket.Name = "cmnuReOpenTicket"
        Me.cmnuReOpenTicket.Size = New System.Drawing.Size(216, 22)
        Me.cmnuReOpenTicket.Text = "Re-Open Ticket"
        '
        'cmnuSep00
        '
        Me.cmnuSep00.Name = "cmnuSep00"
        Me.cmnuSep00.Size = New System.Drawing.Size(213, 6)
        '
        'mnuExportExcel
        '
        Me.mnuExportExcel.Image = CType(resources.GetObject("mnuExportExcel.Image"), System.Drawing.Image)
        Me.mnuExportExcel.Name = "mnuExportExcel"
        Me.mnuExportExcel.Size = New System.Drawing.Size(216, 22)
        Me.mnuExportExcel.Text = "Export to Excel"
        '
        'cmnuSep02
        '
        Me.cmnuSep02.Name = "cmnuSep02"
        Me.cmnuSep02.Size = New System.Drawing.Size(213, 6)
        '
        'cmnuChangeTicketClosedDate
        '
        Me.cmnuChangeTicketClosedDate.Image = CType(resources.GetObject("cmnuChangeTicketClosedDate.Image"), System.Drawing.Image)
        Me.cmnuChangeTicketClosedDate.Name = "cmnuChangeTicketClosedDate"
        Me.cmnuChangeTicketClosedDate.Size = New System.Drawing.Size(216, 22)
        Me.cmnuChangeTicketClosedDate.Text = "Change Ticket Closed Date"
        '
        'cmnuSep01
        '
        Me.cmnuSep01.Name = "cmnuSep01"
        Me.cmnuSep01.Size = New System.Drawing.Size(213, 6)
        '
        'cmnuCancelTicket
        '
        Me.cmnuCancelTicket.Image = CType(resources.GetObject("cmnuCancelTicket.Image"), System.Drawing.Image)
        Me.cmnuCancelTicket.Name = "cmnuCancelTicket"
        Me.cmnuCancelTicket.Size = New System.Drawing.Size(216, 22)
        Me.cmnuCancelTicket.Text = "Cancel Ticket"
        '
        'SpTicketInvoiceBindingSource
        '
        Me.SpTicketInvoiceBindingSource.DataMember = "sp_TicketInvoice"
        Me.SpTicketInvoiceBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTicketID)
        Me.GroupBox1.Controls.Add(Me.cbxDate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbxCustomer)
        Me.GroupBox1.Controls.Add(Me.cbxTicket)
        Me.GroupBox1.Controls.Add(Me.txtTicketId)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.chkCompleted)
        Me.GroupBox1.Controls.Add(Me.chkParcially)
        Me.GroupBox1.Controls.Add(Me.chkNoInvoice)
        Me.GroupBox1.Controls.Add(Me.cbxSite)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbxServiceLine)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbxTicketStatus)
        Me.GroupBox1.Controls.Add(Me.dtpServiceDateEnd)
        Me.GroupBox1.Controls.Add(Me.dtpServiceDateBegin)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1178, 66)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'lblTicketID
        '
        Me.lblTicketID.AutoSize = True
        Me.lblTicketID.Location = New System.Drawing.Point(484, 40)
        Me.lblTicketID.Name = "lblTicketID"
        Me.lblTicketID.Size = New System.Drawing.Size(51, 13)
        Me.lblTicketID.TabIndex = 59
        Me.lblTicketID.Text = "TicketID:"
        '
        'cbxDate
        '
        Me.cbxDate.FormattingEnabled = True
        Me.cbxDate.Items.AddRange(New Object() {"Service Date", "Invoice Date", "Closed Date"})
        Me.cbxDate.Location = New System.Drawing.Point(7, 13)
        Me.cbxDate.Name = "cbxDate"
        Me.cbxDate.Size = New System.Drawing.Size(93, 21)
        Me.cbxDate.TabIndex = 60
        Me.cbxDate.Text = "Service Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(708, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Customer:"
        '
        'cbxCustomer
        '
        Me.cbxCustomer.DataSource = Me.CbxCustomerBindingSource
        Me.cbxCustomer.DisplayMember = "NAME"
        Me.cbxCustomer.FormattingEnabled = True
        Me.cbxCustomer.Location = New System.Drawing.Point(768, 13)
        Me.cbxCustomer.Name = "cbxCustomer"
        Me.cbxCustomer.Size = New System.Drawing.Size(133, 21)
        Me.cbxCustomer.TabIndex = 58
        Me.cbxCustomer.ValueMember = "CUSTOMERID"
        '
        'CbxCustomerBindingSource
        '
        Me.CbxCustomerBindingSource.DataMember = "cbxCustomer"
        Me.CbxCustomerBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'cbxTicket
        '
        Me.cbxTicket.FormattingEnabled = True
        Me.cbxTicket.Items.AddRange(New Object() {"Ticket ID", "Proforma Val.", "Invoice Number"})
        Me.cbxTicket.Location = New System.Drawing.Point(487, 37)
        Me.cbxTicket.Name = "cbxTicket"
        Me.cbxTicket.Size = New System.Drawing.Size(101, 21)
        Me.cbxTicket.TabIndex = 56
        Me.cbxTicket.Text = "Ticket ID"
        '
        'txtTicketId
        '
        Me.txtTicketId.Location = New System.Drawing.Point(594, 38)
        Me.txtTicketId.Name = "txtTicketId"
        Me.txtTicketId.Size = New System.Drawing.Size(99, 20)
        Me.txtTicketId.TabIndex = 57
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(1097, 19)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 53
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'chkCompleted
        '
        Me.chkCompleted.AutoSize = True
        Me.chkCompleted.Checked = True
        Me.chkCompleted.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCompleted.Location = New System.Drawing.Point(1005, 43)
        Me.chkCompleted.Name = "chkCompleted"
        Me.chkCompleted.Size = New System.Drawing.Size(76, 17)
        Me.chkCompleted.TabIndex = 50
        Me.chkCompleted.Text = "Completed"
        Me.chkCompleted.UseVisualStyleBackColor = True
        '
        'chkParcially
        '
        Me.chkParcially.AutoSize = True
        Me.chkParcially.Checked = True
        Me.chkParcially.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkParcially.Location = New System.Drawing.Point(1005, 29)
        Me.chkParcially.Name = "chkParcially"
        Me.chkParcially.Size = New System.Drawing.Size(65, 17)
        Me.chkParcially.TabIndex = 49
        Me.chkParcially.Text = "Parcially"
        Me.chkParcially.UseVisualStyleBackColor = True
        '
        'chkNoInvoice
        '
        Me.chkNoInvoice.AutoSize = True
        Me.chkNoInvoice.Checked = True
        Me.chkNoInvoice.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNoInvoice.Location = New System.Drawing.Point(1005, 14)
        Me.chkNoInvoice.Name = "chkNoInvoice"
        Me.chkNoInvoice.Size = New System.Drawing.Size(84, 17)
        Me.chkNoInvoice.TabIndex = 48
        Me.chkNoInvoice.Text = "No Invoiced"
        Me.chkNoInvoice.UseVisualStyleBackColor = True
        '
        'cbxSite
        '
        Me.cbxSite.DataSource = Me.CbxSiteBindingSource
        Me.cbxSite.DisplayMember = "NAME"
        Me.cbxSite.FormattingEnabled = True
        Me.cbxSite.Location = New System.Drawing.Point(342, 37)
        Me.cbxSite.Name = "cbxSite"
        Me.cbxSite.Size = New System.Drawing.Size(126, 21)
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
        Me.Label6.Location = New System.Drawing.Point(267, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Site:"
        '
        'cbxServiceLine
        '
        Me.cbxServiceLine.DataSource = Me.CbxServiceLineBindingSource
        Me.cbxServiceLine.DisplayMember = "SERVICELINENAME"
        Me.cbxServiceLine.FormattingEnabled = True
        Me.cbxServiceLine.Location = New System.Drawing.Point(342, 13)
        Me.cbxServiceLine.Name = "cbxServiceLine"
        Me.cbxServiceLine.Size = New System.Drawing.Size(126, 21)
        Me.cbxServiceLine.TabIndex = 45
        Me.cbxServiceLine.ValueMember = "SERVICELINEID"
        '
        'CbxServiceLineBindingSource
        '
        Me.CbxServiceLineBindingSource.DataMember = "cbxServiceLine"
        Me.CbxServiceLineBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(267, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Service Line:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(921, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Invoice Status:"
        '
        'cbxTicketStatus
        '
        Me.cbxTicketStatus.DataSource = Me.CbxTicketStatusBindingSource
        Me.cbxTicketStatus.DisplayMember = "TICKETSTATUS"
        Me.cbxTicketStatus.FormattingEnabled = True
        Me.cbxTicketStatus.Location = New System.Drawing.Point(594, 14)
        Me.cbxTicketStatus.Name = "cbxTicketStatus"
        Me.cbxTicketStatus.Size = New System.Drawing.Size(99, 21)
        Me.cbxTicketStatus.TabIndex = 41
        Me.cbxTicketStatus.ValueMember = "TICKETSTATUS"
        '
        'CbxTicketStatusBindingSource
        '
        Me.CbxTicketStatusBindingSource.DataMember = "cbxTicketStatus"
        Me.CbxTicketStatusBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'dtpServiceDateEnd
        '
        Me.dtpServiceDateEnd.CustomFormat = "dd/MM/yyyy"
        Me.dtpServiceDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpServiceDateEnd.Location = New System.Drawing.Point(151, 38)
        Me.dtpServiceDateEnd.Name = "dtpServiceDateEnd"
        Me.dtpServiceDateEnd.Size = New System.Drawing.Size(96, 20)
        Me.dtpServiceDateEnd.TabIndex = 40
        '
        'dtpServiceDateBegin
        '
        Me.dtpServiceDateBegin.CustomFormat = "dd/MM/yyyy"
        Me.dtpServiceDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpServiceDateBegin.Location = New System.Drawing.Point(151, 14)
        Me.dtpServiceDateBegin.Name = "dtpServiceDateBegin"
        Me.dtpServiceDateBegin.Size = New System.Drawing.Size(96, 20)
        Me.dtpServiceDateBegin.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(484, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ticket Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(106, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "(End):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(106, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "(Begin):"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CASINGTableAdapter = Nothing
        Me.TableAdapterManager.CITYTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CONTRACTAIUINVENTORYCLASSTableAdapter = Nothing
        Me.TableAdapterManager.CONTRACTPRICELISTTableAdapter = Nothing
        Me.TableAdapterManager.CONTRACTTableAdapter = Nothing
        Me.TableAdapterManager.CUSTOMERTableAdapter = Nothing
        Me.TableAdapterManager.EQUIPMENTTableAdapter = Nothing
        Me.TableAdapterManager.IMP_CONTRACTPRICELISTTableAdapter = Nothing
        Me.TableAdapterManager.IMP_EQUIPMENTTableAdapter = Nothing
        Me.TableAdapterManager.IMP_INVENTORYITEMTableAdapter = Nothing
        Me.TableAdapterManager.IMP_WELLTableAdapter = Nothing
        Me.TableAdapterManager.IMP_WORKERTableAdapter = Nothing
        Me.TableAdapterManager.INVENTORYCLASS_PRICETableAdapter = Nothing
        Me.TableAdapterManager.INVENTORYCLASSTableAdapter = Nothing
        Me.TableAdapterManager.INVENTORYITEMTableAdapter = Nothing
        Me.TableAdapterManager.INVENTORYUNITTableAdapter = Nothing
        Me.TableAdapterManager.PETRFIELDTableAdapter = Nothing
        Me.TableAdapterManager.RIGTableAdapter = Nothing
        Me.TableAdapterManager.SERVICELINETableAdapter = Nothing
        Me.TableAdapterManager.SERVICETYPETableAdapter = Nothing
        Me.TableAdapterManager.SITESTableAdapter = Nothing
        Me.TableAdapterManager.STATETableAdapter = Nothing
        Me.TableAdapterManager.TICKETINVOICELINETableAdapter = Nothing
        Me.TableAdapterManager.TUBINGTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Nothing
        Me.TableAdapterManager.WELLTableAdapter = Nothing
        Me.TableAdapterManager.WORKERTableAdapter = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtDif)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtInvoicedTotal)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtTicketTotal)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(802, 579)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 46)
        Me.Panel1.TabIndex = 51
        '
        'txtDif
        '
        Me.txtDif.BackColor = System.Drawing.Color.White
        Me.txtDif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDif.Enabled = False
        Me.txtDif.Location = New System.Drawing.Point(252, 17)
        Me.txtDif.Name = "txtDif"
        Me.txtDif.ReadOnly = True
        Me.txtDif.Size = New System.Drawing.Size(105, 20)
        Me.txtDif.TabIndex = 55
        Me.txtDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(249, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Dif:"
        '
        'txtInvoicedTotal
        '
        Me.txtInvoicedTotal.BackColor = System.Drawing.Color.White
        Me.txtInvoicedTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvoicedTotal.Enabled = False
        Me.txtInvoicedTotal.Location = New System.Drawing.Point(141, 17)
        Me.txtInvoicedTotal.Name = "txtInvoicedTotal"
        Me.txtInvoicedTotal.ReadOnly = True
        Me.txtInvoicedTotal.Size = New System.Drawing.Size(105, 20)
        Me.txtInvoicedTotal.TabIndex = 51
        Me.txtInvoicedTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(138, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Invoiced Total:"
        '
        'txtTicketTotal
        '
        Me.txtTicketTotal.BackColor = System.Drawing.Color.White
        Me.txtTicketTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTicketTotal.Enabled = False
        Me.txtTicketTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTicketTotal.Location = New System.Drawing.Point(30, 17)
        Me.txtTicketTotal.Name = "txtTicketTotal"
        Me.txtTicketTotal.ReadOnly = True
        Me.txtTicketTotal.Size = New System.Drawing.Size(105, 20)
        Me.txtTicketTotal.TabIndex = 49
        Me.txtTicketTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(27, 3)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Ticket Total:"
        '
        'Sp_TicketInvoiceTableAdapter
        '
        Me.Sp_TicketInvoiceTableAdapter.ClearBeforeFill = True
        '
        'CbxServiceLineTableAdapter
        '
        Me.CbxServiceLineTableAdapter.ClearBeforeFill = True
        '
        'CbxSiteTableAdapter
        '
        Me.CbxSiteTableAdapter.ClearBeforeFill = True
        '
        'CbxTicketStatusTableAdapter
        '
        Me.CbxTicketStatusTableAdapter.ClearBeforeFill = True
        '
        'CbxCustomerTableAdapter
        '
        Me.CbxCustomerTableAdapter.ClearBeforeFill = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "xlsx"
        Me.SaveFileDialog1.Filter = "*.xlsx|"
        '
        'colTicketId
        '
        Me.colTicketId.DataPropertyName = "TICKETID"
        Me.colTicketId.HeaderText = "Ticket"
        Me.colTicketId.Name = "colTicketId"
        Me.colTicketId.ReadOnly = True
        Me.colTicketId.Width = 55
        '
        'colServiceDate
        '
        Me.colServiceDate.DataPropertyName = "DATESERVICE"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colServiceDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.colServiceDate.HeaderText = "Service Date"
        Me.colServiceDate.Name = "colServiceDate"
        Me.colServiceDate.ReadOnly = True
        Me.colServiceDate.Width = 70
        '
        'colClosedDate
        '
        Me.colClosedDate.DataPropertyName = "CLOSEDDATE"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colClosedDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.colClosedDate.HeaderText = "Ticket Closed Date"
        Me.colClosedDate.Name = "colClosedDate"
        Me.colClosedDate.ReadOnly = True
        Me.colClosedDate.Width = 88
        '
        'colSuperiorNum
        '
        Me.colSuperiorNum.DataPropertyName = "SUPERIORNUM"
        Me.colSuperiorNum.HeaderText = "Proforma Val Field Tickets"
        Me.colSuperiorNum.Name = "colSuperiorNum"
        Me.colSuperiorNum.ReadOnly = True
        '
        'colLineType
        '
        Me.colLineType.DataPropertyName = "LINETYPE"
        Me.colLineType.HeaderText = "Type"
        Me.colLineType.Name = "colLineType"
        Me.colLineType.ReadOnly = True
        Me.colLineType.Width = 55
        '
        'colCreatedBy
        '
        Me.colCreatedBy.DataPropertyName = "CREATEDBY"
        Me.colCreatedBy.HeaderText = "Created By"
        Me.colCreatedBy.Name = "colCreatedBy"
        Me.colCreatedBy.ReadOnly = True
        Me.colCreatedBy.Visible = False
        '
        'colTicketStatus
        '
        Me.colTicketStatus.DataPropertyName = "TICKETSTATUS"
        Me.colTicketStatus.HeaderText = "Ticket Status"
        Me.colTicketStatus.Name = "colTicketStatus"
        Me.colTicketStatus.ReadOnly = True
        Me.colTicketStatus.Width = 55
        '
        'colInvoiceStatus
        '
        Me.colInvoiceStatus.DataPropertyName = "INVOICESTATUS"
        Me.colInvoiceStatus.HeaderText = "Invoice Status"
        Me.colInvoiceStatus.Name = "colInvoiceStatus"
        Me.colInvoiceStatus.ReadOnly = True
        Me.colInvoiceStatus.Width = 95
        '
        'colInvoiceDate
        '
        Me.colInvoiceDate.DataPropertyName = "INVOICEDATE"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.colInvoiceDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.colInvoiceDate.HeaderText = "Invoice Date"
        Me.colInvoiceDate.Name = "colInvoiceDate"
        Me.colInvoiceDate.ReadOnly = True
        Me.colInvoiceDate.Width = 70
        '
        'colServiceLine
        '
        Me.colServiceLine.DataPropertyName = "SERVICELINE"
        Me.colServiceLine.HeaderText = "Service Line"
        Me.colServiceLine.Name = "colServiceLine"
        Me.colServiceLine.ReadOnly = True
        '
        'colCustomer
        '
        Me.colCustomer.DataPropertyName = "CUSTOMER"
        Me.colCustomer.HeaderText = "Customer"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.ReadOnly = True
        '
        'colContract
        '
        Me.colContract.DataPropertyName = "CONTRACTNUMBER"
        Me.colContract.HeaderText = "Contract"
        Me.colContract.Name = "colContract"
        Me.colContract.ReadOnly = True
        Me.colContract.Visible = False
        '
        'colSite
        '
        Me.colSite.DataPropertyName = "SITE"
        Me.colSite.HeaderText = "Site"
        Me.colSite.Name = "colSite"
        Me.colSite.ReadOnly = True
        Me.colSite.Width = 40
        '
        'colWell
        '
        Me.colWell.DataPropertyName = "WELLID"
        Me.colWell.HeaderText = "Well"
        Me.colWell.Name = "colWell"
        Me.colWell.ReadOnly = True
        Me.colWell.Width = 80
        '
        'colCurrency
        '
        Me.colCurrency.DataPropertyName = "CURRENCY"
        Me.colCurrency.HeaderText = "Curr"
        Me.colCurrency.Name = "colCurrency"
        Me.colCurrency.ReadOnly = True
        Me.colCurrency.Width = 34
        '
        'colSubTotal
        '
        Me.colSubTotal.DataPropertyName = "SUBTOTAL"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.colSubTotal.DefaultCellStyle = DataGridViewCellStyle4
        Me.colSubTotal.HeaderText = "SubTotal"
        Me.colSubTotal.Name = "colSubTotal"
        Me.colSubTotal.ReadOnly = True
        Me.colSubTotal.Width = 75
        '
        'colDiscount
        '
        Me.colDiscount.DataPropertyName = "DISCOUNT"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "n2"
        Me.colDiscount.DefaultCellStyle = DataGridViewCellStyle5
        Me.colDiscount.HeaderText = "Discount"
        Me.colDiscount.Name = "colDiscount"
        Me.colDiscount.ReadOnly = True
        Me.colDiscount.Width = 74
        '
        'colTicketTotal
        '
        Me.colTicketTotal.DataPropertyName = "TICKETTOTAL"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "n2"
        Me.colTicketTotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.colTicketTotal.HeaderText = "Ticket Total"
        Me.colTicketTotal.Name = "colTicketTotal"
        Me.colTicketTotal.ReadOnly = True
        Me.colTicketTotal.Width = 75
        '
        'colInvoiceTotal
        '
        Me.colInvoiceTotal.DataPropertyName = "INVOICETOTAL"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "n2"
        Me.colInvoiceTotal.DefaultCellStyle = DataGridViewCellStyle7
        Me.colInvoiceTotal.HeaderText = "Invoiced Total"
        Me.colInvoiceTotal.Name = "colInvoiceTotal"
        Me.colInvoiceTotal.ReadOnly = True
        Me.colInvoiceTotal.Width = 90
        '
        'colDif
        '
        Me.colDif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDif.DataPropertyName = "DIF"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "n2"
        Me.colDif.DefaultCellStyle = DataGridViewCellStyle8
        Me.colDif.HeaderText = "Dif"
        Me.colDif.Name = "colDif"
        Me.colDif.ReadOnly = True
        Me.colDif.Width = 45
        '
        'colTicketInvoiceId
        '
        Me.colTicketInvoiceId.DataPropertyName = "TICKETINVOICEID"
        Me.colTicketInvoiceId.HeaderText = "TICKETINVOICEID"
        Me.colTicketInvoiceId.Name = "colTicketInvoiceId"
        Me.colTicketInvoiceId.ReadOnly = True
        Me.colTicketInvoiceId.Visible = False
        '
        'colInvoiceDetail
        '
        Me.colInvoiceDetail.DataPropertyName = "INVOICEDETAIL"
        Me.colInvoiceDetail.HeaderText = "INVOICEDETAIL"
        Me.colInvoiceDetail.Name = "colInvoiceDetail"
        Me.colInvoiceDetail.ReadOnly = True
        Me.colInvoiceDetail.Visible = False
        '
        'colServiceTypeGrpCode
        '
        Me.colServiceTypeGrpCode.DataPropertyName = "SERVICETYPEGRPCODE"
        Me.colServiceTypeGrpCode.HeaderText = "SERVICETYPEGRPCODE"
        Me.colServiceTypeGrpCode.Name = "colServiceTypeGrpCode"
        Me.colServiceTypeGrpCode.ReadOnly = True
        Me.colServiceTypeGrpCode.Visible = False
        '
        'colServiceType
        '
        Me.colServiceType.DataPropertyName = "SERVICETYPE"
        Me.colServiceType.HeaderText = "SERVICETYPE"
        Me.colServiceType.Name = "colServiceType"
        Me.colServiceType.ReadOnly = True
        Me.colServiceType.Visible = False
        '
        'colDM
        '
        Me.colDM.DataPropertyName = "DM"
        Me.colDM.HeaderText = "DM"
        Me.colDM.Name = "colDM"
        Me.colDM.ReadOnly = True
        Me.colDM.Visible = False
        '
        'colJobNumber
        '
        Me.colJobNumber.DataPropertyName = "JOBNUMBER"
        Me.colJobNumber.HeaderText = "JOBNUMBER"
        Me.colJobNumber.Name = "colJobNumber"
        Me.colJobNumber.ReadOnly = True
        Me.colJobNumber.Visible = False
        '
        'colServiceOrderNum
        '
        Me.colServiceOrderNum.DataPropertyName = "SERVICEORDERNUM"
        Me.colServiceOrderNum.HeaderText = "SERVICEORDERNUM"
        Me.colServiceOrderNum.Name = "colServiceOrderNum"
        Me.colServiceOrderNum.ReadOnly = True
        Me.colServiceOrderNum.Visible = False
        '
        'colSuperiorSupervName
        '
        Me.colSuperiorSupervName.DataPropertyName = "SUPERIORSUPERVNAME"
        Me.colSuperiorSupervName.HeaderText = "SUPERIORSUPERVNAME"
        Me.colSuperiorSupervName.Name = "colSuperiorSupervName"
        Me.colSuperiorSupervName.ReadOnly = True
        Me.colSuperiorSupervName.Visible = False
        '
        'frmInvoiceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1195, 626)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvInvoice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvoiceList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTicket - Invoice Control"
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmnuGridPrincip.ResumeLayout(False)
        CType(Me.SpTicketInvoiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CbxCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbxSiteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbxServiceLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbxTicketStatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpServiceDateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpServiceDateBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxTicketStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cbxServiceLine As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxSite As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkCompleted As System.Windows.Forms.CheckBox
    Friend WithEvents chkParcially As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoInvoice As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtDif As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtInvoicedTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTicketTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SESTicketAccessDataSet As SESTicket.SESTicketAccessDataSet
    Friend WithEvents btnSearch As Button
    Friend WithEvents cbxTicket As ComboBox
    Friend WithEvents txtTicketId As TextBox
    Friend WithEvents cbxDate As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbxCustomer As ComboBox
    Friend WithEvents SpTicketInvoiceBindingSource As BindingSource
    Friend WithEvents Sp_TicketInvoiceTableAdapter As SESTicketSQLDataSetTableAdapters.sp_TicketInvoiceTableAdapter
    Friend WithEvents CbxServiceLineBindingSource As BindingSource
    Friend WithEvents CbxServiceLineTableAdapter As SESTicketSQLDataSetTableAdapters.cbxServiceLineTableAdapter
    Friend WithEvents CbxSiteBindingSource As BindingSource
    Friend WithEvents CbxSiteTableAdapter As SESTicketAccessDataSetTableAdapters.cbxSiteTableAdapter
    Friend WithEvents CbxTicketStatusBindingSource As BindingSource
    Friend WithEvents CbxTicketStatusTableAdapter As SESTicketSQLDataSetTableAdapters.cbxTicketStatusTableAdapter
    Friend WithEvents CbxCustomerBindingSource As BindingSource
    Friend WithEvents CbxCustomerTableAdapter As SESTicketAccessDataSetTableAdapters.cbxCustomerTableAdapter
    Friend WithEvents cmnuGridPrincip As ContextMenuStrip
    Friend WithEvents cmnuImportTicket As ToolStripMenuItem
    Friend WithEvents cmnuReOpenTicket As ToolStripMenuItem
    Friend WithEvents cmnuSep00 As ToolStripSeparator
    Friend WithEvents cmnuCancelTicket As ToolStripMenuItem
    Friend WithEvents mnuExportExcel As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents cmnuSep02 As ToolStripSeparator
    Friend WithEvents lblTicketID As Label
    Friend WithEvents cmnuChangeTicketClosedDate As ToolStripMenuItem
    Friend WithEvents cmnuSep01 As ToolStripSeparator
    Friend WithEvents colTicketId As DataGridViewTextBoxColumn
    Friend WithEvents colServiceDate As DataGridViewTextBoxColumn
    Friend WithEvents colClosedDate As DataGridViewTextBoxColumn
    Friend WithEvents colSuperiorNum As DataGridViewTextBoxColumn
    Friend WithEvents colLineType As DataGridViewTextBoxColumn
    Friend WithEvents colCreatedBy As DataGridViewTextBoxColumn
    Friend WithEvents colTicketStatus As DataGridViewTextBoxColumn
    Friend WithEvents colInvoiceStatus As DataGridViewTextBoxColumn
    Friend WithEvents colInvoiceDate As DataGridViewTextBoxColumn
    Friend WithEvents colServiceLine As DataGridViewTextBoxColumn
    Friend WithEvents colCustomer As DataGridViewTextBoxColumn
    Friend WithEvents colContract As DataGridViewTextBoxColumn
    Friend WithEvents colSite As DataGridViewTextBoxColumn
    Friend WithEvents colWell As DataGridViewTextBoxColumn
    Friend WithEvents colCurrency As DataGridViewTextBoxColumn
    Friend WithEvents colSubTotal As DataGridViewTextBoxColumn
    Friend WithEvents colDiscount As DataGridViewTextBoxColumn
    Friend WithEvents colTicketTotal As DataGridViewTextBoxColumn
    Friend WithEvents colInvoiceTotal As DataGridViewTextBoxColumn
    Friend WithEvents colDif As DataGridViewTextBoxColumn
    Friend WithEvents colTicketInvoiceId As DataGridViewTextBoxColumn
    Friend WithEvents colInvoiceDetail As DataGridViewTextBoxColumn
    Friend WithEvents colServiceTypeGrpCode As DataGridViewTextBoxColumn
    Friend WithEvents colServiceType As DataGridViewTextBoxColumn
    Friend WithEvents colDM As DataGridViewTextBoxColumn
    Friend WithEvents colJobNumber As DataGridViewTextBoxColumn
    Friend WithEvents colServiceOrderNum As DataGridViewTextBoxColumn
    Friend WithEvents colSuperiorSupervName As DataGridViewTextBoxColumn
End Class
