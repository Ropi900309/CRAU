Public Class ProveedorCRUB
    Public Shared Property pro As Proveedor
    Public Shared Property recibView As Proveedores
    Private dao As New DAOProveedor


    Private Sub DataMap()
        dao.Id = pro.Id
        dao.Razon_social = txtRazon.Text
        dao.Rfc = txtRfc.Text
        dao.Direccion = txtDireccion.Text
        dao.Tipo.Id = comboTipo.SelectedValue
    End Sub

    Private Sub RecibirData()
        txtRazon.Text = pro.Razon_social
        txtRfc.Text = pro.Rfc
        txtDireccion.Text = pro.Direccion
        comboTipo.SelectedValue = pro.Tipo.Id
    End Sub

    Private Sub LimpiarForm()
        txtRazon.Text = ""
        txtRfc.Text = ""
        txtDireccion.Text = ""
        comboTipo.SelectedValue = 0
    End Sub


    Public Sub llenarTipos()
        Dim tip As New DAOPtipo

        Dim ti As Object = tip.ListarTodos

        With comboTipo
            .DataSource = ti
            .DisplayMember = "Tipo_asociado"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With

    End Sub

    Private Sub ProveedorCRUB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            llenarTipos()

            If pro.Id = 0 Then
                LimpiarForm()
            Else
                RecibirData()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        Me.Dispose()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PtipoCRUB.recibview = Me
        PtipoCRUB.ShowDialog()
    End Sub
End Class