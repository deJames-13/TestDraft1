
Public Class _cartpage

    Private Sub windowWrapper_VisibleChanged(sender As Object, e As EventArgs) Handles windowWrapper.ForeColorChanged

        If windowWrapper.ForeColor <> activeForeColor Then Return
        Reload()


    End Sub


    Private Sub Reload()
        cartButtons.Clear()
        itemContainer.Controls.Clear()
        itemContainer.Hide()


        RemoveHandler btnEdit.Click, AddressOf btnEdit_Click
        AddHandler btnEdit.Click, AddressOf btnEdit_Click
        RemoveHandler btnCheckOut.Click, AddressOf btnCheckOut_Click
        AddHandler btnCheckOut.Click, AddressOf btnCheckOut_Click



        CartFromSource()
        itemContainer.Show()
        txtTotal.Text = "0.00"
        btnEdit.BackgroundImage = My.Resources.icons8_edit_20
        btnEdit.ForeColor = Color.Red
        SetButtonState(My.Resources.icons8_unchecked_checkbox_30, Color.Black)
    End Sub


    '#############################################################################################
    '
    ' CART PAGE AND SUMMARY
    '
    '#############################################################################################

    '
    ' CHECK OUT BUTTON
    '
    Public Sub btnCheckOut_Click(sender As Object, e As EventArgs)
        Dim res As Integer = MsgBox("Are you sure you want to check out?", MsgBoxStyle.YesNo, "Confirm Orders")

        If res = DialogResult.No Then Return

        If transactionQuery.Keys.Contains("name") AndAlso transactionQuery("name") = "insert" Then CompleteTransaction()

        MsgBox("Items checked out successfully!", MsgBoxStyle.Information, "Success")
        switchPanel(_orderpage.windowWrapper, currentPage)
    End Sub



End Class