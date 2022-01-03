Imports MySql.Data.MySqlClient
Imports System.IO




Public Class cosmetics

    Dim amount As Double
    Dim count As Integer
    Dim grosstotal As Double
    Dim nettotal As Double
    Dim item As New ListView
    Dim ng As Integer = 0




    Dim connection As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=saloon")


    Private Sub cosmetics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load





    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cal.Click

        Dim command As New MySqlCommand("SELECT `cosid`, `cos_name`, `seling_price`, `cos_img` FROM `cosmetics`  WHERE `cosid` = @ID", connection)

        command.Parameters.Add("@ID", MySqlDbType.UInt64).Value = cosID.Text

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()



        Try

            adapter.Fill(table)

            Dim imgByte() As Byte

            If table.Rows.Count = 1 Then

                '  TextBox3.Text = table(0)(2)
                ' TextBox2.Text = table(0)(2)
                'TextBox2.Text = table(0)(2)
                imgByte = table(0)(3)

                Dim ms As New MemoryStream(imgByte)
                PictureBox1.Image = Image.FromStream(ms)

            Else

                MessageBox.Show("No Data Found")

                Name.Text = ""
                op.Text = ""

                PictureBox1.Image = Nothing

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

            op.Text = ""
            Name.Text = ""

            PictureBox1.Image = Nothing
            connection.Close()

        End Try


        Try

            Dim strsql As String
            Dim quentity As Integer = quent.Text

            strsql = "select seling_price,cos_name from cosmetics  where cosid =" + cosID.Text + " "

            connection.Open()

            Dim cmd As New MySqlCommand(strsql, connection)
            Dim myreader As MySqlDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()

            op.Text = myreader("seling_price")
            Name.Text = myreader("cos_name")


            connection.Close()
            grosstotal = op.Text * quent.Text

            'TextBox1.Text = grosstotal



            ng = ng + grosstotal

            nettotal = ng
            nt.Text = nettotal






            Dim price As Double = op.Text
            ' Dim quentity As Integer = ComboBox1.Text

            amount = 0
            amount = (quentity * price)
            count = +-1

            Dim item As New ListViewItem
            item = ListView1.Items.Add(Name.Text)


            item.SubItems.Add(quent.Text)
            item.SubItems.Add(op.Text)
            item.SubItems.Add(amount)


            grosstotal += amount

            'clear section



            dte.Text = Date.Today.ToShortDateString

        Catch ex As Exception
            MessageBox.Show("Please compleate Data")

            op.Text = ""
            Name.Text = ""
            quent.Text = ""
            nt.Text = ""

            PictureBox1.Image = Nothing
            connection.Close()


        End Try

        



    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addbill.Click

        Try
            Dim price As Double = op.Text
            Dim quentity As Integer = quent.Text

            amount = 0
            amount = (quentity * price)
            count = +-1

            Dim item As New ListViewItem
            item = ListView1.Items.Add("")


            item.SubItems.Add("")
            item.SubItems.Add("")
            item.SubItems.Add("")
            item.SubItems.Add("" + nt.Text)

            grosstotal += amount

            'clear section



            dte.Text = Date.Today.ToShortDateString

        Catch ex As Exception
            MessageBox.Show("Please compleate Data")

        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles balance.Click

        Dim balance As Double = 0

        Try
            balance = csh.Text - nettotal
            rim.Text = balance


        Catch ex As Exception
            MessageBox.Show("Please Enter Cash")

        End Try

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cler.Click
        cosID.Text = ""
        op.Text = ""
        Name.Text = ""
        nt.Text = ""
        csh.Text = ""
        rim.Text = ""
        PictureBox1.Image = Nothing
        quent.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click
        Me.Hide()
        Dim home = New Homepage
        home.Show()
    End Sub

    Private Sub cosID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cosID.TextChanged

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Please Select Printer")
    End Sub
End Class