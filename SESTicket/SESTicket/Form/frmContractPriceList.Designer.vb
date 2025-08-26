<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmContractPriceList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContractPriceList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.CONTRACTPRICELISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTRACTPRICELISTTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.CONTRACTPRICELISTTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager()
        Me.CONTRACTTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.CONTRACTTableAdapter()
        Me.CUSTOMERTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.CUSTOMERTableAdapter()
        Me.dgvContractPriceList = New System.Windows.Forms.DataGridView()
        Me.cbxCustomer = New System.Windows.Forms.ComboBox()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxContract = New System.Windows.Forms.ComboBox()
        Me.CONTRACTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuNewItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImportData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUpdateTicket = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkYes = New System.Windows.Forms.CheckBox()
        Me.chkNo = New System.Windows.Forms.CheckBox()
        Me.colTabGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGroupOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCodeItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colClass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInvClassType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContractPriceListId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContractID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIsHeader = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colExibitOnReport = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colShowCustItemRep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPriceBase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPriceUtility = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPermUpdDescrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPermUpdPriceUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPermNegative = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPriceUnitDecimal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRACTPRICELISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvContractPriceList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRACTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONTRACTPRICELISTBindingSource
        '
        Me.CONTRACTPRICELISTBindingSource.DataMember = "CONTRACTPRICELIST"
        Me.CONTRACTPRICELISTBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'CONTRACTPRICELISTTableAdapter
        '
        Me.CONTRACTPRICELISTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CASINGTableAdapter = Nothing
        Me.TableAdapterManager.CITYTableAdapter = Nothing
        Me.TableAdapterManager.CONTRACTAIUINVENTORYCLASSTableAdapter = Nothing
        Me.TableAdapterManager.CONTRACTPRICELISTTableAdapter = Me.CONTRACTPRICELISTTableAdapter
        Me.TableAdapterManager.CONTRACTTableAdapter = Me.CONTRACTTableAdapter
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
        'CONTRACTTableAdapter
        '
        Me.CONTRACTTableAdapter.ClearBeforeFill = True
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'dgvContractPriceList
        '
        Me.dgvContractPriceList.AllowUserToAddRows = False
        Me.dgvContractPriceList.AllowUserToDeleteRows = False
        Me.dgvContractPriceList.AutoGenerateColumns = False
        Me.dgvContractPriceList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvContractPriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvContractPriceList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTabGroup, Me.colGroupOrder, Me.colCodeItem, Me.colDescription, Me.colUnit, Me.colSalesPrice, Me.colClass, Me.colInvClassType, Me.colActive, Me.colQty, Me.colContractPriceListId, Me.colContractID, Me.colIsHeader, Me.colExibitOnReport, Me.colShowCustItemRep, Me.colPriceBase, Me.colPriceUtility, Me.colPermUpdDescrip, Me.colPermUpdPriceUnit, Me.colPermNegative, Me.colPriceUnitDecimal})
        Me.dgvContractPriceList.DataSource = Me.CONTRACTPRICELISTBindingSource
        Me.dgvContractPriceList.Location = New System.Drawing.Point(0, 45)
        Me.dgvContractPriceList.Name = "dgvContractPriceList"
        Me.dgvContractPriceList.ReadOnly = True
        Me.dgvContractPriceList.RowHeadersWidth = 20
        Me.dgvContractPriceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvContractPriceList.Size = New System.Drawing.Size(1192, 566)
        Me.dgvContractPriceList.TabIndex = 1
        '
        'cbxCustomer
        '
        Me.cbxCustomer.DataSource = Me.CUSTOMERBindingSource
        Me.cbxCustomer.DisplayMember = "NAME"
        Me.cbxCustomer.FormattingEnabled = True
        Me.cbxCustomer.Location = New System.Drawing.Point(483, 12)
        Me.cbxCustomer.Name = "cbxCustomer"
        Me.cbxCustomer.Size = New System.Drawing.Size(265, 21)
        Me.cbxCustomer.TabIndex = 5
        Me.cbxCustomer.ValueMember = "CUSTOMERID"
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(423, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Customer:"
        '
        'cbxContract
        '
        Me.cbxContract.DataSource = Me.CONTRACTBindingSource
        Me.cbxContract.DisplayMember = "CONTRACTNUMBER"
        Me.cbxContract.FormattingEnabled = True
        Me.cbxContract.Location = New System.Drawing.Point(810, 12)
        Me.cbxContract.Name = "cbxContract"
        Me.cbxContract.Size = New System.Drawing.Size(231, 21)
        Me.cbxContract.TabIndex = 7
        Me.cbxContract.ValueMember = "CONTRACTID"
        '
        'CONTRACTBindingSource
        '
        Me.CONTRACTBindingSource.DataMember = "CONTRACT"
        Me.CONTRACTBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(754, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contract:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewItem, Me.mnuExportData, Me.mnuImportData, Me.mnuUpdateTicket})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1198, 42)
        Me.MenuStrip1.TabIndex = 31
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
        'mnuExportData
        '
        Me.mnuExportData.Image = CType(resources.GetObject("mnuExportData.Image"), System.Drawing.Image)
        Me.mnuExportData.Name = "mnuExportData"
        Me.mnuExportData.Size = New System.Drawing.Size(95, 38)
        Me.mnuExportData.Text = "Export Data"
        '
        'mnuImportData
        '
        Me.mnuImportData.Image = CType(resources.GetObject("mnuImportData.Image"), System.Drawing.Image)
        Me.mnuImportData.Name = "mnuImportData"
        Me.mnuImportData.Size = New System.Drawing.Size(98, 38)
        Me.mnuImportData.Text = "Import Data"
        '
        'mnuUpdateTicket
        '
        Me.mnuUpdateTicket.Image = CType(resources.GetObject("mnuUpdateTicket.Image"), System.Drawing.Image)
        Me.mnuUpdateTicket.Name = "mnuUpdateTicket"
        Me.mnuUpdateTicket.Size = New System.Drawing.Size(113, 38)
        Me.mnuUpdateTicket.Text = "Update Tickets"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1047, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Active:"
        '
        'chkYes
        '
        Me.chkYes.AutoSize = True
        Me.chkYes.Checked = True
        Me.chkYes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkYes.Location = New System.Drawing.Point(1093, 14)
        Me.chkYes.Name = "chkYes"
        Me.chkYes.Size = New System.Drawing.Size(44, 17)
        Me.chkYes.TabIndex = 33
        Me.chkYes.Text = "Yes"
        Me.chkYes.UseVisualStyleBackColor = True
        '
        'chkNo
        '
        Me.chkNo.AutoSize = True
        Me.chkNo.Location = New System.Drawing.Point(1143, 14)
        Me.chkNo.Name = "chkNo"
        Me.chkNo.Size = New System.Drawing.Size(40, 17)
        Me.chkNo.TabIndex = 34
        Me.chkNo.Text = "No"
        Me.chkNo.UseVisualStyleBackColor = True
        '
        'colTabGroup
        '
        Me.colTabGroup.DataPropertyName = "TABGROUP"
        Me.colTabGroup.HeaderText = "Tab Group"
        Me.colTabGroup.Name = "colTabGroup"
        Me.colTabGroup.ReadOnly = True
        Me.colTabGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colTabGroup.Width = 85
        '
        'colGroupOrder
        '
        Me.colGroupOrder.DataPropertyName = "GROUPORDER"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colGroupOrder.DefaultCellStyle = DataGridViewCellStyle1
        Me.colGroupOrder.HeaderText = "Order"
        Me.colGroupOrder.Name = "colGroupOrder"
        Me.colGroupOrder.ReadOnly = True
        Me.colGroupOrder.Width = 60
        '
        'colCodeItem
        '
        Me.colCodeItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colCodeItem.DataPropertyName = "CUSTCODEITEM"
        Me.colCodeItem.HeaderText = "Code Item"
        Me.colCodeItem.Name = "colCodeItem"
        Me.colCodeItem.ReadOnly = True
        Me.colCodeItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colCodeItem.Width = 61
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "DESCRIPTION"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDescription.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 520
        '
        'colUnit
        '
        Me.colUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colUnit.DataPropertyName = "UNIT_SALE"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colUnit.DefaultCellStyle = DataGridViewCellStyle3
        Me.colUnit.HeaderText = "Unit"
        Me.colUnit.Name = "colUnit"
        Me.colUnit.ReadOnly = True
        Me.colUnit.Width = 51
        '
        'colSalesPrice
        '
        Me.colSalesPrice.DataPropertyName = "SALES_PRICE"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.NullValue = Nothing
        Me.colSalesPrice.DefaultCellStyle = DataGridViewCellStyle4
        Me.colSalesPrice.HeaderText = "Sales Price"
        Me.colSalesPrice.Name = "colSalesPrice"
        Me.colSalesPrice.ReadOnly = True
        '
        'colClass
        '
        Me.colClass.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colClass.DataPropertyName = "INVENTORYCLASSID"
        Me.colClass.HeaderText = "Class"
        Me.colClass.Name = "colClass"
        Me.colClass.ReadOnly = True
        Me.colClass.Width = 57
        '
        'colInvClassType
        '
        Me.colInvClassType.DataPropertyName = "INVENTORYCLASSTYPE"
        Me.colInvClassType.HeaderText = "Type"
        Me.colInvClassType.Name = "colInvClassType"
        Me.colInvClassType.ReadOnly = True
        Me.colInvClassType.Width = 60
        '
        'colActive
        '
        Me.colActive.DataPropertyName = "ACTIVE"
        Me.colActive.HeaderText = "Active"
        Me.colActive.Name = "colActive"
        Me.colActive.ReadOnly = True
        Me.colActive.Width = 60
        '
        'colQty
        '
        Me.colQty.DataPropertyName = "CONTRACTED_QTY"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "n2"
        Me.colQty.DefaultCellStyle = DataGridViewCellStyle5
        Me.colQty.HeaderText = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.ReadOnly = True
        Me.colQty.Visible = False
        Me.colQty.Width = 50
        '
        'colContractPriceListId
        '
        Me.colContractPriceListId.DataPropertyName = "CONTRACTPRICELISTID"
        Me.colContractPriceListId.HeaderText = "ContractPriceListID"
        Me.colContractPriceListId.Name = "colContractPriceListId"
        Me.colContractPriceListId.ReadOnly = True
        Me.colContractPriceListId.Visible = False
        '
        'colContractID
        '
        Me.colContractID.DataPropertyName = "CONTRACTID"
        Me.colContractID.HeaderText = "ContractID"
        Me.colContractID.Name = "colContractID"
        Me.colContractID.ReadOnly = True
        Me.colContractID.Visible = False
        '
        'colIsHeader
        '
        Me.colIsHeader.DataPropertyName = "ISHEADER"
        Me.colIsHeader.HeaderText = "ISHEADER"
        Me.colIsHeader.Name = "colIsHeader"
        Me.colIsHeader.ReadOnly = True
        Me.colIsHeader.Visible = False
        '
        'colExibitOnReport
        '
        Me.colExibitOnReport.DataPropertyName = "EXIBITONREPORT"
        Me.colExibitOnReport.HeaderText = "EXIBITONREPORT"
        Me.colExibitOnReport.Name = "colExibitOnReport"
        Me.colExibitOnReport.ReadOnly = True
        Me.colExibitOnReport.Visible = False
        '
        'colShowCustItemRep
        '
        Me.colShowCustItemRep.DataPropertyName = "SHOWCUSTITEMREPORT"
        Me.colShowCustItemRep.HeaderText = "SHOWCUSTITEMREPORT"
        Me.colShowCustItemRep.Name = "colShowCustItemRep"
        Me.colShowCustItemRep.ReadOnly = True
        Me.colShowCustItemRep.Visible = False
        '
        'colPriceBase
        '
        Me.colPriceBase.DataPropertyName = "PRICEBASE"
        Me.colPriceBase.HeaderText = "PRICEBASE"
        Me.colPriceBase.Name = "colPriceBase"
        Me.colPriceBase.ReadOnly = True
        Me.colPriceBase.Visible = False
        '
        'colPriceUtility
        '
        Me.colPriceUtility.DataPropertyName = "PRICEUTILITY"
        Me.colPriceUtility.HeaderText = "PRICEUTILITY"
        Me.colPriceUtility.Name = "colPriceUtility"
        Me.colPriceUtility.ReadOnly = True
        Me.colPriceUtility.Visible = False
        '
        'colPermUpdDescrip
        '
        Me.colPermUpdDescrip.DataPropertyName = "PERMITUPDATEDESCRIP"
        Me.colPermUpdDescrip.HeaderText = "PERMITUPDATEDESCRIP"
        Me.colPermUpdDescrip.Name = "colPermUpdDescrip"
        Me.colPermUpdDescrip.ReadOnly = True
        Me.colPermUpdDescrip.Visible = False
        '
        'colPermUpdPriceUnit
        '
        Me.colPermUpdPriceUnit.DataPropertyName = "PERMITUPDATEPRICEUNIT"
        Me.colPermUpdPriceUnit.HeaderText = "PERMITUPDATEPRICEUNIT"
        Me.colPermUpdPriceUnit.Name = "colPermUpdPriceUnit"
        Me.colPermUpdPriceUnit.ReadOnly = True
        Me.colPermUpdPriceUnit.Visible = False
        '
        'colPermNegative
        '
        Me.colPermNegative.DataPropertyName = "PERMITNEGATIVE"
        Me.colPermNegative.HeaderText = "PERMITNEGATIVE"
        Me.colPermNegative.Name = "colPermNegative"
        Me.colPermNegative.ReadOnly = True
        Me.colPermNegative.Visible = False
        '
        'colPriceUnitDecimal
        '
        Me.colPriceUnitDecimal.DataPropertyName = "PRICEUNITDECIMAL"
        Me.colPriceUnitDecimal.HeaderText = "PRICEUNITDECIMAL"
        Me.colPriceUnitDecimal.Name = "colPriceUnitDecimal"
        Me.colPriceUnitDecimal.ReadOnly = True
        Me.colPriceUnitDecimal.Visible = False
        '
        'frmContractPriceList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1198, 612)
        Me.Controls.Add(Me.chkNo)
        Me.Controls.Add(Me.chkYes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxContract)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxCustomer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvContractPriceList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContractPriceList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTicket - Contract Price List"
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRACTPRICELISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvContractPriceList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRACTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents CONTRACTPRICELISTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONTRACTPRICELISTTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.CONTRACTPRICELISTTableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvContractPriceList As System.Windows.Forms.DataGridView
    Friend WithEvents cbxCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxContract As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CUSTOMERTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents CUSTOMERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONTRACTTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.CONTRACTTableAdapter
    Friend WithEvents CONTRACTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNewItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuImportData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkYes As System.Windows.Forms.CheckBox
    Friend WithEvents chkNo As System.Windows.Forms.CheckBox
    Friend WithEvents mnuExportData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUpdateTicket As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colTabGroup As DataGridViewTextBoxColumn
    Friend WithEvents colGroupOrder As DataGridViewTextBoxColumn
    Friend WithEvents colCodeItem As DataGridViewTextBoxColumn
    Friend WithEvents colDescription As DataGridViewTextBoxColumn
    Friend WithEvents colUnit As DataGridViewTextBoxColumn
    Friend WithEvents colSalesPrice As DataGridViewTextBoxColumn
    Friend WithEvents colClass As DataGridViewTextBoxColumn
    Friend WithEvents colInvClassType As DataGridViewTextBoxColumn
    Friend WithEvents colActive As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colContractPriceListId As DataGridViewTextBoxColumn
    Friend WithEvents colContractID As DataGridViewTextBoxColumn
    Friend WithEvents colIsHeader As DataGridViewTextBoxColumn
    Friend WithEvents colExibitOnReport As DataGridViewTextBoxColumn
    Friend WithEvents colShowCustItemRep As DataGridViewTextBoxColumn
    Friend WithEvents colPriceBase As DataGridViewTextBoxColumn
    Friend WithEvents colPriceUtility As DataGridViewTextBoxColumn
    Friend WithEvents colPermUpdDescrip As DataGridViewTextBoxColumn
    Friend WithEvents colPermUpdPriceUnit As DataGridViewTextBoxColumn
    Friend WithEvents colPermNegative As DataGridViewTextBoxColumn
    Friend WithEvents colPriceUnitDecimal As DataGridViewTextBoxColumn
End Class
