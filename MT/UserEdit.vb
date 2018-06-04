Imports System.ComponentModel

Public Class UserEdit
    Dim Maxrows As Integer
    Dim ds As New DataSet
    Dim current As Integer = 0
    Private Sub UserEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboxacctyperefresh()
        Maxrows = Checkmaxrows()
        If Maxrows = 0 Then
            adduser("default", "staff", "simple", "staff")
        End If
        mergedataset()
        infoshow()
        checkcurrent()
    End Sub

    Private Function cboxacctyperefresh()
        cboxacctype.Items.Clear()
        cboxacctype.Items.Add("staff")
        cboxacctype.Items.Add("manager")
    End Function
    Private Function cboxacctypeindex(ByVal type As String)
        If type = "staff" Then
            cboxacctype.SelectedIndex = 0
        Else
            cboxacctype.SelectedIndex = 1
        End If
    End Function
    Private Function checkcurrent()
        If current = 0 Then
            btnprev.Enabled = False
        Else
            btnprev.Enabled = True
        End If
        If current = Maxrows - 1 Then
            btnnext.Enabled = False
        Else
            btnnext.Enabled = True
        End If
    End Function

    Private Function Checkmaxrows()
        Dim sql As String = "SELECT Count(Username) FROM SUser"
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, Welcome.conn)
        Welcome.conn.Open()
        dr = cmd.ExecuteReader
        dr.Read()
        Dim max As Integer = dr.Item(0)
        Welcome.conn.Close()
        Return max
    End Function
    Private Function infoshow()
        Dim d As DataRow = ds.Tables("User").Rows(current)
        txtname.Text = d.Item(2)
        txtusr.Text = d.Item(0)
        cboxacctypeindex(d.Item(3))
    End Function
    Private Function mergedataset()
        ds.Clear()
        Dim sql As String = "SELECT * FROM SUser"
        Welcome.conn.Open()
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, Welcome.conn)
        da.Fill(ds, "User")
        Welcome.conn.Close()
        Dim maxrow As Integer = ds.Tables("User").Rows.Count
        Me.Maxrows = maxrow
    End Function

    Private Function adduser(ByVal name As String, ByVal username As String, ByVal psw As String, ByVal acctype As String)
        Dim sql As String = "INSERT INTO SUser (Username,Password,StaffName,Usertype) Values (@usr, @psw, @name, @type);"
        Dim cmd As New OleDb.OleDbCommand(sql, Welcome.conn)
        Welcome.conn.Open()
        If Not cmd.ExecuteNonQuery = 0 Then
            MessageBox.Show("The user is created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error has occured. Please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Welcome.conn.Close()
    End Function

    Private Function edituser(ByVal name As String, ByVal username As String, ByVal acctype As String)
        Dim d As DataRow = ds.Tables("User").Rows(current)
        d.Item(0) = username
        d.Item(2) = name
        d.Item(3) = acctype
        Dim sql As String = "SELECT * FROM SUser"
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, Welcome.conn)
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        Welcome.conn.Open()
        da.Update(ds, "User")
        Welcome.conn.Close()
    End Function
    Private Function deleteuser()
        Dim d As DataRow = ds.Tables("User").Rows(current)
        d.Delete()
        Dim sql As String = "SELECT * FROM SUser"
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, Welcome.conn)
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        Welcome.conn.Open()
        da.Update(ds, "User")
        Welcome.conn.Close()
    End Function

    Private Function checkchanges()
        Dim d As DataRow = ds.Tables("User").Rows(current)
        Dim i As Integer() = {0, 0, 0}
        If Not txtname.Text = d.Item(2) Then
            i(0) = 1
        End If
        If Not txtusr.Text = d.Item(0) Then
            i(1) = 1
        End If
        If Not cboxacctype.Text = d.Item(3) Then
            i(2) = 1
        End If
        Return i
    End Function

    Private Function checkischanged()
        Dim cflag As Integer() = checkchanges()
        For i As Integer = 0 To cflag.GetUpperBound(0)
            If cflag(i) = 1 Then
                Return 1
            End If
        Next
        Return 0
    End Function
    Private Function checkadmin()
        Dim flag As Integer = 0
        For i As Integer = 0 To Maxrows - 1
            Dim d As DataRow = ds.Tables("User").Rows(i)
            If d.Item(3) = "staff" Then
                flag += 1
            End If
            If flag = 2 Then
                Return 0
            End If
        Next
        Return 1
    End Function
    Private Sub btnprev_Click(sender As Object, e As EventArgs) Handles btnprev.Click
        current -= 1
        infoshow()
        checkcurrent()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        current += 1
        infoshow()
        checkcurrent()
    End Sub

    Private Sub btneditdetails_Click(sender As Object, e As EventArgs) Handles btneditdetails.Click
        If checkischanged() = 0 Then
            Exit Sub
        End If
        Dim changes As Integer() = checkchanges()
        If changes(2) = 1 Then
            If checkadmin() = 1 Then
                Dim d As DataRow = ds.Tables("User").Rows(current)
                If Equals(d.Item(3), "staff") Then
                    MessageBox.Show("This is the last staff account. Any modification will not be allowed on this account", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    infoshow()
                    Exit Sub
                End If
            End If
        End If
        makechanges()
    End Sub
    Function makechanges()
        If MessageBox.Show("Do you wish to edit the details of this account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            edituser(txtname.Text, txtusr.Text, cboxacctype.Text)
        Else
            infoshow()
        End If
    End Function

    Private Sub btneditpsw_Click(sender As Object, e As EventArgs) Handles btneditpsw.Click
        UserEditPassword.ShowDialog()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If checkadmin() = 1 Then
            Dim d As DataRow = ds.Tables("User").Rows(current)
            If Equals(d.Item(3), "staff") Then
                MessageBox.Show("This is the last staff account. Any modification will not be allowed on this account", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                infoshow()
                Exit Sub
            End If
        End If
        deleteuser()
        current = 0
        mergedataset()
        infoshow()
        checkcurrent()
    End Sub

    Private Sub UserEdit_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        User.Show()
    End Sub
End Class