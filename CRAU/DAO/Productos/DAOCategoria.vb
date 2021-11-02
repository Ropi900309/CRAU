Imports System.Data.SqlClient

Public Class DAOCategoria
    Inherits Categoria

    Dim conn As SqlConnection
    Dim sql As New SqlCommand
    Public Function getRecords() As Object
        Dim consulta As New List(Of Categoria)
        Dim r As SqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        ' If  IsNot Nothing Then
        Me.sql.CommandText = "select * from productos_categoria where eliminado=" & Eliminado & " "
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()
                '    Console.WriteLine(r.GetValue(0) & " " & r.GetValue(1) & " " & r.GetValue(2).ToString & " " & r.GetValue(3).ToString & " " & r.GetValue(4))
                consulta.Add(New Categoria(r.GetValue((r.GetOrdinal("id"))), r.GetValue((r.GetOrdinal("categoria"))), r.GetValue((r.GetOrdinal("eliminado")))))
                i += 1
            End While
        End If

        r.Close()
        'End If

        Return consulta
    End Function
End Class
