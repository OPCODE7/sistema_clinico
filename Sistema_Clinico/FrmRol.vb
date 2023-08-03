Imports System.Data.SqlClient
Public Class FrmRol
    Dim connectionString As String = "Data Source=DESKTOP-FUNN0TB\MSSQLSERVER2019;Initial Catalog=Sistema_Clinico;User ID=sa;Password=12345"
    Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
    Dim reader As SqlDataReader
    Dim recordset As DataTable
    Dim cmd As SqlCommand

    Private controlesHabilitados As Boolean = False

    Private Sub EnabledControls()
        TxtRol.Enabled = True
        TxtDescripcion.Enabled = True
        DateFechaRegistro.Enabled = True
        CheckActivo.Enabled = True
    End Sub

    Private Sub StartForm()
        BtnGuardar.Visible = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        TxtId.ReadOnly = True
        TxtId.Enabled = False
        TxtRol.Enabled = False
        TxtDescripcion.Enabled = False
        DateFechaRegistro.Enabled = False
        CheckActivo.Enabled = False

    End Sub
    Private Sub ClearForm()
        TxtRol.Clear()
        TxtDescripcion.Clear()
        CheckActivo.Checked = False
    End Sub

    Private Function Validator() As Boolean
        Dim isvalid As Boolean = True
        If TxtRol.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese el rol.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtRol.Focus()
            isvalid = False
        ElseIf TxtDescripcion.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese la descripcion del rol.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtDescripcion.Focus()
            isvalid = False
        End If
        Return isvalid
    End Function

    Private Function ObtenerSiguienteID() As Integer
        Dim siguienteID As Integer = 1

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT ISNULL(MAX(IdRol), 0) + 1 FROM RolEmpleado"
            Using command As New SqlCommand(query, connection)
                siguienteID = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return siguienteID
    End Function
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim siguienteID As Integer = ObtenerSiguienteID()
        TxtId.Text = siguienteID.ToString()
        TxtId.ReadOnly = True
        BtnGuardar.Visible = True
        BtnAgregar.Visible = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False

        EnabledControls()
        ClearForm()
    End Sub

    Private Sub FrmRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtDescripcion.Multiline = True
        TxtDescripcion.ScrollBars = ScrollBars.Vertical
        TxtDescripcion.Height = 100
    End Sub

    Private Sub PanelRol_Paint(sender As Object, e As PaintEventArgs) Handles PanelRol.Paint
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Validator() Then
            con.Open()

            Dim cmd As New SqlClient.SqlCommand("sp_Rol", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Identificador", 1)
            cmd.Parameters.AddWithValue("@IdRol", ObtenerSiguienteID)
            cmd.Parameters.AddWithValue("@Rol", TxtRol.Text)
            cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text)
            cmd.Parameters.AddWithValue("@FechaRegistro", DateFechaRegistro.Value)
            cmd.Parameters.AddWithValue("@FechaModificacion", DateFechaRegistro.Value)
            cmd.Parameters.AddWithValue("@Estado", If(CheckActivo.Checked, 1, 0))

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

    Private Sub ImagenBuscar_Click(sender As Object, e As EventArgs) Handles ImagenBuscar.Click
        con.Open()

        Dim cmd As New SqlClient.SqlCommand("Select RolEmpleado.IdRol, RolEmpleado.Rol, RolEmpleado.Descripcion, RolEmpleado.FechaRegistro, RolEmpleado.Estado
                                             From RolEmpleado
                                             WHERE Rol = '" & TxtBuscar.Text & "'", con)

        reader = cmd.ExecuteReader

        If reader.Read Then
            MessageBox.Show("Información encontrada")
            BtnEditar.Enabled = True
            BtnEliminar.Enabled = True
            BtnAgregar.Visible = True
            TxtBuscar.Text = ""

            TxtId.Text = reader("IdRol").ToString()
            TxtRol.Text = reader("Rol").ToString()
            TxtDescripcion.Text = reader("Descripcion").ToString()
            DateFechaRegistro.Value = DateTime.Parse(reader("FechaRegistro").ToString())
            DateFechaRegistro.Format = DateTimePickerFormat.Custom
            DateFechaRegistro.CustomFormat = "dd/MM/yyyy"

            Dim estado As Integer = Convert.ToInt32(reader("Estado"))
            CheckActivo.Checked = (estado = 1)

        Else
            MessageBox.Show("No existe un registro con esos datos")
        End If

        con.Close()
        cmd.Dispose()
    End Sub

    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            ImagenBuscar_Click(sender, e)
        End If
    End Sub

    Private Sub TxtBuscar_MouseEnter(sender As Object, e As EventArgs) Handles TxtBuscar.MouseEnter
        If String.IsNullOrWhiteSpace(TxtBuscar.Text) OrElse TxtBuscar.Text = "Ingrese el rol" Then
            TxtBuscar.Text = ""
            TxtBuscar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtBuscar_MouseLeave(sender As Object, e As EventArgs) Handles TxtBuscar.MouseLeave
        If String.IsNullOrWhiteSpace(TxtBuscar.Text) Then
            TxtBuscar.Text = "Ingrese el rol"
            TxtBuscar.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        LblFecha.Text = "Fecha modificacion"
        BtnEditar.Visible = False
        EnabledControls()
        TxtId.ReadOnly = True
        TxtId.Enabled = False
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Validator() Then
            con.Open()

            Dim cmd As New SqlClient.SqlCommand("UPDATE RolEmpleado
                                                SET Rol = @Rol, Descripcion = @Descripcion, FechaModificacion = GETDATE(), Estado = @Estado
                                                WHERE IdRol = @IdRol", con)

            cmd.Parameters.AddWithValue("@IdRol", TxtId.Text)
            cmd.Parameters.AddWithValue("@Rol", TxtRol.Text)
            cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text)
            cmd.Parameters.AddWithValue("@FechaModificacion", DateFechaRegistro.Value)
            cmd.Parameters.AddWithValue("@Estado", If(CheckActivo.Checked, 1, 0))

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
                                             FROM RolEmpleado
                                             WHERE IdRol = '" + TxtId.Text + "'", con)

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

        Dim connectionString As String = "Data Source=DESKTOP-FUNN0TB\MSSQLSERVER2019;Initial Catalog=Sistema_Clinico;User ID=sa;Password=12345"
        Dim query As String = "SELECT Rol FROM RolEmpleado WHERE Rol LIKE '%' + @textoBusqueda + '%'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@textoBusqueda", textoBusqueda)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim sugerencia As String = reader("Rol").ToString()
                        sugerencias.Add(sugerencia)
                    End While
                End Using
            End Using
        End Using

        Return sugerencias
    End Function

    Private Sub GroupRol_ControlAdded(sender As Object, e As ControlEventArgs) Handles GroupRol.ControlAdded
        ClearForm()
        StartForm()
    End Sub
End Class