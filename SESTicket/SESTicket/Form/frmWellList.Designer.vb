<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWellList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWellList))
        Me.dgvWell = New System.Windows.Forms.DataGridView()
        Me.colWellID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCountry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPetrFieldCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSiteID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSiteName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRigId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPetrFieldId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WELLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.chkNo = New System.Windows.Forms.CheckBox()
        Me.chkYes = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuNewItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImportData = New System.Windows.Forms.ToolStripMenuItem()
        Me.WELLTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.WELLTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager()
        CType(Me.dgvWell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WELLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvWell
        '
        Me.dgvWell.AllowUserToAddRows = False
        Me.dgvWell.AllowUserToDeleteRows = False
        Me.dgvWell.AllowUserToResizeColumns = False
        Me.dgvWell.AllowUserToResizeRows = False
        Me.dgvWell.AutoGenerateColumns = False
        Me.dgvWell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWell.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colWellID, Me.colName, Me.colCountry, Me.colState, Me.colCity, Me.colPetrFieldCode, Me.colSiteID, Me.colSiteName, Me.colRigId, Me.colActive, Me.colPetrFieldId})
        Me.dgvWell.DataSource = Me.WELLBindingSource
        Me.dgvWell.Location = New System.Drawing.Point(0, 55)
        Me.dgvWell.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvWell.Name = "dgvWell"
        Me.dgvWell.ReadOnly = True
        Me.dgvWell.RowHeadersWidth = 10
        Me.dgvWell.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvWell.Size = New System.Drawing.Size(1208, 708)
        Me.dgvWell.TabIndex = 1
        '
        'colWellID
        '
        Me.colWellID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colWellID.DataPropertyName = "WELLID"
        Me.colWellID.HeaderText = "Well ID"
        Me.colWellID.MinimumWidth = 6
        Me.colWellID.Name = "colWellID"
        Me.colWellID.ReadOnly = True
        Me.colWellID.Width = 79
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
        Me.colState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colState.DataPropertyName = "STATE"
        Me.colState.HeaderText = "State"
        Me.colState.MinimumWidth = 6
        Me.colState.Name = "colState"
        Me.colState.ReadOnly = True
        Me.colState.Width = 67
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
        'colPetrFieldCode
        '
        Me.colPetrFieldCode.DataPropertyName = "PETRFIELDCODE"
        Me.colPetrFieldCode.HeaderText = "Petr Field"
        Me.colPetrFieldCode.MinimumWidth = 6
        Me.colPetrFieldCode.Name = "colPetrFieldCode"
        Me.colPetrFieldCode.ReadOnly = True
        Me.colPetrFieldCode.Width = 125
        '
        'colSiteID
        '
        Me.colSiteID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSiteID.DataPropertyName = "SITEID"
        Me.colSiteID.HeaderText = "SiteID"
        Me.colSiteID.MinimumWidth = 6
        Me.colSiteID.Name = "colSiteID"
        Me.colSiteID.ReadOnly = True
        Me.colSiteID.Visible = False
        Me.colSiteID.Width = 125
        '
        'colSiteName
        '
        Me.colSiteName.DataPropertyName = "SITENAME"
        Me.colSiteName.HeaderText = "Site"
        Me.colSiteName.MinimumWidth = 6
        Me.colSiteName.Name = "colSiteName"
        Me.colSiteName.ReadOnly = True
        Me.colSiteName.Width = 125
        '
        'colRigId
        '
        Me.colRigId.DataPropertyName = "RIGID"
        Me.colRigId.HeaderText = "Rig"
        Me.colRigId.MinimumWidth = 6
        Me.colRigId.Name = "colRigId"
        Me.colRigId.ReadOnly = True
        Me.colRigId.Width = 125
        '
        'colActive
        '
        Me.colActive.DataPropertyName = "ACTIVE"
        Me.colActive.HeaderText = "Active"
        Me.colActive.MinimumWidth = 6
        Me.colActive.Name = "colActive"
        Me.colActive.ReadOnly = True
        Me.colActive.Width = 60
        '
        'colPetrFieldId
        '
        Me.colPetrFieldId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colPetrFieldId.DataPropertyName = "PETRFIELDID"
        Me.colPetrFieldId.HeaderText = "Field"
        Me.colPetrFieldId.MinimumWidth = 6
        Me.colPetrFieldId.Name = "colPetrFieldId"
        Me.colPetrFieldId.ReadOnly = True
        Me.colPetrFieldId.Visible = False
        Me.colPetrFieldId.Width = 125
        '
        'WELLBindingSource
        '
        Me.WELLBindingSource.DataMember = "WELL"
        Me.WELLBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chkNo
        '
        Me.chkNo.AutoSize = True
        Me.chkNo.Location = New System.Drawing.Point(1121, 15)
        Me.chkNo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkNo.Name = "chkNo"
        Me.chkNo.Size = New System.Drawing.Size(47, 20)
        Me.chkNo.TabIndex = 43
        Me.chkNo.Text = "No"
        Me.chkNo.UseVisualStyleBackColor = True
        '
        'chkYes
        '
        Me.chkYes.AutoSize = True
        Me.chkYes.Checked = True
        Me.chkYes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkYes.Location = New System.Drawing.Point(1055, 15)
        Me.chkYes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkYes.Name = "chkYes"
        Me.chkYes.Size = New System.Drawing.Size(53, 20)
        Me.chkYes.TabIndex = 42
        Me.chkYes.Text = "Yes"
        Me.chkYes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(993, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Active:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewItem, Me.mnuExportData, Me.mnuImportData})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1208, 52)
        Me.MenuStrip1.TabIndex = 44
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
        'mnuExportData
        '
        Me.mnuExportData.Image = CType(resources.GetObject("mnuExportData.Image"), System.Drawing.Image)
        Me.mnuExportData.Name = "mnuExportData"
        Me.mnuExportData.Size = New System.Drawing.Size(122, 48)
        Me.mnuExportData.Text = "Export Data"
        '
        'mnuImportData
        '
        Me.mnuImportData.Image = CType(resources.GetObject("mnuImportData.Image"), System.Drawing.Image)
        Me.mnuImportData.Name = "mnuImportData"
        Me.mnuImportData.Size = New System.Drawing.Size(124, 48)
        Me.mnuImportData.Text = "Import Data"
        '
        'WELLTableAdapter
        '
        Me.WELLTableAdapter.ClearBeforeFill = True
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
        'frmWellList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1208, 766)
        Me.Controls.Add(Me.chkNo)
        Me.Controls.Add(Me.chkYes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvWell)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWellList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INNTicket - Well List"
        CType(Me.dgvWell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WELLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents WELLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WELLTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.WELLTableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvWell As System.Windows.Forms.DataGridView
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chkNo As System.Windows.Forms.CheckBox
    Friend WithEvents chkYes As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNewItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuImportData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents colWellID As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colCountry As DataGridViewTextBoxColumn
    Friend WithEvents colState As DataGridViewTextBoxColumn
    Friend WithEvents colCity As DataGridViewTextBoxColumn
    Friend WithEvents colPetrFieldCode As DataGridViewTextBoxColumn
    Friend WithEvents colSiteID As DataGridViewTextBoxColumn
    Friend WithEvents colSiteName As DataGridViewTextBoxColumn
    Friend WithEvents colRigId As DataGridViewTextBoxColumn
    Friend WithEvents colActive As DataGridViewTextBoxColumn
    Friend WithEvents colPetrFieldId As DataGridViewTextBoxColumn
End Class
