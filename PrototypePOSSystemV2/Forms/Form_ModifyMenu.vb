Public Class Form_ModifyMenu

    Private ReadOnly utils As New Class_Utils

    Private lineCounter As Integer

    'When the form is loaded fill the textboxes and datatable
    Private Sub Form_ModifyMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Fill the inventory datatable
        Me.InventoryTableAdapter.Fill(Me.Database_POSSystemDataSet.Inventory)

        'Fill textboxes with menu items if a menu file already exisits
        For Each tabControl As TabControl In Me.Controls.OfType(Of TabControl)
            For Each tab As TabPage In tabControl.Controls.OfType(Of TabPage)
                For Each pnl As Panel In tab.Controls.OfType(Of Panel)
                    For Each txtbox As TextBox In pnl.Controls.OfType(Of TextBox)
                        If txtbox.Name.Contains("Menu") Then
                            Dim tempStr() As String
                            Dim catagory As String
                            tempStr = txtbox.Name.Split(New Char() {"_"})
                            catagory = tempStr(1)

                            'Check if a file exists, if not create one.
                            If Not utils.checkForMenuFile(catagory) Then
                                System.IO.File.Create(utils.path & "\" & catagory & ".menu")
                            End If

                            'Add each line in the file to the text box and create a new line.
                            For Each line As String In System.IO.File.ReadAllLines(utils.path & "\" & catagory & ".menu")
                                lineCounter += 1
                                txtbox.Text &= line & Environment.NewLine
                            Next
                        End If
                    Next
                Next
            Next
        Next
    End Sub

    'Save and update button handler
    Private Sub Button_SaveAndUpdate_Click(sender As Object, e As EventArgs) Handles Button_SaveAndUpdate.Click
        writeSaveFiles() 'write to the text files so that changes are remembered
        utils.refreshButtons() 'reset all buttons
        Form_POSSystem.getMenuItems() 'initialise buttons
        MsgBox("All files saved and menu has been updated.")
        Me.Close()
        Form_POSSystem.BringToFront()
    End Sub

    'Save button handler
    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        writeSaveFiles() 'write To the text files so that changes are remembered
        MsgBox("All files saved.")
        Me.Close()
        Form_POSSystem.BringToFront()
    End Sub

    'Write changes to text files 
    Private Sub writeSaveFiles()
        For Each tabControl As TabControl In Me.Controls.OfType(Of TabControl)
            For Each tab As TabPage In tabControl.Controls.OfType(Of TabPage)
                For Each pnl As Panel In tab.Controls.OfType(Of Panel)
                    For Each txtbox As TextBox In pnl.Controls.OfType(Of TextBox)
                        If txtbox.Name.Contains("Menu") Then
                            Dim tempStr() As String
                            Dim catagory As String
                            tempStr = txtbox.Name.Split(New Char() {"_"})
                            catagory = tempStr(1)

                            'Check if a file exists, if not create one.
                            If Not utils.checkForMenuFile(catagory) Then
                                System.IO.File.Create(utils.path & "\" & catagory & ".menu")
                                Console.WriteLine("Created a file for: " & catagory)
                            End If

                            'Add each line in the file to the text box and create a new line.
                            System.IO.File.WriteAllLines(utils.path & "\" & catagory & ".menu", txtbox.Lines)

                            'increment lineCounter
                            For Each line As String In txtbox.Lines
                                lineCounter += 1
                            Next
                        End If
                    Next
                Next
            Next
        Next
    End Sub
End Class