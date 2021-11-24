Public Class Productos
    Implements GripMethod

    Private listaProducttos As List(Of Producto)
    Public Sub CrearGrid() Implements GripMethod.CrearGrid
        With ListProductos
            .Rows.Clear()

            'PROPIEDADES DEL GRID

            '.DefaultCellStyle.Font = New Font("OCR A", 9)
            '.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowsDefaultCellStyle.BackColor = Color.White
            .RowsDefaultCellStyle.ForeColor = Color.Black
            '.DefaultCellStyle.SelectionBackColor = Color.OrangeRed
            '.DefaultCellStyle.SelectionForeColor = Color.White
            '.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black

            'NUMERO DE COLUMNAS 
            .ColumnCount = 18

            'DEFINICION DE COLUMNAS 
            .Columns(0).HeaderText = "#"
            .Columns(1).HeaderText = "Parte"
            .Columns(2).HeaderText = "Descripcion"
            .Columns(3).HeaderText = "Precio.Comp"
            .Columns(4).HeaderText = "Precio.Vent"
            .Columns(5).HeaderText = "Cost.Prome"
            .Columns(6).HeaderText = "idMedida"
            .Columns(7).HeaderText = "idCategoria"
            .Columns(8).HeaderText = "idMarca"
            .Columns(9).HeaderText = "idFamilia"
            .Columns(10).HeaderText = "eliminado"
            .Columns(11).HeaderText = "unidad"
            .Columns(12).HeaderText = "categoria"
            .Columns(13).HeaderText = "marca"
            .Columns(14).HeaderText = "familia"
            .Columns(15).HeaderText = "stock"
            .Columns(16).HeaderText = "alert_min"
            .Columns(17).HeaderText = "alert_max"


            'DEFINE EL ANCHO DE LAS COLUMNAS 
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(13).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(14).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(1).ValueType = Type.GetType("System.Int32")



            'DEFINE COLUMNA PARA BUSQUEDA
            .Columns(1).Name = "Clave"


            'OCULTAR COLUMNAS
            '.Columns(0).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(8).Visible = False
            .Columns(7).Visible = False
            .Columns(9).Visible = False
            .Columns(16).Visible = False
            .Columns(17).Visible = False
            .Columns(10).Visible = False

            'SOLO LECTURA PARA COLUMNAS 
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = True
            .Columns(6).ReadOnly = True
            .Columns(7).ReadOnly = True
            .Columns(8).ReadOnly = True
            .Columns(9).ReadOnly = True
            .Columns(10).ReadOnly = True
            .Columns(11).ReadOnly = True
            .Columns(12).ReadOnly = True
            .Columns(13).ReadOnly = True
            .Columns(14).ReadOnly = True
            .Columns(15).ReadOnly = True
            .Columns(16).ReadOnly = True
        End With
    End Sub

    Public Sub LlenarGrid() Implements GripMethod.LlenarGrid
        Dim pro As New DAOProducto

        Dim resultado As List(Of Producto) = pro.ListarTodos()

        Dim i As Integer = 0
        Dim a As Integer = 0
        With ListProductos
            .Rows.Clear()


            For Each row As Producto In resultado
                .Rows.Add(1)
                .Item(0, i).Value = row.Id
                .Item(1, i).Value = row.No_parte
                .Item(2, i).Value = row.Descripcion
                .Item(3, i).Value = row.Precio_compra
                .Item(4, i).Value = row.Precio_venta
                .Item(5, i).Value = row.Costo_promedio
                .Item(6, i).Value = row.Medida.Id
                .Item(7, i).Value = row.Categoria.Id
                .Item(8, i).Value = row.Marca.Id
                .Item(9, i).Value = row.Familia.Id
                .Item(10, i).Value = row.Eliminado
                .Item(11, i).Value = row.Medida.Medida
                .Item(12, i).Value = row.Categoria.Categoria
                .Item(13, i).Value = row.Marca.Marca
                .Item(14, i).Value = row.Familia.Familia
                .Item(15, i).Value = row.Stock.Stock
                .Item(16, i).Value = row.Stock.ALerta_min_stock
                .Item(17, i).Value = row.Stock.Alerta_max_stock
                i += 1
                a += 1
            Next

            listaProducttos = resultado
            lblTotEntidades.Text = "LISTADOS " & a

        End With
    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        LlenarGrid()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Metodos.Buscar(textBuscar.Text, ListProductos, 1, 2)
    End Sub

    Private Function BuscarProductoLista(id As Integer) As Integer
        Dim indice As Integer = 0

        For Each item As Producto In listaProducttos
            indice += 1
            If (item.Id = id) Then
                If (indice = 1) Then
                    indice = 0
                Else
                    indice = indice - 1
                End If
                Exit For
            End If
        Next

        Return indice
    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Dim pro As New Producto

            ProductoCRUB.pro = pro
            ProductoCRUB.recibView = Me
            ProductoCRUB.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim pro As New Producto
            With ListProductos
                pro.Id = .Item(0, .CurrentRow.Index).Value

                ' MsgBox(BuscarProductoLista(pro.Id))
                pro = listaProducttos(BuscarProductoLista(pro.Id))
                ProductoCRUB.pro = pro
                ProductoCRUB.recibView = Me
                ProductoCRUB.ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
End Class