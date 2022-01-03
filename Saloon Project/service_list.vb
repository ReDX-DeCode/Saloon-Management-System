Imports MySql.Data.MySqlClient

Public Class service_list


    Dim conn As New DBconnection
    Dim com As New MySqlCommand
    Dim adpt As New MySqlDataAdapter
    Dim reader As MySqlDataReader

  
    Private Sub service_list_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        bindgrid()


    End Sub




    Public Sub bindgrid()

        Using conn As MySqlConnection = New MySqlConnection("server=localhost;username=root;password=;database=saloon")
            conn.Open()
            Using cmd As MySqlCommand = New MySqlCommand("select * from service", conn)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As New DataTable
                da.Fill(dt)
                DataGridView1.DataSource = dt




            End Using

        End Using


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try

            Dim query As String
            query = "insert into saloon.service  values('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "')"
            com = New MySqlCommand(query, conn.openDB)
            reader = com.ExecuteReader

            MessageBox.Show("Data Inserted")

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
           



            conn.closeDB()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try



    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try

            Dim query As String
            query = "update saloon.service  set s_name='" + TextBox2.Text + "',price='" + TextBox3.Text + "' where s_id ='" & TextBox1.Text & "'"
            com = New MySqlCommand(query, conn.openDB)
            reader = com.ExecuteReader

            MessageBox.Show("Data Updated")


            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
           


            conn.closeDB()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Try

            Dim query As String
            query = "delete from saloon.service where s_id ='" & TextBox1.Text & "'"
            com = New MySqlCommand(query, conn.openDB)
            reader = com.ExecuteReader

            MessageBox.Show("Data Deleted")


            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
           



            conn.closeDB()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Dim home = New Homepage
        home.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class