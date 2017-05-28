Public Class frm_addndelcolour

    Private Sub frm_addndelcolour_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dbconnectcode("Select * from tbl_colour")
        'connects with the contacts table in database

        'disables changes in Contact ID
        DataGridView1.DataSource = dt
        'shows the database records in the data grid
    End Sub

    Private Sub frm_addndelcolour_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnectcode("Select * from tbl_colour")
        'connects with the contacts table in database

        'disables changes in Contact ID
        DataGridView1.DataSource = dt
        'shows the database records in the data grid
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtbox_colour.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        Txtbox_ID.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        'passes value to textboxes
    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        Txtbox_ID.Clear()
        txtbox_colour.Clear()
        'clears the textboxes
        dbconnectcode("Select max(ColourId) from tbl_Colour")
        Txtbox_ID.Text = (dt.Rows(0)(0) + 1)
    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        Dim c As String


        If txtbox_colour.Text = "" Then
            MsgBox("No record selected", MsgBoxStyle.Exclamation)
        Else
            If MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                dbconnectcode("Select * from tbl_colour")
                c = "Delete from tbl_colour where ColourName = '" & txtbox_colour.Text & "'"
                altertable(c)
                'deletes the selected record from the database
                MsgBox("Successfully Deleted")
            End If
            txtbox_colour.Clear()
            Txtbox_ID.Clear()
        End If

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click

        If Txtbox_ID.Text = "" Then
            MsgBox("Please select a record")
        ElseIf txtbox_colour.Text = "" Then
            MsgBox("Please select a record")
        Else
            Dim i As Integer
            Dim a As String
            'your code goes here
            dbconnectcode("Select * from tbl_colour")
            If Txtbox_ID.Text = dt.Rows(i)(0) Then
                'a = "Update tbl_colour set ColourName = '" & Txtbox_ID.Text & "', where ColourId = " & Txtbox_ID.Text
                a = "Update tbl_colour set ColourName = '" & txtbox_colour.Text & "', where ColourId = " & Txtbox_ID.Text
                altertable(a)
                MsgBox("Successfully Updated")
            Else
                a = "Insert into tbl_colour "
                a = a & "values (" & Txtbox_ID.Text & ", '" & txtbox_colour.Text & "')"
                altertable(a)
                MsgBox("Successfully Added")
            End If
            
            dbconnectcode("Select * from tbl_colour")

            frm_mainmenu.Show()
            Me.Hide()


        End If
            

    End Sub

    Private Sub Txtbox_ID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtbox_ID.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

 

   


    Private Sub Txtbox_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtbox_ID.TextChanged

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

    Private Sub txtbox_colour_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtbox_colour.KeyUp

    End Sub


  
    Private Sub txtbox_colour_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_colour.TextChanged

    End Sub

    Private Sub btn_add_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btn_add.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub
End Class