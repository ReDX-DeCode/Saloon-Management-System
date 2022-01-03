Imports MySql.Data.MySqlClient


Public Class cosmetic
    Dim connection As String = "server=localhost; username=root; password=""; database=saloon"
    Dim conn As New DBconnection
    Dim com As New MySqlCommand
    Dim adpt As New MySqlDataAdapter
    ' conn = New DBconnection()
    Dim reader As MySqlDataReader
    Dim result As Integer
    Dim imgpath As String
    Dim arrimage() As Byte
    Dim sql As String
    Dim con As New MySqlConnection









    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Dim msstream As New System.IO.MemoryStream
            PictureBox1.Image.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = msstream.GetBuffer()
            Dim filesize As UInt32
            filesize = msstream.Length
            msstream.Close()


            ' Dim query As String
            'query = "insert into saloon.cosmetics  values('" + TextBox5.Text + "', '" + TextBox1.Text + "', '" + TextBox3.Text + "', '" + TextBox2.Text + "')"

            com = New MySqlCommand(sql, conn.openDB)
            ' con.Open()

            sql = "insert into saloon.cosmetics(cosid,cos_name,buying_price,seling_price,cos_img)values(@cosid,@cos_name,@buying_price,@seling_price,@cos_img)"
            'com.Connection = con
            com.CommandText = sql

            ' reader = com.ExecuteReader

            com.Parameters.AddWithValue("@cosid", TextBox5.Text)
            com.Parameters.AddWithValue("@cos_name", TextBox1.Text)
            com.Parameters.AddWithValue("@buying_price", TextBox3.Text)
            com.Parameters.AddWithValue("@seling_price", TextBox2.Text)
            com.Parameters.AddWithValue("@cos_img", arrimage)

            Dim x As Integer
            x = com.ExecuteNonQuery()


            MessageBox.Show("Data Inserted")

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox5.Text = ""
            PictureBox1.Image = Nothing





            conn.closeDB()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Dim home = New Homepage
        home.Show()
    End Sub

    Private Sub cosmetic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Application.Exit()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            Dim query As String
            query = "update saloon.cosmetics   set cos_name='" + TextBox1.Text + "',buying_price='" + TextBox3.Text + "',seling_price= '" + TextBox2.Text + "' where cosid ='" & TextBox5.Text & "'"
            com = New MySqlCommand(query, conn.openDB)
            reader = com.ExecuteReader

            MessageBox.Show("Data Updated")


            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox5.Text = ""
            PictureBox1.Image = Nothing






            conn.closeDB()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            


            Dim query As String
            query = "delete from saloon.cosmetics  where cosid ='" & TextBox5.Text & "'"
            com = New MySqlCommand(query, conn.openDB)
            reader = com.ExecuteReader

            MessageBox.Show("Data Deleted")


            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox5.Text = ""






            conn.closeDB()


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Try

            Dim ofd As FileDialog = New OpenFileDialog()

            ofd.Filter = "Img File(*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.png;*.gif;*.jpeg"

            If ofd.ShowDialog() = DialogResult.OK Then
                imgpath = ofd.FileName
                PictureBox1.ImageLocation = imgpath
            End If

            ofd = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())

        End Try


    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class