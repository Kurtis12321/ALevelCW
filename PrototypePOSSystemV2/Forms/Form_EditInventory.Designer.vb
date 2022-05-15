<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_EditInventory
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
        Dim ItemIDLabel As System.Windows.Forms.Label
        Dim ItemNameLabel As System.Windows.Forms.Label
        Dim ItemPriceLabel As System.Windows.Forms.Label
        Dim StockCountLabel As System.Windows.Forms.Label
        Dim ItemCatagoryLabel As System.Windows.Forms.Label
        Dim LastStockedByLabel As System.Windows.Forms.Label
        Dim DataLinkLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_EditInventory))
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Button_Prev = New System.Windows.Forms.Button()
        Me.Button_Next = New System.Windows.Forms.Button()
        Me.Button_New = New System.Windows.Forms.Button()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Database_POSSystemDataSet = New PrototypePOSSystemV2.Database_POSSystemDataSet()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.InventoryTableAdapter()
        Me.TableAdapterManager = New PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.TableAdapterManager()
        Me.ItemIDTextBox = New System.Windows.Forms.TextBox()
        Me.ItemNameTextBox = New System.Windows.Forms.TextBox()
        Me.ItemPriceTextBox = New System.Windows.Forms.TextBox()
        Me.StockCountTextBox = New System.Windows.Forms.TextBox()
        Me.ItemCatagoryTextBox = New System.Windows.Forms.TextBox()
        Me.LastStockedByTextBox = New System.Windows.Forms.TextBox()
        Me.DataLinkTextBox = New System.Windows.Forms.TextBox()
        ItemIDLabel = New System.Windows.Forms.Label()
        ItemNameLabel = New System.Windows.Forms.Label()
        ItemPriceLabel = New System.Windows.Forms.Label()
        StockCountLabel = New System.Windows.Forms.Label()
        ItemCatagoryLabel = New System.Windows.Forms.Label()
        LastStockedByLabel = New System.Windows.Forms.Label()
        DataLinkLabel = New System.Windows.Forms.Label()
        CType(Me.Database_POSSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ItemIDLabel
        '
        ItemIDLabel.AutoSize = True
        ItemIDLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        ItemIDLabel.Location = New System.Drawing.Point(54, 58)
        ItemIDLabel.Name = "ItemIDLabel"
        ItemIDLabel.Size = New System.Drawing.Size(52, 17)
        ItemIDLabel.TabIndex = 56
        ItemIDLabel.Text = "Item ID:"
        '
        'ItemNameLabel
        '
        ItemNameLabel.AutoSize = True
        ItemNameLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        ItemNameLabel.Location = New System.Drawing.Point(31, 102)
        ItemNameLabel.Name = "ItemNameLabel"
        ItemNameLabel.Size = New System.Drawing.Size(75, 17)
        ItemNameLabel.TabIndex = 58
        ItemNameLabel.Text = "Item Name:"
        '
        'ItemPriceLabel
        '
        ItemPriceLabel.AutoSize = True
        ItemPriceLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        ItemPriceLabel.Location = New System.Drawing.Point(38, 133)
        ItemPriceLabel.Name = "ItemPriceLabel"
        ItemPriceLabel.Size = New System.Drawing.Size(68, 17)
        ItemPriceLabel.TabIndex = 60
        ItemPriceLabel.Text = "Item Price:"
        '
        'StockCountLabel
        '
        StockCountLabel.AutoSize = True
        StockCountLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        StockCountLabel.Location = New System.Drawing.Point(26, 164)
        StockCountLabel.Name = "StockCountLabel"
        StockCountLabel.Size = New System.Drawing.Size(80, 17)
        StockCountLabel.TabIndex = 62
        StockCountLabel.Text = "Stock Count:"
        '
        'ItemCatagoryLabel
        '
        ItemCatagoryLabel.AutoSize = True
        ItemCatagoryLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        ItemCatagoryLabel.Location = New System.Drawing.Point(13, 195)
        ItemCatagoryLabel.Name = "ItemCatagoryLabel"
        ItemCatagoryLabel.Size = New System.Drawing.Size(93, 17)
        ItemCatagoryLabel.TabIndex = 64
        ItemCatagoryLabel.Text = "Item Catagory:"
        '
        'LastStockedByLabel
        '
        LastStockedByLabel.AutoSize = True
        LastStockedByLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        LastStockedByLabel.Location = New System.Drawing.Point(6, 226)
        LastStockedByLabel.Name = "LastStockedByLabel"
        LastStockedByLabel.Size = New System.Drawing.Size(101, 17)
        LastStockedByLabel.TabIndex = 66
        LastStockedByLabel.Text = "Last Stocked By:"
        '
        'DataLinkLabel
        '
        DataLinkLabel.AutoSize = True
        DataLinkLabel.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        DataLinkLabel.Location = New System.Drawing.Point(42, 257)
        DataLinkLabel.Name = "DataLinkLabel"
        DataLinkLabel.Size = New System.Drawing.Size(64, 17)
        DataLinkLabel.TabIndex = 68
        DataLinkLabel.Text = "Data Link:"
        '
        'Button_Delete
        '
        Me.Button_Delete.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Delete.Location = New System.Drawing.Point(192, 321)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(68, 30)
        Me.Button_Delete.TabIndex = 55
        Me.Button_Delete.Text = "Delete"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Button_Prev
        '
        Me.Button_Prev.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Prev.Location = New System.Drawing.Point(113, 285)
        Me.Button_Prev.Name = "Button_Prev"
        Me.Button_Prev.Size = New System.Drawing.Size(34, 30)
        Me.Button_Prev.TabIndex = 52
        Me.Button_Prev.Text = "<"
        Me.Button_Prev.UseVisualStyleBackColor = True
        '
        'Button_Next
        '
        Me.Button_Next.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Next.Location = New System.Drawing.Point(152, 285)
        Me.Button_Next.Name = "Button_Next"
        Me.Button_Next.Size = New System.Drawing.Size(34, 30)
        Me.Button_Next.TabIndex = 53
        Me.Button_Next.Text = ">"
        Me.Button_Next.UseVisualStyleBackColor = True
        '
        'Button_New
        '
        Me.Button_New.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_New.Location = New System.Drawing.Point(192, 285)
        Me.Button_New.Name = "Button_New"
        Me.Button_New.Size = New System.Drawing.Size(68, 30)
        Me.Button_New.TabIndex = 54
        Me.Button_New.Text = "New"
        Me.Button_New.UseVisualStyleBackColor = True
        '
        'Button_Save
        '
        Me.Button_Save.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Save.Location = New System.Drawing.Point(192, 357)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(68, 30)
        Me.Button_Save.TabIndex = 51
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 25)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Edit Inventory"
        '
        'Database_POSSystemDataSet
        '
        Me.Database_POSSystemDataSet.DataSetName = "Database_POSSystemDataSet"
        Me.Database_POSSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.Database_POSSystemDataSet
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Me.InventoryTableAdapter
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ItemIDTextBox
        '
        Me.ItemIDTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ItemIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ItemIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "ItemID", True))
        Me.ItemIDTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.ItemIDTextBox.Location = New System.Drawing.Point(112, 58)
        Me.ItemIDTextBox.Name = "ItemIDTextBox"
        Me.ItemIDTextBox.Size = New System.Drawing.Size(34, 18)
        Me.ItemIDTextBox.TabIndex = 57
        '
        'ItemNameTextBox
        '
        Me.ItemNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "ItemName", True))
        Me.ItemNameTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.ItemNameTextBox.Location = New System.Drawing.Point(112, 99)
        Me.ItemNameTextBox.Name = "ItemNameTextBox"
        Me.ItemNameTextBox.Size = New System.Drawing.Size(147, 25)
        Me.ItemNameTextBox.TabIndex = 59
        '
        'ItemPriceTextBox
        '
        Me.ItemPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "ItemPrice", True))
        Me.ItemPriceTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.ItemPriceTextBox.Location = New System.Drawing.Point(112, 130)
        Me.ItemPriceTextBox.Name = "ItemPriceTextBox"
        Me.ItemPriceTextBox.Size = New System.Drawing.Size(147, 25)
        Me.ItemPriceTextBox.TabIndex = 61
        '
        'StockCountTextBox
        '
        Me.StockCountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "StockCount", True))
        Me.StockCountTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.StockCountTextBox.Location = New System.Drawing.Point(113, 161)
        Me.StockCountTextBox.Name = "StockCountTextBox"
        Me.StockCountTextBox.Size = New System.Drawing.Size(147, 25)
        Me.StockCountTextBox.TabIndex = 63
        '
        'ItemCatagoryTextBox
        '
        Me.ItemCatagoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "ItemCatagory", True))
        Me.ItemCatagoryTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.ItemCatagoryTextBox.Location = New System.Drawing.Point(113, 192)
        Me.ItemCatagoryTextBox.Name = "ItemCatagoryTextBox"
        Me.ItemCatagoryTextBox.Size = New System.Drawing.Size(147, 25)
        Me.ItemCatagoryTextBox.TabIndex = 65
        '
        'LastStockedByTextBox
        '
        Me.LastStockedByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "LastStockedBy", True))
        Me.LastStockedByTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.LastStockedByTextBox.Location = New System.Drawing.Point(113, 223)
        Me.LastStockedByTextBox.Name = "LastStockedByTextBox"
        Me.LastStockedByTextBox.Size = New System.Drawing.Size(147, 25)
        Me.LastStockedByTextBox.TabIndex = 67
        '
        'DataLinkTextBox
        '
        Me.DataLinkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "DataLink", True))
        Me.DataLinkTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!)
        Me.DataLinkTextBox.Location = New System.Drawing.Point(113, 254)
        Me.DataLinkTextBox.Name = "DataLinkTextBox"
        Me.DataLinkTextBox.Size = New System.Drawing.Size(147, 25)
        Me.DataLinkTextBox.TabIndex = 69
        '
        'Form_EditInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(280, 410)
        Me.Controls.Add(ItemIDLabel)
        Me.Controls.Add(Me.ItemIDTextBox)
        Me.Controls.Add(ItemNameLabel)
        Me.Controls.Add(Me.ItemNameTextBox)
        Me.Controls.Add(ItemPriceLabel)
        Me.Controls.Add(Me.ItemPriceTextBox)
        Me.Controls.Add(StockCountLabel)
        Me.Controls.Add(Me.StockCountTextBox)
        Me.Controls.Add(ItemCatagoryLabel)
        Me.Controls.Add(Me.ItemCatagoryTextBox)
        Me.Controls.Add(LastStockedByLabel)
        Me.Controls.Add(Me.LastStockedByTextBox)
        Me.Controls.Add(DataLinkLabel)
        Me.Controls.Add(Me.DataLinkTextBox)
        Me.Controls.Add(Me.Button_Delete)
        Me.Controls.Add(Me.Button_Prev)
        Me.Controls.Add(Me.Button_Next)
        Me.Controls.Add(Me.Button_New)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_EditInventory"
        Me.Text = "POS System  |  Edit Inventory"
        CType(Me.Database_POSSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Delete As Button
    Friend WithEvents Button_Prev As Button
    Friend WithEvents Button_Next As Button
    Friend WithEvents Button_New As Button
    Friend WithEvents Button_Save As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Database_POSSystemDataSet As Database_POSSystemDataSet
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As Database_POSSystemDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents TableAdapterManager As Database_POSSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ItemIDTextBox As TextBox
    Friend WithEvents ItemNameTextBox As TextBox
    Friend WithEvents ItemPriceTextBox As TextBox
    Friend WithEvents StockCountTextBox As TextBox
    Friend WithEvents ItemCatagoryTextBox As TextBox
    Friend WithEvents LastStockedByTextBox As TextBox
    Friend WithEvents DataLinkTextBox As TextBox
End Class
