<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ApplicationConfigurationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ApplicationConfigurationForm))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbServiceLayer = New System.Windows.Forms.RadioButton()
        Me.rbDIAPI = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbTABDel = New System.Windows.Forms.RadioButton()
        Me.rbCSV = New System.Windows.Forms.RadioButton()
        Me.rbExcel = New System.Windows.Forms.RadioButton()
        Me.rbXML = New System.Windows.Forms.RadioButton()
        Me.panelAppConf = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.header = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitle.Location = New System.Drawing.Point(12, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(289, 32)
        Me.lblTitle.TabIndex = 96
        Me.lblTitle.Text = "Application Configuration"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbServiceLayer)
        Me.GroupBox2.Controls.Add(Me.rbDIAPI)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(242, 60)
        Me.GroupBox2.TabIndex = 98
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Integration Mode"
        '
        'rbServiceLayer
        '
        Me.rbServiceLayer.AutoSize = True
        Me.rbServiceLayer.Location = New System.Drawing.Point(79, 21)
        Me.rbServiceLayer.Name = "rbServiceLayer"
        Me.rbServiceLayer.Size = New System.Drawing.Size(158, 21)
        Me.rbServiceLayer.TabIndex = 3
        Me.rbServiceLayer.Text = "HANA Service Layer"
        Me.rbServiceLayer.UseVisualStyleBackColor = True
        '
        'rbDIAPI
        '
        Me.rbDIAPI.AutoSize = True
        Me.rbDIAPI.Checked = True
        Me.rbDIAPI.Location = New System.Drawing.Point(6, 21)
        Me.rbDIAPI.Name = "rbDIAPI"
        Me.rbDIAPI.Size = New System.Drawing.Size(67, 21)
        Me.rbDIAPI.TabIndex = 2
        Me.rbDIAPI.TabStop = True
        Me.rbDIAPI.Text = "DI API"
        Me.rbDIAPI.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbTABDel)
        Me.GroupBox3.Controls.Add(Me.rbCSV)
        Me.GroupBox3.Controls.Add(Me.rbExcel)
        Me.GroupBox3.Controls.Add(Me.rbXML)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 56)
        Me.GroupBox3.TabIndex = 123
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "File Type"
        '
        'rbTABDel
        '
        Me.rbTABDel.AutoSize = True
        Me.rbTABDel.Location = New System.Drawing.Point(210, 21)
        Me.rbTABDel.Name = "rbTABDel"
        Me.rbTABDel.Size = New System.Drawing.Size(132, 21)
        Me.rbTABDel.TabIndex = 3
        Me.rbTABDel.Text = "TAB DELIMITED"
        Me.rbTABDel.UseVisualStyleBackColor = True
        '
        'rbCSV
        '
        Me.rbCSV.AutoSize = True
        Me.rbCSV.Location = New System.Drawing.Point(148, 21)
        Me.rbCSV.Name = "rbCSV"
        Me.rbCSV.Size = New System.Drawing.Size(56, 21)
        Me.rbCSV.TabIndex = 2
        Me.rbCSV.Text = "CSV"
        Me.rbCSV.UseVisualStyleBackColor = True
        '
        'rbExcel
        '
        Me.rbExcel.AutoSize = True
        Me.rbExcel.Location = New System.Drawing.Point(69, 21)
        Me.rbExcel.Name = "rbExcel"
        Me.rbExcel.Size = New System.Drawing.Size(73, 21)
        Me.rbExcel.TabIndex = 1
        Me.rbExcel.Text = "EXCEL"
        Me.rbExcel.UseVisualStyleBackColor = True
        '
        'rbXML
        '
        Me.rbXML.AutoSize = True
        Me.rbXML.Checked = True
        Me.rbXML.Location = New System.Drawing.Point(6, 21)
        Me.rbXML.Name = "rbXML"
        Me.rbXML.Size = New System.Drawing.Size(57, 21)
        Me.rbXML.TabIndex = 0
        Me.rbXML.TabStop = True
        Me.rbXML.Text = "XML"
        Me.rbXML.UseVisualStyleBackColor = True
        '
        'panelAppConf
        '
        Me.panelAppConf.Location = New System.Drawing.Point(12, 182)
        Me.panelAppConf.Name = "panelAppConf"
        Me.panelAppConf.Size = New System.Drawing.Size(352, 70)
        Me.panelAppConf.TabIndex = 124
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(422, 279)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 122
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
        Me.btnclose.Location = New System.Drawing.Point(472, 12)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(25, 25)
        Me.btnclose.TabIndex = 95
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
        Me.header.Size = New System.Drawing.Size(505, 46)
        Me.header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.header.TabIndex = 94
        Me.header.TabStop = False
        '
        'ApplicationConfigurationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 321)
        Me.Controls.Add(Me.panelAppConf)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ApplicationConfigurationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ApplicationConfigurationForm"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.header, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnclose As Button
    Friend WithEvents header As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbServiceLayer As RadioButton
    Friend WithEvents rbDIAPI As RadioButton
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rbTABDel As RadioButton
    Friend WithEvents rbCSV As RadioButton
    Friend WithEvents rbExcel As RadioButton
    Friend WithEvents rbXML As RadioButton
    Friend WithEvents panelAppConf As Panel
End Class
