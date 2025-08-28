<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCloseTicketDB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCloseTicketDB))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuCloseTicket = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.TMP_TICKETCLOSEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TMP_TICKETCLOSETableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TMP_TICKETCLOSETableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager()
        Me.dgvTicketClose = New System.Windows.Forms.DataGridView()
        Me.colTicketId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceTicket = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHasServiceType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHasInvItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colResult = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkTicketNoInventory = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TMP_TICKETCLOSEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTicketClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCloseTicket, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(935, 52)
        Me.MenuStrip1.TabIndex = 42
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuCloseTicket
        '
        Me.mnuCloseTicket.Image = CType(resources.GetObject("mnuCloseTicket.Image"), System.Drawing.Image)
        Me.mnuCloseTicket.Name = "mnuCloseTicket"
        Me.mnuCloseTicket.Size = New System.Drawing.Size(122, 48)
        Me.mnuCloseTicket.Text = "Close Ticket"
        '
        'mnuExit
        '
        Me.mnuExit.Image = CType(resources.GetObject("mnuExit.Image"), System.Drawing.Image)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(67, 48)
        Me.mnuExit.Text = "Exit"
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'TMP_TICKETCLOSEBindingSource
        '
        Me.TMP_TICKETCLOSEBindingSource.DataMember = "TMP_TICKETCLOSE"
        Me.TMP_TICKETCLOSEBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'TMP_TICKETCLOSETableAdapter
        '
        Me.TMP_TICKETCLOSETableAdapter.ClearBeforeFill = True
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
        'dgvTicketClose
        '
        Me.dgvTicketClose.AllowUserToAddRows = False
        Me.dgvTicketClose.AllowUserToDeleteRows = False
        Me.dgvTicketClose.AllowUserToResizeColumns = False
        Me.dgvTicketClose.AllowUserToResizeRows = False
        Me.dgvTicketClose.AutoGenerateColumns = False
        Me.dgvTicketClose.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvTicketClose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTicketClose.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTicketId, Me.colServiceTicket, Me.colHasServiceType, Me.colHasInvItem, Me.colResult})
        Me.dgvTicketClose.DataSource = Me.TMP_TICKETCLOSEBindingSource
        Me.dgvTicketClose.Location = New System.Drawing.Point(0, 55)
        Me.dgvTicketClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvTicketClose.Name = "dgvTicketClose"
        Me.dgvTicketClose.ReadOnly = True
        Me.dgvTicketClose.RowHeadersWidth = 15
        Me.dgvTicketClose.Size = New System.Drawing.Size(933, 510)
        Me.dgvTicketClose.TabIndex = 43
        '
        'colTicketId
        '
        Me.colTicketId.DataPropertyName = "TICKETID"
        Me.colTicketId.HeaderText = "Ticket ID"
        Me.colTicketId.MinimumWidth = 6
        Me.colTicketId.Name = "colTicketId"
        Me.colTicketId.ReadOnly = True
        Me.colTicketId.Width = 125
        '
        'colServiceTicket
        '
        Me.colServiceTicket.DataPropertyName = "SUPERIORNUM"
        Me.colServiceTicket.HeaderText = "Service Ticket"
        Me.colServiceTicket.MinimumWidth = 6
        Me.colServiceTicket.Name = "colServiceTicket"
        Me.colServiceTicket.ReadOnly = True
        Me.colServiceTicket.Width = 125
        '
        'colHasServiceType
        '
        Me.colHasServiceType.DataPropertyName = "HASSERVICETYPE"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colHasServiceType.DefaultCellStyle = DataGridViewCellStyle1
        Me.colHasServiceType.HeaderText = "Has ServiceType?"
        Me.colHasServiceType.MinimumWidth = 6
        Me.colHasServiceType.Name = "colHasServiceType"
        Me.colHasServiceType.ReadOnly = True
        Me.colHasServiceType.Width = 80
        '
        'colHasInvItem
        '
        Me.colHasInvItem.DataPropertyName = "HASINVENTORY"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colHasInvItem.DefaultCellStyle = DataGridViewCellStyle2
        Me.colHasInvItem.HeaderText = "Has Inventory?"
        Me.colHasInvItem.MinimumWidth = 6
        Me.colHasInvItem.Name = "colHasInvItem"
        Me.colHasInvItem.ReadOnly = True
        Me.colHasInvItem.Width = 80
        '
        'colResult
        '
        Me.colResult.DataPropertyName = "RESULT"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colResult.DefaultCellStyle = DataGridViewCellStyle3
        Me.colResult.HeaderText = "Process Result"
        Me.colResult.MinimumWidth = 6
        Me.colResult.Name = "colResult"
        Me.colResult.ReadOnly = True
        Me.colResult.Width = 300
        '
        'chkTicketNoInventory
        '
        Me.chkTicketNoInventory.AutoSize = True
        Me.chkTicketNoInventory.ForeColor = System.Drawing.Color.Maroon
        Me.chkTicketNoInventory.Location = New System.Drawing.Point(659, 27)
        Me.chkTicketNoInventory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkTicketNoInventory.Name = "chkTicketNoInventory"
        Me.chkTicketNoInventory.Size = New System.Drawing.Size(252, 20)
        Me.chkTicketNoInventory.TabIndex = 44
        Me.chkTicketNoInventory.Text = "Force Close Tickets with No Inventory"
        Me.chkTicketNoInventory.UseVisualStyleBackColor = True
        '
        'frmCloseTicketDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(935, 567)
        Me.Controls.Add(Me.chkTicketNoInventory)
        Me.Controls.Add(Me.dgvTicketClose)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCloseTicketDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INNTicket - Close Tickets"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TMP_TICKETCLOSEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTicketClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuCloseTicket As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents SESTicketAccessDataSet As SESTicketAccessDataSet
    Friend WithEvents TMP_TICKETCLOSEBindingSource As BindingSource
    Friend WithEvents TMP_TICKETCLOSETableAdapter As SESTicketAccessDataSetTableAdapters.TMP_TICKETCLOSETableAdapter
    Friend WithEvents TableAdapterManager As SESTicketAccessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvTicketClose As DataGridView
    Friend WithEvents chkTicketNoInventory As CheckBox
    Friend WithEvents colTicketId As DataGridViewTextBoxColumn
    Friend WithEvents colServiceTicket As DataGridViewTextBoxColumn
    Friend WithEvents colHasServiceType As DataGridViewTextBoxColumn
    Friend WithEvents colHasInvItem As DataGridViewTextBoxColumn
    Friend WithEvents colResult As DataGridViewTextBoxColumn
End Class
