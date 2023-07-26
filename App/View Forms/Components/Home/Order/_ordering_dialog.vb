Public Class _ordering_dialog

    Public order As Ordering
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        windowWrapper.Hide()
        switchPanel(_shoppage.windowWrapper, windowWrapper)
    End Sub

    Private Sub _ordering_dialog_Load(sender As Object, e As EventArgs) Handles windowWrapper.ForeColorChanged
        If windowWrapper.ForeColor <> activeForeColor Then Return


        LoadContents()

    End Sub


    Public Sub LoadContents()

        order.order_info = New Dictionary(Of String, String)
        If shipping_fee.Text = "" Then rbt_standard.PerformClick()

        item_name.Text = order.product("item_name")
        price.Text = "₱" & order.product("price")
        quantity.Text = order.quantity
        lbQuant.Text = order.quantity

        customer_name.Text = order.customer("first_name") & " " & order.customer("last_name")
        shipping_address.Text = order.customer("address")
        phone_number.Text = order.customer("phone_number")
        sub_total.Text = "₱" & order.product("price") * order.quantity

        If order.product("image_dir") IsNot DBNull.Value Then
            itemImage.Image = Image.FromFile(order.product("image_dir"))
            itemImage.SizeMode = ImageLayout.Zoom
        Else
            itemImage.Image = My.Resources.icons8_no_image_30
            itemImage.SizeMode = ImageLayout.Center
        End If

    End Sub

    Private Sub rbt_standard_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_express.Click, rbt_priority.Click, rbt_standard.Click


        Select Case sender.name
            Case "rbt_standard"
                shipping_fee.Text = 150
                order.order_info("shipping_fee") = 150
                order.order_info("shipping_type") = "Standard"
                order.order_info("shipping_interval") = "7"

            Case "rbt_express"
                shipping_fee.Text = 300
                order.order_info("shipping_fee") = 300
                order.order_info("shipping_type") = "Express"
                order.order_info("shipping_interval") = "3"

            Case "rbt_priority"
                shipping_fee.Text = 500
                order.order_info("shipping_fee") = 500
                order.order_info("shipping_type") = "Priority"
                order.order_info("shipping_interval") = "2"

        End Select

        order.order_info("total_cost") = order.product("price") * order.quantity + order.order_info("shipping_fee")
        total_cost.Text = "₱" & order.order_info("total_cost")



    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Select Case btnConfirm.Text
            Case "Place Order"
                order.MakeOrder()
            Case "Save Order"
                order.UpdateOrder()
        End Select
        switchPanel(_orderpage.windowWrapper, windowWrapper)
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        switchPanel(_shoppage.windowWrapper, windowWrapper)

    End Sub

    Private Sub addQuant_Click(sender As Object, e As EventArgs) Handles addQuant.Click, subQuant.Click
        Select Case sender.name
            Case "addQuant"
                If order.product("stock_quantity") > order.quantity Then order.quantity += 1
            Case "subQuant"
                If order.quantity > 1 Then order.quantity -= 1
        End Select

        order.order_info("total_cost") = order.product("price") * order.quantity + order.order_info("shipping_fee")
        lbQuant.Text = order.quantity
        quantity.Text = order.quantity
        sub_total.Text = "₱" & order.product("price") * order.quantity
        total_cost.Text = "₱" & order.order_info("total_cost")

    End Sub
End Class