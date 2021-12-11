Public Class ProductoCRUB
    Public Shared Property pro As Producto
    Public Shared Property recibView As Productos
    Private dao As New DAOProducto

    Private Sub ProductoCRUB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarMarcas()
        LlenarCategoria()
        LlenarFamilia()
        LlenarUnidad()
        'MsgBox(pro.id)

        If pro.Id = 0 Then
            LimpiarForm()
        Else

            RecibirData()
        End If

    End Sub

    Private Sub DataMap()
        dao.Id = pro.Id
        dao.No_parte = textParte.Text
        dao.Marca.Id = comboMarca.SelectedValue
        dao.Categoria.Id = comboCategoria.SelectedValue
        dao.Familia.Id = comboFamilia.SelectedValue
        dao.Medida.Id = comboMedida.SelectedValue
        dao.Precio_compra = SoloNumeros.formatoNumero(textPCompra.Text)
        dao.Precio_venta = SoloNumeros.formatoNumero(textPVenta.Text)
        dao.Costo_promedio = SoloNumeros.formatoNumero(textPPromedio.Text)
        dao.Descripcion = textDescripcion.Text
        dao.Stock.Alerta_max_stock = textAlertMax.Text
        dao.Stock.ALerta_min_stock = textAlertMin.Text
        dao.Stock.Stock = textExistencia.Text
    End Sub

    Private Sub RecibirData()
        textParte.Text = pro.No_parte
        comboMarca.SelectedValue = pro.Marca.Id
        comboCategoria.SelectedValue = pro.Categoria.Id
        comboFamilia.SelectedValue = pro.Familia.Id
        comboMedida.SelectedValue = pro.Medida.Id
        textPCompra.Text = SoloNumeros.formatoMoneda(pro.Precio_compra)
        textPVenta.Text = SoloNumeros.formatoMoneda(pro.Precio_venta)
        textPPromedio.Text = SoloNumeros.formatoMoneda(pro.Costo_promedio)
        textDescripcion.Text = pro.Descripcion
        textAlertMax.Text = pro.Stock.Alerta_max_stock
        textAlertMin.Text = pro.Stock.ALerta_min_stock
        textExistencia.Text = pro.Stock.Stock
    End Sub

    Private Sub LimpiarForm()
        textParte.Text = "0"
        comboMarca.SelectedValue = 0
        comboCategoria.SelectedValue = 0
        comboFamilia.SelectedValue = 0
        comboMedida.SelectedValue = 0
        textPCompra.Text = "0.00"
        textPVenta.Text = "0.00"
        textPPromedio.Text = "0.00"
        textDescripcion.Text = ""
        textAlertMax.Text = "0"
        textAlertMin.Text = "0"
        textExistencia.Text = "0"
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

    Public Sub LlenarMarcas()
        Dim mar As New DAOMarca
        mar.Eliminado = 0
        Dim ma As Object = mar.ListarTodos

        With comboMarca
            '.Items.Clear()
            .DataSource = ma
            .DisplayMember = "Marca"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With

    End Sub

    Public Sub LlenarCategoria()
        Dim cate As New DAOCategoria
        cate.Eliminado = 0
        Dim cat As Object = cate.ListarTodos

        With comboCategoria
            '.Items.Clear()
            .DataSource = cat
            .DisplayMember = "Categoria"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With
    End Sub

    Public Sub LlenarUnidad()
        Dim tur As New DAOMedida
        tur.Eliminado = 0
        Dim turList As Object = tur.ListarTodos

        With comboMedida
            '.Items.Clear()
            .DataSource = turList
            .DisplayMember = "Medida"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With
    End Sub

    Public Sub LlenarFamilia()
        Dim tur As New DAOFamilia
        tur.Eliminado = 0
        Dim turList As Object = tur.ListarTodos

        With comboFamilia
            '.Items.Clear()
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

    Private Sub Close_login(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()
        Me.Dispose()
    End Sub


    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        CategoriaCRUB.recibview = Me
        CategoriaCRUB.ShowDialog()
    End Sub

    Private Sub btnMedida_Click(sender As Object, e As EventArgs) Handles btnMedida.Click
        MedidasCRUB.recibview = Me
        MedidasCRUB.ShowDialog()
    End Sub

    Private Sub btnMarca_Click(sender As Object, e As EventArgs) Handles btnMarca.Click
        MarcaCRUB.recibview = Me
        MarcaCRUB.ShowDialog()
    End Sub

    Private Sub btnFamilia_Click(sender As Object, e As EventArgs) Handles btnFamilia.Click
        FamiliaCRUB.recibview = Me
        FamiliaCRUB.ShowDialog()
    End Sub


    Private Sub textPCompra_LostFocus(sender As Object, e As EventArgs) Handles textPCompra.LostFocus
        textPCompra.Text = SoloNumeros.formatoMoneda(textPCompra.Text)
    End Sub

    Private Sub textPVenta_TextChanged(sender As Object, e As EventArgs) Handles textPVenta.LostFocus
        textPVenta.Text = SoloNumeros.formatoMoneda(textPVenta.Text)
    End Sub

    Private Sub textPPromedio_TextChanged(sender As Object, e As EventArgs) Handles textPPromedio.LostFocus
        textPPromedio.Text = SoloNumeros.formatoMoneda(textPPromedio.Text)
    End Sub
    'EL EVENTO SE COLOCA AL PERDER EL FOCO, VALIDO QUE NO ESTE VACIO Y QUE SEA UNICO
    'Private Sub textParte_LostFocus(sender As Object, e As EventArgs) Handles textParte.LostFocus
    '    DataMap()
    '    Metodos.ValidarUnico(dao, textParte)
    '    Metodos.ValidarSolocaja(textParte)
    'End Sub
    'Private Sub textParte_KeyDown(sender As Object, e As KeyEventArgs) Handles textParte.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        SendKeys.Send("{TAB}")
    '    End If
    'End Sub

    Private Sub textDescripcion_TextChanged(sender As Object, e As EventArgs) Handles textDescripcion.TextChanged
        Metodos.ContadorLabel(lblContador, textDescripcion)
    End Sub

End Class