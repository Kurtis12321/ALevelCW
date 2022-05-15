<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_ViewReciept
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
        Me.TextBox_CurrentOrderPrices = New System.Windows.Forms.TextBox()
        Me.TextBox_CurrentOrder = New System.Windows.Forms.TextBox()
        Me.TextBox_TotalCost = New System.Windows.Forms.TextBox()
        Me.TextBox_TotalText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox_CurrentOrderPrices
        '
        Me.TextBox_CurrentOrderPrices.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_CurrentOrderPrices.Location = New System.Drawing.Point(257, 54)
        Me.TextBox_CurrentOrderPrices.Multiline = True
        Me.TextBox_CurrentOrderPrices.Name = "TextBox_CurrentOrderPrices"
        Me.TextBox_CurrentOrderPrices.Size = New System.Drawing.Size(105, 552)
        Me.TextBox_CurrentOrderPrices.TabIndex = 1
        '
        'TextBox_CurrentOrder
        '
        Me.TextBox_CurrentOrder.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_CurrentOrder.Location = New System.Drawing.Point(12, 54)
        Me.TextBox_CurrentOrder.Multiline = True
        Me.TextBox_CurrentOrder.Name = "TextBox_CurrentOrder"
        Me.TextBox_CurrentOrder.Size = New System.Drawing.Size(249, 552)
        Me.TextBox_CurrentOrder.TabIndex = 2
        '
        'TextBox_TotalCost
        '
        Me.TextBox_TotalCost.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TotalCost.Location = New System.Drawing.Point(257, 603)
        Me.TextBox_TotalCost.Multiline = True
        Me.TextBox_TotalCost.Name = "TextBox_TotalCost"
        Me.TextBox_TotalCost.Size = New System.Drawing.Size(105, 50)
        Me.TextBox_TotalCost.TabIndex = 3
        Me.TextBox_TotalCost.Text = "0.00"
        '
        'TextBox_TotalText
        '
        Me.TextBox_TotalText.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TotalText.Location = New System.Drawing.Point(136, 603)
        Me.TextBox_TotalText.Multiline = True
        Me.TextBox_TotalText.Name = "TextBox_TotalText"
        Me.TextBox_TotalText.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox_TotalText.Size = New System.Drawing.Size(125, 50)
        Me.TextBox_TotalText.TabIndex = 4
        Me.TextBox_TotalText.Text = "Total:"
        Me.TextBox_TotalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(59, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Current Order Reciept"
        '
        'Button_Close
        '
        Me.Button_Close.Location = New System.Drawing.Point(287, 659)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(75, 31)
        Me.Button_Close.TabIndex = 6
        Me.Button_Close.Text = "Close"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Form_ViewReciept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(376, 701)
        Me.Controls.Add(Me.Button_Close)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_CurrentOrderPrices)
        Me.Controls.Add(Me.TextBox_CurrentOrder)
        Me.Controls.Add(Me.TextBox_TotalCost)
        Me.Controls.Add(Me.TextBox_TotalText)
        Me.Name = "Form_ViewReciept"
        Me.Text = "Form_ViewReciept"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_CurrentOrderPrices As TextBox
    Friend WithEvents TextBox_CurrentOrder As TextBox
    Friend WithEvents TextBox_TotalCost As TextBox
    Friend WithEvents TextBox_TotalText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Close As Button
End Class
