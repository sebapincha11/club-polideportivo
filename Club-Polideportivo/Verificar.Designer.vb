<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verificar
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
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.txtRegistrar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(68, 189)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(146, 61)
        Me.btnVerificar.TabIndex = 0
        Me.btnVerificar.Text = "VERIFICAR"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Location = New System.Drawing.Point(123, 80)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(26, 13)
        Me.lbl6.TabIndex = 1
        Me.lbl6.Text = "DNI"
        '
        'txtRegistrar
        '
        Me.txtRegistrar.Location = New System.Drawing.Point(86, 108)
        Me.txtRegistrar.Name = "txtRegistrar"
        Me.txtRegistrar.Size = New System.Drawing.Size(100, 20)
        Me.txtRegistrar.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "VERIFICACION DE CLIENTES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Verificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRegistrar)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.btnVerificar)
        Me.Name = "Verificar"
        Me.Text = "Verificar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents txtRegistrar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
