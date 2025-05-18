Imports MySql.Data.MySqlClient

Public Class Form1
    Dim Mysqlcon As MySqlConnection
    Dim command As MySqlCommand
    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to exit ?", "Exit Application",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Application.ExitThread()

        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = True
        Else
            TextBox2.UseSystemPasswordChar = False

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = True
        Else
            TextBox2.UseSystemPasswordChar = False

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        changepass.Show()

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        create_acc.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Mysqlcon = New MySqlConnection
        Mysqlcon.ConnectionString = ("server=localhost; username=root; password=; database=gym_login")
        Dim reader As MySqlDataReader
        Try
            Mysqlcon.Open()
            Dim query As String
            query = "select * from login_table where username ='" & TextBox1.Text & "' and password ='" & TextBox2.Text & "' "
            command = New MySqlCommand(query, Mysqlcon)
            reader = command.ExecuteReader

            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Username and Password is Correct!", "Login Success !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                home.Show()

            ElseIf count > 1 Then
                MessageBox.Show("Username and Password is duplicate")
            Else

                MessageBox.Show("Username or Password is incorrect", "ERROR", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If

            Mysqlcon.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Mysqlcon.Dispose()

        End Try
    End Sub
End Class