<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIT___Inbound
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
        Me.chkIT = New System.Windows.Forms.CheckBox()
        Me.pbIT = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Inventory Transfer"
        '
        'chkIT
        '
        Me.chkIT.AutoSize = True
        Me.chkIT.Location = New System.Drawing.Point(323, 35)
        Me.chkIT.Name = "chkIT"
        Me.chkIT.Size = New System.Drawing.Size(18, 17)
        Me.chkIT.TabIndex = 25
        Me.chkIT.UseVisualStyleBackColor = True
        '
        'pbIT
        '
        Me.pbIT.Location = New System.Drawing.Point(11, 35)
        Me.pbIT.Name = "pbIT"
        Me.pbIT.Size = New System.Drawing.Size(306, 23)
        Me.pbIT.TabIndex = 24
        '
        'frmIT___Inbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 66)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkIT)
        Me.Controls.Add(Me.pbIT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIT___Inbound"
        Me.Text = "frmIT___Inbound"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkIT As CheckBox
    Friend WithEvents pbIT As ProgressBar
End Class
