Public Class ApplicationConfigurationForm
    Private WithEvents btnModuleSettings As New Button
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

    Private Sub ApplicationConfigurationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SetAPPConfUI()
        Call SetAPPConfTable()

        Try
            btnModuleSettings.BackgroundImage = My.Resources.buttonGradient
            btnModuleSettings.BackgroundImageLayout = ImageLayout.Stretch
            btnModuleSettings.FlatStyle = FlatStyle.Flat
            btnModuleSettings.Text = "Show Module Configuration"
            btnModuleSettings.Height = panelAppConf.Height
            btnModuleSettings.Width = panelAppConf.Width
            btnModuleSettings.Location = New Point((panelAppConf.ClientSize.Width - panelAppConf.Width) \ 2, (panelAppConf.ClientSize.Height - btnModuleSettings.Height) \ 2)
            panelAppConf.Controls.Add(btnModuleSettings)
            btnModuleSettings.Show()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
    Private Sub OpenModuleConfig(sender As Object, e As EventArgs) Handles btnModuleSettings.Click
        ModuleConfiguration.Show()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If rbDIAPI.Checked = True Then
                oRegistry.CreateSubKey("IntegMode", "DI API")
            ElseIf rbServiceLayer.Checked = True Then
                oRegistry.CreateSubKey("IntegMode", "SERVICE LAYER")
            End If
            If GroupBox3.Enabled = True Then

                If rbXML.Checked = True Then
                    oRegistry.CreateSubKey("FileType", "XML")
                ElseIf rbExcel.Checked = True Then
                    oRegistry.CreateSubKey("FileType", "EXCEL")
                ElseIf rbCSV.Checked = True Then
                    oRegistry.CreateSubKey("FileType", "CSV")
                ElseIf rbTABDel.Checked = True Then
                    oRegistry.CreateSubKey("FileType", "TAB DELIMITED")
                End If
            End If
            MsgBox("Successfully Saved!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

End Class