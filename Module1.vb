Imports MySql.Data.MySqlClient
Module Module1
    Public constring As MySqlConnection
    Public cm As MySqlCommand


    Sub connection()

        Try
            constring = New MySqlConnection("server=localhost; username=root; password=; database=gym_login")
            constring.Open()
            MsgBox("Connected to database successfully")
        Catch ex As Exception
            MsgBox("Connection Failed, sumuko kana")

        End Try
    End Sub
End Module
