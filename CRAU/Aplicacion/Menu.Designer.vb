<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.components = New System.ComponentModel.Container()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.OrdenDeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TallerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrdenServicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NominaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelDeAsistenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculoDeNominaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitterIzq = New System.Windows.Forms.Splitter()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.PanelInf = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mstMenu.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.PanelInf.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.VehiculosToolStripMenuItem})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(94, 23)
        Me.SalirToolStripMenuItem.Text = "Cátalogos"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'VehiculosToolStripMenuItem
        '
        Me.VehiculosToolStripMenuItem.Name = "VehiculosToolStripMenuItem"
        Me.VehiculosToolStripMenuItem.Size = New System.Drawing.Size(171, 24)
        Me.VehiculosToolStripMenuItem.Text = "Vehiculos"
        '
        'mstMenu
        '
        Me.mstMenu.BackColor = System.Drawing.Color.White
        Me.mstMenu.Font = New System.Drawing.Font("Microsoft JhengHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mstMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mstMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlmacenToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.SalirToolStripMenuItem, Me.TallerToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.NominaToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.mstMenu.Location = New System.Drawing.Point(0, 0)
        Me.mstMenu.Name = "mstMenu"
        Me.mstMenu.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mstMenu.Size = New System.Drawing.Size(1028, 27)
        Me.mstMenu.TabIndex = 73
        Me.mstMenu.Text = "mstMenu"
        '
        'AlmacenToolStripMenuItem
        '
        Me.AlmacenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MovimientosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ResguardoDeHerramientaToolStripMenuItem})
        Me.AlmacenToolStripMenuItem.Name = "AlmacenToolStripMenuItem"
        Me.AlmacenToolStripMenuItem.Size = New System.Drawing.Size(84, 23)
        Me.AlmacenToolStripMenuItem.Text = "Almacen"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecepciónDeMaterialToolStripMenuItem, Me.AjusteInventarioEntradaToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.MovimientosToolStripMenuItem.Text = "Entradas"
        '
        'RecepciónDeMaterialToolStripMenuItem
        '
        Me.RecepciónDeMaterialToolStripMenuItem.Name = "RecepciónDeMaterialToolStripMenuItem"
        Me.RecepciónDeMaterialToolStripMenuItem.Size = New System.Drawing.Size(261, 24)
        Me.RecepciónDeMaterialToolStripMenuItem.Text = "Recepción de Material"
        '
        'AjusteInventarioEntradaToolStripMenuItem
        '
        Me.AjusteInventarioEntradaToolStripMenuItem.Name = "AjusteInventarioEntradaToolStripMenuItem"
        Me.AjusteInventarioEntradaToolStripMenuItem.Size = New System.Drawing.Size(261, 24)
        Me.AjusteInventarioEntradaToolStripMenuItem.Text = "Ajuste Inventario Entrada"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalidaDeMaterialToolStripMenuItem, Me.AjusteInventarioSalidaToolStripMenuItem, Me.VentaToolStripMenuItem, Me.GarantiaToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.ReportesToolStripMenuItem.Text = "Salidas"
        '
        'SalidaDeMaterialToolStripMenuItem
        '
        Me.SalidaDeMaterialToolStripMenuItem.Name = "SalidaDeMaterialToolStripMenuItem"
        Me.SalidaDeMaterialToolStripMenuItem.Size = New System.Drawing.Size(249, 24)
        Me.SalidaDeMaterialToolStripMenuItem.Text = "Salida De Material"
        '
        'AjusteInventarioSalidaToolStripMenuItem
        '
        Me.AjusteInventarioSalidaToolStripMenuItem.Name = "AjusteInventarioSalidaToolStripMenuItem"
        Me.AjusteInventarioSalidaToolStripMenuItem.Size = New System.Drawing.Size(249, 24)
        Me.AjusteInventarioSalidaToolStripMenuItem.Text = "Ajuste Inventario Salida"
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(249, 24)
        Me.VentaToolStripMenuItem.Text = "Venta"
        '
        'GarantiaToolStripMenuItem
        '
        Me.GarantiaToolStripMenuItem.Name = "GarantiaToolStripMenuItem"
        Me.GarantiaToolStripMenuItem.Size = New System.Drawing.Size(249, 24)
        Me.GarantiaToolStripMenuItem.Text = "Garantia"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ResguardoDeHerramientaToolStripMenuItem
        '
        Me.ResguardoDeHerramientaToolStripMenuItem.Name = "ResguardoDeHerramientaToolStripMenuItem"
        Me.ResguardoDeHerramientaToolStripMenuItem.Size = New System.Drawing.Size(272, 24)
        Me.ResguardoDeHerramientaToolStripMenuItem.Text = "Resguardo de herramienta"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RequisicionesToolStripMenuItem, Me.OrdenDeCompraToolStripMenuItem, Me.OrdenDeVentaToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(86, 23)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'RequisicionesToolStripMenuItem
        '
        Me.RequisicionesToolStripMenuItem.Name = "RequisicionesToolStripMenuItem"
        Me.RequisicionesToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.RequisicionesToolStripMenuItem.Text = "Requisiciones"
        '
        'OrdenDeCompraToolStripMenuItem
        '
        Me.OrdenDeCompraToolStripMenuItem.Name = "OrdenDeCompraToolStripMenuItem"
        Me.OrdenDeCompraToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.OrdenDeCompraToolStripMenuItem.Text = "Orden de Compra"
        '
        'OrdenDeVentaToolStripMenuItem
        '
        Me.OrdenDeVentaToolStripMenuItem.Name = "OrdenDeVentaToolStripMenuItem"
        Me.OrdenDeVentaToolStripMenuItem.Size = New System.Drawing.Size(209, 24)
        Me.OrdenDeVentaToolStripMenuItem.Text = "Orden de Venta"
        '
        'TallerToolStripMenuItem
        '
        Me.TallerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenServicioToolStripMenuItem})
        Me.TallerToolStripMenuItem.Name = "TallerToolStripMenuItem"
        Me.TallerToolStripMenuItem.Size = New System.Drawing.Size(61, 23)
        Me.TallerToolStripMenuItem.Text = "Taller"
        '
        'OrdenServicioToolStripMenuItem
        '
        Me.OrdenServicioToolStripMenuItem.Name = "OrdenServicioToolStripMenuItem"
        Me.OrdenServicioToolStripMenuItem.Size = New System.Drawing.Size(186, 24)
        Me.OrdenServicioToolStripMenuItem.Text = "Orden Servicio"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.UsuarioToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(106, 23)
        Me.ConfiguraciónToolStripMenuItem.Text = "Administrar"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'NominaToolStripMenuItem
        '
        Me.NominaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PanelDeAsistenciasToolStripMenuItem, Me.CalculoDeNominaToolStripMenuItem})
        Me.NominaToolStripMenuItem.Name = "NominaToolStripMenuItem"
        Me.NominaToolStripMenuItem.Size = New System.Drawing.Size(78, 23)
        Me.NominaToolStripMenuItem.Text = "Nomina"
        '
        'PanelDeAsistenciasToolStripMenuItem
        '
        Me.PanelDeAsistenciasToolStripMenuItem.Name = "PanelDeAsistenciasToolStripMenuItem"
        Me.PanelDeAsistenciasToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.PanelDeAsistenciasToolStripMenuItem.Text = "Panel de asistencias"
        '
        'CalculoDeNominaToolStripMenuItem
        '
        Me.CalculoDeNominaToolStripMenuItem.Name = "CalculoDeNominaToolStripMenuItem"
        Me.CalculoDeNominaToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.CalculoDeNominaToolStripMenuItem.Text = "Calculo de nominas"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(118, 23)
        Me.SalirToolStripMenuItem1.Text = "Cerrar Sesión"
        '
        'SplitterIzq
        '
        Me.SplitterIzq.BackColor = System.Drawing.Color.DimGray
        Me.SplitterIzq.Location = New System.Drawing.Point(0, 0)
        Me.SplitterIzq.Name = "SplitterIzq"
        Me.SplitterIzq.Size = New System.Drawing.Size(3, 395)
        Me.SplitterIzq.TabIndex = 0
        Me.SplitterIzq.TabStop = False
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.White
        Me.Panel.Controls.Add(Me.SplitterIzq)
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel.Location = New System.Drawing.Point(0, 27)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(1028, 395)
        Me.Panel.TabIndex = 80
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(68, 5)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(59, 18)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "Fecha:"
        '
        'PanelInf
        '
        Me.PanelInf.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.PanelInf.Controls.Add(Me.Label1)
        Me.PanelInf.Controls.Add(Me.lblFecha)
        Me.PanelInf.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelInf.Location = New System.Drawing.Point(0, 422)
        Me.PanelInf.Name = "PanelInf"
        Me.PanelInf.Size = New System.Drawing.Size(1028, 28)
        Me.PanelInf.TabIndex = 78
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hora:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
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
    Friend WithEvents AlmacenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VehiculosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TallerToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents OrdenDeVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NominaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelDeAsistenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculoDeNominaToolStripMenuItem As ToolStripMenuItem
End Class
