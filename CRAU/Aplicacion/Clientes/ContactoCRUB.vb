
Public Class ContactoCRUB

    Implements GripMethod

    Friend Shared recibview As ClienteCRUB
    Private con As New DAOContacto




    Public Sub CrearGrid() Implements GripMethod.CrearGrid
        With ListClientes
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
            .ColumnCount = 5

            'DEFINICION DE COLUMNAS 
            .Columns(0).HeaderText = "id"
            .Columns(1).HeaderText = "#"
            .Columns(2).HeaderText = "Nombre Contacto"
            .Columns(3).HeaderText = "Correo Electronico"
            .Columns(4).HeaderText = "Telefono"

            'DEFINE EL ANCHO DE LAS COLUMNAS 

            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(1).ValueType = Type.GetType("System.Int32")

            'DEFINE COLUMNA PARA BUSQUEDA
            .Columns(1).Name = "Clave"

            'OCULTAR COLUMNAS
            .Columns(0).Visible = False


            'SOLO LECTURA PARA COLUMNAS 
            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True

        End With
    End Sub

    Public Sub LlenarGrid() Implements GripMethod.LlenarGrid
        Try
            Dim con As New DAOContacto
            con.Asociado.Id = recibview.cli.Id
            Dim resultado As List(Of Ccontacto) = con.ListarTodos()

            Dim i As Integer = 0
            Dim a As Integer = 0
            With ListClientes
                .Rows.Clear()


                For Each row As Ccontacto In resultado
                    .Rows.Add(1)
                    .Item(0, i).Value = row.Id
                    .Item(1, i).Value = row.Asociado.Id
                    .Item(2, i).Value = row.Nombre_contacto
                    .Item(3, i).Value = row.Correo_electronico
                    .Item(4, i).Value = row.Telefono


                    i += 1

                    a += 1

                Next
            End With

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub


    Private Sub ContactoCRUB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CrearGrid()
            LlenarGrid()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

End Class