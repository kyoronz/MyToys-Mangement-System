Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnlogin
        CancelButton = btnexit
        Welcome.loginflag = 0

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If checkexist(txtusr.Text, txtpsw.Text) = 0 Then
            If checktype(txtusr.Text, txtpsw.Text) = "staff" Then
                Welcome.loginflag = 1
            ElseIf checktype(txtusr.Text, txtpsw.Text) = "manager" Then
                Welcome.loginflag = 2
            End If
            proceed(Welcome.loginflag)
        End If
    End Sub

    Private Function checkexist(ByVal username As String, ByVal psw As String)
        Dim sql As String = "SELECT * FROM SUser WHERE Username = @usr AND Password = @psw"
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, Welcome.conn)
        cmd.Parameters.AddWithValue("@usr", username)
        cmd.Parameters.AddWithValue("@psw", psw)
        Welcome.conn.Open()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            lblalert1.Text = " "
            Welcome.conn.Close()
            Return 0
        End If
        Welcome.conn.Close()
        lblalert1.Text = "Username and Password is not matched"
        txtpsw.Clear()
        txtusr.Clear()
        Return 1
    End Function

    Private Function checktype(ByVal username As String, ByVal psw As String)
        Dim sql As String = "SELECT * FROM SUser WHERE Username = @usr AND Password = @psw"
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, Welcome.conn)
        cmd.Parameters.AddWithValue("@usr", username)
        cmd.Parameters.AddWithValue("@psw", psw)
        Welcome.conn.Open()
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim type As String = dr.Item(3)
        Welcome.conn.Close()
        Return type
    End Function

    Private Function proceed(ByVal type As Integer)
        txtclear()
        Me.Close()
        If type = 1 Then
            ''enter staff
            Staff.Show()
        ElseIf type = 2 Then
            ''enter management
            Manager.Show()
        End If
    End Function

    Private Function txtclear()
        txtusr.Clear()
        txtpsw.Clear()
        lblalert1.Text = ""
    End Function

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub
End Class