Imports System.Data.SqlClient

Public Class DAOCategoria
    Inherits Categoria
    Implements OpSql

    Dim conn As SqlConnection
    Dim sql As New SqlCommand

    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        Me.sql.CommandText = "INSERT INto productos_categoria values ('" & Categoria & "'," & Eliminado & ")"
        Me.sql.Connection = conn
        'MsgBox(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        conn = Cnx.GetConection
        Me.sql.CommandText = "update productos_categoria set categoria='" & Categoria & "', eliminado=" & Eliminado & " where id=" & Id & ""
        Me.sql.Connection = conn
        'MsgBox(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        conn = Cnx.GetConection
        Me.sql.CommandText = "update productos_categoria set categoria='" & Categoria & "', eliminado=" & Eliminado & " where id=" & Id & ""
        Me.sql.Connection = conn
        'MsgBox(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub
    Public Function Count() As Integer Implements OpSql.Count
        Throw New NotImplementedException()
    End Function

    Public Function ListarTodos() As Object Implements OpSql.ListarTodos
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

    Public Function Buscar() As Object Implements OpSql.Buscar
        Throw New NotImplementedException()
    End Function
End Class
