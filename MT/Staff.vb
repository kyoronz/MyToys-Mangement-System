Imports System.ComponentModel

Public Class Staff
    Dim i As Integer = 0
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click
        Dim Fbutton As Button = CType(sender, Button)
        Dim i As Integer = Integer.Parse(Fbutton.Name.Substring(6))
        Me.i = i
        Me.Close()
    End Sub

    Private Sub Staff_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Select Case (i)
            Case 0 And 5
                Login.Show()
            Case 1
                orderview.Show()
            Case 2
                Feedback.Show()
            Case 3
                InventoryView.Show()
            Case 4
                User.Show()
            Case Else
                Login.Show()
        End Select
    End Sub

    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = 0

    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click, Label3.Click, Label4.Click, Label5.Click
        Dim flabel As Label = CType(sender, Label)
        Dim i As Integer = Integer.Parse(flabel.Name.Substring(5))
        Me.i = i
        Me.Close()
    End Sub

    Private Sub Label_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover, Label2.MouseHover, Label3.MouseHover, Label4.MouseHover, Label5.MouseHover
        Dim flabel As Label = CType(sender, Label)
        Dim i As Integer = Integer.Parse(flabel.Name.Substring(5))
        Dim c = Me.Controls.Find(("Button" + i.ToString("d")), True)
        Dim fbutton As Button = c(0)
        fbutton.FlatStyle = FlatStyle.Flat
        flabel.ForeColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub Label_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave, Label2.MouseLeave, Label3.MouseLeave, Label4.MouseLeave, Label5.MouseLeave
        Dim flabel As Label = CType(sender, Label)
        Dim i As Integer = Integer.Parse(flabel.Name.Substring(5))
        Dim c = Me.Controls.Find(("Button" + i.ToString("d")), True)
        Dim fbutton As Button = c(0)
        fbutton.FlatStyle = FlatStyle.Standard
        flabel.ForeColor = SystemColors.ControlText
    End Sub

    Private Sub Button_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover, Button2.MouseHover, Button3.MouseHover, Button4.MouseHover, Button5.MouseHover
        Dim fbutton As Button = CType(sender, Button)
        Dim i As Integer = Integer.Parse(fbutton.Name.Substring(6))
        Dim c = Me.Controls.Find(("Label" + i.ToString("d")), True) 'it return control collection
        c(0).ForeColor = Color.FromArgb(255, 255, 192) 'thats why here use arry
        fbutton.FlatStyle = FlatStyle.Flat
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave, Button3.MouseLeave, Button4.MouseLeave, Button5.MouseLeave
        Dim fbutton As Button = CType(sender, Button)
        Dim i As Integer = Integer.Parse(fbutton.Name.Substring(6))
        Dim c = Me.Controls.Find(("Label" + i.ToString("d")), True)
        c(0).ForeColor = SystemColors.ControlText
        fbutton.FlatStyle = FlatStyle.Standard
    End Sub
End Class