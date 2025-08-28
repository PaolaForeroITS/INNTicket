<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketInvConsumptionLetterLandscape
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketInvConsumptionLetterLandscape))
        Me.REPORTHEADER_VBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketAccessDataSet = New SESTicket.SESTicketAccessDataSet()
        Me.REPORTINVLINE_VBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.REPORTPARAMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TICKETINVADICBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.REPORTHEADER_VTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.REPORTHEADER_VTableAdapter()
        Me.REPORTINVLINE_VTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.REPORTINVLINE_VTableAdapter()
        Me.REPORTPARAMTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.REPORTPARAMTableAdapter()
        Me.TICKETINVADICTableAdapter = New SESTicket.SESTicketAccessDataSetTableAdapters.TICKETINVADICTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxRepParam = New System.Windows.Forms.ComboBox()
        Me.REPORTPARAMBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.REPORTHEADER_VBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPORTINVLINE_VBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPORTPARAMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETINVADICBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REPORTPARAMBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'REPORTINVLINE_VBindingSource
        '
        Me.REPORTINVLINE_VBindingSource.DataMember = "REPORTINVLINE_V"
        Me.REPORTINVLINE_VBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'REPORTPARAMBindingSource
        '
        Me.REPORTPARAMBindingSource.DataMember = "REPORTPARAM"
        Me.REPORTPARAMBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'TICKETINVADICBindingSource
        '
        Me.TICKETINVADICBindingSource.DataMember = "TICKETINVADIC"
        Me.TICKETINVADICBindingSource.DataSource = Me.SESTicketAccessDataSet
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "dsHeader"
        ReportDataSource1.Value = Me.REPORTHEADER_VBindingSource
        ReportDataSource2.Name = "dsLine"
        ReportDataSource2.Value = Me.REPORTINVLINE_VBindingSource
        ReportDataSource3.Name = "dsReportParam"
        ReportDataSource3.Value = Me.REPORTPARAMBindingSource
        ReportDataSource4.Name = "dsADIC"
        ReportDataSource4.Value = Me.TICKETINVADICBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SESTicket.rptTicketInvConsumptionLetterLandscape.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 60)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1601, 729)
        Me.ReportViewer1.TabIndex = 3
        '
        'REPORTHEADER_VTableAdapter
        '
        Me.REPORTHEADER_VTableAdapter.ClearBeforeFill = True
        '
        'REPORTINVLINE_VTableAdapter
        '
        Me.REPORTINVLINE_VTableAdapter.ClearBeforeFill = True
        '
        'REPORTPARAMTableAdapter
        '
        Me.REPORTPARAMTableAdapter.ClearBeforeFill = True
        '
        'TICKETINVADICTableAdapter
        '
        Me.TICKETINVADICTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Parameter:"
        '
        'cbxRepParam
        '
        Me.cbxRepParam.DataSource = Me.REPORTPARAMBindingSource1
        Me.cbxRepParam.DisplayMember = "DESCRIP"
        Me.cbxRepParam.FormattingEnabled = True
        Me.cbxRepParam.Location = New System.Drawing.Point(100, 15)
        Me.cbxRepParam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxRepParam.Name = "cbxRepParam"
        Me.cbxRepParam.Size = New System.Drawing.Size(284, 24)
        Me.cbxRepParam.TabIndex = 10
        Me.cbxRepParam.ValueMember = "REPORTPARAMID"
        '
        'REPORTPARAMBindingSource1
        '
        Me.REPORTPARAMBindingSource1.DataMember = "REPORTPARAM"
        Me.REPORTPARAMBindingSource1.DataSource = Me.SESTicketAccessDataSet
        '
        'frmTicketInvConsumptionLetterLandscape
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1605, 793)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxRepParam)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTicketInvConsumptionLetterLandscape"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INNTicket - Inventory Consumption - Ticket: "
        CType(Me.REPORTHEADER_VBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketAccessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPORTINVLINE_VBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPORTPARAMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETINVADICBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REPORTPARAMBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents REPORTHEADER_VBindingSource As BindingSource
    Friend WithEvents SESTicketAccessDataSet As SESTicketAccessDataSet
    Friend WithEvents REPORTINVLINE_VBindingSource As BindingSource
    Friend WithEvents REPORTPARAMBindingSource As BindingSource
    Friend WithEvents TICKETINVADICBindingSource As BindingSource
    Friend WithEvents REPORTHEADER_VTableAdapter As SESTicketAccessDataSetTableAdapters.REPORTHEADER_VTableAdapter
    Friend WithEvents REPORTINVLINE_VTableAdapter As SESTicketAccessDataSetTableAdapters.REPORTINVLINE_VTableAdapter
    Friend WithEvents REPORTPARAMTableAdapter As SESTicketAccessDataSetTableAdapters.REPORTPARAMTableAdapter
    Friend WithEvents TICKETINVADICTableAdapter As SESTicketAccessDataSetTableAdapters.TICKETINVADICTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxRepParam As ComboBox
    Friend WithEvents REPORTPARAMBindingSource1 As BindingSource
End Class
