Public Class Form_ViewTransactions

    Private serverName As String

    Private Sub Form_ViewTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransactionsTableAdapter.Fill(Me.Database_POSSystemDataSet.Transactions)

        Dim counter As Integer
        Dim accountID(TransactionsDataGridView.DisplayedRowCount(False)) As Integer


        'need to figure out:::
        '
        'for each row, get the account id and find the name that goes with it. Then add it to the table for display.


        For Each row As DataGridViewRow In TransactionsDataGridView.Rows
            'accountID = row.Cells
            serverName = StaffTableAdapter1.GetServerName(accountID(counter))

            counter += 1
        Next

    End Sub

End Class