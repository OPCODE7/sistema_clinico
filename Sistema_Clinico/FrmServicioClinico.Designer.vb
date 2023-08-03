<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServicioClinico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmServicioClinico))
        Me.PanelServicio = New System.Windows.Forms.Panel()
        Me.GroupBuscar = New System.Windows.Forms.GroupBox()
        Me.ImagenBuscar = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupServicio = New System.Windows.Forms.GroupBox()
        Me.CheckActivo = New System.Windows.Forms.CheckBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.TxtServicio = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.PanelServicio.SuspendLayout()
        Me.GroupBuscar.SuspendLayout()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupServicio.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelServicio
        '
        Me.PanelServicio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelServicio.BackColor = System.Drawing.Color.White
        Me.PanelServicio.Controls.Add(Me.GroupBuscar)
        Me.PanelServicio.Controls.Add(Me.GroupServicio)
        Me.PanelServicio.Location = New System.Drawing.Point(0, 0)
        Me.PanelServicio.Name = "PanelServicio"
        Me.PanelServicio.Size = New System.Drawing.Size(871, 676)
        Me.PanelServicio.TabIndex = 8
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
        Me.GroupBuscar.Size = New System.Drawing.Size(522, 74)
        Me.GroupBuscar.TabIndex = 1
        Me.GroupBuscar.TabStop = False
        Me.GroupBuscar.Text = "Buscar"
        '
        'ImagenBuscar
        '
        Me.ImagenBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImagenBuscar.BackColor = System.Drawing.Color.Transparent
        Me.ImagenBuscar.Image = CType(resources.GetObject("ImagenBuscar.Image"), System.Drawing.Image)
        Me.ImagenBuscar.Location = New System.Drawing.Point(434, 21)
        Me.ImagenBuscar.Name = "ImagenBuscar"
        Me.ImagenBuscar.Size = New System.Drawing.Size(39, 41)
        Me.ImagenBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenBuscar.TabIndex = 38
        Me.ImagenBuscar.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtBuscar.Location = New System.Drawing.Point(44, 30)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(384, 26)
        Me.TxtBuscar.TabIndex = 35
        '
        'GroupServicio
        '
        Me.GroupServicio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupServicio.BackColor = System.Drawing.Color.Transparent
        Me.GroupServicio.Controls.Add(Me.CheckActivo)
        Me.GroupServicio.Controls.Add(Me.BtnEliminar)
        Me.GroupServicio.Controls.Add(Me.Label14)
        Me.GroupServicio.Controls.Add(Me.Label13)
        Me.GroupServicio.Controls.Add(Me.DateFechaRegistro)
        Me.GroupServicio.Controls.Add(Me.TxtServicio)
        Me.GroupServicio.Controls.Add(Me.TxtDescripcion)
        Me.GroupServicio.Controls.Add(Me.Label1)
        Me.GroupServicio.Controls.Add(Me.TxtId)
        Me.GroupServicio.Controls.Add(Me.LblFecha)
        Me.GroupServicio.Controls.Add(Me.Label5)
        Me.GroupServicio.Controls.Add(Me.PictureBox1)
        Me.GroupServicio.Controls.Add(Me.BtnAgregar)
        Me.GroupServicio.Controls.Add(Me.BtnEditar)
        Me.GroupServicio.Controls.Add(Me.BtnActualizar)
        Me.GroupServicio.Controls.Add(Me.BtnGuardar)
        Me.GroupServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupServicio.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupServicio.Location = New System.Drawing.Point(53, 31)
        Me.GroupServicio.Name = "GroupServicio"
        Me.GroupServicio.Size = New System.Drawing.Size(762, 530)
        Me.GroupServicio.TabIndex = 0
        Me.GroupServicio.TabStop = False
        Me.GroupServicio.Text = "Servicios clinicos"
        '
        'CheckActivo
        '
        Me.CheckActivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckActivo.AutoSize = True
        Me.CheckActivo.Location = New System.Drawing.Point(108, 472)
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
        Me.BtnEliminar.Location = New System.Drawing.Point(545, 428)
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
        Me.Label14.Location = New System.Drawing.Point(109, 443)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 18)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Estado"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label13.Location = New System.Drawing.Point(105, 207)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 18)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Descripcion"
        '
        'DateFechaRegistro
        '
        Me.DateFechaRegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateFechaRegistro.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFechaRegistro.Location = New System.Drawing.Point(108, 398)
        Me.DateFechaRegistro.Name = "DateFechaRegistro"
        Me.DateFechaRegistro.Size = New System.Drawing.Size(200, 26)
        Me.DateFechaRegistro.TabIndex = 35
        '
        'TxtServicio
        '
        Me.TxtServicio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtServicio.Location = New System.Drawing.Point(108, 162)
        Me.TxtServicio.Name = "TxtServicio"
        Me.TxtServicio.Size = New System.Drawing.Size(326, 26)
        Me.TxtServicio.TabIndex = 28
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDescripcion.Location = New System.Drawing.Point(108, 236)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(326, 117)
        Me.TxtDescripcion.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(105, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Id"
        '
        'TxtId
        '
        Me.TxtId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtId.Location = New System.Drawing.Point(108, 88)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(56, 26)
        Me.TxtId.TabIndex = 15
        '
        'LblFecha
        '
        Me.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.ForeColor = System.Drawing.Color.SteelBlue
        Me.LblFecha.Location = New System.Drawing.Point(105, 371)
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
        Me.Label5.Location = New System.Drawing.Point(105, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Servicio clinico"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(508, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 234)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAgregar.Location = New System.Drawing.Point(545, 320)
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
        Me.BtnEditar.Location = New System.Drawing.Point(545, 374)
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
        Me.BtnActualizar.Location = New System.Drawing.Point(545, 374)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(116, 48)
        Me.BtnActualizar.TabIndex = 45
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnGuardar.Location = New System.Drawing.Point(545, 320)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(116, 48)
        Me.BtnGuardar.TabIndex = 44
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'FrmServicioClinico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 676)
        Me.Controls.Add(Me.PanelServicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmServicioClinico"
        Me.Text = "FrmServicioClinico"
        Me.PanelServicio.ResumeLayout(False)
        Me.GroupBuscar.ResumeLayout(False)
        Me.GroupBuscar.PerformLayout()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupServicio.ResumeLayout(False)
        Me.GroupServicio.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelServicio As Panel
    Friend WithEvents GroupBuscar As GroupBox
    Friend WithEvents ImagenBuscar As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GroupServicio As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents DateFechaRegistro As DateTimePicker
    Friend WithEvents TxtServicio As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents LblFecha As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckActivo As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnActualizar As Button
End Class
