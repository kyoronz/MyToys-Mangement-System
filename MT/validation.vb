Public Class validation
    Function is_empty(ByVal test As String)
        If test.Length = 0 Then
            Return True
        End If
        Return False
    End Function
    Function is_num(ByVal test As String)
        Dim testparse As String
        Try
            testparse = Double.Parse(test)
        Catch ex As Exception
            ' MessageBox.Show("Invalid input. Please try again.")
            Return False
        End Try
        Return True

    End Function
End Class
