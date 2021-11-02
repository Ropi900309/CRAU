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
End Class