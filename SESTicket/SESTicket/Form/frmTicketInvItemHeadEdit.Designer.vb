<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketInvItemHeadEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketInvItemHeadEdit))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtInvItemId = New System.Windows.Forms.TextBox()
        Me.txtAbbrev = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtReturned = New System.Windows.Forms.TextBox()
        Me.txtConsumption = New System.Windows.Forms.TextBox()
        Me.txtDespatched = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(591, 52)
        Me.MenuStrip1.TabIndex = 35
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDescrip)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtInvItemId)
        Me.GroupBox1.Controls.Add(Me.txtAbbrev)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 55)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(563, 158)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventory Item"
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
        Me.Label7.Location = New System.Drawing.Point(23, 87)
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
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Abbreviation:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtReturned)
        Me.GroupBox2.Controls.Add(Me.txtConsumption)
        Me.GroupBox2.Controls.Add(Me.txtDespatched)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtUnit)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 346)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(567, 134)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        '
        'txtReturned
        '
        Me.txtReturned.BackColor = System.Drawing.SystemColors.Control
        Me.txtReturned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReturned.Location = New System.Drawing.Point(127, 98)
        Me.txtReturned.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReturned.MaxLength = 15
        Me.txtReturned.Name = "txtReturned"
        Me.txtReturned.ReadOnly = True
        Me.txtReturned.Size = New System.Drawing.Size(85, 22)
        Me.txtReturned.TabIndex = 7
        Me.txtReturned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtConsumption
        '
        Me.txtConsumption.BackColor = System.Drawing.SystemColors.Control
        Me.txtConsumption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConsumption.Location = New System.Drawing.Point(127, 73)
        Me.txtConsumption.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConsumption.MaxLength = 15
        Me.txtConsumption.Name = "txtConsumption"
        Me.txtConsumption.ReadOnly = True
        Me.txtConsumption.Size = New System.Drawing.Size(85, 22)
        Me.txtConsumption.TabIndex = 6
        Me.txtConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDespatched
        '
        Me.txtDespatched.BackColor = System.Drawing.Color.White
        Me.txtDespatched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDespatched.Location = New System.Drawing.Point(127, 47)
        Me.txtDespatched.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDespatched.MaxLength = 15
        Me.txtDespatched.Name = "txtDespatched"
        Me.txtDespatched.Size = New System.Drawing.Size(85, 22)
        Me.txtDespatched.TabIndex = 5
        Me.txtDespatched.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 101)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Returned:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 75)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Consumption:"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Unit:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(27, 49)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Dispatched:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtComments)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtLote)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 220)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(567, 118)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'txtComments
        '
        Me.txtComments.BackColor = System.Drawing.Color.White
        Me.txtComments.Location = New System.Drawing.Point(127, 48)
        Me.txtComments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtComments.MaxLength = 50
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(423, 61)
        Me.txtComments.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 52)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Comments:"
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.Color.White
        Me.txtLote.Location = New System.Drawing.Point(127, 20)
        Me.txtLote.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLote.MaxLength = 15
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(241, 22)
        Me.txtLote.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 23)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 16)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Lote:"
        '
        'frmTicketInvItemHeadEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(591, 489)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTicketInvItemHeadEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INNTicket - Inventory Item"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtInvItemId As TextBox
    Friend WithEvents txtAbbrev As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescrip As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtReturned As TextBox
    Friend WithEvents txtConsumption As TextBox
    Friend WithEvents txtDespatched As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtComments As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLote As TextBox
    Friend WithEvents Label8 As Label
End Class
