Imports System.ComponentModel
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class _profilepage

    Private user_info_controls As ArrayList
    Private profile_info As Dictionary(Of String, Object)

    Private Sub windowWrapper_ForeColorChanged(sender As Object, e As EventArgs) Handles windowWrapper.ForeColorChanged

        If Not windowWrapper.ForeColor = activeForeColor Then Return
        Reload()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click, btnLogOut.Click

        Select Case sender.text
            Case "Edit"
                btnEdit.Text = "Save"
                btnEdit.BackColor = Color.PaleGreen
                btnLogOut.Text = "Cancel"
                toggleEnable(user_info_controls, True)
            Case "Save", "Cancel"
                If sender.text = "Save" Then UpdateInfo()
                Reload()

            Case "Log Out"
                Application.Restart()
        End Select

    End Sub


    Private Sub toggleEnable(ByRef controls As ArrayList, state As Boolean)
        For Each c In controls
            c.enabled = state
        Next
    End Sub

    Private Sub UpdateInfo()

        If profile_info("username") <> username.Text AndAlso userExists(username.Text) Then
            MsgBox("Username already exists")
            username.Focus()
            Return
        End If

        Dim age As Integer = DateTime.Now.Year - birthdate.Value.Year
        profile_info("first_name") = first_name.Text
        profile_info("last_name") = last_name.Text
        profile_info("middle_name") = middle_name.Text

        current_user("username") = username.Text
        profile_info("username") = username.Text

        profile_info("email") = email.Text
        profile_info("address") = $"{street_address.Text}, {user_city.Text}, {user_region.Text}, {country.Text}, {zipcode.Text}"
        profile_info("phone_number") = phone_number.Text
        profile_info("birthdate") = $"{birthdate.Value.ToString("yyyy/MM/dd")}"
        profile_info("age") = age.ToString()

        UpdateAccount(profile_info)
    End Sub

    Private Sub Reload()
        SetCurrentUser(current_user("username"))
        profile_info = DataRowToDictionary(current_user)


        btnEdit.Text = "Edit"
        btnEdit.BackColor = Color.Transparent
        btnLogOut.Text = "Log Out"
        user_info_controls = New ArrayList({
                first_name,
                last_name,
                middle_name,
                username,
                email,
                street_address,
                user_city,
                user_region,
                zipcode,
                country,
                phone_number,
                birthdate,
                btnSelectImage,
                labelAge
                })
        toggleEnable(user_info_controls, False)
        Dim lol = citylabel

        first_name.Text = profile_info("first_name")
        last_name.Text = profile_info("last_name")
        middle_name.Text = profile_info("middle_name")
        username.Text = profile_info("username")
        email.Text = profile_info("email")

        Dim address As String() = profile_info("address").Split(",")
        street_address.Text = address(0)
        user_city.Text = address(1)
        user_region.Text = address(2)
        country.Text = address(3)
        zipcode.Text = address(4)

        phone_number.Text = profile_info("phone_number")
        birthdate.Value = profile_info("birthdate")
        labelAge.Text = profile_info("age")



    End Sub
End Class