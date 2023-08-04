Public Class FrmMenu

    'Private MenuVisible As Boolean = False
    Private Movimiento As Boolean = False
    Private UbicacionInicial As Point

    Dim frmMantenimiento As New FrmMantenimiento()
    Dim frmNuevoRegistro As New FrmNuevoRegistro()
    Dim frmAtencionMedica As New FrmAtencionMedica()
    Dim frmFactura As New FrmFactura()

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Panel1.Visible = False
        PanelBarra.BackColor = Color.FromArgb(95, 0, 0, 0)
        Panel1.BackColor = Color.FromArgb(95, 0, 0, 0)

        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
        Me.UpdateStyles()

    End Sub

    Private Sub FrmMenu_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            Maximizar.Visible = False
            Restaurar.Visible = True
        Else
            Maximizar.Visible = True
            Restaurar.Visible = False
        End If
    End Sub

    Private Sub MostrarMenu1_Click(sender As Object, e As EventArgs)
        'Panel1.Visible = True

        'If MenuVisible Then
        '    Panel1.Visible = False
        'Else
        '    Panel1.Location = New Point(MostrarMenu1.Left, MostrarMenu1.Height)
        'End If

        'MenuVisible = Not MenuVisible
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Application.Exit()
    End Sub

    Private Sub Restaurar_Click(sender As Object, e As EventArgs) Handles Restaurar.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Maximizar_Click(sender As Object, e As EventArgs) Handles Maximizar.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Minimizar_Click(sender As Object, e As EventArgs) Handles Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelBarra_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBarra.MouseDown
        If e.Button = MouseButtons.Left Then
            Movimiento = True
            UbicacionInicial = e.Location
        End If
    End Sub

    Private Sub PanelBarra_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarra.MouseMove
        If Movimiento Then
            Dim screenPoint As Point = PointToScreen(e.Location)
            Location = New Point(screenPoint.X - UbicacionInicial.X, screenPoint.Y - UbicacionInicial.Y)
        End If
    End Sub

    Private Sub PanelBarra_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelBarra.MouseUp
        Movimiento = False
    End Sub

    Private Sub Mantenimiento_Click(sender As Object, e As EventArgs) Handles Mantenimiento.Click

        PictureBox1.Visible = False

        If frmMantenimiento Is Nothing Then
            frmMantenimiento = New FrmMantenimiento()
        End If

        Dim panelMantenimiento As Panel = frmMantenimiento.PanelMantenimiento
        Dim panelTexto As Panel = frmMantenimiento.PanelTexto
        Dim btnSalir As Button = frmMantenimiento.BtnSalir

        panelMantenimiento.Dock = DockStyle.Fill
        PanelContenedor.Controls.Clear()
        PanelContenedor.Controls.Add(Nothing)
        PanelContenedor.Controls.Add(panelMantenimiento)
        panelMantenimiento.BackColor = Color.White
        panelMantenimiento.BackColor = Color.FromArgb(50, 0, 0, 0)
        panelTexto.BackColor = Color.White
        btnSalir.Visible = False

    End Sub

    Private Sub PrincipalToolStripMenuItem_MouseEnter(sender As Object, e As EventArgs) Handles PrincipalToolStripMenuItem.MouseEnter
        PrincipalToolStripMenuItem.ForeColor = Color.Black
    End Sub

    Private Sub PrincipalToolStripMenuItem_MouseLeave(sender As Object, e As EventArgs) Handles PrincipalToolStripMenuItem.MouseLeave
        PrincipalToolStripMenuItem.ForeColor = Color.White
    End Sub

    Private Sub Reportes_Click(sender As Object, e As EventArgs) Handles Reportes.Click

    End Sub

    Private Sub Mantenimiento_MouseEnter(sender As Object, e As EventArgs) Handles Mantenimiento.MouseEnter
        Mantenimiento.ForeColor = Color.Black
    End Sub

    Private Sub Mantenimiento_MouseLeave(sender As Object, e As EventArgs) Handles Mantenimiento.MouseLeave
        Mantenimiento.ForeColor = Color.White
    End Sub

    Private Sub NuevoRegistro_MouseEnter(sender As Object, e As EventArgs) Handles NuevoRegistro.MouseEnter
        NuevoRegistro.ForeColor = Color.Black
    End Sub

    Private Sub NuevoRegistro_MouseLeave(sender As Object, e As EventArgs) Handles NuevoRegistro.MouseLeave
        NuevoRegistro.ForeColor = Color.White
    End Sub

    Private Sub GenerarFactura_MouseEnter(sender As Object, e As EventArgs) Handles GenerarFactura.MouseEnter
        GenerarFactura.ForeColor = Color.Black
    End Sub

    Private Sub GenerarFactura_MouseLeave(sender As Object, e As EventArgs) Handles GenerarFactura.MouseLeave
        GenerarFactura.ForeColor = Color.White
    End Sub

    Private Sub Reportes_MouseEnter(sender As Object, e As EventArgs) Handles Reportes.MouseEnter
        Reportes.ForeColor = Color.Black
    End Sub

    Private Sub Reportes_MouseLeave(sender As Object, e As EventArgs) Handles Reportes.MouseLeave
        Reportes.ForeColor = Color.White
    End Sub

    Private Sub ManualUsuario_MouseEnter(sender As Object, e As EventArgs) Handles ManualUsuario.MouseEnter
        ManualUsuario.ForeColor = Color.Black
    End Sub

    Private Sub ManualUsuario_MouseLeave(sender As Object, e As EventArgs) Handles ManualUsuario.MouseLeave
        ManualUsuario.ForeColor = Color.White
    End Sub

    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub

    Private Sub HoraFecha_Tick(sender As Object, e As EventArgs) Handles HoraFecha.Tick
        LblHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LblFecha.Text = DateTime.Now.ToString("dddd MMMM yyy")
    End Sub

    Private Sub PrincipalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrincipalToolStripMenuItem.Click

        PictureBox1.Visible = True
        PanelContenedor.Controls.Clear()
        PanelContenedor.Controls.Add(LblHora)
        PanelContenedor.Controls.Add(LblFecha)

    End Sub

    Private Sub NuevoRegistro_Click(sender As Object, e As EventArgs) Handles NuevoRegistro.Click
        PictureBox1.Visible = False

        FrmNuevoRegistro.TopLevel = False
        frmNuevoRegistro.Dock = DockStyle.Fill
        PanelContenedor.Controls.Clear()
        PanelContenedor.Controls.Add(frmNuevoRegistro)

        frmNuevoRegistro.Show()
    End Sub

    Private Sub GenerarFactura_Click(sender As Object, e As EventArgs) Handles GenerarFactura.Click
        PictureBox1.Visible = False

        frmFactura.TopLevel = False
        frmFactura.Dock = DockStyle.Fill

        PanelContenedor.Controls.Clear()
        PanelContenedor.Controls.Add(frmFactura)

        frmFactura.Show()
    End Sub

    Private Sub AtencionMedica_Click(sender As Object, e As EventArgs) Handles AtencionMedica.Click
        PictureBox1.Visible = False

        frmAtencionMedica.TopLevel = False
        frmAtencionMedica.Dock = DockStyle.Fill

        PanelContenedor.Controls.Clear()
        PanelContenedor.Controls.Add(frmAtencionMedica)

        frmAtencionMedica.Show()
    End Sub

    Private Sub ManualUsuario_Click(sender As Object, e As EventArgs) Handles ManualUsuario.Click
        Try
            ' Ruta del archivo del manual de usuario
            Dim pathApp As String = Application.StartupPath.ToString()
            Dim pathFile As String = pathApp.Substring(0, pathApp.Length - 9) + "ManualdeUsuario_SistemaClinico.pdf"
            MessageBox.Show(pathFile)
            ' Abrir el manual de usuario utilizando el programa predeterminado
            Process.Start(pathFile)
        Catch ex As Exception
            MessageBox.Show("Error al abrir el manual de usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class