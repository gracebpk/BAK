Imports System.Data.SqlClient

Public Class FrmCategorias





    Dim I As Integer

    Private Sub FrmProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        Call CARGAR_DATAGRIDVIEW()
        Call ARMAR_DATAGRIDVIEW()
        Call BOTONES()
    End Sub


    Private Sub DataGridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.Click
        For I = 0 To Me.DataGridView1.RowCount - 1
            If Me.DataGridView1.Rows(I).Selected = True Then
                P01 = Me.DataGridView1.Rows(I).Cells(0).Value
                P02 = Me.DataGridView1.Rows(I).Cells(1).Value
                Exit Sub
            End If
        Next I
    End Sub


    Public Sub ARMAR_DATAGRIDVIEW()
        DataGridView1.Columns(0).HeaderText = "ID CATEGORIA"
        DataGridView1.Columns(1).HeaderText = "NOMBRE DE CATEGORIA"
        DataGridView1.Columns(0).Visible = True
        DataGridView1.Columns(1).Visible = True
        DataGridView1.Columns(1).Width = 180
    End Sub



    Public Sub CARGAR_DATAGRIDVIEW()
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If
        Try
            ConeccionBD.Abrir_BaseDato()
            Dim DA_U As SqlDataAdapter
            Dim DS_U As New DataSet
            DA_U = New SqlDataAdapter("select * from CATEGORIAS ORDER BY DESCATEGORIA", ConeccionBD.CONECCION)
            DS_U.Clear()
            DA_U.Fill(DS_U, "CATEGORIAS")
            DataGridView1.DataSource = DS_U.Tables("CATEGORIAS")
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub


    Public Sub BOTONES()
        Dim dt_B As DataTable
        Dim DA_P As SqlDataAdapter
        Dim DS_P As New DataSet
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If
        Try
            ConeccionBD.Abrir_BaseDato()
            DA_P = New SqlDataAdapter("select * from CATEGORIAS ORDER BY DESCATEGORIA", ConeccionBD.CONECCION)
            DA_P.Fill(DS_P, "CATEGORIAS")
            Dim cb As New SqlCommandBuilder(DA_P)
            dt_B = New DataTable
            DA_P.Fill(dt_B)
            If dt_B.Rows.Count > 0 Then
                btnNuevo.Enabled = True
                btnEditar.Enabled = True
                btnEliminar.Enabled = True
                TextBox1.Enabled = True
                btnBuscar.Enabled = True
                btnCancelar.Enabled = True
            Else
                btnNuevo.Enabled = True
                btnEditar.Enabled = False
                btnEliminar.Enabled = False
                TextBox1.Enabled = False
                btnBuscar.Enabled = False
                btnCancelar.Enabled = False
            End If
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub CARGAR()
        If ConeccionBD.CONECCION.State = ConnectionState.Open Then
            ConeccionBD.Cerrar_BaseDato()
        End If
        Try
            ConeccionBD.Abrir_BaseDato()
            Dim DA_U As SqlDataAdapter
            Dim DS_U As New DataSet
            DA_U = New SqlDataAdapter("select * from CATEGORIAS WHERE DESCATEGORIA like '%" & TextBox1.Text & "%' ORDER BY DESCATEGORIA", ConeccionBD.CONECCION)
            DS_U.Clear()
            DA_U.Fill(DS_U, "CATEGORIAS")
            DataGridView1.DataSource = DS_U.Tables("CATEGORIAS")
        Catch oExcep As SqlException
            MessageBox.Show("Error: " & ControlChars.CrLf & oExcep.Message & ControlChars.CrLf & oExcep.Server)
        Finally
            If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                ConeccionBD.Cerrar_BaseDato()
            End If
        End Try
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        FrmAgregarCategorias.ShowDialog()
        If CANCELAR_A_E = True Then
            Call CARGAR_DATAGRIDVIEW()
            Call ARMAR_DATAGRIDVIEW()
            Call BOTONES()
        End If
    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        If P01 <> "" And P02 <> "" Then

        Else
            MsgBox("Debe seleccionar el registro que desea Editar", MsgBoxStyle.Information, "Mensaje del Sistema")
            DataGridView1.Focus()
        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If P01 = "" Then
            MsgBox("Debe seleccionar el registro que desea Eliminar", MsgBoxStyle.Information, "Mensaje del Sistema")
            DataGridView1.Focus()
            P01 = "" : P02 = ""
            Exit Sub
        End If
        Dim R
        R = MessageBox.Show("Se dispone a Eliminar este registro de Proveedor, ¿Desea continuar?", "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If R = vbYes Then
            Dim DR As SqlDataReader
            Dim ELIMINA_SQL As String
            ELIMINA_SQL = "DELETE FROM DBO.CATEGORIAS WHERE IDCATEGORIA = '" & P01 & "'"
            Dim ELIMINA_CMD As New SqlCommand(ELIMINA_SQL, ConeccionBD.CONECCION)
            If P01 <> "" Then
                Try
                    ConeccionBD.Abrir_BaseDato()
                    DR = ELIMINA_CMD.ExecuteReader
                    DR.Close()
                    TextBox1.Text = ""
                    Call CARGAR_DATAGRIDVIEW()
                    Call ARMAR_DATAGRIDVIEW()
                    Call BOTONES()
                    P01 = "" : P02 = ""
                Catch oExcep As SqlException
                    If oExcep.ErrorCode = "-2146232060" Then
                        MsgBox("El registro no puede ser Eliminado, se encuentra actualmente en uso", MsgBoxStyle.Information, "Mensaje del Sistema")
                    Else
                        MessageBox.Show("Error: " &
                        ControlChars.CrLf &
                        oExcep.Message & ControlChars.CrLf &
                        oExcep.Server)
                    End If
                Finally
                    If ConeccionBD.CONECCION.State = ConnectionState.Open Then
                        ConeccionBD.Cerrar_BaseDato()
                    End If
                End Try
            End If
        Else
            P01 = "" : P02 = ""
        End If
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Call CARGAR()
        Call ARMAR_DATAGRIDVIEW()
        Call BOTONES()
    End Sub
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Me.Close()
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        TextBox1.Text = ""
        Call CARGAR_DATAGRIDVIEW()
        Call ARMAR_DATAGRIDVIEW()
        Call BOTONES()
    End Sub









End Class