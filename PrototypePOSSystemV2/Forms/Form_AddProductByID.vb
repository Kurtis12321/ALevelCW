Public Class Form_AddProductByID

    Public productID As String

    'when add is clicked set the productID to the productID as long as it is in the correct format and has an underscore.
    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click

        Dim values As Array
        values = txtProductID.Text.Split(New Char() {"_"}) 'split the id at every underscore.

        If IsNumeric(values(1)) Then 'if the second part of the id is not numeric then the id is incorrect
            productID = txtProductID.Text
            Form_POSSystem.addProductByID(productID)
        Else
            MsgBox("Product ID must be in the format: 'CATAGORY_ID'.")
            Exit Sub
        End If

    End Sub
End Class