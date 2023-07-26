Imports System.Reflection

Public Class _viewitemdialog

    Public item As DataRow
    Dim quant As Integer = 1
    ' my base load
    Private Sub _viewitemdialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        windowTitle.Text = "View Item ID: " & item("id")
        item_name.Text = item("item_name")
        price.Text = "₱" & item("price")
        stock_quantity.Text = item("stock_quantity")
        tags_specification.Text = item("description")
        quantity.Text = quant


        If item("image_dir") IsNot DBNull.Value Then
            itemImage.Image = Image.FromFile(item("image_dir"))
            itemImage.SizeMode = ImageLayout.Zoom
        Else
            itemImage.Image = My.Resources.icons8_no_image_30
            itemImage.SizeMode = ImageLayout.Center

        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub changeQuantity(sender As Object, e As EventArgs) Handles addQuant.Click, subQuant.Click
        Select Case sender.name
            Case "addQuant"
                If Val(quant) < item("stock_quantity") Then
                    quant += 1
                    quantity.Text = quant
                End If
            Case "subQuant"

                If quant > 1 Then
                    quant -= 1
                    quantity.Text = quant
                End If
        End Select

    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        AddToCart(item, quant)

    End Sub

    Private Sub btnOrderNow_Click(sender As Object, e As EventArgs) Handles btnOrderNow.Click
        Me.Close()

        _ordering_dialog.order = New Ordering(current_user, item, quant)
        switchPanel(_ordering_dialog.windowWrapper, currentPage)


    End Sub
End Class