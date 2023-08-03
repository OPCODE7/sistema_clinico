Imports System.Data.SqlClient
Public Class FrmTipoExamen
    Dim connectionString As String = "Data Source=DESKTOP-FUNN0TB\MSSQLSERVER2019;Initial Catalog=Sistema_Clinico;User ID=sa;Password=12345"
    Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
    Dim reader As SqlDataReader
    Dim recordset As DataTable
    Dim cmd As SqlCommand

    Private controlesHabilitados As Boolean = False

    Private Sub EnabledControls()
        TxtTipo.Enabled = True
        TxtDescripcion.Enabled = True
        CbmEspecialidad.Enabled = True
        TxtCosto.Enabled = True
        DateFechaRegistro.Enabled = True
        CheckActivo.Enabled = True
    End Sub

    Private Sub StartForm()
        BtnGuardar.Visible = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        TxtId.ReadOnly = True
        TxtId.Enabled = False
        TxtTipo.Enabled = False
        TxtDescripcion.Enabled = False
        CbmEspecialidad.Enabled = False
        TxtCosto.Enabled = False
        DateFechaRegistro.Enabled = False
        CheckActivo.Enabled = False

    End Sub
    Private Sub ClearForm()
        TxtTipo.Clear()
        TxtDescripcion.Clear()
        TxtCosto.Clear()
        CheckActivo.Checked = False
        'CbmEspecialidad.SelectedIndex = -1
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

    Private Function Validator() As Boolean
        Dim isvalid As Boolean = True
        If TxtTipo.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese el tipo examen.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtTipo.Focus()
            isvalid = False
        ElseIf TxtDescripcion.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese la descripcion del tipo examen.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtDescripcion.Focus()
            isvalid = False
        ElseIf CbmEspecialidad.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese la especialidad.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbmEspecialidad.Focus()
            isvalid = False
        ElseIf TxtCosto.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese el costo del examen.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtCosto.Focus()
            isvalid = False
        End If
        Return isvalid
    End Function

    Private Function ObtenerSiguienteID() As Integer
        Dim siguienteID As Integer = 1
        Dim connectionString As String = "Data Source=DESKTOP-FUNN0TB\MSSQLSERVER2019;Initial Catalog=Sistema_Clinico;User ID=sa;Password=12345"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT ISNULL(MAX(IdTipoExamen), 0) + 1 FROM TipoExamen"
            Using command As New SqlCommand(query, connection)
                siguienteID = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return siguienteID
    End Function

    Private Sub FrmTipoExamen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtDescripcion.Multiline = True
        TxtDescripcion.ScrollBars = ScrollBars.Vertical
        TxtDescripcion.Height = 100
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim siguienteID As Integer = ObtenerSiguienteID()
        TxtId.Text = siguienteID.ToString()
        TxtId.ReadOnly = True
        BtnGuardar.Visible = True
        BtnAgregar.Visible = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        FillEspecialidad()
        EnabledControls()
        ClearForm()
    End Sub

    Private Sub PanelTipoExamen_Paint(sender As Object, e As PaintEventArgs) Handles PanelTipoExamen.Paint
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Validator() Then
            con.Open()

            Dim cmd As New SqlClient.SqlCommand("sp_TipoExamen", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Identificador", 1)
            cmd.Parameters.AddWithValue("@IdTipoExamen", ObtenerSiguienteID)
            cmd.Parameters.AddWithValue("@TipoExamen", TxtTipo.Text)
            cmd.Parameters.AddWithValue("@IdEspecialidad", CbmEspecialidad.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text)
            cmd.Parameters.AddWithValue("@Costo", TxtCosto.Text)
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
        FillEspecialidad()
        con.Open()

        Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("Select A.IdTipoExamen, A.TipoExamen, A.Descripcion, 
                                             A.IdEspecialidad, A.Costo, A.FechaRegistro, A.Estado, B.Especialidad
                                             From TipoExamen A INNER JOIN Especialidad B ON(A.IdEspecialidad = B.IdEspecialidad) 
                                             WHERE TipoExamen = '" & TxtBuscar.Text & "'", con)

        reader = cmd.ExecuteReader

        If reader.Read Then
            MessageBox.Show("Información encontrada")
            BtnEditar.Enabled = True
            BtnEliminar.Enabled = True
            BtnAgregar.Visible = True
            TxtBuscar.Text = ""

            TxtId.Text = reader("IdTipoExamen").ToString()
            TxtTipo.Text = reader("TipoExamen").ToString()
            TxtDescripcion.Text = reader("Descripcion").ToString()
            CbmEspecialidad.Text = reader("Especialidad").ToString()
            TxtCosto.Text = reader("Costo").ToString()
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
        If String.IsNullOrWhiteSpace(TxtBuscar.Text) OrElse TxtBuscar.Text = "Ingrese tipo de examen" Then
            TxtBuscar.Text = ""
            TxtBuscar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtBuscar_MouseLeave(sender As Object, e As EventArgs) Handles TxtBuscar.MouseLeave
        If String.IsNullOrWhiteSpace(TxtBuscar.Text) Then
            TxtBuscar.Text = "Ingrese tipo de examen"
            TxtBuscar.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        FillEspecialidad()
        LblFecha.Text = "Fecha modificacion"
        BtnEditar.Visible = False
        EnabledControls()
        TxtId.ReadOnly = True
        TxtId.Enabled = False
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Validator() Then
            con.Open()

            Dim cmd As New SqlClient.SqlCommand("UPDATE TipoExamen
                                                SET TipoExamen = @TipoExamen, Descripcion = @Descripcion,
                                                IdEspecialidad = @IdEspecialidad, Costo = @Costo, FechaModificacion = GETDATE(), Estado = @Estado
                                                WHERE IdTipoExamen = @IdTipoExamen", con)

            cmd.Parameters.AddWithValue("@IdTipoExamen", TxtId.Text)
            cmd.Parameters.AddWithValue("@TipoExamen", TxtTipo.Text)
            cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text)
            cmd.Parameters.AddWithValue("@IdEspecialidad", CbmEspecialidad.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@Costo", TxtCosto.Text)
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
                                             FROM TipoExamen
                                             WHERE IdTipoExamen = '" + TxtId.Text + "'", con)

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

        Dim query As String = "SELECT TipoExamen FROM TipoExamen WHERE TipoExamen LIKE '%' + @textoBusqueda + '%'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@textoBusqueda", textoBusqueda)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim sugerencia As String = reader("TipoExamen").ToString()
                        sugerencias.Add(sugerencia)
                    End While
                End Using
            End Using
            connection.Close()
        End Using

        Return sugerencias
    End Function

    Private Sub GroupTipoExamen_ControlAdded(sender As Object, e As ControlEventArgs) Handles GroupTipoExamen.ControlAdded
        ClearForm()
        StartForm()
    End Sub
End Class