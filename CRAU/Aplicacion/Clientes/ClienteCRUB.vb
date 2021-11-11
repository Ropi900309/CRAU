Public Class ClienteCRUB

    Public Shared Property cli As Cliente
    Public Shared Property recibView As Clientes
    Private dao As New DAOCliente


    Private Sub ClienteCRUB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            llenarTipos()

            If cli.Id = 0 Then
                LimpiarForm()
            Else
                RecibirData()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub


    Private Sub DataMap()
        dao.Id = cli.Id
        dao.Razon_social = txtRazon.Text
        dao.Rfc = txtRfc.Text
        dao.Direccion = txtDireccion.Text
        dao.Tipo.Id = 1
    End Sub

    Private Sub RecibirData()
        txtRazon.Text = cli.Razon_social
        txtRfc.Text = cli.Rfc
        txtDireccion.Text = cli.Direccion
        comboTipo.SelectedValue = cli.Tipo.Id
    End Sub

    Private Sub LimpiarForm()
        txtRazon.Text = ""
        txtRfc.Text = ""
        txtDireccion.Text = ""
        comboTipo.SelectedValue = 0
    End Sub


    Public Sub llenarTipos()
        Dim tip As New DAOCtipo

        Dim ti As Object = tip.ListarTodos

        With comboTipo
            .DataSource = ti
            .DisplayMember = "Tipo_asociado"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            DataMap()
            If cli.Id > 0 Then
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ContactoCRUB.ShowDialog()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CondicionesPagoCRUB.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormasPagoCRUB.ShowDialog()
    End Sub
End Class