Public Class Vehiculos
    Implements GripMethod

    Private listaVehiculos As List(Of Vehiculo)

    Public Sub CrearGrid() Implements GripMethod.CrearGrid
        With ListProductos
            .Rows.Clear()

            'PROPIEDADES DEL GRID
            .DefaultCellStyle.Font = New Font("OCR A", 9)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowsDefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.SelectionBackColor = Color.OrangeRed
            .DefaultCellStyle.SelectionForeColor = Color.White
            .RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            'NUMERO DE COLUMNAS 
            .ColumnCount = 9

            'DEFINICION DE COLUMNAS 
            .Columns(0).HeaderText = "id"
            .Columns(1).HeaderText = "Registro_vehicular"
            .Columns(2).HeaderText = "Placas"
            .Columns(3).HeaderText = "Modelo"
            .Columns(4).HeaderText = "Marca"
            .Columns(5).HeaderText = "tipo"
            .Columns(6).HeaderText = "serie"
            .Columns(7).HeaderText = "idmarca"
            .Columns(8).HeaderText = "idtipo"



            'DEFINE EL ANCHO DE LAS COLUMNAS 
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(1).ValueType = Type.GetType("System.Int32")

            'DEFINE COLUMNA PARA BUSQUEDA
            .Columns(1).Name = "Clave"


            'OCULTAR COLUMNAS
            '.Columns(0).Visible = False

            'SOLO LECTURA PARA COLUMNAS 
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = True
            .Columns(6).ReadOnly = True
            .Columns(7).ReadOnly = True
            .Columns(8).ReadOnly = True

        End With
    End Sub

    Public Sub LlenarGrid() Implements GripMethod.LlenarGrid
        Dim pro As New DAOVehiculo

        Dim resultado As List(Of Vehiculo) = pro.ListarTodos()

        Dim i As Integer = 0
        Dim a As Integer = 0
        With ListProductos
            .Rows.Clear()


            For Each row As Vehiculo In resultado
                .Rows.Add(1)
                .Item(0, i).Value = row.Id
                .Item(1, i).Value = row.Registro_vehicular
                .Item(2, i).Value = row.Placas
                .Item(3, i).Value = row.Modelo
                .Item(4, i).Value = row.Marca.Id
                .Item(5, i).Value = row.Tipo.Id
                .Item(6, i).Value = row.Serie
                .Item(7, i).Value = row.Marca.Marca
                .Item(8, i).Value = row.Tipo.Tipo
                i += 1
                a += 1
            Next
            listaVehiculos = resultado
            lblTotEntidades.Text = "LISTADOS " & a
        End With
    End Sub

    Private Sub Vehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        LlenarGrid()
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Dim veh As New Vehiculo
            With ListProductos
                veh.Id = .Item(1, .CurrentRow.Index).Value

                VehiculoCRUB.veh = veh
                VehiculoCRUB.recibView = Me
                VehiculoCRUB.ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub


    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim veh As New Vehiculo
            With ListProductos
                veh.Id = .Item(1, .CurrentRow.Index).Value

                VehiculoCRUB.veh = veh
                VehiculoCRUB.recibView = Me
                VehiculoCRUB.ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
End Class