Public Class ModuleConfiguration
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
    Private Sub ModuleConfiguration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SETModuleUI()
        Call LoadTable()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
    Private Sub LoadTable()
        Try
            If oRegistry.GetKeyValue("ServerType") = 9 Then
                Dim oDotNet As New APP_HANADb(oRegistry.GetKeyValue("ServerName"), oRegistry.GetKeyValue("UserName"), AppTech.Decrypt(oRegistry.GetKeyValue("Password")), oRegistry.GetKeyValue("Database"))
                oDotNet.strCommand = "SELECT * FROM ""APP_Integration"".""APP_Modules"""
                If oDotNet.Ds.Tables(0).Rows.Count = 0 Then
                    lstExcludeInbound.Items.Add("Item Master Data")
                    lstExcludeInbound.Items.Add("BP Master Data")
                    lstExcludeInbound.Items.Add("BOM")
                    lstExcludeInbound.Items.Add("Purchase Request")
                    lstExcludeInbound.Items.Add("Purchase Order")
                    lstExcludeInbound.Items.Add("AR Invoice")
                    lstExcludeInbound.Items.Add("AR Credit Memo")
                    lstExcludeInbound.Items.Add("AP Invoice")
                    lstExcludeInbound.Items.Add("AP Credit Memo")
                    lstExcludeInbound.Items.Add("Goods Receipt PO")
                    lstExcludeInbound.Items.Add("Purchase Return")
                    lstExcludeInbound.Items.Add("Delivery")
                    lstExcludeInbound.Items.Add("Inventory Transfer Request")
                    lstExcludeInbound.Items.Add("Inventory Transfer")
                    lstExcludeInbound.Items.Add("Goods Receipt")
                    lstExcludeInbound.Items.Add("Goods Issue")

                    lstExcludeOutbound.Items.Add("Item Master Data")
                    lstExcludeOutbound.Items.Add("BP Master Data")
                    lstExcludeOutbound.Items.Add("BOM")
                    lstExcludeOutbound.Items.Add("Purchase Request")
                    lstExcludeOutbound.Items.Add("Purchase Order")
                    lstExcludeOutbound.Items.Add("AR Invoice")
                    lstExcludeOutbound.Items.Add("AR Credit Memo")
                    lstExcludeOutbound.Items.Add("AP Invoice")
                    lstExcludeOutbound.Items.Add("AP Credit Memo")
                    lstExcludeOutbound.Items.Add("Goods Receipt PO")
                    lstExcludeOutbound.Items.Add("Purchase Return")
                    lstExcludeOutbound.Items.Add("Delivery")
                    lstExcludeOutbound.Items.Add("Inventory Transfer Request")
                    lstExcludeOutbound.Items.Add("Inventory Transfer")
                    lstExcludeOutbound.Items.Add("Goods Receipt")
                    lstExcludeOutbound.Items.Add("Goods Issue")
                Else
                    For Each oModules As DataRowView In oDotNet.Ds.Tables(0).DefaultView
                        Select Case oModules("Type")
                            Case "Inbound"

                                Select Case oModules("Include")
                                    Case "Y"
                                        lstIncludeInbound.Items.Add(oModules("Name"))
                                    Case "N"
                                        lstExcludeInbound.Items.Add(oModules("Name"))
                                End Select
                            Case "Outbound"
                                Select Case oModules("Include")
                                    Case "Y"
                                        lstIncludeOutbound.Items.Add(oModules("Name"))
                                    Case "N"
                                        lstExcludeOutbound.Items.Add(oModules("Name"))
                                End Select
                        End Select
                    Next
                End If

            ElseIf oRegistry.GetKeyValue("ServerType") = 6 Or oRegistry.GetKeyValue("ServerType") = 7 Or oRegistry.GetKeyValue("ServerType") = 8 Or oRegistry.GetKeyValue("ServerType") = 10 Then
                Dim oDotNet As New App_SqlDb(oRegistry.GetKeyValue("ServerName"), oRegistry.GetKeyValue("UserName"), AppTech.Decrypt(oRegistry.GetKeyValue("Password")), oRegistry.GetKeyValue("Database"))
                oDotNet.strCommand = "SELECT * FROM APP_Integration..APP_Modules"
                If oDotNet.Ds.Tables(0).Rows.Count = 0 Then
                    lstExcludeInbound.Items.Add("Item Master Data")
                    lstExcludeInbound.Items.Add("BP Master Data")
                    lstExcludeInbound.Items.Add("BOM")
                    lstExcludeInbound.Items.Add("Purchase Request")
                    lstExcludeInbound.Items.Add("Purchase Order")
                    lstExcludeInbound.Items.Add("AR Invoice")
                    lstExcludeInbound.Items.Add("AR Credit Memo")
                    lstExcludeInbound.Items.Add("AP Invoice")
                    lstExcludeInbound.Items.Add("AP Credit Memo")
                    lstExcludeInbound.Items.Add("Goods Receipt PO")
                    lstExcludeInbound.Items.Add("Purchase Return")
                    lstExcludeInbound.Items.Add("Delivery")
                    lstExcludeInbound.Items.Add("Inventory Transfer Request")
                    lstExcludeInbound.Items.Add("Inventory Transfer")
                    lstExcludeInbound.Items.Add("Goods Receipt")
                    lstExcludeInbound.Items.Add("Goods Issue")

                    lstExcludeOutbound.Items.Add("Item Master Data")
                    lstExcludeOutbound.Items.Add("BP Master Data")
                    lstExcludeOutbound.Items.Add("BOM")
                    lstExcludeOutbound.Items.Add("Purchase Request")
                    lstExcludeOutbound.Items.Add("Purchase Order")
                    lstExcludeOutbound.Items.Add("AR Invoice")
                    lstExcludeOutbound.Items.Add("AR Credit Memo")
                    lstExcludeOutbound.Items.Add("AP Invoice")
                    lstExcludeOutbound.Items.Add("AP Credit Memo")
                    lstExcludeOutbound.Items.Add("Goods Receipt PO")
                    lstExcludeOutbound.Items.Add("Purchase Return")
                    lstExcludeOutbound.Items.Add("Delivery")
                    lstExcludeOutbound.Items.Add("Inventory Transfer Request")
                    lstExcludeOutbound.Items.Add("Inventory Transfer")
                    lstExcludeOutbound.Items.Add("Goods Receipt")
                    lstExcludeOutbound.Items.Add("Goods Issue")
                Else
                    For Each oModules As DataRowView In oDotNet.Ds.Tables(0).DefaultView
                        Select Case oModules("Type")
                            Case "Inbound"

                                Select Case oModules("Include")
                                    Case "Y"
                                        lstIncludeInbound.Items.Add(oModules("Name"))
                                    Case "N"
                                        lstExcludeInbound.Items.Add(oModules("Name"))
                                End Select
                            Case "Outbound"
                                Select Case oModules("Include")
                                    Case "Y"
                                        lstIncludeOutbound.Items.Add(oModules("Name"))
                                    Case "N"
                                        lstExcludeOutbound.Items.Add(oModules("Name"))
                                End Select
                        End Select
                    Next
                End If
            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub MoveItem(ByVal id As String)
        Try
            Select Case id
                Case 1
                    'Dim count As Integer = lstIncludeInbound.Items.Count
                    lstIncludeInbound.Items.Insert(0, lstExcludeInbound.SelectedItems.Item(0).Text)
                    lstExcludeInbound.Items.Remove(lstExcludeInbound.SelectedItems.Item(0))
                Case 2
                    'Dim count As Integer
                    For Each lst As ListViewItem In lstExcludeInbound.Items
                        'count = lstIncludeInbound.Items.Count
                        lstIncludeInbound.Items.Insert(0, lstExcludeInbound.Items.Item(lst.Index).Text)
                        lstExcludeInbound.Items.Remove(lst)
                    Next
                Case 3
                    'Dim count As Integer = lstExcludeInbound.Items.Count
                    lstExcludeInbound.Items.Insert(0, lstIncludeInbound.SelectedItems.Item(0).Text)
                    lstIncludeInbound.Items.Remove(lstIncludeInbound.SelectedItems.Item(0))
                Case 4
                    'Dim count As Integer
                    For Each lst As ListViewItem In lstIncludeInbound.Items
                        'count = lstExcludeInbound.Items.Count
                        lstExcludeInbound.Items.Insert(0, lstIncludeInbound.Items.Item(lst.Index).Text)
                        lstIncludeInbound.Items.Remove(lst)
                    Next
                Case 5
                    'Dim count As Integer = lstIncludeOutbound.Items.Count
                    lstIncludeOutbound.Items.Insert(0, lstExcludeOutbound.SelectedItems.Item(0).Text)
                    lstExcludeOutbound.Items.Remove(lstExcludeOutbound.SelectedItems.Item(0))
                Case 6
                    'Dim count As Integer
                    For Each lst As ListViewItem In lstExcludeOutbound.Items
                        'count = lstIncludeOutbound.Items.Count
                        lstIncludeOutbound.Items.Insert(0, lstExcludeOutbound.Items.Item(lst.Index).Text)
                        lstExcludeOutbound.Items.Remove(lst)
                    Next
                Case 7
                    'Dim count As Integer = lstExcludeOutbound.Items.Count
                    lstExcludeOutbound.Items.Insert(0, lstIncludeOutbound.SelectedItems.Item(0).Text)
                    lstIncludeOutbound.Items.Remove(lstIncludeOutbound.SelectedItems.Item(0))
                Case 8
                    Dim count As Integer
                    For Each lst As ListViewItem In lstIncludeOutbound.Items
                        'count = lstExcludeOutbound.Items.Count
                        lstExcludeOutbound.Items.Insert(0, lstIncludeOutbound.Items.Item(lst.Index).Text)
                        lstIncludeOutbound.Items.Remove(lst)
                    Next
            End Select
        Catch ex As Exception
        End Try
    End Sub
#Region "MoveItems"
    Private Sub btnInclude_Click(sender As Object, e As EventArgs) Handles btnIncludeInbound.Click
        MoveItem(1)
    End Sub

    Private Sub btnIncludeALL_Click(sender As Object, e As EventArgs) Handles btnIncludeALLInbound.Click
        MoveItem(2)
    End Sub

    Private Sub btnExclude_Click(sender As Object, e As EventArgs) Handles btnExcludeInbound.Click
        MoveItem(3)
    End Sub

    Private Sub btnExcludeALL_Click(sender As Object, e As EventArgs) Handles btnExcludeALLInbound.Click
        MoveItem(4)
    End Sub
    Private Sub btnIncludeOutbound_Click(sender As Object, e As EventArgs) Handles btnIncludeOutbound.Click
        MoveItem(5)
    End Sub

    Private Sub btnIncludeALLOutbound_Click(sender As Object, e As EventArgs) Handles btnIncludeALLOutbound.Click
        MoveItem(6)
    End Sub

    Private Sub btnExcludeOutbound_Click(sender As Object, e As EventArgs) Handles btnExcludeOutbound.Click
        MoveItem(7)
    End Sub

    Private Sub btnExcludeAllOutbound_Click(sender As Object, e As EventArgs) Handles btnExcludeAllOutbound.Click
        MoveItem(8)
    End Sub
#End Region
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If oRegistry.GetKeyValue("ServerType") = 9 Then
                Dim oDotNet As New APP_HANADb(oRegistry.GetKeyValue("ServerName"), oRegistry.GetKeyValue("UserName"), AppTech.Decrypt(oRegistry.GetKeyValue("Password")), oRegistry.GetKeyValue("Database"))
                For Each oModIn As ListViewItem In lstIncludeInbound.Items
                    oDotNet.strCommand = "SELECT * FROM ""APP_Integration"".""APP_Modules"" Where ""Code""='" & oModIn.Text & "' and ""Type""='Inbound'"
                    If oDotNet.Ds.Tables(0).Rows.Count = 0 Then
                        oDotNet.strCommand = "INSERT INTO ""APP_Integration"".""APP_Modules"" VALUES ('" & oModIn.Text & "','" & oModIn.Text & "','Y','Inbound',CURRENT_TIMESTAMP,'" & oRegistry.GetKeyValue("SAPUser") & "',CURRENT_TIMESTAMP(),'" & oRegistry.GetKeyValue("SAPUser") & "')"
                    Else
                        oDotNet.strCommand = "UPDATE ""APP_Integration"".""APP_Modules"" SET ""Include""='Y' WHERE ""Code""='" & oModIn.Text & "' and ""Type""='Inbound'"
                    End If
                Next

                For Each oModEx As ListViewItem In lstExcludeInbound.Items
                    oDotNet.strCommand = "SELECT * FROM ""APP_Integration"".""APP_Modules"" Where ""Code""='" & oModEx.Text & "' and ""Type""='Inbound'"
                    If oDotNet.Ds.Tables(0).Rows.Count = 0 Then
                        oDotNet.strCommand = "INSERT INTO ""APP_Integration"".""APP_Modules"" VALUES ('" & oModEx.Text & "','" & oModEx.Text & "','N','Inbound',CURRENT_TIMESTAMP(),'" & oRegistry.GetKeyValue("SAPUser") & "',CURRENT_TIMESTAMP(),'" & oRegistry.GetKeyValue("SAPUser") & "')"
                    Else
                        oDotNet.strCommand = "UPDATE ""APP_Integration"".""APP_Modules"" SET ""Include""='N' WHERE ""Code""='" & oModEx.Text & "' and ""Type""='Inbound'"
                    End If
                Next

                For Each oModIn As ListViewItem In lstIncludeOutbound.Items
                    oDotNet.strCommand = "SELECT * FROM ""APP_Integration"".""APP_Modules"" Where ""Code""='" & oModIn.Text & "' and ""Type""='Outbound'"
                    If oDotNet.Ds.Tables(0).Rows.Count = 0 Then
                        oDotNet.strCommand = "INSERT INTO ""APP_Integration"".""APP_Modules"" VALUES ('" & oModIn.Text & "','" & oModIn.Text & "','Y','Outbound',CURRENT_TIMESTAMP,'" & oRegistry.GetKeyValue("SAPUser") & "',CURRENT_TIMESTAMP(),'" & oRegistry.GetKeyValue("SAPUser") & "')"
                    Else
                        oDotNet.strCommand = "UPDATE ""APP_Integration"".""APP_Modules"" SET ""Include""='Y' WHERE ""Code""='" & oModIn.Text & "' and ""Type""='Outbound'"
                    End If
                Next

                For Each oModEx As ListViewItem In lstExcludeOutbound.Items
                    oDotNet.strCommand = "SELECT * FROM ""APP_Integration"".""APP_Modules"" Where ""Code""='" & oModEx.Text & "' and ""Type""='Outbound'"
                    If oDotNet.Ds.Tables(0).Rows.Count = 0 Then
                        oDotNet.strCommand = "INSERT INTO ""APP_Integration"".""APP_Modules"" VALUES ('" & oModEx.Text & "','" & oModEx.Text & "','N','Outbound',CURRENT_TIMESTAMP(),'" & oRegistry.GetKeyValue("SAPUser") & "',CURRENT_TIMESTAMP(),'" & oRegistry.GetKeyValue("SAPUser") & "')"
                    Else
                        oDotNet.strCommand = "UPDATE ""APP_Integration"".""APP_Modules"" SET ""Include""='N' WHERE ""Code""='" & oModEx.Text & "' and ""Type""='Outbound'"
                    End If
                Next
            ElseIf oRegistry.GetKeyValue("ServerType") = 6 Or oRegistry.GetKeyValue("ServerType") = 7 Or oRegistry.GetKeyValue("ServerType") = 8 Or oRegistry.GetKeyValue("ServerType") = 10 Then
                Dim oDotNet As New App_SqlDb(oRegistry.GetKeyValue("ServerName"), oRegistry.GetKeyValue("UserName"), AppTech.Decrypt(oRegistry.GetKeyValue("Password")), oRegistry.GetKeyValue("Database"))
                For Each oModIn As ListViewItem In lstIncludeInbound.Items
                    oDotNet.strCommand = "SELECT * FROM APP_Integration..APP_Modules Where Code='" & oModIn.Text & "' and Type='Inbound'"
                    If oDotNet.Ds.Tables(0).Rows.Count = 0 Then
                        oDotNet.strCommand = "INSERT INTO APP_Integration..APP_Modules VALUES ('" & oModIn.Text & "','" & oModIn.Text & "','Y','Inbound',GETDATE(),'" & oRegistry.GetKeyValue("SAPUser") & "',GETDATE(),'" & oRegistry.GetKeyValue("SAPUser") & "')"
                    Else
                        oDotNet.strCommand = "UPDATE APP_Integration..APP_Modules SET Include='Y' WHERE Code='" & oModIn.Text & "' and Type='Inbound'"
                    End If
                Next

                For Each oModEx As ListViewItem In lstExcludeInbound.Items
                    oDotNet.strCommand = "SELECT * FROM APP_Integration..APP_Modules Where Code='" & oModEx.Text & "' and Type='Inbound'"
                    If oDotNet.Ds.Tables(0).Rows.Count = 0 Then
                        oDotNet.strCommand = "INSERT INTO APP_Integration..APP_Modules VALUES ('" & oModEx.Text & "','" & oModEx.Text & "','N','Inbound',GETDATE(),'" & oRegistry.GetKeyValue("SAPUser") & "',GETDATE(),'" & oRegistry.GetKeyValue("SAPUser") & "')"
                    Else
                        oDotNet.strCommand = "UPDATE APP_Integration..APP_Modules SET Include='N' WHERE Code='" & oModEx.Text & "' and Type='Inbound'"
                    End If
                Next

                For Each oModIn As ListViewItem In lstIncludeOutbound.Items
                    oDotNet.strCommand = "SELECT * FROM APP_Integration..APP_Modules Where Code='" & oModIn.Text & "' and Type='Outbound'"
                    If oDotNet.Ds.Tables(0).Rows.Count = 0 Then
                        oDotNet.strCommand = "INSERT INTO APP_Integration..APP_Modules VALUES ('" & oModIn.Text & "','" & oModIn.Text & "','Y','Outbound',GETDATE(),'" & oRegistry.GetKeyValue("SAPUser") & "',GETDATE(),'" & oRegistry.GetKeyValue("SAPUser") & "')"
                    Else
                        oDotNet.strCommand = "UPDATE APP_Integration..APP_Modules SET Include='Y' WHERE Code='" & oModIn.Text & "' and Type='Outbound'"
                    End If
                Next

                For Each oModEx As ListViewItem In lstExcludeOutbound.Items
                    oDotNet.strCommand = "SELECT * FROM APP_Integration..APP_Modules Where Code='" & oModEx.Text & "' and Type='Outbound'"
                    If oDotNet.Ds.Tables(0).Rows.Count = 0 Then
                        oDotNet.strCommand = "INSERT INTO APP_Integration..APP_Modules VALUES ('" & oModEx.Text & "','" & oModEx.Text & "','N','Outbound',GETDATE(),'" & oRegistry.GetKeyValue("SAPUser") & "',GETDATE(),'" & oRegistry.GetKeyValue("SAPUser") & "')"
                    Else
                        oDotNet.strCommand = "UPDATE APP_Integration..APP_Modules SET Include='N' WHERE Code='" & oModEx.Text & "' and Type='Outbound'"
                    End If
                Next

            End If
            Call CheckFormsIncluded()
            MsgBox("Successfully Saved!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox("Module Configuration not saved!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End Try
    End Sub


End Class