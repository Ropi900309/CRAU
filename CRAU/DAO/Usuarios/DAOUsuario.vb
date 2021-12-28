Imports System.Data.SqlClient

Public Class DAOUsuario
    Inherits Usuario
    Implements OpSql

    Dim conn As SqlConnection
    Dim sql As New SqlCommand

    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        'Me.sql.CommandText = "insert into usuarios values('" & Usuario & "','" & Password & "'," & Activo & "," & Empleado & ")"
        Me.sql.Connection = conn
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        conn = Cnx.GetConection
        'Me.sql.CommandText = "update usuarios Set usuario='" & Usuario & "', password='" & Password & "' , activo=" & Activo & " , empleado=" & Empleado & "" &
        '" where id=" & Id & ""
        Me.sql.Connection = conn
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        conn = Cnx.GetConection
        'Me.sql.CommandText = "delete usuarios where id=" & Id & ""
        Me.sql.Connection = conn
        Me.sql.ExecuteNonQuery()
    End Sub

    Friend Function ValidarUser(usuario As String) As Usuario
        Dim r As SqlDataReader
        Dim i As Integer = 0
        Dim consulta As Usuario = New Usuario()
        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT * from usuarios_sistema where usuario='" & usuario & "'"
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()



        While r.Read()

            consulta.Id = r.GetValue((r.GetOrdinal("id")))
            consulta.Usuario = r.GetValue((r.GetOrdinal("usuario")))
            consulta.Contraseña = r.GetValue((r.GetOrdinal("contraseña")))
            consulta.Rol.Rol = r.GetValue((r.GetOrdinal("usuarios_rol")))
            consulta.Empleado.Id = r.GetValue((r.GetOrdinal("empleado")))
            consulta.Empleado.Nombre = r.GetValue((r.GetOrdinal("nombre_empleado")))
            consulta.Empleado.Departamento.Id = r.GetValue((r.GetOrdinal("depId")))
            consulta.Empleado.Departamento.Departamento = r.GetValue((r.GetOrdinal("departamento")))
            consulta.Empleado.Puesto.Id = r.GetValue((r.GetOrdinal("puesId")))
            consulta.Empleado.Puesto.Puesto = r.GetValue((r.GetOrdinal("puesto")))
            consulta.Eliminado = r.GetValue((r.GetOrdinal("eliminado")))

            Active.usuario = consulta

            i += 1
        End While
        r.Close()
        Return consulta
    End Function

    Public Function Count() As Integer Implements OpSql.Count
        Throw New NotImplementedException()
    End Function

    Public Function ListarTodos() As Object Implements OpSql.ListarTodos

        Throw New NotImplementedException()

    End Function

    Public Function Buscar() As Object Implements OpSql.Buscar
        Throw New NotImplementedException()
    End Function

    Public Function Exist() As Boolean Implements OpSql.Exist
        Throw New NotImplementedException()
    End Function
End Class