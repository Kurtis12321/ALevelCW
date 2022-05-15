Public Class Form_ViewReciept

    Private Sub Form_ViewReciept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'display the current order items
        TextBox_CurrentOrder.Text &= Form_POSSystem.TextBox_CurrentOrder.Text
        'display the current price of each item
        TextBox_CurrentOrderPrices.Text &= Form_POSSystem.TextBox_CurrentOrderPrices.Text
        'display the total cost of the order with discount
        TextBox_TotalCost.Text = Form_POSSystem.totalCostWDiscount
    End Sub

    'close the form
    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Form_POSSystem.BringToFront()
        Me.Close()
    End Sub
End Class