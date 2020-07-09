Imports System.Web.HttpServerUtility
Imports System.Windows.Forms
Imports System.Web.UI.Page
Imports System.Web.UI

Public Class App_DotNet
    ' Inherits System.Web.UI.Page 

    Private oProductId As String
    Public SqlDb As App_SqlDb
    Public HANADb As APP_HANADb

    Public IsWeb As Boolean = False

    Sub New(ByVal oAppName As String)
        oProductId = oAppName
    End Sub

    Sub New(ByVal oAppName As String, ByVal oSqlServer As String, ByVal oSqlId As String, ByVal oSqlPassword As String, ByVal oSqlDb As String)
        oProductId = oAppName
        SqlDb = New App_SqlDb(oSqlServer, oSqlId, oSqlPassword, oSqlDb)
        HANADb = New APP_HANADb(oSqlServer, oSqlId, oSqlPassword, oSqlDb)
    End Sub

#Region "Form Binding"

#End Region

#Region "Strings"
    Public Function Encrypt(ByVal strText As String, Optional ByVal strEncrKey _
                   As String = "") As String
        If strText = "" Then Return ""
        If strEncrKey = "" Then strEncrKey = oProductId

        Dim byKey() As Byte = {}
        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
        Try
            byKey = System.Text.Encoding.UTF8.GetBytes(strEncrKey.Substring(0, 8))

            Dim des As New System.Security.Cryptography.DESCryptoServiceProvider()
            Dim inputByteArray() As Byte = System.Text.Encoding.UTF8.GetBytes(strText)
            Dim ms As New System.IO.MemoryStream
            Dim cs As New System.Security.Cryptography.CryptoStream(ms, des.CreateEncryptor(byKey, IV), System.Security.Cryptography.CryptoStreamMode.Write)
            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Return System.Convert.ToBase64String(ms.ToArray())

        Catch ex As Exception
            Return ""
        End Try

    End Function

    Public Function Decrypt(ByVal strText As String, Optional ByVal sDecrKey _
            As String = "") As String
        If strText = "" Then Return ""

        If sDecrKey = "" Then sDecrKey = oProductId

        Dim byKey() As Byte = {}
        Dim IV() As Byte = {&H12, &H34, &H56, &H78, &H90, &HAB, &HCD, &HEF}
        Dim inputByteArray(strText.Length) As Byte

        Try
            byKey = System.Text.Encoding.UTF8.GetBytes(sDecrKey.Substring(0, 8))
            Dim des As New System.Security.Cryptography.DESCryptoServiceProvider

            inputByteArray = System.Convert.FromBase64String(strText.Replace(" ", "+"))
            Dim ms As New System.IO.MemoryStream()
            Dim cs As New System.Security.Cryptography.CryptoStream(ms, des.CreateDecryptor(byKey, IV), System.Security.Cryptography.CryptoStreamMode.Write)

            cs.Write(inputByteArray, 0, inputByteArray.Length)
            cs.FlushFinalBlock()
            Dim encoding As System.Text.Encoding = System.Text.Encoding.UTF8

            Return encoding.GetString(ms.ToArray())

        Catch ex As Exception
            Return ""
        End Try
    End Function

#End Region

#Region "System Message Handling"

    Private sysMessage As String = "&nbsp;", sysMessageType As App_MessageType
    Enum App_MessageType
        oSuccess = 1
        oError = 2
    End Enum

    Private oExpToString As String, oExp As Exception = Nothing
    Sub SetMessage(ByVal oErr As Object, Optional ByVal oMessageType As App_MessageType = App_MessageType.oSuccess)

        If oErr.GetType Is System.Type.GetType("System.String") Then
            sysMessage = oErr
        Else
            sysMessage = oErr.Message
            oExpToString = oErr.ToString
            oMessageType = App_MessageType.oError
            oExp = oErr
        End If
        sysMessageType = oMessageType

        Select Case IsWeb
            Case False
                MsgBox(sysMessage, IIf(oMessageType = App_MessageType.oError, EventLogEntryType.Error, EventLogEntryType.Information))

            Case True
                Try
                    ' Session("sysMessage") = sysMessage
                Catch ex As Exception
                End Try

        End Select
        Dim oLog As String = IIf(oMessageType = App_MessageType.oError, "[Error] ", "[Info] ") & Chr(9) & Now & Chr(9) & sysMessage
        WriteToFile(oLog)
    End Sub

    Private Function WriteToFile(ByVal logValue As String) As Boolean
        Try
            '_Path = oRegistry.GetKeyValue("Path")
            Dim TextFile As New IO.StreamWriter(Application.StartupPath & "\Error Log File.txt", True)
            TextFile.WriteLine(logValue)
            TextFile.Close()
            TextFile = Nothing

            Return True
        Catch ex As Exception
        End Try
        Return False
    End Function

#End Region


End Class
