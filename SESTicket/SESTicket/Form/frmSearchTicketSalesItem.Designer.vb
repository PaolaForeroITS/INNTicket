<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearchTicketSalesItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchTicketSalesItem))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cbxSearch = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.SALESITEMVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SALESITEM_VTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.SALESITEM_VTableAdapter()
        Me.dgvSalesItem = New System.Windows.Forms.DataGridView()
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTabGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSICustCodeItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSIDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSIUnitSale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSIItemQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSITicketSalesItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SALESITEMVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSalesItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.cbxSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(737, 41)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(516, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(597, 12)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(202, 14)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(308, 20)
        Me.txtSearch.TabIndex = 6
        '
        'cbxSearch
        '
        Me.cbxSearch.FormattingEnabled = True
        Me.cbxSearch.Items.AddRange(New Object() {"Item", "Description"})
        Me.cbxSearch.Location = New System.Drawing.Point(75, 14)
        Me.cbxSearch.Name = "cbxSearch"
        Me.cbxSearch.Size = New System.Drawing.Size(121, 21)
        Me.cbxSearch.TabIndex = 10
        Me.cbxSearch.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Search by:"
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'SALESITEMVBindingSource
        '
        Me.SALESITEMVBindingSource.DataMember = "SALESITEM_V"
        Me.SALESITEMVBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'SALESITEM_VTableAdapter
        '
        Me.SALESITEM_VTableAdapter.ClearBeforeFill = True
        '
        'dgvSalesItem
        '
        Me.dgvSalesItem.AllowUserToAddRows = False
        Me.dgvSalesItem.AllowUserToDeleteRows = False
        Me.dgvSalesItem.AutoGenerateColumns = False
        Me.dgvSalesItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSalesItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colType, Me.colTabGroup, Me.colSICustCodeItem, Me.colSIDescription, Me.colSIUnitSale, Me.colSIItemQty, Me.colSITicketSalesItemId})
        Me.dgvSalesItem.DataSource = Me.SALESITEMVBindingSource
        Me.dgvSalesItem.Location = New System.Drawing.Point(7, 50)
        Me.dgvSalesItem.MultiSelect = False
        Me.dgvSalesItem.Name = "dgvSalesItem"
        Me.dgvSalesItem.ReadOnly = True
        Me.dgvSalesItem.RowHeadersWidth = 10
        Me.dgvSalesItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSalesItem.Size = New System.Drawing.Size(737, 468)
        Me.dgvSalesItem.TabIndex = 15
        '
        'colType
        '
        Me.colType.DataPropertyName = "TYPE"
        Me.colType.HeaderText = "Type"
        Me.colType.Name = "colType"
        Me.colType.ReadOnly = True
        Me.colType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colType.Width = 49
        '
        'colTabGroup
        '
        Me.colTabGroup.DataPropertyName = "TABGROUP"
        Me.colTabGroup.HeaderText = "Group"
        Me.colTabGroup.Name = "colTabGroup"
        Me.colTabGroup.ReadOnly = True
        Me.colTabGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colTabGroup.Width = 53
        '
        'colSICustCodeItem
        '
        Me.colSICustCodeItem.DataPropertyName = "CUSTCODEITEM"
        Me.colSICustCodeItem.HeaderText = "Item"
        Me.colSICustCodeItem.Name = "colSICustCodeItem"
        Me.colSICustCodeItem.ReadOnly = True
        Me.colSICustCodeItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colSICustCodeItem.Width = 44
        '
        'colSIDescription
        '
        Me.colSIDescription.DataPropertyName = "DESCRIPTION"
        Me.colSIDescription.HeaderText = "Description"
        Me.colSIDescription.Name = "colSIDescription"
        Me.colSIDescription.ReadOnly = True
        Me.colSIDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colSIDescription.Width = 450
        '
        'colSIUnitSale
        '
        Me.colSIUnitSale.DataPropertyName = "UNIT_SALE"
        Me.colSIUnitSale.HeaderText = "Unit"
        Me.colSIUnitSale.Name = "colSIUnitSale"
        Me.colSIUnitSale.ReadOnly = True
        Me.colSIUnitSale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colSIUnitSale.Width = 50
        '
        'colSIItemQty
        '
        Me.colSIItemQty.DataPropertyName = "ITEMQTY"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colSIItemQty.DefaultCellStyle = DataGridViewCellStyle1
        Me.colSIItemQty.HeaderText = "Qty"
        Me.colSIItemQty.Name = "colSIItemQty"
        Me.colSIItemQty.ReadOnly = True
        Me.colSIItemQty.Width = 50
        '
        'colSITicketSalesItemId
        '
        Me.colSITicketSalesItemId.DataPropertyName = "TICKETSALESITEMID"
        Me.colSITicketSalesItemId.HeaderText = "TICKETSALESITEMID"
        Me.colSITicketSalesItemId.Name = "colSITicketSalesItemId"
        Me.colSITicketSalesItemId.ReadOnly = True
        Me.colSITicketSalesItemId.Visible = False
        '
        'frmSearchTicketSalesItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(750, 523)
        Me.Controls.Add(Me.dgvSalesItem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchTicketSalesItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Ticket Sales Item"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SALESITEMVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSalesItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cbxSearch As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SESTicketAccessDataSet As SESTicketAccessDataSet
    Friend WithEvents SALESITEMVBindingSource As BindingSource
    Friend WithEvents SALESITEM_VTableAdapter As SESTicketAccessDataSetTableAdapters.SALESITEM_VTableAdapter
    Friend WithEvents dgvSalesItem As DataGridView
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colTabGroup As DataGridViewTextBoxColumn
    Friend WithEvents colSICustCodeItem As DataGridViewTextBoxColumn
    Friend WithEvents colSIDescription As DataGridViewTextBoxColumn
    Friend WithEvents colSIUnitSale As DataGridViewTextBoxColumn
    Friend WithEvents colSIItemQty As DataGridViewTextBoxColumn
    Friend WithEvents colSITicketSalesItemId As DataGridViewTextBoxColumn
End Class
