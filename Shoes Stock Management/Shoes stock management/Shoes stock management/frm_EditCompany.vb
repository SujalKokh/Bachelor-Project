Public Class frm_EditCompany

    Private Sub frm_EditCompany_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dbconnectcode("Select * from tbl_company")
        'connects with the contacts table in database

        'disables changes in Contact ID
        'DataGridView1.DataSource = dt
        'shows the database records in the data grid
        dbconnectcode("Select * from tbl_colour")
        Dim s As Integer
        s = dt.Rows.Count
        txtbox_Id.Text = s + 1
    End Sub

    Private Sub frm_EditCompany_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnectcode("Select * from tbl_company")
        'connects with the contacts table in database

        'disables changes in Contact ID
        DataGridView1.DataSource = dt
        'shows the database records in the data grid
        
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtbox_Id.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        txtbox_CompanyName.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        'passes the data in the respective textboxes
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_edit.Click

        Dim b As String
        If txtbox_CompanyName.Text = "" Then
            MsgBox("No record selected", MsgBoxStyle.Exclamation)
        Else
            b = "Update tbl_company set CompanyName = '" & txtbox_CompanyName.Text & "' where CompanyId = " & Val(txtbox_Id.Text)

            altertable(b)
            'updates the selected record in the database
            MsgBox("Update Successful")
        End If
        txtbox_CompanyName.Clear()
        txtbox_Id.Clear()

    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim c As String


        If txtbox_CompanyName.Text = "" Then
            MsgBox("No record selected", MsgBoxStyle.Exclamation)
        Else
            If MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                dbconnectcode("Select * from tbl_company")
                c = "Delete from tbl_company where CompanyName = '" & txtbox_CompanyName.Text & "'"
                altertable(c)
                'deletes the selected record from the database
                MsgBox("Successfully Deleted")
            End If
            txtbox_CompanyName.Clear()
            txtbox_Id.Clear()

        End If
    End Sub

    Private Sub txtbox_Id_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbox_Id.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub




    Private Sub txtbox_Id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_Id.TextChanged

    End Sub

    Private Sub txtbox_CompanyName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbox_CompanyName.KeyPress
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

    Private Sub txtbox_CompanyName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_CompanyName.TextChanged

    End Sub
End Class