Imports System.ComponentModel

Public Class Feedback
    Dim details As New Feedbackpanel

    Dim feedbackds As New DataSet
    Dim rowcounter As Integer = 0

    Dim feedpanel(10) As Panel
    Dim pnltitle(10) As Panel
    Dim pnlfeed(10) As Panel
    Dim feedtitle(10) As Label
    Dim pnlfeedtext(10) As Panel
    Dim feedtext(10) As TextBox
    Dim fpnlreadmore(10) As FlowLayoutPanel
    Dim feedreadmore(10) As LinkLabel

    Dim separator(9) As Panel
    Dim scroll As Label
    Function fclear()
        feedbackds = getfeedbackds()
        refreshpanel()
        calculatefeedback(0)
        Label2.Text = "Pending Request : " & feedbackds.Tables("Feedback").Rows.Count.ToString("d") & " Feedback"
        TextBox1.Text = "1"
        getpagenum()
        Panel1.Focus()
    End Function

    Private Sub Feedback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refreshfilterlist()
        fclear()
        AcceptButton = btnback
    End Sub
    Function refreshfilterlist()
        cboxfilter.Items.Clear()
        cboxfilter.ResetText()
        cboxfilter.DropDownStyle = ComboBoxStyle.DropDownList
        cboxfilter.Items.Add("none")
        cboxfilter.Items.Add("only feedback")
        cboxfilter.Items.Add("only enquiry")
        cboxfilter.Items.Add("only comment")
        cboxfilter.Items.Add("only feedback and enquiry")
        cboxfilter.Items.Add("only feedback and comment")
        cboxfilter.Items.Add("only enquiry and comment")
        cboxfilter.SelectedIndex = 0
    End Function
    Function getfeedbackds()
        Dim sql As String = "SELECT * FROM Feedback"
        If cboxfilter.Text = "none" Then

        ElseIf cboxfilter.Text = "only feedback" Then
            sql += " WHERE FeedbackType = 'Feedback'"
        ElseIf cboxfilter.Text = "only enquiry" Then
            sql += " WHERE FeedbackType = 'Enquiry'"
        ElseIf cboxfilter.Text = "only comment" Then
            sql += " WHERE FeedbackType = 'Comment'"
        ElseIf cboxfilter.Text = "only feedback and enquiry" Then
            sql += " WHERE FeedbackType = 'Feedback' OR FeedbackType = 'Enquiry'"
        ElseIf cboxfilter.Text = "only feedback and comment" Then
            sql += " WHERE FeedbackType = 'Feedback' OR FeedbackType = 'Comment'"
        ElseIf cboxfilter.Text = "only enquiry and comment" Then
            sql += " WHERE FeedbackType = 'Enquiry' OR FeedbackType = 'Comment'"
        End If
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, Welcome.conn)
        Welcome.conn.Open()
        da.Fill(ds, "Feedback")
        Welcome.conn.Close()
        Return ds
    End Function
    Function refreshpanel()
        For i As Integer = 0 To 9
            Panel2.Controls.Remove(feedpanel(i))
        Next
        Me.Controls.Remove(scroll)
    End Function
    Function calculatefeedback(ByVal sfrom As Integer)
        sfrom = sfrom \ 10 * 10
        Dim maxrow As Integer = feedbackds.Tables("Feedback").Rows.Count - 1
        Dim number As Integer = 0
        If maxrow < sfrom + 9 Then
            number = maxrow - sfrom + 1
        Else
            number = 10
        End If
        addfeed(sfrom, number)
    End Function
    Function detecttype(ByVal rowcounter As Integer)
        Dim d As DataRow = feedbackds.Tables("Feedback").Rows(rowcounter)

    End Function
    Function addfeed(ByVal sfrom As Integer, ByVal number As Integer)
        number -= 1
        rowcounter = sfrom
        For i As Integer = 0 To number
            Dim d As DataRow = feedbackds.Tables("Feedback").Rows(rowcounter)
            feedpanel(i) = New Panel
            pnltitle(i) = New Panel
            pnlfeed(i) = New Panel

            feedtitle(i) = New Label
            pnlfeedtext(i) = New Panel
            feedtext(i) = New TextBox
            fpnlreadmore(i) = New FlowLayoutPanel
            feedreadmore(i) = New LinkLabel

            With feedpanel(i)
                .Dock = DockStyle.Top
                .Height = 100
                .Width = Panel2.Width
                .BackColor = originalcolour(d.Item(3))
                .Name = i
            End With
            With pnltitle(i)
                .Dock = DockStyle.Top
                .Height = 30
                .BackColor = originalcolour(d.Item(3))
                .Name = i
                .BorderStyle = BorderStyle.FixedSingle
            End With
            With pnlfeed(i)
                .Dock = DockStyle.Top
                .Height = 70
                .Padding = New Padding(5, 5, 5, 5)
                .Name = i
                .BackColor = originalcolour(d.Item(3))
                .BorderStyle = BorderStyle.FixedSingle

            End With

            With feedtitle(i)
                .Text = "Sent from : " & d.Item(2)
                .Font = New Font("Sans Serif", 20, FontStyle.Regular)
                .AutoSize = True
                .Name = i
            End With

            With pnlfeedtext(i)
                .Dock = DockStyle.Top
                .Height = 40
                .Name = i
                .BackColor = originalcolour(d.Item(3))
            End With
            With feedtext(i)
                .Text = d.Item(4)
                .Multiline = True
                .Enabled = False
                .Dock = DockStyle.Fill
                .BorderStyle = BorderStyle.None
                .Name = i
            End With

            With fpnlreadmore(i)
                .Dock = DockStyle.Bottom
                .Height = 20
                .FlowDirection = FlowDirection.RightToLeft
                .Name = i
                .BackColor = originalcolour(d.Item(3))
            End With
            With feedreadmore(i)
                .Text = "Read more"
                .Name = i
                .Margin = New Padding(0, 5, 0, 0)
            End With
            'click
            AddHandler feedpanel(i).Click, AddressOf panelclicked
            AddHandler pnltitle(i).Click, AddressOf panelclicked
            AddHandler pnlfeed(i).Click, AddressOf panelclicked
            AddHandler pnlfeedtext(i).Click, AddressOf panelclicked
            AddHandler feedtext(i).Click, AddressOf panelclicked
            AddHandler feedtitle(i).Click, AddressOf panelclicked
            AddHandler feedreadmore(i).Click, AddressOf panelclicked
            AddHandler fpnlreadmore(i).Click, AddressOf panelclicked
            'mouse hover
            AddHandler feedpanel(i).MouseHover, AddressOf panelhover
            AddHandler pnltitle(i).MouseHover, AddressOf panelhover
            AddHandler pnlfeed(i).MouseHover, AddressOf panelhover
            AddHandler pnlfeedtext(i).MouseHover, AddressOf panelhover
            AddHandler feedtext(i).MouseHover, AddressOf panelhover
            AddHandler feedtitle(i).MouseHover, AddressOf panelhover
            AddHandler feedreadmore(i).MouseHover, AddressOf panelhover
            AddHandler fpnlreadmore(i).MouseHover, AddressOf panelhover
            'mouse leave
            AddHandler feedpanel(i).MouseLeave, AddressOf panelleave
            AddHandler pnltitle(i).MouseLeave, AddressOf panelleave
            AddHandler pnlfeed(i).MouseLeave, AddressOf panelleave
            AddHandler pnlfeedtext(i).MouseLeave, AddressOf panelleave
            AddHandler feedtext(i).MouseLeave, AddressOf panelleave
            AddHandler feedtitle(i).MouseLeave, AddressOf panelleave
            AddHandler feedreadmore(i).MouseLeave, AddressOf panelleave
            AddHandler fpnlreadmore(i).MouseLeave, AddressOf panelleave
            If i > 0 Then
                Dim j As Integer = i - 1
                separator(j) = New Panel
                With separator(j)
                    .Height = 5
                    .BackColor = Panel2.BackColor
                    .Dock = DockStyle.Top
                End With
            End If
            rowcounter += 1
        Next
        printfeedback(number)
    End Function
    Function printfeedback(ByVal number As Integer)
        For i As Integer = number To 0 Step -1
            Panel2.Controls.Add(feedpanel(i))

            feedpanel(i).Controls.Add(pnlfeed(i))
            feedpanel(i).Controls.Add(pnltitle(i))

            pnltitle(i).Controls.Add(feedtitle(i))

            pnlfeed(i).Controls.Add(pnlfeedtext(i))
            pnlfeedtext(i).Controls.Add(feedtext(i))

            pnlfeed(i).Controls.Add(fpnlreadmore(i))
            fpnlreadmore(i).Controls.Add(feedreadmore(i))
            If (i - 1) >= 0 Then
                Dim j As Integer = i - 1
                Panel2.Controls.Add(separator(j))
            End If

        Next
        scroll = New Label
        Dim yloc As Integer = (100 * (number + 1)) + (5 * (number + 1)) + 10 + Panel1.Height
        With scroll
            .Location = New Point(0, yloc)
            .Size = New Size(0, 0)
        End With
        Me.Controls.Add(scroll)
    End Function
    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub

    Private Sub panelclicked(ByVal sender As Object, ByVal e As EventArgs)
        Dim test
        If TypeOf sender Is Panel Then
            test = CType(sender, Panel)
        ElseIf TypeOf sender Is Label Then
            test = CType(sender, Label)
        ElseIf TypeOf sender Is LinkLabel Then
            test = CType(sender, LinkLabel)
        ElseIf TypeOf sender Is TextBox Then
            test = CType(sender, TextBox)
        ElseIf TypeOf sender Is FlowLayoutPanel Then
            test = CType(sender, FlowLayoutPanel)
        End If
        Dim index As Integer = Integer.Parse(test.Name)
        rowcounter = rowcounter \ 10 * 10
        rowcounter += index
        Dim d As DataRow = feedbackds.Tables("Feedback").Rows(rowcounter)
        details.setfeed(d.Item(3), d.Item(4), d.Item(1), d.Item(2), d.Item(5))
        Feeddetails.ShowDialog()
    End Sub
    Private Sub panelhover(ByVal sender As Object, ByVal e As EventArgs)
        Dim test
        If TypeOf sender Is Panel Then
            test = CType(sender, Panel)
        ElseIf TypeOf sender Is Label Then
            test = CType(sender, Label)
        ElseIf TypeOf sender Is LinkLabel Then
            test = CType(sender, LinkLabel)
        ElseIf TypeOf sender Is TextBox Then
            test = CType(sender, TextBox)
        ElseIf TypeOf sender Is FlowLayoutPanel Then
            test = CType(sender, FlowLayoutPanel)
        End If
        Dim index As Integer = Integer.Parse(test.Name)
        rowcounter = rowcounter \ 10 * 10
        rowcounter += index
        Dim d As DataRow = feedbackds.Tables("Feedback").Rows(rowcounter)
        feedpanel(index).BackColor = hovercolour(d.Item(3))
        pnltitle(index).BackColor = hovercolour(d.Item(3))
        pnlfeedtext(index).BackColor = hovercolour(d.Item(3))
        pnlfeed(index).BackColor = hovercolour(d.Item(3))
        fpnlreadmore(index).BackColor = hovercolour(d.Item(3))
    End Sub
    Private Sub panelleave(ByVal sender As Object, ByVal e As EventArgs)
        Dim test
        If TypeOf sender Is Panel Then
            test = CType(sender, Panel)
        ElseIf TypeOf sender Is Label Then
            test = CType(sender, Label)
        ElseIf TypeOf sender Is LinkLabel Then
            test = CType(sender, LinkLabel)
        ElseIf TypeOf sender Is TextBox Then
            test = CType(sender, TextBox)
        ElseIf TypeOf sender Is FlowLayoutPanel Then
            test = CType(sender, FlowLayoutPanel)
        End If
        Dim index As Integer = Integer.Parse(test.Name)
        rowcounter = rowcounter \ 10 * 10
        rowcounter += index
        Dim d As DataRow = feedbackds.Tables("Feedback").Rows(rowcounter)
        feedpanel(index).BackColor = originalcolour(d.Item(3))
        pnltitle(index).BackColor = originalcolour(d.Item(3))
        pnlfeedtext(index).BackColor = originalcolour(d.Item(3))
        pnlfeed(index).BackColor = originalcolour(d.Item(3))
        fpnlreadmore(index).BackColor = originalcolour(d.Item(3))
    End Sub

    Function getfeed()
        Return details
    End Function
    Function getpagenum()
        Dim pagenum As Integer = feedbackds.Tables("Feedback").Rows.Count
        pagenum \= 10
        pagenum += 1
        lblpage.Text = "Total page :" & vbTab & pagenum.ToString("d")
    End Function
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            MessageBox.Show("Invalid page number")
            TextBox1.Text = "1"

        End If
    End Sub

    Private Sub Feedback_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Welcome.loginflag = 1 Then
            Staff.Show()
        End If
    End Sub

    Function hovercolour(ByVal type As String)
        If Equals(type, "Feedback") Then
            Return Color.LightSkyBlue
        ElseIf Equals(type, "Enquiry") Then
            Return Color.NavajoWhite
        ElseIf Equals(type, "Comment") Then
            Return Color.LightGreen
        End If
    End Function
    Function originalcolour(ByVal type As String)
        If Equals(type, "Feedback") Then
            Return Color.LightBlue
        ElseIf Equals(type, "Enquiry") Then
            Return Color.BlanchedAlmond
        ElseIf Equals(type, "Comment") Then
            Return Color.PaleGreen
        End If
    End Function

    Private Sub cboxfilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxfilter.SelectedIndexChanged
        fclear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button1.Click
        TextBox1.Text = "1"
    End Sub
End Class