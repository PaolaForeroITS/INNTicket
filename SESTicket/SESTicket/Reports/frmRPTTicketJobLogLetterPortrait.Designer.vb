<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTTicketJobLogLetterPortrait
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTTicketJobLogLetterPortrait))
        Me.REPORTHEADER_VBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.TICKETOPEREPACTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TICKETOPEREPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TMP_TICKETOPEREPWORKERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnOk = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxJobLog = New System.Windows.Forms.ComboBox()
        Me.REPORTHEADER_VTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.REPORTHEADER_VTableAdapter()
        Me.TICKETOPEREPACTTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TICKETOPEREPACTTableAdapter()
        Me.TICKETOPEREPTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TICKETOPEREPTableAdapter()
        Me.TMP_TICKETOPEREPWORKERTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TMP_TICKETOPEREPWORKERTableAdapter()
        CType(Me.REPORTHEADER_VBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETOPEREPACTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETOPEREPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TMP_TICKETOPEREPWORKERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'REPORTHEADER_VBindingSource
        '
        Me.REPORTHEADER_VBindingSource.DataMember = "REPORTHEADER_V"
        Me.REPORTHEADER_VBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'TICKETOPEREPACTBindingSource
        '
        Me.TICKETOPEREPACTBindingSource.DataMember = "TICKETOPEREPACT"
        Me.TICKETOPEREPACTBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'TICKETOPEREPBindingSource
        '
        Me.TICKETOPEREPBindingSource.DataMember = "TICKETOPEREP"
        Me.TICKETOPEREPBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'TMP_TICKETOPEREPWORKERBindingSource
        '
        Me.TMP_TICKETOPEREPWORKERBindingSource.DataMember = "TMP_TICKETOPEREPWORKER"
        Me.TMP_TICKETOPEREPWORKERBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(688, 18)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 28)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "dsHeader"
        ReportDataSource1.Value = Me.REPORTHEADER_VBindingSource
        ReportDataSource2.Name = "dsLine"
        ReportDataSource2.Value = Me.TICKETOPEREPACTBindingSource
        ReportDataSource3.Name = "dsHeaderLog"
        ReportDataSource3.Value = Me.TICKETOPEREPBindingSource
        ReportDataSource4.Name = "dsWorker"
        ReportDataSource4.Value = Me.TMP_TICKETOPEREPWORKERBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SESTicket.rptTicketJobLogLetterPortrait.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(16, 75)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1555, 780)
        Me.ReportViewer1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(33, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Job Log:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxJobLog)
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(808, 57)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'cbxJobLog
        '
        Me.cbxJobLog.DataSource = Me.TICKETOPEREPBindingSource
        Me.cbxJobLog.DisplayMember = "DESCRIPNEW"
        Me.cbxJobLog.FormattingEnabled = True
        Me.cbxJobLog.Location = New System.Drawing.Point(105, 21)
        Me.cbxJobLog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxJobLog.Name = "cbxJobLog"
        Me.cbxJobLog.Size = New System.Drawing.Size(560, 24)
        Me.cbxJobLog.TabIndex = 1
        Me.cbxJobLog.ValueMember = "TICKETOPEREPID"
        '
        'REPORTHEADER_VTableAdapter
        '
        Me.REPORTHEADER_VTableAdapter.ClearBeforeFill = True
        '
        'TICKETOPEREPACTTableAdapter
        '
        Me.TICKETOPEREPACTTableAdapter.ClearBeforeFill = True
        '
        'TICKETOPEREPTableAdapter
        '
        Me.TICKETOPEREPTableAdapter.ClearBeforeFill = True
        '
        'TMP_TICKETOPEREPWORKERTableAdapter
        '
        Me.TMP_TICKETOPEREPWORKERTableAdapter.ClearBeforeFill = True
        '
        'frmRPTTicketJobLogLetterPortrait
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1588, 860)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmRPTTicketJobLogLetterPortrait"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report - Ticket Job Log"
        CType(Me.REPORTHEADER_VBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETOPEREPACTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETOPEREPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TMP_TICKETOPEREPWORKERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxJobLog As System.Windows.Forms.ComboBox
    Friend WithEvents REPORTHEADER_VBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SESTicketAccessDataSet As SESTicket.SESTicketAccessDataSet
    Friend WithEvents TICKETOPEREPACTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TICKETOPEREPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REPORTHEADER_VTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.REPORTHEADER_VTableAdapter
    Friend WithEvents TICKETOPEREPACTTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.TICKETOPEREPACTTableAdapter
    Friend WithEvents TICKETOPEREPTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.TICKETOPEREPTableAdapter
    Friend WithEvents TMP_TICKETOPEREPWORKERBindingSource As BindingSource
    Friend WithEvents TMP_TICKETOPEREPWORKERTableAdapter As SESTicketAccessDataSetTableAdapters.TMP_TICKETOPEREPWORKERTableAdapter
End Class
