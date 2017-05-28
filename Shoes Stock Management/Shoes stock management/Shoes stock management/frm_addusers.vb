Public Class frm_addusers
    Dim x As Integer
    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        txtbox_password.Clear()
        txtbox_confirmpassword.Clear()
        txtbox_username.Clear()
        'clears textboxes
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Hide()
        'hides the form
    End Sub

    Private Sub btn_adduser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adduser.Click
        'doesn't adds username and password in the database
        Dim x As Integer
        If txtbox_username.Text = "" Then
            MsgBox("Please enter the User Name")
        ElseIf txtbox_password.Text = "" Then
            MsgBox("Please enter the Password")
        ElseIf txtbox_confirmpassword.Text = "" Then
            MsgBox("Please enter for Password Confirmation")

        Else

            Try
                'your code goes here
                dbconnectcode("Select * from tbl_login")

                Dim a As String
                x = dt.Rows.Count
                If txtbox_confirmpassword.Text = txtbox_password.Text Then
                    a = "Insert into tbl_login "
                    a = a & "values (" & x + 1 & ", '" & txtbox_username.Text & "' , '" & txtbox_password.Text & "')"
                    MsgBox("Successfully Added")
                    dbconnectcode("Select * from tbl_login")
                    If dt.Rows.Count = 1 Then

                    End If
                    frm_mainmenu.Show()
                    Me.Hide()
                Else
                    MsgBox("Please confirm your password correctly")
                End If
            Catch ex As Exception
                'error message
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    Private Sub frm_addusers_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtbox_confirmpassword.Clear()
        txtbox_password.Clear()
        txtbox_username.Clear()
    End Sub


    Private Sub addndel_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dbconnectcode("Select * from tbl_login")
        Dim x As Integer
        x = dt.Rows.Count
        If x <> 0 Then
            Label6.Hide()
            Label5.Hide()
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        frm_deleteusers.Show()
        'opens frm_deleteusers
    End Sub

    Private Sub txtbox_username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_username.TextChanged

    End Sub

    Private Sub txtbox_password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_password.TextChanged

    End Sub
End Class