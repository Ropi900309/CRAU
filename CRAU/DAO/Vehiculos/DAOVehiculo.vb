﻿Imports System.Data.SqlClient
Public Class DAOVehiculo
    Inherits Vehiculo
    Implements OpSql

    Dim conn As SqlConnection
    Dim sql As New SqlCommand


    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        Me.sql.CommandText = "INSERT INTO vehiculos values ('" & Registro_vehicular & "','" & Placas & "'," & Modelo & "," & Marca.Id & "," & Tipo.Id & "," & Serie & ")"
        Me.sql.Connection = conn
        MsgBox(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()

    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        conn = Cnx.GetConection
        Me.sql.CommandText = "UPDATE vehiculos Set registro_vehicular='" & Registro_vehicular & "',placas='" & Placas & "',marca=" & Marca.Id & ", tipo = " & Tipo.Id & ", serie = " & Serie & " where id=" & Id & ""
        Me.sql.Connection = conn
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function Count() As Integer Implements OpSql.Count
        Throw New NotImplementedException()
    End Function

    Public Function ListarTodos() As Object Implements OpSql.ListarTodos
        Dim consulta As New List(Of Vehiculo)
        Dim r As SqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        ' If  IsNot Nothing Then
        Me.sql.CommandText = "select * from listado_vehiculos"


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

                consulta.Add(New Vehiculo(r.GetValue((r.GetOrdinal("id"))), r.GetValue((r.GetOrdinal("modelo"))),
                             marca, tipo, r.GetValue((r.GetOrdinal("registro_vehicular"))),
                             r.GetValue((r.GetOrdinal("placas"))), r.GetValue((r.GetOrdinal("serie")))))
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