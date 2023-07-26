Public Class _shoppage
    Private Sub windowWrapper_VisibleChanged(sender As Object, e As EventArgs) Handles windowWrapper.ForeColorChanged

        If windowWrapper.ForeColor <> activeForeColor Then Return


    End Sub

    '
    ' SHOP PAGE AND CONTROLS
    '
    Public Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim search As String = txtSearch.Text
        If String.IsNullOrEmpty(search) Then Return

        Dim dt As DataTable = FilterFrom("product", "description", search)
        If dt Is Nothing Then Return

        ProductFromSource(dt)
    End Sub
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        If _filterbar.search_bar.ForeColor <> activeForeColor Then
            btnFilter.Text = "Search Product"
            switchPanel(_filterbar.search_bar, search_bar)
        Else
            btnFilter.Text = "Shop Filters"
            switchPanel(search_bar, _filterbar.search_bar)
        End If

    End Sub
End Class