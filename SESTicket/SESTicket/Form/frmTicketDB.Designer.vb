<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketDB))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTicketID = New System.Windows.Forms.Label()
        Me.cbxTicket = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cbxCustomer = New System.Windows.Forms.ComboBox()
        Me.CbxCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
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
        Me.dtpServiceDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpServiceDateBegin = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.Sp_TicketDBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager()
        Me.dgvTicket = New System.Windows.Forms.DataGridView()
        Me.cmnuGridPrincip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuImportTicket = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuReOpenTicket = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuSep00 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuCloseTickets = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChangeSupSupervisor = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuSep01 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmnuCancelTicket = New System.Windows.Forms.ToolStripMenuItem()
        Me.CbxServiceLineTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.cbxServiceLineTableAdapter()
        Me.CbxCustomerTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.cbxCustomerTableAdapter()
        Me.CbxSiteTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.cbxSiteTableAdapter()
        Me.Sp_TicketDBTableAdapter1 = New SESTicket.SESTicketSQLDataSetTableAdapters.sp_TicketDBTableAdapter()
        Me.colAttach = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colTicketId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceTicket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSuperiorSupervisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSyncDateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHasAttach = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CbxCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbxSiteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CbxServiceLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_TicketDBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmnuGridPrincip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTicketID)
        Me.GroupBox1.Controls.Add(Me.cbxTicket)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.cbxCustomer)
        Me.GroupBox1.Controls.Add(Me.txtTicketId)
        Me.GroupBox1.Controls.Add(Me.chkCanceled)
        Me.GroupBox1.Controls.Add(Me.chkClosed)
        Me.GroupBox1.Controls.Add(Me.chkOpen)
        Me.GroupBox1.Controls.Add(Me.cbxSite)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbxServiceLine)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpServiceDateEnd)
        Me.GroupBox1.Controls.Add(Me.dtpServiceDateBegin)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1100, 67)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'lblTicketID
        '
        Me.lblTicketID.AutoSize = True
        Me.lblTicketID.Location = New System.Drawing.Point(498, 42)
        Me.lblTicketID.Name = "lblTicketID"
        Me.lblTicketID.Size = New System.Drawing.Size(51, 13)
        Me.lblTicketID.TabIndex = 59
        Me.lblTicketID.Text = "TicketID:"
        '
        'cbxTicket
        '
        Me.cbxTicket.FormattingEnabled = True
        Me.cbxTicket.Items.AddRange(New Object() {"Ticket ID", "Proforma Val."})
        Me.cbxTicket.Location = New System.Drawing.Point(501, 37)
        Me.cbxTicket.Name = "cbxTicket"
        Me.cbxTicket.Size = New System.Drawing.Size(94, 21)
        Me.cbxTicket.TabIndex = 42
        Me.cbxTicket.Text = "Ticket ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(498, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Customer:"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(977, 16)
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
        Me.cbxCustomer.Location = New System.Drawing.Point(601, 13)
        Me.cbxCustomer.Name = "cbxCustomer"
        Me.cbxCustomer.Size = New System.Drawing.Size(178, 21)
        Me.cbxCustomer.TabIndex = 56
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
        'txtTicketId
        '
        Me.txtTicketId.Location = New System.Drawing.Point(601, 38)
        Me.txtTicketId.Name = "txtTicketId"
        Me.txtTicketId.Size = New System.Drawing.Size(178, 20)
        Me.txtTicketId.TabIndex = 55
        '
        'chkCanceled
        '
        Me.chkCanceled.AutoSize = True
        Me.chkCanceled.Checked = True
        Me.chkCanceled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCanceled.Location = New System.Drawing.Point(880, 41)
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
        Me.chkClosed.Location = New System.Drawing.Point(880, 26)
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
        Me.chkOpen.Location = New System.Drawing.Point(880, 11)
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
        Me.cbxSite.Location = New System.Drawing.Point(328, 37)
        Me.cbxSite.Name = "cbxSite"
        Me.cbxSite.Size = New System.Drawing.Size(162, 21)
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
        Me.Label6.Location = New System.Drawing.Point(253, 37)
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
        Me.cbxServiceLine.Location = New System.Drawing.Point(328, 13)
        Me.cbxServiceLine.Name = "cbxServiceLine"
        Me.cbxServiceLine.Size = New System.Drawing.Size(162, 21)
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
        Me.Label5.Location = New System.Drawing.Point(253, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Service Line:"
        '
        'dtpServiceDateEnd
        '
        Me.dtpServiceDateEnd.CustomFormat = "dd/MM/yyyy"
        Me.dtpServiceDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpServiceDateEnd.Location = New System.Drawing.Point(139, 36)
        Me.dtpServiceDateEnd.Name = "dtpServiceDateEnd"
        Me.dtpServiceDateEnd.Size = New System.Drawing.Size(96, 20)
        Me.dtpServiceDateEnd.TabIndex = 40
        '
        'dtpServiceDateBegin
        '
        Me.dtpServiceDateBegin.CustomFormat = "dd/MM/yyyy"
        Me.dtpServiceDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpServiceDateBegin.Location = New System.Drawing.Point(139, 13)
        Me.dtpServiceDateBegin.Name = "dtpServiceDateBegin"
        Me.dtpServiceDateBegin.Size = New System.Drawing.Size(96, 20)
        Me.dtpServiceDateBegin.TabIndex = 39
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(801, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ticket Status:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(25, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Service Date (End):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(25, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Service Date (Begin):"
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_TicketDBBindingSource
        '
        Me.Sp_TicketDBBindingSource.DataMember = "sp_TicketDB"
        Me.Sp_TicketDBBindingSource.DataSource = Me.SESTicketSQLDataSet
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
        'dgvTicket
        '
        Me.dgvTicket.AllowUserToAddRows = False
        Me.dgvTicket.AllowUserToDeleteRows = False
        Me.dgvTicket.AllowUserToResizeColumns = False
        Me.dgvTicket.AllowUserToResizeRows = False
        Me.dgvTicket.AutoGenerateColumns = False
        Me.dgvTicket.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTicket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAttach, Me.colTicketId, Me.colServiceTicket, Me.colSuperiorSupervisor, Me.colCreatedBy, Me.colTicketStatus, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn19, Me.colItemAmount, Me.colSyncDateTime, Me.colHasAttach})
        Me.dgvTicket.ContextMenuStrip = Me.cmnuGridPrincip
        Me.dgvTicket.DataSource = Me.Sp_TicketDBBindingSource
        Me.dgvTicket.Location = New System.Drawing.Point(6, 85)
        Me.dgvTicket.Name = "dgvTicket"
        Me.dgvTicket.ReadOnly = True
        Me.dgvTicket.RowHeadersWidth = 15
        Me.dgvTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTicket.Size = New System.Drawing.Size(1181, 552)
        Me.dgvTicket.TabIndex = 43
        '
        'cmnuGridPrincip
        '
        Me.cmnuGridPrincip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuImportTicket, Me.cmnuReOpenTicket, Me.cmnuSep00, Me.mnuCloseTickets, Me.mnuChangeSupSupervisor, Me.cmnuSep01, Me.cmnuCancelTicket})
        Me.cmnuGridPrincip.Name = "cmnuGridPrincip"
        Me.cmnuGridPrincip.Size = New System.Drawing.Size(174, 126)
        '
        'cmnuImportTicket
        '
        Me.cmnuImportTicket.Image = CType(resources.GetObject("cmnuImportTicket.Image"), System.Drawing.Image)
        Me.cmnuImportTicket.Name = "cmnuImportTicket"
        Me.cmnuImportTicket.Size = New System.Drawing.Size(173, 22)
        Me.cmnuImportTicket.Text = "Import Ticket"
        '
        'cmnuReOpenTicket
        '
        Me.cmnuReOpenTicket.Image = CType(resources.GetObject("cmnuReOpenTicket.Image"), System.Drawing.Image)
        Me.cmnuReOpenTicket.Name = "cmnuReOpenTicket"
        Me.cmnuReOpenTicket.Size = New System.Drawing.Size(173, 22)
        Me.cmnuReOpenTicket.Text = "Re-Open Ticket"
        '
        'cmnuSep00
        '
        Me.cmnuSep00.Name = "cmnuSep00"
        Me.cmnuSep00.Size = New System.Drawing.Size(170, 6)
        '
        'mnuCloseTickets
        '
        Me.mnuCloseTickets.Image = CType(resources.GetObject("mnuCloseTickets.Image"), System.Drawing.Image)
        Me.mnuCloseTickets.Name = "mnuCloseTickets"
        Me.mnuCloseTickets.Size = New System.Drawing.Size(173, 22)
        Me.mnuCloseTickets.Text = "Close Ticket"
        '
        'mnuChangeSupSupervisor
        '
        Me.mnuChangeSupSupervisor.Image = CType(resources.GetObject("mnuChangeSupSupervisor.Image"), System.Drawing.Image)
        Me.mnuChangeSupSupervisor.Name = "mnuChangeSupSupervisor"
        Me.mnuChangeSupSupervisor.Size = New System.Drawing.Size(173, 22)
        Me.mnuChangeSupSupervisor.Text = "Change Supervisor"
        '
        'cmnuSep01
        '
        Me.cmnuSep01.Name = "cmnuSep01"
        Me.cmnuSep01.Size = New System.Drawing.Size(170, 6)
        '
        'cmnuCancelTicket
        '
        Me.cmnuCancelTicket.Image = CType(resources.GetObject("cmnuCancelTicket.Image"), System.Drawing.Image)
        Me.cmnuCancelTicket.Name = "cmnuCancelTicket"
        Me.cmnuCancelTicket.Size = New System.Drawing.Size(173, 22)
        Me.cmnuCancelTicket.Text = "Cancel Ticket"
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
        'Sp_TicketDBTableAdapter1
        '
        Me.Sp_TicketDBTableAdapter1.ClearBeforeFill = True
        '
        'colAttach
        '
        Me.colAttach.HeaderText = ""
        Me.colAttach.Name = "colAttach"
        Me.colAttach.ReadOnly = True
        Me.colAttach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colAttach.Width = 20
        '
        'colTicketId
        '
        Me.colTicketId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTicketId.DataPropertyName = "TICKETID"
        Me.colTicketId.HeaderText = "Ticket"
        Me.colTicketId.Name = "colTicketId"
        Me.colTicketId.ReadOnly = True
        Me.colTicketId.Width = 62
        '
        'colServiceTicket
        '
        Me.colServiceTicket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colServiceTicket.DataPropertyName = "PROFORMAVAL"
        Me.colServiceTicket.HeaderText = "Proforma Val Field Tickets"
        Me.colServiceTicket.Name = "colServiceTicket"
        Me.colServiceTicket.ReadOnly = True
        Me.colServiceTicket.Width = 110
        '
        'colSuperiorSupervisor
        '
        Me.colSuperiorSupervisor.DataPropertyName = "SUPERIORSUPERVNAME"
        Me.colSuperiorSupervisor.HeaderText = "Superior´s Supervisor"
        Me.colSuperiorSupervisor.Name = "colSuperiorSupervisor"
        Me.colSuperiorSupervisor.ReadOnly = True
        Me.colSuperiorSupervisor.Width = 120
        '
        'colCreatedBy
        '
        Me.colCreatedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCreatedBy.DataPropertyName = "FULLUSERNAME"
        Me.colCreatedBy.HeaderText = "Created by"
        Me.colCreatedBy.Name = "colCreatedBy"
        Me.colCreatedBy.ReadOnly = True
        Me.colCreatedBy.Width = 77
        '
        'colTicketStatus
        '
        Me.colTicketStatus.DataPropertyName = "TICKETSTATUS"
        Me.colTicketStatus.HeaderText = "Status"
        Me.colTicketStatus.Name = "colTicketStatus"
        Me.colTicketStatus.ReadOnly = True
        Me.colTicketStatus.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DATESERVICE"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Service Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 92
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SERVICELINE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Service Line"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 110
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CUSTOMERNAME"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Customer"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 190
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "SITE"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Site"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 45
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "WELLID"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Well"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "CURRENCY"
        Me.DataGridViewTextBoxColumn19.HeaderText = ""
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 19
        '
        'colItemAmount
        '
        Me.colItemAmount.DataPropertyName = "ITEMAMOUNT"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "n2"
        Me.colItemAmount.DefaultCellStyle = DataGridViewCellStyle2
        Me.colItemAmount.HeaderText = "Amount"
        Me.colItemAmount.Name = "colItemAmount"
        Me.colItemAmount.ReadOnly = True
        '
        'colSyncDateTime
        '
        Me.colSyncDateTime.DataPropertyName = "SYNCDATETIME"
        DataGridViewCellStyle3.Format = "G"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.colSyncDateTime.DefaultCellStyle = DataGridViewCellStyle3
        Me.colSyncDateTime.HeaderText = "Sync Date"
        Me.colSyncDateTime.Name = "colSyncDateTime"
        Me.colSyncDateTime.ReadOnly = True
        Me.colSyncDateTime.Width = 135
        '
        'colHasAttach
        '
        Me.colHasAttach.DataPropertyName = "HASATTACH"
        Me.colHasAttach.HeaderText = "HASATTACH"
        Me.colHasAttach.Name = "colHasAttach"
        Me.colHasAttach.ReadOnly = True
        Me.colHasAttach.Visible = False
        '
        'frmTicketDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1191, 649)
        Me.Controls.Add(Me.dgvTicket)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTicketDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTicket - Ticket Database"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CbxCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbxSiteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CbxServiceLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_TicketDBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTicket, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmnuGridPrincip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxTicket As ComboBox
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
    Friend WithEvents dtpServiceDateEnd As DateTimePicker
    Friend WithEvents dtpServiceDateBegin As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents SESTicketSQLDataSet As SESTicketSQLDataSet
    Friend WithEvents Sp_TicketDBBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As SESTicketSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvTicket As DataGridView
    Friend WithEvents SESTicketAccessDataSet As SESTicketAccessDataSet
    Friend WithEvents CbxServiceLineBindingSource As BindingSource
    Friend WithEvents CbxServiceLineTableAdapter As SESTicketAccessDataSetTableAdapters.cbxServiceLineTableAdapter
    Friend WithEvents CbxCustomerBindingSource As BindingSource
    Friend WithEvents CbxCustomerTableAdapter As SESTicketAccessDataSetTableAdapters.cbxCustomerTableAdapter
    Friend WithEvents CbxSiteBindingSource As BindingSource
    Friend WithEvents CbxSiteTableAdapter As SESTicketAccessDataSetTableAdapters.cbxSiteTableAdapter
    Friend WithEvents cmnuGridPrincip As ContextMenuStrip
    Friend WithEvents cmnuImportTicket As ToolStripMenuItem
    Friend WithEvents cmnuReOpenTicket As ToolStripMenuItem
    Friend WithEvents cmnuSep00 As ToolStripSeparator
    Friend WithEvents cmnuCancelTicket As ToolStripMenuItem
    Friend WithEvents lblTicketID As Label
    Friend WithEvents Sp_TicketDBTableAdapter1 As SESTicketSQLDataSetTableAdapters.sp_TicketDBTableAdapter
    Friend WithEvents mnuCloseTickets As ToolStripMenuItem
    Friend WithEvents cmnuSep01 As ToolStripSeparator
    Friend WithEvents mnuChangeSupSupervisor As ToolStripMenuItem
    Friend WithEvents colAttach As DataGridViewImageColumn
    Friend WithEvents colTicketId As DataGridViewTextBoxColumn
    Friend WithEvents colServiceTicket As DataGridViewTextBoxColumn
    Friend WithEvents colSuperiorSupervisor As DataGridViewTextBoxColumn
    Friend WithEvents colCreatedBy As DataGridViewTextBoxColumn
    Friend WithEvents colTicketStatus As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents colItemAmount As DataGridViewTextBoxColumn
    Friend WithEvents colSyncDateTime As DataGridViewTextBoxColumn
    Friend WithEvents colHasAttach As DataGridViewTextBoxColumn
End Class
