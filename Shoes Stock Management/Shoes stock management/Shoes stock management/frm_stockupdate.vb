Public Class frm_stockupdate

    Private Sub frm_stockupdate_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dbconnectcode("Select * from tbl_stock")
        'connects with the contacts table in database

        'disables changes in Contact ID
        DataGridView1.DataSource = dt
        'shows the database records in the data grid
        Dim s As Integer
        dbconnectcode("Select * from tbl_stock")
        s = dt.Rows.Count
        txtbox_ID.Text = s + 1
    End Sub

    Private Sub stock_update_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbconnectcode("Select * from tbl_stock")
        'connects with the contacts table in database

        'disables changes in Contact ID
        DataGridView1.DataSource = dt
        'shows the database records in the data grid
    End Sub

    Private Sub btn_edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtbox_ID.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        txtbox_compnayName.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
        txtbox_ecolour.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
        txtbox_esize.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
        txtbox_erate.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_search.Click
        If txtbox_scompanyname.Text = "" Then
            dbconnectcode("Select * from tbl_stock")
            DataGridView1.DataSource = dt
            'shows all the database records in the data grid
        Else
            dbconnectcode("Select * from tbl_Stock where CompanyName= '" & txtbox_scompanyname.Text & "'")
            DataGridView1.DataSource = dt
            'shows the information of the person that user intends to by typing the name of the person
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim b As String
        If txtbox_compnayName.Text = "" Then
            MsgBox("No record selected", MsgBoxStyle.Exclamation)
        Else
            b = "Update tbl_stock set CompanyName = '" & txtbox_compnayName.Text & "', Colour = '" & txtbox_ecolour.Text & "', [Size] = " & txtbox_esize.Text & " where StockId = " & Val(txtbox_ID.Text)
            altertable(b)
            'updates the selected record in the database
            MsgBox("Update Successful")
        End If
        txtbox_compnayName.Clear()
        txtbox_ecolour.Clear()
        txtbox_esize.Clear()
        txtbox_erate.Clear()
        txtbox_add.Clear()
        txtbox_dec.Clear()
        'clears the textboxes}

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim c As String


        If txtbox_compnayName.Text = "" Then
            MsgBox("No record selected", MsgBoxStyle.Exclamation)
        Else
            If MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                dbconnectcode("Select * from tbl_stock")
                c = "Delete from tbl_stock where CompanyName = '" & txtbox_compnayName.Text & "'"
                altertable(c)
                'deletes the selected record from the database
                MsgBox("Successfully Deleted")
            End If

        End If
        txtbox_compnayName.Clear()
        txtbox_ecolour.Clear()
        txtbox_esize.Clear()
        txtbox_erate.Clear()
        txtbox_add.Clear()
        txtbox_dec.Clear()
        'clears the textboxes



    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtbox_compnayName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_compnayName.TextChanged

    End Sub

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        dbconnectcode("Select * from tbl_Stock where StockId= " & txtbox_ID.Text)
        Dim s As Integer
        s = dt.Rows(0)(4)
        altertable("Update tbl_Stock set Stock = " & (s + txtbox_add.Text) & " where StockId = " & txtbox_ID.Text)
        MsgBox("Done")
    End Sub

    Private Sub btn_dec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        dbconnectcode("Select * from tbl_Stock where StockId= " & txtbox_ID.Text)
        Dim s As Integer
        s = dt.Rows(0)(4)
        altertable("Update tbl_Stock set Stock = " & (s - txtbox_dec.Text) & " where StockId = " & txtbox_ID.Text)
        MsgBox("Done")
    End Sub

    Private Sub txtbox_add_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbox_add.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub


    Private Sub txtbox_add_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_add.TextChanged

    End Sub

    Private Sub txtbox_ID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbox_ID.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If


    End Sub


    Private Sub txtbox_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_ID.TextChanged
        

    End Sub

    Private Sub txtbox_dec_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbox_dec.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

    Private Sub txtbox_dec_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_dec.TextChanged

    End Sub

    Private Sub txtbox_erate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbox_erate.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

    Private Sub txtbox_erate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_erate.TextChanged

    End Sub

    Private Sub txtbox_esize_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbox_esize.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) Then
                MsgBox("Only numbers please!!!")
                e.KeyChar = ""
                'digit validity check
            End If
        End If
    End Sub

    Private Sub txtbox_esize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_esize.TextChanged

    End Sub

    Private Sub txtbox_ecolour_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbox_ecolour.KeyPress
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

    Private Sub txtbox_ecolour_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbox_ecolour.TextChanged

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