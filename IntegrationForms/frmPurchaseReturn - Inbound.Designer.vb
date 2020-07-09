<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseReturn___Inbound
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
        Me.chkPurchaseReturn = New System.Windows.Forms.CheckBox()
        Me.pbPurchaseReturn = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Purchase Return"
        '
        'chkPurchaseReturn
        '
        Me.chkPurchaseReturn.AutoSize = True
        Me.chkPurchaseReturn.Location = New System.Drawing.Point(323, 35)
        Me.chkPurchaseReturn.Name = "chkPurchaseReturn"
        Me.chkPurchaseReturn.Size = New System.Drawing.Size(18, 17)
        Me.chkPurchaseReturn.TabIndex = 16
        Me.chkPurchaseReturn.UseVisualStyleBackColor = True
        '
        'pbPurchaseReturn
        '
        Me.pbPurchaseReturn.Location = New System.Drawing.Point(11, 35)
        Me.pbPurchaseReturn.Name = "pbPurchaseReturn"
        Me.pbPurchaseReturn.Size = New System.Drawing.Size(306, 23)
        Me.pbPurchaseReturn.TabIndex = 15
        '
        'frmPurchaseReturn___Inbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 66)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkPurchaseReturn)
        Me.Controls.Add(Me.pbPurchaseReturn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPurchaseReturn___Inbound"
        Me.Text = "frmPurchaseReturn___Inbound"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkPurchaseReturn As CheckBox
    Friend WithEvents pbPurchaseReturn As ProgressBar
End Class
