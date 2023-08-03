Imports System.Data.SqlClient
Public Class FrmProveedores
    Dim connectionString As String = "Data Source=DESKTOP-FUNN0TB\MSSQLSERVER2019;Initial Catalog=Sistema_Clinico;User ID=sa;Password=12345"
    Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
    Dim reader As SqlDataReader
    Dim recordset As DataTable
    Dim cmd As SqlCommand

    Private controlesHabilitados As Boolean = False

    Private Sub EnabledControls()
        TxtProveedor.Enabled = True
        TxtVendedor.Enabled = True
        CbmCategoria.Enabled = True
        TxtDirección.Enabled = True
        TxtCorreo.Enabled = True
        TxtTelefono.Enabled = True
        DateFechaRegistro.Enabled = True
        CheckActivo.Enabled = True
    End Sub

    Private Sub StartForm()
        BtnGuardar.Visible = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        TxtId.ReadOnly = True
        TxtId.Enabled = False
        TxtProveedor.Enabled = False
        TxtVendedor.Enabled = False
        CbmCategoria.Enabled = False
        TxtDirección.Enabled = False
        TxtCorreo.Enabled = False
        TxtTelefono.Enabled = False
        DateFechaRegistro.Enabled = False
        CheckActivo.Enabled = False

    End Sub
    Private Sub ClearForm()
        TxtProveedor.Clear()
        TxtVendedor.Clear()
        TxtDirección.Clear()
        TxtCorreo.Clear()
        TxtTelefono.Clear()
        CheckActivo.Checked = False
    End Sub

    Private Function Validator() As Boolean
        Dim isvalid As Boolean = True
        If TxtProveedor.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese el proveedor.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtProveedor.Focus()
            isvalid = False
        ElseIf TxtVendedor.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese el nombre del vendedor.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtVendedor.Focus()
            isvalid = False
        ElseIf CbmCategoria.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese ingrese la categoria del proveedor.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CbmCategoria.Focus()
            isvalid = False
        ElseIf TxtDirección.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese el nombre del vendedor.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtDirección.Focus()
            isvalid = False
        ElseIf TxtCorreo.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese el nombre del vendedor.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtCorreo.Focus()
            isvalid = False
        ElseIf TxtTelefono.Text.Trim().Length = 0 Then
            MessageBox.Show("Por favor, ingrese el nombre del vendedor.", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtTelefono.Focus()
            isvalid = False
        End If
        Return isvalid
    End Function

    Private Function ObtenerSiguienteID() As Integer
        Dim siguienteID As Integer = 1
        Dim connectionString As String = "Data Source=DESKTOP-FUNN0TB\MSSQLSERVER2019;Initial Catalog=Sistema_Clinico;User ID=sa;Password=12345"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT ISNULL(MAX(IdProveedor), 0) + 1 FROM Proveedor"
            Using command As New SqlCommand(query, connection)
                siguienteID = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return siguienteID
    End Function

    Private Sub LlenarCategoria()
        CbmCategoria.Items.Clear()

        CbmCategoria.Items.Add("Farmacéutica")
        CbmCategoria.Items.Add("Equipo medico")
    End Sub

    Private Sub FrmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtDirección.Multiline = True
        TxtDirección.ScrollBars = ScrollBars.Vertical
        TxtDirección.Height = 100
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

    Private Sub PanelProveedores_Paint(sender As Object, e As PaintEventArgs) Handles PanelProveedores.Paint
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        LlenarCategoria()
        If Validator() Then
            con.Open()

            Dim cmd As New SqlClient.SqlCommand("sp_Proveedor", con)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@Identificador", 1)
            cmd.Parameters.AddWithValue("@IdProveedor", ObtenerSiguienteID)
            cmd.Parameters.AddWithValue("@NombreProveedor", TxtProveedor.Text)
            cmd.Parameters.AddWithValue("@NombreVendedor", TxtVendedor.Text)
            cmd.Parameters.AddWithValue("@Categoria", CbmCategoria.Text)
            cmd.Parameters.AddWithValue("@Direccion", TxtDirección.Text)
            cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text)
            cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text)
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
        LlenarCategoria()
        Dim con As New SqlClient.SqlConnection(My.Settings.SistemaClinico)
        con.Open()

        Dim reader As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand("Select Proveedor.IdProveedor, Proveedor.NombreProveedor, Proveedor.NombreVendedor, 
                                             Proveedor.Categoria, Proveedor.Direccion, Proveedor.Telefono, Proveedor.Correo, Proveedor.FechaRegistro, Proveedor.Estado
                                             From Proveedor
                                             WHERE NombreProveedor = '" & TxtBuscar.Text & "'", con)

        reader = cmd.ExecuteReader

        If reader.Read Then
            MessageBox.Show("Información encontrada")
            BtnEditar.Enabled = True
            BtnEliminar.Enabled = True
            BtnAgregar.Visible = True
            TxtBuscar.Text = ""

            TxtId.Text = reader("IdProveedor").ToString()
            TxtProveedor.Text = reader("NombreProveedor").ToString()
            TxtVendedor.Text = reader("NombreVendedor").ToString()
            CbmCategoria.Text = reader("Categoria").ToString()
            TxtDirección.Text = reader("Direccion").ToString()
            TxtTelefono.Text = reader("Telefono").ToString()
            TxtCorreo.Text = reader("Correo").ToString()
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
        If String.IsNullOrWhiteSpace(TxtBuscar.Text) OrElse TxtBuscar.Text = "Ingrese nombre del proveedor" Then
            TxtBuscar.Text = ""
            TxtBuscar.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtBuscar_MouseLeave(sender As Object, e As EventArgs) Handles TxtBuscar.MouseLeave
        If String.IsNullOrWhiteSpace(TxtBuscar.Text) Then
            TxtBuscar.Text = "Ingrese nombre del proveedor"
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
        LlenarCategoria()
        If Validator() Then
            con.Open()

            Dim cmd As New SqlClient.SqlCommand("UPDATE Proveedor
                                                SET NombreProveedor = @NombreProveedor, NombreVendedor = @NombreVendedor,
                                                Categoria = @Categoria, Direccion = @Direccion, Telefono = @Telefono, Correo = @Correo, FechaModificacion = GETDATE(), Estado = @Estado
                                                WHERE IdProveedor = @IdProveedor", con)

            cmd.Parameters.AddWithValue("@IdProveedor", TxtId.Text)
            cmd.Parameters.AddWithValue("@NombreProveedor", TxtProveedor.Text)
            cmd.Parameters.AddWithValue("@NombreVendedor", TxtVendedor.Text)
            cmd.Parameters.AddWithValue("@Categoria", CbmCategoria.Text)
            cmd.Parameters.AddWithValue("@Direccion", TxtDirección.Text)
            cmd.Parameters.AddWithValue("@Telefono", TxtTelefono.Text)
            cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text)
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

        LlenarCategoria()

        Dim cmd As New SqlClient.SqlCommand("DELETE 
                                             FROM Proveedor
                                             WHERE IdProveedor = '" + TxtId.Text + "'", con)

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
        Dim query As String = "SELECT NombreProveedor FROM Proveedor WHERE NombreProveedor LIKE '%' + @textoBusqueda + '%'"

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@textoBusqueda", textoBusqueda)

                Using reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim sugerencia As String = reader("NombreProveedor").ToString()
                        sugerencias.Add(sugerencia)
                    End While
                End Using
            End Using
        End Using

        Return sugerencias
    End Function

    Private Sub GroupProveedores_ControlAdded(sender As Object, e As ControlEventArgs) Handles GroupProveedores.ControlAdded
        ClearForm()
        StartForm()
        LlenarCategoria()
    End Sub
End Class