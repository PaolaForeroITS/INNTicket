<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContractPriceRefreshTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContractPriceRefreshTicket))
        Me.dgvTicket = New System.Windows.Forms.DataGridView()
        Me.colChecked = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colTicketID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServiceLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TICKET_VBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.TICKET_VTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.TICKET_VTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager()
        Me.chkCheckAllLines = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxContract = New System.Windows.Forms.ComboBox()
        Me.CONTRACTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxCustomer = New System.Windows.Forms.ComboBox()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.chkShowClosed = New System.Windows.Forms.CheckBox()
        Me.btnRefreshPrices = New System.Windows.Forms.Button()
        Me.CUSTOMERTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.CUSTOMERTableAdapter()
        Me.CONTRACTTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.CONTRACTTableAdapter()
        CType(Me.dgvTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKET_VBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CONTRACTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTicket
        '
        Me.dgvTicket.AllowUserToAddRows = False
        Me.dgvTicket.AllowUserToDeleteRows = False
        Me.dgvTicket.AllowUserToResizeColumns = False
        Me.dgvTicket.AllowUserToResizeRows = False
        Me.dgvTicket.AutoGenerateColumns = False
        Me.dgvTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTicket.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colChecked, Me.colTicketID, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.colServiceLine, Me.DataGridViewTextBoxColumn4, Me.colTicketStatus})
        Me.dgvTicket.DataSource = Me.TICKET_VBindingSource
        Me.dgvTicket.Location = New System.Drawing.Point(7, 116)
        Me.dgvTicket.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvTicket.MultiSelect = False
        Me.dgvTicket.Name = "dgvTicket"
        Me.dgvTicket.ReadOnly = True
        Me.dgvTicket.RowHeadersWidth = 10
        Me.dgvTicket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTicket.Size = New System.Drawing.Size(1028, 577)
        Me.dgvTicket.TabIndex = 1
        '
        'colChecked
        '
        Me.colChecked.HeaderText = ""
        Me.colChecked.MinimumWidth = 6
        Me.colChecked.Name = "colChecked"
        Me.colChecked.ReadOnly = True
        Me.colChecked.Width = 40
        '
        'colTicketID
        '
        Me.colTicketID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTicketID.DataPropertyName = "TICKETID"
        Me.colTicketID.HeaderText = "Ticket"
        Me.colTicketID.MinimumWidth = 6
        Me.colTicketID.Name = "colTicketID"
        Me.colTicketID.ReadOnly = True
        Me.colTicketID.Width = 73
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FULLUSERNAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CreatedBy"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DATESERVICE"
        DataGridViewCellStyle1.Format = "dd/MM/yyyy"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "ServiceDate"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 72
        '
        'colServiceLine
        '
        Me.colServiceLine.DataPropertyName = "SERVICELINE"
        Me.colServiceLine.HeaderText = "Service Line"
        Me.colServiceLine.MinimumWidth = 6
        Me.colServiceLine.Name = "colServiceLine"
        Me.colServiceLine.ReadOnly = True
        Me.colServiceLine.Width = 160
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CUSTOMERNAME"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Customer"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'colTicketStatus
        '
        Me.colTicketStatus.DataPropertyName = "TICKETSTATUS"
        Me.colTicketStatus.HeaderText = "Status"
        Me.colTicketStatus.MinimumWidth = 6
        Me.colTicketStatus.Name = "colTicketStatus"
        Me.colTicketStatus.ReadOnly = True
        Me.colTicketStatus.Width = 68
        '
        'TICKET_VBindingSource
        '
        Me.TICKET_VBindingSource.DataMember = "TICKET_V"
        Me.TICKET_VBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TICKET_VTableAdapter
        '
        Me.TICKET_VTableAdapter.ClearBeforeFill = True
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
        'chkCheckAllLines
        '
        Me.chkCheckAllLines.AutoSize = True
        Me.chkCheckAllLines.Location = New System.Drawing.Point(28, 87)
        Me.chkCheckAllLines.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkCheckAllLines.Name = "chkCheckAllLines"
        Me.chkCheckAllLines.Size = New System.Drawing.Size(120, 20)
        Me.chkCheckAllLines.TabIndex = 2
        Me.chkCheckAllLines.Text = "Check All Lines"
        Me.chkCheckAllLines.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Customer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(399, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Contract:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxContract)
        Me.GroupBox1.Controls.Add(Me.cbxCustomer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1028, 54)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'cbxContract
        '
        Me.cbxContract.DataSource = Me.CONTRACTBindingSource
        Me.cbxContract.DisplayMember = "NAME"
        Me.cbxContract.FormattingEnabled = True
        Me.cbxContract.Location = New System.Drawing.Point(473, 20)
        Me.cbxContract.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxContract.Name = "cbxContract"
        Me.cbxContract.Size = New System.Drawing.Size(436, 24)
        Me.cbxContract.TabIndex = 7
        Me.cbxContract.ValueMember = "CONTRACTID"
        '
        'CONTRACTBindingSource
        '
        Me.CONTRACTBindingSource.DataMember = "CONTRACT"
        Me.CONTRACTBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'cbxCustomer
        '
        Me.cbxCustomer.DataSource = Me.CUSTOMERBindingSource
        Me.cbxCustomer.DisplayMember = "NAME"
        Me.cbxCustomer.FormattingEnabled = True
        Me.cbxCustomer.Location = New System.Drawing.Point(101, 20)
        Me.cbxCustomer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxCustomer.Name = "cbxCustomer"
        Me.cbxCustomer.Size = New System.Drawing.Size(279, 24)
        Me.cbxCustomer.TabIndex = 6
        Me.cbxCustomer.ValueMember = "CUSTOMERID"
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'chkShowClosed
        '
        Me.chkShowClosed.AutoSize = True
        Me.chkShowClosed.Location = New System.Drawing.Point(848, 87)
        Me.chkShowClosed.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkShowClosed.Name = "chkShowClosed"
        Me.chkShowClosed.Size = New System.Drawing.Size(155, 20)
        Me.chkShowClosed.TabIndex = 7
        Me.chkShowClosed.Text = "Show Closed Tickets"
        Me.chkShowClosed.UseVisualStyleBackColor = True
        '
        'btnRefreshPrices
        '
        Me.btnRefreshPrices.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshPrices.ForeColor = System.Drawing.Color.Maroon
        Me.btnRefreshPrices.Location = New System.Drawing.Point(376, 82)
        Me.btnRefreshPrices.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRefreshPrices.Name = "btnRefreshPrices"
        Me.btnRefreshPrices.Size = New System.Drawing.Size(176, 28)
        Me.btnRefreshPrices.TabIndex = 8
        Me.btnRefreshPrices.Text = "Refresh Prices"
        Me.btnRefreshPrices.UseVisualStyleBackColor = True
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'CONTRACTTableAdapter
        '
        Me.CONTRACTTableAdapter.ClearBeforeFill = True
        '
        'frmContractPriceRefreshTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1041, 700)
        Me.Controls.Add(Me.btnRefreshPrices)
        Me.Controls.Add(Me.chkShowClosed)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkCheckAllLines)
        Me.Controls.Add(Me.dgvTicket)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmContractPriceRefreshTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INNTicket - Refresh Contract Prices on Tickets"
        CType(Me.dgvTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKET_VBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CONTRACTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents TICKET_VBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TICKET_VTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.TICKET_VTableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvTicket As System.Windows.Forms.DataGridView
    Friend WithEvents chkCheckAllLines As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxContract As System.Windows.Forms.ComboBox
    Friend WithEvents cbxCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents chkShowClosed As System.Windows.Forms.CheckBox
    Friend WithEvents btnRefreshPrices As System.Windows.Forms.Button
    Friend WithEvents CUSTOMERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUSTOMERTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents CONTRACTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONTRACTTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.CONTRACTTableAdapter
    Friend WithEvents colChecked As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colTicketID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colServiceLine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTicketStatus As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
