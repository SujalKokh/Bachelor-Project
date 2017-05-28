Public Class frm_login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If rbtn_admin.Checked = Enabled Then
            dbconnectcode("Select * from tbl_login")
            If rbtn_admin.Enabled = True Then

                Dim i As Integer
                Dim z As Integer
                z = dt.Rows.Count - 1


                If txtbox_username.Text = "" Or txtbox_password.Text = "" Then
                    MsgBox("Empty Username and password")
                    GoTo top
                End If

                For i = 0 To z
                    If txtbox_username.Text = dt.Rows(i)(1) Then
                        If txtbox_password.Text = dt.Rows(i)(2) Then
                            username = txtbox_username.Text
                            status = dt.Rows(i)(2)
                            frm_mainmenu.Show()
                            txtbox_username.Clear()
                            txtbox_password.Clear()
                            Me.Hide()
                            GoTo top
                        End If
                    End If
                Next i
                MsgBox("Invalid username or Password")
                txtbox_username.Clear()
                txtbox_password.Clear()
top:
            End If
        ElseIf rbtn_user.Checked = Enabled Then
            al = al + 1
            frm_mainmenu.Show()
            Me.Hide()
        End If
        'Helps to login into the main form if radio selected button is admin. Code is in btn_ok and it enables to open the main form. 


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        'closes the Login form.
    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_username.TextChanged

    End Sub

    Private Sub frm_login_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

    End Sub

    Private Sub LoginForm1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnectcode("Select * from tbl_login")
        Dim x As Integer
        x = Val(dt.Rows.Count)
        If x = 0 Then
            frm_addusers.Show()

        End If

    End Sub

    Private Sub rbtn_user_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_user.CheckedChanged
        If rbtn_user.Checked = True Then
            txtbox_password.Hide()
            txtbox_username.Hide()
            al = al + 1
            'hides the textboxes if user logins selecting user radio button
        End If
    End Sub

    Private Sub rbtn_admin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtn_admin.CheckedChanged
        If rbtn_admin.Checked = True Then
            txtbox_password.Show()
            txtbox_username.Show()
            al = 0
            'enables the textboxes to enter username and password as admin.
        End If
    End Sub

    Private Sub btn_okuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub UsernameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameLabel.Click

        frm_mainmenu.Show()
        Me.Hide()
    End Sub


End Class