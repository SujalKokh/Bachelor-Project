Public Class frm_viewstocks

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub frm_viewstocks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnectcode("Select * from tbl_stock")
        'connects with the contacts table in database

        'disables changes in Contact ID
        DataGridView1.DataSource = dt
        'shows the database records in the data grid

    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        If txtbox_search.Text = "" Then
            dbconnectcode("Select * from tbl_stock")
            DataGridView1.DataSource = dt
            'shows all the database records in the data grid
        Else
            dbconnectcode("Select * from tbl_Stock where CompanyName= '" & txtbox_search.Text & "'")
            DataGridView1.DataSource = dt
            'shows the information of the person that user intends to by typing the name of the person
        End If
    End Sub

    Private Sub txtbox_colour_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbox_colour.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) _
And (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 32) And (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only text please!!!")
                e.KeyChar = ""
                'text validity check
            End If
        End If
    End Sub

    Private Sub txtbox_colour_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_colour.TextChanged

    End Sub

    Private Sub txtbox_size_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbox_size.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

    Private Sub txtbox_size_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_size.TextChanged

    End Sub
End Class