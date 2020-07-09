<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemMasterData___Outbound
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
        Me.pbItemMasterOutbound = New System.Windows.Forms.ProgressBar()
        Me.chkItemMaster = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'pbItemMasterOutbound
        '
        Me.pbItemMasterOutbound.Location = New System.Drawing.Point(11, 31)
        Me.pbItemMasterOutbound.Name = "pbItemMasterOutbound"
        Me.pbItemMasterOutbound.Size = New System.Drawing.Size(306, 23)
        Me.pbItemMasterOutbound.TabIndex = 0
        '
        'chkItemMaster
        '
        Me.chkItemMaster.AutoSize = True
        Me.chkItemMaster.Location = New System.Drawing.Point(323, 31)
        Me.chkItemMaster.Name = "chkItemMaster"
        Me.chkItemMaster.Size = New System.Drawing.Size(18, 17)
        Me.chkItemMaster.TabIndex = 1
        Me.chkItemMaster.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Item Master Data"
        '
        'frmItemMasterData___Outbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 66)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkItemMaster)
        Me.Controls.Add(Me.pbItemMasterOutbound)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmItemMasterData___Outbound"
        Me.Tag = "Item Master Data"
        Me.Text = "frmItemMasterData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbItemMasterOutbound As ProgressBar
    Friend WithEvents chkItemMaster As CheckBox
    Friend WithEvents Label1 As Label
End Class
