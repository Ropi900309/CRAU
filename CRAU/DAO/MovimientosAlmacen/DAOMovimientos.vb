Imports System.Data.SqlClient

Public Class DAOMovimientos



    Public opc As String

    Dim conn As SqlConnection
    Dim sql As New SqlCommand

    Public Sub Guardar(id As Integer, almacen As Integer, movimiento As String, empleado As Integer, fecha As Date)
        conn = Cnx.GetConection
        Me.sql.CommandText = " INSERT INto almacen_movimientos values (" & id & "," & almacen & ",(select id from almacen_tip_mov where movimiento='" & movimiento & "')," & empleado & ",'" & ConversionFecha.fechaDB(fecha) & "')
"
        Me.sql.Connection = conn
        '' MsgBox(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub


    Public Sub Actualizar()
        Throw New NotImplementedException()
    End Sub

    Public Sub Eliminar()
        Throw New NotImplementedException()
    End Sub

    Public Function Count() As Integer
        Dim r As SqlDataReader

        Dim i As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT count(id) from almacen_movimientos "
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        While r.Read()
            i = r.GetValue(0)
        End While
        r.Close()
        Return i + 1
    End Function

    Public Function Exist() As Boolean
        Throw New NotImplementedException()
    End Function

    Public Function ListarTodos() As Object

        Try
            Dim consulta As New List(Of Object)
            Dim r As SqlDataReader
            Dim i As Integer = 0

            conn = Cnx.GetConection
            ' If  IsNot Nothing Then
            Me.sql.CommandText = "select * from movimientos_almacen where movimiento = '" & opc & "' "
            'MsgBox(Me.sql.CommandText)
            Me.sql.Connection = conn

            r = Me.sql.ExecuteReader()

            If r.HasRows Then
                While r.Read()


                    consulta.Add({r.GetValue(0).ToString, r.GetValue(1).ToString, r.GetValue(2).ToString, r.GetValue(3).ToString, r.GetValue(4).ToString})
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

    Public Function Buscar() As Object
        Throw New NotImplementedException()
    End Function

    Friend Function buscarProducto(valor As String) As List(Of Object)
        Try
            Dim consulta As New List(Of Object)
            Dim r As SqlDataReader
            Dim i As Integer = 0

            conn = Cnx.GetConection
            ' If  IsNot Nothing Then
            Me.sql.CommandText = "select * from listado_productos where descripcion like '%" & valor & "%' "
            'MsgBox(Me.sql.CommandText)
            Me.sql.Connection = conn

            r = Me.sql.ExecuteReader()

            If r.HasRows Then
                While r.Read()


                    consulta.Add({r.GetValue(0).ToString, r.GetValue(1).ToString, r.GetValue(2).ToString, r.GetValue(11).ToString})
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

    Friend Sub guardarDetalle(id As Integer, value1 As Object, value2 As Object)
        conn = Cnx.GetConection
        Me.sql.CommandText = " INSERT INto alm_mov_det values (" & id & "," & value1 & ",  " & value2 & ")"
        Me.sql.Connection = conn
        '' MsgBox(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub
End Class
