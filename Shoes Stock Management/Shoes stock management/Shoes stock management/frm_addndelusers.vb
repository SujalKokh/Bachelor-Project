Public Class frm_addndelusers

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frm_addusers.Show()
        Me.Hide()
        'opens addusers form 
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frm_deleteusers.Show()
        'opens deleteusers form
    End Sub

    Private Sub frm_addndelusers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class