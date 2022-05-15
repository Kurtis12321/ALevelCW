Imports System.Data.OleDb

Public Class Class_Utils

    Dim provider As String
    Dim datatFile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Public path As String = My.Application.Info.DirectoryPath
    Public buttonCount As Integer

    'Method to check if a menu file exists for the provided catagory, if not it will make one.
    Sub checkAndCreateMenuFile(currentCatagory As String)
        'if there is not a file for the catagory, make one
        If Not My.Computer.FileSystem.FileExists(path & "\" & currentCatagory & ".menu") Then
            System.IO.File.Create(path & "\" & currentCatagory & ".menu")
        End If
    End Sub

    'Function which checks if a file exists, returns true if it does.
    Function checkForMenuFile(currentCatagory As String)
        If My.Computer.FileSystem.FileExists(path & "\" & currentCatagory & ".menu") Then
            Return True
        Else
            Return False
        End If
    End Function

    'Function which will find all controls of a provided type within a form, including those in panels and groupboxes.
    Function GetAllControls(ByVal list As List(Of Control), ByVal parent As Control, ByVal ctrlType As System.Type) As List(Of Control)
        'if the current control does not have a parent then return the current list.
        If parent Is Nothing Then Return list

        If parent.GetType Is ctrlType Then
            list.Add(parent) 'add the control to the list.
        End If

        For Each child As Control In parent.Controls
            GetAllControls(list, child, ctrlType) 'recursive call to repeat until their are no more controls.
        Next
    End Function


    'Function to remove all characters other than numbers from a provided string.
    Function removeChars(s As String) As String

        Dim result As String = Nothing

        'check each character, if it is a number add it to the result string
        For i = 1 To Len(s)
            If Mid(s, i, 1) >= "0" And Mid(s, i, 1) <= "9" Then
                result &= Mid(s, i, 1)
            End If
        Next

        Return result
    End Function

    'Refresh buttons - reset the text, colour and visibility | Called when the menu is modified to remove any buttons that were removed.
    Public Sub refreshButtons()
        For Each pnl As Panel In Form_POSSystem.Controls.OfType(Of Panel) 'For every panel on the form if its catagory panel then for each button within the panel reset its variables.
            If pnl.Name = "Panel_CatSpecials" Or pnl.Name = "Panel_CatStarters" Or pnl.Name = "Panel_CatMains" Or pnl.Name = "Panel_CatBurgers" Or pnl.Name = "Panel_CatKids" Or pnl.Name = "Panel_CatDesserts" Or pnl.Name = "Panel_CatSalads" Or pnl.Name = "Panel_CatSides" Or pnl.Name = "Panel_CatDrinks" Then
                For Each btn As Button In pnl.Controls.OfType(Of Button)
                    btn.Text = ""
                    btn.BackColor = Color.White
                    btn.Visible = False
                Next
            End If
        Next
    End Sub


    '--------------------------------
    '-------- Database Stuff --------
    '--------------------------------

    'Add a new transaction to the transaction database.
    Sub addToTransactionDatabase()
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
        datatFile = Application.StartupPath & "\Database_POSSystem.accdb"
        connString = provider & datatFile
        myConnection.ConnectionString = connString
        myConnection.Open() 'Open a connection to the database.
        Dim str As String
        str = "Insert into Transactions([TransactionID],[AccountID],[CustomerID],[TransactionDate],[PricePaid],[TableNo]) Values (?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection) 'Define a command and specify the parameters.
        cmd.Parameters.Add(New OleDbParameter("TransactionID", CType(Form_POSSystem.transactionNo, String)))
        cmd.Parameters.Add(New OleDbParameter("AccountID", CType(Form_POSSystem.accountID, String)))
        cmd.Parameters.Add(New OleDbParameter("CustomerID", CType(Form_POSSystem.customerID, String)))
        cmd.Parameters.Add(New OleDbParameter("TransactionDate", CType(Date.Today, String)))
        cmd.Parameters.Add(New OleDbParameter("PricePaid", CType(Form_POSSystem.totalCost, String)))
        cmd.Parameters.Add(New OleDbParameter("TableNo", CType(Form_POSSystem.currentTable, String)))

        'Execute the command and then close the connection, output an error message if an error occurs.
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnection.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Class
