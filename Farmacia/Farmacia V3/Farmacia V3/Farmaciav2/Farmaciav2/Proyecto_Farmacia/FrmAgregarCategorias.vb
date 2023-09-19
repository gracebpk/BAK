Imports System.Data.SqlClient

Public Class FrmAgregarCategorias

    Dim EXISTE_CATEGORIA As Boolean
    Dim EXISTE_ID As Boolean
    Dim Cmd_Add As SqlCommand

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click


        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        Else
            ConeccionBD.Abrir_BaseDato()
        End If


        If Me.txtDescripcion.Text = " " Then
            MsgBox("Debe digitar el ID de la Categoria que desea agregar", MsgBoxStyle.Information, "Mensaje del Sistema")
            txtID.Focus()
            Exit Sub
        End If



        Call BUSCAR_SI_YA_EXISTE_CATEGORIA()
        If EXISTE_CATEGORIA = True Then
            MsgBox("Esta Categoria ya fue ingresado con anterioridad", MsgBoxStyle.Information, "Mensaje del sistema")
            txtDescripcion.Focus()
            Exit Sub
        End If

        Call BUSCAR_SI_YA_EXISTE_ID()
        If EXISTE_CATEGORIA = True Then
            MsgBox("Este ID ya fue ingresado con anterioridad", MsgBoxStyle.Information, "Mensaje del sistema")
            txtID.Focus()
            Exit Sub
        End If


        Dim Insertar As String
        Dim Cmd_Add As SqlCommand
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If





        Insertar = "Insert Into DBO.CATEGORIAS (IDCATEGORIA, DESCATEGORIA)values('" & CInt(txtID.Text) & "','" & (Me.txtDescripcion.Text) & "')"

        Try
            Call ConeccionBD.Abrir_BaseDato()
            Cmd_Add = New SqlCommand(Insertar, ConeccionBD.CONECCION)
            Cmd_Add.ExecuteNonQuery()
            MsgBox("registro guardado")
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


    Private Sub BUSCAR_SI_YA_EXISTE_CATEGORIA()
        Dim cmbuscar As SqlCommand
        Dim drbuscar As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            cmbuscar = New SqlCommand("SELECT * FROM DBO.CATEGORIAS WHERE DESCATEGORIA = @Categoria", ConeccionBD.CONECCION)
            cmbuscar.Parameters.AddWithValue("@Categoria", txtDescripcion.Text)
            drbuscar = cmbuscar.ExecuteReader()

            If drbuscar.HasRows Then
                EXISTE_CATEGORIA = True
            Else
                EXISTE_CATEGORIA = False
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


    Private Sub BUSCAR_SI_YA_EXISTE_ID()
        Dim cmbuscar As SqlCommand
        Dim drbuscar As SqlDataReader

        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If

        Try
            ConeccionBD.Abrir_BaseDato()
            cmbuscar = New SqlCommand("SELECT * FROM DBO.CATEGORIAS WHERE IDCATEGORIA = @IDCATEGORIA", ConeccionBD.CONECCION)
            cmbuscar.Parameters.AddWithValue("@IDCATEGORIA", CInt(txtID.Text))
            drbuscar = cmbuscar.ExecuteReader()

            If drbuscar.HasRows Then
                EXISTE_ID = True
            Else
                EXISTE_ID = False
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




    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True ' Ignore the input
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CANCELAR_A_E = False
        Me.Close()
        ClearTextBoxes()
    End Sub

    Private Sub ClearTextBoxes()
        txtDescripcion.Clear()
        txtID.Clear()


    End Sub







End Class