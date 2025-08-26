<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerEdit
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxState = New System.Windows.Forms.ComboBox()
        Me.STATEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbxCity = New System.Windows.Forms.ComboBox()
        Me.CITYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbxCountry = New System.Windows.Forms.ComboBox()
        Me.COUNTRYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtAddress1 = New System.Windows.Forms.TextBox()
        Me.txtAddress2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.COUNTRYTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.COUNTRYTableAdapter()
        Me.STATETableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.STATETableAdapter()
        Me.CITYTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.CITYTableAdapter()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtARSubAccount = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtARAccount = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSalesSubAccount = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSalesAccount = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.STATEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CITYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COUNTRYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(232, 478)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(101, 24)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(124, 478)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(102, 24)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCustomerID)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 76)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Base Information"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(75, 24)
        Me.txtCustomerID.MaxLength = 15
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(119, 20)
        Me.txtCustomerID.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(75, 46)
        Me.txtName.MaxLength = 100
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(367, 20)
        Me.txtName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(33, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
        '
        'cbxState
        '
        Me.cbxState.DataSource = Me.STATEBindingSource
        Me.cbxState.DisplayMember = "NAME"
        Me.cbxState.FormattingEnabled = True
        Me.cbxState.Location = New System.Drawing.Point(75, 94)
        Me.cbxState.Name = "cbxState"
        Me.cbxState.Size = New System.Drawing.Size(149, 21)
        Me.cbxState.TabIndex = 6
        Me.cbxState.ValueMember = "STATEID"
        '
        'STATEBindingSource
        '
        Me.STATEBindingSource.DataMember = "STATE"
        Me.STATEBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(31, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "State:"
        '
        'cbxCity
        '
        Me.cbxCity.DataSource = Me.CITYBindingSource
        Me.cbxCity.DisplayMember = "NAME"
        Me.cbxCity.FormattingEnabled = True
        Me.cbxCity.Location = New System.Drawing.Point(75, 121)
        Me.cbxCity.Name = "cbxCity"
        Me.cbxCity.Size = New System.Drawing.Size(149, 21)
        Me.cbxCity.TabIndex = 7
        Me.cbxCity.ValueMember = "CITYID"
        '
        'CITYBindingSource
        '
        Me.CITYBindingSource.DataMember = "CITY"
        Me.CITYBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'cbxCountry
        '
        Me.cbxCountry.DataSource = Me.COUNTRYBindingSource
        Me.cbxCountry.DisplayMember = "NAME"
        Me.cbxCountry.FormattingEnabled = True
        Me.cbxCountry.Location = New System.Drawing.Point(75, 67)
        Me.cbxCountry.Name = "cbxCountry"
        Me.cbxCountry.Size = New System.Drawing.Size(149, 21)
        Me.cbxCountry.TabIndex = 5
        Me.cbxCountry.ValueMember = "COUNTRYID"
        '
        'COUNTRYBindingSource
        '
        Me.COUNTRYBindingSource.DataMember = "COUNTRY"
        Me.COUNTRYBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(75, 15)
        Me.txtAddress1.MaxLength = 120
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(367, 20)
        Me.txtAddress1.TabIndex = 3
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(75, 41)
        Me.txtAddress2.MaxLength = 120
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(367, 20)
        Me.txtAddress2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(17, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Address 1:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Address 2:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(23, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Country:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "City:"
        '
        'COUNTRYTableAdapter
        '
        Me.COUNTRYTableAdapter.ClearBeforeFill = True
        '
        'STATETableAdapter
        '
        Me.STATETableAdapter.ClearBeforeFill = True
        '
        'CITYTableAdapter
        '
        Me.CITYTableAdapter.ClearBeforeFill = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPhone)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.txtFax)
        Me.GroupBox2.Controls.Add(Me.txtObs)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 250)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(465, 136)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contact Information"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(77, 19)
        Me.txtPhone.MaxLength = 50
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(148, 20)
        Me.txtPhone.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(77, 44)
        Me.txtEmail.MaxLength = 150
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(366, 20)
        Me.txtEmail.TabIndex = 10
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(316, 19)
        Me.txtFax.MaxLength = 20
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(127, 20)
        Me.txtFax.TabIndex = 9
        Me.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(76, 70)
        Me.txtObs.MaxLength = 500
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(367, 51)
        Me.txtObs.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Phone:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(283, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Fax:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Obs:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbxState)
        Me.GroupBox3.Controls.Add(Me.txtAddress1)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cbxCity)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cbxCountry)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtAddress2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 85)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(464, 159)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Address"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtARSubAccount)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtARAccount)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtSalesSubAccount)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.txtSalesAccount)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 392)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(465, 80)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Account"
        '
        'txtARSubAccount
        '
        Me.txtARSubAccount.Location = New System.Drawing.Point(326, 46)
        Me.txtARSubAccount.MaxLength = 30
        Me.txtARSubAccount.Name = "txtARSubAccount"
        Me.txtARSubAccount.Size = New System.Drawing.Size(126, 20)
        Me.txtARSubAccount.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(233, 49)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 13)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "AR SubAccount:"
        '
        'txtARAccount
        '
        Me.txtARAccount.Location = New System.Drawing.Point(85, 46)
        Me.txtARAccount.MaxLength = 30
        Me.txtARAccount.Name = "txtARAccount"
        Me.txtARAccount.Size = New System.Drawing.Size(126, 20)
        Me.txtARAccount.TabIndex = 14
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(16, 49)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "AR Account:"
        '
        'txtSalesSubAccount
        '
        Me.txtSalesSubAccount.Location = New System.Drawing.Point(326, 23)
        Me.txtSalesSubAccount.MaxLength = 30
        Me.txtSalesSubAccount.Name = "txtSalesSubAccount"
        Me.txtSalesSubAccount.Size = New System.Drawing.Size(126, 20)
        Me.txtSalesSubAccount.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(222, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 16)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Sales SubAccount:"
        '
        'txtSalesAccount
        '
        Me.txtSalesAccount.Location = New System.Drawing.Point(85, 22)
        Me.txtSalesAccount.MaxLength = 30
        Me.txtSalesAccount.Name = "txtSalesAccount"
        Me.txtSalesAccount.Size = New System.Drawing.Size(126, 20)
        Me.txtSalesAccount.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(5, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Sales Account:"
        '
        'frmCustomerEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(490, 512)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmCustomerEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Customer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.STATEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CITYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COUNTRYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbxState As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbxCity As System.Windows.Forms.ComboBox
    Friend WithEvents cbxCountry As System.Windows.Forms.ComboBox
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents COUNTRYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COUNTRYTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.COUNTRYTableAdapter
    Friend WithEvents STATEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CITYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STATETableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.STATETableAdapter
    Friend WithEvents CITYTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.CITYTableAdapter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtARSubAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtARAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtSalesSubAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSalesAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
