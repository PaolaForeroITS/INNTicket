<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTicketWorkerEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTicketWorkerEdit))
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAppointment = New System.Windows.Forms.TextBox()
        Me.txtHourQde = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpRegisterDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtHourLost = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHourStandby = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHourOperation = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHourTravel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtActivityResume = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(430, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(51, 20)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtFullName
        '
        Me.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFullName.Enabled = False
        Me.txtFullName.Location = New System.Drawing.Point(71, 14)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(353, 20)
        Me.txtFullName.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Worker:"
        '
        'btnCancelDelete
        '
        Me.btnCancelDelete.Location = New System.Drawing.Point(266, 271)
        Me.btnCancelDelete.Name = "btnCancelDelete"
        Me.btnCancelDelete.Size = New System.Drawing.Size(100, 27)
        Me.btnCancelDelete.TabIndex = 23
        Me.btnCancelDelete.Text = "Delete"
        Me.btnCancelDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(151, 271)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 27)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAppointment)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtFullName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 65)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'txtAppointment
        '
        Me.txtAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppointment.Enabled = False
        Me.txtAppointment.Location = New System.Drawing.Point(71, 35)
        Me.txtAppointment.Name = "txtAppointment"
        Me.txtAppointment.Size = New System.Drawing.Size(353, 20)
        Me.txtAppointment.TabIndex = 22
        '
        'txtHourQde
        '
        Me.txtHourQde.Location = New System.Drawing.Point(108, 160)
        Me.txtHourQde.Name = "txtHourQde"
        Me.txtHourQde.ReadOnly = True
        Me.txtHourQde.Size = New System.Drawing.Size(56, 20)
        Me.txtHourQde.TabIndex = 23
        Me.txtHourQde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(20, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Register Date:"
        '
        'dtpRegisterDate
        '
        Me.dtpRegisterDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRegisterDate.Location = New System.Drawing.Point(108, 19)
        Me.dtpRegisterDate.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.dtpRegisterDate.Name = "dtpRegisterDate"
        Me.dtpRegisterDate.Size = New System.Drawing.Size(125, 20)
        Me.dtpRegisterDate.TabIndex = 19
        Me.dtpRegisterDate.Value = New Date(2017, 1, 31, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Total:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtHourLost)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtHourStandby)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtHourOperation)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtHourTravel)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtHourQde)
        Me.GroupBox2.Controls.Add(Me.dtpRegisterDate)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(246, 193)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'txtHourLost
        '
        Me.txtHourLost.Location = New System.Drawing.Point(108, 134)
        Me.txtHourLost.Name = "txtHourLost"
        Me.txtHourLost.Size = New System.Drawing.Size(56, 20)
        Me.txtHourLost.TabIndex = 31
        Me.txtHourLost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(20, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Hour Lost:"
        '
        'txtHourStandby
        '
        Me.txtHourStandby.Location = New System.Drawing.Point(108, 108)
        Me.txtHourStandby.Name = "txtHourStandby"
        Me.txtHourStandby.Size = New System.Drawing.Size(56, 20)
        Me.txtHourStandby.TabIndex = 29
        Me.txtHourStandby.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(20, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Hour Standby:"
        '
        'txtHourOperation
        '
        Me.txtHourOperation.Location = New System.Drawing.Point(108, 82)
        Me.txtHourOperation.Name = "txtHourOperation"
        Me.txtHourOperation.Size = New System.Drawing.Size(56, 20)
        Me.txtHourOperation.TabIndex = 27
        Me.txtHourOperation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(20, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Hour Operation:"
        '
        'txtHourTravel
        '
        Me.txtHourTravel.Location = New System.Drawing.Point(108, 56)
        Me.txtHourTravel.Name = "txtHourTravel"
        Me.txtHourTravel.Size = New System.Drawing.Size(56, 20)
        Me.txtHourTravel.TabIndex = 25
        Me.txtHourTravel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(20, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Hour Travel:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtActivityResume)
        Me.GroupBox3.Location = New System.Drawing.Point(257, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(245, 193)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Activity Resume:"
        '
        'txtActivityResume
        '
        Me.txtActivityResume.Location = New System.Drawing.Point(9, 19)
        Me.txtActivityResume.Multiline = True
        Me.txtActivityResume.Name = "txtActivityResume"
        Me.txtActivityResume.Size = New System.Drawing.Size(230, 168)
        Me.txtActivityResume.TabIndex = 22
        '
        'frmTicketWorkerEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(508, 306)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancelDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTicketWorkerEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ticket Worker"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpRegisterDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAppointment As System.Windows.Forms.TextBox
    Friend WithEvents txtHourQde As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtHourStandby As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHourOperation As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHourTravel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHourLost As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtActivityResume As TextBox
End Class
