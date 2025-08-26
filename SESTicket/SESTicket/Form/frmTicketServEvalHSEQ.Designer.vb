<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketServEvalHSEQ
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketServEvalHSEQ))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuNewItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HSEQToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrintServEval = New System.Windows.Forms.ToolStripMenuItem()
        Me.HSEQToolStripMenuIPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TICKETSERVEVAL_HSEQBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.TICKETSERVEVALECPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TICKETSERVEVAL_HSEQTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TICKETSERVEVAL_HSEQTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager()
        Me.TICKETSERVEVAL_ECPTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TICKETSERVEVAL_ECPTableAdapter()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvTicketEvalHSEQ = New System.Windows.Forms.DataGridView()
        Me.colEvalGeneralPercep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEvalHSEQPerf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEvalComunication = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEvalEquipment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEvalPersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketServEvalId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colObs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEvalGeneralPercep2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEvalHSEQPerf2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEvalComunication2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEvalEquipment2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEvalPersonal2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServDescrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.TICKETSERVEVAL_HSEQBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETSERVEVALECPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvTicketEvalHSEQ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewItem, Me.mnuPrintServEval})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1100, 42)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuNewItem
        '
        Me.mnuNewItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HSEQToolStripMenuItem})
        Me.mnuNewItem.Image = CType(resources.GetObject("mnuNewItem.Image"), System.Drawing.Image)
        Me.mnuNewItem.Name = "mnuNewItem"
        Me.mnuNewItem.Size = New System.Drawing.Size(161, 38)
        Me.mnuNewItem.Text = "New Service Evaluation"
        '
        'HSEQToolStripMenuItem
        '
        Me.HSEQToolStripMenuItem.Name = "HSEQToolStripMenuItem"
        Me.HSEQToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HSEQToolStripMenuItem.Text = "HSEQ"
        '
        'mnuPrintServEval
        '
        Me.mnuPrintServEval.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HSEQToolStripMenuIPrint})
        Me.mnuPrintServEval.Image = CType(resources.GetObject("mnuPrintServEval.Image"), System.Drawing.Image)
        Me.mnuPrintServEval.Name = "mnuPrintServEval"
        Me.mnuPrintServEval.Size = New System.Drawing.Size(162, 38)
        Me.mnuPrintServEval.Text = "Print Service Evaluation"
        '
        'HSEQToolStripMenuIPrint
        '
        Me.HSEQToolStripMenuIPrint.Name = "HSEQToolStripMenuIPrint"
        Me.HSEQToolStripMenuIPrint.Size = New System.Drawing.Size(180, 22)
        Me.HSEQToolStripMenuIPrint.Text = "HSEQ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Brown
        Me.Label1.Location = New System.Drawing.Point(405, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 52)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Instructions: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1) Create a ""New Service Evaluation""." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2) Select the line and ""Pr" &
    "int Service Evaluation""." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3) After received the customer answers, edit the Servi" &
    "ce Evaluation filling in the fields."
        '
        'TICKETSERVEVAL_HSEQBindingSource
        '
        Me.TICKETSERVEVAL_HSEQBindingSource.DataMember = "TICKETSERVEVAL_HSEQ"
        Me.TICKETSERVEVAL_HSEQBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'TICKETSERVEVALECPBindingSource
        '
        Me.TICKETSERVEVALECPBindingSource.DataMember = "TICKETSERVEVAL_ECP"
        Me.TICKETSERVEVALECPBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'TICKETSERVEVAL_HSEQTableAdapter
        '
        Me.TICKETSERVEVAL_HSEQTableAdapter.ClearBeforeFill = True
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
        'TICKETSERVEVAL_ECPTableAdapter
        '
        Me.TICKETSERVEVAL_ECPTableAdapter.ClearBeforeFill = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvTicketEvalHSEQ)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(1073, 416)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "HSEQ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvTicketEvalHSEQ
        '
        Me.dgvTicketEvalHSEQ.AllowUserToAddRows = False
        Me.dgvTicketEvalHSEQ.AllowUserToDeleteRows = False
        Me.dgvTicketEvalHSEQ.AutoGenerateColumns = False
        Me.dgvTicketEvalHSEQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTicketEvalHSEQ.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colServiceDate, Me.colServDescrip, Me.colEvalPersonal2, Me.colEvalEquipment2, Me.colEvalComunication2, Me.colEvalHSEQPerf2, Me.colEvalGeneralPercep2, Me.colObs, Me.colTicketServEvalId, Me.colTicketId, Me.colActive, Me.colEvalPersonal, Me.colEvalEquipment, Me.colEvalComunication, Me.colEvalHSEQPerf, Me.colEvalGeneralPercep})
        Me.dgvTicketEvalHSEQ.DataSource = Me.TICKETSERVEVAL_HSEQBindingSource
        Me.dgvTicketEvalHSEQ.Location = New System.Drawing.Point(0, 0)
        Me.dgvTicketEvalHSEQ.Name = "dgvTicketEvalHSEQ"
        Me.dgvTicketEvalHSEQ.ReadOnly = True
        Me.dgvTicketEvalHSEQ.RowHeadersWidth = 15
        Me.dgvTicketEvalHSEQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTicketEvalHSEQ.Size = New System.Drawing.Size(1072, 418)
        Me.dgvTicketEvalHSEQ.TabIndex = 2
        '
        'colEvalGeneralPercep
        '
        Me.colEvalGeneralPercep.DataPropertyName = "EVAL_GENERALPERCEP"
        Me.colEvalGeneralPercep.HeaderText = "EVAL_GENERALPERCEP"
        Me.colEvalGeneralPercep.Name = "colEvalGeneralPercep"
        Me.colEvalGeneralPercep.ReadOnly = True
        Me.colEvalGeneralPercep.Visible = False
        '
        'colEvalHSEQPerf
        '
        Me.colEvalHSEQPerf.DataPropertyName = "EVAL_HSEQ_PERF"
        Me.colEvalHSEQPerf.HeaderText = "EVAL_HSEQ_PERF"
        Me.colEvalHSEQPerf.Name = "colEvalHSEQPerf"
        Me.colEvalHSEQPerf.ReadOnly = True
        Me.colEvalHSEQPerf.Visible = False
        '
        'colEvalComunication
        '
        Me.colEvalComunication.DataPropertyName = "EVAL_COMUNICATION"
        Me.colEvalComunication.HeaderText = "EVAL_COMUNICATION"
        Me.colEvalComunication.Name = "colEvalComunication"
        Me.colEvalComunication.ReadOnly = True
        Me.colEvalComunication.Visible = False
        '
        'colEvalEquipment
        '
        Me.colEvalEquipment.DataPropertyName = "EVAL_EQUIPMENT"
        Me.colEvalEquipment.HeaderText = "EVAL_EQUIPMENT"
        Me.colEvalEquipment.Name = "colEvalEquipment"
        Me.colEvalEquipment.ReadOnly = True
        Me.colEvalEquipment.Visible = False
        '
        'colEvalPersonal
        '
        Me.colEvalPersonal.DataPropertyName = "EVAL_PERSONAL"
        Me.colEvalPersonal.HeaderText = "EVAL_PERSONAL"
        Me.colEvalPersonal.Name = "colEvalPersonal"
        Me.colEvalPersonal.ReadOnly = True
        Me.colEvalPersonal.Visible = False
        '
        'colActive
        '
        Me.colActive.DataPropertyName = "ACTIVE"
        Me.colActive.HeaderText = "ACTIVE"
        Me.colActive.Name = "colActive"
        Me.colActive.ReadOnly = True
        Me.colActive.Visible = False
        '
        'colTicketId
        '
        Me.colTicketId.DataPropertyName = "TICKETID"
        Me.colTicketId.HeaderText = "TICKETID"
        Me.colTicketId.Name = "colTicketId"
        Me.colTicketId.ReadOnly = True
        Me.colTicketId.Visible = False
        '
        'colTicketServEvalId
        '
        Me.colTicketServEvalId.DataPropertyName = "TICKETSERVEVALID"
        Me.colTicketServEvalId.HeaderText = "TICKETSERVEVALID"
        Me.colTicketServEvalId.Name = "colTicketServEvalId"
        Me.colTicketServEvalId.ReadOnly = True
        Me.colTicketServEvalId.Visible = False
        '
        'colObs
        '
        Me.colObs.DataPropertyName = "OBS"
        Me.colObs.HeaderText = "Obs"
        Me.colObs.Name = "colObs"
        Me.colObs.ReadOnly = True
        Me.colObs.Width = 280
        '
        'colEvalGeneralPercep2
        '
        Me.colEvalGeneralPercep2.DataPropertyName = "EVAL_GENERALPERCEP_DESC"
        Me.colEvalGeneralPercep2.HeaderText = "General Perception"
        Me.colEvalGeneralPercep2.Name = "colEvalGeneralPercep2"
        Me.colEvalGeneralPercep2.ReadOnly = True
        Me.colEvalGeneralPercep2.Width = 85
        '
        'colEvalHSEQPerf2
        '
        Me.colEvalHSEQPerf2.DataPropertyName = "EVAL_HSEQ_PERF_DESC"
        Me.colEvalHSEQPerf2.HeaderText = "HSEQ Performance"
        Me.colEvalHSEQPerf2.Name = "colEvalHSEQPerf2"
        Me.colEvalHSEQPerf2.ReadOnly = True
        Me.colEvalHSEQPerf2.Width = 85
        '
        'colEvalComunication2
        '
        Me.colEvalComunication2.DataPropertyName = "EVAL_COMUNICATION_DESC"
        Me.colEvalComunication2.HeaderText = "Comunication"
        Me.colEvalComunication2.Name = "colEvalComunication2"
        Me.colEvalComunication2.ReadOnly = True
        Me.colEvalComunication2.Width = 85
        '
        'colEvalEquipment2
        '
        Me.colEvalEquipment2.DataPropertyName = "EVAL_EQUIPMENT_DESC"
        Me.colEvalEquipment2.HeaderText = "Equipment"
        Me.colEvalEquipment2.Name = "colEvalEquipment2"
        Me.colEvalEquipment2.ReadOnly = True
        Me.colEvalEquipment2.Width = 85
        '
        'colEvalPersonal2
        '
        Me.colEvalPersonal2.DataPropertyName = "EVAL_PERSONAL_DESC"
        Me.colEvalPersonal2.HeaderText = "Personal"
        Me.colEvalPersonal2.Name = "colEvalPersonal2"
        Me.colEvalPersonal2.ReadOnly = True
        Me.colEvalPersonal2.Width = 85
        '
        'colServDescrip
        '
        Me.colServDescrip.DataPropertyName = "SERVDESCRIP"
        Me.colServDescrip.HeaderText = "Description"
        Me.colServDescrip.Name = "colServDescrip"
        Me.colServDescrip.ReadOnly = True
        Me.colServDescrip.Width = 220
        '
        'colServiceDate
        '
        Me.colServiceDate.DataPropertyName = "SERVICEDATE"
        DataGridViewCellStyle1.Format = "dd/MM/yyyy"
        Me.colServiceDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.colServiceDate.HeaderText = "Service Date"
        Me.colServiceDate.Name = "colServiceDate"
        Me.colServiceDate.ReadOnly = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(10, 72)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1081, 442)
        Me.TabControl1.TabIndex = 37
        '
        'frmTicketServEvalHSEQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1100, 523)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmTicketServEvalHSEQ"
        Me.Text = "frmTicketServEvalHSEQ"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.TICKETSERVEVAL_HSEQBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETSERVEVALECPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvTicketEvalHSEQ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SESTicketAccessDataSet As SESTicket.SESTicketAccessDataSet
    Friend WithEvents TICKETSERVEVAL_HSEQBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TICKETSERVEVAL_HSEQTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.TICKETSERVEVAL_HSEQTableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNewItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrintServEval As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HSEQToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TICKETSERVEVALECPBindingSource As BindingSource
    Friend WithEvents TICKETSERVEVAL_ECPTableAdapter As SESTicketAccessDataSetTableAdapters.TICKETSERVEVAL_ECPTableAdapter
    Friend WithEvents HSEQToolStripMenuIPrint As ToolStripMenuItem
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvTicketEvalHSEQ As DataGridView
    Friend WithEvents colServiceDate As DataGridViewTextBoxColumn
    Friend WithEvents colServDescrip As DataGridViewTextBoxColumn
    Friend WithEvents colEvalPersonal2 As DataGridViewTextBoxColumn
    Friend WithEvents colEvalEquipment2 As DataGridViewTextBoxColumn
    Friend WithEvents colEvalComunication2 As DataGridViewTextBoxColumn
    Friend WithEvents colEvalHSEQPerf2 As DataGridViewTextBoxColumn
    Friend WithEvents colEvalGeneralPercep2 As DataGridViewTextBoxColumn
    Friend WithEvents colObs As DataGridViewTextBoxColumn
    Friend WithEvents colTicketServEvalId As DataGridViewTextBoxColumn
    Friend WithEvents colTicketId As DataGridViewTextBoxColumn
    Friend WithEvents colActive As DataGridViewTextBoxColumn
    Friend WithEvents colEvalPersonal As DataGridViewTextBoxColumn
    Friend WithEvents colEvalEquipment As DataGridViewTextBoxColumn
    Friend WithEvents colEvalComunication As DataGridViewTextBoxColumn
    Friend WithEvents colEvalHSEQPerf As DataGridViewTextBoxColumn
    Friend WithEvents colEvalGeneralPercep As DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
End Class
