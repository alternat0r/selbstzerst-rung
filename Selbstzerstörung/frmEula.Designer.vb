﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEula))
        Me.btnDecline = New System.Windows.Forms.Button()
        Me.btnAgree = New System.Windows.Forms.Button()
        Me.txtLicense = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDecline
        '
        Me.btnDecline.Location = New System.Drawing.Point(293, 356)
        Me.btnDecline.Name = "btnDecline"
        Me.btnDecline.Size = New System.Drawing.Size(75, 23)
        Me.btnDecline.TabIndex = 1
        Me.btnDecline.Text = "&Decline"
        Me.btnDecline.UseVisualStyleBackColor = True
        '
        'btnAgree
        '
        Me.btnAgree.Location = New System.Drawing.Point(212, 356)
        Me.btnAgree.Name = "btnAgree"
        Me.btnAgree.Size = New System.Drawing.Size(75, 23)
        Me.btnAgree.TabIndex = 2
        Me.btnAgree.Text = "&Agree"
        Me.btnAgree.UseVisualStyleBackColor = True
        '
        'txtLicense
        '
        Me.txtLicense.BackColor = System.Drawing.Color.White
        Me.txtLicense.Location = New System.Drawing.Point(13, 13)
        Me.txtLicense.Multiline = True
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.ReadOnly = True
        Me.txtLicense.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLicense.Size = New System.Drawing.Size(355, 337)
        Me.txtLicense.TabIndex = 3
        Me.txtLicense.Text = resources.GetString("txtLicense.Text")
        '
        'frmEula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 391)
        Me.Controls.Add(Me.txtLicense)
        Me.Controls.Add(Me.btnAgree)
        Me.Controls.Add(Me.btnDecline)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "License"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDecline As System.Windows.Forms.Button
    Friend WithEvents btnAgree As System.Windows.Forms.Button
    Friend WithEvents txtLicense As System.Windows.Forms.TextBox
End Class
