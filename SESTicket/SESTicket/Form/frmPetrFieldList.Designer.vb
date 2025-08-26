<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPetrFieldList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPetrFieldList))
        Me.dgvPetrField = New System.Windows.Forms.DataGridView()
        Me.colPetrFieldCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPetrFieldArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPetrFieldId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PETRFIELDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuNewItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PETRFIELDTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.PETRFIELDTableAdapter()
        CType(Me.dgvPetrField, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETRFIELDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPetrField
        '
        Me.dgvPetrField.AllowUserToAddRows = False
        Me.dgvPetrField.AllowUserToDeleteRows = False
        Me.dgvPetrField.AutoGenerateColumns = False
        Me.dgvPetrField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPetrField.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPetrFieldCode, Me.colDescrip, Me.colPetrFieldArea, Me.colPetrFieldId})
        Me.dgvPetrField.DataSource = Me.PETRFIELDBindingSource
        Me.dgvPetrField.Location = New System.Drawing.Point(0, 45)
        Me.dgvPetrField.Name = "dgvPetrField"
        Me.dgvPetrField.ReadOnly = True
        Me.dgvPetrField.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPetrField.Size = New System.Drawing.Size(619, 479)
        Me.dgvPetrField.TabIndex = 1
        '
        'colPetrFieldCode
        '
        Me.colPetrFieldCode.DataPropertyName = "PETRFIELDCODE"
        Me.colPetrFieldCode.HeaderText = "Code"
        Me.colPetrFieldCode.Name = "colPetrFieldCode"
        Me.colPetrFieldCode.ReadOnly = True
        '
        'colDescrip
        '
        Me.colDescrip.DataPropertyName = "DESCRIP"
        Me.colDescrip.HeaderText = "Description"
        Me.colDescrip.Name = "colDescrip"
        Me.colDescrip.ReadOnly = True
        Me.colDescrip.Width = 250
        '
        'colPetrFieldArea
        '
        Me.colPetrFieldArea.DataPropertyName = "PETRFIELDAREA"
        Me.colPetrFieldArea.HeaderText = "Zona"
        Me.colPetrFieldArea.Name = "colPetrFieldArea"
        Me.colPetrFieldArea.ReadOnly = True
        Me.colPetrFieldArea.Width = 200
        '
        'colPetrFieldId
        '
        Me.colPetrFieldId.DataPropertyName = "PETRFIELDID"
        Me.colPetrFieldId.HeaderText = "PETRFIELDID"
        Me.colPetrFieldId.Name = "colPetrFieldId"
        Me.colPetrFieldId.ReadOnly = True
        Me.colPetrFieldId.Visible = False
        '
        'PETRFIELDBindingSource
        '
        Me.PETRFIELDBindingSource.DataMember = "PETRFIELD"
        Me.PETRFIELDBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(625, 42)
        Me.MenuStrip1.TabIndex = 35
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
        'PETRFIELDTableAdapter
        '
        Me.PETRFIELDTableAdapter.ClearBeforeFill = True
        '
        'frmPetrFieldList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(625, 525)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvPetrField)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPetrFieldList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTicket - Petroleum Fields"
        CType(Me.dgvPetrField, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETRFIELDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPetrField As System.Windows.Forms.DataGridView
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNewItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SESTicketSQLDataSet As SESTicketSQLDataSet
    Friend WithEvents PETRFIELDBindingSource As BindingSource
    Friend WithEvents PETRFIELDTableAdapter As SESTicketSQLDataSetTableAdapters.PETRFIELDTableAdapter
    Friend WithEvents colPetrFieldCode As DataGridViewTextBoxColumn
    Friend WithEvents colDescrip As DataGridViewTextBoxColumn
    Friend WithEvents colPetrFieldArea As DataGridViewTextBoxColumn
    Friend WithEvents colPetrFieldId As DataGridViewTextBoxColumn
End Class
