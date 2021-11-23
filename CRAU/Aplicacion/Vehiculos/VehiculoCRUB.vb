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

    'Private Function Validar()


    'If (txtRegistro.Text = String.Empty) Then
    '    MessageBox.Show("Debe introducir el Registro")
    '    Return False
    'ElseIf (txtPlaca.Text = String.Empty) Then
    '    MessageBox.Show("Debe introducir la Placa")
    '    Return False
    'ElseIf (txtModelo.Text = String.Empty) Then
    '    MessageBox.Show("Debe introducir el Modelo")
    '    Return False
    'ElseIf (comboMarca.SelectedValue = 0) Then
    '    MessageBox.Show("Debe seleccionar la Marca")
    '    Return False
    'ElseIf (comboTipo.SelectedValue = 0) Then
    '    MessageBox.Show("Debe seleccionar el Tipo")
    '    Return False
    'ElseIf (txtSerie.Text = String.Empty) Then
    '    MessageBox.Show("Debe introducir el VIN")
    '    Return False
    'End If

    'Return True 'Si nunca entra en if llegara al final y retornara True es decir paso la validacion

    'End Function


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            DataMap()
            If veh.Id > 0 Then
                dao.Actualizar()
            Else
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
        Try

            Me.lblContador.Text = Me.txtDescripcion.Text.Length
            If Me.lblContador.Text = 255 Then
                MessageBox.Show("Campo Descripción Solo Permite un Máximo 255 Caracteres", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")

        End Try

    End Sub


    Private Sub btnMarca_Click(sender As Object, e As EventArgs) Handles btnMarca.Click
        VmarcaCRUB.recibview = Me
        VmarcaCRUB.ShowDialog()
    End Sub


    Private Sub btnTipo_Click(sender As Object, e As EventArgs) Handles btnTipo.Click
        VtipoCRUB.recibview = Me
        VtipoCRUB.ShowDialog()
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub


End Class