﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstMenu = New System.Windows.Forms.MenuStrip()
        Me.AlmacenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecepciónDeMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjusteInventarioEntradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidaDeMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjusteInventarioSalidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GarantiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResguardoDeHerramientaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequisicionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TallerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenServicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitterIzq = New System.Windows.Forms.Splitter()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.PanelInf = New System.Windows.Forms.Panel()
        Me.mstMenu.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.PanelInf.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ServiciosToolStripMenuItem, Me.EmpleadosToolStripMenuItem, Me.VehiculosToolStripMenuItem})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(82, 21)
        Me.SalirToolStripMenuItem.Text = "Cátalogos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ServiciosToolStripMenuItem.Text = "Servicios"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'VehiculosToolStripMenuItem
        '
        Me.VehiculosToolStripMenuItem.Name = "VehiculosToolStripMenuItem"
        Me.VehiculosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VehiculosToolStripMenuItem.Text = "Vehiculos"
        '
        'mstMenu
        '
        Me.mstMenu.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mstMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mstMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlmacenToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.SalirToolStripMenuItem, Me.TallerToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.mstMenu.Location = New System.Drawing.Point(0, 0)
        Me.mstMenu.Name = "mstMenu"
        Me.mstMenu.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mstMenu.Size = New System.Drawing.Size(1028, 25)
        Me.mstMenu.TabIndex = 73
        Me.mstMenu.Text = "mstMenu"
        '
        'AlmacenToolStripMenuItem
        '
        Me.AlmacenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovimientosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ResguardoDeHerramientaToolStripMenuItem})
        Me.AlmacenToolStripMenuItem.Name = "AlmacenToolStripMenuItem"
        Me.AlmacenToolStripMenuItem.Size = New System.Drawing.Size(74, 21)
        Me.AlmacenToolStripMenuItem.Text = "Almacen"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecepciónDeMaterialToolStripMenuItem, Me.AjusteInventarioEntradaToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.MovimientosToolStripMenuItem.Text = "Entradas"
        '
        'RecepciónDeMaterialToolStripMenuItem
        '
        Me.RecepciónDeMaterialToolStripMenuItem.Name = "RecepciónDeMaterialToolStripMenuItem"
        Me.RecepciónDeMaterialToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.RecepciónDeMaterialToolStripMenuItem.Text = "Recepción de Material"
        '
        'AjusteInventarioEntradaToolStripMenuItem
        '
        Me.AjusteInventarioEntradaToolStripMenuItem.Name = "AjusteInventarioEntradaToolStripMenuItem"
        Me.AjusteInventarioEntradaToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.AjusteInventarioEntradaToolStripMenuItem.Text = "Ajuste Inventario Entrada"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalidaDeMaterialToolStripMenuItem, Me.AjusteInventarioSalidaToolStripMenuItem, Me.VentaToolStripMenuItem, Me.GarantiaToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ReportesToolStripMenuItem.Text = "Salidas"
        '
        'SalidaDeMaterialToolStripMenuItem
        '
        Me.SalidaDeMaterialToolStripMenuItem.Name = "SalidaDeMaterialToolStripMenuItem"
        Me.SalidaDeMaterialToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.SalidaDeMaterialToolStripMenuItem.Text = "Salida De Material"
        '
        'AjusteInventarioSalidaToolStripMenuItem
        '
        Me.AjusteInventarioSalidaToolStripMenuItem.Name = "AjusteInventarioSalidaToolStripMenuItem"
        Me.AjusteInventarioSalidaToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.AjusteInventarioSalidaToolStripMenuItem.Text = "Ajuste Inventario Salida"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'GarantiaToolStripMenuItem
        '
        Me.GarantiaToolStripMenuItem.Name = "GarantiaToolStripMenuItem"
        Me.GarantiaToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.GarantiaToolStripMenuItem.Text = "Garantia"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ResguardoDeHerramientaToolStripMenuItem
        '
        Me.ResguardoDeHerramientaToolStripMenuItem.Name = "ResguardoDeHerramientaToolStripMenuItem"
        Me.ResguardoDeHerramientaToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ResguardoDeHerramientaToolStripMenuItem.Text = "Resguardo de herramienta"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequisicionesToolStripMenuItem, Me.OrdenDeCompraToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(75, 21)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'RequisicionesToolStripMenuItem
        '
        Me.RequisicionesToolStripMenuItem.Name = "RequisicionesToolStripMenuItem"
        Me.RequisicionesToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.RequisicionesToolStripMenuItem.Text = "Requisiciones"
        '
        'OrdenDeCompraToolStripMenuItem
        '
        Me.OrdenDeCompraToolStripMenuItem.Name = "OrdenDeCompraToolStripMenuItem"
        Me.OrdenDeCompraToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.OrdenDeCompraToolStripMenuItem.Text = "Orden de Compra"
        '
        'TallerToolStripMenuItem
        '
        Me.TallerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenServicioToolStripMenuItem})
        Me.TallerToolStripMenuItem.Name = "TallerToolStripMenuItem"
        Me.TallerToolStripMenuItem.Size = New System.Drawing.Size(55, 21)
        Me.TallerToolStripMenuItem.Text = "Taller"
        '
        'OrdenServicioToolStripMenuItem
        '
        Me.OrdenServicioToolStripMenuItem.Name = "OrdenServicioToolStripMenuItem"
        Me.OrdenServicioToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.OrdenServicioToolStripMenuItem.Text = "Orden Servicio"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DepartamentosToolStripMenuItem, Me.UsuarioToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(109, 21)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'DepartamentosToolStripMenuItem
        '
        Me.DepartamentosToolStripMenuItem.Name = "DepartamentosToolStripMenuItem"
        Me.DepartamentosToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DepartamentosToolStripMenuItem.Text = "Departamentos"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(102, 21)
        Me.SalirToolStripMenuItem1.Text = "Cerrar Sesión"
        '
        'SplitterIzq
        '
        Me.SplitterIzq.BackColor = System.Drawing.Color.DimGray
        Me.SplitterIzq.Location = New System.Drawing.Point(0, 0)
        Me.SplitterIzq.Name = "SplitterIzq"
        Me.SplitterIzq.Size = New System.Drawing.Size(3, 397)
        Me.SplitterIzq.TabIndex = 0
        Me.SplitterIzq.TabStop = False
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.White
        Me.Panel.Controls.Add(Me.SplitterIzq)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.Location = New System.Drawing.Point(0, 25)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(1028, 397)
        Me.Panel.TabIndex = 80
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(967, 9)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "Fecha:"
        '
        'PanelInf
        '
        Me.PanelInf.BackColor = System.Drawing.Color.DarkBlue
        Me.PanelInf.Controls.Add(Me.lblFecha)
        Me.PanelInf.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInf.Location = New System.Drawing.Point(0, 422)
        Me.PanelInf.Name = "PanelInf"
        Me.PanelInf.Size = New System.Drawing.Size(1028, 28)
        Me.PanelInf.TabIndex = 78
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 450)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.PanelInf)
        Me.Controls.Add(Me.mstMenu)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mstMenu.ResumeLayout(False)
        Me.mstMenu.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.PanelInf.ResumeLayout(False)
        Me.PanelInf.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mstMenu As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlmacenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VehiculosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TallerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartamentosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RequisicionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenDeCompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrdenServicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitterIzq As Splitter
    Friend WithEvents Panel As Panel
    Friend WithEvents RecepciónDeMaterialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjusteInventarioEntradaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GarantiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjusteInventarioSalidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResguardoDeHerramientaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lblFecha As Label
    Friend WithEvents PanelInf As Panel
    Friend WithEvents SalidaDeMaterialToolStripMenuItem As ToolStripMenuItem
End Class