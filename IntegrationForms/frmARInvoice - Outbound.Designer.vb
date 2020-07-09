<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmARInvoice___Outbound
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
        Me.chkARInvoice = New System.Windows.Forms.CheckBox()
        Me.pbARInvoice = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "AR Invoice"
        '
        'chkARInvoice
        '
        Me.chkARInvoice.AutoSize = True
        Me.chkARInvoice.Location = New System.Drawing.Point(323, 35)
        Me.chkARInvoice.Name = "chkARInvoice"
        Me.chkARInvoice.Size = New System.Drawing.Size(18, 17)
        Me.chkARInvoice.TabIndex = 19
        Me.chkARInvoice.UseVisualStyleBackColor = True
        '
        'pbARInvoice
        '
        Me.pbARInvoice.Location = New System.Drawing.Point(11, 35)
        Me.pbARInvoice.Name = "pbARInvoice"
        Me.pbARInvoice.Size = New System.Drawing.Size(306, 23)
        Me.pbARInvoice.TabIndex = 18
        '
        'frmARInvoice___Outbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 66)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkARInvoice)
        Me.Controls.Add(Me.pbARInvoice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmARInvoice___Outbound"
        Me.Text = "frmARInvoice___Inbound"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkARInvoice As CheckBox
    Friend WithEvents pbARInvoice As ProgressBar
End Class
