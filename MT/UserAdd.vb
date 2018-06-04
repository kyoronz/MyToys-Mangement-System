Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class UserAdd
    Private Function Checkuser(ByVal username As String)
        Dim sql As String = "SELECT * FROM SUser WHERE Username = @usr"
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, Welcome.conn)
        cmd.Parameters.AddWithValue("@usr", username)
        Welcome.conn.Open()
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            Welcome.conn.Close()
            Return 0
        End If
        Welcome.conn.Close()
        Return 1
    End Function

    Private Function adduser(ByVal name As String, ByVal username As String, ByVal psw As String, ByVal acctype As String)
        Dim sql As String = "INSERT INTO SUser ([Username],[Password],[StaffName],[Usertype]) Values (@usr, @psw, @name, @type);"
        Dim cmd As New OleDb.OleDbCommand(sql, Welcome.conn)
        cmd.Parameters.AddWithValue("@usr", txtusr.Text)
        cmd.Parameters.AddWithValue("@psw", txtpsw.Text)
        cmd.Parameters.AddWithValue("@name", txtname.Text)
        cmd.Parameters.AddWithValue("type", cboxacctype.Text)
        Welcome.conn.Open()
        If Not cmd.ExecuteNonQuery = 0 Then
            MessageBox.Show("The user is created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' MessageBox.Show("Error has occured. Please try again later", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Welcome.conn.Close()
    End Function
    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        If checkvalid(txtname.Text, txtusr.Text, txtpsw.Text, txtrepsw.Text, cboxacctype.Text) = 0 Then
            If Checkuser(txtusr.Text) = 1 Then
                adduser(txtname.Text, txtusr.Text, txtpsw.Text, cboxacctype.Text)
            Else
                MessageBox.Show("Same username is used by other user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Please fill in all the details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtname.Clear()
        txtusr.Clear()
        txtpsw.Clear()
        txtrepsw.Clear()
        cboxacctyperefresh()

    End Sub

    Private Sub UserAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboxacctyperefresh()
    End Sub

    Private Function cboxacctyperefresh()
        cboxacctype.Items.Clear()
        cboxacctype.ResetText()
        cboxacctype.DropDownStyle = ComboBoxStyle.DropDownList
        cboxacctype.Items.Add("staff")
        cboxacctype.Items.Add("manager")
    End Function

    Dim times As Integer() = {0, 0, 0, 0, 0}
    Private Function checkvalid(ByVal name As String, ByVal username As String, ByVal psw As String, ByVal repsw As String, ByVal acctype As String)
        Dim flag As Integer = 0
        If name = "" Then
            flag = 1
            lblalert1.Text = ""
        Else
            If Not Regex.Match(name, "^[0-9a-zA-Z]*$").Success Then
                txtname.Clear()
                lblalert1.Text = "Only alphanumeric characters is allowed"
                flag = 1
            Else
                lblalert1.Text = ""
            End If
        End If

        If username = "" Then
            flag = 1
            lblalert2.Text = ""
        Else
            If Not Regex.Match(username, "^[0-9a-zA-Z]*$").Success Then
                txtusr.Clear()
                lblalert2.Text = "Only alphanumeric characters is allowed"
                flag = 1
            Else
                lblalert2.Text = ""
            End If
        End If

        If psw = "" Then
            flag = 1
            lblalert3.Text = ""
        Else
            If psw.Length < 6 Then
                lblalert3.Text = "Password required 6 character or more and only alphanumeric character are allowed"
                flag = 1
            Else
                lblalert3.Text = ""
            End If
        End If

        If repsw = "" Then
            flag = 1
            lblalert4.Text = ""
        Else
            If Not psw = repsw Then
                lblalert4.Text = "Password is not matched with the previous password"
                flag = 1
            Else
                lblalert4.Text = ""
            End If
        End If

        If acctype = "" Then
            flag = 1
        End If

        If flag = 1 Then
            Return 1
        End If
        Return 0

    End Function
    Private Sub txtname_Leave(sender As Object, e As EventArgs) Handles txtname.Leave
        times(0) += 1
        If times(0) > 2 Then
            checkvalid(txtname.Text, txtusr.Text, txtpsw.Text, txtrepsw.Text, cboxacctype.SelectedText)
        End If
    End Sub
    Private Sub txtusr_Leave(sender As Object, e As EventArgs) Handles txtusr.Leave
        times(1) += 1
        If times(1) > 2 Then
            checkvalid(txtname.Text, txtusr.Text, txtpsw.Text, txtrepsw.Text, cboxacctype.SelectedText)
        End If
    End Sub
    Private Sub txtpsw_Leave(sender As Object, e As EventArgs) Handles txtpsw.Leave
        times(2) += 1
        If times(2) > 2 Then
            checkvalid(txtname.Text, txtusr.Text, txtpsw.Text, txtrepsw.Text, cboxacctype.SelectedText)
        End If
    End Sub
    Private Sub txtrepsw_Leave(sender As Object, e As EventArgs) Handles txtrepsw.Leave
        times(3) += 1
        If times(3) > 2 Then
            checkvalid(txtname.Text, txtusr.Text, txtpsw.Text, txtrepsw.Text, cboxacctype.SelectedText)
        End If
    End Sub
    Private Sub cboxacctype_Leave(sender As Object, e As EventArgs) Handles cboxacctype.Leave
        times(4) += 1
        If times(4) > 2 Then
            checkvalid(txtname.Text, txtusr.Text, txtpsw.Text, txtrepsw.Text, cboxacctype.SelectedText)
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click

        Me.Close()
    End Sub

    Private Sub UserAdd_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        User.Show()
    End Sub
End Class