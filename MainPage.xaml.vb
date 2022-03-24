Public NotInheritable Class MainPage
    Inherits Page
    'Adding items
    Private Sub AddItemBox_KeyDown(sender As Object, e As KeyRoutedEventArgs) Handles AddItemBox.KeyDown
        Dim NCB As New CheckBox
        NCB.Content = AddItemBox.Text.ToString() & ", added " & DateTime.Now.ToString("M/d 'at' h:mm tt")
        If e.Key = Windows.System.VirtualKey.Enter Then
            ListMakingBox.Items.Add(NCB)
            ListItems.Text = "You have " & ListMakingBox.Items.Count.ToString() & " items"
            'To account for having only one item...
            If ListMakingBox.Items.Count = 1 Then
                ListItems.Text = "You have 1 item"
            End If
            AddItemBox.Text = ""
        End If
    End Sub
    Private Sub AddButton_Click(sender As Object, e As RoutedEventArgs) Handles AddButton.Click
        Dim NCB As New CheckBox
        NCB.Content = AddItemBox.Text.ToString() & ", added " & DateTime.Now.ToString("M/d 'at' h:mm tt")
        ListMakingBox.Items.Add(NCB)
        'Note: NCB (New Check Box) could be made a global variable, but just in case, it is best to keep it at a local level.
        ListItems.Text = "You have " & ListMakingBox.Items.Count.ToString() & " items"
        'To account for having only one item...
        If ListMakingBox.Items.Count = 1 Then
            ListItems.Text = "You have 1 item"
        End If
    End Sub
    'Removing items
    Private Sub RemoveButton_Click(sender As Object, e As RoutedEventArgs) Handles RemoveButton.Click
        ListMakingBox.Items.Remove(ListMakingBox.SelectedItem)
        ListItems.Text = "You have " & ListMakingBox.Items.Count.ToString() & " items"
        'To account for having only one item...
        If ListMakingBox.Items.Count = 1 Then
            ListItems.Text = "You have 1 item"
        End If
    End Sub
    'Clearing the list
    Private Sub ClearListButton_Click(sender As Object, e As RoutedEventArgs) Handles ClearListButton.Click
        ListMakingBox.Items.Clear()
        ListItems.Text = "You have " & ListMakingBox.Items.Count.ToString() & " items"
    End Sub
End Class