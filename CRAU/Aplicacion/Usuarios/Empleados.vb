Public Class Empleados
    Implements GripMethod



    Private listaEmpleados As List(Of Empleado)
    Public Sub CrearGrid() Implements GripMethod.CrearGrid
        With ListEmpleados
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
            .ColumnCount = 12

            'DEFINICION DE COLUMNAS 
            .Columns(0).HeaderText = "#"
            .Columns(1).HeaderText = "Nombre"
            .Columns(2).HeaderText = "Paterno"
            .Columns(3).HeaderText = "Materno"
            .Columns(4).HeaderText = "RFC"
            .Columns(5).HeaderText = "NSS"
            .Columns(6).HeaderText = "Fecha Alta"
            .Columns(7).HeaderText = "idDepartamento"
            .Columns(8).HeaderText = "idPuesto"
            .Columns(9).HeaderText = "Fecha Baja"
            .Columns(10).HeaderText = "Departamento"
            .Columns(11).HeaderText = "Puesto"



            'DEFINE EL ANCHO DE LAS COLUMNAS 
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


            .Columns(1).ValueType = Type.GetType("System.Int32")



            'DEFINE COLUMNA PARA BUSQUEDA
            .Columns(1).Name = "Clave"


            'OCULTAR COLUMNAS
            '.Columns(0).Visible = False

            .Columns(8).Visible = False
            .Columns(7).Visible = False


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
            .Columns(10).ReadOnly = True
            .Columns(11).ReadOnly = True

        End With
    End Sub

    Public Sub LlenarGrid() Implements GripMethod.LlenarGrid
        Dim pro As New DAOEmpleado

        Dim resultado As List(Of Empleado) = pro.ListarTodos()

        Dim i As Integer = 0
        Dim a As Integer = 0
        With ListEmpleados
            .Rows.Clear()


            For Each row As Empleado In resultado
                .Rows.Add(1)

                .Item(0, i).Value = row.Id
                .Item(1, i).Value = row.Nombre
                .Item(2, i).Value = row.Paterno
                .Item(3, i).Value = row.Materno
                .Item(4, i).Value = row.Rfc
                .Item(5, i).Value = row.Nss
                .Item(6, i).Value = row.Fecha_alta
                .Item(7, i).Value = row.Departamento.Id
                .Item(8, i).Value = row.Puesto.Id
                .Item(9, i).Value = row.Fecha_baja
                .Item(10, i).Value = row.Departamento.Departamento
                .Item(11, i).Value = row.Puesto.Puesto

                i += 1
                a += 1
            Next

            listaEmpleados = resultado
            lblTotEntidades.Text = "LISTADOS " & a

        End With
    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        LlenarGrid()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Dim pro As New Empleado

            EmpleadosCRUB.pro = pro
            EmpleadosCRUB.recibView = Me
            EmpleadosCRUB.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim pro As New Empleado
            With ListEmpleados
                pro.Id = .Item(0, .CurrentRow.Index).Value

                ' MsgBox(BuscarProductoLista(pro.Id))
                pro = listaEmpleados(BuscarEmpleadoLista(pro.Id))

                EmpleadosCRUB.pro = pro
                EmpleadosCRUB.recibView = Me
                EmpleadosCRUB.ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub


    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        LlenarGrid()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Metodos.Buscar(textBuscar.Text, ListEmpleados, 1, 2)
    End Sub

    Private Function BuscarEmpleadoLista(id As Integer) As Integer
        Dim indice As Integer = 0

        For Each item As Empleado In listaEmpleados
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
    End Function
End Class