<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPO___Outbound
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
        Me.chkPO = New System.Windows.Forms.CheckBox()
        Me.pbPO = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Purchase Order"
        '
        'chkPO
        '
        Me.chkPO.AutoSize = True
        Me.chkPO.Location = New System.Drawing.Point(323, 35)
        Me.chkPO.Name = "chkPO"
        Me.chkPO.Size = New System.Drawing.Size(18, 17)
        Me.chkPO.TabIndex = 13
        Me.chkPO.UseVisualStyleBackColor = True
        '
        'pbPO
        '
        Me.pbPO.Location = New System.Drawing.Point(11, 35)
        Me.pbPO.Name = "pbPO"
        Me.pbPO.Size = New System.Drawing.Size(306, 23)
        Me.pbPO.TabIndex = 12
        '
        'frmPO___Inbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 66)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkPO)
        Me.Controls.Add(Me.pbPO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPO___Inbound"
        Me.Text = "frmPO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkPO As CheckBox
    Friend WithEvents pbPO As ProgressBar
End Class
