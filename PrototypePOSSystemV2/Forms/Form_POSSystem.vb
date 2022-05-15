Public Class Form_POSSystem

    Private ReadOnly util As New Class_Utils

    Private ReadOnly specials As New Class_AddSpecials
    Private ReadOnly starters As New Class_AddStarters
    Private ReadOnly mains As New Class_AddMains
    Private ReadOnly burgers As New Class_AddBurgers
    Private ReadOnly kids As New Class_AddKids
    Private ReadOnly desserts As New Class_AddDesserts
    Private ReadOnly salads As New Class_AddSalads
    Private ReadOnly sides As New Class_AddSides
    Private ReadOnly drinks As New Class_AddDrinks

    Public isAdmin, trainingModeActive, currentTransactionComplete As Boolean
    Public student, staff, fivePercent, tenPercent, fifteenPercent, twentyPercent As Boolean

    Public accountID, username, serverName, customerID, productID As String
    Public currentTable, transactionNo As Integer

    Public totalCost, totalCostWDiscount As Double

    Private Sub Form_POSSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set the username variable to the username given
        username = Form_SignIn.username

        'SQLQueries
        '- isAdmin: uses the username supplied and check the database to see if the user is an administrator
        '- GetFirstname: uses the username supplied to get the users first name from the database.
        '- GetAccountID: uses the username to get the users account id.
        '- GetHighestTransactionID: used to get the newest transaction ID from the transaction database.
        isAdmin = StaffTableAdapter.IsAdmin(username)
        serverName = StaffTableAdapter.GetFirstName(username)
        accountID = StaffTableAdapter.GetAccountID(username)
        transactionNo = TransactionsTableAdapter.GetHighestTransactionID + 1

        addinfo()
        hideFeatures()

        'If the user is and admin then add additional administrative permissions and features, also move the training label so it does not overlap.
        If isAdmin = True Then addAdminFeatures() Else Label_Training.Location = New Point(1744, 0)

        getMenuItems()

    End Sub

    'used to add user specific information to the main form.
    Public Sub addinfo()
        TextBox_ServerName.Text = serverName
        If currentTable = Nothing Then TableNoTextBox.Text = "None Selected" Else TableNoTextBox.Text = currentTable
        TransactionIDTextBox.Text = transactionNo
    End Sub

    'used to hide features when the form first loads.
    Private Sub hideFeatures()
        Panel_CatStarters.Visible = False
        Panel_CatMains.Visible = False
        Panel_CatBurgers.Visible = False
        Panel_CatKids.Visible = False
        Panel_CatDesserts.Visible = False
        Panel_CatSalads.Visible = False
        Panel_CatSides.Visible = False
        Panel_CatDrinks.Visible = False

        Label_AdminStatus.Visible = False
        Label_Training.Visible = False

        StaffManagementToolStripMenuItem.Visible = False
        InventoryManagementToolStripMenuItem.Visible = False
        PayrollManagementToolStripMenuItem.Visible = False
        ModifyMenuToolStripMenuItem.Visible = False
    End Sub

    'used to add additional administrator features if the user is an admin.
    Private Sub addAdminFeatures()
        Label_Training.Location = New Point(1621, 0)
        Label_AdminStatus.Visible = True

        StaffManagementToolStripMenuItem.Visible = True
        InventoryManagementToolStripMenuItem.Visible = True
        PayrollManagementToolStripMenuItem.Visible = True
        ModifyMenuToolStripMenuItem.Visible = True
    End Sub

    'this method is used to initialise all of the menu items from a text file onto buttons, see init within each class for more detail
    Public Sub getMenuItems()
        specials.init()
        starters.init()
        mains.init()
        burgers.init()
        kids.init()
        desserts.init()
        salads.init()
        sides.init()
        drinks.init()
    End Sub

    'simply opens the inventory management form.
    Private Sub InventoryManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventoryManagementToolStripMenuItem.Click
        Form_InventoryManagement.Show()
        Form_InventoryManagement.BringToFront()
    End Sub

    'simply opens the view transactions form.
    Private Sub ViewTransactionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTransactionsToolStripMenuItem.Click
        Form_ViewTransactions.Show()
        Form_ViewTransactions.BringToFront()
    End Sub

    'enables training mode when the button is clicked.
    Private Sub TurnTrainingModeOnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TurnTrainingModeOnToolStripMenuItem.Click
        trainingMode()
    End Sub

    'open the staff management form
    Private Sub StaffManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffManagementToolStripMenuItem.Click
        Form_StaffManagement.Show()
        Form_StaffManagement.BringToFront()
    End Sub

    'open the payroll management form
    Private Sub PayrollManagementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayrollManagementToolStripMenuItem.Click
        Form_PayrollManagement.Show()
        Form_PayrollManagement.BringToFront()
    End Sub

    'open the menu modification form
    Private Sub ModifyMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyMenuToolStripMenuItem.Click
        Form_ModifyMenu.Show()
        Form_ModifyMenu.BringToFront()
    End Sub

    'This handler will set visible to false on all catagory panels and then make the specials panels visible, as well as change the colour of the buttons
    Private Sub Button_Specials_Click(sender As Object, e As EventArgs) Handles Button_Specials.Click
        For Each pnl As Panel In Me.Controls.OfType(Of Panel) 'For every panel on the form, check if the name contains "Cat" and not "Catagories" - if true, set visibility false.
            If pnl.Name.Contains("Cat") And Not pnl.Name.Contains("Catagories") Then
                pnl.Visible = False
            End If
        Next

        Panel_CatSpecials.Visible = True 'Set the panel that the user click on visible.

        Button_UpCat.BackColor = Panel_CatSpecials.BackColor 'Change the back colour of the buttons to match the panel.
        Button_DownCat.BackColor = Panel_CatSpecials.BackColor
    End Sub

    'This handler will set visible to false on all catagory panels and then make the starters panels visible, as well as change the colour of the buttons
    Private Sub Button_Starters_Click(sender As Object, e As EventArgs) Handles Button_Starters.Click
        For Each pnl As Panel In Me.Controls.OfType(Of Panel) 'For every panel on the form, check if the name contains "Cat" and not "Catagories" - if true, set visibility false.
            If pnl.Name.Contains("Cat") And Not pnl.Name.Contains("Catagories") Then
                pnl.Visible = False
            End If
        Next

        Panel_CatStarters.Visible = True 'Set the panel that the user click on visible.

        Button_UpCat.BackColor = Panel_CatStarters.BackColor 'Change the back colour of the buttons to match the panel.
        Button_DownCat.BackColor = Panel_CatStarters.BackColor
    End Sub

    'This handler will set visible to false on all catagory panels and then make the mains panels visible, as well as change the colour of the buttons
    Private Sub Button_Mains_Click(sender As Object, e As EventArgs) Handles Button_Mains.Click
        For Each pnl As Panel In Me.Controls.OfType(Of Panel) 'For every panel on the form, check if the name contains "Cat" and not "Catagories" - if true, set visibility false.
            If pnl.Name.Contains("Cat") And Not pnl.Name.Contains("Catagories") Then
                pnl.Visible = False
            End If
        Next

        Panel_CatMains.Visible = True 'Set the panel that the user click on visible.

        Button_UpCat.BackColor = Panel_CatMains.BackColor 'Change the back colour of the buttons to match the panel.
        Button_DownCat.BackColor = Panel_CatMains.BackColor
    End Sub

    'This handler will set visible to false on all catagory panels and then make the burgers panels visible, as well as change the colour of the buttons
    Private Sub Button_Burgers_Click(sender As Object, e As EventArgs) Handles Button_Burgers.Click
        For Each pnl As Panel In Me.Controls.OfType(Of Panel) 'For every panel on the form, check if the name contains "Cat" and not "Catagories" - if true, set visibility false.
            If pnl.Name.Contains("Cat") And Not pnl.Name.Contains("Catagories") Then
                pnl.Visible = False
            End If
        Next

        Panel_CatBurgers.Visible = True 'Set the panel that the user click on visible.
    End Sub

    'This handler will set visible to false on all catagory panels and then make the kids panels visible, as well as change the colour of the buttons
    Private Sub Button_Kids_Click(sender As Object, e As EventArgs) Handles Button_Kids.Click
        For Each pnl As Panel In Me.Controls.OfType(Of Panel) 'For every panel on the form, check if the name contains "Cat" and not "Catagories" - if true, set visibility false.
            If pnl.Name.Contains("Cat") And Not pnl.Name.Contains("Catagories") Then
                pnl.Visible = False
            End If
        Next

        Panel_CatKids.Visible = True 'Set the panel that the user click on visible.
    End Sub

    'This handler will set visible to false on all catagory panels and then make the desserts panels visible, as well as change the colour of the buttons
    Private Sub Button_Desserts_Click(sender As Object, e As EventArgs) Handles Button_Desserts.Click
        For Each pnl As Panel In Me.Controls.OfType(Of Panel) 'For every panel on the form, check if the name contains "Cat" and not "Catagories" - if true, set visibility false.
            If pnl.Name.Contains("Cat") And Not pnl.Name.Contains("Catagories") Then
                pnl.Visible = False
            End If
        Next

        Panel_CatDesserts.Visible = True 'Set the panel that the user click on visible.
    End Sub

    'This handler will set visible to false on all catagory panels and then make the salads panels visible, as well as change the colour of the buttons
    Private Sub Button_Salads_Click(sender As Object, e As EventArgs) Handles Button_Salads.Click
        For Each pnl As Panel In Me.Controls.OfType(Of Panel) 'For every panel on the form, check if the name contains "Cat" and not "Catagories" - if true, set visibility false.
            If pnl.Name.Contains("Cat") And Not pnl.Name.Contains("Catagories") Then
                pnl.Visible = False
            End If
        Next

        Panel_CatSalads.Visible = True 'Set the panel that the user click on visible.
    End Sub

    'This handler will set visible to false on all catagory panels and then make the sides panels visible, as well as change the colour of the buttons
    Private Sub Button_Sides_Click(sender As Object, e As EventArgs) Handles Button_Sides.Click
        For Each pnl As Panel In Me.Controls.OfType(Of Panel) 'For every panel on the form, check if the name contains "Cat" and not "Catagories" - if true, set visibility false.
            If pnl.Name.Contains("Cat") And Not pnl.Name.Contains("Catagories") Then
                pnl.Visible = False
            End If
        Next

        Panel_CatSides.Visible = True 'Set the panel that the user click on visible.
    End Sub

    'This handler will set visible to false on all catagory panels and then make the drinks panels visible, as well as change the colour of the buttons
    Private Sub Button_Drinks_Click(sender As Object, e As EventArgs) Handles Button_Drinks.Click
        For Each pnl As Panel In Me.Controls.OfType(Of Panel) 'For every panel on the form, check if the name contains "Cat" and not "Catagories" - if true, set visibility false.
            If pnl.Name.Contains("Cat") And Not pnl.Name.Contains("Catagories") Then
                pnl.Visible = False
            End If
        Next

        Panel_CatDrinks.Visible = True 'Set the panel that the user click on visible.
    End Sub

    'Handles the completion of a transaction.
    Private Sub Button_CompleteTransaction_Click(sender As Object, e As EventArgs) Handles Button_CompleteTransaction.Click

        'Check if there is a table selected
        If currentTable = Nothing Then
            MsgBox("A table has not been assigned to the current transaction!")
            Exit Sub
        End If

        'Check if there is a customer selected
        If customerID = Nothing Then
            MsgBox("Customer ID is blank, either choose 0 or a customers ID.")
            Exit Sub
        End If

        'Check if training mode is active, if it is then tell the user the transaction is complete and exit without adding to the transaction database and clear variables, else, add a new transaction to the database
        If Not trainingModeActive Then
            util.addToTransactionDatabase()
            TextBox_CurrentOrder.Text = Nothing
            TextBox_CurrentOrderPrices.Text = Nothing
            TextBox_TotalCost.Text = Nothing
            totalCost = Nothing
            totalCostWDiscount = Nothing
            fivePercent = False
            tenPercent = False
            fifteenPercent = False
            twentyPercent = False
            student = False
            staff = False
            currentTable = Nothing
            addinfo()
            currentTransactionComplete = True

            'Let the user know the transaciton was completed and increase transactionNo
            MsgBox("Transaction '" & transactionNo & "' has been completed.")
            transactionNo = TransactionsTableAdapter.GetHighestTransactionID + 1
            addinfo()
        Else
            TextBox_CurrentOrder.Text = Nothing
            TextBox_CurrentOrderPrices.Text = Nothing
            TextBox_TotalCost.Text = Nothing
            totalCost = Nothing
            fivePercent = False
            tenPercent = False
            fifteenPercent = False
            twentyPercent = False
            student = False
            staff = False
            totalCostWDiscount = Nothing
            currentTable = Nothing
            addinfo()
            currentTransactionComplete = True
            MsgBox("[TRAINING MODE] Transaction '" & transactionNo & "' has been completed.")
        End If
    End Sub

    'Handles the cancellation of a transaction.
    Private Sub Button_CancelTransaction_Click(sender As Object, e As EventArgs) Handles Button_CancelTransaction.Click
        'Check that the user wants to cancel the transaction
        Select Case MsgBox("Are you sure you want to cancel the current transaction?", MsgBoxStyle.YesNoCancel)
            Case MsgBoxResult.No
                MsgBox("Transaction was not cancelled.")
                Exit Sub
        End Select

        'Clear textboxes and variables
        TextBox_CurrentOrder.Text = Nothing
        TextBox_CurrentOrderPrices.Text = Nothing
        TextBox_TotalCost.Text = Nothing

        currentTable = Nothing
        addinfo()
        currentTransactionComplete = True
        MsgBox("The transaction has been cancelled.")
    End Sub

    'open the staff management form
    Private Sub Button_StaffManagement_Click(sender As Object, e As EventArgs) Handles Button_StaffManagement.Click
        Form_StaffManagement.Show()
        Form_StaffManagement.BringToFront()
    End Sub

    'open inventory management form
    Private Sub Button_InventoryManagement_Click(sender As Object, e As EventArgs) Handles Button_InventoryManagement.Click
        Form_InventoryManagement.Show()
        Form_InventoryManagement.BringToFront()
    End Sub

    'open payroll management form
    Private Sub Button_PayrollManagement_Click(sender As Object, e As EventArgs) Handles Button_PayrollManagement.Click
        Form_PayrollManagement.Show()
        Form_PayrollManagement.BringToFront()
    End Sub

    'open view transactions form
    Private Sub Button_ViewTransactions_Click(sender As Object, e As EventArgs) Handles Button_ViewTransactions.Click
        Form_ViewTransactions.Show()
        Form_ViewTransactions.BringToFront()
    End Sub

    'open modify menu form
    Private Sub Button_ModifyMenu_Click(sender As Object, e As EventArgs) Handles Button_ModifyMenu.Click
        Form_ModifyMenu.Show()
        Form_ModifyMenu.BringToFront()
    End Sub

    'Enable/Disable training mode
    Private Sub Button_TrainingMode_Click(sender As Object, e As EventArgs) Handles Button_TrainingMode.Click
        trainingMode()
    End Sub

    'Add an item to the menu via it's ID
    Private Sub Button_ProductID_Click(sender As Object, e As EventArgs) Handles Button_ProductID.Click
        Form_AddProductByID.Show()
        Form_AddProductByID.BringToFront()
    End Sub

    'Show the reciept for the current order
    Private Sub Button_Reciept_Click(sender As Object, e As EventArgs) Handles Button_Reciept.Click
        Form_ViewReciept.Show()
        Form_ViewReciept.BringToFront()
    End Sub

    'Apply a staff discount to the current order
    Private Sub Button_StaffDiscount_Click(sender As Object, e As EventArgs) Handles Button_StaffDiscount.Click
        staff = True
        calcCostWDiscount()
    End Sub

    'Apply a student discount to the current order
    Private Sub Button_StudentDiscount_Click(sender As Object, e As EventArgs) Handles Button_StudentDiscount.Click
        student = True
        calcCostWDiscount()
    End Sub

    'Apply a 5% discount to the current order
    Private Sub Button_Discount5_Click(sender As Object, e As EventArgs) Handles Button_Discount5.Click
        fivePercent = True
        calcCostWDiscount()
    End Sub

    'Close the application
    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click
        Application.Exit()
    End Sub

    'Apply a 10% discount to the current order
    Private Sub Button_Discount10_Click(sender As Object, e As EventArgs) Handles Button_Discount10.Click
        tenPercent = True
        calcCostWDiscount()
    End Sub

    'Apply a 15% discount to the current order
    Private Sub Button_Discount15_Click(sender As Object, e As EventArgs) Handles Button_Discount15.Click
        fifteenPercent = True
        calcCostWDiscount()
    End Sub

    'Apply a 20% discount to the current order
    Private Sub Button_Discount20_Click(sender As Object, e As EventArgs) Handles Button_Discount20.Click
        twentyPercent = True
        calcCostWDiscount()
    End Sub

    'Display the main menu.
    Private Sub Button_MainMenu_Click(sender As Object, e As EventArgs) Handles Button_MainMenu.Click, MainMenuToolStripMenuItem.Click
        Form_MainMenu.Show()
        Form_MainMenu.BringToFront()
        Form_MainMenu.loadChecks(currentTransactionComplete)
        Me.Hide()
    End Sub

    'Open the customer selection form
    Private Sub Button_SelectCustomer_Click(sender As Object, e As EventArgs) Handles Button_SelectCustomer.Click
        Form_SelectCustomer.Show()
        Form_SelectCustomer.BringToFront()
    End Sub

    'Open the table selection form
    Private Sub Button_SelectTable_Click(sender As Object, e As EventArgs) Handles Button_SelectTable.Click
        Form_SelectTable.Show()
        Form_SelectTable.BringToFront()
    End Sub

    'This handler is used when the user clicks the sign out button - will check if there are any transactions in progress, if not then it will call LogOut() from form_signIn.
    Private Sub Button_SignOut_Click(sender As Object, e As EventArgs) Handles Button_SignOut.Click
        If currentTransactionComplete = False Then
            Select Case MsgBox("There is an incomplete transaction in progress. Signing out will cancel this transaction! Are you sure you want to sign out?", MsgBoxStyle.YesNoCancel)
                Case MsgBoxResult.No
                    Exit Sub
            End Select
        End If

        'sign out the user and pass this form for it to be closed after the logout has been completed.
        Form_SignIn.LogOut(Me)
    End Sub

    'Placeholder button handler - handles all of the menu item buttons.
    'Calls the addToOrder method and passes through the sender object.
    Private Sub PlaceholderButtons_Click(sender As Object, e As EventArgs) Handles Specials_Button_Placeholder1.Click, Specials_Button_Placeholder2.Click, Specials_Button_Placeholder3.Click, Specials_Button_Placeholder4.Click, Specials_Button_Placeholder5.Click,
                                                                                   Specials_Button_Placeholder6.Click, Specials_Button_Placeholder7.Click, Specials_Button_Placeholder8.Click, Specials_Button_Placeholder9.Click, Specials_Button_Placeholder10.Click,
                                                                                   Specials_Button_Placeholder11.Click, Specials_Button_Placeholder12.Click, Specials_Button_Placeholder13.Click, Specials_Button_Placeholder14.Click, Specials_Button_Placeholder15.Click,
                                                                                   Specials_Button_Placeholder16.Click, Specials_Button_Placeholder17.Click, Specials_Button_Placeholder18.Click, Specials_Button_Placeholder19.Click, Specials_Button_Placeholder20.Click,
                                                                                   Specials_Button_Placeholder21.Click, Specials_Button_Placeholder22.Click, Specials_Button_Placeholder23.Click, Specials_Button_Placeholder24.Click, Specials_Button_Placeholder25.Click,
                                                                                   Specials_Button_Placeholder26.Click, Specials_Button_Placeholder27.Click, Starters_Button_Placeholder1.Click, Starters_Button_Placeholder2.Click, Starters_Button_Placeholder3.Click,
                                                                                   Starters_Button_Placeholder4.Click, Starters_Button_Placeholder5.Click, Starters_Button_Placeholder6.Click, Starters_Button_Placeholder7.Click, Starters_Button_Placeholder8.Click,
                                                                                   Starters_Button_Placeholder9.Click, Starters_Button_Placeholder10.Click, Starters_Button_Placeholder11.Click, Starters_Button_Placeholder12.Click, Starters_Button_Placeholder13.Click,
                                                                                   Starters_Button_Placeholder14.Click, Starters_Button_Placeholder15.Click, Starters_Button_Placeholder16.Click, Starters_Button_Placeholder17.Click, Starters_Button_Placeholder18.Click,
                                                                                   Starters_Button_Placeholder19.Click, Starters_Button_Placeholder20.Click, Starters_Button_Placeholder21.Click, Starters_Button_Placeholder22.Click, Starters_Button_Placeholder23.Click,
                                                                                   Starters_Button_Placeholder24.Click, Starters_Button_Placeholder25.Click, Starters_Button_Placeholder26.Click, Starters_Button_Placeholder27.Click, Mains_Button_Placeholder1.Click,
                                                                                   Mains_Button_Placeholder2.Click, Mains_Button_Placeholder3.Click, Mains_Button_Placeholder4.Click, Mains_Button_Placeholder5.Click,
                                                                                   Mains_Button_Placeholder6.Click, Mains_Button_Placeholder7.Click, Mains_Button_Placeholder8.Click, Mains_Button_Placeholder9.Click, Mains_Button_Placeholder10.Click,
                                                                                   Mains_Button_Placeholder11.Click, Mains_Button_Placeholder12.Click, Mains_Button_Placeholder13.Click, Mains_Button_Placeholder14.Click, Mains_Button_Placeholder15.Click,
                                                                                   Mains_Button_Placeholder16.Click, Mains_Button_Placeholder17.Click, Mains_Button_Placeholder18.Click, Mains_Button_Placeholder19.Click, Mains_Button_Placeholder20.Click,
                                                                                   Mains_Button_Placeholder21.Click, Mains_Button_Placeholder22.Click, Mains_Button_Placeholder23.Click, Mains_Button_Placeholder24.Click, Mains_Button_Placeholder25.Click,
                                                                                   Mains_Button_Placeholder26.Click, Mains_Button_Placeholder27.Click, Burgers_Button_Placeholder1.Click, Burgers_Button_Placeholder2.Click, Burgers_Button_Placeholder3.Click,
                                                                                   Burgers_Button_Placeholder4.Click, Burgers_Button_Placeholder5.Click, Burgers_Button_Placeholder6.Click, Burgers_Button_Placeholder7.Click, Burgers_Button_Placeholder8.Click,
                                                                                   Burgers_Button_Placeholder9.Click, Burgers_Button_Placeholder10.Click, Burgers_Button_Placeholder11.Click, Burgers_Button_Placeholder12.Click, Burgers_Button_Placeholder13.Click,
                                                                                   Burgers_Button_Placeholder14.Click, Burgers_Button_Placeholder15.Click, Burgers_Button_Placeholder16.Click, Burgers_Button_Placeholder17.Click, Burgers_Button_Placeholder18.Click,
                                                                                   Burgers_Button_Placeholder19.Click, Burgers_Button_Placeholder20.Click, Burgers_Button_Placeholder21.Click, Burgers_Button_Placeholder22.Click, Burgers_Button_Placeholder23.Click,
                                                                                   Burgers_Button_Placeholder24.Click, Burgers_Button_Placeholder25.Click, Burgers_Button_Placeholder26.Click, Burgers_Button_Placeholder27.Click, Kids_Button_Placeholder1.Click,
                                                                                   Kids_Button_Placeholder2.Click, Kids_Button_Placeholder3.Click, Kids_Button_Placeholder4.Click, Kids_Button_Placeholder5.Click, Kids_Button_Placeholder6.Click, Kids_Button_Placeholder7.Click,
                                                                                   Kids_Button_Placeholder8.Click, Kids_Button_Placeholder9.Click, Kids_Button_Placeholder10.Click, Kids_Button_Placeholder11.Click, Kids_Button_Placeholder12.Click, Kids_Button_Placeholder13.Click,
                                                                                   Kids_Button_Placeholder14.Click, Kids_Button_Placeholder15.Click, Kids_Button_Placeholder16.Click, Kids_Button_Placeholder17.Click, Kids_Button_Placeholder18.Click, Kids_Button_Placeholder19.Click,
                                                                                   Kids_Button_Placeholder20.Click, Kids_Button_Placeholder21.Click, Kids_Button_Placeholder22.Click, Kids_Button_Placeholder23.Click, Kids_Button_Placeholder24.Click, Kids_Button_Placeholder25.Click,
                                                                                   Kids_Button_Placeholder26.Click, Kids_Button_Placeholder27.Click, Desserts_Button_Placeholder1.Click, Desserts_Button_Placeholder2.Click, Desserts_Button_Placeholder3.Click,
                                                                                   Desserts_Button_Placeholder4.Click, Desserts_Button_Placeholder5.Click, Desserts_Button_Placeholder6.Click, Desserts_Button_Placeholder7.Click, Desserts_Button_Placeholder8.Click,
                                                                                   Desserts_Button_Placeholder9.Click, Desserts_Button_Placeholder10.Click, Desserts_Button_Placeholder11.Click, Desserts_Button_Placeholder12.Click, Desserts_Button_Placeholder13.Click,
                                                                                   Desserts_Button_Placeholder14.Click, Desserts_Button_Placeholder15.Click, Desserts_Button_Placeholder16.Click, Desserts_Button_Placeholder17.Click, Desserts_Button_Placeholder18.Click,
                                                                                   Desserts_Button_Placeholder19.Click, Desserts_Button_Placeholder20.Click, Desserts_Button_Placeholder21.Click, Desserts_Button_Placeholder22.Click, Desserts_Button_Placeholder23.Click,
                                                                                   Desserts_Button_Placeholder24.Click, Desserts_Button_Placeholder25.Click, Desserts_Button_Placeholder26.Click, Desserts_Button_Placeholder27.Click, Salads_Button_Placeholder1.Click,
                                                                                   Salads_Button_Placeholder2.Click, Salads_Button_Placeholder3.Click, Salads_Button_Placeholder4.Click, Salads_Button_Placeholder5.Click, Salads_Button_Placeholder6.Click,
                                                                                   Salads_Button_Placeholder7.Click, Salads_Button_Placeholder8.Click, Salads_Button_Placeholder9.Click, Salads_Button_Placeholder10.Click, Salads_Button_Placeholder11.Click,
                                                                                   Salads_Button_Placeholder12.Click, Salads_Button_Placeholder13.Click, Salads_Button_Placeholder14.Click, Salads_Button_Placeholder15.Click, Salads_Button_Placeholder16.Click,
                                                                                   Salads_Button_Placeholder17.Click, Salads_Button_Placeholder18.Click, Salads_Button_Placeholder19.Click, Salads_Button_Placeholder20.Click, Salads_Button_Placeholder21.Click,
                                                                                   Salads_Button_Placeholder22.Click, Salads_Button_Placeholder23.Click, Salads_Button_Placeholder24.Click, Salads_Button_Placeholder25.Click, Salads_Button_Placeholder26.Click,
                                                                                   Salads_Button_Placeholder27.Click, Sides_Button_Placeholder1.Click, Sides_Button_Placeholder2.Click, Sides_Button_Placeholder3.Click, Sides_Button_Placeholder4.Click, Sides_Button_Placeholder5.Click,
                                                                                   Sides_Button_Placeholder6.Click, Sides_Button_Placeholder7.Click, Sides_Button_Placeholder8.Click, Sides_Button_Placeholder9.Click, Sides_Button_Placeholder10.Click, Sides_Button_Placeholder11.Click,
                                                                                   Sides_Button_Placeholder12.Click, Sides_Button_Placeholder13.Click, Sides_Button_Placeholder14.Click, Sides_Button_Placeholder15.Click, Sides_Button_Placeholder16.Click,
                                                                                   Sides_Button_Placeholder17.Click, Sides_Button_Placeholder18.Click, Sides_Button_Placeholder19.Click, Sides_Button_Placeholder20.Click, Sides_Button_Placeholder21.Click,
                                                                                   Sides_Button_Placeholder22.Click, Sides_Button_Placeholder23.Click, Sides_Button_Placeholder24.Click, Sides_Button_Placeholder25.Click, Sides_Button_Placeholder26.Click,
                                                                                   Sides_Button_Placeholder27.Click, Drinks_Button_Placeholder1.Click, Drinks_Button_Placeholder2.Click, Drinks_Button_Placeholder3.Click, Drinks_Button_Placeholder4.Click,
                                                                                   Drinks_Button_Placeholder5.Click, Drinks_Button_Placeholder6.Click, Drinks_Button_Placeholder7.Click, Drinks_Button_Placeholder8.Click, Drinks_Button_Placeholder9.Click,
                                                                                   Drinks_Button_Placeholder10.Click, Drinks_Button_Placeholder11.Click, Drinks_Button_Placeholder12.Click, Drinks_Button_Placeholder13.Click, Drinks_Button_Placeholder14.Click,
                                                                                   Drinks_Button_Placeholder15.Click, Drinks_Button_Placeholder16.Click, Drinks_Button_Placeholder17.Click, Drinks_Button_Placeholder18.Click, Drinks_Button_Placeholder19.Click,
                                                                                   Drinks_Button_Placeholder20.Click, Drinks_Button_Placeholder21.Click, Drinks_Button_Placeholder22.Click, Drinks_Button_Placeholder23.Click, Drinks_Button_Placeholder24.Click,
                                                                                   Drinks_Button_Placeholder25.Click, Drinks_Button_Placeholder26.Click, Drinks_Button_Placeholder27.Click

        addToOrder(sender)

    End Sub

    'Add an item to the order using a button to get the correct item. (Used when adding an item via a menu button)
    Private Sub addToOrder(sender As Object)

        'create a new button, using the button that was clicked for attributes - Used to grab menu items.
        Dim tempBtn As Button = CType(sender, Button)

        'tempName = number of the button (remove all characters apart from number) - used to reference position of menu item in hashtable
        Dim tempName As Integer = util.removeChars(tempBtn.Name)

        Dim catagory As String
        Dim productName As String
        Dim productPrice As Double
        Dim values() As String

        'Split the button name at underscore and store in values - values(0) = catagory
        values = tempBtn.Name.Split(New Char() {"_"})
        catagory = values(0)

        'Set the productName and productPrice using the number of the button to reference the hashtable and catagory to reference the correct one.
        Select Case catagory
            Case "Specials"
                productName = InventoryTableAdapter.GetButtonName(specials.buttonDataLinkSpecials(tempName))
                productPrice = InventoryTableAdapter.GetProductPrice(specials.buttonDataLinkSpecials(tempName))
            Case "Starters"
                productName = InventoryTableAdapter.GetButtonName(starters.buttonDataLinkStarters(tempName))
                productPrice = InventoryTableAdapter.GetProductPrice(starters.buttonDataLinkStarters(tempName))
            Case "Mains"
                productName = InventoryTableAdapter.GetButtonName(mains.buttonDataLinkMains(tempName))
                productPrice = InventoryTableAdapter.GetProductPrice(mains.buttonDataLinkMains(tempName))
            Case "Burgers"
                productName = InventoryTableAdapter.GetButtonName(burgers.buttonDataLinkBurgers(tempName))
                productPrice = InventoryTableAdapter.GetProductPrice(burgers.buttonDataLinkBurgers(tempName))
            Case "Kids"
                productName = InventoryTableAdapter.GetButtonName(kids.buttonDataLinkKids(tempName))
                productPrice = InventoryTableAdapter.GetProductPrice(kids.buttonDataLinkKids(tempName))
            Case "Desserts"
                productName = InventoryTableAdapter.GetButtonName(desserts.buttonDataLinkDesserts(tempName))
                productPrice = InventoryTableAdapter.GetProductPrice(desserts.buttonDataLinkDesserts(tempName))
            Case "Salads"
                productName = InventoryTableAdapter.GetButtonName(salads.buttonDataLinkSalads(tempName))
                productPrice = InventoryTableAdapter.GetProductPrice(salads.buttonDataLinkSalads(tempName))
            Case "Sides"
                productName = InventoryTableAdapter.GetButtonName(sides.buttonDataLinkSides(tempName))
                productPrice = InventoryTableAdapter.GetProductPrice(sides.buttonDataLinkSides(tempName))
            Case "Drinks"
                productName = InventoryTableAdapter.GetButtonName(drinks.buttonDataLinkDrinks(tempName))
                productPrice = InventoryTableAdapter.GetProductPrice(drinks.buttonDataLinkDrinks(tempName))
        End Select

        'set currentTransactionComplete to false as there is now a transaction in progress.
        currentTransactionComplete = False


        'keep track of total cost for current transaction
        totalCost += productPrice

        'calculate the cost with any added discount
        calcCostWDiscount()

        'display the current order items
        TextBox_CurrentOrder.Text &= productName & Environment.NewLine
        'display the current price of each item
        TextBox_CurrentOrderPrices.Text &= productPrice & Environment.NewLine
        'display the total cost of the order with discount
        TextBox_TotalCost.Text = totalCostWDiscount
    End Sub

    'Add an item to order with a specified catagory and id (Used for adding an item to an order by ID)
    Private Sub addToOrder(catagory As String, id As Integer)

        Dim productName As String
        Dim productPrice As Double

        'Set the productName and productPrice using the number of the button to reference the hashtable and catagory to reference the correct one.
        Select Case catagory
            Case "Specials"
                ProductName = InventoryTableAdapter.GetButtonName(specials.buttonDataLinkSpecials(id))
                productPrice = InventoryTableAdapter.GetProductPrice(specials.buttonDataLinkSpecials(id))
            Case "Starters"
                ProductName = InventoryTableAdapter.GetButtonName(starters.buttonDataLinkStarters(id))
                productPrice = InventoryTableAdapter.GetProductPrice(starters.buttonDataLinkStarters(id))
            Case "Mains"
                ProductName = InventoryTableAdapter.GetButtonName(mains.buttonDataLinkMains(id))
                productPrice = InventoryTableAdapter.GetProductPrice(mains.buttonDataLinkMains(id))
            Case "Burgers"
                ProductName = InventoryTableAdapter.GetButtonName(burgers.buttonDataLinkBurgers(id))
                productPrice = InventoryTableAdapter.GetProductPrice(burgers.buttonDataLinkBurgers(id))
            Case "Kids"
                ProductName = InventoryTableAdapter.GetButtonName(kids.buttonDataLinkKids(id))
                productPrice = InventoryTableAdapter.GetProductPrice(kids.buttonDataLinkKids(id))
            Case "Desserts"
                ProductName = InventoryTableAdapter.GetButtonName(desserts.buttonDataLinkDesserts(id))
                productPrice = InventoryTableAdapter.GetProductPrice(desserts.buttonDataLinkDesserts(id))
            Case "Salads"
                ProductName = InventoryTableAdapter.GetButtonName(salads.buttonDataLinkSalads(id))
                productPrice = InventoryTableAdapter.GetProductPrice(salads.buttonDataLinkSalads(id))
            Case "Sides"
                ProductName = InventoryTableAdapter.GetButtonName(sides.buttonDataLinkSides(id))
                productPrice = InventoryTableAdapter.GetProductPrice(sides.buttonDataLinkSides(id))
            Case "Drinks"
                ProductName = InventoryTableAdapter.GetButtonName(drinks.buttonDataLinkDrinks(id))
                productPrice = InventoryTableAdapter.GetProductPrice(drinks.buttonDataLinkDrinks(id))
        End Select

        'set currentTransactionComplete to false as there is now a transaction in progress.
        currentTransactionComplete = False


        'keep track of total cost for current transaction
        totalCost += productPrice

        'calculate the cost with any added discount
        calcCostWDiscount()

        'display the current order items
        TextBox_CurrentOrder.Text &= productName & Environment.NewLine
        'display the current price of each item
        TextBox_CurrentOrderPrices.Text &= productPrice & Environment.NewLine
        'display the total cost of the order with discount
        TextBox_TotalCost.Text = totalCostWDiscount
    End Sub

    'calculate the total cost with an added discount if there is one active
    Private Sub calcCostWDiscount()
        If student Then
            totalCostWDiscount = totalCost - (totalCost * 0.1) 'apply 10% discount
        ElseIf staff Then
            totalCostWDiscount = totalCost - (totalCost * 0.15) 'apply 15% discount
        ElseIf fivePercent Then
            totalCostWDiscount = totalCost - (totalCost * 0.05) 'apply 5% discount
        ElseIf tenPercent Then
            totalCostWDiscount = totalCost - (totalCost * 0.1) 'apply 10% discount
        ElseIf fifteenPercent Then
            totalCostWDiscount = totalCost - (totalCost * 0.15) 'apply 15% discount
        ElseIf twentyPercent Then
            totalCostWDiscount = totalCost - (totalCost * 0.2) 'apply 20% discount
        Else
            totalCostWDiscount = totalCost
        End If

        'update the total cost of the order with discount
        TextBox_TotalCost.Text = totalCostWDiscount
    End Sub

    'Split the ID from the AddProductByID form and call the addToOrder method with the specified parameters.
    Public Sub addProductByID(productID As String)
        Dim values As Array
        values = productID.Split(New Char() {"_"}) 'split the id at the underscore to seperate the ID number and catagory name
        addToOrder(values(0), values(1))
    End Sub

    'This method is called when training mode is toggled. - This will set the application to allow the user to use all features without having to process transactions.
    Private Sub trainingMode()

        'If training mode is on, turn it off. - change labels and etc.., display a msg telling the user training mode is no longer active.
        If trainingModeActive = True Then
            trainingModeActive = False
            TurnTrainingModeOnToolStripMenuItem.Text = "Turn Training Mode On"
            Label_Training.Visible = False
            Me.Text = "POS System"
            MsgBox("Training mode is now de-activated")
        Else 'If training mode is off, turn it on. - change labels and etc.., display a msg telling the user training mode is now active.
            trainingModeActive = True
            TurnTrainingModeOnToolStripMenuItem.Text = "Turn Training Mode Off"
            Label_Training.Visible = True
            Me.Text &= " - Training Mode"

            MsgBox("Training mode is now activated")
        End If
    End Sub
End Class
