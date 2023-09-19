Imports System.Windows.Forms
Public Class MDI_Factura

    Private Sub FacturasToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem.Click

        ' FrmFactura.ShowDialog()
    End Sub



    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("Esta seguro que desea salir de la Aplicacion?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub FacturasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Frm_Consulta_Facturas.ShowDialog()

    End Sub

    Private Sub AgregarCategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarCategoriasToolStripMenuItem.Click


        Try
            FrmAgregarCategorias.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try


    End Sub

    Private Sub AgregarProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProveedoresToolStripMenuItem.Click
        Try
            FrmAgregarProveedores.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

    End Sub

    Private Sub AgregarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProductosToolStripMenuItem.Click
        Try
            FrmAgregarProductos.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

    End Sub

    Private Sub AgregarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarClientesToolStripMenuItem.Click
        Try
            FrmAgregarClientes.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub ListadoDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeProductosToolStripMenuItem.Click
        Try
            FrmProductos.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub ListadoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        Try
            FrmClientes.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub ListadoDeProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeProveedoresToolStripMenuItem.Click
        Try
            FrmProveedores.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub ListadoDeCategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeCategoriasToolStripMenuItem.Click
        Try
            FrmCategorias.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub AgregarLaboratoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarLaboratoriosToolStripMenuItem.Click
        Try
            FrmAgregarLaboratorios.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub ListadoDeLaboratoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeLaboratoriosToolStripMenuItem.Click
        Try
            FrmLaboratorios.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub AgregarCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarCategoriaToolStripMenuItem.Click
        Try
            FrmAgregarCatTipoVenta.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub ListadoDeCategoriasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListadoDeCategoriasToolStripMenuItem1.Click
        Try
            FrmCatTipoVenta.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
End Class
