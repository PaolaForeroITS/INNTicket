<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketInvItemLineEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketInvItemLineEdit))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpSalesItem = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSearchSalesItem = New System.Windows.Forms.Button()
        Me.txtSalesItemDescrip = New System.Windows.Forms.TextBox()
        Me.txtCustCodeItem = New System.Windows.Forms.TextBox()
        Me.grvInvItem = New System.Windows.Forms.GroupBox()
        Me.btnSearchInvItem = New System.Windows.Forms.Button()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtInvItemId = New System.Windows.Forms.TextBox()
        Me.txtAbbrev = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.grpSalesItem.SuspendLayout()
        Me.grvInvItem.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuDelete, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(595, 52)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuSave
        '
        Me.mnuSave.Image = CType(resources.GetObject("mnuSave.Image"), System.Drawing.Image)
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(74, 48)
        Me.mnuSave.Text = "Save"
        '
        'mnuDelete
        '
        Me.mnuDelete.Image = CType(resources.GetObject("mnuDelete.Image"), System.Drawing.Image)
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(87, 48)
        Me.mnuDelete.Text = "Delete"
        '
        'mnuExit
        '
        Me.mnuExit.Image = CType(resources.GetObject("mnuExit.Image"), System.Drawing.Image)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(67, 48)
        Me.mnuExit.Text = "Exit"
        '
        'grpSalesItem
        '
        Me.grpSalesItem.Controls.Add(Me.Label4)
        Me.grpSalesItem.Controls.Add(Me.Label3)
        Me.grpSalesItem.Controls.Add(Me.btnSearchSalesItem)
        Me.grpSalesItem.Controls.Add(Me.txtSalesItemDescrip)
        Me.grpSalesItem.Controls.Add(Me.txtCustCodeItem)
        Me.grpSalesItem.Location = New System.Drawing.Point(16, 55)
        Me.grpSalesItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSalesItem.Name = "grpSalesItem"
        Me.grpSalesItem.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSalesItem.Size = New System.Drawing.Size(563, 119)
        Me.grpSalesItem.TabIndex = 37
        Me.grpSalesItem.TabStop = False
        Me.grpSalesItem.Text = "Sales Item"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 58)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Item:"
        '
        'btnSearchSalesItem
        '
        Me.btnSearchSalesItem.Location = New System.Drawing.Point(447, 20)
        Me.btnSearchSalesItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchSalesItem.Name = "btnSearchSalesItem"
        Me.btnSearchSalesItem.Size = New System.Drawing.Size(100, 28)
        Me.btnSearchSalesItem.TabIndex = 31
        Me.btnSearchSalesItem.Text = "Search"
        Me.btnSearchSalesItem.UseVisualStyleBackColor = True
        '
        'txtSalesItemDescrip
        '
        Me.txtSalesItemDescrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalesItemDescrip.Location = New System.Drawing.Point(123, 55)
        Me.txtSalesItemDescrip.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSalesItemDescrip.Multiline = True
        Me.txtSalesItemDescrip.Name = "txtSalesItemDescrip"
        Me.txtSalesItemDescrip.ReadOnly = True
        Me.txtSalesItemDescrip.Size = New System.Drawing.Size(423, 50)
        Me.txtSalesItemDescrip.TabIndex = 13
        '
        'txtCustCodeItem
        '
        Me.txtCustCodeItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustCodeItem.Location = New System.Drawing.Point(123, 23)
        Me.txtCustCodeItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCustCodeItem.Name = "txtCustCodeItem"
        Me.txtCustCodeItem.ReadOnly = True
        Me.txtCustCodeItem.Size = New System.Drawing.Size(189, 22)
        Me.txtCustCodeItem.TabIndex = 12
        '
        'grvInvItem
        '
        Me.grvInvItem.Controls.Add(Me.btnSearchInvItem)
        Me.grvInvItem.Controls.Add(Me.txtDescrip)
        Me.grvInvItem.Controls.Add(Me.Label7)
        Me.grvInvItem.Controls.Add(Me.txtInvItemId)
        Me.grvInvItem.Controls.Add(Me.txtAbbrev)
        Me.grvInvItem.Controls.Add(Me.Label1)
        Me.grvInvItem.Controls.Add(Me.Label2)
        Me.grvInvItem.Location = New System.Drawing.Point(16, 182)
        Me.grvInvItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grvInvItem.Name = "grvInvItem"
        Me.grvInvItem.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grvInvItem.Size = New System.Drawing.Size(563, 158)
        Me.grvInvItem.TabIndex = 38
        Me.grvInvItem.TabStop = False
        Me.grvInvItem.Text = "Inventory Item"
        '
        'btnSearchInvItem
        '
        Me.btnSearchInvItem.Location = New System.Drawing.Point(447, 21)
        Me.btnSearchInvItem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchInvItem.Name = "btnSearchInvItem"
        Me.btnSearchInvItem.Size = New System.Drawing.Size(100, 28)
        Me.btnSearchInvItem.TabIndex = 47
        Me.btnSearchInvItem.Text = "Search"
        Me.btnSearchInvItem.UseVisualStyleBackColor = True
        '
        'txtDescrip
        '
        Me.txtDescrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescrip.Location = New System.Drawing.Point(123, 84)
        Me.txtDescrip.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescrip.MaxLength = 50
        Me.txtDescrip.Multiline = True
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.ReadOnly = True
        Me.txtDescrip.Size = New System.Drawing.Size(423, 61)
        Me.txtDescrip.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 86)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Description:"
        '
        'txtInvItemId
        '
        Me.txtInvItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvItemId.Location = New System.Drawing.Point(123, 30)
        Me.txtInvItemId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInvItemId.MaxLength = 15
        Me.txtInvItemId.Name = "txtInvItemId"
        Me.txtInvItemId.ReadOnly = True
        Me.txtInvItemId.Size = New System.Drawing.Size(242, 22)
        Me.txtInvItemId.TabIndex = 1
        '
        'txtAbbrev
        '
        Me.txtAbbrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAbbrev.Location = New System.Drawing.Point(123, 57)
        Me.txtAbbrev.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAbbrev.MaxLength = 50
        Me.txtAbbrev.Name = "txtAbbrev"
        Me.txtAbbrev.ReadOnly = True
        Me.txtAbbrev.Size = New System.Drawing.Size(423, 22)
        Me.txtAbbrev.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Abbreviation:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtQuantity)
        Me.GroupBox3.Controls.Add(Me.txtUnit)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 347)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(563, 85)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.White
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Location = New System.Drawing.Point(127, 47)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtQuantity.MaxLength = 15
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(85, 22)
        Me.txtQuantity.TabIndex = 5
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnit
        '
        Me.txtUnit.BackColor = System.Drawing.SystemColors.Control
        Me.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnit.Location = New System.Drawing.Point(127, 18)
        Me.txtUnit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUnit.MaxLength = 15
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.ReadOnly = True
        Me.txtUnit.Size = New System.Drawing.Size(85, 22)
        Me.txtUnit.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 21)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Unit:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(27, 49)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Quantity:"
        '
        'frmTicketInvItemLineEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(595, 441)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grvInvItem)
        Me.Controls.Add(Me.grpSalesItem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTicketInvItemLineEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INNTicket - Inventory Item - Consumption"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpSalesItem.ResumeLayout(False)
        Me.grpSalesItem.PerformLayout()
        Me.grvInvItem.ResumeLayout(False)
        Me.grvInvItem.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents grpSalesItem As GroupBox
    Friend WithEvents txtSalesItemDescrip As TextBox
    Friend WithEvents txtCustCodeItem As TextBox
    Friend WithEvents btnSearchSalesItem As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grvInvItem As GroupBox
    Friend WithEvents btnSearchInvItem As Button
    Friend WithEvents txtDescrip As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtInvItemId As TextBox
    Friend WithEvents txtAbbrev As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
End Class
