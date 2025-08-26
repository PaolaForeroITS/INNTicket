<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketEquipment
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketEquipment))
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.TICKETEQUIPMENT_VBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TICKETEQUIPMENT_VTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TICKETEQUIPMENT_VTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager()
        Me.dgvEquip = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colConsumptionAux = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colConsumption = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketEquipmentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mnuContextMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuConsDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETEQUIPMENT_VBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEquip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuContextMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'TICKETEQUIPMENT_VBindingSource
        '
        Me.TICKETEQUIPMENT_VBindingSource.DataMember = "TICKETEQUIPMENT_V"
        Me.TICKETEQUIPMENT_VBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'TICKETEQUIPMENT_VTableAdapter
        '
        Me.TICKETEQUIPMENT_VTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.TUBINGTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Nothing
        Me.TableAdapterManager.WELLTableAdapter = Nothing
        Me.TableAdapterManager.WORKERTableAdapter = Nothing
        '
        'dgvEquip
        '
        Me.dgvEquip.AllowUserToAddRows = False
        Me.dgvEquip.AllowUserToDeleteRows = False
        Me.dgvEquip.AllowUserToOrderColumns = True
        Me.dgvEquip.AllowUserToResizeColumns = False
        Me.dgvEquip.AllowUserToResizeRows = False
        Me.dgvEquip.AutoGenerateColumns = False
        Me.dgvEquip.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEquip.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.colConsumptionAux, Me.colConsumption, Me.colTicketEquipmentId, Me.DataGridViewTextBoxColumn2})
        Me.dgvEquip.ContextMenuStrip = Me.mnuContextMain
        Me.dgvEquip.DataSource = Me.TICKETEQUIPMENT_VBindingSource
        Me.dgvEquip.Location = New System.Drawing.Point(12, 55)
        Me.dgvEquip.Name = "dgvEquip"
        Me.dgvEquip.RowHeadersWidth = 12
        Me.dgvEquip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEquip.Size = New System.Drawing.Size(1062, 464)
        Me.dgvEquip.TabIndex = 1
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EQUIPMENTID"
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 43
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DESCRIPTION"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 400
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MODEL"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn5.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SERIAL"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn6.HeaderText = "Serial"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 58
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TAG"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tag"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 51
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UNIT"
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn8.HeaderText = "Unit"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 51
        '
        'colConsumptionAux
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.colConsumptionAux.DefaultCellStyle = DataGridViewCellStyle7
        Me.colConsumptionAux.HeaderText = "Value"
        Me.colConsumptionAux.Name = "colConsumptionAux"
        '
        'colConsumption
        '
        Me.colConsumption.DataPropertyName = "CONSUMPTION"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.colConsumption.DefaultCellStyle = DataGridViewCellStyle8
        Me.colConsumption.HeaderText = "CONSUMPTION"
        Me.colConsumption.Name = "colConsumption"
        Me.colConsumption.ReadOnly = True
        Me.colConsumption.Visible = False
        '
        'colTicketEquipmentId
        '
        Me.colTicketEquipmentId.DataPropertyName = "TICKETEQUIPMENTID"
        Me.colTicketEquipmentId.HeaderText = "TICKETEQUIPMENTID"
        Me.colTicketEquipmentId.Name = "colTicketEquipmentId"
        Me.colTicketEquipmentId.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TICKETID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TICKETID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'mnuContextMain
        '
        Me.mnuContextMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConsDelete})
        Me.mnuContextMain.Name = "mnuContextMain"
        Me.mnuContextMain.Size = New System.Drawing.Size(108, 26)
        '
        'mnuConsDelete
        '
        Me.mnuConsDelete.Image = CType(resources.GetObject("mnuConsDelete.Image"), System.Drawing.Image)
        Me.mnuConsDelete.Name = "mnuConsDelete"
        Me.mnuConsDelete.Size = New System.Drawing.Size(107, 22)
        Me.mnuConsDelete.Text = "Delete"
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(12, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 28)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmTicketEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 523)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvEquip)
        Me.Name = "frmTicketEquipment"
        Me.Text = "frmTicketEquipment"
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETEQUIPMENT_VBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEquip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuContextMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SESTicketAccessDataSet As SESTicketAccessDataSet
    Friend WithEvents TICKETEQUIPMENT_VBindingSource As BindingSource
    Friend WithEvents TICKETEQUIPMENT_VTableAdapter As SESTicketAccessDataSetTableAdapters.TICKETEQUIPMENT_VTableAdapter
    Friend WithEvents TableAdapterManager As SESTicketAccessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvEquip As DataGridView
    Friend WithEvents mnuContextMain As ContextMenuStrip
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents colConsumptionAux As DataGridViewTextBoxColumn
    Friend WithEvents colConsumption As DataGridViewTextBoxColumn
    Friend WithEvents colTicketEquipmentId As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents mnuConsDelete As ToolStripMenuItem
    Friend WithEvents btnAdd As Button
End Class
