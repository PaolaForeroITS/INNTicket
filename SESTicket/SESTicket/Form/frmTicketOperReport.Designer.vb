<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketOperReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketOperReport))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNewOperDate = New System.Windows.Forms.Button()
        Me.dgvOperDate = New System.Windows.Forms.DataGridView()
        Me.colTicketOpeRepId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceDescrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActivityDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colComments = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TICKETOPEREPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.btnNewActivity = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvActivityLine = New System.Windows.Forms.DataGridView()
        Me.colTicketOpeRepActId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketOpeReptId1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLineOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBold = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colAlignment = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colActivityTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TICKETOPEREPACTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnDeleteActivity = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.TICKETOPEREPTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TICKETOPEREPTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager()
        Me.TICKETOPEREPACTTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TICKETOPEREPACTTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvOperDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETOPEREPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvActivityLine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETOPEREPACTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNewOperDate)
        Me.GroupBox1.Controls.Add(Me.dgvOperDate)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(755, 162)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Job Log"
        '
        'btnNewOperDate
        '
        Me.btnNewOperDate.Location = New System.Drawing.Point(644, 23)
        Me.btnNewOperDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNewOperDate.Name = "btnNewOperDate"
        Me.btnNewOperDate.Size = New System.Drawing.Size(96, 27)
        Me.btnNewOperDate.TabIndex = 7
        Me.btnNewOperDate.Text = "New Log"
        Me.btnNewOperDate.UseVisualStyleBackColor = True
        '
        'dgvOperDate
        '
        Me.dgvOperDate.AllowUserToAddRows = False
        Me.dgvOperDate.AllowUserToDeleteRows = False
        Me.dgvOperDate.AllowUserToResizeColumns = False
        Me.dgvOperDate.AllowUserToResizeRows = False
        Me.dgvOperDate.AutoGenerateColumns = False
        Me.dgvOperDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOperDate.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTicketOpeRepId, Me.colTicketId, Me.colServiceDescrip, Me.colActivityDate, Me.colComments})
        Me.dgvOperDate.DataSource = Me.TICKETOPEREPBindingSource
        Me.dgvOperDate.Location = New System.Drawing.Point(8, 23)
        Me.dgvOperDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvOperDate.MultiSelect = False
        Me.dgvOperDate.Name = "dgvOperDate"
        Me.dgvOperDate.ReadOnly = True
        Me.dgvOperDate.RowHeadersWidth = 20
        Me.dgvOperDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOperDate.Size = New System.Drawing.Size(628, 129)
        Me.dgvOperDate.TabIndex = 0
        '
        'colTicketOpeRepId
        '
        Me.colTicketOpeRepId.DataPropertyName = "TICKETOPEREPID"
        Me.colTicketOpeRepId.HeaderText = "TICKETOPEREPID"
        Me.colTicketOpeRepId.MinimumWidth = 6
        Me.colTicketOpeRepId.Name = "colTicketOpeRepId"
        Me.colTicketOpeRepId.ReadOnly = True
        Me.colTicketOpeRepId.Visible = False
        Me.colTicketOpeRepId.Width = 125
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
        'colServiceDescrip
        '
        Me.colServiceDescrip.DataPropertyName = "SERVICEDESCR"
        Me.colServiceDescrip.HeaderText = "Service Description"
        Me.colServiceDescrip.MinimumWidth = 6
        Me.colServiceDescrip.Name = "colServiceDescrip"
        Me.colServiceDescrip.ReadOnly = True
        Me.colServiceDescrip.Width = 330
        '
        'colActivityDate
        '
        Me.colActivityDate.DataPropertyName = "ACTIVITYDATE"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colActivityDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.colActivityDate.HeaderText = "Activity Date"
        Me.colActivityDate.MinimumWidth = 6
        Me.colActivityDate.Name = "colActivityDate"
        Me.colActivityDate.ReadOnly = True
        Me.colActivityDate.Width = 125
        '
        'colComments
        '
        Me.colComments.DataPropertyName = "COMMENTS"
        Me.colComments.HeaderText = "COMMENTS"
        Me.colComments.MinimumWidth = 6
        Me.colComments.Name = "colComments"
        Me.colComments.ReadOnly = True
        Me.colComments.Visible = False
        Me.colComments.Width = 125
        '
        'TICKETOPEREPBindingSource
        '
        Me.TICKETOPEREPBindingSource.DataMember = "TICKETOPEREP"
        Me.TICKETOPEREPBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'btnNewActivity
        '
        Me.btnNewActivity.Location = New System.Drawing.Point(1324, 23)
        Me.btnNewActivity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNewActivity.Name = "btnNewActivity"
        Me.btnNewActivity.Size = New System.Drawing.Size(113, 41)
        Me.btnNewActivity.TabIndex = 8
        Me.btnNewActivity.Text = "New Line"
        Me.btnNewActivity.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvActivityLine)
        Me.GroupBox3.Controls.Add(Me.btnDeleteActivity)
        Me.GroupBox3.Controls.Add(Me.btnNewActivity)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 164)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(1456, 480)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Activities"
        '
        'dgvActivityLine
        '
        Me.dgvActivityLine.AllowUserToAddRows = False
        Me.dgvActivityLine.AllowUserToDeleteRows = False
        Me.dgvActivityLine.AutoGenerateColumns = False
        Me.dgvActivityLine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvActivityLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActivityLine.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTicketOpeRepActId, Me.colTicketOpeReptId1, Me.colLineOrder, Me.colBold, Me.colAlignment, Me.colActivityTime, Me.colDescription})
        Me.dgvActivityLine.DataSource = Me.TICKETOPEREPACTBindingSource
        Me.dgvActivityLine.Location = New System.Drawing.Point(8, 23)
        Me.dgvActivityLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvActivityLine.Name = "dgvActivityLine"
        Me.dgvActivityLine.RowHeadersWidth = 20
        Me.dgvActivityLine.Size = New System.Drawing.Size(1308, 449)
        Me.dgvActivityLine.TabIndex = 42
        '
        'colTicketOpeRepActId
        '
        Me.colTicketOpeRepActId.DataPropertyName = "TICKETOPEREPACTID"
        Me.colTicketOpeRepActId.HeaderText = "TICKETOPEREPACTID"
        Me.colTicketOpeRepActId.MinimumWidth = 6
        Me.colTicketOpeRepActId.Name = "colTicketOpeRepActId"
        Me.colTicketOpeRepActId.Visible = False
        Me.colTicketOpeRepActId.Width = 40
        '
        'colTicketOpeReptId1
        '
        Me.colTicketOpeReptId1.DataPropertyName = "TICKETOPEREPID"
        Me.colTicketOpeReptId1.HeaderText = "TICKETOPEREPID"
        Me.colTicketOpeReptId1.MinimumWidth = 6
        Me.colTicketOpeReptId1.Name = "colTicketOpeReptId1"
        Me.colTicketOpeReptId1.Visible = False
        Me.colTicketOpeReptId1.Width = 40
        '
        'colLineOrder
        '
        Me.colLineOrder.DataPropertyName = "LINEORDER"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.colLineOrder.DefaultCellStyle = DataGridViewCellStyle2
        Me.colLineOrder.HeaderText = "Order"
        Me.colLineOrder.MinimumWidth = 6
        Me.colLineOrder.Name = "colLineOrder"
        Me.colLineOrder.Width = 40
        '
        'colBold
        '
        Me.colBold.DataPropertyName = "BOLD"
        Me.colBold.HeaderText = "Bold"
        Me.colBold.MinimumWidth = 6
        Me.colBold.Name = "colBold"
        Me.colBold.Width = 50
        '
        'colAlignment
        '
        Me.colAlignment.DataPropertyName = "ALIGHMENT"
        Me.colAlignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colAlignment.HeaderText = "Alignment"
        Me.colAlignment.Items.AddRange(New Object() {"Left", "Middle", "Right"})
        Me.colAlignment.MinimumWidth = 6
        Me.colAlignment.Name = "colAlignment"
        Me.colAlignment.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colAlignment.Width = 60
        '
        'colActivityTime
        '
        Me.colActivityTime.DataPropertyName = "ACTIVITYTIME"
        Me.colActivityTime.HeaderText = "Time or Period"
        Me.colActivityTime.MinimumWidth = 6
        Me.colActivityTime.Name = "colActivityTime"
        Me.colActivityTime.Width = 125
        '
        'colDescription
        '
        Me.colDescription.DataPropertyName = "DESCRIPTION"
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colDescription.DefaultCellStyle = DataGridViewCellStyle3
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.MinimumWidth = 6
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Width = 670
        '
        'TICKETOPEREPACTBindingSource
        '
        Me.TICKETOPEREPACTBindingSource.DataMember = "TICKETOPEREPACT"
        Me.TICKETOPEREPACTBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'btnDeleteActivity
        '
        Me.btnDeleteActivity.Location = New System.Drawing.Point(1324, 71)
        Me.btnDeleteActivity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDeleteActivity.Name = "btnDeleteActivity"
        Me.btnDeleteActivity.Size = New System.Drawing.Size(113, 41)
        Me.btnDeleteActivity.TabIndex = 42
        Me.btnDeleteActivity.Text = "Delete Line"
        Me.btnDeleteActivity.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtComments)
        Me.GroupBox2.Location = New System.Drawing.Point(752, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(708, 171)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Comments"
        '
        'txtComments
        '
        Me.txtComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComments.Location = New System.Drawing.Point(15, 23)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtComments.MaxLength = 50000
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.ReadOnly = True
        Me.txtComments.Size = New System.Drawing.Size(685, 129)
        Me.txtComments.TabIndex = 0
        '
        'TICKETOPEREPTableAdapter
        '
        Me.TICKETOPEREPTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CASINGTableAdapter = Nothing
        Me.TableAdapterManager.CITYTableAdapter = Nothing
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
        Me.TableAdapterManager.TICKETOPEREPTableAdapter = Me.TICKETOPEREPTableAdapter
        Me.TableAdapterManager.TICKETTableAdapter = Nothing
        Me.TableAdapterManager.TMP_RPT_TICKETSERVEVALSERVTableAdapter = Nothing
        Me.TableAdapterManager.TMP_TICKETCLOSETableAdapter = Nothing
        Me.TableAdapterManager.TUBINGTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Nothing
        Me.TableAdapterManager.WELLTableAdapter = Nothing
        Me.TableAdapterManager.WORKERTableAdapter = Nothing
        '
        'TICKETOPEREPACTTableAdapter
        '
        Me.TICKETOPEREPACTTableAdapter.ClearBeforeFill = True
        '
        'frmTicketOperReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1467, 644)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmTicketOperReport"
        Me.Text = "frmTicketOperReport"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvOperDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETOPEREPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvActivityLine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETOPEREPACTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SESTicketAccessDataSet As SESTicket.SESTicketAccessDataSet
    Friend WithEvents TICKETOPEREPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TICKETOPEREPTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.TICKETOPEREPTableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvOperDate As System.Windows.Forms.DataGridView
    Friend WithEvents btnNewOperDate As System.Windows.Forms.Button
    Friend WithEvents TICKETOPEREPACTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TICKETOPEREPACTTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.TICKETOPEREPACTTableAdapter
    Friend WithEvents btnNewActivity As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDeleteActivity As System.Windows.Forms.Button
    Friend WithEvents dgvActivityLine As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents colTicketOpeRepActId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTicketOpeReptId1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colLineOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBold As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colAlignment As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colActivityTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTicketOpeRepId As DataGridViewTextBoxColumn
    Friend WithEvents colTicketId As DataGridViewTextBoxColumn
    Friend WithEvents colServiceDescrip As DataGridViewTextBoxColumn
    Friend WithEvents colActivityDate As DataGridViewTextBoxColumn
    Friend WithEvents colComments As DataGridViewTextBoxColumn
End Class
