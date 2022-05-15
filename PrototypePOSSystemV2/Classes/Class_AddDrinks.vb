Public Class Class_AddDrinks

    Dim util As New Class_Utils
    Dim htCounter As Integer = 0
    Dim buttonCount As Integer = 0
    Dim currentCatagory As String = "Drinks"
    Public buttonDataLinkDrinks As Hashtable = New Hashtable

    'Initialisation method - will read text files and allocate buttons to menu items on the form.
    Public Sub init()

        'Clear variables
        htCounter = Nothing
        buttonCount = Nothing
        buttonDataLinkDrinks = New Hashtable

        'check if a menu file exists, if not create it
        util.checkAndCreateMenuFile(currentCatagory)

        'basically, read the text file, for every line change a placeholder button, will be updated with the properties of that line of text.
        For Each line As String In System.IO.File.ReadLines(util.path & "\" & currentCatagory & ".menu")

            'If the line is blank then exit the method.
            If line = "" Then
                Exit Sub
            End If

            'Counter used for button numbers
            buttonCount += 1

            Dim values() As String
            values = line.Split(New Char() {","})   'Split the current line at each comma.

            htCounter += 1
            buttonDataLinkDrinks.Add(htCounter, values(1)) 'Add the second part of the line to a hashtable, This is used as a data link to link to the inventory database and get the price and other information.

            'debug stuff
            Console.WriteLine(htCounter)
            Console.WriteLine(currentCatagory)
            Console.WriteLine(buttonCount)
            Console.WriteLine(values(0))

            'For each panel on the form, if it's name is equal to Panel_CatSpecials then change the name and colour of a button on that panel.
            For Each pnl As Panel In Form_POSSystem.Controls.OfType(Of Panel)
                If pnl.Name = "Panel_Cat" & currentCatagory Then
                    pnl.Controls(currentCatagory & "_Button_Placeholder" & buttonCount).Text = values(0)    'Set the name to the first part of the line.
                    pnl.Controls(currentCatagory & "_Button_Placeholder" & buttonCount).BackColor = Color.FromName(values(2))   'Set the colour to the third part of the line.
                    pnl.Controls(currentCatagory & "_Button_Placeholder" & buttonCount).Visible = True 'Set the button to visible
                End If
            Next
        Next
    End Sub
End Class