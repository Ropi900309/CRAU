<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehiculoCRUB
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblPlaca = New System.Windows.Forms.Label()
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtPlaca = New System.Windows.Forms.TextBox()
        Me.txtRegistro = New System.Windows.Forms.TextBox()
        Me.comboMarca = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.btnErase = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(470, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Serire"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(24, 111)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(42, 13)
        Me.lblModelo.TabIndex = 6
        Me.lblModelo.Text = "Modelo"
        '
        'lblPlaca
        '
        Me.lblPlaca.AutoSize = True
        Me.lblPlaca.Location = New System.Drawing.Point(465, 60)
        Me.lblPlaca.Name = "lblPlaca"
        Me.lblPlaca.Size = New System.Drawing.Size(39, 13)
        Me.lblPlaca.TabIndex = 5
        Me.lblPlaca.Text = "Placas"
        '
        'lblRegistro
        '
        Me.lblRegistro.AutoSize = True
        Me.lblRegistro.Location = New System.Drawing.Point(24, 60)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(93, 13)
        Me.lblRegistro.TabIndex = 4
        Me.lblRegistro.Text = "Registro Vehicular"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(541, 159)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(195, 20)
        Me.txtSerie.TabIndex = 3
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(127, 104)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(195, 20)
        Me.txtModelo.TabIndex = 2
        '
        'txtPlaca
        '
        Me.txtPlaca.Location = New System.Drawing.Point(541, 53)
        Me.txtPlaca.Name = "txtPlaca"
        Me.txtPlaca.Size = New System.Drawing.Size(195, 20)
        Me.txtPlaca.TabIndex = 1
        '
        'txtRegistro
        '
        Me.txtRegistro.Location = New System.Drawing.Point(127, 57)
        Me.txtRegistro.Name = "txtRegistro"
        Me.txtRegistro.Size = New System.Drawing.Size(195, 20)
        Me.txtRegistro.TabIndex = 0
        '
        'comboMarca
        '
        Me.comboMarca.FormattingEnabled = True
        Me.comboMarca.Location = New System.Drawing.Point(541, 111)
        Me.comboMarca.Name = "comboMarca"
        Me.comboMarca.Size = New System.Drawing.Size(195, 21)
        Me.comboMarca.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(470, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Marca:"
        '
        'comboTipo
        '
        Me.comboTipo.FormattingEnabled = True
        Me.comboTipo.Location = New System.Drawing.Point(127, 158)
        Me.comboTipo.Name = "comboTipo"
        Me.comboTipo.Size = New System.Drawing.Size(195, 21)
        Me.comboTipo.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Tipo:"
        '
        'btnSave
        '
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnSave.IconColor = System.Drawing.Color.Black
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.IconSize = 25
        Me.btnSave.Location = New System.Drawing.Point(580, 212)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 38)
        Me.btnSave.TabIndex = 24
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnErase
        '
        Me.btnErase.IconChar = FontAwesome.Sharp.IconChar.Eraser
        Me.btnErase.IconColor = System.Drawing.Color.Black
        Me.btnErase.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnErase.IconSize = 25
        Me.btnErase.Location = New System.Drawing.Point(661, 212)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(75, 38)
        Me.btnErase.TabIndex = 25
        Me.btnErase.UseVisualStyleBackColor = True
        '
        'VehiculoCRUB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(763, 273)
        Me.Controls.Add(Me.btnErase)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboTipo)
        Me.Controls.Add(Me.comboMarca)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.txtRegistro)
        Me.Controls.Add(Me.lblPlaca)
        Me.Controls.Add(Me.lblRegistro)
        Me.Controls.Add(Me.txtPlaca)
        Me.Name = "VehiculoCRUB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VehiculoCRUB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents lblModelo As Label
    Friend WithEvents lblPlaca As Label
    Friend WithEvents lblRegistro As Label
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents txtRegistro As TextBox
    Friend WithEvents comboMarca As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comboTipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents btnErase As FontAwesome.Sharp.IconButton
End Class
