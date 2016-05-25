

Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.ObjectModel


Public Class Addstu1



    Sub AddStudents()
        Dim firstname As String
        Dim lastname As String



        firstname = First.Text
        lastname = SurName.Text

        Dim q As String = "INSERT INTO Student(Firstname, Surname) VALUES ('" & firstname & "','" & lastname & "' )"

        Dim cmd As New OleDb.OleDbCommand(q, connection)
        cmd.ExecuteNonQuery()

        MsgBox("worked")





    End Sub

    Private Sub AddStu_Click(sender As Object, e As RoutedEventArgs) Handles AddStu.Click
        AddStudents()
    End Sub
End Class
