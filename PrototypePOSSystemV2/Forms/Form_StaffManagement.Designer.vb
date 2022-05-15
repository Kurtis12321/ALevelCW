<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_StaffManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_StaffManagement))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_ViewStaff = New System.Windows.Forms.Button()
        Me.Button_EditStaff = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "POS System  |  Manage Staff"
        '
        'Button_ViewStaff
        '
        Me.Button_ViewStaff.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ViewStaff.Location = New System.Drawing.Point(33, 46)
        Me.Button_ViewStaff.Name = "Button_ViewStaff"
        Me.Button_ViewStaff.Size = New System.Drawing.Size(90, 30)
        Me.Button_ViewStaff.TabIndex = 27
        Me.Button_ViewStaff.Text = "View Staff"
        Me.Button_ViewStaff.UseVisualStyleBackColor = True
        '
        'Button_EditStaff
        '
        Me.Button_EditStaff.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_EditStaff.Location = New System.Drawing.Point(33, 82)
        Me.Button_EditStaff.Name = "Button_EditStaff"
        Me.Button_EditStaff.Size = New System.Drawing.Size(90, 30)
        Me.Button_EditStaff.TabIndex = 27
        Me.Button_EditStaff.Text = "Edit Staff"
        Me.Button_EditStaff.UseVisualStyleBackColor = True
        '
        'Form_StaffManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(153, 133)
        Me.Controls.Add(Me.Button_EditStaff)
        Me.Controls.Add(Me.Button_ViewStaff)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_StaffManagement"
        Me.Text = "Staff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button_ViewStaff As Button
    Friend WithEvents Button_EditStaff As Button
End Class
