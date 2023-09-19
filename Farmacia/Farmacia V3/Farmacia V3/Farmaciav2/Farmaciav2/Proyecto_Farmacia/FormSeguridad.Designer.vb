<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSeguridad
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
        PictureBox1 = New PictureBox()
        txtCargarUsuario = New TextBox()
        txtCargarContraseña = New TextBox()
        txtContraseña = New TextBox()
        txtUsuario = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnAceptar = New Button()
        btnCancelar = New Button()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.users_4071826_3408814_0
        PictureBox1.Location = New Point(41, 94)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(147, 137)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txtCargarUsuario
        ' 
        txtCargarUsuario.Location = New Point(306, 147)
        txtCargarUsuario.Name = "txtCargarUsuario"
        txtCargarUsuario.Size = New Size(100, 23)
        txtCargarUsuario.TabIndex = 1
        ' 
        ' txtCargarContraseña
        ' 
        txtCargarContraseña.Location = New Point(306, 208)
        txtCargarContraseña.Name = "txtCargarContraseña"
        txtCargarContraseña.Size = New Size(100, 23)
        txtCargarContraseña.TabIndex = 2
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(166, 343)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.Size = New Size(240, 23)
        txtContraseña.TabIndex = 3
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(166, 292)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(240, 23)
        txtUsuario.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(76, 285)
        Label1.Name = "Label1"
        Label1.Size = New Size(83, 30)
        Label1.TabIndex = 5
        Label1.Text = "Usuario"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(41, 336)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 30)
        Label2.TabIndex = 6
        Label2.Text = "Contraseña"
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Location = New Point(80, 418)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(75, 23)
        btnAceptar.TabIndex = 7
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(331, 418)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(75, 23)
        btnCancelar.TabIndex = 8
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(80, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(333, 45)
        Label3.TabIndex = 9
        Label3.Text = "Validación de Acceso"
        ' 
        ' FormSeguridad
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(509, 484)
        Controls.Add(Label3)
        Controls.Add(btnCancelar)
        Controls.Add(btnAceptar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtUsuario)
        Controls.Add(txtContraseña)
        Controls.Add(txtCargarContraseña)
        Controls.Add(txtCargarUsuario)
        Controls.Add(PictureBox1)
        Name = "FormSeguridad"
        Text = "FormSeguridad"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCargarUsuario As TextBox
    Friend WithEvents txtCargarContraseña As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label3 As Label
End Class
