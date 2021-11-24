Imports System.Data.SqlClient
Public Class DAOCtipo
    Inherits Ctipo
    Implements OpSql

    Dim conn As SqlConnection
    Dim sql As New SqlCommand


    Public Sub Guardar() Implements OpSql.Guardar
        Try
            conn = Cnx.GetConection
            Me.sql.CommandText = "INSERT INTO asociados_tipo values ('" & Tipo_asociado.Trim & "'," & Eliminado & ") "
            Me.sql.Connection = conn
            MsgBox(Me.sql.CommandText)
            Me.sql.ExecuteNonQuery()

        Catch ex As SqlException
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        Try
            conn = Cnx.GetConection
            Me.sql.CommandText = "update asociados_tipo set tipo_asociado='" & Tipo_asociado.Trim & "', eliminado=" & Eliminado & " where id=" & Id & ""
            Me.sql.Connection = conn
            MsgBox(Me.sql.CommandText)
            Me.sql.ExecuteNonQuery()
        Catch ex As SqlException
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        Try

            conn = Cnx.GetConection
            Me.sql.CommandText = "update asociados_tipo set tipo_asociado='" & Tipo_asociado & "', eliminado=" & Eliminado & " where id=" & Id & ""
            Me.sql.Connection = conn
            MsgBox(Me.sql.CommandText)
            Me.sql.ExecuteNonQuery()

        Catch ex As SqlException
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Public Function Count() As Integer Implements OpSql.Count
        Throw New NotImplementedException()
    End Function

    Public Function ListarTodos() As Object Implements OpSql.ListarTodos
        Dim consulta As New List(Of Ctipo)
        Dim r As SqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        Me.sql.CommandText = "select * from asociados_tipo where eliminado=" & Eliminado & " "
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        If r.HasRows Then
            While r.Read()

                consulta.Add(New Ctipo(r.GetValue((r.GetOrdinal("id"))), ((r.GetValue((r.GetOrdinal("eliminado"))))), r.GetValue((r.GetOrdinal("tipo_asociado")))))
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

    Public Function Exist() As Boolean Implements OpSql.Exist
        Throw New NotImplementedException()
    End Function
End Class
