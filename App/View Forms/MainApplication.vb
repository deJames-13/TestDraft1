Imports System.Runtime.InteropServices

Public Class MainApplication
    Private Sub MainApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the main application
    End Sub
    Private Sub MainApplication_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        ' Load the main application

    End Sub


    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        Me.Hide()
        _login.role = "customer"
        _login.ShowDialog()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Hide()
        _login.role = "user"
        _login.btnSignUp.Visible = False
        _login.ShowDialog()
    End Sub
End Class
