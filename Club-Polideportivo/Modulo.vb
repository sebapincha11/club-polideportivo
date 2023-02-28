Imports System.Data.Odbc
Module Modulo
    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs As OdbcDataReader

    'cmd = New OdbcCommand(sql,cnn)
    'cmd.CommandType = CommandType.text
    'rs=cmd.ExecuteReader()
    'cmd.Dispose()

End Module
