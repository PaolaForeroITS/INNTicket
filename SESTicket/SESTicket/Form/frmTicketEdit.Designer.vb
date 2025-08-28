<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketEdit))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearchSite = New System.Windows.Forms.Button()
        Me.txtSiteId = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnSearchRig = New System.Windows.Forms.Button()
        Me.txtWellName = New System.Windows.Forms.TextBox()
        Me.btnSearchWell = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRig = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.gpbServiceDate = New System.Windows.Forms.GroupBox()
        Me.dtpServiceDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txtContrRepres = New System.Windows.Forms.TextBox()
        Me.btnSearchWorker = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtContrComments = New System.Windows.Forms.TextBox()
        Me.grpServiceType = New System.Windows.Forms.GroupBox()
        Me.dgvTicketServType = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketServiceTypeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TICKETSERVICETYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.btnDeleteServiceLine = New System.Windows.Forms.Button()
        Me.btnAddServiceType = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxServiceType = New System.Windows.Forms.ComboBox()
        Me.SERVICETYPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtJobDescription = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtCustRepresAssistPos = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCustComments = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCustRepresPosition = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCustRepresAssist = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCustRepres = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dtpTimeCompleted = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpTimeArrived = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpTimeStarted = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tabSalesItem = New System.Windows.Forms.TabPage()
        Me.pnlSalesItem = New System.Windows.Forms.Panel()
        Me.tabEquipments = New System.Windows.Forms.TabPage()
        Me.pnlEquipment = New System.Windows.Forms.Panel()
        Me.tabWorkers = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.dgvTicketOpeHour = New System.Windows.Forms.DataGridView()
        Me.colOpHourTravel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOpHourOperation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOpHourStandby = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOpHourLost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOpHourQde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TICKETOPEHOURBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btnWAdd = New System.Windows.Forms.Button()
        Me.dgvWorker = New System.Windows.Forms.DataGridView()
        Me.colWFullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWAppoint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWRegisterDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHourTravel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHourOperation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHourStandby = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHourLost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWHourQde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colResumeActivity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWWorkerId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWTicketWorkerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TICKETWORKERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabOperReport = New System.Windows.Forms.TabPage()
        Me.pnlOperReport = New System.Windows.Forms.Panel()
        Me.tabServEvalHSEQ = New System.Windows.Forms.TabPage()
        Me.pnlHSEQServEval = New System.Windows.Forms.Panel()
        Me.tabAdicInform = New System.Windows.Forms.TabPage()
        Me.grpAddicInfoARG = New System.Windows.Forms.GroupBox()
        Me.txtSuperiorSupervisor = New System.Windows.Forms.TextBox()
        Me.btnSearchSupervisor = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSONumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJobNumber = New System.Windows.Forms.TextBox()
        Me.txtDM = New System.Windows.Forms.TextBox()
        Me.txtSupNum = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtMaxDepth = New System.Windows.Forms.TextBox()
        Me.txtMaxPressure = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbxTubingGrade = New System.Windows.Forms.ComboBox()
        Me.TUBINGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxTubingWeight = New System.Windows.Forms.ComboBox()
        Me.TUBBINGWEIGHTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxTubingPipe = New System.Windows.Forms.ComboBox()
        Me.TUBBINGDRILLPIPEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbxCasingGrade = New System.Windows.Forms.ComboBox()
        Me.CASINGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxCasingWeight = New System.Windows.Forms.ComboBox()
        Me.CASINGWEIGHTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxCasingSize = New System.Windows.Forms.ComboBox()
        Me.CASINGSIZEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtAdicInform = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuSaveTicket = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketSalesItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuActaIniFimOpe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuJobLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.FronteraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInvItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCloseTicket = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAttachment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlTicket = New System.Windows.Forms.Panel()
        Me.lblServiceLine = New System.Windows.Forms.Label()
        Me.cbxServiceLine = New System.Windows.Forms.ComboBox()
        Me.SERVLINECUSTVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxContract = New System.Windows.Forms.ComboBox()
        Me.CONTRACTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxCurrency = New System.Windows.Forms.ComboBox()
        Me.CURRENCYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblCurrency = New System.Windows.Forms.Label()
        Me.lblContract = New System.Windows.Forms.Label()
        Me.cbxCustomer = New System.Windows.Forms.ComboBox()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtTicketNumber = New System.Windows.Forms.TextBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblTicketNumber = New System.Windows.Forms.Label()
        Me.CUSTOMERTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.CUSTOMERTableAdapter()
        Me.SERVICETYPETableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.SERVICETYPETableAdapter()
        Me.CURRENCYTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.CURRENCYTableAdapter()
        Me.TUBINGTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TUBINGTableAdapter()
        Me.CASINGTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.CASINGTableAdapter()
        Me.CONTRACTTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.CONTRACTTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager()
        Me.TICKETWORKERTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TICKETWORKERTableAdapter()
        Me.pnlTicketCanceled = New System.Windows.Forms.Panel()
        Me.btnCancelDet = New System.Windows.Forms.Button()
        Me.lblTicketCancelDet = New System.Windows.Forms.Label()
        Me.TUBBING_DRILLPIPETableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TUBBING_DRILLPIPETableAdapter()
        Me.TUBBING_WEIGHTTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TUBBING_WEIGHTTableAdapter()
        Me.CASING_SIZETableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.CASING_SIZETableAdapter()
        Me.CASING_WEIGHTTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.CASING_WEIGHTTableAdapter()
        Me.SERVLINE_CUST_VTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.SERVLINE_CUST_VTableAdapter()
        Me.TICKETSERVICETYPETableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TICKETSERVICETYPETableAdapter()
        Me.TICKETOPEHOURTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TICKETOPEHOURTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gpbServiceDate.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.grpServiceType.SuspendLayout()
        CType(Me.dgvTicketServType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETSERVICETYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERVICETYPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.tabSalesItem.SuspendLayout()
        Me.tabEquipments.SuspendLayout()
        Me.tabWorkers.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.dgvTicketOpeHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETOPEHOURBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.dgvWorker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETWORKERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOperReport.SuspendLayout()
        Me.tabServEvalHSEQ.SuspendLayout()
        Me.tabAdicInform.SuspendLayout()
        Me.grpAddicInfoARG.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TUBINGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TUBBINGWEIGHTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TUBBINGDRILLPIPEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CASINGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CASINGWEIGHTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CASINGSIZEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlTicket.SuspendLayout()
        CType(Me.SERVLINECUSTVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRACTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CURRENCYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTicketCanceled.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.tabSalesItem)
        Me.TabControl1.Controls.Add(Me.tabEquipments)
        Me.TabControl1.Controls.Add(Me.tabWorkers)
        Me.TabControl1.Controls.Add(Me.tabOperReport)
        Me.TabControl1.Controls.Add(Me.tabServEvalHSEQ)
        Me.TabControl1.Controls.Add(Me.tabAdicInform)
        Me.TabControl1.Location = New System.Drawing.Point(8, 140)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1493, 686)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.gpbServiceDate)
        Me.TabPage1.Controls.Add(Me.GroupBox10)
        Me.TabPage1.Controls.Add(Me.grpServiceType)
        Me.TabPage1.Controls.Add(Me.GroupBox6)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(1485, 657)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearchSite)
        Me.GroupBox1.Controls.Add(Me.txtSiteId)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.btnSearchRig)
        Me.GroupBox1.Controls.Add(Me.txtWellName)
        Me.GroupBox1.Controls.Add(Me.btnSearchWell)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtRig)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Location = New System.Drawing.Point(864, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(608, 73)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'btnSearchSite
        '
        Me.btnSearchSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchSite.Location = New System.Drawing.Point(549, 37)
        Me.btnSearchSite.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchSite.Name = "btnSearchSite"
        Me.btnSearchSite.Size = New System.Drawing.Size(36, 28)
        Me.btnSearchSite.TabIndex = 21
        Me.btnSearchSite.Text = "..."
        Me.btnSearchSite.UseVisualStyleBackColor = True
        '
        'txtSiteId
        '
        Me.txtSiteId.BackColor = System.Drawing.Color.White
        Me.txtSiteId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSiteId.Location = New System.Drawing.Point(432, 41)
        Me.txtSiteId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSiteId.Name = "txtSiteId"
        Me.txtSiteId.ReadOnly = True
        Me.txtSiteId.Size = New System.Drawing.Size(110, 22)
        Me.txtSiteId.TabIndex = 19
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label30.Location = New System.Drawing.Point(428, 22)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(73, 16)
        Me.Label30.TabIndex = 20
        Me.Label30.Text = "Ticket Site:"
        '
        'btnSearchRig
        '
        Me.btnSearchRig.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchRig.Location = New System.Drawing.Point(381, 38)
        Me.btnSearchRig.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchRig.Name = "btnSearchRig"
        Me.btnSearchRig.Size = New System.Drawing.Size(36, 28)
        Me.btnSearchRig.TabIndex = 18
        Me.btnSearchRig.Text = "..."
        Me.btnSearchRig.UseVisualStyleBackColor = True
        '
        'txtWellName
        '
        Me.txtWellName.BackColor = System.Drawing.Color.White
        Me.txtWellName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWellName.Location = New System.Drawing.Point(16, 41)
        Me.txtWellName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWellName.Name = "txtWellName"
        Me.txtWellName.ReadOnly = True
        Me.txtWellName.Size = New System.Drawing.Size(154, 22)
        Me.txtWellName.TabIndex = 16
        '
        'btnSearchWell
        '
        Me.btnSearchWell.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchWell.Location = New System.Drawing.Point(177, 38)
        Me.btnSearchWell.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchWell.Name = "btnSearchWell"
        Me.btnSearchWell.Size = New System.Drawing.Size(36, 28)
        Me.btnSearchWell.TabIndex = 17
        Me.btnSearchWell.Text = "..."
        Me.btnSearchWell.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Well:"
        '
        'txtRig
        '
        Me.txtRig.BackColor = System.Drawing.Color.White
        Me.txtRig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRig.Location = New System.Drawing.Point(228, 41)
        Me.txtRig.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRig.Name = "txtRig"
        Me.txtRig.ReadOnly = True
        Me.txtRig.Size = New System.Drawing.Size(147, 22)
        Me.txtRig.TabIndex = 11
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(223, 22)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(31, 16)
        Me.Label24.TabIndex = 15
        Me.Label24.Text = "Rig:"
        '
        'gpbServiceDate
        '
        Me.gpbServiceDate.BackColor = System.Drawing.SystemColors.Control
        Me.gpbServiceDate.Controls.Add(Me.dtpServiceDate)
        Me.gpbServiceDate.Controls.Add(Me.Label7)
        Me.gpbServiceDate.Location = New System.Drawing.Point(21, 9)
        Me.gpbServiceDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpbServiceDate.Name = "gpbServiceDate"
        Me.gpbServiceDate.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpbServiceDate.Size = New System.Drawing.Size(163, 71)
        Me.gpbServiceDate.TabIndex = 38
        Me.gpbServiceDate.TabStop = False
        '
        'dtpServiceDate
        '
        Me.dtpServiceDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpServiceDate.Location = New System.Drawing.Point(16, 39)
        Me.dtpServiceDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpServiceDate.Name = "dtpServiceDate"
        Me.dtpServiceDate.Size = New System.Drawing.Size(127, 22)
        Me.dtpServiceDate.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 20)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Service Date:"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtContrRepres)
        Me.GroupBox10.Controls.Add(Me.btnSearchWorker)
        Me.GroupBox10.Controls.Add(Me.Label22)
        Me.GroupBox10.Controls.Add(Me.Label23)
        Me.GroupBox10.Controls.Add(Me.txtContrComments)
        Me.GroupBox10.Location = New System.Drawing.Point(21, 87)
        Me.GroupBox10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox10.Size = New System.Drawing.Size(835, 198)
        Me.GroupBox10.TabIndex = 37
        Me.GroupBox10.TabStop = False
        '
        'txtContrRepres
        '
        Me.txtContrRepres.BackColor = System.Drawing.Color.White
        Me.txtContrRepres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContrRepres.Location = New System.Drawing.Point(8, 34)
        Me.txtContrRepres.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContrRepres.Name = "txtContrRepres"
        Me.txtContrRepres.ReadOnly = True
        Me.txtContrRepres.Size = New System.Drawing.Size(439, 22)
        Me.txtContrRepres.TabIndex = 20
        '
        'btnSearchWorker
        '
        Me.btnSearchWorker.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchWorker.Location = New System.Drawing.Point(455, 32)
        Me.btnSearchWorker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchWorker.Name = "btnSearchWorker"
        Me.btnSearchWorker.Size = New System.Drawing.Size(36, 28)
        Me.btnSearchWorker.TabIndex = 21
        Me.btnSearchWorker.Text = "..."
        Me.btnSearchWorker.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(9, 16)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(166, 16)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "Contractor Representative:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(9, 69)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(138, 16)
        Me.Label23.TabIndex = 14
        Me.Label23.Text = "Contractor Comments:"
        '
        'txtContrComments
        '
        Me.txtContrComments.Location = New System.Drawing.Point(8, 89)
        Me.txtContrComments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtContrComments.MaxLength = 1000
        Me.txtContrComments.Multiline = True
        Me.txtContrComments.Name = "txtContrComments"
        Me.txtContrComments.Size = New System.Drawing.Size(813, 90)
        Me.txtContrComments.TabIndex = 19
        '
        'grpServiceType
        '
        Me.grpServiceType.Controls.Add(Me.dgvTicketServType)
        Me.grpServiceType.Controls.Add(Me.btnDeleteServiceLine)
        Me.grpServiceType.Controls.Add(Me.btnAddServiceType)
        Me.grpServiceType.Controls.Add(Me.Label4)
        Me.grpServiceType.Controls.Add(Me.cbxServiceType)
        Me.grpServiceType.Controls.Add(Me.txtJobDescription)
        Me.grpServiceType.Controls.Add(Me.Label17)
        Me.grpServiceType.Location = New System.Drawing.Point(864, 87)
        Me.grpServiceType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpServiceType.Name = "grpServiceType"
        Me.grpServiceType.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpServiceType.Size = New System.Drawing.Size(608, 517)
        Me.grpServiceType.TabIndex = 36
        Me.grpServiceType.TabStop = False
        '
        'dgvTicketServType
        '
        Me.dgvTicketServType.AllowUserToAddRows = False
        Me.dgvTicketServType.AllowUserToDeleteRows = False
        Me.dgvTicketServType.AllowUserToResizeColumns = False
        Me.dgvTicketServType.AllowUserToResizeRows = False
        Me.dgvTicketServType.AutoGenerateColumns = False
        Me.dgvTicketServType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTicketServType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.colTicketServiceTypeId, Me.colTicketId, Me.DataGridViewTextBoxColumn3})
        Me.dgvTicketServType.DataSource = Me.TICKETSERVICETYPEBindingSource
        Me.dgvTicketServType.Location = New System.Drawing.Point(16, 254)
        Me.dgvTicketServType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvTicketServType.Name = "dgvTicketServType"
        Me.dgvTicketServType.ReadOnly = True
        Me.dgvTicketServType.RowHeadersWidth = 20
        Me.dgvTicketServType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTicketServType.Size = New System.Drawing.Size(584, 249)
        Me.dgvTicketServType.TabIndex = 14
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SERVICETYPECODE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DESCRIPTION"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Service Type"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 270
        '
        'colTicketServiceTypeId
        '
        Me.colTicketServiceTypeId.DataPropertyName = "TICKETSERVICETYPEID"
        Me.colTicketServiceTypeId.HeaderText = "TICKETSERVICETYPEID"
        Me.colTicketServiceTypeId.MinimumWidth = 6
        Me.colTicketServiceTypeId.Name = "colTicketServiceTypeId"
        Me.colTicketServiceTypeId.ReadOnly = True
        Me.colTicketServiceTypeId.Visible = False
        Me.colTicketServiceTypeId.Width = 125
        '
        'colTicketId
        '
        Me.colTicketId.DataPropertyName = "TICKETID"
        Me.colTicketId.HeaderText = "TICKETID"
        Me.colTicketId.MinimumWidth = 6
        Me.colTicketId.Name = "colTicketId"
        Me.colTicketId.ReadOnly = True
        Me.colTicketId.Visible = False
        Me.colTicketId.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SERVICETYPEID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SERVICETYPEID"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'TICKETSERVICETYPEBindingSource
        '
        Me.TICKETSERVICETYPEBindingSource.DataMember = "TICKETSERVICETYPE"
        Me.TICKETSERVICETYPEBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnDeleteServiceLine
        '
        Me.btnDeleteServiceLine.Location = New System.Drawing.Point(524, 212)
        Me.btnDeleteServiceLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDeleteServiceLine.Name = "btnDeleteServiceLine"
        Me.btnDeleteServiceLine.Size = New System.Drawing.Size(76, 28)
        Me.btnDeleteServiceLine.TabIndex = 14
        Me.btnDeleteServiceLine.Text = "Delete"
        Me.btnDeleteServiceLine.UseVisualStyleBackColor = True
        '
        'btnAddServiceType
        '
        Me.btnAddServiceType.Location = New System.Drawing.Point(440, 212)
        Me.btnAddServiceType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAddServiceType.Name = "btnAddServiceType"
        Me.btnAddServiceType.Size = New System.Drawing.Size(76, 28)
        Me.btnAddServiceType.TabIndex = 13
        Me.btnAddServiceType.Text = "Add"
        Me.btnAddServiceType.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 194)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Service Type:"
        '
        'cbxServiceType
        '
        Me.cbxServiceType.DataSource = Me.SERVICETYPEBindingSource
        Me.cbxServiceType.DisplayMember = "DESCRIPTION"
        Me.cbxServiceType.FormattingEnabled = True
        Me.cbxServiceType.Location = New System.Drawing.Point(16, 214)
        Me.cbxServiceType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxServiceType.Name = "cbxServiceType"
        Me.cbxServiceType.Size = New System.Drawing.Size(415, 24)
        Me.cbxServiceType.TabIndex = 9
        Me.cbxServiceType.ValueMember = "SERVICETYPEID"
        '
        'SERVICETYPEBindingSource
        '
        Me.SERVICETYPEBindingSource.DataMember = "SERVICETYPE"
        Me.SERVICETYPEBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'txtJobDescription
        '
        Me.txtJobDescription.Location = New System.Drawing.Point(16, 36)
        Me.txtJobDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtJobDescription.MaxLength = 200
        Me.txtJobDescription.Multiline = True
        Me.txtJobDescription.Name = "txtJobDescription"
        Me.txtJobDescription.Size = New System.Drawing.Size(583, 143)
        Me.txtJobDescription.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 16)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Service Description:"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Controls.Add(Me.txtCustRepresAssistPos)
        Me.GroupBox6.Controls.Add(Me.Label21)
        Me.GroupBox6.Controls.Add(Me.txtCustComments)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.txtCustRepresPosition)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.txtCustRepresAssist)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.txtCustRepres)
        Me.GroupBox6.Location = New System.Drawing.Point(21, 286)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(835, 319)
        Me.GroupBox6.TabIndex = 34
        Me.GroupBox6.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(385, 69)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(123, 16)
        Me.Label28.TabIndex = 16
        Me.Label28.Text = "Position (Assistant):"
        '
        'txtCustRepresAssistPos
        '
        Me.txtCustRepresAssistPos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustRepresAssistPos.Location = New System.Drawing.Point(385, 89)
        Me.txtCustRepresAssistPos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustRepresAssistPos.MaxLength = 50
        Me.txtCustRepresAssistPos.Name = "txtCustRepresAssistPos"
        Me.txtCustRepresAssistPos.Size = New System.Drawing.Size(436, 22)
        Me.txtCustRepresAssistPos.TabIndex = 16
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(12, 117)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(134, 16)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Customer Comments:"
        '
        'txtCustComments
        '
        Me.txtCustComments.Location = New System.Drawing.Point(12, 137)
        Me.txtCustComments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustComments.MaxLength = 1000
        Me.txtCustComments.Multiline = True
        Me.txtCustComments.Name = "txtCustComments"
        Me.txtCustComments.Size = New System.Drawing.Size(809, 166)
        Me.txtCustComments.TabIndex = 17
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(385, 16)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 16)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Position:"
        '
        'txtCustRepresPosition
        '
        Me.txtCustRepresPosition.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustRepresPosition.Location = New System.Drawing.Point(385, 36)
        Me.txtCustRepresPosition.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustRepresPosition.MaxLength = 50
        Me.txtCustRepresPosition.Name = "txtCustRepresPosition"
        Me.txtCustRepresPosition.Size = New System.Drawing.Size(436, 22)
        Me.txtCustRepresPosition.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 69)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(219, 16)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Customer Representative Assistant:"
        '
        'txtCustRepresAssist
        '
        Me.txtCustRepresAssist.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustRepresAssist.Location = New System.Drawing.Point(12, 89)
        Me.txtCustRepresAssist.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustRepresAssist.MaxLength = 50
        Me.txtCustRepresAssist.Name = "txtCustRepresAssist"
        Me.txtCustRepresAssist.Size = New System.Drawing.Size(364, 22)
        Me.txtCustRepresAssist.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(12, 16)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(162, 16)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Customer Representative:"
        '
        'txtCustRepres
        '
        Me.txtCustRepres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustRepres.Location = New System.Drawing.Point(12, 36)
        Me.txtCustRepres.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustRepres.MaxLength = 50
        Me.txtCustRepres.Name = "txtCustRepres"
        Me.txtCustRepres.Size = New System.Drawing.Size(364, 22)
        Me.txtCustRepres.TabIndex = 13
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox5.Controls.Add(Me.dtpTimeCompleted)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.dtpTimeArrived)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.dtpTimeStarted)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(192, 9)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(664, 71)
        Me.GroupBox5.TabIndex = 33
        Me.GroupBox5.TabStop = False
        '
        'dtpTimeCompleted
        '
        Me.dtpTimeCompleted.CustomFormat = "dd/MM/yyyy HH:mm tt"
        Me.dtpTimeCompleted.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeCompleted.Location = New System.Drawing.Point(449, 39)
        Me.dtpTimeCompleted.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpTimeCompleted.Name = "dtpTimeCompleted"
        Me.dtpTimeCompleted.Size = New System.Drawing.Size(193, 22)
        Me.dtpTimeCompleted.TabIndex = 7
        Me.dtpTimeCompleted.Value = New Date(2017, 3, 21, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(19, 20)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Time Arrived:"
        '
        'dtpTimeArrived
        '
        Me.dtpTimeArrived.CustomFormat = "dd/MM/yyyy HH:mm tt"
        Me.dtpTimeArrived.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeArrived.Location = New System.Drawing.Point(23, 39)
        Me.dtpTimeArrived.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpTimeArrived.Name = "dtpTimeArrived"
        Me.dtpTimeArrived.Size = New System.Drawing.Size(205, 22)
        Me.dtpTimeArrived.TabIndex = 5
        Me.dtpTimeArrived.Value = New Date(2017, 3, 21, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(233, 20)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Time Started:"
        '
        'dtpTimeStarted
        '
        Me.dtpTimeStarted.CustomFormat = "dd/MM/yyyy HH:mm tt"
        Me.dtpTimeStarted.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeStarted.Location = New System.Drawing.Point(237, 39)
        Me.dtpTimeStarted.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpTimeStarted.Name = "dtpTimeStarted"
        Me.dtpTimeStarted.Size = New System.Drawing.Size(203, 22)
        Me.dtpTimeStarted.TabIndex = 6
        Me.dtpTimeStarted.Value = New Date(2017, 3, 21, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(447, 20)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Time Completed:"
        '
        'tabSalesItem
        '
        Me.tabSalesItem.AutoScroll = True
        Me.tabSalesItem.Controls.Add(Me.pnlSalesItem)
        Me.tabSalesItem.Location = New System.Drawing.Point(4, 25)
        Me.tabSalesItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabSalesItem.Name = "tabSalesItem"
        Me.tabSalesItem.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabSalesItem.Size = New System.Drawing.Size(1485, 657)
        Me.tabSalesItem.TabIndex = 1
        Me.tabSalesItem.Text = "Sales Item"
        Me.tabSalesItem.UseVisualStyleBackColor = True
        '
        'pnlSalesItem
        '
        Me.pnlSalesItem.BackColor = System.Drawing.SystemColors.Control
        Me.pnlSalesItem.Location = New System.Drawing.Point(0, 0)
        Me.pnlSalesItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlSalesItem.Name = "pnlSalesItem"
        Me.pnlSalesItem.Size = New System.Drawing.Size(1483, 654)
        Me.pnlSalesItem.TabIndex = 0
        '
        'tabEquipments
        '
        Me.tabEquipments.BackColor = System.Drawing.SystemColors.Control
        Me.tabEquipments.Controls.Add(Me.pnlEquipment)
        Me.tabEquipments.Location = New System.Drawing.Point(4, 25)
        Me.tabEquipments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabEquipments.Name = "tabEquipments"
        Me.tabEquipments.Size = New System.Drawing.Size(1485, 657)
        Me.tabEquipments.TabIndex = 2
        Me.tabEquipments.Text = "Equipments"
        '
        'pnlEquipment
        '
        Me.pnlEquipment.Location = New System.Drawing.Point(0, 0)
        Me.pnlEquipment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlEquipment.Name = "pnlEquipment"
        Me.pnlEquipment.Size = New System.Drawing.Size(1483, 654)
        Me.pnlEquipment.TabIndex = 0
        '
        'tabWorkers
        '
        Me.tabWorkers.BackColor = System.Drawing.SystemColors.Control
        Me.tabWorkers.Controls.Add(Me.GroupBox9)
        Me.tabWorkers.Controls.Add(Me.GroupBox8)
        Me.tabWorkers.Location = New System.Drawing.Point(4, 25)
        Me.tabWorkers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabWorkers.Name = "tabWorkers"
        Me.tabWorkers.Size = New System.Drawing.Size(1485, 657)
        Me.tabWorkers.TabIndex = 3
        Me.tabWorkers.Text = "Workers"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.dgvTicketOpeHour)
        Me.GroupBox9.Location = New System.Drawing.Point(4, 10)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox9.Size = New System.Drawing.Size(737, 122)
        Me.GroupBox9.TabIndex = 20
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Operation (Hours Total) - Double click to edit"
        '
        'dgvTicketOpeHour
        '
        Me.dgvTicketOpeHour.AllowUserToAddRows = False
        Me.dgvTicketOpeHour.AllowUserToDeleteRows = False
        Me.dgvTicketOpeHour.AllowUserToResizeColumns = False
        Me.dgvTicketOpeHour.AutoGenerateColumns = False
        Me.dgvTicketOpeHour.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTicketOpeHour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTicketOpeHour.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colOpHourTravel, Me.colOpHourOperation, Me.colOpHourStandby, Me.colOpHourLost, Me.colOpHourQde, Me.DataGridViewTextBoxColumn1})
        Me.dgvTicketOpeHour.DataSource = Me.TICKETOPEHOURBindingSource
        Me.dgvTicketOpeHour.Location = New System.Drawing.Point(5, 20)
        Me.dgvTicketOpeHour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvTicketOpeHour.MultiSelect = False
        Me.dgvTicketOpeHour.Name = "dgvTicketOpeHour"
        Me.dgvTicketOpeHour.ReadOnly = True
        Me.dgvTicketOpeHour.RowHeadersWidth = 51
        Me.dgvTicketOpeHour.RowTemplate.Height = 28
        Me.dgvTicketOpeHour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTicketOpeHour.Size = New System.Drawing.Size(723, 85)
        Me.dgvTicketOpeHour.TabIndex = 0
        '
        'colOpHourTravel
        '
        Me.colOpHourTravel.DataPropertyName = "HOURTRAVEL"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.colOpHourTravel.DefaultCellStyle = DataGridViewCellStyle1
        Me.colOpHourTravel.HeaderText = "Hour Travel"
        Me.colOpHourTravel.MinimumWidth = 6
        Me.colOpHourTravel.Name = "colOpHourTravel"
        Me.colOpHourTravel.ReadOnly = True
        Me.colOpHourTravel.Width = 90
        '
        'colOpHourOperation
        '
        Me.colOpHourOperation.DataPropertyName = "HOUROPERATION"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.colOpHourOperation.DefaultCellStyle = DataGridViewCellStyle2
        Me.colOpHourOperation.HeaderText = "Hour Operation"
        Me.colOpHourOperation.MinimumWidth = 6
        Me.colOpHourOperation.Name = "colOpHourOperation"
        Me.colOpHourOperation.ReadOnly = True
        Me.colOpHourOperation.Width = 90
        '
        'colOpHourStandby
        '
        Me.colOpHourStandby.DataPropertyName = "HOURSTANDBY"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.colOpHourStandby.DefaultCellStyle = DataGridViewCellStyle3
        Me.colOpHourStandby.HeaderText = "Hour Standby"
        Me.colOpHourStandby.MinimumWidth = 6
        Me.colOpHourStandby.Name = "colOpHourStandby"
        Me.colOpHourStandby.ReadOnly = True
        Me.colOpHourStandby.Width = 90
        '
        'colOpHourLost
        '
        Me.colOpHourLost.DataPropertyName = "HOURLOST"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.colOpHourLost.DefaultCellStyle = DataGridViewCellStyle4
        Me.colOpHourLost.HeaderText = "Hour Lost"
        Me.colOpHourLost.MinimumWidth = 6
        Me.colOpHourLost.Name = "colOpHourLost"
        Me.colOpHourLost.ReadOnly = True
        Me.colOpHourLost.Width = 90
        '
        'colOpHourQde
        '
        Me.colOpHourQde.DataPropertyName = "HOURQDE"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = "0.00"
        Me.colOpHourQde.DefaultCellStyle = DataGridViewCellStyle5
        Me.colOpHourQde.HeaderText = "Total"
        Me.colOpHourQde.MinimumWidth = 6
        Me.colOpHourQde.Name = "colOpHourQde"
        Me.colOpHourQde.ReadOnly = True
        Me.colOpHourQde.Width = 90
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TICKETID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TICKETID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'TICKETOPEHOURBindingSource
        '
        Me.TICKETOPEHOURBindingSource.DataMember = "TICKETOPEHOUR"
        Me.TICKETOPEHOURBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btnWAdd)
        Me.GroupBox8.Controls.Add(Me.dgvWorker)
        Me.GroupBox8.Location = New System.Drawing.Point(3, 135)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox8.Size = New System.Drawing.Size(1476, 490)
        Me.GroupBox8.TabIndex = 19
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Workers"
        '
        'btnWAdd
        '
        Me.btnWAdd.Image = CType(resources.GetObject("btnWAdd.Image"), System.Drawing.Image)
        Me.btnWAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnWAdd.Location = New System.Drawing.Point(7, 22)
        Me.btnWAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnWAdd.Name = "btnWAdd"
        Me.btnWAdd.Size = New System.Drawing.Size(107, 34)
        Me.btnWAdd.TabIndex = 12
        Me.btnWAdd.Text = "Add"
        Me.btnWAdd.UseVisualStyleBackColor = True
        '
        'dgvWorker
        '
        Me.dgvWorker.AllowDrop = True
        Me.dgvWorker.AllowUserToAddRows = False
        Me.dgvWorker.AllowUserToDeleteRows = False
        Me.dgvWorker.AutoGenerateColumns = False
        Me.dgvWorker.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorker.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colWFullName, Me.colWAppoint, Me.colWRegisterDate, Me.colHourTravel, Me.colHourOperation, Me.colHourStandby, Me.colHourLost, Me.colWHourQde, Me.colResumeActivity, Me.colWWorkerId, Me.colWTicketWorkerID})
        Me.dgvWorker.DataSource = Me.TICKETWORKERBindingSource
        Me.dgvWorker.Location = New System.Drawing.Point(7, 64)
        Me.dgvWorker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvWorker.MultiSelect = False
        Me.dgvWorker.Name = "dgvWorker"
        Me.dgvWorker.ReadOnly = True
        Me.dgvWorker.RowHeadersWidth = 51
        Me.dgvWorker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvWorker.Size = New System.Drawing.Size(1457, 417)
        Me.dgvWorker.TabIndex = 18
        '
        'colWFullName
        '
        Me.colWFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colWFullName.DataPropertyName = "FULLNAME"
        Me.colWFullName.HeaderText = "Name"
        Me.colWFullName.MinimumWidth = 6
        Me.colWFullName.Name = "colWFullName"
        Me.colWFullName.ReadOnly = True
        Me.colWFullName.Width = 73
        '
        'colWAppoint
        '
        Me.colWAppoint.DataPropertyName = "APPOINTMENT"
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colWAppoint.DefaultCellStyle = DataGridViewCellStyle6
        Me.colWAppoint.HeaderText = "Appointment"
        Me.colWAppoint.MinimumWidth = 6
        Me.colWAppoint.Name = "colWAppoint"
        Me.colWAppoint.ReadOnly = True
        Me.colWAppoint.Width = 200
        '
        'colWRegisterDate
        '
        Me.colWRegisterDate.DataPropertyName = "REGISTERDATE"
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.colWRegisterDate.DefaultCellStyle = DataGridViewCellStyle7
        Me.colWRegisterDate.HeaderText = "Register Date"
        Me.colWRegisterDate.MinimumWidth = 6
        Me.colWRegisterDate.Name = "colWRegisterDate"
        Me.colWRegisterDate.ReadOnly = True
        Me.colWRegisterDate.Width = 70
        '
        'colHourTravel
        '
        Me.colHourTravel.DataPropertyName = "HOURTRAVEL"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "n2"
        Me.colHourTravel.DefaultCellStyle = DataGridViewCellStyle8
        Me.colHourTravel.HeaderText = "Hour Travel"
        Me.colHourTravel.MinimumWidth = 6
        Me.colHourTravel.Name = "colHourTravel"
        Me.colHourTravel.ReadOnly = True
        Me.colHourTravel.Width = 60
        '
        'colHourOperation
        '
        Me.colHourOperation.DataPropertyName = "HOUROPERATION"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "n2"
        Me.colHourOperation.DefaultCellStyle = DataGridViewCellStyle9
        Me.colHourOperation.HeaderText = "Hour Operation"
        Me.colHourOperation.MinimumWidth = 6
        Me.colHourOperation.Name = "colHourOperation"
        Me.colHourOperation.ReadOnly = True
        Me.colHourOperation.Width = 60
        '
        'colHourStandby
        '
        Me.colHourStandby.DataPropertyName = "HOURSTANDBY"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Format = "n2"
        Me.colHourStandby.DefaultCellStyle = DataGridViewCellStyle10
        Me.colHourStandby.HeaderText = "Hour Standby"
        Me.colHourStandby.MinimumWidth = 6
        Me.colHourStandby.Name = "colHourStandby"
        Me.colHourStandby.ReadOnly = True
        Me.colHourStandby.Width = 60
        '
        'colHourLost
        '
        Me.colHourLost.DataPropertyName = "HOURLOST"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Format = "n2"
        Me.colHourLost.DefaultCellStyle = DataGridViewCellStyle11
        Me.colHourLost.HeaderText = "Hour Lost"
        Me.colHourLost.MinimumWidth = 6
        Me.colHourLost.Name = "colHourLost"
        Me.colHourLost.ReadOnly = True
        Me.colHourLost.Width = 60
        '
        'colWHourQde
        '
        Me.colWHourQde.DataPropertyName = "HOURQDE"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.colWHourQde.DefaultCellStyle = DataGridViewCellStyle12
        Me.colWHourQde.HeaderText = "Total"
        Me.colWHourQde.MinimumWidth = 6
        Me.colWHourQde.Name = "colWHourQde"
        Me.colWHourQde.ReadOnly = True
        Me.colWHourQde.Width = 75
        '
        'colResumeActivity
        '
        Me.colResumeActivity.DataPropertyName = "RESUMEACTIVITY"
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colResumeActivity.DefaultCellStyle = DataGridViewCellStyle13
        Me.colResumeActivity.HeaderText = "Resume"
        Me.colResumeActivity.MinimumWidth = 6
        Me.colResumeActivity.Name = "colResumeActivity"
        Me.colResumeActivity.ReadOnly = True
        Me.colResumeActivity.Width = 260
        '
        'colWWorkerId
        '
        Me.colWWorkerId.DataPropertyName = "WORKERID"
        Me.colWWorkerId.HeaderText = "WORKERID"
        Me.colWWorkerId.MinimumWidth = 6
        Me.colWWorkerId.Name = "colWWorkerId"
        Me.colWWorkerId.ReadOnly = True
        Me.colWWorkerId.Visible = False
        Me.colWWorkerId.Width = 125
        '
        'colWTicketWorkerID
        '
        Me.colWTicketWorkerID.DataPropertyName = "TICKETWORKERID"
        Me.colWTicketWorkerID.HeaderText = "TICKETWORKERID"
        Me.colWTicketWorkerID.MinimumWidth = 6
        Me.colWTicketWorkerID.Name = "colWTicketWorkerID"
        Me.colWTicketWorkerID.ReadOnly = True
        Me.colWTicketWorkerID.Visible = False
        Me.colWTicketWorkerID.Width = 125
        '
        'TICKETWORKERBindingSource
        '
        Me.TICKETWORKERBindingSource.DataMember = "TICKETWORKER"
        Me.TICKETWORKERBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'tabOperReport
        '
        Me.tabOperReport.BackColor = System.Drawing.SystemColors.Control
        Me.tabOperReport.Controls.Add(Me.pnlOperReport)
        Me.tabOperReport.Location = New System.Drawing.Point(4, 25)
        Me.tabOperReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabOperReport.Name = "tabOperReport"
        Me.tabOperReport.Size = New System.Drawing.Size(1485, 657)
        Me.tabOperReport.TabIndex = 5
        Me.tabOperReport.Text = "Job Log"
        '
        'pnlOperReport
        '
        Me.pnlOperReport.BackColor = System.Drawing.SystemColors.Control
        Me.pnlOperReport.Location = New System.Drawing.Point(0, 0)
        Me.pnlOperReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlOperReport.Name = "pnlOperReport"
        Me.pnlOperReport.Size = New System.Drawing.Size(1483, 654)
        Me.pnlOperReport.TabIndex = 1
        '
        'tabServEvalHSEQ
        '
        Me.tabServEvalHSEQ.Controls.Add(Me.pnlHSEQServEval)
        Me.tabServEvalHSEQ.Location = New System.Drawing.Point(4, 25)
        Me.tabServEvalHSEQ.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabServEvalHSEQ.Name = "tabServEvalHSEQ"
        Me.tabServEvalHSEQ.Size = New System.Drawing.Size(1485, 657)
        Me.tabServEvalHSEQ.TabIndex = 6
        Me.tabServEvalHSEQ.Text = "HSEQ - Service Evaluation"
        Me.tabServEvalHSEQ.UseVisualStyleBackColor = True
        '
        'pnlHSEQServEval
        '
        Me.pnlHSEQServEval.BackColor = System.Drawing.SystemColors.Control
        Me.pnlHSEQServEval.Location = New System.Drawing.Point(0, 0)
        Me.pnlHSEQServEval.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlHSEQServEval.Name = "pnlHSEQServEval"
        Me.pnlHSEQServEval.Size = New System.Drawing.Size(1483, 654)
        Me.pnlHSEQServEval.TabIndex = 2
        '
        'tabAdicInform
        '
        Me.tabAdicInform.BackColor = System.Drawing.SystemColors.Control
        Me.tabAdicInform.Controls.Add(Me.grpAddicInfoARG)
        Me.tabAdicInform.Controls.Add(Me.GroupBox7)
        Me.tabAdicInform.Controls.Add(Me.GroupBox4)
        Me.tabAdicInform.Controls.Add(Me.GroupBox3)
        Me.tabAdicInform.Controls.Add(Me.PictureBox1)
        Me.tabAdicInform.Controls.Add(Me.txtAdicInform)
        Me.tabAdicInform.Controls.Add(Me.Label29)
        Me.tabAdicInform.Location = New System.Drawing.Point(4, 25)
        Me.tabAdicInform.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabAdicInform.Name = "tabAdicInform"
        Me.tabAdicInform.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabAdicInform.Size = New System.Drawing.Size(1485, 657)
        Me.tabAdicInform.TabIndex = 4
        Me.tabAdicInform.Text = "Additional Information"
        '
        'grpAddicInfoARG
        '
        Me.grpAddicInfoARG.Controls.Add(Me.txtSuperiorSupervisor)
        Me.grpAddicInfoARG.Controls.Add(Me.btnSearchSupervisor)
        Me.grpAddicInfoARG.Controls.Add(Me.Label27)
        Me.grpAddicInfoARG.Controls.Add(Me.Label5)
        Me.grpAddicInfoARG.Controls.Add(Me.txtSONumber)
        Me.grpAddicInfoARG.Controls.Add(Me.Label3)
        Me.grpAddicInfoARG.Controls.Add(Me.txtJobNumber)
        Me.grpAddicInfoARG.Controls.Add(Me.txtDM)
        Me.grpAddicInfoARG.Controls.Add(Me.txtSupNum)
        Me.grpAddicInfoARG.Controls.Add(Me.Label2)
        Me.grpAddicInfoARG.Controls.Add(Me.Label1)
        Me.grpAddicInfoARG.ForeColor = System.Drawing.Color.Red
        Me.grpAddicInfoARG.Location = New System.Drawing.Point(915, 380)
        Me.grpAddicInfoARG.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpAddicInfoARG.Name = "grpAddicInfoARG"
        Me.grpAddicInfoARG.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpAddicInfoARG.Size = New System.Drawing.Size(564, 198)
        Me.grpAddicInfoARG.TabIndex = 39
        Me.grpAddicInfoARG.TabStop = False
        Me.grpAddicInfoARG.Text = "Argentina Only"
        '
        'txtSuperiorSupervisor
        '
        Me.txtSuperiorSupervisor.BackColor = System.Drawing.Color.White
        Me.txtSuperiorSupervisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSuperiorSupervisor.Location = New System.Drawing.Point(13, 153)
        Me.txtSuperiorSupervisor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSuperiorSupervisor.Name = "txtSuperiorSupervisor"
        Me.txtSuperiorSupervisor.ReadOnly = True
        Me.txtSuperiorSupervisor.Size = New System.Drawing.Size(269, 22)
        Me.txtSuperiorSupervisor.TabIndex = 32
        '
        'btnSearchSupervisor
        '
        Me.btnSearchSupervisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchSupervisor.Location = New System.Drawing.Point(288, 149)
        Me.btnSearchSupervisor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchSupervisor.Name = "btnSearchSupervisor"
        Me.btnSearchSupervisor.Size = New System.Drawing.Size(36, 28)
        Me.btnSearchSupervisor.TabIndex = 33
        Me.btnSearchSupervisor.Text = "..."
        Me.btnSearchSupervisor.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(9, 133)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(140, 16)
        Me.Label27.TabIndex = 31
        Me.Label27.Text = "Superior´s Supervisor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(284, 74)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Service Order / Parte de Campo"
        '
        'txtSONumber
        '
        Me.txtSONumber.Location = New System.Drawing.Point(288, 92)
        Me.txtSONumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSONumber.MaxLength = 255
        Me.txtSONumber.Name = "txtSONumber"
        Me.txtSONumber.Size = New System.Drawing.Size(268, 22)
        Me.txtSONumber.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Job Number:"
        '
        'txtJobNumber
        '
        Me.txtJobNumber.Location = New System.Drawing.Point(13, 92)
        Me.txtJobNumber.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtJobNumber.MaxLength = 255
        Me.txtJobNumber.Name = "txtJobNumber"
        Me.txtJobNumber.Size = New System.Drawing.Size(268, 22)
        Me.txtJobNumber.TabIndex = 27
        '
        'txtDM
        '
        Me.txtDM.Location = New System.Drawing.Point(288, 44)
        Me.txtDM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDM.MaxLength = 255
        Me.txtDM.Name = "txtDM"
        Me.txtDM.Size = New System.Drawing.Size(269, 22)
        Me.txtDM.TabIndex = 26
        '
        'txtSupNum
        '
        Me.txtSupNum.Location = New System.Drawing.Point(12, 44)
        Me.txtSupNum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSupNum.MaxLength = 255
        Me.txtSupNum.Name = "txtSupNum"
        Me.txtSupNum.Size = New System.Drawing.Size(269, 22)
        Me.txtSupNum.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(284, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 16)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "DM/CERTOP:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Proforma Valorizada / Field Tickets:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtMaxDepth)
        Me.GroupBox7.Controls.Add(Me.txtMaxPressure)
        Me.GroupBox7.Controls.Add(Me.Label25)
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Location = New System.Drawing.Point(913, 177)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox7.Size = New System.Drawing.Size(271, 81)
        Me.GroupBox7.TabIndex = 38
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Pressure"
        '
        'txtMaxDepth
        '
        Me.txtMaxDepth.BackColor = System.Drawing.Color.White
        Me.txtMaxDepth.Location = New System.Drawing.Point(147, 47)
        Me.txtMaxDepth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaxDepth.Name = "txtMaxDepth"
        Me.txtMaxDepth.Size = New System.Drawing.Size(105, 22)
        Me.txtMaxDepth.TabIndex = 24
        '
        'txtMaxPressure
        '
        Me.txtMaxPressure.BackColor = System.Drawing.Color.White
        Me.txtMaxPressure.Location = New System.Drawing.Point(147, 20)
        Me.txtMaxPressure.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaxPressure.Name = "txtMaxPressure"
        Me.txtMaxPressure.Size = New System.Drawing.Size(105, 22)
        Me.txtMaxPressure.TabIndex = 23
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(9, 23)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(122, 16)
        Me.Label25.TabIndex = 20
        Me.Label25.Text = "Max Pressure (Psi):"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(9, 50)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(96, 16)
        Me.Label26.TabIndex = 22
        Me.Label26.Text = "Max Depth (Ft):"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.cbxTubingGrade)
        Me.GroupBox4.Controls.Add(Me.cbxTubingWeight)
        Me.GroupBox4.Controls.Add(Me.cbxTubingPipe)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Location = New System.Drawing.Point(913, 59)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(271, 106)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tubing"
        '
        'cbxTubingGrade
        '
        Me.cbxTubingGrade.DataSource = Me.TUBINGBindingSource
        Me.cbxTubingGrade.DisplayMember = "GRADE"
        Me.cbxTubingGrade.FormattingEnabled = True
        Me.cbxTubingGrade.Location = New System.Drawing.Point(133, 74)
        Me.cbxTubingGrade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxTubingGrade.Name = "cbxTubingGrade"
        Me.cbxTubingGrade.Size = New System.Drawing.Size(109, 24)
        Me.cbxTubingGrade.TabIndex = 22
        Me.cbxTubingGrade.ValueMember = "GRADE"
        '
        'cbxTubingWeight
        '
        Me.cbxTubingWeight.DataSource = Me.TUBBINGWEIGHTBindingSource
        Me.cbxTubingWeight.DisplayMember = "WEIGHT"
        Me.cbxTubingWeight.FormattingEnabled = True
        Me.cbxTubingWeight.Location = New System.Drawing.Point(133, 47)
        Me.cbxTubingWeight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxTubingWeight.Name = "cbxTubingWeight"
        Me.cbxTubingWeight.Size = New System.Drawing.Size(109, 24)
        Me.cbxTubingWeight.TabIndex = 21
        Me.cbxTubingWeight.ValueMember = "WEIGHT"
        '
        'TUBBINGWEIGHTBindingSource
        '
        Me.TUBBINGWEIGHTBindingSource.DataMember = "TUBBING_WEIGHT"
        Me.TUBBINGWEIGHTBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'cbxTubingPipe
        '
        Me.cbxTubingPipe.DataSource = Me.TUBBINGDRILLPIPEBindingSource
        Me.cbxTubingPipe.DisplayMember = "DRILL_PIPE"
        Me.cbxTubingPipe.FormattingEnabled = True
        Me.cbxTubingPipe.Location = New System.Drawing.Point(133, 20)
        Me.cbxTubingPipe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxTubingPipe.Name = "cbxTubingPipe"
        Me.cbxTubingPipe.Size = New System.Drawing.Size(109, 24)
        Me.cbxTubingPipe.TabIndex = 20
        Me.cbxTubingPipe.ValueMember = "DRILL_PIPE"
        '
        'TUBBINGDRILLPIPEBindingSource
        '
        Me.TUBBINGDRILLPIPEBindingSource.DataMember = "TUBBING_DRILLPIPE"
        Me.TUBBINGDRILLPIPEBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 23)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Pipe (Inches):"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 50)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 16)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Weight (#/FT):"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 78)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 16)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Grade:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbxCasingGrade)
        Me.GroupBox3.Controls.Add(Me.cbxCasingWeight)
        Me.GroupBox3.Controls.Add(Me.cbxCasingSize)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(913, 266)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(271, 106)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Casing"
        '
        'cbxCasingGrade
        '
        Me.cbxCasingGrade.DataSource = Me.CASINGBindingSource
        Me.cbxCasingGrade.DisplayMember = "GRADE"
        Me.cbxCasingGrade.FormattingEnabled = True
        Me.cbxCasingGrade.Location = New System.Drawing.Point(133, 74)
        Me.cbxCasingGrade.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxCasingGrade.Name = "cbxCasingGrade"
        Me.cbxCasingGrade.Size = New System.Drawing.Size(109, 24)
        Me.cbxCasingGrade.TabIndex = 27
        Me.cbxCasingGrade.ValueMember = "GRADE"
        '
        'CASINGBindingSource
        '
        Me.CASINGBindingSource.DataMember = "CASING"
        Me.CASINGBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'cbxCasingWeight
        '
        Me.cbxCasingWeight.DataSource = Me.CASINGWEIGHTBindingSource
        Me.cbxCasingWeight.DisplayMember = "WEIGHTFT"
        Me.cbxCasingWeight.FormattingEnabled = True
        Me.cbxCasingWeight.Location = New System.Drawing.Point(133, 47)
        Me.cbxCasingWeight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxCasingWeight.Name = "cbxCasingWeight"
        Me.cbxCasingWeight.Size = New System.Drawing.Size(109, 24)
        Me.cbxCasingWeight.TabIndex = 26
        Me.cbxCasingWeight.ValueMember = "WEIGHTFT"
        '
        'CASINGWEIGHTBindingSource
        '
        Me.CASINGWEIGHTBindingSource.DataMember = "CASING_WEIGHT"
        Me.CASINGWEIGHTBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'cbxCasingSize
        '
        Me.cbxCasingSize.DataSource = Me.CASINGSIZEBindingSource
        Me.cbxCasingSize.DisplayMember = "SIZEINC"
        Me.cbxCasingSize.FormattingEnabled = True
        Me.cbxCasingSize.Location = New System.Drawing.Point(133, 20)
        Me.cbxCasingSize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxCasingSize.Name = "cbxCasingSize"
        Me.cbxCasingSize.Size = New System.Drawing.Size(109, 24)
        Me.cbxCasingSize.TabIndex = 25
        Me.cbxCasingSize.ValueMember = "SIZEINC"
        '
        'CASINGSIZEBindingSource
        '
        Me.CASINGSIZEBindingSource.DataMember = "CASING_SIZE"
        Me.CASINGSIZEBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 23)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 16)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Size (Inches):"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(8, 50)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 16)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Weight (#/FT):"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 78)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 16)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Grade:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'txtAdicInform
        '
        Me.txtAdicInform.Location = New System.Drawing.Point(15, 59)
        Me.txtAdicInform.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAdicInform.MaxLength = 1000
        Me.txtAdicInform.Multiline = True
        Me.txtAdicInform.Name = "txtAdicInform"
        Me.txtAdicInform.Size = New System.Drawing.Size(889, 570)
        Me.txtAdicInform.TabIndex = 18
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(85, 7)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(472, 48)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "Additional Information: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Use this area to write anything that is important regis" &
    "ter for this Ticket." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This information will not exhibit in the Ticket print. Its" &
    " only for your internal control."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSaveTicket, Me.mnuPrint, Me.mnuInvItem, Me.mnuCloseTicket, Me.mnuAttachment, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1509, 52)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuSaveTicket
        '
        Me.mnuSaveTicket.Image = CType(resources.GetObject("mnuSaveTicket.Image"), System.Drawing.Image)
        Me.mnuSaveTicket.Name = "mnuSaveTicket"
        Me.mnuSaveTicket.Size = New System.Drawing.Size(78, 48)
        Me.mnuSaveTicket.Text = "Save"
        Me.mnuSaveTicket.ToolTipText = "Save the Ticket"
        '
        'mnuPrint
        '
        Me.mnuPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TicketSalesItemToolStripMenuItem, Me.ToolStripSeparator1, Me.mnuActaIniFimOpe, Me.mnuJobLog, Me.FronteraToolStripMenuItem})
        Me.mnuPrint.Image = CType(resources.GetObject("mnuPrint.Image"), System.Drawing.Image)
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(77, 48)
        Me.mnuPrint.Text = "Print"
        Me.mnuPrint.ToolTipText = "Print the Ticket"
        '
        'TicketSalesItemToolStripMenuItem
        '
        Me.TicketSalesItemToolStripMenuItem.Name = "TicketSalesItemToolStripMenuItem"
        Me.TicketSalesItemToolStripMenuItem.Size = New System.Drawing.Size(309, 26)
        Me.TicketSalesItemToolStripMenuItem.Text = "Ticket Sales Item"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(306, 6)
        '
        'mnuActaIniFimOpe
        '
        Me.mnuActaIniFimOpe.Name = "mnuActaIniFimOpe"
        Me.mnuActaIniFimOpe.Size = New System.Drawing.Size(309, 26)
        Me.mnuActaIniFimOpe.Text = "Acta Inicio y Finaliz. Operaciones"
        '
        'mnuJobLog
        '
        Me.mnuJobLog.Name = "mnuJobLog"
        Me.mnuJobLog.Size = New System.Drawing.Size(309, 26)
        Me.mnuJobLog.Text = "Job Log"
        '
        'FronteraToolStripMenuItem
        '
        Me.FronteraToolStripMenuItem.Name = "FronteraToolStripMenuItem"
        Me.FronteraToolStripMenuItem.Size = New System.Drawing.Size(309, 26)
        Me.FronteraToolStripMenuItem.Text = "Frontera"
        '
        'mnuInvItem
        '
        Me.mnuInvItem.Image = CType(resources.GetObject("mnuInvItem.Image"), System.Drawing.Image)
        Me.mnuInvItem.Name = "mnuInvItem"
        Me.mnuInvItem.Size = New System.Drawing.Size(142, 48)
        Me.mnuInvItem.Text = "Inventory Item"
        '
        'mnuCloseTicket
        '
        Me.mnuCloseTicket.Image = CType(resources.GetObject("mnuCloseTicket.Image"), System.Drawing.Image)
        Me.mnuCloseTicket.Name = "mnuCloseTicket"
        Me.mnuCloseTicket.Size = New System.Drawing.Size(126, 48)
        Me.mnuCloseTicket.Text = "Close Ticket"
        '
        'mnuAttachment
        '
        Me.mnuAttachment.Image = CType(resources.GetObject("mnuAttachment.Image"), System.Drawing.Image)
        Me.mnuAttachment.Name = "mnuAttachment"
        Me.mnuAttachment.Size = New System.Drawing.Size(124, 48)
        Me.mnuAttachment.Text = "Attachment"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.AutoSize = False
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(53, 38)
        Me.ExitToolStripMenuItem.Text = "Exit"
        Me.ExitToolStripMenuItem.ToolTipText = "Close the Ticket"
        '
        'pnlTicket
        '
        Me.pnlTicket.BackColor = System.Drawing.Color.White
        Me.pnlTicket.Controls.Add(Me.lblServiceLine)
        Me.pnlTicket.Controls.Add(Me.cbxServiceLine)
        Me.pnlTicket.Controls.Add(Me.cbxContract)
        Me.pnlTicket.Controls.Add(Me.cbxCurrency)
        Me.pnlTicket.Controls.Add(Me.lblCurrency)
        Me.pnlTicket.Controls.Add(Me.lblContract)
        Me.pnlTicket.Controls.Add(Me.cbxCustomer)
        Me.pnlTicket.Controls.Add(Me.txtTicketNumber)
        Me.pnlTicket.Controls.Add(Me.lblCustomer)
        Me.pnlTicket.Controls.Add(Me.lblTicketNumber)
        Me.pnlTicket.Location = New System.Drawing.Point(8, 57)
        Me.pnlTicket.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTicket.Name = "pnlTicket"
        Me.pnlTicket.Size = New System.Drawing.Size(1316, 76)
        Me.pnlTicket.TabIndex = 31
        '
        'lblServiceLine
        '
        Me.lblServiceLine.AutoSize = True
        Me.lblServiceLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblServiceLine.Location = New System.Drawing.Point(545, 12)
        Me.lblServiceLine.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServiceLine.Name = "lblServiceLine"
        Me.lblServiceLine.Size = New System.Drawing.Size(84, 16)
        Me.lblServiceLine.TabIndex = 41
        Me.lblServiceLine.Text = "Service Line:"
        '
        'cbxServiceLine
        '
        Me.cbxServiceLine.DataSource = Me.SERVLINECUSTVBindingSource
        Me.cbxServiceLine.DisplayMember = "NAME"
        Me.cbxServiceLine.FormattingEnabled = True
        Me.cbxServiceLine.Location = New System.Drawing.Point(549, 31)
        Me.cbxServiceLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxServiceLine.Name = "cbxServiceLine"
        Me.cbxServiceLine.Size = New System.Drawing.Size(271, 24)
        Me.cbxServiceLine.TabIndex = 40
        Me.cbxServiceLine.ValueMember = "SERVICELINEID"
        '
        'SERVLINECUSTVBindingSource
        '
        Me.SERVLINECUSTVBindingSource.DataMember = "SERVLINE_CUST_V"
        Me.SERVLINECUSTVBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'cbxContract
        '
        Me.cbxContract.DataSource = Me.CONTRACTBindingSource
        Me.cbxContract.DisplayMember = "CONTRACTNUMBER"
        Me.cbxContract.FormattingEnabled = True
        Me.cbxContract.Location = New System.Drawing.Point(829, 30)
        Me.cbxContract.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxContract.Name = "cbxContract"
        Me.cbxContract.Size = New System.Drawing.Size(256, 24)
        Me.cbxContract.TabIndex = 3
        Me.cbxContract.ValueMember = "CONTRACTID"
        '
        'CONTRACTBindingSource
        '
        Me.CONTRACTBindingSource.DataMember = "CONTRACT"
        Me.CONTRACTBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'cbxCurrency
        '
        Me.cbxCurrency.DataSource = Me.CURRENCYBindingSource
        Me.cbxCurrency.DisplayMember = "CURRENCYNAME"
        Me.cbxCurrency.Enabled = False
        Me.cbxCurrency.FormattingEnabled = True
        Me.cbxCurrency.Location = New System.Drawing.Point(1095, 30)
        Me.cbxCurrency.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxCurrency.Name = "cbxCurrency"
        Me.cbxCurrency.Size = New System.Drawing.Size(203, 24)
        Me.cbxCurrency.TabIndex = 4
        Me.cbxCurrency.ValueMember = "CURRENCYCODE"
        '
        'CURRENCYBindingSource
        '
        Me.CURRENCYBindingSource.DataMember = "CURRENCY"
        Me.CURRENCYBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'lblCurrency
        '
        Me.lblCurrency.AutoSize = True
        Me.lblCurrency.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCurrency.Location = New System.Drawing.Point(1091, 11)
        Me.lblCurrency.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrency.Name = "lblCurrency"
        Me.lblCurrency.Size = New System.Drawing.Size(63, 16)
        Me.lblCurrency.TabIndex = 39
        Me.lblCurrency.Text = "Currency:"
        '
        'lblContract
        '
        Me.lblContract.AutoSize = True
        Me.lblContract.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblContract.Location = New System.Drawing.Point(825, 10)
        Me.lblContract.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContract.Name = "lblContract"
        Me.lblContract.Size = New System.Drawing.Size(59, 16)
        Me.lblContract.TabIndex = 30
        Me.lblContract.Text = "Contract:"
        '
        'cbxCustomer
        '
        Me.cbxCustomer.DataSource = Me.CUSTOMERBindingSource
        Me.cbxCustomer.DisplayMember = "NAME"
        Me.cbxCustomer.FormattingEnabled = True
        Me.cbxCustomer.Location = New System.Drawing.Point(155, 31)
        Me.cbxCustomer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxCustomer.Name = "cbxCustomer"
        Me.cbxCustomer.Size = New System.Drawing.Size(385, 24)
        Me.cbxCustomer.TabIndex = 2
        Me.cbxCustomer.ValueMember = "CUSTOMERID"
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'txtTicketNumber
        '
        Me.txtTicketNumber.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtTicketNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTicketNumber.Enabled = False
        Me.txtTicketNumber.Location = New System.Drawing.Point(20, 32)
        Me.txtTicketNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTicketNumber.Name = "txtTicketNumber"
        Me.txtTicketNumber.Size = New System.Drawing.Size(114, 22)
        Me.txtTicketNumber.TabIndex = 1
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCustomer.Location = New System.Drawing.Point(151, 12)
        Me.lblCustomer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(67, 16)
        Me.lblCustomer.TabIndex = 34
        Me.lblCustomer.Text = "Customer:"
        '
        'lblTicketNumber
        '
        Me.lblTicketNumber.AutoSize = True
        Me.lblTicketNumber.Location = New System.Drawing.Point(16, 12)
        Me.lblTicketNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTicketNumber.Name = "lblTicketNumber"
        Me.lblTicketNumber.Size = New System.Drawing.Size(98, 16)
        Me.lblTicketNumber.TabIndex = 33
        Me.lblTicketNumber.Text = "Ticket Number:"
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'SERVICETYPETableAdapter
        '
        Me.SERVICETYPETableAdapter.ClearBeforeFill = True
        '
        'CURRENCYTableAdapter
        '
        Me.CURRENCYTableAdapter.ClearBeforeFill = True
        '
        'TUBINGTableAdapter
        '
        Me.TUBINGTableAdapter.ClearBeforeFill = True
        '
        'CASINGTableAdapter
        '
        Me.CASINGTableAdapter.ClearBeforeFill = True
        '
        'CONTRACTTableAdapter
        '
        Me.CONTRACTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CASINGTableAdapter = Me.CASINGTableAdapter
        Me.TableAdapterManager.CITYTableAdapter = Nothing
        Me.TableAdapterManager.CONTRACTTableAdapter = Me.CONTRACTTableAdapter
        Me.TableAdapterManager.COUNTRYTableAdapter = Nothing
        Me.TableAdapterManager.CURRENCYTableAdapter = Me.CURRENCYTableAdapter
        Me.TableAdapterManager.CUSTOMERTableAdapter = Me.CUSTOMERTableAdapter
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
        Me.TableAdapterManager.TUBINGTableAdapter = Me.TUBINGTableAdapter
        Me.TableAdapterManager.UpdateOrder = SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Nothing
        Me.TableAdapterManager.WELLTableAdapter = Nothing
        Me.TableAdapterManager.WORKERTableAdapter = Nothing
        '
        'TICKETWORKERTableAdapter
        '
        Me.TICKETWORKERTableAdapter.ClearBeforeFill = True
        '
        'pnlTicketCanceled
        '
        Me.pnlTicketCanceled.BackColor = System.Drawing.Color.White
        Me.pnlTicketCanceled.Controls.Add(Me.btnCancelDet)
        Me.pnlTicketCanceled.Controls.Add(Me.lblTicketCancelDet)
        Me.pnlTicketCanceled.Location = New System.Drawing.Point(1331, 58)
        Me.pnlTicketCanceled.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlTicketCanceled.Name = "pnlTicketCanceled"
        Me.pnlTicketCanceled.Size = New System.Drawing.Size(165, 75)
        Me.pnlTicketCanceled.TabIndex = 33
        '
        'btnCancelDet
        '
        Me.btnCancelDet.Location = New System.Drawing.Point(32, 31)
        Me.btnCancelDet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelDet.Name = "btnCancelDet"
        Me.btnCancelDet.Size = New System.Drawing.Size(100, 28)
        Me.btnCancelDet.TabIndex = 38
        Me.btnCancelDet.Text = "Details"
        Me.btnCancelDet.UseVisualStyleBackColor = True
        '
        'lblTicketCancelDet
        '
        Me.lblTicketCancelDet.AutoSize = True
        Me.lblTicketCancelDet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketCancelDet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTicketCancelDet.Location = New System.Drawing.Point(1, 11)
        Me.lblTicketCancelDet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTicketCancelDet.Name = "lblTicketCancelDet"
        Me.lblTicketCancelDet.Size = New System.Drawing.Size(148, 17)
        Me.lblTicketCancelDet.TabIndex = 37
        Me.lblTicketCancelDet.Text = "TICKET CANCELED"
        '
        'TUBBING_DRILLPIPETableAdapter
        '
        Me.TUBBING_DRILLPIPETableAdapter.ClearBeforeFill = True
        '
        'TUBBING_WEIGHTTableAdapter
        '
        Me.TUBBING_WEIGHTTableAdapter.ClearBeforeFill = True
        '
        'CASING_SIZETableAdapter
        '
        Me.CASING_SIZETableAdapter.ClearBeforeFill = True
        '
        'CASING_WEIGHTTableAdapter
        '
        Me.CASING_WEIGHTTableAdapter.ClearBeforeFill = True
        '
        'SERVLINE_CUST_VTableAdapter
        '
        Me.SERVLINE_CUST_VTableAdapter.ClearBeforeFill = True
        '
        'TICKETSERVICETYPETableAdapter
        '
        Me.TICKETSERVICETYPETableAdapter.ClearBeforeFill = True
        '
        'TICKETOPEHOURTableAdapter
        '
        Me.TICKETOPEHOURTableAdapter.ClearBeforeFill = True
        '
        'frmTicketEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1509, 831)
        Me.Controls.Add(Me.pnlTicketCanceled)
        Me.Controls.Add(Me.pnlTicket)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmTicketEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INNTicket - Ticket Detail"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpbServiceDate.ResumeLayout(False)
        Me.gpbServiceDate.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.grpServiceType.ResumeLayout(False)
        Me.grpServiceType.PerformLayout()
        CType(Me.dgvTicketServType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETSERVICETYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERVICETYPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.tabSalesItem.ResumeLayout(False)
        Me.tabEquipments.ResumeLayout(False)
        Me.tabWorkers.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.dgvTicketOpeHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETOPEHOURBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.dgvWorker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETWORKERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOperReport.ResumeLayout(False)
        Me.tabServEvalHSEQ.ResumeLayout(False)
        Me.tabAdicInform.ResumeLayout(False)
        Me.tabAdicInform.PerformLayout()
        Me.grpAddicInfoARG.ResumeLayout(False)
        Me.grpAddicInfoARG.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.TUBINGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TUBBINGWEIGHTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TUBBINGDRILLPIPEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.CASINGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CASINGWEIGHTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CASINGSIZEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlTicket.ResumeLayout(False)
        Me.pnlTicket.PerformLayout()
        CType(Me.SERVLINECUSTVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRACTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CURRENCYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTicketCanceled.ResumeLayout(False)
        Me.pnlTicketCanceled.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tabSalesItem As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tabEquipments As System.Windows.Forms.TabPage
    Friend WithEvents tabWorkers As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SESTicketAccessDataSet As SESTicket.SESTicketAccessDataSet
    Friend WithEvents cbxServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents dtpTimeStarted As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeArrived As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeCompleted As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCustRepresAssist As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCustRepres As System.Windows.Forms.TextBox
    Friend WithEvents txtJobDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCustRepresPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtContrComments As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCustComments As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtRig As System.Windows.Forms.TextBox
    Friend WithEvents grpServiceType As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSaveTicket As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlTicket As System.Windows.Forms.Panel
    Friend WithEvents cbxCurrency As System.Windows.Forms.ComboBox
    Friend WithEvents lblCurrency As System.Windows.Forms.Label
    Friend WithEvents dtpServiceDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents txtTicketNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents lblTicketNumber As System.Windows.Forms.Label
    Friend WithEvents lblContract As System.Windows.Forms.Label
    Friend WithEvents CUSTOMERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUSTOMERTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents SERVICETYPEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERVICETYPETableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.SERVICETYPETableAdapter
    Friend WithEvents CURRENCYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CURRENCYTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.CURRENCYTableAdapter
    Friend WithEvents TUBINGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TUBINGTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.TUBINGTableAdapter
    ' Friend WithEvents CASING_SIZETableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.CASING_SIZETableAdapter
    'Friend WithEvents CASING_WEIGHTTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.CASING_WEIGHTTableAdapter
    Friend WithEvents CASINGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CASINGTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.CASINGTableAdapter
    Friend WithEvents cbxContract As System.Windows.Forms.ComboBox
    Friend WithEvents CONTRACTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONTRACTTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.CONTRACTTableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnWAdd As System.Windows.Forms.Button
    Friend WithEvents mnuCloseTicket As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TICKETWORKERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TICKETWORKERTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.TICKETWORKERTableAdapter
    Friend WithEvents dgvWorker As System.Windows.Forms.DataGridView
    Friend WithEvents colWTicketWorker As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWTimeStarted As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWTimeFinish As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pnlTicketCanceled As System.Windows.Forms.Panel
    Friend WithEvents lblTicketCancelDet As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtCustRepresAssistPos As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents gpbServiceDate As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelDet As System.Windows.Forms.Button
    Friend WithEvents pnlSalesItem As System.Windows.Forms.Panel
    Friend WithEvents tabAdicInform As System.Windows.Forms.TabPage
    Friend WithEvents txtAdicInform As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tabOperReport As System.Windows.Forms.TabPage
    Friend WithEvents pnlOperReport As System.Windows.Forms.Panel
    Friend WithEvents TUBBINGDRILLPIPEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TUBBING_DRILLPIPETableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.TUBBING_DRILLPIPETableAdapter
    Friend WithEvents TUBBINGWEIGHTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TUBBING_WEIGHTTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.TUBBING_WEIGHTTableAdapter
    Friend WithEvents CASINGSIZEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CASING_SIZETableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.CASING_SIZETableAdapter
    Friend WithEvents CASINGWEIGHTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CASING_WEIGHTTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.CASING_WEIGHTTableAdapter
    Friend WithEvents TicketSalesItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuJobLog As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuActaIniFimOpe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAttachment As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblServiceLine As System.Windows.Forms.Label
    Friend WithEvents cbxServiceLine As System.Windows.Forms.ComboBox
    Friend WithEvents tabServEvalHSEQ As System.Windows.Forms.TabPage
    Friend WithEvents pnlHSEQServEval As System.Windows.Forms.Panel
    Friend WithEvents SERVLINECUSTVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SERVLINE_CUST_VTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.SERVLINE_CUST_VTableAdapter
    Friend WithEvents txtWellName As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchWell As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txtMaxDepth As TextBox
    Friend WithEvents txtMaxPressure As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cbxTubingGrade As ComboBox
    Friend WithEvents cbxTubingWeight As ComboBox
    Friend WithEvents cbxTubingPipe As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbxCasingGrade As ComboBox
    Friend WithEvents cbxCasingWeight As ComboBox
    Friend WithEvents cbxCasingSize As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnSearchRig As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDeleteServiceLine As Button
    Friend WithEvents btnAddServiceType As Button
    Friend WithEvents TICKETSERVICETYPEBindingSource As BindingSource
    Friend WithEvents TICKETSERVICETYPETableAdapter As SESTicketAccessDataSetTableAdapters.TICKETSERVICETYPETableAdapter
    Friend WithEvents dgvTicketServType As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents colTicketServiceTypeId As DataGridViewTextBoxColumn
    Friend WithEvents colTicketId As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents grpAddicInfoARG As GroupBox
    Friend WithEvents txtDM As TextBox
    Friend WithEvents txtSupNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mnuInvItem As ToolStripMenuItem
    Friend WithEvents txtJobNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSONumber As TextBox
    Friend WithEvents btnSearchSite As Button
    Friend WithEvents txtSiteId As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents TICKETOPEHOURBindingSource As BindingSource
    Friend WithEvents TICKETOPEHOURTableAdapter As SESTicketAccessDataSetTableAdapters.TICKETOPEHOURTableAdapter
    Friend WithEvents dgvTicketOpeHour As DataGridView
    Friend WithEvents colOpHourTravel As DataGridViewTextBoxColumn
    Friend WithEvents colOpHourOperation As DataGridViewTextBoxColumn
    Friend WithEvents colOpHourStandby As DataGridViewTextBoxColumn
    Friend WithEvents colOpHourLost As DataGridViewTextBoxColumn
    Friend WithEvents colOpHourQde As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents txtContrRepres As TextBox
    Friend WithEvents btnSearchWorker As Button
    Friend WithEvents pnlEquipment As Panel
    Friend WithEvents txtSuperiorSupervisor As TextBox
    Friend WithEvents btnSearchSupervisor As Button
    Friend WithEvents Label27 As Label
    Friend WithEvents colWFullName As DataGridViewTextBoxColumn
    Friend WithEvents colWAppoint As DataGridViewTextBoxColumn
    Friend WithEvents colWRegisterDate As DataGridViewTextBoxColumn
    Friend WithEvents colHourTravel As DataGridViewTextBoxColumn
    Friend WithEvents colHourOperation As DataGridViewTextBoxColumn
    Friend WithEvents colHourStandby As DataGridViewTextBoxColumn
    Friend WithEvents colHourLost As DataGridViewTextBoxColumn
    Friend WithEvents colWHourQde As DataGridViewTextBoxColumn
    Friend WithEvents colResumeActivity As DataGridViewTextBoxColumn
    Friend WithEvents colWWorkerId As DataGridViewTextBoxColumn
    Friend WithEvents colWTicketWorkerID As DataGridViewTextBoxColumn
    Friend WithEvents FronteraToolStripMenuItem As ToolStripMenuItem
End Class
