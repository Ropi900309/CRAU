Public Class Vehiculos
    Implements GripMethod

    Private listaVehiculos As List(Of Vehiculo)

    Public Sub CrearGrid() Implements GripMethod.CrearGrid
        With ListVehiculos
            .Rows.Clear()

            'PROPIEDADES DEL GRID
            '.DefaultCellStyle.Font = New Font("OCR A", 9)
            '.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowsDefaultCellStyle.BackColor = Color.White
            .RowsDefaultCellStyle.ForeColor = Color.Black
            '.DefaultCellStyle.SelectionBackColor = Color.OrangeRed
            '.DefaultCellStyle.SelectionForeColor = Color.White
            '.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.Black

            'NUMERO DE COLUMNAS 
            .ColumnCount = 10

            'DEFINICION DE COLUMNAS 
            .Columns(0).HeaderText = "#"
            .Columns(1).HeaderText = "Número Económico"
            .Columns(2).HeaderText = "Placas"
            .Columns(3).HeaderText = "Modelo"
            .Columns(4).HeaderText = "Marca.id"
            .Columns(5).HeaderText = "Tipo.id"
            .Columns(6).HeaderText = "VIN"
            .Columns(7).HeaderText = "Marca"
            .Columns(8).HeaderText = "Tipo"
            .Columns(9).HeaderText = "Descripción"

            'DEFINE EL ANCHO DE LAS COLUMNAS 
            '.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(1).ValueType = Type.GetType("System.Int32")

            'DEFINE COLUMNA PARA BUSQUEDA
            .Columns(1).Name = "Clave"

            'OCULTAR COLUMNAS
            '.Columns(0).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False

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
            .Columns(9).ReadOnly = True

        End With
    End Sub

    Public Sub LlenarGrid() Implements GripMethod.LlenarGrid
        Dim veh As New DAOVehiculo

        Dim resultado As List(Of Vehiculo) = veh.ListarTodos()

        Dim i As Integer = 0
        Dim a As Integer = 0
        With ListVehiculos
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
                .Item(9, i).Value = row.Descripcion
                i += 1
                a += 1
            Next
            listaVehiculos = resultado
            lblTotEntidades.Text = "LISTADOS " & a
        End With
    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try

            Dim veh As New Vehiculo


            VehiculoCRUB.veh = veh
            VehiculoCRUB.recibView = Me
            VehiculoCRUB.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim veh As New Vehiculo
            With ListVehiculos
                'MsgBox(veh.Id)
                veh.Id = .Item(0, .CurrentRow.Index).Value

                veh = listaVehiculos(BuscarVehiculoLista(veh.Id))
                VehiculoCRUB.veh = veh
                VehiculoCRUB.recibView = Me
                VehiculoCRUB.ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub



    Private Function BuscarVehiculoLista(id As Integer) As Integer
        Try

            Dim indice As Integer = 0
            For Each item As Vehiculo In listaVehiculos
                indice += 1
                If (item.Id = id) Then
                    If (indice = 1) Then
                        indice = 0
                    Else
                        indice = indice - 1
                    End If
                    Exit For
                End If
            Next

            Return indice
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Function


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Metodos.Buscar(textBuscar.Text, ListVehiculos, 1, 2)
    End Sub

    Private Sub Vehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            CrearGrid()
            LlenarGrid()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub



End Class