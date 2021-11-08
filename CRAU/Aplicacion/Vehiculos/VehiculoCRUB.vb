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
    End Sub

    Private Sub RecibirData()
        txtRegistro.Text = veh.Registro_vehicular
        txtPlaca.Text = veh.Placas
        txtModelo.Text = veh.Modelo
        comboMarca.SelectedValue = veh.Marca.Id
        comboTipo.SelectedValue = veh.Tipo.Id
        txtSerie.Text = veh.Serie
    End Sub

    Private Sub LimpiarForm()
        txtRegistro.Text = ""
        txtPlaca.Text = ""
        txtModelo.Text = ""
        comboMarca.SelectedValue = 0
        comboTipo.SelectedValue = 0
        txtSerie.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            DataMap()
            If veh.Id > 0 Then
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


    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VmarcaCRUB.recibview = Me
        VmarcaCRUB.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        VtipoCRUB.recibview = Me
        VtipoCRUB.ShowDialog()
    End Sub


End Class