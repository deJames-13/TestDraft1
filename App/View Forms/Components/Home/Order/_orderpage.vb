Public Class _orderpage
    Private Sub windowWrapper_VisibleChanged(sender As Object, e As EventArgs) Handles windowWrapper.ForeColorChanged

        If windowWrapper.ForeColor <> activeForeColor Then Return

        Reload()

    End Sub

    Private Sub status_Click(sender As Object, e As EventArgs) Handles btnPending.Click, btnShipping.Click, btnDelivered.Click, btnCancelled.Click
        Dim btn As Button = sender
        Dim status As String = btn.Text.ToLower
        Dim dt As DataTable = ExecuteQuery(_sqlString & $"AND status = '{status}'")

        If dt.Rows.Count < 1 Then
            cartButtons.Clear()
            order_itemContainer.Controls.Clear()
        Else
            Reload(dt)
        End If


    End Sub

    Private Sub Reload(Optional dt As DataTable = Nothing)

        RemoveHandler btnEditOrders.Click, AddressOf btnEdit_Click
        AddHandler btnEditOrders.Click, AddressOf btnEdit_Click

        cartButtons.Clear()
        order_itemContainer.Hide()
        order_itemContainer.Controls.Clear()

        OrdersFromSource(dt)

        order_itemContainer.Show()
        btnEditOrders.BackgroundImage = My.Resources.icons8_remove_20
        btnEditOrders.ForeColor = Color.LightCoral
        SetButtonState(My.Resources.icons8_unchecked_checkbox_30, Color.Blue)
    End Sub
End Class