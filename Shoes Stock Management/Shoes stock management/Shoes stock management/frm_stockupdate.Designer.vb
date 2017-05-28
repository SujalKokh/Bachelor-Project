<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stockupdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtbox_colour = New System.Windows.Forms.TextBox
        Me.txtbox_size = New System.Windows.Forms.TextBox
        Me.btn_search = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.txtbox_scompanyname = New System.Windows.Forms.TextBox
        Me.btn_add = New System.Windows.Forms.Button
        Me.btn_del = New System.Windows.Forms.Button
        Me.txtbox_add = New System.Windows.Forms.TextBox
        Me.txtbox_dec = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtbox_compnayName = New System.Windows.Forms.TextBox
        Me.txtbox_esize = New System.Windows.Forms.TextBox
        Me.txtbox_erate = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtbox_ecolour = New System.Windows.Forms.TextBox
        Me.btn_update = New System.Windows.Forms.Button
        Me.btn_delete = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtbox_ID = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(162, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Update"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(483, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(350, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Colour"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Company Name"
        '
        'txtbox_colour
        '
        Me.txtbox_colour.Location = New System.Drawing.Point(393, 71)
        Me.txtbox_colour.Name = "txtbox_colour"
        Me.txtbox_colour.Size = New System.Drawing.Size(84, 20)
        Me.txtbox_colour.TabIndex = 23
        '
        'txtbox_size
        '
        Me.txtbox_size.Location = New System.Drawing.Point(516, 72)
        Me.txtbox_size.Name = "txtbox_size"
        Me.txtbox_size.Size = New System.Drawing.Size(50, 20)
        Me.txtbox_size.TabIndex = 22
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(579, 72)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 21
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(71, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(583, 173)
        Me.DataGridView1.TabIndex = 20
        '
        'txtbox_scompanyname
        '
        Me.txtbox_scompanyname.Location = New System.Drawing.Point(195, 71)
        Me.txtbox_scompanyname.Name = "txtbox_scompanyname"
        Me.txtbox_scompanyname.Size = New System.Drawing.Size(149, 20)
        Me.txtbox_scompanyname.TabIndex = 19
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(228, 293)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(75, 23)
        Me.btn_add.TabIndex = 27
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(399, 293)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(75, 23)
        Me.btn_del.TabIndex = 28
        Me.btn_del.Text = "Del"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'txtbox_add
        '
        Me.txtbox_add.Location = New System.Drawing.Point(309, 295)
        Me.txtbox_add.Name = "txtbox_add"
        Me.txtbox_add.Size = New System.Drawing.Size(84, 20)
        Me.txtbox_add.TabIndex = 29
        '
        'txtbox_dec
        '
        Me.txtbox_dec.Location = New System.Drawing.Point(480, 296)
        Me.txtbox_dec.Name = "txtbox_dec"
        Me.txtbox_dec.Size = New System.Drawing.Size(84, 20)
        Me.txtbox_dec.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(132, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "NameOfCompany"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(193, 405)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Size"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(182, 380)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Colour"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(187, 298)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Stock"
        '
        'txtbox_compnayName
        '
        Me.txtbox_compnayName.Location = New System.Drawing.Point(228, 351)
        Me.txtbox_compnayName.Name = "txtbox_compnayName"
        Me.txtbox_compnayName.Size = New System.Drawing.Size(159, 20)
        Me.txtbox_compnayName.TabIndex = 35
        '
        'txtbox_esize
        '
        Me.txtbox_esize.Location = New System.Drawing.Point(228, 403)
        Me.txtbox_esize.Name = "txtbox_esize"
        Me.txtbox_esize.Size = New System.Drawing.Size(159, 20)
        Me.txtbox_esize.TabIndex = 37
        '
        'txtbox_erate
        '
        Me.txtbox_erate.Location = New System.Drawing.Point(228, 429)
        Me.txtbox_erate.Name = "txtbox_erate"
        Me.txtbox_erate.Size = New System.Drawing.Size(159, 20)
        Me.txtbox_erate.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(192, 431)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Rate"
        '
        'txtbox_ecolour
        '
        Me.txtbox_ecolour.Location = New System.Drawing.Point(228, 377)
        Me.txtbox_ecolour.Name = "txtbox_ecolour"
        Me.txtbox_ecolour.Size = New System.Drawing.Size(159, 20)
        Me.txtbox_ecolour.TabIndex = 40
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(224, 458)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 41
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(353, 459)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 42
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(201, 328)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 13)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "ID"
        '
        'txtbox_ID
        '
        Me.txtbox_ID.Location = New System.Drawing.Point(227, 325)
        Me.txtbox_ID.Name = "txtbox_ID"
        Me.txtbox_ID.Size = New System.Drawing.Size(159, 20)
        Me.txtbox_ID.TabIndex = 44
        '
        'frm_stockupdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 485)
        Me.Controls.Add(Me.txtbox_ID)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.txtbox_ecolour)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtbox_erate)
        Me.Controls.Add(Me.txtbox_esize)
        Me.Controls.Add(Me.txtbox_compnayName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbox_dec)
        Me.Controls.Add(Me.txtbox_add)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbox_colour)
        Me.Controls.Add(Me.txtbox_size)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtbox_scompanyname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_stockupdate"
        Me.Text = "Stock Update"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbox_colour As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_size As System.Windows.Forms.TextBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtbox_scompanyname As System.Windows.Forms.TextBox
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents txtbox_add As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_dec As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtbox_compnayName As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_esize As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_erate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtbox_ecolour As System.Windows.Forms.TextBox
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtbox_ID As System.Windows.Forms.TextBox
End Class
