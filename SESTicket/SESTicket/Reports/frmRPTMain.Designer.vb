<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTMain))
        Me.pnlReport = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxTicketLayout = New System.Windows.Forms.ComboBox()
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.cbxOrientation = New System.Windows.Forms.ComboBox()
        Me.lblOrientation = New System.Windows.Forms.Label()
        Me.chkPageBreak = New System.Windows.Forms.CheckBox()
        Me.cbxRepParam = New System.Windows.Forms.ComboBox()
        Me.REPORTPARAMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.REPORTPARAMTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.REPORTPARAMTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxCountry = New System.Windows.Forms.ComboBox()
        Me.COUNTRYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COUNTRYTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.COUNTRYTableAdapter()
        Me.CONTRACTREPLAYOUTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTRACTREPLAYOUTTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.CONTRACTREPLAYOUTTableAdapter()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPORTPARAMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COUNTRYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRACTREPLAYOUTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlReport
        '
        Me.pnlReport.Location = New System.Drawing.Point(0, 41)
        Me.pnlReport.Name = "pnlReport"
        Me.pnlReport.Size = New System.Drawing.Size(1204, 645)
        Me.pnlReport.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ticket Layout:"
        '
        'cbxTicketLayout
        '
        Me.cbxTicketLayout.DataSource = Me.CONTRACTREPLAYOUTBindingSource
        Me.cbxTicketLayout.DisplayMember = "REPORTNAME"
        Me.cbxTicketLayout.FormattingEnabled = True
        Me.cbxTicketLayout.Location = New System.Drawing.Point(234, 12)
        Me.cbxTicketLayout.Name = "cbxTicketLayout"
        Me.cbxTicketLayout.Size = New System.Drawing.Size(280, 21)
        Me.cbxTicketLayout.TabIndex = 2
        Me.cbxTicketLayout.ValueMember = "REPORTCODE"
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'cbxOrientation
        '
        Me.cbxOrientation.FormattingEnabled = True
        Me.cbxOrientation.Items.AddRange(New Object() {"Portrait", "Landscape"})
        Me.cbxOrientation.Location = New System.Drawing.Point(786, 12)
        Me.cbxOrientation.Name = "cbxOrientation"
        Me.cbxOrientation.Size = New System.Drawing.Size(77, 21)
        Me.cbxOrientation.TabIndex = 6
        Me.cbxOrientation.Text = "Landscape"
        '
        'lblOrientation
        '
        Me.lblOrientation.AutoSize = True
        Me.lblOrientation.Location = New System.Drawing.Point(719, 15)
        Me.lblOrientation.Name = "lblOrientation"
        Me.lblOrientation.Size = New System.Drawing.Size(61, 13)
        Me.lblOrientation.TabIndex = 5
        Me.lblOrientation.Text = "Orientation:"
        '
        'chkPageBreak
        '
        Me.chkPageBreak.AutoSize = True
        Me.chkPageBreak.Location = New System.Drawing.Point(526, 14)
        Me.chkPageBreak.Name = "chkPageBreak"
        Me.chkPageBreak.Size = New System.Drawing.Size(188, 17)
        Me.chkPageBreak.TabIndex = 7
        Me.chkPageBreak.Text = "Totals and Signature in New Page"
        Me.chkPageBreak.UseVisualStyleBackColor = True
        '
        'cbxRepParam
        '
        Me.cbxRepParam.DataSource = Me.REPORTPARAMBindingSource
        Me.cbxRepParam.DisplayMember = "DESCRIP"
        Me.cbxRepParam.FormattingEnabled = True
        Me.cbxRepParam.Location = New System.Drawing.Point(945, 12)
        Me.cbxRepParam.Name = "cbxRepParam"
        Me.cbxRepParam.Size = New System.Drawing.Size(214, 21)
        Me.cbxRepParam.TabIndex = 8
        Me.cbxRepParam.ValueMember = "REPORTPARAMID"
        '
        'REPORTPARAMBindingSource
        '
        Me.REPORTPARAMBindingSource.DataMember = "REPORTPARAM"
        Me.REPORTPARAMBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(881, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Parameter:"
        '
        'REPORTPARAMTableAdapter
        '
        Me.REPORTPARAMTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Country:"
        '
        'cbxCountry
        '
        Me.cbxCountry.DataSource = Me.COUNTRYBindingSource
        Me.cbxCountry.DisplayMember = "COUNTRYCODE"
        Me.cbxCountry.FormattingEnabled = True
        Me.cbxCountry.Location = New System.Drawing.Point(64, 12)
        Me.cbxCountry.Name = "cbxCountry"
        Me.cbxCountry.Size = New System.Drawing.Size(77, 21)
        Me.cbxCountry.TabIndex = 11
        Me.cbxCountry.ValueMember = "COUNTRYCODE"
        '
        'COUNTRYBindingSource
        '
        Me.COUNTRYBindingSource.DataMember = "COUNTRY"
        Me.COUNTRYBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'COUNTRYTableAdapter
        '
        Me.COUNTRYTableAdapter.ClearBeforeFill = True
        '
        'CONTRACTREPLAYOUTBindingSource
        '
        Me.CONTRACTREPLAYOUTBindingSource.DataMember = "CONTRACTREPLAYOUT"
        Me.CONTRACTREPLAYOUTBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'CONTRACTREPLAYOUTTableAdapter
        '
        Me.CONTRACTREPLAYOUTTableAdapter.ClearBeforeFill = True
        '
        'frmRPTMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 698)
        Me.Controls.Add(Me.cbxCountry)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxRepParam)
        Me.Controls.Add(Me.chkPageBreak)
        Me.Controls.Add(Me.cbxOrientation)
        Me.Controls.Add(Me.lblOrientation)
        Me.Controls.Add(Me.cbxTicketLayout)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRPTMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ticket Printing"
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPORTPARAMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COUNTRYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRACTREPLAYOUTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlReport As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxTicketLayout As System.Windows.Forms.ComboBox
    Friend WithEvents cbxOrientation As System.Windows.Forms.ComboBox
    Friend WithEvents lblOrientation As System.Windows.Forms.Label
    Friend WithEvents chkPageBreak As System.Windows.Forms.CheckBox
    Friend WithEvents cbxRepParam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SESTicketAccessDataSet As SESTicket.SESTicketAccessDataSet
    Friend WithEvents REPORTPARAMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REPORTPARAMTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.REPORTPARAMTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxCountry As ComboBox
    Friend WithEvents COUNTRYBindingSource As BindingSource
    Friend WithEvents COUNTRYTableAdapter As SESTicketAccessDataSetTableAdapters.COUNTRYTableAdapter
    Friend WithEvents CONTRACTREPLAYOUTBindingSource As BindingSource
    Friend WithEvents CONTRACTREPLAYOUTTableAdapter As SESTicketAccessDataSetTableAdapters.CONTRACTREPLAYOUTTableAdapter
End Class
