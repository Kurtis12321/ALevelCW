Public Class Form_EditStaff

    Private Sub Form_EditStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StaffTableAdapter.Fill(Me.Database_POSSystemDataSet.Staff) 'Fill the textboxes from the database
    End Sub

    'Save button handler
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        Me.Validate() 'Save any changes to the staff database
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database_POSSystemDataSet)
    End Sub

    'New button handler
    Private Sub Button_New_Click(sender As Object, e As EventArgs) Handles Button_New.Click
        Me.StaffBindingSource.AddNew() 'Add a new record and place the cursor in the username textbox
        UsernameTextBox.Select()
    End Sub

    'Next record button handler
    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        Me.StaffBindingSource.MoveNext()
    End Sub

    'Previous record button handler
    Private Sub Button_Prev_Click(sender As Object, e As EventArgs) Handles Button_Prev.Click
        Me.StaffBindingSource.MovePrevious()
    End Sub

    'Show password button handler
    Private Sub Button_ShowPass_Click(sender As Object, e As EventArgs) Handles Button_ShowPass.Click
        If Me.Text = "Show" Then 'if the buttons text is show then show the password and set the text to hide
            PasswordTextBox.PasswordChar = ""
            Me.Text = "Hide"
        ElseIf Me.Text = "Hide" Then 'if the buttons text is hide then hide the password and set the text to show
            PasswordTextBox.PasswordChar = "*"
            Me.Text = "Show"
        End If
    End Sub

    'Delete record button handler
    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        Select Case MsgBox("Are you sure you want to remove this staff member?", MsgBoxStyle.YesNoCancel) 'Show message box to confirm, if the user clicks yes then delete the current record.
            Case MsgBoxResult.Yes
                Me.StaffBindingSource.RemoveCurrent()
            Case MsgBoxResult.No Or MsgBoxResult.Cancel
                'Nothing
        End Select
    End Sub
End Class