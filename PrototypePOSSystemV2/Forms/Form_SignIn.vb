Public Class Form_SignIn

    Public username As String
    Private password As String

    'When user presses 'ok', check username and password against database(using sql query). If both are correct then log in, else don't login and tell the user the details were incorrect.
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        username = UsernameTextBox.Text
        password = PasswordTextBox.Text

        Dim login = StaffTableAdapter.GetUsernameAndPassword(username, password)

        If login Is Nothing Then
            MsgBox("Username or password is incorrect.")
            Exit Sub
        Else
            'MsgBox("Logging In...")
        End If

        Me.Hide()
        Form_MainMenu.Show()
        Form_MainMenu.BringToFront()
        Form_MainMenu.loadChecks(True)

    End Sub

    'if user presses cancel button then close the application.
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    'Log out, reset all variables, close whichever form the method was called from.
    Public Sub LogOut(frmToClose As Form)
        username = Nothing
        password = Nothing
        UsernameTextBox.Text = Nothing
        PasswordTextBox.Text = Nothing
        Form_POSSystem.isAdmin = False
        Form_POSSystem.serverName = Nothing
        Form_POSSystem.trainingModeActive = False
        Form_MainMenu.username = Nothing

        Me.Show()

        frmToClose.Close()

        Me.BringToFront()
        Me.Activate()
        UsernameTextBox.Select()
    End Sub

End Class
