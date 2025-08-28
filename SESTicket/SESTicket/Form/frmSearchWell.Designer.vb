<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchWell
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchWell))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cbxSearch = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvWell = New System.Windows.Forms.DataGridView()
        Me.colWellId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWellName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PETRFIELDIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRigId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SITENAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSiteId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTIVEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSiteAlias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WELLVBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet1 = New SESTicket.SESTicketAccessDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WELL_VTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.WELL_VTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvWell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WELLVBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.cbxSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(95, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(756, 62)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(637, 18)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(99, 28)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(531, 18)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(99, 28)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Ok"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cbxSearch
        '
        Me.cbxSearch.FormattingEnabled = True
        Me.cbxSearch.Items.AddRange(New Object() {"WellID", "Name", "Petroleum Field", "Rig", "Site"})
        Me.cbxSearch.Location = New System.Drawing.Point(103, 20)
        Me.cbxSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxSearch.Name = "cbxSearch"
        Me.cbxSearch.Size = New System.Drawing.Size(159, 24)
        Me.cbxSearch.TabIndex = 5
        Me.cbxSearch.Text = "WellID"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(271, 20)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(251, 22)
        Me.txtSearch.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search by:"
        '
        'dgvWell
        '
        Me.dgvWell.AllowUserToAddRows = False
        Me.dgvWell.AllowUserToDeleteRows = False
        Me.dgvWell.AutoGenerateColumns = False
        Me.dgvWell.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvWell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWell.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colWellId, Me.colWellName, Me.PETRFIELDIDDataGridViewTextBoxColumn, Me.colRigId, Me.SITENAMEDataGridViewTextBoxColumn, Me.colSiteId, Me.ACTIVEDataGridViewTextBoxColumn, Me.colSiteAlias})
        Me.dgvWell.DataSource = Me.WELLVBindingSource1
        Me.dgvWell.Location = New System.Drawing.Point(5, 112)
        Me.dgvWell.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvWell.MultiSelect = False
        Me.dgvWell.Name = "dgvWell"
        Me.dgvWell.ReadOnly = True
        Me.dgvWell.RowHeadersWidth = 51
        Me.dgvWell.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvWell.Size = New System.Drawing.Size(948, 558)
        Me.dgvWell.TabIndex = 12
        '
        'colWellId
        '
        Me.colWellId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colWellId.DataPropertyName = "WELLID"
        Me.colWellId.HeaderText = "Well ID"
        Me.colWellId.MinimumWidth = 6
        Me.colWellId.Name = "colWellId"
        Me.colWellId.ReadOnly = True
        Me.colWellId.Width = 74
        '
        'colWellName
        '
        Me.colWellName.DataPropertyName = "NAME"
        Me.colWellName.HeaderText = "Name"
        Me.colWellName.MinimumWidth = 6
        Me.colWellName.Name = "colWellName"
        Me.colWellName.ReadOnly = True
        Me.colWellName.Width = 180
        '
        'PETRFIELDIDDataGridViewTextBoxColumn
        '
        Me.PETRFIELDIDDataGridViewTextBoxColumn.DataPropertyName = "PETRFIELDDESCR"
        Me.PETRFIELDIDDataGridViewTextBoxColumn.HeaderText = "Petroleum Field"
        Me.PETRFIELDIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PETRFIELDIDDataGridViewTextBoxColumn.Name = "PETRFIELDIDDataGridViewTextBoxColumn"
        Me.PETRFIELDIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PETRFIELDIDDataGridViewTextBoxColumn.Width = 140
        '
        'colRigId
        '
        Me.colRigId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colRigId.DataPropertyName = "RIGID"
        Me.colRigId.HeaderText = "Rig"
        Me.colRigId.MinimumWidth = 6
        Me.colRigId.Name = "colRigId"
        Me.colRigId.ReadOnly = True
        Me.colRigId.Width = 57
        '
        'SITENAMEDataGridViewTextBoxColumn
        '
        Me.SITENAMEDataGridViewTextBoxColumn.DataPropertyName = "SITENAME"
        Me.SITENAMEDataGridViewTextBoxColumn.HeaderText = "Site"
        Me.SITENAMEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SITENAMEDataGridViewTextBoxColumn.Name = "SITENAMEDataGridViewTextBoxColumn"
        Me.SITENAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SITENAMEDataGridViewTextBoxColumn.Width = 125
        '
        'colSiteId
        '
        Me.colSiteId.DataPropertyName = "SITEID"
        Me.colSiteId.HeaderText = "SITEID"
        Me.colSiteId.MinimumWidth = 6
        Me.colSiteId.Name = "colSiteId"
        Me.colSiteId.ReadOnly = True
        Me.colSiteId.Visible = False
        Me.colSiteId.Width = 125
        '
        'ACTIVEDataGridViewTextBoxColumn
        '
        Me.ACTIVEDataGridViewTextBoxColumn.DataPropertyName = "ACTIVE"
        Me.ACTIVEDataGridViewTextBoxColumn.HeaderText = "ACTIVE"
        Me.ACTIVEDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ACTIVEDataGridViewTextBoxColumn.Name = "ACTIVEDataGridViewTextBoxColumn"
        Me.ACTIVEDataGridViewTextBoxColumn.ReadOnly = True
        Me.ACTIVEDataGridViewTextBoxColumn.Visible = False
        Me.ACTIVEDataGridViewTextBoxColumn.Width = 125
        '
        'colSiteAlias
        '
        Me.colSiteAlias.DataPropertyName = "SITEALIAS"
        Me.colSiteAlias.HeaderText = "SITEALIAS"
        Me.colSiteAlias.MinimumWidth = 6
        Me.colSiteAlias.Name = "colSiteAlias"
        Me.colSiteAlias.ReadOnly = True
        Me.colSiteAlias.Visible = False
        Me.colSiteAlias.Width = 125
        '
        'WELLVBindingSource1
        '
        Me.WELLVBindingSource1.DataMember = "WELL_V"
        Me.WELLVBindingSource1.DataSource = Me.SESTicketAccessDataSet1
        '
        'SESTicketAccessDataSet1
        '
        Me.SESTicketAccessDataSet1.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(5, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Double click to select the line"
        '
        'WELL_VTableAdapter
        '
        Me.WELL_VTableAdapter.ClearBeforeFill = True
        '
        'frmSearchWell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(959, 676)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvWell)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchWell"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Well"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvWell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WELLVBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cbxSearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvWell As System.Windows.Forms.DataGridView
    Friend WithEvents SITEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WELL_VTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.WELL_VTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SESTicketAccessDataSet1 As SESTicketAccessDataSet
    Friend WithEvents WELLVBindingSource1 As BindingSource
    Friend WithEvents colWellId As DataGridViewTextBoxColumn
    Friend WithEvents colWellName As DataGridViewTextBoxColumn
    Friend WithEvents PETRFIELDIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colRigId As DataGridViewTextBoxColumn
    Friend WithEvents SITENAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colSiteId As DataGridViewTextBoxColumn
    Friend WithEvents ACTIVEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colSiteAlias As DataGridViewTextBoxColumn
End Class
