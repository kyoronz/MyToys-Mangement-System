Imports System.ComponentModel

Public Class orderview
    Dim details As New Orderpanel
    Function getorder()
        Return details
    End Function

    Dim orderds As New DataSet
    Function getorderds()
        Dim sql As String = "SELECT * FROM SpecialProduct WHERE Status='Pending' ORDER BY SProductID ASC" '!!!!!!!!!!!!
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, Welcome.conn)
        Welcome.conn.Open()
        da.Fill(ds, "Order")
        Welcome.conn.Close()
        Return ds
    End Function


    Dim rowcounter As Integer

    Dim orderpanel(10) As Panel
    Dim pnltitle(10) As Panel
    Dim pnlcontent(10) As Panel
    Dim lblordtitle(10) As Label

    Dim lblcustomer(10) As Label
    Dim lbldetails(10) As LinkLabel
    Dim separator(9) As Panel
    Dim scroll As Label

    Function fclear()
        orderds = getorderds()
        refreshpanel()
        calculateorder(0)
        Label2.Text = "Pending Request : " & orderds.Tables("Order").Rows.Count.ToString("d") & " customisation request"
        TextBox1.Text = "1"
        getpagenum()
        Panel1.Focus()

    End Function

    Private Sub detailsclicked(ByVal sender As Object, ByVal e As EventArgs)
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
        Dim d As DataRow = orderds.Tables("Order").Rows(rowcounter)
        details.setfeed(d.Item(5), d.Item(6), d.Item(1), d.Item(2), d.Item(3), d.Item(0))
        Order.ShowDialog()
        fclear()
    End Sub
    Private Sub detailshover(ByVal sender As Object, ByVal e As EventArgs)
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
        orderpanel(index).BackColor = Color.NavajoWhite
        pnltitle(index).BackColor = Color.NavajoWhite
        pnlcontent(index).BackColor = Color.NavajoWhite
        lbldetails(index).BackColor = Color.NavajoWhite
        lblcustomer(index).BackColor = Color.NavajoWhite
        lblordtitle(index).BackColor = Color.NavajoWhite
    End Sub
    Private Sub detailsleave(ByVal sender As Object, ByVal e As EventArgs)
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
        orderpanel(index).BackColor = Color.BlanchedAlmond
        pnltitle(index).BackColor = Color.BlanchedAlmond
        pnlcontent(index).BackColor = Color.BlanchedAlmond
        lbldetails(index).BackColor = Color.BlanchedAlmond
        lblcustomer(index).BackColor = Color.BlanchedAlmond
        lblordtitle(index).BackColor = Color.BlanchedAlmond
    End Sub
    Private Sub orderview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fclear()
        CancelButton = btnback
    End Sub


    Function refreshpanel()
        For i As Integer = 0 To 9
            Panel2.Controls.Remove(orderpanel(i))
        Next
        Me.Controls.Remove(scroll)
    End Function
    Function calculateorder(ByVal sfrom As Integer)
        sfrom = sfrom \ 10 * 10
        Dim maxrow As Integer = orderds.Tables("Order").Rows.Count - 1
        Dim number As Integer = 0
        If maxrow < sfrom + 9 Then
            number = maxrow - sfrom + 1
        Else
            number = 10
        End If
        addorder(sfrom, number)
    End Function
    Function addorder(ByVal sfrom As Integer, ByVal number As Integer)
        number -= 1
        rowcounter = sfrom
        For i As Integer = 0 To number
            Dim d As DataRow = orderds.Tables("Order").Rows(rowcounter)
            'assign panel here
            orderpanel(i) = New Panel
            pnltitle(i) = New Panel
            pnlcontent(i) = New Panel
            lblordtitle(i) = New Label
            lblcustomer(i) = New Label
            lbldetails(i) = New LinkLabel

            With orderpanel(i)
                .Dock = DockStyle.Top
                .Height = 70
                .Name = i
                .BackColor = Color.BlanchedAlmond
            End With
            With pnltitle(i)
                .Dock = DockStyle.Top
                .Height = 40
                .Name = i
                .BorderStyle = BorderStyle.FixedSingle
                .BackColor = Color.BlanchedAlmond
            End With
            With pnlcontent(i)
                .Dock = DockStyle.Top
                .Height = 30
                .Name = i
                .BorderStyle = BorderStyle.FixedSingle
                .Padding = New Padding(5, 5, 5, 0)
                .BackColor = Color.BlanchedAlmond
            End With
            With lblordtitle(i)
                .Text = d.Item(2)
                .Name = "title" + i.ToString("00")
                .Font = New Font("Sans Serif", 17, FontStyle.Regular)
                .AutoSize = True
                .Name = i
                .BackColor = Color.BlanchedAlmond
            End With
            With lblcustomer(i)
                .Dock = DockStyle.Left
                .Text = "Ordered by : " & vbTab & d.Item(5)
                .AutoSize = True
                .Name = i
                .BackColor = Color.BlanchedAlmond
            End With
            With lbldetails(i)
                .Dock = DockStyle.Right
                .Text = "Details"
                .Name = i
                .BackColor = Color.BlanchedAlmond
            End With
            'click
            AddHandler lbldetails(i).Click, AddressOf detailsclicked
            AddHandler orderpanel(i).Click, AddressOf detailsclicked
            AddHandler pnltitle(i).Click, AddressOf detailsclicked
            AddHandler pnlcontent(i).Click, AddressOf detailsclicked
            AddHandler lblcustomer(i).Click, AddressOf detailsclicked
            AddHandler lblordtitle(i).Click, AddressOf detailsclicked
            'mousehover
            AddHandler lbldetails(i).MouseHover, AddressOf detailshover
            AddHandler orderpanel(i).MouseHover, AddressOf detailshover
            AddHandler pnltitle(i).MouseHover, AddressOf detailshover
            AddHandler pnlcontent(i).MouseHover, AddressOf detailshover
            AddHandler lblcustomer(i).MouseHover, AddressOf detailshover
            AddHandler lblordtitle(i).MouseHover, AddressOf detailshover
            'mouseleave
            AddHandler lbldetails(i).MouseLeave, AddressOf detailsleave
            AddHandler orderpanel(i).MouseLeave, AddressOf detailsleave
            AddHandler pnltitle(i).MouseLeave, AddressOf detailsleave
            AddHandler pnlcontent(i).MouseLeave, AddressOf detailsleave
            AddHandler lblcustomer(i).MouseLeave, AddressOf detailsleave
            AddHandler lblordtitle(i).MouseLeave, AddressOf detailsleave

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
        printorder(number)
    End Function
    Function printorder(ByVal number As Integer)
        For i As Integer = number To 0 Step -1
            'add panel here
            Panel2.Controls.Add(orderpanel(i))
            orderpanel(i).Controls.Add(pnlcontent(i))
            orderpanel(i).Controls.Add(pnltitle(i))
            pnltitle(i).Controls.Add(lblordtitle(i))
            pnlcontent(i).Controls.Add(lblcustomer(i))
            pnlcontent(i).Controls.Add(lbldetails(i))
            If (i - 1) >= 0 Then
                Dim j As Integer = i - 1
                Panel2.Controls.Add(separator(j))
            End If
        Next
        scroll = New Label
        Dim yloc As Integer = (70 * (number + 1)) + (5 * (number + 1)) + 10 + Panel1.Height
        With scroll
            .Location = New Point(0, yloc)
            .Size = New Size(0, 0)
        End With
        Me.Controls.Add(scroll)
    End Function

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            MessageBox.Show("Invalid page number")
            fclear()
        End If
    End Sub

    Function getpagenum()
        Dim pagenum As Integer = orderds.Tables("Order").Rows.Count
        pagenum \= 10
        pagenum += 1
        lblpage.Text = "Total page :" & vbTab & pagenum.ToString("d")
    End Function

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub

    Private Sub orderview_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Welcome.loginflag = 1 Then
            Staff.Show()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button1.Click
        TextBox1.Text = "1"
    End Sub

End Class