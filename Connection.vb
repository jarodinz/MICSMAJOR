
Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections.ObjectModel



Module modConnection


    Public connection As OleDb.OleDbConnection

    Public Sub Connect()

        connection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; " &
                                               "Data Source=MICSdb.accdb;")
        connection.Open()


        MsgBox("worked")

    End Sub

End Module
