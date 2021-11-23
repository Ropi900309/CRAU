Imports System.Data.SqlClient
Public Class DAOCpago
    Inherits Ccpago
    Implements OpSql

    Dim conn As SqlConnection
    Dim sql As New SqlCommand

    Public Sub Guardar() Implements OpSql.Guardar
        Throw New NotImplementedException()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        Throw New NotImplementedException()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function Count() As Integer Implements OpSql.Count
        Throw New NotImplementedException()
    End Function

    Public Function ListarTodos() As Object Implements OpSql.ListarTodos
        Dim consulta As New List(Of Ccpago)
        Dim r As SqlDataReader
        Dim i As Integer = 0


        conn = Cnx.GetConection
        Me.sql.CommandText = " 
        SELECT asocp.id ,asocp.pago
        FROM asociados aso
        INNER JOIN asociados_cond_pago asocp on asocp.asociado = aso.id where asocp.asociado=" & Asociado.Id & " "
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        If r.HasRows Then
            While r.Read()

                Dim asociado As New Cliente

                asociado.Id = r.GetValue((r.GetOrdinal("id")))

                consulta.Add(New Ccpago(r.GetValue((r.GetOrdinal("id"))), Asociado, r.GetValue((r.GetOrdinal("pago")))))
                i += 1
            End While
        End If
        r.Close()
        'End If
        Return consulta


    End Function

    Public Function Buscar() As Object Implements OpSql.Buscar
        Throw New NotImplementedException()
    End Function
End Class
