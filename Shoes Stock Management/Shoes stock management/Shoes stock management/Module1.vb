Imports System.Data.OleDb

Module Module1
    Public al As Integer
    Public dbcon As OleDbConnection
    Public dbcmd As OleDbCommand
    Public dbadapter As OleDbDataAdapter
    Public db As DataSet
    Public dt As DataTable
    Public connectionstring As String = "provider=microsoft.jet.OLEDB.4.0; data source= shoestocks.mdb"
    Public username As String
    Public status As String



    Public Function dbconnectcode(ByVal sql As String)
        dbcon = New OleDbConnection(connectionstring)
        dbcmd = New OleDbCommand(sql, dbcon)
        dbcon.Open()
        dbadapter = New OleDbDataAdapter(sql, dbcon)
        db = New DataSet("TABLE")
        dbadapter.Fill(db, "TABLE")
        'create new instance of table so that row an be accessed
        dt = db.Tables("TABLE")
        Return dt
    End Function
    Public Function altertable(ByVal sql As String)
        dbcmd = New OleDbCommand(sql, dbcon)
        dbcmd.ExecuteNonQuery()
        Return dt

    End Function
End Module

