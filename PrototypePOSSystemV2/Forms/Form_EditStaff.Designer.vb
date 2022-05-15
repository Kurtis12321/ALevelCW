<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_EditStaff
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
        Dim AccountIDLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim AdministratorLabel As System.Windows.Forms.Label
        Dim AddressLine1Label As System.Windows.Forms.Label
        Dim TownLabel As System.Windows.Forms.Label
        Dim PostCodeLabel As System.Windows.Forms.Label
        Dim TelephoneNoLabel As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_EditStaff))
        Me.Database_POSSystemDataSet = New PrototypePOSSystemV2.Database_POSSystemDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.TableAdapterManager()
        Me.AccountIDTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.AdministratorCheckBox = New System.Windows.Forms.CheckBox()
        Me.AddressLine1TextBox = New System.Windows.Forms.TextBox()
        Me.TownTextBox = New System.Windows.Forms.TextBox()
        Me.PostCodeTextBox = New System.Windows.Forms.TextBox()
        Me.TelephoneNoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_ShowPass = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Button_New = New System.Windows.Forms.Button()
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.Button_Prev = New System.Windows.Forms.Button()
        Me.Button_Delete = New System.Windows.Forms.Button()
        AccountIDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        AdministratorLabel = New System.Windows.Forms.Label()
        AddressLine1Label = New System.Windows.Forms.Label()
        TownLabel = New System.Windows.Forms.Label()
        PostCodeLabel = New System.Windows.Forms.Label()
        TelephoneNoLabel = New System.Windows.Forms.Label()
        EmailAddressLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        CType(Me.Database_POSSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccountIDLabel
        '
        AccountIDLabel.AutoSize = True
        AccountIDLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AccountIDLabel.Location = New System.Drawing.Point(33, 51)
        AccountIDLabel.Name = "AccountIDLabel"
        AccountIDLabel.Size = New System.Drawing.Size(73, 17)
        AccountIDLabel.TabIndex = 1
        AccountIDLabel.Text = "Account ID:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.Location = New System.Drawing.Point(36, 89)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(70, 17)
        UsernameLabel.TabIndex = 3
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(39, 120)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(67, 17)
        PasswordLabel.TabIndex = 5
        PasswordLabel.Text = "Password:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(32, 151)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(74, 17)
        FirstNameLabel.TabIndex = 7
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(33, 182)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(73, 17)
        LastNameLabel.TabIndex = 9
        LastNameLabel.Text = "Last Name:"
        '
        'AdministratorLabel
        '
        AdministratorLabel.AutoSize = True
        AdministratorLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AdministratorLabel.Location = New System.Drawing.Point(16, 213)
        AdministratorLabel.Name = "AdministratorLabel"
        AdministratorLabel.Size = New System.Drawing.Size(90, 17)
        AdministratorLabel.TabIndex = 11
        AdministratorLabel.Text = "Administrator:"
        '
        'AddressLine1Label
        '
        AddressLine1Label.AutoSize = True
        AddressLine1Label.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLine1Label.Location = New System.Drawing.Point(13, 243)
        AddressLine1Label.Name = "AddressLine1Label"
        AddressLine1Label.Size = New System.Drawing.Size(93, 17)
        AddressLine1Label.TabIndex = 13
        AddressLine1Label.Text = "Address Line1:"
        '
        'TownLabel
        '
        TownLabel.AutoSize = True
        TownLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TownLabel.Location = New System.Drawing.Point(64, 274)
        TownLabel.Name = "TownLabel"
        TownLabel.Size = New System.Drawing.Size(42, 17)
        TownLabel.TabIndex = 15
        TownLabel.Text = "Town:"
        '
        'PostCodeLabel
        '
        PostCodeLabel.AutoSize = True
        PostCodeLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PostCodeLabel.Location = New System.Drawing.Point(35, 305)
        PostCodeLabel.Name = "PostCodeLabel"
        PostCodeLabel.Size = New System.Drawing.Size(71, 17)
        PostCodeLabel.TabIndex = 17
        PostCodeLabel.Text = "Post Code:"
        '
        'TelephoneNoLabel
        '
        TelephoneNoLabel.AutoSize = True
        TelephoneNoLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelephoneNoLabel.Location = New System.Drawing.Point(12, 336)
        TelephoneNoLabel.Name = "TelephoneNoLabel"
        TelephoneNoLabel.Size = New System.Drawing.Size(94, 17)
        TelephoneNoLabel.TabIndex = 19
        TelephoneNoLabel.Text = "Telephone No:"
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.AutoSize = True
        EmailAddressLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailAddressLabel.Location = New System.Drawing.Point(12, 367)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(94, 17)
        EmailAddressLabel.TabIndex = 21
        EmailAddressLabel.Text = "Email Address:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PositionLabel.Location = New System.Drawing.Point(49, 398)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(57, 17)
        PositionLabel.TabIndex = 23
        PositionLabel.Text = "Position:"
        '
        'Database_POSSystemDataSet
        '
        Me.Database_POSSystemDataSet.DataSetName = "Database_POSSystemDataSet"
        Me.Database_POSSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.Database_POSSystemDataSet
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Me.StaffTableAdapter
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AccountIDTextBox
        '
        Me.AccountIDTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AccountIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AccountIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "AccountID", True))
        Me.AccountIDTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountIDTextBox.Location = New System.Drawing.Point(112, 51)
        Me.AccountIDTextBox.Name = "AccountIDTextBox"
        Me.AccountIDTextBox.ReadOnly = True
        Me.AccountIDTextBox.Size = New System.Drawing.Size(38, 18)
        Me.AccountIDTextBox.TabIndex = 2
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Username", True))
        Me.UsernameTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(112, 86)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(147, 25)
        Me.UsernameTextBox.TabIndex = 4
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Password", True))
        Me.PasswordTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(112, 117)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(147, 25)
        Me.PasswordTextBox.TabIndex = 6
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(112, 148)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(147, 25)
        Me.FirstNameTextBox.TabIndex = 8
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "LastName", True))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(112, 179)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(147, 25)
        Me.LastNameTextBox.TabIndex = 10
        '
        'AdministratorCheckBox
        '
        Me.AdministratorCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.StaffBindingSource, "Administrator", True))
        Me.AdministratorCheckBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministratorCheckBox.Location = New System.Drawing.Point(112, 210)
        Me.AdministratorCheckBox.Name = "AdministratorCheckBox"
        Me.AdministratorCheckBox.Size = New System.Drawing.Size(147, 24)
        Me.AdministratorCheckBox.TabIndex = 12
        Me.AdministratorCheckBox.UseVisualStyleBackColor = True
        '
        'AddressLine1TextBox
        '
        Me.AddressLine1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "AddressLine1", True))
        Me.AddressLine1TextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLine1TextBox.Location = New System.Drawing.Point(112, 240)
        Me.AddressLine1TextBox.Name = "AddressLine1TextBox"
        Me.AddressLine1TextBox.Size = New System.Drawing.Size(147, 25)
        Me.AddressLine1TextBox.TabIndex = 14
        '
        'TownTextBox
        '
        Me.TownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Town", True))
        Me.TownTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TownTextBox.Location = New System.Drawing.Point(112, 271)
        Me.TownTextBox.Name = "TownTextBox"
        Me.TownTextBox.Size = New System.Drawing.Size(147, 25)
        Me.TownTextBox.TabIndex = 16
        '
        'PostCodeTextBox
        '
        Me.PostCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "PostCode", True))
        Me.PostCodeTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostCodeTextBox.Location = New System.Drawing.Point(112, 302)
        Me.PostCodeTextBox.Name = "PostCodeTextBox"
        Me.PostCodeTextBox.Size = New System.Drawing.Size(147, 25)
        Me.PostCodeTextBox.TabIndex = 18
        '
        'TelephoneNoTextBox
        '
        Me.TelephoneNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "TelephoneNo", True))
        Me.TelephoneNoTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelephoneNoTextBox.Location = New System.Drawing.Point(112, 333)
        Me.TelephoneNoTextBox.Name = "TelephoneNoTextBox"
        Me.TelephoneNoTextBox.Size = New System.Drawing.Size(147, 25)
        Me.TelephoneNoTextBox.TabIndex = 20
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(112, 364)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(147, 25)
        Me.EmailAddressTextBox.TabIndex = 22
        '
        'PositionTextBox
        '
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Position", True))
        Me.PositionTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionTextBox.Location = New System.Drawing.Point(112, 395)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(147, 25)
        Me.PositionTextBox.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Edit Staff Accounts"
        '
        'Button_ShowPass
        '
        Me.Button_ShowPass.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ShowPass.Location = New System.Drawing.Point(265, 117)
        Me.Button_ShowPass.Name = "Button_ShowPass"
        Me.Button_ShowPass.Size = New System.Drawing.Size(54, 25)
        Me.Button_ShowPass.TabIndex = 26
        Me.Button_ShowPass.Text = "Show"
        Me.Button_ShowPass.UseVisualStyleBackColor = True
        '
        'Button_Save
        '
        Me.Button_Save.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(258, 438)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(61, 30)
        Me.Button_Save.TabIndex = 27
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Button_New
        '
        Me.Button_New.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_New.Location = New System.Drawing.Point(191, 438)
        Me.Button_New.Name = "Button_New"
        Me.Button_New.Size = New System.Drawing.Size(61, 30)
        Me.Button_New.TabIndex = 28
        Me.Button_New.Text = "New"
        Me.Button_New.UseVisualStyleBackColor = True
        '
        'Button_Next
        '
        Me.Button_Next.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Next.Location = New System.Drawing.Point(151, 438)
        Me.Button_Next.Name = "Button_Next"
        Me.Button_Next.Size = New System.Drawing.Size(34, 30)
        Me.Button_Next.TabIndex = 28
        Me.Button_Next.Text = ">"
        Me.Button_Next.UseVisualStyleBackColor = True
        '
        'Button_Prev
        '
        Me.Button_Prev.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Prev.Location = New System.Drawing.Point(112, 438)
        Me.Button_Prev.Name = "Button_Prev"
        Me.Button_Prev.Size = New System.Drawing.Size(34, 30)
        Me.Button_Prev.TabIndex = 28
        Me.Button_Prev.Text = "<"
        Me.Button_Prev.UseVisualStyleBackColor = True
        '
        'Button_Delete
        '
        Me.Button_Delete.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Delete.Location = New System.Drawing.Point(45, 438)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(61, 30)
        Me.Button_Delete.TabIndex = 29
        Me.Button_Delete.Text = "Delete"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Form_EditStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(331, 480)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Prev)
        Me.Controls.Add(Me.Button_Next)
        Me.Controls.Add(Me.Button_New)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Button_ShowPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(AccountIDLabel)
        Me.Controls.Add(Me.AccountIDTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(AdministratorLabel)
        Me.Controls.Add(Me.AdministratorCheckBox)
        Me.Controls.Add(AddressLine1Label)
        Me.Controls.Add(Me.AddressLine1TextBox)
        Me.Controls.Add(TownLabel)
        Me.Controls.Add(Me.TownTextBox)
        Me.Controls.Add(PostCodeLabel)
        Me.Controls.Add(Me.PostCodeTextBox)
        Me.Controls.Add(TelephoneNoLabel)
        Me.Controls.Add(Me.TelephoneNoTextBox)
        Me.Controls.Add(EmailAddressLabel)
        Me.Controls.Add(Me.EmailAddressTextBox)
        Me.Controls.Add(PositionLabel)
        Me.Controls.Add(Me.PositionTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_EditStaff"
        Me.Text = "POS System  |  Edit Staff"
        CType(Me.Database_POSSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Database_POSSystemDataSet As Database_POSSystemDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As Database_POSSystemDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As Database_POSSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AccountIDTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents AdministratorCheckBox As CheckBox
    Friend WithEvents AddressLine1TextBox As TextBox
    Friend WithEvents TownTextBox As TextBox
    Friend WithEvents PostCodeTextBox As TextBox
    Friend WithEvents TelephoneNoTextBox As TextBox
    Friend WithEvents EmailAddressTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_ShowPass As Button
    Friend WithEvents Button_Save As Button
    Friend WithEvents Button_New As Button
    Friend WithEvents Button_Next As Button
    Friend WithEvents Button_Prev As Button
    Friend WithEvents Button_Delete As Button
End Class
