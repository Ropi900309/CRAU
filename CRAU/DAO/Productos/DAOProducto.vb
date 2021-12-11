Imports System.Data.SqlClient
Public Class DAOProducto
    Inherits Producto
    Implements OpSql

    Dim conn As SqlConnection
    Dim sql As New SqlCommand

    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        Me.sql.CommandText = "INSERT INto productos values ('" & No_parte & "','" & Descripcion & "'," & Precio_compra & "," & Precio_venta & "," & Costo_promedio & "," & Medida.Id & "," & Categoria.Id & "," & Marca.Id & "," & Familia.Id & "," & Eliminado & ")"
        Me.sql.Connection = conn
        MsgBox(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        conn = Cnx.GetConection
        Me.sql.CommandText = "update productos Set no_parte='" & No_parte & "', descripcion='" & Descripcion & "' , precio_compra=" & Precio_compra & " , precio_venta=" & Precio_venta & ", costo_promedio=" & Costo_promedio & ", medida=" & Medida.Id & ", categoria=" & Categoria.Id & ",marca=" & Marca.Id & ",familia=" & Familia.Id & ",eliminado=" & Eliminado & " " &
        " where id=" & Id & ""
        Me.sql.Connection = conn
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        conn = Cnx.GetConection
        Me.sql.CommandText = "update productos Set eliminado=" & Eliminado & " " &
        " where id=" & Id & ""
        Me.sql.Connection = conn
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Function Count() As Integer Implements OpSql.Count
        Throw New NotImplementedException()
    End Function

    Public Function ListarTodos() As Object Implements OpSql.ListarTodos
        Dim consulta As New List(Of Producto)
        Dim r As SqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        ' If  IsNot Nothing Then
        Me.sql.CommandText = "select top 100* from listado_productos "


        Me.sql.Connection = conn

        r = Me.sql.ExecuteReader()

        If r.HasRows Then
            While r.Read()

                Dim medida As New Medida
                Dim categoria As New Categoria
                Dim marca As New Marca
                Dim familia As New Familia
                Dim stock As New Stock

                medida.Id = r.GetValue((r.GetOrdinal("medida")))
                medida.Medida = r.GetValue((r.GetOrdinal("des_unidad")))

                categoria.Id = r.GetValue((r.GetOrdinal("categoria")))
                categoria.Categoria = r.GetValue((r.GetOrdinal("des_categoria")))

                marca.Id = r.GetValue((r.GetOrdinal("marca")))
                marca.Marca = r.GetValue((r.GetOrdinal("des_marca")))

                familia.Id = r.GetValue((r.GetOrdinal("familia")))
                familia.Familia = r.GetValue((r.GetOrdinal("des_familia")))

                stock.Id = r.GetValue((r.GetOrdinal("stock")))
                stock.Alerta_max_stock = r.GetValue((r.GetOrdinal("stock")))
                stock.ALerta_min_stock = r.GetValue((r.GetOrdinal("stock")))

                consulta.Add(New Producto(r.GetValue((r.GetOrdinal("id"))),
                             r.GetValue((r.GetOrdinal("eliminado"))), r.GetValue((r.GetOrdinal("no_parte"))), r.GetValue((r.GetOrdinal("descripcion"))), r.GetValue((r.GetOrdinal("precio_compra"))),
                             r.GetValue((r.GetOrdinal("precio_venta"))), r.GetValue((r.GetOrdinal("costo_promedio"))), medida, categoria, marca, familia, stock))
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
        Dim consulta As Boolean = False
        Dim r As SqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        ' If  IsNot Nothing Then
        Me.sql.CommandText = "select * from listado_productos where no_parte='" & No_parte & "' "


        Me.sql.Connection = conn

        r = Me.sql.ExecuteReader()

        If r.HasRows Then
            While r.Read()

                consulta = True

            End While
        End If

        r.Close()
        'End If

        Return consulta
    End Function
End Class
