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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSave, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(443, 42)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuSave
        '
        Me.mnuSave.Image = CType(resources.GetObject("mnuSave.Image"), System.Drawing.Image)
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(59, 38)
        Me.mnuSave.Text = "Save"
        '
        'mnuExit
        '
        Me.mnuExit.Image = CType(resources.GetObject("mnuExit.Image"), System.Drawing.Image)
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(53, 38)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 128)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventory Item"
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
        Me.Label7.Location = New System.Drawing.Point(17, 71)
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
        Me.Label2.Location = New System.Drawing.Point(17, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
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
        Me.GroupBox2.Location = New System.Drawing.Point(9, 281)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 109)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        '
        'txtReturned
        '
        Me.txtReturned.BackColor = System.Drawing.SystemColors.Control
        Me.txtReturned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReturned.Location = New System.Drawing.Point(95, 80)
        Me.txtReturned.MaxLength = 15
        Me.txtReturned.Name = "txtReturned"
        Me.txtReturned.ReadOnly = True
        Me.txtReturned.Size = New System.Drawing.Size(64, 20)
        Me.txtReturned.TabIndex = 7
        Me.txtReturned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtConsumption
        '
        Me.txtConsumption.BackColor = System.Drawing.SystemColors.Control
        Me.txtConsumption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConsumption.Location = New System.Drawing.Point(95, 59)
        Me.txtConsumption.MaxLength = 15
        Me.txtConsumption.Name = "txtConsumption"
        Me.txtConsumption.ReadOnly = True
        Me.txtConsumption.Size = New System.Drawing.Size(64, 20)
        Me.txtConsumption.TabIndex = 6
        Me.txtConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDespatched
        '
        Me.txtDespatched.BackColor = System.Drawing.Color.White
        Me.txtDespatched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDespatched.Location = New System.Drawing.Point(95, 38)
        Me.txtDespatched.MaxLength = 15
        Me.txtDespatched.Name = "txtDespatched"
        Me.txtDespatched.Size = New System.Drawing.Size(64, 20)
        Me.txtDespatched.TabIndex = 5
        Me.txtDespatched.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Returned:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Consumption:"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Unit:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(20, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Dispatched:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtComments)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtLote)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 179)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(425, 96)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'txtComments
        '
        Me.txtComments.BackColor = System.Drawing.Color.White
        Me.txtComments.Location = New System.Drawing.Point(95, 39)
        Me.txtComments.MaxLength = 50
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(318, 50)
        Me.txtComments.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Comments:"
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.Color.White
        Me.txtLote.Location = New System.Drawing.Point(95, 16)
        Me.txtLote.MaxLength = 15
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(182, 20)
        Me.txtLote.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Lote:"
        '
        'frmTicketInvItemHeadEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(443, 397)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTicketInvItemHeadEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SESTicket - Inventory Item"
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
