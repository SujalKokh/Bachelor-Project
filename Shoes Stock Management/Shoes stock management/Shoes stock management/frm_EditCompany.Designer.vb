<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EditCompany
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.txtbox_CompanyName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_edit = New System.Windows.Forms.Button
        Me.txtbox_Id = New System.Windows.Forms.TextBox
        Me.ID = New System.Windows.Forms.Label
        Me.btn_delete = New System.Windows.Forms.Button
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(33, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(247, 195)
        Me.DataGridView1.TabIndex = 0
        '
        'txtbox_CompanyName
        '
        Me.txtbox_CompanyName.Location = New System.Drawing.Point(95, 237)
        Me.txtbox_CompanyName.Name = "txtbox_CompanyName"
        Me.txtbox_CompanyName.Size = New System.Drawing.Size(185, 20)
        Me.txtbox_CompanyName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Company Name"
        '
        'btn_edit
        '
        Me.btn_edit.Location = New System.Drawing.Point(116, 263)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(75, 23)
        Me.btn_edit.TabIndex = 4
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = True
        '
        'txtbox_Id
        '
        Me.txtbox_Id.Location = New System.Drawing.Point(95, 213)
        Me.txtbox_Id.Name = "txtbox_Id"
        Me.txtbox_Id.Size = New System.Drawing.Size(185, 20)
        Me.txtbox_Id.TabIndex = 5
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(54, 218)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(21, 13)
        Me.ID.TabIndex = 6
        Me.ID.Text = " ID"
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(197, 263)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 23)
        Me.btn_delete.TabIndex = 7
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'frm_EditCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 289)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.txtbox_Id)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbox_CompanyName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frm_EditCompany"
        Me.Text = "Edit Company"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtbox_CompanyName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents txtbox_Id As System.Windows.Forms.TextBox
    Friend WithEvents ID As System.Windows.Forms.Label
    Friend WithEvents btn_delete As System.Windows.Forms.Button
End Class
