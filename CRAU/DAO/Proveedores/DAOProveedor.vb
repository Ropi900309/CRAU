Imports System.Data.SqlClient
Public Class DAOProveedor

    Inherits Proveedor
    Implements OpSql

    Dim conn As SqlConnection
    Dim sql As New SqlCommand

    Public Sub Guardar() Implements OpSql.Guardar
        Try
            conn = Cnx.GetConection
            Me.sql.CommandText = "INSERT INTO asociados values ('" & Razon_social.Trim & "','" & Rfc.Trim & "','" & Direccion.Trim & "',2) "
            Me.sql.Connection = conn
            MsgBox(Me.sql.CommandText)
            Me.sql.ExecuteNonQuery()

            'If (Me.sql.ExecuteNonQuery() = 1) Then
            '    MsgBox("Datos almacenados")
            'Else
            '    MsgBox("Datos no enviados")
            'End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        Try
            conn = Cnx.GetConection
            Me.sql.CommandText = "update asociados Set razon_social='" & Razon_social.Trim & "', rfc='" & Rfc.Trim & "' , direccion='" & Direccion.Trim & "' where id=" & Id & " "
            Me.sql.Connection = conn
            MsgBox(Me.sql.CommandText)
            Me.sql.ExecuteNonQuery()
            'If (Me.sql.ExecuteNonQuery() = 1) Then
            '    MsgBox("Datos almacenados")
            'Else
            '    MsgBox("Datos no enviados")
            'End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function Count() As Integer Implements OpSql.Count
        Throw New NotImplementedException()
    End Function

    Public Function ListarTodos() As Object Implements OpSql.ListarTodos

        Dim consulta As New List(Of Proveedor)
            Dim r As SqlDataReader
            Dim i As Integer = 0

            conn = Cnx.GetConection
            ' If  IsNot Nothing Then
            Me.sql.CommandText = "select * from listado_Proveedores "
            'MsgBox(Me.sql.CommandText)
            Me.sql.Connection = conn

            r = Me.sql.ExecuteReader()

            If r.HasRows Then
                While r.Read()

                    Dim tipo As New Ptipo

                    tipo.Id = r.GetValue((r.GetOrdinal("tipo_asociado")))
                    tipo.Tipo_asociado = r.GetValue((r.GetOrdinal("des_tipo")))

                    consulta.Add(New Proveedor(r.GetValue((r.GetOrdinal("id"))), tipo, r.GetValue((r.GetOrdinal("razon_social"))), r.GetValue((r.GetOrdinal("rfc"))), r.GetValue((r.GetOrdinal("direccion")))))
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
