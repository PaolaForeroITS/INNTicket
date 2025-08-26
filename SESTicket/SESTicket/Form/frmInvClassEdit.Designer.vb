<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvClassEdit
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxType = New System.Windows.Forms.ComboBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInvClassID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtInvSubAccount = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtInvAccount = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtSalesAccountUBRAIU = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtSalesAccountUBR = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSalesAccountAIU = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtSalesSubAccount = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSalesAccount = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtGoodsSubAccount = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtGoodAccount = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxType)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtInvClassID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 118)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Information"
        '
        'cbxType
        '
        Me.cbxType.FormattingEnabled = True
        Me.cbxType.Items.AddRange(New Object() {"Material", "Service"})
        Me.cbxType.Location = New System.Drawing.Point(443, 25)
        Me.cbxType.Name = "cbxType"
        Me.cbxType.Size = New System.Drawing.Size(126, 21)
        Me.cbxType.TabIndex = 4
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(112, 52)
        Me.txtDescription.MaxLength = 120
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(457, 55)
        Me.txtDescription.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(403, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(43, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Description:"
        '
        'txtInvClassID
        '
        Me.txtInvClassID.Location = New System.Drawing.Point(112, 26)
        Me.txtInvClassID.MaxLength = 10
        Me.txtInvClassID.Name = "txtInvClassID"
        Me.txtInvClassID.Size = New System.Drawing.Size(126, 20)
        Me.txtInvClassID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(15, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inventory Class ID:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtInvSubAccount)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.txtInvAccount)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txtSalesAccountUBRAIU)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txtSalesAccountUBR)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtSalesAccountAIU)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtSalesSubAccount)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.txtSalesAccount)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtGoodsSubAccount)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txtGoodAccount)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 136)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(575, 156)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Account"
        '
        'txtInvSubAccount
        '
        Me.txtInvSubAccount.Location = New System.Drawing.Point(431, 45)
        Me.txtInvSubAccount.MaxLength = 50
        Me.txtInvSubAccount.Name = "txtInvSubAccount"
        Me.txtInvSubAccount.Size = New System.Drawing.Size(126, 20)
        Me.txtInvSubAccount.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(315, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(115, 13)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "Inventory Subaccount:"
        '
        'txtInvAccount
        '
        Me.txtInvAccount.Location = New System.Drawing.Point(112, 45)
        Me.txtInvAccount.MaxLength = 50
        Me.txtInvAccount.Name = "txtInvAccount"
        Me.txtInvAccount.Size = New System.Drawing.Size(196, 20)
        Me.txtInvAccount.TabIndex = 16
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(12, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(97, 13)
        Me.Label22.TabIndex = 17
        Me.Label22.Text = "Inventory Account:"
        '
        'txtSalesAccountUBRAIU
        '
        Me.txtSalesAccountUBRAIU.Location = New System.Drawing.Point(431, 123)
        Me.txtSalesAccountUBRAIU.MaxLength = 50
        Me.txtSalesAccountUBRAIU.Name = "txtSalesAccountUBRAIU"
        Me.txtSalesAccountUBRAIU.Size = New System.Drawing.Size(126, 20)
        Me.txtSalesAccountUBRAIU.TabIndex = 22
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(301, 126)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(126, 13)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Sales Account UBR AIU:"
        '
        'txtSalesAccountUBR
        '
        Me.txtSalesAccountUBR.Location = New System.Drawing.Point(431, 97)
        Me.txtSalesAccountUBR.MaxLength = 50
        Me.txtSalesAccountUBR.Name = "txtSalesAccountUBR"
        Me.txtSalesAccountUBR.Size = New System.Drawing.Size(126, 20)
        Me.txtSalesAccountUBR.TabIndex = 21
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(322, 100)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 13)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Sales Account UBR:"
        '
        'txtSalesAccountAIU
        '
        Me.txtSalesAccountAIU.Location = New System.Drawing.Point(112, 97)
        Me.txtSalesAccountAIU.MaxLength = 50
        Me.txtSalesAccountAIU.Name = "txtSalesAccountAIU"
        Me.txtSalesAccountAIU.Size = New System.Drawing.Size(196, 20)
        Me.txtSalesAccountAIU.TabIndex = 20
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(9, 100)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 13)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "Sales Account AIU:"
        '
        'txtSalesSubAccount
        '
        Me.txtSalesSubAccount.Location = New System.Drawing.Point(431, 71)
        Me.txtSalesSubAccount.MaxLength = 50
        Me.txtSalesSubAccount.Name = "txtSalesSubAccount"
        Me.txtSalesSubAccount.Size = New System.Drawing.Size(126, 20)
        Me.txtSalesSubAccount.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(332, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 13)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Sales SubAccount:"
        '
        'txtSalesAccount
        '
        Me.txtSalesAccount.Location = New System.Drawing.Point(112, 71)
        Me.txtSalesAccount.MaxLength = 50
        Me.txtSalesAccount.Name = "txtSalesAccount"
        Me.txtSalesAccount.Size = New System.Drawing.Size(196, 20)
        Me.txtSalesAccount.TabIndex = 18
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(28, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Sales Account:"
        '
        'txtGoodsSubAccount
        '
        Me.txtGoodsSubAccount.Location = New System.Drawing.Point(431, 19)
        Me.txtGoodsSubAccount.MaxLength = 50
        Me.txtGoodsSubAccount.Name = "txtGoodsSubAccount"
        Me.txtGoodsSubAccount.Size = New System.Drawing.Size(126, 20)
        Me.txtGoodsSubAccount.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(327, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Goods SubAccount:"
        '
        'txtGoodAccount
        '
        Me.txtGoodAccount.Location = New System.Drawing.Point(112, 19)
        Me.txtGoodAccount.MaxLength = 50
        Me.txtGoodAccount.Name = "txtGoodAccount"
        Me.txtGoodAccount.Size = New System.Drawing.Size(196, 20)
        Me.txtGoodAccount.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(25, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Goods Account:"
        '
        'btnExit
        '
        Me.btnExit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnExit.Location = New System.Drawing.Point(316, 298)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(99, 24)
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(211, 298)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 24)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmInvClassEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(594, 334)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvClassEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Inventory Class"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxType As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInvClassID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtInvSubAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtInvAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtSalesAccountUBRAIU As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtSalesAccountUBR As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtSalesAccountAIU As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtSalesSubAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtSalesAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtGoodsSubAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtGoodAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
