Public Class Form_InventoryManagement
    'show the view inventory form
    Private Sub Button_ViewInventory_Click(sender As Object, e As EventArgs) Handles Button_ViewInventory.Click
        Form_ViewInventory.Show()
        Form_ViewInventory.BringToFront()
        Me.Close()
    End Sub

    'Show the edit inventory form
    Private Sub Button_EditInventory_Click(sender As Object, e As EventArgs) Handles Button_EditInventory.Click
        Form_EditInventory.Show()
        Form_EditInventory.BringToFront()
        Me.Close()
    End Sub
End Class