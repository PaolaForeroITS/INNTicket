<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiceTypeList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServiceTypeList))
        Me.SERVICETYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.dgvServiceType = New System.Windows.Forms.DataGridView()
        Me.colServiceTypeID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceTypeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERVICETYPETableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.SERVICETYPETableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuNewItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkNo = New System.Windows.Forms.CheckBox()
        Me.chkYes = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.SERVICETYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvServiceType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SERVICETYPEBindingSource
        '
        Me.SERVICETYPEBindingSource.DataMember = "SERVICETYPE"
        Me.SERVICETYPEBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvServiceType
        '
        Me.dgvServiceType.AllowUserToAddRows = False
        Me.dgvServiceType.AllowUserToDeleteRows = False
        Me.dgvServiceType.AutoGenerateColumns = False
        Me.dgvServiceType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServiceType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colServiceTypeID, Me.colServiceTypeCode, Me.colDescription, Me.colActive})
        Me.dgvServiceType.DataSource = Me.SERVICETYPEBindingSource
        Me.dgvServiceType.Location = New System.Drawing.Point(0, 45)
        Me.dgvServiceType.Name = "dgvServiceType"
        Me.dgvServiceType.ReadOnly = True
        Me.dgvServiceType.RowHeadersWidth = 10
        Me.dgvServiceType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServiceType.Size = New System.Drawing.Size(497, 511)
        Me.dgvServiceType.TabIndex = 1
        '
        'colServiceTypeID
        '
        Me.colServiceTypeID.DataPropertyName = "SERVICETYPEID"
        Me.colServiceTypeID.HeaderText = "ServiceTypeID"
        Me.colServiceTypeID.Name = "colServiceTypeID"
        Me.colServiceTypeID.ReadOnly = True
        Me.colServiceTypeID.Visible = False
        '
        'colServiceTypeCode
        '
        Me.colServiceTypeCode.DataPropertyName = "SERVICETYPECODE"
        Me.colServiceTypeCode.HeaderText = "Code"
        Me.colServiceTypeCode.Name = "colServiceTypeCode"
        Me.colServiceTypeCode.ReadOnly = True
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "DESCRIPTION"
        Me.colDescription.HeaderText = "Service Type"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 300
        '
        'colActive
        '
        Me.colActive.DataPropertyName = "ACTIVE"
        Me.colActive.HeaderText = "Active"
        Me.colActive.Name = "colActive"
        Me.colActive.ReadOnly = True
        Me.colActive.Width = 60
        '
        'SERVICETYPETableAdapter
        '
        Me.SERVICETYPETableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SERVICETYPETableAdapter = Me.SERVICETYPETableAdapter
        Me.TableAdapterManager.SITESTableAdapter = Nothing
        Me.TableAdapterManager.STATETableAdapter = Nothing
        Me.TableAdapterManager.TICKETINVOICELINETableAdapter = Nothing
        Me.TableAdapterManager.TUBINGTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Nothing
        Me.TableAdapterManager.WELLTableAdapter = Nothing
        Me.TableAdapterManager.WORKERTableAdapter = Nothing
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(503, 42)
        Me.MenuStrip1.TabIndex = 34
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
        'chkNo
        '
        Me.chkNo.AutoSize = True
        Me.chkNo.Location = New System.Drawing.Point(356, 12)
        Me.chkNo.Name = "chkNo"
        Me.chkNo.Size = New System.Drawing.Size(40, 17)
        Me.chkNo.TabIndex = 43
        Me.chkNo.Text = "No"
        Me.chkNo.UseVisualStyleBackColor = True
        '
        'chkYes
        '
        Me.chkYes.AutoSize = True
        Me.chkYes.Checked = True
        Me.chkYes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkYes.Location = New System.Drawing.Point(306, 12)
        Me.chkYes.Name = "chkYes"
        Me.chkYes.Size = New System.Drawing.Size(44, 17)
        Me.chkYes.TabIndex = 42
        Me.chkYes.Text = "Yes"
        Me.chkYes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Active:"
        '
        'frmServiceTypeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(503, 559)
        Me.Controls.Add(Me.chkNo)
        Me.Controls.Add(Me.chkYes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvServiceType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmServiceTypeList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTicket - Service Type"
        CType(Me.SERVICETYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvServiceType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents SERVICETYPEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERVICETYPETableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.SERVICETYPETableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvServiceType As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNewItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkNo As System.Windows.Forms.CheckBox
    Friend WithEvents chkYes As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents colServiceTypeID As DataGridViewTextBoxColumn
    Friend WithEvents colServiceTypeCode As DataGridViewTextBoxColumn
    Friend WithEvents colDescription As DataGridViewTextBoxColumn
    Friend WithEvents colActive As DataGridViewTextBoxColumn
End Class
