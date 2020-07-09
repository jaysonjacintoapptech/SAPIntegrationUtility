<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAPInvoice___Outbound
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
        Me.chkAPInvoice = New System.Windows.Forms.CheckBox()
        Me.pbAPInvoice = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "AP Invoice"
        '
        'chkAPInvoice
        '
        Me.chkAPInvoice.AutoSize = True
        Me.chkAPInvoice.Location = New System.Drawing.Point(323, 35)
        Me.chkAPInvoice.Name = "chkAPInvoice"
        Me.chkAPInvoice.Size = New System.Drawing.Size(18, 17)
        Me.chkAPInvoice.TabIndex = 7
        Me.chkAPInvoice.UseVisualStyleBackColor = True
        '
        'pbAPInvoice
        '
        Me.pbAPInvoice.Location = New System.Drawing.Point(11, 35)
        Me.pbAPInvoice.Name = "pbAPInvoice"
        Me.pbAPInvoice.Size = New System.Drawing.Size(306, 23)
        Me.pbAPInvoice.TabIndex = 6
        '
        'frmAPInvoice___Inbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 66)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkAPInvoice)
        Me.Controls.Add(Me.pbAPInvoice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAPInvoice___Inbound"
        Me.Text = "frmAPInvoice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkAPInvoice As CheckBox
    Friend WithEvents pbAPInvoice As ProgressBar
End Class
