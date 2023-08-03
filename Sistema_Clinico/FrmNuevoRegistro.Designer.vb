<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNuevoRegistro
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNuevoRegistro))
        Me.PanelNuevoRegistro = New System.Windows.Forms.Panel()
        Me.PanelTexto = New System.Windows.Forms.Panel()
        Me.LblTexto = New System.Windows.Forms.Label()
        Me.PanelConte = New System.Windows.Forms.Panel()
        Me.PanelMante = New System.Windows.Forms.Panel()
        Me.BtnSeguroMedico = New System.Windows.Forms.Button()
        Me.ImagenBuscar = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupNuevoRegistro = New System.Windows.Forms.GroupBox()
        Me.PanelSeguroMedico = New System.Windows.Forms.Panel()
        Me.GroupSeguroMedico = New System.Windows.Forms.GroupBox()
        Me.CheckPremiun = New System.Windows.Forms.CheckBox()
        Me.CheckPlatinum = New System.Windows.Forms.CheckBox()
        Me.CheckSeguroBasico = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnListo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.CbmEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.DateFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.CheckMasculino = New System.Windows.Forms.CheckBox()
        Me.CheckFemenino = New System.Windows.Forms.CheckBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelNuevoRegistro.SuspendLayout()
        Me.PanelTexto.SuspendLayout()
        Me.PanelConte.SuspendLayout()
        Me.PanelMante.SuspendLayout()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupNuevoRegistro.SuspendLayout()
        Me.PanelSeguroMedico.SuspendLayout()
        Me.GroupSeguroMedico.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelNuevoRegistro
        '
        Me.PanelNuevoRegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelNuevoRegistro.BackColor = System.Drawing.Color.White
        Me.PanelNuevoRegistro.Controls.Add(Me.PanelTexto)
        Me.PanelNuevoRegistro.Controls.Add(Me.PanelConte)
        Me.PanelNuevoRegistro.Location = New System.Drawing.Point(-1, -1)
        Me.PanelNuevoRegistro.Name = "PanelNuevoRegistro"
        Me.PanelNuevoRegistro.Size = New System.Drawing.Size(871, 732)
        Me.PanelNuevoRegistro.TabIndex = 29
        '
        'PanelTexto
        '
        Me.PanelTexto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelTexto.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelTexto.Controls.Add(Me.LblTexto)
        Me.PanelTexto.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelTexto.Location = New System.Drawing.Point(2, 2)
        Me.PanelTexto.Name = "PanelTexto"
        Me.PanelTexto.Size = New System.Drawing.Size(869, 57)
        Me.PanelTexto.TabIndex = 27
        '
        'LblTexto
        '
        Me.LblTexto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblTexto.AutoSize = True
        Me.LblTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTexto.Location = New System.Drawing.Point(367, 17)
        Me.LblTexto.Name = "LblTexto"
        Me.LblTexto.Size = New System.Drawing.Size(133, 24)
        Me.LblTexto.TabIndex = 26
        Me.LblTexto.Text = "Nuevo registro"
        '
        'PanelConte
        '
        Me.PanelConte.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelConte.BackColor = System.Drawing.Color.Transparent
        Me.PanelConte.Controls.Add(Me.PanelMante)
        Me.PanelConte.Location = New System.Drawing.Point(0, 56)
        Me.PanelConte.Name = "PanelConte"
        Me.PanelConte.Size = New System.Drawing.Size(871, 676)
        Me.PanelConte.TabIndex = 29
        '
        'PanelMante
        '
        Me.PanelMante.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelMante.BackColor = System.Drawing.Color.Transparent
        Me.PanelMante.Controls.Add(Me.BtnSeguroMedico)
        Me.PanelMante.Controls.Add(Me.ImagenBuscar)
        Me.PanelMante.Controls.Add(Me.TxtBuscar)
        Me.PanelMante.Controls.Add(Me.GroupNuevoRegistro)
        Me.PanelMante.Location = New System.Drawing.Point(0, 0)
        Me.PanelMante.Name = "PanelMante"
        Me.PanelMante.Size = New System.Drawing.Size(871, 676)
        Me.PanelMante.TabIndex = 0
        '
        'BtnSeguroMedico
        '
        Me.BtnSeguroMedico.BackColor = System.Drawing.Color.SlateGray
        Me.BtnSeguroMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSeguroMedico.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSeguroMedico.Location = New System.Drawing.Point(738, 17)
        Me.BtnSeguroMedico.Name = "BtnSeguroMedico"
        Me.BtnSeguroMedico.Size = New System.Drawing.Size(77, 68)
        Me.BtnSeguroMedico.TabIndex = 75
        Me.BtnSeguroMedico.Text = "Seguro medico"
        Me.BtnSeguroMedico.UseVisualStyleBackColor = False
        '
        'ImagenBuscar
        '
        Me.ImagenBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImagenBuscar.BackColor = System.Drawing.Color.Transparent
        Me.ImagenBuscar.Image = CType(resources.GetObject("ImagenBuscar.Image"), System.Drawing.Image)
        Me.ImagenBuscar.Location = New System.Drawing.Point(449, 29)
        Me.ImagenBuscar.Name = "ImagenBuscar"
        Me.ImagenBuscar.Size = New System.Drawing.Size(39, 41)
        Me.ImagenBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenBuscar.TabIndex = 38
        Me.ImagenBuscar.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBuscar.Location = New System.Drawing.Point(59, 38)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(384, 24)
        Me.TxtBuscar.TabIndex = 35
        Me.ToolTip1.SetToolTip(Me.TxtBuscar, "Ingrese nombre del paciente")
        '
        'GroupNuevoRegistro
        '
        Me.GroupNuevoRegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupNuevoRegistro.BackColor = System.Drawing.Color.Transparent
        Me.GroupNuevoRegistro.Controls.Add(Me.PanelSeguroMedico)
        Me.GroupNuevoRegistro.Controls.Add(Me.TxtIdentidad)
        Me.GroupNuevoRegistro.Controls.Add(Me.Label12)
        Me.GroupNuevoRegistro.Controls.Add(Me.TxtDireccion)
        Me.GroupNuevoRegistro.Controls.Add(Me.Label7)
        Me.GroupNuevoRegistro.Controls.Add(Me.BtnEliminar)
        Me.GroupNuevoRegistro.Controls.Add(Me.BtnEditar)
        Me.GroupNuevoRegistro.Controls.Add(Me.BtnAgregar)
        Me.GroupNuevoRegistro.Controls.Add(Me.CbmEstadoCivil)
        Me.GroupNuevoRegistro.Controls.Add(Me.Label13)
        Me.GroupNuevoRegistro.Controls.Add(Me.DateFechaRegistro)
        Me.GroupNuevoRegistro.Controls.Add(Me.DateFechaNacimiento)
        Me.GroupNuevoRegistro.Controls.Add(Me.CheckMasculino)
        Me.GroupNuevoRegistro.Controls.Add(Me.CheckFemenino)
        Me.GroupNuevoRegistro.Controls.Add(Me.TxtCorreo)
        Me.GroupNuevoRegistro.Controls.Add(Me.TxtTelefono)
        Me.GroupNuevoRegistro.Controls.Add(Me.TxtEdad)
        Me.GroupNuevoRegistro.Controls.Add(Me.TxtApellido)
        Me.GroupNuevoRegistro.Controls.Add(Me.Label9)
        Me.GroupNuevoRegistro.Controls.Add(Me.TxtNombre)
        Me.GroupNuevoRegistro.Controls.Add(Me.Label1)
        Me.GroupNuevoRegistro.Controls.Add(Me.TxtId)
        Me.GroupNuevoRegistro.Controls.Add(Me.Label11)
        Me.GroupNuevoRegistro.Controls.Add(Me.LblFecha)
        Me.GroupNuevoRegistro.Controls.Add(Me.Label8)
        Me.GroupNuevoRegistro.Controls.Add(Me.Label6)
        Me.GroupNuevoRegistro.Controls.Add(Me.Label5)
        Me.GroupNuevoRegistro.Controls.Add(Me.Label3)
        Me.GroupNuevoRegistro.Controls.Add(Me.Label2)
        Me.GroupNuevoRegistro.Controls.Add(Me.PictureBox2)
        Me.GroupNuevoRegistro.Controls.Add(Me.BtnGuardar)
        Me.GroupNuevoRegistro.Controls.Add(Me.BtnActualizar)
        Me.GroupNuevoRegistro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupNuevoRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupNuevoRegistro.Location = New System.Drawing.Point(53, 90)
        Me.GroupNuevoRegistro.Name = "GroupNuevoRegistro"
        Me.GroupNuevoRegistro.Size = New System.Drawing.Size(762, 561)
        Me.GroupNuevoRegistro.TabIndex = 30
        Me.GroupNuevoRegistro.TabStop = False
        Me.GroupNuevoRegistro.Text = "Agregar paciente"
        '
        'PanelSeguroMedico
        '
        Me.PanelSeguroMedico.BackColor = System.Drawing.Color.SlateGray
        Me.PanelSeguroMedico.Controls.Add(Me.GroupSeguroMedico)
        Me.PanelSeguroMedico.Location = New System.Drawing.Point(216, 155)
        Me.PanelSeguroMedico.Name = "PanelSeguroMedico"
        Me.PanelSeguroMedico.Size = New System.Drawing.Size(540, 400)
        Me.PanelSeguroMedico.TabIndex = 76
        '
        'GroupSeguroMedico
        '
        Me.GroupSeguroMedico.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupSeguroMedico.BackColor = System.Drawing.Color.Transparent
        Me.GroupSeguroMedico.Controls.Add(Me.CheckPremiun)
        Me.GroupSeguroMedico.Controls.Add(Me.CheckPlatinum)
        Me.GroupSeguroMedico.Controls.Add(Me.CheckSeguroBasico)
        Me.GroupSeguroMedico.Controls.Add(Me.Label4)
        Me.GroupSeguroMedico.Controls.Add(Me.BtnCancelar)
        Me.GroupSeguroMedico.Controls.Add(Me.BtnListo)
        Me.GroupSeguroMedico.Controls.Add(Me.PictureBox1)
        Me.GroupSeguroMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupSeguroMedico.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupSeguroMedico.Location = New System.Drawing.Point(56, 30)
        Me.GroupSeguroMedico.Name = "GroupSeguroMedico"
        Me.GroupSeguroMedico.Size = New System.Drawing.Size(417, 341)
        Me.GroupSeguroMedico.TabIndex = 33
        Me.GroupSeguroMedico.TabStop = False
        Me.GroupSeguroMedico.Text = "Tipo seguro medico"
        '
        'CheckPremiun
        '
        Me.CheckPremiun.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckPremiun.AutoSize = True
        Me.CheckPremiun.Location = New System.Drawing.Point(125, 182)
        Me.CheckPremiun.Name = "CheckPremiun"
        Me.CheckPremiun.Size = New System.Drawing.Size(141, 24)
        Me.CheckPremiun.TabIndex = 122
        Me.CheckPremiun.Text = "Seguro premiun"
        Me.CheckPremiun.UseVisualStyleBackColor = True
        '
        'CheckPlatinum
        '
        Me.CheckPlatinum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckPlatinum.AutoSize = True
        Me.CheckPlatinum.Location = New System.Drawing.Point(125, 146)
        Me.CheckPlatinum.Name = "CheckPlatinum"
        Me.CheckPlatinum.Size = New System.Drawing.Size(144, 24)
        Me.CheckPlatinum.TabIndex = 121
        Me.CheckPlatinum.Text = "Seguro platinum"
        Me.CheckPlatinum.UseVisualStyleBackColor = True
        '
        'CheckSeguroBasico
        '
        Me.CheckSeguroBasico.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckSeguroBasico.AutoSize = True
        Me.CheckSeguroBasico.Location = New System.Drawing.Point(125, 107)
        Me.CheckSeguroBasico.Name = "CheckSeguroBasico"
        Me.CheckSeguroBasico.Size = New System.Drawing.Size(130, 24)
        Me.CheckSeguroBasico.TabIndex = 120
        Me.CheckSeguroBasico.Text = "Seguro basico"
        Me.CheckSeguroBasico.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(122, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 18)
        Me.Label4.TabIndex = 119
        Me.Label4.Text = "Seleccione el tipo de seguro medico"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Crimson
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnCancelar.Location = New System.Drawing.Point(224, 236)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(116, 48)
        Me.BtnCancelar.TabIndex = 118
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnListo
        '
        Me.BtnListo.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnListo.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnListo.Location = New System.Drawing.Point(76, 236)
        Me.BtnListo.Name = "BtnListo"
        Me.BtnListo.Size = New System.Drawing.Size(116, 48)
        Me.BtnListo.TabIndex = 117
        Me.BtnListo.Text = "Listo"
        Me.BtnListo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtIdentidad.Location = New System.Drawing.Point(245, 271)
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(218, 26)
        Me.TxtIdentidad.TabIndex = 78
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label12.Location = New System.Drawing.Point(243, 243)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 18)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Identidad"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDireccion.Location = New System.Drawing.Point(524, 65)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(204, 95)
        Me.TxtDireccion.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(521, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 18)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Dirección"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Crimson
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEliminar.Location = New System.Drawing.Point(598, 480)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(116, 48)
        Me.BtnEliminar.TabIndex = 70
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnEditar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEditar.Location = New System.Drawing.Point(442, 480)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(116, 48)
        Me.BtnEditar.TabIndex = 69
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAgregar.Location = New System.Drawing.Point(289, 480)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(116, 48)
        Me.BtnAgregar.TabIndex = 68
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'CbmEstadoCivil
        '
        Me.CbmEstadoCivil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CbmEstadoCivil.FormattingEnabled = True
        Me.CbmEstadoCivil.Location = New System.Drawing.Point(524, 271)
        Me.CbmEstadoCivil.Name = "CbmEstadoCivil"
        Me.CbmEstadoCivil.Size = New System.Drawing.Size(204, 28)
        Me.CbmEstadoCivil.TabIndex = 67
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label13.Location = New System.Drawing.Point(521, 242)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 18)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "Estado civil"
        '
        'DateFechaRegistro
        '
        Me.DateFechaRegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateFechaRegistro.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFechaRegistro.Location = New System.Drawing.Point(524, 410)
        Me.DateFechaRegistro.Name = "DateFechaRegistro"
        Me.DateFechaRegistro.Size = New System.Drawing.Size(200, 26)
        Me.DateFechaRegistro.TabIndex = 65
        '
        'DateFechaNacimiento
        '
        Me.DateFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateFechaNacimiento.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFechaNacimiento.Location = New System.Drawing.Point(524, 343)
        Me.DateFechaNacimiento.Name = "DateFechaNacimiento"
        Me.DateFechaNacimiento.Size = New System.Drawing.Size(200, 26)
        Me.DateFechaNacimiento.TabIndex = 64
        '
        'CheckMasculino
        '
        Me.CheckMasculino.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckMasculino.AutoSize = True
        Me.CheckMasculino.Location = New System.Drawing.Point(629, 202)
        Me.CheckMasculino.Name = "CheckMasculino"
        Me.CheckMasculino.Size = New System.Drawing.Size(99, 24)
        Me.CheckMasculino.TabIndex = 63
        Me.CheckMasculino.Text = "Masculino"
        Me.CheckMasculino.UseVisualStyleBackColor = True
        '
        'CheckFemenino
        '
        Me.CheckFemenino.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckFemenino.AutoSize = True
        Me.CheckFemenino.Location = New System.Drawing.Point(524, 202)
        Me.CheckFemenino.Name = "CheckFemenino"
        Me.CheckFemenino.Size = New System.Drawing.Size(99, 24)
        Me.CheckFemenino.TabIndex = 62
        Me.CheckFemenino.Text = "Femenino"
        Me.CheckFemenino.UseVisualStyleBackColor = True
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCorreo.Location = New System.Drawing.Point(249, 412)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(216, 26)
        Me.TxtCorreo.TabIndex = 61
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtTelefono.Location = New System.Drawing.Point(320, 345)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(143, 26)
        Me.TxtTelefono.TabIndex = 60
        '
        'TxtEdad
        '
        Me.TxtEdad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtEdad.Location = New System.Drawing.Point(245, 345)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(55, 26)
        Me.TxtEdad.TabIndex = 59
        '
        'TxtApellido
        '
        Me.TxtApellido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtApellido.Location = New System.Drawing.Point(247, 203)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(218, 26)
        Me.TxtApellido.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(244, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 18)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Apellido"
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNombre.Location = New System.Drawing.Point(247, 134)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(218, 26)
        Me.TxtNombre.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(244, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 18)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Id"
        '
        'TxtId
        '
        Me.TxtId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtId.Location = New System.Drawing.Point(247, 65)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(55, 26)
        Me.TxtId.TabIndex = 54
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(521, 314)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 18)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Fecha nacimiento"
        '
        'LblFecha
        '
        Me.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.ForeColor = System.Drawing.Color.SteelBlue
        Me.LblFecha.Location = New System.Drawing.Point(521, 383)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(103, 18)
        Me.LblFecha.TabIndex = 52
        Me.LblFecha.Text = "Fecha registro"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(242, 316)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 18)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Edad"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(317, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 18)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(246, 383)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 18)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Correo"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(521, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Genero"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(244, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Nombre"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(23, 55)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(194, 450)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 46
        Me.PictureBox2.TabStop = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnGuardar.Location = New System.Drawing.Point(289, 480)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(116, 48)
        Me.BtnGuardar.TabIndex = 71
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnActualizar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnActualizar.Location = New System.Drawing.Point(442, 480)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(116, 48)
        Me.BtnActualizar.TabIndex = 72
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        '
        'FrmNuevoRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 732)
        Me.Controls.Add(Me.PanelNuevoRegistro)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNuevoRegistro"
        Me.Text = "FrmNuevoRegistro"
        Me.PanelNuevoRegistro.ResumeLayout(False)
        Me.PanelTexto.ResumeLayout(False)
        Me.PanelTexto.PerformLayout()
        Me.PanelConte.ResumeLayout(False)
        Me.PanelMante.ResumeLayout(False)
        Me.PanelMante.PerformLayout()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupNuevoRegistro.ResumeLayout(False)
        Me.GroupNuevoRegistro.PerformLayout()
        Me.PanelSeguroMedico.ResumeLayout(False)
        Me.GroupSeguroMedico.ResumeLayout(False)
        Me.GroupSeguroMedico.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelNuevoRegistro As Panel
    Friend WithEvents PanelTexto As Panel
    Friend WithEvents LblTexto As Label
    Friend WithEvents PanelConte As Panel
    Friend WithEvents PanelMante As Panel
    Friend WithEvents GroupNuevoRegistro As GroupBox
    Friend WithEvents ImagenBuscar As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents CbmEstadoCivil As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DateFechaRegistro As DateTimePicker
    Friend WithEvents DateFechaNacimiento As DateTimePicker
    Friend WithEvents CheckMasculino As CheckBox
    Friend WithEvents CheckFemenino As CheckBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnSeguroMedico As Button
    Friend WithEvents PanelSeguroMedico As Panel
    Friend WithEvents GroupSeguroMedico As GroupBox
    Friend WithEvents CheckPremiun As CheckBox
    Friend WithEvents CheckPlatinum As CheckBox
    Friend WithEvents CheckSeguroBasico As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnListo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtIdentidad As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
