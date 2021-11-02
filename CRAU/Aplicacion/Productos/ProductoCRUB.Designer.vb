<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductoCRUB
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.textParte = New System.Windows.Forms.TextBox()
        Me.textDescripcion = New System.Windows.Forms.TextBox()
        Me.textPPromedio = New System.Windows.Forms.TextBox()
        Me.textPCompra = New System.Windows.Forms.TextBox()
        Me.textPVenta = New System.Windows.Forms.TextBox()
        Me.comboMarca = New System.Windows.Forms.ComboBox()
        Me.comboMedida = New System.Windows.Forms.ComboBox()
        Me.comboCategoria = New System.Windows.Forms.ComboBox()
        Me.comboFamilia = New System.Windows.Forms.ComboBox()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.btnErase = New FontAwesome.Sharp.IconButton()
        Me.textExistencia = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textAlertMax = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.textAlertMin = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "# Parte"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(429, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio Venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(429, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Costo Promedio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Marca"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Medida"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(203, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Categoria"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(203, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Familia"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(429, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Precio Compra"
        '
        'textParte
        '
        Me.textParte.Location = New System.Drawing.Point(76, 27)
        Me.textParte.Name = "textParte"
        Me.textParte.Size = New System.Drawing.Size(306, 20)
        Me.textParte.TabIndex = 10
        '
        'textDescripcion
        '
        Me.textDescripcion.Location = New System.Drawing.Point(36, 272)
        Me.textDescripcion.Multiline = True
        Me.textDescripcion.Name = "textDescripcion"
        Me.textDescripcion.Size = New System.Drawing.Size(694, 110)
        Me.textDescripcion.TabIndex = 11
        '
        'textPPromedio
        '
        Me.textPPromedio.Location = New System.Drawing.Point(529, 132)
        Me.textPPromedio.Name = "textPPromedio"
        Me.textPPromedio.Size = New System.Drawing.Size(201, 20)
        Me.textPPromedio.TabIndex = 12
        '
        'textPCompra
        '
        Me.textPCompra.Location = New System.Drawing.Point(529, 27)
        Me.textPCompra.Name = "textPCompra"
        Me.textPCompra.Size = New System.Drawing.Size(201, 20)
        Me.textPCompra.TabIndex = 13
        '
        'textPVenta
        '
        Me.textPVenta.Location = New System.Drawing.Point(529, 78)
        Me.textPVenta.Name = "textPVenta"
        Me.textPVenta.Size = New System.Drawing.Size(201, 20)
        Me.textPVenta.TabIndex = 17
        '
        'comboMarca
        '
        Me.comboMarca.FormattingEnabled = True
        Me.comboMarca.Location = New System.Drawing.Point(76, 132)
        Me.comboMarca.Name = "comboMarca"
        Me.comboMarca.Size = New System.Drawing.Size(121, 21)
        Me.comboMarca.TabIndex = 18
        '
        'comboMedida
        '
        Me.comboMedida.FormattingEnabled = True
        Me.comboMedida.Location = New System.Drawing.Point(76, 78)
        Me.comboMedida.Name = "comboMedida"
        Me.comboMedida.Size = New System.Drawing.Size(121, 21)
        Me.comboMedida.TabIndex = 19
        '
        'comboCategoria
        '
        Me.comboCategoria.FormattingEnabled = True
        Me.comboCategoria.Location = New System.Drawing.Point(261, 78)
        Me.comboCategoria.Name = "comboCategoria"
        Me.comboCategoria.Size = New System.Drawing.Size(121, 21)
        Me.comboCategoria.TabIndex = 20
        '
        'comboFamilia
        '
        Me.comboFamilia.FormattingEnabled = True
        Me.comboFamilia.Location = New System.Drawing.Point(261, 132)
        Me.comboFamilia.Name = "comboFamilia"
        Me.comboFamilia.Size = New System.Drawing.Size(121, 21)
        Me.comboFamilia.TabIndex = 21
        '
        'btnSave
        '
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnSave.IconColor = System.Drawing.Color.Black
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.IconSize = 25
        Me.btnSave.Location = New System.Drawing.Point(544, 389)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 38)
        Me.btnSave.TabIndex = 22
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnErase
        '
        Me.btnErase.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnErase.IconColor = System.Drawing.Color.Black
        Me.btnErase.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnErase.IconSize = 25
        Me.btnErase.Location = New System.Drawing.Point(655, 389)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(75, 38)
        Me.btnErase.TabIndex = 23
        Me.btnErase.UseVisualStyleBackColor = True
        '
        'textExistencia
        '
        Me.textExistencia.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.textExistencia.Location = New System.Drawing.Point(94, 190)
        Me.textExistencia.Name = "textExistencia"
        Me.textExistencia.ReadOnly = True
        Me.textExistencia.Size = New System.Drawing.Size(148, 20)
        Me.textExistencia.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 193)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Existencia"
        '
        'textAlertMax
        '
        Me.textAlertMax.Location = New System.Drawing.Point(339, 190)
        Me.textAlertMax.Name = "textAlertMax"
        Me.textAlertMax.Size = New System.Drawing.Size(148, 20)
        Me.textAlertMax.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(255, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Existencia Max"
        '
        'textAlertMin
        '
        Me.textAlertMin.Location = New System.Drawing.Point(582, 190)
        Me.textAlertMin.Name = "textAlertMin"
        Me.textAlertMin.Size = New System.Drawing.Size(148, 20)
        Me.textAlertMin.TabIndex = 29
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(497, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Existencia Min"
        '
        'ProductoCRUB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 440)
        Me.Controls.Add(Me.textAlertMin)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.textAlertMax)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.textExistencia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnErase)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.comboFamilia)
        Me.Controls.Add(Me.comboCategoria)
        Me.Controls.Add(Me.comboMedida)
        Me.Controls.Add(Me.comboMarca)
        Me.Controls.Add(Me.textPVenta)
        Me.Controls.Add(Me.textPCompra)
        Me.Controls.Add(Me.textPPromedio)
        Me.Controls.Add(Me.textDescripcion)
        Me.Controls.Add(Me.textParte)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ProductoCRUB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ProductoCRUB"
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
    Friend WithEvents Label10 As Label
    Friend WithEvents textParte As TextBox
    Friend WithEvents textDescripcion As TextBox
    Friend WithEvents textPPromedio As TextBox
    Friend WithEvents textPCompra As TextBox
    Friend WithEvents textPVenta As TextBox
    Friend WithEvents comboMarca As ComboBox
    Friend WithEvents comboMedida As ComboBox
    Friend WithEvents comboCategoria As ComboBox
    Friend WithEvents comboFamilia As ComboBox
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents btnErase As FontAwesome.Sharp.IconButton
    Friend WithEvents textExistencia As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents textAlertMax As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents textAlertMin As TextBox
    Friend WithEvents Label12 As Label
End Class
