Public Class Form_SelectTable

    Private ReadOnly utils As New Class_Utils

    Private number As Integer
    Private transactionID As Integer

    Private Sub Form_SelectTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        transactionID = Form_POSSystem.transactionNo 'Set local transactionID to the transactionID in Form_POSSystem
        Label1.Text = "Select a table to assign to transaction '" & transactionID & "'." 'Change the label to match the current transactionID
    End Sub

    'Button handler for table buttons
    Private Sub TableButtons_Click(sender As Object, e As EventArgs) Handles Button_Table1.Click, Button_Table2.Click, Button_Table3.Click, Button_Table4.Click, Button_Table5.Click, Button_Table6.Click, Button_Table7.Click, Button_Table8.Click, Button_Table9.Click,
                                                                             Button_Table10.Click, Button_Table11.Click, Button_Table12.Click, Button_Table13.Click, Button_Table14.Click, Button_Table15.Click, Button_Table16.Click, Button_Table17.Click, Button_Table18.Click
        Dim tempBtn As Button = CType(sender, Button) 'Create a temporary button to be used to reference each button.
        number = utils.removeChars(tempBtn.Name) 'Remove all characters from the name that are not numbers

        'Confirm if the user wants to assign this table, if yes, then assign the currentTable variable to the number and inform the user, also update labels on the POSSystem form.
        Select Case MsgBox("Are you sure you would like to assign table '" & number & "' to transaction '" & transactionID & "'?", MsgBoxStyle.YesNoCancel, "Are you sure?")
            Case MsgBoxResult.Yes
                Form_POSSystem.currentTable = number
                MsgBox("Table '" & number & "' was assigned to transaction '" & transactionID & "'.")
                Form_POSSystem.addinfo() 'Update the current table label
                Form_POSSystem.BringToFront() 'Bring POS back to the front.
                Me.Close() 'Close this form
            Case MsgBoxResult.No
                Exit Sub
            Case MsgBoxResult.Cancel
                Exit Sub
        End Select
    End Sub
End Class