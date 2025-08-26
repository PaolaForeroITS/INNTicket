<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchEquipment
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchEquipment))
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.EQUIPMENTTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.EQUIPMENTTableAdapter()
        Me.dgvEquipment = New System.Windows.Forms.DataGridView()
        Me.colEquipmentId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colModel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSerial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EQUIPMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.mnuPrincip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuContextOk = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEquipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuPrincip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'EQUIPMENTTableAdapter
        '
        Me.EQUIPMENTTableAdapter.ClearBeforeFill = True
        '
        'dgvEquipment
        '
        Me.dgvEquipment.AllowUserToAddRows = False
        Me.dgvEquipment.AllowUserToDeleteRows = False
        Me.dgvEquipment.AutoGenerateColumns = False
        Me.dgvEquipment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEquipment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEquipmentId, Me.colDescription, Me.colModel, Me.colSerial, Me.colTag})
        Me.dgvEquipment.ContextMenuStrip = Me.mnuPrincip
        Me.dgvEquipment.DataSource = Me.EQUIPMENTBindingSource
        Me.dgvEquipment.Location = New System.Drawing.Point(12, 44)
        Me.dgvEquipment.Name = "dgvEquipment"
        Me.dgvEquipment.ReadOnly = True
        Me.dgvEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEquipment.Size = New System.Drawing.Size(913, 629)
        Me.dgvEquipment.TabIndex = 11
        '
        'colEquipmentId
        '
        Me.colEquipmentId.DataPropertyName = "EQUIPMENTID"
        Me.colEquipmentId.HeaderText = "Item"
        Me.colEquipmentId.Name = "colEquipmentId"
        Me.colEquipmentId.ReadOnly = True
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "DESCRIPTION"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDescription.DefaultCellStyle = DataGridViewCellStyle3
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.Width = 420
        '
        'colModel
        '
        Me.colModel.DataPropertyName = "MODEL"
        Me.colModel.HeaderText = "Model"
        Me.colModel.Name = "colModel"
        Me.colModel.ReadOnly = True
        Me.colModel.Width = 80
        '
        'colSerial
        '
        Me.colSerial.DataPropertyName = "SERIAL"
        Me.colSerial.HeaderText = "Serial"
        Me.colSerial.Name = "colSerial"
        Me.colSerial.ReadOnly = True
        Me.colSerial.Width = 80
        '
        'colTag
        '
        Me.colTag.DataPropertyName = "TAG"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colTag.DefaultCellStyle = DataGridViewCellStyle4
        Me.colTag.HeaderText = "Tag"
        Me.colTag.Name = "colTag"
        Me.colTag.ReadOnly = True
        Me.colTag.Width = 120
        '
        'EQUIPMENTBindingSource
        '
        Me.EQUIPMENTBindingSource.DataMember = "EQUIPMENT"
        Me.EQUIPMENTBindingSource.DataSource = Me.SESTicketAccessDataSet
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(364, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(50, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(308, 20)
        Me.txtSearch.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Text:"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(457, 12)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 18
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'mnuPrincip
        '
        Me.mnuPrincip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuContextOk})
        Me.mnuPrincip.Name = "mnuPrincip"
        Me.mnuPrincip.Size = New System.Drawing.Size(90, 26)
        '
        'mnuContextOk
        '
        Me.mnuContextOk.Image = CType(resources.GetObject("mnuContextOk.Image"), System.Drawing.Image)
        Me.mnuContextOk.Name = "mnuContextOk"
        Me.mnuContextOk.Size = New System.Drawing.Size(89, 22)
        Me.mnuContextOk.Text = "Ok"
        '
        'frmSearchEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(932, 678)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvEquipment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchEquipment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Equipment"
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEquipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuPrincip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SESTicketAccessDataSet As SESTicket.SESTicketAccessDataSet
    Friend WithEvents EQUIPMENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPMENTTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.EQUIPMENTTableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvEquipment As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnOk As Button
    Friend WithEvents colEquipmentId As DataGridViewTextBoxColumn
    Friend WithEvents colDescription As DataGridViewTextBoxColumn
    Friend WithEvents colModel As DataGridViewTextBoxColumn
    Friend WithEvents colSerial As DataGridViewTextBoxColumn
    Friend WithEvents colTag As DataGridViewTextBoxColumn
    Friend WithEvents mnuPrincip As ContextMenuStrip
    Friend WithEvents mnuContextOk As ToolStripMenuItem
End Class
