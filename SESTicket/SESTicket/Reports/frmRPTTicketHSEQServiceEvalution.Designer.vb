<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTTicketHSEQServiceEvalution
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkCanceled = New System.Windows.Forms.CheckBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.chkClosed = New System.Windows.Forms.CheckBox()
        Me.dtpServiceDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.chkOpen = New System.Windows.Forms.CheckBox()
        Me.dtpServiceDateBegin = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.TICKETHSEQ_VBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TICKETHSEQ_VTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.TICKETHSEQ_VTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETHSEQ_VBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkCanceled)
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.chkClosed)
        Me.GroupBox1.Controls.Add(Me.dtpServiceDateEnd)
        Me.GroupBox1.Controls.Add(Me.chkOpen)
        Me.GroupBox1.Controls.Add(Me.dtpServiceDateBegin)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 67)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'chkCanceled
        '
        Me.chkCanceled.AutoSize = True
        Me.chkCanceled.Checked = True
        Me.chkCanceled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCanceled.Location = New System.Drawing.Point(454, 20)
        Me.chkCanceled.Name = "chkCanceled"
        Me.chkCanceled.Size = New System.Drawing.Size(71, 17)
        Me.chkCanceled.TabIndex = 11
        Me.chkCanceled.Text = "Canceled"
        Me.chkCanceled.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(547, 19)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 43
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'chkClosed
        '
        Me.chkClosed.AutoSize = True
        Me.chkClosed.Checked = True
        Me.chkClosed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkClosed.Location = New System.Drawing.Point(390, 20)
        Me.chkClosed.Name = "chkClosed"
        Me.chkClosed.Size = New System.Drawing.Size(58, 17)
        Me.chkClosed.TabIndex = 10
        Me.chkClosed.Text = "Closed"
        Me.chkClosed.UseVisualStyleBackColor = True
        '
        'dtpServiceDateEnd
        '
        Me.dtpServiceDateEnd.CustomFormat = "dd/MM/yyyy"
        Me.dtpServiceDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpServiceDateEnd.Location = New System.Drawing.Point(139, 40)
        Me.dtpServiceDateEnd.Name = "dtpServiceDateEnd"
        Me.dtpServiceDateEnd.Size = New System.Drawing.Size(96, 20)
        Me.dtpServiceDateEnd.TabIndex = 40
        '
        'chkOpen
        '
        Me.chkOpen.AutoSize = True
        Me.chkOpen.Checked = True
        Me.chkOpen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOpen.Location = New System.Drawing.Point(332, 20)
        Me.chkOpen.Name = "chkOpen"
        Me.chkOpen.Size = New System.Drawing.Size(52, 17)
        Me.chkOpen.TabIndex = 9
        Me.chkOpen.Text = "Open"
        Me.chkOpen.UseVisualStyleBackColor = True
        '
        'dtpServiceDateBegin
        '
        Me.dtpServiceDateBegin.CustomFormat = "dd/MM/yyyy"
        Me.dtpServiceDateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpServiceDateBegin.Location = New System.Drawing.Point(139, 17)
        Me.dtpServiceDateBegin.Name = "dtpServiceDateBegin"
        Me.dtpServiceDateBegin.Size = New System.Drawing.Size(96, 20)
        Me.dtpServiceDateBegin.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(253, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ticket Status:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(25, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Service Date (End):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Service Date (Begin):"
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "dsInventory"
        ReportDataSource1.Value = Me.TICKETHSEQ_VBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SESTicket.rptTicketHSEQServiceEvalution.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 85)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1125, 473)
        Me.ReportViewer1.TabIndex = 4
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TICKETHSEQ_VBindingSource
        '
        Me.TICKETHSEQ_VBindingSource.DataMember = "TICKETHSEQ_V"
        Me.TICKETHSEQ_VBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'TICKETHSEQ_VTableAdapter
        '
        Me.TICKETHSEQ_VTableAdapter.ClearBeforeFill = True
        '
        'frmRPTTicketHSEQServiceEvalution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 563)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRPTTicketHSEQServiceEvalution"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report - HSEQ Service Evaluation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETHSEQ_VBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkCanceled As CheckBox
    Friend WithEvents btnOk As Button
    Friend WithEvents chkClosed As CheckBox
    Friend WithEvents dtpServiceDateEnd As DateTimePicker
    Friend WithEvents chkOpen As CheckBox
    Friend WithEvents dtpServiceDateBegin As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TICKETHSEQ_VBindingSource As BindingSource
    Friend WithEvents SESTicketSQLDataSet As SESTicketSQLDataSet
    Friend WithEvents TICKETHSEQ_VTableAdapter As SESTicketSQLDataSetTableAdapters.TICKETHSEQ_VTableAdapter
End Class
