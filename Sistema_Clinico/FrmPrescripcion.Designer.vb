<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrescripcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrescripcion))
        Me.PanelAtencionMedica = New System.Windows.Forms.Panel()
        Me.Salir = New System.Windows.Forms.PictureBox()
        Me.GroupCita = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtIdHistorial = New System.Windows.Forms.TextBox()
        Me.DateFechaCita = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.TxtIdentidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ImagenBuscar = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.DateFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.TxtPaciente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtIdPa = New System.Windows.Forms.TextBox()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.ListTratamiento = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CheckTipoExamen = New System.Windows.Forms.CheckedListBox()
        Me.PanelAtencionMedica.SuspendLayout()
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupCita.SuspendLayout()
        CType(Me.BuscarMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarPaciente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelAtencionMedica
        '
        Me.PanelAtencionMedica.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelAtencionMedica.BackColor = System.Drawing.Color.SteelBlue
        Me.PanelAtencionMedica.Controls.Add(Me.Salir)
        Me.PanelAtencionMedica.Controls.Add(Me.GroupCita)
        Me.PanelAtencionMedica.Location = New System.Drawing.Point(22, 21)
        Me.PanelAtencionMedica.Name = "PanelAtencionMedica"
        Me.PanelAtencionMedica.Size = New System.Drawing.Size(924, 776)
        Me.PanelAtencionMedica.TabIndex = 10
        '
        'Salir
        '
        Me.Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Salir.BackColor = System.Drawing.Color.Transparent
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.Location = New System.Drawing.Point(896, 3)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(25, 25)
        Me.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Salir.TabIndex = 11
        Me.Salir.TabStop = False
        '
        'GroupCita
        '
        Me.GroupCita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupCita.BackColor = System.Drawing.Color.Transparent
        Me.GroupCita.Controls.Add(Me.CheckTipoExamen)
        Me.GroupCita.Controls.Add(Me.Label12)
        Me.GroupCita.Controls.Add(Me.ListTratamiento)
        Me.GroupCita.Controls.Add(Me.Label11)
        Me.GroupCita.Controls.Add(Me.Label7)
        Me.GroupCita.Controls.Add(Me.TxtId)
        Me.GroupCita.Controls.Add(Me.TxtIdHistorial)
        Me.GroupCita.Controls.Add(Me.BtnGuardar)
        Me.GroupCita.Controls.Add(Me.DateFechaCita)
        Me.GroupCita.Controls.Add(Me.BtnAgregar)
        Me.GroupCita.Controls.Add(Me.Label3)
        Me.GroupCita.Controls.Add(Me.Label2)
        Me.GroupCita.Controls.Add(Me.TxtIdentidadMe)
        Me.GroupCita.Controls.Add(Me.LblFecha)
        Me.GroupCita.Controls.Add(Me.Label10)
        Me.GroupCita.Controls.Add(Me.TxtIdPa)
        Me.GroupCita.Controls.Add(Me.Label9)
        Me.GroupCita.Controls.Add(Me.Label1)
        Me.GroupCita.Controls.Add(Me.TxtIdMe)
        Me.GroupCita.Controls.Add(Me.TxtPaciente)
        Me.GroupCita.Controls.Add(Me.DateFechaRegistro)
        Me.GroupCita.Controls.Add(Me.BuscarMedico)
        Me.GroupCita.Controls.Add(Me.BtnEliminar)
        Me.GroupCita.Controls.Add(Me.BuscarPaciente)
        Me.GroupCita.Controls.Add(Me.TxtBuscar)
        Me.GroupCita.Controls.Add(Me.TxtEspecialidad)
        Me.GroupCita.Controls.Add(Me.ImagenBuscar)
        Me.GroupCita.Controls.Add(Me.Label8)
        Me.GroupCita.Controls.Add(Me.Label4)
        Me.GroupCita.Controls.Add(Me.TxtApellidoMe)
        Me.GroupCita.Controls.Add(Me.Label5)
        Me.GroupCita.Controls.Add(Me.TxtMedico)
        Me.GroupCita.Controls.Add(Me.TxtIdentidad)
        Me.GroupCita.Controls.Add(Me.TxtApellidoPa)
        Me.GroupCita.Controls.Add(Me.Label6)
        Me.GroupCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupCita.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupCita.Location = New System.Drawing.Point(21, 16)
        Me.GroupCita.Name = "GroupCita"
        Me.GroupCita.Size = New System.Drawing.Size(878, 749)
        Me.GroupCita.TabIndex = 1
        Me.GroupCita.TabStop = False
        Me.GroupCita.Text = "Cita medica"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(61, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 18)
        Me.Label7.TabIndex = 192
        Me.Label7.Text = "Historial clinico"
        '
        'TxtIdHistorial
        '
        Me.TxtIdHistorial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtIdHistorial.Location = New System.Drawing.Point(177, 106)
        Me.TxtIdHistorial.Name = "TxtIdHistorial"
        Me.TxtIdHistorial.Size = New System.Drawing.Size(44, 26)
        Me.TxtIdHistorial.TabIndex = 191
        '
        'DateFechaCita
        '
        Me.DateFechaCita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateFechaCita.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFechaCita.Location = New System.Drawing.Point(64, 326)
        Me.DateFechaCita.Name = "DateFechaCita"
        Me.DateFechaCita.Size = New System.Drawing.Size(200, 26)
        Me.DateFechaCita.TabIndex = 190
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(61, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 18)
        Me.Label3.TabIndex = 189
        Me.Label3.Text = "Fecha cita"
        '
        'TxtIdentidadMe
        '
        Me.TxtIdentidadMe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtIdentidadMe.Location = New System.Drawing.Point(481, 255)
        Me.TxtIdentidadMe.Name = "TxtIdentidadMe"
        Me.TxtIdentidadMe.Size = New System.Drawing.Size(133, 26)
        Me.TxtIdentidadMe.TabIndex = 188
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(478, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 18)
        Me.Label10.TabIndex = 187
        Me.Label10.Text = "Identidad"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(61, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 18)
        Me.Label9.TabIndex = 186
        Me.Label9.Text = "Id"
        '
        'TxtIdMe
        '
        Me.TxtIdMe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtIdMe.Location = New System.Drawing.Point(64, 255)
        Me.TxtIdMe.Name = "TxtIdMe"
        Me.TxtIdMe.Size = New System.Drawing.Size(44, 26)
        Me.TxtIdMe.TabIndex = 185
        '
        'TxtId
        '
        Me.TxtId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtId.Location = New System.Drawing.Point(62, 62)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(44, 26)
        Me.TxtId.TabIndex = 184
        '
        'BuscarMedico
        '
        Me.BuscarMedico.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BuscarMedico.BackColor = System.Drawing.Color.Transparent
        Me.BuscarMedico.Image = CType(resources.GetObject("BuscarMedico.Image"), System.Drawing.Image)
        Me.BuscarMedico.Location = New System.Drawing.Point(124, 251)
        Me.BuscarMedico.Name = "BuscarMedico"
        Me.BuscarMedico.Size = New System.Drawing.Size(30, 30)
        Me.BuscarMedico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BuscarMedico.TabIndex = 183
        Me.BuscarMedico.TabStop = False
        '
        'BuscarPaciente
        '
        Me.BuscarPaciente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BuscarPaciente.BackColor = System.Drawing.Color.Transparent
        Me.BuscarPaciente.Image = CType(resources.GetObject("BuscarPaciente.Image"), System.Drawing.Image)
        Me.BuscarPaciente.Location = New System.Drawing.Point(124, 176)
        Me.BuscarPaciente.Name = "BuscarPaciente"
        Me.BuscarPaciente.Size = New System.Drawing.Size(30, 30)
        Me.BuscarPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BuscarPaciente.TabIndex = 182
        Me.BuscarPaciente.TabStop = False
        '
        'TxtEspecialidad
        '
        Me.TxtEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtEspecialidad.Location = New System.Drawing.Point(629, 255)
        Me.TxtEspecialidad.Name = "TxtEspecialidad"
        Me.TxtEspecialidad.Size = New System.Drawing.Size(169, 26)
        Me.TxtEspecialidad.TabIndex = 181
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(626, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 18)
        Me.Label8.TabIndex = 180
        Me.Label8.Text = "Especialidad"
        '
        'TxtApellidoMe
        '
        Me.TxtApellidoMe.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtApellidoMe.Location = New System.Drawing.Point(295, 255)
        Me.TxtApellidoMe.Name = "TxtApellidoMe"
        Me.TxtApellidoMe.Size = New System.Drawing.Size(169, 26)
        Me.TxtApellidoMe.TabIndex = 179
        '
        'TxtMedico
        '
        Me.TxtMedico.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtMedico.Location = New System.Drawing.Point(156, 255)
        Me.TxtMedico.Name = "TxtMedico"
        Me.TxtMedico.Size = New System.Drawing.Size(139, 26)
        Me.TxtMedico.TabIndex = 178
        '
        'TxtApellidoPa
        '
        Me.TxtApellidoPa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtApellidoPa.Location = New System.Drawing.Point(295, 180)
        Me.TxtApellidoPa.Name = "TxtApellidoPa"
        Me.TxtApellidoPa.Size = New System.Drawing.Size(169, 26)
        Me.TxtApellidoPa.TabIndex = 177
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(123, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 18)
        Me.Label6.TabIndex = 176
        Me.Label6.Text = "Medico"
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtIdentidad.Location = New System.Drawing.Point(481, 180)
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(133, 26)
        Me.TxtIdentidad.TabIndex = 175
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(478, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "Identidad"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(119, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 18)
        Me.Label4.TabIndex = 173
        Me.Label4.Text = "Buscar paciente con historial "
        '
        'ImagenBuscar
        '
        Me.ImagenBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ImagenBuscar.BackColor = System.Drawing.Color.Transparent
        Me.ImagenBuscar.Image = CType(resources.GetObject("ImagenBuscar.Image"), System.Drawing.Image)
        Me.ImagenBuscar.Location = New System.Drawing.Point(761, 53)
        Me.ImagenBuscar.Name = "ImagenBuscar"
        Me.ImagenBuscar.Size = New System.Drawing.Size(39, 41)
        Me.ImagenBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImagenBuscar.TabIndex = 163
        Me.ImagenBuscar.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtBuscar.Location = New System.Drawing.Point(327, 62)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(428, 26)
        Me.TxtBuscar.TabIndex = 162
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Crimson
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEliminar.Location = New System.Drawing.Point(742, 684)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(116, 48)
        Me.BtnEliminar.TabIndex = 171
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'DateFechaRegistro
        '
        Me.DateFechaRegistro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateFechaRegistro.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateFechaRegistro.Location = New System.Drawing.Point(62, 691)
        Me.DateFechaRegistro.Name = "DateFechaRegistro"
        Me.DateFechaRegistro.Size = New System.Drawing.Size(200, 26)
        Me.DateFechaRegistro.TabIndex = 169
        '
        'TxtPaciente
        '
        Me.TxtPaciente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtPaciente.Location = New System.Drawing.Point(156, 180)
        Me.TxtPaciente.Name = "TxtPaciente"
        Me.TxtPaciente.Size = New System.Drawing.Size(139, 26)
        Me.TxtPaciente.TabIndex = 168
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(61, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 18)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Id"
        '
        'TxtIdPa
        '
        Me.TxtIdPa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtIdPa.Location = New System.Drawing.Point(64, 180)
        Me.TxtIdPa.Name = "TxtIdPa"
        Me.TxtIdPa.Size = New System.Drawing.Size(44, 26)
        Me.TxtIdPa.TabIndex = 166
        '
        'LblFecha
        '
        Me.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.ForeColor = System.Drawing.Color.White
        Me.LblFecha.Location = New System.Drawing.Point(59, 664)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(103, 18)
        Me.LblFecha.TabIndex = 165
        Me.LblFecha.Text = "Fecha registro"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(123, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Paciente"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAgregar.Location = New System.Drawing.Point(514, 684)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(205, 48)
        Me.BtnAgregar.TabIndex = 170
        Me.BtnAgregar.Text = "Agregar cita medica"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnGuardar.Location = New System.Drawing.Point(514, 684)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(205, 48)
        Me.BtnGuardar.TabIndex = 172
        Me.BtnGuardar.Text = "Guardar cita medica"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'ListTratamiento
        '
        Me.ListTratamiento.FormattingEnabled = True
        Me.ListTratamiento.ItemHeight = 20
        Me.ListTratamiento.Location = New System.Drawing.Point(62, 396)
        Me.ListTratamiento.Name = "ListTratamiento"
        Me.ListTratamiento.Size = New System.Drawing.Size(275, 264)
        Me.ListTratamiento.TabIndex = 195
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(59, 370)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 18)
        Me.Label11.TabIndex = 193
        Me.Label11.Text = "Tratamiento"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(377, 299)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 18)
        Me.Label12.TabIndex = 196
        Me.Label12.Text = "Tipo examen"
        '
        'CheckTipoExamen
        '
        Me.CheckTipoExamen.FormattingEnabled = True
        Me.CheckTipoExamen.Location = New System.Drawing.Point(380, 325)
        Me.CheckTipoExamen.Name = "CheckTipoExamen"
        Me.CheckTipoExamen.Size = New System.Drawing.Size(420, 340)
        Me.CheckTipoExamen.TabIndex = 197
        '
        'FrmPrescripcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 821)
        Me.Controls.Add(Me.PanelAtencionMedica)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPrescripcion"
        Me.Text = "FrmPrescripcion"
        Me.PanelAtencionMedica.ResumeLayout(False)
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupCita.ResumeLayout(False)
        Me.GroupCita.PerformLayout()
        CType(Me.BuscarMedico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarPaciente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelAtencionMedica As Panel
    Friend WithEvents Salir As PictureBox
    Friend WithEvents GroupCita As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents TxtIdHistorial As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents DateFechaCita As DateTimePicker
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdentidadMe As TextBox
    Friend WithEvents LblFecha As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtIdPa As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIdMe As TextBox
    Friend WithEvents TxtPaciente As TextBox
    Friend WithEvents DateFechaRegistro As DateTimePicker
    Friend WithEvents BuscarMedico As PictureBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BuscarPaciente As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents TxtEspecialidad As TextBox
    Friend WithEvents ImagenBuscar As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtApellidoMe As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtMedico As TextBox
    Friend WithEvents TxtIdentidad As TextBox
    Friend WithEvents TxtApellidoPa As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckTipoExamen As CheckedListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ListTratamiento As ListBox
    Friend WithEvents Label11 As Label
End Class
