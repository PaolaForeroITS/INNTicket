<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataExpLayout
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optExpDataNo = New System.Windows.Forms.RadioButton()
        Me.optExpDataYes = New System.Windows.Forms.RadioButton()
        Me.grpExpInacLine = New System.Windows.Forms.GroupBox()
        Me.optExpInacLineNo = New System.Windows.Forms.RadioButton()
        Me.optExpInacLineYes = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabContrPrice = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxCustomer = New System.Windows.Forms.ComboBox()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.cbxContract = New System.Windows.Forms.ComboBox()
        Me.CONTRACTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.CONTRACTTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.CONTRACTTableAdapter()
        Me.CUSTOMERTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.CUSTOMERTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.grpExpInacLine.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabContrPrice.SuspendLayout()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRACTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optExpDataNo)
        Me.GroupBox1.Controls.Add(Me.optExpDataYes)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 39)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Export Data"
        '
        'optExpDataNo
        '
        Me.optExpDataNo.AutoSize = True
        Me.optExpDataNo.Location = New System.Drawing.Point(87, 16)
        Me.optExpDataNo.Name = "optExpDataNo"
        Me.optExpDataNo.Size = New System.Drawing.Size(39, 17)
        Me.optExpDataNo.TabIndex = 1
        Me.optExpDataNo.Text = "No"
        Me.optExpDataNo.UseVisualStyleBackColor = True
        '
        'optExpDataYes
        '
        Me.optExpDataYes.AutoSize = True
        Me.optExpDataYes.Checked = True
        Me.optExpDataYes.Location = New System.Drawing.Point(27, 16)
        Me.optExpDataYes.Name = "optExpDataYes"
        Me.optExpDataYes.Size = New System.Drawing.Size(43, 17)
        Me.optExpDataYes.TabIndex = 0
        Me.optExpDataYes.TabStop = True
        Me.optExpDataYes.Text = "Yes"
        Me.optExpDataYes.UseVisualStyleBackColor = True
        '
        'grpExpInacLine
        '
        Me.grpExpInacLine.Controls.Add(Me.optExpInacLineNo)
        Me.grpExpInacLine.Controls.Add(Me.optExpInacLineYes)
        Me.grpExpInacLine.Location = New System.Drawing.Point(156, 12)
        Me.grpExpInacLine.Name = "grpExpInacLine"
        Me.grpExpInacLine.Size = New System.Drawing.Size(135, 39)
        Me.grpExpInacLine.TabIndex = 2
        Me.grpExpInacLine.TabStop = False
        Me.grpExpInacLine.Text = "Export Inactive Lines"
        '
        'optExpInacLineNo
        '
        Me.optExpInacLineNo.AutoSize = True
        Me.optExpInacLineNo.Checked = True
        Me.optExpInacLineNo.Location = New System.Drawing.Point(81, 16)
        Me.optExpInacLineNo.Name = "optExpInacLineNo"
        Me.optExpInacLineNo.Size = New System.Drawing.Size(39, 17)
        Me.optExpInacLineNo.TabIndex = 3
        Me.optExpInacLineNo.TabStop = True
        Me.optExpInacLineNo.Text = "No"
        Me.optExpInacLineNo.UseVisualStyleBackColor = True
        '
        'optExpInacLineYes
        '
        Me.optExpInacLineYes.AutoSize = True
        Me.optExpInacLineYes.Location = New System.Drawing.Point(20, 16)
        Me.optExpInacLineYes.Name = "optExpInacLineYes"
        Me.optExpInacLineYes.Size = New System.Drawing.Size(43, 17)
        Me.optExpInacLineYes.TabIndex = 2
        Me.optExpInacLineYes.Text = "Yes"
        Me.optExpInacLineYes.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabContrPrice)
        Me.TabControl1.Location = New System.Drawing.Point(12, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(366, 104)
        Me.TabControl1.TabIndex = 3
        '
        'tabContrPrice
        '
        Me.tabContrPrice.BackColor = System.Drawing.SystemColors.Control
        Me.tabContrPrice.Controls.Add(Me.Label2)
        Me.tabContrPrice.Controls.Add(Me.Label1)
        Me.tabContrPrice.Controls.Add(Me.cbxCustomer)
        Me.tabContrPrice.Controls.Add(Me.cbxContract)
        Me.tabContrPrice.Location = New System.Drawing.Point(4, 22)
        Me.tabContrPrice.Name = "tabContrPrice"
        Me.tabContrPrice.Padding = New System.Windows.Forms.Padding(3)
        Me.tabContrPrice.Size = New System.Drawing.Size(358, 78)
        Me.tabContrPrice.TabIndex = 0
        Me.tabContrPrice.Text = "CONTRACT PRICE LIST"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contract:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Customer:"
        '
        'cbxCustomer
        '
        Me.cbxCustomer.DataSource = Me.CUSTOMERBindingSource
        Me.cbxCustomer.DisplayMember = "NAME"
        Me.cbxCustomer.FormattingEnabled = True
        Me.cbxCustomer.Location = New System.Drawing.Point(69, 12)
        Me.cbxCustomer.Name = "cbxCustomer"
        Me.cbxCustomer.Size = New System.Drawing.Size(283, 21)
        Me.cbxCustomer.TabIndex = 1
        Me.cbxCustomer.ValueMember = "CUSTOMERID"
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbxContract
        '
        Me.cbxContract.DataSource = Me.CONTRACTBindingSource
        Me.cbxContract.DisplayMember = "CONTRACTNUMBER"
        Me.cbxContract.FormattingEnabled = True
        Me.cbxContract.Location = New System.Drawing.Point(69, 39)
        Me.cbxContract.Name = "cbxContract"
        Me.cbxContract.Size = New System.Drawing.Size(283, 21)
        Me.cbxContract.TabIndex = 0
        Me.cbxContract.ValueMember = "CONTRACTID"
        '
        'CONTRACTBindingSource
        '
        Me.CONTRACTBindingSource.DataMember = "CONTRACT"
        Me.CONTRACTBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(297, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 35)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Export Layout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "xlsx"
        Me.SaveFileDialog1.Filter = "*.xlsx|"
        '
        'CONTRACTTableAdapter
        '
        Me.CONTRACTTableAdapter.ClearBeforeFill = True
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'frmDataExpLayout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(385, 167)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.grpExpInacLine)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDataExpLayout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTicket - Export Data Layout Tool"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpExpInacLine.ResumeLayout(False)
        Me.grpExpInacLine.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabContrPrice.ResumeLayout(False)
        Me.tabContrPrice.PerformLayout()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRACTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optExpDataNo As System.Windows.Forms.RadioButton
    Friend WithEvents optExpDataYes As System.Windows.Forms.RadioButton
    Friend WithEvents grpExpInacLine As System.Windows.Forms.GroupBox
    Friend WithEvents optExpInacLineNo As System.Windows.Forms.RadioButton
    Friend WithEvents optExpInacLineYes As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabContrPrice As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cbxContract As System.Windows.Forms.ComboBox
    Friend WithEvents CONTRACTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents CONTRACTTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.CONTRACTTableAdapter
    Friend WithEvents cbxCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents CUSTOMERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUSTOMERTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.CUSTOMERTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
