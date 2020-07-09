<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModuleConfiguration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModuleConfiguration))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.header = New System.Windows.Forms.PictureBox()
        Me.lstExcludeInbound = New System.Windows.Forms.ListView()
        Me.lstIncludeInbound = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnIncludeInbound = New System.Windows.Forms.Button()
        Me.btnIncludeALLInbound = New System.Windows.Forms.Button()
        Me.btnExcludeInbound = New System.Windows.Forms.Button()
        Me.btnExcludeALLInbound = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lstExcludeOutbound = New System.Windows.Forms.ListView()
        Me.lstIncludeOutbound = New System.Windows.Forms.ListView()
        Me.btnExcludeAllOutbound = New System.Windows.Forms.Button()
        Me.btnExcludeOutbound = New System.Windows.Forms.Button()
        Me.btnIncludeALLOutbound = New System.Windows.Forms.Button()
        Me.btnIncludeOutbound = New System.Windows.Forms.Button()
        Me.ExcludeInbound = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IncludeInbound = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ExcludeOutbound = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IncludeOutbound = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitle.Location = New System.Drawing.Point(10, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(252, 32)
        Me.lblTitle.TabIndex = 99
        Me.lblTitle.Text = "Module Configuration"
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
        Me.btnclose.Location = New System.Drawing.Point(600, 11)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(25, 25)
        Me.btnclose.TabIndex = 98
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
        Me.header.Size = New System.Drawing.Size(640, 46)
        Me.header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.header.TabIndex = 97
        Me.header.TabStop = False
        '
        'lstExcludeInbound
        '
        Me.lstExcludeInbound.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ExcludeInbound})
        Me.lstExcludeInbound.FullRowSelect = True
        Me.lstExcludeInbound.HideSelection = False
        Me.lstExcludeInbound.Location = New System.Drawing.Point(16, 89)
        Me.lstExcludeInbound.MultiSelect = False
        Me.lstExcludeInbound.Name = "lstExcludeInbound"
        Me.lstExcludeInbound.Size = New System.Drawing.Size(278, 299)
        Me.lstExcludeInbound.TabIndex = 100
        Me.lstExcludeInbound.UseCompatibleStateImageBehavior = False
        Me.lstExcludeInbound.View = System.Windows.Forms.View.Details
        '
        'lstIncludeInbound
        '
        Me.lstIncludeInbound.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IncludeInbound})
        Me.lstIncludeInbound.FullRowSelect = True
        Me.lstIncludeInbound.HideSelection = False
        Me.lstIncludeInbound.Location = New System.Drawing.Point(347, 89)
        Me.lstIncludeInbound.MultiSelect = False
        Me.lstIncludeInbound.Name = "lstIncludeInbound"
        Me.lstIncludeInbound.Size = New System.Drawing.Size(278, 299)
        Me.lstIncludeInbound.TabIndex = 101
        Me.lstIncludeInbound.UseCompatibleStateImageBehavior = False
        Me.lstIncludeInbound.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 23)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Excluded"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(344, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 23)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "Included"
        '
        'btnIncludeInbound
        '
        Me.btnIncludeInbound.BackgroundImage = Global.SAPIntegrationUtility.My.Resources.Resources.buttonGradient
        Me.btnIncludeInbound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIncludeInbound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncludeInbound.Location = New System.Drawing.Point(299, 169)
        Me.btnIncludeInbound.Margin = New System.Windows.Forms.Padding(0)
        Me.btnIncludeInbound.Name = "btnIncludeInbound"
        Me.btnIncludeInbound.Size = New System.Drawing.Size(40, 25)
        Me.btnIncludeInbound.TabIndex = 104
        Me.btnIncludeInbound.Text = ">"
        Me.btnIncludeInbound.UseVisualStyleBackColor = True
        '
        'btnIncludeALLInbound
        '
        Me.btnIncludeALLInbound.BackgroundImage = CType(resources.GetObject("btnIncludeALLInbound.BackgroundImage"), System.Drawing.Image)
        Me.btnIncludeALLInbound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIncludeALLInbound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncludeALLInbound.Location = New System.Drawing.Point(299, 198)
        Me.btnIncludeALLInbound.Margin = New System.Windows.Forms.Padding(0)
        Me.btnIncludeALLInbound.Name = "btnIncludeALLInbound"
        Me.btnIncludeALLInbound.Size = New System.Drawing.Size(40, 25)
        Me.btnIncludeALLInbound.TabIndex = 105
        Me.btnIncludeALLInbound.Text = ">>"
        Me.btnIncludeALLInbound.UseVisualStyleBackColor = True
        '
        'btnExcludeInbound
        '
        Me.btnExcludeInbound.BackgroundImage = CType(resources.GetObject("btnExcludeInbound.BackgroundImage"), System.Drawing.Image)
        Me.btnExcludeInbound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcludeInbound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcludeInbound.Location = New System.Drawing.Point(299, 227)
        Me.btnExcludeInbound.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcludeInbound.Name = "btnExcludeInbound"
        Me.btnExcludeInbound.Size = New System.Drawing.Size(40, 25)
        Me.btnExcludeInbound.TabIndex = 106
        Me.btnExcludeInbound.Text = "<"
        Me.btnExcludeInbound.UseVisualStyleBackColor = True
        '
        'btnExcludeALLInbound
        '
        Me.btnExcludeALLInbound.BackgroundImage = CType(resources.GetObject("btnExcludeALLInbound.BackgroundImage"), System.Drawing.Image)
        Me.btnExcludeALLInbound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcludeALLInbound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcludeALLInbound.Location = New System.Drawing.Point(299, 256)
        Me.btnExcludeALLInbound.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcludeALLInbound.Name = "btnExcludeALLInbound"
        Me.btnExcludeALLInbound.Size = New System.Drawing.Size(40, 25)
        Me.btnExcludeALLInbound.TabIndex = 107
        Me.btnExcludeALLInbound.Text = "<<"
        Me.btnExcludeALLInbound.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.SAPIntegrationUtility.My.Resources.Resources.buttonGradient
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(550, 786)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 122
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lstExcludeOutbound
        '
        Me.lstExcludeOutbound.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ExcludeOutbound})
        Me.lstExcludeOutbound.FullRowSelect = True
        Me.lstExcludeOutbound.HideSelection = False
        Me.lstExcludeOutbound.Location = New System.Drawing.Point(16, 419)
        Me.lstExcludeOutbound.MultiSelect = False
        Me.lstExcludeOutbound.Name = "lstExcludeOutbound"
        Me.lstExcludeOutbound.Size = New System.Drawing.Size(278, 299)
        Me.lstExcludeOutbound.TabIndex = 123
        Me.lstExcludeOutbound.UseCompatibleStateImageBehavior = False
        Me.lstExcludeOutbound.View = System.Windows.Forms.View.Details
        '
        'lstIncludeOutbound
        '
        Me.lstIncludeOutbound.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IncludeOutbound})
        Me.lstIncludeOutbound.FullRowSelect = True
        Me.lstIncludeOutbound.HideSelection = False
        Me.lstIncludeOutbound.Location = New System.Drawing.Point(347, 423)
        Me.lstIncludeOutbound.MultiSelect = False
        Me.lstIncludeOutbound.Name = "lstIncludeOutbound"
        Me.lstIncludeOutbound.Size = New System.Drawing.Size(278, 299)
        Me.lstIncludeOutbound.TabIndex = 124
        Me.lstIncludeOutbound.UseCompatibleStateImageBehavior = False
        Me.lstIncludeOutbound.View = System.Windows.Forms.View.Details
        '
        'btnExcludeAllOutbound
        '
        Me.btnExcludeAllOutbound.BackgroundImage = CType(resources.GetObject("btnExcludeAllOutbound.BackgroundImage"), System.Drawing.Image)
        Me.btnExcludeAllOutbound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcludeAllOutbound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcludeAllOutbound.Location = New System.Drawing.Point(299, 589)
        Me.btnExcludeAllOutbound.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcludeAllOutbound.Name = "btnExcludeAllOutbound"
        Me.btnExcludeAllOutbound.Size = New System.Drawing.Size(40, 25)
        Me.btnExcludeAllOutbound.TabIndex = 128
        Me.btnExcludeAllOutbound.Text = "<<"
        Me.btnExcludeAllOutbound.UseVisualStyleBackColor = True
        '
        'btnExcludeOutbound
        '
        Me.btnExcludeOutbound.BackgroundImage = CType(resources.GetObject("btnExcludeOutbound.BackgroundImage"), System.Drawing.Image)
        Me.btnExcludeOutbound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcludeOutbound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcludeOutbound.Location = New System.Drawing.Point(299, 560)
        Me.btnExcludeOutbound.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExcludeOutbound.Name = "btnExcludeOutbound"
        Me.btnExcludeOutbound.Size = New System.Drawing.Size(40, 25)
        Me.btnExcludeOutbound.TabIndex = 127
        Me.btnExcludeOutbound.Text = "<"
        Me.btnExcludeOutbound.UseVisualStyleBackColor = True
        '
        'btnIncludeALLOutbound
        '
        Me.btnIncludeALLOutbound.BackgroundImage = CType(resources.GetObject("btnIncludeALLOutbound.BackgroundImage"), System.Drawing.Image)
        Me.btnIncludeALLOutbound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIncludeALLOutbound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncludeALLOutbound.Location = New System.Drawing.Point(299, 531)
        Me.btnIncludeALLOutbound.Margin = New System.Windows.Forms.Padding(0)
        Me.btnIncludeALLOutbound.Name = "btnIncludeALLOutbound"
        Me.btnIncludeALLOutbound.Size = New System.Drawing.Size(40, 25)
        Me.btnIncludeALLOutbound.TabIndex = 126
        Me.btnIncludeALLOutbound.Text = ">>"
        Me.btnIncludeALLOutbound.UseVisualStyleBackColor = True
        '
        'btnIncludeOutbound
        '
        Me.btnIncludeOutbound.BackgroundImage = Global.SAPIntegrationUtility.My.Resources.Resources.buttonGradient
        Me.btnIncludeOutbound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIncludeOutbound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncludeOutbound.Location = New System.Drawing.Point(299, 502)
        Me.btnIncludeOutbound.Margin = New System.Windows.Forms.Padding(0)
        Me.btnIncludeOutbound.Name = "btnIncludeOutbound"
        Me.btnIncludeOutbound.Size = New System.Drawing.Size(40, 25)
        Me.btnIncludeOutbound.TabIndex = 125
        Me.btnIncludeOutbound.Text = ">"
        Me.btnIncludeOutbound.UseVisualStyleBackColor = True
        '
        'ExcludeInbound
        '
        Me.ExcludeInbound.Text = "Exclude Inbound"
        Me.ExcludeInbound.Width = 180
        '
        'IncludeInbound
        '
        Me.IncludeInbound.Text = "Include Inbound"
        Me.IncludeInbound.Width = 180
        '
        'ExcludeOutbound
        '
        Me.ExcludeOutbound.Text = "Exclude Outbound"
        Me.ExcludeOutbound.Width = 180
        '
        'IncludeOutbound
        '
        Me.IncludeOutbound.Text = "Include Outbound"
        Me.IncludeOutbound.Width = 180
        '
        'ModuleConfiguration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 828)
        Me.Controls.Add(Me.btnExcludeAllOutbound)
        Me.Controls.Add(Me.btnExcludeOutbound)
        Me.Controls.Add(Me.btnIncludeALLOutbound)
        Me.Controls.Add(Me.btnIncludeOutbound)
        Me.Controls.Add(Me.lstIncludeOutbound)
        Me.Controls.Add(Me.lstExcludeOutbound)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExcludeALLInbound)
        Me.Controls.Add(Me.btnExcludeInbound)
        Me.Controls.Add(Me.btnIncludeALLInbound)
        Me.Controls.Add(Me.btnIncludeInbound)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstIncludeInbound)
        Me.Controls.Add(Me.lstExcludeInbound)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModuleConfiguration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModuleConfiguration"
        CType(Me.header, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnclose As Button
    Friend WithEvents header As PictureBox
    Friend WithEvents lstExcludeInbound As ListView
    Friend WithEvents lstIncludeInbound As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnIncludeInbound As Button
    Friend WithEvents btnIncludeALLInbound As Button
    Friend WithEvents btnExcludeInbound As Button
    Friend WithEvents btnExcludeALLInbound As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lstExcludeOutbound As ListView
    Friend WithEvents lstIncludeOutbound As ListView
    Friend WithEvents btnExcludeAllOutbound As Button
    Friend WithEvents btnExcludeOutbound As Button
    Friend WithEvents btnIncludeALLOutbound As Button
    Friend WithEvents btnIncludeOutbound As Button
    Friend WithEvents ExcludeInbound As ColumnHeader
    Friend WithEvents IncludeInbound As ColumnHeader
    Friend WithEvents ExcludeOutbound As ColumnHeader
    Friend WithEvents IncludeOutbound As ColumnHeader
End Class
