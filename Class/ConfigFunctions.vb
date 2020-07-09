Imports System.Data.SqlClient

Public Class ConfigFunctions
    Dim oRecset As SAPbobsCOM.Recordset = Nothing
    Public Function SaveConfig() As Boolean
        Try
            oWriteText(DBConfigForm.ConfLog, ".......................")
            oWriteText(DBConfigForm.ConfLog, "Validating SAP credentials, please wait...")
            Try
                oCompany = New SAPbobsCOM.Company

                oCompany.Server = DBConfigForm.txtServerName.Text
                oCompany.DbUserName = DBConfigForm.txtUser.Text
                oCompany.DbPassword = DBConfigForm.txtPass.Text
                oCompany.CompanyDB = DBConfigForm.txtDB.Text
                oCompany.UserName = DBConfigForm.txtSAPUser.Text
                oCompany.Password = DBConfigForm.txtSAPPass.Text
                oCompany.LicenseServer = DBConfigForm.txtLicSer.Text
                oCompany.DbServerType = DBConfigForm.cbServerType.SelectedValue
                oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English

                If Not oCompany.Connect = 0 Then
                    oWriteText(DBConfigForm.ConfLog, oCompany.GetLastErrorDescription, Color.Red, True)
                    oWriteText(DBConfigForm.ConfLog, ".......................")
                    Return False
                End If

            Catch ex As Exception
            End Try
            oWriteText(DBConfigForm.ConfLog, "SAP Successfully connected.", Color.Green, True)
            oWriteText(DBConfigForm.ConfLog, ".......................")

            MakeINI(DBConfigForm.cbServerType.SelectedValue, DBConfigForm.txtServerName.Text, DBConfigForm.txtDB.Text, DBConfigForm.txtUser.Text,
                  AppTech.Encrypt(DBConfigForm.txtPass.Text),
                  DBConfigForm.txtLicSer.Text, DBConfigForm.txtSAPUser.Text, AppTech.Encrypt(DBConfigForm.txtSAPPass.Text), "", "", "", "", GetIntegType)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private oSqlConnection As SqlConnection
    Public Function SaveIntegConfig() As Boolean
        Try
            If DBConfigForm.rbDB.Checked Then
                Dim Server As String
                Dim UserId As String
                Dim Password As String
                Dim Database As String

                For Each p As Control In DBConfigForm.panelInteg.Controls
                    For Each pint As Control In p.Controls
                        If pint.Name = "txtIntegServer" Then
                            Server = pint.Text
                        ElseIf pint.Name = "txtIntegUser" Then
                            UserId = pint.Text
                        ElseIf pint.Name = "txtIntegPass" Then
                            Password = pint.Text
                        ElseIf pint.Name = "txtIntegDB" Then
                            Database = pint.Text
                        End If
                    Next
                Next


                oWriteText(DBConfigForm.ConfLog, "Validating Integ Server SQL credentials, please wait...")

                oQry = "data source=" & Server & "; user id=" & UserId & "; password=" & Password & "; initial catalog=" & Database & ""
                Try
                    oSqlConnection = New SqlConnection(oQry)
                    oSqlConnection.Open()

                    oSqlConnection.Close()
                Catch ex As Exception
                    oWriteText(DBConfigForm.ConfLog, "Please check your credentials." & vbCrLf & ex.Message, Color.Red, True)
                    oWriteText(DBConfigForm.ConfLog, ".......................")

                    Return False
                End Try
                oWriteText(DBConfigForm.ConfLog, "Integ Server SQL Successfully connected.", Color.Green, True)

                MakeINI(DBConfigForm.cbServerType.SelectedValue, DBConfigForm.txtServerName.Text, DBConfigForm.txtDB.Text, DBConfigForm.txtUser.Text,
                      AppTech.Encrypt(DBConfigForm.txtPass.Text),
                      DBConfigForm.txtLicSer.Text, DBConfigForm.txtSAPUser.Text, AppTech.Encrypt(DBConfigForm.txtSAPPass.Text), Server, UserId, AppTech.Encrypt(Password), Database, GetIntegType)
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function


    Function GetIntegType() As String
        If DBConfigForm.rbDB.Checked Then
            Return "DB"
        ElseIf DBConfigForm.rbFile.Checked Then
            Return "FILE"
        ElseIf DBConfigForm.rbAPI.Checked Then
            Return "API"
        End If
    End Function
    Function GetUDFId(ByVal TableName As String, ByVal FieldName As String) As Long
        'BTG 11/7/2013
        Dim _TableName As String
        If Microsoft.VisualBasic.Left(TableName, 1) = "@" Then
            If Microsoft.VisualBasic.Left(oCompany.Version, 2) > "80" Then
                GoTo HighVer
            Else
                _TableName = TableName.Substring(1, TableName.Length - 1)
            End If
        Else
HighVer:
            _TableName = TableName

        End If
        oRecset = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oRecset.DoQuery("SELECT TOP 1 ""FieldID"" FROM CUFD Where ""TableID"" = '" & _TableName & "' and ""AliasID"" = '" & FieldName & "'")
        If oRecset.RecordCount > 0 Then Return oRecset.Fields.Item("FieldID").Value
        Return -1
    End Function

    Function CreateUDF(ByVal TableName As String, ByVal FieldName As String, ByVal FieldDescription As String, Optional ByVal UDFLength As Integer = 10, Optional ByVal FieldType As SAPbobsCOM.BoFieldTypes = SAPbobsCOM.BoFieldTypes.db_Alpha, Optional ByVal DefaultValue As Object = "", Optional ByVal ShowMessage As Boolean = False, Optional ByVal dtValidValues As Data.DataTable = Nothing, Optional ByVal LinkedTable As String = "", Optional ByVal FieldSubType As SAPbobsCOM.BoFldSubTypes = Nothing, Optional ByVal isMandatory As SAPbobsCOM.BoYesNoEnum = SAPbobsCOM.BoYesNoEnum.tNO, Optional ByVal isUpdateExisting As Boolean = False, Optional LinkSystemObj As String = "") As Boolean
        Try
            Dim FieldID As Integer = GetUDFId(TableName, FieldName)

            oRecset = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

            If Not IsNothing(oRecset) Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oRecset)
                oRecset = Nothing
                GC.Collect()
            End If

            Dim oUserFields As SAPbobsCOM.UserFieldsMD
            oUserFields = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)
            Dim isExists As Boolean = False

            'LSC 10/20/2013
            If Not FieldID = -1 Then 'oUserFields.GetByKey(TableName, FieldID) Then
                'oUserFields.Remove()
                ' If Not isUpdateExisting Then Return True
                Return True

                'oUserFields.Remove()
            End If


            With oUserFields
                If Not isExists Then
                    .TableName = TableName
                    .Name = FieldName
                    .Description = FieldDescription
                    .Type = FieldType
                End If
                .EditSize = UDFLength
                .Mandatory = isMandatory
                Select Case oUserFields.Type
                    Case 4
                        .SubType = FieldSubType

                End Select

                If FieldType = SAPbobsCOM.BoFieldTypes.db_Alpha Or FieldType = SAPbobsCOM.BoFieldTypes.db_Float Or FieldType = SAPbobsCOM.BoFieldTypes.db_Numeric Or FieldType = SAPbobsCOM.BoFieldTypes.db_Date Then
                    If Not DefaultValue = "" Then .DefaultValue = DefaultValue
                End If

                If Not LinkedTable = "" Then .LinkedTable = LinkedTable
                'If Not LinkSystemObj = "" Then .LinkedSystemObject = LinkSystemObj

                If Not IsNothing(dtValidValues) Then
                    For Loops As Integer = 0 To dtValidValues.Rows.Count - 1
                        .ValidValues.Value = dtValidValues.Rows(Loops).Item("Value")
                        .ValidValues.Description = dtValidValues.Rows(Loops).Item("Description")
                        If Loops <= dtValidValues.Rows.Count - 1 Then .ValidValues.Add()
                    Next
                End If

                If isExists Then
                    If Not .Update = 0 Then
                        If ShowMessage Then oWriteText(DBConfigForm.ConfLog, oCompany.GetLastErrorDescription, Color.Red, True)
                        Return False
                    End If
                Else
                    If Not .Add = 0 Then
                        If ShowMessage Then oWriteText(DBConfigForm.ConfLog, oCompany.GetLastErrorDescription, Color.Red, True)
                        Console.WriteLine(oCompany.GetLastErrorDescription)
                        Return False
                    End If
                End If

            End With

            System.Runtime.InteropServices.Marshal.ReleaseComObject(oUserFields)
            oUserFields = Nothing
            GC.Collect()

            Return True
        Catch ex As Exception
            oWriteText(DBConfigForm.ConfLog, "[Err] - " & FieldName & ex.ToString, Color.Red, True)
            Return False
        End Try
    End Function

    Function CreateTable(ByVal TableName As String, ByVal TableDescr As String, ByVal TableType As SAPbobsCOM.BoUTBTableType, Optional ByVal ShowMessage As Boolean = False) As Boolean
        Try
            If Not IsNothing(oRecset) Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(oRecset)
                oRecset = Nothing
                GC.Collect()
            End If

            Dim oUSR As SAPbobsCOM.UserTablesMD

            oUSR = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserTables)

            If oUSR.GetByKey(TableName) Then Return False

            oUSR.TableName = TableName
            oUSR.TableDescription = TableDescr
            oUSR.TableType = TableType
            If Not oUSR.Add = 0 Then
                If ShowMessage Then oWriteText(DBConfigForm.ConfLog, oCompany.GetLastErrorDescription, Color.Red, True)
                Return False
            End If

            System.Runtime.InteropServices.Marshal.ReleaseComObject(oUSR)
            oUSR = Nothing
            GC.Collect()

            Return True
        Catch ex As Exception
            oWriteText(DBConfigForm.ConfLog, ex.ToString, Color.Red, True)
            Return False
        End Try
    End Function
End Class
