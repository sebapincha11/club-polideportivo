Imports System.Data.Odbc
Public Class Verificar
    Dim cnn As OdbcConnection
    Dim cmd As OdbcCommand
    Dim rs As OdbcDataReader
    Dim sql As String
    Private Sub Verificar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cnn = New OdbcConnection("DSN = cpl")
            cnn.Open()
            MsgBox("La conexion ha sido realizada con exito")

        Catch ex As Exception
            MsgBox("Fallo la conexion con la base de datos")
        End Try
    End Sub
    Private Sub btnVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificar.Click
        sql = "Select dni From Cliente Where dni=txtRegistrar.text"

    End Sub
End Class