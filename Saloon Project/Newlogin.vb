Imports MySql.Data.MySqlClient



Public Class Newlogin

    Dim conn As New DBconnection
    Dim com As New MySqlCommand


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Label1.Text = "SalooN Liyo" Then
            PictureBox1.Image = My.Resources.a0
            Label1.Text = "Welcome"

        ElseIf Label1.Text = "Welcome" Then
            PictureBox1.Image = My.Resources.a1
            Label1.Text = "Cosemtics"

        ElseIf Label1.Text = "Cosemtics" Then
            PictureBox1.Image = My.Resources.a3
            Label1.Text = "Services"

        ElseIf Label1.Text = "Services" Then
            PictureBox1.Image = My.Resources.a4
            Label1.Text = "Appoinments"

        ElseIf Label1.Text = "Appoinments" Then
            PictureBox1.Image = My.Resources.a1
            Label1.Text = "Saloon Liyo"

        ElseIf Label1.Text = "Saloon Liyo" Then
            PictureBox1.Image = My.Resources.a3
            Label1.Text = "All in One"

        ElseIf Label1.Text = "All in One" Then
            PictureBox1.Image = My.Resources.a0
            Label1.Text = "SalooN Liyo"




        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Me.Hide()
            Dim log = New Login
            log.Show()
            Timer2.Enabled = False



        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Strt.Click
        conn.openDB()
        Timer2.Start()

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ext.Click
        Application.Exit()
        conn.closeDB()
    End Sub
End Class


