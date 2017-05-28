<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_deleteusers
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
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.btn_clear = New System.Windows.Forms.Button
        Me.btn_adduser = New System.Windows.Forms.Button
        Me.txtbox_password = New System.Windows.Forms.TextBox
        Me.txtbox_confirmpassword = New System.Windows.Forms.TextBox
        Me.txtbox_username = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(242, 146)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 20
        Me.btn_cancel.Text = "cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(80, 146)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 19
        Me.btn_clear.Text = "clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_adduser
        '
        Me.btn_adduser.Location = New System.Drawing.Point(161, 146)
        Me.btn_adduser.Name = "btn_adduser"
        Me.btn_adduser.Size = New System.Drawing.Size(75, 23)
        Me.btn_adduser.TabIndex = 18
        Me.btn_adduser.Text = "Delete Users"
        Me.btn_adduser.UseVisualStyleBackColor = True
        '
        'txtbox_password
        '
        Me.txtbox_password.Location = New System.Drawing.Point(108, 94)
        Me.txtbox_password.Name = "txtbox_password"
        Me.txtbox_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_password.Size = New System.Drawing.Size(213, 20)
        Me.txtbox_password.TabIndex = 17
        '
        'txtbox_confirmpassword
        '
        Me.txtbox_confirmpassword.Location = New System.Drawing.Point(108, 120)
        Me.txtbox_confirmpassword.Name = "txtbox_confirmpassword"
        Me.txtbox_confirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbox_confirmpassword.Size = New System.Drawing.Size(213, 20)
        Me.txtbox_confirmpassword.TabIndex = 16
        Me.txtbox_confirmpassword.UseWaitCursor = True
        '
        'txtbox_username
        '
        Me.txtbox_username.Location = New System.Drawing.Point(108, 66)
        Me.txtbox_username.Name = "txtbox_username"
        Me.txtbox_username.Size = New System.Drawing.Size(213, 20)
        Me.txtbox_username.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Confirm password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Delete Users"
        '
        'frm_deleteusers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 199)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_adduser)
        Me.Controls.Add(Me.txtbox_password)
        Me.Controls.Add(Me.txtbox_confirmpassword)
        Me.Controls.Add(Me.txtbox_username)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_deleteusers"
        Me.Text = "Delete User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_clear As System.Windows.Forms.Button
    Friend WithEvents btn_adduser As System.Windows.Forms.Button
    Friend WithEvents txtbox_password As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_confirmpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_username As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
