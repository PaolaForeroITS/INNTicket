<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchInvItem
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchInvItem))
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvInvItem = New System.Windows.Forms.DataGridView()
        Me.colInventoryItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAbbrev = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVENTORYCLASSID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStorageUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENDOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BRAND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTCOST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInventoryClassId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVENTORYITEMCONTRACTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.cbxSearch = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.INVENTORYITEMCONTRACTTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.INVENTORYITEMCONTRACTTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager()
        CType(Me.dgvInvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTORYITEMCONTRACTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(688, 15)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 28)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(269, 17)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(409, 22)
        Me.txtSearch.TabIndex = 6
        '
        'dgvInvItem
        '
        Me.dgvInvItem.AllowUserToAddRows = False
        Me.dgvInvItem.AllowUserToDeleteRows = False
        Me.dgvInvItem.AutoGenerateColumns = False
        Me.dgvInvItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvInvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colInventoryItemId, Me.colAbbrev, Me.colDescription, Me.INVENTORYCLASSID, Me.colStorageUnit, Me.VENDOR, Me.BRAND, Me.LASTCOST, Me.colInventoryClassId})
        Me.dgvInvItem.DataSource = Me.INVENTORYITEMCONTRACTBindingSource
        Me.dgvInvItem.Location = New System.Drawing.Point(16, 62)
        Me.dgvInvItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvInvItem.Name = "dgvInvItem"
        Me.dgvInvItem.ReadOnly = True
        Me.dgvInvItem.RowHeadersWidth = 10
        Me.dgvInvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvItem.Size = New System.Drawing.Size(1533, 620)
        Me.dgvInvItem.TabIndex = 8
        '
        'colInventoryItemId
        '
        Me.colInventoryItemId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colInventoryItemId.DataPropertyName = "INVENTORYITEMID"
        Me.colInventoryItemId.HeaderText = "Item"
        Me.colInventoryItemId.MinimumWidth = 6
        Me.colInventoryItemId.Name = "colInventoryItemId"
        Me.colInventoryItemId.ReadOnly = True
        Me.colInventoryItemId.Width = 61
        '
        'colAbbrev
        '
        Me.colAbbrev.DataPropertyName = "ABBREVIATION"
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colAbbrev.DefaultCellStyle = DataGridViewCellStyle1
        Me.colAbbrev.HeaderText = "Abbreviation"
        Me.colAbbrev.MinimumWidth = 6
        Me.colAbbrev.Name = "colAbbrev"
        Me.colAbbrev.ReadOnly = True
        Me.colAbbrev.Width = 160
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "DESCRIPTION"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDescription.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.MinimumWidth = 6
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 350
        '
        'INVENTORYCLASSID
        '
        Me.INVENTORYCLASSID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.INVENTORYCLASSID.DataPropertyName = "INVENTORYCLASSID"
        Me.INVENTORYCLASSID.HeaderText = "Class"
        Me.INVENTORYCLASSID.MinimumWidth = 6
        Me.INVENTORYCLASSID.Name = "INVENTORYCLASSID"
        Me.INVENTORYCLASSID.ReadOnly = True
        Me.INVENTORYCLASSID.Width = 70
        '
        'colStorageUnit
        '
        Me.colStorageUnit.DataPropertyName = "STORAGEUNIT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colStorageUnit.DefaultCellStyle = DataGridViewCellStyle3
        Me.colStorageUnit.HeaderText = "Unit"
        Me.colStorageUnit.MinimumWidth = 6
        Me.colStorageUnit.Name = "colStorageUnit"
        Me.colStorageUnit.ReadOnly = True
        Me.colStorageUnit.Width = 60
        '
        'VENDOR
        '
        Me.VENDOR.DataPropertyName = "VENDOR"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VENDOR.DefaultCellStyle = DataGridViewCellStyle4
        Me.VENDOR.HeaderText = "Vendor"
        Me.VENDOR.MinimumWidth = 6
        Me.VENDOR.Name = "VENDOR"
        Me.VENDOR.ReadOnly = True
        Me.VENDOR.Width = 120
        '
        'BRAND
        '
        Me.BRAND.DataPropertyName = "BRAND"
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BRAND.DefaultCellStyle = DataGridViewCellStyle5
        Me.BRAND.HeaderText = "Brand"
        Me.BRAND.MinimumWidth = 6
        Me.BRAND.Name = "BRAND"
        Me.BRAND.ReadOnly = True
        Me.BRAND.Width = 120
        '
        'LASTCOST
        '
        Me.LASTCOST.DataPropertyName = "LASTCOST"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "n2"
        Me.LASTCOST.DefaultCellStyle = DataGridViewCellStyle6
        Me.LASTCOST.HeaderText = "Last Cost"
        Me.LASTCOST.MinimumWidth = 6
        Me.LASTCOST.Name = "LASTCOST"
        Me.LASTCOST.ReadOnly = True
        Me.LASTCOST.Width = 125
        '
        'colInventoryClassId
        '
        Me.colInventoryClassId.DataPropertyName = "INVENTORYCLASSID"
        Me.colInventoryClassId.HeaderText = "INVENTORYCLASSID"
        Me.colInventoryClassId.MinimumWidth = 6
        Me.colInventoryClassId.Name = "colInventoryClassId"
        Me.colInventoryClassId.ReadOnly = True
        Me.colInventoryClassId.Visible = False
        Me.colInventoryClassId.Width = 125
        '
        'INVENTORYITEMCONTRACTBindingSource
        '
        Me.INVENTORYITEMCONTRACTBindingSource.DataMember = "INVENTORYITEMCONTRACT"
        Me.INVENTORYITEMCONTRACTBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'cbxSearch
        '
        Me.cbxSearch.FormattingEnabled = True
        Me.cbxSearch.Items.AddRange(New Object() {"Item", "Abbreviation", "Description"})
        Me.cbxSearch.Location = New System.Drawing.Point(100, 17)
        Me.cbxSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxSearch.Name = "cbxSearch"
        Me.cbxSearch.Size = New System.Drawing.Size(160, 24)
        Me.cbxSearch.TabIndex = 10
        Me.cbxSearch.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Search by:"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(796, 15)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 28)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.cbxSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(928, 50)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'INVENTORYITEMCONTRACTTableAdapter
        '
        Me.INVENTORYITEMCONTRACTTableAdapter.ClearBeforeFill = True
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
        'frmSearchInvItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1555, 693)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvInvItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchInvItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Inventory Item"
        CType(Me.dgvInvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTORYITEMCONTRACTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents SESTicketAccessDataSet As SESTicket.SESTicketAccessDataSet
    Friend WithEvents INVENTORYITEMCONTRACTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INVENTORYITEMCONTRACTTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.INVENTORYITEMCONTRACTTableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvInvItem As System.Windows.Forms.DataGridView
    Friend WithEvents cbxSearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents colInventoryItemId As DataGridViewTextBoxColumn
    Friend WithEvents colAbbrev As DataGridViewTextBoxColumn
    Friend WithEvents colDescription As DataGridViewTextBoxColumn
    Friend WithEvents INVENTORYCLASSID As DataGridViewTextBoxColumn
    Friend WithEvents colStorageUnit As DataGridViewTextBoxColumn
    Friend WithEvents VENDOR As DataGridViewTextBoxColumn
    Friend WithEvents BRAND As DataGridViewTextBoxColumn
    Friend WithEvents LASTCOST As DataGridViewTextBoxColumn
    Friend WithEvents colInventoryClassId As DataGridViewTextBoxColumn
End Class
