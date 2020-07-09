<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGR___Outbound
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
        Me.chkGR = New System.Windows.Forms.CheckBox()
        Me.pbGR = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Goods Receipt"
        '
        'chkGR
        '
        Me.chkGR.AutoSize = True
        Me.chkGR.Location = New System.Drawing.Point(323, 35)
        Me.chkGR.Name = "chkGR"
        Me.chkGR.Size = New System.Drawing.Size(18, 17)
        Me.chkGR.TabIndex = 28
        Me.chkGR.UseVisualStyleBackColor = True
        '
        'pbGR
        '
        Me.pbGR.Location = New System.Drawing.Point(11, 35)
        Me.pbGR.Name = "pbGR"
        Me.pbGR.Size = New System.Drawing.Size(306, 23)
        Me.pbGR.TabIndex = 27
        '
        'frmGR___Inbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 66)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkGR)
        Me.Controls.Add(Me.pbGR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGR___Inbound"
        Me.Text = "frmGR___Inbound"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkGR As CheckBox
    Friend WithEvents pbGR As ProgressBar
End Class
