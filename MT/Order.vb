Public Class Order
    Dim price As Double
    Dim duration As Integer
    Dim details As Orderpanel = orderview.getorder()
    Dim cancel As New Button

    Private Sub Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fclear()
        txtcustname.Text = details.getcustname()
        txtcontact.Text = details.getcontact()
        txtpid.Text = details.getpid
        txtpname.Text = details.getpname
        rtxtdesc.Text = details.getdesc
        rtxtodesc.Text = details.getodesc
        AddHandler cancel.Click, AddressOf cancel_click
        CancelButton = cancel
    End Sub
    Private Sub cancel_click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub
    Function fclear()
        txtcustname.Clear()
        txtcontact.Clear()
        txtpid.Clear()
        txtpname.Clear()
        rtxtdesc.Clear()
        rtxtodesc.Clear()
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim orddetails As New Orderdetails
        orddetails.ShowDialog()
        If orddetails.DialogResult = DialogResult.Yes Then
            setduration(orddetails.getduration())
            setprice(orddetails.getprice())
            approve(0)
            Me.Close()
        End If
    End Sub
    Function approve(ByVal i As Integer)
        Dim sql As String
        If i = 0 Then
            sql = "UPDATE SpecialProduct SET Status='Available',NewPrice=@price,Duration=@duration WHERE SProductID=@id"

        Else
            sql = "UPDATE SpecialProduct SET Status='Rejected',NewPrice=@price,Duration=@duration WHERE SProductID=@id"
        End If
        Dim cmd As New OleDb.OleDbCommand(sql, Welcome.conn)
        If i = 0 Then
            cmd.Parameters.AddWithValue("@price", price)
            cmd.Parameters.AddWithValue("@duration", duration)
        Else
            cmd.Parameters.AddWithValue("@price", 0)
            cmd.Parameters.AddWithValue("@duration", 0)
        End If
        cmd.Parameters.AddWithValue("@id", details.getspid)
        Welcome.conn.Open()
        If cmd.ExecuteNonQuery() = 0 Then
            'fail
        Else
            If i = 0 Then
                Dim str As String = "The customisation order is approved"
                str += " with new price (RM " & price.ToString("0.00") & ") with " & duration.ToString("d") & " month to complete the customisation product"
                MessageBox.Show(str, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf i = 1 Then
                MessageBox.Show("The customisation order is rejected", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
        Welcome.conn.Close()
    End Function
    Function setprice(ByVal price As Double)
        Me.price = price
    End Function
    Function setduration(ByVal duration As Integer)
        Me.duration = duration
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        approve(1)
        Me.Close()
    End Sub
End Class