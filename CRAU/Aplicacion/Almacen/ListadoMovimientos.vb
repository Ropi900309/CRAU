Public Class ListadoMovimientos
    Implements GripMethod

    Public opc As String

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
            .ColumnCount = 5

            'DEFINICION DE COLUMNAS 
            .Columns(0).HeaderText = "#"
            .Columns(1).HeaderText = "Almacen"
            .Columns(2).HeaderText = "Movimiento"
            .Columns(3).HeaderText = "Empleado"
            .Columns(4).HeaderText = "Fecha de creacion"


            'DEFINE EL ANCHO DE LAS COLUMNAS 
            '.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(0).ValueType = Type.GetType("System.Int32")

            'DEFINE COLUMNA PARA BUSQUEDA
            .Columns(0).Name = "Clave"

            'OCULTAR COLUMNAS
            .Columns(1).Visible = False
            '.Columns(4).Visible = False
            '.Columns(5).Visible = False

            'SOLO LECTURA PARA COLUMNAS 
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True


        End With
    End Sub

    Public Sub LlenarGrid() Implements GripMethod.LlenarGrid
        Dim veh As New DAOMovimientos
        veh.opc = opc
        Dim resultado As List(Of Object) = veh.ListarTodos()

        Dim i As Integer = 0
        Dim a As Integer = 0
        With ListVehiculos
            .Rows.Clear()


            For Each row As Object In resultado
                .Rows.Add(1)
                .Item(0, i).Value = row(0)
                .Item(1, i).Value = row(1)
                .Item(2, i).Value = row(2)
                .Item(3, i).Value = row(3)
                .Item(4, i).Value = row(4)

                i += 1
                a += 1
            Next
            ' listaVehiculos = resultado
            lblTotEntidades.Text = "LISTADOS " & a
        End With
    End Sub

    Private Sub ListadoMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        LlenarGrid()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        CRUBMovimiento.opc = opc
        CRUBMovimiento.recibview = Me
        CRUBMovimiento.ShowDialog()
    End Sub
End Class