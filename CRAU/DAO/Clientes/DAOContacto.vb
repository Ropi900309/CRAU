Imports System.Data.SqlClient

Public Class DAOContacto

    Inherits Ccontacto
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
        Try

             Dim consulta As New List(Of Ccontacto)

            Dim r As SqlDataReader
            Dim i As Integer = 0

            conn = Cnx.GetConection
            Me.sql.CommandText = "SELECT 
            asoc.id,asoc.asociado,asoc.nombre_contacto, asoc.telefono, asoc.correo_electronico 
            FROM asociados aso
            INNER JOIN asociados_tipo asot ON asot.id = aso.tipo_asociado
            INNER JOIN asociados_contactos asoc ON asoc.asociado = aso.id
            where asoc.asociado=" & Asociado.Id & " "


            Me.sql.Connection = conn
            'MsgBox(Asociado.Id)
            r = Me.sql.ExecuteReader()
            If r.HasRows Then
                While r.Read()

                    Dim asociado As New Cliente

                    asociado.Id = r.GetValue((r.GetOrdinal("id")))

                    consulta.Add(New Ccontacto(r.GetValue((r.GetOrdinal("id"))), asociado, ((r.GetValue((r.GetOrdinal("telefono"))))), ((r.GetValue((r.GetOrdinal("correo_electronico"))))), r.GetValue((r.GetOrdinal("nombre_contacto")))))
                    i += 1
                End While
            End If
            r.Close()
            'End If
            Return consulta
        Catch ex As SqlException
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Function

    Public Function Buscar() As Object Implements OpSql.Buscar
        Throw New NotImplementedException()
    End Function
End Class
