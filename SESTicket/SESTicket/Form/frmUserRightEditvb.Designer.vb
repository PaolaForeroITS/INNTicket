<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserRightEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserRightEdit))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuCopyFromUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvObjGroupItem = New System.Windows.Forms.DataGridView()
        Me.OBJECTDESCRIPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colObjectGroupItemUserId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBJECTGROUPIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEnableOpt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkCheck = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.mnuGrant = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PermitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DenyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OBJECTGROUPITEMVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSubGroup = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvObjGroup = New System.Windows.Forms.DataGridView()
        Me.colSubGroup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GROUPNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colObjectGroupId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colObjectGroupUserId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEnable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BENABLEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.OBJECTGROUPVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableAdapterManager = New SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager()
        Me.OBJECTGROUP_VTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.OBJECTGROUP_VTableAdapter()
        Me.OBJECTGROUPITEM_VTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.OBJECTGROUPITEM_VTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvObjGroupItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuGrant.SuspendLayout()
        CType(Me.OBJECTGROUPITEMVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvObjGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OBJECTGROUPVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopyFromUser, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(587, 42)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuCopyFromUser
        '
        Me.mnuCopyFromUser.Image = CType(resources.GetObject("mnuCopyFromUser.Image"), System.Drawing.Image)
        Me.mnuCopyFromUser.Name = "mnuCopyFromUser"
        Me.mnuCopyFromUser.Size = New System.Drawing.Size(120, 38)
        Me.mnuCopyFromUser.Text = "Copy From User"
        '
        'mnuExit
        '
        Me.mnuExit.Image = CType(resources.GetObject("mnuExit.Image"), System.Drawing.Image)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(53, 38)
        Me.mnuExit.Text = "Exit"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvObjGroupItem)
        Me.GroupBox3.Location = New System.Drawing.Point(247, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(335, 392)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'dgvObjGroupItem
        '
        Me.dgvObjGroupItem.AllowUserToAddRows = False
        Me.dgvObjGroupItem.AllowUserToDeleteRows = False
        Me.dgvObjGroupItem.AllowUserToResizeColumns = False
        Me.dgvObjGroupItem.AllowUserToResizeRows = False
        Me.dgvObjGroupItem.AutoGenerateColumns = False
        Me.dgvObjGroupItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvObjGroupItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvObjGroupItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OBJECTDESCRIPTIONDataGridViewTextBoxColumn, Me.USERNAMEDataGridViewTextBoxColumn, Me.colObjectGroupItemUserId, Me.OBJECTGROUPIDDataGridViewTextBoxColumn, Me.colEnableOpt, Me.chkCheck})
        Me.dgvObjGroupItem.ContextMenuStrip = Me.mnuGrant
        Me.dgvObjGroupItem.DataSource = Me.OBJECTGROUPITEMVBindingSource
        Me.dgvObjGroupItem.Location = New System.Drawing.Point(6, 19)
        Me.dgvObjGroupItem.Name = "dgvObjGroupItem"
        Me.dgvObjGroupItem.RowHeadersWidth = 10
        Me.dgvObjGroupItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvObjGroupItem.Size = New System.Drawing.Size(322, 365)
        Me.dgvObjGroupItem.TabIndex = 0
        '
        'OBJECTDESCRIPTIONDataGridViewTextBoxColumn
        '
        Me.OBJECTDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "OBJECTDESCRIPTION"
        Me.OBJECTDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = ""
        Me.OBJECTDESCRIPTIONDataGridViewTextBoxColumn.Name = "OBJECTDESCRIPTIONDataGridViewTextBoxColumn"
        Me.OBJECTDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.OBJECTDESCRIPTIONDataGridViewTextBoxColumn.Width = 270
        '
        'USERNAMEDataGridViewTextBoxColumn
        '
        Me.USERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME"
        Me.USERNAMEDataGridViewTextBoxColumn.Name = "USERNAMEDataGridViewTextBoxColumn"
        Me.USERNAMEDataGridViewTextBoxColumn.Visible = False
        '
        'colObjectGroupItemUserId
        '
        Me.colObjectGroupItemUserId.DataPropertyName = "OBJECTGROUPITEMUSERID"
        Me.colObjectGroupItemUserId.HeaderText = "OBJECTGROUPITEMUSERID"
        Me.colObjectGroupItemUserId.Name = "colObjectGroupItemUserId"
        Me.colObjectGroupItemUserId.Visible = False
        '
        'OBJECTGROUPIDDataGridViewTextBoxColumn
        '
        Me.OBJECTGROUPIDDataGridViewTextBoxColumn.DataPropertyName = "OBJECTGROUPID"
        Me.OBJECTGROUPIDDataGridViewTextBoxColumn.HeaderText = "OBJECTGROUPID"
        Me.OBJECTGROUPIDDataGridViewTextBoxColumn.Name = "OBJECTGROUPIDDataGridViewTextBoxColumn"
        Me.OBJECTGROUPIDDataGridViewTextBoxColumn.Visible = False
        '
        'colEnableOpt
        '
        Me.colEnableOpt.DataPropertyName = "ENABLE"
        Me.colEnableOpt.HeaderText = "ENABLE"
        Me.colEnableOpt.Name = "colEnableOpt"
        Me.colEnableOpt.Visible = False
        '
        'chkCheck
        '
        Me.chkCheck.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.chkCheck.DataPropertyName = "BENABLE"
        Me.chkCheck.HeaderText = ""
        Me.chkCheck.Name = "chkCheck"
        Me.chkCheck.ReadOnly = True
        Me.chkCheck.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chkCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.chkCheck.Width = 19
        '
        'mnuGrant
        '
        Me.mnuGrant.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermitToolStripMenuItem, Me.DenyToolStripMenuItem})
        Me.mnuGrant.Name = "mnuGrant"
        Me.mnuGrant.Size = New System.Drawing.Size(181, 70)
        '
        'PermitToolStripMenuItem
        '
        Me.PermitToolStripMenuItem.Image = CType(resources.GetObject("PermitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PermitToolStripMenuItem.Name = "PermitToolStripMenuItem"
        Me.PermitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PermitToolStripMenuItem.Text = "Permit"
        '
        'DenyToolStripMenuItem
        '
        Me.DenyToolStripMenuItem.Image = CType(resources.GetObject("DenyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DenyToolStripMenuItem.Name = "DenyToolStripMenuItem"
        Me.DenyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DenyToolStripMenuItem.Text = "Deny"
        '
        'OBJECTGROUPITEMVBindingSource
        '
        Me.OBJECTGROUPITEMVBindingSource.DataMember = "OBJECTGROUPITEM_V"
        Me.OBJECTGROUPITEMVBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSubGroup)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(247, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 53)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'txtSubGroup
        '
        Me.txtSubGroup.BackColor = System.Drawing.Color.White
        Me.txtSubGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubGroup.Location = New System.Drawing.Point(46, 20)
        Me.txtSubGroup.Name = "txtSubGroup"
        Me.txtSubGroup.ReadOnly = True
        Me.txtSubGroup.Size = New System.Drawing.Size(263, 20)
        Me.txtSubGroup.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form:"
        '
        'dgvObjGroup
        '
        Me.dgvObjGroup.AllowUserToAddRows = False
        Me.dgvObjGroup.AllowUserToDeleteRows = False
        Me.dgvObjGroup.AllowUserToResizeColumns = False
        Me.dgvObjGroup.AllowUserToResizeRows = False
        Me.dgvObjGroup.AutoGenerateColumns = False
        Me.dgvObjGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvObjGroup.ColumnHeadersVisible = False
        Me.dgvObjGroup.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSubGroup, Me.GROUPNAMEDataGridViewTextBoxColumn, Me.colObjectGroupId, Me.colObjectGroupUserId, Me.colEnable, Me.BENABLEDataGridViewTextBoxColumn})
        Me.dgvObjGroup.ContextMenuStrip = Me.mnuGrant
        Me.dgvObjGroup.DataSource = Me.OBJECTGROUPVBindingSource
        Me.dgvObjGroup.Location = New System.Drawing.Point(9, 20)
        Me.dgvObjGroup.Name = "dgvObjGroup"
        Me.dgvObjGroup.ReadOnly = True
        Me.dgvObjGroup.RowHeadersVisible = False
        Me.dgvObjGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvObjGroup.Size = New System.Drawing.Size(214, 423)
        Me.dgvObjGroup.TabIndex = 1
        '
        'colSubGroup
        '
        Me.colSubGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colSubGroup.DataPropertyName = "SUBGROUP"
        Me.colSubGroup.HeaderText = "SUBGROUP"
        Me.colSubGroup.Name = "colSubGroup"
        Me.colSubGroup.ReadOnly = True
        Me.colSubGroup.Width = 5
        '
        'GROUPNAMEDataGridViewTextBoxColumn
        '
        Me.GROUPNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.GROUPNAMEDataGridViewTextBoxColumn.DataPropertyName = "GROUPNAME"
        Me.GROUPNAMEDataGridViewTextBoxColumn.HeaderText = "GROUPNAME"
        Me.GROUPNAMEDataGridViewTextBoxColumn.Name = "GROUPNAMEDataGridViewTextBoxColumn"
        Me.GROUPNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.GROUPNAMEDataGridViewTextBoxColumn.Width = 5
        '
        'colObjectGroupId
        '
        Me.colObjectGroupId.DataPropertyName = "OBJECTGROUPID"
        Me.colObjectGroupId.HeaderText = "OBJECTGROUPID"
        Me.colObjectGroupId.Name = "colObjectGroupId"
        Me.colObjectGroupId.ReadOnly = True
        Me.colObjectGroupId.Visible = False
        '
        'colObjectGroupUserId
        '
        Me.colObjectGroupUserId.DataPropertyName = "OBJECTGROUPUSERID"
        Me.colObjectGroupUserId.HeaderText = "OBJECTGROUPUSERID"
        Me.colObjectGroupUserId.Name = "colObjectGroupUserId"
        Me.colObjectGroupUserId.ReadOnly = True
        Me.colObjectGroupUserId.Visible = False
        '
        'colEnable
        '
        Me.colEnable.DataPropertyName = "ENABLE"
        Me.colEnable.HeaderText = "ENABLE"
        Me.colEnable.Name = "colEnable"
        Me.colEnable.ReadOnly = True
        Me.colEnable.Visible = False
        '
        'BENABLEDataGridViewTextBoxColumn
        '
        Me.BENABLEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.BENABLEDataGridViewTextBoxColumn.DataPropertyName = "BENABLE"
        Me.BENABLEDataGridViewTextBoxColumn.HeaderText = ""
        Me.BENABLEDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.BENABLEDataGridViewTextBoxColumn.Name = "BENABLEDataGridViewTextBoxColumn"
        Me.BENABLEDataGridViewTextBoxColumn.ReadOnly = True
        Me.BENABLEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BENABLEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.BENABLEDataGridViewTextBoxColumn.Width = 10
        '
        'OBJECTGROUPVBindingSource
        '
        Me.OBJECTGROUPVBindingSource.DataMember = "OBJECTGROUP_V"
        Me.OBJECTGROUPVBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvObjGroup)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 451)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Forms"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CASINGTableAdapter = Nothing
        Me.TableAdapterManager.CITYTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.SITESTableAdapter = Nothing
        Me.TableAdapterManager.STATETableAdapter = Nothing
        Me.TableAdapterManager.TICKETINVOICELINETableAdapter = Nothing
        Me.TableAdapterManager.TUBINGTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Nothing
        Me.TableAdapterManager.WELLTableAdapter = Nothing
        Me.TableAdapterManager.WORKERTableAdapter = Nothing
        '
        'OBJECTGROUP_VTableAdapter
        '
        Me.OBJECTGROUP_VTableAdapter.ClearBeforeFill = True
        '
        'OBJECTGROUPITEM_VTableAdapter
        '
        Me.OBJECTGROUPITEM_VTableAdapter.ClearBeforeFill = True
        '
        'frmUserRightEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(587, 500)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserRightEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTicket - User Right"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvObjGroupItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuGrant.ResumeLayout(False)
        CType(Me.OBJECTGROUPITEMVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvObjGroup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OBJECTGROUPVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuCopyFromUser As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableAdapterManager As SESTicketSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvObjGroup As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtSubGroup As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvObjGroupItem As DataGridView
    Friend WithEvents OBJECTGROUPVBindingSource As BindingSource
    Friend WithEvents SESTicketSQLDataSet As SESTicketSQLDataSet
    Friend WithEvents OBJECTGROUP_VTableAdapter As SESTicketSQLDataSetTableAdapters.OBJECTGROUP_VTableAdapter
    Friend WithEvents OBJECTGROUPITEMVBindingSource As BindingSource
    Friend WithEvents OBJECTGROUPITEM_VTableAdapter As SESTicketSQLDataSetTableAdapters.OBJECTGROUPITEM_VTableAdapter
    Friend WithEvents mnuGrant As ContextMenuStrip
    Friend WithEvents PermitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DenyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents colSubGroup As DataGridViewTextBoxColumn
    Friend WithEvents GROUPNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colObjectGroupId As DataGridViewTextBoxColumn
    Friend WithEvents colObjectGroupUserId As DataGridViewTextBoxColumn
    Friend WithEvents colEnable As DataGridViewTextBoxColumn
    Friend WithEvents BENABLEDataGridViewTextBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents OBJECTDESCRIPTIONDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USERNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colObjectGroupItemUserId As DataGridViewTextBoxColumn
    Friend WithEvents OBJECTGROUPIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colEnableOpt As DataGridViewTextBoxColumn
    Friend WithEvents chkCheck As DataGridViewCheckBoxColumn
End Class
