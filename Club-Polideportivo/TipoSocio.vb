Public Class TipoSocio
    Private Sub btnAvanzar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvanzar.Click
        If rdbTotal.Checked Then
            Actividades.Show()
            Me.Hide()
        ElseIf rdbParcial.Checked Then
            Actividades.Show()
            Me.Hide()
        End If
    End Sub
End Class