Imports System.Data.Odbc
Public Class Registro
    Dim cnn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim rs As OdbcDataReader
    Dim sql As String
    Private Sub Registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cnn = New OdbcConnection("DSN = cpl")
            cnn.Open()
            MsgBox("La conexion ha sido realizada con exito")

        Catch ex As Exception
            MsgBox("Fallo la conexion con la base de datos")
        End Try
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click

        If rdbSocio.Checked And txtNombre.Text <> "" And txtApellido.Text <> "" And txtDni.Text <> "" Then
            TipoSocio.Show()
            Me.Hide()

            MsgBox("Cliente 'Socio' registrado con exito")

        ElseIf rdbNoSocio.Checked And txtNombre.Text <> "" And txtApellido.Text <> "" And txtDni.Text <> "" Then
            Actividades.Show()
            Me.Hide()
            MsgBox("Cliente 'No Socio' registrado con exito")
        Else
            MsgBox("Completar los campos obligatorios")

        End If

    End Sub
End Class
