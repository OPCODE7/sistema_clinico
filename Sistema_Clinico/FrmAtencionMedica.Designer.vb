<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAtencionMedica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAtencionMedica))
        Me.PanelAtencionMedica = New System.Windows.Forms.Panel()
        Me.GroupAtencionMedica = New System.Windows.Forms.GroupBox()
        Me.BuscarTratamiento = New System.Windows.Forms.PictureBox()
        Me.TxtIdentidadMe = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtIdMe = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BuscarMedico = New System.Windows.Forms.PictureBox()
        Me.BuscarPaciente = New System.Windows.Forms.PictureBox()
        Me.TxtEspecialidad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtApellidoMe = New System.Windows.Forms.TextBox()
        Me.TxtMedico = New System.Windows.Forms.TextBox()
        Me.TxtApellidoPa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnCita = New System.Windows.Forms.Button()
        Me.TxtTratamiento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ImagenBuscar = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.TxtDiagnostico = New System.Windows.Forms.TextBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.DateFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.TxtPaciente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtIdPa = New System.Windows.Forms.TextBox()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnHistorial = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelTexto = New System.Windows.Forms.Panel()
        Me.LblTexto = New System.Windows.Forms.Label()
        Me.PanelAtencionMedica.SuspendLayout()
        Me.GroupAtencionMedica.SuspendLayout()
        CType(Me.BuscarTratamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTexto.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelAtencionMedica
        '
        Me.PanelAtencionMedica.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelAtencionMedica.BackColor = System.Drawing.Color.SlateGray
        Me.PanelAtencionMedica.Controls.Add(Me.GroupAtencionMedica)
        Me.PanelAtencionMedica.Location = New System.Drawing.Point(0, 28)
        Me.PanelAtencionMedica.Name = "PanelAtencionMedica"
        Me.PanelAtencionMedica.Size = New System.Drawing.Size(871, 732)
        Me.PanelAtencionMedica.TabIndex = 8
        '
        'GroupAtencionMedica
        '
        Me.GroupAtencionMedica.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupAtencionMedica.BackColor = System.Drawing.Color.Transparent
        Me.GroupAtencionMedica.Controls.Add(Me.BuscarTratamiento)
        Me.GroupAtencionMedica.Controls.Add(Me.TxtIdentidadMe)
        Me.GroupAtencionMedica.Controls.Add(Me.Label10)
        Me.GroupAtencionMedica.Controls.Add(Me.Label9)
        Me.GroupAtencionMedica.Controls.Add(Me.TxtIdMe)
        Me.GroupAtencionMedica.Controls.Add(Me.TxtId)
        Me.GroupAtencionMedica.Controls.Add(Me.BuscarMedico)
        Me.GroupAtencionMedica.Controls.Add(Me.BuscarPaciente)
        Me.GroupAtencionMedica.Controls.Add(Me.TxtEspecialidad)
        Me.GroupAtencionMedica.Controls.Add(Me.Label8)
        Me.GroupAtencionMedica.Controls.Add(Me.TxtApellidoMe)
        Me.GroupAtencionMedica.Controls.Add(Me.TxtMedico)
        Me.GroupAtencionMedica.Controls.Add(Me.TxtApellidoPa)
        Me.GroupAtencionMedica.Controls.Add(Me.Label6)
        Me.GroupAtencionMedica.Controls.Add(Me.BtnCita)
        Me.GroupAtencionMedica.Controls.Add(Me.TxtTratamiento)
        Me.GroupAtencionMedica.Controls.Add(Me.Label3)
        Me.GroupAtencionMedica.Controls.Add(Me.TxtIdentidad)
        Me.GroupAtencionMedica.Controls.Add(Me.Label5)
        Me.GroupAtencionMedica.Controls.Add(Me.Label4)
        Me.GroupAtencionMedica.Controls.Add(Me.ImagenBuscar)
        Me.GroupAtencionMedica.Controls.Add(Me.TxtBuscar)
        Me.GroupAtencionMedica.Controls.Add(Me.TxtDiagnostico)
        Me.GroupAtencionMedica.Controls.Add(Me.BtnEliminar)
        Me.GroupAtencionMedica.Controls.Add(Me.DateFechaRegistro)
        Me.GroupAtencionMedica.Controls.Add(Me.TxtPaciente)
        Me.GroupAtencionMedica.Controls.Add(Me.Label1)
        Me.GroupAtencionMedica.Controls.Add(Me.TxtIdPa)
        Me.GroupAtencionMedica.Controls.Add(Me.LblFecha)
        Me.GroupAtencionMedica.Controls.Add(Me.Label7)
        Me.GroupAtencionMedica.Controls.Add(Me.Label2)
        Me.GroupAtencionMedica.Controls.Add(Me.PictureBox1)
        Me.GroupAtencionMedica.Controls.Add(Me.BtnAgregar)
        Me.GroupAtencionMedica.Controls.Add(Me.BtnGuardar)
        Me.GroupAtencionMedica.Controls.Add(Me.BtnHistorial)
        Me.GroupAtencionMedica.Controls.Add(Me.BtnEditar)
        Me.GroupAtencionMedica.Controls.Add(Me.BtnActualizar)
        Me.GroupAtencionMedica.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupAtencionMedica.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupAtencionMedica.Location = New System.Drawing.Point(23, 55)
        Me.GroupAtencionMedica.Name = "GroupAtencionMedica"
        Me.GroupAtencionMedica.Size = New System.Drawing.Size(823, 623)
        Me.GroupAtencionMedica.TabIndex = 0
        Me.GroupAtencionMedica.TabStop = False
        Me.GroupAtencionMedica.Text = "Atención medica"
        '
        'BuscarTratamiento
        '
        Me.BuscarTratamiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BuscarTratamiento.BackColor = System.Drawing.Color.Transparent
        Me.BuscarTratamiento.Image = CType(resources.GetObject("BuscarTratamiento.Image"), System.Drawing.Image)
        Me.BuscarTratamiento.Location = New System.Drawing.Point(550, 343)
        Me.BuscarTratamiento.Name = "BuscarTratamiento"
        Me.BuscarTratamiento.Size = New System.Drawing.Size(30, 30)
        Me.BuscarTratamiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BuscarTratamiento.TabIndex = 96
        Me.BuscarTratamiento.TabStop = False
        '
        'TxtIdentidadMe
        '
        Me.TxtIdentidadMe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtIdentidadMe.Location = New System.Drawing.Point(447, 202)
        Me.TxtIdentidadMe.Name = "TxtIdentidadMe"
        Me.TxtIdentidadMe.Size = New System.Drawing.Size(133, 26)
        Me.TxtIdentidadMe.TabIndex = 95
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(444, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 18)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Identidad"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(27, 174)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 18)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Id"
        '
        'TxtIdMe
        '
        Me.TxtIdMe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtIdMe.Location = New System.Drawing.Point(30, 202)
        Me.TxtIdMe.Name = "TxtIdMe"
        Me.TxtIdMe.Size = New System.Drawing.Size(44, 26)
        Me.TxtIdMe.TabIndex = 92
        '
        'TxtId
        '
        Me.TxtId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtId.Location = New System.Drawing.Point(30, 42)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(44, 26)
        Me.TxtId.TabIndex = 91
        '
        'BuscarMedico
        '
        Me.BuscarMedico.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BuscarMedico.BackColor = System.Drawing.Color.Transparent
        Me.BuscarMedico.Image = CType(resources.GetObject("BuscarMedico.Image"), System.Drawing.Image)
        Me.BuscarMedico.Location = New System.Drawing.Point(90, 198)
        Me.BuscarMedico.Name = "BuscarMedico"
        Me.BuscarMedico.Size = New System.Drawing.Size(30, 30)
        Me.BuscarMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BuscarMedico.TabIndex = 90
        Me.BuscarMedico.TabStop = False
        '
        'BuscarPaciente
        '
        Me.BuscarPaciente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BuscarPaciente.BackColor = System.Drawing.Color.Transparent
        Me.BuscarPaciente.Image = CType(resources.GetObject("BuscarPaciente.Image"), System.Drawing.Image)
        Me.BuscarPaciente.Location = New System.Drawing.Point(90, 123)
        Me.BuscarPaciente.Name = "BuscarPaciente"
        Me.BuscarPaciente.Size = New System.Drawing.Size(30, 30)
        Me.BuscarPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BuscarPaciente.TabIndex = 89
        Me.BuscarPaciente.TabStop = False
        '
        'TxtEspecialidad
        '
        Me.TxtEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtEspecialidad.Location = New System.Drawing.Point(30, 281)
        Me.TxtEspecialidad.Name = "TxtEspecialidad"
        Me.TxtEspecialidad.Size = New System.Drawing.Size(191, 26)
        Me.TxtEspecialidad.TabIndex = 87
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(27, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 18)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "Especialidad"
        '
        'TxtApellidoMe
        '
        Me.TxtApellidoMe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtApellidoMe.Location = New System.Drawing.Point(261, 202)
        Me.TxtApellidoMe.Name = "TxtApellidoMe"
        Me.TxtApellidoMe.Size = New System.Drawing.Size(169, 26)
        Me.TxtApellidoMe.TabIndex = 85
        '
        'TxtMedico
        '
        Me.TxtMedico.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtMedico.Location = New System.Drawing.Point(122, 202)
        Me.TxtMedico.Name = "TxtMedico"
        Me.TxtMedico.Size = New System.Drawing.Size(139, 26)
        Me.TxtMedico.TabIndex = 84
        Me.ToolTip1.SetToolTip(Me.TxtMedico, "Ingresar medico")
        '
        'TxtApellidoPa
        '
        Me.TxtApellidoPa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtApellidoPa.Location = New System.Drawing.Point(261, 127)
        Me.TxtApellidoPa.Name = "TxtApellidoPa"
        Me.TxtApellidoPa.Size = New System.Drawing.Size(169, 26)
        Me.TxtApellidoPa.TabIndex = 83
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(89, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 18)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Medico"
        '
        'BtnCita
        '
        Me.BtnCita.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnCita.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnCita.Location = New System.Drawing.Point(614, 420)
        Me.BtnCita.Name = "BtnCita"
        Me.BtnCita.Size = New System.Drawing.Size(173, 48)
        Me.BtnCita.TabIndex = 78
        Me.BtnCita.Text = "Cita medica"
        Me.BtnCita.UseVisualStyleBackColor = False
        '
        'TxtTratamiento
        '
        Me.TxtTratamiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtTratamiento.Location = New System.Drawing.Point(305, 347)
        Me.TxtTratamiento.Multiline = True
        Me.TxtTratamiento.Name = "TxtTratamiento"
        Me.TxtTratamiento.Size = New System.Drawing.Size(239, 253)
        Me.TxtTratamiento.TabIndex = 77
        Me.ToolTip1.SetToolTip(Me.TxtTratamiento, "Ingresar nombre del medicamento")
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(302, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 18)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Tratamiento"
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtIdentidad.Location = New System.Drawing.Point(447, 127)
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(133, 26)
        Me.TxtIdentidad.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(444, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Identidad"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(89, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 18)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Buscar historial de paciente "
        '
        'ImagenBuscar
        '
        Me.ImagenBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImagenBuscar.BackColor = System.Drawing.Color.Transparent
        Me.ImagenBuscar.Image = CType(resources.GetObject("ImagenBuscar.Image"), System.Drawing.Image)
        Me.ImagenBuscar.Location = New System.Drawing.Point(541, 33)
        Me.ImagenBuscar.Name = "ImagenBuscar"
        Me.ImagenBuscar.Size = New System.Drawing.Size(39, 41)
        Me.ImagenBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenBuscar.TabIndex = 38
        Me.ImagenBuscar.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtBuscar.Location = New System.Drawing.Point(289, 42)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(246, 26)
        Me.TxtBuscar.TabIndex = 35
        Me.ToolTip1.SetToolTip(Me.TxtBuscar, "Buscar paciente para conocer historial")
        '
        'TxtDiagnostico
        '
        Me.TxtDiagnostico.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDiagnostico.Location = New System.Drawing.Point(30, 350)
        Me.TxtDiagnostico.Multiline = True
        Me.TxtDiagnostico.Name = "TxtDiagnostico"
        Me.TxtDiagnostico.Size = New System.Drawing.Size(253, 250)
        Me.TxtDiagnostico.TabIndex = 69
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Crimson
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEliminar.Location = New System.Drawing.Point(643, 352)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(116, 48)
        Me.BtnEliminar.TabIndex = 66
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'DateFechaRegistro
        '
        Me.DateFechaRegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateFechaRegistro.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFechaRegistro.Location = New System.Drawing.Point(600, 573)
        Me.DateFechaRegistro.Name = "DateFechaRegistro"
        Me.DateFechaRegistro.Size = New System.Drawing.Size(200, 26)
        Me.DateFechaRegistro.TabIndex = 60
        '
        'TxtPaciente
        '
        Me.TxtPaciente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtPaciente.Location = New System.Drawing.Point(122, 127)
        Me.TxtPaciente.Name = "TxtPaciente"
        Me.TxtPaciente.Size = New System.Drawing.Size(139, 26)
        Me.TxtPaciente.TabIndex = 58
        Me.ToolTip1.SetToolTip(Me.TxtPaciente, "Ingresar nuevo paciente")
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 18)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Id"
        '
        'TxtIdPa
        '
        Me.TxtIdPa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtIdPa.Location = New System.Drawing.Point(30, 127)
        Me.TxtIdPa.Name = "TxtIdPa"
        Me.TxtIdPa.Size = New System.Drawing.Size(44, 26)
        Me.TxtIdPa.TabIndex = 56
        '
        'LblFecha
        '
        Me.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.ForeColor = System.Drawing.Color.White
        Me.LblFecha.Location = New System.Drawing.Point(597, 546)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(103, 18)
        Me.LblFecha.TabIndex = 55
        Me.LblFecha.Text = "Fecha registro"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(27, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 18)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Diagnostico"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(89, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Paciente"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(600, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAgregar.Location = New System.Drawing.Point(643, 244)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(116, 48)
        Me.BtnAgregar.TabIndex = 64
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnGuardar.Location = New System.Drawing.Point(643, 244)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(116, 48)
        Me.BtnGuardar.TabIndex = 67
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'BtnHistorial
        '
        Me.BtnHistorial.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnHistorial.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnHistorial.Location = New System.Drawing.Point(643, 298)
        Me.BtnHistorial.Name = "BtnHistorial"
        Me.BtnHistorial.Size = New System.Drawing.Size(116, 48)
        Me.BtnHistorial.TabIndex = 88
        Me.BtnHistorial.Text = "Buscar "
        Me.BtnHistorial.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnEditar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEditar.Location = New System.Drawing.Point(643, 298)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(116, 48)
        Me.BtnEditar.TabIndex = 65
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnActualizar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnActualizar.Location = New System.Drawing.Point(643, 298)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(116, 48)
        Me.BtnActualizar.TabIndex = 68
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        '
        'PanelTexto
        '
        Me.PanelTexto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelTexto.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelTexto.Controls.Add(Me.LblTexto)
        Me.PanelTexto.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelTexto.Location = New System.Drawing.Point(0, 0)
        Me.PanelTexto.Name = "PanelTexto"
        Me.PanelTexto.Size = New System.Drawing.Size(871, 57)
        Me.PanelTexto.TabIndex = 28
        '
        'LblTexto
        '
        Me.LblTexto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblTexto.AutoSize = True
        Me.LblTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTexto.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblTexto.Location = New System.Drawing.Point(368, 17)
        Me.LblTexto.Name = "LblTexto"
        Me.LblTexto.Size = New System.Drawing.Size(157, 24)
        Me.LblTexto.TabIndex = 26
        Me.LblTexto.Text = "Atencion medica "
        '
        'FrmAtencionMedica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 732)
        Me.Controls.Add(Me.PanelTexto)
        Me.Controls.Add(Me.PanelAtencionMedica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "FrmAtencionMedica"
        Me.Text = "FrmAtencionMedica"
        Me.PanelAtencionMedica.ResumeLayout(False)
        Me.GroupAtencionMedica.ResumeLayout(False)
        Me.GroupAtencionMedica.PerformLayout()
        CType(Me.BuscarTratamiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarMedico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTexto.ResumeLayout(False)
        Me.PanelTexto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelAtencionMedica As Panel
    Friend WithEvents ImagenBuscar As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GroupAtencionMedica As GroupBox
    Friend WithEvents TxtDiagnostico As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents DateFechaRegistro As DateTimePicker
    Friend WithEvents TxtPaciente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIdPa As TextBox
    Friend WithEvents LblFecha As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents TxtTratamiento As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtIdentidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCita As Button
    Friend WithEvents TxtEspecialidad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtApellidoMe As TextBox
    Friend WithEvents TxtMedico As TextBox
    Friend WithEvents TxtApellidoPa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnHistorial As Button
    Friend WithEvents BuscarMedico As PictureBox
    Friend WithEvents BuscarPaciente As PictureBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtIdentidadMe As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtIdMe As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PanelTexto As Panel
    Friend WithEvents LblTexto As Label
    Friend WithEvents BuscarTratamiento As PictureBox
End Class
