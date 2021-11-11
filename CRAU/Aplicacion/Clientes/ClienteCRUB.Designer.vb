<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClienteCRUB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClienteCRUB))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSalir = New FontAwesome.Sharp.IconButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPlaca = New System.Windows.Forms.Label()
        Me.btnErase = New FontAwesome.Sharp.IconButton()
        Me.btnSave = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRazon = New System.Windows.Forms.TextBox()
        Me.lblRegistro = New System.Windows.Forms.Label()
        Me.txtRfc = New System.Windows.Forms.TextBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.comboTipo = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(693, 204)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 23)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "..."
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.btnSalir.Location = New System.Drawing.Point(615, 355)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(115, 38)
        Me.btnSalir.TabIndex = 59
        Me.btnSalir.Text = "Cancelar"
        Me.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(29, 139)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(185, 118)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 57
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(413, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(308, 42)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Datos Del Cliente"
        '
        'lblPlaca
        '
        Me.lblPlaca.AutoSize = True
        Me.lblPlaca.BackColor = System.Drawing.Color.White
        Me.lblPlaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlaca.Location = New System.Drawing.Point(325, 124)
        Me.lblPlaca.Name = "lblPlaca"
        Me.lblPlaca.Size = New System.Drawing.Size(47, 18)
        Me.lblPlaca.TabIndex = 47
        Me.lblPlaca.Text = "RFC:"
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
        Me.btnErase.Location = New System.Drawing.Point(509, 355)
        Me.btnErase.Name = "btnErase"
        Me.btnErase.Size = New System.Drawing.Size(100, 38)
        Me.btnErase.TabIndex = 52
        Me.btnErase.Text = "Eliminar"
        Me.btnErase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnErase.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.btnSave.IconColor = System.Drawing.Color.White
        Me.btnSave.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSave.IconSize = 25
        Me.btnSave.Location = New System.Drawing.Point(394, 355)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 38)
        Me.btnSave.TabIndex = 51
        Me.btnSave.Text = "Guardar"
        Me.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(239, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 18)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Formas de Pago"
        '
        'txtRazon
        '
        Me.txtRazon.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtRazon.Location = New System.Drawing.Point(394, 91)
        Me.txtRazon.Name = "txtRazon"
        Me.txtRazon.Size = New System.Drawing.Size(327, 20)
        Me.txtRazon.TabIndex = 42
        '
        'lblRegistro
        '
        Me.lblRegistro.AutoSize = True
        Me.lblRegistro.BackColor = System.Drawing.Color.White
        Me.lblRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistro.Location = New System.Drawing.Point(258, 91)
        Me.lblRegistro.Name = "lblRegistro"
        Me.lblRegistro.Size = New System.Drawing.Size(114, 18)
        Me.lblRegistro.TabIndex = 46
        Me.lblRegistro.Text = "Razon Social:"
        '
        'txtRfc
        '
        Me.txtRfc.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtRfc.Location = New System.Drawing.Point(394, 127)
        Me.txtRfc.Name = "txtRfc"
        Me.txtRfc.Size = New System.Drawing.Size(327, 20)
        Me.txtRfc.TabIndex = 43
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.BackColor = System.Drawing.Color.White
        Me.lblModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(287, 170)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(85, 18)
        Me.lblModelo.TabIndex = 49
        Me.lblModelo.Text = "Dirección:"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(394, 168)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(327, 20)
        Me.txtDireccion.TabIndex = 44
        '
        'comboTipo
        '
        Me.comboTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.comboTipo.FormattingEnabled = True
        Me.comboTipo.Location = New System.Drawing.Point(394, 247)
        Me.comboTipo.Name = "comboTipo"
        Me.comboTipo.Size = New System.Drawing.Size(275, 21)
        Me.comboTipo.TabIndex = 48
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(351, 405)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(394, 206)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(275, 21)
        Me.ComboBox1.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Contactos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(693, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 23)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(203, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 18)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Condiciones de Pago"
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(394, 288)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(275, 21)
        Me.ComboBox2.TabIndex = 66
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(693, 286)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 23)
        Me.Button3.TabIndex = 68
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ClienteCRUB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(733, 405)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPlaca)
        Me.Controls.Add(Me.btnErase)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRazon)
        Me.Controls.Add(Me.lblRegistro)
        Me.Controls.Add(Me.txtRfc)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.comboTipo)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClienteCRUB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClienteCRUB"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents btnSalir As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPlaca As Label
    Friend WithEvents btnErase As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSave As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRazon As TextBox
    Friend WithEvents lblRegistro As Label
    Friend WithEvents txtRfc As TextBox
    Friend WithEvents lblModelo As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents comboTipo As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button3 As Button
End Class
