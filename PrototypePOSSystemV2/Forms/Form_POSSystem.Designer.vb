<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_POSSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_POSSystem))
        Me.Panel_Catagories = New System.Windows.Forms.Panel()
        Me.Button_Drinks = New System.Windows.Forms.Button()
        Me.Button_Sides = New System.Windows.Forms.Button()
        Me.Button_Salads = New System.Windows.Forms.Button()
        Me.Button_Desserts = New System.Windows.Forms.Button()
        Me.Button_Kids = New System.Windows.Forms.Button()
        Me.Button_Burgers = New System.Windows.Forms.Button()
        Me.Button_Mains = New System.Windows.Forms.Button()
        Me.Button_Starters = New System.Windows.Forms.Button()
        Me.Button_Specials = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayrollManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewTransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrainingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnTrainingModeOnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_Information = New System.Windows.Forms.Panel()
        Me.TransactionIDTextBox = New System.Windows.Forms.TextBox()
        Me.TransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database_POSSystemDataSet = New PrototypePOSSystemV2.Database_POSSystemDataSet()
        Me.TextBox_ServerName = New System.Windows.Forms.TextBox()
        Me.TableNoTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_CurrentOrder = New System.Windows.Forms.Panel()
        Me.TextBox_CurrentOrderPrices = New System.Windows.Forms.TextBox()
        Me.TextBox_CurrentOrder = New System.Windows.Forms.TextBox()
        Me.Panel_CurrentOrderTotal = New System.Windows.Forms.Panel()
        Me.Button_DownCurrOrder = New System.Windows.Forms.Button()
        Me.Button_UpCurrOrder = New System.Windows.Forms.Button()
        Me.TextBox_TotalCost = New System.Windows.Forms.TextBox()
        Me.TextBox_TotalText = New System.Windows.Forms.TextBox()
        Me.Panel_CommonControls = New System.Windows.Forms.Panel()
        Me.Button_Discount20 = New System.Windows.Forms.Button()
        Me.Button_Discount15 = New System.Windows.Forms.Button()
        Me.Button_Discount10 = New System.Windows.Forms.Button()
        Me.Button_CancelTransaction = New System.Windows.Forms.Button()
        Me.Button_SignOut = New System.Windows.Forms.Button()
        Me.Button_CompleteTransaction = New System.Windows.Forms.Button()
        Me.Button_SelectCustomer = New System.Windows.Forms.Button()
        Me.Button_MainMenu = New System.Windows.Forms.Button()
        Me.Button_InventoryManagement = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Button_ClearTable = New System.Windows.Forms.Button()
        Me.Button_ViewTransactions = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button43 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button_Discount5 = New System.Windows.Forms.Button()
        Me.Button_StudentDiscount = New System.Windows.Forms.Button()
        Me.Button_StaffManagement = New System.Windows.Forms.Button()
        Me.Button_ClearCustomer = New System.Windows.Forms.Button()
        Me.Button_SelectTable = New System.Windows.Forms.Button()
        Me.Button_PayrollManagement = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button_ModifyMenu = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button_Reciept = New System.Windows.Forms.Button()
        Me.Button_ProductID = New System.Windows.Forms.Button()
        Me.Button_StaffDiscount = New System.Windows.Forms.Button()
        Me.Button_TrainingMode = New System.Windows.Forms.Button()
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.Button_DownCat = New System.Windows.Forms.Button()
        Me.Button_UpCat = New System.Windows.Forms.Button()
        Me.Panel_CatSpecials = New System.Windows.Forms.Panel()
        Me.Specials_Button_Placeholder27 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder18 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder26 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder17 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder25 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder16 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder24 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder15 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder23 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder14 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder22 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder13 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder21 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder12 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder20 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder11 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder19 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder10 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder9 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder8 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder7 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder6 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder5 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder4 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder3 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder2 = New System.Windows.Forms.Button()
        Me.Specials_Button_Placeholder1 = New System.Windows.Forms.Button()
        Me.Label_AdminStatus = New System.Windows.Forms.Label()
        Me.Label_Training = New System.Windows.Forms.Label()
        Me.Panel_CatStarters = New System.Windows.Forms.Panel()
        Me.Starters_Button_Placeholder27 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder26 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder25 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder24 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder23 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder22 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder21 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder20 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder19 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder18 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder17 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder16 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder15 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder14 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder13 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder12 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder11 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder10 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder9 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder8 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder7 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder6 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder5 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder4 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder3 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder2 = New System.Windows.Forms.Button()
        Me.Starters_Button_Placeholder1 = New System.Windows.Forms.Button()
        Me.Panel_CatMains = New System.Windows.Forms.Panel()
        Me.Mains_Button_Placeholder27 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder18 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder26 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder17 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder25 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder16 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder24 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder15 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder23 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder14 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder22 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder13 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder21 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder12 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder20 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder11 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder19 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder10 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder9 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder8 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder7 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder6 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder5 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder4 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder3 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder2 = New System.Windows.Forms.Button()
        Me.Mains_Button_Placeholder1 = New System.Windows.Forms.Button()
        Me.Panel_CatBurgers = New System.Windows.Forms.Panel()
        Me.Burgers_Button_Placeholder27 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder18 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder26 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder17 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder25 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder16 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder24 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder15 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder23 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder14 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder22 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder13 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder21 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder12 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder20 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder11 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder19 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder10 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder9 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder8 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder7 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder6 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder5 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder4 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder3 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder2 = New System.Windows.Forms.Button()
        Me.Burgers_Button_Placeholder1 = New System.Windows.Forms.Button()
        Me.Panel_CatKids = New System.Windows.Forms.Panel()
        Me.Kids_Button_Placeholder27 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder18 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder26 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder17 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder25 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder16 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder24 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder15 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder23 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder14 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder22 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder13 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder21 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder12 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder20 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder11 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder19 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder10 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder9 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder8 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder7 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder6 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder5 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder4 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder3 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder2 = New System.Windows.Forms.Button()
        Me.Kids_Button_Placeholder1 = New System.Windows.Forms.Button()
        Me.Panel_CatDesserts = New System.Windows.Forms.Panel()
        Me.Desserts_Button_Placeholder27 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder18 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder26 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder17 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder25 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder16 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder24 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder15 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder23 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder14 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder22 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder13 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder21 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder12 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder20 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder11 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder19 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder10 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder9 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder8 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder7 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder6 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder5 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder4 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder3 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder2 = New System.Windows.Forms.Button()
        Me.Desserts_Button_Placeholder1 = New System.Windows.Forms.Button()
        Me.Panel_CatSalads = New System.Windows.Forms.Panel()
        Me.Salads_Button_Placeholder27 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder18 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder26 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder17 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder25 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder16 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder24 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder15 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder23 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder14 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder22 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder13 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder21 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder12 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder20 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder11 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder19 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder10 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder9 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder8 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder7 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder6 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder5 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder4 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder3 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder2 = New System.Windows.Forms.Button()
        Me.Salads_Button_Placeholder1 = New System.Windows.Forms.Button()
        Me.Panel_CatSides = New System.Windows.Forms.Panel()
        Me.Sides_Button_Placeholder27 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder18 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder26 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder17 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder25 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder16 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder24 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder15 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder23 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder14 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder22 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder13 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder21 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder12 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder20 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder11 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder19 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder10 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder9 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder8 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder7 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder6 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder5 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder4 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder3 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder2 = New System.Windows.Forms.Button()
        Me.Sides_Button_Placeholder1 = New System.Windows.Forms.Button()
        Me.Panel_CatDrinks = New System.Windows.Forms.Panel()
        Me.Drinks_Button_Placeholder27 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder18 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder26 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder17 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder25 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder16 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder24 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder15 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder23 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder14 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder22 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder13 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder21 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder12 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder20 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder11 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder19 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder10 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder9 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder8 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder7 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder6 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder5 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder4 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder3 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder2 = New System.Windows.Forms.Button()
        Me.Drinks_Button_Placeholder1 = New System.Windows.Forms.Button()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.StaffTableAdapter()
        Me.TableAdapterManager = New PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.TableAdapterManager()
        Me.TransactionsTableAdapter = New PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.TransactionsTableAdapter()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.InventoryTableAdapter()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New PrototypePOSSystemV2.Database_POSSystemDataSetTableAdapters.CustomersTableAdapter()
        Me.Panel_Catagories.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel_Information.SuspendLayout()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database_POSSystemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_CurrentOrder.SuspendLayout()
        Me.Panel_CurrentOrderTotal.SuspendLayout()
        Me.Panel_CommonControls.SuspendLayout()
        Me.Panel_CatSpecials.SuspendLayout()
        Me.Panel_CatStarters.SuspendLayout()
        Me.Panel_CatMains.SuspendLayout()
        Me.Panel_CatBurgers.SuspendLayout()
        Me.Panel_CatKids.SuspendLayout()
        Me.Panel_CatDesserts.SuspendLayout()
        Me.Panel_CatSalads.SuspendLayout()
        Me.Panel_CatSides.SuspendLayout()
        Me.Panel_CatDrinks.SuspendLayout()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Catagories
        '
        Me.Panel_Catagories.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel_Catagories.Controls.Add(Me.Button_Drinks)
        Me.Panel_Catagories.Controls.Add(Me.Button_Sides)
        Me.Panel_Catagories.Controls.Add(Me.Button_Salads)
        Me.Panel_Catagories.Controls.Add(Me.Button_Desserts)
        Me.Panel_Catagories.Controls.Add(Me.Button_Kids)
        Me.Panel_Catagories.Controls.Add(Me.Button_Burgers)
        Me.Panel_Catagories.Controls.Add(Me.Button_Mains)
        Me.Panel_Catagories.Controls.Add(Me.Button_Starters)
        Me.Panel_Catagories.Controls.Add(Me.Button_Specials)
        Me.Panel_Catagories.Location = New System.Drawing.Point(0, 23)
        Me.Panel_Catagories.Name = "Panel_Catagories"
        Me.Panel_Catagories.Size = New System.Drawing.Size(1543, 73)
        Me.Panel_Catagories.TabIndex = 0
        '
        'Button_Drinks
        '
        Me.Button_Drinks.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Button_Drinks.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Drinks.Location = New System.Drawing.Point(1375, 3)
        Me.Button_Drinks.Name = "Button_Drinks"
        Me.Button_Drinks.Size = New System.Drawing.Size(165, 67)
        Me.Button_Drinks.TabIndex = 0
        Me.Button_Drinks.Text = "Drinks"
        Me.Button_Drinks.UseVisualStyleBackColor = False
        '
        'Button_Sides
        '
        Me.Button_Sides.BackColor = System.Drawing.Color.SteelBlue
        Me.Button_Sides.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Sides.Location = New System.Drawing.Point(1204, 3)
        Me.Button_Sides.Name = "Button_Sides"
        Me.Button_Sides.Size = New System.Drawing.Size(165, 67)
        Me.Button_Sides.TabIndex = 0
        Me.Button_Sides.Text = "Sides"
        Me.Button_Sides.UseVisualStyleBackColor = False
        '
        'Button_Salads
        '
        Me.Button_Salads.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button_Salads.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Salads.Location = New System.Drawing.Point(1033, 3)
        Me.Button_Salads.Name = "Button_Salads"
        Me.Button_Salads.Size = New System.Drawing.Size(165, 67)
        Me.Button_Salads.TabIndex = 0
        Me.Button_Salads.Text = "Salads"
        Me.Button_Salads.UseVisualStyleBackColor = False
        '
        'Button_Desserts
        '
        Me.Button_Desserts.BackColor = System.Drawing.Color.SkyBlue
        Me.Button_Desserts.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Desserts.Location = New System.Drawing.Point(862, 3)
        Me.Button_Desserts.Name = "Button_Desserts"
        Me.Button_Desserts.Size = New System.Drawing.Size(165, 67)
        Me.Button_Desserts.TabIndex = 0
        Me.Button_Desserts.Text = "Desserts"
        Me.Button_Desserts.UseVisualStyleBackColor = False
        '
        'Button_Kids
        '
        Me.Button_Kids.BackColor = System.Drawing.Color.LightBlue
        Me.Button_Kids.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Kids.Location = New System.Drawing.Point(691, 3)
        Me.Button_Kids.Name = "Button_Kids"
        Me.Button_Kids.Size = New System.Drawing.Size(165, 67)
        Me.Button_Kids.TabIndex = 0
        Me.Button_Kids.Text = "Kids"
        Me.Button_Kids.UseVisualStyleBackColor = False
        '
        'Button_Burgers
        '
        Me.Button_Burgers.BackColor = System.Drawing.Color.PowderBlue
        Me.Button_Burgers.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Burgers.Location = New System.Drawing.Point(520, 3)
        Me.Button_Burgers.Name = "Button_Burgers"
        Me.Button_Burgers.Size = New System.Drawing.Size(165, 67)
        Me.Button_Burgers.TabIndex = 0
        Me.Button_Burgers.Text = "Burgers"
        Me.Button_Burgers.UseVisualStyleBackColor = False
        '
        'Button_Mains
        '
        Me.Button_Mains.BackColor = System.Drawing.Color.LightCyan
        Me.Button_Mains.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Mains.Location = New System.Drawing.Point(349, 3)
        Me.Button_Mains.Name = "Button_Mains"
        Me.Button_Mains.Size = New System.Drawing.Size(165, 67)
        Me.Button_Mains.TabIndex = 0
        Me.Button_Mains.Text = "Mains"
        Me.Button_Mains.UseVisualStyleBackColor = False
        '
        'Button_Starters
        '
        Me.Button_Starters.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Button_Starters.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Starters.Location = New System.Drawing.Point(178, 3)
        Me.Button_Starters.Name = "Button_Starters"
        Me.Button_Starters.Size = New System.Drawing.Size(165, 67)
        Me.Button_Starters.TabIndex = 0
        Me.Button_Starters.Text = "Starters"
        Me.Button_Starters.UseVisualStyleBackColor = False
        '
        'Button_Specials
        '
        Me.Button_Specials.BackColor = System.Drawing.Color.LightCoral
        Me.Button_Specials.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Specials.Location = New System.Drawing.Point(3, 3)
        Me.Button_Specials.Name = "Button_Specials"
        Me.Button_Specials.Size = New System.Drawing.Size(169, 67)
        Me.Button_Specials.TabIndex = 0
        Me.Button_Specials.Text = "Specials"
        Me.Button_Specials.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.TrainingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1904, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem, Me.StaffManagementToolStripMenuItem, Me.InventoryManagementToolStripMenuItem, Me.PayrollManagementToolStripMenuItem, Me.ModifyMenuToolStripMenuItem, Me.ViewTransactionsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.MainMenuToolStripMenuItem.Text = "Main Menu"
        '
        'StaffManagementToolStripMenuItem
        '
        Me.StaffManagementToolStripMenuItem.Name = "StaffManagementToolStripMenuItem"
        Me.StaffManagementToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.StaffManagementToolStripMenuItem.Text = "Staff Management"
        '
        'InventoryManagementToolStripMenuItem
        '
        Me.InventoryManagementToolStripMenuItem.Name = "InventoryManagementToolStripMenuItem"
        Me.InventoryManagementToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.InventoryManagementToolStripMenuItem.Text = "Inventory Management"
        '
        'PayrollManagementToolStripMenuItem
        '
        Me.PayrollManagementToolStripMenuItem.Name = "PayrollManagementToolStripMenuItem"
        Me.PayrollManagementToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.PayrollManagementToolStripMenuItem.Text = "Payroll Management"
        '
        'ModifyMenuToolStripMenuItem
        '
        Me.ModifyMenuToolStripMenuItem.Name = "ModifyMenuToolStripMenuItem"
        Me.ModifyMenuToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ModifyMenuToolStripMenuItem.Text = "Modify Menu"
        '
        'ViewTransactionsToolStripMenuItem
        '
        Me.ViewTransactionsToolStripMenuItem.Name = "ViewTransactionsToolStripMenuItem"
        Me.ViewTransactionsToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ViewTransactionsToolStripMenuItem.Text = "View Transactions"
        '
        'TrainingToolStripMenuItem
        '
        Me.TrainingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnTrainingModeOnToolStripMenuItem})
        Me.TrainingToolStripMenuItem.Name = "TrainingToolStripMenuItem"
        Me.TrainingToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.TrainingToolStripMenuItem.Text = "Training"
        '
        'TurnTrainingModeOnToolStripMenuItem
        '
        Me.TurnTrainingModeOnToolStripMenuItem.Name = "TurnTrainingModeOnToolStripMenuItem"
        Me.TurnTrainingModeOnToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.TurnTrainingModeOnToolStripMenuItem.Text = "Turn Training Mode On"
        '
        'Panel_Information
        '
        Me.Panel_Information.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel_Information.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Information.Controls.Add(Me.TransactionIDTextBox)
        Me.Panel_Information.Controls.Add(Me.TextBox_ServerName)
        Me.Panel_Information.Controls.Add(Me.TableNoTextBox)
        Me.Panel_Information.Controls.Add(Me.Label3)
        Me.Panel_Information.Controls.Add(Me.Label2)
        Me.Panel_Information.Controls.Add(Me.Label1)
        Me.Panel_Information.Location = New System.Drawing.Point(1549, 23)
        Me.Panel_Information.Name = "Panel_Information"
        Me.Panel_Information.Size = New System.Drawing.Size(355, 73)
        Me.Panel_Information.TabIndex = 2
        '
        'TransactionIDTextBox
        '
        Me.TransactionIDTextBox.BackColor = System.Drawing.SystemColors.Menu
        Me.TransactionIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TransactionIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "TransactionID", True))
        Me.TransactionIDTextBox.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TransactionIDTextBox.Location = New System.Drawing.Point(124, 43)
        Me.TransactionIDTextBox.Name = "TransactionIDTextBox"
        Me.TransactionIDTextBox.Size = New System.Drawing.Size(221, 22)
        Me.TransactionIDTextBox.TabIndex = 1
        '
        'TransactionsBindingSource
        '
        Me.TransactionsBindingSource.DataMember = "Transactions"
        Me.TransactionsBindingSource.DataSource = Me.Database_POSSystemDataSet
        '
        'Database_POSSystemDataSet
        '
        Me.Database_POSSystemDataSet.DataSetName = "Database_POSSystemDataSet"
        Me.Database_POSSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox_ServerName
        '
        Me.TextBox_ServerName.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox_ServerName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox_ServerName.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ServerName.ForeColor = System.Drawing.Color.Black
        Me.TextBox_ServerName.Location = New System.Drawing.Point(124, 1)
        Me.TextBox_ServerName.Name = "TextBox_ServerName"
        Me.TextBox_ServerName.ReadOnly = True
        Me.TextBox_ServerName.Size = New System.Drawing.Size(221, 22)
        Me.TextBox_ServerName.TabIndex = 1
        Me.TextBox_ServerName.TabStop = False
        '
        'TableNoTextBox
        '
        Me.TableNoTextBox.BackColor = System.Drawing.SystemColors.Menu
        Me.TableNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TransactionsBindingSource, "TableNo", True))
        Me.TableNoTextBox.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableNoTextBox.Location = New System.Drawing.Point(124, 22)
        Me.TableNoTextBox.Name = "TableNoTextBox"
        Me.TableNoTextBox.Size = New System.Drawing.Size(221, 22)
        Me.TableNoTextBox.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Transaction #:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(11, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Current Table:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Server:"
        '
        'Panel_CurrentOrder
        '
        Me.Panel_CurrentOrder.BackColor = System.Drawing.SystemColors.Menu
        Me.Panel_CurrentOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_CurrentOrder.Controls.Add(Me.TextBox_CurrentOrderPrices)
        Me.Panel_CurrentOrder.Controls.Add(Me.TextBox_CurrentOrder)
        Me.Panel_CurrentOrder.Location = New System.Drawing.Point(1549, 97)
        Me.Panel_CurrentOrder.Name = "Panel_CurrentOrder"
        Me.Panel_CurrentOrder.Size = New System.Drawing.Size(355, 562)
        Me.Panel_CurrentOrder.TabIndex = 3
        '
        'TextBox_CurrentOrderPrices
        '
        Me.TextBox_CurrentOrderPrices.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_CurrentOrderPrices.Location = New System.Drawing.Point(248, 3)
        Me.TextBox_CurrentOrderPrices.Multiline = True
        Me.TextBox_CurrentOrderPrices.Name = "TextBox_CurrentOrderPrices"
        Me.TextBox_CurrentOrderPrices.Size = New System.Drawing.Size(105, 552)
        Me.TextBox_CurrentOrderPrices.TabIndex = 0
        '
        'TextBox_CurrentOrder
        '
        Me.TextBox_CurrentOrder.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_CurrentOrder.Location = New System.Drawing.Point(3, 3)
        Me.TextBox_CurrentOrder.Multiline = True
        Me.TextBox_CurrentOrder.Name = "TextBox_CurrentOrder"
        Me.TextBox_CurrentOrder.Size = New System.Drawing.Size(249, 552)
        Me.TextBox_CurrentOrder.TabIndex = 0
        '
        'Panel_CurrentOrderTotal
        '
        Me.Panel_CurrentOrderTotal.BackColor = System.Drawing.SystemColors.Menu
        Me.Panel_CurrentOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_CurrentOrderTotal.Controls.Add(Me.Button_DownCurrOrder)
        Me.Panel_CurrentOrderTotal.Controls.Add(Me.Button_UpCurrOrder)
        Me.Panel_CurrentOrderTotal.Controls.Add(Me.TextBox_TotalCost)
        Me.Panel_CurrentOrderTotal.Controls.Add(Me.TextBox_TotalText)
        Me.Panel_CurrentOrderTotal.Location = New System.Drawing.Point(1549, 661)
        Me.Panel_CurrentOrderTotal.Name = "Panel_CurrentOrderTotal"
        Me.Panel_CurrentOrderTotal.Size = New System.Drawing.Size(355, 59)
        Me.Panel_CurrentOrderTotal.TabIndex = 3
        '
        'Button_DownCurrOrder
        '
        Me.Button_DownCurrOrder.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_DownCurrOrder.Location = New System.Drawing.Point(59, 3)
        Me.Button_DownCurrOrder.Name = "Button_DownCurrOrder"
        Me.Button_DownCurrOrder.Size = New System.Drawing.Size(50, 50)
        Me.Button_DownCurrOrder.TabIndex = 1
        Me.Button_DownCurrOrder.Text = "\/"
        Me.Button_DownCurrOrder.UseVisualStyleBackColor = True
        '
        'Button_UpCurrOrder
        '
        Me.Button_UpCurrOrder.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_UpCurrOrder.Location = New System.Drawing.Point(3, 3)
        Me.Button_UpCurrOrder.Name = "Button_UpCurrOrder"
        Me.Button_UpCurrOrder.Size = New System.Drawing.Size(50, 50)
        Me.Button_UpCurrOrder.TabIndex = 1
        Me.Button_UpCurrOrder.Text = "/\"
        Me.Button_UpCurrOrder.UseVisualStyleBackColor = True
        '
        'TextBox_TotalCost
        '
        Me.TextBox_TotalCost.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TotalCost.Location = New System.Drawing.Point(248, 3)
        Me.TextBox_TotalCost.Multiline = True
        Me.TextBox_TotalCost.Name = "TextBox_TotalCost"
        Me.TextBox_TotalCost.Size = New System.Drawing.Size(105, 50)
        Me.TextBox_TotalCost.TabIndex = 0
        Me.TextBox_TotalCost.Text = "0.00"
        '
        'TextBox_TotalText
        '
        Me.TextBox_TotalText.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TotalText.Location = New System.Drawing.Point(127, 3)
        Me.TextBox_TotalText.Multiline = True
        Me.TextBox_TotalText.Name = "TextBox_TotalText"
        Me.TextBox_TotalText.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_TotalText.Size = New System.Drawing.Size(125, 50)
        Me.TextBox_TotalText.TabIndex = 0
        Me.TextBox_TotalText.Text = "Total:"
        Me.TextBox_TotalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel_CommonControls
        '
        Me.Panel_CommonControls.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel_CommonControls.Controls.Add(Me.Button_Discount20)
        Me.Panel_CommonControls.Controls.Add(Me.Button_Discount15)
        Me.Panel_CommonControls.Controls.Add(Me.Button_Discount10)
        Me.Panel_CommonControls.Controls.Add(Me.Button_CancelTransaction)
        Me.Panel_CommonControls.Controls.Add(Me.Button_SignOut)
        Me.Panel_CommonControls.Controls.Add(Me.Button_CompleteTransaction)
        Me.Panel_CommonControls.Controls.Add(Me.Button_SelectCustomer)
        Me.Panel_CommonControls.Controls.Add(Me.Button_MainMenu)
        Me.Panel_CommonControls.Controls.Add(Me.Button_InventoryManagement)
        Me.Panel_CommonControls.Controls.Add(Me.Button31)
        Me.Panel_CommonControls.Controls.Add(Me.Button_ClearTable)
        Me.Panel_CommonControls.Controls.Add(Me.Button_ViewTransactions)
        Me.Panel_CommonControls.Controls.Add(Me.Button30)
        Me.Panel_CommonControls.Controls.Add(Me.Button12)
        Me.Panel_CommonControls.Controls.Add(Me.Button29)
        Me.Panel_CommonControls.Controls.Add(Me.Button10)
        Me.Panel_CommonControls.Controls.Add(Me.Button28)
        Me.Panel_CommonControls.Controls.Add(Me.Button8)
        Me.Panel_CommonControls.Controls.Add(Me.Button43)
        Me.Panel_CommonControls.Controls.Add(Me.Button27)
        Me.Panel_CommonControls.Controls.Add(Me.Button6)
        Me.Panel_CommonControls.Controls.Add(Me.Button_Discount5)
        Me.Panel_CommonControls.Controls.Add(Me.Button_StudentDiscount)
        Me.Panel_CommonControls.Controls.Add(Me.Button_StaffManagement)
        Me.Panel_CommonControls.Controls.Add(Me.Button_ClearCustomer)
        Me.Panel_CommonControls.Controls.Add(Me.Button_SelectTable)
        Me.Panel_CommonControls.Controls.Add(Me.Button_PayrollManagement)
        Me.Panel_CommonControls.Controls.Add(Me.Button24)
        Me.Panel_CommonControls.Controls.Add(Me.Button13)
        Me.Panel_CommonControls.Controls.Add(Me.Button_ModifyMenu)
        Me.Panel_CommonControls.Controls.Add(Me.Button23)
        Me.Panel_CommonControls.Controls.Add(Me.Button11)
        Me.Panel_CommonControls.Controls.Add(Me.Button22)
        Me.Panel_CommonControls.Controls.Add(Me.Button9)
        Me.Panel_CommonControls.Controls.Add(Me.Button21)
        Me.Panel_CommonControls.Controls.Add(Me.Button7)
        Me.Panel_CommonControls.Controls.Add(Me.Button5)
        Me.Panel_CommonControls.Controls.Add(Me.Button_Reciept)
        Me.Panel_CommonControls.Controls.Add(Me.Button_ProductID)
        Me.Panel_CommonControls.Controls.Add(Me.Button_StaffDiscount)
        Me.Panel_CommonControls.Controls.Add(Me.Button_TrainingMode)
        Me.Panel_CommonControls.Controls.Add(Me.Button_Exit)
        Me.Panel_CommonControls.Controls.Add(Me.Button_DownCat)
        Me.Panel_CommonControls.Controls.Add(Me.Button_UpCat)
        Me.Panel_CommonControls.Location = New System.Drawing.Point(0, 722)
        Me.Panel_CommonControls.Name = "Panel_CommonControls"
        Me.Panel_CommonControls.Size = New System.Drawing.Size(1904, 319)
        Me.Panel_CommonControls.TabIndex = 4
        '
        'Button_Discount20
        '
        Me.Button_Discount20.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button_Discount20.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Discount20.Location = New System.Drawing.Point(442, 215)
        Me.Button_Discount20.Name = "Button_Discount20"
        Me.Button_Discount20.Size = New System.Drawing.Size(100, 100)
        Me.Button_Discount20.TabIndex = 7
        Me.Button_Discount20.Text = "Apply 20% Discount"
        Me.Button_Discount20.UseVisualStyleBackColor = False
        '
        'Button_Discount15
        '
        Me.Button_Discount15.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button_Discount15.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Discount15.Location = New System.Drawing.Point(442, 109)
        Me.Button_Discount15.Name = "Button_Discount15"
        Me.Button_Discount15.Size = New System.Drawing.Size(100, 100)
        Me.Button_Discount15.TabIndex = 6
        Me.Button_Discount15.Text = "Apply 15% Discount"
        Me.Button_Discount15.UseVisualStyleBackColor = False
        '
        'Button_Discount10
        '
        Me.Button_Discount10.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button_Discount10.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Discount10.Location = New System.Drawing.Point(442, 3)
        Me.Button_Discount10.Name = "Button_Discount10"
        Me.Button_Discount10.Size = New System.Drawing.Size(100, 100)
        Me.Button_Discount10.TabIndex = 5
        Me.Button_Discount10.Text = "Apply 10% Discount"
        Me.Button_Discount10.UseVisualStyleBackColor = False
        '
        'Button_CancelTransaction
        '
        Me.Button_CancelTransaction.BackColor = System.Drawing.Color.Firebrick
        Me.Button_CancelTransaction.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_CancelTransaction.Location = New System.Drawing.Point(1714, 4)
        Me.Button_CancelTransaction.Name = "Button_CancelTransaction"
        Me.Button_CancelTransaction.Size = New System.Drawing.Size(100, 100)
        Me.Button_CancelTransaction.TabIndex = 4
        Me.Button_CancelTransaction.Text = "Cancel Current Transaction"
        Me.Button_CancelTransaction.UseVisualStyleBackColor = False
        '
        'Button_SignOut
        '
        Me.Button_SignOut.BackColor = System.Drawing.Color.Red
        Me.Button_SignOut.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SignOut.ForeColor = System.Drawing.Color.White
        Me.Button_SignOut.Location = New System.Drawing.Point(1714, 216)
        Me.Button_SignOut.Name = "Button_SignOut"
        Me.Button_SignOut.Size = New System.Drawing.Size(100, 100)
        Me.Button_SignOut.TabIndex = 4
        Me.Button_SignOut.Text = "Sign Out"
        Me.Button_SignOut.UseVisualStyleBackColor = False
        '
        'Button_CompleteTransaction
        '
        Me.Button_CompleteTransaction.BackColor = System.Drawing.Color.LawnGreen
        Me.Button_CompleteTransaction.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_CompleteTransaction.Location = New System.Drawing.Point(1714, 110)
        Me.Button_CompleteTransaction.Name = "Button_CompleteTransaction"
        Me.Button_CompleteTransaction.Size = New System.Drawing.Size(100, 100)
        Me.Button_CompleteTransaction.TabIndex = 4
        Me.Button_CompleteTransaction.Text = "Complete Current Transaction"
        Me.Button_CompleteTransaction.UseVisualStyleBackColor = False
        '
        'Button_SelectCustomer
        '
        Me.Button_SelectCustomer.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button_SelectCustomer.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SelectCustomer.Location = New System.Drawing.Point(1608, 110)
        Me.Button_SelectCustomer.Name = "Button_SelectCustomer"
        Me.Button_SelectCustomer.Size = New System.Drawing.Size(100, 100)
        Me.Button_SelectCustomer.TabIndex = 4
        Me.Button_SelectCustomer.Text = "Select Customer"
        Me.Button_SelectCustomer.UseVisualStyleBackColor = False
        '
        'Button_MainMenu
        '
        Me.Button_MainMenu.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button_MainMenu.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_MainMenu.Location = New System.Drawing.Point(1608, 215)
        Me.Button_MainMenu.Name = "Button_MainMenu"
        Me.Button_MainMenu.Size = New System.Drawing.Size(100, 100)
        Me.Button_MainMenu.TabIndex = 4
        Me.Button_MainMenu.Text = "Main Menu"
        Me.Button_MainMenu.UseVisualStyleBackColor = False
        '
        'Button_InventoryManagement
        '
        Me.Button_InventoryManagement.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button_InventoryManagement.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_InventoryManagement.Location = New System.Drawing.Point(1184, 215)
        Me.Button_InventoryManagement.Name = "Button_InventoryManagement"
        Me.Button_InventoryManagement.Size = New System.Drawing.Size(206, 100)
        Me.Button_InventoryManagement.TabIndex = 4
        Me.Button_InventoryManagement.Text = "Inventory Management"
        Me.Button_InventoryManagement.UseVisualStyleBackColor = False
        '
        'Button31
        '
        Me.Button31.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button31.Location = New System.Drawing.Point(1396, 109)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(100, 100)
        Me.Button31.TabIndex = 4
        Me.Button31.UseVisualStyleBackColor = True
        '
        'Button_ClearTable
        '
        Me.Button_ClearTable.BackColor = System.Drawing.Color.LightCoral
        Me.Button_ClearTable.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ClearTable.Location = New System.Drawing.Point(1502, 3)
        Me.Button_ClearTable.Name = "Button_ClearTable"
        Me.Button_ClearTable.Size = New System.Drawing.Size(100, 100)
        Me.Button_ClearTable.TabIndex = 4
        Me.Button_ClearTable.Text = "Clear Table"
        Me.Button_ClearTable.UseVisualStyleBackColor = False
        '
        'Button_ViewTransactions
        '
        Me.Button_ViewTransactions.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button_ViewTransactions.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ViewTransactions.Location = New System.Drawing.Point(760, 215)
        Me.Button_ViewTransactions.Name = "Button_ViewTransactions"
        Me.Button_ViewTransactions.Size = New System.Drawing.Size(206, 100)
        Me.Button_ViewTransactions.TabIndex = 4
        Me.Button_ViewTransactions.Text = "View Transactions"
        Me.Button_ViewTransactions.UseVisualStyleBackColor = False
        '
        'Button30
        '
        Me.Button30.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button30.Location = New System.Drawing.Point(1184, 109)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(100, 100)
        Me.Button30.TabIndex = 4
        Me.Button30.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(1290, 3)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(100, 100)
        Me.Button12.TabIndex = 4
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button29
        '
        Me.Button29.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.Location = New System.Drawing.Point(972, 109)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(100, 100)
        Me.Button29.TabIndex = 4
        Me.Button29.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(1078, 3)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(100, 100)
        Me.Button10.TabIndex = 4
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button28
        '
        Me.Button28.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.Location = New System.Drawing.Point(760, 109)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(100, 100)
        Me.Button28.TabIndex = 4
        Me.Button28.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(866, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 100)
        Me.Button8.TabIndex = 4
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button43
        '
        Me.Button43.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button43.Location = New System.Drawing.Point(548, 215)
        Me.Button43.Name = "Button43"
        Me.Button43.Size = New System.Drawing.Size(100, 100)
        Me.Button43.TabIndex = 4
        Me.Button43.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.Location = New System.Drawing.Point(548, 109)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(100, 100)
        Me.Button27.TabIndex = 4
        Me.Button27.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(654, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 100)
        Me.Button6.TabIndex = 4
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button_Discount5
        '
        Me.Button_Discount5.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button_Discount5.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Discount5.Location = New System.Drawing.Point(336, 215)
        Me.Button_Discount5.Name = "Button_Discount5"
        Me.Button_Discount5.Size = New System.Drawing.Size(100, 100)
        Me.Button_Discount5.TabIndex = 4
        Me.Button_Discount5.Text = "Apply 5% Discount"
        Me.Button_Discount5.UseVisualStyleBackColor = False
        '
        'Button_StudentDiscount
        '
        Me.Button_StudentDiscount.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button_StudentDiscount.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_StudentDiscount.Location = New System.Drawing.Point(336, 109)
        Me.Button_StudentDiscount.Name = "Button_StudentDiscount"
        Me.Button_StudentDiscount.Size = New System.Drawing.Size(100, 100)
        Me.Button_StudentDiscount.TabIndex = 4
        Me.Button_StudentDiscount.Text = "Apply Student Discount"
        Me.Button_StudentDiscount.UseVisualStyleBackColor = False
        '
        'Button_StaffManagement
        '
        Me.Button_StaffManagement.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button_StaffManagement.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_StaffManagement.Location = New System.Drawing.Point(1396, 216)
        Me.Button_StaffManagement.Name = "Button_StaffManagement"
        Me.Button_StaffManagement.Size = New System.Drawing.Size(206, 100)
        Me.Button_StaffManagement.TabIndex = 4
        Me.Button_StaffManagement.Text = "Staff Management"
        Me.Button_StaffManagement.UseVisualStyleBackColor = False
        '
        'Button_ClearCustomer
        '
        Me.Button_ClearCustomer.BackColor = System.Drawing.Color.LightCoral
        Me.Button_ClearCustomer.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ClearCustomer.Location = New System.Drawing.Point(1502, 110)
        Me.Button_ClearCustomer.Name = "Button_ClearCustomer"
        Me.Button_ClearCustomer.Size = New System.Drawing.Size(100, 100)
        Me.Button_ClearCustomer.TabIndex = 4
        Me.Button_ClearCustomer.Text = "Clear Customer"
        Me.Button_ClearCustomer.UseVisualStyleBackColor = False
        '
        'Button_SelectTable
        '
        Me.Button_SelectTable.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Button_SelectTable.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_SelectTable.Location = New System.Drawing.Point(1608, 4)
        Me.Button_SelectTable.Name = "Button_SelectTable"
        Me.Button_SelectTable.Size = New System.Drawing.Size(100, 100)
        Me.Button_SelectTable.TabIndex = 4
        Me.Button_SelectTable.Text = "Select Table"
        Me.Button_SelectTable.UseVisualStyleBackColor = False
        '
        'Button_PayrollManagement
        '
        Me.Button_PayrollManagement.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button_PayrollManagement.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_PayrollManagement.Location = New System.Drawing.Point(972, 215)
        Me.Button_PayrollManagement.Name = "Button_PayrollManagement"
        Me.Button_PayrollManagement.Size = New System.Drawing.Size(206, 100)
        Me.Button_PayrollManagement.TabIndex = 4
        Me.Button_PayrollManagement.Text = "Payroll Management"
        Me.Button_PayrollManagement.UseVisualStyleBackColor = False
        '
        'Button24
        '
        Me.Button24.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.Location = New System.Drawing.Point(1290, 109)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(100, 100)
        Me.Button24.TabIndex = 4
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(1396, 3)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(100, 100)
        Me.Button13.TabIndex = 4
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button_ModifyMenu
        '
        Me.Button_ModifyMenu.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button_ModifyMenu.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ModifyMenu.Location = New System.Drawing.Point(654, 215)
        Me.Button_ModifyMenu.Name = "Button_ModifyMenu"
        Me.Button_ModifyMenu.Size = New System.Drawing.Size(100, 100)
        Me.Button_ModifyMenu.TabIndex = 4
        Me.Button_ModifyMenu.Text = "Modify Menu"
        Me.Button_ModifyMenu.UseVisualStyleBackColor = False
        '
        'Button23
        '
        Me.Button23.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.Location = New System.Drawing.Point(1078, 109)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(100, 100)
        Me.Button23.TabIndex = 4
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(1184, 3)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(100, 100)
        Me.Button11.TabIndex = 4
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.Location = New System.Drawing.Point(866, 109)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(100, 100)
        Me.Button22.TabIndex = 4
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(972, 3)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(100, 100)
        Me.Button9.TabIndex = 4
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.Location = New System.Drawing.Point(654, 109)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(100, 100)
        Me.Button21.TabIndex = 4
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(760, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 100)
        Me.Button7.TabIndex = 4
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(548, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 100)
        Me.Button5.TabIndex = 4
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button_Reciept
        '
        Me.Button_Reciept.BackColor = System.Drawing.Color.SkyBlue
        Me.Button_Reciept.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Reciept.Location = New System.Drawing.Point(230, 215)
        Me.Button_Reciept.Name = "Button_Reciept"
        Me.Button_Reciept.Size = New System.Drawing.Size(100, 100)
        Me.Button_Reciept.TabIndex = 4
        Me.Button_Reciept.Text = "View Reciept"
        Me.Button_Reciept.UseVisualStyleBackColor = False
        '
        'Button_ProductID
        '
        Me.Button_ProductID.BackColor = System.Drawing.Color.SkyBlue
        Me.Button_ProductID.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ProductID.Location = New System.Drawing.Point(230, 109)
        Me.Button_ProductID.Name = "Button_ProductID"
        Me.Button_ProductID.Size = New System.Drawing.Size(100, 100)
        Me.Button_ProductID.TabIndex = 4
        Me.Button_ProductID.Text = "Enter Product ID"
        Me.Button_ProductID.UseVisualStyleBackColor = False
        '
        'Button_StaffDiscount
        '
        Me.Button_StaffDiscount.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button_StaffDiscount.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_StaffDiscount.Location = New System.Drawing.Point(336, 3)
        Me.Button_StaffDiscount.Name = "Button_StaffDiscount"
        Me.Button_StaffDiscount.Size = New System.Drawing.Size(100, 100)
        Me.Button_StaffDiscount.TabIndex = 4
        Me.Button_StaffDiscount.Text = "Apply Staff Discount"
        Me.Button_StaffDiscount.UseVisualStyleBackColor = False
        '
        'Button_TrainingMode
        '
        Me.Button_TrainingMode.BackColor = System.Drawing.Color.Bisque
        Me.Button_TrainingMode.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_TrainingMode.Location = New System.Drawing.Point(230, 3)
        Me.Button_TrainingMode.Name = "Button_TrainingMode"
        Me.Button_TrainingMode.Size = New System.Drawing.Size(100, 100)
        Me.Button_TrainingMode.TabIndex = 4
        Me.Button_TrainingMode.Text = "Training Mode"
        Me.Button_TrainingMode.UseVisualStyleBackColor = False
        '
        'Button_Exit
        '
        Me.Button_Exit.BackColor = System.Drawing.Color.Red
        Me.Button_Exit.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Exit.Location = New System.Drawing.Point(18, 215)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.Size = New System.Drawing.Size(100, 100)
        Me.Button_Exit.TabIndex = 4
        Me.Button_Exit.Text = "Exit"
        Me.Button_Exit.UseVisualStyleBackColor = False
        '
        'Button_DownCat
        '
        Me.Button_DownCat.BackColor = System.Drawing.Color.LightCoral
        Me.Button_DownCat.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_DownCat.Location = New System.Drawing.Point(68, 3)
        Me.Button_DownCat.Name = "Button_DownCat"
        Me.Button_DownCat.Size = New System.Drawing.Size(50, 50)
        Me.Button_DownCat.TabIndex = 2
        Me.Button_DownCat.Text = "\/"
        Me.Button_DownCat.UseVisualStyleBackColor = False
        '
        'Button_UpCat
        '
        Me.Button_UpCat.BackColor = System.Drawing.Color.LightCoral
        Me.Button_UpCat.Font = New System.Drawing.Font("Leelawadee UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_UpCat.Location = New System.Drawing.Point(12, 3)
        Me.Button_UpCat.Name = "Button_UpCat"
        Me.Button_UpCat.Size = New System.Drawing.Size(50, 50)
        Me.Button_UpCat.TabIndex = 3
        Me.Button_UpCat.Text = "/\"
        Me.Button_UpCat.UseVisualStyleBackColor = False
        '
        'Panel_CatSpecials
        '
        Me.Panel_CatSpecials.BackColor = System.Drawing.Color.LightCoral
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder27)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder18)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder26)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder17)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder25)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder16)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder24)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder15)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder23)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder14)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder22)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder13)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder21)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder12)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder20)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder11)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder19)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder10)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder9)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder8)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder7)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder6)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder5)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder4)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder3)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder2)
        Me.Panel_CatSpecials.Controls.Add(Me.Specials_Button_Placeholder1)
        Me.Panel_CatSpecials.Location = New System.Drawing.Point(12, 102)
        Me.Panel_CatSpecials.Name = "Panel_CatSpecials"
        Me.Panel_CatSpecials.Size = New System.Drawing.Size(1528, 614)
        Me.Panel_CatSpecials.TabIndex = 5
        '
        'Specials_Button_Placeholder27
        '
        Me.Specials_Button_Placeholder27.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder27.Location = New System.Drawing.Point(1348, 348)
        Me.Specials_Button_Placeholder27.Name = "Specials_Button_Placeholder27"
        Me.Specials_Button_Placeholder27.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder27.TabIndex = 0
        Me.Specials_Button_Placeholder27.Text = "Placeholder"
        Me.Specials_Button_Placeholder27.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder27.Visible = False
        '
        'Specials_Button_Placeholder18
        '
        Me.Specials_Button_Placeholder18.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder18.Location = New System.Drawing.Point(1348, 182)
        Me.Specials_Button_Placeholder18.Name = "Specials_Button_Placeholder18"
        Me.Specials_Button_Placeholder18.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder18.TabIndex = 0
        Me.Specials_Button_Placeholder18.Text = "Placeholder"
        Me.Specials_Button_Placeholder18.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder18.Visible = False
        '
        'Specials_Button_Placeholder26
        '
        Me.Specials_Button_Placeholder26.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder26.Location = New System.Drawing.Point(1182, 348)
        Me.Specials_Button_Placeholder26.Name = "Specials_Button_Placeholder26"
        Me.Specials_Button_Placeholder26.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder26.TabIndex = 0
        Me.Specials_Button_Placeholder26.Text = "Placeholder"
        Me.Specials_Button_Placeholder26.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder26.Visible = False
        '
        'Specials_Button_Placeholder17
        '
        Me.Specials_Button_Placeholder17.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder17.Location = New System.Drawing.Point(1182, 182)
        Me.Specials_Button_Placeholder17.Name = "Specials_Button_Placeholder17"
        Me.Specials_Button_Placeholder17.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder17.TabIndex = 0
        Me.Specials_Button_Placeholder17.Text = "Placeholder"
        Me.Specials_Button_Placeholder17.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder17.Visible = False
        '
        'Specials_Button_Placeholder25
        '
        Me.Specials_Button_Placeholder25.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder25.Location = New System.Drawing.Point(1016, 348)
        Me.Specials_Button_Placeholder25.Name = "Specials_Button_Placeholder25"
        Me.Specials_Button_Placeholder25.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder25.TabIndex = 0
        Me.Specials_Button_Placeholder25.Text = "Placeholder"
        Me.Specials_Button_Placeholder25.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder25.Visible = False
        '
        'Specials_Button_Placeholder16
        '
        Me.Specials_Button_Placeholder16.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder16.Location = New System.Drawing.Point(1016, 182)
        Me.Specials_Button_Placeholder16.Name = "Specials_Button_Placeholder16"
        Me.Specials_Button_Placeholder16.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder16.TabIndex = 0
        Me.Specials_Button_Placeholder16.Text = "Placeholder"
        Me.Specials_Button_Placeholder16.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder16.Visible = False
        '
        'Specials_Button_Placeholder24
        '
        Me.Specials_Button_Placeholder24.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder24.Location = New System.Drawing.Point(850, 348)
        Me.Specials_Button_Placeholder24.Name = "Specials_Button_Placeholder24"
        Me.Specials_Button_Placeholder24.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder24.TabIndex = 0
        Me.Specials_Button_Placeholder24.Text = "Placeholder"
        Me.Specials_Button_Placeholder24.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder24.Visible = False
        '
        'Specials_Button_Placeholder15
        '
        Me.Specials_Button_Placeholder15.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder15.Location = New System.Drawing.Point(850, 182)
        Me.Specials_Button_Placeholder15.Name = "Specials_Button_Placeholder15"
        Me.Specials_Button_Placeholder15.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder15.TabIndex = 0
        Me.Specials_Button_Placeholder15.Text = "Placeholder"
        Me.Specials_Button_Placeholder15.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder15.Visible = False
        '
        'Specials_Button_Placeholder23
        '
        Me.Specials_Button_Placeholder23.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder23.Location = New System.Drawing.Point(685, 348)
        Me.Specials_Button_Placeholder23.Name = "Specials_Button_Placeholder23"
        Me.Specials_Button_Placeholder23.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder23.TabIndex = 0
        Me.Specials_Button_Placeholder23.Text = "Placeholder"
        Me.Specials_Button_Placeholder23.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder23.Visible = False
        '
        'Specials_Button_Placeholder14
        '
        Me.Specials_Button_Placeholder14.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder14.Location = New System.Drawing.Point(685, 182)
        Me.Specials_Button_Placeholder14.Name = "Specials_Button_Placeholder14"
        Me.Specials_Button_Placeholder14.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder14.TabIndex = 0
        Me.Specials_Button_Placeholder14.Text = "Placeholder"
        Me.Specials_Button_Placeholder14.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder14.Visible = False
        '
        'Specials_Button_Placeholder22
        '
        Me.Specials_Button_Placeholder22.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder22.Location = New System.Drawing.Point(519, 348)
        Me.Specials_Button_Placeholder22.Name = "Specials_Button_Placeholder22"
        Me.Specials_Button_Placeholder22.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder22.TabIndex = 0
        Me.Specials_Button_Placeholder22.Text = "Placeholder"
        Me.Specials_Button_Placeholder22.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder22.Visible = False
        '
        'Specials_Button_Placeholder13
        '
        Me.Specials_Button_Placeholder13.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder13.Location = New System.Drawing.Point(519, 182)
        Me.Specials_Button_Placeholder13.Name = "Specials_Button_Placeholder13"
        Me.Specials_Button_Placeholder13.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder13.TabIndex = 0
        Me.Specials_Button_Placeholder13.Text = "Placeholder"
        Me.Specials_Button_Placeholder13.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder13.Visible = False
        '
        'Specials_Button_Placeholder21
        '
        Me.Specials_Button_Placeholder21.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder21.Location = New System.Drawing.Point(353, 348)
        Me.Specials_Button_Placeholder21.Name = "Specials_Button_Placeholder21"
        Me.Specials_Button_Placeholder21.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder21.TabIndex = 0
        Me.Specials_Button_Placeholder21.Text = "Placeholder"
        Me.Specials_Button_Placeholder21.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder21.Visible = False
        '
        'Specials_Button_Placeholder12
        '
        Me.Specials_Button_Placeholder12.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder12.Location = New System.Drawing.Point(353, 182)
        Me.Specials_Button_Placeholder12.Name = "Specials_Button_Placeholder12"
        Me.Specials_Button_Placeholder12.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder12.TabIndex = 0
        Me.Specials_Button_Placeholder12.Text = "Placeholder"
        Me.Specials_Button_Placeholder12.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder12.Visible = False
        '
        'Specials_Button_Placeholder20
        '
        Me.Specials_Button_Placeholder20.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder20.Location = New System.Drawing.Point(187, 348)
        Me.Specials_Button_Placeholder20.Name = "Specials_Button_Placeholder20"
        Me.Specials_Button_Placeholder20.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder20.TabIndex = 0
        Me.Specials_Button_Placeholder20.Text = "Placeholder"
        Me.Specials_Button_Placeholder20.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder20.Visible = False
        '
        'Specials_Button_Placeholder11
        '
        Me.Specials_Button_Placeholder11.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder11.Location = New System.Drawing.Point(187, 182)
        Me.Specials_Button_Placeholder11.Name = "Specials_Button_Placeholder11"
        Me.Specials_Button_Placeholder11.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder11.TabIndex = 0
        Me.Specials_Button_Placeholder11.Text = "Placeholder"
        Me.Specials_Button_Placeholder11.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder11.Visible = False
        '
        'Specials_Button_Placeholder19
        '
        Me.Specials_Button_Placeholder19.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder19.Location = New System.Drawing.Point(21, 348)
        Me.Specials_Button_Placeholder19.Name = "Specials_Button_Placeholder19"
        Me.Specials_Button_Placeholder19.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder19.TabIndex = 0
        Me.Specials_Button_Placeholder19.Text = "Placeholder"
        Me.Specials_Button_Placeholder19.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder19.Visible = False
        '
        'Specials_Button_Placeholder10
        '
        Me.Specials_Button_Placeholder10.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder10.Location = New System.Drawing.Point(21, 182)
        Me.Specials_Button_Placeholder10.Name = "Specials_Button_Placeholder10"
        Me.Specials_Button_Placeholder10.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder10.TabIndex = 0
        Me.Specials_Button_Placeholder10.Text = "Placeholder"
        Me.Specials_Button_Placeholder10.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder10.Visible = False
        '
        'Specials_Button_Placeholder9
        '
        Me.Specials_Button_Placeholder9.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder9.Location = New System.Drawing.Point(1348, 16)
        Me.Specials_Button_Placeholder9.Name = "Specials_Button_Placeholder9"
        Me.Specials_Button_Placeholder9.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder9.TabIndex = 0
        Me.Specials_Button_Placeholder9.Text = "Placeholder"
        Me.Specials_Button_Placeholder9.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder9.Visible = False
        '
        'Specials_Button_Placeholder8
        '
        Me.Specials_Button_Placeholder8.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder8.Location = New System.Drawing.Point(1182, 16)
        Me.Specials_Button_Placeholder8.Name = "Specials_Button_Placeholder8"
        Me.Specials_Button_Placeholder8.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder8.TabIndex = 0
        Me.Specials_Button_Placeholder8.Text = "Placeholder"
        Me.Specials_Button_Placeholder8.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder8.Visible = False
        '
        'Specials_Button_Placeholder7
        '
        Me.Specials_Button_Placeholder7.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder7.Location = New System.Drawing.Point(1016, 16)
        Me.Specials_Button_Placeholder7.Name = "Specials_Button_Placeholder7"
        Me.Specials_Button_Placeholder7.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder7.TabIndex = 0
        Me.Specials_Button_Placeholder7.Text = "Placeholder"
        Me.Specials_Button_Placeholder7.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder7.Visible = False
        '
        'Specials_Button_Placeholder6
        '
        Me.Specials_Button_Placeholder6.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder6.Location = New System.Drawing.Point(850, 16)
        Me.Specials_Button_Placeholder6.Name = "Specials_Button_Placeholder6"
        Me.Specials_Button_Placeholder6.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder6.TabIndex = 0
        Me.Specials_Button_Placeholder6.Text = "Placeholder"
        Me.Specials_Button_Placeholder6.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder6.Visible = False
        '
        'Specials_Button_Placeholder5
        '
        Me.Specials_Button_Placeholder5.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder5.Location = New System.Drawing.Point(685, 16)
        Me.Specials_Button_Placeholder5.Name = "Specials_Button_Placeholder5"
        Me.Specials_Button_Placeholder5.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder5.TabIndex = 0
        Me.Specials_Button_Placeholder5.Text = "Placeholder"
        Me.Specials_Button_Placeholder5.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder5.Visible = False
        '
        'Specials_Button_Placeholder4
        '
        Me.Specials_Button_Placeholder4.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder4.Location = New System.Drawing.Point(519, 16)
        Me.Specials_Button_Placeholder4.Name = "Specials_Button_Placeholder4"
        Me.Specials_Button_Placeholder4.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder4.TabIndex = 0
        Me.Specials_Button_Placeholder4.Text = "Placeholder"
        Me.Specials_Button_Placeholder4.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder4.Visible = False
        '
        'Specials_Button_Placeholder3
        '
        Me.Specials_Button_Placeholder3.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder3.Location = New System.Drawing.Point(353, 16)
        Me.Specials_Button_Placeholder3.Name = "Specials_Button_Placeholder3"
        Me.Specials_Button_Placeholder3.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder3.TabIndex = 0
        Me.Specials_Button_Placeholder3.Text = "Placeholder"
        Me.Specials_Button_Placeholder3.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder3.Visible = False
        '
        'Specials_Button_Placeholder2
        '
        Me.Specials_Button_Placeholder2.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder2.Location = New System.Drawing.Point(187, 16)
        Me.Specials_Button_Placeholder2.Name = "Specials_Button_Placeholder2"
        Me.Specials_Button_Placeholder2.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder2.TabIndex = 0
        Me.Specials_Button_Placeholder2.Text = "Placeholder"
        Me.Specials_Button_Placeholder2.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder2.Visible = False
        '
        'Specials_Button_Placeholder1
        '
        Me.Specials_Button_Placeholder1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Specials_Button_Placeholder1.Location = New System.Drawing.Point(21, 16)
        Me.Specials_Button_Placeholder1.Name = "Specials_Button_Placeholder1"
        Me.Specials_Button_Placeholder1.Size = New System.Drawing.Size(160, 160)
        Me.Specials_Button_Placeholder1.TabIndex = 0
        Me.Specials_Button_Placeholder1.Text = "Placeholder"
        Me.Specials_Button_Placeholder1.UseVisualStyleBackColor = True
        Me.Specials_Button_Placeholder1.Visible = False
        '
        'Label_AdminStatus
        '
        Me.Label_AdminStatus.AutoSize = True
        Me.Label_AdminStatus.BackColor = System.Drawing.Color.White
        Me.Label_AdminStatus.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_AdminStatus.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label_AdminStatus.Location = New System.Drawing.Point(1775, 0)
        Me.Label_AdminStatus.Name = "Label_AdminStatus"
        Me.Label_AdminStatus.Size = New System.Drawing.Size(124, 21)
        Me.Label_AdminStatus.TabIndex = 6
        Me.Label_AdminStatus.Text = "[ Administrator ]"
        Me.Label_AdminStatus.Visible = False
        '
        'Label_Training
        '
        Me.Label_Training.AutoSize = True
        Me.Label_Training.BackColor = System.Drawing.Color.White
        Me.Label_Training.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Training.ForeColor = System.Drawing.Color.Red
        Me.Label_Training.Location = New System.Drawing.Point(1744, 0)
        Me.Label_Training.Name = "Label_Training"
        Me.Label_Training.Size = New System.Drawing.Size(148, 21)
        Me.Label_Training.TabIndex = 6
        Me.Label_Training.Text = "[ TRAINING MODE ]"
        '
        'Panel_CatStarters
        '
        Me.Panel_CatStarters.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder27)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder26)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder25)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder24)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder23)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder22)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder21)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder20)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder19)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder18)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder17)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder16)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder15)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder14)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder13)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder12)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder11)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder10)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder9)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder8)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder7)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder6)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder5)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder4)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder3)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder2)
        Me.Panel_CatStarters.Controls.Add(Me.Starters_Button_Placeholder1)
        Me.Panel_CatStarters.Location = New System.Drawing.Point(12, 102)
        Me.Panel_CatStarters.Name = "Panel_CatStarters"
        Me.Panel_CatStarters.Size = New System.Drawing.Size(1528, 614)
        Me.Panel_CatStarters.TabIndex = 6
        '
        'Starters_Button_Placeholder27
        '
        Me.Starters_Button_Placeholder27.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder27.Location = New System.Drawing.Point(1348, 348)
        Me.Starters_Button_Placeholder27.Name = "Starters_Button_Placeholder27"
        Me.Starters_Button_Placeholder27.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder27.TabIndex = 0
        Me.Starters_Button_Placeholder27.Text = "Placeholder"
        Me.Starters_Button_Placeholder27.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder27.Visible = False
        '
        'Starters_Button_Placeholder26
        '
        Me.Starters_Button_Placeholder26.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder26.Location = New System.Drawing.Point(1348, 182)
        Me.Starters_Button_Placeholder26.Name = "Starters_Button_Placeholder26"
        Me.Starters_Button_Placeholder26.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder26.TabIndex = 0
        Me.Starters_Button_Placeholder26.Text = "Placeholder"
        Me.Starters_Button_Placeholder26.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder26.Visible = False
        '
        'Starters_Button_Placeholder25
        '
        Me.Starters_Button_Placeholder25.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder25.Location = New System.Drawing.Point(1182, 348)
        Me.Starters_Button_Placeholder25.Name = "Starters_Button_Placeholder25"
        Me.Starters_Button_Placeholder25.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder25.TabIndex = 0
        Me.Starters_Button_Placeholder25.Text = "Placeholder"
        Me.Starters_Button_Placeholder25.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder25.Visible = False
        '
        'Starters_Button_Placeholder24
        '
        Me.Starters_Button_Placeholder24.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder24.Location = New System.Drawing.Point(1182, 182)
        Me.Starters_Button_Placeholder24.Name = "Starters_Button_Placeholder24"
        Me.Starters_Button_Placeholder24.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder24.TabIndex = 0
        Me.Starters_Button_Placeholder24.Text = "Placeholder"
        Me.Starters_Button_Placeholder24.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder24.Visible = False
        '
        'Starters_Button_Placeholder23
        '
        Me.Starters_Button_Placeholder23.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder23.Location = New System.Drawing.Point(1016, 348)
        Me.Starters_Button_Placeholder23.Name = "Starters_Button_Placeholder23"
        Me.Starters_Button_Placeholder23.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder23.TabIndex = 0
        Me.Starters_Button_Placeholder23.Text = "Placeholder"
        Me.Starters_Button_Placeholder23.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder23.Visible = False
        '
        'Starters_Button_Placeholder22
        '
        Me.Starters_Button_Placeholder22.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder22.Location = New System.Drawing.Point(1016, 182)
        Me.Starters_Button_Placeholder22.Name = "Starters_Button_Placeholder22"
        Me.Starters_Button_Placeholder22.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder22.TabIndex = 0
        Me.Starters_Button_Placeholder22.Text = "Placeholder"
        Me.Starters_Button_Placeholder22.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder22.Visible = False
        '
        'Starters_Button_Placeholder21
        '
        Me.Starters_Button_Placeholder21.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder21.Location = New System.Drawing.Point(850, 348)
        Me.Starters_Button_Placeholder21.Name = "Starters_Button_Placeholder21"
        Me.Starters_Button_Placeholder21.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder21.TabIndex = 0
        Me.Starters_Button_Placeholder21.Text = "Placeholder"
        Me.Starters_Button_Placeholder21.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder21.Visible = False
        '
        'Starters_Button_Placeholder20
        '
        Me.Starters_Button_Placeholder20.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder20.Location = New System.Drawing.Point(850, 182)
        Me.Starters_Button_Placeholder20.Name = "Starters_Button_Placeholder20"
        Me.Starters_Button_Placeholder20.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder20.TabIndex = 0
        Me.Starters_Button_Placeholder20.Text = "Placeholder"
        Me.Starters_Button_Placeholder20.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder20.Visible = False
        '
        'Starters_Button_Placeholder19
        '
        Me.Starters_Button_Placeholder19.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder19.Location = New System.Drawing.Point(685, 348)
        Me.Starters_Button_Placeholder19.Name = "Starters_Button_Placeholder19"
        Me.Starters_Button_Placeholder19.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder19.TabIndex = 0
        Me.Starters_Button_Placeholder19.Text = "Placeholder"
        Me.Starters_Button_Placeholder19.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder19.Visible = False
        '
        'Starters_Button_Placeholder18
        '
        Me.Starters_Button_Placeholder18.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder18.Location = New System.Drawing.Point(685, 182)
        Me.Starters_Button_Placeholder18.Name = "Starters_Button_Placeholder18"
        Me.Starters_Button_Placeholder18.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder18.TabIndex = 0
        Me.Starters_Button_Placeholder18.Text = "Placeholder"
        Me.Starters_Button_Placeholder18.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder18.Visible = False
        '
        'Starters_Button_Placeholder17
        '
        Me.Starters_Button_Placeholder17.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder17.Location = New System.Drawing.Point(519, 348)
        Me.Starters_Button_Placeholder17.Name = "Starters_Button_Placeholder17"
        Me.Starters_Button_Placeholder17.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder17.TabIndex = 0
        Me.Starters_Button_Placeholder17.Text = "Placeholder"
        Me.Starters_Button_Placeholder17.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder17.Visible = False
        '
        'Starters_Button_Placeholder16
        '
        Me.Starters_Button_Placeholder16.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder16.Location = New System.Drawing.Point(519, 182)
        Me.Starters_Button_Placeholder16.Name = "Starters_Button_Placeholder16"
        Me.Starters_Button_Placeholder16.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder16.TabIndex = 0
        Me.Starters_Button_Placeholder16.Text = "Placeholder"
        Me.Starters_Button_Placeholder16.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder16.Visible = False
        '
        'Starters_Button_Placeholder15
        '
        Me.Starters_Button_Placeholder15.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder15.Location = New System.Drawing.Point(353, 348)
        Me.Starters_Button_Placeholder15.Name = "Starters_Button_Placeholder15"
        Me.Starters_Button_Placeholder15.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder15.TabIndex = 0
        Me.Starters_Button_Placeholder15.Text = "Placeholder"
        Me.Starters_Button_Placeholder15.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder15.Visible = False
        '
        'Starters_Button_Placeholder14
        '
        Me.Starters_Button_Placeholder14.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder14.Location = New System.Drawing.Point(353, 182)
        Me.Starters_Button_Placeholder14.Name = "Starters_Button_Placeholder14"
        Me.Starters_Button_Placeholder14.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder14.TabIndex = 0
        Me.Starters_Button_Placeholder14.Text = "Placeholder"
        Me.Starters_Button_Placeholder14.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder14.Visible = False
        '
        'Starters_Button_Placeholder13
        '
        Me.Starters_Button_Placeholder13.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder13.Location = New System.Drawing.Point(187, 348)
        Me.Starters_Button_Placeholder13.Name = "Starters_Button_Placeholder13"
        Me.Starters_Button_Placeholder13.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder13.TabIndex = 0
        Me.Starters_Button_Placeholder13.Text = "Placeholder"
        Me.Starters_Button_Placeholder13.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder13.Visible = False
        '
        'Starters_Button_Placeholder12
        '
        Me.Starters_Button_Placeholder12.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder12.Location = New System.Drawing.Point(187, 182)
        Me.Starters_Button_Placeholder12.Name = "Starters_Button_Placeholder12"
        Me.Starters_Button_Placeholder12.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder12.TabIndex = 0
        Me.Starters_Button_Placeholder12.Text = "Placeholder"
        Me.Starters_Button_Placeholder12.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder12.Visible = False
        '
        'Starters_Button_Placeholder11
        '
        Me.Starters_Button_Placeholder11.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder11.Location = New System.Drawing.Point(21, 348)
        Me.Starters_Button_Placeholder11.Name = "Starters_Button_Placeholder11"
        Me.Starters_Button_Placeholder11.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder11.TabIndex = 0
        Me.Starters_Button_Placeholder11.Text = "Placeholder"
        Me.Starters_Button_Placeholder11.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder11.Visible = False
        '
        'Starters_Button_Placeholder10
        '
        Me.Starters_Button_Placeholder10.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder10.Location = New System.Drawing.Point(21, 182)
        Me.Starters_Button_Placeholder10.Name = "Starters_Button_Placeholder10"
        Me.Starters_Button_Placeholder10.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder10.TabIndex = 0
        Me.Starters_Button_Placeholder10.Text = "Placeholder"
        Me.Starters_Button_Placeholder10.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder10.Visible = False
        '
        'Starters_Button_Placeholder9
        '
        Me.Starters_Button_Placeholder9.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder9.Location = New System.Drawing.Point(1348, 16)
        Me.Starters_Button_Placeholder9.Name = "Starters_Button_Placeholder9"
        Me.Starters_Button_Placeholder9.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder9.TabIndex = 0
        Me.Starters_Button_Placeholder9.Text = "Placeholder"
        Me.Starters_Button_Placeholder9.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder9.Visible = False
        '
        'Starters_Button_Placeholder8
        '
        Me.Starters_Button_Placeholder8.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder8.Location = New System.Drawing.Point(1182, 16)
        Me.Starters_Button_Placeholder8.Name = "Starters_Button_Placeholder8"
        Me.Starters_Button_Placeholder8.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder8.TabIndex = 1
        Me.Starters_Button_Placeholder8.Text = "Placeholder"
        Me.Starters_Button_Placeholder8.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder8.Visible = False
        '
        'Starters_Button_Placeholder7
        '
        Me.Starters_Button_Placeholder7.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder7.Location = New System.Drawing.Point(1016, 16)
        Me.Starters_Button_Placeholder7.Name = "Starters_Button_Placeholder7"
        Me.Starters_Button_Placeholder7.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder7.TabIndex = 0
        Me.Starters_Button_Placeholder7.Text = "Placeholder"
        Me.Starters_Button_Placeholder7.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder7.Visible = False
        '
        'Starters_Button_Placeholder6
        '
        Me.Starters_Button_Placeholder6.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder6.Location = New System.Drawing.Point(850, 16)
        Me.Starters_Button_Placeholder6.Name = "Starters_Button_Placeholder6"
        Me.Starters_Button_Placeholder6.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder6.TabIndex = 0
        Me.Starters_Button_Placeholder6.Text = "Placeholder"
        Me.Starters_Button_Placeholder6.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder6.Visible = False
        '
        'Starters_Button_Placeholder5
        '
        Me.Starters_Button_Placeholder5.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder5.Location = New System.Drawing.Point(685, 16)
        Me.Starters_Button_Placeholder5.Name = "Starters_Button_Placeholder5"
        Me.Starters_Button_Placeholder5.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder5.TabIndex = 0
        Me.Starters_Button_Placeholder5.Text = "Placeholder"
        Me.Starters_Button_Placeholder5.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder5.Visible = False
        '
        'Starters_Button_Placeholder4
        '
        Me.Starters_Button_Placeholder4.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder4.Location = New System.Drawing.Point(519, 16)
        Me.Starters_Button_Placeholder4.Name = "Starters_Button_Placeholder4"
        Me.Starters_Button_Placeholder4.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder4.TabIndex = 0
        Me.Starters_Button_Placeholder4.Text = "Placeholder"
        Me.Starters_Button_Placeholder4.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder4.Visible = False
        '
        'Starters_Button_Placeholder3
        '
        Me.Starters_Button_Placeholder3.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder3.Location = New System.Drawing.Point(353, 16)
        Me.Starters_Button_Placeholder3.Name = "Starters_Button_Placeholder3"
        Me.Starters_Button_Placeholder3.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder3.TabIndex = 0
        Me.Starters_Button_Placeholder3.Text = "Placeholder"
        Me.Starters_Button_Placeholder3.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder3.Visible = False
        '
        'Starters_Button_Placeholder2
        '
        Me.Starters_Button_Placeholder2.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder2.Location = New System.Drawing.Point(187, 16)
        Me.Starters_Button_Placeholder2.Name = "Starters_Button_Placeholder2"
        Me.Starters_Button_Placeholder2.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder2.TabIndex = 0
        Me.Starters_Button_Placeholder2.Text = "Placeholder"
        Me.Starters_Button_Placeholder2.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder2.Visible = False
        '
        'Starters_Button_Placeholder1
        '
        Me.Starters_Button_Placeholder1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starters_Button_Placeholder1.Location = New System.Drawing.Point(21, 16)
        Me.Starters_Button_Placeholder1.Name = "Starters_Button_Placeholder1"
        Me.Starters_Button_Placeholder1.Size = New System.Drawing.Size(160, 160)
        Me.Starters_Button_Placeholder1.TabIndex = 0
        Me.Starters_Button_Placeholder1.Text = "Placeholder"
        Me.Starters_Button_Placeholder1.UseVisualStyleBackColor = True
        Me.Starters_Button_Placeholder1.Visible = False
        '
        'Panel_CatMains
        '
        Me.Panel_CatMains.BackColor = System.Drawing.Color.LightCyan
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder27)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder18)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder26)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder17)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder25)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder16)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder24)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder15)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder23)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder14)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder22)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder13)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder21)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder12)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder20)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder11)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder19)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder10)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder9)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder8)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder7)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder6)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder5)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder4)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder3)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder2)
        Me.Panel_CatMains.Controls.Add(Me.Mains_Button_Placeholder1)
        Me.Panel_CatMains.Location = New System.Drawing.Point(12, 102)
        Me.Panel_CatMains.Name = "Panel_CatMains"
        Me.Panel_CatMains.Size = New System.Drawing.Size(1528, 614)
        Me.Panel_CatMains.TabIndex = 7
        '
        'Mains_Button_Placeholder27
        '
        Me.Mains_Button_Placeholder27.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder27.Location = New System.Drawing.Point(1348, 348)
        Me.Mains_Button_Placeholder27.Name = "Mains_Button_Placeholder27"
        Me.Mains_Button_Placeholder27.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder27.TabIndex = 0
        Me.Mains_Button_Placeholder27.Text = "Placeholder"
        Me.Mains_Button_Placeholder27.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder27.Visible = False
        '
        'Mains_Button_Placeholder18
        '
        Me.Mains_Button_Placeholder18.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder18.Location = New System.Drawing.Point(1348, 182)
        Me.Mains_Button_Placeholder18.Name = "Mains_Button_Placeholder18"
        Me.Mains_Button_Placeholder18.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder18.TabIndex = 0
        Me.Mains_Button_Placeholder18.Text = "Placeholder"
        Me.Mains_Button_Placeholder18.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder18.Visible = False
        '
        'Mains_Button_Placeholder26
        '
        Me.Mains_Button_Placeholder26.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder26.Location = New System.Drawing.Point(1182, 348)
        Me.Mains_Button_Placeholder26.Name = "Mains_Button_Placeholder26"
        Me.Mains_Button_Placeholder26.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder26.TabIndex = 0
        Me.Mains_Button_Placeholder26.Text = "Placeholder"
        Me.Mains_Button_Placeholder26.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder26.Visible = False
        '
        'Mains_Button_Placeholder17
        '
        Me.Mains_Button_Placeholder17.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder17.Location = New System.Drawing.Point(1182, 182)
        Me.Mains_Button_Placeholder17.Name = "Mains_Button_Placeholder17"
        Me.Mains_Button_Placeholder17.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder17.TabIndex = 0
        Me.Mains_Button_Placeholder17.Text = "Placeholder"
        Me.Mains_Button_Placeholder17.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder17.Visible = False
        '
        'Mains_Button_Placeholder25
        '
        Me.Mains_Button_Placeholder25.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder25.Location = New System.Drawing.Point(1016, 348)
        Me.Mains_Button_Placeholder25.Name = "Mains_Button_Placeholder25"
        Me.Mains_Button_Placeholder25.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder25.TabIndex = 0
        Me.Mains_Button_Placeholder25.Text = "Placeholder"
        Me.Mains_Button_Placeholder25.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder25.Visible = False
        '
        'Mains_Button_Placeholder16
        '
        Me.Mains_Button_Placeholder16.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder16.Location = New System.Drawing.Point(1016, 182)
        Me.Mains_Button_Placeholder16.Name = "Mains_Button_Placeholder16"
        Me.Mains_Button_Placeholder16.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder16.TabIndex = 0
        Me.Mains_Button_Placeholder16.Text = "Placeholder"
        Me.Mains_Button_Placeholder16.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder16.Visible = False
        '
        'Mains_Button_Placeholder24
        '
        Me.Mains_Button_Placeholder24.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder24.Location = New System.Drawing.Point(850, 348)
        Me.Mains_Button_Placeholder24.Name = "Mains_Button_Placeholder24"
        Me.Mains_Button_Placeholder24.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder24.TabIndex = 0
        Me.Mains_Button_Placeholder24.Text = "Placeholder"
        Me.Mains_Button_Placeholder24.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder24.Visible = False
        '
        'Mains_Button_Placeholder15
        '
        Me.Mains_Button_Placeholder15.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder15.Location = New System.Drawing.Point(850, 182)
        Me.Mains_Button_Placeholder15.Name = "Mains_Button_Placeholder15"
        Me.Mains_Button_Placeholder15.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder15.TabIndex = 0
        Me.Mains_Button_Placeholder15.Text = "Placeholder"
        Me.Mains_Button_Placeholder15.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder15.Visible = False
        '
        'Mains_Button_Placeholder23
        '
        Me.Mains_Button_Placeholder23.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder23.Location = New System.Drawing.Point(685, 348)
        Me.Mains_Button_Placeholder23.Name = "Mains_Button_Placeholder23"
        Me.Mains_Button_Placeholder23.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder23.TabIndex = 0
        Me.Mains_Button_Placeholder23.Text = "Placeholder"
        Me.Mains_Button_Placeholder23.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder23.Visible = False
        '
        'Mains_Button_Placeholder14
        '
        Me.Mains_Button_Placeholder14.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder14.Location = New System.Drawing.Point(685, 182)
        Me.Mains_Button_Placeholder14.Name = "Mains_Button_Placeholder14"
        Me.Mains_Button_Placeholder14.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder14.TabIndex = 0
        Me.Mains_Button_Placeholder14.Text = "Placeholder"
        Me.Mains_Button_Placeholder14.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder14.Visible = False
        '
        'Mains_Button_Placeholder22
        '
        Me.Mains_Button_Placeholder22.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder22.Location = New System.Drawing.Point(519, 348)
        Me.Mains_Button_Placeholder22.Name = "Mains_Button_Placeholder22"
        Me.Mains_Button_Placeholder22.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder22.TabIndex = 0
        Me.Mains_Button_Placeholder22.Text = "Placeholder"
        Me.Mains_Button_Placeholder22.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder22.Visible = False
        '
        'Mains_Button_Placeholder13
        '
        Me.Mains_Button_Placeholder13.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder13.Location = New System.Drawing.Point(519, 182)
        Me.Mains_Button_Placeholder13.Name = "Mains_Button_Placeholder13"
        Me.Mains_Button_Placeholder13.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder13.TabIndex = 0
        Me.Mains_Button_Placeholder13.Text = "Placeholder"
        Me.Mains_Button_Placeholder13.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder13.Visible = False
        '
        'Mains_Button_Placeholder21
        '
        Me.Mains_Button_Placeholder21.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder21.Location = New System.Drawing.Point(353, 348)
        Me.Mains_Button_Placeholder21.Name = "Mains_Button_Placeholder21"
        Me.Mains_Button_Placeholder21.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder21.TabIndex = 0
        Me.Mains_Button_Placeholder21.Text = "Placeholder"
        Me.Mains_Button_Placeholder21.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder21.Visible = False
        '
        'Mains_Button_Placeholder12
        '
        Me.Mains_Button_Placeholder12.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder12.Location = New System.Drawing.Point(353, 182)
        Me.Mains_Button_Placeholder12.Name = "Mains_Button_Placeholder12"
        Me.Mains_Button_Placeholder12.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder12.TabIndex = 0
        Me.Mains_Button_Placeholder12.Text = "Placeholder"
        Me.Mains_Button_Placeholder12.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder12.Visible = False
        '
        'Mains_Button_Placeholder20
        '
        Me.Mains_Button_Placeholder20.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder20.Location = New System.Drawing.Point(187, 348)
        Me.Mains_Button_Placeholder20.Name = "Mains_Button_Placeholder20"
        Me.Mains_Button_Placeholder20.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder20.TabIndex = 0
        Me.Mains_Button_Placeholder20.Text = "Placeholder"
        Me.Mains_Button_Placeholder20.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder20.Visible = False
        '
        'Mains_Button_Placeholder11
        '
        Me.Mains_Button_Placeholder11.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder11.Location = New System.Drawing.Point(187, 182)
        Me.Mains_Button_Placeholder11.Name = "Mains_Button_Placeholder11"
        Me.Mains_Button_Placeholder11.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder11.TabIndex = 0
        Me.Mains_Button_Placeholder11.Text = "Placeholder"
        Me.Mains_Button_Placeholder11.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder11.Visible = False
        '
        'Mains_Button_Placeholder19
        '
        Me.Mains_Button_Placeholder19.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder19.Location = New System.Drawing.Point(21, 348)
        Me.Mains_Button_Placeholder19.Name = "Mains_Button_Placeholder19"
        Me.Mains_Button_Placeholder19.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder19.TabIndex = 0
        Me.Mains_Button_Placeholder19.Text = "Placeholder"
        Me.Mains_Button_Placeholder19.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder19.Visible = False
        '
        'Mains_Button_Placeholder10
        '
        Me.Mains_Button_Placeholder10.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder10.Location = New System.Drawing.Point(21, 182)
        Me.Mains_Button_Placeholder10.Name = "Mains_Button_Placeholder10"
        Me.Mains_Button_Placeholder10.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder10.TabIndex = 0
        Me.Mains_Button_Placeholder10.Text = "Placeholder"
        Me.Mains_Button_Placeholder10.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder10.Visible = False
        '
        'Mains_Button_Placeholder9
        '
        Me.Mains_Button_Placeholder9.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder9.Location = New System.Drawing.Point(1348, 16)
        Me.Mains_Button_Placeholder9.Name = "Mains_Button_Placeholder9"
        Me.Mains_Button_Placeholder9.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder9.TabIndex = 0
        Me.Mains_Button_Placeholder9.Text = "Placeholder"
        Me.Mains_Button_Placeholder9.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder9.Visible = False
        '
        'Mains_Button_Placeholder8
        '
        Me.Mains_Button_Placeholder8.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder8.Location = New System.Drawing.Point(1182, 16)
        Me.Mains_Button_Placeholder8.Name = "Mains_Button_Placeholder8"
        Me.Mains_Button_Placeholder8.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder8.TabIndex = 0
        Me.Mains_Button_Placeholder8.Text = "Placeholder"
        Me.Mains_Button_Placeholder8.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder8.Visible = False
        '
        'Mains_Button_Placeholder7
        '
        Me.Mains_Button_Placeholder7.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder7.Location = New System.Drawing.Point(1016, 16)
        Me.Mains_Button_Placeholder7.Name = "Mains_Button_Placeholder7"
        Me.Mains_Button_Placeholder7.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder7.TabIndex = 0
        Me.Mains_Button_Placeholder7.Text = "Placeholder"
        Me.Mains_Button_Placeholder7.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder7.Visible = False
        '
        'Mains_Button_Placeholder6
        '
        Me.Mains_Button_Placeholder6.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder6.Location = New System.Drawing.Point(850, 16)
        Me.Mains_Button_Placeholder6.Name = "Mains_Button_Placeholder6"
        Me.Mains_Button_Placeholder6.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder6.TabIndex = 0
        Me.Mains_Button_Placeholder6.Text = "Placeholder"
        Me.Mains_Button_Placeholder6.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder6.Visible = False
        '
        'Mains_Button_Placeholder5
        '
        Me.Mains_Button_Placeholder5.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder5.Location = New System.Drawing.Point(685, 16)
        Me.Mains_Button_Placeholder5.Name = "Mains_Button_Placeholder5"
        Me.Mains_Button_Placeholder5.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder5.TabIndex = 0
        Me.Mains_Button_Placeholder5.Text = "Placeholder"
        Me.Mains_Button_Placeholder5.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder5.Visible = False
        '
        'Mains_Button_Placeholder4
        '
        Me.Mains_Button_Placeholder4.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder4.Location = New System.Drawing.Point(519, 16)
        Me.Mains_Button_Placeholder4.Name = "Mains_Button_Placeholder4"
        Me.Mains_Button_Placeholder4.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder4.TabIndex = 0
        Me.Mains_Button_Placeholder4.Text = "Placeholder"
        Me.Mains_Button_Placeholder4.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder4.Visible = False
        '
        'Mains_Button_Placeholder3
        '
        Me.Mains_Button_Placeholder3.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder3.Location = New System.Drawing.Point(353, 16)
        Me.Mains_Button_Placeholder3.Name = "Mains_Button_Placeholder3"
        Me.Mains_Button_Placeholder3.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder3.TabIndex = 0
        Me.Mains_Button_Placeholder3.Text = "Placeholder"
        Me.Mains_Button_Placeholder3.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder3.Visible = False
        '
        'Mains_Button_Placeholder2
        '
        Me.Mains_Button_Placeholder2.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder2.Location = New System.Drawing.Point(187, 16)
        Me.Mains_Button_Placeholder2.Name = "Mains_Button_Placeholder2"
        Me.Mains_Button_Placeholder2.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder2.TabIndex = 0
        Me.Mains_Button_Placeholder2.Text = "Placeholder"
        Me.Mains_Button_Placeholder2.UseVisualStyleBackColor = True
        Me.Mains_Button_Placeholder2.Visible = False
        '
        'Mains_Button_Placeholder1
        '
        Me.Mains_Button_Placeholder1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Mains_Button_Placeholder1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mains_Button_Placeholder1.Location = New System.Drawing.Point(21, 16)
        Me.Mains_Button_Placeholder1.Name = "Mains_Button_Placeholder1"
        Me.Mains_Button_Placeholder1.Size = New System.Drawing.Size(160, 160)
        Me.Mains_Button_Placeholder1.TabIndex = 0
        Me.Mains_Button_Placeholder1.Text = "Placeholder"
        Me.Mains_Button_Placeholder1.UseVisualStyleBackColor = False
        Me.Mains_Button_Placeholder1.Visible = False
        '
        'Panel_CatBurgers
        '
        Me.Panel_CatBurgers.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder27)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder18)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder26)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder17)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder25)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder16)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder24)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder15)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder23)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder14)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder22)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder13)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder21)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder12)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder20)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder11)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder19)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder10)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder9)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder8)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder7)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder6)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder5)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder4)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder3)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder2)
        Me.Panel_CatBurgers.Controls.Add(Me.Burgers_Button_Placeholder1)
        Me.Panel_CatBurgers.Location = New System.Drawing.Point(9, 102)
        Me.Panel_CatBurgers.Name = "Panel_CatBurgers"
        Me.Panel_CatBurgers.Size = New System.Drawing.Size(1528, 614)
        Me.Panel_CatBurgers.TabIndex = 8
        '
        'Burgers_Button_Placeholder27
        '
        Me.Burgers_Button_Placeholder27.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder27.Location = New System.Drawing.Point(1348, 348)
        Me.Burgers_Button_Placeholder27.Name = "Burgers_Button_Placeholder27"
        Me.Burgers_Button_Placeholder27.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder27.TabIndex = 0
        Me.Burgers_Button_Placeholder27.Text = "Placeholder"
        Me.Burgers_Button_Placeholder27.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder27.Visible = False
        '
        'Burgers_Button_Placeholder18
        '
        Me.Burgers_Button_Placeholder18.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder18.Location = New System.Drawing.Point(1348, 182)
        Me.Burgers_Button_Placeholder18.Name = "Burgers_Button_Placeholder18"
        Me.Burgers_Button_Placeholder18.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder18.TabIndex = 0
        Me.Burgers_Button_Placeholder18.Text = "Placeholder"
        Me.Burgers_Button_Placeholder18.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder18.Visible = False
        '
        'Burgers_Button_Placeholder26
        '
        Me.Burgers_Button_Placeholder26.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder26.Location = New System.Drawing.Point(1182, 348)
        Me.Burgers_Button_Placeholder26.Name = "Burgers_Button_Placeholder26"
        Me.Burgers_Button_Placeholder26.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder26.TabIndex = 0
        Me.Burgers_Button_Placeholder26.Text = "Placeholder"
        Me.Burgers_Button_Placeholder26.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder26.Visible = False
        '
        'Burgers_Button_Placeholder17
        '
        Me.Burgers_Button_Placeholder17.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder17.Location = New System.Drawing.Point(1182, 182)
        Me.Burgers_Button_Placeholder17.Name = "Burgers_Button_Placeholder17"
        Me.Burgers_Button_Placeholder17.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder17.TabIndex = 0
        Me.Burgers_Button_Placeholder17.Text = "Placeholder"
        Me.Burgers_Button_Placeholder17.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder17.Visible = False
        '
        'Burgers_Button_Placeholder25
        '
        Me.Burgers_Button_Placeholder25.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder25.Location = New System.Drawing.Point(1016, 348)
        Me.Burgers_Button_Placeholder25.Name = "Burgers_Button_Placeholder25"
        Me.Burgers_Button_Placeholder25.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder25.TabIndex = 0
        Me.Burgers_Button_Placeholder25.Text = "Placeholder"
        Me.Burgers_Button_Placeholder25.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder25.Visible = False
        '
        'Burgers_Button_Placeholder16
        '
        Me.Burgers_Button_Placeholder16.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder16.Location = New System.Drawing.Point(1016, 182)
        Me.Burgers_Button_Placeholder16.Name = "Burgers_Button_Placeholder16"
        Me.Burgers_Button_Placeholder16.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder16.TabIndex = 0
        Me.Burgers_Button_Placeholder16.Text = "Placeholder"
        Me.Burgers_Button_Placeholder16.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder16.Visible = False
        '
        'Burgers_Button_Placeholder24
        '
        Me.Burgers_Button_Placeholder24.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder24.Location = New System.Drawing.Point(850, 348)
        Me.Burgers_Button_Placeholder24.Name = "Burgers_Button_Placeholder24"
        Me.Burgers_Button_Placeholder24.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder24.TabIndex = 0
        Me.Burgers_Button_Placeholder24.Text = "Placeholder"
        Me.Burgers_Button_Placeholder24.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder24.Visible = False
        '
        'Burgers_Button_Placeholder15
        '
        Me.Burgers_Button_Placeholder15.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder15.Location = New System.Drawing.Point(850, 182)
        Me.Burgers_Button_Placeholder15.Name = "Burgers_Button_Placeholder15"
        Me.Burgers_Button_Placeholder15.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder15.TabIndex = 0
        Me.Burgers_Button_Placeholder15.Text = "Placeholder"
        Me.Burgers_Button_Placeholder15.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder15.Visible = False
        '
        'Burgers_Button_Placeholder23
        '
        Me.Burgers_Button_Placeholder23.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder23.Location = New System.Drawing.Point(685, 348)
        Me.Burgers_Button_Placeholder23.Name = "Burgers_Button_Placeholder23"
        Me.Burgers_Button_Placeholder23.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder23.TabIndex = 0
        Me.Burgers_Button_Placeholder23.Text = "Placeholder"
        Me.Burgers_Button_Placeholder23.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder23.Visible = False
        '
        'Burgers_Button_Placeholder14
        '
        Me.Burgers_Button_Placeholder14.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder14.Location = New System.Drawing.Point(685, 182)
        Me.Burgers_Button_Placeholder14.Name = "Burgers_Button_Placeholder14"
        Me.Burgers_Button_Placeholder14.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder14.TabIndex = 0
        Me.Burgers_Button_Placeholder14.Text = "Placeholder"
        Me.Burgers_Button_Placeholder14.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder14.Visible = False
        '
        'Burgers_Button_Placeholder22
        '
        Me.Burgers_Button_Placeholder22.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder22.Location = New System.Drawing.Point(519, 348)
        Me.Burgers_Button_Placeholder22.Name = "Burgers_Button_Placeholder22"
        Me.Burgers_Button_Placeholder22.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder22.TabIndex = 0
        Me.Burgers_Button_Placeholder22.Text = "Placeholder"
        Me.Burgers_Button_Placeholder22.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder22.Visible = False
        '
        'Burgers_Button_Placeholder13
        '
        Me.Burgers_Button_Placeholder13.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder13.Location = New System.Drawing.Point(519, 182)
        Me.Burgers_Button_Placeholder13.Name = "Burgers_Button_Placeholder13"
        Me.Burgers_Button_Placeholder13.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder13.TabIndex = 0
        Me.Burgers_Button_Placeholder13.Text = "Placeholder"
        Me.Burgers_Button_Placeholder13.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder13.Visible = False
        '
        'Burgers_Button_Placeholder21
        '
        Me.Burgers_Button_Placeholder21.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder21.Location = New System.Drawing.Point(353, 348)
        Me.Burgers_Button_Placeholder21.Name = "Burgers_Button_Placeholder21"
        Me.Burgers_Button_Placeholder21.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder21.TabIndex = 0
        Me.Burgers_Button_Placeholder21.Text = "Placeholder"
        Me.Burgers_Button_Placeholder21.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder21.Visible = False
        '
        'Burgers_Button_Placeholder12
        '
        Me.Burgers_Button_Placeholder12.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder12.Location = New System.Drawing.Point(353, 182)
        Me.Burgers_Button_Placeholder12.Name = "Burgers_Button_Placeholder12"
        Me.Burgers_Button_Placeholder12.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder12.TabIndex = 0
        Me.Burgers_Button_Placeholder12.Text = "Placeholder"
        Me.Burgers_Button_Placeholder12.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder12.Visible = False
        '
        'Burgers_Button_Placeholder20
        '
        Me.Burgers_Button_Placeholder20.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder20.Location = New System.Drawing.Point(187, 348)
        Me.Burgers_Button_Placeholder20.Name = "Burgers_Button_Placeholder20"
        Me.Burgers_Button_Placeholder20.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder20.TabIndex = 0
        Me.Burgers_Button_Placeholder20.Text = "Placeholder"
        Me.Burgers_Button_Placeholder20.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder20.Visible = False
        '
        'Burgers_Button_Placeholder11
        '
        Me.Burgers_Button_Placeholder11.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder11.Location = New System.Drawing.Point(187, 182)
        Me.Burgers_Button_Placeholder11.Name = "Burgers_Button_Placeholder11"
        Me.Burgers_Button_Placeholder11.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder11.TabIndex = 0
        Me.Burgers_Button_Placeholder11.Text = "Placeholder"
        Me.Burgers_Button_Placeholder11.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder11.Visible = False
        '
        'Burgers_Button_Placeholder19
        '
        Me.Burgers_Button_Placeholder19.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder19.Location = New System.Drawing.Point(21, 348)
        Me.Burgers_Button_Placeholder19.Name = "Burgers_Button_Placeholder19"
        Me.Burgers_Button_Placeholder19.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder19.TabIndex = 0
        Me.Burgers_Button_Placeholder19.Text = "Placeholder"
        Me.Burgers_Button_Placeholder19.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder19.Visible = False
        '
        'Burgers_Button_Placeholder10
        '
        Me.Burgers_Button_Placeholder10.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder10.Location = New System.Drawing.Point(21, 182)
        Me.Burgers_Button_Placeholder10.Name = "Burgers_Button_Placeholder10"
        Me.Burgers_Button_Placeholder10.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder10.TabIndex = 0
        Me.Burgers_Button_Placeholder10.Text = "Placeholder"
        Me.Burgers_Button_Placeholder10.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder10.Visible = False
        '
        'Burgers_Button_Placeholder9
        '
        Me.Burgers_Button_Placeholder9.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder9.Location = New System.Drawing.Point(1348, 16)
        Me.Burgers_Button_Placeholder9.Name = "Burgers_Button_Placeholder9"
        Me.Burgers_Button_Placeholder9.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder9.TabIndex = 0
        Me.Burgers_Button_Placeholder9.Text = "Placeholder"
        Me.Burgers_Button_Placeholder9.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder9.Visible = False
        '
        'Burgers_Button_Placeholder8
        '
        Me.Burgers_Button_Placeholder8.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder8.Location = New System.Drawing.Point(1182, 16)
        Me.Burgers_Button_Placeholder8.Name = "Burgers_Button_Placeholder8"
        Me.Burgers_Button_Placeholder8.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder8.TabIndex = 0
        Me.Burgers_Button_Placeholder8.Text = "Placeholder"
        Me.Burgers_Button_Placeholder8.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder8.Visible = False
        '
        'Burgers_Button_Placeholder7
        '
        Me.Burgers_Button_Placeholder7.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder7.Location = New System.Drawing.Point(1016, 16)
        Me.Burgers_Button_Placeholder7.Name = "Burgers_Button_Placeholder7"
        Me.Burgers_Button_Placeholder7.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder7.TabIndex = 0
        Me.Burgers_Button_Placeholder7.Text = "Placeholder"
        Me.Burgers_Button_Placeholder7.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder7.Visible = False
        '
        'Burgers_Button_Placeholder6
        '
        Me.Burgers_Button_Placeholder6.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder6.Location = New System.Drawing.Point(850, 16)
        Me.Burgers_Button_Placeholder6.Name = "Burgers_Button_Placeholder6"
        Me.Burgers_Button_Placeholder6.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder6.TabIndex = 0
        Me.Burgers_Button_Placeholder6.Text = "Placeholder"
        Me.Burgers_Button_Placeholder6.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder6.Visible = False
        '
        'Burgers_Button_Placeholder5
        '
        Me.Burgers_Button_Placeholder5.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder5.Location = New System.Drawing.Point(685, 16)
        Me.Burgers_Button_Placeholder5.Name = "Burgers_Button_Placeholder5"
        Me.Burgers_Button_Placeholder5.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder5.TabIndex = 0
        Me.Burgers_Button_Placeholder5.Text = "Placeholder"
        Me.Burgers_Button_Placeholder5.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder5.Visible = False
        '
        'Burgers_Button_Placeholder4
        '
        Me.Burgers_Button_Placeholder4.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder4.Location = New System.Drawing.Point(519, 16)
        Me.Burgers_Button_Placeholder4.Name = "Burgers_Button_Placeholder4"
        Me.Burgers_Button_Placeholder4.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder4.TabIndex = 0
        Me.Burgers_Button_Placeholder4.Text = "Placeholder"
        Me.Burgers_Button_Placeholder4.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder4.Visible = False
        '
        'Burgers_Button_Placeholder3
        '
        Me.Burgers_Button_Placeholder3.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder3.Location = New System.Drawing.Point(353, 16)
        Me.Burgers_Button_Placeholder3.Name = "Burgers_Button_Placeholder3"
        Me.Burgers_Button_Placeholder3.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder3.TabIndex = 0
        Me.Burgers_Button_Placeholder3.Text = "Placeholder"
        Me.Burgers_Button_Placeholder3.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder3.Visible = False
        '
        'Burgers_Button_Placeholder2
        '
        Me.Burgers_Button_Placeholder2.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder2.Location = New System.Drawing.Point(187, 16)
        Me.Burgers_Button_Placeholder2.Name = "Burgers_Button_Placeholder2"
        Me.Burgers_Button_Placeholder2.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder2.TabIndex = 0
        Me.Burgers_Button_Placeholder2.Text = "Placeholder"
        Me.Burgers_Button_Placeholder2.UseVisualStyleBackColor = True
        Me.Burgers_Button_Placeholder2.Visible = False
        '
        'Burgers_Button_Placeholder1
        '
        Me.Burgers_Button_Placeholder1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Burgers_Button_Placeholder1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Burgers_Button_Placeholder1.Location = New System.Drawing.Point(21, 16)
        Me.Burgers_Button_Placeholder1.Name = "Burgers_Button_Placeholder1"
        Me.Burgers_Button_Placeholder1.Size = New System.Drawing.Size(160, 160)
        Me.Burgers_Button_Placeholder1.TabIndex = 0
        Me.Burgers_Button_Placeholder1.Text = "Placeholder"
        Me.Burgers_Button_Placeholder1.UseVisualStyleBackColor = False
        Me.Burgers_Button_Placeholder1.Visible = False
        '
        'Panel_CatKids
        '
        Me.Panel_CatKids.BackColor = System.Drawing.Color.LightBlue
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder27)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder18)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder26)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder17)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder25)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder16)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder24)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder15)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder23)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder14)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder22)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder13)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder21)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder12)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder20)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder11)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder19)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder10)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder9)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder8)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder7)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder6)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder5)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder4)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder3)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder2)
        Me.Panel_CatKids.Controls.Add(Me.Kids_Button_Placeholder1)
        Me.Panel_CatKids.Location = New System.Drawing.Point(9, 102)
        Me.Panel_CatKids.Name = "Panel_CatKids"
        Me.Panel_CatKids.Size = New System.Drawing.Size(1528, 614)
        Me.Panel_CatKids.TabIndex = 9
        '
        'Kids_Button_Placeholder27
        '
        Me.Kids_Button_Placeholder27.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder27.Location = New System.Drawing.Point(1348, 348)
        Me.Kids_Button_Placeholder27.Name = "Kids_Button_Placeholder27"
        Me.Kids_Button_Placeholder27.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder27.TabIndex = 0
        Me.Kids_Button_Placeholder27.Text = "Placeholder"
        Me.Kids_Button_Placeholder27.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder27.Visible = False
        '
        'Kids_Button_Placeholder18
        '
        Me.Kids_Button_Placeholder18.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder18.Location = New System.Drawing.Point(1348, 182)
        Me.Kids_Button_Placeholder18.Name = "Kids_Button_Placeholder18"
        Me.Kids_Button_Placeholder18.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder18.TabIndex = 0
        Me.Kids_Button_Placeholder18.Text = "Placeholder"
        Me.Kids_Button_Placeholder18.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder18.Visible = False
        '
        'Kids_Button_Placeholder26
        '
        Me.Kids_Button_Placeholder26.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder26.Location = New System.Drawing.Point(1182, 348)
        Me.Kids_Button_Placeholder26.Name = "Kids_Button_Placeholder26"
        Me.Kids_Button_Placeholder26.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder26.TabIndex = 0
        Me.Kids_Button_Placeholder26.Text = "Placeholder"
        Me.Kids_Button_Placeholder26.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder26.Visible = False
        '
        'Kids_Button_Placeholder17
        '
        Me.Kids_Button_Placeholder17.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder17.Location = New System.Drawing.Point(1182, 182)
        Me.Kids_Button_Placeholder17.Name = "Kids_Button_Placeholder17"
        Me.Kids_Button_Placeholder17.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder17.TabIndex = 0
        Me.Kids_Button_Placeholder17.Text = "Placeholder"
        Me.Kids_Button_Placeholder17.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder17.Visible = False
        '
        'Kids_Button_Placeholder25
        '
        Me.Kids_Button_Placeholder25.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder25.Location = New System.Drawing.Point(1016, 348)
        Me.Kids_Button_Placeholder25.Name = "Kids_Button_Placeholder25"
        Me.Kids_Button_Placeholder25.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder25.TabIndex = 0
        Me.Kids_Button_Placeholder25.Text = "Placeholder"
        Me.Kids_Button_Placeholder25.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder25.Visible = False
        '
        'Kids_Button_Placeholder16
        '
        Me.Kids_Button_Placeholder16.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder16.Location = New System.Drawing.Point(1016, 182)
        Me.Kids_Button_Placeholder16.Name = "Kids_Button_Placeholder16"
        Me.Kids_Button_Placeholder16.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder16.TabIndex = 0
        Me.Kids_Button_Placeholder16.Text = "Placeholder"
        Me.Kids_Button_Placeholder16.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder16.Visible = False
        '
        'Kids_Button_Placeholder24
        '
        Me.Kids_Button_Placeholder24.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder24.Location = New System.Drawing.Point(850, 348)
        Me.Kids_Button_Placeholder24.Name = "Kids_Button_Placeholder24"
        Me.Kids_Button_Placeholder24.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder24.TabIndex = 0
        Me.Kids_Button_Placeholder24.Text = "Placeholder"
        Me.Kids_Button_Placeholder24.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder24.Visible = False
        '
        'Kids_Button_Placeholder15
        '
        Me.Kids_Button_Placeholder15.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder15.Location = New System.Drawing.Point(850, 182)
        Me.Kids_Button_Placeholder15.Name = "Kids_Button_Placeholder15"
        Me.Kids_Button_Placeholder15.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder15.TabIndex = 0
        Me.Kids_Button_Placeholder15.Text = "Placeholder"
        Me.Kids_Button_Placeholder15.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder15.Visible = False
        '
        'Kids_Button_Placeholder23
        '
        Me.Kids_Button_Placeholder23.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder23.Location = New System.Drawing.Point(685, 348)
        Me.Kids_Button_Placeholder23.Name = "Kids_Button_Placeholder23"
        Me.Kids_Button_Placeholder23.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder23.TabIndex = 0
        Me.Kids_Button_Placeholder23.Text = "Placeholder"
        Me.Kids_Button_Placeholder23.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder23.Visible = False
        '
        'Kids_Button_Placeholder14
        '
        Me.Kids_Button_Placeholder14.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder14.Location = New System.Drawing.Point(685, 182)
        Me.Kids_Button_Placeholder14.Name = "Kids_Button_Placeholder14"
        Me.Kids_Button_Placeholder14.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder14.TabIndex = 0
        Me.Kids_Button_Placeholder14.Text = "Placeholder"
        Me.Kids_Button_Placeholder14.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder14.Visible = False
        '
        'Kids_Button_Placeholder22
        '
        Me.Kids_Button_Placeholder22.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder22.Location = New System.Drawing.Point(519, 348)
        Me.Kids_Button_Placeholder22.Name = "Kids_Button_Placeholder22"
        Me.Kids_Button_Placeholder22.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder22.TabIndex = 0
        Me.Kids_Button_Placeholder22.Text = "Placeholder"
        Me.Kids_Button_Placeholder22.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder22.Visible = False
        '
        'Kids_Button_Placeholder13
        '
        Me.Kids_Button_Placeholder13.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder13.Location = New System.Drawing.Point(519, 182)
        Me.Kids_Button_Placeholder13.Name = "Kids_Button_Placeholder13"
        Me.Kids_Button_Placeholder13.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder13.TabIndex = 0
        Me.Kids_Button_Placeholder13.Text = "Placeholder"
        Me.Kids_Button_Placeholder13.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder13.Visible = False
        '
        'Kids_Button_Placeholder21
        '
        Me.Kids_Button_Placeholder21.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder21.Location = New System.Drawing.Point(353, 348)
        Me.Kids_Button_Placeholder21.Name = "Kids_Button_Placeholder21"
        Me.Kids_Button_Placeholder21.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder21.TabIndex = 0
        Me.Kids_Button_Placeholder21.Text = "Placeholder"
        Me.Kids_Button_Placeholder21.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder21.Visible = False
        '
        'Kids_Button_Placeholder12
        '
        Me.Kids_Button_Placeholder12.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder12.Location = New System.Drawing.Point(353, 182)
        Me.Kids_Button_Placeholder12.Name = "Kids_Button_Placeholder12"
        Me.Kids_Button_Placeholder12.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder12.TabIndex = 0
        Me.Kids_Button_Placeholder12.Text = "Placeholder"
        Me.Kids_Button_Placeholder12.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder12.Visible = False
        '
        'Kids_Button_Placeholder20
        '
        Me.Kids_Button_Placeholder20.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder20.Location = New System.Drawing.Point(187, 348)
        Me.Kids_Button_Placeholder20.Name = "Kids_Button_Placeholder20"
        Me.Kids_Button_Placeholder20.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder20.TabIndex = 0
        Me.Kids_Button_Placeholder20.Text = "Placeholder"
        Me.Kids_Button_Placeholder20.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder20.Visible = False
        '
        'Kids_Button_Placeholder11
        '
        Me.Kids_Button_Placeholder11.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder11.Location = New System.Drawing.Point(187, 182)
        Me.Kids_Button_Placeholder11.Name = "Kids_Button_Placeholder11"
        Me.Kids_Button_Placeholder11.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder11.TabIndex = 0
        Me.Kids_Button_Placeholder11.Text = "Placeholder"
        Me.Kids_Button_Placeholder11.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder11.Visible = False
        '
        'Kids_Button_Placeholder19
        '
        Me.Kids_Button_Placeholder19.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder19.Location = New System.Drawing.Point(21, 348)
        Me.Kids_Button_Placeholder19.Name = "Kids_Button_Placeholder19"
        Me.Kids_Button_Placeholder19.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder19.TabIndex = 0
        Me.Kids_Button_Placeholder19.Text = "Placeholder"
        Me.Kids_Button_Placeholder19.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder19.Visible = False
        '
        'Kids_Button_Placeholder10
        '
        Me.Kids_Button_Placeholder10.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder10.Location = New System.Drawing.Point(21, 182)
        Me.Kids_Button_Placeholder10.Name = "Kids_Button_Placeholder10"
        Me.Kids_Button_Placeholder10.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder10.TabIndex = 0
        Me.Kids_Button_Placeholder10.Text = "Placeholder"
        Me.Kids_Button_Placeholder10.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder10.Visible = False
        '
        'Kids_Button_Placeholder9
        '
        Me.Kids_Button_Placeholder9.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder9.Location = New System.Drawing.Point(1348, 16)
        Me.Kids_Button_Placeholder9.Name = "Kids_Button_Placeholder9"
        Me.Kids_Button_Placeholder9.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder9.TabIndex = 0
        Me.Kids_Button_Placeholder9.Text = "Placeholder"
        Me.Kids_Button_Placeholder9.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder9.Visible = False
        '
        'Kids_Button_Placeholder8
        '
        Me.Kids_Button_Placeholder8.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder8.Location = New System.Drawing.Point(1182, 16)
        Me.Kids_Button_Placeholder8.Name = "Kids_Button_Placeholder8"
        Me.Kids_Button_Placeholder8.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder8.TabIndex = 0
        Me.Kids_Button_Placeholder8.Text = "Placeholder"
        Me.Kids_Button_Placeholder8.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder8.Visible = False
        '
        'Kids_Button_Placeholder7
        '
        Me.Kids_Button_Placeholder7.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder7.Location = New System.Drawing.Point(1016, 16)
        Me.Kids_Button_Placeholder7.Name = "Kids_Button_Placeholder7"
        Me.Kids_Button_Placeholder7.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder7.TabIndex = 0
        Me.Kids_Button_Placeholder7.Text = "Placeholder"
        Me.Kids_Button_Placeholder7.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder7.Visible = False
        '
        'Kids_Button_Placeholder6
        '
        Me.Kids_Button_Placeholder6.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder6.Location = New System.Drawing.Point(850, 16)
        Me.Kids_Button_Placeholder6.Name = "Kids_Button_Placeholder6"
        Me.Kids_Button_Placeholder6.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder6.TabIndex = 0
        Me.Kids_Button_Placeholder6.Text = "Placeholder"
        Me.Kids_Button_Placeholder6.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder6.Visible = False
        '
        'Kids_Button_Placeholder5
        '
        Me.Kids_Button_Placeholder5.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder5.Location = New System.Drawing.Point(685, 16)
        Me.Kids_Button_Placeholder5.Name = "Kids_Button_Placeholder5"
        Me.Kids_Button_Placeholder5.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder5.TabIndex = 0
        Me.Kids_Button_Placeholder5.Text = "Placeholder"
        Me.Kids_Button_Placeholder5.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder5.Visible = False
        '
        'Kids_Button_Placeholder4
        '
        Me.Kids_Button_Placeholder4.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder4.Location = New System.Drawing.Point(519, 16)
        Me.Kids_Button_Placeholder4.Name = "Kids_Button_Placeholder4"
        Me.Kids_Button_Placeholder4.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder4.TabIndex = 0
        Me.Kids_Button_Placeholder4.Text = "Placeholder"
        Me.Kids_Button_Placeholder4.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder4.Visible = False
        '
        'Kids_Button_Placeholder3
        '
        Me.Kids_Button_Placeholder3.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder3.Location = New System.Drawing.Point(353, 16)
        Me.Kids_Button_Placeholder3.Name = "Kids_Button_Placeholder3"
        Me.Kids_Button_Placeholder3.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder3.TabIndex = 0
        Me.Kids_Button_Placeholder3.Text = "Placeholder"
        Me.Kids_Button_Placeholder3.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder3.Visible = False
        '
        'Kids_Button_Placeholder2
        '
        Me.Kids_Button_Placeholder2.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder2.Location = New System.Drawing.Point(187, 16)
        Me.Kids_Button_Placeholder2.Name = "Kids_Button_Placeholder2"
        Me.Kids_Button_Placeholder2.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder2.TabIndex = 0
        Me.Kids_Button_Placeholder2.Text = "Placeholder"
        Me.Kids_Button_Placeholder2.UseVisualStyleBackColor = True
        Me.Kids_Button_Placeholder2.Visible = False
        '
        'Kids_Button_Placeholder1
        '
        Me.Kids_Button_Placeholder1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Kids_Button_Placeholder1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kids_Button_Placeholder1.Location = New System.Drawing.Point(21, 16)
        Me.Kids_Button_Placeholder1.Name = "Kids_Button_Placeholder1"
        Me.Kids_Button_Placeholder1.Size = New System.Drawing.Size(160, 160)
        Me.Kids_Button_Placeholder1.TabIndex = 0
        Me.Kids_Button_Placeholder1.Text = "Placeholder"
        Me.Kids_Button_Placeholder1.UseVisualStyleBackColor = False
        Me.Kids_Button_Placeholder1.Visible = False
        '
        'Panel_CatDesserts
        '
        Me.Panel_CatDesserts.BackColor = System.Drawing.Color.SkyBlue
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder27)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder18)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder26)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder17)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder25)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder16)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder24)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder15)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder23)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder14)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder22)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder13)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder21)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder12)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder20)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder11)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder19)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder10)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder9)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder8)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder7)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder6)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder5)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder4)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder3)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder2)
        Me.Panel_CatDesserts.Controls.Add(Me.Desserts_Button_Placeholder1)
        Me.Panel_CatDesserts.Location = New System.Drawing.Point(9, 102)
        Me.Panel_CatDesserts.Name = "Panel_CatDesserts"
        Me.Panel_CatDesserts.Size = New System.Drawing.Size(1528, 614)
        Me.Panel_CatDesserts.TabIndex = 10
        '
        'Desserts_Button_Placeholder27
        '
        Me.Desserts_Button_Placeholder27.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder27.Location = New System.Drawing.Point(1348, 348)
        Me.Desserts_Button_Placeholder27.Name = "Desserts_Button_Placeholder27"
        Me.Desserts_Button_Placeholder27.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder27.TabIndex = 0
        Me.Desserts_Button_Placeholder27.Text = "Placeholder"
        Me.Desserts_Button_Placeholder27.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder27.Visible = False
        '
        'Desserts_Button_Placeholder18
        '
        Me.Desserts_Button_Placeholder18.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder18.Location = New System.Drawing.Point(1348, 182)
        Me.Desserts_Button_Placeholder18.Name = "Desserts_Button_Placeholder18"
        Me.Desserts_Button_Placeholder18.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder18.TabIndex = 0
        Me.Desserts_Button_Placeholder18.Text = "Placeholder"
        Me.Desserts_Button_Placeholder18.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder18.Visible = False
        '
        'Desserts_Button_Placeholder26
        '
        Me.Desserts_Button_Placeholder26.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder26.Location = New System.Drawing.Point(1182, 348)
        Me.Desserts_Button_Placeholder26.Name = "Desserts_Button_Placeholder26"
        Me.Desserts_Button_Placeholder26.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder26.TabIndex = 0
        Me.Desserts_Button_Placeholder26.Text = "Placeholder"
        Me.Desserts_Button_Placeholder26.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder26.Visible = False
        '
        'Desserts_Button_Placeholder17
        '
        Me.Desserts_Button_Placeholder17.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder17.Location = New System.Drawing.Point(1182, 182)
        Me.Desserts_Button_Placeholder17.Name = "Desserts_Button_Placeholder17"
        Me.Desserts_Button_Placeholder17.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder17.TabIndex = 0
        Me.Desserts_Button_Placeholder17.Text = "Placeholder"
        Me.Desserts_Button_Placeholder17.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder17.Visible = False
        '
        'Desserts_Button_Placeholder25
        '
        Me.Desserts_Button_Placeholder25.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder25.Location = New System.Drawing.Point(1016, 348)
        Me.Desserts_Button_Placeholder25.Name = "Desserts_Button_Placeholder25"
        Me.Desserts_Button_Placeholder25.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder25.TabIndex = 0
        Me.Desserts_Button_Placeholder25.Text = "Placeholder"
        Me.Desserts_Button_Placeholder25.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder25.Visible = False
        '
        'Desserts_Button_Placeholder16
        '
        Me.Desserts_Button_Placeholder16.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder16.Location = New System.Drawing.Point(1016, 182)
        Me.Desserts_Button_Placeholder16.Name = "Desserts_Button_Placeholder16"
        Me.Desserts_Button_Placeholder16.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder16.TabIndex = 0
        Me.Desserts_Button_Placeholder16.Text = "Placeholder"
        Me.Desserts_Button_Placeholder16.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder16.Visible = False
        '
        'Desserts_Button_Placeholder24
        '
        Me.Desserts_Button_Placeholder24.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder24.Location = New System.Drawing.Point(850, 348)
        Me.Desserts_Button_Placeholder24.Name = "Desserts_Button_Placeholder24"
        Me.Desserts_Button_Placeholder24.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder24.TabIndex = 0
        Me.Desserts_Button_Placeholder24.Text = "Placeholder"
        Me.Desserts_Button_Placeholder24.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder24.Visible = False
        '
        'Desserts_Button_Placeholder15
        '
        Me.Desserts_Button_Placeholder15.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder15.Location = New System.Drawing.Point(850, 182)
        Me.Desserts_Button_Placeholder15.Name = "Desserts_Button_Placeholder15"
        Me.Desserts_Button_Placeholder15.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder15.TabIndex = 0
        Me.Desserts_Button_Placeholder15.Text = "Placeholder"
        Me.Desserts_Button_Placeholder15.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder15.Visible = False
        '
        'Desserts_Button_Placeholder23
        '
        Me.Desserts_Button_Placeholder23.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder23.Location = New System.Drawing.Point(685, 348)
        Me.Desserts_Button_Placeholder23.Name = "Desserts_Button_Placeholder23"
        Me.Desserts_Button_Placeholder23.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder23.TabIndex = 0
        Me.Desserts_Button_Placeholder23.Text = "Placeholder"
        Me.Desserts_Button_Placeholder23.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder23.Visible = False
        '
        'Desserts_Button_Placeholder14
        '
        Me.Desserts_Button_Placeholder14.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder14.Location = New System.Drawing.Point(685, 182)
        Me.Desserts_Button_Placeholder14.Name = "Desserts_Button_Placeholder14"
        Me.Desserts_Button_Placeholder14.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder14.TabIndex = 0
        Me.Desserts_Button_Placeholder14.Text = "Placeholder"
        Me.Desserts_Button_Placeholder14.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder14.Visible = False
        '
        'Desserts_Button_Placeholder22
        '
        Me.Desserts_Button_Placeholder22.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder22.Location = New System.Drawing.Point(519, 348)
        Me.Desserts_Button_Placeholder22.Name = "Desserts_Button_Placeholder22"
        Me.Desserts_Button_Placeholder22.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder22.TabIndex = 0
        Me.Desserts_Button_Placeholder22.Text = "Placeholder"
        Me.Desserts_Button_Placeholder22.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder22.Visible = False
        '
        'Desserts_Button_Placeholder13
        '
        Me.Desserts_Button_Placeholder13.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder13.Location = New System.Drawing.Point(519, 182)
        Me.Desserts_Button_Placeholder13.Name = "Desserts_Button_Placeholder13"
        Me.Desserts_Button_Placeholder13.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder13.TabIndex = 0
        Me.Desserts_Button_Placeholder13.Text = "Placeholder"
        Me.Desserts_Button_Placeholder13.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder13.Visible = False
        '
        'Desserts_Button_Placeholder21
        '
        Me.Desserts_Button_Placeholder21.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder21.Location = New System.Drawing.Point(353, 348)
        Me.Desserts_Button_Placeholder21.Name = "Desserts_Button_Placeholder21"
        Me.Desserts_Button_Placeholder21.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder21.TabIndex = 0
        Me.Desserts_Button_Placeholder21.Text = "Placeholder"
        Me.Desserts_Button_Placeholder21.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder21.Visible = False
        '
        'Desserts_Button_Placeholder12
        '
        Me.Desserts_Button_Placeholder12.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder12.Location = New System.Drawing.Point(353, 182)
        Me.Desserts_Button_Placeholder12.Name = "Desserts_Button_Placeholder12"
        Me.Desserts_Button_Placeholder12.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder12.TabIndex = 0
        Me.Desserts_Button_Placeholder12.Text = "Placeholder"
        Me.Desserts_Button_Placeholder12.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder12.Visible = False
        '
        'Desserts_Button_Placeholder20
        '
        Me.Desserts_Button_Placeholder20.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder20.Location = New System.Drawing.Point(187, 348)
        Me.Desserts_Button_Placeholder20.Name = "Desserts_Button_Placeholder20"
        Me.Desserts_Button_Placeholder20.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder20.TabIndex = 0
        Me.Desserts_Button_Placeholder20.Text = "Placeholder"
        Me.Desserts_Button_Placeholder20.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder20.Visible = False
        '
        'Desserts_Button_Placeholder11
        '
        Me.Desserts_Button_Placeholder11.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder11.Location = New System.Drawing.Point(187, 182)
        Me.Desserts_Button_Placeholder11.Name = "Desserts_Button_Placeholder11"
        Me.Desserts_Button_Placeholder11.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder11.TabIndex = 0
        Me.Desserts_Button_Placeholder11.Text = "Placeholder"
        Me.Desserts_Button_Placeholder11.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder11.Visible = False
        '
        'Desserts_Button_Placeholder19
        '
        Me.Desserts_Button_Placeholder19.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder19.Location = New System.Drawing.Point(21, 348)
        Me.Desserts_Button_Placeholder19.Name = "Desserts_Button_Placeholder19"
        Me.Desserts_Button_Placeholder19.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder19.TabIndex = 0
        Me.Desserts_Button_Placeholder19.Text = "Placeholder"
        Me.Desserts_Button_Placeholder19.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder19.Visible = False
        '
        'Desserts_Button_Placeholder10
        '
        Me.Desserts_Button_Placeholder10.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder10.Location = New System.Drawing.Point(21, 182)
        Me.Desserts_Button_Placeholder10.Name = "Desserts_Button_Placeholder10"
        Me.Desserts_Button_Placeholder10.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder10.TabIndex = 0
        Me.Desserts_Button_Placeholder10.Text = "Placeholder"
        Me.Desserts_Button_Placeholder10.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder10.Visible = False
        '
        'Desserts_Button_Placeholder9
        '
        Me.Desserts_Button_Placeholder9.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder9.Location = New System.Drawing.Point(1348, 16)
        Me.Desserts_Button_Placeholder9.Name = "Desserts_Button_Placeholder9"
        Me.Desserts_Button_Placeholder9.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder9.TabIndex = 0
        Me.Desserts_Button_Placeholder9.Text = "Placeholder"
        Me.Desserts_Button_Placeholder9.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder9.Visible = False
        '
        'Desserts_Button_Placeholder8
        '
        Me.Desserts_Button_Placeholder8.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder8.Location = New System.Drawing.Point(1182, 16)
        Me.Desserts_Button_Placeholder8.Name = "Desserts_Button_Placeholder8"
        Me.Desserts_Button_Placeholder8.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder8.TabIndex = 0
        Me.Desserts_Button_Placeholder8.Text = "Placeholder"
        Me.Desserts_Button_Placeholder8.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder8.Visible = False
        '
        'Desserts_Button_Placeholder7
        '
        Me.Desserts_Button_Placeholder7.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder7.Location = New System.Drawing.Point(1016, 16)
        Me.Desserts_Button_Placeholder7.Name = "Desserts_Button_Placeholder7"
        Me.Desserts_Button_Placeholder7.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder7.TabIndex = 0
        Me.Desserts_Button_Placeholder7.Text = "Placeholder"
        Me.Desserts_Button_Placeholder7.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder7.Visible = False
        '
        'Desserts_Button_Placeholder6
        '
        Me.Desserts_Button_Placeholder6.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder6.Location = New System.Drawing.Point(850, 16)
        Me.Desserts_Button_Placeholder6.Name = "Desserts_Button_Placeholder6"
        Me.Desserts_Button_Placeholder6.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder6.TabIndex = 0
        Me.Desserts_Button_Placeholder6.Text = "Placeholder"
        Me.Desserts_Button_Placeholder6.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder6.Visible = False
        '
        'Desserts_Button_Placeholder5
        '
        Me.Desserts_Button_Placeholder5.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder5.Location = New System.Drawing.Point(685, 16)
        Me.Desserts_Button_Placeholder5.Name = "Desserts_Button_Placeholder5"
        Me.Desserts_Button_Placeholder5.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder5.TabIndex = 0
        Me.Desserts_Button_Placeholder5.Text = "Placeholder"
        Me.Desserts_Button_Placeholder5.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder5.Visible = False
        '
        'Desserts_Button_Placeholder4
        '
        Me.Desserts_Button_Placeholder4.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder4.Location = New System.Drawing.Point(519, 16)
        Me.Desserts_Button_Placeholder4.Name = "Desserts_Button_Placeholder4"
        Me.Desserts_Button_Placeholder4.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder4.TabIndex = 0
        Me.Desserts_Button_Placeholder4.Text = "Placeholder"
        Me.Desserts_Button_Placeholder4.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder4.Visible = False
        '
        'Desserts_Button_Placeholder3
        '
        Me.Desserts_Button_Placeholder3.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder3.Location = New System.Drawing.Point(353, 16)
        Me.Desserts_Button_Placeholder3.Name = "Desserts_Button_Placeholder3"
        Me.Desserts_Button_Placeholder3.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder3.TabIndex = 0
        Me.Desserts_Button_Placeholder3.Text = "Placeholder"
        Me.Desserts_Button_Placeholder3.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder3.Visible = False
        '
        'Desserts_Button_Placeholder2
        '
        Me.Desserts_Button_Placeholder2.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder2.Location = New System.Drawing.Point(187, 16)
        Me.Desserts_Button_Placeholder2.Name = "Desserts_Button_Placeholder2"
        Me.Desserts_Button_Placeholder2.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder2.TabIndex = 0
        Me.Desserts_Button_Placeholder2.Text = "Placeholder"
        Me.Desserts_Button_Placeholder2.UseVisualStyleBackColor = True
        Me.Desserts_Button_Placeholder2.Visible = False
        '
        'Desserts_Button_Placeholder1
        '
        Me.Desserts_Button_Placeholder1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Desserts_Button_Placeholder1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Desserts_Button_Placeholder1.Location = New System.Drawing.Point(21, 16)
        Me.Desserts_Button_Placeholder1.Name = "Desserts_Button_Placeholder1"
        Me.Desserts_Button_Placeholder1.Size = New System.Drawing.Size(160, 160)
        Me.Desserts_Button_Placeholder1.TabIndex = 0
        Me.Desserts_Button_Placeholder1.Text = "Placeholder"
        Me.Desserts_Button_Placeholder1.UseVisualStyleBackColor = False
        Me.Desserts_Button_Placeholder1.Visible = False
        '
        'Panel_CatSalads
        '
        Me.Panel_CatSalads.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder27)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder18)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder26)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder17)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder25)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder16)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder24)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder15)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder23)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder14)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder22)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder13)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder21)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder12)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder20)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder11)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder19)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder10)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder9)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder8)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder7)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder6)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder5)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder4)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder3)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder2)
        Me.Panel_CatSalads.Controls.Add(Me.Salads_Button_Placeholder1)
        Me.Panel_CatSalads.Location = New System.Drawing.Point(9, 102)
        Me.Panel_CatSalads.Name = "Panel_CatSalads"
        Me.Panel_CatSalads.Size = New System.Drawing.Size(1528, 614)
        Me.Panel_CatSalads.TabIndex = 11
        '
        'Salads_Button_Placeholder27
        '
        Me.Salads_Button_Placeholder27.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder27.Location = New System.Drawing.Point(1348, 348)
        Me.Salads_Button_Placeholder27.Name = "Salads_Button_Placeholder27"
        Me.Salads_Button_Placeholder27.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder27.TabIndex = 0
        Me.Salads_Button_Placeholder27.Text = "Placeholder"
        Me.Salads_Button_Placeholder27.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder27.Visible = False
        '
        'Salads_Button_Placeholder18
        '
        Me.Salads_Button_Placeholder18.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder18.Location = New System.Drawing.Point(1348, 182)
        Me.Salads_Button_Placeholder18.Name = "Salads_Button_Placeholder18"
        Me.Salads_Button_Placeholder18.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder18.TabIndex = 0
        Me.Salads_Button_Placeholder18.Text = "Placeholder"
        Me.Salads_Button_Placeholder18.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder18.Visible = False
        '
        'Salads_Button_Placeholder26
        '
        Me.Salads_Button_Placeholder26.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder26.Location = New System.Drawing.Point(1182, 348)
        Me.Salads_Button_Placeholder26.Name = "Salads_Button_Placeholder26"
        Me.Salads_Button_Placeholder26.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder26.TabIndex = 0
        Me.Salads_Button_Placeholder26.Text = "Placeholder"
        Me.Salads_Button_Placeholder26.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder26.Visible = False
        '
        'Salads_Button_Placeholder17
        '
        Me.Salads_Button_Placeholder17.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder17.Location = New System.Drawing.Point(1182, 182)
        Me.Salads_Button_Placeholder17.Name = "Salads_Button_Placeholder17"
        Me.Salads_Button_Placeholder17.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder17.TabIndex = 0
        Me.Salads_Button_Placeholder17.Text = "Placeholder"
        Me.Salads_Button_Placeholder17.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder17.Visible = False
        '
        'Salads_Button_Placeholder25
        '
        Me.Salads_Button_Placeholder25.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder25.Location = New System.Drawing.Point(1016, 348)
        Me.Salads_Button_Placeholder25.Name = "Salads_Button_Placeholder25"
        Me.Salads_Button_Placeholder25.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder25.TabIndex = 0
        Me.Salads_Button_Placeholder25.Text = "Placeholder"
        Me.Salads_Button_Placeholder25.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder25.Visible = False
        '
        'Salads_Button_Placeholder16
        '
        Me.Salads_Button_Placeholder16.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder16.Location = New System.Drawing.Point(1016, 182)
        Me.Salads_Button_Placeholder16.Name = "Salads_Button_Placeholder16"
        Me.Salads_Button_Placeholder16.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder16.TabIndex = 0
        Me.Salads_Button_Placeholder16.Text = "Placeholder"
        Me.Salads_Button_Placeholder16.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder16.Visible = False
        '
        'Salads_Button_Placeholder24
        '
        Me.Salads_Button_Placeholder24.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder24.Location = New System.Drawing.Point(850, 348)
        Me.Salads_Button_Placeholder24.Name = "Salads_Button_Placeholder24"
        Me.Salads_Button_Placeholder24.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder24.TabIndex = 0
        Me.Salads_Button_Placeholder24.Text = "Placeholder"
        Me.Salads_Button_Placeholder24.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder24.Visible = False
        '
        'Salads_Button_Placeholder15
        '
        Me.Salads_Button_Placeholder15.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder15.Location = New System.Drawing.Point(850, 182)
        Me.Salads_Button_Placeholder15.Name = "Salads_Button_Placeholder15"
        Me.Salads_Button_Placeholder15.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder15.TabIndex = 0
        Me.Salads_Button_Placeholder15.Text = "Placeholder"
        Me.Salads_Button_Placeholder15.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder15.Visible = False
        '
        'Salads_Button_Placeholder23
        '
        Me.Salads_Button_Placeholder23.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder23.Location = New System.Drawing.Point(685, 348)
        Me.Salads_Button_Placeholder23.Name = "Salads_Button_Placeholder23"
        Me.Salads_Button_Placeholder23.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder23.TabIndex = 0
        Me.Salads_Button_Placeholder23.Text = "Placeholder"
        Me.Salads_Button_Placeholder23.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder23.Visible = False
        '
        'Salads_Button_Placeholder14
        '
        Me.Salads_Button_Placeholder14.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder14.Location = New System.Drawing.Point(685, 182)
        Me.Salads_Button_Placeholder14.Name = "Salads_Button_Placeholder14"
        Me.Salads_Button_Placeholder14.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder14.TabIndex = 0
        Me.Salads_Button_Placeholder14.Text = "Placeholder"
        Me.Salads_Button_Placeholder14.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder14.Visible = False
        '
        'Salads_Button_Placeholder22
        '
        Me.Salads_Button_Placeholder22.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder22.Location = New System.Drawing.Point(519, 348)
        Me.Salads_Button_Placeholder22.Name = "Salads_Button_Placeholder22"
        Me.Salads_Button_Placeholder22.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder22.TabIndex = 0
        Me.Salads_Button_Placeholder22.Text = "Placeholder"
        Me.Salads_Button_Placeholder22.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder22.Visible = False
        '
        'Salads_Button_Placeholder13
        '
        Me.Salads_Button_Placeholder13.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder13.Location = New System.Drawing.Point(519, 182)
        Me.Salads_Button_Placeholder13.Name = "Salads_Button_Placeholder13"
        Me.Salads_Button_Placeholder13.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder13.TabIndex = 0
        Me.Salads_Button_Placeholder13.Text = "Placeholder"
        Me.Salads_Button_Placeholder13.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder13.Visible = False
        '
        'Salads_Button_Placeholder21
        '
        Me.Salads_Button_Placeholder21.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder21.Location = New System.Drawing.Point(353, 348)
        Me.Salads_Button_Placeholder21.Name = "Salads_Button_Placeholder21"
        Me.Salads_Button_Placeholder21.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder21.TabIndex = 0
        Me.Salads_Button_Placeholder21.Text = "Placeholder"
        Me.Salads_Button_Placeholder21.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder21.Visible = False
        '
        'Salads_Button_Placeholder12
        '
        Me.Salads_Button_Placeholder12.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder12.Location = New System.Drawing.Point(353, 182)
        Me.Salads_Button_Placeholder12.Name = "Salads_Button_Placeholder12"
        Me.Salads_Button_Placeholder12.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder12.TabIndex = 0
        Me.Salads_Button_Placeholder12.Text = "Placeholder"
        Me.Salads_Button_Placeholder12.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder12.Visible = False
        '
        'Salads_Button_Placeholder20
        '
        Me.Salads_Button_Placeholder20.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder20.Location = New System.Drawing.Point(187, 348)
        Me.Salads_Button_Placeholder20.Name = "Salads_Button_Placeholder20"
        Me.Salads_Button_Placeholder20.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder20.TabIndex = 0
        Me.Salads_Button_Placeholder20.Text = "Placeholder"
        Me.Salads_Button_Placeholder20.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder20.Visible = False
        '
        'Salads_Button_Placeholder11
        '
        Me.Salads_Button_Placeholder11.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder11.Location = New System.Drawing.Point(187, 182)
        Me.Salads_Button_Placeholder11.Name = "Salads_Button_Placeholder11"
        Me.Salads_Button_Placeholder11.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder11.TabIndex = 0
        Me.Salads_Button_Placeholder11.Text = "Placeholder"
        Me.Salads_Button_Placeholder11.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder11.Visible = False
        '
        'Salads_Button_Placeholder19
        '
        Me.Salads_Button_Placeholder19.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder19.Location = New System.Drawing.Point(21, 348)
        Me.Salads_Button_Placeholder19.Name = "Salads_Button_Placeholder19"
        Me.Salads_Button_Placeholder19.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder19.TabIndex = 0
        Me.Salads_Button_Placeholder19.Text = "Placeholder"
        Me.Salads_Button_Placeholder19.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder19.Visible = False
        '
        'Salads_Button_Placeholder10
        '
        Me.Salads_Button_Placeholder10.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder10.Location = New System.Drawing.Point(21, 182)
        Me.Salads_Button_Placeholder10.Name = "Salads_Button_Placeholder10"
        Me.Salads_Button_Placeholder10.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder10.TabIndex = 0
        Me.Salads_Button_Placeholder10.Text = "Placeholder"
        Me.Salads_Button_Placeholder10.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder10.Visible = False
        '
        'Salads_Button_Placeholder9
        '
        Me.Salads_Button_Placeholder9.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder9.Location = New System.Drawing.Point(1348, 16)
        Me.Salads_Button_Placeholder9.Name = "Salads_Button_Placeholder9"
        Me.Salads_Button_Placeholder9.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder9.TabIndex = 0
        Me.Salads_Button_Placeholder9.Text = "Placeholder"
        Me.Salads_Button_Placeholder9.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder9.Visible = False
        '
        'Salads_Button_Placeholder8
        '
        Me.Salads_Button_Placeholder8.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder8.Location = New System.Drawing.Point(1182, 16)
        Me.Salads_Button_Placeholder8.Name = "Salads_Button_Placeholder8"
        Me.Salads_Button_Placeholder8.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder8.TabIndex = 0
        Me.Salads_Button_Placeholder8.Text = "Placeholder"
        Me.Salads_Button_Placeholder8.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder8.Visible = False
        '
        'Salads_Button_Placeholder7
        '
        Me.Salads_Button_Placeholder7.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder7.Location = New System.Drawing.Point(1016, 16)
        Me.Salads_Button_Placeholder7.Name = "Salads_Button_Placeholder7"
        Me.Salads_Button_Placeholder7.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder7.TabIndex = 0
        Me.Salads_Button_Placeholder7.Text = "Placeholder"
        Me.Salads_Button_Placeholder7.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder7.Visible = False
        '
        'Salads_Button_Placeholder6
        '
        Me.Salads_Button_Placeholder6.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder6.Location = New System.Drawing.Point(850, 16)
        Me.Salads_Button_Placeholder6.Name = "Salads_Button_Placeholder6"
        Me.Salads_Button_Placeholder6.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder6.TabIndex = 0
        Me.Salads_Button_Placeholder6.Text = "Placeholder"
        Me.Salads_Button_Placeholder6.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder6.Visible = False
        '
        'Salads_Button_Placeholder5
        '
        Me.Salads_Button_Placeholder5.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder5.Location = New System.Drawing.Point(685, 16)
        Me.Salads_Button_Placeholder5.Name = "Salads_Button_Placeholder5"
        Me.Salads_Button_Placeholder5.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder5.TabIndex = 0
        Me.Salads_Button_Placeholder5.Text = "Placeholder"
        Me.Salads_Button_Placeholder5.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder5.Visible = False
        '
        'Salads_Button_Placeholder4
        '
        Me.Salads_Button_Placeholder4.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder4.Location = New System.Drawing.Point(519, 16)
        Me.Salads_Button_Placeholder4.Name = "Salads_Button_Placeholder4"
        Me.Salads_Button_Placeholder4.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder4.TabIndex = 0
        Me.Salads_Button_Placeholder4.Text = "Placeholder"
        Me.Salads_Button_Placeholder4.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder4.Visible = False
        '
        'Salads_Button_Placeholder3
        '
        Me.Salads_Button_Placeholder3.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder3.Location = New System.Drawing.Point(353, 16)
        Me.Salads_Button_Placeholder3.Name = "Salads_Button_Placeholder3"
        Me.Salads_Button_Placeholder3.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder3.TabIndex = 0
        Me.Salads_Button_Placeholder3.Text = "Placeholder"
        Me.Salads_Button_Placeholder3.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder3.Visible = False
        '
        'Salads_Button_Placeholder2
        '
        Me.Salads_Button_Placeholder2.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder2.Location = New System.Drawing.Point(187, 16)
        Me.Salads_Button_Placeholder2.Name = "Salads_Button_Placeholder2"
        Me.Salads_Button_Placeholder2.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder2.TabIndex = 0
        Me.Salads_Button_Placeholder2.Text = "Placeholder"
        Me.Salads_Button_Placeholder2.UseVisualStyleBackColor = True
        Me.Salads_Button_Placeholder2.Visible = False
        '
        'Salads_Button_Placeholder1
        '
        Me.Salads_Button_Placeholder1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Salads_Button_Placeholder1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salads_Button_Placeholder1.Location = New System.Drawing.Point(21, 16)
        Me.Salads_Button_Placeholder1.Name = "Salads_Button_Placeholder1"
        Me.Salads_Button_Placeholder1.Size = New System.Drawing.Size(160, 160)
        Me.Salads_Button_Placeholder1.TabIndex = 0
        Me.Salads_Button_Placeholder1.Text = "Placeholder"
        Me.Salads_Button_Placeholder1.UseVisualStyleBackColor = False
        Me.Salads_Button_Placeholder1.Visible = False
        '
        'Panel_CatSides
        '
        Me.Panel_CatSides.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder27)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder18)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder26)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder17)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder25)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder16)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder24)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder15)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder23)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder14)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder22)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder13)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder21)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder12)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder20)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder11)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder19)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder10)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder9)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder8)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder7)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder6)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder5)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder4)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder3)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder2)
        Me.Panel_CatSides.Controls.Add(Me.Sides_Button_Placeholder1)
        Me.Panel_CatSides.Location = New System.Drawing.Point(9, 102)
        Me.Panel_CatSides.Name = "Panel_CatSides"
        Me.Panel_CatSides.Size = New System.Drawing.Size(1528, 614)
        Me.Panel_CatSides.TabIndex = 12
        '
        'Sides_Button_Placeholder27
        '
        Me.Sides_Button_Placeholder27.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder27.Location = New System.Drawing.Point(1348, 348)
        Me.Sides_Button_Placeholder27.Name = "Sides_Button_Placeholder27"
        Me.Sides_Button_Placeholder27.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder27.TabIndex = 0
        Me.Sides_Button_Placeholder27.Text = "Placeholder"
        Me.Sides_Button_Placeholder27.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder27.Visible = False
        '
        'Sides_Button_Placeholder18
        '
        Me.Sides_Button_Placeholder18.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder18.Location = New System.Drawing.Point(1348, 182)
        Me.Sides_Button_Placeholder18.Name = "Sides_Button_Placeholder18"
        Me.Sides_Button_Placeholder18.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder18.TabIndex = 0
        Me.Sides_Button_Placeholder18.Text = "Placeholder"
        Me.Sides_Button_Placeholder18.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder18.Visible = False
        '
        'Sides_Button_Placeholder26
        '
        Me.Sides_Button_Placeholder26.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder26.Location = New System.Drawing.Point(1182, 348)
        Me.Sides_Button_Placeholder26.Name = "Sides_Button_Placeholder26"
        Me.Sides_Button_Placeholder26.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder26.TabIndex = 0
        Me.Sides_Button_Placeholder26.Text = "Placeholder"
        Me.Sides_Button_Placeholder26.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder26.Visible = False
        '
        'Sides_Button_Placeholder17
        '
        Me.Sides_Button_Placeholder17.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder17.Location = New System.Drawing.Point(1182, 182)
        Me.Sides_Button_Placeholder17.Name = "Sides_Button_Placeholder17"
        Me.Sides_Button_Placeholder17.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder17.TabIndex = 0
        Me.Sides_Button_Placeholder17.Text = "Placeholder"
        Me.Sides_Button_Placeholder17.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder17.Visible = False
        '
        'Sides_Button_Placeholder25
        '
        Me.Sides_Button_Placeholder25.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder25.Location = New System.Drawing.Point(1016, 348)
        Me.Sides_Button_Placeholder25.Name = "Sides_Button_Placeholder25"
        Me.Sides_Button_Placeholder25.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder25.TabIndex = 0
        Me.Sides_Button_Placeholder25.Text = "Placeholder"
        Me.Sides_Button_Placeholder25.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder25.Visible = False
        '
        'Sides_Button_Placeholder16
        '
        Me.Sides_Button_Placeholder16.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder16.Location = New System.Drawing.Point(1016, 182)
        Me.Sides_Button_Placeholder16.Name = "Sides_Button_Placeholder16"
        Me.Sides_Button_Placeholder16.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder16.TabIndex = 0
        Me.Sides_Button_Placeholder16.Text = "Placeholder"
        Me.Sides_Button_Placeholder16.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder16.Visible = False
        '
        'Sides_Button_Placeholder24
        '
        Me.Sides_Button_Placeholder24.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder24.Location = New System.Drawing.Point(850, 348)
        Me.Sides_Button_Placeholder24.Name = "Sides_Button_Placeholder24"
        Me.Sides_Button_Placeholder24.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder24.TabIndex = 0
        Me.Sides_Button_Placeholder24.Text = "Placeholder"
        Me.Sides_Button_Placeholder24.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder24.Visible = False
        '
        'Sides_Button_Placeholder15
        '
        Me.Sides_Button_Placeholder15.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder15.Location = New System.Drawing.Point(850, 182)
        Me.Sides_Button_Placeholder15.Name = "Sides_Button_Placeholder15"
        Me.Sides_Button_Placeholder15.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder15.TabIndex = 0
        Me.Sides_Button_Placeholder15.Text = "Placeholder"
        Me.Sides_Button_Placeholder15.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder15.Visible = False
        '
        'Sides_Button_Placeholder23
        '
        Me.Sides_Button_Placeholder23.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder23.Location = New System.Drawing.Point(685, 348)
        Me.Sides_Button_Placeholder23.Name = "Sides_Button_Placeholder23"
        Me.Sides_Button_Placeholder23.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder23.TabIndex = 0
        Me.Sides_Button_Placeholder23.Text = "Placeholder"
        Me.Sides_Button_Placeholder23.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder23.Visible = False
        '
        'Sides_Button_Placeholder14
        '
        Me.Sides_Button_Placeholder14.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder14.Location = New System.Drawing.Point(685, 182)
        Me.Sides_Button_Placeholder14.Name = "Sides_Button_Placeholder14"
        Me.Sides_Button_Placeholder14.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder14.TabIndex = 0
        Me.Sides_Button_Placeholder14.Text = "Placeholder"
        Me.Sides_Button_Placeholder14.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder14.Visible = False
        '
        'Sides_Button_Placeholder22
        '
        Me.Sides_Button_Placeholder22.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder22.Location = New System.Drawing.Point(519, 348)
        Me.Sides_Button_Placeholder22.Name = "Sides_Button_Placeholder22"
        Me.Sides_Button_Placeholder22.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder22.TabIndex = 0
        Me.Sides_Button_Placeholder22.Text = "Placeholder"
        Me.Sides_Button_Placeholder22.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder22.Visible = False
        '
        'Sides_Button_Placeholder13
        '
        Me.Sides_Button_Placeholder13.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder13.Location = New System.Drawing.Point(519, 182)
        Me.Sides_Button_Placeholder13.Name = "Sides_Button_Placeholder13"
        Me.Sides_Button_Placeholder13.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder13.TabIndex = 0
        Me.Sides_Button_Placeholder13.Text = "Placeholder"
        Me.Sides_Button_Placeholder13.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder13.Visible = False
        '
        'Sides_Button_Placeholder21
        '
        Me.Sides_Button_Placeholder21.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder21.Location = New System.Drawing.Point(353, 348)
        Me.Sides_Button_Placeholder21.Name = "Sides_Button_Placeholder21"
        Me.Sides_Button_Placeholder21.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder21.TabIndex = 0
        Me.Sides_Button_Placeholder21.Text = "Placeholder"
        Me.Sides_Button_Placeholder21.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder21.Visible = False
        '
        'Sides_Button_Placeholder12
        '
        Me.Sides_Button_Placeholder12.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder12.Location = New System.Drawing.Point(353, 182)
        Me.Sides_Button_Placeholder12.Name = "Sides_Button_Placeholder12"
        Me.Sides_Button_Placeholder12.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder12.TabIndex = 0
        Me.Sides_Button_Placeholder12.Text = "Placeholder"
        Me.Sides_Button_Placeholder12.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder12.Visible = False
        '
        'Sides_Button_Placeholder20
        '
        Me.Sides_Button_Placeholder20.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder20.Location = New System.Drawing.Point(187, 348)
        Me.Sides_Button_Placeholder20.Name = "Sides_Button_Placeholder20"
        Me.Sides_Button_Placeholder20.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder20.TabIndex = 0
        Me.Sides_Button_Placeholder20.Text = "Placeholder"
        Me.Sides_Button_Placeholder20.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder20.Visible = False
        '
        'Sides_Button_Placeholder11
        '
        Me.Sides_Button_Placeholder11.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder11.Location = New System.Drawing.Point(187, 182)
        Me.Sides_Button_Placeholder11.Name = "Sides_Button_Placeholder11"
        Me.Sides_Button_Placeholder11.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder11.TabIndex = 0
        Me.Sides_Button_Placeholder11.Text = "Placeholder"
        Me.Sides_Button_Placeholder11.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder11.Visible = False
        '
        'Sides_Button_Placeholder19
        '
        Me.Sides_Button_Placeholder19.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder19.Location = New System.Drawing.Point(21, 348)
        Me.Sides_Button_Placeholder19.Name = "Sides_Button_Placeholder19"
        Me.Sides_Button_Placeholder19.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder19.TabIndex = 0
        Me.Sides_Button_Placeholder19.Text = "Placeholder"
        Me.Sides_Button_Placeholder19.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder19.Visible = False
        '
        'Sides_Button_Placeholder10
        '
        Me.Sides_Button_Placeholder10.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder10.Location = New System.Drawing.Point(21, 182)
        Me.Sides_Button_Placeholder10.Name = "Sides_Button_Placeholder10"
        Me.Sides_Button_Placeholder10.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder10.TabIndex = 0
        Me.Sides_Button_Placeholder10.Text = "Placeholder"
        Me.Sides_Button_Placeholder10.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder10.Visible = False
        '
        'Sides_Button_Placeholder9
        '
        Me.Sides_Button_Placeholder9.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder9.Location = New System.Drawing.Point(1348, 16)
        Me.Sides_Button_Placeholder9.Name = "Sides_Button_Placeholder9"
        Me.Sides_Button_Placeholder9.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder9.TabIndex = 0
        Me.Sides_Button_Placeholder9.Text = "Placeholder"
        Me.Sides_Button_Placeholder9.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder9.Visible = False
        '
        'Sides_Button_Placeholder8
        '
        Me.Sides_Button_Placeholder8.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder8.Location = New System.Drawing.Point(1182, 16)
        Me.Sides_Button_Placeholder8.Name = "Sides_Button_Placeholder8"
        Me.Sides_Button_Placeholder8.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder8.TabIndex = 0
        Me.Sides_Button_Placeholder8.Text = "Placeholder"
        Me.Sides_Button_Placeholder8.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder8.Visible = False
        '
        'Sides_Button_Placeholder7
        '
        Me.Sides_Button_Placeholder7.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder7.Location = New System.Drawing.Point(1016, 16)
        Me.Sides_Button_Placeholder7.Name = "Sides_Button_Placeholder7"
        Me.Sides_Button_Placeholder7.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder7.TabIndex = 0
        Me.Sides_Button_Placeholder7.Text = "Placeholder"
        Me.Sides_Button_Placeholder7.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder7.Visible = False
        '
        'Sides_Button_Placeholder6
        '
        Me.Sides_Button_Placeholder6.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder6.Location = New System.Drawing.Point(850, 16)
        Me.Sides_Button_Placeholder6.Name = "Sides_Button_Placeholder6"
        Me.Sides_Button_Placeholder6.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder6.TabIndex = 0
        Me.Sides_Button_Placeholder6.Text = "Placeholder"
        Me.Sides_Button_Placeholder6.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder6.Visible = False
        '
        'Sides_Button_Placeholder5
        '
        Me.Sides_Button_Placeholder5.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder5.Location = New System.Drawing.Point(685, 16)
        Me.Sides_Button_Placeholder5.Name = "Sides_Button_Placeholder5"
        Me.Sides_Button_Placeholder5.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder5.TabIndex = 0
        Me.Sides_Button_Placeholder5.Text = "Placeholder"
        Me.Sides_Button_Placeholder5.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder5.Visible = False
        '
        'Sides_Button_Placeholder4
        '
        Me.Sides_Button_Placeholder4.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder4.Location = New System.Drawing.Point(519, 16)
        Me.Sides_Button_Placeholder4.Name = "Sides_Button_Placeholder4"
        Me.Sides_Button_Placeholder4.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder4.TabIndex = 0
        Me.Sides_Button_Placeholder4.Text = "Placeholder"
        Me.Sides_Button_Placeholder4.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder4.Visible = False
        '
        'Sides_Button_Placeholder3
        '
        Me.Sides_Button_Placeholder3.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder3.Location = New System.Drawing.Point(353, 16)
        Me.Sides_Button_Placeholder3.Name = "Sides_Button_Placeholder3"
        Me.Sides_Button_Placeholder3.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder3.TabIndex = 0
        Me.Sides_Button_Placeholder3.Text = "Placeholder"
        Me.Sides_Button_Placeholder3.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder3.Visible = False
        '
        'Sides_Button_Placeholder2
        '
        Me.Sides_Button_Placeholder2.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder2.Location = New System.Drawing.Point(187, 16)
        Me.Sides_Button_Placeholder2.Name = "Sides_Button_Placeholder2"
        Me.Sides_Button_Placeholder2.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder2.TabIndex = 0
        Me.Sides_Button_Placeholder2.Text = "Placeholder"
        Me.Sides_Button_Placeholder2.UseVisualStyleBackColor = True
        Me.Sides_Button_Placeholder2.Visible = False
        '
        'Sides_Button_Placeholder1
        '
        Me.Sides_Button_Placeholder1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Sides_Button_Placeholder1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sides_Button_Placeholder1.Location = New System.Drawing.Point(21, 16)
        Me.Sides_Button_Placeholder1.Name = "Sides_Button_Placeholder1"
        Me.Sides_Button_Placeholder1.Size = New System.Drawing.Size(160, 160)
        Me.Sides_Button_Placeholder1.TabIndex = 0
        Me.Sides_Button_Placeholder1.Text = "Placeholder"
        Me.Sides_Button_Placeholder1.UseVisualStyleBackColor = False
        Me.Sides_Button_Placeholder1.Visible = False
        '
        'Panel_CatDrinks
        '
        Me.Panel_CatDrinks.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder27)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder18)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder26)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder17)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder25)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder16)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder24)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder15)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder23)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder14)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder22)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder13)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder21)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder12)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder20)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder11)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder19)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder10)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder9)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder8)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder7)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder6)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder5)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder4)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder3)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder2)
        Me.Panel_CatDrinks.Controls.Add(Me.Drinks_Button_Placeholder1)
        Me.Panel_CatDrinks.Location = New System.Drawing.Point(9, 102)
        Me.Panel_CatDrinks.Name = "Panel_CatDrinks"
        Me.Panel_CatDrinks.Size = New System.Drawing.Size(1528, 614)
        Me.Panel_CatDrinks.TabIndex = 13
        '
        'Drinks_Button_Placeholder27
        '
        Me.Drinks_Button_Placeholder27.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder27.Location = New System.Drawing.Point(1348, 348)
        Me.Drinks_Button_Placeholder27.Name = "Drinks_Button_Placeholder27"
        Me.Drinks_Button_Placeholder27.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder27.TabIndex = 0
        Me.Drinks_Button_Placeholder27.Text = "Placeholder"
        Me.Drinks_Button_Placeholder27.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder27.Visible = False
        '
        'Drinks_Button_Placeholder18
        '
        Me.Drinks_Button_Placeholder18.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder18.Location = New System.Drawing.Point(1348, 182)
        Me.Drinks_Button_Placeholder18.Name = "Drinks_Button_Placeholder18"
        Me.Drinks_Button_Placeholder18.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder18.TabIndex = 0
        Me.Drinks_Button_Placeholder18.Text = "Placeholder"
        Me.Drinks_Button_Placeholder18.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder18.Visible = False
        '
        'Drinks_Button_Placeholder26
        '
        Me.Drinks_Button_Placeholder26.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder26.Location = New System.Drawing.Point(1182, 348)
        Me.Drinks_Button_Placeholder26.Name = "Drinks_Button_Placeholder26"
        Me.Drinks_Button_Placeholder26.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder26.TabIndex = 0
        Me.Drinks_Button_Placeholder26.Text = "Placeholder"
        Me.Drinks_Button_Placeholder26.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder26.Visible = False
        '
        'Drinks_Button_Placeholder17
        '
        Me.Drinks_Button_Placeholder17.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder17.Location = New System.Drawing.Point(1182, 182)
        Me.Drinks_Button_Placeholder17.Name = "Drinks_Button_Placeholder17"
        Me.Drinks_Button_Placeholder17.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder17.TabIndex = 0
        Me.Drinks_Button_Placeholder17.Text = "Placeholder"
        Me.Drinks_Button_Placeholder17.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder17.Visible = False
        '
        'Drinks_Button_Placeholder25
        '
        Me.Drinks_Button_Placeholder25.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder25.Location = New System.Drawing.Point(1016, 348)
        Me.Drinks_Button_Placeholder25.Name = "Drinks_Button_Placeholder25"
        Me.Drinks_Button_Placeholder25.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder25.TabIndex = 0
        Me.Drinks_Button_Placeholder25.Text = "Placeholder"
        Me.Drinks_Button_Placeholder25.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder25.Visible = False
        '
        'Drinks_Button_Placeholder16
        '
        Me.Drinks_Button_Placeholder16.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder16.Location = New System.Drawing.Point(1016, 182)
        Me.Drinks_Button_Placeholder16.Name = "Drinks_Button_Placeholder16"
        Me.Drinks_Button_Placeholder16.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder16.TabIndex = 0
        Me.Drinks_Button_Placeholder16.Text = "Placeholder"
        Me.Drinks_Button_Placeholder16.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder16.Visible = False
        '
        'Drinks_Button_Placeholder24
        '
        Me.Drinks_Button_Placeholder24.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder24.Location = New System.Drawing.Point(850, 348)
        Me.Drinks_Button_Placeholder24.Name = "Drinks_Button_Placeholder24"
        Me.Drinks_Button_Placeholder24.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder24.TabIndex = 0
        Me.Drinks_Button_Placeholder24.Text = "Placeholder"
        Me.Drinks_Button_Placeholder24.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder24.Visible = False
        '
        'Drinks_Button_Placeholder15
        '
        Me.Drinks_Button_Placeholder15.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder15.Location = New System.Drawing.Point(850, 182)
        Me.Drinks_Button_Placeholder15.Name = "Drinks_Button_Placeholder15"
        Me.Drinks_Button_Placeholder15.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder15.TabIndex = 0
        Me.Drinks_Button_Placeholder15.Text = "Placeholder"
        Me.Drinks_Button_Placeholder15.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder15.Visible = False
        '
        'Drinks_Button_Placeholder23
        '
        Me.Drinks_Button_Placeholder23.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder23.Location = New System.Drawing.Point(685, 348)
        Me.Drinks_Button_Placeholder23.Name = "Drinks_Button_Placeholder23"
        Me.Drinks_Button_Placeholder23.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder23.TabIndex = 0
        Me.Drinks_Button_Placeholder23.Text = "Placeholder"
        Me.Drinks_Button_Placeholder23.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder23.Visible = False
        '
        'Drinks_Button_Placeholder14
        '
        Me.Drinks_Button_Placeholder14.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder14.Location = New System.Drawing.Point(685, 182)
        Me.Drinks_Button_Placeholder14.Name = "Drinks_Button_Placeholder14"
        Me.Drinks_Button_Placeholder14.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder14.TabIndex = 0
        Me.Drinks_Button_Placeholder14.Text = "Placeholder"
        Me.Drinks_Button_Placeholder14.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder14.Visible = False
        '
        'Drinks_Button_Placeholder22
        '
        Me.Drinks_Button_Placeholder22.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder22.Location = New System.Drawing.Point(519, 348)
        Me.Drinks_Button_Placeholder22.Name = "Drinks_Button_Placeholder22"
        Me.Drinks_Button_Placeholder22.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder22.TabIndex = 0
        Me.Drinks_Button_Placeholder22.Text = "Placeholder"
        Me.Drinks_Button_Placeholder22.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder22.Visible = False
        '
        'Drinks_Button_Placeholder13
        '
        Me.Drinks_Button_Placeholder13.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder13.Location = New System.Drawing.Point(519, 182)
        Me.Drinks_Button_Placeholder13.Name = "Drinks_Button_Placeholder13"
        Me.Drinks_Button_Placeholder13.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder13.TabIndex = 0
        Me.Drinks_Button_Placeholder13.Text = "Placeholder"
        Me.Drinks_Button_Placeholder13.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder13.Visible = False
        '
        'Drinks_Button_Placeholder21
        '
        Me.Drinks_Button_Placeholder21.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder21.Location = New System.Drawing.Point(353, 348)
        Me.Drinks_Button_Placeholder21.Name = "Drinks_Button_Placeholder21"
        Me.Drinks_Button_Placeholder21.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder21.TabIndex = 0
        Me.Drinks_Button_Placeholder21.Text = "Placeholder"
        Me.Drinks_Button_Placeholder21.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder21.Visible = False
        '
        'Drinks_Button_Placeholder12
        '
        Me.Drinks_Button_Placeholder12.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder12.Location = New System.Drawing.Point(353, 182)
        Me.Drinks_Button_Placeholder12.Name = "Drinks_Button_Placeholder12"
        Me.Drinks_Button_Placeholder12.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder12.TabIndex = 0
        Me.Drinks_Button_Placeholder12.Text = "Placeholder"
        Me.Drinks_Button_Placeholder12.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder12.Visible = False
        '
        'Drinks_Button_Placeholder20
        '
        Me.Drinks_Button_Placeholder20.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder20.Location = New System.Drawing.Point(187, 348)
        Me.Drinks_Button_Placeholder20.Name = "Drinks_Button_Placeholder20"
        Me.Drinks_Button_Placeholder20.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder20.TabIndex = 0
        Me.Drinks_Button_Placeholder20.Text = "Placeholder"
        Me.Drinks_Button_Placeholder20.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder20.Visible = False
        '
        'Drinks_Button_Placeholder11
        '
        Me.Drinks_Button_Placeholder11.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder11.Location = New System.Drawing.Point(187, 182)
        Me.Drinks_Button_Placeholder11.Name = "Drinks_Button_Placeholder11"
        Me.Drinks_Button_Placeholder11.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder11.TabIndex = 0
        Me.Drinks_Button_Placeholder11.Text = "Placeholder"
        Me.Drinks_Button_Placeholder11.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder11.Visible = False
        '
        'Drinks_Button_Placeholder19
        '
        Me.Drinks_Button_Placeholder19.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder19.Location = New System.Drawing.Point(21, 348)
        Me.Drinks_Button_Placeholder19.Name = "Drinks_Button_Placeholder19"
        Me.Drinks_Button_Placeholder19.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder19.TabIndex = 0
        Me.Drinks_Button_Placeholder19.Text = "Placeholder"
        Me.Drinks_Button_Placeholder19.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder19.Visible = False
        '
        'Drinks_Button_Placeholder10
        '
        Me.Drinks_Button_Placeholder10.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder10.Location = New System.Drawing.Point(21, 182)
        Me.Drinks_Button_Placeholder10.Name = "Drinks_Button_Placeholder10"
        Me.Drinks_Button_Placeholder10.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder10.TabIndex = 0
        Me.Drinks_Button_Placeholder10.Text = "Placeholder"
        Me.Drinks_Button_Placeholder10.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder10.Visible = False
        '
        'Drinks_Button_Placeholder9
        '
        Me.Drinks_Button_Placeholder9.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder9.Location = New System.Drawing.Point(1348, 16)
        Me.Drinks_Button_Placeholder9.Name = "Drinks_Button_Placeholder9"
        Me.Drinks_Button_Placeholder9.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder9.TabIndex = 0
        Me.Drinks_Button_Placeholder9.Text = "Placeholder"
        Me.Drinks_Button_Placeholder9.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder9.Visible = False
        '
        'Drinks_Button_Placeholder8
        '
        Me.Drinks_Button_Placeholder8.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder8.Location = New System.Drawing.Point(1182, 16)
        Me.Drinks_Button_Placeholder8.Name = "Drinks_Button_Placeholder8"
        Me.Drinks_Button_Placeholder8.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder8.TabIndex = 0
        Me.Drinks_Button_Placeholder8.Text = "Placeholder"
        Me.Drinks_Button_Placeholder8.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder8.Visible = False
        '
        'Drinks_Button_Placeholder7
        '
        Me.Drinks_Button_Placeholder7.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder7.Location = New System.Drawing.Point(1016, 16)
        Me.Drinks_Button_Placeholder7.Name = "Drinks_Button_Placeholder7"
        Me.Drinks_Button_Placeholder7.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder7.TabIndex = 0
        Me.Drinks_Button_Placeholder7.Text = "Placeholder"
        Me.Drinks_Button_Placeholder7.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder7.Visible = False
        '
        'Drinks_Button_Placeholder6
        '
        Me.Drinks_Button_Placeholder6.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder6.Location = New System.Drawing.Point(850, 16)
        Me.Drinks_Button_Placeholder6.Name = "Drinks_Button_Placeholder6"
        Me.Drinks_Button_Placeholder6.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder6.TabIndex = 0
        Me.Drinks_Button_Placeholder6.Text = "Placeholder"
        Me.Drinks_Button_Placeholder6.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder6.Visible = False
        '
        'Drinks_Button_Placeholder5
        '
        Me.Drinks_Button_Placeholder5.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder5.Location = New System.Drawing.Point(685, 16)
        Me.Drinks_Button_Placeholder5.Name = "Drinks_Button_Placeholder5"
        Me.Drinks_Button_Placeholder5.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder5.TabIndex = 0
        Me.Drinks_Button_Placeholder5.Text = "Placeholder"
        Me.Drinks_Button_Placeholder5.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder5.Visible = False
        '
        'Drinks_Button_Placeholder4
        '
        Me.Drinks_Button_Placeholder4.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder4.Location = New System.Drawing.Point(519, 16)
        Me.Drinks_Button_Placeholder4.Name = "Drinks_Button_Placeholder4"
        Me.Drinks_Button_Placeholder4.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder4.TabIndex = 0
        Me.Drinks_Button_Placeholder4.Text = "Placeholder"
        Me.Drinks_Button_Placeholder4.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder4.Visible = False
        '
        'Drinks_Button_Placeholder3
        '
        Me.Drinks_Button_Placeholder3.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder3.Location = New System.Drawing.Point(353, 16)
        Me.Drinks_Button_Placeholder3.Name = "Drinks_Button_Placeholder3"
        Me.Drinks_Button_Placeholder3.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder3.TabIndex = 0
        Me.Drinks_Button_Placeholder3.Text = "Placeholder"
        Me.Drinks_Button_Placeholder3.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder3.Visible = False
        '
        'Drinks_Button_Placeholder2
        '
        Me.Drinks_Button_Placeholder2.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder2.Location = New System.Drawing.Point(187, 16)
        Me.Drinks_Button_Placeholder2.Name = "Drinks_Button_Placeholder2"
        Me.Drinks_Button_Placeholder2.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder2.TabIndex = 0
        Me.Drinks_Button_Placeholder2.Text = "Placeholder"
        Me.Drinks_Button_Placeholder2.UseVisualStyleBackColor = True
        Me.Drinks_Button_Placeholder2.Visible = False
        '
        'Drinks_Button_Placeholder1
        '
        Me.Drinks_Button_Placeholder1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Drinks_Button_Placeholder1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Drinks_Button_Placeholder1.Location = New System.Drawing.Point(21, 16)
        Me.Drinks_Button_Placeholder1.Name = "Drinks_Button_Placeholder1"
        Me.Drinks_Button_Placeholder1.Size = New System.Drawing.Size(160, 160)
        Me.Drinks_Button_Placeholder1.TabIndex = 0
        Me.Drinks_Button_Placeholder1.Text = "Placeholder"
        Me.Drinks_Button_Placeholder1.UseVisualStyleBackColor = False
        Me.Drinks_Button_Placeholder1.Visible = False
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
        'TransactionsTableAdapter
        '
        Me.TransactionsTableAdapter.ClearBeforeFill = True
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
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.Database_POSSystemDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'Form_POSSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1904, 1041)
        Me.Controls.Add(Me.Panel_CatDrinks)
        Me.Controls.Add(Me.Panel_CatSides)
        Me.Controls.Add(Me.Panel_CatSalads)
        Me.Controls.Add(Me.Panel_CatDesserts)
        Me.Controls.Add(Me.Panel_CatKids)
        Me.Controls.Add(Me.Panel_CatBurgers)
        Me.Controls.Add(Me.Panel_CatMains)
        Me.Controls.Add(Me.Panel_CatStarters)
        Me.Controls.Add(Me.Label_Training)
        Me.Controls.Add(Me.Label_AdminStatus)
        Me.Controls.Add(Me.Panel_CatSpecials)
        Me.Controls.Add(Me.Panel_CommonControls)
        Me.Controls.Add(Me.Panel_CurrentOrderTotal)
        Me.Controls.Add(Me.Panel_CurrentOrder)
        Me.Controls.Add(Me.Panel_Information)
        Me.Controls.Add(Me.Panel_Catagories)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_POSSystem"
        Me.Text = "POS System  |  Order"
        Me.Panel_Catagories.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel_Information.ResumeLayout(False)
        Me.Panel_Information.PerformLayout()
        CType(Me.TransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database_POSSystemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_CurrentOrder.ResumeLayout(False)
        Me.Panel_CurrentOrder.PerformLayout()
        Me.Panel_CurrentOrderTotal.ResumeLayout(False)
        Me.Panel_CurrentOrderTotal.PerformLayout()
        Me.Panel_CommonControls.ResumeLayout(False)
        Me.Panel_CatSpecials.ResumeLayout(False)
        Me.Panel_CatStarters.ResumeLayout(False)
        Me.Panel_CatMains.ResumeLayout(False)
        Me.Panel_CatBurgers.ResumeLayout(False)
        Me.Panel_CatKids.ResumeLayout(False)
        Me.Panel_CatDesserts.ResumeLayout(False)
        Me.Panel_CatSalads.ResumeLayout(False)
        Me.Panel_CatSides.ResumeLayout(False)
        Me.Panel_CatDrinks.ResumeLayout(False)
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_Catagories As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StaffManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PayrollManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewTransactionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button_Drinks As Button
    Friend WithEvents Button_Sides As Button
    Friend WithEvents Button_Salads As Button
    Friend WithEvents Button_Desserts As Button
    Friend WithEvents Button_Kids As Button
    Friend WithEvents Button_Burgers As Button
    Friend WithEvents Button_Mains As Button
    Friend WithEvents Button_Starters As Button
    Friend WithEvents Button_Specials As Button
    Friend WithEvents Panel_Information As Panel
    Friend WithEvents TextBox_ServerName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_CurrentOrder As Panel
    Friend WithEvents TextBox_CurrentOrderPrices As TextBox
    Friend WithEvents TextBox_CurrentOrder As TextBox
    Friend WithEvents Panel_CurrentOrderTotal As Panel
    Friend WithEvents Button_DownCurrOrder As Button
    Friend WithEvents Button_UpCurrOrder As Button
    Friend WithEvents TextBox_TotalText As TextBox
    Friend WithEvents Panel_CommonControls As Panel
    Friend WithEvents Button_DownCat As Button
    Friend WithEvents Button_UpCat As Button
    Friend WithEvents Panel_CatSpecials As Panel
    Friend WithEvents Button_CancelTransaction As Button
    Friend WithEvents Button_SignOut As Button
    Friend WithEvents Button_CompleteTransaction As Button
    Friend WithEvents Button_SelectCustomer As Button
    Friend WithEvents Button_MainMenu As Button
    Friend WithEvents Button_InventoryManagement As Button
    Friend WithEvents Button31 As Button
    Friend WithEvents Button_ClearTable As Button
    Friend WithEvents Button_ViewTransactions As Button
    Friend WithEvents Button30 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button43 As Button
    Friend WithEvents Button27 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button_Discount5 As Button
    Friend WithEvents Button_StudentDiscount As Button
    Friend WithEvents Button_StaffManagement As Button
    Friend WithEvents Button_ClearCustomer As Button
    Friend WithEvents Button_SelectTable As Button
    Friend WithEvents Button_PayrollManagement As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button_ModifyMenu As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button_Reciept As Button
    Friend WithEvents Button_ProductID As Button
    Friend WithEvents Button_StaffDiscount As Button
    Friend WithEvents Button_TrainingMode As Button
    Friend WithEvents Button_Exit As Button
    Friend WithEvents Label_AdminStatus As Label
    Friend WithEvents Database_POSSystemDataSet As Database_POSSystemDataSet
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As Database_POSSystemDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents TableAdapterManager As Database_POSSystemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TransactionsBindingSource As BindingSource
    Friend WithEvents TransactionsTableAdapter As Database_POSSystemDataSetTableAdapters.TransactionsTableAdapter
    Friend WithEvents ModifyMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionIDTextBox As TextBox
    Friend WithEvents TableNoTextBox As TextBox
    Friend WithEvents Label_Training As Label
    Friend WithEvents Specials_Button_Placeholder10 As Button
    Friend WithEvents Specials_Button_Placeholder9 As Button
    Friend WithEvents Specials_Button_Placeholder8 As Button
    Friend WithEvents Specials_Button_Placeholder7 As Button
    Friend WithEvents Specials_Button_Placeholder6 As Button
    Friend WithEvents Specials_Button_Placeholder5 As Button
    Friend WithEvents Specials_Button_Placeholder4 As Button
    Friend WithEvents Specials_Button_Placeholder3 As Button
    Friend WithEvents Specials_Button_Placeholder2 As Button
    Friend WithEvents Specials_Button_Placeholder1 As Button
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As Database_POSSystemDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents Specials_Button_Placeholder13 As Button
    Friend WithEvents Specials_Button_Placeholder12 As Button
    Friend WithEvents Specials_Button_Placeholder11 As Button
    Friend WithEvents Specials_Button_Placeholder27 As Button
    Friend WithEvents Specials_Button_Placeholder18 As Button
    Friend WithEvents Specials_Button_Placeholder26 As Button
    Friend WithEvents Specials_Button_Placeholder17 As Button
    Friend WithEvents Specials_Button_Placeholder25 As Button
    Friend WithEvents Specials_Button_Placeholder16 As Button
    Friend WithEvents Specials_Button_Placeholder24 As Button
    Friend WithEvents Specials_Button_Placeholder15 As Button
    Friend WithEvents Specials_Button_Placeholder23 As Button
    Friend WithEvents Specials_Button_Placeholder14 As Button
    Friend WithEvents Specials_Button_Placeholder22 As Button
    Friend WithEvents Specials_Button_Placeholder21 As Button
    Friend WithEvents Specials_Button_Placeholder20 As Button
    Friend WithEvents Specials_Button_Placeholder19 As Button
    Friend WithEvents Panel_CatStarters As Panel
    Friend WithEvents Starters_Button_Placeholder27 As Button
    Friend WithEvents Starters_Button_Placeholder26 As Button
    Friend WithEvents Starters_Button_Placeholder25 As Button
    Friend WithEvents Starters_Button_Placeholder24 As Button
    Friend WithEvents Starters_Button_Placeholder23 As Button
    Friend WithEvents Starters_Button_Placeholder22 As Button
    Friend WithEvents Starters_Button_Placeholder21 As Button
    Friend WithEvents Starters_Button_Placeholder20 As Button
    Friend WithEvents Starters_Button_Placeholder19 As Button
    Friend WithEvents Starters_Button_Placeholder18 As Button
    Friend WithEvents Starters_Button_Placeholder17 As Button
    Friend WithEvents Starters_Button_Placeholder16 As Button
    Friend WithEvents Starters_Button_Placeholder15 As Button
    Friend WithEvents Starters_Button_Placeholder14 As Button
    Friend WithEvents Starters_Button_Placeholder13 As Button
    Friend WithEvents Starters_Button_Placeholder12 As Button
    Friend WithEvents Starters_Button_Placeholder11 As Button
    Friend WithEvents Starters_Button_Placeholder10 As Button
    Friend WithEvents Starters_Button_Placeholder9 As Button
    Friend WithEvents Starters_Button_Placeholder8 As Button
    Friend WithEvents Starters_Button_Placeholder7 As Button
    Friend WithEvents Starters_Button_Placeholder6 As Button
    Friend WithEvents Starters_Button_Placeholder5 As Button
    Friend WithEvents Starters_Button_Placeholder4 As Button
    Friend WithEvents Starters_Button_Placeholder3 As Button
    Friend WithEvents Starters_Button_Placeholder2 As Button
    Friend WithEvents Starters_Button_Placeholder1 As Button
    Friend WithEvents TextBox_TotalCost As TextBox
    Friend WithEvents TrainingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TurnTrainingModeOnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel_CatMains As Panel
    Friend WithEvents Mains_Button_Placeholder27 As Button
    Friend WithEvents Mains_Button_Placeholder18 As Button
    Friend WithEvents Mains_Button_Placeholder26 As Button
    Friend WithEvents Mains_Button_Placeholder17 As Button
    Friend WithEvents Mains_Button_Placeholder25 As Button
    Friend WithEvents Mains_Button_Placeholder16 As Button
    Friend WithEvents Mains_Button_Placeholder24 As Button
    Friend WithEvents Mains_Button_Placeholder15 As Button
    Friend WithEvents Mains_Button_Placeholder23 As Button
    Friend WithEvents Mains_Button_Placeholder14 As Button
    Friend WithEvents Mains_Button_Placeholder22 As Button
    Friend WithEvents Mains_Button_Placeholder13 As Button
    Friend WithEvents Mains_Button_Placeholder21 As Button
    Friend WithEvents Mains_Button_Placeholder12 As Button
    Friend WithEvents Mains_Button_Placeholder20 As Button
    Friend WithEvents Mains_Button_Placeholder11 As Button
    Friend WithEvents Mains_Button_Placeholder19 As Button
    Friend WithEvents Mains_Button_Placeholder10 As Button
    Friend WithEvents Mains_Button_Placeholder9 As Button
    Friend WithEvents Mains_Button_Placeholder8 As Button
    Friend WithEvents Mains_Button_Placeholder7 As Button
    Friend WithEvents Mains_Button_Placeholder6 As Button
    Friend WithEvents Mains_Button_Placeholder5 As Button
    Friend WithEvents Mains_Button_Placeholder4 As Button
    Friend WithEvents Mains_Button_Placeholder3 As Button
    Friend WithEvents Mains_Button_Placeholder2 As Button
    Friend WithEvents Mains_Button_Placeholder1 As Button
    Friend WithEvents Panel_CatBurgers As Panel
    Friend WithEvents Burgers_Button_Placeholder27 As Button
    Friend WithEvents Burgers_Button_Placeholder18 As Button
    Friend WithEvents Burgers_Button_Placeholder26 As Button
    Friend WithEvents Burgers_Button_Placeholder17 As Button
    Friend WithEvents Burgers_Button_Placeholder25 As Button
    Friend WithEvents Burgers_Button_Placeholder16 As Button
    Friend WithEvents Burgers_Button_Placeholder24 As Button
    Friend WithEvents Burgers_Button_Placeholder15 As Button
    Friend WithEvents Burgers_Button_Placeholder23 As Button
    Friend WithEvents Burgers_Button_Placeholder14 As Button
    Friend WithEvents Burgers_Button_Placeholder22 As Button
    Friend WithEvents Burgers_Button_Placeholder13 As Button
    Friend WithEvents Burgers_Button_Placeholder21 As Button
    Friend WithEvents Burgers_Button_Placeholder12 As Button
    Friend WithEvents Burgers_Button_Placeholder20 As Button
    Friend WithEvents Burgers_Button_Placeholder11 As Button
    Friend WithEvents Burgers_Button_Placeholder19 As Button
    Friend WithEvents Burgers_Button_Placeholder10 As Button
    Friend WithEvents Burgers_Button_Placeholder9 As Button
    Friend WithEvents Burgers_Button_Placeholder8 As Button
    Friend WithEvents Burgers_Button_Placeholder7 As Button
    Friend WithEvents Burgers_Button_Placeholder6 As Button
    Friend WithEvents Burgers_Button_Placeholder5 As Button
    Friend WithEvents Burgers_Button_Placeholder4 As Button
    Friend WithEvents Burgers_Button_Placeholder3 As Button
    Friend WithEvents Burgers_Button_Placeholder2 As Button
    Friend WithEvents Burgers_Button_Placeholder1 As Button
    Friend WithEvents Panel_CatKids As Panel
    Friend WithEvents Kids_Button_Placeholder27 As Button
    Friend WithEvents Kids_Button_Placeholder18 As Button
    Friend WithEvents Kids_Button_Placeholder26 As Button
    Friend WithEvents Kids_Button_Placeholder17 As Button
    Friend WithEvents Kids_Button_Placeholder25 As Button
    Friend WithEvents Kids_Button_Placeholder16 As Button
    Friend WithEvents Kids_Button_Placeholder24 As Button
    Friend WithEvents Kids_Button_Placeholder15 As Button
    Friend WithEvents Kids_Button_Placeholder23 As Button
    Friend WithEvents Kids_Button_Placeholder14 As Button
    Friend WithEvents Kids_Button_Placeholder22 As Button
    Friend WithEvents Kids_Button_Placeholder13 As Button
    Friend WithEvents Kids_Button_Placeholder21 As Button
    Friend WithEvents Kids_Button_Placeholder12 As Button
    Friend WithEvents Kids_Button_Placeholder20 As Button
    Friend WithEvents Kids_Button_Placeholder11 As Button
    Friend WithEvents Kids_Button_Placeholder19 As Button
    Friend WithEvents Kids_Button_Placeholder10 As Button
    Friend WithEvents Kids_Button_Placeholder9 As Button
    Friend WithEvents Kids_Button_Placeholder8 As Button
    Friend WithEvents Kids_Button_Placeholder7 As Button
    Friend WithEvents Kids_Button_Placeholder6 As Button
    Friend WithEvents Kids_Button_Placeholder5 As Button
    Friend WithEvents Kids_Button_Placeholder4 As Button
    Friend WithEvents Kids_Button_Placeholder3 As Button
    Friend WithEvents Kids_Button_Placeholder2 As Button
    Friend WithEvents Kids_Button_Placeholder1 As Button
    Friend WithEvents Panel_CatDesserts As Panel
    Friend WithEvents Desserts_Button_Placeholder27 As Button
    Friend WithEvents Desserts_Button_Placeholder18 As Button
    Friend WithEvents Desserts_Button_Placeholder26 As Button
    Friend WithEvents Desserts_Button_Placeholder17 As Button
    Friend WithEvents Desserts_Button_Placeholder25 As Button
    Friend WithEvents Desserts_Button_Placeholder16 As Button
    Friend WithEvents Desserts_Button_Placeholder24 As Button
    Friend WithEvents Desserts_Button_Placeholder15 As Button
    Friend WithEvents Desserts_Button_Placeholder23 As Button
    Friend WithEvents Desserts_Button_Placeholder14 As Button
    Friend WithEvents Desserts_Button_Placeholder22 As Button
    Friend WithEvents Desserts_Button_Placeholder13 As Button
    Friend WithEvents Desserts_Button_Placeholder21 As Button
    Friend WithEvents Desserts_Button_Placeholder12 As Button
    Friend WithEvents Desserts_Button_Placeholder20 As Button
    Friend WithEvents Desserts_Button_Placeholder11 As Button
    Friend WithEvents Desserts_Button_Placeholder19 As Button
    Friend WithEvents Desserts_Button_Placeholder10 As Button
    Friend WithEvents Desserts_Button_Placeholder9 As Button
    Friend WithEvents Desserts_Button_Placeholder8 As Button
    Friend WithEvents Desserts_Button_Placeholder7 As Button
    Friend WithEvents Desserts_Button_Placeholder6 As Button
    Friend WithEvents Desserts_Button_Placeholder5 As Button
    Friend WithEvents Desserts_Button_Placeholder4 As Button
    Friend WithEvents Desserts_Button_Placeholder3 As Button
    Friend WithEvents Desserts_Button_Placeholder2 As Button
    Friend WithEvents Desserts_Button_Placeholder1 As Button
    Friend WithEvents Panel_CatSalads As Panel
    Friend WithEvents Salads_Button_Placeholder27 As Button
    Friend WithEvents Salads_Button_Placeholder18 As Button
    Friend WithEvents Salads_Button_Placeholder26 As Button
    Friend WithEvents Salads_Button_Placeholder17 As Button
    Friend WithEvents Salads_Button_Placeholder25 As Button
    Friend WithEvents Salads_Button_Placeholder16 As Button
    Friend WithEvents Salads_Button_Placeholder24 As Button
    Friend WithEvents Salads_Button_Placeholder15 As Button
    Friend WithEvents Salads_Button_Placeholder23 As Button
    Friend WithEvents Salads_Button_Placeholder14 As Button
    Friend WithEvents Salads_Button_Placeholder22 As Button
    Friend WithEvents Salads_Button_Placeholder13 As Button
    Friend WithEvents Salads_Button_Placeholder21 As Button
    Friend WithEvents Salads_Button_Placeholder12 As Button
    Friend WithEvents Salads_Button_Placeholder20 As Button
    Friend WithEvents Salads_Button_Placeholder11 As Button
    Friend WithEvents Salads_Button_Placeholder19 As Button
    Friend WithEvents Salads_Button_Placeholder10 As Button
    Friend WithEvents Salads_Button_Placeholder9 As Button
    Friend WithEvents Salads_Button_Placeholder8 As Button
    Friend WithEvents Salads_Button_Placeholder7 As Button
    Friend WithEvents Salads_Button_Placeholder6 As Button
    Friend WithEvents Salads_Button_Placeholder5 As Button
    Friend WithEvents Salads_Button_Placeholder4 As Button
    Friend WithEvents Salads_Button_Placeholder3 As Button
    Friend WithEvents Salads_Button_Placeholder2 As Button
    Friend WithEvents Salads_Button_Placeholder1 As Button
    Friend WithEvents Panel_CatSides As Panel
    Friend WithEvents Sides_Button_Placeholder27 As Button
    Friend WithEvents Sides_Button_Placeholder18 As Button
    Friend WithEvents Sides_Button_Placeholder26 As Button
    Friend WithEvents Sides_Button_Placeholder17 As Button
    Friend WithEvents Sides_Button_Placeholder25 As Button
    Friend WithEvents Sides_Button_Placeholder16 As Button
    Friend WithEvents Sides_Button_Placeholder24 As Button
    Friend WithEvents Sides_Button_Placeholder15 As Button
    Friend WithEvents Sides_Button_Placeholder23 As Button
    Friend WithEvents Sides_Button_Placeholder14 As Button
    Friend WithEvents Sides_Button_Placeholder22 As Button
    Friend WithEvents Sides_Button_Placeholder13 As Button
    Friend WithEvents Sides_Button_Placeholder21 As Button
    Friend WithEvents Sides_Button_Placeholder12 As Button
    Friend WithEvents Sides_Button_Placeholder20 As Button
    Friend WithEvents Sides_Button_Placeholder11 As Button
    Friend WithEvents Sides_Button_Placeholder19 As Button
    Friend WithEvents Sides_Button_Placeholder10 As Button
    Friend WithEvents Sides_Button_Placeholder9 As Button
    Friend WithEvents Sides_Button_Placeholder8 As Button
    Friend WithEvents Sides_Button_Placeholder7 As Button
    Friend WithEvents Sides_Button_Placeholder6 As Button
    Friend WithEvents Sides_Button_Placeholder5 As Button
    Friend WithEvents Sides_Button_Placeholder4 As Button
    Friend WithEvents Sides_Button_Placeholder3 As Button
    Friend WithEvents Sides_Button_Placeholder2 As Button
    Friend WithEvents Sides_Button_Placeholder1 As Button
    Friend WithEvents Panel_CatDrinks As Panel
    Friend WithEvents Drinks_Button_Placeholder27 As Button
    Friend WithEvents Drinks_Button_Placeholder18 As Button
    Friend WithEvents Drinks_Button_Placeholder26 As Button
    Friend WithEvents Drinks_Button_Placeholder17 As Button
    Friend WithEvents Drinks_Button_Placeholder25 As Button
    Friend WithEvents Drinks_Button_Placeholder16 As Button
    Friend WithEvents Drinks_Button_Placeholder24 As Button
    Friend WithEvents Drinks_Button_Placeholder15 As Button
    Friend WithEvents Drinks_Button_Placeholder23 As Button
    Friend WithEvents Drinks_Button_Placeholder14 As Button
    Friend WithEvents Drinks_Button_Placeholder22 As Button
    Friend WithEvents Drinks_Button_Placeholder13 As Button
    Friend WithEvents Drinks_Button_Placeholder21 As Button
    Friend WithEvents Drinks_Button_Placeholder12 As Button
    Friend WithEvents Drinks_Button_Placeholder20 As Button
    Friend WithEvents Drinks_Button_Placeholder11 As Button
    Friend WithEvents Drinks_Button_Placeholder19 As Button
    Friend WithEvents Drinks_Button_Placeholder10 As Button
    Friend WithEvents Drinks_Button_Placeholder9 As Button
    Friend WithEvents Drinks_Button_Placeholder8 As Button
    Friend WithEvents Drinks_Button_Placeholder7 As Button
    Friend WithEvents Drinks_Button_Placeholder6 As Button
    Friend WithEvents Drinks_Button_Placeholder5 As Button
    Friend WithEvents Drinks_Button_Placeholder4 As Button
    Friend WithEvents Drinks_Button_Placeholder3 As Button
    Friend WithEvents Drinks_Button_Placeholder2 As Button
    Friend WithEvents Drinks_Button_Placeholder1 As Button
    Friend WithEvents MainMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As Database_POSSystemDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents Button_Discount20 As Button
    Friend WithEvents Button_Discount15 As Button
    Friend WithEvents Button_Discount10 As Button
End Class
