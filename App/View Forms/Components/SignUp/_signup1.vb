Public Class _signup1
    Private Sub _signup1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.BackgroundImage = My.Resources.baclground_portrait_2
        switchPanel(_signuptemp.mainPanel, mainPanel)
    End Sub

    Private Sub _signup1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class