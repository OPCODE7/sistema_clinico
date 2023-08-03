<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTurnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTurnos))
        Me.PanelTurnos = New System.Windows.Forms.Panel()
        Me.GroupBuscar = New System.Windows.Forms.GroupBox()
        Me.ImagenBuscar = New System.Windows.Forms.PictureBox()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.GroupTurnos = New System.Windows.Forms.GroupBox()
        Me.TxtDias = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtHora = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CheckActivo = New System.Windows.Forms.CheckBox()
        Me.DateFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.TxtTurno = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.PanelTurnos.SuspendLayout()
        Me.GroupBuscar.SuspendLayout()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupTurnos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTurnos
        '
        Me.PanelTurnos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelTurnos.BackColor = System.Drawing.Color.White
        Me.PanelTurnos.Controls.Add(Me.GroupBuscar)
        Me.PanelTurnos.Controls.Add(Me.GroupTurnos)
        Me.PanelTurnos.Location = New System.Drawing.Point(0, 0)
        Me.PanelTurnos.Name = "PanelTurnos"
        Me.PanelTurnos.Size = New System.Drawing.Size(871, 676)
        Me.PanelTurnos.TabIndex = 8
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
        Me.ImagenBuscar.TabIndex = 42
        Me.ImagenBuscar.TabStop = False
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtBuscar.Location = New System.Drawing.Point(49, 28)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(384, 26)
        Me.TxtBuscar.TabIndex = 41
        '
        'GroupTurnos
        '
        Me.GroupTurnos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupTurnos.BackColor = System.Drawing.Color.Transparent
        Me.GroupTurnos.Controls.Add(Me.TxtDias)
        Me.GroupTurnos.Controls.Add(Me.Label3)
        Me.GroupTurnos.Controls.Add(Me.TxtHora)
        Me.GroupTurnos.Controls.Add(Me.Label2)
        Me.GroupTurnos.Controls.Add(Me.BtnEliminar)
        Me.GroupTurnos.Controls.Add(Me.Label13)
        Me.GroupTurnos.Controls.Add(Me.CheckActivo)
        Me.GroupTurnos.Controls.Add(Me.DateFechaRegistro)
        Me.GroupTurnos.Controls.Add(Me.TxtTurno)
        Me.GroupTurnos.Controls.Add(Me.TxtDescripcion)
        Me.GroupTurnos.Controls.Add(Me.Label1)
        Me.GroupTurnos.Controls.Add(Me.TxtId)
        Me.GroupTurnos.Controls.Add(Me.Label14)
        Me.GroupTurnos.Controls.Add(Me.LblFecha)
        Me.GroupTurnos.Controls.Add(Me.Label5)
        Me.GroupTurnos.Controls.Add(Me.PictureBox1)
        Me.GroupTurnos.Controls.Add(Me.BtnAgregar)
        Me.GroupTurnos.Controls.Add(Me.BtnGuardar)
        Me.GroupTurnos.Controls.Add(Me.BtnEditar)
        Me.GroupTurnos.Controls.Add(Me.BtnActualizar)
        Me.GroupTurnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupTurnos.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupTurnos.Location = New System.Drawing.Point(53, 31)
        Me.GroupTurnos.Name = "GroupTurnos"
        Me.GroupTurnos.Size = New System.Drawing.Size(762, 530)
        Me.GroupTurnos.TabIndex = 0
        Me.GroupTurnos.TabStop = False
        Me.GroupTurnos.Text = "Turnos"
        '
        'TxtDias
        '
        Me.TxtDias.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDias.Location = New System.Drawing.Point(75, 320)
        Me.TxtDias.Name = "TxtDias"
        Me.TxtDias.Size = New System.Drawing.Size(161, 26)
        Me.TxtDias.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(72, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 18)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Dias"
        '
        'TxtHora
        '
        Me.TxtHora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtHora.Location = New System.Drawing.Point(267, 320)
        Me.TxtHora.Name = "TxtHora"
        Me.TxtHora.Size = New System.Drawing.Size(134, 26)
        Me.TxtHora.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(264, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 18)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Hora"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Crimson
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEliminar.Location = New System.Drawing.Point(527, 411)
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
        Me.Label13.Location = New System.Drawing.Point(72, 196)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 18)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Descripcion"
        '
        'CheckActivo
        '
        Me.CheckActivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CheckActivo.AutoSize = True
        Me.CheckActivo.Location = New System.Drawing.Point(75, 467)
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
        Me.DateFechaRegistro.Location = New System.Drawing.Point(75, 387)
        Me.DateFechaRegistro.Name = "DateFechaRegistro"
        Me.DateFechaRegistro.Size = New System.Drawing.Size(200, 26)
        Me.DateFechaRegistro.TabIndex = 35
        '
        'TxtTurno
        '
        Me.TxtTurno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtTurno.Location = New System.Drawing.Point(75, 151)
        Me.TxtTurno.Name = "TxtTurno"
        Me.TxtTurno.Size = New System.Drawing.Size(200, 26)
        Me.TxtTurno.TabIndex = 28
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtDescripcion.Location = New System.Drawing.Point(75, 225)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(326, 49)
        Me.TxtDescripcion.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(72, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 18)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Id"
        '
        'TxtId
        '
        Me.TxtId.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtId.Location = New System.Drawing.Point(75, 77)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(56, 26)
        Me.TxtId.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label14.Location = New System.Drawing.Point(76, 438)
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
        Me.LblFecha.Location = New System.Drawing.Point(72, 360)
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
        Me.Label5.Location = New System.Drawing.Point(72, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Turno"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(450, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(239, 238)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnAgregar.Location = New System.Drawing.Point(527, 303)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(116, 48)
        Me.BtnAgregar.TabIndex = 45
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnGuardar.Location = New System.Drawing.Point(527, 303)
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
        Me.BtnEditar.Location = New System.Drawing.Point(527, 357)
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
        Me.BtnActualizar.Location = New System.Drawing.Point(527, 357)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(116, 48)
        Me.BtnActualizar.TabIndex = 46
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'FrmTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 676)
        Me.Controls.Add(Me.PanelTurnos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTurnos"
        Me.Text = "FrmTurnos"
        Me.PanelTurnos.ResumeLayout(False)
        Me.GroupBuscar.ResumeLayout(False)
        Me.GroupBuscar.PerformLayout()
        CType(Me.ImagenBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupTurnos.ResumeLayout(False)
        Me.GroupTurnos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTurnos As Panel
    Friend WithEvents GroupBuscar As GroupBox
    Friend WithEvents ImagenBuscar As PictureBox
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents GroupTurnos As GroupBox
    Friend WithEvents TxtDias As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtHora As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents CheckActivo As CheckBox
    Friend WithEvents DateFechaRegistro As DateTimePicker
    Friend WithEvents TxtTurno As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnGuardar As Button
End Class
