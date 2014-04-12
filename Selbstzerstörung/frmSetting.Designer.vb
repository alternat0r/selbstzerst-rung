<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Me.cmbWipeStyle = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.chkShowKey = New System.Windows.Forms.CheckBox()
        Me.chkKeyForSetting = New System.Windows.Forms.CheckBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.chkEncryptConf = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lvSchedule = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.chkSelfDestroy = New System.Windows.Forms.CheckBox()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lvSoftware = New System.Windows.Forms.ListView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbWipeStyle)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Wipe Style"
        '
        'cmbWipeStyle
        '
        Me.cmbWipeStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbWipeStyle.FormattingEnabled = True
        Me.cmbWipeStyle.Items.AddRange(New Object() {"Using sdelete (Random)", "Nato Standard (7x)", "Peter Gutmann (35x)"})
        Me.cmbWipeStyle.Location = New System.Drawing.Point(7, 20)
        Me.cmbWipeStyle.Name = "cmbWipeStyle"
        Me.cmbWipeStyle.Size = New System.Drawing.Size(331, 21)
        Me.cmbWipeStyle.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkSelfDestroy)
        Me.GroupBox2.Controls.Add(Me.chkEncryptConf)
        Me.GroupBox2.Controls.Add(Me.chkKeyForSetting)
        Me.GroupBox2.Controls.Add(Me.chkShowKey)
        Me.GroupBox2.Controls.Add(Me.txtKey)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 139)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Security"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password:"
        '
        'txtKey
        '
        Me.txtKey.Location = New System.Drawing.Point(69, 25)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtKey.Size = New System.Drawing.Size(269, 20)
        Me.txtKey.TabIndex = 1
        '
        'chkShowKey
        '
        Me.chkShowKey.AutoSize = True
        Me.chkShowKey.Location = New System.Drawing.Point(69, 52)
        Me.chkShowKey.Name = "chkShowKey"
        Me.chkShowKey.Size = New System.Drawing.Size(101, 17)
        Me.chkShowKey.TabIndex = 2
        Me.chkShowKey.Text = "Show password"
        Me.chkShowKey.UseVisualStyleBackColor = True
        '
        'chkKeyForSetting
        '
        Me.chkKeyForSetting.AutoSize = True
        Me.chkKeyForSetting.Location = New System.Drawing.Point(69, 70)
        Me.chkKeyForSetting.Name = "chkKeyForSetting"
        Me.chkKeyForSetting.Size = New System.Drawing.Size(168, 17)
        Me.chkKeyForSetting.TabIndex = 3
        Me.chkKeyForSetting.Text = "Use this password for Settings"
        Me.chkKeyForSetting.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(590, 399)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(509, 399)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'chkEncryptConf
        '
        Me.chkEncryptConf.AutoSize = True
        Me.chkEncryptConf.Location = New System.Drawing.Point(69, 89)
        Me.chkEncryptConf.Name = "chkEncryptConf"
        Me.chkEncryptConf.Size = New System.Drawing.Size(142, 17)
        Me.chkEncryptConf.TabIndex = 4
        Me.chkEncryptConf.Text = "Encrypt configuration file"
        Me.chkEncryptConf.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.lvSchedule)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 218)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(344, 163)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Schedule"
        '
        'lvSchedule
        '
        Me.lvSchedule.CheckBoxes = True
        Me.lvSchedule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lvSchedule.FullRowSelect = True
        Me.lvSchedule.GridLines = True
        Me.lvSchedule.Location = New System.Drawing.Point(7, 20)
        Me.lvSchedule.Name = "lvSchedule"
        Me.lvSchedule.Size = New System.Drawing.Size(331, 105)
        Me.lvSchedule.TabIndex = 0
        Me.lvSchedule.UseCompatibleStateImageBehavior = False
        Me.lvSchedule.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Object"
        Me.ColumnHeader1.Width = 100
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Time"
        Me.ColumnHeader2.Width = 120
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(7, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(23, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(36, 131)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(23, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "-"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'chkSelfDestroy
        '
        Me.chkSelfDestroy.AutoSize = True
        Me.chkSelfDestroy.Location = New System.Drawing.Point(69, 110)
        Me.chkSelfDestroy.Name = "chkSelfDestroy"
        Me.chkSelfDestroy.Size = New System.Drawing.Size(143, 17)
        Me.chkSelfDestroy.TabIndex = 5
        Me.chkSelfDestroy.Text = "Destroy Selbstzerstorung"
        Me.chkSelfDestroy.UseVisualStyleBackColor = True
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Check-in Time"
        Me.ColumnHeader3.Width = 100
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.lvSoftware)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(363, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(302, 368)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pre-Listed Software"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "This part allow you to destroy certain software installed on your machine. Tick a" & _
    "ny listed software to enable."
        '
        'lvSoftware
        '
        Me.lvSoftware.CheckBoxes = True
        Me.lvSoftware.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4})
        Me.lvSoftware.FullRowSelect = True
        Me.lvSoftware.GridLines = True
        Me.lvSoftware.Location = New System.Drawing.Point(10, 60)
        Me.lvSoftware.Name = "lvSoftware"
        Me.lvSoftware.Size = New System.Drawing.Size(286, 270)
        Me.lvSoftware.TabIndex = 2
        Me.lvSoftware.UseCompatibleStateImageBehavior = False
        Me.lvSoftware.View = System.Windows.Forms.View.Details
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(39, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "-"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 336)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(23, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Software Name"
        Me.ColumnHeader4.Width = 280
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(677, 431)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbWipeStyle As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKey As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkKeyForSetting As System.Windows.Forms.CheckBox
    Friend WithEvents chkShowKey As System.Windows.Forms.CheckBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents chkEncryptConf As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lvSchedule As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents chkSelfDestroy As System.Windows.Forms.CheckBox
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lvSoftware As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
End Class
