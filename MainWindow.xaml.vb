
Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.ObjectModel
Class MainWindow





    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Connect()
    End Sub

    Private Sub AddStudents_Click(sender As Object, e As RoutedEventArgs) Handles AddStudents.Click
        Dim addform As New Addstu1
        addform.ShowDialog()
    End Sub

    Private Sub ViewStudents_Click(sender As Object, e As RoutedEventArgs) Handles ViewStudents.Click

        Dim viewform As New ViewStudents
        viewform.ShowDialog()
    End Sub
End Class
