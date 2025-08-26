<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContractList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContractList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CONTRACTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.dgvContract = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxCustomer = New System.Windows.Forms.ComboBox()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUSTOMERTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.CUSTOMERTableAdapter()
        Me.CONTRACTTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.CONTRACTTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager()
        Me.chkNo = New System.Windows.Forms.CheckBox()
        Me.chkYes = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuNewItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.colContractID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceLineName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContractNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStartDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCompletionDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCurrency = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesSubAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoodsAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoodsSubAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceUtility = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceUtilityPerc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceIVAPerc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaterialIVAPerc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPortionCOP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPortionUSD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLayoutType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExchangeRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEnableExcRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEnableDisc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSplitAmountMatServ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceLineId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReportParamId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReportParamDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CONTRACTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContract, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        'dgvContract
        '
        Me.dgvContract.AllowUserToAddRows = False
        Me.dgvContract.AllowUserToDeleteRows = False
        Me.dgvContract.AutoGenerateColumns = False
        Me.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContract.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colContractID, Me.colServiceLineName, Me.colContractNumber, Me.colName, Me.colDescription, Me.colStartDate, Me.colCompletionDate, Me.colCustomerName, Me.colCurrency, Me.colActive, Me.colSalesAccount, Me.colSalesSubAccount, Me.colGoodsAccount, Me.colGoodsSubAccount, Me.colServiceUtility, Me.colServiceUtilityPerc, Me.colServiceIVAPerc, Me.colMaterialIVAPerc, Me.colPortionCOP, Me.colPortionUSD, Me.colLayoutType, Me.colExchangeRate, Me.colEnableExcRate, Me.colEnableDisc, Me.colSplitAmountMatServ, Me.colServiceLineId, Me.colCustomerID, Me.colReportParamId, Me.colReportParamDesc})
        Me.dgvContract.DataSource = Me.CONTRACTBindingSource
        Me.dgvContract.Location = New System.Drawing.Point(0, 45)
        Me.dgvContract.Name = "dgvContract"
        Me.dgvContract.ReadOnly = True
        Me.dgvContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContract.Size = New System.Drawing.Size(1056, 500)
        Me.dgvContract.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(350, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer:"
        '
        'cbxCustomer
        '
        Me.cbxCustomer.DataSource = Me.CUSTOMERBindingSource
        Me.cbxCustomer.DisplayMember = "NAME"
        Me.cbxCustomer.FormattingEnabled = True
        Me.cbxCustomer.Location = New System.Drawing.Point(411, 12)
        Me.cbxCustomer.Name = "cbxCustomer"
        Me.cbxCustomer.Size = New System.Drawing.Size(295, 21)
        Me.cbxCustomer.TabIndex = 3
        Me.cbxCustomer.ValueMember = "CUSTOMERID"
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'CONTRACTTableAdapter
        '
        Me.CONTRACTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CASINGTableAdapter = Nothing
        Me.TableAdapterManager.CITYTableAdapter = Nothing
        Me.TableAdapterManager.CONTRACTAIUINVENTORYCLASSTableAdapter = Nothing
        Me.TableAdapterManager.CONTRACTPRICELISTTableAdapter = Nothing
        Me.TableAdapterManager.CONTRACTTableAdapter = Me.CONTRACTTableAdapter
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
        'chkNo
        '
        Me.chkNo.AutoSize = True
        Me.chkNo.Location = New System.Drawing.Point(1011, 16)
        Me.chkNo.Name = "chkNo"
        Me.chkNo.Size = New System.Drawing.Size(40, 17)
        Me.chkNo.TabIndex = 41
        Me.chkNo.Text = "No"
        Me.chkNo.UseVisualStyleBackColor = True
        '
        'chkYes
        '
        Me.chkYes.AutoSize = True
        Me.chkYes.Checked = True
        Me.chkYes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkYes.Location = New System.Drawing.Point(961, 16)
        Me.chkYes.Name = "chkYes"
        Me.chkYes.Size = New System.Drawing.Size(44, 17)
        Me.chkYes.TabIndex = 40
        Me.chkYes.Text = "Yes"
        Me.chkYes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(915, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Active:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1066, 42)
        Me.MenuStrip1.TabIndex = 38
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuNewItem
        '
        Me.mnuNewItem.Image = CType(resources.GetObject("mnuNewItem.Image"), System.Drawing.Image)
        Me.mnuNewItem.Name = "mnuNewItem"
        Me.mnuNewItem.Size = New System.Drawing.Size(86, 38)
        Me.mnuNewItem.Text = "New Item"
        Me.mnuNewItem.ToolTipText = "Save the Ticket"
        '
        'colContractID
        '
        Me.colContractID.DataPropertyName = "CONTRACTID"
        Me.colContractID.HeaderText = "ID"
        Me.colContractID.Name = "colContractID"
        Me.colContractID.ReadOnly = True
        Me.colContractID.Width = 50
        '
        'colServiceLineName
        '
        Me.colServiceLineName.DataPropertyName = "SERVICELINENAME"
        Me.colServiceLineName.HeaderText = "Service Line"
        Me.colServiceLineName.Name = "colServiceLineName"
        Me.colServiceLineName.ReadOnly = True
        Me.colServiceLineName.Width = 140
        '
        'colContractNumber
        '
        Me.colContractNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colContractNumber.DataPropertyName = "CONTRACTNUMBER"
        Me.colContractNumber.HeaderText = "Contract Number"
        Me.colContractNumber.Name = "colContractNumber"
        Me.colContractNumber.ReadOnly = True
        Me.colContractNumber.Width = 103
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colName.DataPropertyName = "NAME"
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Width = 60
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "DESCRIPTION"
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Visible = False
        Me.colDescription.Width = 250
        '
        'colStartDate
        '
        Me.colStartDate.DataPropertyName = "START_DATE"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colStartDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.colStartDate.HeaderText = "Start Date"
        Me.colStartDate.Name = "colStartDate"
        Me.colStartDate.ReadOnly = True
        Me.colStartDate.Width = 80
        '
        'colCompletionDate
        '
        Me.colCompletionDate.DataPropertyName = "COMPLETION_DATE"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colCompletionDate.DefaultCellStyle = DataGridViewCellStyle2
        Me.colCompletionDate.HeaderText = "Due Date"
        Me.colCompletionDate.Name = "colCompletionDate"
        Me.colCompletionDate.ReadOnly = True
        Me.colCompletionDate.Width = 80
        '
        'colCustomerName
        '
        Me.colCustomerName.DataPropertyName = "CUSTOMERNAME"
        Me.colCustomerName.HeaderText = "Customer"
        Me.colCustomerName.Name = "colCustomerName"
        Me.colCustomerName.ReadOnly = True
        Me.colCustomerName.Width = 230
        '
        'colCurrency
        '
        Me.colCurrency.DataPropertyName = "CURRENCY"
        Me.colCurrency.HeaderText = "Currency"
        Me.colCurrency.Name = "colCurrency"
        Me.colCurrency.ReadOnly = True
        Me.colCurrency.Width = 60
        '
        'colActive
        '
        Me.colActive.DataPropertyName = "ACTIVE"
        Me.colActive.HeaderText = "Active"
        Me.colActive.Name = "colActive"
        Me.colActive.ReadOnly = True
        Me.colActive.Width = 60
        '
        'colSalesAccount
        '
        Me.colSalesAccount.DataPropertyName = "SALESACCOUNT"
        Me.colSalesAccount.HeaderText = "Sales Account"
        Me.colSalesAccount.Name = "colSalesAccount"
        Me.colSalesAccount.ReadOnly = True
        Me.colSalesAccount.Visible = False
        '
        'colSalesSubAccount
        '
        Me.colSalesSubAccount.DataPropertyName = "SALESSUBACCOUNT"
        Me.colSalesSubAccount.HeaderText = "Sales SubAccount"
        Me.colSalesSubAccount.Name = "colSalesSubAccount"
        Me.colSalesSubAccount.ReadOnly = True
        Me.colSalesSubAccount.Visible = False
        '
        'colGoodsAccount
        '
        Me.colGoodsAccount.DataPropertyName = "COSTOFGOODSACCOUNT"
        Me.colGoodsAccount.HeaderText = "CostOfGoodsAccount"
        Me.colGoodsAccount.Name = "colGoodsAccount"
        Me.colGoodsAccount.ReadOnly = True
        Me.colGoodsAccount.Visible = False
        '
        'colGoodsSubAccount
        '
        Me.colGoodsSubAccount.DataPropertyName = "COSTOFGOODSSUBACCOUNT"
        Me.colGoodsSubAccount.HeaderText = "CostOfGoodsSubAccount"
        Me.colGoodsSubAccount.Name = "colGoodsSubAccount"
        Me.colGoodsSubAccount.ReadOnly = True
        Me.colGoodsSubAccount.Visible = False
        '
        'colServiceUtility
        '
        Me.colServiceUtility.DataPropertyName = "SERVICE_UTILITY"
        Me.colServiceUtility.HeaderText = "Service Utility"
        Me.colServiceUtility.Name = "colServiceUtility"
        Me.colServiceUtility.ReadOnly = True
        Me.colServiceUtility.Visible = False
        '
        'colServiceUtilityPerc
        '
        Me.colServiceUtilityPerc.DataPropertyName = "SERVICE_UTILITY_PERC"
        Me.colServiceUtilityPerc.HeaderText = "Service Utility Perc"
        Me.colServiceUtilityPerc.Name = "colServiceUtilityPerc"
        Me.colServiceUtilityPerc.ReadOnly = True
        Me.colServiceUtilityPerc.Visible = False
        '
        'colServiceIVAPerc
        '
        Me.colServiceIVAPerc.DataPropertyName = "SERVICE_IVA_PERC"
        Me.colServiceIVAPerc.HeaderText = "Service IVA Perc"
        Me.colServiceIVAPerc.Name = "colServiceIVAPerc"
        Me.colServiceIVAPerc.ReadOnly = True
        Me.colServiceIVAPerc.Visible = False
        '
        'colMaterialIVAPerc
        '
        Me.colMaterialIVAPerc.DataPropertyName = "MATERIAL_IVA_PERC"
        Me.colMaterialIVAPerc.HeaderText = "Material IVA Perc"
        Me.colMaterialIVAPerc.Name = "colMaterialIVAPerc"
        Me.colMaterialIVAPerc.ReadOnly = True
        Me.colMaterialIVAPerc.Visible = False
        '
        'colPortionCOP
        '
        Me.colPortionCOP.DataPropertyName = "PORTIONCOP"
        Me.colPortionCOP.HeaderText = "PORTIONCOP"
        Me.colPortionCOP.Name = "colPortionCOP"
        Me.colPortionCOP.ReadOnly = True
        Me.colPortionCOP.Visible = False
        '
        'colPortionUSD
        '
        Me.colPortionUSD.DataPropertyName = "PORTIONUSD"
        Me.colPortionUSD.HeaderText = "PORTIONUSD"
        Me.colPortionUSD.Name = "colPortionUSD"
        Me.colPortionUSD.ReadOnly = True
        Me.colPortionUSD.Visible = False
        '
        'colLayoutType
        '
        Me.colLayoutType.DataPropertyName = "LAYOUTTYPE"
        Me.colLayoutType.HeaderText = "LAYOUTTYPE"
        Me.colLayoutType.Name = "colLayoutType"
        Me.colLayoutType.ReadOnly = True
        Me.colLayoutType.Visible = False
        '
        'colExchangeRate
        '
        Me.colExchangeRate.DataPropertyName = "EXCHANGERATE"
        Me.colExchangeRate.HeaderText = "EXCHANGERATE"
        Me.colExchangeRate.Name = "colExchangeRate"
        Me.colExchangeRate.ReadOnly = True
        Me.colExchangeRate.Visible = False
        '
        'colEnableExcRate
        '
        Me.colEnableExcRate.DataPropertyName = "ENABLEEXCHANGERATE"
        Me.colEnableExcRate.HeaderText = "ENABLEEXCHANGERATE"
        Me.colEnableExcRate.Name = "colEnableExcRate"
        Me.colEnableExcRate.ReadOnly = True
        Me.colEnableExcRate.Visible = False
        '
        'colEnableDisc
        '
        Me.colEnableDisc.DataPropertyName = "ENABLEDISCOUNT"
        Me.colEnableDisc.HeaderText = "ENABLEDISCOUNT"
        Me.colEnableDisc.Name = "colEnableDisc"
        Me.colEnableDisc.ReadOnly = True
        Me.colEnableDisc.Visible = False
        '
        'colSplitAmountMatServ
        '
        Me.colSplitAmountMatServ.DataPropertyName = "SPLITAMOUNTMATSERV"
        Me.colSplitAmountMatServ.HeaderText = "SPLITAMOUNTMATSERV"
        Me.colSplitAmountMatServ.Name = "colSplitAmountMatServ"
        Me.colSplitAmountMatServ.ReadOnly = True
        Me.colSplitAmountMatServ.Visible = False
        '
        'colServiceLineId
        '
        Me.colServiceLineId.DataPropertyName = "SERVICELINEID"
        Me.colServiceLineId.HeaderText = "SERVICELINEID"
        Me.colServiceLineId.Name = "colServiceLineId"
        Me.colServiceLineId.ReadOnly = True
        Me.colServiceLineId.Visible = False
        '
        'colCustomerID
        '
        Me.colCustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCustomerID.DataPropertyName = "CUSTOMERID"
        Me.colCustomerID.HeaderText = "CustomerID"
        Me.colCustomerID.Name = "colCustomerID"
        Me.colCustomerID.ReadOnly = True
        Me.colCustomerID.Visible = False
        Me.colCustomerID.Width = 87
        '
        'colReportParamId
        '
        Me.colReportParamId.DataPropertyName = "REPORTPARAMID"
        Me.colReportParamId.HeaderText = "REPORTPARAMID"
        Me.colReportParamId.Name = "colReportParamId"
        Me.colReportParamId.ReadOnly = True
        Me.colReportParamId.Visible = False
        '
        'colReportParamDesc
        '
        Me.colReportParamDesc.DataPropertyName = "REPPARAMDESC"
        Me.colReportParamDesc.HeaderText = "REPPARAMDESC"
        Me.colReportParamDesc.Name = "colReportParamDesc"
        Me.colReportParamDesc.ReadOnly = True
        Me.colReportParamDesc.Visible = False
        '
        'frmContractList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1066, 546)
        Me.Controls.Add(Me.cbxCustomer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkNo)
        Me.Controls.Add(Me.chkYes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvContract)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContractList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTicket - Contract"
        CType(Me.CONTRACTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContract, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents CONTRACTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONTRACTTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.CONTRACTTableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvContract As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents CUSTOMERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUSTOMERTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chkNo As System.Windows.Forms.CheckBox
    Friend WithEvents chkYes As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNewItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colContractID As DataGridViewTextBoxColumn
    Friend WithEvents colServiceLineName As DataGridViewTextBoxColumn
    Friend WithEvents colContractNumber As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colDescription As DataGridViewTextBoxColumn
    Friend WithEvents colStartDate As DataGridViewTextBoxColumn
    Friend WithEvents colCompletionDate As DataGridViewTextBoxColumn
    Friend WithEvents colCustomerName As DataGridViewTextBoxColumn
    Friend WithEvents colCurrency As DataGridViewTextBoxColumn
    Friend WithEvents colActive As DataGridViewTextBoxColumn
    Friend WithEvents colSalesAccount As DataGridViewTextBoxColumn
    Friend WithEvents colSalesSubAccount As DataGridViewTextBoxColumn
    Friend WithEvents colGoodsAccount As DataGridViewTextBoxColumn
    Friend WithEvents colGoodsSubAccount As DataGridViewTextBoxColumn
    Friend WithEvents colServiceUtility As DataGridViewTextBoxColumn
    Friend WithEvents colServiceUtilityPerc As DataGridViewTextBoxColumn
    Friend WithEvents colServiceIVAPerc As DataGridViewTextBoxColumn
    Friend WithEvents colMaterialIVAPerc As DataGridViewTextBoxColumn
    Friend WithEvents colPortionCOP As DataGridViewTextBoxColumn
    Friend WithEvents colPortionUSD As DataGridViewTextBoxColumn
    Friend WithEvents colLayoutType As DataGridViewTextBoxColumn
    Friend WithEvents colExchangeRate As DataGridViewTextBoxColumn
    Friend WithEvents colEnableExcRate As DataGridViewTextBoxColumn
    Friend WithEvents colEnableDisc As DataGridViewTextBoxColumn
    Friend WithEvents colSplitAmountMatServ As DataGridViewTextBoxColumn
    Friend WithEvents colServiceLineId As DataGridViewTextBoxColumn
    Friend WithEvents colCustomerID As DataGridViewTextBoxColumn
    Friend WithEvents colReportParamId As DataGridViewTextBoxColumn
    Friend WithEvents colReportParamDesc As DataGridViewTextBoxColumn
End Class
