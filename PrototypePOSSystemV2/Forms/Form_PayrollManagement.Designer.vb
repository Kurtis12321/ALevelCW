<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_PayrollManagement
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
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim AddressLine1Label As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_PayrollManagement))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.AccountIDTextBox = New System.Windows.Forms.TextBox()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_POSSystemDataSet = New PrototypePOSSystemV2.Database_POSSystemDataSet()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressLine1TextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.StaffTableAdapter = New PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.TableAdapterManager()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtWeekendWage = New System.Windows.Forms.TextBox()
        Me.txtWeekendsWorked = New System.Windows.Forms.TextBox()
        Me.txtWeekDayWage = New System.Windows.Forms.TextBox()
        Me.txtWeekDaysWorked = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtNetpay = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtDec = New System.Windows.Forms.TextBox()
        Me.txtGross = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        AccountIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        AddressLine1Label = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_POSSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'AccountIDLabel
        '
        AccountIDLabel.AutoSize = True
        AccountIDLabel.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AccountIDLabel.ForeColor = System.Drawing.SystemColors.Control
        AccountIDLabel.Location = New System.Drawing.Point(12, 12)
        AccountIDLabel.Name = "AccountIDLabel"
        AccountIDLabel.Size = New System.Drawing.Size(85, 20)
        AccountIDLabel.TabIndex = 0
        AccountIDLabel.Text = "Account ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.ForeColor = System.Drawing.SystemColors.Control
        FirstNameLabel.Location = New System.Drawing.Point(162, 12)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(83, 20)
        FirstNameLabel.TabIndex = 6
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.ForeColor = System.Drawing.SystemColors.Control
        LastNameLabel.Location = New System.Drawing.Point(162, 45)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(82, 20)
        LastNameLabel.TabIndex = 8
        LastNameLabel.Text = "Last Name:"
        '
        'AddressLine1Label
        '
        AddressLine1Label.AutoSize = True
        AddressLine1Label.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLine1Label.ForeColor = System.Drawing.SystemColors.Control
        AddressLine1Label.Location = New System.Drawing.Point(380, 12)
        AddressLine1Label.Name = "AddressLine1Label"
        AddressLine1Label.Size = New System.Drawing.Size(104, 20)
        AddressLine1Label.TabIndex = 12
        AddressLine1Label.Text = "Address Line1:"
        '
        'PositionLabel
        '
        PositionLabel.AutoSize = True
        PositionLabel.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PositionLabel.ForeColor = System.Drawing.SystemColors.Control
        PositionLabel.Location = New System.Drawing.Point(612, 12)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(65, 20)
        PositionLabel.TabIndex = 22
        PositionLabel.Text = "Position:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.SystemColors.Control
        Label2.Location = New System.Drawing.Point(12, 15)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(206, 20)
        Label2.TabIndex = 24
        Label2.Text = "Weekdays worked this month:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.SystemColors.Control
        Label3.Location = New System.Drawing.Point(80, 50)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(138, 20)
        Label3.TabIndex = 26
        Label3.Text = "Weekday Wage (£):"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.SystemColors.Control
        Label4.Location = New System.Drawing.Point(416, 50)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(139, 20)
        Label4.TabIndex = 30
        Label4.Text = "Weekend Wage (£):"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.SystemColors.Control
        Label5.Location = New System.Drawing.Point(348, 15)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(207, 20)
        Label5.TabIndex = 29
        Label5.Text = "Weekends worked this month:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.Control
        Label6.Location = New System.Drawing.Point(531, 11)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(135, 20)
        Label6.TabIndex = 30
        Label6.Text = "15% Deduction (£):"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.SystemColors.Control
        Label7.Location = New System.Drawing.Point(257, 11)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(135, 20)
        Label7.TabIndex = 29
        Label7.Text = "10% Deduction (£):"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.ForeColor = System.Drawing.SystemColors.Control
        Label9.Location = New System.Drawing.Point(12, 11)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(97, 20)
        Label9.TabIndex = 24
        Label9.Text = "Gross Pay (£):"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.ForeColor = System.Drawing.SystemColors.Control
        Label8.Location = New System.Drawing.Point(27, 46)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(82, 20)
        Label8.TabIndex = 33
        Label8.Text = "Netpay (£):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(248, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 32)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Payroll Management System"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.btnPrev)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(AccountIDLabel)
        Me.Panel1.Controls.Add(Me.AccountIDTextBox)
        Me.Panel1.Controls.Add(FirstNameLabel)
        Me.Panel1.Controls.Add(Me.FirstNameTextBox)
        Me.Panel1.Controls.Add(LastNameLabel)
        Me.Panel1.Controls.Add(Me.LastNameTextBox)
        Me.Panel1.Controls.Add(AddressLine1Label)
        Me.Panel1.Controls.Add(Me.AddressLine1TextBox)
        Me.Panel1.Controls.Add(PositionLabel)
        Me.Panel1.Controls.Add(Me.PositionTextBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 77)
        Me.Panel1.TabIndex = 28
        '
        'btnPrev
        '
        Me.btnPrev.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnPrev.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.ForeColor = System.Drawing.SystemColors.Control
        Me.btnPrev.Location = New System.Drawing.Point(707, 42)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(37, 30)
        Me.btnPrev.TabIndex = 36
        Me.btnPrev.Text = "<"
        Me.btnPrev.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnNext.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNext.Location = New System.Drawing.Point(750, 42)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(37, 30)
        Me.btnNext.TabIndex = 35
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'AccountIDTextBox
        '
        Me.AccountIDTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AccountIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AccountIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "AccountID", True))
        Me.AccountIDTextBox.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountIDTextBox.Location = New System.Drawing.Point(103, 12)
        Me.AccountIDTextBox.Name = "AccountIDTextBox"
        Me.AccountIDTextBox.ReadOnly = True
        Me.AccountIDTextBox.Size = New System.Drawing.Size(34, 20)
        Me.AccountIDTextBox.TabIndex = 1
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.Database_POSSystemDataSet
        '
        'Database_POSSystemDataSet
        '
        Me.Database_POSSystemDataSet.DataSetName = "Database_POSSystemDataSet"
        Me.Database_POSSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.Color.Gray
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(251, 9)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.ReadOnly = True
        Me.FirstNameTextBox.Size = New System.Drawing.Size(104, 27)
        Me.FirstNameTextBox.TabIndex = 7
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.BackColor = System.Drawing.Color.Gray
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "LastName", True))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(251, 42)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.ReadOnly = True
        Me.LastNameTextBox.Size = New System.Drawing.Size(104, 27)
        Me.LastNameTextBox.TabIndex = 9
        '
        'AddressLine1TextBox
        '
        Me.AddressLine1TextBox.BackColor = System.Drawing.Color.Gray
        Me.AddressLine1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "AddressLine1", True))
        Me.AddressLine1TextBox.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLine1TextBox.Location = New System.Drawing.Point(490, 9)
        Me.AddressLine1TextBox.Name = "AddressLine1TextBox"
        Me.AddressLine1TextBox.ReadOnly = True
        Me.AddressLine1TextBox.Size = New System.Drawing.Size(104, 27)
        Me.AddressLine1TextBox.TabIndex = 13
        '
        'PositionTextBox
        '
        Me.PositionTextBox.BackColor = System.Drawing.Color.Gray
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StaffBindingSource, "Position", True))
        Me.PositionTextBox.Font = New System.Drawing.Font("Leelawadee UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PositionTextBox.Location = New System.Drawing.Point(683, 9)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.ReadOnly = True
        Me.PositionTextBox.Size = New System.Drawing.Size(104, 27)
        Me.PositionTextBox.TabIndex = 23
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Controls.Add(Me.txtWeekendWage)
        Me.Panel2.Controls.Add(Me.txtWeekendsWorked)
        Me.Panel2.Controls.Add(Label4)
        Me.Panel2.Controls.Add(Label5)
        Me.Panel2.Controls.Add(Me.txtWeekDayWage)
        Me.Panel2.Controls.Add(Me.txtWeekDaysWorked)
        Me.Panel2.Controls.Add(Label3)
        Me.Panel2.Controls.Add(Label2)
        Me.Panel2.Location = New System.Drawing.Point(12, 146)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(801, 84)
        Me.Panel2.TabIndex = 29
        '
        'txtWeekendWage
        '
        Me.txtWeekendWage.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeekendWage.Location = New System.Drawing.Point(561, 46)
        Me.txtWeekendWage.Name = "txtWeekendWage"
        Me.txtWeekendWage.Size = New System.Drawing.Size(104, 29)
        Me.txtWeekendWage.TabIndex = 32
        '
        'txtWeekendsWorked
        '
        Me.txtWeekendsWorked.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeekendsWorked.Location = New System.Drawing.Point(561, 11)
        Me.txtWeekendsWorked.Name = "txtWeekendsWorked"
        Me.txtWeekendsWorked.Size = New System.Drawing.Size(104, 29)
        Me.txtWeekendsWorked.TabIndex = 31
        '
        'txtWeekDayWage
        '
        Me.txtWeekDayWage.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeekDayWage.Location = New System.Drawing.Point(224, 46)
        Me.txtWeekDayWage.Name = "txtWeekDayWage"
        Me.txtWeekDayWage.Size = New System.Drawing.Size(104, 29)
        Me.txtWeekDayWage.TabIndex = 28
        '
        'txtWeekDaysWorked
        '
        Me.txtWeekDaysWorked.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeekDaysWorked.Location = New System.Drawing.Point(224, 11)
        Me.txtWeekDaysWorked.Name = "txtWeekDaysWorked"
        Me.txtWeekDaysWorked.Size = New System.Drawing.Size(104, 29)
        Me.txtWeekDaysWorked.TabIndex = 27
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel3.Controls.Add(Me.txtNetpay)
        Me.Panel3.Controls.Add(Label8)
        Me.Panel3.Controls.Add(Me.txtTax)
        Me.Panel3.Controls.Add(Me.txtDec)
        Me.Panel3.Controls.Add(Label6)
        Me.Panel3.Controls.Add(Label7)
        Me.Panel3.Controls.Add(Me.txtGross)
        Me.Panel3.Controls.Add(Label9)
        Me.Panel3.Location = New System.Drawing.Point(12, 236)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(801, 84)
        Me.Panel3.TabIndex = 33
        '
        'txtNetpay
        '
        Me.txtNetpay.BackColor = System.Drawing.Color.Gray
        Me.txtNetpay.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetpay.Location = New System.Drawing.Point(115, 42)
        Me.txtNetpay.Name = "txtNetpay"
        Me.txtNetpay.Size = New System.Drawing.Size(104, 29)
        Me.txtNetpay.TabIndex = 34
        '
        'txtTax
        '
        Me.txtTax.BackColor = System.Drawing.Color.Gray
        Me.txtTax.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(672, 7)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(104, 29)
        Me.txtTax.TabIndex = 32
        '
        'txtDec
        '
        Me.txtDec.BackColor = System.Drawing.Color.Gray
        Me.txtDec.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDec.Location = New System.Drawing.Point(398, 7)
        Me.txtDec.Name = "txtDec"
        Me.txtDec.Size = New System.Drawing.Size(104, 29)
        Me.txtDec.TabIndex = 31
        '
        'txtGross
        '
        Me.txtGross.BackColor = System.Drawing.Color.Gray
        Me.txtGross.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGross.Location = New System.Drawing.Point(115, 7)
        Me.txtGross.Name = "txtGross"
        Me.txtGross.Size = New System.Drawing.Size(104, 29)
        Me.txtGross.TabIndex = 27
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCalc.Font = New System.Drawing.Font("Leelawadee UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCalc.Location = New System.Drawing.Point(340, 329)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(147, 44)
        Me.btnCalc.TabIndex = 34
        Me.btnCalc.Text = "Calculate Salary"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'Form_PayrollManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(825, 385)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_PayrollManagement"
        Me.Text = "POS System  |  Payroll Management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_POSSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Database_POSSystemDataSet As Database_POSSystemDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As Database_POSSystemDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As Database_POSSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents AccountIDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents AddressLine1TextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtWeekendWage As TextBox
    Friend WithEvents txtWeekendsWorked As TextBox
    Friend WithEvents txtWeekDayWage As TextBox
    Friend WithEvents txtWeekDaysWorked As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtNetpay As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtDec As TextBox
    Friend WithEvents txtGross As TextBox
    Friend WithEvents btnCalc As Button
End Class
