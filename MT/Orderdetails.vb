Imports System.ComponentModel

Public Class Orderdetails
    Dim price As Double
    Dim duration As Integer
    Dim a As Integer = 0
    Function fclear()
        durationlist()
        TextBox1.Clear()
    End Function
    Function durationlist()
        ComboBox1.Items.Clear()
        ComboBox1.ResetText()
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
    End Function
    Function checkvalid()
        Dim valid As New validation
        If valid.is_empty(TextBox1.Text) = True Then
            MessageBox.Show("Please complete the details before proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        ElseIf valid.is_empty(ComboBox1.Text) = True Then
            MessageBox.Show("Please complete the details before proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        If valid.is_num(TextBox1.Text) = False Then
            MessageBox.Show("Invalid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If
        Return True
    End Function

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        If checkvalid() = False Then
            Exit Sub
        End If
        Me.price = Double.Parse(TextBox1.Text)
        Me.duration = Integer.Parse(ComboBox1.Text)
        Me.a = 1
        Me.Close()
    End Sub

    Private Sub Orderdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fclear()
        CancelButton = btncancel
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Function getduration()
        Return duration
    End Function
    Function getprice()
        Return price
    End Function

    Private Sub Orderdetails_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Me.a = 0 Then
            Me.DialogResult = DialogResult.No
        ElseIf Me.a = 1 Then
            Me.DialogResult = DialogResult.Yes
        End If
    End Sub
End Class