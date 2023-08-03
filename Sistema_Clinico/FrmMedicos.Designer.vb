<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMedicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMedicos))
        Me.PanelMedicos = New System.Windows.Forms.Panel()
        Me.GroupBuscar = New System.Windows.Forms.GroupBox()
        Me.ImagenBuscar = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupMedicos = New System.Windows.Forms.GroupBox()
        Me.TxtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CbmEspecialidad = New System.Windows.Forms.ComboBox()
        Me.CbmEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CheckActivo = New System.Windows.Forms.CheckBox()
        Me.DateFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.DateFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.CbmTurno = New System.Windows.Forms.ComboBox()
        Me.CheckMasculino = New System.Windows.Forms.CheckBox()
        Me.CheckFemenino = New System.Windows.Forms.CheckBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.PanelMedicos.SuspendLayout()
        Me.GroupBuscar.SuspendLayout()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupMedicos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMedicos
        '
        Me.PanelMedicos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelMedicos.BackColor = System.Drawing.Color.White
        Me.PanelMedicos.Controls.Add(Me.GroupBuscar)
        Me.PanelMedicos.Controls.Add(Me.GroupMedicos)
        Me.PanelMedicos.Location = New System.Drawing.Point(0, 0)
        Me.PanelMedicos.Name = "PanelMedicos"
        Me.PanelMedicos.Size = New System.Drawing.Size(871, 676)
        Me.PanelMedicos.TabIndex = 4
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
        'GroupMedicos
        '
        Me.GroupMedicos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupMedicos.BackColor = System.Drawing.Color.Transparent
        Me.GroupMedicos.Controls.Add(Me.TxtIdentidad)
        Me.GroupMedicos.Controls.Add(Me.Label12)
        Me.GroupMedicos.Controls.Add(Me.BtnEliminar)
        Me.GroupMedicos.Controls.Add(Me.PictureBox1)
        Me.GroupMedicos.Controls.Add(Me.CbmEspecialidad)
        Me.GroupMedicos.Controls.Add(Me.CbmEstadoCivil)
        Me.GroupMedicos.Controls.Add(Me.Label13)
        Me.GroupMedicos.Controls.Add(Me.CheckActivo)
        Me.GroupMedicos.Controls.Add(Me.DateFechaRegistro)
        Me.GroupMedicos.Controls.Add(Me.DateFechaNacimiento)
        Me.GroupMedicos.Controls.Add(Me.CbmTurno)
        Me.GroupMedicos.Controls.Add(Me.CheckMasculino)
        Me.GroupMedicos.Controls.Add(Me.CheckFemenino)
        Me.GroupMedicos.Controls.Add(Me.TxtCorreo)
        Me.GroupMedicos.Controls.Add(Me.TxtDireccion)
        Me.GroupMedicos.Controls.Add(Me.TxtTelefono)
        Me.GroupMedicos.Controls.Add(Me.TxtEdad)
        Me.GroupMedicos.Controls.Add(Me.TxtApellido)
        Me.GroupMedicos.Controls.Add(Me.Label9)
        Me.GroupMedicos.Controls.Add(Me.TxtNombre)
        Me.GroupMedicos.Controls.Add(Me.Label1)
        Me.GroupMedicos.Controls.Add(Me.TxtId)
        Me.GroupMedicos.Controls.Add(Me.Label14)
        Me.GroupMedicos.Controls.Add(Me.Label10)
        Me.GroupMedicos.Controls.Add(Me.Label11)
        Me.GroupMedicos.Controls.Add(Me.LblFecha)
        Me.GroupMedicos.Controls.Add(Me.Label8)
        Me.GroupMedicos.Controls.Add(Me.Label7)
        Me.GroupMedicos.Controls.Add(Me.Label6)
        Me.GroupMedicos.Controls.Add(Me.Label5)
        Me.GroupMedicos.Controls.Add(Me.Label4)
        Me.GroupMedicos.Controls.Add(Me.Label3)
        Me.GroupMedicos.Controls.Add(Me.Label2)
        Me.GroupMedicos.Controls.Add(Me.BtnAgregar)
        Me.GroupMedicos.Controls.Add(Me.BtnGuardar)
        Me.GroupMedicos.Controls.Add(Me.BtnEditar)
        Me.GroupMedicos.Controls.Add(Me.BtnActualizar)
        Me.GroupMedicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupMedicos.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupMedicos.Location = New System.Drawing.Point(53, 31)
        Me.GroupMedicos.Name = "GroupMedicos"
        Me.GroupMedicos.Size = New System.Drawing.Size(762, 530)
        Me.GroupMedicos.TabIndex = 0
        Me.GroupMedicos.TabStop = False
        Me.GroupMedicos.Text = "Medicos"
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtIdentidad.Location = New System.Drawing.Point(25, 275)
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(238, 26)
        Me.TxtIdentidad.TabIndex = 64
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label12.Location = New System.Drawing.Point(23, 247)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 18)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Identidad"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Crimson
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEliminar.Location = New System.Drawing.Point(582, 415)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(116, 48)
        Me.BtnEliminar.TabIndex = 43
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(544, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(203, 232)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'CbmEspecialidad
        '
        Me.CbmEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CbmEspecialidad.FormattingEnabled = True
        Me.CbmEspecialidad.Location = New System.Drawing.Point(304, 213)
        Me.CbmEspecialidad.Name = "CbmEspecialidad"
        Me.CbmEspecialidad.Size = New System.Drawing.Size(204, 28)
        Me.CbmEspecialidad.TabIndex = 40
        '
        'CbmEstadoCivil
        '
        Me.CbmEstadoCivil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CbmEstadoCivil.FormattingEnabled = True
        Me.CbmEstadoCivil.Location = New System.Drawing.Point(304, 141)
        Me.CbmEstadoCivil.Name = "CbmEstadoCivil"
        Me.CbmEstadoCivil.Size = New System.Drawing.Size(204, 28)
        Me.CbmEstadoCivil.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label13.Location = New System.Drawing.Point(301, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 18)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "EstadoCivil"
        '
        'CheckActivo
        '
        Me.CheckActivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckActivo.AutoSize = True
        Me.CheckActivo.Location = New System.Drawing.Point(300, 493)
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
        Me.DateFechaRegistro.Location = New System.Drawing.Point(304, 422)
        Me.DateFechaRegistro.Name = "DateFechaRegistro"
        Me.DateFechaRegistro.Size = New System.Drawing.Size(200, 26)
        Me.DateFechaRegistro.TabIndex = 35
        '
        'DateFechaNacimiento
        '
        Me.DateFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateFechaNacimiento.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFechaNacimiento.Location = New System.Drawing.Point(304, 351)
        Me.DateFechaNacimiento.Name = "DateFechaNacimiento"
        Me.DateFechaNacimiento.Size = New System.Drawing.Size(200, 26)
        Me.DateFechaNacimiento.TabIndex = 34
        '
        'CbmTurno
        '
        Me.CbmTurno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CbmTurno.FormattingEnabled = True
        Me.CbmTurno.Location = New System.Drawing.Point(304, 280)
        Me.CbmTurno.Name = "CbmTurno"
        Me.CbmTurno.Size = New System.Drawing.Size(204, 28)
        Me.CbmTurno.TabIndex = 33
        '
        'CheckMasculino
        '
        Me.CheckMasculino.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckMasculino.AutoSize = True
        Me.CheckMasculino.Location = New System.Drawing.Point(409, 72)
        Me.CheckMasculino.Name = "CheckMasculino"
        Me.CheckMasculino.Size = New System.Drawing.Size(99, 24)
        Me.CheckMasculino.TabIndex = 31
        Me.CheckMasculino.Text = "Masculino"
        Me.CheckMasculino.UseVisualStyleBackColor = True
        '
        'CheckFemenino
        '
        Me.CheckFemenino.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckFemenino.AutoSize = True
        Me.CheckFemenino.Location = New System.Drawing.Point(304, 72)
        Me.CheckFemenino.Name = "CheckFemenino"
        Me.CheckFemenino.Size = New System.Drawing.Size(99, 24)
        Me.CheckFemenino.TabIndex = 30
        Me.CheckFemenino.Text = "Femenino"
        Me.CheckFemenino.UseVisualStyleBackColor = True
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCorreo.Location = New System.Drawing.Point(25, 408)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(238, 26)
        Me.TxtCorreo.TabIndex = 28
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDireccion.Location = New System.Drawing.Point(25, 474)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(238, 40)
        Me.TxtDireccion.TabIndex = 27
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtTelefono.Location = New System.Drawing.Point(113, 341)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(150, 26)
        Me.TxtTelefono.TabIndex = 22
        '
        'TxtEdad
        '
        Me.TxtEdad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtEdad.Location = New System.Drawing.Point(25, 341)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(55, 26)
        Me.TxtEdad.TabIndex = 20
        '
        'TxtApellido
        '
        Me.TxtApellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtApellido.Location = New System.Drawing.Point(25, 209)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(238, 26)
        Me.TxtApellido.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(22, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Apellido"
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNombre.Location = New System.Drawing.Point(25, 140)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(238, 26)
        Me.TxtNombre.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(22, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Id"
        '
        'TxtId
        '
        Me.TxtId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtId.Location = New System.Drawing.Point(25, 71)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(55, 26)
        Me.TxtId.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label14.Location = New System.Drawing.Point(301, 464)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 18)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Estado"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label10.Location = New System.Drawing.Point(301, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 18)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Turno"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(301, 322)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 18)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Fecha nacimiento"
        '
        'LblFecha
        '
        Me.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.ForeColor = System.Drawing.Color.SteelBlue
        Me.LblFecha.Location = New System.Drawing.Point(301, 395)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(103, 18)
        Me.LblFecha.TabIndex = 11
        Me.LblFecha.Text = "Fecha registro"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(22, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Edad"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(22, 446)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Dirección"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(110, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(22, 379)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Correo"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(301, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Especialidad"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(301, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Genero"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(22, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnActualizar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnActualizar.Location = New System.Drawing.Point(582, 362)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(116, 48)
        Me.BtnActualizar.TabIndex = 45
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAgregar.Location = New System.Drawing.Point(582, 307)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(582, 308)
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
        Me.BtnEditar.Location = New System.Drawing.Point(582, 361)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(116, 48)
        Me.BtnEditar.TabIndex = 42
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'FrmMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 676)
        Me.Controls.Add(Me.PanelMedicos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMedicos"
        Me.Text = "FrmMedicos"
        Me.PanelMedicos.ResumeLayout(False)
        Me.GroupBuscar.ResumeLayout(False)
        Me.GroupBuscar.PerformLayout()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupMedicos.ResumeLayout(False)
        Me.GroupMedicos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMedicos As Panel
    Friend WithEvents GroupBuscar As GroupBox
    Friend WithEvents ImagenBuscar As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GroupMedicos As GroupBox
    Friend WithEvents CheckActivo As CheckBox
    Friend WithEvents DateFechaRegistro As DateTimePicker
    Friend WithEvents DateFechaNacimiento As DateTimePicker
    Friend WithEvents CbmTurno As ComboBox
    Friend WithEvents CheckMasculino As CheckBox
    Friend WithEvents CheckFemenino As CheckBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CbmEspecialidad As ComboBox
    Friend WithEvents CbmEstadoCivil As ComboBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtIdentidad As TextBox
    Friend WithEvents Label12 As Label
End Class
