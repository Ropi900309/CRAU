<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.textUser = New System.Windows.Forms.TextBox()
        Me.textPasswprd = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnPassword = New FontAwesome.Sharp.IconButton()
        Me.btnUser = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textUser
        '
        Me.textUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.textUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textUser.Location = New System.Drawing.Point(152, 139)
        Me.textUser.Margin = New System.Windows.Forms.Padding(2)
        Me.textUser.MaxLength = 25
        Me.textUser.Name = "textUser"
        Me.textUser.Size = New System.Drawing.Size(239, 31)
        Me.textUser.TabIndex = 0
        '
        'textPasswprd
        '
        Me.textPasswprd.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.textPasswprd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textPasswprd.Location = New System.Drawing.Point(152, 192)
        Me.textPasswprd.Margin = New System.Windows.Forms.Padding(2)
        Me.textPasswprd.MaxLength = 25
        Me.textPasswprd.Name = "textPasswprd"
        Me.textPasswprd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textPasswprd.Size = New System.Drawing.Size(239, 31)
        Me.textPasswprd.TabIndex = 1
        Me.textPasswprd.UseSystemPasswordChar = True
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.DarkBlue
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(152, 234)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(239, 37)
        Me.btnConfirm.TabIndex = 2
        Me.btnConfirm.Text = "Ingresar"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnPassword
        '
        Me.btnPassword.BackColor = System.Drawing.Color.White
        Me.btnPassword.FlatAppearance.BorderSize = 0
        Me.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPassword.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPassword.ForeColor = System.Drawing.Color.Black
        Me.btnPassword.IconChar = FontAwesome.Sharp.IconChar.Key
        Me.btnPassword.IconColor = System.Drawing.Color.Black
        Me.btnPassword.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPassword.IconSize = 25
        Me.btnPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPassword.Location = New System.Drawing.Point(5, 196)
        Me.btnPassword.Name = "btnPassword"
        Me.btnPassword.Size = New System.Drawing.Size(147, 28)
        Me.btnPassword.TabIndex = 18
        Me.btnPassword.Text = "Contraseña"
        Me.btnPassword.UseVisualStyleBackColor = False
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.White
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Microsoft JhengHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.Black
        Me.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.btnUser.IconColor = System.Drawing.Color.Black
        Me.btnUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUser.IconSize = 25
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Location = New System.Drawing.Point(5, 138)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(121, 32)
        Me.btnUser.TabIndex = 17
        Me.btnUser.Text = "Usuario"
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(398, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(416, 297)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPassword)
        Me.Controls.Add(Me.btnUser)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.textPasswprd)
        Me.Controls.Add(Me.textUser)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textUser As TextBox
    Friend WithEvents textPasswprd As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnPassword As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUser As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
End Class
