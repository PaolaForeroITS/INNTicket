<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketFile))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuNewItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.dgvTicketFile = New System.Windows.Forms.DataGridView()
        Me.colSync = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colAvailable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketFileName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketFileId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLocation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TICKETFILEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.TableAdapterManager = New SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager()
        Me.TICKETFILETableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TICKETFILETableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTicketId = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvTicketFile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETFILEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewItem, Me.mnuOpenFile, Me.mnuDeleteFile, Me.mnuRefresh, Me.mnuLog})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1065, 42)
        Me.MenuStrip1.TabIndex = 33
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
        'mnuOpenFile
        '
        Me.mnuOpenFile.Image = CType(resources.GetObject("mnuOpenFile.Image"), System.Drawing.Image)
        Me.mnuOpenFile.Name = "mnuOpenFile"
        Me.mnuOpenFile.Size = New System.Drawing.Size(85, 38)
        Me.mnuOpenFile.Text = "Open File"
        '
        'mnuDeleteFile
        '
        Me.mnuDeleteFile.Image = CType(resources.GetObject("mnuDeleteFile.Image"), System.Drawing.Image)
        Me.mnuDeleteFile.Name = "mnuDeleteFile"
        Me.mnuDeleteFile.Size = New System.Drawing.Size(89, 38)
        Me.mnuDeleteFile.Text = "Delete File"
        '
        'mnuRefresh
        '
        Me.mnuRefresh.Image = CType(resources.GetObject("mnuRefresh.Image"), System.Drawing.Image)
        Me.mnuRefresh.Name = "mnuRefresh"
        Me.mnuRefresh.Size = New System.Drawing.Size(74, 38)
        Me.mnuRefresh.Text = "Refresh"
        '
        'mnuLog
        '
        Me.mnuLog.Image = CType(resources.GetObject("mnuLog.Image"), System.Drawing.Image)
        Me.mnuLog.Name = "mnuLog"
        Me.mnuLog.Size = New System.Drawing.Size(55, 38)
        Me.mnuLog.Text = "Log"
        '
        'dgvTicketFile
        '
        Me.dgvTicketFile.AllowUserToAddRows = False
        Me.dgvTicketFile.AllowUserToDeleteRows = False
        Me.dgvTicketFile.AllowUserToResizeColumns = False
        Me.dgvTicketFile.AllowUserToResizeRows = False
        Me.dgvTicketFile.AutoGenerateColumns = False
        Me.dgvTicketFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTicketFile.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSync, Me.colAvailable, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn9, Me.colTicketFileName, Me.DataGridViewTextBoxColumn5, Me.colTicketFileId, Me.colTicketId, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn10, Me.colLocation})
        Me.dgvTicketFile.DataSource = Me.TICKETFILEBindingSource
        Me.dgvTicketFile.Location = New System.Drawing.Point(0, 45)
        Me.dgvTicketFile.MultiSelect = False
        Me.dgvTicketFile.Name = "dgvTicketFile"
        Me.dgvTicketFile.ReadOnly = True
        Me.dgvTicketFile.RowHeadersWidth = 10
        Me.dgvTicketFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTicketFile.Size = New System.Drawing.Size(1061, 472)
        Me.dgvTicketFile.TabIndex = 34
        '
        'colSync
        '
        Me.colSync.DataPropertyName = "SYNC"
        Me.colSync.HeaderText = "Sync"
        Me.colSync.Name = "colSync"
        Me.colSync.ReadOnly = True
        Me.colSync.Width = 50
        '
        'colAvailable
        '
        Me.colAvailable.DataPropertyName = "AVAILABLE"
        Me.colAvailable.HeaderText = "Ready"
        Me.colAvailable.Name = "colAvailable"
        Me.colAvailable.ReadOnly = True
        Me.colAvailable.Width = 45
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CREATEDDATETIME"
        DataGridViewCellStyle1.Format = "dd/MM/yyyy HH:mm tt"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn11.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 55
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "USERNAME"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Created By"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 84
        '
        'colTicketFileName
        '
        Me.colTicketFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTicketFileName.DataPropertyName = "TICKETFILENAME"
        Me.colTicketFileName.HeaderText = "File Name"
        Me.colTicketFileName.Name = "colTicketFileName"
        Me.colTicketFileName.ReadOnly = True
        Me.colTicketFileName.Width = 79
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "COMMENT"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Comment"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 450
        '
        'colTicketFileId
        '
        Me.colTicketFileId.DataPropertyName = "TICKETFILEID"
        Me.colTicketFileId.HeaderText = "TICKETFILEID"
        Me.colTicketFileId.Name = "colTicketFileId"
        Me.colTicketFileId.ReadOnly = True
        Me.colTicketFileId.Visible = False
        '
        'colTicketId
        '
        Me.colTicketId.DataPropertyName = "TICKETID"
        Me.colTicketId.HeaderText = "TICKETID"
        Me.colTicketId.Name = "colTicketId"
        Me.colTicketId.ReadOnly = True
        Me.colTicketId.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ACTION"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ACTION"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FILESIZE"
        Me.DataGridViewTextBoxColumn10.HeaderText = "FILESIZE"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'colLocation
        '
        Me.colLocation.DataPropertyName = "LOCATION"
        Me.colLocation.HeaderText = "Stored"
        Me.colLocation.Name = "colLocation"
        Me.colLocation.ReadOnly = True
        Me.colLocation.Visible = False
        '
        'TICKETFILEBindingSource
        '
        Me.TICKETFILEBindingSource.DataMember = "TICKETFILE"
        Me.TICKETFILEBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
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
        'TICKETFILETableAdapter
        '
        Me.TICKETFILETableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(711, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Ticket:"
        '
        'txtTicketId
        '
        Me.txtTicketId.BackColor = System.Drawing.Color.FloralWhite
        Me.txtTicketId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTicketId.ForeColor = System.Drawing.Color.Red
        Me.txtTicketId.Location = New System.Drawing.Point(757, 17)
        Me.txtTicketId.Name = "txtTicketId"
        Me.txtTicketId.ReadOnly = True
        Me.txtTicketId.Size = New System.Drawing.Size(100, 20)
        Me.txtTicketId.TabIndex = 36
        '
        'frmTicketFile
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1065, 519)
        Me.Controls.Add(Me.txtTicketId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvTicketFile)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTicketFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTicket - Attachment"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvTicketFile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETFILEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNewItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpenFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDeleteFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SESTicketAccessDataSet As SESTicket.SESTicketAccessDataSet
    Friend WithEvents TICKETFILEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TICKETFILETableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.TICKETFILETableAdapter
    Friend WithEvents dgvTicketFile As System.Windows.Forms.DataGridView
    Friend WithEvents mnuRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTicketId As System.Windows.Forms.TextBox
    Friend WithEvents colSync As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colAvailable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTicketFileName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTicketFileId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTicketId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLocation As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
