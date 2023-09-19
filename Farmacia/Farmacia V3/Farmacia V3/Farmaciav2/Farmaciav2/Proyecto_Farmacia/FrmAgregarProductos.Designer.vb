<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarProductos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        txtDescripcion = New TextBox()
        txtCantidad = New TextBox()
        txtPrecio = New TextBox()
        cbProveedor = New ComboBox()
        CbCategoria = New ComboBox()
        ChkDescontinuado = New CheckBox()
        Label8 = New Label()
        txtID = New TextBox()
        btnAceptar = New Button()
        btnCerrar = New Button()
        Label6 = New Label()
        txtUnidades = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(60, 67)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 25)
        Label1.TabIndex = 0
        Label1.Text = "Descripción"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(60, 142)
        Label2.Margin = New Padding(5, 0, 5, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 25)
        Label2.TabIndex = 1
        Label2.Text = "Categoria"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(60, 204)
        Label3.Margin = New Padding(5, 0, 5, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 25)
        Label3.TabIndex = 2
        Label3.Text = "Proveedor"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(30, 274)
        Label4.Margin = New Padding(5, 0, 5, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(169, 25)
        Label4.TabIndex = 3
        Label4.Text = "Unidad de Medida"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(49, 372)
        Label5.Margin = New Padding(5, 0, 5, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(139, 25)
        Label5.TabIndex = 4
        Label5.Text = "Precio Unitario"' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(60, 419)
        Label7.Margin = New Padding(5, 0, 5, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 25)
        Label7.TabIndex = 6
        Label7.Text = "Descontinuado"' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(209, 59)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(254, 33)
        txtDescripcion.TabIndex = 7
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Location = New Point(209, 266)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(254, 33)
        txtCantidad.TabIndex = 8
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(209, 369)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(254, 33)
        txtPrecio.TabIndex = 9
        ' 
        ' cbProveedor
        ' 
        cbProveedor.FormattingEnabled = True
        cbProveedor.Location = New Point(209, 196)
        cbProveedor.Name = "cbProveedor"
        cbProveedor.Size = New Size(254, 33)
        cbProveedor.TabIndex = 11
        ' 
        ' CbCategoria
        ' 
        CbCategoria.FormattingEnabled = True
        CbCategoria.Location = New Point(209, 134)
        CbCategoria.Name = "CbCategoria"
        CbCategoria.Size = New Size(254, 33)
        CbCategoria.TabIndex = 12
        ' 
        ' ChkDescontinuado
        ' 
        ChkDescontinuado.AutoSize = True
        ChkDescontinuado.Location = New Point(209, 425)
        ChkDescontinuado.Name = "ChkDescontinuado"
        ChkDescontinuado.Size = New Size(15, 14)
        ChkDescontinuado.TabIndex = 13
        ChkDescontinuado.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(14, 482)
        Label8.Margin = New Padding(5, 0, 5, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 25)
        Label8.TabIndex = 15
        Label8.Text = "IDPRODUCTO"' 
        ' txtID
        ' 
        txtID.Enabled = False
        txtID.Location = New Point(153, 479)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(177, 33)
        txtID.TabIndex = 16
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Location = New Point(336, 478)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(94, 33)
        btnAceptar.TabIndex = 17
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Location = New Point(467, 479)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(94, 33)
        btnCerrar.TabIndex = 18
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(97, 325)
        Label6.Margin = New Padding(5, 0, 5, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 25)
        Label6.TabIndex = 19
        Label6.Text = "Unidades"' 
        ' txtUnidades
        ' 
        txtUnidades.Location = New Point(209, 317)
        txtUnidades.Name = "txtUnidades"
        txtUnidades.Size = New Size(254, 33)
        txtUnidades.TabIndex = 20
        ' 
        ' FrmAgregarProductos
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(608, 568)
        Controls.Add(txtUnidades)
        Controls.Add(Label6)
        Controls.Add(btnCerrar)
        Controls.Add(btnAceptar)
        Controls.Add(txtID)
        Controls.Add(Label8)
        Controls.Add(ChkDescontinuado)
        Controls.Add(CbCategoria)
        Controls.Add(cbProveedor)
        Controls.Add(txtPrecio)
        Controls.Add(txtCantidad)
        Controls.Add(txtDescripcion)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(5)
        Name = "FrmAgregarProductos"
        Text = "FrmAgregarProductos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents cbProveedor As ComboBox
    Friend WithEvents CbCategoria As ComboBox
    Friend WithEvents ChkDescontinuado As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUnidades As TextBox
End Class
