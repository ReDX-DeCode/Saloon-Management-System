Imports MySql.Data.MySqlClient

Public Class DBconnection
    Public conn As New MySqlConnection("server=localhost;username=root;password=;database=saloon")
    Public Function openDB()
        Try
            conn.Open()
            Newlogin.Label2.Text = "         welcome"

        Catch ex As Exception
            Newlogin.Label2.Text = "Something wrong"
            MsgBox(ex.Message)

        End Try
        Return conn

    End Function

    Public Function closeDB()
        Try
            conn.Close()



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return conn
    End Function

    Function CreateCommand() As MySqlCommand
        Throw New NotImplementedException
    End Function

End Class