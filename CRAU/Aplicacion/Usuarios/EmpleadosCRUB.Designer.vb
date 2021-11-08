<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpleadosCRUB
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.txtMAterno = New System.Windows.Forms.TextBox()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.txtNss = New System.Windows.Forms.TextBox()
        Me.comboDepto = New System.Windows.Forms.ComboBox()
        Me.comboPuesto = New System.Windows.Forms.ComboBox()
        Me.dateAlta = New System.Windows.Forms.DateTimePicker()
        Me.dateBaja = New System.Windows.Forms.DateTimePicker()
        Me.btnNewDepto = New System.Windows.Forms.Button()
        Me.btnNewPuesto = New System.Windows.Forms.Button()
        Me.btnErase = New FontAwesome.Sharp.IconButton()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.btnSalir = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Paterno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "materno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "RFC"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "NSS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(416, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha Baja"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(416, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Fecha Alta"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(408, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Departamento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(443, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Puesto"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(100, 40)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(230, 20)
        Me.txtNombre.TabIndex = 9
        '
        'txtPaterno
        '
        Me.txtPaterno.Location = New System.Drawing.Point(100, 84)
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(230, 20)
        Me.txtPaterno.TabIndex = 10
        '
        'txtMAterno
        '
        Me.txtMAterno.Location = New System.Drawing.Point(100, 129)
        Me.txtMAterno.Name = "txtMAterno"
        Me.txtMAterno.Size = New System.Drawing.Size(230, 20)
        Me.txtMAterno.TabIndex = 11
        '
        'txtRfc
        '
        Me.txtRfc.Location = New System.Drawing.Point(100, 175)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.Size = New System.Drawing.Size(230, 20)
        Me.txtRfc.TabIndex = 12
        '
        'txtNss
        '
        Me.txtNss.Location = New System.Drawing.Point(100, 222)
        Me.txtNss.Name = "txtNss"
        Me.txtNss.Size = New System.Drawing.Size(230, 20)
        Me.txtNss.TabIndex = 13
        '
        'comboDepto
        '
        Me.comboDepto.FormattingEnabled = True
        Me.comboDepto.Location = New System.Drawing.Point(495, 40)
        Me.comboDepto.Name = "comboDepto"
        Me.comboDepto.Size = New System.Drawing.Size(201, 21)
        Me.comboDepto.TabIndex = 16
        '
        'comboPuesto
        '
        Me.comboPuesto.FormattingEnabled = True
        Me.comboPuesto.Location = New System.Drawing.Point(495, 89)
        Me.comboPuesto.Name = "comboPuesto"
        Me.comboPuesto.Size = New System.Drawing.Size(201, 21)
        Me.comboPuesto.TabIndex = 17
        '
        'dateAlta
        '
        Me.dateAlta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateAlta.Location = New System.Drawing.Point(496, 143)
        Me.dateAlta.Name = "dateAlta"
        Me.dateAlta.Size = New System.Drawing.Size(200, 20)
        Me.dateAlta.TabIndex = 18
        '
        'dateBaja
        '
        Me.dateBaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateBaja.Location = New System.Drawing.Point(496, 190)
        Me.dateBaja.Name = "dateBaja"
        Me.dateBaja.Size = New System.Drawing.Size(200, 20)
        Me.dateBaja.TabIndex = 19
        '
        'btnNewDepto
        '
        Me.btnNewDepto.Location = New System.Drawing.Point(702, 40)
        Me.btnNewDepto.Name = "btnNewDepto"
        Me.btnNewDepto.Size = New System.Drawing.Size(30, 23)
        Me.btnNewDepto.TabIndex = 20
        Me.btnNewDepto.Text = "..."
        Me.btnNewDepto.UseVisualStyleBackColor = True
        '
        'btnNewPuesto
        '
        Me.btnNewPuesto.Location = New System.Drawing.Point(702, 87)
        Me.btnNewPuesto.Name = "btnNewPuesto"
        Me.btnNewPuesto.Size = New System.Drawing.Size(30, 23)
        Me.btnNewPuesto.TabIndex = 21
        Me.btnNewPuesto.Text = "..."
        Me.btnNewPuesto.UseVisualStyleBackColor = True
        '
        'btnErase
        '
        Me.btnErase.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnErase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnErase.ForeColor = System.Drawing.Color.White
        Me.btnErase.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnErase.IconColor = System.Drawing.Color.White
        Me.btnErase.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnErase.IconSize = 25
        Me.btnErase.Location = New System.Drawing.Point(662, 386)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(107, 38)
        Me.btnErase.TabIndex = 23
        Me.btnErase.Text = "Eliminar"
        Me.btnErase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnErase.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnSave.IconColor = System.Drawing.Color.White
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.IconSize = 25
        Me.btnSave.Location = New System.Drawing.Point(542, 386)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 38)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Guardar"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.IconChar = FontAwesome.Sharp.IconChar.WindowClose
        Me.btnSalir.IconColor = System.Drawing.Color.White
        Me.btnSalir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSalir.IconSize = 25
        Me.btnSalir.Location = New System.Drawing.Point(47, 386)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(99, 38)
        Me.btnSalir.TabIndex = 24
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'EmpleadosCRUB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnErase)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNewPuesto)
        Me.Controls.Add(Me.btnNewDepto)
        Me.Controls.Add(Me.dateBaja)
        Me.Controls.Add(Me.dateAlta)
        Me.Controls.Add(Me.comboPuesto)
        Me.Controls.Add(Me.comboDepto)
        Me.Controls.Add(Me.txtNss)
        Me.Controls.Add(Me.txtRfc)
        Me.Controls.Add(Me.txtMAterno)
        Me.Controls.Add(Me.txtPaterno)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EmpleadosCRUB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmpleadosCRUB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPaterno As TextBox
    Friend WithEvents txtMAterno As TextBox
    Friend WithEvents txtRfc As TextBox
    Friend WithEvents txtNss As TextBox
    Friend WithEvents comboDepto As ComboBox
    Friend WithEvents comboPuesto As ComboBox
    Friend WithEvents dateAlta As DateTimePicker
    Friend WithEvents dateBaja As DateTimePicker
    Friend WithEvents btnNewDepto As Button
    Friend WithEvents btnNewPuesto As Button
    Friend WithEvents btnErase As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconButton
End Class
