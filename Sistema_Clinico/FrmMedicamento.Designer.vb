<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMedicamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMedicamento))
        Me.PanelMedicamento = New System.Windows.Forms.Panel()
        Me.GroupBuscar = New System.Windows.Forms.GroupBox()
        Me.ImagenBuscar = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupMedicamento = New System.Windows.Forms.GroupBox()
        Me.CheckActivo = New System.Windows.Forms.CheckBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CbmProveedor = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.DateFechaVencimiento = New System.Windows.Forms.DateTimePicker()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtEnExistencia = New System.Windows.Forms.TextBox()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.PanelMedicamento.SuspendLayout()
        Me.GroupBuscar.SuspendLayout()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupMedicamento.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMedicamento
        '
        Me.PanelMedicamento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelMedicamento.BackColor = System.Drawing.Color.White
        Me.PanelMedicamento.Controls.Add(Me.GroupBuscar)
        Me.PanelMedicamento.Controls.Add(Me.GroupMedicamento)
        Me.PanelMedicamento.Location = New System.Drawing.Point(0, 0)
        Me.PanelMedicamento.Name = "PanelMedicamento"
        Me.PanelMedicamento.Size = New System.Drawing.Size(871, 676)
        Me.PanelMedicamento.TabIndex = 5
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
        Me.GroupBuscar.Size = New System.Drawing.Size(762, 74)
        Me.GroupBuscar.TabIndex = 1
        Me.GroupBuscar.TabStop = False
        Me.GroupBuscar.Text = "Buscar"
        '
        'ImagenBuscar
        '
        Me.ImagenBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImagenBuscar.BackColor = System.Drawing.Color.Transparent
        Me.ImagenBuscar.Image = CType(resources.GetObject("ImagenBuscar.Image"), System.Drawing.Image)
        Me.ImagenBuscar.Location = New System.Drawing.Point(429, 25)
        Me.ImagenBuscar.Name = "ImagenBuscar"
        Me.ImagenBuscar.Size = New System.Drawing.Size(39, 41)
        Me.ImagenBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenBuscar.TabIndex = 38
        Me.ImagenBuscar.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtBuscar.Location = New System.Drawing.Point(39, 34)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(384, 26)
        Me.TxtBuscar.TabIndex = 35
        '
        'GroupMedicamento
        '
        Me.GroupMedicamento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupMedicamento.BackColor = System.Drawing.Color.Transparent
        Me.GroupMedicamento.Controls.Add(Me.CheckActivo)
        Me.GroupMedicamento.Controls.Add(Me.BtnEliminar)
        Me.GroupMedicamento.Controls.Add(Me.Label14)
        Me.GroupMedicamento.Controls.Add(Me.CbmProveedor)
        Me.GroupMedicamento.Controls.Add(Me.Label13)
        Me.GroupMedicamento.Controls.Add(Me.DateFechaRegistro)
        Me.GroupMedicamento.Controls.Add(Me.DateFechaVencimiento)
        Me.GroupMedicamento.Controls.Add(Me.TxtPrecio)
        Me.GroupMedicamento.Controls.Add(Me.TxtDescripcion)
        Me.GroupMedicamento.Controls.Add(Me.TxtEnExistencia)
        Me.GroupMedicamento.Controls.Add(Me.TxtTipo)
        Me.GroupMedicamento.Controls.Add(Me.Label9)
        Me.GroupMedicamento.Controls.Add(Me.TxtNombre)
        Me.GroupMedicamento.Controls.Add(Me.Label1)
        Me.GroupMedicamento.Controls.Add(Me.TxtId)
        Me.GroupMedicamento.Controls.Add(Me.Label11)
        Me.GroupMedicamento.Controls.Add(Me.LblFecha)
        Me.GroupMedicamento.Controls.Add(Me.Label7)
        Me.GroupMedicamento.Controls.Add(Me.Label6)
        Me.GroupMedicamento.Controls.Add(Me.Label5)
        Me.GroupMedicamento.Controls.Add(Me.Label2)
        Me.GroupMedicamento.Controls.Add(Me.PictureBox1)
        Me.GroupMedicamento.Controls.Add(Me.BtnAgregar)
        Me.GroupMedicamento.Controls.Add(Me.BtnGuardar)
        Me.GroupMedicamento.Controls.Add(Me.BtnEditar)
        Me.GroupMedicamento.Controls.Add(Me.BtnActualizar)
        Me.GroupMedicamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupMedicamento.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupMedicamento.Location = New System.Drawing.Point(53, 31)
        Me.GroupMedicamento.Name = "GroupMedicamento"
        Me.GroupMedicamento.Size = New System.Drawing.Size(762, 530)
        Me.GroupMedicamento.TabIndex = 0
        Me.GroupMedicamento.TabStop = False
        Me.GroupMedicamento.Text = "Medicamentos"
        '
        'CheckActivo
        '
        Me.CheckActivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckActivo.AutoSize = True
        Me.CheckActivo.Location = New System.Drawing.Point(322, 362)
        Me.CheckActivo.Name = "CheckActivo"
        Me.CheckActivo.Size = New System.Drawing.Size(71, 24)
        Me.CheckActivo.TabIndex = 38
        Me.CheckActivo.Text = "Activo"
        Me.CheckActivo.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Crimson
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEliminar.Location = New System.Drawing.Point(586, 426)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(116, 48)
        Me.BtnEliminar.TabIndex = 43
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label14.Location = New System.Drawing.Point(323, 333)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 18)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Estado"
        '
        'CbmProveedor
        '
        Me.CbmProveedor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CbmProveedor.FormattingEnabled = True
        Me.CbmProveedor.Location = New System.Drawing.Point(39, 470)
        Me.CbmProveedor.Name = "CbmProveedor"
        Me.CbmProveedor.Size = New System.Drawing.Size(204, 28)
        Me.CbmProveedor.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label13.Location = New System.Drawing.Point(36, 441)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 18)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Proveedor"
        '
        'DateFechaRegistro
        '
        Me.DateFechaRegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateFechaRegistro.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFechaRegistro.Location = New System.Drawing.Point(326, 286)
        Me.DateFechaRegistro.Name = "DateFechaRegistro"
        Me.DateFechaRegistro.Size = New System.Drawing.Size(200, 26)
        Me.DateFechaRegistro.TabIndex = 35
        '
        'DateFechaVencimiento
        '
        Me.DateFechaVencimiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateFechaVencimiento.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFechaVencimiento.Location = New System.Drawing.Point(326, 215)
        Me.DateFechaVencimiento.Name = "DateFechaVencimiento"
        Me.DateFechaVencimiento.Size = New System.Drawing.Size(200, 26)
        Me.DateFechaVencimiento.TabIndex = 34
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtPrecio.Location = New System.Drawing.Point(326, 78)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(119, 26)
        Me.TxtPrecio.TabIndex = 28
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDescripcion.Location = New System.Drawing.Point(39, 287)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(235, 136)
        Me.TxtDescripcion.TabIndex = 27
        '
        'TxtEnExistencia
        '
        Me.TxtEnExistencia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtEnExistencia.Location = New System.Drawing.Point(326, 146)
        Me.TxtEnExistencia.Name = "TxtEnExistencia"
        Me.TxtEnExistencia.Size = New System.Drawing.Size(119, 26)
        Me.TxtEnExistencia.TabIndex = 22
        '
        'TxtTipo
        '
        Me.TxtTipo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtTipo.Location = New System.Drawing.Point(39, 215)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(235, 26)
        Me.TxtTipo.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(36, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Tipo de medicamento"
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNombre.Location = New System.Drawing.Point(39, 146)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(235, 26)
        Me.TxtNombre.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(36, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Codigo"
        '
        'TxtId
        '
        Me.TxtId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtId.Location = New System.Drawing.Point(39, 77)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(149, 26)
        Me.TxtId.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(323, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 18)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Fecha vencimiento"
        '
        'LblFecha
        '
        Me.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.ForeColor = System.Drawing.Color.SteelBlue
        Me.LblFecha.Location = New System.Drawing.Point(323, 259)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(103, 18)
        Me.LblFecha.TabIndex = 11
        Me.LblFecha.Text = "Fecha registro"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(36, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Descripcion"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(323, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "En existencia"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(323, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(36, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre del medicamento"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(556, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 228)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAgregar.Location = New System.Drawing.Point(586, 318)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(116, 48)
        Me.BtnAgregar.TabIndex = 41
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnGuardar.Location = New System.Drawing.Point(586, 318)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(116, 48)
        Me.BtnGuardar.TabIndex = 44
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnEditar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEditar.Location = New System.Drawing.Point(586, 372)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(116, 48)
        Me.BtnEditar.TabIndex = 42
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnActualizar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnActualizar.Location = New System.Drawing.Point(586, 372)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(116, 48)
        Me.BtnActualizar.TabIndex = 45
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'FrmMedicamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 676)
        Me.Controls.Add(Me.PanelMedicamento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMedicamento"
        Me.Text = "FrmMedicamento"
        Me.PanelMedicamento.ResumeLayout(False)
        Me.GroupBuscar.ResumeLayout(False)
        Me.GroupBuscar.PerformLayout()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupMedicamento.ResumeLayout(False)
        Me.GroupMedicamento.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMedicamento As Panel
    Friend WithEvents GroupBuscar As GroupBox
    Friend WithEvents ImagenBuscar As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GroupMedicamento As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents CbmProveedor As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DateFechaRegistro As DateTimePicker
    Friend WithEvents DateFechaVencimiento As DateTimePicker
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtEnExistencia As TextBox
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckActivo As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnActualizar As Button
End Class
