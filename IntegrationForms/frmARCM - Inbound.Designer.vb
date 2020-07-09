<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmARCM___Inbound
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
        Me.chkARCM = New System.Windows.Forms.CheckBox()
        Me.pbARCM = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "AR Credit Memo"
        '
        'chkARCM
        '
        Me.chkARCM.AutoSize = True
        Me.chkARCM.Location = New System.Drawing.Point(323, 35)
        Me.chkARCM.Name = "chkARCM"
        Me.chkARCM.Size = New System.Drawing.Size(18, 17)
        Me.chkARCM.TabIndex = 4
        Me.chkARCM.UseVisualStyleBackColor = True
        '
        'pbARCM
        '
        Me.pbARCM.Location = New System.Drawing.Point(11, 35)
        Me.pbARCM.Name = "pbARCM"
        Me.pbARCM.Size = New System.Drawing.Size(306, 23)
        Me.pbARCM.TabIndex = 3
        '
        'frmARCM___Inbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 66)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkARCM)
        Me.Controls.Add(Me.pbARCM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmARCM___Inbound"
        Me.Text = "frmARCM___Inbound"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkARCM As CheckBox
    Friend WithEvents pbARCM As ProgressBar
End Class
