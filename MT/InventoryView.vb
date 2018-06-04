Imports System.ComponentModel

Public Class InventoryView
    Function getproductset()
        Welcome.conn.Open()
        Dim sql As String = "SELECT * FROM Product"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, Welcome.conn)
        da.Fill(ds, "Product")

        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Product"

        Welcome.conn.Close()
    End Function
    Private Sub InventoryView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fclear()
        CancelButton = btnback
    End Sub

    Private Sub btnaddproduct_Click(sender As Object, e As EventArgs) Handles btnaddproduct.Click
        Inventoryaddproduct.ShowDialog()
    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        If checkvalid() = False Then
            Exit Sub
        End If
        updateproduct()
        fclear()
    End Sub

    Function checkempty()
        Dim validation As New validation()
        If validation.is_empty(TextBox1.Text) = True Then
            Return True
        ElseIf validation.is_empty(TextBox2.Text) = True Then
            Return True
        ElseIf validation.is_empty(ComboBox1.Text) = True Then
            Return True
        End If
        Return False
    End Function
    Function checkvalid()
        Dim valid As New validation()
        If checkempty() = True Then
            'empty error
            MessageBox.Show("The details is not complete. Please fill in the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        ElseIf valid.is_num(TextBox2.Text) = False Then
            MessageBox.Show("Invalid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return False
        End If

        Return True
    End Function
    Function status()
        ComboBox1.Items.Clear()
        ComboBox1.ResetText()
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Items.Add("Check in")
        ComboBox1.Items.Add("Check out")
    End Function
    Function fclear()
        status()
        getproductset()
        TextBox1.Clear()
        TextBox2.Clear()
        RichTextBox1.Clear()
    End Function
    Function addinventory()
        Welcome.conn.Open()
        Dim auto As New autonumber()
        Dim sql As String = "SELECT InventoryID FROM Inventory ORDER BY InventoryID DESC"
        Dim cmd As New OleDb.OleDbCommand(sql, Welcome.conn)
        Dim dr As OleDb.OleDbDataReader
        dr = cmd.ExecuteReader
        Dim id As String
        If dr.HasRows() Then
            dr.Read()
            auto.setid(dr.Item(0))
            id = auto.getnextid(3)
        Else
            id = "IN000001"
        End If
        dr.Close()
        sql = "INSERT INTO Inventory Values @invid,＠id,@quantity,@status,@date"
        cmd = New OleDb.OleDbCommand(sql, Welcome.conn)
        cmd.Parameters.AddWithValue("@invid", id)
        cmd.Parameters.AddWithValue("@id", TextBox1.Text)
        cmd.Parameters.AddWithValue("@quantity", TextBox2.Text)
        cmd.Parameters.AddWithValue("@status", ComboBox1.SelectedText)
        cmd.Parameters.AddWithValue("@date", Date.Now)
        If cmd.ExecuteNonQuery() = 0 Then
            'fail
        Else
            'success
            MessageBox.Show("The details is added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function
    Function getquantity()
        Welcome.conn.Open()
        Dim sql As String = "SELECT * FROM Product WHERE ProductID=@id"
        Dim cmd As New OleDb.OleDbCommand(sql, Welcome.conn)
        cmd.Parameters.AddWithValue("@id", TextBox1.Text)
        Dim dr As OleDb.OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            Dim quantity As Integer = 0
            quantity = dr.Item(4)
            Welcome.conn.Close()
            Return quantity
        Else
            Welcome.conn.Close()
            Return "error"
        End If
    End Function

    Function updateproduct()
        Dim quantity As Integer = 0
        If Equals(getquantity(), "error") Then
            'no such id
            MessageBox.Show("Invalid Product ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Return False
        Else
            quantity = getquantity()
        End If
        If Equals(quantityforupdate(quantity), "error") Then
            Return 1
        End If
        Dim i As Integer = quantityforupdate(quantity)
        quantity = i
        Dim sql As String = "UPDATE Product SET ProductQuantity=@quantity WHERE ProductID=@id"
        Dim cmd As New OleDb.OleDbCommand(sql, Welcome.conn)
        cmd.Parameters.AddWithValue("@quantity", (quantity))
        cmd.Parameters.AddWithValue("@id", TextBox1.Text)
        Welcome.conn.Open()
        If cmd.ExecuteNonQuery() = 0 Then
            'success
            Welcome.conn.Close()
            addinventory()
            Return 0
        Else
            'fail
            Welcome.conn.Close()
            Return 2
        End If
    End Function
    Function quantityforupdate(ByVal quantity As Integer)
        If ComboBox1.SelectedIndex = 0 Then 'check in
            quantity += Integer.Parse(TextBox2.Text)
            Return quantity
        ElseIf quantity >= Integer.Parse(TextBox2.Text) Then
            quantity -= Integer.Parse(TextBox2.Text)
            Return quantity
        Else
            MessageBox.Show("Invalid Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Return "error"
        End If


    End Function
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim row As Integer = e.RowIndex
        If row = -1 Then
            Exit Sub
        End If
        TextBox1.Text = DataGridView1.Rows(row).Cells(0).Value
        RichTextBox1.Text = DataGridView1.Rows(row).Cells(5).Value
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        fclear()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub

    Private Sub InventoryView_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Welcome.loginflag = 1 Then
            Staff.Show()
        End If
    End Sub
End Class