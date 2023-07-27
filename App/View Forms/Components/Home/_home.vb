Public Class _home
    Private Sub home_FormClosed() Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub _home_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If role Is "viewer" Then
            btnSettings.Image = My.Resources.signinBtn
            ToggleControls({btnCart, btnProfile, btnOrders}, False)
        Else
            ToggleControls({btnCart, btnProfile, btnSettings, btnOrders}, True)
        End If
        CreateHandlers()




    End Sub

    Private Sub selectNav(sender As Object, e As EventArgs) Handles MyBase.Load, btnShop.Click, btnCart.Click, btnProfile.Click, btnSettings.Click, btnOrders.Click

        Reload()
        Select Case sender.name
            Case MyBase.Name
                switchPanel(_shoppage.windowWrapper, windowWrapper)
                ProductFromSource()
            Case "btnShop"
                switchPanel(_shoppage.windowWrapper, currentPage)

            Case "btnCart"
                switchPanel(_cartpage.windowWrapper, currentPage)

            Case "btnOrders"
                switchPanel(_orderpage.windowWrapper, currentPage)

            Case "btnProfile"
                switchPanel(_profilepage.windowWrapper, currentPage)

            Case "btnSettings"
                If role Is "viewer" Then
                    Me.Hide()
                    _login.ShowDialog()
                    Exit Sub
                End If
                switchPanel(_settingspage.windowWrapper, currentPage)
        End Select


    End Sub

    Private Sub Reload()
        If Not isConnected() Then
            Application.Exit()
        End If

        ClearCartSummaries()
        If transactionQuery.ContainsKey("name") AndAlso transactionQuery("name") = "delete" Then
            CompleteTransaction(0)
        Else
            transactionQuery.Clear()
        End If
    End Sub

    Private Sub CreateHandlers()
        'AddHandler btnDebug.Click, AddressOf btnDebugger_Click

        AddHandler btnShop.MouseEnter, AddressOf HoverEvents
        AddHandler btnCart.MouseEnter, AddressOf HoverEvents
        AddHandler btnProfile.MouseEnter, AddressOf HoverEvents
        AddHandler btnOrders.MouseEnter, AddressOf HoverEvents
        AddHandler btnSettings.MouseEnter, AddressOf HoverEvents

        AddHandler btnShop.MouseLeave, AddressOf HoverEvents
        AddHandler btnCart.MouseLeave, AddressOf HoverEvents
        AddHandler btnProfile.MouseLeave, AddressOf HoverEvents
        AddHandler btnSettings.MouseLeave, AddressOf HoverEvents
        AddHandler btnOrders.MouseLeave, AddressOf HoverEvents
    End Sub

    Private Sub windowWrapper_Paint(sender As Object, e As PaintEventArgs) Handles windowWrapper.Paint

    End Sub

End Class
