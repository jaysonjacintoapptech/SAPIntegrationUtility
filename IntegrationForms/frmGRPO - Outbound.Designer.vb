<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGRPO___Outbound
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkGRPO = New System.Windows.Forms.CheckBox()
        Me.pbGRPO = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Goods Receipt PO"
        '
        'chkGRPO
        '
        Me.chkGRPO.AutoSize = True
        Me.chkGRPO.Location = New System.Drawing.Point(323, 35)
        Me.chkGRPO.Name = "chkGRPO"
        Me.chkGRPO.Size = New System.Drawing.Size(18, 17)
        Me.chkGRPO.TabIndex = 13
        Me.chkGRPO.UseVisualStyleBackColor = True
        '
        'pbGRPO
        '
        Me.pbGRPO.Location = New System.Drawing.Point(11, 35)
        Me.pbGRPO.Name = "pbGRPO"
        Me.pbGRPO.Size = New System.Drawing.Size(306, 23)
        Me.pbGRPO.TabIndex = 12
        '
        'frmGRPO___Inbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 66)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkGRPO)
        Me.Controls.Add(Me.pbGRPO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGRPO___Inbound"
        Me.Text = "frmGRPO___Inbound"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkGRPO As CheckBox
    Friend WithEvents pbGRPO As ProgressBar
End Class
