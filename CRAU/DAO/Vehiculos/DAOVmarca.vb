Imports System.Data.SqlClient
Public Class DAOVmarca
    Inherits Vmarca

    Dim conn As SqlConnection
    Dim sql As New SqlCommand

    Public Function getRecords() As Object
        Dim consulta As New List(Of Vmarca)
        Dim r As SqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        Me.sql.CommandText = "Select * from vehiculo_marca"
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        If r.HasRows Then
            While r.Read()

                consulta.Add(New Vmarca(r.GetValue((r.GetOrdinal("id"))), r.GetValue((r.GetOrdinal("marca")))))
                i += 1
            End While
        End If

        r.Close()
        'End If
        Return consulta
    End Function
End Class
