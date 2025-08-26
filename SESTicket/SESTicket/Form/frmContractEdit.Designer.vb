<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmContractEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContractEdit))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbxServiceLine = New System.Windows.Forms.ComboBox()
        Me.SERVICELINEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.cbxActive = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxCustomer = New System.Windows.Forms.ComboBox()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtContractNumber = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxCurrency = New System.Windows.Forms.ComboBox()
        Me.CURRENCYBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.CURRENCYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpDueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CURRENCYTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.CURRENCYTableAdapter()
        Me.CUSTOMERTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.CUSTOMERTableAdapter()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtGoodsSubAccount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtGoodAccount = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSalesSubAccount = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSalesAccount = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkAIUApplication = New System.Windows.Forms.CheckedListBox()
        Me.AIUTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AIUTableTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.AIUTableTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtServiceIVAPerc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtServiceUtilityPerc = New System.Windows.Forms.TextBox()
        Me.chkServiceUtility = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtMaterialIVAPerc = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grpPortion = New System.Windows.Forms.GroupBox()
        Me.txtPortionCOP = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPortionUSD = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cbxLayoutType = New System.Windows.Forms.ComboBox()
        Me.LAYOUTTYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LAYOUTTYPETableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.LAYOUTTYPETableAdapter()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtExchangeRate = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbxEnableExcRate = New System.Windows.Forms.ComboBox()
        Me.cbxEnableDisc = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.cbxInvSplitAmount = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.SERVICELINETableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.SERVICELINETableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.grpReportList = New System.Windows.Forms.GroupBox()
        Me.dgvReportLayout = New System.Windows.Forms.DataGridView()
        Me.colCountryCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReportName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContractId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReportCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContractRepLayout = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTRACTREPLAYOUTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxTicketLayout = New System.Windows.Forms.ComboBox()
        Me.REPORTTICKETLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxCountry = New System.Windows.Forms.ComboBox()
        Me.COUNTRYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnDeleteTicketLayout = New System.Windows.Forms.Button()
        Me.btnAddTicketLayout = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txtRepParam = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.COUNTRYTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.COUNTRYTableAdapter()
        Me.REPORTTICKETLISTTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.REPORTTICKETLISTTableAdapter()
        Me.CONTRACTREPLAYOUTTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.CONTRACTREPLAYOUTTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SERVICELINEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CURRENCYBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CURRENCYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AIUTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.grpPortion.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.LAYOUTTYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.grpReportList.SuspendLayout()
        CType(Me.dgvReportLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRACTREPLAYOUTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPORTTICKETLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COUNTRYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.cbxServiceLine)
        Me.GroupBox1.Controls.Add(Me.cbxActive)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbxCustomer)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtContractNumber)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(529, 193)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Information"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(30, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(69, 13)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "Service Line:"
        '
        'cbxServiceLine
        '
        Me.cbxServiceLine.DataSource = Me.SERVICELINEBindingSource
        Me.cbxServiceLine.DisplayMember = "NAME"
        Me.cbxServiceLine.FormattingEnabled = True
        Me.cbxServiceLine.Location = New System.Drawing.Point(105, 25)
        Me.cbxServiceLine.Name = "cbxServiceLine"
        Me.cbxServiceLine.Size = New System.Drawing.Size(196, 21)
        Me.cbxServiceLine.TabIndex = 30
        Me.cbxServiceLine.ValueMember = "SERVICELINEID"
        '
        'SERVICELINEBindingSource
        '
        Me.SERVICELINEBindingSource.DataMember = "SERVICELINE"
        Me.SERVICELINEBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbxActive
        '
        Me.cbxActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbxActive.FormattingEnabled = True
        Me.cbxActive.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbxActive.Location = New System.Drawing.Point(362, 25)
        Me.cbxActive.Name = "cbxActive"
        Me.cbxActive.Size = New System.Drawing.Size(51, 21)
        Me.cbxActive.TabIndex = 40
        Me.cbxActive.Text = "YES"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(316, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Active:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(105, 118)
        Me.txtDescription.MaxLength = 300
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(411, 64)
        Me.txtDescription.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(36, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Description:"
        '
        'cbxCustomer
        '
        Me.cbxCustomer.DataSource = Me.CUSTOMERBindingSource
        Me.cbxCustomer.DisplayMember = "NAME"
        Me.cbxCustomer.FormattingEnabled = True
        Me.cbxCustomer.Location = New System.Drawing.Point(105, 52)
        Me.cbxCustomer.Name = "cbxCustomer"
        Me.cbxCustomer.Size = New System.Drawing.Size(308, 21)
        Me.cbxCustomer.TabIndex = 1
        Me.cbxCustomer.ValueMember = "CUSTOMERID"
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(45, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Customer:"
        '
        'txtContractNumber
        '
        Me.txtContractNumber.Location = New System.Drawing.Point(105, 74)
        Me.txtContractNumber.MaxLength = 25
        Me.txtContractNumber.Name = "txtContractNumber"
        Me.txtContractNumber.Size = New System.Drawing.Size(308, 20)
        Me.txtContractNumber.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(105, 96)
        Me.txtName.MaxLength = 100
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(411, 20)
        Me.txtName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Contract Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(61, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'cbxCurrency
        '
        Me.cbxCurrency.DataSource = Me.CURRENCYBindingSource1
        Me.cbxCurrency.DisplayMember = "CURRENCYNAME"
        Me.cbxCurrency.FormattingEnabled = True
        Me.cbxCurrency.Location = New System.Drawing.Point(102, 18)
        Me.cbxCurrency.Name = "cbxCurrency"
        Me.cbxCurrency.Size = New System.Drawing.Size(205, 21)
        Me.cbxCurrency.TabIndex = 7
        Me.cbxCurrency.ValueMember = "CURRENCYCODE"
        '
        'CURRENCYBindingSource1
        '
        Me.CURRENCYBindingSource1.DataMember = "CURRENCY"
        Me.CURRENCYBindingSource1.DataSource = Me.SESTicketAccessDataSet
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Currency:"
        '
        'dtpDueDate
        '
        Me.dtpDueDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDueDate.Location = New System.Drawing.Point(76, 41)
        Me.dtpDueDate.Name = "dtpDueDate"
        Me.dtpDueDate.Size = New System.Drawing.Size(95, 20)
        Me.dtpDueDate.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(14, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Due Date:"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(76, 21)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(95, 20)
        Me.dtpStartDate.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(14, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Start Date:"
        '
        'CURRENCYTableAdapter
        '
        Me.CURRENCYTableAdapter.ClearBeforeFill = True
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtGoodsSubAccount)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtGoodAccount)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.txtSalesSubAccount)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.txtSalesAccount)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 86)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(529, 69)
        Me.GroupBox4.TabIndex = 27
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Account"
        '
        'txtGoodsSubAccount
        '
        Me.txtGoodsSubAccount.Location = New System.Drawing.Point(370, 40)
        Me.txtGoodsSubAccount.MaxLength = 30
        Me.txtGoodsSubAccount.Name = "txtGoodsSubAccount"
        Me.txtGoodsSubAccount.Size = New System.Drawing.Size(126, 20)
        Me.txtGoodsSubAccount.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(261, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Goods SubAccount:"
        '
        'txtGoodAccount
        '
        Me.txtGoodAccount.Location = New System.Drawing.Point(127, 40)
        Me.txtGoodAccount.MaxLength = 30
        Me.txtGoodAccount.Name = "txtGoodAccount"
        Me.txtGoodAccount.Size = New System.Drawing.Size(126, 20)
        Me.txtGoodAccount.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(37, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Goods Account:"
        '
        'txtSalesSubAccount
        '
        Me.txtSalesSubAccount.Location = New System.Drawing.Point(370, 18)
        Me.txtSalesSubAccount.MaxLength = 30
        Me.txtSalesSubAccount.Name = "txtSalesSubAccount"
        Me.txtSalesSubAccount.Size = New System.Drawing.Size(126, 20)
        Me.txtSalesSubAccount.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(266, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 16)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Sales SubAccount:"
        '
        'txtSalesAccount
        '
        Me.txtSalesAccount.Location = New System.Drawing.Point(127, 18)
        Me.txtSalesAccount.MaxLength = 30
        Me.txtSalesAccount.Name = "txtSalesAccount"
        Me.txtSalesAccount.Size = New System.Drawing.Size(126, 20)
        Me.txtSalesAccount.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(42, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Sales Account:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkAIUApplication)
        Me.GroupBox2.Location = New System.Drawing.Point(325, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 202)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Application"
        '
        'chkAIUApplication
        '
        Me.chkAIUApplication.FormattingEnabled = True
        Me.chkAIUApplication.Items.AddRange(New Object() {"Cemento", "Primary Cementing Products", "Primary Cementing Personal", "Primary Cementing Services", "Remedial Cementing Products", "Remedial Cementing Personal", "Remedial Cementing Services", "Equipo de Flotacion", "Gravel Pack Products", "Gravel Pack Personal", "Gravel Pack Services", "Casing Hardware Products", "Pumping Jobs Products", "Pumping Jobs Personal", "Pumping Jobs Services", "Quimica "})
        Me.chkAIUApplication.Location = New System.Drawing.Point(12, 19)
        Me.chkAIUApplication.Name = "chkAIUApplication"
        Me.chkAIUApplication.Size = New System.Drawing.Size(191, 169)
        Me.chkAIUApplication.TabIndex = 9
        '
        'AIUTableBindingSource
        '
        Me.AIUTableBindingSource.DataMember = "AIUTable"
        Me.AIUTableBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'AIUTableTableAdapter
        '
        Me.AIUTableTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtServiceIVAPerc)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtServiceUtilityPerc)
        Me.GroupBox3.Controls.Add(Me.chkServiceUtility)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 66)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(193, 63)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tax - Service"
        '
        'txtServiceIVAPerc
        '
        Me.txtServiceIVAPerc.Location = New System.Drawing.Point(61, 15)
        Me.txtServiceIVAPerc.Name = "txtServiceIVAPerc"
        Me.txtServiceIVAPerc.Size = New System.Drawing.Size(52, 20)
        Me.txtServiceIVAPerc.TabIndex = 4
        Me.txtServiceIVAPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(11, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "IVA (%):"
        '
        'txtServiceUtilityPerc
        '
        Me.txtServiceUtilityPerc.Location = New System.Drawing.Point(61, 37)
        Me.txtServiceUtilityPerc.Name = "txtServiceUtilityPerc"
        Me.txtServiceUtilityPerc.Size = New System.Drawing.Size(52, 20)
        Me.txtServiceUtilityPerc.TabIndex = 1
        Me.txtServiceUtilityPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkServiceUtility
        '
        Me.chkServiceUtility.AutoSize = True
        Me.chkServiceUtility.Location = New System.Drawing.Point(118, 39)
        Me.chkServiceUtility.Name = "chkServiceUtility"
        Me.chkServiceUtility.Size = New System.Drawing.Size(68, 17)
        Me.chkServiceUtility.TabIndex = 2
        Me.chkServiceUtility.Text = "No Utility"
        Me.chkServiceUtility.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Utility (%):"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtMaterialIVAPerc)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(208, 66)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(115, 63)
        Me.GroupBox5.TabIndex = 30
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tax - Material"
        '
        'txtMaterialIVAPerc
        '
        Me.txtMaterialIVAPerc.Location = New System.Drawing.Point(58, 15)
        Me.txtMaterialIVAPerc.Name = "txtMaterialIVAPerc"
        Me.txtMaterialIVAPerc.Size = New System.Drawing.Size(51, 20)
        Me.txtMaterialIVAPerc.TabIndex = 4
        Me.txtMaterialIVAPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(6, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "IVA (%):"
        '
        'grpPortion
        '
        Me.grpPortion.Controls.Add(Me.txtPortionCOP)
        Me.grpPortion.Controls.Add(Me.Label12)
        Me.grpPortion.Controls.Add(Me.txtPortionUSD)
        Me.grpPortion.Controls.Add(Me.Label11)
        Me.grpPortion.Location = New System.Drawing.Point(329, 64)
        Me.grpPortion.Name = "grpPortion"
        Me.grpPortion.Size = New System.Drawing.Size(119, 65)
        Me.grpPortion.TabIndex = 31
        Me.grpPortion.TabStop = False
        Me.grpPortion.Text = "Portion"
        '
        'txtPortionCOP
        '
        Me.txtPortionCOP.Location = New System.Drawing.Point(61, 39)
        Me.txtPortionCOP.Name = "txtPortionCOP"
        Me.txtPortionCOP.Size = New System.Drawing.Size(53, 20)
        Me.txtPortionCOP.TabIndex = 7
        Me.txtPortionCOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(6, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "COP (%):"
        '
        'txtPortionUSD
        '
        Me.txtPortionUSD.Location = New System.Drawing.Point(61, 17)
        Me.txtPortionUSD.Name = "txtPortionUSD"
        Me.txtPortionUSD.Size = New System.Drawing.Size(53, 20)
        Me.txtPortionUSD.TabIndex = 5
        Me.txtPortionUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(6, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "USD (%):"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cbxLayoutType)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.grpPortion)
        Me.GroupBox7.Controls.Add(Me.GroupBox5)
        Me.GroupBox7.Controls.Add(Me.GroupBox3)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(6, 190)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(462, 148)
        Me.GroupBox7.TabIndex = 32
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Calculation"
        '
        'cbxLayoutType
        '
        Me.cbxLayoutType.DataSource = Me.LAYOUTTYPEBindingSource
        Me.cbxLayoutType.DisplayMember = "DESCRIPTION"
        Me.cbxLayoutType.FormattingEnabled = True
        Me.cbxLayoutType.Location = New System.Drawing.Point(64, 24)
        Me.cbxLayoutType.Name = "cbxLayoutType"
        Me.cbxLayoutType.Size = New System.Drawing.Size(239, 21)
        Me.cbxLayoutType.TabIndex = 30
        Me.cbxLayoutType.ValueMember = "LAYOUTTYPE"
        '
        'LAYOUTTYPEBindingSource
        '
        Me.LAYOUTTYPEBindingSource.DataMember = "LAYOUTTYPE"
        Me.LAYOUTTYPEBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(16, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Layout:"
        '
        'LAYOUTTYPETableAdapter
        '
        Me.LAYOUTTYPETableAdapter.ClearBeforeFill = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dtpDueDate)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.dtpStartDate)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 216)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(208, 72)
        Me.GroupBox6.TabIndex = 33
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Contract Vigency"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtExchangeRate)
        Me.GroupBox8.Controls.Add(Me.Label19)
        Me.GroupBox8.Controls.Add(Me.cbxCurrency)
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 23)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(317, 71)
        Me.GroupBox8.TabIndex = 34
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Currency"
        '
        'txtExchangeRate
        '
        Me.txtExchangeRate.Location = New System.Drawing.Point(102, 41)
        Me.txtExchangeRate.Name = "txtExchangeRate"
        Me.txtExchangeRate.Size = New System.Drawing.Size(93, 20)
        Me.txtExchangeRate.TabIndex = 30
        Me.txtExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(16, 44)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 13)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Exchange Rate:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(16, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(168, 13)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "Can Update the Exchange Rate?:"
        '
        'cbxEnableExcRate
        '
        Me.cbxEnableExcRate.FormattingEnabled = True
        Me.cbxEnableExcRate.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbxEnableExcRate.Location = New System.Drawing.Point(190, 16)
        Me.cbxEnableExcRate.Name = "cbxEnableExcRate"
        Me.cbxEnableExcRate.Size = New System.Drawing.Size(53, 21)
        Me.cbxEnableExcRate.TabIndex = 33
        '
        'cbxEnableDisc
        '
        Me.cbxEnableDisc.FormattingEnabled = True
        Me.cbxEnableDisc.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbxEnableDisc.Location = New System.Drawing.Point(189, 40)
        Me.cbxEnableDisc.Name = "cbxEnableDisc"
        Me.cbxEnableDisc.Size = New System.Drawing.Size(54, 21)
        Me.cbxEnableDisc.TabIndex = 32
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(16, 43)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(102, 13)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "Can Give Discount?"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.cbxInvSplitAmount)
        Me.GroupBox9.Controls.Add(Me.Label22)
        Me.GroupBox9.Location = New System.Drawing.Point(329, 109)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(214, 51)
        Me.GroupBox9.TabIndex = 35
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Invoice Control"
        '
        'cbxInvSplitAmount
        '
        Me.cbxInvSplitAmount.FormattingEnabled = True
        Me.cbxInvSplitAmount.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbxInvSplitAmount.Location = New System.Drawing.Point(145, 16)
        Me.cbxInvSplitAmount.Name = "cbxInvSplitAmount"
        Me.cbxInvSplitAmount.Size = New System.Drawing.Size(53, 21)
        Me.cbxInvSplitAmount.TabIndex = 34
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(16, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(123, 13)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Split Amount (Mat/Serv):"
        '
        'SERVICELINETableAdapter
        '
        Me.SERVICELINETableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(5, 45)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(559, 452)
        Me.TabControl1.TabIndex = 38
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(551, 426)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Contract Information"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.GroupBox12)
        Me.TabPage2.Controls.Add(Me.GroupBox8)
        Me.TabPage2.Controls.Add(Me.GroupBox9)
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(551, 426)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Currency, Invoice, Discount"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Label21)
        Me.GroupBox12.Controls.Add(Me.cbxEnableExcRate)
        Me.GroupBox12.Controls.Add(Me.Label20)
        Me.GroupBox12.Controls.Add(Me.cbxEnableDisc)
        Me.GroupBox12.Location = New System.Drawing.Point(6, 109)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(317, 75)
        Me.GroupBox12.TabIndex = 36
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "User Permission"
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.grpReportList)
        Me.TabPage3.Controls.Add(Me.GroupBox11)
        Me.TabPage3.Controls.Add(Me.GroupBox10)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(551, 426)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Report Config"
        '
        'grpReportList
        '
        Me.grpReportList.Controls.Add(Me.dgvReportLayout)
        Me.grpReportList.Controls.Add(Me.cbxTicketLayout)
        Me.grpReportList.Controls.Add(Me.cbxCountry)
        Me.grpReportList.Controls.Add(Me.Label27)
        Me.grpReportList.Controls.Add(Me.Label26)
        Me.grpReportList.Controls.Add(Me.btnDeleteTicketLayout)
        Me.grpReportList.Controls.Add(Me.btnAddTicketLayout)
        Me.grpReportList.Location = New System.Drawing.Point(15, 74)
        Me.grpReportList.Name = "grpReportList"
        Me.grpReportList.Size = New System.Drawing.Size(511, 321)
        Me.grpReportList.TabIndex = 38
        Me.grpReportList.TabStop = False
        Me.grpReportList.Text = "Report Sales Itens Availlabe for Contract"
        '
        'dgvReportLayout
        '
        Me.dgvReportLayout.AllowUserToAddRows = False
        Me.dgvReportLayout.AllowUserToDeleteRows = False
        Me.dgvReportLayout.AutoGenerateColumns = False
        Me.dgvReportLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReportLayout.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCountryCode, Me.colReportName, Me.colContractId, Me.colReportCode, Me.colContractRepLayout})
        Me.dgvReportLayout.DataSource = Me.CONTRACTREPLAYOUTBindingSource
        Me.dgvReportLayout.Location = New System.Drawing.Point(10, 82)
        Me.dgvReportLayout.Name = "dgvReportLayout"
        Me.dgvReportLayout.ReadOnly = True
        Me.dgvReportLayout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReportLayout.Size = New System.Drawing.Size(486, 220)
        Me.dgvReportLayout.TabIndex = 21
        '
        'colCountryCode
        '
        Me.colCountryCode.DataPropertyName = "COUNTRYCODE"
        Me.colCountryCode.HeaderText = "Country"
        Me.colCountryCode.Name = "colCountryCode"
        Me.colCountryCode.ReadOnly = True
        Me.colCountryCode.Width = 60
        '
        'colReportName
        '
        Me.colReportName.DataPropertyName = "REPORTNAME"
        Me.colReportName.HeaderText = "Ticket Layout"
        Me.colReportName.Name = "colReportName"
        Me.colReportName.ReadOnly = True
        Me.colReportName.Width = 320
        '
        'colContractId
        '
        Me.colContractId.DataPropertyName = "CONTRACTID"
        Me.colContractId.HeaderText = "CONTRACTID"
        Me.colContractId.Name = "colContractId"
        Me.colContractId.ReadOnly = True
        Me.colContractId.Visible = False
        '
        'colReportCode
        '
        Me.colReportCode.DataPropertyName = "REPORTCODE"
        Me.colReportCode.HeaderText = "REPORTCODE"
        Me.colReportCode.Name = "colReportCode"
        Me.colReportCode.ReadOnly = True
        Me.colReportCode.Visible = False
        '
        'colContractRepLayout
        '
        Me.colContractRepLayout.DataPropertyName = "CONTRACTREPLAYOUT"
        Me.colContractRepLayout.HeaderText = "CONTRACTREPLAYOUT"
        Me.colContractRepLayout.Name = "colContractRepLayout"
        Me.colContractRepLayout.ReadOnly = True
        Me.colContractRepLayout.Visible = False
        '
        'CONTRACTREPLAYOUTBindingSource
        '
        Me.CONTRACTREPLAYOUTBindingSource.DataMember = "CONTRACTREPLAYOUT"
        Me.CONTRACTREPLAYOUTBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'cbxTicketLayout
        '
        Me.cbxTicketLayout.DataSource = Me.REPORTTICKETLISTBindingSource
        Me.cbxTicketLayout.DisplayMember = "REPORTNAME"
        Me.cbxTicketLayout.FormattingEnabled = True
        Me.cbxTicketLayout.Location = New System.Drawing.Point(93, 43)
        Me.cbxTicketLayout.Name = "cbxTicketLayout"
        Me.cbxTicketLayout.Size = New System.Drawing.Size(261, 21)
        Me.cbxTicketLayout.TabIndex = 21
        Me.cbxTicketLayout.ValueMember = "REPORTCODE"
        '
        'REPORTTICKETLISTBindingSource
        '
        Me.REPORTTICKETLISTBindingSource.DataMember = "REPORTTICKETLIST"
        Me.REPORTTICKETLISTBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'cbxCountry
        '
        Me.cbxCountry.DataSource = Me.COUNTRYBindingSource
        Me.cbxCountry.DisplayMember = "COUNTRYCODE"
        Me.cbxCountry.FormattingEnabled = True
        Me.cbxCountry.Location = New System.Drawing.Point(10, 43)
        Me.cbxCountry.Name = "cbxCountry"
        Me.cbxCountry.Size = New System.Drawing.Size(77, 21)
        Me.cbxCountry.TabIndex = 20
        Me.cbxCountry.ValueMember = "COUNTRYCODE"
        '
        'COUNTRYBindingSource
        '
        Me.COUNTRYBindingSource.DataMember = "COUNTRY"
        Me.COUNTRYBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(90, 27)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(75, 13)
        Me.Label27.TabIndex = 19
        Me.Label27.Text = "Ticket Layout:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(7, 27)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(46, 13)
        Me.Label26.TabIndex = 18
        Me.Label26.Text = "Country:"
        '
        'btnDeleteTicketLayout
        '
        Me.btnDeleteTicketLayout.Location = New System.Drawing.Point(439, 41)
        Me.btnDeleteTicketLayout.Name = "btnDeleteTicketLayout"
        Me.btnDeleteTicketLayout.Size = New System.Drawing.Size(57, 23)
        Me.btnDeleteTicketLayout.TabIndex = 17
        Me.btnDeleteTicketLayout.Text = "Delete"
        Me.btnDeleteTicketLayout.UseVisualStyleBackColor = True
        '
        'btnAddTicketLayout
        '
        Me.btnAddTicketLayout.Location = New System.Drawing.Point(376, 41)
        Me.btnAddTicketLayout.Name = "btnAddTicketLayout"
        Me.btnAddTicketLayout.Size = New System.Drawing.Size(57, 23)
        Me.btnAddTicketLayout.TabIndex = 16
        Me.btnAddTicketLayout.Text = "Add"
        Me.btnAddTicketLayout.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label25)
        Me.GroupBox11.Location = New System.Drawing.Point(15, 382)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(317, 41)
        Me.GroupBox11.TabIndex = 37
        Me.GroupBox11.TabStop = False
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(6, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(304, 17)
        Me.Label25.TabIndex = 35
        Me.Label25.Text = "To Update - Double Click" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtRepParam)
        Me.GroupBox10.Controls.Add(Me.Label24)
        Me.GroupBox10.Location = New System.Drawing.Point(15, 16)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(317, 51)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        '
        'txtRepParam
        '
        Me.txtRepParam.BackColor = System.Drawing.Color.White
        Me.txtRepParam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRepParam.ForeColor = System.Drawing.Color.Red
        Me.txtRepParam.Location = New System.Drawing.Point(106, 18)
        Me.txtRepParam.Name = "txtRepParam"
        Me.txtRepParam.ReadOnly = True
        Me.txtRepParam.Size = New System.Drawing.Size(191, 20)
        Me.txtRepParam.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(7, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(93, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Report Parameter:"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(551, 426)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Accounts"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(567, 42)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuSave
        '
        Me.mnuSave.Image = CType(resources.GetObject("mnuSave.Image"), System.Drawing.Image)
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(59, 38)
        Me.mnuSave.Text = "Save"
        '
        'mnuExit
        '
        Me.mnuExit.Image = CType(resources.GetObject("mnuExit.Image"), System.Drawing.Image)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(53, 38)
        Me.mnuExit.Text = "Exit"
        '
        'COUNTRYTableAdapter
        '
        Me.COUNTRYTableAdapter.ClearBeforeFill = True
        '
        'REPORTTICKETLISTTableAdapter
        '
        Me.REPORTTICKETLISTTableAdapter.ClearBeforeFill = True
        '
        'CONTRACTREPLAYOUTTableAdapter
        '
        Me.CONTRACTREPLAYOUTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CASINGTableAdapter = Nothing
        Me.TableAdapterManager.CITYTableAdapter = Nothing
        Me.TableAdapterManager.CONTRACTAIUINVENTORYCLASSTableAdapter = Nothing
        Me.TableAdapterManager.CONTRACTPRICELISTTableAdapter = Nothing
        Me.TableAdapterManager.CONTRACTTableAdapter = Nothing
        Me.TableAdapterManager.CUSTOMERTableAdapter = Me.CUSTOMERTableAdapter
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
        'frmContractEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(567, 502)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContractEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTICKET - Contract Edit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SERVICELINEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CURRENCYBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CURRENCYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.AIUTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.grpPortion.ResumeLayout(False)
        Me.grpPortion.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.LAYOUTTYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.grpReportList.ResumeLayout(False)
        Me.grpReportList.PerformLayout()
        CType(Me.dgvReportLayout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRACTREPLAYOUTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPORTTICKETLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COUNTRYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxCurrency As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtContractNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CURRENCYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CURRENCYTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.CURRENCYTableAdapter
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents CUSTOMERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUSTOMERTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSalesSubAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSalesAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtGoodsSubAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtGoodAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents AIUTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AIUTableTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.AIUTableTableAdapter
    Friend WithEvents chkAIUApplication As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtServiceIVAPerc As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkServiceUtility As System.Windows.Forms.CheckBox
    Friend WithEvents txtServiceUtilityPerc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMaterialIVAPerc As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents grpPortion As System.Windows.Forms.GroupBox
    Friend WithEvents txtPortionCOP As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPortionUSD As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbxLayoutType As System.Windows.Forms.ComboBox
    Friend WithEvents LAYOUTTYPEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LAYOUTTYPETableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.LAYOUTTYPETableAdapter
    Friend WithEvents cbxActive As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxEnableDisc As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtExchangeRate As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbxEnableExcRate As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxInvSplitAmount As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbxServiceLine As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents SERVICELINEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERVICELINETableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.SERVICELINETableAdapter
    Friend WithEvents CURRENCYBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SESTicketAccessDataSet As SESTicket.SESTicketAccessDataSet
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRepParam As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents grpReportList As GroupBox
    Friend WithEvents btnDeleteTicketLayout As Button
    Friend WithEvents btnAddTicketLayout As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents cbxCountry As ComboBox
    Friend WithEvents cbxTicketLayout As ComboBox
    Friend WithEvents COUNTRYBindingSource As BindingSource
    Friend WithEvents COUNTRYTableAdapter As SESTicketAccessDataSetTableAdapters.COUNTRYTableAdapter
    Friend WithEvents REPORTTICKETLISTBindingSource As BindingSource
    Friend WithEvents REPORTTICKETLISTTableAdapter As SESTicketAccessDataSetTableAdapters.REPORTTICKETLISTTableAdapter
    Friend WithEvents CONTRACTREPLAYOUTBindingSource As BindingSource
    Friend WithEvents CONTRACTREPLAYOUTTableAdapter As SESTicketSQLDataSetTableAdapters.CONTRACTREPLAYOUTTableAdapter
    Friend WithEvents TableAdapterManager As SESTicketSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvReportLayout As DataGridView
    Friend WithEvents colCountryCode As DataGridViewTextBoxColumn
    Friend WithEvents colReportName As DataGridViewTextBoxColumn
    Friend WithEvents colContractId As DataGridViewTextBoxColumn
    Friend WithEvents colReportCode As DataGridViewTextBoxColumn
    Friend WithEvents colContractRepLayout As DataGridViewTextBoxColumn
End Class
