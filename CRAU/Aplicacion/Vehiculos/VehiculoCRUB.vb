Public Class VehiculoCRUB
    Public Shared Property veh As Vehiculo
    Public Shared Property recibView As Vehiculos
    Private dao As New DAOVehiculo
    Private Sub VehiculoCRUB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            llenarMarcas()
            llenarTipos()

            If veh.Id = 0 Then
                LimpiarForm()
            Else
                RecibirData()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub DataMap()
        dao.Id = veh.Id
        dao.Registro_vehicular = txtRegistro.Text
        dao.Placas = txtPlaca.Text
        dao.Modelo = txtModelo.Text
        dao.Marca.Id = comboMarca.SelectedValue
        dao.Tipo.Id = comboTipo.SelectedValue
        dao.Serie = txtSerie.Text
        dao.Descripcion = txtDescripcion.Text
    End Sub

    Private Sub RecibirData()
        txtRegistro.Text = veh.Registro_vehicular
        txtPlaca.Text = veh.Placas
        txtModelo.Text = veh.Modelo
        comboMarca.SelectedValue = veh.Marca.Id
        comboTipo.SelectedValue = veh.Tipo.Id
        txtSerie.Text = veh.Serie
        txtDescripcion.Text = veh.Descripcion
    End Sub

    Private Sub LimpiarForm()
        txtRegistro.Text = ""
        txtPlaca.Text = ""
        txtModelo.Text = ""
        comboMarca.SelectedValue = 0
        comboTipo.SelectedValue = 0
        txtSerie.Text = ""
        txtDescripcion.Text = ""
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            DataMap()
            If veh.Id > 0 Then
                dao.Actualizar()
            Else
                Metodos.ValidarSolocaja(txtRegistro)
                Metodos.ValidarSolocaja(txtPlaca)
                Metodos.ValidarSolocaja(txtModelo)
                Metodos.ValidarSolocaja(txtSerie)
                Metodos.ValidarCombo(comboMarca)
                Metodos.ValidarCombo(comboTipo)
                dao.Guardar()
            End If
            recibView.LlenarGrid()
            Me.Close()
            Me.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnErase_Click(sender As Object, e As EventArgs) Handles btnErase.Click
        Try
            DataMap()
            If veh.Id > 0 Then
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


    Public Sub llenarMarcas()
        Dim mar As New DAOVmarca
        mar.Eliminado = 0
        Dim ma As Object = mar.ListarTodos

        With comboMarca
            .DataSource = ma
            .DisplayMember = "Marca"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With

    End Sub

    Public Sub llenarTipos()
        Dim tip As New DAOVtipo

        Dim ti As Object = tip.ListarTodos

        With comboTipo
            .DataSource = ti
            .DisplayMember = "Tipo"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With

    End Sub

    Private Sub txtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged
        Metodos.ContadorLabel(lblContador, txtDescripcion)
    End Sub


    Private Sub btnMarca_Click(sender As Object, e As EventArgs) Handles btnMarca.Click
        VmarcaCRUB.recibview = Me
        VmarcaCRUB.ShowDialog()
    End Sub


    Private Sub btnTipo_Click(sender As Object, e As EventArgs) Handles btnTipo.Click
        VtipoCRUB.recibview = Me
        VtipoCRUB.ShowDialog()
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub


End Class