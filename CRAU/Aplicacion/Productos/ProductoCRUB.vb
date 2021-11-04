Public Class ProductoCRUB
    Public Shared Property pro As Producto
    Public Shared Property recibView As Productos
    Private dao As New DAOProducto

    Private Sub ProductoCRUB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarMarcas()
        LlenarCategoria()
        LlenarFamilia()
        LlenarUnidad()

        If pro.Id > 0 Then
            textParte.Text = pro.No_parte
            comboMarca.SelectedValue = pro.Marca.Id
            comboCategoria.SelectedValue = pro.Categoria.Id
            comboFamilia.SelectedValue = pro.Familia.Id
            comboMedida.SelectedValue = pro.Medida.Id
            textPCompra.Text = pro.Precio_compra
            textPVenta.Text = pro.Precio_venta
            textPPromedio.Text = pro.Costo_promedio
            textDescripcion.Text = pro.Descripcion
            textAlertMax.Text = pro.Stock.Alerta_max_stock
            textAlertMin.Text = pro.Stock.ALerta_min_stock
            textExistencia.Text = pro.Stock.Stock
        End If
    End Sub

    Private Sub DataMap()
        dao.Id = pro.Id
        dao.No_parte = textParte.Text
        dao.Marca.Id = comboMarca.SelectedValue
        dao.Categoria.Id = comboCategoria.SelectedValue
        dao.Familia.Id = comboFamilia.SelectedValue
        dao.Medida.Id = comboMedida.SelectedValue
        dao.Precio_compra = textPCompra.Text
        dao.Precio_venta = textPVenta.Text
        dao.Costo_promedio = textPPromedio.Text
        dao.Descripcion = textDescripcion.Text
        dao.Stock.Alerta_max_stock = textAlertMax.Text
        dao.Stock.ALerta_min_stock = textAlertMin.Text
        dao.Stock.Stock = textExistencia.Text
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            DataMap()
            If pro.Id > 0 Then
                dao.Actualizar()
            Else
                dao.Guardar()
            End If
            MsgBox("Se ha completado la operacion con exito", vbInformation, "Informacion")
            recibView.LlenarGrid()
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub LlenarMarcas()
        Dim mar As New DAOMarca
        mar.Eliminado = 0
        Dim ma As Object = mar.getRecords

        With comboMarca
            '.Items.Clear()
            .DataSource = ma
            .DisplayMember = "Marca"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With

    End Sub

    Private Sub LlenarCategoria()
        Dim cate As New DAOCategoria
        cate.Eliminado = 0
        Dim cat As Object = cate.getRecords

        With comboCategoria
            '.Items.Clear()
            .DataSource = cat
            .DisplayMember = "Categoria"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub LlenarUnidad()
        Dim tur As New DAOMedida

        Dim turList As Object = tur.getRecords

        With comboMedida
            .Items.Clear()
            .DataSource = turList
            .DisplayMember = "Medida"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub LlenarFamilia()
        Dim tur As New DAOFamilia

        Dim turList As Object = tur.getRecords

        With comboFamilia
            .Items.Clear()
            .DataSource = turList
            .DisplayMember = "Familia"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub btnErase_Click(sender As Object, e As EventArgs) Handles btnErase.Click
        Try
            DataMap()
            If pro.Id > 0 Then
                dao.Eliminado = 1
                dao.Eliminar()
            End If
            MsgBox("Se ha eliminado con exito", vbInformation, "Informacion")
            recibView.LlenarGrid()
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class