Public Class Feeddetails
    Private Sub Feeddetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim details As Feedbackpanel = Feedback.getfeed()
        fclear()
        TextBox1.Text = details.getname()
        TextBox2.Text = details.getemail()
        TextBox3.Text = details.getfeeddate()
        RichTextBox1.Text = details.gettitle()
        RichTextBox2.Text = details.getfeedback()
        AcceptButton = btnback
        CancelButton = btnback
    End Sub
    Function fclear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        RichTextBox1.Clear()
        RichTextBox2.Clear()
    End Function

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub
End Class