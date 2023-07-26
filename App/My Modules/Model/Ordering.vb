
Public Class Ordering

    Public customer As DataRow
    Public product As DataRow
    Public quantity As Integer


    Public order_info As New Dictionary(Of String, String)
    'Public shipping_info As New DataTable

    Public Sub New(ByVal customer As DataRow, ByVal product As DataRow, ByVal quantity As Integer)
        Me.customer = customer
        Me.product = product
        Me.quantity = quantity
        'shipping_info = SelectAllFrom("shipping_info")
    End Sub

    Public Sub MakeOrder()

        Try
            Dim query As String =
            $"
            INSERT INTO `order` (customer_id, shipping_type, ship_date)
            VALUES
            ({customer("id")}, '{order_info("shipping_type")}', NOW() + INTERVAL {order_info("shipping_interval")} DAY);

            INSERT INTO `order_has_product` (order_id, product_id, quantity, cost, status)
            VALUES
            (LAST_INSERT_ID(), {product("id")}, {quantity}, {order_info("total_cost")}, 'pending');
            "

            ExecuteNonQuery(query)

            MsgBox("Order has been placed successfully!", MsgBoxStyle.Information, "Order Placed")

        Catch ex As Exception

        End Try




    End Sub


    Public Sub UpdateOrder()
        Dim query As String =
        $"

            UPDATE `order_has_product` SET quantity = {quantity}, cost = {order_info("total_cost")}
            WHERE order_id = {product("id")} AND product_id = {product("product_id")};

            UPDATE `order` SET shipping_type = '{order_info("shipping_type")}', ship_date = NOW() + INTERVAL {order_info("shipping_interval")} DAY
            WHERE id = {product("id")};

            "


        ExecuteNonQuery(query)
        MsgBox("Order Info has been updated!", MsgBoxStyle.Information, "Order Update")



    End Sub



End Class