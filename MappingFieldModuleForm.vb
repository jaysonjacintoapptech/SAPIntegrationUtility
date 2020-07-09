Public Class MappingFieldModuleForm
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
    Private Sub MappingFieldModuleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SetMapUI("Module " & Me.Tag & " Mapping - " & Me.AccessibleName)
        Call LoadTables(Me.Tag, Me.AccessibleName)
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub


    Private Sub LoadTables(ByVal Type As String, ByVal Direction As String)
        Try
            Dim DG, DGFilter As New DataGridView
            Dim OpCMB As New DataGridViewComboBoxColumn
            DG.Columns.Add("FieldName", "Field Name")
            DG.Columns.Add("DataType", "Data Type")
            DG.Columns.Add("Length", "Length")
            DG.Columns.Add("IntegField", "Integ Field")
            DG.Columns.Add("IntegDefaultValue", "Integ Value")
            DG.AllowUserToAddRows = False
            DG.AllowUserToDeleteRows = False
            DG.AllowUserToResizeRows = False
            DG.AllowUserToOrderColumns = False
            DG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            DGFilter.Columns.Add("FieldName", "Field Name")
            OpCMB.DataSource = GetComboboxColumn()
            OpCMB.ValueMember = "Value"
            OpCMB.DisplayMember = "Description"
            OpCMB.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
            OpCMB.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            OpCMB.HeaderText = "Condition"
            DGFilter.Columns.Add(OpCMB)
            DGFilter.Columns.Add("FilterValue", "Filter Value")
            DGFilter.AllowUserToAddRows = False
            DGFilter.AllowUserToDeleteRows = False
            DGFilter.AllowUserToResizeRows = False
            DGFilter.AllowUserToOrderColumns = False
            DGFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            If oRegistry.GetKeyValue("ServerType") = 9 Then
                Dim oDotnet As New APP_HANADb(oRegistry.GetKeyValue("ServerName"), oRegistry.GetKeyValue("UserName"), AppTech.Decrypt(oRegistry.GetKeyValue("Password")), oRegistry.GetKeyValue("Database"))
                oDotnet.strCommand = "SELECT * FROM ""APP_Integration"".""APP_Mapping"" Where ""SAPTable""='" & GetTable(Type) & "' and ""Direction""='" & Direction & "'"
                If oDotnet.Ds.Tables(0).Rows.Count = 0 Then LoadCustomTables(Direction)

                For Each oDr As DataRowView In oDotnet.Ds.Tables(0).DefaultView
                    Select Case oDr("Direction")
                        Case "Inbound"
                            DG.Rows.Add(New Object() {oDr("Code").ToString, oDr("DataType").ToString, oDr("Length").ToString, oDr("IntegField").ToString, oDr("IntegValue").ToString})

                        Case "Outbound"
                            DG.Rows.Add(New Object() {oDr("Code").ToString, oDr("DataType").ToString, oDr("Length").ToString, "", ""})
                            DGFilter.Rows.Add(New Object() {oDr("FilterField").ToString, oDr("Operation").ToString, oDr("FilterValue").ToString})
                    End Select
                Next
                DG.Columns.Item("FieldName").ReadOnly = True
                DG.Columns.Item("DataType").ReadOnly = True
                DG.Columns.Item("Length").ReadOnly = True
                DG.Dock = DockStyle.Fill
                panelField.Controls.Add(DG)
                DGFilter.Columns.Item("FieldName").ReadOnly = True

                DGFilter.Dock = DockStyle.Fill
                panelFilter.Controls.Add(DGFilter)
            ElseIf oRegistry.GetKeyValue("ServerType") = 6 Or oRegistry.GetKeyValue("ServerType") = 7 Or oRegistry.GetKeyValue("ServerType") = 8 Or oRegistry.GetKeyValue("ServerType") = 10 Then
                Dim oDotNet As New App_SqlDb(oRegistry.GetKeyValue("ServerName"), oRegistry.GetKeyValue("UserName"), AppTech.Decrypt(oRegistry.GetKeyValue("Password")), oRegistry.GetKeyValue("Database"))
                oDotNet.strCommand = "SELECT * FROM APP_Integration..APP_Mapping Where SAPTable='" & GetTable(Type) & "' and Direction='" & Direction & "'"
                If oDotNet.Ds.Tables(0).Rows.Count = 0 Then LoadCustomTables(Direction)

                For Each oDr As DataRowView In oDotNet.Ds.Tables(0).DefaultView
                    Select Case oDr("Direction")
                        Case "Inbound"
                            DG.Rows.Add(New Object() {oDr("Code").ToString, oDr("DataType").ToString, oDr("Length").ToString, oDr("IntegField").ToString, oDr("IntegValue").ToString})

                        Case "Outbound"
                            DG.Rows.Add(New Object() {oDr("Code").ToString, oDr("DataType").ToString, oDr("Length").ToString, "", ""})
                            DGFilter.Rows.Add(New Object() {oDr("FilterField").ToString, oDr("Operation").ToString, oDr("FilterValue").ToString})
                    End Select
                Next
                DG.Columns.Item("FieldName").ReadOnly = True
                DG.Columns.Item("DataType").ReadOnly = True
                DG.Columns.Item("Length").ReadOnly = True
                DG.Dock = DockStyle.Fill
                panelField.Controls.Add(DG)
                DGFilter.Columns.Item("FieldName").ReadOnly = True

                DGFilter.Dock = DockStyle.Fill
                panelFilter.Controls.Add(DGFilter)

            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub LoadCustomTables(ByVal Direction As String)
        Try

            If oRegistry.GetKeyValue("ServerType") = 9 Then
                Dim oDotNet As New APP_HANADb(oRegistry.GetKeyValue("ServerName"), oRegistry.GetKeyValue("UserName"), AppTech.Decrypt(oRegistry.GetKeyValue("Password")), oRegistry.GetKeyValue("Database"))
                If Me.Tag = "Item Master Data" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OITM'"
                ElseIf Me.Tag = "BP Master Data" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OCRD'"
                ElseIf Me.Tag = "BOM" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OITT'"
                ElseIf Me.Tag = "Purchase Request" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OPRQ'"
                ElseIf Me.Tag = "Purchase Order" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OPOR'"
                ElseIf Me.Tag = "AR Invoice" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OINV'"
                ElseIf Me.Tag = "AR Credit Memo" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'ORIN'"
                ElseIf Me.Tag = "Goods Receipt PO" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OPDN'"
                ElseIf Me.Tag = "Purchase Return" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView""' ORPD'"
                ElseIf Me.Tag = "Delivery" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'ODLN'"
                ElseIf Me.Tag = "Inventory Transfer Request" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OWTQ'"
                ElseIf Me.Tag = "Inventory Transfer" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OWTR'"
                ElseIf Me.Tag = "Goods Receipt" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OIGN'"
                ElseIf Me.Tag = "Goods Issue" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OIGE'"
                End If

                Dim oDataTableH As DataTable = Nothing
                Dim oDataTableD As DataTable = Nothing
                Dim oDataTableP As DataTable = Nothing

                Try
                    oDataTableH = oDotNet.Ds.Tables(0).Copy
                    oDataTableD = oDotNet.Ds.Tables(1).Copy
                    oDataTableP = oDotNet.Ds.Tables(2).Copy
                Catch ex As Exception

                End Try

                Dim DG, DGFilter As New DataGridView
                Dim OpCMB As New DataGridViewComboBoxColumn
                DG.Columns.Add("FieldName", "Field Name")
                DG.Columns.Add("DataType", "Data Type")
                DG.Columns.Add("Length", "Length")
                DG.Columns.Add("IntegField", "Integ Field")
                DG.Columns.Add("IntegDefaultValue", "Integ Value")
                DG.AllowUserToAddRows = False
                DG.AllowUserToDeleteRows = False
                DG.AllowUserToResizeRows = False
                DG.AllowUserToOrderColumns = False
                DG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

                DGFilter.Columns.Add("FieldName", "Field Name")
                OpCMB.DataSource = GetComboboxColumn()
                OpCMB.ValueMember = "Value"
                OpCMB.DisplayMember = "Description"
                OpCMB.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
                OpCMB.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                OpCMB.HeaderText = "Condition"
                DGFilter.Columns.Add(OpCMB)
                DGFilter.Columns.Add("FilterValue", "Filter Value")
                DGFilter.AllowUserToAddRows = False
                DGFilter.AllowUserToDeleteRows = False
                DGFilter.AllowUserToResizeRows = False
                DGFilter.AllowUserToOrderColumns = False
                DGFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


                For Each oCol As ColumnHeader In oDataTableH.Columns

                    oDotNet.strCommand = "SELECT "

                Next
                DG.Columns.Item("FieldName").ReadOnly = True
                DG.Columns.Item("DataType").ReadOnly = True
                DG.Columns.Item("Length").ReadOnly = True
                DG.Dock = DockStyle.Fill
                panelField.Controls.Add(DG)
                DGFilter.Columns.Item("FieldName").ReadOnly = True

                DGFilter.Dock = DockStyle.Fill
                panelFilter.Controls.Add(DGFilter)


            ElseIf oRegistry.GetKeyValue("ServerType") = 6 Or oRegistry.GetKeyValue("ServerType") = 7 Or oRegistry.GetKeyValue("ServerType") = 8 Or oRegistry.GetKeyValue("ServerType") = 10 Then
                Dim oDotNet As New App_SqlDb(oRegistry.GetKeyValue("ServerName"), oRegistry.GetKeyValue("UserName"), AppTech.Decrypt(oRegistry.GetKeyValue("Password")), oRegistry.GetKeyValue("Database"))
                If Me.Tag = "Item Master Data" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OITM'"
                ElseIf Me.Tag = "BP Master Data" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OCRD'"
                ElseIf Me.Tag = "BOM" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OITT'"
                ElseIf Me.Tag = "Purchase Request" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OPRQ'"
                ElseIf Me.Tag = "Purchase Order" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OPOR'"
                ElseIf Me.Tag = "AR Invoice" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OINV'"
                ElseIf Me.Tag = "AR Credit Memo" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'ORIN'"
                ElseIf Me.Tag = "Goods Receipt PO" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OPDN'"
                ElseIf Me.Tag = "Purchase Return" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView""' ORPD'"
                ElseIf Me.Tag = "Delivery" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'ODLN'"
                ElseIf Me.Tag = "Inventory Transfer Request" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OWTQ'"
                ElseIf Me.Tag = "Inventory Transfer" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OWTR'"
                ElseIf Me.Tag = "Goods Receipt" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OIGN'"
                ElseIf Me.Tag = "Goods Issue" Then
                    oDotNet.strCommand = "EXEC ""spAPP_IntegView"" 'OIGE'"
                End If


                Dim DG, DGFilter As New DataGridView
                Dim OpCMB As New DataGridViewComboBoxColumn
                DG.Columns.Add("FieldName", "Field Name")
                DG.Columns.Add("DataType", "Data Type")
                DG.Columns.Add("Length", "Length")
                DG.Columns.Add("IntegField", "Integ Field")
                DG.Columns.Add("IntegDefaultValue", "Integ Value")
                DG.AllowUserToAddRows = False
                DG.AllowUserToDeleteRows = False
                DG.AllowUserToResizeRows = False
                DG.AllowUserToOrderColumns = False
                DG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                DGFilter.Columns.Add("FieldName", "Field Name")
                OpCMB.DataSource = GetComboboxColumn()
                OpCMB.ValueMember = "Value"
                OpCMB.DisplayMember = "Description"
                OpCMB.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
                OpCMB.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                OpCMB.HeaderText = "Condition"
                DGFilter.Columns.Add(OpCMB)
                DGFilter.Columns.Add("FilterValue", "Filter Value")
                DGFilter.AllowUserToAddRows = False
                DGFilter.AllowUserToDeleteRows = False
                DGFilter.AllowUserToResizeRows = False
                DGFilter.AllowUserToOrderColumns = False
                DGFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


                For Each oDR As DataRowView In oDotNet.Ds.Tables(0).DefaultView
                    Select Case Direction
                        Case "Inbound"

                            DG.Rows.Add(New Object() {oDR("COLUMN_NAME").ToString, oDR("DATA_TYPE").ToString, oDR("CHARACTER_MAXIMUM_LENGTH").ToString, "", ""})


                        Case "Outbound"
                            DG.Rows.Add(New Object() {oDR("COLUMN_NAME").ToString, oDR("DATA_TYPE").ToString, oDR("CHARACTER_MAXIMUM_LENGTH").ToString, "", ""})
                            DGFilter.Rows.Add(New Object() {oDR("COLUMN_NAME").ToString, "", ""})

                    End Select
                Next
                DG.Columns.Item("FieldName").ReadOnly = True
                DG.Columns.Item("DataType").ReadOnly = True
                DG.Columns.Item("Length").ReadOnly = True
                DG.Dock = DockStyle.Fill
                panelField.Controls.Add(DG)
                DGFilter.Columns.Item("FieldName").ReadOnly = True

                DGFilter.Dock = DockStyle.Fill
                panelFilter.Controls.Add(DGFilter)
            End If



        Catch ex As Exception

        End Try

    End Sub

    Private Function GetComboboxColumn() As DataTable
        Try
            Dim oTable As New DataTable
            oTable.Columns.Add("Value")
            oTable.Columns.Add("Description")
            oTable.Rows.Add(New Object() {"=", "Equal"})
            oTable.Rows.Add(New Object() {">", "Greater Than"})
            oTable.Rows.Add(New Object() {"<", "Smaller Than"})
            oTable.Rows.Add(New Object() {">=", "Greater or Equal"})
            oTable.Rows.Add(New Object() {"<=", "Smaller or Equal"})
            oTable.Rows.Add(New Object() {"<>", "Not Equal"})
            oTable.Rows.Add(New Object() {"LIKE", "Contains"})
            oTable.Rows.Add(New Object() {"NOT LIKE", "Does Not Contain"})
            oTable.Rows.Add(New Object() {"IS NULL", "IS NULL"})
            oTable.Rows.Add(New Object() {"IS NOT NULL", "IS NOT NULL"})

            Return oTable
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try

            If oRegistry.GetKeyValue("ServerType") = 9 Then
                Dim oDotNet As New APP_HANADb(oRegistry.GetKeyValue("ServerName"), oRegistry.GetKeyValue("UserName"), AppTech.Decrypt(oRegistry.GetKeyValue("Password")), oRegistry.GetKeyValue("Database"))

                For Each oControl As Control In panelField.Controls

                    Dim oDataGrid As DataGridView = CType(oControl, DataGridView)
                    For Each oDataGridView As DataGridViewRow In oDataGrid.Rows
                        Select Case Me.AccessibleName
                            Case "Inbound"
                                oDotNet.strCommand = "SELECT * FROM ""APP_Integration"".""APP_Mapping"" Where ""Code""='" & oDataGridView.Cells.Item("FieldName").Value & "' and ""SAPTable""='" & GetTable(Me.Tag) & "' and ""Direction""='Inbound'"
                                If oDotNet.Ds.Tables(0).Rows.Count = 0 Then
                                    oDotNet.strCommand = "INSERT INTO ""APP_Integration"".""APP_Mapping"" (""Code"",""Name"",""SAPTable"",""DataType"",""Length"",""IntegField"",""IntegValue"",""Direction"",""CreatedDate"",""CreatedBy"",""UpdateDate"",""UpdatedBy"") VALUES ('" & oDataGridView.Cells.Item("FieldName").Value & "','" & oDataGridView.Cells.Item("FieldName").Value & "','" & GetTable(Me.Tag) & "','" & oDataGridView.Cells.Item("DataType").Value & "','" & oDataGridView.Cells.Item("Length").Value & "','" & oDataGridView.Cells.Item("IntegField").Value & "','" & oDataGridView.Cells.Item("IntegDefaultValue").Value & "','" & Me.AccessibleName & "',CURRENT_TIMESTAMP(),'" & oRegistry.GetKeyValue("SAPUser") & "',CURRENT_TIMESTAMP(),'" & oRegistry.GetKeyValue("SAPUser") & "')"
                                Else
                                    oDotNet.strCommand = "UPDATE ""APP_Integration"".""APP_Mapping"" SET ""IntegField""='" & oDataGridView.Cells.Item("IntegField").Value & "',""IntegValue""='" & oDataGridView.Cells.Item("IntegDefaultValue").Value & "',""UpdateDate""=CURRENT_TIMESTAMP(),""UpdatedBy""='" & oRegistry.GetKeyValue("SAPUser") & "' Where ""Code""='" & oDataGridView.Cells.Item("FieldName") & "' and ""SAPTable""='" & GetTable(Me.Tag) & "' and ""Direction""='Inbound'"

                                End If
                            Case "Outbound"
                                oDotNet.strCommand = "SELECT * FROM ""APP_Integration"".""APP_Mapping"" Where ""Code""='" & oDataGridView.Cells.Item("FieldName").Value & "' and ""SAPTable""='" & GetTable(Me.Tag) & "' and ""Direction""='Outbound'"
                                If oDotNet.Ds.Tables(0).Rows.Count = 0 Then
                                    oDotNet.strCommand = "INSERT INTO ""APP_Integration"".""APP_Mapping"" (""Code"",""Name"",""SAPTable"",""DataType"",""Length"",""IntegField"",""IntegValue"",""Direction"",""CreatedDate"",""CreatedBy"",""UpdateDate"",""UpdatedBy"") VALUES ('" & oDataGridView.Cells.Item("FieldName").Value & "','" & oDataGridView.Cells.Item("FieldName").Value & "','" & GetTable(Me.Tag) & "','" & oDataGridView.Cells.Item("DataType").Value & "','" & oDataGridView.Cells.Item("Length").Value & "','" & oDataGridView.Cells.Item("IntegField").Value & "','" & oDataGridView.Cells.Item("IntegDefaultValue").Value & "','" & Me.AccessibleName & "',CURRENT_TIMESTAMP(),'" & oRegistry.GetKeyValue("SAPUser") & "',CURRENT_TIMESTAMP(),'" & oRegistry.GetKeyValue("SAPUser") & "')"
                                Else
                                    oDotNet.strCommand = "UPDATE ""APP_Integration"".""APP_Mapping"" SET ""IntegField""='" & oDataGridView.Cells.Item("IntegField").Value & "',""IntegValue""='" & oDataGridView.Cells.Item("IntegDefaultValue").Value & "',""UpdateDate""=CURRENT_TIMESTAMP(),""UpdatedBy""='" & oRegistry.GetKeyValue("SAPUser") & "' Where ""Code""='" & oDataGridView.Cells.Item("FieldName").Value & "' and ""SAPTable""='" & GetTable(Me.Tag) & "' and ""Direction""='Outbound'"
                                End If

                                For Each oCtrl As Control In panelFilter.Controls
                                    Dim oData As DataGridView = CType(oCtrl, DataGridView)
                                    For Each oRow As DataGridViewRow In oData.Rows
                                        oDotNet.strCommand = "UPDATE ""APP_Integration"".""APP_Mapping"" SET ""FilterField""='" & oRow.Cells.Item("FieldName").Value & "',""Operation""='" & oRow.Cells.Item("Condition").Value & "',""FilterValue""='" & oRow.Cells.Item("FilterValue").Value & "' Where ""Code""='" & oDataGridView.Cells.Item("FieldName").Value & "' and ""SAPTable""='" & GetTable(Me.Tag) & "' and ""Direction""='" & Me.AccessibleName & "'"

                                    Next
                                Next
                        End Select
                    Next
                Next

            ElseIf oRegistry.GetKeyValue("ServerType") = 6 Or oRegistry.GetKeyValue("ServerType") = 7 Or oRegistry.GetKeyValue("ServerType") = 8 Or oRegistry.GetKeyValue("ServerType") = 10 Then
                Dim oDotNet As New App_SqlDb(oRegistry.GetKeyValue("ServerName"), oRegistry.GetKeyValue("UserName"), AppTech.Decrypt(oRegistry.GetKeyValue("Password")), oRegistry.GetKeyValue("Database"))

                For Each oControl As Control In panelField.Controls

                    Dim oDataGrid As DataGridView = CType(oControl, DataGridView)
                    For Each oDataGridView As DataGridViewRow In oDataGrid.Rows

                        Select Case Me.AccessibleName
                                Case "Inbound"
                                oDotNet.strCommand = "SELECT * FROM APP_Integration..APP_Mapping Where Code='" & oDataGridView.Cells.Item("FieldName").Value & "' and SAPTable='" & GetTable(Me.Tag) & "' and Direction='Inbound'"
                                If oDotNet.Ds.Tables(0).Rows.Count = 0 Then
                                    oDotNet.strCommand = "INSERT INTO APP_Integration..APP_Mapping (Code,Name,SAPTable,DataType,Length,IntegField,IntegValue,Direction,CreatedDate,CreatedBy,UpdateDate,UpdatedBy) VALUES ('" & oDataGridView.Cells.Item("FieldName").Value & "','" & oDataGridView.Cells.Item("FieldName").Value & "','" & GetTable(Me.Tag) & "','" & oDataGridView.Cells.Item("DataType").Value & "','" & oDataGridView.Cells.Item("Length").Value & "','" & oDataGridView.Cells.Item("IntegField").Value & "','" & oDataGridView.Cells.Item("IntegDefaultValue").Value & "','" & Me.AccessibleName & "',GETDATE(),'" & oRegistry.GetKeyValue("SAPUser") & "',GETDATE(),'" & oRegistry.GetKeyValue("SAPUser") & "')"
                                Else
                                    oDotNet.strCommand = "UPDATE APP_Integration..APP_Mapping SET IntegField='" & oDataGridView.Cells.Item("IntegField").Value & "',IntegValue='" & oDataGridView.Cells.Item("IntegDefaultValue").Value & "',UpdateDate=GETDATE(),UpdatedBy='" & oRegistry.GetKeyValue("SAPUser") & "' Where Code='" & oDataGridView.Cells.Item("FieldName").Value & "' and SAPTable='" & GetTable(Me.Tag) & "' and Direction='Inbound'"

                                End If
                            Case "Outbound"
                                oDotNet.strCommand = "SELECT * FROM APP_Integration..APP_Mapping Where Code='" & oDataGridView.Cells.Item("FieldName").Value & "' and SAPTable='" & GetTable(Me.Tag) & "' and Direction='Outbound'"
                                If oDotNet.Ds.Tables(0).Rows.Count = 0 Then
                                    oDotNet.strCommand = "INSERT INTO APP_Integration..APP_Mapping (Code,Name,SAPTable,DataType,Length,IntegField,IntegValue,Direction,CreatedDate,CreatedBy,UpdateDate,UpdatedBy) VALUES ('" & oDataGridView.Cells.Item("FieldName").Value & "','" & oDataGridView.Cells.Item("FieldName").Value & "','" & GetTable(Me.Tag) & "','" & oDataGridView.Cells.Item("DataType").Value & "','" & oDataGridView.Cells.Item("Length").Value & "','" & oDataGridView.Cells.Item("IntegField").Value & "','" & oDataGridView.Cells.Item("IntegDefaultValue").Value & "','" & Me.AccessibleName & "',GETDATE(),'" & oRegistry.GetKeyValue("SAPUser") & "',GETDATE(),'" & oRegistry.GetKeyValue("SAPUser") & "')"
                                Else
                                    oDotNet.strCommand = "UPDATE APP_Integration..APP_Mapping SET IntegField='" & oDataGridView.Cells.Item("IntegField").Value & "',IntegValue='" & oDataGridView.Cells.Item("IntegDefaultValue").Value & "',UpdateDate=GETDATE(),UpdatedBy='" & oRegistry.GetKeyValue("SAPUser") & "' Where Code='" & oDataGridView.Cells.Item("FieldName") & "' and SAPTable='" & GetTable(Me.Tag) & "' and Direction='Outbound'"
                                End If

                                For Each oCtrl As Control In panelFilter.Controls
                                    Dim oData As DataGridView = CType(oCtrl, DataGridView)
                                    For Each oRow As DataGridViewRow In oData.Rows
                                        oDotNet.strCommand = "UPDATE APP_Integration..APP_Mapping SET FilterField='" & oRow.Cells.Item("FieldName").Value & "',Operation='" & oRow.Cells.Item("Condition").Value & "',FilterValue='" & oRow.Cells.Item("FilterValue").Value & "' Where Code='" & oDataGridView.Cells.Item("FieldName").Value & "' and SAPTable='" & GetTable(Me.Tag) & "' and Direction='" & Me.AccessibleName & "'"

                                    Next
                                Next

                        End Select

                    Next
                Next
            End If

            MsgBox("Successfully Saved Mapping for " & Me.lblTitle.Text, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Function GetTable(ByVal Tag As String) As String
        Try

            Select Case Tag
                Case "Item Master Data"
                    Return "OITM"
                Case "BP Master Data"
                    Return "OCRD"
                Case "BOM"
                    Return "OITT"
                Case "Purchase Request"
                    Return "OPRQ"
                Case "Purchase Order"
                    Return "OPOR"
                Case "AR Invoice"
                    Return "OINV"
                Case "AR Credit Memo"
                    Return "ORIN"
                Case "Goods Receipt PO"
                    Return "OPDN"
                Case "Purchase Return"
                    Return "ORPD"
                Case "Delivery"
                    Return "ODLN"
                Case "Inventory Transfer Request"
                    Return "OWTQ"
                Case "Inventory Transfer"
                    Return "OWTR"
                Case "Goods Receipt"
                    Return "OIGN"
                Case "Goods Issue"
                    Return "OIGE"
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function
End Class