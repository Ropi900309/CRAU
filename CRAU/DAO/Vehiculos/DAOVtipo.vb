Imports System.Data.SqlClient
Public Class DAOVtipo
    Inherits Vtipo
    Implements OpSql

    Dim conn As SqlConnection
    Dim sql As New SqlCommand

    Public Sub Guardar() Implements OpSql.Guardar
        Try
            conn = Cnx.GetConection
            Me.sql.CommandText = "INSERT INTO vehiculo_tipo values ('" & Tipo.Trim & "'," & Eliminado & ") "
            Me.sql.Connection = conn
            MsgBox(Me.sql.CommandText)
            Me.sql.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar

        conn = Cnx.GetConection
        Me.sql.CommandText = "update vehiculo_tipo set tipo='" & Tipo.Trim & "', eliminado=" & Eliminado & " where id=" & Id & ""
        Me.sql.Connection = conn
        MsgBox(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        Try

            conn = Cnx.GetConection
            Me.sql.CommandText = "update vehiculo_tipo set tipo='" & Tipo & "', eliminado=" & Eliminado & " where id=" & Id & ""
            Me.sql.Connection = conn
            MsgBox(Me.sql.CommandText)
            Me.sql.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Public Function Count() As Integer Implements OpSql.Count
        Throw New NotImplementedException()
    End Function

    Public Function ListarTodos() As Object Implements OpSql.ListarTodos
        Dim consulta As New List(Of Vtipo)
        Dim r As SqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        Me.sql.CommandText = "select * from vehiculo_tipo where eliminado=" & Eliminado & " "
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        If r.HasRows Then
            While r.Read()

                consulta.Add(New Vtipo(r.GetValue((r.GetOrdinal("id"))), ((r.GetValue((r.GetOrdinal("eliminado"))))), r.GetValue((r.GetOrdinal("tipo")))))
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
