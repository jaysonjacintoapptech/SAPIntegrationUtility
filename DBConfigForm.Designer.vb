<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBConfigForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DBConfigForm))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ConfLog = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbAPI = New System.Windows.Forms.RadioButton()
        Me.rbFile = New System.Windows.Forms.RadioButton()
        Me.rbDB = New System.Windows.Forms.RadioButton()
        Me.panelInteg = New System.Windows.Forms.Panel()
        Me.panelSAP = New System.Windows.Forms.Panel()
        Me.txtSAPPass = New System.Windows.Forms.TextBox()
        Me.txtSAPUser = New System.Windows.Forms.TextBox()
        Me.txtLicSer = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtDB = New System.Windows.Forms.TextBox()
        Me.txtServerName = New System.Windows.Forms.TextBox()
        Me.cbServerType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.header = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.panelSAP.SuspendLayout()
        CType(Me.header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitle.Location = New System.Drawing.Point(7, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(267, 32)
        Me.lblTitle.TabIndex = 93
        Me.lblTitle.Text = "Database Configuration"
        '
        'ConfLog
        '
        Me.ConfLog.FullRowSelect = True
        Me.ConfLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ConfLog.HideSelection = False
        Me.ConfLog.Location = New System.Drawing.Point(441, 53)
        Me.ConfLog.Name = "ConfLog"
        Me.ConfLog.Size = New System.Drawing.Size(380, 421)
        Me.ConfLog.TabIndex = 118
        Me.ConfLog.UseCompatibleStateImageBehavior = False
        Me.ConfLog.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbAPI)
        Me.GroupBox1.Controls.Add(Me.rbFile)
        Me.GroupBox1.Controls.Add(Me.rbDB)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 49)
        Me.GroupBox1.TabIndex = 119
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Integration Type"
        '
        'rbAPI
        '
        Me.rbAPI.AutoSize = True
        Me.rbAPI.Location = New System.Drawing.Point(301, 22)
        Me.rbAPI.Name = "rbAPI"
        Me.rbAPI.Size = New System.Drawing.Size(121, 21)
        Me.rbAPI.TabIndex = 123
        Me.rbAPI.Text = "API Integration"
        Me.rbAPI.UseVisualStyleBackColor = True
        '
        'rbFile
        '
        Me.rbFile.AutoSize = True
        Me.rbFile.Location = New System.Drawing.Point(173, 22)
        Me.rbFile.Name = "rbFile"
        Me.rbFile.Size = New System.Drawing.Size(122, 21)
        Me.rbFile.TabIndex = 122
        Me.rbFile.Text = "File Integration"
        Me.rbFile.UseVisualStyleBackColor = True
        '
        'rbDB
        '
        Me.rbDB.AutoSize = True
        Me.rbDB.Checked = True
        Me.rbDB.Location = New System.Drawing.Point(6, 22)
        Me.rbDB.Name = "rbDB"
        Me.rbDB.Size = New System.Drawing.Size(161, 21)
        Me.rbDB.TabIndex = 120
        Me.rbDB.TabStop = True
        Me.rbDB.Text = "Database Integration"
        Me.rbDB.UseVisualStyleBackColor = True
        '
        'panelInteg
        '
        Me.panelInteg.Location = New System.Drawing.Point(0, 317)
        Me.panelInteg.Name = "panelInteg"
        Me.panelInteg.Size = New System.Drawing.Size(435, 122)
        Me.panelInteg.TabIndex = 120
        '
        'panelSAP
        '
        Me.panelSAP.Controls.Add(Me.txtSAPPass)
        Me.panelSAP.Controls.Add(Me.txtSAPUser)
        Me.panelSAP.Controls.Add(Me.txtLicSer)
        Me.panelSAP.Controls.Add(Me.txtPass)
        Me.panelSAP.Controls.Add(Me.txtUser)
        Me.panelSAP.Controls.Add(Me.txtDB)
        Me.panelSAP.Controls.Add(Me.txtServerName)
        Me.panelSAP.Controls.Add(Me.cbServerType)
        Me.panelSAP.Controls.Add(Me.Label8)
        Me.panelSAP.Controls.Add(Me.Label7)
        Me.panelSAP.Controls.Add(Me.Label6)
        Me.panelSAP.Controls.Add(Me.Label5)
        Me.panelSAP.Controls.Add(Me.Label4)
        Me.panelSAP.Controls.Add(Me.Label3)
        Me.panelSAP.Controls.Add(Me.Label2)
        Me.panelSAP.Controls.Add(Me.Label1)
        Me.panelSAP.Location = New System.Drawing.Point(0, 103)
        Me.panelSAP.Name = "panelSAP"
        Me.panelSAP.Size = New System.Drawing.Size(435, 208)
        Me.panelSAP.TabIndex = 121
        '
        'txtSAPPass
        '
        Me.txtSAPPass.Location = New System.Drawing.Point(138, 177)
        Me.txtSAPPass.Name = "txtSAPPass"
        Me.txtSAPPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSAPPass.Size = New System.Drawing.Size(294, 22)
        Me.txtSAPPass.TabIndex = 137
        '
        'txtSAPUser
        '
        Me.txtSAPUser.Location = New System.Drawing.Point(138, 152)
        Me.txtSAPUser.Name = "txtSAPUser"
        Me.txtSAPUser.Size = New System.Drawing.Size(294, 22)
        Me.txtSAPUser.TabIndex = 136
        '
        'txtLicSer
        '
        Me.txtLicSer.Location = New System.Drawing.Point(138, 126)
        Me.txtLicSer.Name = "txtLicSer"
        Me.txtLicSer.Size = New System.Drawing.Size(294, 22)
        Me.txtLicSer.TabIndex = 135
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(138, 102)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(294, 22)
        Me.txtPass.TabIndex = 134
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(138, 78)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(294, 22)
        Me.txtUser.TabIndex = 133
        '
        'txtDB
        '
        Me.txtDB.Location = New System.Drawing.Point(138, 53)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(294, 22)
        Me.txtDB.TabIndex = 132
        '
        'txtServerName
        '
        Me.txtServerName.Location = New System.Drawing.Point(138, 29)
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(294, 22)
        Me.txtServerName.TabIndex = 131
        '
        'cbServerType
        '
        Me.cbServerType.FormattingEnabled = True
        Me.cbServerType.Location = New System.Drawing.Point(138, 3)
        Me.cbServerType.Name = "cbServerType"
        Me.cbServerType.Size = New System.Drawing.Size(294, 24)
        Me.cbServerType.TabIndex = 130
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 17)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "SAP Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "SAP User"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 17)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "License Server"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 17)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 17)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "UserName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Database Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Server Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Server Type"
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(360, 444)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 117
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.BackgroundImage = CType(resources.GetObject("btnclose.BackgroundImage"), System.Drawing.Image)
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Tahoma", 7.25!)
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.Location = New System.Drawing.Point(796, 11)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(25, 25)
        Me.btnclose.TabIndex = 92
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.Transparent
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Image = CType(resources.GetObject("header.Image"), System.Drawing.Image)
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Margin = New System.Windows.Forms.Padding(4)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(833, 46)
        Me.header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.header.TabIndex = 90
        Me.header.TabStop = False
        '
        'DBConfigForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 487)
        Me.Controls.Add(Me.panelSAP)
        Me.Controls.Add(Me.panelInteg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ConfLog)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DBConfigForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Configuration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panelSAP.ResumeLayout(False)
        Me.panelSAP.PerformLayout()
        CType(Me.header, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents header As PictureBox
    Friend WithEvents btnclose As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents ConfLog As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbFile As RadioButton
    Friend WithEvents rbDB As RadioButton
    Friend WithEvents panelInteg As Panel
    Friend WithEvents panelSAP As Panel
    Friend WithEvents txtSAPPass As TextBox
    Friend WithEvents txtSAPUser As TextBox
    Friend WithEvents txtLicSer As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtDB As TextBox
    Friend WithEvents txtServerName As TextBox
    Friend WithEvents cbServerType As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbAPI As RadioButton
End Class
