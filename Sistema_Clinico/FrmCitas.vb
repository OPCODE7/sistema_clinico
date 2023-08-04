Imports System.Data.SqlClient
Public Class FrmCitas
    Dim connectionString As String = "Data Source=OPCODE;Initial Catalog=Sistema_Clinico;User ID=opcode;Password=opcode7"
    Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
    Dim reader As SqlDataReader
    Dim recordset As DataTable
    Dim cmd As SqlCommand

    Private controlesHabilitados As Boolean = False

    Private Sub EnabledControls()
        TxtPaciente.Enabled = True
        TxtApellidoPa.Enabled = True
        TxtMedico.Enabled = True
        TxtApellidoMe.Enabled = True
        TxtIdentidad.Enabled = True
        TxtIdentidadMe.Enabled = True
        TxtEspecialidad.Enabled = True
        DateFechaCita.Enabled = True
        DateFechaRegistro.Enabled = True
    End Sub

    Private Sub StartForm()
        BtnAgregar.Enabled = False
        BtnGuardar.Visible = False
        BtnEliminar.Enabled = False
        TxtId.ReadOnly = True
        TxtId.Enabled = False

        TxtIdPa.Enabled = False
        TxtPaciente.Enabled = False
        TxtApellidoPa.Enabled = False
        TxtIdMe.Enabled = False
        TxtMedico.Enabled = False
        TxtApellidoMe.Enabled = False
        TxtIdentidad.Enabled = False
        TxtIdentidadMe.Enabled = False
        TxtEspecialidad.Enabled = False
        DateFechaCita.Enabled = False
        DateFechaRegistro.Enabled = False

    End Sub
    Private Sub ClearForm()
        TxtIdHistorial.Clear()
        TxtIdPa.Clear()
        TxtPaciente.Clear()
        TxtApellidoPa.Clear()
        TxtIdMe.Clear()
        TxtMedico.Clear()
        TxtApellidoMe.Clear()
        TxtIdentidad.Clear()
        TxtIdentidadMe.Clear()
        TxtEspecialidad.Clear()
    End Sub

    Private Function Validator() As Boolean
        Dim isvalid As Boolean = True
        If TxtPaciente.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar los datos del paciente.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPaciente.Focus()
            isvalid = False
        ElseIf TxtMedico.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar los datos del medico.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtMedico.Focus()
            isvalid = False
        ElseIf DateFechaCita.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingresar la fecha de la cita.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            DateFechaCita.Focus()
            isvalid = False
        End If
        Return isvalid
    End Function

    Private Function ObtenerSiguienteID() As Integer
        Dim siguienteID As Integer = 1

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT ISNULL(MAX(IdCita), 0) + 1 FROM CitaMedica"
            Using command As New SqlCommand(query, connection)
                siguienteID = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return siguienteID
    End Function

    Private Sub BuscarPaciente_Click(sender As Object, e As EventArgs) Handles BuscarPaciente.Click
    End Sub

    Private Function ObtenerSugerencias(textoBusqueda As String) As List(Of String)
        Dim sugerencias As New List(Of String)()

        Dim query As String = "SELECT A.IdPaciente, B.NombrePaciente 
                               FROM HistorialMedico A INNER JOIN Paciente B ON(A.IdPaciente = B.IdPaciente) WHERE B.NombrePaciente LIKE '%' + @textoBusqueda + '%'"

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

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Close()
    End Sub

    Private Sub TxtPaciente_TextChanged(sender As Object, e As EventArgs) Handles TxtPaciente.TextChanged

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

    Private Sub GroupCita_ControlAdded(sender As Object, e As ControlEventArgs) Handles GroupCita.ControlAdded
        ClearForm()
        StartForm()
    End Sub

    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            ImagenBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub ImagenBuscar_Click(sender As Object, e As EventArgs) Handles ImagenBuscar.Click
        con.Open()

        Dim query As String = "SELECT A.IdHistorialClinico, A.IdPaciente, A.IdMedico, B.IdPaciente, B.NombrePaciente, B.ApellidoPaciente, B.Identidad as IdentidadPaciente, C.IdMedico, C.NombreMedico, C.ApellidoMedico, C.IdEspecialidad, C.Identidad as IdentidadMedico, E.Especialidad " &
                              "FROM HistorialMedico A " &
                              "INNER JOIN Paciente B ON A.IdPaciente = B.IdPaciente " &
                              "INNER JOIN Medico C ON A.IdMedico = C.IdMedico " &
                              "INNER JOIN Especialidad E ON C.IdEspecialidad = E.IdEspecialidad " &
                              "WHERE B.NombrePaciente = @NombrePaciente"

        Using cmd As New SqlClient.SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@NombrePaciente", TxtBuscar.Text)

            reader = cmd.ExecuteReader

            If reader.Read Then
                MessageBox.Show("Información encontrada")
                BtnAgregar.Enabled = True

                TxtIdHistorial.Text = reader("IdHistorialClinico").ToString()
                TxtIdPa.Text = reader("IdPaciente").ToString()
                TxtPaciente.Text = reader("NombrePaciente").ToString()
                TxtApellidoPa.Text = reader("ApellidoPaciente").ToString()
                TxtIdentidad.Text = reader("IdentidadPaciente").ToString()

                TxtIdMe.Text = reader("IdMedico").ToString()
                TxtMedico.Text = reader("NombreMedico").ToString()
                TxtApellidoMe.Text = reader("ApellidoMedico").ToString()
                TxtIdentidadMe.Text = reader("IdentidadMedico").ToString()
                TxtEspecialidad.Text = reader("Especialidad").ToString()

            Else
                MessageBox.Show("No existe un registro con esos datos")
            End If
        End Using

        con.Close()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim siguienteID As Integer = ObtenerSiguienteID()
        TxtId.Text = siguienteID.ToString()
        TxtId.ReadOnly = True
        BtnGuardar.Visible = True
        BtnAgregar.Visible = False
        BtnEliminar.Enabled = True
        EnabledControls()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Validator() Then
            con.Open()

            Dim cmd As New SqlClient.SqlCommand("sp_CitaMedica", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Identificador", 1)
            cmd.Parameters.AddWithValue("@IdCita", ObtenerSiguienteID)
            cmd.Parameters.AddWithValue("@IdHistorial", TxtIdHistorial.Text)
            cmd.Parameters.AddWithValue("@FechaCita", DateFechaCita.Value)
            cmd.Parameters.AddWithValue("@FechaRegistro", DateFechaRegistro.Value)
            cmd.Parameters.AddWithValue("@FechaModificacion", DateFechaRegistro.Value)

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

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
        con.Open()

        Dim cmd As New SqlClient.SqlCommand("DELETE 
                                             FROM CitaMedica
                                             WHERE IdCita = '" + TxtId.Text + "'", con)

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