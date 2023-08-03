<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip6 = New System.Windows.Forms.MenuStrip()
        Me.AtencionMedica = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        Me.ManualUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip5 = New System.Windows.Forms.MenuStrip()
        Me.Reportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.GenerarFactura = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.NuevoRegistro = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Mantenimiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Principal = New System.Windows.Forms.MenuStrip()
        Me.PrincipalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Salir = New System.Windows.Forms.PictureBox()
        Me.PanelBarra = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Maximizar = New System.Windows.Forms.PictureBox()
        Me.Minimizar = New System.Windows.Forms.PictureBox()
        Me.Restaurar = New System.Windows.Forms.PictureBox()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.HoraFecha = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip6.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip4.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip5.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Principal.SuspendLayout()
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarra.SuspendLayout()
        CType(Me.Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Restaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPrincipal.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1004, 625)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 151)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.MenuStrip6)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.MenuStrip4)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.MenuStrip5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.MenuStrip2)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.MenuStrip3)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Principal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 723)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(11, 277)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(49, 52)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 13
        Me.PictureBox8.TabStop = False
        '
        'MenuStrip6
        '
        Me.MenuStrip6.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip6.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtencionMedica})
        Me.MenuStrip6.Location = New System.Drawing.Point(75, 293)
        Me.MenuStrip6.Name = "MenuStrip6"
        Me.MenuStrip6.Size = New System.Drawing.Size(184, 30)
        Me.MenuStrip6.TabIndex = 12
        Me.MenuStrip6.Text = "MenuStrip6"
        '
        'AtencionMedica
        '
        Me.AtencionMedica.ForeColor = System.Drawing.SystemColors.Control
        Me.AtencionMedica.Name = "AtencionMedica"
        Me.AtencionMedica.Size = New System.Drawing.Size(176, 26)
        Me.AtencionMedica.Text = "Atención medica"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(19, 509)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(49, 52)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 11
        Me.PictureBox6.TabStop = False
        '
        'MenuStrip4
        '
        Me.MenuStrip4.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualUsuario})
        Me.MenuStrip4.Location = New System.Drawing.Point(75, 525)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.Size = New System.Drawing.Size(202, 30)
        Me.MenuStrip4.TabIndex = 10
        Me.MenuStrip4.Text = "MenuStrip4"
        '
        'ManualUsuario
        '
        Me.ManualUsuario.ForeColor = System.Drawing.SystemColors.Control
        Me.ManualUsuario.Name = "ManualUsuario"
        Me.ManualUsuario.Size = New System.Drawing.Size(194, 26)
        Me.ManualUsuario.Text = "Manual de usuario"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(11, 431)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(49, 52)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 9
        Me.PictureBox7.TabStop = False
        '
        'MenuStrip5
        '
        Me.MenuStrip5.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip5.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Reportes})
        Me.MenuStrip5.Location = New System.Drawing.Point(75, 447)
        Me.MenuStrip5.Name = "MenuStrip5"
        Me.MenuStrip5.Size = New System.Drawing.Size(114, 30)
        Me.MenuStrip5.TabIndex = 8
        Me.MenuStrip5.Text = "MenuStrip5"
        '
        'Reportes
        '
        Me.Reportes.ForeColor = System.Drawing.SystemColors.Control
        Me.Reportes.Name = "Reportes"
        Me.Reportes.Size = New System.Drawing.Size(106, 26)
        Me.Reportes.Text = "Reportes"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(11, 354)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(49, 52)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarFactura})
        Me.MenuStrip2.Location = New System.Drawing.Point(75, 370)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(176, 30)
        Me.MenuStrip2.TabIndex = 6
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'GenerarFactura
        '
        Me.GenerarFactura.ForeColor = System.Drawing.SystemColors.Control
        Me.GenerarFactura.Name = "GenerarFactura"
        Me.GenerarFactura.Size = New System.Drawing.Size(168, 26)
        Me.GenerarFactura.Text = "Generar factura"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(11, 201)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 52)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoRegistro})
        Me.MenuStrip3.Location = New System.Drawing.Point(75, 217)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(167, 30)
        Me.MenuStrip3.TabIndex = 4
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'NuevoRegistro
        '
        Me.NuevoRegistro.ForeColor = System.Drawing.SystemColors.Control
        Me.NuevoRegistro.Name = "NuevoRegistro"
        Me.NuevoRegistro.Size = New System.Drawing.Size(159, 26)
        Me.NuevoRegistro.Text = "Nuevo registro"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(11, 124)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(49, 52)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mantenimiento})
        Me.MenuStrip1.Location = New System.Drawing.Point(75, 140)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(167, 30)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Mantenimiento
        '
        Me.Mantenimiento.ForeColor = System.Drawing.SystemColors.Control
        Me.Mantenimiento.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.Mantenimiento.Name = "Mantenimiento"
        Me.Mantenimiento.Size = New System.Drawing.Size(159, 26)
        Me.Mantenimiento.Text = "Mantenimiento"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(11, 46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Principal
        '
        Me.Principal.BackColor = System.Drawing.Color.Transparent
        Me.Principal.Dock = System.Windows.Forms.DockStyle.None
        Me.Principal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrincipalToolStripMenuItem})
        Me.Principal.Location = New System.Drawing.Point(75, 62)
        Me.Principal.Name = "Principal"
        Me.Principal.Size = New System.Drawing.Size(112, 30)
        Me.Principal.TabIndex = 0
        Me.Principal.Text = "Principal"
        '
        'PrincipalToolStripMenuItem
        '
        Me.PrincipalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.PrincipalToolStripMenuItem.Name = "PrincipalToolStripMenuItem"
        Me.PrincipalToolStripMenuItem.Size = New System.Drawing.Size(104, 26)
        Me.PrincipalToolStripMenuItem.Text = "Principal"
        '
        'Salir
        '
        Me.Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Salir.BackColor = System.Drawing.Color.Transparent
        Me.Salir.Image = CType(resources.GetObject("Salir.Image"), System.Drawing.Image)
        Me.Salir.Location = New System.Drawing.Point(1134, 17)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(25, 25)
        Me.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Salir.TabIndex = 10
        Me.Salir.TabStop = False
        '
        'PanelBarra
        '
        Me.PanelBarra.BackColor = System.Drawing.Color.Black
        Me.PanelBarra.Controls.Add(Me.Label1)
        Me.PanelBarra.Controls.Add(Me.Maximizar)
        Me.PanelBarra.Controls.Add(Me.Minimizar)
        Me.PanelBarra.Controls.Add(Me.Restaurar)
        Me.PanelBarra.Controls.Add(Me.Salir)
        Me.PanelBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarra.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarra.Name = "PanelBarra"
        Me.PanelBarra.Size = New System.Drawing.Size(1175, 65)
        Me.PanelBarra.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(46, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sistema Clinico"
        '
        'Maximizar
        '
        Me.Maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Maximizar.BackColor = System.Drawing.Color.Transparent
        Me.Maximizar.BackgroundImage = CType(resources.GetObject("Maximizar.BackgroundImage"), System.Drawing.Image)
        Me.Maximizar.Image = CType(resources.GetObject("Maximizar.Image"), System.Drawing.Image)
        Me.Maximizar.Location = New System.Drawing.Point(1092, 17)
        Me.Maximizar.Name = "Maximizar"
        Me.Maximizar.Size = New System.Drawing.Size(25, 25)
        Me.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Maximizar.TabIndex = 13
        Me.Maximizar.TabStop = False
        '
        'Minimizar
        '
        Me.Minimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimizar.BackColor = System.Drawing.Color.Transparent
        Me.Minimizar.Image = CType(resources.GetObject("Minimizar.Image"), System.Drawing.Image)
        Me.Minimizar.Location = New System.Drawing.Point(1051, 17)
        Me.Minimizar.Name = "Minimizar"
        Me.Minimizar.Size = New System.Drawing.Size(25, 25)
        Me.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Minimizar.TabIndex = 12
        Me.Minimizar.TabStop = False
        '
        'Restaurar
        '
        Me.Restaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Restaurar.BackColor = System.Drawing.Color.Transparent
        Me.Restaurar.BackgroundImage = CType(resources.GetObject("Restaurar.BackgroundImage"), System.Drawing.Image)
        Me.Restaurar.Image = CType(resources.GetObject("Restaurar.Image"), System.Drawing.Image)
        Me.Restaurar.Location = New System.Drawing.Point(1092, 17)
        Me.Restaurar.Name = "Restaurar"
        Me.Restaurar.Size = New System.Drawing.Size(25, 25)
        Me.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Restaurar.TabIndex = 11
        Me.Restaurar.TabStop = False
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.PanelPrincipal.Controls.Add(Me.PanelContenedor)
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(1175, 788)
        Me.PanelPrincipal.TabIndex = 12
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelContenedor.Controls.Add(Me.LblFecha)
        Me.PanelContenedor.Controls.Add(Me.LblHora)
        Me.PanelContenedor.Location = New System.Drawing.Point(302, 65)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(871, 720)
        Me.PanelContenedor.TabIndex = 0
        '
        'LblFecha
        '
        Me.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.ForeColor = System.Drawing.SystemColors.Control
        Me.LblFecha.Location = New System.Drawing.Point(339, 365)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(72, 25)
        Me.LblFecha.TabIndex = 1
        Me.LblFecha.Text = "Fecha"
        '
        'LblHora
        '
        Me.LblHora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblHora.AutoSize = True
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblHora.Location = New System.Drawing.Point(274, 277)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(175, 73)
        Me.LblHora.TabIndex = 0
        Me.LblHora.Text = "Hora"
        '
        'HoraFecha
        '
        Me.HoraFecha.Enabled = True
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1175, 788)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelBarra)
        Me.Controls.Add(Me.PanelPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.Principal
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip6.ResumeLayout(False)
        Me.MenuStrip6.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip4.ResumeLayout(False)
        Me.MenuStrip4.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip5.ResumeLayout(False)
        Me.MenuStrip5.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Principal.ResumeLayout(False)
        Me.Principal.PerformLayout()
        CType(Me.Salir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarra.ResumeLayout(False)
        Me.PanelBarra.PerformLayout()
        CType(Me.Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Restaurar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPrincipal.ResumeLayout(False)
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Salir As PictureBox
    Friend WithEvents PanelBarra As Panel
    Friend WithEvents Minimizar As PictureBox
    Friend WithEvents Restaurar As PictureBox
    Friend WithEvents Maximizar As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Principal As MenuStrip
    Friend WithEvents PrincipalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents MenuStrip4 As MenuStrip
    Friend WithEvents ManualUsuario As ToolStripMenuItem
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents MenuStrip5 As MenuStrip
    Friend WithEvents Reportes As ToolStripMenuItem
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents GenerarFactura As ToolStripMenuItem
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents NuevoRegistro As ToolStripMenuItem
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Mantenimiento As ToolStripMenuItem
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents LblHora As Label
    Friend WithEvents HoraFecha As Timer
    Friend WithEvents LblFecha As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents MenuStrip6 As MenuStrip
    Friend WithEvents AtencionMedica As ToolStripMenuItem
End Class
