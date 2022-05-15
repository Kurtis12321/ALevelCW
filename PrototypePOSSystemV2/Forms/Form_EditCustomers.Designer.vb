<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_EditCustomers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim AddressLine1Label As System.Windows.Forms.Label
        Dim Town_CityLabel As System.Windows.Forms.Label
        Dim PostcodeLabel As System.Windows.Forms.Label
        Dim TelephoneNoLabel As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim NoOfVisitsToRestaurantLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_EditCustomers))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Database_POSSystemDataSet = New PrototypePOSSystemV2.Database_POSSystemDataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.TableAdapterManager()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressLine1TextBox = New System.Windows.Forms.TextBox()
        Me.Town_CityTextBox = New System.Windows.Forms.TextBox()
        Me.PostcodeTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneNoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.NoOfVisitsToRestaurantTextBox = New System.Windows.Forms.TextBox()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Button_Prev = New System.Windows.Forms.Button()
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.Button_New = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        CustomerIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        AddressLine1Label = New System.Windows.Forms.Label()
        Town_CityLabel = New System.Windows.Forms.Label()
        PostcodeLabel = New System.Windows.Forms.Label()
        TelephoneNoLabel = New System.Windows.Forms.Label()
        EmailAddressLabel = New System.Windows.Forms.Label()
        NoOfVisitsToRestaurantLabel = New System.Windows.Forms.Label()
        CType(Me.Database_POSSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CustomerIDLabel.Location = New System.Drawing.Point(23, 51)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(83, 17)
        CustomerIDLabel.TabIndex = 27
        CustomerIDLabel.Text = "Customer ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(32, 92)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(74, 17)
        FirstNameLabel.TabIndex = 29
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(33, 120)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(73, 17)
        LastNameLabel.TabIndex = 31
        LastNameLabel.Text = "Last Name:"
        '
        'AddressLine1Label
        '
        AddressLine1Label.AutoSize = True
        AddressLine1Label.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLine1Label.Location = New System.Drawing.Point(13, 151)
        AddressLine1Label.Name = "AddressLine1Label"
        AddressLine1Label.Size = New System.Drawing.Size(93, 17)
        AddressLine1Label.TabIndex = 33
        AddressLine1Label.Text = "Address Line1:"
        '
        'Town_CityLabel
        '
        Town_CityLabel.AutoSize = True
        Town_CityLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Town_CityLabel.Location = New System.Drawing.Point(38, 182)
        Town_CityLabel.Name = "Town_CityLabel"
        Town_CityLabel.Size = New System.Drawing.Size(68, 17)
        Town_CityLabel.TabIndex = 35
        Town_CityLabel.Text = "Town/City:"
        '
        'PostcodeLabel
        '
        PostcodeLabel.AutoSize = True
        PostcodeLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PostcodeLabel.Location = New System.Drawing.Point(41, 213)
        PostcodeLabel.Name = "PostcodeLabel"
        PostcodeLabel.Size = New System.Drawing.Size(65, 17)
        PostcodeLabel.TabIndex = 37
        PostcodeLabel.Text = "Postcode:"
        '
        'TelephoneNoLabel
        '
        TelephoneNoLabel.AutoSize = True
        TelephoneNoLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelephoneNoLabel.Location = New System.Drawing.Point(12, 244)
        TelephoneNoLabel.Name = "TelephoneNoLabel"
        TelephoneNoLabel.Size = New System.Drawing.Size(94, 17)
        TelephoneNoLabel.TabIndex = 39
        TelephoneNoLabel.Text = "Telephone No:"
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.AutoSize = True
        EmailAddressLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailAddressLabel.Location = New System.Drawing.Point(12, 275)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(94, 17)
        EmailAddressLabel.TabIndex = 41
        EmailAddressLabel.Text = "Email Address:"
        '
        'NoOfVisitsToRestaurantLabel
        '
        NoOfVisitsToRestaurantLabel.AutoSize = True
        NoOfVisitsToRestaurantLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoOfVisitsToRestaurantLabel.Location = New System.Drawing.Point(65, 306)
        NoOfVisitsToRestaurantLabel.Name = "NoOfVisitsToRestaurantLabel"
        NoOfVisitsToRestaurantLabel.Size = New System.Drawing.Size(41, 17)
        NoOfVisitsToRestaurantLabel.TabIndex = 43
        NoOfVisitsToRestaurantLabel.Text = "Visits:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Edit Customer Accounts"
        '
        'Database_POSSystemDataSet
        '
        Me.Database_POSSystemDataSet.DataSetName = "Database_POSSystemDataSet"
        Me.Database_POSSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.Database_POSSystemDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CustomerIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(112, 51)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.ReadOnly = True
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(38, 18)
        Me.CustomerIDTextBox.TabIndex = 28
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(112, 86)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(147, 25)
        Me.FirstNameTextBox.TabIndex = 30
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "LastName", True))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(112, 117)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(147, 25)
        Me.LastNameTextBox.TabIndex = 32
        '
        'AddressLine1TextBox
        '
        Me.AddressLine1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "AddressLine1", True))
        Me.AddressLine1TextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLine1TextBox.Location = New System.Drawing.Point(112, 148)
        Me.AddressLine1TextBox.Name = "AddressLine1TextBox"
        Me.AddressLine1TextBox.Size = New System.Drawing.Size(147, 25)
        Me.AddressLine1TextBox.TabIndex = 34
        '
        'Town_CityTextBox
        '
        Me.Town_CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Town/City", True))
        Me.Town_CityTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Town_CityTextBox.Location = New System.Drawing.Point(112, 179)
        Me.Town_CityTextBox.Name = "Town_CityTextBox"
        Me.Town_CityTextBox.Size = New System.Drawing.Size(147, 25)
        Me.Town_CityTextBox.TabIndex = 36
        '
        'PostcodeTextBox
        '
        Me.PostcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Postcode", True))
        Me.PostcodeTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostcodeTextBox.Location = New System.Drawing.Point(112, 210)
        Me.PostcodeTextBox.Name = "PostcodeTextBox"
        Me.PostcodeTextBox.Size = New System.Drawing.Size(147, 25)
        Me.PostcodeTextBox.TabIndex = 38
        '
        'TelephoneNoTextBox
        '
        Me.TelephoneNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "TelephoneNo", True))
        Me.TelephoneNoTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelephoneNoTextBox.Location = New System.Drawing.Point(112, 241)
        Me.TelephoneNoTextBox.Name = "TelephoneNoTextBox"
        Me.TelephoneNoTextBox.Size = New System.Drawing.Size(147, 25)
        Me.TelephoneNoTextBox.TabIndex = 40
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(112, 272)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(147, 25)
        Me.EmailAddressTextBox.TabIndex = 42
        '
        'NoOfVisitsToRestaurantTextBox
        '
        Me.NoOfVisitsToRestaurantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "NoOfVisitsToRestaurant", True))
        Me.NoOfVisitsToRestaurantTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoOfVisitsToRestaurantTextBox.Location = New System.Drawing.Point(112, 303)
        Me.NoOfVisitsToRestaurantTextBox.Name = "NoOfVisitsToRestaurantTextBox"
        Me.NoOfVisitsToRestaurantTextBox.Size = New System.Drawing.Size(147, 25)
        Me.NoOfVisitsToRestaurantTextBox.TabIndex = 44
        '
        'Button_Delete
        '
        Me.Button_Delete.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Delete.Location = New System.Drawing.Point(191, 370)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(68, 30)
        Me.Button_Delete.TabIndex = 49
        Me.Button_Delete.Text = "Delete"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Prev
        '
        Me.Button_Prev.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Prev.Location = New System.Drawing.Point(112, 334)
        Me.Button_Prev.Name = "Button_Prev"
        Me.Button_Prev.Size = New System.Drawing.Size(34, 30)
        Me.Button_Prev.TabIndex = 46
        Me.Button_Prev.Text = "<"
        Me.Button_Prev.UseVisualStyleBackColor = True
        '
        'Button_Next
        '
        Me.Button_Next.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Next.Location = New System.Drawing.Point(151, 334)
        Me.Button_Next.Name = "Button_Next"
        Me.Button_Next.Size = New System.Drawing.Size(34, 30)
        Me.Button_Next.TabIndex = 47
        Me.Button_Next.Text = ">"
        Me.Button_Next.UseVisualStyleBackColor = True
        '
        'Button_New
        '
        Me.Button_New.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_New.Location = New System.Drawing.Point(191, 334)
        Me.Button_New.Name = "Button_New"
        Me.Button_New.Size = New System.Drawing.Size(68, 30)
        Me.Button_New.TabIndex = 48
        Me.Button_New.Text = "New"
        Me.Button_New.UseVisualStyleBackColor = True
        '
        'Button_Save
        '
        Me.Button_Save.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(191, 406)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(68, 30)
        Me.Button_Save.TabIndex = 45
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Form_EditCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(280, 449)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Prev)
        Me.Controls.Add(Me.Button_Next)
        Me.Controls.Add(Me.Button_New)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(AddressLine1Label)
        Me.Controls.Add(Me.AddressLine1TextBox)
        Me.Controls.Add(Town_CityLabel)
        Me.Controls.Add(Me.Town_CityTextBox)
        Me.Controls.Add(PostcodeLabel)
        Me.Controls.Add(Me.PostcodeTextBox)
        Me.Controls.Add(TelephoneNoLabel)
        Me.Controls.Add(Me.TelephoneNoTextBox)
        Me.Controls.Add(EmailAddressLabel)
        Me.Controls.Add(Me.EmailAddressTextBox)
        Me.Controls.Add(NoOfVisitsToRestaurantLabel)
        Me.Controls.Add(Me.NoOfVisitsToRestaurantTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_EditCustomers"
        Me.Text = "POS System  |  Edit Customer"
        CType(Me.Database_POSSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Database_POSSystemDataSet As Database_POSSystemDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As Database_POSSystemDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As Database_POSSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents AddressLine1TextBox As TextBox
    Friend WithEvents Town_CityTextBox As TextBox
    Friend WithEvents PostcodeTextBox As TextBox
    Friend WithEvents TelephoneNoTextBox As TextBox
    Friend WithEvents EmailAddressTextBox As TextBox
    Friend WithEvents NoOfVisitsToRestaurantTextBox As TextBox
    Friend WithEvents Button_Delete As Button
    Friend WithEvents Button_Prev As Button
    Friend WithEvents Button_Next As Button
    Friend WithEvents Button_New As Button
    Friend WithEvents Button_Save As Button
End Class
