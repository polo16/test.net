Imports MySql.Data.MySqlClient
Public Class ConnectionClass
    Public bandera_cnx As Boolean
    Friend conexion As MySqlConnection

    Public Sub connectMysql()
        Try
            Dim Host As String = "192.168.13.251:3306"
            Dim falloConexion = 0
            Dim conexion = New MySqlConnection
            Dim conexionTransaccion = New MySqlConnection
            Dim lector As MySqlDataReader
            'ConfigEncryption("puropollo.exe")
            'conexion.ConnectionString = ConfigurationManager.ConnectionStrings("DBConexion").ToString & "Host=" & Host & ";"
            conexion.ConnectionString = "User ID=puropollo;Password=purpmorz2478;Host= 192.168.13.251; Database=test; allow user variables = true;default command timeout=3600; CharSet=utf8;"
            conexionTransaccion.ConnectionString = "User ID=puropollo;Password=purpmorz2478;Host= 192.168.13.251; Database=test; allow user variables = true;default command timeout=3600; CharSet=utf8;"
            conexion.Open()
            MsgBox("La Conexión a MySQL es Correcta")


        Catch ex As MySqlException
            MsgBox("No se ha podido conectar al servidor", MsgBoxStyle.OkOnly, "Puro Pollo")
            MsgBox(ex.Message)
            bandera_cnx = False
        End Try
    End Sub

    Public Function consulta(ByVal sentenciaSql As String) As MySqlDataReader
        connectMysql()
        Dim lectura As MySqlDataReader
        lectura = creadorSentencia(sentenciaSql).ExecuteReader() ' le digo a la variable lectora que lo que tiene que recojer es la ejecucion de la variable comandos
        Return lectura 'retorno una variable del tipo MysqlDataReader
    End Function

    Public Function creadorSentencia(ByVal sentenciaSql As String) As MySqlCommand
        Dim comandos As New MySqlCommand()
        comandos.CommandText = sentenciaSql
        comandos.CommandType = CommandType.Text
        comandos.CommandTimeout = 0
        comandos.Connection = conexion
        Return comandos
    End Function

    Public Sub requestToDb()
        Dim lector As MySqlDataReader
        'Try
        MsgBox("consulta:")
        lector = consulta("select * form test.sucursal where ID_SUCURSAL = 1")
        MsgBox(lector)
        'Catch ex As Exception
        'MsgBox("ERROR en consulta" & ex.Message & "'")

        'End Try
    End Sub
End Class
