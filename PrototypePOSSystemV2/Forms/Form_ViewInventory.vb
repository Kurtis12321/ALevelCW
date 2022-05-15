Public Class Form_ViewInventory

    Private Sub Form_ViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InventoryTableAdapter.Fill(Me.Database_POSSystemDataSet.Inventory) 'fill the table with the data in the inventory database

    End Sub

    'take user to edit inventory form
    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        Form_EditInventory.Show()
        Form_EditInventory.BringToFront()
        Me.Close()
    End Sub
End Class