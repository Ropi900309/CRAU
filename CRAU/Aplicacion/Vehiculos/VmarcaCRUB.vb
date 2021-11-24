Public Class VmarcaCRUB

    Implements GripMethod

    Friend Shared recibview As VehiculoCRUB
    Private mar As New DAOVmarca

    Public Sub CrearGrid() Implements GripMethod.CrearGrid
        With ListVehiculos
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
            .ColumnCount = 4

            'DEFINICION DE COLUMNAS 
            .Columns(0).HeaderText = "id"
            .Columns(1).HeaderText = "#"
            .Columns(2).HeaderText = "Descripcion"
            .Columns(3).HeaderText = "Eliminado"

            'DEFINE EL ANCHO DE LAS COLUMNAS 

            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(1).ValueType = Type.GetType("System.Int32")

            'DEFINE COLUMNA PARA BUSQUEDA
            .Columns(1).Name = "Clave"


            'OCULTAR COLUMNAS
            .Columns(0).Visible = False
            .Columns(3).Visible = False

            'SOLO LECTURA PARA COLUMNAS 
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True

        End With
    End Sub

    Public Sub LlenarGrid() Implements GripMethod.LlenarGrid
        Try
            Dim mar As New DAOVmarca

            Dim resultado As List(Of Vmarca) = mar.ListarTodos()

            Dim i As Integer = 0
            Dim a As Integer = 0
            With ListVehiculos
                .Rows.Clear()


                For Each row As Vmarca In resultado
                    .Rows.Add(1)
                    .Item(0, i).Value = row.Id
                    .Item(1, i).Value = row.Id
                    .Item(2, i).Value = row.Marca
                    .Item(3, i).Value = row.Eliminado

                    i += 1

                    a += 1

                Next

            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            mar.Marca = textNombre.Text
            mar.Eliminado = 0

            If mar.Id > 0 Then
                mar.Actualizar()
            Else
                mar.Guardar()
            End If
            ClearData()
            recibview.llenarMarcas()
            LlenarGrid()
            MsgBox("Se actualizaron los datos correctamente", vbInformation, "Resultado")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub ClearData()
        mar.Id = 0
        mar.Marca = ""
        mar.Eliminado = 0
        textNombre.Text = ""
    End Sub


    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Try
            With ListVehiculos

                recibview.comboMarca.SelectedValue = .Item(0, .CurrentRow.Index).Value
            End With
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub VmarcaCRUB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CrearGrid()
            LlenarGrid()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            With ListVehiculos
                mar.Id = .Item(0, .CurrentRow.Index).Value
                mar.Marca = .Item(2, .CurrentRow.Index).Value
                mar.Eliminado = .Item(3, .CurrentRow.Index).Value

                textNombre.Text = mar.Marca
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            With ListVehiculos
                mar.Id = .Item(0, .CurrentRow.Index).Value
                mar.Marca = .Item(2, .CurrentRow.Index).Value
                mar.Eliminado = 1
                mar.Eliminar()
            End With
            ClearData()
            recibview.llenarMarcas()
            LlenarGrid()
            MsgBox("Se eliminaron los datos correctamente", vbInformation, "Resultado")
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
End Class