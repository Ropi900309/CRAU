Imports Microsoft.Reporting.WinForms

Public Class RptProductos

    Private Sub RptProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DtsDatos.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DtsDatos.Productos)
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport
        Me.ReportViewer1.RefreshReport
    End Sub


End Class