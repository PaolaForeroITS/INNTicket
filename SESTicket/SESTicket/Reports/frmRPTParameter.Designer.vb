<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTParameter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTParameter))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvParam = New System.Windows.Forms.DataGridView()
        Me.colDescrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHead1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHead2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSESLogo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAuxLogo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colReportParamId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REPORTPARAMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtParamDescrip = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.gpbLogo = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picAUXLogo = New System.Windows.Forms.PictureBox()
        Me.picSESLogo = New System.Windows.Forms.PictureBox()
        Me.grpHeaderText = New System.Windows.Forms.GroupBox()
        Me.txtHEAD2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHEAD1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.REPORTPARAMTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.REPORTPARAMTableAdapter()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvParam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPORTPARAMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gpbLogo.SuspendLayout()
        CType(Me.picAUXLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSESLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpHeaderText.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvParam)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 45)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(207, 471)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Parameter"
        '
        'dgvParam
        '
        Me.dgvParam.AllowUserToAddRows = False
        Me.dgvParam.AllowUserToDeleteRows = False
        Me.dgvParam.AllowUserToResizeColumns = False
        Me.dgvParam.AllowUserToResizeRows = False
        Me.dgvParam.AutoGenerateColumns = False
        Me.dgvParam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParam.ColumnHeadersVisible = False
        Me.dgvParam.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDescrip, Me.colHead1, Me.colHead2, Me.colSESLogo, Me.colAuxLogo, Me.colReportParamId})
        Me.dgvParam.DataSource = Me.REPORTPARAMBindingSource
        Me.dgvParam.Location = New System.Drawing.Point(9, 20)
        Me.dgvParam.MultiSelect = False
        Me.dgvParam.Name = "dgvParam"
        Me.dgvParam.ReadOnly = True
        Me.dgvParam.RowHeadersVisible = False
        Me.dgvParam.Size = New System.Drawing.Size(186, 442)
        Me.dgvParam.TabIndex = 0
        '
        'colDescrip
        '
        Me.colDescrip.DataPropertyName = "DESCRIP"
        Me.colDescrip.HeaderText = "DESCRIP"
        Me.colDescrip.Name = "colDescrip"
        Me.colDescrip.ReadOnly = True
        Me.colDescrip.Width = 160
        '
        'colHead1
        '
        Me.colHead1.DataPropertyName = "HEAD1"
        Me.colHead1.HeaderText = "HEAD1"
        Me.colHead1.Name = "colHead1"
        Me.colHead1.ReadOnly = True
        Me.colHead1.Visible = False
        '
        'colHead2
        '
        Me.colHead2.DataPropertyName = "HEAD2"
        Me.colHead2.HeaderText = "HEAD2"
        Me.colHead2.Name = "colHead2"
        Me.colHead2.ReadOnly = True
        Me.colHead2.Visible = False
        '
        'colSESLogo
        '
        Me.colSESLogo.DataPropertyName = "SESLOGO"
        Me.colSESLogo.HeaderText = "SESLOGO"
        Me.colSESLogo.Name = "colSESLogo"
        Me.colSESLogo.ReadOnly = True
        Me.colSESLogo.Visible = False
        '
        'colAuxLogo
        '
        Me.colAuxLogo.DataPropertyName = "AUXLOGO"
        Me.colAuxLogo.HeaderText = "AUXLOGO"
        Me.colAuxLogo.Name = "colAuxLogo"
        Me.colAuxLogo.ReadOnly = True
        Me.colAuxLogo.Visible = False
        '
        'colReportParamId
        '
        Me.colReportParamId.DataPropertyName = "REPORTPARAMID"
        Me.colReportParamId.HeaderText = "REPORTPARAMID"
        Me.colReportParamId.Name = "colReportParamId"
        Me.colReportParamId.ReadOnly = True
        Me.colReportParamId.Visible = False
        '
        'REPORTPARAMBindingSource
        '
        Me.REPORTPARAMBindingSource.DataMember = "REPORTPARAM"
        Me.REPORTPARAMBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuSave, Me.mnuEdit, Me.mnuDelete, Me.mnuCancel, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(556, 42)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuNew
        '
        Me.mnuNew.Image = CType(resources.GetObject("mnuNew.Image"), System.Drawing.Image)
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(59, 38)
        Me.mnuNew.Text = "New"
        '
        'mnuSave
        '
        Me.mnuSave.Image = CType(resources.GetObject("mnuSave.Image"), System.Drawing.Image)
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(59, 38)
        Me.mnuSave.Text = "Save"
        '
        'mnuEdit
        '
        Me.mnuEdit.Image = CType(resources.GetObject("mnuEdit.Image"), System.Drawing.Image)
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(55, 38)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuDelete
        '
        Me.mnuDelete.Image = CType(resources.GetObject("mnuDelete.Image"), System.Drawing.Image)
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(68, 38)
        Me.mnuDelete.Text = "Delete"
        '
        'mnuCancel
        '
        Me.mnuCancel.Image = CType(resources.GetObject("mnuCancel.Image"), System.Drawing.Image)
        Me.mnuCancel.Name = "mnuCancel"
        Me.mnuCancel.Size = New System.Drawing.Size(71, 38)
        Me.mnuCancel.Text = "Cancel"
        '
        'mnuExit
        '
        Me.mnuExit.Image = CType(resources.GetObject("mnuExit.Image"), System.Drawing.Image)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(53, 38)
        Me.mnuExit.Text = "Exit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtParamDescrip)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Location = New System.Drawing.Point(216, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 44)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'txtParamDescrip
        '
        Me.txtParamDescrip.Location = New System.Drawing.Point(85, 14)
        Me.txtParamDescrip.Name = "txtParamDescrip"
        Me.txtParamDescrip.Size = New System.Drawing.Size(194, 20)
        Me.txtParamDescrip.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(21, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name:"
        '
        'gpbLogo
        '
        Me.gpbLogo.Controls.Add(Me.Label3)
        Me.gpbLogo.Controls.Add(Me.Label1)
        Me.gpbLogo.Controls.Add(Me.picAUXLogo)
        Me.gpbLogo.Controls.Add(Me.picSESLogo)
        Me.gpbLogo.Location = New System.Drawing.Point(216, 95)
        Me.gpbLogo.Name = "gpbLogo"
        Me.gpbLogo.Size = New System.Drawing.Size(316, 105)
        Me.gpbLogo.TabIndex = 35
        Me.gpbLogo.TabStop = False
        Me.gpbLogo.Text = "Logo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(153, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Image Local:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Image SES:"
        '
        'picAUXLogo
        '
        Me.picAUXLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAUXLogo.Location = New System.Drawing.Point(156, 43)
        Me.picAUXLogo.Name = "picAUXLogo"
        Me.picAUXLogo.Size = New System.Drawing.Size(126, 50)
        Me.picAUXLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAUXLogo.TabIndex = 1
        Me.picAUXLogo.TabStop = False
        '
        'picSESLogo
        '
        Me.picSESLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picSESLogo.Location = New System.Drawing.Point(24, 43)
        Me.picSESLogo.Name = "picSESLogo"
        Me.picSESLogo.Size = New System.Drawing.Size(126, 50)
        Me.picSESLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSESLogo.TabIndex = 0
        Me.picSESLogo.TabStop = False
        '
        'grpHeaderText
        '
        Me.grpHeaderText.Controls.Add(Me.txtHEAD2)
        Me.grpHeaderText.Controls.Add(Me.Label4)
        Me.grpHeaderText.Controls.Add(Me.txtHEAD1)
        Me.grpHeaderText.Controls.Add(Me.Label5)
        Me.grpHeaderText.Location = New System.Drawing.Point(216, 206)
        Me.grpHeaderText.Name = "grpHeaderText"
        Me.grpHeaderText.Size = New System.Drawing.Size(333, 311)
        Me.grpHeaderText.TabIndex = 36
        Me.grpHeaderText.TabStop = False
        Me.grpHeaderText.Text = "Header Text"
        '
        'txtHEAD2
        '
        Me.txtHEAD2.Location = New System.Drawing.Point(9, 183)
        Me.txtHEAD2.MaxLength = 1000
        Me.txtHEAD2.Multiline = True
        Me.txtHEAD2.Name = "txtHEAD2"
        Me.txtHEAD2.Size = New System.Drawing.Size(315, 118)
        Me.txtHEAD2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "# 2:"
        '
        'txtHEAD1
        '
        Me.txtHEAD1.Location = New System.Drawing.Point(9, 43)
        Me.txtHEAD1.MaxLength = 1000
        Me.txtHEAD1.Multiline = True
        Me.txtHEAD1.Name = "txtHEAD1"
        Me.txtHEAD1.Size = New System.Drawing.Size(315, 118)
        Me.txtHEAD1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "# 1:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Image|*.jpg;*.jpeg;*.bmp;*.png;*.ico|All files|*.*"
        '
        'REPORTPARAMTableAdapter
        '
        Me.REPORTPARAMTableAdapter.ClearBeforeFill = True
        '
        'frmRPTParameter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 528)
        Me.Controls.Add(Me.grpHeaderText)
        Me.Controls.Add(Me.gpbLogo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRPTParameter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTICKET - Report Parameter"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvParam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPORTPARAMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpbLogo.ResumeLayout(False)
        Me.gpbLogo.PerformLayout()
        CType(Me.picAUXLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSESLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpHeaderText.ResumeLayout(False)
        Me.grpHeaderText.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvParam As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtParamDescrip As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents gpbLogo As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picAUXLogo As System.Windows.Forms.PictureBox
    Friend WithEvents picSESLogo As System.Windows.Forms.PictureBox
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpHeaderText As System.Windows.Forms.GroupBox
    Friend WithEvents txtHEAD1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtHEAD2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SESTicketAccessDataSet As SESTicket.SESTicketAccessDataSet
    Friend WithEvents REPORTPARAMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REPORTPARAMTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.REPORTPARAMTableAdapter
    Friend WithEvents colDescrip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHead1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHead2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSESLogo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAuxLogo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colReportParamId As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
