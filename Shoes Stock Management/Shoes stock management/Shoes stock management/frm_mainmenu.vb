
Public Class frm_mainmenu

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
        'closes the main menu
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        frm_stockupdate.Show()
        'shows stock update form.
    End Sub

    Private Sub btn_view_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_view.Click
        frm_viewstocks.Show()
        'shows stock view form
    End Sub

    Private Sub btn_bkrs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bkrs.Click
        frm_backupandrestore.Show()
        'shoes backup and restoring form
    End Sub

    Private Sub btn_pwdchange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pwdchange.Click
        frm_passwordchange.Show()
        'shows password changing form
    End Sub

    Private Sub btn_printrpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_printrpt.Click
        frm_Printreport.Show()
        'shows report printing form
    End Sub

    Private Sub btn_additem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addcompany.Click
        frm_addcompany.Show()
        'shows form to add company.
    End Sub

    Private Sub btn_addndeladm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addndeladm.Click
        frm_addndelusers.Show()
        'shows form which adds and delete admin users.
    End Sub

    Private Sub Mainmenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If al > 1 Then
            btn_update.Hide()
            btn_bkrs.Hide()
            btn_addcompany.Hide()
            btn_pwdchange.Hide()
            btn_addndeladm.Hide()
            btn_addndelcolour.Hide()


        Else
            btn_update.Show()
            btn_bkrs.Show()
            btn_addcompany.Show()
            btn_pwdchange.Show()
            btn_addndeladm.Show()
            btn_addndelcolour.Show()

        End If
        'Enables or disables the major action buttons of the main menu according tho the user type.
    End Sub

    Private Sub btn_deletecompany_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_gotologin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gotologin.Click
        frm_login.Show()
        al = 0
        Me.Close()
        'takes to login screen and resets value of a to zero
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addndelcolour.Click
        frm_addndelcolour.Show()
        'shows add and delete colour form

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
