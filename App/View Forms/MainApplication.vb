Imports System.Runtime.InteropServices

Public Class MainApplication
    Private Sub MainApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the main application
    End Sub
    Private Sub MainApplication_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        ' Load the main application

    End Sub

    Private Sub OnRoleSelection(sender As Object, e As EventArgs) Handles btnAdmin.Click, btnCustomer.Click
        Me.Hide()

        Select Case sender.name
            Case "btnCustomer"

                role = "viewer"
                _home.ShowDialog()

            Case "btnAdmin"

                role = "user"
                _login.btnSignUp.Visible = False
                _login.ShowDialog()
        End Select
    End Sub
End Class
