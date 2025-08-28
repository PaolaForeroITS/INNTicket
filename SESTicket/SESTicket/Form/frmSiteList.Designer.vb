<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSiteList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSiteList))
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.SITESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SITESTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.SITESTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager()
        Me.dgvSite = New System.Windows.Forms.DataGridView()
        Me.colSiteID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAlias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAttention = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCountry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoodsAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGoodsSubAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesSubAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInventoryAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInventorySubAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuNewItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SITESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SITESBindingSource
        '
        Me.SITESBindingSource.DataMember = "SITES"
        Me.SITESBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SITESTableAdapter
        '
        Me.SITESTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.INVENTORYITEMTableAdapter = Nothing
        Me.TableAdapterManager.INVENTORYUNITTableAdapter = Nothing
        Me.TableAdapterManager.PETRFIELDTableAdapter = Nothing
        Me.TableAdapterManager.RIGTableAdapter = Nothing
        Me.TableAdapterManager.SERVICELINETableAdapter = Nothing
        Me.TableAdapterManager.SERVICETYPETableAdapter = Nothing
        Me.TableAdapterManager.SITESTableAdapter = Me.SITESTableAdapter
        Me.TableAdapterManager.STATETableAdapter = Nothing
        Me.TableAdapterManager.TICKETINVOICELINETableAdapter = Nothing
        Me.TableAdapterManager.TUBINGTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Nothing
        Me.TableAdapterManager.WELLTableAdapter = Nothing
        Me.TableAdapterManager.WORKERTableAdapter = Nothing
        '
        'dgvSite
        '
        Me.dgvSite.AllowUserToAddRows = False
        Me.dgvSite.AllowUserToDeleteRows = False
        Me.dgvSite.AutoGenerateColumns = False
        Me.dgvSite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSite.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSiteID, Me.colAlias, Me.colName, Me.colDescription, Me.colAddress, Me.colAttention, Me.colCountry, Me.colState, Me.colCity, Me.colPhone, Me.colFax, Me.colEmail, Me.colGoodsAccount, Me.colGoodsSubAccount, Me.colSalesAccount, Me.colSalesSubAccount, Me.colInventoryAccount, Me.colInventorySubAccount})
        Me.dgvSite.DataSource = Me.SITESBindingSource
        Me.dgvSite.Location = New System.Drawing.Point(0, 55)
        Me.dgvSite.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvSite.Name = "dgvSite"
        Me.dgvSite.ReadOnly = True
        Me.dgvSite.RowHeadersWidth = 51
        Me.dgvSite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSite.Size = New System.Drawing.Size(1153, 295)
        Me.dgvSite.TabIndex = 1
        '
        'colSiteID
        '
        Me.colSiteID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSiteID.DataPropertyName = "SITEID"
        Me.colSiteID.HeaderText = "ID"
        Me.colSiteID.MinimumWidth = 6
        Me.colSiteID.Name = "colSiteID"
        Me.colSiteID.ReadOnly = True
        Me.colSiteID.Width = 49
        '
        'colAlias
        '
        Me.colAlias.DataPropertyName = "ALIAS"
        Me.colAlias.HeaderText = "Alias"
        Me.colAlias.MinimumWidth = 6
        Me.colAlias.Name = "colAlias"
        Me.colAlias.ReadOnly = True
        Me.colAlias.Width = 45
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colName.DataPropertyName = "NAME"
        Me.colName.HeaderText = "Name"
        Me.colName.MinimumWidth = 6
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Width = 73
        '
        'colDescription
        '
        Me.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDescription.DataPropertyName = "DESCRIPTION"
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.MinimumWidth = 6
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 104
        '
        'colAddress
        '
        Me.colAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colAddress.DataPropertyName = "ADDRESS"
        Me.colAddress.HeaderText = "Address"
        Me.colAddress.MinimumWidth = 6
        Me.colAddress.Name = "colAddress"
        Me.colAddress.ReadOnly = True
        Me.colAddress.Width = 87
        '
        'colAttention
        '
        Me.colAttention.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colAttention.DataPropertyName = "ATENTION"
        Me.colAttention.HeaderText = "Attention"
        Me.colAttention.MinimumWidth = 6
        Me.colAttention.Name = "colAttention"
        Me.colAttention.ReadOnly = True
        Me.colAttention.Width = 87
        '
        'colCountry
        '
        Me.colCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCountry.DataPropertyName = "COUNTRY"
        Me.colCountry.HeaderText = "Country"
        Me.colCountry.MinimumWidth = 6
        Me.colCountry.Name = "colCountry"
        Me.colCountry.ReadOnly = True
        Me.colCountry.Width = 81
        '
        'colState
        '
        Me.colState.DataPropertyName = "STATE"
        Me.colState.HeaderText = "State"
        Me.colState.MinimumWidth = 6
        Me.colState.Name = "colState"
        Me.colState.ReadOnly = True
        Me.colState.Width = 125
        '
        'colCity
        '
        Me.colCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCity.DataPropertyName = "CITY"
        Me.colCity.HeaderText = "City"
        Me.colCity.MinimumWidth = 6
        Me.colCity.Name = "colCity"
        Me.colCity.ReadOnly = True
        Me.colCity.Width = 58
        '
        'colPhone
        '
        Me.colPhone.DataPropertyName = "PHONE"
        Me.colPhone.HeaderText = "Phone"
        Me.colPhone.MinimumWidth = 6
        Me.colPhone.Name = "colPhone"
        Me.colPhone.ReadOnly = True
        Me.colPhone.Visible = False
        Me.colPhone.Width = 125
        '
        'colFax
        '
        Me.colFax.DataPropertyName = "FAX"
        Me.colFax.HeaderText = "Fax"
        Me.colFax.MinimumWidth = 6
        Me.colFax.Name = "colFax"
        Me.colFax.ReadOnly = True
        Me.colFax.Visible = False
        Me.colFax.Width = 125
        '
        'colEmail
        '
        Me.colEmail.DataPropertyName = "EMAIL"
        Me.colEmail.HeaderText = "Email"
        Me.colEmail.MinimumWidth = 6
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.Visible = False
        Me.colEmail.Width = 125
        '
        'colGoodsAccount
        '
        Me.colGoodsAccount.DataPropertyName = "COSTOFGOODSACCOUNT"
        Me.colGoodsAccount.HeaderText = "GoodsAccount"
        Me.colGoodsAccount.MinimumWidth = 6
        Me.colGoodsAccount.Name = "colGoodsAccount"
        Me.colGoodsAccount.ReadOnly = True
        Me.colGoodsAccount.Visible = False
        Me.colGoodsAccount.Width = 125
        '
        'colGoodsSubAccount
        '
        Me.colGoodsSubAccount.DataPropertyName = "COSTOFGOODSSUBACCOUNT"
        Me.colGoodsSubAccount.HeaderText = "GoodsSubAccount"
        Me.colGoodsSubAccount.MinimumWidth = 6
        Me.colGoodsSubAccount.Name = "colGoodsSubAccount"
        Me.colGoodsSubAccount.ReadOnly = True
        Me.colGoodsSubAccount.Visible = False
        Me.colGoodsSubAccount.Width = 125
        '
        'colSalesAccount
        '
        Me.colSalesAccount.DataPropertyName = "SALESACCOUNT"
        Me.colSalesAccount.HeaderText = "SalesAccount"
        Me.colSalesAccount.MinimumWidth = 6
        Me.colSalesAccount.Name = "colSalesAccount"
        Me.colSalesAccount.ReadOnly = True
        Me.colSalesAccount.Visible = False
        Me.colSalesAccount.Width = 125
        '
        'colSalesSubAccount
        '
        Me.colSalesSubAccount.DataPropertyName = "SALESSUBACCOUNT"
        Me.colSalesSubAccount.HeaderText = "SalesSubAccount"
        Me.colSalesSubAccount.MinimumWidth = 6
        Me.colSalesSubAccount.Name = "colSalesSubAccount"
        Me.colSalesSubAccount.ReadOnly = True
        Me.colSalesSubAccount.Visible = False
        Me.colSalesSubAccount.Width = 125
        '
        'colInventoryAccount
        '
        Me.colInventoryAccount.DataPropertyName = "INVENTORYACCOUNT"
        Me.colInventoryAccount.HeaderText = "InventoryAccount"
        Me.colInventoryAccount.MinimumWidth = 6
        Me.colInventoryAccount.Name = "colInventoryAccount"
        Me.colInventoryAccount.ReadOnly = True
        Me.colInventoryAccount.Visible = False
        Me.colInventoryAccount.Width = 125
        '
        'colInventorySubAccount
        '
        Me.colInventorySubAccount.DataPropertyName = "INVENTORYSUBACCOUNT"
        Me.colInventorySubAccount.HeaderText = "InventorySubAccount"
        Me.colInventorySubAccount.MinimumWidth = 6
        Me.colInventorySubAccount.Name = "colInventorySubAccount"
        Me.colInventorySubAccount.ReadOnly = True
        Me.colInventorySubAccount.Visible = False
        Me.colInventorySubAccount.Width = 125
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1160, 52)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuNewItem
        '
        Me.mnuNewItem.Image = CType(resources.GetObject("mnuNewItem.Image"), System.Drawing.Image)
        Me.mnuNewItem.Name = "mnuNewItem"
        Me.mnuNewItem.Size = New System.Drawing.Size(107, 48)
        Me.mnuNewItem.Text = "New Item"
        Me.mnuNewItem.ToolTipText = "Save the Ticket"
        '
        'frmSiteList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1160, 353)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvSite)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSiteList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INNTicket - Sites"
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SITESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents SITESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SITESTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.SITESTableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvSite As System.Windows.Forms.DataGridView
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNewItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colSiteID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAlias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAttention As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCountry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGoodsAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGoodsSubAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSalesAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSalesSubAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInventoryAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInventorySubAccount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
