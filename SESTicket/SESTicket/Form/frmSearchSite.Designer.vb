<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchSite
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchSite))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvSite = New System.Windows.Forms.DataGridView()
        Me.colSiteAlias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSiteId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SITESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.SITESTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.SITESTableAdapter()
        Me.TableAdapterManager = New SESTicket.SESTicketAccessDataSetTableAdapters.TableAdapterManager()
        CType(Me.dgvSite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SITESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(1, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Double click to select the line"
        '
        'dgvSite
        '
        Me.dgvSite.AllowUserToAddRows = False
        Me.dgvSite.AllowUserToDeleteRows = False
        Me.dgvSite.AllowUserToResizeColumns = False
        Me.dgvSite.AllowUserToResizeRows = False
        Me.dgvSite.AutoGenerateColumns = False
        Me.dgvSite.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSite.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSiteAlias, Me.colName, Me.colSiteId})
        Me.dgvSite.DataSource = Me.SITESBindingSource
        Me.dgvSite.Location = New System.Drawing.Point(4, 21)
        Me.dgvSite.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvSite.MultiSelect = False
        Me.dgvSite.Name = "dgvSite"
        Me.dgvSite.ReadOnly = True
        Me.dgvSite.RowTemplate.Height = 28
        Me.dgvSite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSite.Size = New System.Drawing.Size(497, 345)
        Me.dgvSite.TabIndex = 15
        '
        'colSiteAlias
        '
        Me.colSiteAlias.DataPropertyName = "ALIAS"
        Me.colSiteAlias.HeaderText = "Site"
        Me.colSiteAlias.Name = "colSiteAlias"
        Me.colSiteAlias.ReadOnly = True
        '
        'colName
        '
        Me.colName.DataPropertyName = "NAME"
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        Me.colName.ReadOnly = True
        Me.colName.Width = 320
        '
        'colSiteId
        '
        Me.colSiteId.DataPropertyName = "SITEID"
        Me.colSiteId.HeaderText = "SITEID"
        Me.colSiteId.Name = "colSiteId"
        Me.colSiteId.ReadOnly = True
        Me.colSiteId.Visible = False
        '
        'SITESBindingSource
        '
        Me.SITESBindingSource.DataMember = "SITES"
        Me.SITESBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'SITESTableAdapter
        '
        Me.SITESTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.SITESTableAdapter = Me.SITESTableAdapter
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
        'frmSearchSite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(504, 369)
        Me.Controls.Add(Me.dgvSite)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchSite"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Site"
        CType(Me.dgvSite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SITESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents SESTicketAccessDataSet As SESTicketAccessDataSet
    Friend WithEvents SITESBindingSource As BindingSource
    Friend WithEvents SITESTableAdapter As SESTicketAccessDataSetTableAdapters.SITESTableAdapter
    Friend WithEvents TableAdapterManager As SESTicketAccessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvSite As DataGridView
    Friend WithEvents colSiteAlias As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colSiteId As DataGridViewTextBoxColumn
End Class
