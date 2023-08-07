<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimiento))
        Me.PanelMante = New System.Windows.Forms.Panel()
        Me.BtnDescuentos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnTurnos = New System.Windows.Forms.Button()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.BtnRolEmpleado = New System.Windows.Forms.Button()
        Me.BtnMedicamentos = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.BtnProveedores = New System.Windows.Forms.Button()
        Me.BtnEspecialidad = New System.Windows.Forms.Button()
        Me.BtnMedicos = New System.Windows.Forms.Button()
        Me.BtnServicios = New System.Windows.Forms.Button()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.BtnEquipoMedico = New System.Windows.Forms.Button()
        Me.BtnEmpleados = New System.Windows.Forms.Button()
        Me.BtnTipoExamen = New System.Windows.Forms.Button()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PanelMantenimiento = New System.Windows.Forms.Panel()
        Me.PanelTexto = New System.Windows.Forms.Panel()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.LblTexto = New System.Windows.Forms.Label()
        Me.PanelConte = New System.Windows.Forms.Panel()
        Me.PanelMante.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMantenimiento.SuspendLayout()
        Me.PanelTexto.SuspendLayout()
        Me.PanelConte.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMante
        '
        Me.PanelMante.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelMante.BackColor = System.Drawing.Color.Transparent
        Me.PanelMante.Controls.Add(Me.BtnDescuentos)
        Me.PanelMante.Controls.Add(Me.PictureBox1)
        Me.PanelMante.Controls.Add(Me.BtnTurnos)
        Me.PanelMante.Controls.Add(Me.PictureBox13)
        Me.PanelMante.Controls.Add(Me.PictureBox7)
        Me.PanelMante.Controls.Add(Me.PictureBox6)
        Me.PanelMante.Controls.Add(Me.BtnRolEmpleado)
        Me.PanelMante.Controls.Add(Me.BtnMedicamentos)
        Me.PanelMante.Controls.Add(Me.PictureBox8)
        Me.PanelMante.Controls.Add(Me.PictureBox5)
        Me.PanelMante.Controls.Add(Me.BtnProveedores)
        Me.PanelMante.Controls.Add(Me.BtnEspecialidad)
        Me.PanelMante.Controls.Add(Me.BtnMedicos)
        Me.PanelMante.Controls.Add(Me.BtnServicios)
        Me.PanelMante.Controls.Add(Me.PictureBox10)
        Me.PanelMante.Controls.Add(Me.PictureBox3)
        Me.PanelMante.Controls.Add(Me.PictureBox2)
        Me.PanelMante.Controls.Add(Me.PictureBox12)
        Me.PanelMante.Controls.Add(Me.BtnEquipoMedico)
        Me.PanelMante.Controls.Add(Me.BtnEmpleados)
        Me.PanelMante.Controls.Add(Me.BtnTipoExamen)
        Me.PanelMante.Controls.Add(Me.PictureBox11)
        Me.PanelMante.Location = New System.Drawing.Point(0, 0)
        Me.PanelMante.Name = "PanelMante"
        Me.PanelMante.Size = New System.Drawing.Size(871, 676)
        Me.PanelMante.TabIndex = 0
        '
        'BtnDescuentos
        '
        Me.BtnDescuentos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnDescuentos.BackColor = System.Drawing.Color.White
        Me.BtnDescuentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDescuentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDescuentos.Location = New System.Drawing.Point(220, 602)
        Me.BtnDescuentos.Name = "BtnDescuentos"
        Me.BtnDescuentos.Size = New System.Drawing.Size(121, 30)
        Me.BtnDescuentos.TabIndex = 25
        Me.BtnDescuentos.Text = "Descuentos"
        Me.BtnDescuentos.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(70, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnTurnos
        '
        Me.BtnTurnos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnTurnos.BackColor = System.Drawing.Color.White
        Me.BtnTurnos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTurnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTurnos.Location = New System.Drawing.Point(70, 383)
        Me.BtnTurnos.Name = "BtnTurnos"
        Me.BtnTurnos.Size = New System.Drawing.Size(121, 30)
        Me.BtnTurnos.TabIndex = 11
        Me.BtnTurnos.Text = "Turnos"
        Me.BtnTurnos.UseVisualStyleBackColor = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(220, 458)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(121, 138)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox13.TabIndex = 24
        Me.PictureBox13.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(70, 239)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(121, 138)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 10
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(220, 240)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(121, 138)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 12
        Me.PictureBox6.TabStop = False
        '
        'BtnRolEmpleado
        '
        Me.BtnRolEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnRolEmpleado.BackColor = System.Drawing.Color.White
        Me.BtnRolEmpleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRolEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRolEmpleado.Location = New System.Drawing.Point(615, 168)
        Me.BtnRolEmpleado.Name = "BtnRolEmpleado"
        Me.BtnRolEmpleado.Size = New System.Drawing.Size(121, 30)
        Me.BtnRolEmpleado.TabIndex = 9
        Me.BtnRolEmpleado.Text = "Rol empleado"
        Me.BtnRolEmpleado.UseVisualStyleBackColor = False
        '
        'BtnMedicamentos
        '
        Me.BtnMedicamentos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnMedicamentos.BackColor = System.Drawing.Color.White
        Me.BtnMedicamentos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMedicamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMedicamentos.Location = New System.Drawing.Point(219, 383)
        Me.BtnMedicamentos.Name = "BtnMedicamentos"
        Me.BtnMedicamentos.Size = New System.Drawing.Size(121, 30)
        Me.BtnMedicamentos.TabIndex = 13
        Me.BtnMedicamentos.Text = "Medicamentos"
        Me.BtnMedicamentos.UseVisualStyleBackColor = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(615, 23)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(121, 138)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 8
        Me.PictureBox8.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(371, 239)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(121, 138)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'BtnProveedores
        '
        Me.BtnProveedores.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnProveedores.BackColor = System.Drawing.Color.White
        Me.BtnProveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProveedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProveedores.Location = New System.Drawing.Point(70, 601)
        Me.BtnProveedores.Name = "BtnProveedores"
        Me.BtnProveedores.Size = New System.Drawing.Size(121, 30)
        Me.BtnProveedores.TabIndex = 21
        Me.BtnProveedores.Text = "Proveedores"
        Me.BtnProveedores.UseVisualStyleBackColor = False
        '
        'BtnEspecialidad
        '
        Me.BtnEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEspecialidad.BackColor = System.Drawing.Color.White
        Me.BtnEspecialidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEspecialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEspecialidad.Location = New System.Drawing.Point(409, 168)
        Me.BtnEspecialidad.Name = "BtnEspecialidad"
        Me.BtnEspecialidad.Size = New System.Drawing.Size(121, 49)
        Me.BtnEspecialidad.TabIndex = 7
        Me.BtnEspecialidad.Text = "Especialidad medica"
        Me.BtnEspecialidad.UseVisualStyleBackColor = False
        '
        'BtnMedicos
        '
        Me.BtnMedicos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnMedicos.BackColor = System.Drawing.Color.White
        Me.BtnMedicos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMedicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMedicos.Location = New System.Drawing.Point(69, 167)
        Me.BtnMedicos.Name = "BtnMedicos"
        Me.BtnMedicos.Size = New System.Drawing.Size(121, 30)
        Me.BtnMedicos.TabIndex = 1
        Me.BtnMedicos.Text = "Medicos"
        Me.BtnMedicos.UseVisualStyleBackColor = False
        '
        'BtnServicios
        '
        Me.BtnServicios.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnServicios.BackColor = System.Drawing.Color.White
        Me.BtnServicios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnServicios.Location = New System.Drawing.Point(371, 383)
        Me.BtnServicios.Name = "BtnServicios"
        Me.BtnServicios.Size = New System.Drawing.Size(121, 49)
        Me.BtnServicios.TabIndex = 15
        Me.BtnServicios.Text = "Servicios Clinicos"
        Me.BtnServicios.UseVisualStyleBackColor = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(71, 458)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(121, 138)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox10.TabIndex = 20
        Me.PictureBox10.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(408, 23)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(121, 138)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(244, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(121, 138)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(523, 240)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(121, 138)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 16
        Me.PictureBox12.TabStop = False
        '
        'BtnEquipoMedico
        '
        Me.BtnEquipoMedico.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEquipoMedico.BackColor = System.Drawing.Color.White
        Me.BtnEquipoMedico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEquipoMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEquipoMedico.Location = New System.Drawing.Point(675, 383)
        Me.BtnEquipoMedico.Name = "BtnEquipoMedico"
        Me.BtnEquipoMedico.Size = New System.Drawing.Size(121, 49)
        Me.BtnEquipoMedico.TabIndex = 19
        Me.BtnEquipoMedico.Text = "Equipo medico"
        Me.BtnEquipoMedico.UseVisualStyleBackColor = False
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEmpleados.BackColor = System.Drawing.Color.White
        Me.BtnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpleados.Location = New System.Drawing.Point(244, 168)
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.Size = New System.Drawing.Size(121, 30)
        Me.BtnEmpleados.TabIndex = 3
        Me.BtnEmpleados.Text = "Empleados"
        Me.BtnEmpleados.UseVisualStyleBackColor = False
        '
        'BtnTipoExamen
        '
        Me.BtnTipoExamen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnTipoExamen.BackColor = System.Drawing.Color.White
        Me.BtnTipoExamen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTipoExamen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTipoExamen.Location = New System.Drawing.Point(522, 383)
        Me.BtnTipoExamen.Name = "BtnTipoExamen"
        Me.BtnTipoExamen.Size = New System.Drawing.Size(121, 49)
        Me.BtnTipoExamen.TabIndex = 17
        Me.BtnTipoExamen.Text = "Tipos de Examenes"
        Me.BtnTipoExamen.UseVisualStyleBackColor = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(675, 239)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(121, 138)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox11.TabIndex = 18
        Me.PictureBox11.TabStop = False
        '
        'PanelMantenimiento
        '
        Me.PanelMantenimiento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelMantenimiento.BackColor = System.Drawing.Color.White
        Me.PanelMantenimiento.Controls.Add(Me.PanelTexto)
        Me.PanelMantenimiento.Controls.Add(Me.PanelConte)
        Me.PanelMantenimiento.Location = New System.Drawing.Point(100, 3)
        Me.PanelMantenimiento.Name = "PanelMantenimiento"
        Me.PanelMantenimiento.Size = New System.Drawing.Size(871, 732)
        Me.PanelMantenimiento.TabIndex = 28
        '
        'PanelTexto
        '
        Me.PanelTexto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelTexto.BackColor = System.Drawing.Color.Transparent
        Me.PanelTexto.Controls.Add(Me.BtnSalir)
        Me.PanelTexto.Controls.Add(Me.LblTexto)
        Me.PanelTexto.Location = New System.Drawing.Point(2, 2)
        Me.PanelTexto.Name = "PanelTexto"
        Me.PanelTexto.Size = New System.Drawing.Size(869, 57)
        Me.PanelTexto.TabIndex = 27
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Crimson
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSalir.Location = New System.Drawing.Point(816, 20)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(29, 23)
        Me.BtnSalir.TabIndex = 29
        Me.BtnSalir.Text = "X"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'LblTexto
        '
        Me.LblTexto.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblTexto.AutoSize = True
        Me.LblTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTexto.Location = New System.Drawing.Point(367, 17)
        Me.LblTexto.Name = "LblTexto"
        Me.LblTexto.Size = New System.Drawing.Size(134, 24)
        Me.LblTexto.TabIndex = 26
        Me.LblTexto.Text = "Mantenimiento"
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
        'FrmMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 749)
        Me.Controls.Add(Me.PanelMantenimiento)
        Me.Name = "FrmMantenimiento"
        Me.Text = " "
        Me.PanelMante.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMantenimiento.ResumeLayout(False)
        Me.PanelTexto.ResumeLayout(False)
        Me.PanelTexto.PerformLayout()
        Me.PanelConte.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMante As Panel
    Friend WithEvents BtnDescuentos As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnTurnos As Button
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents BtnRolEmpleado As Button
    Friend WithEvents BtnMedicamentos As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents BtnProveedores As Button
    Friend WithEvents BtnEspecialidad As Button
    Friend WithEvents BtnMedicos As Button
    Friend WithEvents BtnServicios As Button
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents BtnEquipoMedico As Button
    Friend WithEvents BtnEmpleados As Button
    Friend WithEvents BtnTipoExamen As Button
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PanelMantenimiento As Panel
    Friend WithEvents PanelTexto As Panel
    Friend WithEvents LblTexto As Label
    Friend WithEvents PanelConte As Panel
    Friend WithEvents BtnSalir As Button
End Class
