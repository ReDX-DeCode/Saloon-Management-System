Imports MySql.Data.MySqlClient


Public Class employe

    Dim conn As New DBconnection
    Dim com As New MySqlCommand
    Dim adpt As New MySqlDataAdapter
    'conn = New DBconnection()
    Dim reader As MySqlDataReader




    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Dim home = New Homepage
        home.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Application.Exit()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub employe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        bindgrid()




    End Sub
    
    Public Sub bindgrid()

        Using conn As MySqlConnection = New MySqlConnection("server=localhost;username=root;password=;database=saloon")
            conn.Open()
            Using cmd As MySqlCommand = New MySqlCommand("select * from employe", conn)
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
            query = "insert into saloon.employe  values('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox4.Text + "', '" + TextBox3.Text + "', '" + TextBox5.Text + "', '" + TextBox6.Text + "')"
            com = New MySqlCommand(query, conn.openDB)
            reader = com.ExecuteReader

            MessageBox.Show("Data Inserted")

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""



            conn.closeDB()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try



    End Sub





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            Dim query As String
            query = "update saloon.employe  set emp_name='" + TextBox2.Text + "',emp_age='" + TextBox4.Text + "',emp_salary= '" + TextBox3.Text + "',emp_phone= '" + TextBox5.Text + "',password='" + TextBox6.Text + "' where empid ='" & TextBox1.Text & "'"
            com = New MySqlCommand(query, conn.openDB)
            reader = com.ExecuteReader

            MessageBox.Show("Data Updated")


            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""




            conn.closeDB()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub





    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            Dim query As String
            query = "delete from saloon.employe where empid ='" & TextBox1.Text & "'"
            com = New MySqlCommand(query, conn.openDB)
            reader = com.ExecuteReader

            MessageBox.Show("Data Deleted")


            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""



            conn.closeDB()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class