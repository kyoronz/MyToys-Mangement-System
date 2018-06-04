Public Class autonumber
    Dim id As String
    Function setid(ByVal id As String)
        Me.id = id
    End Function

    Function getidnumber()
        Dim idnumber As Integer = Integer.Parse(id.Substring(2))
        Return idnumber
    End Function
    Function getnextid(ByVal type As Integer)
        Dim idnumber As Integer = Integer.Parse(Me.id.Substring(2))
        Dim addzero As Integer = 0
        Select Case (idnumber) 'get error after over 999999 - 6 digit value
            Case 1 To 9
                addzero = 5
            Case 10 To 99
                addzero = 4
            Case 100 To 999
                addzero = 3
            Case 1000 To 9999
                addzero = 2
            Case 10000 To 99999
                addzero = 1
            Case Else
                addzero = 0
        End Select

        Dim id As String
        Select Case (type)
            Case 1
                id = "PR" 'Product
            Case 2
                id = "OD" 'Order
            Case 3
                id = "IN" 'Inventory
            Case 4
                id = "FD" 'Feedback
            Case 5
                id = "SP" 'Special Product
            Case Else
                Return False
        End Select
        idnumber += 1
        id = id + idnumber.ToString("000000")
        Return id
    End Function
End Class
