Public Class EmpleadosCRUB
    Public Shared Property pro As Empleado
    Public Shared Property recibView As Empleados

    Private dao As New DAOEmpleado

    Private Sub EmpleadosCRUB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LlenarDeptos()
        LlenarPuestos()

        If pro.Id = 0 Then
            LimpiarForm()
        Else

            RecibirData()
        End If
    End Sub

    Private Sub DataMap()
        dao.Id = pro.Id
        dao.Nombre = txtNombre.Text
        dao.Paterno = txtPaterno.Text
        dao.Materno = txtMAterno.Text
        dao.Rfc = txtRfc.Text
        dao.Nss = txtNss.Text
        dao.Fecha_alta = dateAlta.Value
        dao.Fecha_baja = dateBaja.Value
        dao.Departamento.Id = comboDepto.SelectedValue
        dao.Puesto.Id = comboPuesto.SelectedValue
    End Sub

    Private Sub RecibirData()

        txtNombre.Text = pro.Nombre
        txtPaterno.Text = pro.Paterno
        txtMAterno.Text = pro.Materno
        txtRfc.Text = pro.Rfc
        txtNss.Text = pro.Nss
        If pro.Fecha_baja = "" Then
            pro.Fecha_baja = Today
        End If
        If pro.Fecha_alta = "" Then
            pro.Fecha_alta = Today
        End If
        dateAlta.Value = pro.Fecha_alta
        dateBaja.Value = pro.Fecha_baja
        comboDepto.SelectedValue = pro.Departamento.Id
        comboPuesto.SelectedValue = pro.Puesto.Id
    End Sub

    Private Sub LimpiarForm()
        pro.Id = 0
        txtNombre.Text = ""
        txtPaterno.Text = ""
        txtMAterno.Text = ""
        txtRfc.Text = ""
        txtNss.Text = ""
        dateAlta.Value = Today
        dateBaja.Value = Today
        comboDepto.SelectedValue = 0
        comboPuesto.SelectedValue = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Try
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
        'Catch ex As Exception
        '    MsgBox(ex.Message, vbCritical, "Error")
        'End Try
    End Sub

    Public Sub LlenarDeptos()
        Dim mar As New DAODepartamento
        mar.Eliminado = 0
        Dim ma As Object = mar.ListarTodos

        With comboDepto
            '.Items.Clear()
            .DataSource = ma
            .DisplayMember = "Departamento"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With

    End Sub

    Public Sub LlenarPuestos()
        Dim cate As New DAOPuesto
        cate.Eliminado = 0
        Dim cat As Object = cate.ListarTodos

        With comboPuesto
            '.Items.Clear()
            .DataSource = cat
            .DisplayMember = "Puesto"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub btnErase_Click(sender As Object, e As EventArgs) Handles btnErase.Click
        Try
            DataMap()
            If pro.Id > 0 Then
                dao.Fecha_baja = Today
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

    Private Sub btnNewDepto_Click(sender As Object, e As EventArgs) Handles btnNewDepto.Click
        DepartamentosCRUB.recibview = Me
        DepartamentosCRUB.ShowDialog()
    End Sub

    Private Sub btnNewPuesto_Click(sender As Object, e As EventArgs) Handles btnNewPuesto.Click
        PuestosCRUB.recibview = Me
        PuestosCRUB.ShowDialog()
    End Sub
End Class