<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FieldMappingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApplicationConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LsView = New System.Windows.Forms.ListView()
        Me.frmPanelInbound = New System.Windows.Forms.Panel()
        Me.frmPanelOutbound = New System.Windows.Forms.Panel()
        Me.imgIcon = New System.Windows.Forms.PictureBox()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.header = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IntegrationLog = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.imgIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitle.Location = New System.Drawing.Point(106, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(249, 32)
        Me.lblTitle.TabIndex = 91
        Me.lblTitle.Text = "SAP Integration Utility"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 46)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1064, 28)
        Me.MenuStrip1.TabIndex = 112
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseConfigurationToolStripMenuItem, Me.FieldMappingToolStripMenuItem, Me.ApplicationConfigurationToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DatabaseConfigurationToolStripMenuItem
        '
        Me.DatabaseConfigurationToolStripMenuItem.Name = "DatabaseConfigurationToolStripMenuItem"
        Me.DatabaseConfigurationToolStripMenuItem.Size = New System.Drawing.Size(283, 26)
        Me.DatabaseConfigurationToolStripMenuItem.Text = "Database Configuration"
        '
        'FieldMappingToolStripMenuItem
        '
        Me.FieldMappingToolStripMenuItem.Name = "FieldMappingToolStripMenuItem"
        Me.FieldMappingToolStripMenuItem.Size = New System.Drawing.Size(283, 26)
        Me.FieldMappingToolStripMenuItem.Text = "Field Mapping Configuration"
        '
        'ApplicationConfigurationToolStripMenuItem
        '
        Me.ApplicationConfigurationToolStripMenuItem.Name = "ApplicationConfigurationToolStripMenuItem"
        Me.ApplicationConfigurationToolStripMenuItem.Size = New System.Drawing.Size(283, 26)
        Me.ApplicationConfigurationToolStripMenuItem.Text = "Application Configuration"
        '
        'LsView
        '
        Me.LsView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IntegrationLog})
        Me.LsView.Dock = System.Windows.Forms.DockStyle.Right
        Me.LsView.FullRowSelect = True
        Me.LsView.HideSelection = False
        Me.LsView.Location = New System.Drawing.Point(561, 74)
        Me.LsView.Name = "LsView"
        Me.LsView.Size = New System.Drawing.Size(503, 599)
        Me.LsView.TabIndex = 113
        Me.LsView.UseCompatibleStateImageBehavior = False
        Me.LsView.View = System.Windows.Forms.View.Details
        '
        'frmPanelInbound
        '
        Me.frmPanelInbound.AutoScroll = True
        Me.frmPanelInbound.Location = New System.Drawing.Point(11, 101)
        Me.frmPanelInbound.Name = "frmPanelInbound"
        Me.frmPanelInbound.Size = New System.Drawing.Size(543, 249)
        Me.frmPanelInbound.TabIndex = 114
        '
        'frmPanelOutbound
        '
        Me.frmPanelOutbound.AutoScroll = True
        Me.frmPanelOutbound.Location = New System.Drawing.Point(12, 379)
        Me.frmPanelOutbound.Name = "frmPanelOutbound"
        Me.frmPanelOutbound.Size = New System.Drawing.Size(543, 250)
        Me.frmPanelOutbound.TabIndex = 115
        '
        'imgIcon
        '
        Me.imgIcon.BackgroundImage = Global.SAPIntegrationUtility.My.Resources.Resources.APPTech_Logo_Trans
        Me.imgIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgIcon.Location = New System.Drawing.Point(1, 2)
        Me.imgIcon.Name = "imgIcon"
        Me.imgIcon.Size = New System.Drawing.Size(100, 32)
        Me.imgIcon.TabIndex = 119
        Me.imgIcon.TabStop = False
        '
        'btnManual
        '
        Me.btnManual.BackgroundImage = CType(resources.GetObject("btnManual.BackgroundImage"), System.Drawing.Image)
        Me.btnManual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManual.Location = New System.Drawing.Point(479, 635)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(75, 30)
        Me.btnManual.TabIndex = 118
        Me.btnManual.Text = "Manual"
        Me.btnManual.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.BackgroundImage = CType(resources.GetObject("btnStop.BackgroundImage"), System.Drawing.Image)
        Me.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStop.Location = New System.Drawing.Point(398, 635)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 30)
        Me.btnStop.TabIndex = 117
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.BackgroundImage = CType(resources.GetObject("btnStart.BackgroundImage"), System.Drawing.Image)
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Location = New System.Drawing.Point(317, 635)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 30)
        Me.btnStart.TabIndex = 116
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.BackgroundImage = Global.SAPIntegrationUtility.My.Resources.Resources.delete_26px
        Me.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Tahoma", 7.25!)
        Me.btnclose.ForeColor = System.Drawing.Color.Black
        Me.btnclose.Location = New System.Drawing.Point(1033, 10)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(25, 25)
        Me.btnclose.TabIndex = 90
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
        Me.header.Size = New System.Drawing.Size(1064, 46)
        Me.header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.header.TabIndex = 89
        Me.header.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inbound"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Outbound"
        '
        'IntegrationLog
        '
        Me.IntegrationLog.Text = "Integration Log"
        Me.IntegrationLog.Width = 400
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 673)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.imgIcon)
        Me.Controls.Add(Me.btnManual)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.frmPanelInbound)
        Me.Controls.Add(Me.LsView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.frmPanelOutbound)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SAP Integration Utility"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.imgIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.header, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnclose As Button
    Friend WithEvents header As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FieldMappingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApplicationConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LsView As ListView
    Friend WithEvents frmPanelInbound As Panel
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnManual As Button
    Friend WithEvents imgIcon As PictureBox
    Friend WithEvents frmPanelOutbound As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IntegrationLog As ColumnHeader
End Class
