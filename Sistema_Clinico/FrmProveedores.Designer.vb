<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProveedores))
        Me.PanelProveedores = New System.Windows.Forms.Panel()
        Me.GroupBuscar = New System.Windows.Forms.GroupBox()
        Me.ImagenBuscar = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupProveedores = New System.Windows.Forms.GroupBox()
        Me.CbmCategoria = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtVendedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CheckActivo = New System.Windows.Forms.CheckBox()
        Me.DateFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.TxtDirección = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PanelProveedores.SuspendLayout()
        Me.GroupBuscar.SuspendLayout()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupProveedores.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelProveedores
        '
        Me.PanelProveedores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelProveedores.BackColor = System.Drawing.Color.White
        Me.PanelProveedores.Controls.Add(Me.GroupBuscar)
        Me.PanelProveedores.Controls.Add(Me.GroupProveedores)
        Me.PanelProveedores.Location = New System.Drawing.Point(0, 0)
        Me.PanelProveedores.Name = "PanelProveedores"
        Me.PanelProveedores.Size = New System.Drawing.Size(871, 676)
        Me.PanelProveedores.TabIndex = 9
        '
        'GroupBuscar
        '
        Me.GroupBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBuscar.Controls.Add(Me.ImagenBuscar)
        Me.GroupBuscar.Controls.Add(Me.TxtBuscar)
        Me.GroupBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBuscar.Location = New System.Drawing.Point(53, 570)
        Me.GroupBuscar.Name = "GroupBuscar"
        Me.GroupBuscar.Size = New System.Drawing.Size(527, 74)
        Me.GroupBuscar.TabIndex = 1
        Me.GroupBuscar.TabStop = False
        Me.GroupBuscar.Text = "Buscar"
        '
        'ImagenBuscar
        '
        Me.ImagenBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImagenBuscar.BackColor = System.Drawing.Color.Transparent
        Me.ImagenBuscar.Image = CType(resources.GetObject("ImagenBuscar.Image"), System.Drawing.Image)
        Me.ImagenBuscar.Location = New System.Drawing.Point(439, 19)
        Me.ImagenBuscar.Name = "ImagenBuscar"
        Me.ImagenBuscar.Size = New System.Drawing.Size(39, 41)
        Me.ImagenBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenBuscar.TabIndex = 38
        Me.ImagenBuscar.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtBuscar.Location = New System.Drawing.Point(49, 28)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(384, 26)
        Me.TxtBuscar.TabIndex = 35
        '
        'GroupProveedores
        '
        Me.GroupProveedores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupProveedores.BackColor = System.Drawing.Color.Transparent
        Me.GroupProveedores.Controls.Add(Me.CbmCategoria)
        Me.GroupProveedores.Controls.Add(Me.Label6)
        Me.GroupProveedores.Controls.Add(Me.TxtCorreo)
        Me.GroupProveedores.Controls.Add(Me.Label3)
        Me.GroupProveedores.Controls.Add(Me.TxtTelefono)
        Me.GroupProveedores.Controls.Add(Me.Label4)
        Me.GroupProveedores.Controls.Add(Me.TxtVendedor)
        Me.GroupProveedores.Controls.Add(Me.Label2)
        Me.GroupProveedores.Controls.Add(Me.BtnEliminar)
        Me.GroupProveedores.Controls.Add(Me.Label13)
        Me.GroupProveedores.Controls.Add(Me.CheckActivo)
        Me.GroupProveedores.Controls.Add(Me.DateFechaRegistro)
        Me.GroupProveedores.Controls.Add(Me.TxtProveedor)
        Me.GroupProveedores.Controls.Add(Me.TxtDirección)
        Me.GroupProveedores.Controls.Add(Me.Label1)
        Me.GroupProveedores.Controls.Add(Me.TxtId)
        Me.GroupProveedores.Controls.Add(Me.Label14)
        Me.GroupProveedores.Controls.Add(Me.LblFecha)
        Me.GroupProveedores.Controls.Add(Me.Label5)
        Me.GroupProveedores.Controls.Add(Me.PictureBox1)
        Me.GroupProveedores.Controls.Add(Me.BtnAgregar)
        Me.GroupProveedores.Controls.Add(Me.BtnEditar)
        Me.GroupProveedores.Controls.Add(Me.BtnGuardar)
        Me.GroupProveedores.Controls.Add(Me.Button1)
        Me.GroupProveedores.Controls.Add(Me.BtnActualizar)
        Me.GroupProveedores.Controls.Add(Me.Button2)
        Me.GroupProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupProveedores.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupProveedores.Location = New System.Drawing.Point(53, 31)
        Me.GroupProveedores.Name = "GroupProveedores"
        Me.GroupProveedores.Size = New System.Drawing.Size(762, 530)
        Me.GroupProveedores.TabIndex = 0
        Me.GroupProveedores.TabStop = False
        Me.GroupProveedores.Text = "Proveedores"
        '
        'CbmCategoria
        '
        Me.CbmCategoria.FormattingEnabled = True
        Me.CbmCategoria.Location = New System.Drawing.Point(266, 147)
        Me.CbmCategoria.Name = "CbmCategoria"
        Me.CbmCategoria.Size = New System.Drawing.Size(175, 28)
        Me.CbmCategoria.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(263, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Categoria"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCorreo.Location = New System.Drawing.Point(45, 328)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(326, 26)
        Me.TxtCorreo.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(42, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Correo"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtTelefono.Location = New System.Drawing.Point(45, 399)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(171, 26)
        Me.TxtTelefono.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(42, 370)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 18)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Telefono"
        '
        'TxtVendedor
        '
        Me.TxtVendedor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtVendedor.Location = New System.Drawing.Point(45, 147)
        Me.TxtVendedor.Name = "TxtVendedor"
        Me.TxtVendedor.Size = New System.Drawing.Size(198, 26)
        Me.TxtVendedor.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(42, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 18)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Vendedor"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Crimson
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEliminar.Location = New System.Drawing.Point(538, 436)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(116, 48)
        Me.BtnEliminar.TabIndex = 43
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label13.Location = New System.Drawing.Point(42, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 18)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Dirección"
        '
        'CheckActivo
        '
        Me.CheckActivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckActivo.AutoSize = True
        Me.CheckActivo.Location = New System.Drawing.Point(41, 476)
        Me.CheckActivo.Name = "CheckActivo"
        Me.CheckActivo.Size = New System.Drawing.Size(71, 24)
        Me.CheckActivo.TabIndex = 36
        Me.CheckActivo.Text = "Activo"
        Me.CheckActivo.UseVisualStyleBackColor = True
        '
        'DateFechaRegistro
        '
        Me.DateFechaRegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateFechaRegistro.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFechaRegistro.Location = New System.Drawing.Point(241, 399)
        Me.DateFechaRegistro.Name = "DateFechaRegistro"
        Me.DateFechaRegistro.Size = New System.Drawing.Size(200, 26)
        Me.DateFechaRegistro.TabIndex = 35
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtProveedor.Location = New System.Drawing.Point(109, 72)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.Size = New System.Drawing.Size(332, 26)
        Me.TxtProveedor.TabIndex = 28
        '
        'TxtDirección
        '
        Me.TxtDirección.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDirección.Location = New System.Drawing.Point(45, 216)
        Me.TxtDirección.Multiline = True
        Me.TxtDirección.Name = "TxtDirección"
        Me.TxtDirección.Size = New System.Drawing.Size(396, 65)
        Me.TxtDirección.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(42, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Id"
        '
        'TxtId
        '
        Me.TxtId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtId.Location = New System.Drawing.Point(45, 72)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(39, 26)
        Me.TxtId.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label14.Location = New System.Drawing.Point(42, 447)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 18)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Estado"
        '
        'LblFecha
        '
        Me.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.ForeColor = System.Drawing.Color.SteelBlue
        Me.LblFecha.Location = New System.Drawing.Point(238, 372)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(103, 18)
        Me.LblFecha.TabIndex = 11
        Me.LblFecha.Text = "Fecha registro"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(106, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Proveedor"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(489, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(230, 230)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAgregar.Location = New System.Drawing.Point(538, 328)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(116, 48)
        Me.BtnAgregar.TabIndex = 41
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnEditar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEditar.Location = New System.Drawing.Point(538, 382)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(116, 48)
        Me.BtnEditar.TabIndex = 42
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnGuardar.Location = New System.Drawing.Point(538, 328)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(116, 48)
        Me.BtnGuardar.TabIndex = 44
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(538, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 48)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnActualizar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnActualizar.Location = New System.Drawing.Point(538, 382)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(116, 48)
        Me.BtnActualizar.TabIndex = 45
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.ForeColor = System.Drawing.SystemColors.Control
        Me.Button2.Location = New System.Drawing.Point(538, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 48)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FrmProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 676)
        Me.Controls.Add(Me.PanelProveedores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProveedores"
        Me.Text = "FrmProveedores"
        Me.PanelProveedores.ResumeLayout(False)
        Me.GroupBuscar.ResumeLayout(False)
        Me.GroupBuscar.PerformLayout()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupProveedores.ResumeLayout(False)
        Me.GroupProveedores.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelProveedores As Panel
    Friend WithEvents GroupBuscar As GroupBox
    Friend WithEvents ImagenBuscar As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GroupProveedores As GroupBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtVendedor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents CheckActivo As CheckBox
    Friend WithEvents DateFechaRegistro As DateTimePicker
    Friend WithEvents TxtProveedor As TextBox
    Friend WithEvents TxtDirección As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents CbmCategoria As ComboBox
End Class
