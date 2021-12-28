Public Class BuscarProductos
    Implements GripMethod

    Friend Shared recibview As CRUBMovimiento

    Public Sub CrearGrid() Implements GripMethod.CrearGrid
        With DataGridView1
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
            .ColumnCount = 4

            'DEFINICION DE COLUMNAS 
            .Columns(0).HeaderText = "id_articulo"
            .Columns(1).HeaderText = "No Parte"
            .Columns(2).HeaderText = "Articulo"
            .Columns(3).HeaderText = "Unidad"



            'DEFINE EL ANCHO DE LAS COLUMNAS 
            '.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            '.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            '.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


            .Columns(1).ValueType = Type.GetType("System.Int32")

            'DEFINE COLUMNA PARA BUSQUEDA
            .Columns(1).Name = "Clave"

            'OCULTAR COLUMNAS
            .Columns(0).Visible = False
            '.Columns(4).Visible = False
            '.Columns(5).Visible = False

            'SOLO LECTURA PARA COLUMNAS 
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True



        End With
    End Sub

    Public Sub LlenarGrid() Implements GripMethod.LlenarGrid
        Dim veh As New DAOMovimientos
        Dim valor As String = txtValor.Text
        Dim resultado As List(Of Object) = veh.buscarProducto(valor)

        Dim i As Integer = 0
        Dim a As Integer = 0
        With DataGridView1
            .Rows.Clear()


            For Each row As Object In resultado
                .Rows.Add(1)
                .Item(0, i).Value = row(0)
                .Item(1, i).Value = row(1)
                .Item(2, i).Value = row(2)
                .Item(3, i).Value = row(3)


                i += 1
                a += 1
            Next
            ' listaVehiculos = resultado
            ' lblTotEntidades.Text = "LISTADOS " & a
        End With
    End Sub

    Private Sub BuscarProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LlenarGrid()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If recibview.ListVehiculos.RowCount > 0 Then
            Dim x As Integer = recibview.ListVehiculos.RowCount - 1
            If x = 0 Then
                x = 1
            End If
            For Each fila As DataGridViewRow In recibview.ListVehiculos.Rows
                If (fila.Cells(1).Value = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value) Then
                    'MsgBox(fila.Cells(1).Value & " " & DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value)
                    recibview.ListVehiculos.Item(5, fila.Index).Value = recibview.ListVehiculos.Item(5, fila.Index).Value + 1
                    Exit Sub
                End If
            Next
            With recibview.ListVehiculos
                .Rows.Add(1)
                .Item(1, x).Value = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                .Item(2, x).Value = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                .Item(3, x).Value = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
                .Item(4, x).Value = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
                .Item(5, x).Value = InputBox("Ingrese la cantidad", " Cantidad de articulos solicitados", 1)
            End With
        Else
            With recibview.ListVehiculos
                .Rows.Add(1)
                .Item(1, 0).Value = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
                .Item(2, 0).Value = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value
                .Item(3, 0).Value = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value
                .Item(4, 0).Value = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value
                .Item(5, 0).Value = InputBox("Ingrese la cantidad", " Cantidad de articulos solicitados", 1)
            End With
        End If

    End Sub
End Class