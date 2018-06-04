Imports System.ComponentModel

Public Class SalesReport
    Private Sub SalesReport_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Manager.Show()
    End Sub

    Private Sub SalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalesDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.SalesDataSet.Sales)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class