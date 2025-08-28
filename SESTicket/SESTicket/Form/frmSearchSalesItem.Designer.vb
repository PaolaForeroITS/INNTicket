<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchSalesItem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchSalesItem))
        Me.dgvSalesItemSearch = New System.Windows.Forms.DataGridView()
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTabGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCustCodeItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUnitSale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colContractPriceList = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIsHeader = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPriceUnitDecimal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTRACTPRICELISTTMPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cbxSearch = New System.Windows.Forms.ComboBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkMaterial = New System.Windows.Forms.CheckBox()
        Me.chkService = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager()
        Me.CONTRACTPRICELISTTMPTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.CONTRACTPRICELISTTMPTableAdapter()
        CType(Me.dgvSalesItemSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRACTPRICELISTTMPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvSalesItemSearch
        '
        Me.dgvSalesItemSearch.AllowUserToAddRows = False
        Me.dgvSalesItemSearch.AllowUserToDeleteRows = False
        Me.dgvSalesItemSearch.AutoGenerateColumns = False
        Me.dgvSalesItemSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSalesItemSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesItemSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colType, Me.colTabGroup, Me.colCustCodeItem, Me.colDescription, Me.colSalesPrice, Me.colUnitSale, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.colContractPriceList, Me.DataGridViewTextBoxColumn2, Me.colIsHeader, Me.colPriceUnitDecimal})
        Me.dgvSalesItemSearch.DataSource = Me.CONTRACTPRICELISTTMPBindingSource
        Me.dgvSalesItemSearch.Location = New System.Drawing.Point(11, 80)
        Me.dgvSalesItemSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvSalesItemSearch.MultiSelect = False
        Me.dgvSalesItemSearch.Name = "dgvSalesItemSearch"
        Me.dgvSalesItemSearch.ReadOnly = True
        Me.dgvSalesItemSearch.RowHeadersWidth = 51
        Me.dgvSalesItemSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalesItemSearch.Size = New System.Drawing.Size(1543, 591)
        Me.dgvSalesItemSearch.TabIndex = 1
        '
        'colType
        '
        Me.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colType.DataPropertyName = "TYPE"
        Me.colType.HeaderText = "Type"
        Me.colType.MinimumWidth = 6
        Me.colType.Name = "colType"
        Me.colType.ReadOnly = True
        Me.colType.Width = 68
        '
        'colTabGroup
        '
        Me.colTabGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTabGroup.DataPropertyName = "TABGROUP"
        Me.colTabGroup.HeaderText = "Group"
        Me.colTabGroup.MinimumWidth = 6
        Me.colTabGroup.Name = "colTabGroup"
        Me.colTabGroup.ReadOnly = True
        Me.colTabGroup.Width = 73
        '
        'colCustCodeItem
        '
        Me.colCustCodeItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCustCodeItem.DataPropertyName = "CUSTCODEITEM"
        Me.colCustCodeItem.HeaderText = "Item"
        Me.colCustCodeItem.MinimumWidth = 6
        Me.colCustCodeItem.Name = "colCustCodeItem"
        Me.colCustCodeItem.ReadOnly = True
        Me.colCustCodeItem.Width = 61
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "DESCRIPTION"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDescription.DefaultCellStyle = DataGridViewCellStyle1
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.MinimumWidth = 6
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 560
        '
        'colSalesPrice
        '
        Me.colSalesPrice.DataPropertyName = "SALES_PRICE"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colSalesPrice.DefaultCellStyle = DataGridViewCellStyle2
        Me.colSalesPrice.HeaderText = "Sales Price"
        Me.colSalesPrice.MinimumWidth = 6
        Me.colSalesPrice.Name = "colSalesPrice"
        Me.colSalesPrice.ReadOnly = True
        Me.colSalesPrice.Width = 125
        '
        'colUnitSale
        '
        Me.colUnitSale.DataPropertyName = "UNIT_SALE"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colUnitSale.DefaultCellStyle = DataGridViewCellStyle3
        Me.colUnitSale.HeaderText = "Unit"
        Me.colUnitSale.MinimumWidth = 6
        Me.colUnitSale.Name = "colUnitSale"
        Me.colUnitSale.ReadOnly = True
        Me.colUnitSale.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "INVENTORYCLASSID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "INVENTORYCLASSID"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CONTRACTED_QTY"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CONTRACTED_QTY"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'colContractPriceList
        '
        Me.colContractPriceList.DataPropertyName = "CONTRACTPRICELISTID"
        Me.colContractPriceList.HeaderText = "CONTRACTPRICELISTID"
        Me.colContractPriceList.MinimumWidth = 6
        Me.colContractPriceList.Name = "colContractPriceList"
        Me.colContractPriceList.ReadOnly = True
        Me.colContractPriceList.Visible = False
        Me.colContractPriceList.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CONTRACTID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CONTRACTID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'colIsHeader
        '
        Me.colIsHeader.DataPropertyName = "ISHEADER"
        Me.colIsHeader.HeaderText = "ISHEADER"
        Me.colIsHeader.MinimumWidth = 6
        Me.colIsHeader.Name = "colIsHeader"
        Me.colIsHeader.ReadOnly = True
        Me.colIsHeader.Visible = False
        Me.colIsHeader.Width = 125
        '
        'colPriceUnitDecimal
        '
        Me.colPriceUnitDecimal.DataPropertyName = "PRICEUNITDECIMAL"
        Me.colPriceUnitDecimal.HeaderText = "PRICEUNITDECIMAL"
        Me.colPriceUnitDecimal.MinimumWidth = 6
        Me.colPriceUnitDecimal.Name = "colPriceUnitDecimal"
        Me.colPriceUnitDecimal.ReadOnly = True
        Me.colPriceUnitDecimal.Visible = False
        Me.colPriceUnitDecimal.Width = 125
        '
        'CONTRACTPRICELISTTMPBindingSource
        '
        Me.CONTRACTPRICELISTTMPBindingSource.DataMember = "CONTRACTPRICELISTTMP"
        Me.CONTRACTPRICELISTTMPBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search by:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(221, 22)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(292, 22)
        Me.txtSearch.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(880, 22)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 28)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Ok"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cbxSearch
        '
        Me.cbxSearch.FormattingEnabled = True
        Me.cbxSearch.Items.AddRange(New Object() {"Group", "Item", "Description"})
        Me.cbxSearch.Location = New System.Drawing.Point(103, 21)
        Me.cbxSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxSearch.Name = "cbxSearch"
        Me.cbxSearch.Size = New System.Drawing.Size(109, 24)
        Me.cbxSearch.TabIndex = 5
        Me.cbxSearch.Text = "Description"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(988, 22)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 28)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkMaterial)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.cbxSearch)
        Me.GroupBox1.Controls.Add(Me.chkService)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1137, 62)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'chkMaterial
        '
        Me.chkMaterial.AutoSize = True
        Me.chkMaterial.Checked = True
        Me.chkMaterial.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMaterial.Location = New System.Drawing.Point(748, 25)
        Me.chkMaterial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkMaterial.Name = "chkMaterial"
        Me.chkMaterial.Size = New System.Drawing.Size(77, 20)
        Me.chkMaterial.TabIndex = 10
        Me.chkMaterial.Text = "Material"
        Me.chkMaterial.UseVisualStyleBackColor = True
        '
        'chkService
        '
        Me.chkService.AutoSize = True
        Me.chkService.Checked = True
        Me.chkService.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkService.Location = New System.Drawing.Point(661, 25)
        Me.chkService.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkService.Name = "chkService"
        Me.chkService.Size = New System.Drawing.Size(75, 20)
        Me.chkService.TabIndex = 9
        Me.chkService.Text = "Service"
        Me.chkService.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(556, 25)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ticket Status:"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CASINGTableAdapter = Nothing
        Me.TableAdapterManager.CITYTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CONTRACTTableAdapter = Nothing
        Me.TableAdapterManager.COUNTRYTableAdapter = Nothing
        Me.TableAdapterManager.CURRENCYTableAdapter = Nothing
        Me.TableAdapterManager.CUSTOMERTableAdapter = Nothing
        Me.TableAdapterManager.EQUIPMENTTableAdapter = Nothing
        Me.TableAdapterManager.HSEQ_ANSWERSTableAdapter = Nothing
        Me.TableAdapterManager.INVENTORYCLASSTableAdapter = Nothing
        Me.TableAdapterManager.INVENTORYITEMTableAdapter = Nothing
        Me.TableAdapterManager.INVENTORYUNITTableAdapter = Nothing
        Me.TableAdapterManager.PETRFIELDTableAdapter = Nothing
        Me.TableAdapterManager.REPORTTICKETLISTTableAdapter = Nothing
        Me.TableAdapterManager.RIGTableAdapter = Nothing
        Me.TableAdapterManager.SALESITEM_TOTAL_L01TableAdapter = Nothing
        Me.TableAdapterManager.SALESITEM_TOTAL_L02_MATTableAdapter = Nothing
        Me.TableAdapterManager.SALESITEM_TOTAL_L02_SERVTableAdapter = Nothing
        Me.TableAdapterManager.SERVICELINETableAdapter = Nothing
        Me.TableAdapterManager.SITESTableAdapter = Nothing
        Me.TableAdapterManager.STATETableAdapter = Nothing
        Me.TableAdapterManager.TICKETFILELOGTableAdapter = Nothing
        Me.TableAdapterManager.TICKETOPEREPACTTableAdapter = Nothing
        Me.TableAdapterManager.TICKETOPEREPTableAdapter = Nothing
        Me.TableAdapterManager.TICKETTableAdapter = Nothing
        Me.TableAdapterManager.TMP_RPT_TICKETSERVEVALSERVTableAdapter = Nothing
        Me.TableAdapterManager.TMP_TICKETCLOSETableAdapter = Nothing
        Me.TableAdapterManager.TUBINGTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Nothing
        Me.TableAdapterManager.WELLTableAdapter = Nothing
        Me.TableAdapterManager.WORKERTableAdapter = Nothing
        '
        'CONTRACTPRICELISTTMPTableAdapter
        '
        Me.CONTRACTPRICELISTTMPTableAdapter.ClearBeforeFill = True
        '
        'frmSearchSalesItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1560, 676)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvSalesItemSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSearchSalesItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Contract Price Item"
        CType(Me.dgvSalesItemSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRACTPRICELISTTMPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SESTicketAccessDataSet As SESTicket.SESTicketAccessDataSet
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvSalesItemSearch As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cbxSearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMaterial As System.Windows.Forms.CheckBox
    Friend WithEvents chkService As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CONTRACTPRICELISTTMPBindingSource As BindingSource
    Friend WithEvents CONTRACTPRICELISTTMPTableAdapter As SESTicketAccessDataSetTableAdapters.CONTRACTPRICELISTTMPTableAdapter
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colTabGroup As DataGridViewTextBoxColumn
    Friend WithEvents colCustCodeItem As DataGridViewTextBoxColumn
    Friend WithEvents colDescription As DataGridViewTextBoxColumn
    Friend WithEvents colSalesPrice As DataGridViewTextBoxColumn
    Friend WithEvents colUnitSale As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents colContractPriceList As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents colIsHeader As DataGridViewTextBoxColumn
    Friend WithEvents colPriceUnitDecimal As DataGridViewTextBoxColumn
End Class
