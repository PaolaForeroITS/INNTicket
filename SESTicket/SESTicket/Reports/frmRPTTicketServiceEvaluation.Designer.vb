<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTTicketServiceEvaluation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTTicketServiceEvaluation))
        Me.REPORTHEADER_VBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.TMP_RPT_TICKETSERVEVALSERVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.REPORTHEADER_VTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.REPORTHEADER_VTableAdapter()
        Me.TMP_RPT_TICKETSERVEVALSERVTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TMP_RPT_TICKETSERVEVALSERVTableAdapter()
        CType(Me.REPORTHEADER_VBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TMP_RPT_TICKETSERVEVALSERVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TMP_RPT_TICKETSERVEVALSERVBindingSource
        '
        Me.TMP_RPT_TICKETSERVEVALSERVBindingSource.DataMember = "TMP_RPT_TICKETSERVEVALSERV"
        Me.TMP_RPT_TICKETSERVEVALSERVBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "dsHeader"
        ReportDataSource1.Value = Me.REPORTHEADER_VBindingSource
        ReportDataSource2.Name = "dsComplem"
        ReportDataSource2.Value = Me.TMP_RPT_TICKETSERVEVALSERVBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SESTicket.rptTicketServiceEvaluationLetterPortrait.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 1)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1531, 736)
        Me.ReportViewer1.TabIndex = 3
        '
        'REPORTHEADER_VTableAdapter
        '
        Me.REPORTHEADER_VTableAdapter.ClearBeforeFill = True
        '
        'TMP_RPT_TICKETSERVEVALSERVTableAdapter
        '
        Me.TMP_RPT_TICKETSERVEVALSERVTableAdapter.ClearBeforeFill = True
        '
        'frmRPTTicketServiceEvaluation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1535, 738)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRPTTicketServiceEvaluation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report - Ticket Service Evaluation"
        CType(Me.REPORTHEADER_VBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TMP_RPT_TICKETSERVEVALSERVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents REPORTHEADER_VBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SESTicketAccessDataSet As SESTicket.SESTicketAccessDataSet
    Friend WithEvents TMP_RPT_TICKETSERVEVALSERVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REPORTHEADER_VTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.REPORTHEADER_VTableAdapter
    Friend WithEvents TMP_RPT_TICKETSERVEVALSERVTableAdapter As SESTicket.SESTicketAccessDataSetTableAdapters.TMP_RPT_TICKETSERVEVALSERVTableAdapter
End Class
