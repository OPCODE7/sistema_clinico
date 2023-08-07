Imports System.Data.SqlClient
Public Class FrmEquipoMedico
    Dim connectionString As String = "Data Source=OPCODE;Initial Catalog=Sistema_Clinico;User ID=opcode;Password=opcode7"
    Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
    Dim reader As SqlDataReader
    Dim recordset As DataTable
    Dim cmd As SqlCommand

    Private controlesHabilitados As Boolean = False

    Private Sub EnabledControls()
        TxtTipo.Enabled = True
        TxtMarca.Enabled = True
        TxtCosto.Enabled = True
        CbmProveedor.Enabled = True
        DateFechaDescartado.Enabled = True
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
        TxtMarca.Enabled = False
        TxtCosto.Enabled = False
        CbmProveedor.Enabled = False
        DateFechaDescartado.Enabled = False
        DateFechaRegistro.Enabled = False
        CheckActivo.Enabled = False

    End Sub
    Private Sub ClearForm()
        TxtTipo.Clear()
        TxtMarca.Clear()
        TxtCosto.Clear()
        DateFechaDescartado.Value = Date.Now()
        CheckActivo.Checked = False
        'CbmProveedores.SelectedIndex = -1
    End Sub

    Private Sub FillProveedores()
        recordset = New DataTable()

        Try
            cmd = New SqlCommand("SELECT DISTINCT IdProveedor, NombreProveedor FROM Proveedor WHERE Categoria = 'EquipoMedico'", con)
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
        If TxtTipo.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese el nombre del equipo.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtTipo.Focus()
            isvalid = False
        ElseIf TxtMarca.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese la marca del equipo.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtMarca.Focus()
            isvalid = False
        ElseIf TxtCosto.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese el costo del equipo.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtCosto.Focus()
            isvalid = False
        ElseIf CbmProveedor.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese el proveedor del equipo.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbmProveedor.Focus()
            isvalid = False
        End If
        Return isvalid
    End Function

    Private Function ObtenerSiguienteID() As Integer
        Dim siguienteID As Integer = 1

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT ISNULL(MAX(NumeroInventario), 0) + 1 FROM EquipoMedico"
            Using command As New SqlCommand(query, connection)
                siguienteID = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return siguienteID
    End Function

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TxtTipo_TextChanged(sender As Object, e As EventArgs) Handles TxtTipo.TextChanged

    End Sub

    Private Sub FrmEquipoMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnGuardar.Visible = controlesHabilitados
        TxtId.ReadOnly = True
        TxtId.Enabled = False
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim siguienteID As Integer = ObtenerSiguienteID()
        Dim formattedId As String = siguienteID.ToString("0000000")
        TxtId.Text = formattedId
        TxtId.ReadOnly = True
        BtnGuardar.Visible = True
        BtnAgregar.Visible = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False

        FillProveedores()
        EnabledControls()
        ClearForm()
    End Sub


    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Validator() Then
            con.Open()

            Dim cmd As New SqlClient.SqlCommand("sp_EquipoMedico", con)
            cmd.CommandType = CommandType.StoredProcedure

            Dim siguienteID As Integer = ObtenerSiguienteID()
            Dim formattedId As String = siguienteID.ToString("0000000")

            cmd.Parameters.AddWithValue("@Identificador", 1)
            cmd.Parameters.AddWithValue("@NumeroInventario", formattedId)
            cmd.Parameters.AddWithValue("@NombreEquipo", TxtTipo.Text)
            cmd.Parameters.AddWithValue("@Marca", TxtMarca.Text)
            cmd.Parameters.AddWithValue("@CostoEquipo", TxtCosto.Text)
            cmd.Parameters.AddWithValue("@IdProveedor", CbmProveedor.SelectedValue.ToString())
            cmd.Parameters.AddWithValue("@FechaDescartado", DateFechaDescartado.Value)
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

            TxtId.Text = ObtenerSiguienteID().ToString("0000000")
        End If
    End Sub

    Private Sub PanelEquipoMedico_Paint(sender As Object, e As PaintEventArgs) Handles PanelEquipoMedico.Paint
    End Sub

    Private Sub ImagenBuscar_Click(sender As Object, e As EventArgs) Handles ImagenBuscar.Click
        FillProveedores()
        con.Open()

        Dim cmd As New SqlClient.SqlCommand("Select A.NumeroInventario, A.NombreEquipo, A.Marca, 
                                             A.CostoEquipo, A.IdProveedor, A.FechaRegistro, A.Estado,A.FechaDescartado,A.FechaRegistro, B.NombreProveedor
                                             From EquipoMedico A INNER JOIN Proveedor B ON(A.IdProveedor = B.IdProveedor) 
                                             WHERE NombreEquipo = '" & TxtBuscar.Text & "'", con)

        reader = cmd.ExecuteReader

        If reader.Read Then
            MessageBox.Show("Información encontrada")
            EnabledControls()
            BtnEditar.Enabled = True
            BtnEliminar.Enabled = True
            BtnAgregar.Visible = True

            TxtId.Text = reader("NumeroInventario").ToString()
            TxtTipo.Text = reader("NombreEquipo").ToString()
            TxtMarca.Text = reader("Marca").ToString()
            TxtCosto.Text = reader("CostoEquipo").ToString()
            CbmProveedor.Text = reader("IdProveedor").ToString()
            DateFechaDescartado.Value = DateTime.Parse(reader("FechaDescartado").ToString())
            DateFechaDescartado.Format = DateTimePickerFormat.Custom
            DateFechaDescartado.CustomFormat = "dd/MM/yyyy"

            DateFechaRegistro.Value = DateTime.Parse(reader("FechaRegistro").ToString())
            DateFechaRegistro.Format = DateTimePickerFormat.Custom
            DateFechaRegistro.CustomFormat = "dd/MM/yyyy"

            Dim estado As Integer = Convert.ToInt32(reader("Estado"))
            CheckActivo.Checked = (estado = 1)
            CbmProveedor.Text = reader("NombreProveedor").ToString()

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
        If String.IsNullOrWhiteSpace(TxtBuscar.Text) OrElse TxtBuscar.Text = "Ingrese aquipo medico" Then
            TxtBuscar.Text = ""
            TxtBuscar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtBuscar_MouseLeave(sender As Object, e As EventArgs) Handles TxtBuscar.MouseLeave
        If String.IsNullOrWhiteSpace(TxtBuscar.Text) Then
            TxtBuscar.Text = "Ingrese equipo medico"
            TxtBuscar.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        LblFecha.Text = "Fecha modificacion"
        BtnEditar.Visible = False
        FillProveedores()
        EnabledControls()
        TxtId.ReadOnly = True
        TxtId.Enabled = False
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Validator() Then
            con.Open()

            Dim cmd As New SqlClient.SqlCommand("Update EquipoMedico
	                                        set NombreEquipo = @NombreEquipo, Marca = @Marca, CostoEquipo = @CostoEquipo, 
	                                        IdProveedor = @IdProveedor, FechaDescartado = @FechaDescartado, FechaModificacion = GETDATE(), Estado = @Estado
	                                        where NumeroInventario = @NumeroInventario", con)

            cmd.Parameters.AddWithValue("@NumeroInventario", TxtId.Text)
            cmd.Parameters.AddWithValue("@NombreEquipo", TxtTipo.Text)
            cmd.Parameters.AddWithValue("@Marca", TxtMarca.Text)
            cmd.Parameters.AddWithValue("@CostoEquipo", TxtCosto.Text)
            cmd.Parameters.AddWithValue("@FechaDescartado", DateFechaDescartado.Value)
            cmd.Parameters.AddWithValue("@FechaRegistro", DateFechaRegistro.Value)
            cmd.Parameters.AddWithValue("@FechaModificacion", DateFechaRegistro.Value)
            cmd.Parameters.AddWithValue("@Estado", If(CheckActivo.Checked, 1, 0))
            cmd.Parameters.AddWithValue("@IdProveedor", CbmProveedor.SelectedValue.ToString())


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

        Dim cmd As New SqlClient.SqlCommand("Delete 
                                            from EquipoMedico 
                                            where NumeroInventario = '" + TxtId.Text + "'", con)

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

        Dim query As String = "SELECT NombreEquipo FROM EquipoMedico WHERE NombreEquipo LIKE '%' + @textoBusqueda + '%'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@textoBusqueda", textoBusqueda)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim sugerencia As String = reader("NombreEquipo").ToString()
                        sugerencias.Add(sugerencia)
                    End While
                End Using
            End Using
        End Using

        Return sugerencias
    End Function

    Private Sub GroupTipoMedico_ControlAdded(sender As Object, e As ControlEventArgs) Handles GroupTipoMedico.ControlAdded
        ClearForm()
        StartForm()
        'FiltrarCategorias("Equipo medico")
    End Sub

    'Private Sub FiltrarCategorias(categoriaFiltrada As String)
    '    Dim query As String = "SELECT DISTINCT NombreProveedor FROM Proveedor WHERE Categoria = @categoriaFiltrada"

    '    Using con As New SqlConnection(connectionString)
    '        con.Open()
    '        Using cmd As New SqlCommand(query, con)
    '            cmd.Parameters.AddWithValue("@categoriaFiltrada", categoriaFiltrada)

    '            Using reader As SqlDataReader = cmd.ExecuteReader()
    '                CbmProveedores.Items.Clear() ' Limpia los elementos anteriores del ComboBox
    '                While reader.Read()
    '                    CbmProveedores.Items.Add(reader("NombreProveedor").ToString()) ' Agrega las categorías al ComboBox
    '                End While
    '            End Using
    '        End Using
    '    End Using
    'End Sub

    Private Sub GroupTipoMedico_Enter(sender As Object, e As EventArgs) Handles GroupTipoMedico.Enter

    End Sub
End Class