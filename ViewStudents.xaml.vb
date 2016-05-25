
Imports System.Data

Imports System.Data.SqlClient
Imports System.Collections.ObjectModel


Public Class ViewStudents


    Sub ViewStudents()

        Dim q As String = "SELECT * FROM Student"
        Dim firstname As String
        Dim lastname As String
        Dim DOB As Integer
        Dim cmd As New OleDb.OleDbCommand(q, connection)
        Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader

        While reader.Read
            If Not IsDBNull(reader("Firstname")) Then
                firstname = reader("Firstname")
            Else
                firstname = ""
            End If

            If Not IsDBNull(reader("Surname")) Then
                lastname = reader("Surname")
            Else
                lastname = ""
            End If


            Dim newStudent As New Studentslist(firstname, lastname, 0)

            students.Add(newStudent)





        End While

        listView.ItemsSource = students


    End Sub

    Dim students As New ObservableCollection(Of Studentslist)

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        ViewStudents()

    End Sub
   
End Class
