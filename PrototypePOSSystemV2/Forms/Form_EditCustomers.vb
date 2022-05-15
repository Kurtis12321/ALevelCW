Public Class Form_EditCustomers

    Private Sub Form_EditCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CustomersTableAdapter.Fill(Me.Database_POSSystemDataSet.Customers) 'Fill the textboxes from the database
    End Sub

    'Save button handler
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        Me.Validate() 'Save any changes to the customer database
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database_POSSystemDataSet)
    End Sub

    'New button handler
    Private Sub Button_New_Click(sender As Object, e As EventArgs) Handles Button_New.Click
        Me.CustomersBindingSource.AddNew() 'Add a new record and place the cursor in the username textbox
        FirstNameTextBox.Select()
    End Sub

    'Next record button handler
    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        Me.CustomersBindingSource.MoveNext()
    End Sub

    'Previous record button handler
    Private Sub Button_Prev_Click(sender As Object, e As EventArgs) Handles Button_Prev.Click
        Me.CustomersBindingSource.MovePrevious()
    End Sub

    'Delete record button handler
    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        Select Case MsgBox("Are you sure you want to remove this staff member?", MsgBoxStyle.YesNoCancel) 'Show message box to confirm, if the user clicks yes then delete the current record.
            Case MsgBoxResult.Yes
                Me.CustomersBindingSource.RemoveCurrent()
            Case MsgBoxResult.No Or MsgBoxResult.Cancel
                'Do Nothing
        End Select
    End Sub
End Class