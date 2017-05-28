<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_passwordchange
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
        Me.btn_pwdchange = New System.Windows.Forms.Button
        Me.txtbox_newpassword = New System.Windows.Forms.TextBox
        Me.txtbox_currentpassword = New System.Windows.Forms.TextBox
        Me.txtbox_username = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtbox_confirmpassword = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbn_cancel = New System.Windows.Forms.Button
        Me.deleteAdminUsers = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_pwdchange
        '
        Me.btn_pwdchange.Location = New System.Drawing.Point(33, 216)
        Me.btn_pwdchange.Name = "btn_pwdchange"
        Me.btn_pwdchange.Size = New System.Drawing.Size(79, 34)
        Me.btn_pwdchange.TabIndex = 0
        Me.btn_pwdchange.Text = "change passowrd"
        Me.btn_pwdchange.UseVisualStyleBackColor = True
        '
        'txtbox_newpassword
        '
        Me.txtbox_newpassword.Location = New System.Drawing.Point(131, 130)
        Me.txtbox_newpassword.Name = "txtbox_newpassword"
        Me.txtbox_newpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_newpassword.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_newpassword.TabIndex = 1
        '
        'txtbox_currentpassword
        '
        Me.txtbox_currentpassword.Location = New System.Drawing.Point(131, 104)
        Me.txtbox_currentpassword.Name = "txtbox_currentpassword"
        Me.txtbox_currentpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_currentpassword.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_currentpassword.TabIndex = 2
        '
        'txtbox_username
        '
        Me.txtbox_username.Location = New System.Drawing.Point(131, 78)
        Me.txtbox_username.Name = "txtbox_username"
        Me.txtbox_username.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_username.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Current password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "new password"
        '
        'txtbox_confirmpassword
        '
        Me.txtbox_confirmpassword.Location = New System.Drawing.Point(131, 153)
        Me.txtbox_confirmpassword.Name = "txtbox_confirmpassword"
        Me.txtbox_confirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_confirmpassword.Size = New System.Drawing.Size(100, 20)
        Me.txtbox_confirmpassword.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "confirm new password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Password change interface"
        '
        'tbn_cancel
        '
        Me.tbn_cancel.Location = New System.Drawing.Point(152, 216)
        Me.tbn_cancel.Name = "tbn_cancel"
        Me.tbn_cancel.Size = New System.Drawing.Size(79, 34)
        Me.tbn_cancel.TabIndex = 10
        Me.tbn_cancel.Text = "Cancel"
        Me.tbn_cancel.UseVisualStyleBackColor = True
        '
        'deleteAdminUsers
        '
        Me.deleteAdminUsers.AutoSize = True
        Me.deleteAdminUsers.Location = New System.Drawing.Point(172, 50)
        Me.deleteAdminUsers.Name = "deleteAdminUsers"
        Me.deleteAdminUsers.Size = New System.Drawing.Size(100, 13)
        Me.deleteAdminUsers.TabIndex = 11
        Me.deleteAdminUsers.Text = "Delete Admin Users"
        '
        'frm_passwordchange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.deleteAdminUsers)
        Me.Controls.Add(Me.tbn_cancel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbox_confirmpassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbox_username)
        Me.Controls.Add(Me.txtbox_currentpassword)
        Me.Controls.Add(Me.txtbox_newpassword)
        Me.Controls.Add(Me.btn_pwdchange)
        Me.Name = "frm_passwordchange"
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_pwdchange As System.Windows.Forms.Button
    Friend WithEvents txtbox_newpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_currentpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbox_confirmpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbn_cancel As System.Windows.Forms.Button
    Friend WithEvents deleteAdminUsers As System.Windows.Forms.Label
End Class
