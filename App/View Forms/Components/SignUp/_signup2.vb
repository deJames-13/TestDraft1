Imports System.Security.Principal

Public Class _signup2
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        switchPanel(_signuptemp.mainPanel, mainPanel)
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        If Not validInputs({username, phone_number, city, country, street_address, zipcode}) Then
            Return
        End If

        If userExists(username.Text) Then
            MsgBox("Username already exists!", MsgBoxStyle.Exclamation, "Username Exists!")
            Return
        End If



        Dim address As String = $"""{street_address.Text}, {city.Text}, {province.Text}, {country.Text}, {zipcode.Text}"""
        Dim age As Integer = DateTime.Now.Year - birthdate.Value.Year

        customer_info("username") = $"""{username.Text}"""
        customer_info("phone_number") = $"""{phone_number.Text}"""
        customer_info("address") = address
        customer_info("birthdate") = $"'{birthdate.Value.ToString("yyyy/MM/dd")}'"
        customer_info("age") = age.ToString()


        Dim result As Integer = MsgBox("Do you want to save this account?", MsgBoxStyle.YesNo, "Confirm Account Creation")

        If Not result = DialogResult.Yes Then
            Return
        End If

        CreateAccount(customer_info)



        Me.Hide()
        _signup1.Hide()
        _login.Show()

        ' CLEAN ALL FIELDS
        Dim f As _signuptemp = _signuptemp
        ClearAll({
                     f.first_name, f.last_name, f.middle_name, f.user_email, f.user_password, f.confirm_password,
                     username, phone_number, city, province, country, street_address, zipcode
                })
        customer_info.Clear()

    End Sub


End Class