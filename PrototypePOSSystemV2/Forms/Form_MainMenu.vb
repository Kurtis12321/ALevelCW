Public Class Form_MainMenu

    Public username As String
    Public staffName As String

    Private Sub Form_MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadChecks(True)
    End Sub

    'This will be called any time this form is loaded
    Public Sub loadChecks(transacStatus As Boolean)

        'set the username and name and change the welcome message.
        username = Form_SignIn.username
        staffName = StaffTableAdapter.GetFirstName(username)
        Label1.Text = "Welcome, " & staffName

        'If the user is an administrator display the admin label and enable administrator buttons.
        If StaffTableAdapter.IsAdmin(username) Then
            Label_AdminStatus.Visible = True

            btn_AddCustomer.Enabled = True
            btn_AddCustomer.BackColor = Color.LightSteelBlue
            btn_AddInventory.Enabled = True
            btn_AddInventory.BackColor = Color.LightSteelBlue
            btn_AddStaff.Enabled = True
            btn_AddStaff.BackColor = Color.LightSteelBlue
            btn_Payroll.Enabled = True
            btn_Payroll.BackColor = Color.LightSteelBlue
            btn_ViewStaff.Enabled = True
            btn_ViewStaff.BackColor = Color.LightSteelBlue
            btn_ViewCustomer.Enabled = True
            btn_ViewCustomer.BackColor = Color.LightSteelBlue
        Else
            Label_AdminStatus.Visible = False
        End If

        'If there is a transaction in progress, display a message letting the user know, else don't display this.
        If transacStatus Then
            Panel_TransacInProgress.BackColor = Color.Gray
            Panel_TransacInProgress.Visible = True
            Label_TransacInProgress.Visible = False
        Else
            Panel_TransacInProgress.BackColor = Color.Khaki
            Panel_TransacInProgress.Visible = True
            Label_TransacInProgress.Visible = True
        End If
    End Sub

    'If the transaction in progress label or panel or order button are clicked then take the user to the POS system.
    Private Sub showPOSSystemForm(sender As Object, e As EventArgs) Handles Label_TransacInProgress.Click, Panel_TransacInProgress.Click, btn_Order.Click
        Form_POSSystem.Show()
        Form_POSSystem.BringToFront()
        Me.Hide()
    End Sub

    'Show about box
    Private Sub btn_About_Click(sender As Object, e As EventArgs) Handles btn_About.Click
        AboutBox.Show()
        AboutBox.BringToFront()
    End Sub

    'Log the user out
    Private Sub btn_Logout_Click(sender As Object, e As EventArgs) Handles btn_Logout.Click
        Form_SignIn.LogOut(Me)
    End Sub

    'Edit staff button handler
    Private Sub btn_AddStaff_Click(sender As Object, e As EventArgs) Handles btn_AddStaff.Click
        Form_EditStaff.Show()
        Form_EditStaff.BringToFront()
    End Sub

    'View staff button handler
    Private Sub btn_ViewStaff_Click(sender As Object, e As EventArgs) Handles btn_ViewStaff.Click
        Form_ViewStaff.Show()
        Form_ViewStaff.BringToFront()
    End Sub

    'Add customer button handler
    Private Sub btn_AddCustomer_Click(sender As Object, e As EventArgs) Handles btn_AddCustomer.Click
        Form_EditCustomers.Show()
        Form_EditCustomers.BringToFront()
    End Sub

    'View customer button handler
    Private Sub btn_ViewCustomer_Click(sender As Object, e As EventArgs) Handles btn_ViewCustomer.Click
        Form_ViewCustomers.Show()
        Form_ViewCustomers.BringToFront()
    End Sub

    'Add inventory button handler
    Private Sub btn_AddInventory_Click(sender As Object, e As EventArgs) Handles btn_AddInventory.Click
        Form_EditInventory.Show()
        Form_EditInventory.BringToFront()
    End Sub

    'View inventory button handler
    Private Sub btn_ViewInventory_Click(sender As Object, e As EventArgs) Handles btn_ViewInventory.Click
        Form_ViewInventory.Show()
        Form_ViewInventory.BringToFront()
    End Sub

    'View orders button handler
    Private Sub btn_ViewOrders_Click(sender As Object, e As EventArgs) Handles btn_ViewOrders.Click
        Form_ViewTransactions.Show()
        Form_ViewTransactions.BringToFront()
    End Sub

    'payroll button handler
    Private Sub btn_Payroll_Click(sender As Object, e As EventArgs) Handles btn_Payroll.Click
        Form_PayrollManagement.Show()
        Form_PayrollManagement.BringToFront()
    End Sub
End Class