<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTModel04LetterLandscape
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.REPORTHEADER_VBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REPORTHEADER_VTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.REPORTHEADER_VTableAdapter()
        Me.REPORTLINE_VBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REPORTLINE_VTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.REPORTLINE_VTableAdapter()
        Me.REPORTPARAMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REPORTPARAMTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.REPORTPARAMTableAdapter()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPORTHEADER_VBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPORTLINE_VBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPORTPARAMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "dsHeader"
        ReportDataSource1.Value = Me.REPORTHEADER_VBindingSource
        ReportDataSource2.Name = "dsLine"
        ReportDataSource2.Value = Me.REPORTLINE_VBindingSource
        ReportDataSource3.Name = "dsReportParam"
        ReportDataSource3.Value = Me.REPORTPARAMBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SESTicket.rptTicketModel04LetterLandscape.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(6, 1)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1159, 644)
        Me.ReportViewer1.TabIndex = 1
        '
        'SESTicketAccessDataSet
        '
        Me.SESTicketAccessDataSet.DataSetName = "SESTicketAccessDataSet"
        Me.SESTicketAccessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.ExcludeSchema
        '
        'REPORTHEADER_VBindingSource
        '
        Me.REPORTHEADER_VBindingSource.DataMember = "REPORTHEADER_V"
        Me.REPORTHEADER_VBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'REPORTHEADER_VTableAdapter
        '
        Me.REPORTHEADER_VTableAdapter.ClearBeforeFill = True
        '
        'REPORTLINE_VBindingSource
        '
        Me.REPORTLINE_VBindingSource.DataMember = "REPORTLINE_V"
        Me.REPORTLINE_VBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'REPORTLINE_VTableAdapter
        '
        Me.REPORTLINE_VTableAdapter.ClearBeforeFill = True
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
        'frmRPTModel04LetterLandscape
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1171, 646)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRPTModel04LetterLandscape"
        Me.Text = "frmRPTModel04LetterLandscape"
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPORTHEADER_VBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPORTLINE_VBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPORTPARAMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents REPORTHEADER_VBindingSource As BindingSource
    Friend WithEvents SESTicketAccessDataSet As SESTicketAccessDataSet
    Friend WithEvents REPORTLINE_VBindingSource As BindingSource
    Friend WithEvents REPORTPARAMBindingSource As BindingSource
    Friend WithEvents REPORTHEADER_VTableAdapter As SESTicketAccessDataSetTableAdapters.REPORTHEADER_VTableAdapter
    Friend WithEvents REPORTLINE_VTableAdapter As SESTicketAccessDataSetTableAdapters.REPORTLINE_VTableAdapter
    Friend WithEvents REPORTPARAMTableAdapter As SESTicketAccessDataSetTableAdapters.REPORTPARAMTableAdapter
End Class
