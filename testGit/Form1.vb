Imports MySql.Data.MySqlClient
Public Class Form1
    Public bandera_cnx As Boolean
    Friend conexion As MySqlConnection
    Dim functions As ConnectionClass = New ConnectionClass

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        functions.requestToDb()
    End Sub

    Public Sub connect()
        Dim nameCharacter As String = "polo"
        Const MyVar = 459
        Const MyInt As Integer = 5
        MsgBox(MyVar)
        MsgBox("¡Su respuesta es correcta!", 0, "Cuadro de Respuesta")
    End Sub

End Class
