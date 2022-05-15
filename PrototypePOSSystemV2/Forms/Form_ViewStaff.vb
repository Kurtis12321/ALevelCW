Public Class Form_ViewStaff

    Private Sub Form_ViewStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StaffTableAdapter.Fill(Me.Database_POSSystemDataSet.Staff) 'Fill the table with data from the staff database
    End Sub

    'Open the edit staff form and close this one.
    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        Form_EditStaff.Show()
        Form_EditStaff.BringToFront()
        Me.Close()
    End Sub
End Class