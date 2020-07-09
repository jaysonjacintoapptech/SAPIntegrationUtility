Module Main

    Public AppTech As New App_DotNet("oAPPTech")
    Public oRegistry As New APPRegistry("APP-Integration")
    Public Sub oWriteText(ByVal lsView As Object, ByRef txt As String, Optional ByVal oColor As Color = Nothing, Optional ByVal isStored As Boolean = False, Optional ByVal oFile As String = "logs")
        If oColor = Nothing Then
            oColor = Color.Black
        End If

        Try
            Dim addItem As ListViewItem = lsView.Items.Add(txt)
            lsView.EnsureVisible(lsView.Items.Count - 1)
            addItem.SubItems(0).ForeColor = oColor
            lsView.Refresh()
        Catch ex As Exception
        End Try

        WriteToFile(txt, Application.StartupPath + "\logs\" & oFile & "_" & oGetDate(1) & "_" & oGetDate(2) & "_" & oGetDate(3) & ".txt", isStored)
    End Sub

    Public Function WriteToFile(ByVal logValue As String, ByVal path As String, Optional ByVal isStored As Boolean = False) As Boolean
        Try
            If isStored Then

                If Not System.IO.Directory.Exists(path) Then
                    System.IO.Directory.CreateDirectory(Application.StartupPath + "\logs")
                End If

                Dim TextFile As New IO.StreamWriter(path, True)
                TextFile.WriteLine(logValue)
                TextFile.Close()
                TextFile = Nothing

            End If

            Return True
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical, "System Message")
        End Try
        Return False
    End Function

    Public Sub MakeINI(ByVal oServerType As String,
                    ByVal oServerName As String,
                    ByVal oDatabase As String,
                    ByVal oUserName As String,
                    ByVal oPassword As String,
                    ByVal oLicServer As String,
                    ByVal oSAPuser As String,
                    ByVal oSAPpass As String,
                    ByVal oPOSServer As String,
                    ByVal oPOSUser As String,
                    ByVal oPOSPass As String,
                    ByVal oIntegDB As String,
                    ByVal oIntegType As String
                    )
        Try

            oRegistry = New APPRegistry("APP-Integration")

            oRegistry.CreateSubKey("ServerType", oServerType)
            oRegistry.CreateSubKey("ServerName", oServerName)
            oRegistry.CreateSubKey("Database", oDatabase)
            oRegistry.CreateSubKey("UserName", oUserName)
            oRegistry.CreateSubKey("Password", oPassword)
            oRegistry.CreateSubKey("LicenseServer", oLicServer)
            oRegistry.CreateSubKey("SAPuser", oSAPuser)
            oRegistry.CreateSubKey("SAPpass", oSAPpass)
            oRegistry.CreateSubKey("POSServer", oPOSServer)
            oRegistry.CreateSubKey("POSUser", oPOSUser)
            oRegistry.CreateSubKey("POSPass", oPOSPass)
            oRegistry.CreateSubKey("IntegDB", oIntegDB)
            oRegistry.CreateSubKey("IntegType", oIntegType)

        Catch ex As Exception
            MsgBox("Cannot write file. Please setup folder permissions.", MsgBoxStyle.Critical, "System Message")
        End Try
    End Sub

    'Public Sub oErrLog(ByVal oErrMsg As String, Optional site_reference_code As String = "", Optional terminal_id As String = "", Optional oFile As String = "", Optional oDocNum As String = "", Optional ByVal oSendAlert As Boolean = True)
    '    Dim oDotNet As New App_SqlDb(oRegistry.GetKeyValue("ServerName"), oRegistry.GetKeyValue("UserName"), AppTech.Decrypt(oRegistry.GetKeyValue("Password")), oRegistry.GetKeyValue("Database"))

    '    oDotNet.strCommand = "INSERT INTO /*[DBMULTIPLE_HERE]..*/..[APP_errLog] " & _
    '                            "SELECT '" & Replace(site_reference_code, "'", "") & "', '" & terminal_id & "', '" & oErrMsg & "', GETDATE(), '" & oFile & "', '" & oDocNum & "' "

    '    'If oSendAlert Then
    '    '    ErrorSendEmail(oErrMsg)
    '    'End If
    'End Sub

    'Function ErrorSendEmail(oError As String) As Boolean
    '    Try
    '        Dim htmlHdr As String = "<html><head>"
    '        htmlHdr &= "</style></head><body><font size='2' face='Arial'>"
    '        Dim htmlFtr As String = "</body></font></html>"
    '        Dim htmlBody As String = htmlHdr

    '        htmlBody &= "Hi Team, <br /><br />"
    '        htmlBody &= oError & "<br /><br />SAP-RETAIL M@ster." & htmlFtr

    '        Dim oMail As System.Net.Mail.MailMessage = New System.Net.Mail.MailMessage
    '        oMail.From = New System.Net.Mail.MailAddress("donotreplyemail0@gmail.com")
    '        oMail.To.Add(New System.Net.Mail.MailAddress("christopher.tan@apptech-experts.com"))
    '        oMail.To.Add(New System.Net.Mail.MailAddress("amtanguanco@dizonfarms.net"))

    '        oMail.Subject = "From SAP-RETAIL Utility"
    '        oMail.Body = htmlBody
    '        oMail.IsBodyHtml = True

    '        Dim SmtpServer As System.Net.Mail.SmtpClient = New System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
    '        SmtpServer.Credentials = New System.Net.NetworkCredential("sapintegrationdizon@gmail.com", "d!z0n2015")
    '        'SmtpServer.Timeout = 15
    '        SmtpServer.EnableSsl = True
    '        SmtpServer.Send(oMail)
    '        Return True
    '    Catch Exp As Exception
    '        Return False
    '    End Try
    'End Function

End Module
