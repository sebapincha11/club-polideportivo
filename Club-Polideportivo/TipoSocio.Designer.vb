<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TipoSocio
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
        Me.rdbTotal = New System.Windows.Forms.RadioButton()
        Me.rdbParcial = New System.Windows.Forms.RadioButton()
        Me.btnAvanzar = New System.Windows.Forms.Button()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rdbTotal
        '
        Me.rdbTotal.AutoSize = True
        Me.rdbTotal.Location = New System.Drawing.Point(87, 123)
        Me.rdbTotal.Name = "rdbTotal"
        Me.rdbTotal.Size = New System.Drawing.Size(49, 17)
        Me.rdbTotal.TabIndex = 0
        Me.rdbTotal.TabStop = True
        Me.rdbTotal.Text = "Total"
        Me.rdbTotal.UseVisualStyleBackColor = True
        '
        'rdbParcial
        '
        Me.rdbParcial.AutoSize = True
        Me.rdbParcial.Location = New System.Drawing.Point(207, 123)
        Me.rdbParcial.Name = "rdbParcial"
        Me.rdbParcial.Size = New System.Drawing.Size(57, 17)
        Me.rdbParcial.TabIndex = 1
        Me.rdbParcial.TabStop = True
        Me.rdbParcial.Text = "Parcial"
        Me.rdbParcial.UseVisualStyleBackColor = True
        '
        'btnAvanzar
        '
        Me.btnAvanzar.Location = New System.Drawing.Point(58, 199)
        Me.btnAvanzar.Name = "btnAvanzar"
        Me.btnAvanzar.Size = New System.Drawing.Size(224, 74)
        Me.btnAvanzar.TabIndex = 2
        Me.btnAvanzar.Text = "AVANZAR"
        Me.btnAvanzar.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(93, 40)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(151, 13)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "¿Que tipo de socio desea ser?"
        '
        'TipoSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 302)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.btnAvanzar)
        Me.Controls.Add(Me.rdbParcial)
        Me.Controls.Add(Me.rdbTotal)
        Me.Name = "TipoSocio"
        Me.Text = "TipoSocio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbTotal As System.Windows.Forms.RadioButton
    Friend WithEvents rdbParcial As System.Windows.Forms.RadioButton
    Friend WithEvents btnAvanzar As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
End Class
