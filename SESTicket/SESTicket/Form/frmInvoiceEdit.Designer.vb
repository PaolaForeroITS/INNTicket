<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoiceEdit))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTicket = New System.Windows.Forms.Panel()
        Me.txtJobDescription = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCreatedBy = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtServiceType = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSite = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLineType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWell = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContract = New System.Windows.Forms.TextBox()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.txtServiceLine = New System.Windows.Forms.TextBox()
        Me.lblServiceLine = New System.Windows.Forms.Label()
        Me.lblContract = New System.Windows.Forms.Label()
        Me.txtTicketNumber = New System.Windows.Forms.TextBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblTicketNumber = New System.Windows.Forms.Label()
        Me.txtCurrency = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxInvoiceStatus = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.dgvTicketInvLine = New System.Windows.Forms.DataGridView()
        Me.colInvoiceNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvoiceDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAxGpNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvoiceAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketInvLineId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketInvoiceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TICKETINVOICELINEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtUnitSale = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.dgvSalesItem = New System.Windows.Forms.DataGridView()
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTabGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSICustCodeItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSIDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSIUnitSale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSIItemQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPriceUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSISubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSIItemDisc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSITotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SALESITEM_VBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDif = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtInvoicedTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTicketTotal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TICKETINVOICELINETableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.TICKETINVOICELINETableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager()
        Me.SALESITEM_VTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.SALESITEM_VTableAdapter()
        Me.pnlTicket.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvTicketInvLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETINVOICELINEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvSalesItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALESITEM_VBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTicket
        '
        Me.pnlTicket.BackColor = System.Drawing.Color.White
        Me.pnlTicket.Controls.Add(Me.txtJobDescription)
        Me.pnlTicket.Controls.Add(Me.Label13)
        Me.pnlTicket.Controls.Add(Me.txtCreatedBy)
        Me.pnlTicket.Controls.Add(Me.Label7)
        Me.pnlTicket.Controls.Add(Me.txtServiceType)
        Me.pnlTicket.Controls.Add(Me.Label6)
        Me.pnlTicket.Controls.Add(Me.txtSite)
        Me.pnlTicket.Controls.Add(Me.Label5)
        Me.pnlTicket.Controls.Add(Me.txtLineType)
        Me.pnlTicket.Controls.Add(Me.Label1)
        Me.pnlTicket.Controls.Add(Me.txtWell)
        Me.pnlTicket.Controls.Add(Me.Label4)
        Me.pnlTicket.Controls.Add(Me.txtContract)
        Me.pnlTicket.Controls.Add(Me.txtCustomer)
        Me.pnlTicket.Controls.Add(Me.txtServiceLine)
        Me.pnlTicket.Controls.Add(Me.lblServiceLine)
        Me.pnlTicket.Controls.Add(Me.lblContract)
        Me.pnlTicket.Controls.Add(Me.txtTicketNumber)
        Me.pnlTicket.Controls.Add(Me.lblCustomer)
        Me.pnlTicket.Controls.Add(Me.lblTicketNumber)
        resources.ApplyResources(Me.pnlTicket, "pnlTicket")
        Me.pnlTicket.Name = "pnlTicket"
        '
        'txtJobDescription
        '
        Me.txtJobDescription.BackColor = System.Drawing.Color.White
        Me.txtJobDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtJobDescription, "txtJobDescription")
        Me.txtJobDescription.Name = "txtJobDescription"
        Me.txtJobDescription.ReadOnly = True
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'txtCreatedBy
        '
        Me.txtCreatedBy.BackColor = System.Drawing.Color.White
        Me.txtCreatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtCreatedBy, "txtCreatedBy")
        Me.txtCreatedBy.Name = "txtCreatedBy"
        Me.txtCreatedBy.ReadOnly = True
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'txtServiceType
        '
        Me.txtServiceType.BackColor = System.Drawing.Color.White
        Me.txtServiceType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtServiceType, "txtServiceType")
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'txtSite
        '
        Me.txtSite.BackColor = System.Drawing.Color.White
        Me.txtSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtSite, "txtSite")
        Me.txtSite.Name = "txtSite"
        Me.txtSite.ReadOnly = True
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'txtLineType
        '
        Me.txtLineType.BackColor = System.Drawing.Color.White
        Me.txtLineType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtLineType, "txtLineType")
        Me.txtLineType.Name = "txtLineType"
        Me.txtLineType.ReadOnly = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'txtWell
        '
        Me.txtWell.BackColor = System.Drawing.Color.White
        Me.txtWell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtWell, "txtWell")
        Me.txtWell.Name = "txtWell"
        Me.txtWell.ReadOnly = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'txtContract
        '
        Me.txtContract.BackColor = System.Drawing.Color.White
        Me.txtContract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtContract, "txtContract")
        Me.txtContract.Name = "txtContract"
        Me.txtContract.ReadOnly = True
        '
        'txtCustomer
        '
        Me.txtCustomer.BackColor = System.Drawing.Color.White
        Me.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtCustomer, "txtCustomer")
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        '
        'txtServiceLine
        '
        Me.txtServiceLine.BackColor = System.Drawing.Color.White
        Me.txtServiceLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtServiceLine, "txtServiceLine")
        Me.txtServiceLine.Name = "txtServiceLine"
        Me.txtServiceLine.ReadOnly = True
        '
        'lblServiceLine
        '
        resources.ApplyResources(Me.lblServiceLine, "lblServiceLine")
        Me.lblServiceLine.Name = "lblServiceLine"
        '
        'lblContract
        '
        resources.ApplyResources(Me.lblContract, "lblContract")
        Me.lblContract.Name = "lblContract"
        '
        'txtTicketNumber
        '
        Me.txtTicketNumber.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTicketNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtTicketNumber, "txtTicketNumber")
        Me.txtTicketNumber.Name = "txtTicketNumber"
        '
        'lblCustomer
        '
        resources.ApplyResources(Me.lblCustomer, "lblCustomer")
        Me.lblCustomer.Name = "lblCustomer"
        '
        'lblTicketNumber
        '
        resources.ApplyResources(Me.lblTicketNumber, "lblTicketNumber")
        Me.lblTicketNumber.Name = "lblTicketNumber"
        '
        'txtCurrency
        '
        Me.txtCurrency.BackColor = System.Drawing.Color.White
        Me.txtCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtCurrency, "txtCurrency")
        Me.txtCurrency.Name = "txtCurrency"
        Me.txtCurrency.ReadOnly = True
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'cbxInvoiceStatus
        '
        Me.cbxInvoiceStatus.FormattingEnabled = True
        Me.cbxInvoiceStatus.Items.AddRange(New Object() {resources.GetString("cbxInvoiceStatus.Items"), resources.GetString("cbxInvoiceStatus.Items1")})
        resources.ApplyResources(Me.cbxInvoiceStatus, "cbxInvoiceStatus")
        Me.cbxInvoiceStatus.Name = "cbxInvoiceStatus"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Name = "Label12"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPage1
        '
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Controls.Add(Me.btnDelete)
        Me.TabPage1.Controls.Add(Me.btnNew)
        Me.TabPage1.Controls.Add(Me.dgvTicketInvLine)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        resources.ApplyResources(Me.btnNew, "btnNew")
        Me.btnNew.ForeColor = System.Drawing.Color.Navy
        Me.btnNew.Name = "btnNew"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'dgvTicketInvLine
        '
        Me.dgvTicketInvLine.AllowUserToAddRows = False
        Me.dgvTicketInvLine.AllowUserToDeleteRows = False
        Me.dgvTicketInvLine.AutoGenerateColumns = False
        Me.dgvTicketInvLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTicketInvLine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colInvoiceNumber, Me.colInvoiceDate, Me.colAxGpNumber, Me.colInvoiceAmount, Me.colComment, Me.colActive, Me.colTicketInvLineId, Me.colTicketInvoiceID, Me.colTicketId})
        Me.dgvTicketInvLine.DataSource = Me.TICKETINVOICELINEBindingSource
        resources.ApplyResources(Me.dgvTicketInvLine, "dgvTicketInvLine")
        Me.dgvTicketInvLine.Name = "dgvTicketInvLine"
        Me.dgvTicketInvLine.ShowRowErrors = False
        '
        'colInvoiceNumber
        '
        Me.colInvoiceNumber.DataPropertyName = "INVOICENUMBER"
        resources.ApplyResources(Me.colInvoiceNumber, "colInvoiceNumber")
        Me.colInvoiceNumber.Name = "colInvoiceNumber"
        '
        'colInvoiceDate
        '
        Me.colInvoiceDate.DataPropertyName = "INVOICEDATE"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = "now"
        Me.colInvoiceDate.DefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.colInvoiceDate, "colInvoiceDate")
        Me.colInvoiceDate.Name = "colInvoiceDate"
        '
        'colAxGpNumber
        '
        Me.colAxGpNumber.DataPropertyName = "AX_GP_NUMBER"
        resources.ApplyResources(Me.colAxGpNumber, "colAxGpNumber")
        Me.colAxGpNumber.Name = "colAxGpNumber"
        '
        'colInvoiceAmount
        '
        Me.colInvoiceAmount.DataPropertyName = "INVOICEAMOUNT"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.colInvoiceAmount.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.colInvoiceAmount, "colInvoiceAmount")
        Me.colInvoiceAmount.Name = "colInvoiceAmount"
        '
        'colComment
        '
        Me.colComment.DataPropertyName = "COMMENT"
        resources.ApplyResources(Me.colComment, "colComment")
        Me.colComment.Name = "colComment"
        '
        'colActive
        '
        Me.colActive.DataPropertyName = "ACTIVE"
        resources.ApplyResources(Me.colActive, "colActive")
        Me.colActive.Name = "colActive"
        '
        'colTicketInvLineId
        '
        Me.colTicketInvLineId.DataPropertyName = "TICKETINVOICELINEID"
        resources.ApplyResources(Me.colTicketInvLineId, "colTicketInvLineId")
        Me.colTicketInvLineId.Name = "colTicketInvLineId"
        Me.colTicketInvLineId.ReadOnly = True
        '
        'colTicketInvoiceID
        '
        Me.colTicketInvoiceID.DataPropertyName = "TICKETINVOICEID"
        resources.ApplyResources(Me.colTicketInvoiceID, "colTicketInvoiceID")
        Me.colTicketInvoiceID.Name = "colTicketInvoiceID"
        '
        'colTicketId
        '
        Me.colTicketId.DataPropertyName = "TICKETID"
        resources.ApplyResources(Me.colTicketId, "colTicketId")
        Me.colTicketId.Name = "colTicketId"
        '
        'TICKETINVOICELINEBindingSource
        '
        Me.TICKETINVOICELINEBindingSource.DataMember = "TICKETINVOICELINE"
        Me.TICKETINVOICELINEBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Controls.Add(Me.txtUnitSale)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtDescription)
        Me.TabPage2.Controls.Add(Me.dgvSalesItem)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtUnitSale
        '
        Me.txtUnitSale.BackColor = System.Drawing.Color.White
        Me.txtUnitSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtUnitSale, "txtUnitSale")
        Me.txtUnitSale.Name = "txtUnitSale"
        Me.txtUnitSale.ReadOnly = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtDescription, "txtDescription")
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        '
        'dgvSalesItem
        '
        Me.dgvSalesItem.AllowUserToAddRows = False
        Me.dgvSalesItem.AllowUserToDeleteRows = False
        Me.dgvSalesItem.AutoGenerateColumns = False
        Me.dgvSalesItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colType, Me.colTabGroup, Me.colSICustCodeItem, Me.colSIDescription, Me.colSIUnitSale, Me.colSIItemQty, Me.colPriceUnit, Me.colSISubtotal, Me.colSIItemDisc, Me.colSITotal})
        Me.dgvSalesItem.DataSource = Me.SALESITEM_VBindingSource
        resources.ApplyResources(Me.dgvSalesItem, "dgvSalesItem")
        Me.dgvSalesItem.Name = "dgvSalesItem"
        Me.dgvSalesItem.ReadOnly = True
        Me.dgvSalesItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'colType
        '
        Me.colType.DataPropertyName = "TYPE"
        resources.ApplyResources(Me.colType, "colType")
        Me.colType.Name = "colType"
        Me.colType.ReadOnly = True
        '
        'colTabGroup
        '
        Me.colTabGroup.DataPropertyName = "TABGROUP"
        resources.ApplyResources(Me.colTabGroup, "colTabGroup")
        Me.colTabGroup.Name = "colTabGroup"
        Me.colTabGroup.ReadOnly = True
        '
        'colSICustCodeItem
        '
        Me.colSICustCodeItem.DataPropertyName = "CUSTCODEITEM"
        resources.ApplyResources(Me.colSICustCodeItem, "colSICustCodeItem")
        Me.colSICustCodeItem.Name = "colSICustCodeItem"
        Me.colSICustCodeItem.ReadOnly = True
        '
        'colSIDescription
        '
        Me.colSIDescription.DataPropertyName = "DESCRIPTION"
        resources.ApplyResources(Me.colSIDescription, "colSIDescription")
        Me.colSIDescription.Name = "colSIDescription"
        Me.colSIDescription.ReadOnly = True
        '
        'colSIUnitSale
        '
        Me.colSIUnitSale.DataPropertyName = "UNIT_SALE"
        resources.ApplyResources(Me.colSIUnitSale, "colSIUnitSale")
        Me.colSIUnitSale.Name = "colSIUnitSale"
        Me.colSIUnitSale.ReadOnly = True
        '
        'colSIItemQty
        '
        Me.colSIItemQty.DataPropertyName = "ITEMQTY"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "n2"
        Me.colSIItemQty.DefaultCellStyle = DataGridViewCellStyle3
        resources.ApplyResources(Me.colSIItemQty, "colSIItemQty")
        Me.colSIItemQty.Name = "colSIItemQty"
        Me.colSIItemQty.ReadOnly = True
        '
        'colPriceUnit
        '
        Me.colPriceUnit.DataPropertyName = "PRICEUNIT"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "n2"
        Me.colPriceUnit.DefaultCellStyle = DataGridViewCellStyle4
        resources.ApplyResources(Me.colPriceUnit, "colPriceUnit")
        Me.colPriceUnit.Name = "colPriceUnit"
        Me.colPriceUnit.ReadOnly = True
        '
        'colSISubtotal
        '
        Me.colSISubtotal.DataPropertyName = "SUBTOTAL"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "n2"
        Me.colSISubtotal.DefaultCellStyle = DataGridViewCellStyle5
        resources.ApplyResources(Me.colSISubtotal, "colSISubtotal")
        Me.colSISubtotal.Name = "colSISubtotal"
        Me.colSISubtotal.ReadOnly = True
        '
        'colSIItemDisc
        '
        Me.colSIItemDisc.DataPropertyName = "ITEMDISC"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "n2"
        Me.colSIItemDisc.DefaultCellStyle = DataGridViewCellStyle6
        resources.ApplyResources(Me.colSIItemDisc, "colSIItemDisc")
        Me.colSIItemDisc.Name = "colSIItemDisc"
        Me.colSIItemDisc.ReadOnly = True
        '
        'colSITotal
        '
        Me.colSITotal.DataPropertyName = "TOTAL"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "n2"
        Me.colSITotal.DefaultCellStyle = DataGridViewCellStyle7
        resources.ApplyResources(Me.colSITotal, "colSITotal")
        Me.colSITotal.Name = "colSITotal"
        Me.colSITotal.ReadOnly = True
        '
        'SALESITEM_VBindingSource
        '
        Me.SALESITEM_VBindingSource.DataMember = "SALESITEM_V"
        Me.SALESITEM_VBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtDif)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtCurrency)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtInvoicedTotal)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtTicketTotal)
        Me.Panel1.Controls.Add(Me.Label11)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'txtDif
        '
        Me.txtDif.BackColor = System.Drawing.Color.White
        Me.txtDif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtDif, "txtDif")
        Me.txtDif.Name = "txtDif"
        Me.txtDif.ReadOnly = True
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'txtInvoicedTotal
        '
        Me.txtInvoicedTotal.BackColor = System.Drawing.Color.White
        Me.txtInvoicedTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtInvoicedTotal, "txtInvoicedTotal")
        Me.txtInvoicedTotal.Name = "txtInvoicedTotal"
        Me.txtInvoicedTotal.ReadOnly = True
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'txtTicketTotal
        '
        Me.txtTicketTotal.BackColor = System.Drawing.Color.White
        Me.txtTicketTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtTicketTotal, "txtTicketTotal")
        Me.txtTicketTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTicketTotal.Name = "txtTicketTotal"
        Me.txtTicketTotal.ReadOnly = True
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'TICKETINVOICELINETableAdapter
        '
        Me.TICKETINVOICELINETableAdapter.ClearBeforeFill = True
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
        'SALESITEM_VTableAdapter
        '
        Me.SALESITEM_VTableAdapter.ClearBeforeFill = True
        '
        'frmInvoiceEdit
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cbxInvoiceStatus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlTicket)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvoiceEdit"
        Me.pnlTicket.ResumeLayout(False)
        Me.pnlTicket.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvTicketInvLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETINVOICELINEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvSalesItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALESITEM_VBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlTicket As System.Windows.Forms.Panel
    Friend WithEvents txtServiceLine As System.Windows.Forms.TextBox
    Friend WithEvents lblServiceLine As System.Windows.Forms.Label
    Friend WithEvents lblContract As System.Windows.Forms.Label
    Friend WithEvents txtTicketNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblTicketNumber As System.Windows.Forms.Label
    Friend WithEvents txtContract As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtWell As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLineType As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxInvoiceStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtDif As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCurrency As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtInvoicedTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTicketTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents TICKETINVOICELINEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TICKETINVOICELINETableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.TICKETINVOICELINETableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvTicketInvLine As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SALESITEM_VBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SALESITEM_VTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.SALESITEM_VTableAdapter
    Friend WithEvents dgvSalesItem As System.Windows.Forms.DataGridView
    Friend WithEvents colType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTabGroup As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSICustCodeItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSIDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSIUnitSale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSIItemQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPriceUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSISubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSIItemDisc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSITotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitSale As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtServiceType As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSite As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtJobDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCreatedBy As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents colInvoiceNumber As DataGridViewTextBoxColumn
    Friend WithEvents colInvoiceDate As DataGridViewTextBoxColumn
    Friend WithEvents colAxGpNumber As DataGridViewTextBoxColumn
    Friend WithEvents colInvoiceAmount As DataGridViewTextBoxColumn
    Friend WithEvents colComment As DataGridViewTextBoxColumn
    Friend WithEvents colActive As DataGridViewTextBoxColumn
    Friend WithEvents colTicketInvLineId As DataGridViewTextBoxColumn
    Friend WithEvents colTicketInvoiceID As DataGridViewTextBoxColumn
    Friend WithEvents colTicketId As DataGridViewTextBoxColumn
End Class
