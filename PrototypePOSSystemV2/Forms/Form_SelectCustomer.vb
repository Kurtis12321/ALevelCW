Public Class Form_SelectCustomer

    Private customerNo As Integer

    'when select is clicked get the customers id either directly from the text box of from an SQL query if a name is entered.
    Private Sub Button_Select_Click(sender As Object, e As EventArgs) Handles Button_Select.Click

        'check if the textbox has an ID(integer) or name(string)
        If IsNumeric(txtCustomer.Text) Then
            customerNo = txtCustomer.Text
        Else
            'Check if a customerID with the name given could be found.
            If Form_POSSystem.CustomersTableAdapter.GetCustomerID(txtCustomer.Text) Is Nothing Then
                MsgBox("A customer with that name could not be found.")
                Exit Sub
            End If

            'set the customer id to the outcome of the SQL query.
            customerNo = Form_POSSystem.CustomersTableAdapter.GetCustomerID(txtCustomer.Text)

        End If

        'set customer ID to the customer's id and let the user know.
        Form_POSSystem.customerID = customerNo
        MsgBox("Customer ID '" & customerNo & "' was assigned to the current transaction.")
        Form_POSSystem.BringToFront()
        Me.Close()
    End Sub
End Class