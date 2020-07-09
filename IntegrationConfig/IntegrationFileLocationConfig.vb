Public Class IntegrationFileLocationConfig
    Private WithEvents openDialog As FolderBrowserDialog
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
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub IntegrationFileLocationConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SetFileConfUI()
        Call BTNAddressOf()
        If Not CreateAndLoadTable() Then
            MsgBox("Unable to create table! Must set first database configuration.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Internal Error")
        End If
    End Sub
    Private Sub browserDialog(ByVal id_ As String)
        Try
            openDialog = New FolderBrowserDialog

            If openDialog.ShowDialog <> DialogResult.OK Then Return
            For Each p As Control In Controls
                If TypeOf p Is TextBox Then
                    If p.Tag = id_ Then
                        p.Text = openDialog.SelectedPath
                    End If
                End If
            Next

        Catch ex As Exception

        End Try
    End Sub
    Private Sub BTNAddressOf()
        Try
            Dim btn As Button = Nothing
            For Each oControl As Control In Controls
                If TypeOf oControl Is Button Then
                    If Not oControl.Tag = "" Then
                        btn = DirectCast(oControl, Button)
                        AddHandler btn.Click, AddressOf btn_Click
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            For Each p As Control In Controls

                If p.GetType() = GetType(TextBox) Then

                    If oRegistry.GetKeyValue("ServerType") = 9 Then
                        Dim oDotNet As New APP_HANADb(oRegistry.GetKeyValue("ServerName"), oRegistry.GetKeyValue("UserName"), AppTech.Decrypt(oRegistry.GetKeyValue("Password")), oRegistry.GetKeyValue("Database"))
                        oDotNet.strCommand = "SELECT * FROM ""APP_Integration"".""APP_Path"" Where ""Code"" ='" & p.Tag & "'"
                        If oDotNet.Ds.Tables(0).Rows.Count = 0 Then
                            oDotNet.strCommand = "INSERT INTO ""APP_Integration"".""APP_Path"" VALUES('" & p.Tag & "','" & p.Name & "','" & p.AccessibleName & "','" & IIf(Strings.Left(p.Tag, 1) = "1", "Inbound", "Outbound") & "',CURRENT_DATE(),'" & p.Text & "',CURRENT_TIMESTAMP(),'" & oRegistry.GetKeyValue("SAPUser") & "',CURRENT_TIMESTAMP(),'" & oRegistry.GetKeyValue("SAPUser") & "')"
                        Else
                            oDotNet.strCommand = "UPDATE ""APP_Integration"".""APP_Path"" SET ""Name""='" & p.Name & "',""DocType""='" & p.AccessibleName & "',""Path""='" & p.Text & "',""UpdateDate""=CURRENT_TIMESTAMP(),""UpdatedBy""='" & oRegistry.GetKeyValue("SAPUser") & "' Where ""Code""='" & p.Tag & "'"
                        End If
                    Else
                        Dim oDotNet As New App_SqlDb(oRegistry.GetKeyValue("ServerName"), oRegistry.GetKeyValue("Username"), AppTech.Decrypt(oRegistry.GetKeyValue("Password")), oRegistry.GetKeyValue("Database"))
                        oDotNet.strCommand = "SELECT * FROM APP_Integration..APP_Path Where Code ='" & p.Tag & "'"
                        If oDotNet.Ds.Tables(0).Rows.Count = 0 Then
                            oDotNet.strCommand = "INSERT INTO APP_Integration..APP_Path VALUES('" & p.Tag & "','" & p.Name & "','" & p.AccessibleName & "','" & IIf(Strings.Left(p.Tag, 1) = "1", "Inbound", "Outbound") & "',GETDATE(),'" & p.Text & "',GETDATE(),'" & oRegistry.GetKeyValue("SAPUser") & "',GETDATE(),'" & oRegistry.GetKeyValue("SAPUser") & "')"
                        Else
                            oDotNet.strCommand = "UPDATE APP_Integration..APP_Path SET Name='" & p.Name & "',DocType='" & p.AccessibleName & "',Path='" & p.Text & "',UpdateDate=GETDATE(),UpdatedBy='" & oRegistry.GetKeyValue("SAPUser") & "' Where Code='" & p.Tag & "'"
                        End If
                    End If
                End If
            Next

            oWriteText(DBConfigForm.ConfLog, "Successfully saved path!", Color.Green)
        Catch ex As Exception
            oWriteText(DBConfigForm.ConfLog, ex.ToString, Color.Red)
        End Try
    End Sub

    Protected Sub btn_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        browserDialog(btn.Tag)
    End Sub
End Class