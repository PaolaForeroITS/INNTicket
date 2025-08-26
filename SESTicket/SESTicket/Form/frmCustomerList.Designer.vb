<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerList))
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.dgvCustomer = New System.Windows.Forms.DataGridView()
        Me.colCustomerID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAddress1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAddress2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCountry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colObs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSalesSubAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colARAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colARSubAccount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMERTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.CUSTOMERTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuNewItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgvCustomer
        '
        Me.dgvCustomer.AllowUserToAddRows = False
        Me.dgvCustomer.AllowUserToDeleteRows = False
        Me.dgvCustomer.AutoGenerateColumns = False
        Me.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCustomerID, Me.colName, Me.colAddress1, Me.colAddress2, Me.colCity, Me.colState, Me.colCountry, Me.colPhone, Me.colFax, Me.colEmail, Me.colObs, Me.colSalesAccount, Me.colSalesSubAccount, Me.colARAccount, Me.colARSubAccount})
        Me.dgvCustomer.DataSource = Me.CUSTOMERBindingSource
        Me.dgvCustomer.Location = New System.Drawing.Point(0, 45)
        Me.dgvCustomer.Name = "dgvCustomer"
        Me.dgvCustomer.ReadOnly = True
        Me.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomer.Size = New System.Drawing.Size(751, 262)
        Me.dgvCustomer.TabIndex = 1
        '
        'colCustomerID
        '
        Me.colCustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCustomerID.DataPropertyName = "CUSTOMERID"
        Me.colCustomerID.HeaderText = "ID"
        Me.colCustomerID.Name = "colCustomerID"
        Me.colCustomerID.ReadOnly = True
        Me.colCustomerID.Width = 43
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colName.DataPropertyName = "NAME"
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Width = 60
        '
        'colAddress1
        '
        Me.colAddress1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colAddress1.DataPropertyName = "ADDRESS1"
        Me.colAddress1.HeaderText = "Address1"
        Me.colAddress1.Name = "colAddress1"
        Me.colAddress1.ReadOnly = True
        Me.colAddress1.Width = 76
        '
        'colAddress2
        '
        Me.colAddress2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colAddress2.DataPropertyName = "ADDRESS2"
        Me.colAddress2.HeaderText = "Address2"
        Me.colAddress2.Name = "colAddress2"
        Me.colAddress2.ReadOnly = True
        Me.colAddress2.Visible = False
        '
        'colCity
        '
        Me.colCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCity.DataPropertyName = "CITY"
        Me.colCity.HeaderText = "City"
        Me.colCity.Name = "colCity"
        Me.colCity.ReadOnly = True
        Me.colCity.Visible = False
        '
        'colState
        '
        Me.colState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colState.DataPropertyName = "STATE"
        Me.colState.HeaderText = "State"
        Me.colState.Name = "colState"
        Me.colState.ReadOnly = True
        Me.colState.Visible = False
        '
        'colCountry
        '
        Me.colCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCountry.DataPropertyName = "COUNTRY"
        Me.colCountry.HeaderText = "Country"
        Me.colCountry.Name = "colCountry"
        Me.colCountry.ReadOnly = True
        Me.colCountry.Visible = False
        '
        'colPhone
        '
        Me.colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colPhone.DataPropertyName = "PHONE"
        Me.colPhone.HeaderText = "Phone"
        Me.colPhone.Name = "colPhone"
        Me.colPhone.ReadOnly = True
        Me.colPhone.Width = 63
        '
        'colFax
        '
        Me.colFax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colFax.DataPropertyName = "FAX"
        Me.colFax.HeaderText = "Fax"
        Me.colFax.Name = "colFax"
        Me.colFax.ReadOnly = True
        Me.colFax.Visible = False
        '
        'colEmail
        '
        Me.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colEmail.DataPropertyName = "EMAIL"
        Me.colEmail.HeaderText = "Email"
        Me.colEmail.Name = "colEmail"
        Me.colEmail.ReadOnly = True
        Me.colEmail.Visible = False
        '
        'colObs
        '
        Me.colObs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colObs.DataPropertyName = "OBS"
        Me.colObs.HeaderText = "Obs"
        Me.colObs.Name = "colObs"
        Me.colObs.ReadOnly = True
        Me.colObs.Visible = False
        '
        'colSalesAccount
        '
        Me.colSalesAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesAccount.DataPropertyName = "SALESACCOUNT"
        Me.colSalesAccount.HeaderText = "SalesAccount"
        Me.colSalesAccount.Name = "colSalesAccount"
        Me.colSalesAccount.ReadOnly = True
        Me.colSalesAccount.Visible = False
        '
        'colSalesSubAccount
        '
        Me.colSalesSubAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSalesSubAccount.DataPropertyName = "SALESSUBACCOUNT"
        Me.colSalesSubAccount.HeaderText = "SalesSubAccount"
        Me.colSalesSubAccount.Name = "colSalesSubAccount"
        Me.colSalesSubAccount.ReadOnly = True
        Me.colSalesSubAccount.Visible = False
        '
        'colARAccount
        '
        Me.colARAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colARAccount.DataPropertyName = "ARACCOUNT"
        Me.colARAccount.HeaderText = "ARAccount"
        Me.colARAccount.Name = "colARAccount"
        Me.colARAccount.ReadOnly = True
        Me.colARAccount.Visible = False
        '
        'colARSubAccount
        '
        Me.colARSubAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colARSubAccount.DataPropertyName = "ARSUBACCOUNT"
        Me.colARSubAccount.HeaderText = "ARSubAccount"
        Me.colARSubAccount.Name = "colARSubAccount"
        Me.colARSubAccount.ReadOnly = True
        Me.colARSubAccount.Visible = False
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CASINGTableAdapter = Nothing
        Me.TableAdapterManager.CITYTableAdapter = Nothing
        Me.TableAdapterManager.CONTRACTAIUINVENTORYCLASSTableAdapter = Nothing
        Me.TableAdapterManager.CONTRACTPRICELISTTableAdapter = Nothing
        Me.TableAdapterManager.CONTRACTTableAdapter = Nothing
        Me.TableAdapterManager.CUSTOMERTableAdapter = Me.CUSTOMERTableAdapter
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
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(751, 42)
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
        'frmCustomerList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(751, 308)
        Me.Controls.Add(Me.dgvCustomer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCustomerList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTicket - Customer"
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents CUSTOMERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUSTOMERTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents colCustomerID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddress1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAddress2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colState As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCountry As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFax As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colObs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSalesAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSalesSubAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colARAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colARSubAccount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNewItem As System.Windows.Forms.ToolStripMenuItem
End Class
