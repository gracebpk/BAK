<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarCatTipoVenta
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
        Label2 = New Label()
        Label1 = New Label()
        txtNombre = New TextBox()
        txtID = New TextBox()
        btnCancelar = New Button()
        btnAceptar = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(27, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(197, 25)
        Label2.TabIndex = 27
        Label2.Text = "Nombre de Categoria"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(208, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 25)
        Label1.TabIndex = 26
        Label1.Text = "ID"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(256, 95)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(229, 23)
        txtNombre.TabIndex = 25
        ' 
        ' txtID
        ' 
        txtID.Enabled = False
        txtID.Location = New Point(256, 46)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(229, 23)
        txtID.TabIndex = 24
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(341, 184)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 31
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Location = New Point(133, 184)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(75, 23)
        btnAceptar.TabIndex = 30
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' FrmAgregarCatTipoVenta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(570, 236)
        Controls.Add(btnCancelar)
        Controls.Add(btnAceptar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNombre)
        Controls.Add(txtID)
        Name = "FrmAgregarCatTipoVenta"
        Text = "FrmAgregarCatTipoVenta"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
End Class
