Public Class Form_EditInventory

    'Save button handler
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        Me.Validate() 'Save any changes to the customer database
        Me.InventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database_POSSystemDataSet)
    End Sub

    'New button handler
    Private Sub Button_New_Click(sender As Object, e As EventArgs) Handles Button_New.Click
        Me.InventoryBindingSource.AddNew() 'Add a new record and place the cursor in the username textbox
        ItemNameTextBox.Select()
    End Sub

    'Next record button handler
    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        Me.InventoryBindingSource.MoveNext()
    End Sub

    'Previous record button handler
    Private Sub Button_Prev_Click(sender As Object, e As EventArgs) Handles Button_Prev.Click
        Me.InventoryBindingSource.MovePrevious()
    End Sub

    'Delete record button handler
    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        Select Case MsgBox("Are you sure you want to remove this staff member?", MsgBoxStyle.YesNoCancel) 'Show message box to confirm, if the user clicks yes then delete the current record.
            Case MsgBoxResult.Yes
                Me.InventoryBindingSource.RemoveCurrent()
            Case MsgBoxResult.No Or MsgBoxResult.Cancel
                'Nothing
        End Select
    End Sub

    Private Sub Form_EditInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database_POSSystemDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.Database_POSSystemDataSet.Inventory)

    End Sub
End Class