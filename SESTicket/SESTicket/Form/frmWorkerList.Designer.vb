<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkerList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkerList))
        Me.WORKERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.dgvWorker = New System.Windows.Forms.DataGridView()
        Me.colWorkerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSurname1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSurname2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAppointment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSubaccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBonusValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colManHourValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WORKERTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.WORKERTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuNewItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExportData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImportData = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkNo = New System.Windows.Forms.CheckBox()
        Me.chkYes = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.WORKERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvWorker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WORKERBindingSource
        '
        Me.WORKERBindingSource.DataMember = "WORKER"
        Me.WORKERBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvWorker
        '
        Me.dgvWorker.AllowUserToAddRows = False
        Me.dgvWorker.AllowUserToDeleteRows = False
        Me.dgvWorker.AllowUserToResizeRows = False
        Me.dgvWorker.AutoGenerateColumns = False
        Me.dgvWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorker.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colWorkerID, Me.colName1, Me.colName2, Me.colSurname1, Me.colSurname2, Me.colAppointment, Me.colSubaccount, Me.colEmail, Me.colPhone, Me.colBonusValue, Me.colManHourValue, Me.colActive})
        Me.dgvWorker.DataSource = Me.WORKERBindingSource
        Me.dgvWorker.Location = New System.Drawing.Point(0, 45)
        Me.dgvWorker.Name = "dgvWorker"
        Me.dgvWorker.ReadOnly = True
        Me.dgvWorker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvWorker.Size = New System.Drawing.Size(967, 476)
        Me.dgvWorker.TabIndex = 1
        '
        'colWorkerID
        '
        Me.colWorkerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colWorkerID.DataPropertyName = "WORKERID"
        Me.colWorkerID.HeaderText = "ID"
        Me.colWorkerID.Name = "colWorkerID"
        Me.colWorkerID.ReadOnly = True
        Me.colWorkerID.Width = 43
        '
        'colName1
        '
        Me.colName1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colName1.DataPropertyName = "NAME1"
        Me.colName1.HeaderText = "Name1"
        Me.colName1.Name = "colName1"
        Me.colName1.ReadOnly = True
        Me.colName1.Width = 66
        '
        'colName2
        '
        Me.colName2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colName2.DataPropertyName = "NAME2"
        Me.colName2.HeaderText = "Name2"
        Me.colName2.Name = "colName2"
        Me.colName2.ReadOnly = True
        Me.colName2.Width = 66
        '
        'colSurname1
        '
        Me.colSurname1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSurname1.DataPropertyName = "SURNAME1"
        Me.colSurname1.HeaderText = "Surname1"
        Me.colSurname1.Name = "colSurname1"
        Me.colSurname1.ReadOnly = True
        Me.colSurname1.Width = 80
        '
        'colSurname2
        '
        Me.colSurname2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSurname2.DataPropertyName = "SURNAME2"
        Me.colSurname2.HeaderText = "Surname2"
        Me.colSurname2.Name = "colSurname2"
        Me.colSurname2.ReadOnly = True
        Me.colSurname2.Width = 80
        '
        'colAppointment
        '
        Me.colAppointment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colAppointment.DataPropertyName = "APPOINTMENT"
        Me.colAppointment.HeaderText = "Appointment"
        Me.colAppointment.Name = "colAppointment"
        Me.colAppointment.ReadOnly = True
        Me.colAppointment.Width = 91
        '
        'colSubaccount
        '
        Me.colSubaccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSubaccount.DataPropertyName = "SUBACCOUNT"
        Me.colSubaccount.HeaderText = "SubAccount"
        Me.colSubaccount.Name = "colSubaccount"
        Me.colSubaccount.ReadOnly = True
        Me.colSubaccount.Width = 91
        '
        'colEmail
        '
        Me.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colEmail.DataPropertyName = "EMAIL"
        Me.colEmail.HeaderText = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.Width = 57
        '
        'colPhone
        '
        Me.colPhone.DataPropertyName = "PHONE"
        Me.colPhone.HeaderText = "Phone"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.ReadOnly = True
        '
        'colBonusValue
        '
        Me.colBonusValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colBonusValue.DataPropertyName = "BONUSVALUE"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colBonusValue.DefaultCellStyle = DataGridViewCellStyle1
        Me.colBonusValue.HeaderText = "Bonus Value"
        Me.colBonusValue.Name = "colBonusValue"
        Me.colBonusValue.ReadOnly = True
        Me.colBonusValue.Width = 85
        '
        'colManHourValue
        '
        Me.colManHourValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colManHourValue.DataPropertyName = "MANHOURVALUE"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.colManHourValue.DefaultCellStyle = DataGridViewCellStyle2
        Me.colManHourValue.HeaderText = "Man-Hour Value"
        Me.colManHourValue.Name = "colManHourValue"
        Me.colManHourValue.ReadOnly = True
        '
        'colActive
        '
        Me.colActive.DataPropertyName = "ACTIVE"
        Me.colActive.HeaderText = "Active"
        Me.colActive.Name = "colActive"
        Me.colActive.ReadOnly = True
        Me.colActive.Width = 60
        '
        'WORKERTableAdapter
        '
        Me.WORKERTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SERVICETYPETableAdapter = Nothing
        Me.TableAdapterManager.SITESTableAdapter = Nothing
        Me.TableAdapterManager.STATETableAdapter = Nothing
        Me.TableAdapterManager.TICKETINVOICELINETableAdapter = Nothing
        Me.TableAdapterManager.TUBINGTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.USERTableAdapter = Nothing
        Me.TableAdapterManager.WELLTableAdapter = Nothing
        Me.TableAdapterManager.WORKERTableAdapter = Me.WORKERTableAdapter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewItem, Me.mnuExportData, Me.mnuImportData})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(979, 42)
        Me.MenuStrip1.TabIndex = 32
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
        'mnuExportData
        '
        Me.mnuExportData.Image = CType(resources.GetObject("mnuExportData.Image"), System.Drawing.Image)
        Me.mnuExportData.Name = "mnuExportData"
        Me.mnuExportData.Size = New System.Drawing.Size(95, 38)
        Me.mnuExportData.Text = "Export Data"
        '
        'mnuImportData
        '
        Me.mnuImportData.Image = CType(resources.GetObject("mnuImportData.Image"), System.Drawing.Image)
        Me.mnuImportData.Name = "mnuImportData"
        Me.mnuImportData.Size = New System.Drawing.Size(98, 38)
        Me.mnuImportData.Text = "Import Data"
        '
        'chkNo
        '
        Me.chkNo.AutoSize = True
        Me.chkNo.Location = New System.Drawing.Point(927, 16)
        Me.chkNo.Name = "chkNo"
        Me.chkNo.Size = New System.Drawing.Size(40, 17)
        Me.chkNo.TabIndex = 37
        Me.chkNo.Text = "No"
        Me.chkNo.UseVisualStyleBackColor = True
        '
        'chkYes
        '
        Me.chkYes.AutoSize = True
        Me.chkYes.Checked = True
        Me.chkYes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkYes.Location = New System.Drawing.Point(877, 16)
        Me.chkYes.Name = "chkYes"
        Me.chkYes.Size = New System.Drawing.Size(44, 17)
        Me.chkYes.TabIndex = 36
        Me.chkYes.Text = "Yes"
        Me.chkYes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(831, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Active:"
        '
        'frmWorkerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(979, 527)
        Me.Controls.Add(Me.chkNo)
        Me.Controls.Add(Me.chkYes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvWorker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWorkerList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTicket - Worker"
        CType(Me.WORKERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvWorker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents WORKERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WORKERTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.WORKERTableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvWorker As System.Windows.Forms.DataGridView
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colWorkerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSurname1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSurname2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAppointment As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubaccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBonusValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colManHourValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colActive As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNewItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExportData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuImportData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkNo As System.Windows.Forms.CheckBox
    Friend WithEvents chkYes As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
