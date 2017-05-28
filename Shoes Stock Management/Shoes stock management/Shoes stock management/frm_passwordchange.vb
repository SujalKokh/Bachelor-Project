Public Class frm_passwordchange

    Private Sub tbn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbn_cancel.Click
        Me.Close()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteAdminUsers.Click
        frm_deleteusers.Show()
        Me.Hide()

    End Sub

    Private Sub btn_pwdchange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pwdchange.Click
        If txtbox_UserName.Text = "" Or txtbox_currentpassword.Text = "" Or txtbox_newpassword.Text = "" Or txtbox_ConfirmPassword.Text = "" Then
            MsgBox("Required parameters are missing", MsgBoxStyle.Exclamation)
            'empty data check alert
            GoTo top
        End If
        dbconnectcode("Select * from tbl_login")
        'connect with the logintable in database file
        Dim i As Integer
        Dim z As Integer
        'declaration of variables used for iterations
        z = dt.Rows.Count - 1

        For i = 0 To z
            If txtbox_username.Text = dt.Rows(i)(1) Then
                If txtbox_currentpassword.Text = dt.Rows(i)(2) Then
                    'checking the username and password in database
                    If txtbox_newpassword.Text = txtbox_confirmpassword.Text Then



                        altertable("Update tbl_login set [PassWord] = '" & txtbox_newpassword.Text & "' where UserName = '" & txtbox_username.Text & "'")
                        'updates the existing password with new password after correct confirmation
                        MsgBox("Successfully changed password")
                      
                        'closes the change password form and displays the login form
                        
                    Else
                        MsgBox("Please confirm your new password", MsgBoxStyle.Exclamation)
                        'confirmation error alert
                        txtbox_confirmpassword.Clear()
                        txtbox_newpassword.Clear()
                        'clears the textboxes
                        GoTo top

                    End If
                    txtbox_username.Clear()
                    txtbox_currentpassword.Clear()
                    txtbox_confirmpassword.Clear()
                    txtbox_newpassword.Clear()
                    'clears the textboxes
                    GoTo top
                End If
            End If

        Next i
        If MsgBox("Invalid Username or password. Do you wish to retry?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            'invalid username or password alert
            txtbox_username.Clear()
            txtbox_currentpassword.Clear()
            txtbox_confirmpassword.Clear()
            txtbox_newpassword.Clear()
            'clears the textboxes
            frm_login.Show()
            Me.Hide()
        Else
            txtbox_username.Clear()
            txtbox_currentpassword.Clear()
            txtbox_confirmpassword.Clear()
            txtbox_newpassword.Clear()
            'clears the textboxes
        End If
top:
    End Sub

    Private Sub txtbox_username_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbox_username.KeyPress


    End Sub

    Private Sub txtbox_username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_username.TextChanged

    End Sub

    Private Sub frm_passwordchange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class