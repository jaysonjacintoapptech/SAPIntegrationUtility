Imports System.Data.SqlClient
Imports System.Data

Public Class App_SqlDb

    Public DotNet As App_DotNet
    Private oSqlConnection As SqlConnection, oSqlDataAdapter As SqlDataAdapter, oSqlCommand As SqlCommand, oSqlTransaction As SqlTransaction
    Public Ds As DataSet
    Private _strCommand As String
    Public Property strCommand() As String
        Get
            Return _strCommand
        End Get
        Set(ByVal value As String)
            _strCommand = value
            DbQuery()
        End Set
    End Property

    Dim _SqlServer As String
    Dim _SqlId As String
    Dim _SqlPassword As String
    Dim _SqlDb As String
    Sub New(ByVal oSqlServer As String, ByVal oSqlId As String, ByVal oSqlPassword As String, ByVal oSqlDb As String, Optional ByVal oAPP_DotNet As App_DotNet = Nothing)

        Select Case IsNothing(oAPP_DotNet)
            Case True
                DotNet = New App_DotNet(My.Application.Info.ProductName)
            Case False
                DotNet = oAPP_DotNet
        End Select
        _SqlServer = oSqlServer
        _SqlId = oSqlId
        _SqlPassword = oSqlPassword
        _SqlDb = oSqlDb
        'oSqlConnection = New SqlConnection("data source=" & oSqlServer & "; user id=" & oSqlId & "; password=" & oSqlPassword & "; initial catalog=" & oSqlDb & "") 

    End Sub

    Public ReadOnly Property GetField(Optional ByVal oRow As Object = 0, Optional ByVal oColumn As Object = 0) As Object
        Get
            Return Ds.Tables(0).Rows(oRow).Item(oColumn)
        End Get
    End Property

    Private Sub DbQuery()
        Try
            'oSqlCommand = oSqlConnection.CreateCommand

            'If _InTransaction_Initial Then
            '    oSqlConnection.Open()
            '    oSqlTransaction = oSqlConnection.BeginTransaction("AppSql")
            '    _InTransaction_Initial = False
            'End If
            'oSqlCommand.Transaction = oSqlTransaction

            'oSqlCommand.CommandText = _strCommand
            'oSqlCommand.CommandTimeout = 0

            'oSqlDataAdapter = New SqlDataAdapter(oSqlCommand)
            Ds = New DataSet
            'oSqlDataAdapter.Fill(Ds)

            Using oCon = New SqlConnection("data source=" & _SqlServer & "; user id=" & _SqlId & "; password=" & _SqlPassword & "; initial catalog=" & _SqlDb & "")
                Using oCommand = New SqlCommand(_strCommand, oCon)
                    oCommand.CommandTimeout = 0
                    Using oDa = New SqlDataAdapter(oCommand)
                        oDa.Fill(Ds)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            oWriteText(MainForm.LsView, ex.ToString, Color.Red, True)
            Console.WriteLine(ex.ToString)
        End Try
    End Sub

    Private _InTransaction_Initial As Boolean = False, InTransaction As Boolean
    Public Sub StartTransaction()
        _InTransaction_Initial = True
        InTransaction = True
    End Sub

    Public Sub RollBack_Transaction()
        Try
            oSqlTransaction.Rollback()
        Catch ex As Exception
        End Try
        Try
            oSqlConnection.Close()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Commit_Transaction()
        Try
            oSqlTransaction.Commit()

        Catch ex As Exception
        End Try
        Try
            oSqlConnection.Close()
        Catch ex As Exception

        End Try
    End Sub

End Class
