Public Class frm_addcompany
    Dim x As Integer
    Private Sub add_company_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnectcode("Select * from tbl_company")
        If dt.Rows.Count = 0 Then
            x = 0
        Else
            dbconnectcode("Select max(CompanyId) from tbl_company")
            x = dt.Rows(0)(0)
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Dim b As String

        If txtbox_companyName.Text = TextBox1.Text Then
            b = "Insert into tbl_company values (" & x + 1 & ", '" & txtbox_companyName.Text & "')"
            altertable(b)
            'Adds the selected record in the database
            MsgBox("Add Successful")
        Else
            MsgBox("Please make sure of the name of the company", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click
        frm_EditCompany.Show()
        'opens frm_edit company
    End Sub




    Private Sub txtbox_companyName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_companyName.TextChanged

    End Sub



    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class