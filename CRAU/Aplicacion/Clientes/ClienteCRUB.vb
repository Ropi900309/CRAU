Public Class ClienteCRUB

    Public Shared Property cli As Cliente
    Public Shared Property recibView As Clientes
    Private dao As New DAOCliente

    Private Sub ClienteCRUB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim pag As New DAOCpago
            pag.Asociado.Id = pag.Id

            llenarContacto()
            llenarCondicion()

            MsgBox(dao.CountCliente)

            If (comboCondicion.SelectedValue = pag.Pago) Then
                comboCondicion.Enabled = True

            Else
                comboCondicion.Enabled = False

            End If


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
        comboContacto.SelectedValue = cli.Id
        comboForma.SelectedValue = cli.Id
    End Sub

    Private Sub LimpiarForm()
        txtRazon.Text = ""
        txtRfc.Text = ""
        txtDireccion.Text = ""
        comboContacto.SelectedValue = 0
        comboForma.SelectedValue = 0
    End Sub

    Public Sub llenarContacto()

        Dim con As New DAOContacto
        con.Asociado.Id = cli.Id

        Dim co As Object = con.ListarTodos

        With comboContacto
            .DataSource = co
            .DisplayMember = "Nombre_contacto"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With
    End Sub

    Public Sub llenarCondicion()
        Dim con As New DAOCpago
        con.Asociado.Id = cli.Id

        Dim co As Object = con.ListarTodos

        With comboForma
            .DataSource = co
            .DisplayMember = "pago"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With
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

        Try
            ContactoCRUB.recibview = Me
            ContactoCRUB.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        CpagoCRUB.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FpagoCRUB.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class