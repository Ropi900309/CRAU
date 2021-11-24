Public Class ProveedorCRUB
    Public Shared Property pro As Proveedor
    Public Shared Property recibView As Proveedores
    Private dao As New DAOProveedor


    Private Sub DataMap()
        dao.Id = pro.Id
        dao.Razon_social = txtRazon.Text
        dao.Rfc = txtRfc.Text
        dao.Direccion = txtDireccion.Text
    End Sub

    Private Sub RecibirData()
        txtRazon.Text = pro.Razon_social
        txtRfc.Text = pro.Rfc
        txtDireccion.Text = pro.Direccion
    End Sub

    Private Sub LimpiarForm()
        txtRazon.Text = ""
        txtRfc.Text = ""
        txtDireccion.Text = ""
    End Sub

    Private Sub ProveedorCRUB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            If pro.Id = 0 Then
                LimpiarForm()
            Else
                RecibirData()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class