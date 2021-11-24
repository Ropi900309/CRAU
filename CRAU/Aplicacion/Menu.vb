Imports System.Runtime.InteropServices
Public Class Menu

    Private currentChildForm As Form


    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub


    Private Sub OpenChildForm(childForm As Form)
        Try
            'Open only form'
            If currentChildForm IsNot Nothing Then
                currentChildForm.Close()
            End If
            currentChildForm = childForm
            'end'
            childForm.TopLevel = False
            childForm.FormBorderStyle = FormBorderStyle.None
            childForm.Dock = DockStyle.Fill
            Panel.Controls.Add(childForm)
            Panel.Tag = childForm
            childForm.BringToFront()
            childForm.Show()
            Me.Text = "Menu - " & childForm.Text
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        OpenChildForm(Productos)
    End Sub

    Private Sub VehiculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehiculosToolStripMenuItem.Click
        OpenChildForm(Vehiculos)
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub
    Private Sub colorMenu()
        Stylo.cambiarColor(mstMenu)
        mstMenu.Renderer = New Stylo
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colorMenu()
        lblFecha.Text = TimeOfDay
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        OpenChildForm(Empleados)
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        OpenChildForm(Usuarios)
    End Sub

    Private Sub RecepciónDeMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecepciónDeMaterialToolStripMenuItem.Click

    End Sub

    Private Sub GarantiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GarantiaToolStripMenuItem.Click

    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click

    End Sub

    Private Sub OrdenDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDeCompraToolStripMenuItem.Click

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        OpenChildForm(Clientes)
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        OpenChildForm(Proveedores)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblFecha.Text = TimeOfDay
    End Sub
End Class