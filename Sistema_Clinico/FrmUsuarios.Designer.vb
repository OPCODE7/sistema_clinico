<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarios))
        Me.PanelUsuarios = New System.Windows.Forms.Panel()
        Me.GroupBuscar = New System.Windows.Forms.GroupBox()
        Me.ImagenBuscar = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupUsuarios = New System.Windows.Forms.GroupBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.CbmNivelAcceso = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CheckInactivo = New System.Windows.Forms.CheckBox()
        Me.CheckActivo = New System.Windows.Forms.CheckBox()
        Me.DateFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtConfirmar = New System.Windows.Forms.TextBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtEmpleado = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelUsuarios.SuspendLayout()
        Me.GroupBuscar.SuspendLayout()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupUsuarios.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelUsuarios
        '
        Me.PanelUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelUsuarios.BackColor = System.Drawing.Color.White
        Me.PanelUsuarios.Controls.Add(Me.GroupBuscar)
        Me.PanelUsuarios.Controls.Add(Me.GroupUsuarios)
        Me.PanelUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.PanelUsuarios.Name = "PanelUsuarios"
        Me.PanelUsuarios.Size = New System.Drawing.Size(871, 676)
        Me.PanelUsuarios.TabIndex = 6
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
        'GroupUsuarios
        '
        Me.GroupUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.GroupUsuarios.Controls.Add(Me.BtnEliminar)
        Me.GroupUsuarios.Controls.Add(Me.BtnEditar)
        Me.GroupUsuarios.Controls.Add(Me.BtnAgregar)
        Me.GroupUsuarios.Controls.Add(Me.CbmNivelAcceso)
        Me.GroupUsuarios.Controls.Add(Me.Label13)
        Me.GroupUsuarios.Controls.Add(Me.CheckInactivo)
        Me.GroupUsuarios.Controls.Add(Me.CheckActivo)
        Me.GroupUsuarios.Controls.Add(Me.DateFechaRegistro)
        Me.GroupUsuarios.Controls.Add(Me.TxtCorreo)
        Me.GroupUsuarios.Controls.Add(Me.TxtConfirmar)
        Me.GroupUsuarios.Controls.Add(Me.TxtContraseña)
        Me.GroupUsuarios.Controls.Add(Me.Label9)
        Me.GroupUsuarios.Controls.Add(Me.TxtUsuario)
        Me.GroupUsuarios.Controls.Add(Me.Label1)
        Me.GroupUsuarios.Controls.Add(Me.TxtEmpleado)
        Me.GroupUsuarios.Controls.Add(Me.Label14)
        Me.GroupUsuarios.Controls.Add(Me.Label12)
        Me.GroupUsuarios.Controls.Add(Me.Label8)
        Me.GroupUsuarios.Controls.Add(Me.Label5)
        Me.GroupUsuarios.Controls.Add(Me.Label2)
        Me.GroupUsuarios.Controls.Add(Me.PictureBox1)
        Me.GroupUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupUsuarios.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupUsuarios.Location = New System.Drawing.Point(53, 31)
        Me.GroupUsuarios.Name = "GroupUsuarios"
        Me.GroupUsuarios.Size = New System.Drawing.Size(762, 530)
        Me.GroupUsuarios.TabIndex = 0
        Me.GroupUsuarios.TabStop = False
        Me.GroupUsuarios.Text = "Usuarios"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Crimson
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEliminar.Location = New System.Drawing.Point(509, 422)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(116, 48)
        Me.BtnEliminar.TabIndex = 43
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnEditar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEditar.Location = New System.Drawing.Point(509, 368)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(116, 48)
        Me.BtnEditar.TabIndex = 42
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAgregar.Location = New System.Drawing.Point(509, 314)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(116, 48)
        Me.BtnAgregar.TabIndex = 41
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'CbmNivelAcceso
        '
        Me.CbmNivelAcceso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CbmNivelAcceso.FormattingEnabled = True
        Me.CbmNivelAcceso.Location = New System.Drawing.Point(83, 314)
        Me.CbmNivelAcceso.Name = "CbmNivelAcceso"
        Me.CbmNivelAcceso.Size = New System.Drawing.Size(110, 28)
        Me.CbmNivelAcceso.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label13.Location = New System.Drawing.Point(80, 285)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 18)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Nivel de acceso"
        '
        'CheckInactivo
        '
        Me.CheckInactivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckInactivo.AutoSize = True
        Me.CheckInactivo.Location = New System.Drawing.Point(160, 470)
        Me.CheckInactivo.Name = "CheckInactivo"
        Me.CheckInactivo.Size = New System.Drawing.Size(83, 24)
        Me.CheckInactivo.TabIndex = 37
        Me.CheckInactivo.Text = "Inactivo"
        Me.CheckInactivo.UseVisualStyleBackColor = True
        '
        'CheckActivo
        '
        Me.CheckActivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckActivo.AutoSize = True
        Me.CheckActivo.Location = New System.Drawing.Point(83, 470)
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
        Me.DateFechaRegistro.Location = New System.Drawing.Point(83, 390)
        Me.DateFechaRegistro.Name = "DateFechaRegistro"
        Me.DateFechaRegistro.Size = New System.Drawing.Size(200, 26)
        Me.DateFechaRegistro.TabIndex = 35
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtCorreo.Location = New System.Drawing.Point(83, 240)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(288, 26)
        Me.TxtCorreo.TabIndex = 28
        '
        'TxtConfirmar
        '
        Me.TxtConfirmar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtConfirmar.Location = New System.Drawing.Point(460, 235)
        Me.TxtConfirmar.Name = "TxtConfirmar"
        Me.TxtConfirmar.Size = New System.Drawing.Size(210, 26)
        Me.TxtConfirmar.TabIndex = 20
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtContraseña.Location = New System.Drawing.Point(460, 166)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(210, 26)
        Me.TxtContraseña.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(457, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 18)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Contraseña"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtUsuario.Location = New System.Drawing.Point(460, 95)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(210, 26)
        Me.TxtUsuario.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(80, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Empleado"
        '
        'TxtEmpleado
        '
        Me.TxtEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtEmpleado.Location = New System.Drawing.Point(83, 166)
        Me.TxtEmpleado.Name = "TxtEmpleado"
        Me.TxtEmpleado.Size = New System.Drawing.Size(288, 26)
        Me.TxtEmpleado.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label14.Location = New System.Drawing.Point(84, 441)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 18)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Estado"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label12.Location = New System.Drawing.Point(80, 363)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 18)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Fecha registro"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(457, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Confirmar contraseña"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(80, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Correo"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(457, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(83, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 676)
        Me.Controls.Add(Me.PanelUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUsuarios"
        Me.Text = "FrmUsuarios"
        Me.PanelUsuarios.ResumeLayout(False)
        Me.GroupBuscar.ResumeLayout(False)
        Me.GroupBuscar.PerformLayout()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupUsuarios.ResumeLayout(False)
        Me.GroupUsuarios.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelUsuarios As Panel
    Friend WithEvents GroupBuscar As GroupBox
    Friend WithEvents ImagenBuscar As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GroupUsuarios As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents CbmNivelAcceso As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents CheckInactivo As CheckBox
    Friend WithEvents CheckActivo As CheckBox
    Friend WithEvents DateFechaRegistro As DateTimePicker
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtConfirmar As TextBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtEmpleado As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
