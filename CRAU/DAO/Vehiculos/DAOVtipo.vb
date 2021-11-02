Imports System.Data.SqlClient
Public Class DAOVtipo
    Inherits Vtipo

    Dim conn As SqlConnection
    Dim sql As New SqlCommand

    Public Function getRecords() As Object
        Dim consulta As New List(Of Vtipo)
        Dim r As SqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        Me.sql.CommandText = "select * from vehiculo_tipo"
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        If r.HasRows Then
            While r.Read()

                consulta.Add(New Vtipo(r.GetValue((r.GetOrdinal("id"))), r.GetValue((r.GetOrdinal("tipo")))))
                i += 1
            End While
        End If
        r.Close()
        'End If
        Return consulta
    End Function
End Class
