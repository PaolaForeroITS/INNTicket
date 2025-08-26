<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRPTTicketWorker
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
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
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.sp_TicketWorkerRptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sp_TicketWorkerRptTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.sp_TicketWorkerRptTableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.sp_TicketWorkerTotalRptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sp_TicketWorkerTotalRptTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.sp_TicketWorkerTotalRptTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sp_TicketWorkerRptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.sp_TicketWorkerTotalRptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(895, 67)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter"
        '
        'chkCanceled
        '
        Me.chkCanceled.AutoSize = True
        Me.chkCanceled.Checked = True
        Me.chkCanceled.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCanceled.Location = New System.Drawing.Point(694, 20)
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
        Me.chkClosed.Location = New System.Drawing.Point(630, 20)
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
        Me.chkOpen.Location = New System.Drawing.Point(572, 20)
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
        Me.btnOk.Location = New System.Drawing.Point(786, 22)
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
        Me.Label5.Location = New System.Drawing.Point(490, 20)
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
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sp_TicketWorkerRptBindingSource
        '
        Me.sp_TicketWorkerRptBindingSource.DataMember = "sp_TicketWorkerRpt"
        Me.sp_TicketWorkerRptBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'sp_TicketWorkerRptTableAdapter
        '
        Me.sp_TicketWorkerRptTableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 83)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1174, 566)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1166, 540)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ticket Worker"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1166, 540)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ticket Worker - Sum"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "dsL01"
        ReportDataSource3.Value = Me.sp_TicketWorkerRptBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SESTicket.rptTicketWorker.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1150, 532)
        Me.ReportViewer1.TabIndex = 6
        '
        'ReportViewer2
        '
        ReportDataSource4.Name = "dsL01"
        ReportDataSource4.Value = Me.sp_TicketWorkerTotalRptBindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "SESTicket.rptTicketWorkerTotal.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1150, 532)
        Me.ReportViewer2.TabIndex = 7
        '
        'sp_TicketWorkerTotalRptBindingSource
        '
        Me.sp_TicketWorkerTotalRptBindingSource.DataMember = "sp_TicketWorkerTotalRpt"
        Me.sp_TicketWorkerTotalRptBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'sp_TicketWorkerTotalRptTableAdapter
        '
        Me.sp_TicketWorkerTotalRptTableAdapter.ClearBeforeFill = True
        '
        'frmRPTTicketWorker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 652)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmRPTTicketWorker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report - Ticket Worker"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sp_TicketWorkerRptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.sp_TicketWorkerTotalRptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCanceled As System.Windows.Forms.CheckBox
    Friend WithEvents chkClosed As System.Windows.Forms.CheckBox
    Friend WithEvents chkOpen As System.Windows.Forms.CheckBox
    Friend WithEvents txtCreatedBy As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents txtTicketID As System.Windows.Forms.TextBox
    Friend WithEvents dtpServiceDateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpServiceDateBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sp_TicketWorkerRptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents sp_TicketWorkerRptTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.sp_TicketWorkerRptTableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents sp_TicketWorkerTotalRptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents sp_TicketWorkerTotalRptTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.sp_TicketWorkerTotalRptTableAdapter
End Class
