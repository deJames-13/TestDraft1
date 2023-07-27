Module WindowPageManager

    Public Function validNumber(str As String) As Boolean
        If IsNumeric(str) Then
            Return True
        End If
        Return False
    End Function

    Public Function isEmptyInput(ByRef input As TextBox, Optional message As String = "Input Required!") As Boolean
        If String.IsNullOrEmpty(input.Text.Trim) Then
            MsgBox(message, MsgBoxStyle.Exclamation, "Empty Input!")
            Return True
        End If
        Return False
    End Function

    Public Function validInputs(ByRef texts As TextBox())
        For Each t In texts
            Dim message As String = $"Input Required for {t.Name.ToUpper.Replace("_", " ")}"
            If isEmptyInput(t, message) Then
                Return False
            End If
        Next
        Return True
    End Function





    '######################################################################
    '#  Takes a list of textbox and iterates it to clear each instance
    '######################################################################
    Public Sub ClearAll(ts As TextBox())
        For Each t In ts
            t.ForeColor = Color.Black
            t.Clear()
        Next
    End Sub

    Public Sub ToggleControls(ByRef controls As Control(), state As Boolean)
        For Each control In controls
            control.Enabled = state
            control.Visible = state
        Next
    End Sub


    '######################################################################

    '######################################################################
    '#  Manges the page switch by swapping the existing panel
    '######################################################################

    Private pages As Dictionary(Of String, Panel) = New Dictionary(Of String, Panel)
    Public currentPage As Panel = Nothing
    Public topPanel As Panel = Nothing
    Public activeForeColor As Color = Color.Black
    Public inactiveForeColor As Color = Color.White


    Public Sub switchPanel(ByRef newPage As Panel, ByVal current As Panel)
        If newPage Is current Then
            Return
        End If

        If pages.Keys.Contains(newPage.Name) Then current = pages(newPage.Name)

        current.Hide()
        current.ForeColor = inactiveForeColor

        newPage.Parent = current.Parent
        newPage.Dock = DockStyle.Fill
        newPage.Show()
        newPage.Focus()
        newPage.ForeColor = activeForeColor

        pages(newPage.Name) = newPage
        currentPage = pages(newPage.Name)
    End Sub

    Dim toggleHover As Boolean = False
    Public Sub HoverEvents(sender As Object, e As EventArgs)
        toggleHover = Not toggleHover
        If sender.GetType() Is GetType(Button) Then
            HoverOnButton(CType(sender, Button), toggleHover)
        End If
    End Sub

    Public Sub HoverOnButton(button As Button, state As Boolean)
        Try
            Select Case state
                Case True
                    button.BackColor = Color.Azure
                    button.FlatAppearance.BorderSize += 1
                Case False

                    button.BackColor = Color.Transparent
                    button.FlatAppearance.BorderSize -= 1
            End Select
        Catch ex As Exception

        End Try
    End Sub



    '######################################################################
    Public Function DataRowToDictionary(row As DataRow) As Dictionary(Of String, Object)
        Dim dictionary As New Dictionary(Of String, Object)()

        For Each column As DataColumn In row.Table.Columns
            Dim columnName As String = column.ColumnName
            Dim value As Object = row(columnName)
            dictionary.Add(columnName, value)
        Next

        Return dictionary
    End Function
    Public Function DictionariesAreEqual(dict1 As Dictionary(Of String, Object), dict2 As Dictionary(Of String, Object)) As Boolean
        If dict1 Is Nothing AndAlso dict2 Is Nothing Then
            Return True
        End If

        If dict1 Is Nothing OrElse dict2 Is Nothing Then
            Return False
        End If

        If dict1.Count <> dict2.Count Then
            Return False
        End If

        For Each kvp As KeyValuePair(Of String, Object) In dict1
            Dim key As String = kvp.Key
            Dim value1 As Object = kvp.Value
            Dim value2 As Object = Nothing

            If dict2.TryGetValue(key, value2) Then
                If Not Equals(value1, value2) Then
                    Return False
                End If
            Else
                Return False
            End If
        Next

        Return True
    End Function

End Module
