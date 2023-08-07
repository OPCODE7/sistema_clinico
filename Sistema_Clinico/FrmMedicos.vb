Imports System.Data.SqlClient
Public Class FrmMedicos
    Dim connectionString As String = "Data Source=OPCODE;Initial Catalog=Sistema_Clinico;User ID=opcode;Password=opcode7"
    Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
    Dim reader As SqlDataReader
    Dim recordset As DataTable
    Dim cmd As SqlCommand

    Private controlesHabilitados As Boolean = False

    Private Sub EnabledControls()
        TxtNombre.Enabled = True
        TxtApellido.Enabled = True
        TxtIdentidad.Enabled = True
        TxtEdad.Enabled = True
        TxtTelefono.Enabled = True
        TxtCorreo.Enabled = True
        TxtDireccion.Enabled = True
        CheckFemenino.Enabled = True
        CheckMasculino.Enabled = True
        CbmEstadoCivil.Enabled = True
        CbmEspecialidad.Enabled = True
        CbmTurno.Enabled = True
        DateFechaNacimiento.Enabled = True
        DateFechaRegistro.Enabled = True
        CheckActivo.Enabled = True
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
        TxtEdad.Enabled = False
        TxtTelefono.Enabled = False
        TxtCorreo.Enabled = False
        TxtDireccion.Enabled = False
        CheckFemenino.Enabled = False
        CheckMasculino.Enabled = False
        CbmEstadoCivil.Enabled = False
        CbmEspecialidad.Enabled = False
        CbmTurno.Enabled = False
        DateFechaNacimiento.Enabled = False
        DateFechaRegistro.Enabled = False
        CheckActivo.Enabled = False

    End Sub
    Private Sub ClearForm()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtIdentidad.Clear()
        TxtEdad.Clear()
        TxtTelefono.Clear()
        TxtCorreo.Clear()
        TxtDireccion.Clear()
        DateFechaNacimiento.Value = Date.Now()
        CheckFemenino.Checked = False
        CheckMasculino.Checked = False
        CheckActivo.Checked = False
    End Sub

    Private Function Validator() As Boolean
        Dim isvalid As Boolean = True
        If TxtNombre.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar nombre del medico.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNombre.Focus()
            isvalid = False
        ElseIf TxtApellido.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar apellido del medico.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtApellido.Focus()
            isvalid = False
        ElseIf TxtIdentidad.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar identidad del medico.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtIdentidad.Focus()
            isvalid = False
        ElseIf TxtEdad.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar edad del medico.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtEdad.Focus()
            isvalid = False
        ElseIf TxtTelefono.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar telefono del medico.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtTelefono.Focus()
            isvalid = False
        ElseIf TxtCorreo.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar correo del medico.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtCorreo.Focus()
            isvalid = False
        ElseIf TxtDireccion.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar direccion del medico.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtDireccion.Focus()
            isvalid = False
        ElseIf CheckMasculino.Checked = False And CheckFemenino.Checked = False Then
            MessageBox.Show("Por favor, seleccionar genero del medico.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CheckMasculino.Focus()
            isvalid = False
        ElseIf CbmEstadoCivil.Text.Length = 0 Then
            MessageBox.Show("Por favor, seleccionar estado civil del medico.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbmEstadoCivil.Focus()
            isvalid = False
        ElseIf CbmEspecialidad.Text.Length = 0 Then
            MessageBox.Show("Por favor, seleccionar especialidad del medico.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbmEspecialidad.Focus()
            isvalid = False
        ElseIf CbmTurno.Text.Length = 0 Then
            MessageBox.Show("Por favor, seleccionar turno del medico.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbmTurno.Focus()
            isvalid = False
        End If
        Return isvalid
    End Function

    Private Function ObtenerSiguienteID() As Integer
        Dim siguienteID As Integer = 1

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT ISNULL(MAX(IdMedico), 0) + 1 FROM Medico"
            Using command As New SqlCommand(query, connection)
                siguienteID = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return siguienteID
    End Function

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

    Private Sub FillEspecialidad()
        recordset = New DataTable()

        Try
            cmd = New SqlCommand("Select * from Especialidad", con)
            con.Open()

            reader = cmd.ExecuteReader()
            recordset.Load(reader)
            con.Close()
            reader.Close()
            cmd.Dispose()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        End Try


        CbmEspecialidad.DataSource = recordset
        CbmEspecialidad.ValueMember = "IdEspecialidad"
        CbmEspecialidad.DisplayMember = "Especialidad"
        CbmEspecialidad.SelectedIndex = -1
    End Sub

    Private Sub FillTurno()
        recordset = New DataTable()

        Try
            cmd = New SqlCommand("Select * from Turnos", con)
            con.Open()

            reader = cmd.ExecuteReader()
            recordset.Load(reader)
            con.Close()
            reader.Close()
            cmd.Dispose()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        End Try


        CbmTurno.DataSource = recordset
        CbmTurno.ValueMember = "IdTurno"
        CbmTurno.DisplayMember = "Turno"
        CbmTurno.SelectedIndex = -1
    End Sub

    Private Sub CbmTurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbmTurno.SelectedIndexChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub GroupEmpleados_Enter(sender As Object, e As EventArgs) Handles GroupMedicos.Enter

    End Sub

    Private Sub FrmMedicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtDireccion.Multiline = True
        TxtDireccion.ScrollBars = ScrollBars.Vertical
        TxtDireccion.Height = 100
    End Sub

    Private Sub GroupBuscar_Enter(sender As Object, e As EventArgs) Handles GroupBuscar.Enter

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim siguienteID As Integer = ObtenerSiguienteID()
        TxtId.Text = siguienteID.ToString()
        TxtId.ReadOnly = True
        BtnGuardar.Visible = True
        BtnAgregar.Visible = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        FillEstadoCivil()
        FillEspecialidad()
        FillTurno()
        EnabledControls()
        ClearForm()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Validator() Then
            con.Open()

            Dim cmd As New SqlClient.SqlCommand("sp_Medico", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Identificador", 1)
            cmd.Parameters.AddWithValue("@IdMedico", ObtenerSiguienteID)
            cmd.Parameters.AddWithValue("@NombreMedico", TxtNombre.Text)
            cmd.Parameters.AddWithValue("@ApellidoMedico", TxtApellido.Text)
            cmd.Parameters.AddWithValue("@Identidad", TxtIdentidad.Text)
            cmd.Parameters.AddWithValue("@Edad", TxtEdad.Text)
            cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text)
            cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text)
            cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text)
            cmd.Parameters.AddWithValue("@IdEstadoCivil", CbmEstadoCivil.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@IdEspecialidad", CbmEspecialidad.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@IdTurno", CbmTurno.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@FechaNacimiento", DateFechaNacimiento.Value)
            cmd.Parameters.AddWithValue("@FechaRegistro", DateFechaRegistro.Value)
            cmd.Parameters.AddWithValue("@FechaModificacion", DateFechaRegistro.Value)
            cmd.Parameters.AddWithValue("@Estado", If(CheckActivo.Checked, 1, 0))


            Dim genero As String
            If CheckMasculino.Checked Then
                genero = 2
            ElseIf CheckFemenino.Checked Then
                genero = 1
            End If

            cmd.Parameters.AddWithValue("@IdGenero", genero)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("El registro se guardo correctamente")
                BtnAgregar.Visible = True
                TxtId.ReadOnly = True
                TxtId.Enabled = False
                ClearForm()
                StartForm()
            Else
                MessageBox.Show("El registro no se pudo guardar correctamente, algo falló")
            End If

            con.Close()

            TxtId.Text = ObtenerSiguienteID()
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        FillEstadoCivil()
        FillEspecialidad()
        FillTurno()
        LblFecha.Text = "Fecha modificacion"
        BtnEditar.Visible = False
        EnabledControls()
        TxtId.ReadOnly = True
        TxtId.Enabled = False
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Validator() Then
            con.Open()

            Dim cmd As New SqlClient.SqlCommand("UPDATE Medico
	                                             SET IdMedico = @IdMedico, NombreMedico = @NombreMedico, ApellidoMedico = @ApellidoMedico, 
                                                 Edad = @Edad, Telefono = @Telefono, Direccion = @Direccion, Correo = @Correo, 
                                                 IdEstadoCivil = @IdEstadoCivil, IdEspecialidad = @IdEspecialidad, IdTurno = @IdTurno, 
                                                 FechaNacimiento = @FechaNacimiento, FechaModificacion = GETDATE(), Estado = @Estado, 
                                                 IdGenero = @Genero, Identidad = @Identidad
                                                 WHERE IdMedico = @IdMedico", con)

            cmd.Parameters.AddWithValue("@IdMedico", TxtId.Text)
            cmd.Parameters.AddWithValue("@NombreMedico", TxtNombre.Text)
            cmd.Parameters.AddWithValue("@ApellidoMedico", TxtApellido.Text)
            cmd.Parameters.AddWithValue("@Identidad", TxtIdentidad.Text)
            cmd.Parameters.AddWithValue("@Edad", TxtEdad.Text)
            cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text)
            cmd.Parameters.AddWithValue("@Direccion", TxtDireccion.Text)
            cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text)
            cmd.Parameters.AddWithValue("@IdEstadoCivil", CbmEstadoCivil.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@IdEspecialidad", CbmEspecialidad.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@IdTurno", CbmTurno.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@FechaNacimiento", DateFechaNacimiento.Value)
            cmd.Parameters.AddWithValue("@FechaModificacion", DateFechaRegistro.Value)
            cmd.Parameters.AddWithValue("@Estado", If(CheckActivo.Checked, 1, 0))

            Dim genero As String
            If CheckMasculino.Checked Then
                genero = 2
            ElseIf CheckFemenino.Checked Then
                genero = 1
            End If

            cmd.Parameters.AddWithValue("@Genero", genero)

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
        FillEspecialidad()
        FillTurno()

        con.Open()

        Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("Select A.IdMedico, A.NombreMedico, A.ApellidoMedico, A.Edad, A.Telefono,A.Direccion, A.Correo, A.IdEstadoCivil, A.IdEspecialidad, A.IdTurno, A.FechaNacimiento,A.FechaRegistro, A.Estado, E.Descripcion As Genero, A.Identidad, B.Descripcion, C.Especialidad, D.Turno From Medico A INNER JOIN EstadoCivil B ON(A.IdEstadoCivil = B.IdEstadoCivil) INNER JOIN   Especialidad C ON(A.IdEspecialidad = C.IdEspecialidad) INNER JOIN Turnos D ON(A.IdTurno = D.IdTurno) INNER JOIN Genero E ON (A.IdGenero=E.IdGenero)
         WHERE NombreMedico = '" & TxtBuscar.Text & "'", con)

        reader = cmd.ExecuteReader

        If reader.Read Then
            MessageBox.Show("Información encontrada")
            BtnEditar.Enabled = True
            BtnEliminar.Enabled = True
            BtnAgregar.Visible = True
            TxtBuscar.Text = ""

            TxtId.Text = reader("IdMedico").ToString()
            TxtNombre.Text = reader("NombreMedico").ToString()
            TxtApellido.Text = reader("ApellidoMedico").ToString()
            TxtIdentidad.Text = reader("Identidad").ToString()
            TxtEdad.Text = reader("Edad").ToString()
            TxtTelefono.Text = reader("Telefono").ToString()
            TxtDireccion.Text = reader("Direccion").ToString()
            TxtCorreo.Text = reader("Correo").ToString()
            CbmEstadoCivil.Text = reader("Descripcion").ToString()
            CbmEspecialidad.Text = reader("Especialidad").ToString()
            CbmTurno.Text = reader("Turno").ToString()
            DateFechaRegistro.Value = DateTime.Parse(reader("FechaRegistro").ToString())
            DateFechaRegistro.Format = DateTimePickerFormat.Custom
            DateFechaRegistro.CustomFormat = "dd/MM/yyyy"

            If reader("Genero") = "Masculino" Then
                CheckMasculino.Checked = True
            ElseIf reader("Genero") = "Femenino" Then
                CheckFemenino.Checked = True

            End If
            DateFechaNacimiento.Value = reader("FechaNacimiento")

            Dim estado As Integer = Convert.ToInt32(reader("Estado"))
            CheckActivo.Checked = (estado = 1)

        Else
            MessageBox.Show("No existe un registro con esos datos")
        End If

        con.Close()
        cmd.Dispose()
    End Sub

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

        Dim query As String = "SELECT NombreMedico FROM Medico WHERE NombreMedico LIKE '%' + @textoBusqueda + '%'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@textoBusqueda", textoBusqueda)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim sugerencia As String = reader("NombreMedico").ToString()
                        sugerencias.Add(sugerencia)
                    End While
                End Using
            End Using
            connection.Close()
        End Using

        Return sugerencias
    End Function

    Private Sub GroupMedicos_ControlAdded(sender As Object, e As ControlEventArgs) Handles GroupMedicos.ControlAdded
        ClearForm()
        StartForm()
    End Sub

    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            ImagenBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub TxtBuscar_MouseEnter(sender As Object, e As EventArgs) Handles TxtBuscar.MouseEnter
        If String.IsNullOrWhiteSpace(TxtBuscar.Text) OrElse TxtBuscar.Text = "Ingrese el nombre del medico" Then
            TxtBuscar.Text = ""
            TxtBuscar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtBuscar_MouseLeave(sender As Object, e As EventArgs) Handles TxtBuscar.MouseLeave
        If String.IsNullOrWhiteSpace(TxtBuscar.Text) Then
            TxtBuscar.Text = "Ingrese el nombre del medico"
            TxtBuscar.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
        con.Open()

        Dim cmd As New SqlClient.SqlCommand("DELETE 
                                             FROM Medico
                                             WHERE IdMedico = '" + TxtId.Text + "'", con)

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
End Class