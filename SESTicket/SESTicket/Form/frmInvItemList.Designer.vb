<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvItemList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvItemList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvInvItem = New System.Windows.Forms.DataGridView()
        Me.colInventoryItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAbbreviation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVendor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBrand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInventoryClassID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLastCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAverageCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBuyerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colListPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDefaultSiteID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStorageUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDefaultSalesUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDefaultPurchaseUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCostOfGoodsAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCostOfGoodsSubAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesAccountAIU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesAccountUBR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesAccountUBRAIU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesSubAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInventoryAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInventorySubAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMinOnHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMaxOnHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVendorId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVENTORYITEMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.chkNo = New System.Windows.Forms.CheckBox()
        Me.chkYes = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuNewItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImportData = New System.Windows.Forms.ToolStripMenuItem()
        Me.INVENTORYITEMTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.INVENTORYITEMTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager()
        CType(Me.dgvInvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTORYITEMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvInvItem
        '
        Me.dgvInvItem.AllowUserToAddRows = False
        Me.dgvInvItem.AllowUserToDeleteRows = False
        Me.dgvInvItem.AutoGenerateColumns = False
        Me.dgvInvItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvInvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colInventoryItemID, Me.colAbbreviation, Me.colDescription, Me.colVendor, Me.colBrand, Me.colInventoryClassID, Me.colLastCost, Me.colAverageCost, Me.colActive, Me.colBuyerID, Me.colListPrice, Me.colDefaultSiteID, Me.colStorageUnit, Me.colDefaultSalesUnit, Me.colDefaultPurchaseUnit, Me.colCostOfGoodsAccount, Me.colCostOfGoodsSubAccount, Me.colSalesAccountAIU, Me.colSalesAccount, Me.colSalesAccountUBR, Me.colSalesAccountUBRAIU, Me.colSalesSubAccount, Me.colInventoryAccount, Me.colInventorySubAccount, Me.colMinOnHand, Me.colMaxOnHand, Me.colVendorId})
        Me.dgvInvItem.DataSource = Me.INVENTORYITEMBindingSource
        resources.ApplyResources(Me.dgvInvItem, "dgvInvItem")
        Me.dgvInvItem.Name = "dgvInvItem"
        Me.dgvInvItem.ReadOnly = True
        Me.dgvInvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvItem.ShowCellErrors = False
        Me.dgvInvItem.ShowRowErrors = False
        '
        'colInventoryItemID
        '
        Me.colInventoryItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colInventoryItemID.DataPropertyName = "INVENTORYITEMID"
        resources.ApplyResources(Me.colInventoryItemID, "colInventoryItemID")
        Me.colInventoryItemID.Name = "colInventoryItemID"
        Me.colInventoryItemID.ReadOnly = True
        '
        'colAbbreviation
        '
        Me.colAbbreviation.DataPropertyName = "ABBREVIATION"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colAbbreviation.DefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.colAbbreviation, "colAbbreviation")
        Me.colAbbreviation.Name = "colAbbreviation"
        Me.colAbbreviation.ReadOnly = True
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "DESCRIPTION"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDescription.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.colDescription, "colDescription")
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        '
        'colVendor
        '
        Me.colVendor.DataPropertyName = "VENDOR"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colVendor.DefaultCellStyle = DataGridViewCellStyle3
        resources.ApplyResources(Me.colVendor, "colVendor")
        Me.colVendor.Name = "colVendor"
        Me.colVendor.ReadOnly = True
        '
        'colBrand
        '
        Me.colBrand.DataPropertyName = "BRAND"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colBrand.DefaultCellStyle = DataGridViewCellStyle4
        resources.ApplyResources(Me.colBrand, "colBrand")
        Me.colBrand.Name = "colBrand"
        Me.colBrand.ReadOnly = True
        '
        'colInventoryClassID
        '
        Me.colInventoryClassID.DataPropertyName = "INVENTORYCLASSID"
        Me.colInventoryClassID.FillWeight = 60.0!
        resources.ApplyResources(Me.colInventoryClassID, "colInventoryClassID")
        Me.colInventoryClassID.Name = "colInventoryClassID"
        Me.colInventoryClassID.ReadOnly = True
        '
        'colLastCost
        '
        Me.colLastCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colLastCost.DataPropertyName = "LASTCOST"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.colLastCost.DefaultCellStyle = DataGridViewCellStyle5
        resources.ApplyResources(Me.colLastCost, "colLastCost")
        Me.colLastCost.Name = "colLastCost"
        Me.colLastCost.ReadOnly = True
        '
        'colAverageCost
        '
        Me.colAverageCost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colAverageCost.DataPropertyName = "AVERAGECOST"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.colAverageCost.DefaultCellStyle = DataGridViewCellStyle6
        resources.ApplyResources(Me.colAverageCost, "colAverageCost")
        Me.colAverageCost.Name = "colAverageCost"
        Me.colAverageCost.ReadOnly = True
        '
        'colActive
        '
        Me.colActive.DataPropertyName = "ACTIVE"
        resources.ApplyResources(Me.colActive, "colActive")
        Me.colActive.Name = "colActive"
        Me.colActive.ReadOnly = True
        '
        'colBuyerID
        '
        Me.colBuyerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colBuyerID.DataPropertyName = "BUYERID"
        resources.ApplyResources(Me.colBuyerID, "colBuyerID")
        Me.colBuyerID.Name = "colBuyerID"
        Me.colBuyerID.ReadOnly = True
        '
        'colListPrice
        '
        Me.colListPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colListPrice.DataPropertyName = "LISTPRICE"
        resources.ApplyResources(Me.colListPrice, "colListPrice")
        Me.colListPrice.Name = "colListPrice"
        Me.colListPrice.ReadOnly = True
        '
        'colDefaultSiteID
        '
        Me.colDefaultSiteID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDefaultSiteID.DataPropertyName = "DEFAULTSITEID"
        resources.ApplyResources(Me.colDefaultSiteID, "colDefaultSiteID")
        Me.colDefaultSiteID.Name = "colDefaultSiteID"
        Me.colDefaultSiteID.ReadOnly = True
        '
        'colStorageUnit
        '
        Me.colStorageUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colStorageUnit.DataPropertyName = "STORAGEUNIT"
        resources.ApplyResources(Me.colStorageUnit, "colStorageUnit")
        Me.colStorageUnit.Name = "colStorageUnit"
        Me.colStorageUnit.ReadOnly = True
        '
        'colDefaultSalesUnit
        '
        Me.colDefaultSalesUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDefaultSalesUnit.DataPropertyName = "DEFAULTSALESUNIT"
        resources.ApplyResources(Me.colDefaultSalesUnit, "colDefaultSalesUnit")
        Me.colDefaultSalesUnit.Name = "colDefaultSalesUnit"
        Me.colDefaultSalesUnit.ReadOnly = True
        '
        'colDefaultPurchaseUnit
        '
        Me.colDefaultPurchaseUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDefaultPurchaseUnit.DataPropertyName = "DEFAULTPURCHASEUNIT"
        resources.ApplyResources(Me.colDefaultPurchaseUnit, "colDefaultPurchaseUnit")
        Me.colDefaultPurchaseUnit.Name = "colDefaultPurchaseUnit"
        Me.colDefaultPurchaseUnit.ReadOnly = True
        '
        'colCostOfGoodsAccount
        '
        Me.colCostOfGoodsAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCostOfGoodsAccount.DataPropertyName = "COSTOFGOODSACCOUNT"
        resources.ApplyResources(Me.colCostOfGoodsAccount, "colCostOfGoodsAccount")
        Me.colCostOfGoodsAccount.Name = "colCostOfGoodsAccount"
        Me.colCostOfGoodsAccount.ReadOnly = True
        '
        'colCostOfGoodsSubAccount
        '
        Me.colCostOfGoodsSubAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCostOfGoodsSubAccount.DataPropertyName = "COSTOFGOODSSUBACCOUNT"
        resources.ApplyResources(Me.colCostOfGoodsSubAccount, "colCostOfGoodsSubAccount")
        Me.colCostOfGoodsSubAccount.Name = "colCostOfGoodsSubAccount"
        Me.colCostOfGoodsSubAccount.ReadOnly = True
        '
        'colSalesAccountAIU
        '
        Me.colSalesAccountAIU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesAccountAIU.DataPropertyName = "SALESACCOUNTAIU"
        resources.ApplyResources(Me.colSalesAccountAIU, "colSalesAccountAIU")
        Me.colSalesAccountAIU.Name = "colSalesAccountAIU"
        Me.colSalesAccountAIU.ReadOnly = True
        '
        'colSalesAccount
        '
        Me.colSalesAccount.DataPropertyName = "SALESACCOUNT"
        resources.ApplyResources(Me.colSalesAccount, "colSalesAccount")
        Me.colSalesAccount.Name = "colSalesAccount"
        Me.colSalesAccount.ReadOnly = True
        '
        'colSalesAccountUBR
        '
        Me.colSalesAccountUBR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesAccountUBR.DataPropertyName = "SALESACCOUNTUBR"
        resources.ApplyResources(Me.colSalesAccountUBR, "colSalesAccountUBR")
        Me.colSalesAccountUBR.Name = "colSalesAccountUBR"
        Me.colSalesAccountUBR.ReadOnly = True
        '
        'colSalesAccountUBRAIU
        '
        Me.colSalesAccountUBRAIU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesAccountUBRAIU.DataPropertyName = "SALESACCOUNTUBRAIU"
        resources.ApplyResources(Me.colSalesAccountUBRAIU, "colSalesAccountUBRAIU")
        Me.colSalesAccountUBRAIU.Name = "colSalesAccountUBRAIU"
        Me.colSalesAccountUBRAIU.ReadOnly = True
        '
        'colSalesSubAccount
        '
        Me.colSalesSubAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesSubAccount.DataPropertyName = "SALESSUBACCOUNT"
        resources.ApplyResources(Me.colSalesSubAccount, "colSalesSubAccount")
        Me.colSalesSubAccount.Name = "colSalesSubAccount"
        Me.colSalesSubAccount.ReadOnly = True
        '
        'colInventoryAccount
        '
        Me.colInventoryAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colInventoryAccount.DataPropertyName = "INVENTORYACCOUNT"
        resources.ApplyResources(Me.colInventoryAccount, "colInventoryAccount")
        Me.colInventoryAccount.Name = "colInventoryAccount"
        Me.colInventoryAccount.ReadOnly = True
        '
        'colInventorySubAccount
        '
        Me.colInventorySubAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colInventorySubAccount.DataPropertyName = "INVENTORYSUBACCOUNT"
        resources.ApplyResources(Me.colInventorySubAccount, "colInventorySubAccount")
        Me.colInventorySubAccount.Name = "colInventorySubAccount"
        Me.colInventorySubAccount.ReadOnly = True
        '
        'colMinOnHand
        '
        Me.colMinOnHand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colMinOnHand.DataPropertyName = "MINONHAND"
        resources.ApplyResources(Me.colMinOnHand, "colMinOnHand")
        Me.colMinOnHand.Name = "colMinOnHand"
        Me.colMinOnHand.ReadOnly = True
        '
        'colMaxOnHand
        '
        Me.colMaxOnHand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colMaxOnHand.DataPropertyName = "MAXONHAND"
        resources.ApplyResources(Me.colMaxOnHand, "colMaxOnHand")
        Me.colMaxOnHand.Name = "colMaxOnHand"
        Me.colMaxOnHand.ReadOnly = True
        '
        'colVendorId
        '
        Me.colVendorId.DataPropertyName = "VENDORID"
        resources.ApplyResources(Me.colVendorId, "colVendorId")
        Me.colVendorId.Name = "colVendorId"
        Me.colVendorId.ReadOnly = True
        '
        'INVENTORYITEMBindingSource
        '
        Me.INVENTORYITEMBindingSource.DataMember = "INVENTORYITEM"
        Me.INVENTORYITEMBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chkNo
        '
        resources.ApplyResources(Me.chkNo, "chkNo")
        Me.chkNo.Name = "chkNo"
        Me.chkNo.UseVisualStyleBackColor = True
        '
        'chkYes
        '
        resources.ApplyResources(Me.chkYes, "chkYes")
        Me.chkYes.Checked = True
        Me.chkYes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkYes.Name = "chkYes"
        Me.chkYes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewItem, Me.mnuExportData, Me.mnuImportData})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'mnuNewItem
        '
        resources.ApplyResources(Me.mnuNewItem, "mnuNewItem")
        Me.mnuNewItem.Name = "mnuNewItem"
        '
        'mnuExportData
        '
        resources.ApplyResources(Me.mnuExportData, "mnuExportData")
        Me.mnuExportData.Name = "mnuExportData"
        '
        'mnuImportData
        '
        resources.ApplyResources(Me.mnuImportData, "mnuImportData")
        Me.mnuImportData.Name = "mnuImportData"
        '
        'INVENTORYITEMTableAdapter
        '
        Me.INVENTORYITEMTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CASINGTableAdapter = Nothing
        Me.TableAdapterManager.CITYTableAdapter = Nothing
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
        Me.TableAdapterManager.INVENTORYITEMTableAdapter = Me.INVENTORYITEMTableAdapter
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
        'frmInvItemList
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkNo)
        Me.Controls.Add(Me.chkYes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvInvItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvItemList"
        CType(Me.dgvInvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTORYITEMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents INVENTORYITEMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INVENTORYITEMTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.INVENTORYITEMTableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvInvItem As System.Windows.Forms.DataGridView
    Friend WithEvents chkNo As System.Windows.Forms.CheckBox
    Friend WithEvents chkYes As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNewItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuImportData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colInventoryItemID As DataGridViewTextBoxColumn
    Friend WithEvents colAbbreviation As DataGridViewTextBoxColumn
    Friend WithEvents colDescription As DataGridViewTextBoxColumn
    Friend WithEvents colVendor As DataGridViewTextBoxColumn
    Friend WithEvents colBrand As DataGridViewTextBoxColumn
    Friend WithEvents colInventoryClassID As DataGridViewTextBoxColumn
    Friend WithEvents colLastCost As DataGridViewTextBoxColumn
    Friend WithEvents colAverageCost As DataGridViewTextBoxColumn
    Friend WithEvents colActive As DataGridViewTextBoxColumn
    Friend WithEvents colBuyerID As DataGridViewTextBoxColumn
    Friend WithEvents colListPrice As DataGridViewTextBoxColumn
    Friend WithEvents colDefaultSiteID As DataGridViewTextBoxColumn
    Friend WithEvents colStorageUnit As DataGridViewTextBoxColumn
    Friend WithEvents colDefaultSalesUnit As DataGridViewTextBoxColumn
    Friend WithEvents colDefaultPurchaseUnit As DataGridViewTextBoxColumn
    Friend WithEvents colCostOfGoodsAccount As DataGridViewTextBoxColumn
    Friend WithEvents colCostOfGoodsSubAccount As DataGridViewTextBoxColumn
    Friend WithEvents colSalesAccountAIU As DataGridViewTextBoxColumn
    Friend WithEvents colSalesAccount As DataGridViewTextBoxColumn
    Friend WithEvents colSalesAccountUBR As DataGridViewTextBoxColumn
    Friend WithEvents colSalesAccountUBRAIU As DataGridViewTextBoxColumn
    Friend WithEvents colSalesSubAccount As DataGridViewTextBoxColumn
    Friend WithEvents colInventoryAccount As DataGridViewTextBoxColumn
    Friend WithEvents colInventorySubAccount As DataGridViewTextBoxColumn
    Friend WithEvents colMinOnHand As DataGridViewTextBoxColumn
    Friend WithEvents colMaxOnHand As DataGridViewTextBoxColumn
    Friend WithEvents colVendorId As DataGridViewTextBoxColumn
End Class
