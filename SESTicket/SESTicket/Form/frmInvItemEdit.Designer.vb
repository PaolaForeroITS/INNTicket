<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvItemEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvItemEdit))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxActive = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAbbrev = New System.Windows.Forms.TextBox()
        Me.cbxDefaultSite = New System.Windows.Forms.ComboBox()
        Me.SITESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxInventoryClass = New System.Windows.Forms.ComboBox()
        Me.INVENTORYCLASSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInvItemID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBrand = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtVendor = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMaxOnHand = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMinOnHand = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtListPrice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAvgCost = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLastCost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSalesUnit = New System.Windows.Forms.TextBox()
        Me.txtPurchaseUnit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbxStorageUnit = New System.Windows.Forms.ComboBox()
        Me.INVENTORYUNITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lable = New System.Windows.Forms.Label()
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
        Me.INVENTORYCLASSTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.INVENTORYCLASSTableAdapter()
        Me.SITESTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.SITESTableAdapter()
        Me.INVENTORYUNITTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.INVENTORYUNITTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtVendorId = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SITESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTORYCLASSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.INVENTORYUNITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxActive)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtAbbrev)
        Me.GroupBox1.Controls.Add(Me.cbxDefaultSite)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbxInventoryClass)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtInvItemID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'cbxActive
        '
        Me.cbxActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbxActive.FormattingEnabled = True
        Me.cbxActive.Items.AddRange(New Object() {resources.GetString("cbxActive.Items"), resources.GetString("cbxActive.Items1")})
        resources.ApplyResources(Me.cbxActive, "cbxActive")
        Me.cbxActive.Name = "cbxActive"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Name = "Label15"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'txtAbbrev
        '
        resources.ApplyResources(Me.txtAbbrev, "txtAbbrev")
        Me.txtAbbrev.Name = "txtAbbrev"
        '
        'cbxDefaultSite
        '
        Me.cbxDefaultSite.DataSource = Me.SITESBindingSource
        Me.cbxDefaultSite.DisplayMember = "NAME"
        Me.cbxDefaultSite.FormattingEnabled = True
        resources.ApplyResources(Me.cbxDefaultSite, "cbxDefaultSite")
        Me.cbxDefaultSite.Name = "cbxDefaultSite"
        Me.cbxDefaultSite.ValueMember = "SITEID"
        '
        'SITESBindingSource
        '
        Me.SITESBindingSource.DataMember = "SITES"
        Me.SITESBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'SESTicketSQLDataSet
        '
        Me.SESTicketSQLDataSet.DataSetName = "SESTicketSQLDataSet"
        Me.SESTicketSQLDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Name = "Label4"
        '
        'cbxInventoryClass
        '
        Me.cbxInventoryClass.DataSource = Me.INVENTORYCLASSBindingSource
        Me.cbxInventoryClass.DisplayMember = "DESCRIPTION"
        Me.cbxInventoryClass.FormattingEnabled = True
        resources.ApplyResources(Me.cbxInventoryClass, "cbxInventoryClass")
        Me.cbxInventoryClass.Name = "cbxInventoryClass"
        Me.cbxInventoryClass.ValueMember = "INVENTORYCLASSID"
        '
        'INVENTORYCLASSBindingSource
        '
        Me.INVENTORYCLASSBindingSource.DataMember = "INVENTORYCLASS"
        Me.INVENTORYCLASSBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'txtDescription
        '
        resources.ApplyResources(Me.txtDescription, "txtDescription")
        Me.txtDescription.Name = "txtDescription"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtInvItemID
        '
        resources.ApplyResources(Me.txtInvItemID, "txtInvItemID")
        Me.txtInvItemID.Name = "txtInvItemID"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Name = "Label1"
        '
        'txtBrand
        '
        resources.ApplyResources(Me.txtBrand, "txtBrand")
        Me.txtBrand.Name = "txtBrand"
        '
        'Label24
        '
        resources.ApplyResources(Me.Label24, "Label24")
        Me.Label24.Name = "Label24"
        '
        'txtVendor
        '
        resources.ApplyResources(Me.txtVendor, "txtVendor")
        Me.txtVendor.Name = "txtVendor"
        '
        'Label23
        '
        resources.ApplyResources(Me.Label23, "Label23")
        Me.Label23.Name = "Label23"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtMaxOnHand)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtMinOnHand)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtListPrice)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtAvgCost)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtLastCost)
        Me.GroupBox2.Controls.Add(Me.Label5)
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'txtMaxOnHand
        '
        resources.ApplyResources(Me.txtMaxOnHand, "txtMaxOnHand")
        Me.txtMaxOnHand.Name = "txtMaxOnHand"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        Me.Label12.Tag = ""
        '
        'txtMinOnHand
        '
        resources.ApplyResources(Me.txtMinOnHand, "txtMinOnHand")
        Me.txtMinOnHand.Name = "txtMinOnHand"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        Me.Label11.Tag = ""
        '
        'txtListPrice
        '
        resources.ApplyResources(Me.txtListPrice, "txtListPrice")
        Me.txtListPrice.Name = "txtListPrice"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        Me.Label8.Tag = ""
        '
        'txtAvgCost
        '
        resources.ApplyResources(Me.txtAvgCost, "txtAvgCost")
        Me.txtAvgCost.Name = "txtAvgCost"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        Me.Label6.Tag = ""
        '
        'txtLastCost
        '
        resources.ApplyResources(Me.txtLastCost, "txtLastCost")
        Me.txtLastCost.Name = "txtLastCost"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        Me.Label5.Tag = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSalesUnit)
        Me.GroupBox3.Controls.Add(Me.txtPurchaseUnit)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.cbxStorageUnit)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lable)
        resources.ApplyResources(Me.GroupBox3, "GroupBox3")
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.TabStop = False
        '
        'txtSalesUnit
        '
        resources.ApplyResources(Me.txtSalesUnit, "txtSalesUnit")
        Me.txtSalesUnit.Name = "txtSalesUnit"
        Me.txtSalesUnit.ReadOnly = True
        '
        'txtPurchaseUnit
        '
        resources.ApplyResources(Me.txtPurchaseUnit, "txtPurchaseUnit")
        Me.txtPurchaseUnit.Name = "txtPurchaseUnit"
        Me.txtPurchaseUnit.ReadOnly = True
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        Me.Label10.Tag = ""
        '
        'cbxStorageUnit
        '
        Me.cbxStorageUnit.DataSource = Me.INVENTORYUNITBindingSource
        Me.cbxStorageUnit.DisplayMember = "STORAGEUNIT"
        Me.cbxStorageUnit.FormattingEnabled = True
        resources.ApplyResources(Me.cbxStorageUnit, "cbxStorageUnit")
        Me.cbxStorageUnit.Name = "cbxStorageUnit"
        Me.cbxStorageUnit.ValueMember = "STORAGEUNIT"
        '
        'INVENTORYUNITBindingSource
        '
        Me.INVENTORYUNITBindingSource.DataMember = "INVENTORYUNIT"
        Me.INVENTORYUNITBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Name = "Label9"
        Me.Label9.Tag = ""
        '
        'lable
        '
        resources.ApplyResources(Me.lable, "lable")
        Me.lable.Name = "lable"
        Me.lable.Tag = ""
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
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        '
        'txtInvSubAccount
        '
        resources.ApplyResources(Me.txtInvSubAccount, "txtInvSubAccount")
        Me.txtInvSubAccount.Name = "txtInvSubAccount"
        '
        'Label21
        '
        resources.ApplyResources(Me.Label21, "Label21")
        Me.Label21.Name = "Label21"
        '
        'txtInvAccount
        '
        resources.ApplyResources(Me.txtInvAccount, "txtInvAccount")
        Me.txtInvAccount.Name = "txtInvAccount"
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.Name = "Label22"
        '
        'txtSalesAccountUBRAIU
        '
        resources.ApplyResources(Me.txtSalesAccountUBRAIU, "txtSalesAccountUBRAIU")
        Me.txtSalesAccountUBRAIU.Name = "txtSalesAccountUBRAIU"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.Name = "Label20"
        '
        'txtSalesAccountUBR
        '
        resources.ApplyResources(Me.txtSalesAccountUBR, "txtSalesAccountUBR")
        Me.txtSalesAccountUBR.Name = "txtSalesAccountUBR"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.Name = "Label18"
        '
        'txtSalesAccountAIU
        '
        resources.ApplyResources(Me.txtSalesAccountAIU, "txtSalesAccountAIU")
        Me.txtSalesAccountAIU.Name = "txtSalesAccountAIU"
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.Name = "Label19"
        '
        'txtSalesSubAccount
        '
        resources.ApplyResources(Me.txtSalesSubAccount, "txtSalesSubAccount")
        Me.txtSalesSubAccount.Name = "txtSalesSubAccount"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'txtSalesAccount
        '
        resources.ApplyResources(Me.txtSalesAccount, "txtSalesAccount")
        Me.txtSalesAccount.Name = "txtSalesAccount"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'txtGoodsSubAccount
        '
        resources.ApplyResources(Me.txtGoodsSubAccount, "txtGoodsSubAccount")
        Me.txtGoodsSubAccount.Name = "txtGoodsSubAccount"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'txtGoodAccount
        '
        resources.ApplyResources(Me.txtGoodAccount, "txtGoodAccount")
        Me.txtGoodAccount.Name = "txtGoodAccount"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'INVENTORYCLASSTableAdapter
        '
        Me.INVENTORYCLASSTableAdapter.ClearBeforeFill = True
        '
        'SITESTableAdapter
        '
        Me.SITESTableAdapter.ClearBeforeFill = True
        '
        'INVENTORYUNITTableAdapter
        '
        Me.INVENTORYUNITTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuExit})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'mnuSave
        '
        resources.ApplyResources(Me.mnuSave, "mnuSave")
        Me.mnuSave.Name = "mnuSave"
        '
        'mnuExit
        '
        resources.ApplyResources(Me.mnuExit, "mnuExit")
        Me.mnuExit.Name = "mnuExit"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtVendorId)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.txtBrand)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.txtVendor)
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        '
        'txtVendorId
        '
        resources.ApplyResources(Me.txtVendorId, "txtVendorId")
        Me.txtVendorId.Name = "txtVendorId"
        '
        'Label25
        '
        resources.ApplyResources(Me.Label25, "Label25")
        Me.Label25.Name = "Label25"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        '
        'frmInvItemEdit
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInvItemEdit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SITESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTORYCLASSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.INVENTORYUNITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInvItemID As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents cbxInventoryClass As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxDefaultSite As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLastCost As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAvgCost As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lable As System.Windows.Forms.Label
    Friend WithEvents cbxStorageUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMaxOnHand As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMinOnHand As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtListPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtGoodAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
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
    Friend WithEvents txtInvSubAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtInvAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtSalesAccountUBRAIU As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents INVENTORYCLASSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INVENTORYCLASSTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.INVENTORYCLASSTableAdapter
    Friend WithEvents SITESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SITESTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.SITESTableAdapter
    Friend WithEvents txtSalesUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtPurchaseUnit As System.Windows.Forms.TextBox
    Friend WithEvents INVENTORYUNITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INVENTORYUNITTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.INVENTORYUNITTableAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAbbrev As System.Windows.Forms.TextBox
    Friend WithEvents cbxActive As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtBrand As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtVendor As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtVendorId As TextBox
    Friend WithEvents Label25 As Label
End Class
