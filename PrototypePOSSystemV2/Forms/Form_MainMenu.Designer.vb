<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_MainMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_TransacInProgress = New System.Windows.Forms.Panel()
        Me.Label_AdminStatus = New System.Windows.Forms.Label()
        Me.Label_TransacInProgress = New System.Windows.Forms.Label()
        Me.btn_ViewCustomer = New System.Windows.Forms.Button()
        Me.btn_ViewStaff = New System.Windows.Forms.Button()
        Me.btn_ViewInventory = New System.Windows.Forms.Button()
        Me.btn_ViewOrders = New System.Windows.Forms.Button()
        Me.btn_Payroll = New System.Windows.Forms.Button()
        Me.btn_AddInventory = New System.Windows.Forms.Button()
        Me.btn_AddCustomer = New System.Windows.Forms.Button()
        Me.btn_AddStaff = New System.Windows.Forms.Button()
        Me.btn_Order = New System.Windows.Forms.Button()
        Me.btn_Logout = New System.Windows.Forms.Button()
        Me.btn_About = New System.Windows.Forms.Button()
        Me.Database_POSSystemDataSet = New PrototypePOSSystemV2.Database_POSSystemDataSet()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel_TransacInProgress.SuspendLayout()
        CType(Me.Database_POSSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome, USER_NAME"
        '
        'Panel_TransacInProgress
        '
        Me.Panel_TransacInProgress.BackColor = System.Drawing.Color.Gray
        Me.Panel_TransacInProgress.Controls.Add(Me.Label_AdminStatus)
        Me.Panel_TransacInProgress.Controls.Add(Me.Label_TransacInProgress)
        Me.Panel_TransacInProgress.Location = New System.Drawing.Point(-6, -3)
        Me.Panel_TransacInProgress.Name = "Panel_TransacInProgress"
        Me.Panel_TransacInProgress.Size = New System.Drawing.Size(560, 26)
        Me.Panel_TransacInProgress.TabIndex = 2
        '
        'Label_AdminStatus
        '
        Me.Label_AdminStatus.AutoSize = True
        Me.Label_AdminStatus.BackColor = System.Drawing.Color.Transparent
        Me.Label_AdminStatus.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_AdminStatus.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label_AdminStatus.Location = New System.Drawing.Point(424, 2)
        Me.Label_AdminStatus.Name = "Label_AdminStatus"
        Me.Label_AdminStatus.Size = New System.Drawing.Size(124, 21)
        Me.Label_AdminStatus.TabIndex = 7
        Me.Label_AdminStatus.Text = "[ Administrator ]"
        Me.Label_AdminStatus.Visible = False
        '
        'Label_TransacInProgress
        '
        Me.Label_TransacInProgress.AutoSize = True
        Me.Label_TransacInProgress.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_TransacInProgress.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label_TransacInProgress.Location = New System.Drawing.Point(154, 2)
        Me.Label_TransacInProgress.Name = "Label_TransacInProgress"
        Me.Label_TransacInProgress.Size = New System.Drawing.Size(252, 21)
        Me.Label_TransacInProgress.TabIndex = 0
        Me.Label_TransacInProgress.Text = "A transaction is still in progress!"
        Me.Label_TransacInProgress.Visible = False
        '
        'btn_ViewCustomer
        '
        Me.btn_ViewCustomer.BackColor = System.Drawing.Color.SlateGray
        Me.btn_ViewCustomer.Enabled = False
        Me.btn_ViewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ViewCustomer.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ViewCustomer.Location = New System.Drawing.Point(189, 226)
        Me.btn_ViewCustomer.Name = "btn_ViewCustomer"
        Me.btn_ViewCustomer.Size = New System.Drawing.Size(162, 37)
        Me.btn_ViewCustomer.TabIndex = 4
        Me.btn_ViewCustomer.Text = "View Customers"
        Me.btn_ViewCustomer.UseVisualStyleBackColor = False
        '
        'btn_ViewStaff
        '
        Me.btn_ViewStaff.BackColor = System.Drawing.Color.SlateGray
        Me.btn_ViewStaff.Enabled = False
        Me.btn_ViewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ViewStaff.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ViewStaff.Location = New System.Drawing.Point(189, 183)
        Me.btn_ViewStaff.Name = "btn_ViewStaff"
        Me.btn_ViewStaff.Size = New System.Drawing.Size(162, 37)
        Me.btn_ViewStaff.TabIndex = 5
        Me.btn_ViewStaff.Text = "View Staff"
        Me.btn_ViewStaff.UseVisualStyleBackColor = False
        '
        'btn_ViewInventory
        '
        Me.btn_ViewInventory.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_ViewInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ViewInventory.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ViewInventory.Location = New System.Drawing.Point(189, 269)
        Me.btn_ViewInventory.Name = "btn_ViewInventory"
        Me.btn_ViewInventory.Size = New System.Drawing.Size(162, 37)
        Me.btn_ViewInventory.TabIndex = 6
        Me.btn_ViewInventory.Text = "View Inventory"
        Me.btn_ViewInventory.UseVisualStyleBackColor = False
        '
        'btn_ViewOrders
        '
        Me.btn_ViewOrders.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_ViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ViewOrders.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ViewOrders.Location = New System.Drawing.Point(189, 97)
        Me.btn_ViewOrders.Name = "btn_ViewOrders"
        Me.btn_ViewOrders.Size = New System.Drawing.Size(162, 37)
        Me.btn_ViewOrders.TabIndex = 7
        Me.btn_ViewOrders.Text = "View Orders"
        Me.btn_ViewOrders.UseVisualStyleBackColor = False
        '
        'btn_Payroll
        '
        Me.btn_Payroll.BackColor = System.Drawing.Color.SlateGray
        Me.btn_Payroll.Enabled = False
        Me.btn_Payroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Payroll.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Payroll.Location = New System.Drawing.Point(189, 140)
        Me.btn_Payroll.Name = "btn_Payroll"
        Me.btn_Payroll.Size = New System.Drawing.Size(162, 37)
        Me.btn_Payroll.TabIndex = 8
        Me.btn_Payroll.Text = "Payroll"
        Me.btn_Payroll.UseVisualStyleBackColor = False
        '
        'btn_AddInventory
        '
        Me.btn_AddInventory.BackColor = System.Drawing.Color.SlateGray
        Me.btn_AddInventory.Enabled = False
        Me.btn_AddInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddInventory.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddInventory.Location = New System.Drawing.Point(21, 269)
        Me.btn_AddInventory.Name = "btn_AddInventory"
        Me.btn_AddInventory.Size = New System.Drawing.Size(162, 37)
        Me.btn_AddInventory.TabIndex = 9
        Me.btn_AddInventory.Text = "Add Inventory"
        Me.btn_AddInventory.UseVisualStyleBackColor = False
        '
        'btn_AddCustomer
        '
        Me.btn_AddCustomer.BackColor = System.Drawing.Color.SlateGray
        Me.btn_AddCustomer.Enabled = False
        Me.btn_AddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddCustomer.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddCustomer.Location = New System.Drawing.Point(21, 226)
        Me.btn_AddCustomer.Name = "btn_AddCustomer"
        Me.btn_AddCustomer.Size = New System.Drawing.Size(162, 37)
        Me.btn_AddCustomer.TabIndex = 10
        Me.btn_AddCustomer.Text = "Add Customer"
        Me.btn_AddCustomer.UseVisualStyleBackColor = False
        '
        'btn_AddStaff
        '
        Me.btn_AddStaff.BackColor = System.Drawing.Color.SlateGray
        Me.btn_AddStaff.Enabled = False
        Me.btn_AddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_AddStaff.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddStaff.Location = New System.Drawing.Point(21, 183)
        Me.btn_AddStaff.Name = "btn_AddStaff"
        Me.btn_AddStaff.Size = New System.Drawing.Size(162, 37)
        Me.btn_AddStaff.TabIndex = 11
        Me.btn_AddStaff.Text = "Edit Staff"
        Me.btn_AddStaff.UseVisualStyleBackColor = False
        '
        'btn_Order
        '
        Me.btn_Order.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btn_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Order.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Order.Location = New System.Drawing.Point(21, 97)
        Me.btn_Order.Name = "btn_Order"
        Me.btn_Order.Size = New System.Drawing.Size(162, 80)
        Me.btn_Order.TabIndex = 12
        Me.btn_Order.Text = "ORDER"
        Me.btn_Order.UseVisualStyleBackColor = False
        '
        'btn_Logout
        '
        Me.btn_Logout.BackColor = System.Drawing.Color.LightCoral
        Me.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Logout.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Logout.Location = New System.Drawing.Point(418, 269)
        Me.btn_Logout.Name = "btn_Logout"
        Me.btn_Logout.Size = New System.Drawing.Size(115, 37)
        Me.btn_Logout.TabIndex = 13
        Me.btn_Logout.Text = "Logout"
        Me.btn_Logout.UseVisualStyleBackColor = False
        '
        'btn_About
        '
        Me.btn_About.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_About.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_About.Location = New System.Drawing.Point(474, 187)
        Me.btn_About.Name = "btn_About"
        Me.btn_About.Size = New System.Drawing.Size(59, 29)
        Me.btn_About.TabIndex = 14
        Me.btn_About.Text = "About"
        Me.btn_About.UseVisualStyleBackColor = False
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PrototypePOSSystemV2.My.Resources.Resources.CrownLogoNoText
        Me.PictureBox1.Location = New System.Drawing.Point(357, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(176, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form_MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(546, 325)
        Me.Controls.Add(Me.btn_About)
        Me.Controls.Add(Me.btn_Logout)
        Me.Controls.Add(Me.btn_ViewCustomer)
        Me.Controls.Add(Me.btn_ViewStaff)
        Me.Controls.Add(Me.btn_ViewInventory)
        Me.Controls.Add(Me.btn_ViewOrders)
        Me.Controls.Add(Me.btn_Payroll)
        Me.Controls.Add(Me.btn_AddInventory)
        Me.Controls.Add(Me.btn_AddCustomer)
        Me.Controls.Add(Me.btn_AddStaff)
        Me.Controls.Add(Me.btn_Order)
        Me.Controls.Add(Me.Panel_TransacInProgress)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_MainMenu"
        Me.Text = "POS System  |  Main Menu"
        Me.Panel_TransacInProgress.ResumeLayout(False)
        Me.Panel_TransacInProgress.PerformLayout()
        CType(Me.Database_POSSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel_TransacInProgress As Panel
    Friend WithEvents Label_TransacInProgress As Label
    Friend WithEvents btn_ViewCustomer As Button
    Friend WithEvents btn_ViewStaff As Button
    Friend WithEvents btn_ViewInventory As Button
    Friend WithEvents btn_ViewOrders As Button
    Friend WithEvents btn_Payroll As Button
    Friend WithEvents btn_AddInventory As Button
    Friend WithEvents btn_AddCustomer As Button
    Friend WithEvents btn_AddStaff As Button
    Friend WithEvents btn_Order As Button
    Friend WithEvents Label_AdminStatus As Label
    Friend WithEvents btn_Logout As Button
    Friend WithEvents btn_About As Button
    Friend WithEvents Database_POSSystemDataSet As Database_POSSystemDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As Database_POSSystemDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As Database_POSSystemDataSetTableAdapters.TableAdapterManager
End Class
