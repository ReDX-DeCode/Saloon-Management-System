Imports MySql.Data.MySqlClient

Public Class Login

    Dim conn As New DBconnection
    Dim com As New MySqlCommand




    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        ' conn = New DBconnection
        ' conn.openDB()
        Dim reader As MySqlDataReader

        Try
            'conn.openDB()
            Dim query As String

            query = "select * from employe where empid = '" & Username.Text & "' and password= '" & Password.Text & "'"
            com = New MySqlCommand(query, conn.openDB)

            reader = com.ExecuteReader

            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While


            If count = 1 Then
                Me.Hide()
                Homepage.Show()

            ElseIf count > 0 Then
                MessageBox.Show("password duplicated")

            Else
                MessageBox.Show("Password or user name in incorrect")

            End If

            conn.closeDB()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally


        End Try




    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Username.Text = ""
        Password.Text = ""


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ext.Click
        conn.closeDB()
        Application.Exit()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub Username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Username.TextChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class