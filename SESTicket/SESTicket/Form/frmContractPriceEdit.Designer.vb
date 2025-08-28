<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContractPriceEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContractPriceEdit))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtGroupOrder = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbxActive = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbxShowCustCodeRpt = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtTabGroup = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxExibitonReport = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxHeaderGroup = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtContract = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCustomerItemCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CONTRACTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.cbxInventoryClass = New System.Windows.Forms.ComboBox()
        Me.INVENTORYCLASSPRICEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVENTORYCLASSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPriceUtility = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtPriceBase = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtInventoryClassType = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSalesPrice = New System.Windows.Forms.TextBox()
        Me.cmnuDecimal = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.IncreaseDecimalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecreaseDecimalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtContractedQuantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSalesUnit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.CONTRACTTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.CONTRACTTableAdapter()
        Me.INVENTORYCLASSTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.INVENTORYCLASSTableAdapter()
        Me.INVENTORYCLASS_PRICETableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.INVENTORYCLASS_PRICETableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbxPermNegative = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbxPermUpdPriceUnit = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cbxPermUpdDescrip = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CONTRACTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTORYCLASSPRICEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTORYCLASSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.cmnuDecimal.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGroupOrder)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cbxActive)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cbxShowCustCodeRpt)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtTabGroup)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbxExibitonReport)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cbxHeaderGroup)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtContract)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCustomer)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCustomerItemCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(751, 353)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Information"
        '
        'txtGroupOrder
        '
        Me.txtGroupOrder.Location = New System.Drawing.Point(427, 94)
        Me.txtGroupOrder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGroupOrder.Name = "txtGroupOrder"
        Me.txtGroupOrder.Size = New System.Drawing.Size(83, 22)
        Me.txtGroupOrder.TabIndex = 39
        Me.txtGroupOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(303, 97)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 16)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "Line Order (group):"
        '
        'cbxActive
        '
        Me.cbxActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbxActive.FormattingEnabled = True
        Me.cbxActive.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbxActive.Location = New System.Drawing.Point(647, 33)
        Me.cbxActive.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxActive.Name = "cbxActive"
        Me.cbxActive.Size = New System.Drawing.Size(93, 24)
        Me.cbxActive.TabIndex = 38
        Me.cbxActive.Text = "YES"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(585, 37)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 16)
        Me.Label14.TabIndex = 36
        Me.Label14.Text = "Active:"
        '
        'cbxShowCustCodeRpt
        '
        Me.cbxShowCustCodeRpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxShowCustCodeRpt.FormattingEnabled = True
        Me.cbxShowCustCodeRpt.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbxShowCustCodeRpt.Location = New System.Drawing.Point(647, 121)
        Me.cbxShowCustCodeRpt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxShowCustCodeRpt.Name = "cbxShowCustCodeRpt"
        Me.cbxShowCustCodeRpt.Size = New System.Drawing.Size(93, 25)
        Me.cbxShowCustCodeRpt.TabIndex = 37
        Me.cbxShowCustCodeRpt.Text = "YES"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(469, 124)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(157, 16)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Show CustCode (Report):"
        '
        'txtTabGroup
        '
        Me.txtTabGroup.Location = New System.Drawing.Point(156, 94)
        Me.txtTabGroup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTabGroup.MaxLength = 50
        Me.txtTabGroup.Name = "txtTabGroup"
        Me.txtTabGroup.Size = New System.Drawing.Size(137, 22)
        Me.txtTabGroup.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(69, 94)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 16)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Tab Group:"
        '
        'cbxExibitonReport
        '
        Me.cbxExibitonReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxExibitonReport.FormattingEnabled = True
        Me.cbxExibitonReport.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbxExibitonReport.Location = New System.Drawing.Point(647, 60)
        Me.cbxExibitonReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxExibitonReport.Name = "cbxExibitonReport"
        Me.cbxExibitonReport.Size = New System.Drawing.Size(93, 25)
        Me.cbxExibitonReport.TabIndex = 33
        Me.cbxExibitonReport.Text = "YES"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(496, 64)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 16)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Exibit Line on Report:"
        '
        'cbxHeaderGroup
        '
        Me.cbxHeaderGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxHeaderGroup.FormattingEnabled = True
        Me.cbxHeaderGroup.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbxHeaderGroup.Location = New System.Drawing.Point(647, 94)
        Me.cbxHeaderGroup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxHeaderGroup.Name = "cbxHeaderGroup"
        Me.cbxHeaderGroup.Size = New System.Drawing.Size(93, 25)
        Me.cbxHeaderGroup.TabIndex = 28
        Me.cbxHeaderGroup.Text = "NO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(564, 97)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 16)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Is Header:"
        '
        'txtContract
        '
        Me.txtContract.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContract.Location = New System.Drawing.Point(156, 62)
        Me.txtContract.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContract.Name = "txtContract"
        Me.txtContract.ReadOnly = True
        Me.txtContract.Size = New System.Drawing.Size(318, 22)
        Me.txtContract.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(87, 62)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Contract:"
        '
        'txtCustomer
        '
        Me.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomer.Location = New System.Drawing.Point(156, 33)
        Me.txtCustomer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(318, 22)
        Me.txtCustomer.TabIndex = 24
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(157, 154)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescription.MaxLength = 5000
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(584, 185)
        Me.txtDescription.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 158)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(83, 33)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Customer:"
        '
        'txtCustomerItemCode
        '
        Me.txtCustomerItemCode.Location = New System.Drawing.Point(156, 121)
        Me.txtCustomerItemCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustomerItemCode.MaxLength = 30
        Me.txtCustomerItemCode.Name = "txtCustomerItemCode"
        Me.txtCustomerItemCode.Size = New System.Drawing.Size(137, 22)
        Me.txtCustomerItemCode.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer Item Code:"
        '
        'CONTRACTBindingSource
        '
        Me.CONTRACTBindingSource.DataMember = "CONTRACT"
        Me.CONTRACTBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbxInventoryClass
        '
        Me.cbxInventoryClass.DataSource = Me.INVENTORYCLASSPRICEBindingSource
        Me.cbxInventoryClass.DisplayMember = "DESCRIPTION"
        Me.cbxInventoryClass.FormattingEnabled = True
        Me.cbxInventoryClass.Location = New System.Drawing.Point(156, 21)
        Me.cbxInventoryClass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxInventoryClass.Name = "cbxInventoryClass"
        Me.cbxInventoryClass.Size = New System.Drawing.Size(223, 24)
        Me.cbxInventoryClass.TabIndex = 3
        Me.cbxInventoryClass.ValueMember = "INVENTORYCLASSID"
        '
        'INVENTORYCLASSPRICEBindingSource
        '
        Me.INVENTORYCLASSPRICEBindingSource.DataMember = "INVENTORYCLASS_PRICE"
        Me.INVENTORYCLASSPRICEBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'INVENTORYCLASSBindingSource
        '
        Me.INVENTORYCLASSBindingSource.DataMember = "INVENTORYCLASS"
        Me.INVENTORYCLASSBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(39, 25)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 16)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Inventory Class:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPriceUtility)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtPriceBase)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtInventoryClassType)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtSalesPrice)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtContractedQuantity)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtSalesUnit)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cbxInventoryClass)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 375)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(751, 140)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item"
        '
        'txtPriceUtility
        '
        Me.txtPriceUtility.Location = New System.Drawing.Point(623, 105)
        Me.txtPriceUtility.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPriceUtility.Name = "txtPriceUtility"
        Me.txtPriceUtility.Size = New System.Drawing.Size(117, 22)
        Me.txtPriceUtility.TabIndex = 40
        Me.txtPriceUtility.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(543, 108)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 16)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "Price Utility:"
        '
        'txtPriceBase
        '
        Me.txtPriceBase.Location = New System.Drawing.Point(415, 105)
        Me.txtPriceBase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPriceBase.Name = "txtPriceBase"
        Me.txtPriceBase.Size = New System.Drawing.Size(119, 22)
        Me.txtPriceBase.TabIndex = 38
        Me.txtPriceBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(335, 108)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 16)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Price Base:"
        '
        'txtInventoryClassType
        '
        Me.txtInventoryClassType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInventoryClassType.Location = New System.Drawing.Point(441, 21)
        Me.txtInventoryClassType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInventoryClassType.Name = "txtInventoryClassType"
        Me.txtInventoryClassType.ReadOnly = True
        Me.txtInventoryClassType.Size = New System.Drawing.Size(130, 22)
        Me.txtInventoryClassType.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(388, 22)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 16)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Type:"
        '
        'txtSalesPrice
        '
        Me.txtSalesPrice.ContextMenuStrip = Me.cmnuDecimal
        Me.txtSalesPrice.Location = New System.Drawing.Point(156, 105)
        Me.txtSalesPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSalesPrice.Name = "txtSalesPrice"
        Me.txtSalesPrice.Size = New System.Drawing.Size(157, 22)
        Me.txtSalesPrice.TabIndex = 34
        Me.txtSalesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmnuDecimal
        '
        Me.cmnuDecimal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmnuDecimal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncreaseDecimalToolStripMenuItem, Me.DecreaseDecimalToolStripMenuItem})
        Me.cmnuDecimal.Name = "cmnuDecimal"
        Me.cmnuDecimal.Size = New System.Drawing.Size(199, 52)
        '
        'IncreaseDecimalToolStripMenuItem
        '
        Me.IncreaseDecimalToolStripMenuItem.Name = "IncreaseDecimalToolStripMenuItem"
        Me.IncreaseDecimalToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.IncreaseDecimalToolStripMenuItem.Text = "Increase Decimal"
        '
        'DecreaseDecimalToolStripMenuItem
        '
        Me.DecreaseDecimalToolStripMenuItem.Name = "DecreaseDecimalToolStripMenuItem"
        Me.DecreaseDecimalToolStripMenuItem.Size = New System.Drawing.Size(198, 24)
        Me.DecreaseDecimalToolStripMenuItem.Text = "Decrease Decimal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(64, 108)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 16)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Sales Price:"
        '
        'txtContractedQuantity
        '
        Me.txtContractedQuantity.Location = New System.Drawing.Point(156, 78)
        Me.txtContractedQuantity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContractedQuantity.Name = "txtContractedQuantity"
        Me.txtContractedQuantity.Size = New System.Drawing.Size(157, 22)
        Me.txtContractedQuantity.TabIndex = 5
        Me.txtContractedQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(9, 81)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 16)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Contracted Quantity:"
        '
        'txtSalesUnit
        '
        Me.txtSalesUnit.Location = New System.Drawing.Point(156, 49)
        Me.txtSalesUnit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSalesUnit.MaxLength = 40
        Me.txtSalesUnit.Name = "txtSalesUnit"
        Me.txtSalesUnit.Size = New System.Drawing.Size(157, 22)
        Me.txtSalesUnit.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 53)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Sales Unit:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(385, 607)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(135, 30)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(241, 607)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(136, 30)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'CONTRACTTableAdapter
        '
        Me.CONTRACTTableAdapter.ClearBeforeFill = True
        '
        'INVENTORYCLASSTableAdapter
        '
        Me.INVENTORYCLASSTableAdapter.ClearBeforeFill = True
        '
        'INVENTORYCLASS_PRICETableAdapter
        '
        Me.INVENTORYCLASS_PRICETableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbxPermNegative)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.cbxPermUpdPriceUnit)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.cbxPermUpdDescrip)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 523)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(751, 76)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Permits the User:"
        '
        'cbxPermNegative
        '
        Me.cbxPermNegative.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPermNegative.FormattingEnabled = True
        Me.cbxPermNegative.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbxPermNegative.Location = New System.Drawing.Point(623, 30)
        Me.cbxPermNegative.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxPermNegative.Name = "cbxPermNegative"
        Me.cbxPermNegative.Size = New System.Drawing.Size(93, 25)
        Me.cbxPermNegative.TabIndex = 34
        Me.cbxPermNegative.Text = "NO"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(543, 33)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 16)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "Negative:"
        '
        'cbxPermUpdPriceUnit
        '
        Me.cbxPermUpdPriceUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPermUpdPriceUnit.FormattingEnabled = True
        Me.cbxPermUpdPriceUnit.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbxPermUpdPriceUnit.Location = New System.Drawing.Point(416, 30)
        Me.cbxPermUpdPriceUnit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxPermUpdPriceUnit.Name = "cbxPermUpdPriceUnit"
        Me.cbxPermUpdPriceUnit.Size = New System.Drawing.Size(93, 25)
        Me.cbxPermUpdPriceUnit.TabIndex = 32
        Me.cbxPermUpdPriceUnit.Text = "YES"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(280, 33)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(117, 16)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Change Price Unit:"
        '
        'cbxPermUpdDescrip
        '
        Me.cbxPermUpdDescrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxPermUpdDescrip.FormattingEnabled = True
        Me.cbxPermUpdDescrip.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbxPermUpdDescrip.Location = New System.Drawing.Point(159, 30)
        Me.cbxPermUpdDescrip.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxPermUpdDescrip.Name = "cbxPermUpdDescrip"
        Me.cbxPermUpdDescrip.Size = New System.Drawing.Size(93, 25)
        Me.cbxPermUpdDescrip.TabIndex = 30
        Me.cbxPermUpdDescrip.Text = "YES"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(12, 33)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 16)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Change Description:"
        '
        'frmContractPriceEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(767, 642)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContractPriceEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Contract Price"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CONTRACTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTORYCLASSPRICEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTORYCLASSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.cmnuDecimal.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerItemCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxInventoryClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtContractedQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSalesUnit As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents CONTRACTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents CONTRACTTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.CONTRACTTableAdapter
    Friend WithEvents INVENTORYCLASSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INVENTORYCLASSTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.INVENTORYCLASSTableAdapter
    Friend WithEvents INVENTORYCLASSPRICEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INVENTORYCLASS_PRICETableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.INVENTORYCLASS_PRICETableAdapter
    Friend WithEvents txtContract As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents txtSalesPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbxHeaderGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbxExibitonReport As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTabGroup As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbxShowCustCodeRpt As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtInventoryClassType As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbxActive As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtGroupOrder As System.Windows.Forms.TextBox
    Friend WithEvents txtPriceUtility As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtPriceBase As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbxPermNegative As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cbxPermUpdPriceUnit As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cbxPermUpdDescrip As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cmnuDecimal As ContextMenuStrip
    Friend WithEvents IncreaseDecimalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecreaseDecimalToolStripMenuItem As ToolStripMenuItem
End Class
