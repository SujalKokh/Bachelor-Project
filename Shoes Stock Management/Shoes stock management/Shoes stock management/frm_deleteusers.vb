Public Class frm_deleteusers

    Private Sub btn_adduser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_adduser.Click
        MsgBox("Invalid Username or password")
        Dim c As String
        dbconnectcode("Select * from tbl_login")
        'connecting with the login table of database
        Try

            Dim i As Integer
            For i = 0 To (dt.Rows.Count - 1)
                If txtbox_username.Text = dt.Rows(i)(1) Then
                    'checking if the username exixts
                    If txtbox_password.Text = dt.Rows(i)(2) Then
                        'checking whether the password and usertype matches with the respective username
                        If MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            c = "Delete from tbl_login where UserName = '" & txtbox_username.Text & "'"
                            altertable(c)
                            'deletes the selected user account
                            MsgBox("Successfully Deleted")
                        End If
                        dbconnectcode("Select * from tbl_login")
                        If dt.Rows.Count = 0 Then
                            frm_login.Show()
                            Me.Hide()
                            'displays login form
                        Else
                            frm_mainmenu.Show()
                            Me.Close()
                            'displays main form
                        End If
                        GoTo top
                    End If
                End If
            Next i
            MsgBox("Invalid Username, Usertype or password", MsgBoxStyle.Critical)
            'invalid username, usertype or password check
        Catch ex As Exception
            'error message
            MsgBox(ex.Message)

        End Try
top:
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Me.Hide()
        'hides the form
    End Sub

    Private Sub frm_deleteusers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        txtbox_confirmpassword.Clear()
        txtbox_password.Clear()
        txtbox_username.Clear()
    End Sub
End Class