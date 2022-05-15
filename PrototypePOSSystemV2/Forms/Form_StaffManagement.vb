Public Class Form_StaffManagement

    'View staff button handler - show the view staff form
    Private Sub Button_ViewStaff_Click(sender As Object, e As EventArgs) Handles Button_ViewStaff.Click
        Form_ViewStaff.Show()
        Form_ViewStaff.BringToFront()
        Me.Close()
    End Sub

    'Edit staff button handler - show the edit staff form
    Private Sub Button_EditStaff_Click(sender As Object, e As EventArgs) Handles Button_EditStaff.Click
        Form_EditStaff.Show()
        Form_EditStaff.BringToFront()
        Me.Close()
    End Sub
End Class