Public Class DBConfigForm
    Private WithEvents btnShowFTPConf As New Button

#Region "Header"
    Dim mousex As Integer
    Dim mousey As Integer
    Dim drag As Boolean
    Private Sub header_MouseDown(sender As Object, e As MouseEventArgs) Handles header.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub header_MouseMove(sender As Object, e As MouseEventArgs) Handles header.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub header_MouseUp(sender As Object, e As MouseEventArgs) Handles header.MouseUp
        drag = False
    End Sub

#End Region
    Private Sub DBConfigForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SetDBConfUI()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub RB_ChangeEvent(sender As Object, e As EventArgs) Handles rbDB.CheckedChanged, rbFile.CheckedChanged
        Dim IntegDBConfig As IntegrationDatabaseConfig = New IntegrationDatabaseConfig()
        Dim IntegFileConfig As IntegrationFileLocationConfig = New IntegrationFileLocationConfig
        panelInteg.Controls.Clear()

        If rbDB.Checked Then
            IntegDBConfig.TopLevel = False
            panelInteg.Controls.Add(IntegDBConfig)
            IntegDBConfig.Show()
        ElseIf rbFile.Checked Then
            btnShowFTPConf.BackgroundImage = My.Resources.buttonGradient
            btnShowFTPConf.BackgroundImageLayout = ImageLayout.Stretch
            btnShowFTPConf.FlatStyle = FlatStyle.Flat
            btnShowFTPConf.Text = "Show FTP Configuration"
            btnShowFTPConf.Height = panelInteg.Height - 50
            btnShowFTPConf.Width = panelInteg.Width - 50
            btnShowFTPConf.Location = New Point((panelInteg.ClientSize.Width - btnShowFTPConf.Width) \ 2, (panelInteg.ClientSize.Height - btnShowFTPConf.Height) \ 2)
            panelInteg.Controls.Add(btnShowFTPConf)
            btnShowFTPConf.Show()
        ElseIf rbAPI.Checked Then
            btnShowFTPConf.BackgroundImage = My.Resources.buttonGradient
            btnShowFTPConf.BackgroundImageLayout = ImageLayout.Stretch
            btnShowFTPConf.FlatStyle = FlatStyle.Flat
            btnShowFTPConf.Text = "Show API Configuration"
            btnShowFTPConf.Height = panelInteg.Height - 50
            btnShowFTPConf.Width = panelInteg.Width - 50
            btnShowFTPConf.Location = New Point((panelInteg.ClientSize.Width - btnShowFTPConf.Width) \ 2, (panelInteg.ClientSize.Height - btnShowFTPConf.Height) \ 2)
            panelInteg.Controls.Add(btnShowFTPConf)
            btnShowFTPConf.Show()
        End If
    End Sub

    Private Sub btnShotFTPConf(sender As Object, e As EventArgs) Handles btnShowFTPConf.Click
        If rbFile.Checked Then
            IntegrationFileLocationConfig.Show()
        ElseIf rbAPI.Checked Then
            IntegrationAPIConfig.Show()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim oSave As New ConfigFunctions
        oSave.SaveConfig()
        oSave.SaveIntegConfig()
    End Sub
End Class