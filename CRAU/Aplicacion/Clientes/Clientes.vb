Public Class Clientes


    Implements GripMethod
    Private listaClientes As List(Of Cliente)

    Public Sub CrearGrid() Implements GripMethod.CrearGrid
        With ListClientes
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
            .Columns(0).HeaderText = "#"
            .Columns(1).HeaderText = "Razon Social"
            .Columns(2).HeaderText = "RFC"
            .Columns(3).HeaderText = "Dirección"
            .Columns(4).HeaderText = "Tipoid"
            .Columns(5).HeaderText = "Tipo"


            'DEFINE EL ANCHO DE LAS COLUMNAS 
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


            .Columns(1).ValueType = Type.GetType("System.Int32")

            'DEFINE COLUMNA PARA BUSQUEDA

            .Columns(1).Name = "Clave"


            'OCULTAR COLUMNAS
            .Columns(4).Visible = False

            'SOLO LECTURA PARA COLUMNAS 
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = True



        End With
    End Sub

    Public Sub LlenarGrid() Implements GripMethod.LlenarGrid

        Try
            Dim cli As New DAOCliente

            Dim resultado As List(Of Cliente) = cli.ListarTodos()

            Dim i As Integer = 0
            Dim a As Integer = 0
            With ListClientes
                .Rows.Clear()

                For Each row As Cliente In resultado
                    .Rows.Add(1)
                    .Item(0, i).Value = row.Id
                    .Item(1, i).Value = row.Razon_social
                    .Item(2, i).Value = row.Rfc
                    .Item(3, i).Value = row.Direccion
                    .Item(4, i).Value = row.Tipo.Id
                    .Item(5, i).Value = row.Tipo.Tipo_asociado
                    i += 1
                    a += 1
                Next
                listaClientes = resultado
                lblTotEntidades.Text = "LISTADOS " & a
            End With

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            Dim cli As New Cliente

            ClienteCRUB.cli = cli
            ClienteCRUB.recibView = Me
            ClienteCRUB.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Dim cli As New Cliente
            With ListClientes
                'MsgBox(veh.Id)

                cli.Id = .Item(0, .CurrentRow.Index).Value
                cli = listaClientes(BuscarClienteLista(cli.Id))

                ClienteCRUB.cli = cli
                ClienteCRUB.recibView = Me
                ClienteCRUB.ShowDialog()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Private Function BuscarClienteLista(id As Integer) As Integer
        Dim indice As Integer = 0

        For Each item As Cliente In listaClientes
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

    Private Sub textBuscar_TextChanged(sender As Object, e As EventArgs)
        Metodos.Buscar(textBuscar.Text, ListClientes, 1, 2)
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            CrearGrid()
            LlenarGrid()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

End Class