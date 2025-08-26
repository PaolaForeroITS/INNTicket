<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTExcel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTExcel))
        Me.cbxExcelLayout = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxRepParam = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.REPORTPARAMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REPORTPARAMTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.REPORTPARAMTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPORTPARAMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxExcelLayout
        '
        Me.cbxExcelLayout.FormattingEnabled = True
        Me.cbxExcelLayout.Items.AddRange(New Object() {"Ecopetrol - Material", "Ecopetrol - Service"})
        Me.cbxExcelLayout.Location = New System.Drawing.Point(86, 43)
        Me.cbxExcelLayout.Name = "cbxExcelLayout"
        Me.cbxExcelLayout.Size = New System.Drawing.Size(280, 21)
        Me.cbxExcelLayout.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Excel Layout:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Parameter:"
        '
        'cbxRepParam
        '
        Me.cbxRepParam.DataSource = Me.REPORTPARAMBindingSource
        Me.cbxRepParam.DisplayMember = "DESCRIP"
        Me.cbxRepParam.FormattingEnabled = True
        Me.cbxRepParam.Location = New System.Drawing.Point(86, 70)
        Me.cbxRepParam.Name = "cbxRepParam"
        Me.cbxRepParam.Size = New System.Drawing.Size(280, 21)
        Me.cbxRepParam.TabIndex = 16
        Me.cbxRepParam.ValueMember = "REPORTPARAMID"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(378, 42)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuSave
        '
        Me.mnuSave.Image = CType(resources.GetObject("mnuSave.Image"), System.Drawing.Image)
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(82, 38)
        Me.mnuSave.Text = "Generate"
        '
        'mnuExit
        '
        Me.mnuExit.Image = CType(resources.GetObject("mnuExit.Image"), System.Drawing.Image)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(53, 38)
        Me.mnuExit.Text = "Exit"
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'REPORTPARAMBindingSource
        '
        Me.REPORTPARAMBindingSource.DataMember = "REPORTPARAM"
        Me.REPORTPARAMBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'REPORTPARAMTableAdapter
        '
        Me.REPORTPARAMTableAdapter.ClearBeforeFill = True
        '
        'frmRPTExcel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(378, 101)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxRepParam)
        Me.Controls.Add(Me.cbxExcelLayout)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRPTExcel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTicket - Report Excel Tool"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPORTPARAMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxExcelLayout As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxRepParam As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents SESTicketAccessDataSet As SESTicketAccessDataSet
    Friend WithEvents REPORTPARAMBindingSource As BindingSource
    Friend WithEvents REPORTPARAMTableAdapter As SESTicketAccessDataSetTableAdapters.REPORTPARAMTableAdapter
End Class
