﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtKey = New System.Windows.Forms.MaskedTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuCheckin = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAbout2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrivacyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WipeSelectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sbStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.stCheckin = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnTips = New System.Windows.Forms.Button()
        Me.btnWipeSelect = New System.Windows.Forms.Button()
        Me.tmrCheckin = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtKey)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 83)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtKey
        '
        Me.txtKey.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKey.Location = New System.Drawing.Point(20, 19)
        Me.txtKey.Name = "txtKey"
        Me.txtKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtKey.Size = New System.Drawing.Size(387, 47)
        Me.txtKey.TabIndex = 5
        Me.txtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(437, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuCheckin, Me.StopToolStripMenuItem, Me.ToolStripSeparator2, Me.menuAbout, Me.WipeSelectToolStripMenuItem, Me.menuSettings, Me.ToolStripSeparator1, Me.menuExit})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'menuCheckin
        '
        Me.menuCheckin.Name = "menuCheckin"
        Me.menuCheckin.Size = New System.Drawing.Size(135, 22)
        Me.menuCheckin.Text = "Check-in"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.StopToolStripMenuItem.Text = "S&top"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(132, 6)
        '
        'menuAbout
        '
        Me.menuAbout.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuAbout2, Me.PrivacyToolStripMenuItem})
        Me.menuAbout.Name = "menuAbout"
        Me.menuAbout.Size = New System.Drawing.Size(135, 22)
        Me.menuAbout.Text = "&About"
        '
        'menuAbout2
        '
        Me.menuAbout2.Name = "menuAbout2"
        Me.menuAbout2.Size = New System.Drawing.Size(112, 22)
        Me.menuAbout2.Text = "About"
        '
        'PrivacyToolStripMenuItem
        '
        Me.PrivacyToolStripMenuItem.Name = "PrivacyToolStripMenuItem"
        Me.PrivacyToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.PrivacyToolStripMenuItem.Text = "Privacy"
        '
        'WipeSelectToolStripMenuItem
        '
        Me.WipeSelectToolStripMenuItem.Name = "WipeSelectToolStripMenuItem"
        Me.WipeSelectToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.WipeSelectToolStripMenuItem.Text = "&Wipe Select"
        '
        'menuSettings
        '
        Me.menuSettings.Name = "menuSettings"
        Me.menuSettings.Size = New System.Drawing.Size(135, 22)
        Me.menuSettings.Text = "&Settings"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(132, 6)
        '
        'menuExit
        '
        Me.menuExit.Name = "menuExit"
        Me.menuExit.Size = New System.Drawing.Size(135, 22)
        Me.menuExit.Text = "E&xit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbStatus, Me.stCheckin})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 150)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(437, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'sbStatus
        '
        Me.sbStatus.Name = "sbStatus"
        Me.sbStatus.Size = New System.Drawing.Size(39, 17)
        Me.sbStatus.Text = "Ready"
        '
        'stCheckin
        '
        Me.stCheckin.Name = "stCheckin"
        Me.stCheckin.Size = New System.Drawing.Size(383, 17)
        Me.stCheckin.Spring = True
        Me.stCheckin.Text = "Last checked-in:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(269, 117)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnTips
        '
        Me.btnTips.Location = New System.Drawing.Point(350, 116)
        Me.btnTips.Name = "btnTips"
        Me.btnTips.Size = New System.Drawing.Size(75, 23)
        Me.btnTips.TabIndex = 9
        Me.btnTips.Text = "&Help"
        Me.btnTips.UseVisualStyleBackColor = True
        '
        'btnWipeSelect
        '
        Me.btnWipeSelect.Location = New System.Drawing.Point(12, 117)
        Me.btnWipeSelect.Name = "btnWipeSelect"
        Me.btnWipeSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnWipeSelect.TabIndex = 10
        Me.btnWipeSelect.Text = "Wipe Select"
        Me.btnWipeSelect.UseVisualStyleBackColor = True
        '
        'tmrCheckin
        '
        Me.tmrCheckin.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 172)
        Me.Controls.Add(Me.btnWipeSelect)
        Me.Controls.Add(Me.btnTips)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selbstzerstorung"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCheckin As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents txtKey As System.Windows.Forms.MaskedTextBox
    Friend WithEvents menuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAbout2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrivacyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents sbStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnTips As System.Windows.Forms.Button
    Friend WithEvents btnWipeSelect As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents WipeSelectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stCheckin As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrCheckin As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon

End Class
