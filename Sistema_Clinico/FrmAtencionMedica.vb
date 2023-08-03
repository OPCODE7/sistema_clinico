Imports System.Data.SqlClient
Public Class FrmAtencionMedica
    Dim connectionString As String = "Data Source=DESKTOP-FUNN0TB\MSSQLSERVER2019;Initial Catalog=Sistema_Clinico;User ID=sa;Password=12345"
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
        TxtDiagnostico.Enabled = True
        TxtTratamiento.Enabled = True
        ListTratamiento.Enabled = True
        DateFechaRegistro.Enabled = True
    End Sub

    Private Sub StartForm()
        BtnGuardar.Visible = False
        BtnHistorial.Enabled = False
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
        TxtDiagnostico.Enabled = False
        TxtTratamiento.Enabled = False
        ListTratamiento.Enabled = False
        DateFechaRegistro.Enabled = False

    End Sub
    Private Sub ClearForm()
        TxtIdPa.Clear()
        TxtPaciente.Clear()
        TxtApellidoPa.Clear()
        TxtIdMe.Clear()
        TxtMedico.Clear()
        TxtApellidoMe.Clear()
        TxtIdentidad.Clear()
        TxtIdentidadMe.Clear()
        TxtEspecialidad.Clear()
        TxtDiagnostico.Clear()
        TxtTratamiento.Clear()
        ListTratamiento.Items.Clear()
    End Sub

    Private Sub Buscar()
        TxtBuscar.Enabled = False
        ImagenBuscar.Enabled = False
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
        ElseIf TxtDiagnostico.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese el diagnostico del paciente.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtDiagnostico.Focus()
            isvalid = False
        ElseIf ListTratamiento.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese el tratamiento del paciente.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ListTratamiento.Focus()
            isvalid = False
        End If
        Return isvalid
    End Function

    Private Function ObtenerSiguienteID() As Integer
        Dim siguienteID As Integer = 1

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT ISNULL(MAX(IdHistorial), 0) + 1 FROM HistorialMedico"
            Using command As New SqlCommand(query, connection)
                siguienteID = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return siguienteID
    End Function

    Private Sub FrmAtencionMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TxtDiagnostico.Multiline = True
        'TxtDiagnostico.ScrollBars = ScrollBars.Vertical
        'TxtDiagnostico.Height = 100

        TxtTratamiento.AcceptsReturn = True
        'TxtTra.Multiline = True
        'TxtTra.ScrollBars = ScrollBars.Vertical

    End Sub

    Private Sub BuscarPaciente_Click(sender As Object, e As EventArgs) Handles BuscarPaciente.Click
        con.Open()

        Dim cmd As New SqlClient.SqlCommand("Select Paciente.IdPaciente, Paciente.NombrePaciente, Paciente.ApellidoPaciente, Paciente.Identidad
                                             From Paciente
                                             WHERE NombrePaciente = '" & TxtPaciente.Text & "'", con)

        reader = cmd.ExecuteReader


        If reader.Read Then
            MessageBox.Show("Información encontrada")
            BtnGuardar.Visible = True

            TxtIdPa.Text = reader("IdPaciente").ToString()
            TxtPaciente.Text = reader("NombrePaciente").ToString()
            TxtApellidoPa.Text = reader("ApellidoPaciente").ToString()
            TxtIdentidad.Text = reader("Identidad").ToString()

        Else
            MessageBox.Show("No existe un registro con esos datos")
        End If
        con.Close()
        cmd.Dispose()
    End Sub

    Private Sub BuscarMedico_Click(sender As Object, e As EventArgs) Handles BuscarMedico.Click
        con.Open()

        Dim cmd As New SqlClient.SqlCommand("Select A.IdMedico, A.NombreMedico, A.ApellidoMedico, A.IdEspecialidad, 
                                             A.Identidad, B.Especialidad
                                             From Medico A INNER JOIN Especialidad B ON(A.IdEspecialidad = B.IdEspecialidad) 
                                             WHERE NombreMedico = '" & TxtMedico.Text & "'", con)

        reader = cmd.ExecuteReader

        If reader.Read Then
            MessageBox.Show("Información encontrada")

            TxtIdMe.Text = reader("IdMedico").ToString()
            TxtMedico.Text = reader("NombreMedico").ToString()
            TxtApellidoMe.Text = reader("ApellidoMedico").ToString()
            TxtIdentidadMe.Text = reader("Identidad").ToString()
            TxtEspecialidad.Text = reader("Especialidad").ToString()

        Else
            MessageBox.Show("No existe un registro con esos datos")
        End If
        con.Close()
        cmd.Dispose()
    End Sub

    Private Function ObtenerPaciente(textoBusqueda As String) As List(Of String)
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

    Private Sub TxtPaciente_TextChanged(sender As Object, e As EventArgs) Handles TxtPaciente.TextChanged
        Dim textoBusqueda As String = TxtPaciente.Text

        ' Realizar la consulta a la base de datos para obtener las sugerencias
        Dim sugerencias As List(Of String) = ObtenerPaciente(textoBusqueda)

        ' Configurar las sugerencias en el control TextBox utilizando AutoComplete
        TxtPaciente.AutoCompleteMode = AutoCompleteMode.Suggest
        TxtPaciente.AutoCompleteSource = AutoCompleteSource.CustomSource

        ' Crear una colección de sugerencias
        Dim fuenteSugerencias As New AutoCompleteStringCollection()
        fuenteSugerencias.AddRange(sugerencias.ToArray())

        ' Asignar la colección de sugerencias al control TextBox
        TxtPaciente.AutoCompleteCustomSource = fuenteSugerencias
    End Sub

    Private Function ObtenerMedico(textoBusqueda As String) As List(Of String)
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

    Private Sub TxtMedico_TextChanged(sender As Object, e As EventArgs) Handles TxtMedico.TextChanged
        Dim textoBusqueda As String = TxtMedico.Text

        ' Realizar la consulta a la base de datos para obtener las sugerencias
        Dim sugerencias As List(Of String) = ObtenerMedico(textoBusqueda)

        ' Configurar las sugerencias en el control TextBox utilizando AutoComplete
        TxtMedico.AutoCompleteMode = AutoCompleteMode.Suggest
        TxtMedico.AutoCompleteSource = AutoCompleteSource.CustomSource

        ' Crear una colección de sugerencias
        Dim fuenteSugerencias As New AutoCompleteStringCollection()
        fuenteSugerencias.AddRange(sugerencias.ToArray())

        ' Asignar la colección de sugerencias al control TextBox
        TxtMedico.AutoCompleteCustomSource = fuenteSugerencias
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

    Private Sub GroupAtencionMedica_ControlAdded(sender As Object, e As ControlEventArgs) Handles GroupAtencionMedica.ControlAdded
        ClearForm()
        StartForm()
    End Sub

    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            ImagenBuscar_Click(sender, e)
        End If
    End Sub

    'Private Sub TxtBuscar_MouseEnter(sender As Object, e As EventArgs) Handles TxtBuscar.MouseEnter
    '    If String.IsNullOrWhiteSpace(TxtBuscar.Text) OrElse TxtBuscar.Text = "Ingrese un paciente" Then
    '        TxtBuscar.Text = ""
    '        TxtBuscar.ForeColor = Color.Black
    '    End If
    'End Sub

    'Private Sub TxtBuscar_MouseLeave(sender As Object, e As EventArgs) Handles TxtBuscar.MouseLeave
    '    If String.IsNullOrWhiteSpace(TxtBuscar.Text) Then
    '        TxtBuscar.Text = "Ingrese un paciente"
    '        TxtBuscar.ForeColor = Color.Gray
    '    End If
    'End Sub

    Private Sub TxtPaciente_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPaciente.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarPaciente_Click(sender, e)
        End If
    End Sub

    'Private Sub TxtPaciente_MouseEnter(sender As Object, e As EventArgs) Handles TxtPaciente.MouseEnter
    '    If String.IsNullOrWhiteSpace(TxtBuscar.Text) OrElse TxtBuscar.Text = "Ingrese un nuevo paciente" Then
    '        TxtPaciente.Text = ""
    '        TxtPaciente.ForeColor = Color.Black
    '    End If
    'End Sub

    'Private Sub TxtPaciente_MouseMove(sender As Object, e As MouseEventArgs) Handles TxtPaciente.MouseMove
    '    If String.IsNullOrWhiteSpace(TxtPaciente.Text) Then
    '        TxtPaciente.Text = "Ingrese un nuevo paciente"
    '        TxtPaciente.ForeColor = Color.Gray
    '    End If
    'End Sub

    Private Sub TxtMedico_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtMedico.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarMedico_Click(sender, e)
        End If
    End Sub

    'Private Sub TxtMedico_MouseEnter(sender As Object, e As EventArgs) Handles TxtMedico.MouseEnter
    '    If String.IsNullOrWhiteSpace(TxtBuscar.Text) OrElse TxtBuscar.Text = "Ingrese un medico" Then
    '        TxtMedico.Text = ""
    '        TxtMedico.ForeColor = Color.Black
    '    End If
    'End Sub

    'Private Sub TxtMedico_MouseLeave(sender As Object, e As EventArgs) Handles TxtMedico.MouseLeave
    '    If String.IsNullOrWhiteSpace(TxtMedico.Text) Then
    '        TxtMedico.Text = "Ingrese un medico"
    '        TxtMedico.ForeColor = Color.Gray
    '    End If
    'End Sub

    Private Sub ImagenBuscar_Click(sender As Object, e As EventArgs) Handles ImagenBuscar.Click
        con.Open()

        Dim cmd As New SqlClient.SqlCommand("SELECT A.IdHistorial, A.IdPaciente, A.IdMedico, A.Diagnostico, A.Tratamiento, A.FechaRegistro,
                                            B.IdPaciente, B.NombrePaciente, B.ApellidoPaciente, B.Identidad as IdentidadPaciente,
                                            C.IdMedico, C.NombreMedico, C.ApellidoMedico, C.IdEspecialidad, C.Identidad as IdentidadMedico,
                                            E.Especialidad
                                            FROM HistorialMedico A
                                                                    INNER JOIN Paciente B ON A.IdPaciente = B.IdPaciente
                                                                    INNER JOIN Medico C ON A.IdMedico = C.IdMedico
                                                                    INNER JOIN Especialidad E ON C.IdEspecialidad = E.IdEspecialidad
                                            WHERE B.NombrePaciente = '" & TxtBuscar.Text & "'", con)

        reader = cmd.ExecuteReader

        If reader.Read Then
            MessageBox.Show("Información encontrada")
            TxtBuscar.Text = ""
            StartForm()
            BtnHistorial.Visible = False
            BtnEditar.Visible = True
            BtnEditar.Enabled = True
            BtnEliminar.Enabled = True
            BtnAgregar.Visible = True

            TxtId.Text = reader("IdHistorial").ToString()
            TxtIdPa.Text = reader("IdPaciente").ToString()
            TxtPaciente.Text = reader("NombrePaciente").ToString()
            TxtApellidoPa.Text = reader("ApellidoPaciente").ToString()
            TxtIdentidad.Text = reader("IdentidadPaciente").ToString()

            TxtIdMe.Text = reader("IdMedico").ToString()
            TxtMedico.Text = reader("NombreMedico").ToString()
            TxtApellidoMe.Text = reader("ApellidoMedico").ToString()
            TxtIdentidad.Text = reader("IdentidadMedico").ToString()
            TxtEspecialidad.Text = reader("Especialidad").ToString()

            TxtDiagnostico.Text = reader("Diagnostico").ToString()
            ListTratamiento.Text = reader("Tratamiento").ToString()
            DateFechaRegistro.Value = DateTime.Parse(reader("FechaRegistro").ToString())
            DateFechaRegistro.Format = DateTimePickerFormat.Custom
            DateFechaRegistro.CustomFormat = "dd/MM/yyyy"

        Else
            MessageBox.Show("No existe un registro con esos datos")
        End If
        con.Close()
        cmd.Dispose()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Buscar()
        Dim siguienteID As Integer = ObtenerSiguienteID()
        TxtId.Text = siguienteID.ToString()
        TxtId.ReadOnly = True
        BtnGuardar.Visible = True
        BtnAgregar.Visible = False
        BtnHistorial.Enabled = True
        BtnEliminar.Enabled = False
        EnabledControls()
        ClearForm()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Validator() Then
            con.Open()

            Dim cmd As New SqlClient.SqlCommand("sp_HistorialMedico", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Identificador", 1)
            cmd.Parameters.AddWithValue("@IdHistorial", ObtenerSiguienteID())
            cmd.Parameters.AddWithValue("@IdPaciente", TxtIdPa.Text)
            cmd.Parameters.AddWithValue("@IdMedico", TxtIdMe.Text)
            cmd.Parameters.AddWithValue("@Diagnostico", TxtDiagnostico.Text)
            ' Cambia ListTratamiento.Text por ListTratamientos
            cmd.Parameters.AddWithValue("@Tratamiento", GetTratamientosString())
            cmd.Parameters.AddWithValue("@FechaRegistro", DateFechaRegistro.Value)
            cmd.Parameters.AddWithValue("@FechaModificacion", DateFechaRegistro.Value)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("El registro se guardó correctamente")
                BtnAgregar.Visible = True
                BtnHistorial.Visible = True
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

    Private Function GetTratamientosString() As String
        Return String.Join(",", ListTratamientos)
    End Function

    Private Sub BtnHistorial_Click(sender As Object, e As EventArgs) Handles BtnHistorial.Click
        ClearForm()
        StartForm()
        TxtBuscar.Enabled = True
        ImagenBuscar.Enabled = True
        BtnAgregar.Visible = True
        BtnAgregar.Enabled = True
        BtnHistorial.Visible = False
        BtnEditar.Visible = True
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        LblFecha.Text = "Fecha modificacion"
        BtnEditar.Visible = False
        BtnActualizar.Visible = True
        EnabledControls()
        TxtId.ReadOnly = True
        TxtId.Enabled = False
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Validator() Then
            con.Open()

            Dim cmd As New SqlClient.SqlCommand("Update HistorialMedico
	                                             set IdHistorial = @IdHistorial, IdPaciente = @IdPaciente, IdMedico = @IdMedico, 
	                                             Diagnostico = @Diagnostico, Tratamiento = @Tratamiento, FechaModificacion = GETDATE()
	                                             where IdHistorial = @IdHistorial", con)

            cmd.Parameters.AddWithValue("@IdHistorial", TxtId.Text)
            cmd.Parameters.AddWithValue("@IdPaciente", TxtIdPa.Text)
            cmd.Parameters.AddWithValue("@IdMedico", TxtIdMe.Text)
            cmd.Parameters.AddWithValue("@Diagnostico", TxtDiagnostico.Text)
            cmd.Parameters.AddWithValue("@Tratamiento", ListTratamiento.Text)
            cmd.Parameters.AddWithValue("@FechaModificacion", DateFechaRegistro.Value)

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

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
        con.Open()

        Dim cmd As New SqlClient.SqlCommand("DELETE 
                                             FROM HistorialMedico
                                             WHERE IdHistorial = '" + TxtId.Text + "'", con)

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

    Private ListTratamientos As New List(Of String)()

    Private Function ObtenerTratamiento(textoBusqueda As String) As List(Of String)
        Dim sugerencias As New List(Of String)()

        Dim query As String = "SELECT NombreMedicamento FROM Medicamentos WHERE NombreMedicamento LIKE '%' + @textoBusqueda + '%'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@textoBusqueda", textoBusqueda)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim sugerencia As String = reader("NombreMedicamento").ToString()
                        sugerencias.Add(sugerencia)
                    End While
                End Using
            End Using
            connection.Close()
        End Using

        Return sugerencias
    End Function

    Private Sub TxtTratamiento_TextChanged(sender As Object, e As EventArgs) Handles TxtTratamiento.TextChanged
        Dim textoBusqueda As String = TxtTratamiento.Text

        ' Realizar la consulta a la base de datos para obtener las sugerencias
        Dim sugerencias As List(Of String) = ObtenerTratamiento(textoBusqueda)

        ' Configurar las sugerencias en el control TextBox utilizando AutoComplete
        TxtTratamiento.AutoCompleteMode = AutoCompleteMode.Suggest
        TxtTratamiento.AutoCompleteSource = AutoCompleteSource.CustomSource

        ' Crear una colección de sugerencias
        Dim fuenteSugerencias As New AutoCompleteStringCollection()
        fuenteSugerencias.AddRange(sugerencias.ToArray())

        ' Asignar la colección de sugerencias al control TextBox
        TxtTratamiento.AutoCompleteCustomSource = fuenteSugerencias
    End Sub

    Private tratamientosSeleccionados As New List(Of String)()

    Private Sub TxtTratamiento_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtTratamiento.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarTratamiento_Click(sender, e)
        End If
    End Sub

    Private Sub BuscarTratamiento_Click(sender As Object, e As EventArgs) Handles BuscarTratamiento.Click
        con.Open()

        Dim cmd As New SqlClient.SqlCommand("SELECT Medicamentos.NombreMedicamento
                                         FROM Medicamentos
                                         WHERE NombreMedicamento = '" & TxtTratamiento.Text & "'", con)

        reader = cmd.ExecuteReader

        If reader.Read Then
            MessageBox.Show("Información encontrada")

            ListTratamientos.Add(reader("NombreMedicamento").ToString())

            ListTratamiento.Text = reader("NombreMedicamento").ToString()
        Else
            MessageBox.Show("No existe un registro con esos datos")
        End If

        con.Close()
        cmd.Dispose()
    End Sub

    Private Sub ListTratamiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListTratamiento.SelectedIndexChanged
        'Dim selectedItem As String = ListTratamiento.SelectedItem.ToString()
        'ListTratamiento.ClearSelected()
    End Sub

    Private Sub BtnCita_Click(sender As Object, e As EventArgs) Handles BtnCita.Click
        Dim frmCitas As New FrmCitas()
        frmCitas.ShowDialog()
    End Sub

    Private Sub BtnPrescripcion_Click(sender As Object, e As EventArgs) Handles BtnPrescripcion.Click
        Dim frmPrescripcion As New FrmPrescripcion()
        frmPrescripcion.ShowDialog()
    End Sub

    'Sub LlenarGridAuto()
    '    Dim DT As DataTable
    '    Dim DA As New SqlDataAdapter
    '    Dim cmd As New SqlCommand

    '    con.Open()
    '    cmd.Connection = con
    '    cmd.CommandType = CommandType.Text
    '    cmd.CommandText = "SELECT NombreMedicamento as Medicamento FROM Medicamentos"
    '    cmd.ExecuteNonQuery()
    '    con.Close()

    '    DA.SelectCommand = cmd
    '    DT = New DataTable
    '    DA.Fill(DT)

    '    DgvTratamiento.DataSource = DT
    '    DgvTratamiento.AllowUserToAddRows = False

    'End Sub

    'Sub LlenarGridAutoFiltrado()
    '    Dim DT As DataTable
    '    Dim DA As New SqlDataAdapter
    '    Dim cmd As New SqlCommand

    '    con.Open()
    '    cmd.Connection = con
    '    cmd.CommandType = CommandType.Text
    '    cmd.CommandText = "SELECT NombreMedicamento as Medicamento FROM Medicamentos WHERE NombreMedicamento LIKE '%" & TxtTratamiento.Text & "%'"
    '    cmd.ExecuteNonQuery()
    '    con.Close()

    '    DA.SelectCommand = cmd
    '    DT = New DataTable
    '    DA.Fill(DT)

    '    DgvTratamiento.DataSource = DT
    '    DgvTratamiento.AllowUserToAddRows = False

    '    ' Limpiar y luego agregar los elementos filtrados al ListBox
    '    ListTratamiento.Items.Clear()
    '    For Each row As DataGridViewRow In DgvTratamiento.Rows
    '        ListTratamiento.Items.Add(row.Cells("Medicamento").Value.ToString())
    '    Next
    'End Sub

    Private Sub FrmAtencionMedica_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'If e.KeyCode = Keys.Enter And TxtTratamiento.Focused Then

        '    LlenarGridAutoFiltrado()
        'End If
    End Sub

    Private Sub GroupAtencionMedica_Enter(sender As Object, e As EventArgs) Handles GroupAtencionMedica.Enter

    End Sub

    'Private Sub DgvTratamiento_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvTratamiento.CellClick
    '    Dim linea As Int32 = Val(Me.DgvTratamiento.CurrentRow.Index.ToString)
    '    TxtTra.Text = Me.DgvTratamiento(2, linea).Value.ToString
    'End Sub
End Class