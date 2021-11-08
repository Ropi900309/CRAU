﻿Imports System.Data.SqlClient

Public Class DAOPuesto
    Inherits Puesto
    Implements OpSql


    Dim conn As SqlConnection
    Dim sql As New SqlCommand
    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        Me.sql.CommandText = "INSERT INto empleados_puestos values ('" & Puesto & "'," & Eliminado & ")"
        Me.sql.Connection = conn
        'MsgBox(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        conn = Cnx.GetConection
        Me.sql.CommandText = "update empleados_puestos set puesto='" & Puesto & "', eliminado=" & Eliminado & " where id=" & Id & ""
        Me.sql.Connection = conn
        'MsgBox(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        conn = Cnx.GetConection
        Me.sql.CommandText = "update empleados_puestos set puesto='" & Puesto & "', eliminado=" & Eliminado & " where id=" & Id & ""
        Me.sql.Connection = conn
        'MsgBox(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub
    Public Function Count() As Integer Implements OpSql.Count
        Throw New NotImplementedException()
    End Function

    Public Function ListarTodos() As Object Implements OpSql.ListarTodos
        Dim consulta As New List(Of Puesto)
        Dim r As SqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        ' If  IsNot Nothing Then
        Me.sql.CommandText = "select * from empleados_puestos where eliminado=" & Eliminado & " "
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()
                '    Console.WriteLine(r.GetValue(0) & " " & r.GetValue(1) & " " & r.GetValue(2).ToString & " " & r.GetValue(3).ToString & " " & r.GetValue(4))
                consulta.Add(New Puesto(r.GetValue((r.GetOrdinal("id"))), r.GetValue((r.GetOrdinal("puesto"))), r.GetValue((r.GetOrdinal("eliminado")))))
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