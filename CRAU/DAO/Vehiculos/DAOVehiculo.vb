Imports System.Data.SqlClient
Public Class DAOVehiculo
    Inherits Vehiculo
    Implements OpSql

    Dim conn As SqlConnection
    Dim sql As New SqlCommand

    Public Sub Guardar() Implements OpSql.Guardar

        Try
            conn = Cnx.GetConection
            Me.sql.CommandText = "INSERT INTO vehiculos values ('" & Registro_vehicular.Trim.ToUpper & "','" & Placas.Trim.ToUpper & "','" & Modelo.Trim.ToUpper & "'," & Marca.Id & "," & Tipo.Id & ",'" & Serie.Trim.ToUpper & "', '" & Descripcion & "', " & Eliminado & ")"
            Me.sql.Connection = conn
            'MsgBox(Me.sql.CommandText)
            Me.sql.ExecuteNonQuery()

        Catch ex As SqlException
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        Try
            conn = Cnx.GetConection
            Me.sql.CommandText = "update vehiculos Set registro_vehicular='" & Registro_vehicular.Trim.ToUpper & "', placas='" & Placas.Trim & "' , modelo='" & Modelo.Trim.ToUpper & "' , marca=" & Marca.Id & ", tipo=" & Tipo.Id & ", serie='" & Serie.Trim.ToUpper & "', descripcion='" & Descripcion & "'  where id=" & Id & ""
            Me.sql.Connection = conn
            'MsgBox(Me.sql.CommandText)
            Me.sql.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        Try
            conn = Cnx.GetConection
            Me.sql.CommandText = "update vehiculos Set eliminado=" & Eliminado & " " &
            " where id=" & Id & ""
            Me.sql.Connection = conn
            Me.sql.ExecuteNonQuery()
            ' MsgBox(Me.sql.CommandText)
        Catch ex As SqlException
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Public Function Count() As Integer Implements OpSql.Count
        Throw New NotImplementedException()
    End Function

    Public Function ListarTodos() As Object Implements OpSql.ListarTodos

        Try
            Dim consulta As New List(Of Vehiculo)
            Dim r As SqlDataReader
            Dim i As Integer = 0

            conn = Cnx.GetConection
            ' If  IsNot Nothing Then
            Me.sql.CommandText = "select * from listado_vehiculos "
            'MsgBox(Me.sql.CommandText)
            Me.sql.Connection = conn

            r = Me.sql.ExecuteReader()

            If r.HasRows Then
                While r.Read()

                    Dim marca As New Vmarca
                    Dim tipo As New Vtipo

                    marca.Id = r.GetValue((r.GetOrdinal("marca")))
                    marca.Marca = r.GetValue((r.GetOrdinal("des_marca")))

                    tipo.Id = r.GetValue((r.GetOrdinal("tipo")))
                    tipo.Tipo = r.GetValue((r.GetOrdinal("des_tipo")))

                    consulta.Add(New Vehiculo(r.GetValue((r.GetOrdinal("id"))), r.GetValue((r.GetOrdinal("eliminado"))), marca, tipo, r.GetValue((r.GetOrdinal("registro_vehicular"))), r.GetValue((r.GetOrdinal("modelo"))),
                                 r.GetValue((r.GetOrdinal("placas"))), r.GetValue((r.GetOrdinal("serie"))), r.GetValue((r.GetOrdinal("descripcion")))))
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
