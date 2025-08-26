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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuDelete, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(446, 42)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuSave
        '
        Me.mnuSave.Image = CType(resources.GetObject("mnuSave.Image"), System.Drawing.Image)
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(59, 38)
        Me.mnuSave.Text = "Save"
        '
        'mnuDelete
        '
        Me.mnuDelete.Image = CType(resources.GetObject("mnuDelete.Image"), System.Drawing.Image)
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(68, 38)
        Me.mnuDelete.Text = "Delete"
        '
        'mnuExit
        '
        Me.mnuExit.Image = CType(resources.GetObject("mnuExit.Image"), System.Drawing.Image)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(53, 38)
        Me.mnuExit.Text = "Exit"
        '
        'grpSalesItem
        '
        Me.grpSalesItem.Controls.Add(Me.Label4)
        Me.grpSalesItem.Controls.Add(Me.Label3)
        Me.grpSalesItem.Controls.Add(Me.btnSearchSalesItem)
        Me.grpSalesItem.Controls.Add(Me.txtSalesItemDescrip)
        Me.grpSalesItem.Controls.Add(Me.txtCustCodeItem)
        Me.grpSalesItem.Location = New System.Drawing.Point(12, 45)
        Me.grpSalesItem.Name = "grpSalesItem"
        Me.grpSalesItem.Size = New System.Drawing.Size(422, 97)
        Me.grpSalesItem.TabIndex = 37
        Me.grpSalesItem.TabStop = False
        Me.grpSalesItem.Text = "Sales Item"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Item:"
        '
        'btnSearchSalesItem
        '
        Me.btnSearchSalesItem.Location = New System.Drawing.Point(335, 16)
        Me.btnSearchSalesItem.Name = "btnSearchSalesItem"
        Me.btnSearchSalesItem.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchSalesItem.TabIndex = 31
        Me.btnSearchSalesItem.Text = "Search"
        Me.btnSearchSalesItem.UseVisualStyleBackColor = True
        '
        'txtSalesItemDescrip
        '
        Me.txtSalesItemDescrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalesItemDescrip.Location = New System.Drawing.Point(92, 45)
        Me.txtSalesItemDescrip.Multiline = True
        Me.txtSalesItemDescrip.Name = "txtSalesItemDescrip"
        Me.txtSalesItemDescrip.ReadOnly = True
        Me.txtSalesItemDescrip.Size = New System.Drawing.Size(318, 41)
        Me.txtSalesItemDescrip.TabIndex = 13
        '
        'txtCustCodeItem
        '
        Me.txtCustCodeItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustCodeItem.Location = New System.Drawing.Point(92, 19)
        Me.txtCustCodeItem.Name = "txtCustCodeItem"
        Me.txtCustCodeItem.ReadOnly = True
        Me.txtCustCodeItem.Size = New System.Drawing.Size(142, 20)
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
        Me.grvInvItem.Location = New System.Drawing.Point(12, 148)
        Me.grvInvItem.Name = "grvInvItem"
        Me.grvInvItem.Size = New System.Drawing.Size(422, 128)
        Me.grvInvItem.TabIndex = 38
        Me.grvInvItem.TabStop = False
        Me.grvInvItem.Text = "Inventory Item"
        '
        'btnSearchInvItem
        '
        Me.btnSearchInvItem.Location = New System.Drawing.Point(335, 17)
        Me.btnSearchInvItem.Name = "btnSearchInvItem"
        Me.btnSearchInvItem.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchInvItem.TabIndex = 47
        Me.btnSearchInvItem.Text = "Search"
        Me.btnSearchInvItem.UseVisualStyleBackColor = True
        '
        'txtDescrip
        '
        Me.txtDescrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescrip.Location = New System.Drawing.Point(92, 68)
        Me.txtDescrip.MaxLength = 50
        Me.txtDescrip.Multiline = True
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.ReadOnly = True
        Me.txtDescrip.Size = New System.Drawing.Size(318, 50)
        Me.txtDescrip.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Description:"
        '
        'txtInvItemId
        '
        Me.txtInvItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvItemId.Location = New System.Drawing.Point(92, 24)
        Me.txtInvItemId.MaxLength = 15
        Me.txtInvItemId.Name = "txtInvItemId"
        Me.txtInvItemId.ReadOnly = True
        Me.txtInvItemId.Size = New System.Drawing.Size(182, 20)
        Me.txtInvItemId.TabIndex = 1
        '
        'txtAbbrev
        '
        Me.txtAbbrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAbbrev.Location = New System.Drawing.Point(92, 46)
        Me.txtAbbrev.MaxLength = 50
        Me.txtAbbrev.Name = "txtAbbrev"
        Me.txtAbbrev.ReadOnly = True
        Me.txtAbbrev.Size = New System.Drawing.Size(318, 20)
        Me.txtAbbrev.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Abbreviation:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtQuantity)
        Me.GroupBox3.Controls.Add(Me.txtUnit)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 282)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(422, 69)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.White
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Location = New System.Drawing.Point(95, 38)
        Me.txtQuantity.MaxLength = 15
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(64, 20)
        Me.txtQuantity.TabIndex = 5
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnit
        '
        Me.txtUnit.BackColor = System.Drawing.SystemColors.Control
        Me.txtUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnit.Location = New System.Drawing.Point(95, 15)
        Me.txtUnit.MaxLength = 15
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.ReadOnly = True
        Me.txtUnit.Size = New System.Drawing.Size(64, 20)
        Me.txtUnit.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Unit:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(20, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Quantity:"
        '
        'frmTicketInvItemLineEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(446, 358)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grvInvItem)
        Me.Controls.Add(Me.grpSalesItem)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTicketInvItemLineEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTicket - Inventory Item - Consumption"
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
