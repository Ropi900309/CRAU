Public Class CRUBMovimiento
    Implements GripMethod

    Friend Shared recibview As ListadoMovimientos
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
            .ColumnCount = 6

            'DEFINICION DE COLUMNAS 
            .Columns(0).HeaderText = "id_movimiento"
            .Columns(1).HeaderText = "id_producto"
            .Columns(2).HeaderText = "NO_PARTE"
            .Columns(3).HeaderText = "DESCRIPCION"
            .Columns(4).HeaderText = "UNIDAD"
            .Columns(5).HeaderText = "CANTIDAD"


            .Columns(1).ContextMenuStrip = ContextMenuStrip1
            .Columns(2).ContextMenuStrip = ContextMenuStrip1
            .Columns(3).ContextMenuStrip = ContextMenuStrip1
            .Columns(4).ContextMenuStrip = ContextMenuStrip1
            .Columns(5).ContextMenuStrip = ContextMenuStrip1



            'DEFINE EL ANCHO DE LAS COLUMNAS 
            '.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            '.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            '.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            '.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(0).ValueType = Type.GetType("System.Int32")

            'DEFINE COLUMNA PARA BUSQUEDA
            .Columns(0).Name = "Clave"

            'OCULTAR COLUMNAS
            .Columns(0).Visible = False
            .Columns(1).Visible = False


            'SOLO LECTURA PARA COLUMNAS 
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True


        End With



    End Sub

    Public Sub LlenarGrid() Implements GripMethod.LlenarGrid
        Throw New NotImplementedException()
    End Sub

    Private Sub CRUBMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmpleado.Text = Active.usuario.Empleado.Nombre
        txtMovimiento.Text = opc
        CrearGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BuscarProductos.recibview = Me
        BuscarProductos.ShowDialog()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try
            With ListVehiculos
                If Not .RowCount = 0 Then
                    .Rows.Remove(.CurrentRow)
                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim mv As New DAOMovimientos
            Dim id As Integer = mv.Count()
            mv.Guardar(id, 1, opc, Active.usuario.Empleado.Id, Today)
            For Each fila As DataGridViewRow In ListVehiculos.Rows
                mv.guardarDetalle(id, fila.Cells(1).Value, fila.Cells(5).Value)
            Next
            MsgBox("Se ha guandaron los cambios correctamente", vbInformation, "Resultado")
            recibview.LlenarGrid()
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgBox("Error al insertar", vbCritical, "error")
        End Try



    End Sub
End Class