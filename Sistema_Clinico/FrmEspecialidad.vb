Imports System.Data.SqlClient
Public Class FrmEspecialidad


    Private Sub GroupEspecialidad_Enter(sender As Object, e As EventArgs) Handles GroupEspecialidad.Enter

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If String.IsNullOrEmpty(TxtEspecialidad.Text.Trim()) OrElse String.IsNullOrEmpty(TxtDescripcion.Text.Trim()) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.")
            Return
        End If

        Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
        con.Open()

        Dim cmd As New SqlClient.SqlCommand("sp_Especialidad", con)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@Identificador", 1)
        cmd.Parameters.AddWithValue("@IdEspecialidad", ObtenerSiguienteID)
        cmd.Parameters.AddWithValue("@Especialidad", TxtEspecialidad.Text)
        cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text)
        cmd.Parameters.AddWithValue("@FechaRegistro", DateFechaRegistro.Value)
        cmd.Parameters.AddWithValue("@FechaModificacion", DateFechaRegistro.Value)
        cmd.Parameters.AddWithValue("@Estado", If(CheckActivo.Checked, 1, 0))


        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

        If rowsAffected > 0 Then
            MessageBox.Show("El registro se guardo correctamente")
            TxtId.ReadOnly = True
            TxtId.Enabled = False
        Else
            MessageBox.Show("El registro no se pudo guardar correctamente, algo falló")
        End If

        con.Close()

        TxtId.Text = ObtenerSiguienteID()
        TxtEspecialidad.Text = ""
        TxtDescripcion.Text = ""
        DateFechaRegistro.Text = ""
        CheckActivo.Checked = False

        TxtId.Enabled = controlesHabilitados
        TxtEspecialidad.Enabled = controlesHabilitados
        TxtDescripcion.Enabled = controlesHabilitados
        DateFechaRegistro.Enabled = controlesHabilitados
        CheckActivo.Enabled = controlesHabilitados
    End Sub

    Private Sub BtnAgregar_Click_1(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        BtnGuardar.Visible = True
        Dim siguienteID As Integer = ObtenerSiguienteID()
        TxtId.Text = siguienteID.ToString()
        TxtId.ReadOnly = True

        BtnAgregar.Visible = False
        TxtEspecialidad.Enabled = True
        TxtDescripcion.Enabled = True
        DateFechaRegistro.Enabled = True
        CheckActivo.Enabled = True

        controlesHabilitados = True

        PanelEspecialidad.Refresh()
    End Sub

    Private Function ObtenerSiguienteID() As Integer
        Dim siguienteID As Integer = 1
        Dim connectionString As String = "Data Source=OPCODE;Initial Catalog=Sistema_Clinico;User ID=opcode;Password=opcode7"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT ISNULL(MAX(IdEspecialidad), 0) + 1 FROM Especialidad"
            Using command As New SqlCommand(query, connection)
                siguienteID = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return siguienteID
    End Function

    Private controlesHabilitados As Boolean = False

    Private Sub PanelEspecialidad_Paint(sender As Object, e As PaintEventArgs) Handles PanelEspecialidad.Paint
        TxtId.Enabled = controlesHabilitados
        TxtEspecialidad.Enabled = controlesHabilitados
        TxtDescripcion.Enabled = controlesHabilitados
        DateFechaRegistro.Enabled = controlesHabilitados
        CheckActivo.Enabled = controlesHabilitados
    End Sub

    Private Sub FrmEspecialidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnGuardar.Visible = controlesHabilitados
        TxtId.ReadOnly = True
        TxtId.Enabled = False

        TxtDescripcion.Multiline = True
        TxtDescripcion.ScrollBars = ScrollBars.Vertical
        TxtDescripcion.Height = 100
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If String.IsNullOrEmpty(TxtEspecialidad.Text.Trim()) OrElse String.IsNullOrEmpty(TxtDescripcion.Text.Trim()) Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.")
            Return
        End If

        Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
        con.Open()

        Dim cmd As New SqlClient.SqlCommand("UPDATE Especialidad
                                            SET Especialidad = @Especialidad, Descripcion = @Descripcion, FechaModificacion = GETDATE(), Estado = @Estado
                                            WHERE IdEspecialidad = @IdEspecialidad", con)

        'Dim cmd As New SqlClient.SqlCommand("sp_Especialidad", con)
        'cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@IdEspecialidad", TxtId.Text)
        cmd.Parameters.AddWithValue("@Especialidad", TxtEspecialidad.Text)
        cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text)
        cmd.Parameters.AddWithValue("@FechaModificacion", DateFechaRegistro.Value)
        cmd.Parameters.AddWithValue("@Estado", If(CheckActivo.Checked, 1, 0))

        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

        If rowsAffected > 0 Then
            MessageBox.Show("Los datos se editaron correctamente")
        Else
            MessageBox.Show("No se pudo editar correctamente, algo falló")
        End If

        con.Close()

        TxtId.Text = ""
        TxtEspecialidad.Text = ""
        TxtDescripcion.Text = ""
        DateFechaRegistro.Text = ""
        CheckActivo.Checked = False

        TxtId.Enabled = controlesHabilitados
        TxtEspecialidad.Enabled = controlesHabilitados
        TxtDescripcion.Enabled = controlesHabilitados
        DateFechaRegistro.Enabled = controlesHabilitados
        CheckActivo.Enabled = controlesHabilitados
    End Sub

    Private Sub ImagenBuscar_Click(sender As Object, e As EventArgs) Handles ImagenBuscar.Click
        Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
        con.Open()

        Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("Select Especialidad.IdEspecialidad, Especialidad.Especialidad, Especialidad.Descripcion, Especialidad.FechaRegistro, Especialidad.Estado
                                             From Especialidad
                                             WHERE Especialidad = '" & TxtBuscar.Text & "'", con)

        reader = cmd.ExecuteReader

        If reader.Read Then
            MessageBox.Show("Información encontrada")
            BtnAgregar.Visible = True

            TxtId.Text = reader("IdEspecialidad").ToString()
            TxtEspecialidad.Text = reader("Especialidad").ToString()
            TxtDescripcion.Text = reader("Descripcion").ToString()
            DateFechaRegistro.Value = DateTime.Parse(reader("FechaRegistro").ToString())
            DateFechaRegistro.Format = DateTimePickerFormat.Custom
            DateFechaRegistro.CustomFormat = "dd/MM/yyyy"

            Dim estado As Integer = Convert.ToInt32(reader("Estado"))
            CheckActivo.Checked = (estado = 1)

        Else
            MessageBox.Show("No existe un registro con esos datos")
        End If

        TxtBuscar.Text = ""
        TxtEspecialidad.Enabled = False
        TxtDescripcion.Enabled = False
        DateFechaRegistro.Enabled = False
        CheckActivo.Enabled = False
        controlesHabilitados = False
        TxtId.Enabled = False
        BtnEditar.Visible = True

        TxtId.Enabled = controlesHabilitados
        TxtEspecialidad.Enabled = controlesHabilitados
        TxtDescripcion.Enabled = controlesHabilitados
        DateFechaRegistro.Enabled = controlesHabilitados
        CheckActivo.Enabled = controlesHabilitados
    End Sub

    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            ImagenBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub TxtBuscar_MouseEnter(sender As Object, e As EventArgs) Handles TxtBuscar.MouseEnter
        If String.IsNullOrWhiteSpace(TxtBuscar.Text) OrElse TxtBuscar.Text = "Ingrese la especialidad" Then
            TxtBuscar.Text = ""
            TxtBuscar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtBuscar_MouseLeave(sender As Object, e As EventArgs) Handles TxtBuscar.MouseLeave
        If String.IsNullOrWhiteSpace(TxtBuscar.Text) Then
            TxtBuscar.Text = "Ingrese la especialidad"
            TxtBuscar.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        LblFecha.Text = "Fecha modificacion"
        BtnEditar.Visible = False
        BtnGuardar.Visible = False
        BtnAgregar.Visible = True
        TxtEspecialidad.Enabled = True
        TxtDescripcion.Enabled = True
        DateFechaRegistro.Enabled = True
        CheckActivo.Enabled = True
        TxtId.ReadOnly = True

        controlesHabilitados = True
        TxtId.Enabled = False

        PanelEspecialidad.Refresh()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
        con.Open()

        Dim cmd As New SqlClient.SqlCommand("DELETE 
                                             FROM Especialidad
                                             WHERE IdEspecialidad = @IdEspecialidad", con)

        cmd.Parameters.AddWithValue("@IdEspecialidad", TxtId.Text)

        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

        If rowsAffected > 0 Then
            MessageBox.Show("Registro eliminado con éxito")
        Else
            MessageBox.Show("El registro no se pudo eliminar, algo falló")
        End If

        con.Close()

        TxtId.Text = ""
        TxtEspecialidad.Text = ""
        TxtDescripcion.Text = ""
        DateFechaRegistro.Text = ""
        CheckActivo.Checked = False

        TxtId.Enabled = controlesHabilitados
        TxtEspecialidad.Enabled = controlesHabilitados
        TxtDescripcion.Enabled = controlesHabilitados
        DateFechaRegistro.Enabled = controlesHabilitados
        CheckActivo.Enabled = controlesHabilitados
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

        Dim connectionString As String = "Data Source=
OPCODE;Initial Catalog=Sistema_Clinico;User ID=opcode;Password=opcode7"
        Dim query As String = "SELECT Especialidad FROM Especialidad WHERE Especialidad LIKE '%' + @textoBusqueda + '%'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@textoBusqueda", textoBusqueda)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim sugerencia As String = reader("Especialidad").ToString()
                        sugerencias.Add(sugerencia)
                    End While
                End Using
            End Using
        End Using

        Return sugerencias
    End Function
End Class