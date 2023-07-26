Imports System.Runtime.Hosting

Public Class _login

    Public role As String = "customer"
    Private Sub _login_Closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
    Private Sub _login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        If isConnected() Then
            Me.Show()
        Else
            Me.Close()
        End If

    End Sub


    Private Sub togglePass_Click(sender As Object, e As EventArgs) Handles togglePass.Click

        togglePass.Image = Nothing

        Select Case togglePass.ForeColor
            Case Color.Black
                togglePass.Image = My.Resources.icons8_closed_eye_20
                togglePass.ForeColor = Color.Red
                txtPass.PasswordChar = "•"
            Case Color.Red
                togglePass.Image = My.Resources.icons8_eye_20
                txtPass.PasswordChar = ""
                togglePass.ForeColor = Color.Black
        End Select



    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        _signup1.ShowDialog()
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not isValidUser(txtUsername.Text, txtPass.Text, role) Then
            Return
        End If

        SetCurrentUser(txtUsername.Text, role)

        Select Case role
            Case "user"
                Me.Hide()
                AdminMain.Show()
            Case "customer"
                Me.Hide()
                _home.Show()
        End Select

    End Sub

End Class