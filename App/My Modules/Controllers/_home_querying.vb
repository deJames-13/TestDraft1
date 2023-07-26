Module HomeQueries

    Public transactionQuery As Dictionary(Of String, String) = New Dictionary(Of String, String)
    Public current_table As DataTable = Nothing
    Public current_user As DataRow = Nothing

    '#############################################################################################
    '
    ' CUSTOMER/USER ACCOUNT
    '
    '#############################################################################################

    '
    ' CREATING ACCOUNT
    '
    Public Sub CreateAccount(account As Dictionary(Of String, String), Optional table As String = "customer")

        Dim fields As String = String.Join(",", account.Keys.ToArray)
        Dim values As String = String.Join(",", account.Values.ToArray)

        InsertInto(table, fields, values)

    End Sub

    '
    ' UPDATING ACCOUNT
    '
    Public Sub UpdateAccount(account As Dictionary(Of String, Object), Optional table As String = "customer")

        Dim values As String = ""
        For Each field As KeyValuePair(Of String, Object) In account
            If field.Key = "created_at" Then Continue For
            values += $"{field.Key} = '{field.Value}',"
        Next
        values = values.TrimEnd(",")

        UpdateTable(table, values, $"id={account("id")}")
        MsgBox("Account Updated!", MsgBoxStyle.Information, "Account")

    End Sub
    '#############################################################################################




    '#############################################################################################
    '
    ' TRANSACTIONS - INSERTING, UPDATING and DELETING multiple datas done in one single transaction
    '
    '#############################################################################################
    '
    ' COMPLETE PENDING TRANSACTIONS
    '
    Public Sub CompleteTransaction(Optional showHistory = False)
        Try

            If transactionQuery.Count < 1 Then Return
            If showHistory Then If Not OnShowResult() Then Return


            Dim query As String = ""
            transactionQuery.Remove("name")
            For Each transaction As KeyValuePair(Of String, String) In transactionQuery
                query += transaction.Value & vbNewLine
            Next

            ExecuteNonQuery(query)
            transactionQuery.Clear()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error while performing the actions")
            transactionQuery.Clear()
        End Try
    End Sub

    '
    ' CREATE A TRANSACTION FROM CART and ORDER
    '
    Public Sub MakeTransactions(item As Dictionary(Of String, Object), transaction_type As String)
        Select Case transaction_type
            '
            ' MAKING AN ORDER RECORD FROM CART
            '
            Case "insert_order"
                Dim query As String =
$"
                INSERT INTO `order` (customer_id, shipping_type, ship_date)
                VALUES
                ({current_user("id")}, 'standard', NOW() + INTERVAL 7 DAY);

                INSERT INTO `order_has_product` (order_id, product_id, quantity, cost, status)
                VALUES
                (
                LAST_INSERT_ID(), 
                {item("product_id")}, 
                {item("quantity")}, 
                {item("cost_per_item") + 150}, 
                'pending'
                );

                DELETE FROM `cart` WHERE `cart`.`id` = {item("id")};
                "

                Dim key As String = $"{item("id")}"

                transactionQuery(key) = query
                transactionQuery("name") = "insert"

            '
            ' DELETING AN ORDER RECORD
            '
            Case "delete_order"
                Dim key As String = $"[{item("id")}][Item: {item("item_name")}] Removed from order."

                Dim delete_items As String = $"

                DELETE FROM `order_has_product` WHERE (`order_id` = '{item("id")}'); 
                DELETE FROM `order` WHERE (`id` = '{item("id")}'); 

                "

                transactionQuery(key) = delete_items
                transactionQuery("name") = "delete"

            '
            ' DELETING AN ITEM FROM CART
            '
            Case "delete_cart"
                Dim key As String = $"[{item("id")}][Item: {item("item_name")}] Removed from order."
                Dim delete_items As String = $"DELETE FROM `cart` WHERE `cart`.`id` = {item("id")};"

                transactionQuery(key) = delete_items
                transactionQuery("name") = "delete"

            '
            ' UPDATING AN ITEM FROM CART
            '
            Case "update_cart"
                Dim key As String = $"[UPDATED QUANTITY] {item("item_name")} = {item("new_quantity")}"
                Dim query As String = $"UPDATE cart SET quantity={item("new_quantity")} WHERE id={item("id")};"

                transactionQuery.Add(key, query)
                transactionQuery("name") = "update"

        End Select

    End Sub
    '#############################################################################################

    '#############################################################################################
    '
    ' CART QUERIES
    '
    '#############################################################################################

    '
    ' ADDING ITEM TO CART
    '
    Public Sub AddToCart(item As DataRow, quantity As Integer)

        Dim log As String = "Item Saved!" & vbNewLine
        'log += "Item ID: " & item("id") & vbNewLine
        'log += "Item Name: " & item("item_name") & vbNewLine
        'log += "Quantity: " & quantity & vbNewLine
        'log += "Price: " & item("price") & vbNewLine
        MsgBox(log, MsgBoxStyle.Information, "Cart")

        Dim fields As String = "customer_id, product_id, quantity"
        Dim values As String = $"{current_user("id")}, {item("id")}, {quantity}"
        InsertInto("cart", fields, values)


    End Sub



    '#############################################################################################
    '
    ' TABLE QUERIES
    '
    '#############################################################################################

    '
    ' Product rendering
    '
    Public Sub ProductFromSource(Optional source As DataTable = Nothing)

        Dim query As String = "SELECT * FROM product ORDER BY item_name ASC"
        Dim dt As New DataTable
        dt = IIf(source Is Nothing, ExecuteQuery(query), source)
        If dt.Rows.Count = 0 Then Return

        Dim parent As Control = _shoppage.itemsContainer
        Dim index As Integer
        Dim card As ProductCard

        _shoppage.itemsContainer.Controls.Clear()
        _shoppage.itemsContainer.Hide()

        For Each row As DataRow In dt.Rows


            card = New ProductCard(parent, index)
            card.MakeCard()
            card.SetProperties(row)
        Next

        _shoppage.itemsContainer.Show()

        current_table = dt
    End Sub


    '
    ' Orders rendering
    '
    Public Sub OrdersFromSource(Optional source As DataTable = Nothing)
        Dim query As String = $"

        SELECT
        ohp.order_id as id,
        ohp.order_id,
        ohp.product_id,
        o.customer_id,
        ohp.quantity,
        p.item_name,
        p.stock_quantity,
        p.price,
        ohp.cost,
        p.image_dir,
        o.shipping_type,
        o.ship_date,
        s.amount as shipping_fee,
        `ohp`.`status`
        FROM order_has_product as ohp
        INNER JOIN `order` as o
        ON ohp.order_id = o.id
        INNER JOIN product as p
        ON ohp.product_id = p.id
        INNER JOIN shipping_info as s
        ON o.shipping_type = s.`type`
        WHERE o.customer_id = {current_user("id")}
        
        "
        _sqlString = query


        Dim dt As New DataTable
        dt = IIf(source Is Nothing, ExecuteQuery(query), source)
        If dt.Rows.Count = 0 Then Return


        Dim order_item As Cart
        Dim parent As Control = _orderpage.order_itemContainer
        _orderpage.order_itemContainer.Controls.Clear()

        For Each row As DataRow In dt.Rows

            Dim i As Integer = row("order_id")
            order_item = New Cart(parent, i, row)
            order_item.MakeCartItem()
            order_item.SetProperties()
            order_item.SetOrderProperties()

            Select Case _orderpage.btnEditOrders.ForeColor
                Case Color.Red
                    order_item.btnSelect.BackgroundImage = My.Resources.icons8_unchecked_checkbox_30
                    order_item.btnSelect.ForeColor = Color.Black

                Case Color.Black
                    order_item.btnSelect.BackgroundImage = My.Resources.icons8_remove_20
                    order_item.btnSelect.ForeColor = Color.Yellow
            End Select
        Next

        current_table = dt

    End Sub


    '
    ' Cart rendering
    '
    Public Sub CartFromSource(Optional source As DataTable = Nothing)
        Dim query As String = $"
        SELECT 
        c.id,
        c.id as cart_id,
        c.customer_id,
        cust.username,
        c.product_id,
        p.item_name,
        p.price,
        c.quantity,
        (p.price * c.quantity) as cost_per_item,
        p.image_dir

        FROM cart as c
        INNER JOIN customer as cust
        ON c.customer_id = cust.id

        INNER JOIN product as p
        ON c.product_id = p.id

        WHERE cust.id = {current_user("id")};
;
        "

        Dim dt As New DataTable
        dt = IIf(source Is Nothing, ExecuteQuery(query), source)
        If dt.Rows.Count = 0 Then Return

        Dim new_cart As Cart
        Dim parent As Control = _cartpage.itemContainer
        _cartpage.itemContainer.Controls.Clear()

        For Each row As DataRow In dt.Rows
            Dim i As Integer = row("cart_id")
            new_cart = New Cart(parent, i, row)
            new_cart.MakeCartItem()
            new_cart.SetProperties()

            Select Case _cartpage.btnEdit.ForeColor
                Case Color.Red
                    new_cart.btnSelect.BackgroundImage = My.Resources.icons8_unchecked_checkbox_30
                    new_cart.btnSelect.ForeColor = Color.Black

                Case Color.Black
                    new_cart.btnSelect.BackgroundImage = My.Resources.icons8_remove_20
                    new_cart.btnSelect.ForeColor = Color.Yellow
            End Select
        Next

        current_table = dt
    End Sub

End Module
