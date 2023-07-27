Imports System.Web

Public Class _filterbar

    Private category = ""
    Private brand = ""
    Private filters = ""
    Private order = "DESC"
    Private condition = ""

    Private Sub OnPanelLoad(sender As Object, e As EventArgs) Handles search_bar.ForeColorChanged
        If search_bar.ForeColor <> activeForeColor Then Return
        Reload()
    End Sub

    Private Sub cmb_filters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_filters.SelectedIndexChanged, cmb_brand.SelectedIndexChanged, cmb_category.SelectedIndexChanged

        If sender.text = "" Then Return

        Select Case sender.name
            Case "cmb_filters"
                If sender.text = "All" Then filters = $""
                If sender.text = "Name" Then filters = $"ORDER BY item_name"
                If sender.text = "Quantity" Then filters = $"ORDER BY stock_quantity"
                If sender.text = "Price" Then filters = $"ORDER BY price"

            Case "cmb_category"
                If sender.text = "All" Then
                    category = $""
                    Exit Select
                End If
                category = sender.text

            Case "cmb_brand"
                If sender.text = "All" Then
                    brand = $""
                    Exit Select
                End If
                brand = sender.text

        End Select

        SetCondition()

        Dim dt As DataTable = New DataTable
        dt = SelectAllFrom("product", condition:=condition)
        ProductFromSource(dt)

    End Sub

    Private Sub SetCondition()
        condition = $"WHERE category LIKE '%{category}%' AND brand LIKE '%{brand}%' {filters} {IIf(Not filters = "", order, "")}"
    End Sub

    Private Sub Reload()
        Try
            cmb_category.Text = ""
            cmb_brand.Text = ""
            cmb_filters.Text = ""
            cmb_category.Items.Clear()
            cmb_brand.Items.Clear()
            cmb_filters.Items.Clear()

            cmb_category.Items.Add("All")
            cmb_brand.Items.Add("All")
            cmb_filters.Items.Add("All")
            cmb_filters.Items.Add("Name")
            cmb_filters.Items.Add("Quantity")
            cmb_filters.Items.Add("Price")
            For Each row As DataRow In SelectAllFrom("product", "brand", "GROUP BY brand").Rows
                cmb_brand.Items.Add(row("brand"))
            Next
            For Each row As DataRow In SelectAllFrom("product", "category", "GROUP BY category").Rows
                cmb_category.Items.Add(row("category"))
            Next


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")

        End Try
    End Sub

    Private Sub btnSetOrder_Click(sender As Object, e As EventArgs) Handles btnSetOrder.Click
        If btnSetOrder.ForeColor <> activeForeColor Then
            order = "ASC"
            btnSetOrder.Image = My.Resources.icons8_ascending_sorting_15
            btnSetOrder.ForeColor = activeForeColor
        Else
            order = "DESC"
            btnSetOrder.Image = My.Resources.icons8_descending_sorting_15
            btnSetOrder.ForeColor = inactiveForeColor
        End If
        SetCondition()
        If filters = "" Then Return
        Dim dt As DataTable = New DataTable
        dt = SelectAllFrom("product", condition:=condition)
        ProductFromSource(dt)
    End Sub
End Class