<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntegrationDatabaseConfig
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIntegDB = New System.Windows.Forms.TextBox()
        Me.txtIntegUser = New System.Windows.Forms.TextBox()
        Me.txtIntegPass = New System.Windows.Forms.TextBox()
        Me.txtIntegServer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Integration Database"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Integration Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Integration Password"
        '
        'txtIntegDB
        '
        Me.txtIntegDB.Location = New System.Drawing.Point(158, 29)
        Me.txtIntegDB.Name = "txtIntegDB"
        Me.txtIntegDB.Size = New System.Drawing.Size(145, 22)
        Me.txtIntegDB.TabIndex = 3
        '
        'txtIntegUser
        '
        Me.txtIntegUser.Location = New System.Drawing.Point(158, 56)
        Me.txtIntegUser.Name = "txtIntegUser"
        Me.txtIntegUser.Size = New System.Drawing.Size(145, 22)
        Me.txtIntegUser.TabIndex = 4
        '
        'txtIntegPass
        '
        Me.txtIntegPass.Location = New System.Drawing.Point(158, 84)
        Me.txtIntegPass.Name = "txtIntegPass"
        Me.txtIntegPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtIntegPass.Size = New System.Drawing.Size(145, 22)
        Me.txtIntegPass.TabIndex = 5
        '
        'txtIntegServer
        '
        Me.txtIntegServer.Location = New System.Drawing.Point(158, 3)
        Me.txtIntegServer.Name = "txtIntegServer"
        Me.txtIntegServer.Size = New System.Drawing.Size(145, 22)
        Me.txtIntegServer.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Integration Server"
        '
        'IntegrationDatabaseConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 112)
        Me.Controls.Add(Me.txtIntegServer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIntegPass)
        Me.Controls.Add(Me.txtIntegUser)
        Me.Controls.Add(Me.txtIntegDB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "IntegrationDatabaseConfig"
        Me.Text = "IntegrationDatabaseConfig"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIntegDB As TextBox
    Friend WithEvents txtIntegUser As TextBox
    Friend WithEvents txtIntegPass As TextBox
    Friend WithEvents txtIntegServer As TextBox
    Friend WithEvents Label4 As Label
End Class
