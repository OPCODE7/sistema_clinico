Imports System.Data.SqlClient
Public Class FrmMedicamento
    Dim connectionString As String = "Data Source=OPCODE;Initial Catalog=Sistema_Clinico;User ID=opcode;Password=opcode7"
    Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
    Dim reader As SqlDataReader
    Dim recordset As DataTable
    Dim cmd As SqlCommand

    Private controlesHabilitados As Boolean = False

    Private Sub EnabledControls()
        TxtNombre.Enabled = True
        TxtTipo.Enabled = True
        TxtDescripcion.Enabled = True
        CbmProveedor.Enabled = True
        TxtPrecio.Enabled = True
        TxtEnExistencia.Enabled = True
        DateFechaVencimiento.Enabled = True
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
        TxtTipo.Enabled = False
        TxtDescripcion.Enabled = False
        CbmProveedor.Enabled = False
        TxtPrecio.Enabled = False
        TxtEnExistencia.Enabled = False
        DateFechaVencimiento.Enabled = False
        DateFechaRegistro.Enabled = False
        CheckActivo.Enabled = False
    End Sub

    Private Sub ClearForm()
        TxtNombre.Clear()
        TxtTipo.Clear()
        TxtDescripcion.Clear()
        TxtPrecio.Clear()
        TxtEnExistencia.Clear()
        CheckActivo.Checked = False
        'CbmEspecialidad.SelectedIndex = -1
    End Sub

    Private Sub FillProveedor()
        recordset = New DataTable()

        Try
            cmd = New SqlCommand("SELECT DISTINCT IdProveedor, NombreProveedor FROM Proveedor WHERE Categoria = 'Farmaceutica'", con)
            con.Open()

            reader = cmd.ExecuteReader()
            recordset.Load(reader)
            con.Close()
            reader.Close()
            cmd.Dispose()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try

        CbmProveedor.DataSource = recordset
        CbmProveedor.ValueMember = "IdProveedor"
        CbmProveedor.DisplayMember = "NombreProveedor"
        CbmProveedor.SelectedIndex = -1
    End Sub

    Private Function Validator() As Boolean
        Dim isvalid As Boolean = True
        If TxtNombre.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese el tipo examen.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNombre.Focus()
            isvalid = False
        ElseIf TxtTipo.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese la descripcion del tipo examen.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtTipo.Focus()
            isvalid = False
        ElseIf TxtDescripcion.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese la descripcion del tipo examen.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtDescripcion.Focus()
            isvalid = False
        ElseIf CbmProveedor.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese el proveedor.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbmProveedor.Focus()
            isvalid = False
        ElseIf TxtPrecio.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese el costo del examen.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPrecio.Focus()
            isvalid = False
        ElseIf TxtEnExistencia.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese la descripcion del tipo examen.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtEnExistencia.Focus()
            isvalid = False
        End If
        Return isvalid
    End Function

    Private Function ObtenerSiguienteID() As Integer
        Dim siguienteID As Integer = 1
        Dim connectionString As String = "Data Source=OPCODE;Initial Catalog=Sistema_Clinico;User ID=opcode;Password=opcode7"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT ISNULL(MAX(Codigo), 0) + 1 FROM Medicamentos"
            Using command As New SqlCommand(query, connection)
                siguienteID = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return siguienteID
    End Function
    Private Sub GroupMedicamento_Enter(sender As Object, e As EventArgs) Handles GroupMedicamento.Enter

    End Sub

    Private Sub FrmMedicamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtDescripcion.Multiline = True
        TxtDescripcion.ScrollBars = ScrollBars.Vertical
        TxtDescripcion.Height = 100
        FillProveedor()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim siguienteID As Integer = ObtenerSiguienteID()
        TxtId.Text = siguienteID.ToString("0000000")
        TxtId.ReadOnly = True
        BtnGuardar.Visible = True
        BtnAgregar.Visible = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False

        FillProveedor()
        EnabledControls()
        ClearForm()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Validator() Then
            con.Open()

            ' Obtener el nuevo ID antes de la inserción
            Dim siguienteID As Integer = ObtenerSiguienteID()

            Dim cmd As New SqlClient.SqlCommand("sp_Medicamentos", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Identificador", 1)
            cmd.Parameters.AddWithValue("@Codigo", siguienteID.ToString("0000000"))
            cmd.Parameters.AddWithValue("@NombreMedicamento", TxtNombre.Text)
            cmd.Parameters.AddWithValue("@TipoMedicamento", TxtTipo.Text)
            cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text)
            cmd.Parameters.AddWithValue("@IdProveedor", CbmProveedor.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@EnExistencia", TxtEnExistencia.Text)
            cmd.Parameters.AddWithValue("@Precio", TxtPrecio.Text)
            cmd.Parameters.AddWithValue("@FechaDescartado", DateFechaVencimiento.Value)
            cmd.Parameters.AddWithValue("@FechaRegistro", DateFechaRegistro.Value)
            cmd.Parameters.AddWithValue("@FechaModificacion", DateFechaRegistro.Value)
            cmd.Parameters.AddWithValue("@Estado", If(CheckActivo.Checked, 1, 0))

            Try
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
                MessageBox.Show("Error: " & ex.Message)
            Finally
                con.Close()
            End Try

            ' Actualizar el campo ID después de la inserción
            TxtId.Text = siguienteID.ToString("0000000")
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Validator() Then
            con.Open()

            Dim cmd As New SqlClient.SqlCommand("UPDATE Medicamentos
                                                SET NombreMedicamento = @NombreMedicamento, TipoMedicamento = @TipoMedicamento, 
	                                            Descripcion = @Descripcion, EnExistencia = @EnExistencia, Precio = @Precio, 
                                                IdProveedor = @IdProveedor, FechaDescartado = @FechaDescartado, FechaModificacion = GETDATE(), Estado = @Estado
                                                WHERE Codigo = @Codigo", con)

            cmd.Parameters.AddWithValue("@Codigo", TxtId.Text)
            cmd.Parameters.AddWithValue("@NombreMedicamento", TxtNombre.Text)
            cmd.Parameters.AddWithValue("@TipoMedicamento", TxtTipo.Text)
            cmd.Parameters.AddWithValue("@Descripcion", TxtDescripcion.Text)
            cmd.Parameters.AddWithValue("@EnExistencia", TxtEnExistencia.Text)
            cmd.Parameters.AddWithValue("@Precio", TxtPrecio.Text)
            cmd.Parameters.AddWithValue("@IdProveedor", CbmProveedor.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@FechaDescartado", DateFechaVencimiento.Value)
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

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        FillProveedor()
        LblFecha.Text = "Fecha modificacion"
        BtnEditar.Visible = False
        EnabledControls()
        TxtId.ReadOnly = True
        TxtId.Enabled = False
    End Sub

    Private Sub ImagenBuscar_Click(sender As Object, e As EventArgs) Handles ImagenBuscar.Click
        FillProveedor()
        con.Open()

        Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("Select A.Codigo, A.NombreMedicamento, A.TipoMedicamento, A.Descripcion,
	                                         A.EnExistencia, A.Precio, A.IdProveedor, A.FechaDescartado, A.FechaRegistro, 
                                             A.Estado, B.NombreProveedor
                                             From Medicamentos A INNER JOIN Proveedor B ON(A.IdProveedor = B.IdProveedor) 
                                             WHERE NombreMedicamento = '" & TxtBuscar.Text & "'", con)

        reader = cmd.ExecuteReader

        If reader.Read Then
            MessageBox.Show("Información encontrada")
            BtnEditar.Enabled = True
            BtnEliminar.Enabled = True
            BtnAgregar.Visible = True
            TxtBuscar.Text = ""

            TxtId.Text = reader("Codigo").ToString()
            TxtNombre.Text = reader("NombreMedicamento").ToString()
            TxtTipo.Text = reader("TipoMedicamento").ToString()
            TxtDescripcion.Text = reader("Descripcion").ToString()
            CbmProveedor.Text = reader("NombreProveedor").ToString()
            TxtEnExistencia.Text = reader("EnExistencia").ToString()
            TxtPrecio.Text = reader("Precio").ToString()
            DateFechaRegistro.Value = DateTime.Parse(reader("FechaRegistro").ToString())
            DateFechaRegistro.Format = DateTimePickerFormat.Custom
            DateFechaRegistro.CustomFormat = "dd/MM/yyyy"

            DateFechaVencimiento.Value = DateTime.Parse(reader("FechaDescartado").ToString())
            DateFechaVencimiento.Format = DateTimePickerFormat.Custom
            DateFechaVencimiento.CustomFormat = "dd/MM/yyyy"

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
        If String.IsNullOrWhiteSpace(TxtBuscar.Text) OrElse TxtBuscar.Text = "Ingrese nombre de medicamento" Then
            TxtBuscar.Text = ""
            TxtBuscar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtBuscar_MouseLeave(sender As Object, e As EventArgs) Handles TxtBuscar.MouseLeave
        If String.IsNullOrWhiteSpace(TxtBuscar.Text) Then
            TxtBuscar.Text = "Ingrese nombre de medicamento"
            TxtBuscar.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
        con.Open()

        Dim cmd As New SqlClient.SqlCommand("DELETE 
                                             FROM Medicamentos
                                             WHERE Codigo = '" + TxtId.Text + "'", con)

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

    Private Sub GroupMedicamento_ControlAdded(sender As Object, e As ControlEventArgs) Handles GroupMedicamento.ControlAdded
        ClearForm()
        StartForm()
    End Sub
End Class