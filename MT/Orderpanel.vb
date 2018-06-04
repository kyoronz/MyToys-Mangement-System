Public Class Orderpanel
    Dim custname As String
    Dim contact As String
    Dim pid As String
    Dim pname As String
    Dim desc As String
    Dim odesc As String
    Dim spid As String
    Function setfeed(ByVal custname As String, ByVal contact As String, ByVal pid As String, ByVal pname As String, ByVal desc As String, ByVal spid As String)
        Me.custname = custname
        Me.contact = contact
        Me.pid = pid
        Me.pname = pname
        Me.desc = desc
        Me.spid = spid
        Welcome.conn.Open()
        Dim sql As String = "SELECT ProductDesc FROM Product WHERE ProductID = @id"
        Dim cmd As New OleDb.OleDbCommand(sql, Welcome.conn)
        cmd.Parameters.AddWithValue("@id", pid)
        Dim dr As OleDb.OleDbDataReader
        dr = cmd.ExecuteReader()
        If dr.HasRows() Then
            dr.Read()
            Me.odesc = dr.Item(0)
        Else
            'error
        End If
        Welcome.conn.Close()
    End Function
    Function getcustname()
        Return custname
    End Function
    Function getcontact()
        Return contact
    End Function
    Function getpid()
        Return pid
    End Function
    Function getpname()
        Return pname
    End Function
    Function getdesc()
        Return desc
    End Function
    Function getodesc()
        Return odesc
    End Function
    Function getspid()
        Return spid
    End Function
End Class
