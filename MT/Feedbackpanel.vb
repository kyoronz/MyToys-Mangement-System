Public Class Feedbackpanel
    Dim title As String
    Dim feedback As String
    Dim name As String
    Dim email As String
    Dim feeddate As Date
    Function setfeed(ByVal title As String, ByVal feedback As String, ByVal name As String, ByVal email As String, ByVal feeddate As Date)
        Me.title = title
        Me.feedback = feedback
        Me.name = name
        Me.email = email
        Me.feeddate = feeddate
    End Function
    Function gettitle()
        Return title
    End Function
    Function getfeedback()
        Return feedback
    End Function
    Function getname()
        Return name
    End Function
    Function getemail()
        Return email
    End Function
    Function getfeeddate()
        Return feeddate
    End Function
End Class
