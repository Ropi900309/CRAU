Imports System.Data.SqlClient

Public Class DAOEmpleado
    Inherits Empleado

    Implements OpSql


    Dim conn As SqlConnection
    Dim sql As New SqlCommand
    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        Me.sql.CommandText = "INSERT INto empleados values ('" & Nombre & "','" & Paterno & "','" & Materno & "','" & Rfc & "','" & Nss & "','" & ConversionFecha.fechaDB(Fecha_alta) & "'," & Departamento.Id & "," & Puesto.Id & ",'" & ConversionFecha.fechaDB(Fecha_baja) & "')"
        Me.sql.Connection = conn
        MsgBox(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        conn = Cnx.GetConection
        Me.sql.CommandText = "update empleados Set nombre='" & Nombre & "', paterno='" & Paterno & "' , materno='" & Materno & "' , rfc='" & Rfc & "', nss='" & Nss & "', fecha_alta='" & ConversionFecha.fechaDB(Fecha_alta) & "', departamento=" & Departamento.Id & ",puesto=" & Puesto.Id & ",fecha_baja='" & ConversionFecha.fechaDB(Fecha_baja) & "'  " &
        " where id=" & Id & ""
        Me.sql.Connection = conn
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        conn = Cnx.GetConection
        Me.sql.CommandText = "update empleados Set fecha_baja='" & ConversionFecha.fechaDB(Fecha_baja) & "' " &
        " where id=" & Id & ""
        Me.sql.Connection = conn
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Function Count() As Integer Implements OpSql.Count
        Throw New NotImplementedException()
    End Function

    Public Function ListarTodos() As Object Implements OpSql.ListarTodos
        Dim consulta As New List(Of Empleado)
        Dim r As SqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        ' If  IsNot Nothing Then
        Me.sql.CommandText = "select * from listado_empleados "


        Me.sql.Connection = conn

        r = Me.sql.ExecuteReader()

        If r.HasRows Then
            While r.Read()

                Dim depto As New Departamento
                Dim pue As New Puesto


                depto.Id = r.GetValue((r.GetOrdinal("departamento")))
                depto.Departamento = r.GetValue((r.GetOrdinal("dec_depto")))

                pue.Id = r.GetValue((r.GetOrdinal("puesto")))
                pue.Puesto = r.GetValue((r.GetOrdinal("desc_puesto")))



                consulta.Add(New Empleado(r.GetValue((r.GetOrdinal("id"))), r.GetValue((r.GetOrdinal("nombre"))), r.GetValue((r.GetOrdinal("paterno"))),
                                          r.GetValue((r.GetOrdinal("materno"))), r.GetValue((r.GetOrdinal("rfc"))), r.GetValue((r.GetOrdinal("nss"))),
                                          r.GetValue((r.GetOrdinal("fecha_alta"))), r.GetValue((r.GetOrdinal("fecha_baja"))).ToString, depto, pue))


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
