Public Class Form_ViewCustomers

    Private Sub Form_ViewCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CustomersTableAdapter.Fill(Me.Database_POSSystemDataSet.Customers) 'Fill the table with data from the customer database
    End Sub

    'Open the edit customers form and close this one.
    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        Form_EditCustomers.Show()
        Form_EditCustomers.BringToFront()
        Me.Close()
    End Sub
End Class