<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.rdbSocio = New System.Windows.Forms.RadioButton()
        Me.rdbNoSocio = New System.Windows.Forms.RadioButton()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(88, 27)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(136, 13)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "REGISTRO DE CLIENTES"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(154, 73)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(154, 109)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 2
        '
        'rdbSocio
        '
        Me.rdbSocio.AutoSize = True
        Me.rdbSocio.Location = New System.Drawing.Point(113, 267)
        Me.rdbSocio.Name = "rdbSocio"
        Me.rdbSocio.Size = New System.Drawing.Size(58, 17)
        Me.rdbSocio.TabIndex = 3
        Me.rdbSocio.TabStop = True
        Me.rdbSocio.Text = "SOCIO"
        Me.rdbSocio.UseVisualStyleBackColor = True
        '
        'rdbNoSocio
        '
        Me.rdbNoSocio.AutoSize = True
        Me.rdbNoSocio.Location = New System.Drawing.Point(177, 267)
        Me.rdbNoSocio.Name = "rdbNoSocio"
        Me.rdbNoSocio.Size = New System.Drawing.Size(77, 17)
        Me.rdbNoSocio.TabIndex = 4
        Me.rdbNoSocio.TabStop = True
        Me.rdbNoSocio.Text = "NO SOCIO"
        Me.rdbNoSocio.UseVisualStyleBackColor = True
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(153, 147)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 20)
        Me.txtDni.TabIndex = 5
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(154, 182)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 6
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(49, 76)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(99, 13)
        Me.lbl2.TabIndex = 7
        Me.lbl2.Text = "Nombre (necesario)"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(49, 109)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(99, 13)
        Me.lbl3.TabIndex = 8
        Me.lbl3.Text = "Apellido (necesario)"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(49, 182)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(98, 13)
        Me.lbl4.TabIndex = 9
        Me.lbl4.Text = "Telefono (opcional)"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(49, 225)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(101, 13)
        Me.lbl5.TabIndex = 10
        Me.lbl5.Text = "Direccion (opcional)"
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(86, 317)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(144, 69)
        Me.btnRegistrar.TabIndex = 11
        Me.btnRegistrar.Text = "REGISTRAR"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Location = New System.Drawing.Point(61, 147)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(81, 13)
        Me.lbl6.TabIndex = 12
        Me.lbl6.Text = "DNI (necesario)"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(153, 222)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 13
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(49, 271)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(59, 13)
        Me.lbl.TabIndex = 14
        Me.lbl.Text = "(necesario)"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 421)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.rdbNoSocio)
        Me.Controls.Add(Me.rdbSocio)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lbl1)
        Me.Name = "Registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents rdbSocio As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNoSocio As System.Windows.Forms.RadioButton
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lbl As System.Windows.Forms.Label

End Class
