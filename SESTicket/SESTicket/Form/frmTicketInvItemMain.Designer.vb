<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTicketInvItemMain
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketInvItemMain))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkNoInvItem = New System.Windows.Forms.CheckBox()
        Me.cbxCategory = New System.Windows.Forms.ComboBox()
        Me.TICKETINVGROUPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvInvItemLine = New System.Windows.Forms.DataGridView()
        Me.colTicketInvLineId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketSalesItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLineType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLineTabGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustCodeItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLineQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TICKETINVLINEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvInvItemHead = New System.Windows.Forms.DataGridView()
        Me.colTicketInvHeadId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHeadInvClassId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHeadInvItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHeadAbbrev = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHeadDescrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHeadLote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHeadUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHeadDespatched = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHeadConsumption = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHeadReturned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHeadComments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TICKETINVHEADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TICKETINVGROUPTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TICKETINVGROUPTableAdapter()
        Me.TICKETINVHEADTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TICKETINVHEADTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInvCons = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TICKETINVLINETableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TICKETINVLINETableAdapter()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNewInvItem = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtEngResp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOperResp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtWarehouseResp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtDriver = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTranspCompany = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDateReturned = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpDateDispatched = New System.Windows.Forms.DateTimePicker()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TICKETINVGROUPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvInvItemLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETINVLINEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvInvItemHead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETINVHEADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkNoInvItem)
        Me.GroupBox3.Controls.Add(Me.cbxCategory)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(525, 63)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        '
        'chkNoInvItem
        '
        Me.chkNoInvItem.AutoSize = True
        Me.chkNoInvItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkNoInvItem.Location = New System.Drawing.Point(321, 25)
        Me.chkNoInvItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkNoInvItem.Name = "chkNoInvItem"
        Me.chkNoInvItem.Size = New System.Drawing.Size(166, 20)
        Me.chkNoInvItem.TabIndex = 2
        Me.chkNoInvItem.Text = "Ticket without Inventory"
        Me.chkNoInvItem.UseVisualStyleBackColor = True
        '
        'cbxCategory
        '
        Me.cbxCategory.DataSource = Me.TICKETINVGROUPBindingSource
        Me.cbxCategory.DisplayMember = "INVENTORYCLASSID"
        Me.cbxCategory.FormattingEnabled = True
        Me.cbxCategory.Location = New System.Drawing.Point(87, 21)
        Me.cbxCategory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxCategory.Name = "cbxCategory"
        Me.cbxCategory.Size = New System.Drawing.Size(204, 24)
        Me.cbxCategory.TabIndex = 1
        Me.cbxCategory.ValueMember = "INVENTORYCLASSID"
        '
        'TICKETINVGROUPBindingSource
        '
        Me.TICKETINVGROUPBindingSource.DataMember = "TICKETINVGROUP"
        Me.TICKETINVGROUPBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvInvItemLine)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 481)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(1113, 235)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sales Item - Consumption"
        '
        'dgvInvItemLine
        '
        Me.dgvInvItemLine.AllowUserToAddRows = False
        Me.dgvInvItemLine.AllowUserToDeleteRows = False
        Me.dgvInvItemLine.AllowUserToResizeColumns = False
        Me.dgvInvItemLine.AllowUserToResizeRows = False
        Me.dgvInvItemLine.AutoGenerateColumns = False
        Me.dgvInvItemLine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvInvItemLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvItemLine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTicketInvLineId, Me.colTicketSalesItemId, Me.colLineType, Me.colLineTabGroup, Me.colCustCodeItem, Me.colDescription, Me.colLineQty})
        Me.dgvInvItemLine.DataSource = Me.TICKETINVLINEBindingSource
        Me.dgvInvItemLine.Location = New System.Drawing.Point(8, 23)
        Me.dgvInvItemLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvInvItemLine.MultiSelect = False
        Me.dgvInvItemLine.Name = "dgvInvItemLine"
        Me.dgvInvItemLine.ReadOnly = True
        Me.dgvInvItemLine.RowHeadersVisible = False
        Me.dgvInvItemLine.RowHeadersWidth = 20
        Me.dgvInvItemLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvItemLine.Size = New System.Drawing.Size(1096, 204)
        Me.dgvInvItemLine.TabIndex = 5
        '
        'colTicketInvLineId
        '
        Me.colTicketInvLineId.DataPropertyName = "TICKETINVLINEID"
        Me.colTicketInvLineId.HeaderText = "TICKETINVLINEID"
        Me.colTicketInvLineId.MinimumWidth = 6
        Me.colTicketInvLineId.Name = "colTicketInvLineId"
        Me.colTicketInvLineId.ReadOnly = True
        Me.colTicketInvLineId.Visible = False
        Me.colTicketInvLineId.Width = 125
        '
        'colTicketSalesItemId
        '
        Me.colTicketSalesItemId.DataPropertyName = "TICKETSALESITEMID"
        Me.colTicketSalesItemId.HeaderText = "TICKETSALESITEMID"
        Me.colTicketSalesItemId.MinimumWidth = 6
        Me.colTicketSalesItemId.Name = "colTicketSalesItemId"
        Me.colTicketSalesItemId.ReadOnly = True
        Me.colTicketSalesItemId.Visible = False
        Me.colTicketSalesItemId.Width = 125
        '
        'colLineType
        '
        Me.colLineType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colLineType.DataPropertyName = "TYPE"
        Me.colLineType.HeaderText = "Type"
        Me.colLineType.MinimumWidth = 6
        Me.colLineType.Name = "colLineType"
        Me.colLineType.ReadOnly = True
        Me.colLineType.Width = 68
        '
        'colLineTabGroup
        '
        Me.colLineTabGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colLineTabGroup.DataPropertyName = "TABGROUP"
        Me.colLineTabGroup.HeaderText = "Group"
        Me.colLineTabGroup.MinimumWidth = 6
        Me.colLineTabGroup.Name = "colLineTabGroup"
        Me.colLineTabGroup.ReadOnly = True
        Me.colLineTabGroup.Width = 73
        '
        'colCustCodeItem
        '
        Me.colCustCodeItem.DataPropertyName = "CUSTCODEITEM"
        Me.colCustCodeItem.HeaderText = "Item"
        Me.colCustCodeItem.MinimumWidth = 6
        Me.colCustCodeItem.Name = "colCustCodeItem"
        Me.colCustCodeItem.ReadOnly = True
        Me.colCustCodeItem.Width = 125
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "DESCRIPTION"
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.MinimumWidth = 6
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 500
        '
        'colLineQty
        '
        Me.colLineQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colLineQty.DataPropertyName = "ITEMQTY"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "n2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.colLineQty.DefaultCellStyle = DataGridViewCellStyle1
        Me.colLineQty.HeaderText = "Qty"
        Me.colLineQty.MinimumWidth = 6
        Me.colLineQty.Name = "colLineQty"
        Me.colLineQty.ReadOnly = True
        Me.colLineQty.Width = 56
        '
        'TICKETINVLINEBindingSource
        '
        Me.TICKETINVLINEBindingSource.DataMember = "TICKETINVLINE"
        Me.TICKETINVLINEBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvInvItemHead)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1491, 322)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventory Item - Resume"
        '
        'dgvInvItemHead
        '
        Me.dgvInvItemHead.AllowUserToAddRows = False
        Me.dgvInvItemHead.AllowUserToDeleteRows = False
        Me.dgvInvItemHead.AllowUserToResizeColumns = False
        Me.dgvInvItemHead.AllowUserToResizeRows = False
        Me.dgvInvItemHead.AutoGenerateColumns = False
        Me.dgvInvItemHead.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.dgvInvItemHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvItemHead.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTicketInvHeadId, Me.colHeadInvClassId, Me.colHeadInvItemId, Me.colHeadAbbrev, Me.colHeadDescrip, Me.colHeadLote, Me.colHeadUnit, Me.colHeadDespatched, Me.colHeadConsumption, Me.colHeadReturned, Me.colHeadComments})
        Me.dgvInvItemHead.DataSource = Me.TICKETINVHEADBindingSource
        Me.dgvInvItemHead.Location = New System.Drawing.Point(8, 23)
        Me.dgvInvItemHead.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvInvItemHead.MultiSelect = False
        Me.dgvInvItemHead.Name = "dgvInvItemHead"
        Me.dgvInvItemHead.ReadOnly = True
        Me.dgvInvItemHead.RowHeadersVisible = False
        Me.dgvInvItemHead.RowHeadersWidth = 20
        Me.dgvInvItemHead.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvItemHead.Size = New System.Drawing.Size(1475, 292)
        Me.dgvInvItemHead.TabIndex = 4
        '
        'colTicketInvHeadId
        '
        Me.colTicketInvHeadId.DataPropertyName = "TICKETINVHEADERID"
        Me.colTicketInvHeadId.HeaderText = "TICKETINVHEADERID"
        Me.colTicketInvHeadId.MinimumWidth = 6
        Me.colTicketInvHeadId.Name = "colTicketInvHeadId"
        Me.colTicketInvHeadId.ReadOnly = True
        Me.colTicketInvHeadId.Visible = False
        Me.colTicketInvHeadId.Width = 125
        '
        'colHeadInvClassId
        '
        Me.colHeadInvClassId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colHeadInvClassId.DataPropertyName = "INVENTORYCLASSID"
        Me.colHeadInvClassId.HeaderText = "Category"
        Me.colHeadInvClassId.MinimumWidth = 6
        Me.colHeadInvClassId.Name = "colHeadInvClassId"
        Me.colHeadInvClassId.ReadOnly = True
        Me.colHeadInvClassId.Width = 91
        '
        'colHeadInvItemId
        '
        Me.colHeadInvItemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colHeadInvItemId.DataPropertyName = "INVENTORYITEMID"
        Me.colHeadInvItemId.HeaderText = "Code"
        Me.colHeadInvItemId.MinimumWidth = 6
        Me.colHeadInvItemId.Name = "colHeadInvItemId"
        Me.colHeadInvItemId.ReadOnly = True
        Me.colHeadInvItemId.Width = 69
        '
        'colHeadAbbrev
        '
        Me.colHeadAbbrev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colHeadAbbrev.DataPropertyName = "ABBREVIATION"
        Me.colHeadAbbrev.HeaderText = "Abbreviation"
        Me.colHeadAbbrev.MinimumWidth = 6
        Me.colHeadAbbrev.Name = "colHeadAbbrev"
        Me.colHeadAbbrev.ReadOnly = True
        Me.colHeadAbbrev.Width = 112
        '
        'colHeadDescrip
        '
        Me.colHeadDescrip.DataPropertyName = "DESCRIPTION"
        Me.colHeadDescrip.HeaderText = "Description"
        Me.colHeadDescrip.MinimumWidth = 6
        Me.colHeadDescrip.Name = "colHeadDescrip"
        Me.colHeadDescrip.ReadOnly = True
        Me.colHeadDescrip.Width = 370
        '
        'colHeadLote
        '
        Me.colHeadLote.DataPropertyName = "LOTE"
        Me.colHeadLote.HeaderText = "Lote"
        Me.colHeadLote.MinimumWidth = 6
        Me.colHeadLote.Name = "colHeadLote"
        Me.colHeadLote.ReadOnly = True
        Me.colHeadLote.Width = 53
        '
        'colHeadUnit
        '
        Me.colHeadUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colHeadUnit.DataPropertyName = "STORAGEUNIT"
        Me.colHeadUnit.HeaderText = "Unit"
        Me.colHeadUnit.MinimumWidth = 6
        Me.colHeadUnit.Name = "colHeadUnit"
        Me.colHeadUnit.ReadOnly = True
        Me.colHeadUnit.Width = 59
        '
        'colHeadDespatched
        '
        Me.colHeadDespatched.DataPropertyName = "DESPATCHED"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "n2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.colHeadDespatched.DefaultCellStyle = DataGridViewCellStyle2
        Me.colHeadDespatched.HeaderText = "Dispached"
        Me.colHeadDespatched.MinimumWidth = 6
        Me.colHeadDespatched.Name = "colHeadDespatched"
        Me.colHeadDespatched.ReadOnly = True
        Me.colHeadDespatched.Width = 70
        '
        'colHeadConsumption
        '
        Me.colHeadConsumption.DataPropertyName = "CONSUMPTION"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "n2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.colHeadConsumption.DefaultCellStyle = DataGridViewCellStyle3
        Me.colHeadConsumption.HeaderText = "Consumption"
        Me.colHeadConsumption.MinimumWidth = 6
        Me.colHeadConsumption.Name = "colHeadConsumption"
        Me.colHeadConsumption.ReadOnly = True
        Me.colHeadConsumption.Width = 70
        '
        'colHeadReturned
        '
        Me.colHeadReturned.DataPropertyName = "RETURNED"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "n2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.colHeadReturned.DefaultCellStyle = DataGridViewCellStyle4
        Me.colHeadReturned.HeaderText = "Returned"
        Me.colHeadReturned.MinimumWidth = 6
        Me.colHeadReturned.Name = "colHeadReturned"
        Me.colHeadReturned.ReadOnly = True
        Me.colHeadReturned.Width = 70
        '
        'colHeadComments
        '
        Me.colHeadComments.DataPropertyName = "COMMENTS"
        Me.colHeadComments.HeaderText = "Comments"
        Me.colHeadComments.MinimumWidth = 6
        Me.colHeadComments.Name = "colHeadComments"
        Me.colHeadComments.ReadOnly = True
        Me.colHeadComments.Width = 125
        '
        'TICKETINVHEADBindingSource
        '
        Me.TICKETINVHEADBindingSource.DataMember = "TICKETINVHEAD"
        Me.TICKETINVHEADBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'TICKETINVGROUPTableAdapter
        '
        Me.TICKETINVGROUPTableAdapter.ClearBeforeFill = True
        '
        'TICKETINVHEADTableAdapter
        '
        Me.TICKETINVHEADTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPrint, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1532, 52)
        Me.MenuStrip1.TabIndex = 31
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuPrint
        '
        Me.mnuPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInvCons})
        Me.mnuPrint.Image = CType(resources.GetObject("mnuPrint.Image"), System.Drawing.Image)
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(73, 48)
        Me.mnuPrint.Text = "Print"
        Me.mnuPrint.ToolTipText = "Print the Ticket"
        '
        'mnuInvCons
        '
        Me.mnuInvCons.Name = "mnuInvCons"
        Me.mnuInvCons.Size = New System.Drawing.Size(245, 26)
        Me.mnuInvCons.Text = "Inventory Consumption"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.AutoSize = False
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(53, 38)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'TICKETINVLINETableAdapter
        '
        Me.TICKETINVLINETableAdapter.ClearBeforeFill = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtDescrip)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtCode)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 410)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(1113, 64)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        '
        'txtDescrip
        '
        Me.txtDescrip.BackColor = System.Drawing.Color.White
        Me.txtDescrip.Location = New System.Drawing.Point(356, 21)
        Me.txtDescrip.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.ReadOnly = True
        Me.txtDescrip.Size = New System.Drawing.Size(719, 22)
        Me.txtDescrip.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description:"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.White
        Me.txtCode.Location = New System.Drawing.Point(68, 21)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(177, 22)
        Me.txtCode.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Code:"
        '
        'btnNewInvItem
        '
        Me.btnNewInvItem.Location = New System.Drawing.Point(556, 31)
        Me.btnNewInvItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNewInvItem.Name = "btnNewInvItem"
        Me.btnNewInvItem.Size = New System.Drawing.Size(165, 37)
        Me.btnNewInvItem.TabIndex = 33
        Me.btnNewInvItem.Text = "New Inventory Item"
        Me.btnNewInvItem.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.btnSave)
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(1517, 727)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Warehouse Data"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(729, 30)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(111, 32)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox7.Controls.Add(Me.txtComments)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 241)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox7.Size = New System.Drawing.Size(831, 204)
        Me.GroupBox7.TabIndex = 37
        Me.GroupBox7.TabStop = False
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(105, 16)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(709, 170)
        Me.txtComments.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 20)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 16)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Comments:"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox6.Controls.Add(Me.txtEngResp)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.txtOperResp)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.txtWarehouseResp)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 155)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(831, 79)
        Me.GroupBox6.TabIndex = 35
        Me.GroupBox6.TabStop = False
        '
        'txtEngResp
        '
        Me.txtEngResp.Location = New System.Drawing.Point(556, 39)
        Me.txtEngResp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEngResp.Name = "txtEngResp"
        Me.txtEngResp.Size = New System.Drawing.Size(257, 22)
        Me.txtEngResp.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(552, 20)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Engenner Responsible:"
        '
        'txtOperResp
        '
        Me.txtOperResp.Location = New System.Drawing.Point(289, 39)
        Me.txtOperResp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOperResp.Name = "txtOperResp"
        Me.txtOperResp.Size = New System.Drawing.Size(257, 22)
        Me.txtOperResp.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(285, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Operation Responsible:"
        '
        'txtWarehouseResp
        '
        Me.txtWarehouseResp.Location = New System.Drawing.Point(23, 39)
        Me.txtWarehouseResp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWarehouseResp.Name = "txtWarehouseResp"
        Me.txtWarehouseResp.Size = New System.Drawing.Size(257, 22)
        Me.txtWarehouseResp.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 20)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Warehouse Responsible:"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.txtDriver)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.txtTranspCompany)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.dtpDateReturned)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.dtpDateDispatched)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 69)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(831, 79)
        Me.GroupBox5.TabIndex = 34
        Me.GroupBox5.TabStop = False
        '
        'txtDriver
        '
        Me.txtDriver.Location = New System.Drawing.Point(556, 39)
        Me.txtDriver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDriver.Name = "txtDriver"
        Me.txtDriver.Size = New System.Drawing.Size(257, 22)
        Me.txtDriver.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(552, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Driver (Conductor):"
        '
        'txtTranspCompany
        '
        Me.txtTranspCompany.Location = New System.Drawing.Point(289, 39)
        Me.txtTranspCompany.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTranspCompany.Name = "txtTranspCompany"
        Me.txtTranspCompany.Size = New System.Drawing.Size(257, 22)
        Me.txtTranspCompany.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Transport Company:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(133, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Returned:"
        '
        'dtpDateReturned
        '
        Me.dtpDateReturned.CustomFormat = "dd/MM/yyyy HH:mm tt"
        Me.dtpDateReturned.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateReturned.Location = New System.Drawing.Point(137, 39)
        Me.dtpDateReturned.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpDateReturned.Name = "dtpDateReturned"
        Me.dtpDateReturned.Size = New System.Drawing.Size(105, 22)
        Me.dtpDateReturned.TabIndex = 7
        Me.dtpDateReturned.Value = New Date(2017, 3, 21, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Dispatched:"
        '
        'dtpDateDispatched
        '
        Me.dtpDateDispatched.CustomFormat = "dd/MM/yyyy HH:mm tt"
        Me.dtpDateDispatched.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateDispatched.Location = New System.Drawing.Point(23, 39)
        Me.dtpDateDispatched.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpDateDispatched.Name = "dtpDateDispatched"
        Me.dtpDateDispatched.Size = New System.Drawing.Size(105, 22)
        Me.dtpDateDispatched.TabIndex = 5
        Me.dtpDateDispatched.Value = New Date(2017, 3, 21, 0, 0, 0, 0)
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.btnNewInvItem)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(1517, 727)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Consumed"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 55)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1525, 756)
        Me.TabControl1.TabIndex = 34
        '
        'frmTicketInvItemMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1532, 815)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTicketInvItemMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INNTicket - Inventory Itens"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TICKETINVGROUPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvInvItemLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETINVLINEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvInvItemHead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETINVHEADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvInvItemHead As DataGridView
    Friend WithEvents SESTicketAccessDataSet As SESTicketAccessDataSet
    Friend WithEvents TICKETINVGROUPBindingSource As BindingSource
    Friend WithEvents TICKETINVGROUPTableAdapter As SESTicketAccessDataSetTableAdapters.TICKETINVGROUPTableAdapter
    Friend WithEvents TICKETINVHEADBindingSource As BindingSource
    Friend WithEvents TICKETINVHEADTableAdapter As SESTicketAccessDataSetTableAdapters.TICKETINVHEADTableAdapter
    Friend WithEvents cbxCategory As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkNoInvItem As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuPrint As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents colTicketInvHeadId As DataGridViewTextBoxColumn
    Friend WithEvents colHeadInvClassId As DataGridViewTextBoxColumn
    Friend WithEvents colHeadInvItemId As DataGridViewTextBoxColumn
    Friend WithEvents colHeadAbbrev As DataGridViewTextBoxColumn
    Friend WithEvents colHeadDescrip As DataGridViewTextBoxColumn
    Friend WithEvents colHeadLote As DataGridViewTextBoxColumn
    Friend WithEvents colHeadUnit As DataGridViewTextBoxColumn
    Friend WithEvents colHeadDespatched As DataGridViewTextBoxColumn
    Friend WithEvents colHeadConsumption As DataGridViewTextBoxColumn
    Friend WithEvents colHeadReturned As DataGridViewTextBoxColumn
    Friend WithEvents colHeadComments As DataGridViewTextBoxColumn
    Friend WithEvents dgvInvItemLine As DataGridView
    Friend WithEvents TICKETINVLINEBindingSource As BindingSource
    Friend WithEvents TICKETINVLINETableAdapter As SESTicketAccessDataSetTableAdapters.TICKETINVLINETableAdapter
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtDescrip As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNewInvItem As Button
    Friend WithEvents colTicketInvLineId As DataGridViewTextBoxColumn
    Friend WithEvents colTicketSalesItemId As DataGridViewTextBoxColumn
    Friend WithEvents colLineType As DataGridViewTextBoxColumn
    Friend WithEvents colLineTabGroup As DataGridViewTextBoxColumn
    Friend WithEvents colCustCodeItem As DataGridViewTextBoxColumn
    Friend WithEvents colDescription As DataGridViewTextBoxColumn
    Friend WithEvents colLineQty As DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtEngResp As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtOperResp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtWarehouseResp As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtDriver As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTranspCompany As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpDateReturned As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpDateDispatched As DateTimePicker
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txtComments As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents mnuInvCons As ToolStripMenuItem
End Class
