﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBOM___Inbound
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkBOM = New System.Windows.Forms.CheckBox()
        Me.pbBOM = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Bill of Materials"
        '
        'chkBOM
        '
        Me.chkBOM.AutoSize = True
        Me.chkBOM.Location = New System.Drawing.Point(323, 35)
        Me.chkBOM.Name = "chkBOM"
        Me.chkBOM.Size = New System.Drawing.Size(18, 17)
        Me.chkBOM.TabIndex = 7
        Me.chkBOM.UseVisualStyleBackColor = True
        '
        'pbBOM
        '
        Me.pbBOM.Location = New System.Drawing.Point(11, 35)
        Me.pbBOM.Name = "pbBOM"
        Me.pbBOM.Size = New System.Drawing.Size(306, 23)
        Me.pbBOM.TabIndex = 6
        '
        'frmBOM___Inbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 66)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkBOM)
        Me.Controls.Add(Me.pbBOM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBOM___Inbound"
        Me.Text = "frmBOM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkBOM As CheckBox
    Friend WithEvents pbBOM As ProgressBar
End Class
