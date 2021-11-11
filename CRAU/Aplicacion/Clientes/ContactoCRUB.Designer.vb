<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ContactoCRUB
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
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textNombre = New System.Windows.Forms.TextBox()
        Me.ListClientes = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.ListClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(252, 310)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(99, 23)
        Me.btnSeleccionar.TabIndex = 337
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(357, 310)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(99, 23)
        Me.btnEditar.TabIndex = 336
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(462, 310)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(99, 23)
        Me.btnEliminar.TabIndex = 335
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(462, 10)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(99, 23)
        Me.btnGuardar.TabIndex = 334
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 333
        Me.Label1.Text = "Nombre"
        '
        'textNombre
        '
        Me.textNombre.Location = New System.Drawing.Point(66, 12)
        Me.textNombre.Name = "textNombre"
        Me.textNombre.Size = New System.Drawing.Size(390, 20)
        Me.textNombre.TabIndex = 332
        '
        'ListClientes
        '
        Me.ListClientes.AllowUserToAddRows = False
        Me.ListClientes.AllowUserToDeleteRows = False
        Me.ListClientes.AllowUserToResizeRows = False
        Me.ListClientes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ListClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ListClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.ListClientes.Location = New System.Drawing.Point(19, 88)
        Me.ListClientes.Name = "ListClientes"
        Me.ListClientes.ReadOnly = True
        Me.ListClientes.RowHeadersVisible = False
        Me.ListClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListClientes.Size = New System.Drawing.Size(542, 207)
        Me.ListClientes.TabIndex = 331
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(372, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 339
        Me.Label3.Text = "Telefono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 338
        Me.Label2.Text = "Correo"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(427, 52)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(134, 20)
        Me.TextBox2.TabIndex = 336
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(66, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(300, 20)
        Me.TextBox1.TabIndex = 335
        '
        'ContactoCRUB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 345)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ListClientes)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.textNombre)
        Me.Name = "ContactoCRUB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ContactoCRUB"
        CType(Me.ListClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents textNombre As TextBox
    Friend WithEvents ListClientes As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
