Imports System.Data.OleDb

Module connectionModule

    Public connect As OleDbConnection
    Public dataAdapter As OleDbDataAdapter
    Public command As OleDbCommand
    Public dataReader As OleDbDataReader


    Public Sub connection()
        'melakukan koneksi ke database
        connect = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=laundry.accdb")
        connect.Open()

    End Sub


End Module
