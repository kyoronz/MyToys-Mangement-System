Public Class Inventoryaddproduct
    Dim validation As New validation()
    Private Sub Inventoryaddproduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fclear()
        AcceptButton = btnconfirm
        CancelButton = btncancel
    End Sub
    Function add()
        Welcome.conn.Open()
        Dim sql As String = "SELECT ProductID FROM Product ORDER BY ProductID DESC"
        Dim cmd As New OleDb.OleDbCommand(sql, Welcome.conn)
        Dim dr As OleDb.OleDbDataReader
        dr = cmd.ExecuteReader
        Dim auto As New autonumber()
        Dim id As String
        If dr.HasRows() Then
            dr.Read()
            auto.setid(dr.Item(0))
            id = auto.getnextid(1)
        Else
            id = "PR000001"
        End If
        sql = "INSERT INTO Product (ProductID,ProductName,ProductPrice,ProductType,ProductQuantity,ProductDesc) Values (@id,@name,@price,@type,0,@desc);"
        cmd = New OleDb.OleDbCommand(sql, Welcome.conn)
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@name", TextBox1.Text)
        cmd.Parameters.AddWithValue("@price", TextBox2.Text)
        cmd.Parameters.AddWithValue("@type", ComboBox1.Text)
        'quantity=0
        cmd.Parameters.AddWithValue("@desc", RichTextBox1.Text)
        If cmd.ExecuteNonQuery = 0 Then
            'fail

        Else
            'success
            MessageBox.Show("The details is added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Welcome.conn.Close()

        Return True
    End Function
    Function checkvalid()
        If all_empty() = True Then
            Return False
        End If
        If validation.is_num(TextBox2.Text) = False Then
            Return False
        End If
        Return True
    End Function
    Function all_empty()
        If validation.is_empty(TextBox1.Text) Then
            Return True
        ElseIf validation.is_empty(TextBox2.Text) Then
            Return True
        ElseIf validation.is_empty(ComboBox1.SelectedIndex = 0) Then 'check this may got prob
            Return True
        ElseIf validation.is_empty(RichTextBox1.Text) Then
            Return True
        End If
        Return False
    End Function
    Function fclear()
        TextBox1.Clear()
        TextBox2.Clear()
        RichTextBox1.ResetText()
        category()
    End Function
    Function category()
        ComboBox1.Items.Clear()
        ComboBox1.ResetText()
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Items.Add("action figures")
        ComboBox1.Items.Add("dress up toys")
        ComboBox1.Items.Add("cooking toys")
        ComboBox1.Items.Add("baby toys")
        ComboBox1.Items.Add("education toys")
        ComboBox1.Items.Add("outdoor play")
        ComboBox1.Items.Add("lego toys")
        ComboBox1.Items.Add("vehicles or toys")
        ComboBox1.Items.Add("video games")
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        If checkvalid() = False Then
            MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        add()
        'message box for success
        Me.Close()
        InventoryView.fclear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub

    Private Sub btnconfirm_Click(sender As Object, e As EventArgs) Handles btnconfirm.Click
        If checkvalid() = False Then
            MessageBox.Show("Invalid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        add()
        'message box for success
        Me.Close()
        InventoryView.fclear()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
End Class