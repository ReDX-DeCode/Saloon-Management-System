Imports MySql.Data.MySqlClient

Public Class Bill


    Dim conn As New DBconnection
    Dim com As New MySqlCommand
    Dim adpt As New MySqlDataAdapter
    'conn = New DBconnection()
    Dim reader As MySqlDataReader



    Dim amount As Double
    Dim count As Integer
    Dim grosstotal As Double
    Dim nettotal As Double
    Dim item As New ListView
    Dim ng As Integer = 0





    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ext.Click
        Me.Hide()
        Dim home = New Homepage
        home.Show()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Application.Exit()

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quntity.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addToBill.Click

        Try

            Dim pri As Double = Price.Text = 0
            Dim quentity As Integer = quntity.Text = 1


            amount = 0
            amount = (quentity * pri)
            count = +-1

            Dim item As New ListViewItem
            item = ListView1.Items.Add("")


            item.SubItems.Add("")
            item.SubItems.Add("")
            item.SubItems.Add("")
            item.SubItems.Add("" + NetT.Text)

            grosstotal += amount

            'clear section



            Dte.Text = Date.Today.ToShortDateString



        Catch ex As Exception
            MessageBox.Show("Please compleate Data")


        End Try








    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculate.Click

        Try

            Using conn As MySqlConnection = New MySqlConnection("server=localhost;username=root;password=;database=saloon")
                conn.Open()


                Dim strsql As String

                strsql = "select price,s_name from service  where s_id =" + s_ID.Text + " "


                ' Command.Parameters.Add("@id", SqlDbType.Int).Value = TextBoxID.Text
                Dim cmd As New MySqlCommand(strsql, conn)
                Dim myreader As MySqlDataReader
                myreader = cmd.ExecuteReader
                myreader.Read()

                Price.Text = myreader("price")
                Nme.Text = myreader("s_name")

            End Using


            grosstotal = Price.Text * quntity.Text

            ' Nme.Text = grosstotal






            ng = ng + grosstotal

            nettotal = ng
            NetT.Text = nettotal



            'list view

            Dim pri As Double = Price.Text
            Dim quentity As Integer = quntity.Text

            amount = 0
            amount = (quentity * pri)
            count = +-1

            Dim item As New ListViewItem
            ' item = ListView1.Items.Add(count)
            item = ListView1.Items.Add(Nme.Text)


            item.SubItems.Add(quntity.Text)
            item.SubItems.Add(Price.Text)
            item.SubItems.Add(amount)

            grosstotal += amount

            Dte.Text = Date.Today.ToShortDateString


        Catch ex As Exception
            MessageBox.Show("Please compleate Data")

        End Try


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Balance.Click
        Dim balance As Double = 0
        Try
            balance = Cash.Text - nettotal
            Remain.Text = balance

        Catch ex As Exception
            MessageBox.Show("Please Enter Cash")

        End Try


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        Nme.Text = ""
        Price.Text = ""
        Cash.Text = ""
        NetT.Text = ""
        Remain.Text = ""
        s_ID.Text = ""
        quntity.Text = ""


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)





    End Sub

    Private Sub TextBox4_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NetT.TextChanged

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CosBill.Click
        Me.Hide()
        Dim cosmetics = New cosmetics
        cosmetics.Show()
    End Sub

    Private Sub s_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles s_ID.TextChanged

    End Sub

    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click
        MessageBox.Show("Please Select Printer")
    End Sub
End Class