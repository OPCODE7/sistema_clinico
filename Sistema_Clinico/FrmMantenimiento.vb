Public Class FrmMantenimiento

    Private FormularioA As Form = Nothing
    Private ContenidoPanel As Control = Nothing

    Private frmMedicos As FrmMedicos = Nothing
    Private frmEmpleados As FrmEmpleados = Nothing
    Private frmUsuarios As FrmUsuarios = Nothing
    Private frmEspecialidad As FrmEspecialidad = Nothing
    Private frmRol As FrmRol = Nothing
    Private frmTurnos As FrmTurnos = Nothing
    Private frmMedicamento As FrmMedicamento = Nothing
    Private frmServicioClinico As FrmServicioClinico = Nothing
    Private frmTipoExamen As FrmTipoExamen = Nothing
    Private frmEquipoMedico As FrmEquipoMedico = Nothing
    Private frmProveedores As FrmProveedores = Nothing
    Private frmDescuento As FrmDescuento = Nothing

    Private Sub MostrarFormularioEnPanel(formulario As Form)
        ' Ocultar el formulario actual en el PanelConte, si hay uno
        If FormularioA IsNot Nothing Then
            FormularioA.Hide()
        End If

        ' Guardar el contenido actual del PanelConte antes de agregar el formulario
        ContenidoPanel = If(PanelConte.Controls.Count > 0, PanelConte.Controls(0), Nothing)

        ' Establecer las propiedades para que el formulario se pueda mostrar dentro del PanelConte
        formulario.TopLevel = False
        formulario.FormBorderStyle = FormBorderStyle.None
        formulario.Dock = DockStyle.Fill

        ' Agregar el formulario al PanelConte
        PanelConte.Controls.Clear()
        PanelConte.Controls.Add(formulario)

        ' Mostrar el formulario
        formulario.Show()

        ' Actualizar el formulario actual en el PanelConte
        FormularioA = formulario

    End Sub

    Private Sub PanelMantenimiento_Paint(sender As Object, e As PaintEventArgs) Handles PanelMante.Paint
    End Sub

    Private Sub FrmMantenimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
        Me.UpdateStyles()
    End Sub

    Private Sub BtnMedicos_Click(sender As Object, e As EventArgs) Handles BtnMedicos.Click

        ' Verificar si ya se creó una instancia del formulario frmMedicos
        If frmMedicos Is Nothing Then
            frmMedicos = New FrmMedicos() ' Si no existe, crear una nueva instancia
        End If

        MostrarFormularioEnPanel(frmMedicos)

        PanelMante.Visible = False
        PanelTexto.Visible = True
        BtnSalir.Visible = True
        PanelTexto.BackColor = Color.SteelBlue
    End Sub

    Private Sub BtnEmpleados_Click(sender As Object, e As EventArgs) Handles BtnEmpleados.Click
        If frmEmpleados Is Nothing Then
            frmEmpleados = New FrmEmpleados()
        End If

        MostrarFormularioEnPanel(frmEmpleados)

        PanelMante.Visible = False
        PanelTexto.Visible = True
        BtnSalir.Visible = True
        PanelTexto.BackColor = Color.SteelBlue
    End Sub

    Private Sub BtnSalir_Click_1(sender As Object, e As EventArgs) Handles BtnSalir.Click
        If frmMedicos IsNot Nothing AndAlso frmMedicos.Parent Is PanelConte Then
            ' Ocultar y cerrar el formulario actual
            frmMedicos.Hide()
            frmMedicos.Close()
            frmMedicos = Nothing

            If ContenidoPanel IsNot Nothing Then
                PanelConte.Controls.Clear()
                PanelConte.Controls.Add(ContenidoPanel)
            End If

        ElseIf frmEmpleados IsNot Nothing AndAlso frmEmpleados.Parent Is PanelConte Then
            frmEmpleados.Hide()
            frmEmpleados.Close()
            frmEmpleados = Nothing

            If ContenidoPanel IsNot Nothing Then
                PanelConte.Controls.Clear()
                PanelConte.Controls.Add(ContenidoPanel)
            End If

        ElseIf frmUsuarios IsNot Nothing AndAlso frmUsuarios.Parent Is PanelConte Then
            frmUsuarios.Hide()
            frmUsuarios.Close()
            frmUsuarios = Nothing

            If ContenidoPanel IsNot Nothing Then
                PanelConte.Controls.Clear()
                PanelConte.Controls.Add(ContenidoPanel)
            End If

        ElseIf frmEspecialidad IsNot Nothing AndAlso frmEspecialidad.Parent Is PanelConte Then
            frmEspecialidad.Hide()
            frmEspecialidad.Close()
            frmEspecialidad = Nothing

            If ContenidoPanel IsNot Nothing Then
                PanelConte.Controls.Clear()
                PanelConte.Controls.Add(ContenidoPanel)
            End If

        ElseIf frmRol IsNot Nothing AndAlso frmRol.Parent Is PanelConte Then
            frmRol.Hide()
            frmRol.Close()
            frmRol = Nothing

            If ContenidoPanel IsNot Nothing Then
                PanelConte.Controls.Clear()
                PanelConte.Controls.Add(ContenidoPanel)
            End If

        ElseIf frmTurnos IsNot Nothing AndAlso frmTurnos.Parent Is PanelConte Then
            frmTurnos.Hide()
            frmTurnos.Close()
            frmTurnos = Nothing

            If ContenidoPanel IsNot Nothing Then
                PanelConte.Controls.Clear()
                PanelConte.Controls.Add(ContenidoPanel)
            End If

        ElseIf frmMedicamento IsNot Nothing AndAlso frmMedicamento.Parent Is PanelConte Then
            frmMedicamento.Hide()
            frmMedicamento.Close()
            frmMedicamento = Nothing

            If ContenidoPanel IsNot Nothing Then
                PanelConte.Controls.Clear()
                PanelConte.Controls.Add(ContenidoPanel)
            End If

        ElseIf frmServicioClinico IsNot Nothing AndAlso frmServicioClinico.Parent Is PanelConte Then
            frmServicioClinico.Hide()
            frmServicioClinico.Close()
            frmServicioClinico = Nothing

            If ContenidoPanel IsNot Nothing Then
                PanelConte.Controls.Clear()
                PanelConte.Controls.Add(ContenidoPanel)
            End If

        ElseIf frmTipoExamen IsNot Nothing AndAlso frmTipoExamen.Parent Is PanelConte Then
            frmTipoExamen.Hide()
            frmTipoExamen.Close()
            frmTipoExamen = Nothing

            If ContenidoPanel IsNot Nothing Then
                PanelConte.Controls.Clear()
                PanelConte.Controls.Add(ContenidoPanel)
            End If

        ElseIf frmEquipoMedico IsNot Nothing AndAlso frmEquipoMedico.Parent Is PanelConte Then
            frmEquipoMedico.Hide()
            frmEquipoMedico.Close()
            frmEquipoMedico = Nothing

            If ContenidoPanel IsNot Nothing Then
                PanelConte.Controls.Clear()
                PanelConte.Controls.Add(ContenidoPanel)
            End If

        ElseIf frmProveedores IsNot Nothing AndAlso frmProveedores.Parent Is PanelConte Then
            frmProveedores.Hide()
            frmProveedores.Close()
            frmProveedores = Nothing

            If ContenidoPanel IsNot Nothing Then
                PanelConte.Controls.Clear()
                PanelConte.Controls.Add(ContenidoPanel)
            End If

        ElseIf frmDescuento IsNot Nothing AndAlso frmDescuento.Parent Is PanelConte Then
            frmDescuento.Hide()
            frmDescuento.Close()
            frmDescuento = Nothing

            If ContenidoPanel IsNot Nothing Then
                PanelConte.Controls.Clear()
                PanelConte.Controls.Add(ContenidoPanel)
            End If
        End If

        PanelMante.Visible = True
        PanelTexto.BackColor = Color.White
        BtnSalir.Visible = False

    End Sub

    Private Sub PanelTexto_Paint(sender As Object, e As PaintEventArgs) Handles PanelTexto.Paint

    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) 
        If frmUsuarios Is Nothing Then
            frmUsuarios = New FrmUsuarios()
        End If

        MostrarFormularioEnPanel(frmUsuarios)

        PanelMante.Visible = False
        PanelTexto.Visible = True
        BtnSalir.Visible = True
        PanelTexto.BackColor = Color.SteelBlue
    End Sub

    Private Sub BtnEspecialidad_Click(sender As Object, e As EventArgs) Handles BtnEspecialidad.Click
        If frmEspecialidad Is Nothing Then
            frmEspecialidad = New FrmEspecialidad()
        End If

        MostrarFormularioEnPanel(frmEspecialidad)

        PanelMante.Visible = False
        PanelTexto.Visible = True
        BtnSalir.Visible = True
        PanelTexto.BackColor = Color.SteelBlue
    End Sub

    Private Sub BtnRolEmpleado_Click(sender As Object, e As EventArgs) Handles BtnRolEmpleado.Click
        If frmRol Is Nothing Then
            frmRol = New FrmRol()
        End If

        MostrarFormularioEnPanel(frmRol)

        PanelMante.Visible = False
        PanelTexto.Visible = True
        BtnSalir.Visible = True
        PanelTexto.BackColor = Color.SteelBlue
    End Sub

    Private Sub BtnTurnos_Click(sender As Object, e As EventArgs) Handles BtnTurnos.Click
        If frmTurnos Is Nothing Then
            frmTurnos = New FrmTurnos()
        End If

        MostrarFormularioEnPanel(frmTurnos)

        PanelMante.Visible = False
        PanelTexto.Visible = True
        BtnSalir.Visible = True
        PanelTexto.BackColor = Color.SteelBlue
    End Sub

    Private Sub BtnMedicamentos_Click(sender As Object, e As EventArgs) Handles BtnMedicamentos.Click
        If frmMedicamento Is Nothing Then
            frmMedicamento = New FrmMedicamento()
        End If

        MostrarFormularioEnPanel(frmMedicamento)

        PanelMante.Visible = False
        PanelTexto.Visible = True
        BtnSalir.Visible = True
        PanelTexto.BackColor = Color.SteelBlue
    End Sub

    Private Sub BtnServicios_Click(sender As Object, e As EventArgs) Handles BtnServicios.Click
        If frmServicioClinico Is Nothing Then
            frmServicioClinico = New FrmServicioClinico()
        End If

        MostrarFormularioEnPanel(frmServicioClinico)

        PanelMante.Visible = False
        PanelTexto.Visible = True
        BtnSalir.Visible = True
        PanelTexto.BackColor = Color.SteelBlue
    End Sub

    Private Sub BtnTipoExamen_Click(sender As Object, e As EventArgs) Handles BtnTipoExamen.Click
        If frmTipoExamen Is Nothing Then
            frmTipoExamen = New FrmTipoExamen()
        End If

        MostrarFormularioEnPanel(frmTipoExamen)

        PanelMante.Visible = False
        PanelTexto.Visible = True
        BtnSalir.Visible = True
        PanelTexto.BackColor = Color.SteelBlue
    End Sub

    Private Sub BtnEquipoMedico_Click(sender As Object, e As EventArgs) Handles BtnEquipoMedico.Click
        If frmEquipoMedico Is Nothing Then
            frmEquipoMedico = New FrmEquipoMedico()
        End If

        MostrarFormularioEnPanel(frmEquipoMedico)

        PanelMante.Visible = False
        PanelTexto.Visible = True
        BtnSalir.Visible = True
        PanelTexto.BackColor = Color.SteelBlue
    End Sub

    Private Sub BtnProveedores_Click(sender As Object, e As EventArgs) Handles BtnProveedores.Click
        If frmProveedores Is Nothing Then
            frmProveedores = New FrmProveedores()
        End If

        MostrarFormularioEnPanel(frmProveedores)

        PanelMante.Visible = False
        PanelTexto.Visible = True
        BtnSalir.Visible = True
        PanelTexto.BackColor = Color.SteelBlue
    End Sub

    Private Sub BtnSeguroMedico_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub BtnDescuentos_Click(sender As Object, e As EventArgs) Handles BtnDescuentos.Click
        If frmDescuento Is Nothing Then
            frmDescuento = New FrmDescuento()
        End If

        MostrarFormularioEnPanel(frmDescuento)

        PanelMante.Visible = False
        PanelTexto.Visible = True
        BtnSalir.Visible = True
        PanelTexto.BackColor = Color.SteelBlue
    End Sub

    'Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
    '    Dim panelMedicos As Panel = FrmMedicos.PanelMedicos
    '    Dim panelEmpleados As Panel = FrmEmpleados.PanelEmpleados

    '    If panelMedicos.Visible Then
    '        panelMedicos.Visible = False
    '    ElseIf panelEmpleados.Visible Then
    '        panelEmpleados.Visible = False
    '    End If

    'End Sub
End Class