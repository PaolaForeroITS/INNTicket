<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserList))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuNewItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.chkNo = New System.Windows.Forms.CheckBox()
        Me.chkYes = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.USERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.USERTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.USERTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager()
        Me.colUserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUsername = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUserLang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAppVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBaseDataSync = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTicketSync = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.USERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToDeleteRows = False
        Me.dgvUser.AllowUserToResizeColumns = False
        Me.dgvUser.AllowUserToResizeRows = False
        Me.dgvUser.AutoGenerateColumns = False
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colUserID, Me.colUsername, Me.colName, Me.colUserLang, Me.colAppVersion, Me.colBaseDataSync, Me.colTicketSync, Me.colActive})
        Me.dgvUser.DataSource = Me.USERBindingSource
        resources.ApplyResources(Me.dgvUser, "dgvUser")
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.ReadOnly = True
        Me.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewItem})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'mnuNewItem
        '
        resources.ApplyResources(Me.mnuNewItem, "mnuNewItem")
        Me.mnuNewItem.Name = "mnuNewItem"
        '
        'chkNo
        '
        resources.ApplyResources(Me.chkNo, "chkNo")
        Me.chkNo.Name = "chkNo"
        Me.chkNo.UseVisualStyleBackColor = True
        '
        'chkYes
        '
        resources.ApplyResources(Me.chkYes, "chkYes")
        Me.chkYes.Checked = True
        Me.chkYes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkYes.Name = "chkYes"
        Me.chkYes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'USERBindingSource
        '
        Me.USERBindingSource.DataMember = "USER"
        Me.USERBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'USERTableAdapter
        '
        Me.USERTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.USERTableAdapter = Me.USERTableAdapter
        Me.TableAdapterManager.WELLTableAdapter = Nothing
        Me.TableAdapterManager.WORKERTableAdapter = Nothing
        '
        'colUserID
        '
        Me.colUserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colUserID.DataPropertyName = "USERID"
        resources.ApplyResources(Me.colUserID, "colUserID")
        Me.colUserID.Name = "colUserID"
        Me.colUserID.ReadOnly = True
        '
        'colUsername
        '
        Me.colUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colUsername.DataPropertyName = "USERNAME"
        resources.ApplyResources(Me.colUsername, "colUsername")
        Me.colUsername.Name = "colUsername"
        Me.colUsername.ReadOnly = True
        '
        'colName
        '
        Me.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colName.DataPropertyName = "NAME"
        resources.ApplyResources(Me.colName, "colName")
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        '
        'colUserLang
        '
        Me.colUserLang.DataPropertyName = "USERLANG"
        resources.ApplyResources(Me.colUserLang, "colUserLang")
        Me.colUserLang.Name = "colUserLang"
        Me.colUserLang.ReadOnly = True
        '
        'colAppVersion
        '
        Me.colAppVersion.DataPropertyName = "APPVERSION"
        resources.ApplyResources(Me.colAppVersion, "colAppVersion")
        Me.colAppVersion.Name = "colAppVersion"
        Me.colAppVersion.ReadOnly = True
        '
        'colBaseDataSync
        '
        Me.colBaseDataSync.DataPropertyName = "BASEDATASYNC"
        DataGridViewCellStyle3.Format = "G"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.colBaseDataSync.DefaultCellStyle = DataGridViewCellStyle3
        resources.ApplyResources(Me.colBaseDataSync, "colBaseDataSync")
        Me.colBaseDataSync.Name = "colBaseDataSync"
        Me.colBaseDataSync.ReadOnly = True
        '
        'colTicketSync
        '
        Me.colTicketSync.DataPropertyName = "TICKETSYNC"
        DataGridViewCellStyle4.Format = "G"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.colTicketSync.DefaultCellStyle = DataGridViewCellStyle4
        resources.ApplyResources(Me.colTicketSync, "colTicketSync")
        Me.colTicketSync.Name = "colTicketSync"
        Me.colTicketSync.ReadOnly = True
        '
        'colActive
        '
        Me.colActive.DataPropertyName = "ACTIVE"
        resources.ApplyResources(Me.colActive, "colActive")
        Me.colActive.Name = "colActive"
        Me.colActive.ReadOnly = True
        '
        'frmUserList
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkNo)
        Me.Controls.Add(Me.chkYes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserList"
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.USERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents USERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents USERTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.USERTableAdapter
    Friend WithEvents TableAdapterManager As SESTicket.SESTicketSQLDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvUser As System.Windows.Forms.DataGridView
    Friend WithEvents colPassword As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEnabled As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNewItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkNo As System.Windows.Forms.CheckBox
    Friend WithEvents chkYes As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents colUserID As DataGridViewTextBoxColumn
    Friend WithEvents colUsername As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colUserLang As DataGridViewTextBoxColumn
    Friend WithEvents colAppVersion As DataGridViewTextBoxColumn
    Friend WithEvents colBaseDataSync As DataGridViewTextBoxColumn
    Friend WithEvents colTicketSync As DataGridViewTextBoxColumn
    Friend WithEvents colActive As DataGridViewTextBoxColumn
End Class
