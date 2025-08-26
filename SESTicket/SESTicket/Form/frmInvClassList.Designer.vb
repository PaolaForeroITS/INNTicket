<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvClassList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvClassList))
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.INVENTORYCLASSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INVENTORYCLASSTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.INVENTORYCLASSTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager()
        Me.dgvInvClass = New System.Windows.Forms.DataGridView()
        Me.colInvClassID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCostOfGoodsAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCostOfGoodsSubAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesAccountAIU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesAccountUBR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesAccountUBRAIU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesSubAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInventoryAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInventorySubAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuNewItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTORYCLASSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInvClass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'INVENTORYCLASSBindingSource
        '
        Me.INVENTORYCLASSBindingSource.DataMember = "INVENTORYCLASS"
        Me.INVENTORYCLASSBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'INVENTORYCLASSTableAdapter
        '
        Me.INVENTORYCLASSTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.INVENTORYCLASSTableAdapter = Me.INVENTORYCLASSTableAdapter
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
        'dgvInvClass
        '
        Me.dgvInvClass.AllowUserToAddRows = False
        Me.dgvInvClass.AllowUserToDeleteRows = False
        Me.dgvInvClass.AutoGenerateColumns = False
        Me.dgvInvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvClass.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colInvClassID, Me.colType, Me.colDescription, Me.colCostOfGoodsAccount, Me.colCostOfGoodsSubAccount, Me.colSalesAccount, Me.colSalesAccountAIU, Me.colSalesAccountUBR, Me.colSalesAccountUBRAIU, Me.colSalesSubAccount, Me.colInventoryAccount, Me.colInventorySubAccount})
        Me.dgvInvClass.DataSource = Me.INVENTORYCLASSBindingSource
        Me.dgvInvClass.Location = New System.Drawing.Point(0, 45)
        Me.dgvInvClass.Name = "dgvInvClass"
        Me.dgvInvClass.ReadOnly = True
        Me.dgvInvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInvClass.Size = New System.Drawing.Size(514, 420)
        Me.dgvInvClass.TabIndex = 1
        '
        'colInvClassID
        '
        Me.colInvClassID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colInvClassID.DataPropertyName = "INVENTORYCLASSID"
        Me.colInvClassID.HeaderText = "ID"
        Me.colInvClassID.Name = "colInvClassID"
        Me.colInvClassID.ReadOnly = True
        Me.colInvClassID.Width = 43
        '
        'colType
        '
        Me.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colType.DataPropertyName = "TYPE"
        Me.colType.HeaderText = "Type"
        Me.colType.Name = "colType"
        Me.colType.ReadOnly = True
        Me.colType.Width = 56
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "DESCRIPTION"
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 300
        '
        'colCostOfGoodsAccount
        '
        Me.colCostOfGoodsAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCostOfGoodsAccount.DataPropertyName = "COSTOFGOODSACCOUNT"
        Me.colCostOfGoodsAccount.HeaderText = "COSTOFGOODSACCOUNT"
        Me.colCostOfGoodsAccount.Name = "colCostOfGoodsAccount"
        Me.colCostOfGoodsAccount.ReadOnly = True
        Me.colCostOfGoodsAccount.Visible = False
        '
        'colCostOfGoodsSubAccount
        '
        Me.colCostOfGoodsSubAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCostOfGoodsSubAccount.DataPropertyName = "COSTOFGOODSSUBACCOUNT"
        Me.colCostOfGoodsSubAccount.HeaderText = "COSTOFGOODSSUBACCOUNT"
        Me.colCostOfGoodsSubAccount.Name = "colCostOfGoodsSubAccount"
        Me.colCostOfGoodsSubAccount.ReadOnly = True
        Me.colCostOfGoodsSubAccount.Visible = False
        '
        'colSalesAccount
        '
        Me.colSalesAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesAccount.DataPropertyName = "SALESACCOUNT"
        Me.colSalesAccount.HeaderText = "SALESACCOUNT"
        Me.colSalesAccount.Name = "colSalesAccount"
        Me.colSalesAccount.ReadOnly = True
        Me.colSalesAccount.Visible = False
        '
        'colSalesAccountAIU
        '
        Me.colSalesAccountAIU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesAccountAIU.DataPropertyName = "SALESACCOUNTAIU"
        Me.colSalesAccountAIU.HeaderText = "SALESACCOUNTAIU"
        Me.colSalesAccountAIU.Name = "colSalesAccountAIU"
        Me.colSalesAccountAIU.ReadOnly = True
        Me.colSalesAccountAIU.Visible = False
        '
        'colSalesAccountUBR
        '
        Me.colSalesAccountUBR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesAccountUBR.DataPropertyName = "SALESACCOUNTUBR"
        Me.colSalesAccountUBR.HeaderText = "SALESACCOUNTUBR"
        Me.colSalesAccountUBR.Name = "colSalesAccountUBR"
        Me.colSalesAccountUBR.ReadOnly = True
        Me.colSalesAccountUBR.Visible = False
        '
        'colSalesAccountUBRAIU
        '
        Me.colSalesAccountUBRAIU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesAccountUBRAIU.DataPropertyName = "SALESACCOUNTUBRAIU"
        Me.colSalesAccountUBRAIU.HeaderText = "SALESACCOUNTUBRAIU"
        Me.colSalesAccountUBRAIU.Name = "colSalesAccountUBRAIU"
        Me.colSalesAccountUBRAIU.ReadOnly = True
        Me.colSalesAccountUBRAIU.Visible = False
        '
        'colSalesSubAccount
        '
        Me.colSalesSubAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesSubAccount.DataPropertyName = "SALESSUBACCOUNT"
        Me.colSalesSubAccount.HeaderText = "SALESSUBACCOUNT"
        Me.colSalesSubAccount.Name = "colSalesSubAccount"
        Me.colSalesSubAccount.ReadOnly = True
        Me.colSalesSubAccount.Visible = False
        '
        'colInventoryAccount
        '
        Me.colInventoryAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colInventoryAccount.DataPropertyName = "INVENTORYACCOUNT"
        Me.colInventoryAccount.HeaderText = "INVENTORYACCOUNT"
        Me.colInventoryAccount.Name = "colInventoryAccount"
        Me.colInventoryAccount.ReadOnly = True
        Me.colInventoryAccount.Visible = False
        '
        'colInventorySubAccount
        '
        Me.colInventorySubAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colInventorySubAccount.DataPropertyName = "INVENTORYSUBACCOUNT"
        Me.colInventorySubAccount.HeaderText = "INVENTORYSUBACCOUNT"
        Me.colInventorySubAccount.Name = "colInventorySubAccount"
        Me.colInventorySubAccount.ReadOnly = True
        Me.colInventorySubAccount.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(517, 42)
        Me.MenuStrip1.TabIndex = 36
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
        'frmInvClassList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(517, 468)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvInvClass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvClassList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTicket - Inventory Class"
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTORYCLASSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInvClass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents INVENTORYCLASSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INVENTORYCLASSTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.INVENTORYCLASSTableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvInvClass As System.Windows.Forms.DataGridView
    Friend WithEvents colInvClassID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCostOfGoodsAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCostOfGoodsSubAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSalesAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSalesAccountAIU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSalesAccountUBR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSalesAccountUBRAIU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSalesSubAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInventoryAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInventorySubAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNewItem As System.Windows.Forms.ToolStripMenuItem
End Class
