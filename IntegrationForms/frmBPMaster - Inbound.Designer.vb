<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBPMaster___Inbound
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
        Me.chkBPMaster = New System.Windows.Forms.CheckBox()
        Me.pbBPMaster = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "BP Master Data"
        '
        'chkBPMaster
        '
        Me.chkBPMaster.AutoSize = True
        Me.chkBPMaster.Location = New System.Drawing.Point(324, 37)
        Me.chkBPMaster.Name = "chkBPMaster"
        Me.chkBPMaster.Size = New System.Drawing.Size(18, 17)
        Me.chkBPMaster.TabIndex = 4
        Me.chkBPMaster.UseVisualStyleBackColor = True
        '
        'pbBPMaster
        '
        Me.pbBPMaster.Location = New System.Drawing.Point(12, 37)
        Me.pbBPMaster.Name = "pbBPMaster"
        Me.pbBPMaster.Size = New System.Drawing.Size(306, 23)
        Me.pbBPMaster.TabIndex = 3
        '
        'frmBPMaster___Inbound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 66)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkBPMaster)
        Me.Controls.Add(Me.pbBPMaster)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBPMaster___Inbound"
        Me.Tag = "BP Master Data"
        Me.Text = "frmBPMaster"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkBPMaster As CheckBox
    Friend WithEvents pbBPMaster As ProgressBar
End Class
