<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListadoMovimientos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTotEntidades = New System.Windows.Forms.Label()
        Me.ListVehiculos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textBuscar = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New FontAwesome.Sharp.IconButton()
        Me.btnBuscar = New FontAwesome.Sharp.IconButton()
        CType(Me.ListVehiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotEntidades
        '
        Me.lblTotEntidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotEntidades.AutoSize = True
        Me.lblTotEntidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotEntidades.Location = New System.Drawing.Point(12, 598)
        Me.lblTotEntidades.Name = "lblTotEntidades"
        Me.lblTotEntidades.Size = New System.Drawing.Size(93, 18)
        Me.lblTotEntidades.TabIndex = 307
        Me.lblTotEntidades.Text = "LISTADOS:"
        '
        'ListVehiculos
        '
        Me.ListVehiculos.AllowUserToAddRows = False
        Me.ListVehiculos.AllowUserToDeleteRows = False
        Me.ListVehiculos.AllowUserToResizeRows = False
        Me.ListVehiculos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListVehiculos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.ListVehiculos.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListVehiculos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ListVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(20, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListVehiculos.DefaultCellStyle = DataGridViewCellStyle2
        Me.ListVehiculos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.ListVehiculos.EnableHeadersVisualStyles = False
        Me.ListVehiculos.Location = New System.Drawing.Point(12, 52)
        Me.ListVehiculos.Name = "ListVehiculos"
        Me.ListVehiculos.ReadOnly = True
        Me.ListVehiculos.RowHeadersVisible = False
        Me.ListVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListVehiculos.Size = New System.Drawing.Size(1308, 524)
        Me.ListVehiculos.TabIndex = 304
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(952, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 303
        Me.Label1.Text = "Buscar:"
        '
        'textBuscar
        '
        Me.textBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.textBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBuscar.Location = New System.Drawing.Point(1024, 20)
        Me.textBuscar.Name = "textBuscar"
        Me.textBuscar.Size = New System.Drawing.Size(243, 22)
        Me.textBuscar.TabIndex = 301
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.Window
        Me.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.Box
        Me.btnNuevo.IconColor = System.Drawing.Color.White
        Me.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNuevo.IconSize = 25
        Me.btnNuevo.Location = New System.Drawing.Point(1236, 587)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(84, 35)
        Me.btnNuevo.TabIndex = 306
        Me.btnNuevo.Text = "Agregar"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevo.UseVisualStyleBackColor = False
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
        Me.btnBuscar.TabIndex = 302
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'ListadoMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1332, 634)
        Me.Controls.Add(Me.lblTotEntidades)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.ListVehiculos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.textBuscar)
        Me.Name = "ListadoMovimientos"
        Me.Text = "ListadoMovimientos"
        CType(Me.ListVehiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTotEntidades As Label
    Friend WithEvents btnNuevo As FontAwesome.Sharp.IconButton
    Friend WithEvents ListVehiculos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBuscar As FontAwesome.Sharp.IconButton
    Friend WithEvents textBuscar As TextBox
End Class
