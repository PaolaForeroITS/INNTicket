<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTTicketAnalytical
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
        Me.sp_TicketHeaderRptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkCanceled = New System.Windows.Forms.CheckBox()
        Me.chkClosed = New System.Windows.Forms.CheckBox()
        Me.chkOpen = New System.Windows.Forms.CheckBox()
        Me.txtCreatedBy = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtTicketID = New System.Windows.Forms.TextBox()
        Me.dtpServiceDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpServiceDateBegin = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.sp_TicketHeaderRptTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.sp_TicketHeaderRptTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.sp_TicketHeaderByInvoiceRptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sp_TicketHeaderByInvoiceRptTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.sp_TicketHeaderByInvoiceRptTableAdapter()
        Me.chkOpenByInvoice = New System.Windows.Forms.CheckBox()
        CType(Me.sp_TicketHeaderRptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.sp_TicketHeaderByInvoiceRptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sp_TicketHeaderRptBindingSource
        '
        Me.sp_TicketHeaderRptBindingSource.DataMember = "sp_TicketHeaderRpt"
        Me.sp_TicketHeaderRptBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkOpenByInvoice)
        Me.GroupBox1.Controls.Add(Me.chkCanceled)
        Me.GroupBox1.Controls.Add(Me.chkClosed)
        Me.GroupBox1.Controls.Add(Me.chkOpen)
        Me.GroupBox1.Controls.Add(Me.txtCreatedBy)
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.txtTicketID)
        Me.GroupBox1.Controls.Add(Me.dtpServiceDateEnd)
        Me.GroupBox1.Controls.Add(Me.dtpServiceDateBegin)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1076, 67)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'chkCanceled
        '
        Me.chkCanceled.AutoSize = True
        Me.chkCanceled.Checked = True
        Me.chkCanceled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCanceled.Location = New System.Drawing.Point(808, 21)
        Me.chkCanceled.Name = "chkCanceled"
        Me.chkCanceled.Size = New System.Drawing.Size(71, 17)
        Me.chkCanceled.TabIndex = 47
        Me.chkCanceled.Text = "Canceled"
        Me.chkCanceled.UseVisualStyleBackColor = True
        '
        'chkClosed
        '
        Me.chkClosed.AutoSize = True
        Me.chkClosed.Checked = True
        Me.chkClosed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkClosed.Location = New System.Drawing.Point(744, 21)
        Me.chkClosed.Name = "chkClosed"
        Me.chkClosed.Size = New System.Drawing.Size(58, 17)
        Me.chkClosed.TabIndex = 46
        Me.chkClosed.Text = "Closed"
        Me.chkClosed.UseVisualStyleBackColor = True
        '
        'chkOpen
        '
        Me.chkOpen.AutoSize = True
        Me.chkOpen.Checked = True
        Me.chkOpen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOpen.Location = New System.Drawing.Point(686, 21)
        Me.chkOpen.Name = "chkOpen"
        Me.chkOpen.Size = New System.Drawing.Size(52, 17)
        Me.chkOpen.TabIndex = 45
        Me.chkOpen.Text = "Open"
        Me.chkOpen.UseVisualStyleBackColor = True
        '
        'txtCreatedBy
        '
        Me.txtCreatedBy.Location = New System.Drawing.Point(348, 40)
        Me.txtCreatedBy.Name = "txtCreatedBy"
        Me.txtCreatedBy.Size = New System.Drawing.Size(100, 20)
        Me.txtCreatedBy.TabIndex = 44
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(982, 22)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 43
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtTicketID
        '
        Me.txtTicketID.Location = New System.Drawing.Point(348, 19)
        Me.txtTicketID.Name = "txtTicketID"
        Me.txtTicketID.Size = New System.Drawing.Size(100, 20)
        Me.txtTicketID.TabIndex = 41
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
        Me.Label5.Location = New System.Drawing.Point(604, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ticket Status:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(280, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ticket ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Created By:"
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
        ReportDataSource1.Name = "dsHeader"
        ReportDataSource1.Value = Me.sp_TicketHeaderRptBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SESTicket.rptTicketAnalytical.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 85)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1166, 561)
        Me.ReportViewer1.TabIndex = 1
        '
        'sp_TicketHeaderRptTableAdapter
        '
        Me.sp_TicketHeaderRptTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        ReportDataSource2.Name = "dsHeader"
        ReportDataSource2.Value = Me.sp_TicketHeaderByInvoiceRptBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "SESTicket.rptTicketAnalyticalByInvoice.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(12, 85)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1166, 561)
        Me.ReportViewer2.TabIndex = 2
        '
        'sp_TicketHeaderByInvoiceRptBindingSource
        '
        Me.sp_TicketHeaderByInvoiceRptBindingSource.DataMember = "sp_TicketHeaderByInvoiceRpt"
        Me.sp_TicketHeaderByInvoiceRptBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'sp_TicketHeaderByInvoiceRptTableAdapter
        '
        Me.sp_TicketHeaderByInvoiceRptTableAdapter.ClearBeforeFill = True
        '
        'chkOpenByInvoice
        '
        Me.chkOpenByInvoice.AutoSize = True
        Me.chkOpenByInvoice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkOpenByInvoice.Location = New System.Drawing.Point(476, 22)
        Me.chkOpenByInvoice.Name = "chkOpenByInvoice"
        Me.chkOpenByInvoice.Size = New System.Drawing.Size(104, 17)
        Me.chkOpenByInvoice.TabIndex = 48
        Me.chkOpenByInvoice.Text = "Open by Invoice"
        Me.chkOpenByInvoice.UseVisualStyleBackColor = True
        '
        'frmRPTTicketAnalytical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 652)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmRPTTicketAnalytical"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report - Ticket Analytical"
        CType(Me.sp_TicketHeaderRptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.sp_TicketHeaderByInvoiceRptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents txtTicketID As System.Windows.Forms.TextBox
    Friend WithEvents dtpServiceDateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpServiceDateBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sp_TicketHeaderRptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents sp_TicketHeaderRptTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.sp_TicketHeaderRptTableAdapter
    Friend WithEvents txtCreatedBy As System.Windows.Forms.TextBox
    Friend WithEvents chkCanceled As System.Windows.Forms.CheckBox
    Friend WithEvents chkClosed As System.Windows.Forms.CheckBox
    Friend WithEvents chkOpen As System.Windows.Forms.CheckBox
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sp_TicketHeaderByInvoiceRptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents sp_TicketHeaderByInvoiceRptTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.sp_TicketHeaderByInvoiceRptTableAdapter
    Friend WithEvents chkOpenByInvoice As System.Windows.Forms.CheckBox
End Class
