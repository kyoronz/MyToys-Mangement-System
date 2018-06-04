Imports System.Text.RegularExpressions
Public Class UserEditPassword
    Private Sub UserEditPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub
    Function containempty()
        Dim valid As New validation()
        If valid.is_empty(txtusr.Text) = True Then
            Return True
        End If
        If valid.is_empty(txtnewpsw.Text) = True Then
            Return True
        End If
        If valid.is_empty(txtrepsw.Text) = True Then
            Return True
        End If
        If valid.is_empty(txtoldpsw.Text) = True Then
            Return True
        End If
        Return False
    End Function
    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        If Finduser(txtusr.Text, txtoldpsw.Text) = 0 Then
            If Checkpassword(txtnewpsw.Text) = 0 Then
                If Checksame(txtnewpsw.Text, txtrepsw.Text) = 0 Then
                    If containempty() = False Then
                        Updatepsw(txtusr.Text, txtnewpsw.Text)
                        Me.Close()
                    Else
                        MessageBox.Show("Please fill in all the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Private Function Finduser(ByVal username As String, ByVal psw As String)
        Dim sql As String = "SELECT * FROM SUser WHERE Username = @usr AND Password = @psw"
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, Welcome.conn)
        cmd.Parameters.AddWithValue("@usr", username)
        cmd.Parameters.AddWithValue("@psw", psw)
        Welcome.conn.Open()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Welcome.conn.Close()
            Return 0
        End If
        Welcome.conn.Close()
        MessageBox.Show("Username and password is not match.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Return 1
    End Function
    Private Function Checkpassword(ByVal psw As String)
        If Not Regex.Match(psw, "^[0-9a-zA-Z]*$").Success Then
            MessageBox.Show("Only alphanumeric characters is allowed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtnewpsw.Clear()
            txtrepsw.Clear()
            Return 1
        End If
        Return 0
    End Function
    Private Function Checksame(ByVal psw As String, ByVal psw2 As String)
        If Not psw = psw2 Then
            MessageBox.Show("New password and re-enter password is not matched.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtnewpsw.Clear()
            txtrepsw.Clear()
            Return 1
        End If
        Return 0
    End Function
    Private Function Updatepsw(ByVal username As String, ByVal psw As String)
        Dim sql As String = "UPDATE SUser SET [Password]=@psw WHERE Username=@usr"
        Dim cmd As New OleDb.OleDbCommand(sql, Welcome.conn)
        cmd.Parameters.AddWithValue("@psw", psw)
        cmd.Parameters.AddWithValue("@usr", username)
        Welcome.conn.Open()
        If cmd.ExecuteNonQuery = 0 Then
            MessageBox.Show("Password change is fail. Please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Password is changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Welcome.conn.Close()
    End Function
    Private Function Clear()
        txtusr.Clear()
        txtoldpsw.Clear()
        txtnewpsw.Clear()
        txtrepsw.Clear()
    End Function
End Class