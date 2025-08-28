<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWellEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWellEdit))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxSite = New System.Windows.Forms.ComboBox()
        Me.SITESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SESTicketSQLDataSet = New SESTicket.SESTicketSQLDataSet()
        Me.cbxState = New System.Windows.Forms.ComboBox()
        Me.STATEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxCity = New System.Windows.Forms.ComboBox()
        Me.CITYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxCountry = New System.Windows.Forms.ComboBox()
        Me.COUNTRYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxRig = New System.Windows.Forms.ComboBox()
        Me.RIGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxActive = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxField = New System.Windows.Forms.ComboBox()
        Me.PETRFIELDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtWellID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.COUNTRYTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.COUNTRYTableAdapter()
        Me.STATETableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.STATETableAdapter()
        Me.CITYTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.CITYTableAdapter()
        Me.SITESTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.SITESTableAdapter()
        Me.PETRFIELDTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.PETRFIELDTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.RIGTableAdapter = New SESTicket.SESTicketSQLDataSetTableAdapters.RIGTableAdapter()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SITESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STATEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CITYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COUNTRYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RIGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PETRFIELDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cbxSite)
        Me.GroupBox3.Controls.Add(Me.cbxState)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cbxCity)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cbxCountry)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 214)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(473, 155)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(23, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 16)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Site:"
        '
        'cbxSite
        '
        Me.cbxSite.DataSource = Me.SITESBindingSource
        Me.cbxSite.DisplayMember = "NAME"
        Me.cbxSite.FormattingEnabled = True
        Me.cbxSite.Location = New System.Drawing.Point(100, 23)
        Me.cbxSite.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxSite.Name = "cbxSite"
        Me.cbxSite.Size = New System.Drawing.Size(197, 24)
        Me.cbxSite.TabIndex = 16
        Me.cbxSite.ValueMember = "SITEID"
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
        'cbxState
        '
        Me.cbxState.DataSource = Me.STATEBindingSource
        Me.cbxState.DisplayMember = "NAME"
        Me.cbxState.FormattingEnabled = True
        Me.cbxState.Location = New System.Drawing.Point(100, 85)
        Me.cbxState.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxState.Name = "cbxState"
        Me.cbxState.Size = New System.Drawing.Size(197, 24)
        Me.cbxState.TabIndex = 6
        Me.cbxState.ValueMember = "STATEID"
        '
        'STATEBindingSource
        '
        Me.STATEBindingSource.DataMember = "STATE"
        Me.STATEBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(23, 89)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "State:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(23, 118)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "City:"
        '
        'cbxCity
        '
        Me.cbxCity.DataSource = Me.CITYBindingSource
        Me.cbxCity.DisplayMember = "NAME"
        Me.cbxCity.FormattingEnabled = True
        Me.cbxCity.Location = New System.Drawing.Point(100, 114)
        Me.cbxCity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxCity.Name = "cbxCity"
        Me.cbxCity.Size = New System.Drawing.Size(197, 24)
        Me.cbxCity.TabIndex = 7
        Me.cbxCity.ValueMember = "CITYID"
        '
        'CITYBindingSource
        '
        Me.CITYBindingSource.DataMember = "CITY"
        Me.CITYBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(23, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Country:"
        '
        'cbxCountry
        '
        Me.cbxCountry.DataSource = Me.COUNTRYBindingSource
        Me.cbxCountry.DisplayMember = "NAME"
        Me.cbxCountry.FormattingEnabled = True
        Me.cbxCountry.Location = New System.Drawing.Point(100, 58)
        Me.cbxCountry.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxCountry.Name = "cbxCountry"
        Me.cbxCountry.Size = New System.Drawing.Size(197, 24)
        Me.cbxCountry.TabIndex = 5
        Me.cbxCountry.ValueMember = "COUNTRYID"
        '
        'COUNTRYBindingSource
        '
        Me.COUNTRYBindingSource.DataMember = "COUNTRY"
        Me.COUNTRYBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbxRig)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbxActive)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbxField)
        Me.GroupBox1.Controls.Add(Me.txtWellID)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(473, 151)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Base Information"
        '
        'cbxRig
        '
        Me.cbxRig.DataSource = Me.RIGBindingSource
        Me.cbxRig.DisplayMember = "RIGID"
        Me.cbxRig.FormattingEnabled = True
        Me.cbxRig.Location = New System.Drawing.Point(100, 114)
        Me.cbxRig.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxRig.Name = "cbxRig"
        Me.cbxRig.Size = New System.Drawing.Size(197, 24)
        Me.cbxRig.TabIndex = 46
        Me.cbxRig.ValueMember = "RIGID"
        '
        'RIGBindingSource
        '
        Me.RIGBindingSource.DataMember = "RIG"
        Me.RIGBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 16)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Rig:"
        '
        'cbxActive
        '
        Me.cbxActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbxActive.FormattingEnabled = True
        Me.cbxActive.Items.AddRange(New Object() {"YES", "NO"})
        Me.cbxActive.Location = New System.Drawing.Point(384, 28)
        Me.cbxActive.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxActive.Name = "cbxActive"
        Me.cbxActive.Size = New System.Drawing.Size(67, 24)
        Me.cbxActive.TabIndex = 44
        Me.cbxActive.Text = "YES"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(323, 32)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 16)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Active:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(23, 87)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Petr Field:"
        '
        'cbxField
        '
        Me.cbxField.DataSource = Me.PETRFIELDBindingSource
        Me.cbxField.DisplayMember = "DESCRIP"
        Me.cbxField.FormattingEnabled = True
        Me.cbxField.Location = New System.Drawing.Point(100, 84)
        Me.cbxField.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbxField.Name = "cbxField"
        Me.cbxField.Size = New System.Drawing.Size(197, 24)
        Me.cbxField.TabIndex = 21
        Me.cbxField.ValueMember = "PETRFIELDID"
        '
        'PETRFIELDBindingSource
        '
        Me.PETRFIELDBindingSource.DataMember = "PETRFIELD"
        Me.PETRFIELDBindingSource.DataSource = Me.SESTicketSQLDataSet
        '
        'txtWellID
        '
        Me.txtWellID.Location = New System.Drawing.Point(100, 30)
        Me.txtWellID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWellID.MaxLength = 15
        Me.txtWellID.Name = "txtWellID"
        Me.txtWellID.Size = New System.Drawing.Size(157, 22)
        Me.txtWellID.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(100, 57)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(351, 22)
        Me.txtName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Well ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name:"
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
        'SITESTableAdapter
        '
        Me.SITESTableAdapter.ClearBeforeFill = True
        '
        'PETRFIELDTableAdapter
        '
        Me.PETRFIELDTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(496, 52)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuSave
        '
        Me.mnuSave.Image = CType(resources.GetObject("mnuSave.Image"), System.Drawing.Image)
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(74, 48)
        Me.mnuSave.Text = "Save"
        '
        'mnuExit
        '
        Me.mnuExit.Image = CType(resources.GetObject("mnuExit.Image"), System.Drawing.Image)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(67, 48)
        Me.mnuExit.Text = "Exit"
        '
        'RIGTableAdapter
        '
        Me.RIGTableAdapter.ClearBeforeFill = True
        '
        'frmWellEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(496, 379)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWellEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INNTICKET - Well Edit"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.SITESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SESTicketSQLDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STATEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CITYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COUNTRYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RIGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PETRFIELDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxState As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbxCity As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxCountry As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtWellID As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxSite As System.Windows.Forms.ComboBox
    Friend WithEvents SESTicketSQLDataSet As SESTicket.SESTicketSQLDataSet
    Friend WithEvents COUNTRYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COUNTRYTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.COUNTRYTableAdapter
    Friend WithEvents STATEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CITYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STATETableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.STATETableAdapter
    Friend WithEvents CITYTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.CITYTableAdapter
    Friend WithEvents SITESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SITESTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.SITESTableAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxField As System.Windows.Forms.ComboBox
    Friend WithEvents PETRFIELDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PETRFIELDTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.PETRFIELDTableAdapter
    Friend WithEvents cbxActive As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxRig As System.Windows.Forms.ComboBox
    Friend WithEvents RIGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RIGTableAdapter As SESTicket.SESTicketSQLDataSetTableAdapters.RIGTableAdapter
End Class
