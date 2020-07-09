﻿Public Class IntegrationAPIConfig
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
    Private Sub IntegrationAPIConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call SETAPIConfUI()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class