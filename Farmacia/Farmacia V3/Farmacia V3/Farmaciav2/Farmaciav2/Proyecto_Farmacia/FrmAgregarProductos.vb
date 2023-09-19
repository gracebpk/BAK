Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class FrmAgregarProductos

    Dim EXISTE_PRODUCTO As Boolean
    Private categoriaadapter As New SqlDataAdapter
    Private proveedoradapter As New SqlDataAdapter
    Private posicion As Integer
    Private posicionCB As Integer
    Dim categoriadataset As New DataSet
    Dim proveedordataset As New DataSet

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        CANCELAR_A_E = False
        Me.Close()
        ClearTextBoxes()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
            ConeccionBD.Abrir_BaseDato()
        Else
            ConeccionBD.Abrir_BaseDato()
        End If


        If Me.txtID.Text = " " Or txtCantidad.Text = " " Or txtDescripcion.Text = " " Or txtPrecio.Text = " " Then
            MsgBox("Uno o más campos están vacios o malos. Por favor revise e intente otra vez", MsgBoxStyle.Information, "Mensaje del Sistema")
            txtID.Focus()
            Exit Sub
        End If

        Call BUSCAR_SI_YA_EXISTE_PRODUCTO()
        If EXISTE_PRODUCTO = True Then
            MsgBox("Este Producto ya fue ingresado con anterioridad", MsgBoxStyle.Information, "Mensaje del sistema")
            txtDescripcion.Focus()
            Exit Sub
        End If


        Call GENERAR_CODIGO_ID_PRODUCTO()
        Dim Insertar As String
        Dim Cmd_Add As SqlCommand
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If


        ' Declaración de Variable para ver si está descontinuado o no
        Dim isChecked As Boolean = ChkDescontinuado.Checked
        Dim valueToStore As Integer = If(isChecked, 1, 0)

        If CInt(txtUnidades.Text) < 1 Then
            MsgBox("Las unidades no pueden ser menores que 1")
            Exit Sub
        End If

        ' Utiliza parámetros para evitar SQL Injection y mejorar la legibilidad del código
        Insertar = "INSERT INTO DBO.PRODUCTOS (ID_PRODUCTO, DES_PRODUCTO, ID_CATEGORIA, ID_PROVEEDOR, CANT_X_PRESENTACION, PRECIO_UNIT, UNIDADES_INV, DESCONTINUADO) VALUES (@ID_PRODUCTO, @DES_PRODUCTO, @ID_CATEGORIA, @ID_PROVEEDOR, @CANT_X_PRESENTACION, @PRECIO_UNIT, @UNIDADES_INV, @DESCONTINUADO)"
        Try
            Call ConeccionBD.Abrir_BaseDato()
            Cmd_Add = New SqlCommand(Insertar, ConeccionBD.CONECCION)
            Cmd_Add.Parameters.AddWithValue("@ID_PRODUCTO", CInt(txtID.Text))
            Cmd_Add.Parameters.AddWithValue("@DES_PRODUCTO", UCase(Me.txtDescripcion.Text))
            Cmd_Add.Parameters.AddWithValue("@ID_CATEGORIA", Me.CbCategoria.SelectedValue)
            Cmd_Add.Parameters.AddWithValue("@ID_PROVEEDOR", Me.cbProveedor.SelectedValue)
            Cmd_Add.Parameters.AddWithValue("@CANT_X_PRESENTACION", UCase(Me.txtCantidad.Text))
            Cmd_Add.Parameters.AddWithValue("@PRECIO_UNIT", UCase(Me.txtPrecio.Text))
            Cmd_Add.Parameters.AddWithValue("@UNIDADES_INV", CInt(Me.txtUnidades.Text))
            Cmd_Add.Parameters.AddWithValue("@DESCONTINUADO", valueToStore)
            Cmd_Add.ExecuteNonQuery()
            MsgBox("Registro guardado")
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try

        CANCELAR_A_E = True
        Close()
        ClearTextBoxes()

    End Sub

    Private Sub BUSCAR_SI_YA_EXISTE_PRODUCTO()
        Dim cmbuscar As SqlCommand
        Dim drbuscar As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            cmbuscar = New SqlCommand("SELECT * FROM DBO.PRODUCTOS WHERE DES_PRODUCTO = @DES_PRODUCTO", ConeccionBD.CONECCION)
            cmbuscar.Parameters.AddWithValue("@DES_PRODUCTO", txtDescripcion.Text)
            drbuscar = cmbuscar.ExecuteReader()

            If drbuscar.HasRows Then
                EXISTE_PRODUCTO = True
            Else
                EXISTE_PRODUCTO = False
            End If

            drbuscar.Close()
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub GENERAR_CODIGO_ID_PRODUCTO()

        Dim VALOR_ID_PRODUCTO As Integer
        Dim VALOR_DR As SqlDataReader
        txtID.Text = 0
        CADENA_SQL = "SELECT * FROM DBO.PRODUCTOS ORDER BY ID_PRODUCTO"
        Dim COMMAND1 As New SqlCommand(CADENA_SQL, ConeccionBD.CONECCION)
        Try
            ConeccionBD.Abrir_BaseDato()
            VALOR_DR = COMMAND1.ExecuteReader
            If (VALOR_DR.HasRows) Then
                While VALOR_DR.Read()
                    VALOR_ID_PRODUCTO = VALOR_DR("ID_PRODUCTO").ToString
                    txtID.Text = VALOR_ID_PRODUCTO + 1
                End While
            End If
            If txtID.Text = "" Or txtID.Text = 0 Then
                txtID.Text = 1
            End If
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try


    End Sub

    Private Sub FrmAgregarProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        posicion = 0
        Me.CargaDatos()
    End Sub

    Private Sub CargaDatos()

        'Declaramos variable para manipular registros con DataRow
        'Dim odatarow As DataRow
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If
        Try
            ConeccionBD.Abrir_BaseDato()
            Dim categoriadatarow As DataRow
            Dim proveedordatarow As DataRow

            'Relacionamos los adapter con las tablas a traves de consultas Select
            Me.categoriaadapter = New SqlDataAdapter("Select * from CATEGORIAS", ConeccionBD.CONECCION)
            Me.proveedoradapter = New SqlDataAdapter("Select * from PROVEEDORES", ConeccionBD.CONECCION)

            'Limpiamos el DataSet
            categoriadataset.Clear()
            proveedordataset.Clear()

            'abrimos la conexion
            'ConeccionBD.CONECCION.Open()
            'Llenamos el DataAdapter con el metodo Fill invocando el DataSet
            Me.categoriaadapter.Fill(categoriadataset, "CATEGORIAS")
            Me.proveedoradapter.Fill(proveedordataset, "PROVEEDORES")

            'cerramos la conexion
            'ConeccionBD.CONECCION.Close()
            'establecemos que la variable odatarow va a cargar el primer registro
            posicionCB = 0
            categoriadatarow = Me.categoriadataset.Tables("CATEGORIAS").Rows(posicionCB)
            proveedordatarow = Me.proveedordataset.Tables("PROVEEDORES").Rows(posicionCB)

            'Establecemos variables para datatable y relacionamos con su respectivo DataSet
            Dim dt As DataTable = categoriadataset.Tables(0)
            Dim dt2 As DataTable = proveedordataset.Tables(0)

            'Asignamos la propiedad DisplayMember y ValueMember de los combobox
            Me.CbCategoria.DataSource = categoriadataset.Tables("CATEGORIAS")
            Me.CbCategoria.DisplayMember = "DESCATEGORIA"
            Me.CbCategoria.ValueMember = "IDCATEGORIA"
            Me.cbProveedor.DataSource = proveedordataset.Tables("PROVEEDORES")
            Me.cbProveedor.DisplayMember = "NOMBREPROVEEDOR"
            Me.cbProveedor.ValueMember = "IDPROVEEDOR"

        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub ClearTextBoxes()
        txtCantidad.Clear()
        txtDescripcion.Clear()
        txtID.Clear()
        txtPrecio.Clear()
        ChkDescontinuado.Checked = False


    End Sub


End Class



