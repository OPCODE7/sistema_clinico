Imports System.Data.SqlClient
Public Class FrmNuevoRegistro
    Dim connectionString As String = "Data Source=DESKTOP-FUNN0TB\MSSQLSERVER2019;Initial Catalog=Sistema_Clinico;User ID=sa;Password=12345"
    Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
    Dim reader As SqlDataReader
    Dim recordset As DataTable
    Dim cmd As SqlCommand

    Private controlesHabilitados As Boolean = False

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs)
        Dim siguienteID As Integer = ObtenerSiguienteID()
        TxtId.Text = siguienteID.ToString()
        TxtId.ReadOnly = True
        BtnGuardar.Visible = True
        BtnAgregar.Visible = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        FillEstadoCivil()
        EnabledControls()
        ClearForm()

    End Sub

    Private Sub EnabledControls()
        TxtNombre.Enabled = True
        TxtApellido.Enabled = True
        TxtIdentidad.Enabled = True
        TxtCorreo.Enabled = True
        TxtEdad.Enabled = True
        TxtDireccion.Enabled = True
        TxtTelefono.Enabled = True
        DateFechaNacimiento.Enabled = True
        DateFechaRegistro.Enabled = True
        CheckFemenino.Enabled = True
        CheckMasculino.Enabled = True
        CheckSeguroBasico.Enabled = True
        CheckPlatinum.Enabled = True
        CheckPremiun.Enabled = True
        CbmEstadoCivil.Enabled = True
    End Sub


    Private Sub StartForm()
        BtnGuardar.Visible = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        TxtId.ReadOnly = True
        TxtId.Enabled = False

        TxtNombre.Enabled = False
        TxtApellido.Enabled = False
        TxtIdentidad.Enabled = False
        TxtCorreo.Enabled = False
        TxtEdad.Enabled = False
        TxtDireccion.Enabled = False
        TxtTelefono.Enabled = False
        DateFechaNacimiento.Enabled = False
        DateFechaRegistro.Enabled = False
        CheckFemenino.Enabled = False
        CheckMasculino.Enabled = False
        CheckSeguroBasico.Enabled = False
        CheckPlatinum.Enabled = False
        CheckPremiun.Enabled = False
        CbmEstadoCivil.Enabled = False

    End Sub
    Private Sub ClearForm()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtIdentidad.Clear()
        TxtCorreo.Clear()
        TxtEdad.Clear()
        TxtDireccion.Clear()
        TxtTelefono.Clear()
        TxtBuscar.Clear()
        DateFechaNacimiento.Value = Date.Now()
        CheckFemenino.Checked = False
        CheckMasculino.Checked = False
        CheckSeguroBasico.Checked = False
        CheckPlatinum.Checked = False
        CheckPremiun.Checked = False

    End Sub

    Private Sub FillEstadoCivil()
        recordset = New DataTable()

        Try
            cmd = New SqlCommand("Select * from EstadoCivil", con)
            con.Open()

            reader = cmd.ExecuteReader()
            recordset.Load(reader)
            con.Close()
            reader.Close()
            cmd.Dispose()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        End Try


        CbmEstadoCivil.DataSource = recordset
        CbmEstadoCivil.ValueMember = "IdEstadoCivil"
        CbmEstadoCivil.DisplayMember = "Descripcion"
        CbmEstadoCivil.SelectedIndex = -1
    End Sub

    Private Function Validator() As Boolean
        Dim isvalid As Boolean = True
        If TxtNombre.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar nombre del paciente.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNombre.Focus()
            isvalid = False
        ElseIf TxtApellido.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar apellido del paciente.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtApellido.Focus()
            isvalid = False
        ElseIf TxtIdentidad.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar identidad del paciente.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtIdentidad.Focus()
            isvalid = False
        ElseIf TxtEdad.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar edad del paciente.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtEdad.Focus()
            isvalid = False
        ElseIf TxtTelefono.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar telefono del paciente.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtTelefono.Focus()
            isvalid = False
        ElseIf TxtDireccion.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar direccion del paciente.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtDireccion.Focus()
            isvalid = False
        ElseIf CheckMasculino.Checked = False And CheckFemenino.Checked = False Then
            MessageBox.Show("Por favor, seleccionar genero del paciente.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CheckMasculino.Focus()
            isvalid = False
        ElseIf CbmEstadoCivil.Text.Length = 0 Then
            MessageBox.Show("Por favor, seleccionar estado civil del paciente.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbmEstadoCivil.Focus()
            isvalid = False

        End If
        Return isvalid

    End Function

    Private Function ObtenerSiguienteID() As Integer
        Dim siguienteID As Integer = 1

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT ISNULL(MAX(IdPaciente), 0) + 1 FROM Paciente"
            Using command As New SqlCommand(query, connection)
                siguienteID = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return siguienteID
    End Function

    Private Sub PanelMante_Paint(sender As Object, e As PaintEventArgs) Handles PanelMante.Paint

    End Sub

    Private Sub CbmTurno_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmNuevoRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtDireccion.Multiline = True
        TxtDireccion.ScrollBars = ScrollBars.Vertical
        TxtDireccion.Height = 100

        PanelSeguroMedico.Visible = False
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
        con.Open()

        Dim cmd As New SqlClient.SqlCommand("DELETE FROM Paciente WHERE IdPaciente = '" + TxtId.Text + "'", con)

        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

        If rowsAffected > 0 Then
            MessageBox.Show("Registro eliminado con éxito")
            ClearForm()
            StartForm()
        Else
            MessageBox.Show("El registro no se pudo eliminar, algo falló")
        End If

        con.Close()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        FillEstadoCivil()
        LblFecha.Text = "Fecha modificacion"
        BtnEditar.Visible = False
        EnabledControls()
        TxtId.ReadOnly = True
        TxtId.Enabled = False
    End Sub

    Private Sub BtnAgregar_Click_1(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim siguienteID As Integer = ObtenerSiguienteID()
        TxtId.Text = siguienteID.ToString()
        TxtId.ReadOnly = True
        BtnGuardar.Visible = True
        BtnAgregar.Visible = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        FillEstadoCivil()
        EnabledControls()
        ClearForm()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'Dim guardarDatos As Boolean = True
        Dim seguroMedico As String = ""

        If Not (CheckSeguroBasico.Checked Or CheckPlatinum.Checked Or CheckPremiun.Checked) Then
            Dim resultado As DialogResult = MessageBox.Show("¿Este paciente no tiene seguro médico?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If resultado = DialogResult.Yes Then
                ' Si el usuario elige "Sí" en el MessageBox, mostrar el mensaje y salir del evento
                MessageBox.Show("Ingrese el seguro médico del paciente")
                Return
            End If

            ' Si el usuario elige "No" o cierra el MessageBox, se guardará el registro sin seguro médico
        Else
            ' El usuario seleccionó algún seguro médico
            If CheckSeguroBasico.Checked Then
                seguroMedico = CheckSeguroBasico.Text
            ElseIf CheckPlatinum.Checked Then
                seguroMedico = CheckPlatinum.Text
            ElseIf CheckPremiun.Checked Then
                seguroMedico = CheckPremiun.Text
            End If
        End If

        ' Validar campos antes de guardar los datos
        If Validator() Then
            Try
                con.Open()

                Dim cmd As New SqlCommand("sp_Paciente", con)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@Identificador", 1)
                cmd.Parameters.AddWithValue("@IdPaciente", ObtenerSiguienteID)
                cmd.Parameters.AddWithValue("@NombrePaciente", TxtNombre.Text)
                cmd.Parameters.AddWithValue("@ApellidoPaciente", TxtApellido.Text)
                cmd.Parameters.AddWithValue("@Identidad", TxtIdentidad.Text)
                cmd.Parameters.AddWithValue("@Edad", TxtEdad.Text)
                cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text)
                cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text)
                cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text)
                cmd.Parameters.AddWithValue("@IdEstadoCivil", CbmEstadoCivil.SelectedValue.ToString())
                cmd.Parameters.AddWithValue("@FechaRegistro", DateFechaRegistro.Value)
                cmd.Parameters.AddWithValue("@FechaModificacion", DateFechaRegistro.Value)

                Dim genero As String
                If CheckMasculino.Checked Then
                    genero = CheckMasculino.Text
                ElseIf CheckFemenino.Checked Then
                    genero = CheckFemenino.Text
                End If

                cmd.Parameters.AddWithValue("@Genero", genero)
                cmd.Parameters.AddWithValue("@SeguroMedico", seguroMedico)
                cmd.Parameters.AddWithValue("@FechaNacimiento", DateFechaNacimiento.Value)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("El registro se guardó correctamente")
                    BtnAgregar.Visible = True
                    TxtId.ReadOnly = True
                    TxtId.Enabled = False
                    ClearForm()
                    StartForm()
                Else
                    MessageBox.Show("El registro no se pudo guardar correctamente, algo falló")
                End If
            Catch ex As Exception
                MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()
            End Try

            TxtId.Text = ObtenerSiguienteID()
        End If

        CheckSeguroBasico.Focus()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Validator() Then
            con.Open()

            Dim cmd As New SqlClient.SqlCommand("Update Paciente
	                                             set IdPaciente = @IdPaciente, NombrePaciente = @NombrePaciente, ApellidoPaciente = @ApellidoPaciente, Edad = @Edad, 
	                                             Telefono = @Telefono, Direccion = @Direccion, Correo = @Correo, IdEstadoCivil = @IdEstadoCivil, 
	                                             FechaNacimiento = @FechaNacimiento, FechaModificacion = GETDATE(), Genero = @Genero, SeguroMedico = @SeguroMedico,
                                                 Identidad = @Identidad
                                                 where IdPaciente = @IdPaciente", con)

            cmd.Parameters.AddWithValue("@IdPaciente", TxtId.Text)
            cmd.Parameters.AddWithValue("@NombrePaciente", TxtNombre.Text)
            cmd.Parameters.AddWithValue("@ApellidoPaciente", TxtApellido.Text)
            cmd.Parameters.AddWithValue("@Identidad", TxtIdentidad.Text)
            cmd.Parameters.AddWithValue("@Edad", TxtEdad.Text)
            cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text)
            cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text)
            cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text)
            cmd.Parameters.AddWithValue("@IdEstadoCivil", CbmEstadoCivil.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@FechaModificacion", DateFechaRegistro.Value)

            Dim genero As String
            If CheckMasculino.Checked Then
                genero = CheckMasculino.Text
            ElseIf CheckFemenino.Checked Then
                genero = CheckFemenino.Text
            End If

            Dim seguro As String
            If CheckSeguroBasico.Checked Then
                seguro = CheckSeguroBasico.Text
            ElseIf CheckPlatinum.Checked Then
                seguro = CheckPlatinum.Text
            ElseIf CheckPremiun.Checked Then
                seguro = CheckPremiun.Text
            End If

            cmd.Parameters.AddWithValue("@Genero", genero)
            cmd.Parameters.AddWithValue("@SeguroMedico", seguro)
            cmd.Parameters.AddWithValue("@FechaNacimiento", DateFechaNacimiento.Value)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("El registro se actualizo correctamente")
                BtnEditar.Visible = True
                TxtId.ReadOnly = True
                TxtId.Enabled = False
                ClearForm()
                StartForm()
                LblFecha.Text = "Fecha registro"
            Else
                MessageBox.Show("El registro no se pudo actualizar correctamente, algo falló")
            End If

            con.Close()
        End If
    End Sub

    Private Sub ImagenBuscar_Click(sender As Object, e As EventArgs) Handles ImagenBuscar.Click
        FillEstadoCivil()

        con.Open()

        Dim cmd As New SqlCommand("SELECT A.IdPaciente,A.NombrePaciente,A.ApellidoPaciente,A.Edad,A.Telefono,
                                   A.Direccion,A.Correo,A.Genero,A.FechaNacimiento,A.FechaRegistro, A.SeguroMedico, A.Identidad, B.Descripcion 
                                   FROM Paciente A INNER JOIN EstadoCivil B ON(A.IdEstadoCivil=B.IdEstadoCivil) 
                                   WHERE NombrePaciente = '" & TxtBuscar.Text & "'", con)

        reader = cmd.ExecuteReader


        If reader.Read Then
            MessageBox.Show("Información encontrada")
            TxtBuscar.Text = ""
            StartForm()
            BtnEditar.Visible = True
            BtnEditar.Enabled = True
            BtnEliminar.Enabled = True
            BtnAgregar.Visible = True

            TxtId.Text = reader("IdPaciente").ToString()
            TxtNombre.Text = reader("NombrePaciente").ToString()
            TxtApellido.Text = reader("ApellidoPaciente").ToString()
            TxtEdad.Text = reader("Identidad").ToString()
            TxtEdad.Text = reader("Edad").ToString()
            TxtTelefono.Text = reader("Telefono").ToString()
            TxtDireccion.Text = reader("Direccion").ToString()
            TxtCorreo.Text = reader("Correo").ToString()

            DateFechaRegistro.Value = DateTime.Parse(reader("FechaRegistro").ToString())
            DateFechaRegistro.Format = DateTimePickerFormat.Custom
            DateFechaRegistro.CustomFormat = "dd/MM/yyyy"

            If reader("Genero") = "Masculino" Then
                CheckMasculino.Checked = True
            ElseIf reader("Genero") = "Femenino" Then
                CheckFemenino.Checked = True

            End If

            If reader("SeguroMedico") = "Seguro basico" Then
                CheckSeguroBasico.Checked = True
            ElseIf reader("SeguroMedico") = "Seguro platinum" Then
                CheckPlatinum.Checked = True
            ElseIf reader("SeguroMedico") = "Seguro premiun" Then
                CheckPremiun.Checked = True
            End If

            DateFechaNacimiento.Value = reader("FechaNacimiento")
            CbmEstadoCivil.Text = reader("Descripcion").ToString()

        Else
            MessageBox.Show("No existe un registro con esos datos")
        End If
        con.Close()
        cmd.Dispose()
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Dim textoBusqueda As String = TxtBuscar.Text

        ' Realizar la consulta a la base de datos para obtener las sugerencias
        Dim sugerencias As List(Of String) = ObtenerSugerencias(textoBusqueda)

        ' Configurar las sugerencias en el control TextBox utilizando AutoComplete
        TxtBuscar.AutoCompleteMode = AutoCompleteMode.Suggest
        TxtBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource

        ' Crear una colección de sugerencias
        Dim fuenteSugerencias As New AutoCompleteStringCollection()
        fuenteSugerencias.AddRange(sugerencias.ToArray())

        ' Asignar la colección de sugerencias al control TextBox
        TxtBuscar.AutoCompleteCustomSource = fuenteSugerencias
    End Sub

    Private Function ObtenerSugerencias(textoBusqueda As String) As List(Of String)
        Dim sugerencias As New List(Of String)()

        Dim query As String = "SELECT NombrePaciente FROM Paciente WHERE NombrePaciente LIKE '%' + @textoBusqueda + '%'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@textoBusqueda", textoBusqueda)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim sugerencia As String = reader("NombrePaciente").ToString()
                        sugerencias.Add(sugerencia)
                    End While
                End Using
            End Using
            connection.Close()
        End Using

        Return sugerencias
    End Function

    Private Sub CheckFemenino_CheckedChanged(sender As Object, e As EventArgs) Handles CheckFemenino.CheckedChanged

    End Sub

    Private Sub CheckFemenino_Click(sender As Object, e As EventArgs) Handles CheckFemenino.Click
        If CheckMasculino.Checked Then
            CheckMasculino.Checked = False
        End If
    End Sub

    Private Sub CheckMasculino_Click(sender As Object, e As EventArgs) Handles CheckMasculino.Click
        If CheckFemenino.Checked Then
            CheckFemenino.Checked = False
        End If
    End Sub

    Private Sub GroupNuevoRegistro_ControlAdded(sender As Object, e As ControlEventArgs) Handles GroupNuevoRegistro.ControlAdded
        ClearForm()
        StartForm()
    End Sub

    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            ImagenBuscar_Click(sender, e)
        End If
    End Sub

    'Private Sub TxtBuscar_MouseEnter(sender As Object, e As EventArgs) Handles TxtBuscar.MouseEnter
    '    If String.IsNullOrWhiteSpace(TxtBuscar.Text) OrElse TxtBuscar.Text = "Ingrese nombre del paciente" Then
    '        TxtBuscar.Text = ""
    '        TxtBuscar.ForeColor = Color.Black
    '    End If
    'End Sub

    'Private Sub TxtBuscar_MouseLeave(sender As Object, e As EventArgs) Handles TxtBuscar.MouseLeave
    '    If String.IsNullOrWhiteSpace(TxtBuscar.Text) Then
    '        TxtBuscar.Text = "Ingrese nombre del paciente"
    '        TxtBuscar.ForeColor = Color.Gray
    '    End If
    'End Sub

    Private Sub BtnSeguroMedico_Click(sender As Object, e As EventArgs) Handles BtnSeguroMedico.Click
        PanelSeguroMedico.Visible = True
    End Sub

    Private Sub BtnListo_Click(sender As Object, e As EventArgs) Handles BtnListo.Click
        PanelSeguroMedico.Visible = False
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        PanelSeguroMedico.Visible = False
    End Sub

    Private Sub CheckSeguroBasico_Click(sender As Object, e As EventArgs) Handles CheckSeguroBasico.Click
        If CheckPlatinum.Checked Then
            CheckPlatinum.Checked = False
        ElseIf CheckPremiun.Checked Then
            CheckPremiun.Checked = False
        End If
    End Sub

    Private Sub CheckPlatinum_Click(sender As Object, e As EventArgs) Handles CheckPlatinum.Click
        If CheckSeguroBasico.Checked Then
            CheckSeguroBasico.Checked = False
        ElseIf CheckPremiun.Checked Then
            CheckPremiun.Checked = False
        End If
    End Sub

    Private Sub CheckPremiun_Click(sender As Object, e As EventArgs) Handles CheckPremiun.Click
        If CheckSeguroBasico.Checked Then
            CheckSeguroBasico.Checked = False
        ElseIf CheckPlatinum.Checked Then
            CheckPlatinum.Checked = False
        End If
    End Sub
End Class