<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTModel03LetterLandscapePageBreak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRPTModel03LetterLandscapePageBreak))
        Me.REPORTHEADER_VBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.REPORTLINE_VBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REPORTPARAMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.REPORTHEADER_VTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.REPORTHEADER_VTableAdapter()
        Me.REPORTLINE_VTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.REPORTLINE_VTableAdapter()
        Me.REPORTPARAMTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.REPORTPARAMTableAdapter()
        CType(Me.REPORTHEADER_VBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPORTLINE_VBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPORTPARAMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'REPORTLINE_VBindingSource
        '
        Me.REPORTLINE_VBindingSource.DataMember = "REPORTLINE_V"
        Me.REPORTLINE_VBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'REPORTPARAMBindingSource
        '
        Me.REPORTPARAMBindingSource.DataMember = "REPORTPARAM"
        Me.REPORTPARAMBindingSource.DataSource = Me.SESTicketAccessDataSet
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
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SESTicket.rptTicketModel03LetterLandscapePageBreak.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(8, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1545, 792)
        Me.ReportViewer1.TabIndex = 0
        '
        'REPORTHEADER_VTableAdapter
        '
        Me.REPORTHEADER_VTableAdapter.ClearBeforeFill = True
        '
        'REPORTLINE_VTableAdapter
        '
        Me.REPORTLINE_VTableAdapter.ClearBeforeFill = True
        '
        'REPORTPARAMTableAdapter
        '
        Me.REPORTPARAMTableAdapter.ClearBeforeFill = True
        '
        'frmRPTModel03LetterLandscapePageBreak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1561, 795)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmRPTModel03LetterLandscapePageBreak"
        Me.Text = "frmRPTModel03LetterLandscapePageBreak"
        CType(Me.REPORTHEADER_VBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
