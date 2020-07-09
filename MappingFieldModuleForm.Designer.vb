<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MappingFieldModuleForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MappingFieldModuleForm))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.header = New System.Windows.Forms.PictureBox()
        Me.panelField = New System.Windows.Forms.Panel()
        Me.panelFilter = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.header, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitle.Location = New System.Drawing.Point(3, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(123, 19)
        Me.lblTitle.TabIndex = 102
        Me.lblTitle.Text = "Mapping {Module}"
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
        Me.btnclose.Location = New System.Drawing.Point(1107, 9)
        Me.btnclose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(25, 25)
        Me.btnclose.TabIndex = 101
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
        Me.header.Size = New System.Drawing.Size(1136, 46)
        Me.header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.header.TabIndex = 100
        Me.header.TabStop = False
        '
        'panelField
        '
        Me.panelField.Location = New System.Drawing.Point(7, 53)
        Me.panelField.Name = "panelField"
        Me.panelField.Size = New System.Drawing.Size(616, 385)
        Me.panelField.TabIndex = 103
        '
        'panelFilter
        '
        Me.panelFilter.Location = New System.Drawing.Point(629, 53)
        Me.panelFilter.Name = "panelFilter"
        Me.panelFilter.Size = New System.Drawing.Size(503, 385)
        Me.panelFilter.TabIndex = 105
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.SAPIntegrationUtility.My.Resources.Resources.buttonGradient
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(1057, 452)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 30)
        Me.btnSave.TabIndex = 123
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'MappingFieldModuleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 494)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.panelFilter)
        Me.Controls.Add(Me.panelField)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.header)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MappingFieldModuleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MappingFieldModuleForm"
        CType(Me.header, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnclose As Button
    Friend WithEvents header As PictureBox
    Friend WithEvents panelField As Panel
    Friend WithEvents panelFilter As Panel
    Friend WithEvents btnSave As Button
End Class
