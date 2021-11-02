<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vehiculos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTotEntidades = New System.Windows.Forms.Label()
        Me.btnNuevo = New FontAwesome.Sharp.IconButton()
        Me.btnEditar = New FontAwesome.Sharp.IconButton()
        Me.ListProductos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBuscar = New FontAwesome.Sharp.IconButton()
        Me.textBuscar = New System.Windows.Forms.TextBox()
        CType(Me.ListProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotEntidades
        '
        Me.lblTotEntidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotEntidades.AutoSize = True
        Me.lblTotEntidades.Location = New System.Drawing.Point(12, 598)
        Me.lblTotEntidades.Name = "lblTotEntidades"
        Me.lblTotEntidades.Size = New System.Drawing.Size(63, 13)
        Me.lblTotEntidades.TabIndex = 300
        Me.lblTotEntidades.Text = "LISTADOS:"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Box
        Me.btnNuevo.IconColor = System.Drawing.Color.Black
        Me.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNuevo.IconSize = 25
        Me.btnNuevo.Location = New System.Drawing.Point(1213, 587)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(47, 35)
        Me.btnNuevo.TabIndex = 299
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit
        Me.btnEditar.IconColor = System.Drawing.Color.Black
        Me.btnEditar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEditar.IconSize = 25
        Me.btnEditar.Location = New System.Drawing.Point(1266, 587)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(54, 35)
        Me.btnEditar.TabIndex = 298
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'ListProductos
        '
        Me.ListProductos.AllowUserToAddRows = False
        Me.ListProductos.AllowUserToDeleteRows = False
        Me.ListProductos.AllowUserToResizeRows = False
        Me.ListProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ListProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.ListProductos.Location = New System.Drawing.Point(12, 52)
        Me.ListProductos.Name = "ListProductos"
        Me.ListProductos.ReadOnly = True
        Me.ListProductos.RowHeadersVisible = False
        Me.ListProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListProductos.Size = New System.Drawing.Size(1308, 524)
        Me.ListProductos.TabIndex = 297
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(932, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 296
        Me.Label1.Text = "Buscar Producto"
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.btnBuscar.IconColor = System.Drawing.Color.Black
        Me.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBuscar.IconSize = 25
        Me.btnBuscar.Location = New System.Drawing.Point(1273, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(47, 35)
        Me.btnBuscar.TabIndex = 295
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'textBuscar
        '
        Me.textBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBuscar.Location = New System.Drawing.Point(1024, 20)
        Me.textBuscar.Name = "textBuscar"
        Me.textBuscar.Size = New System.Drawing.Size(243, 20)
        Me.textBuscar.TabIndex = 294
        '
        'Vehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 634)
        Me.Controls.Add(Me.lblTotEntidades)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.ListProductos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.textBuscar)
        Me.Name = "Vehiculos"
        Me.Text = "Vehiculos"
        CType(Me.ListProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotEntidades As Label
    Friend WithEvents btnNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditar As FontAwesome.Sharp.IconButton
    Friend WithEvents ListProductos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents textBuscar As TextBox
End Class
