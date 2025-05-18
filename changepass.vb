Imports MySql.Data.MySqlClient

Public Class changepass
    Dim connect As MySqlConnection
    Dim cmd As MySqlCommand


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you want to exit ?", "Exit Application",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Me.Hide()

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If CheckBox1.Checked = True Then
            TextBox3.UseSystemPasswordChar = True
        Else
            TextBox3.UseSystemPasswordChar = False

        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox3.UseSystemPasswordChar = True
        Else
            TextBox3.UseSystemPasswordChar = False

        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If CheckBox2.Checked = True Then
            TextBox4.UseSystemPasswordChar = True
        Else
            TextBox4.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox4.UseSystemPasswordChar = True
        Else
            TextBox4.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()

        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If TextBox3.Text = TextBox4.Text Then
            connect = New MySqlConnection
            connect.ConnectionString = ("server=localhost; username=root; password=; database=gym_login")
            Dim query As String
            query = "update login_table set password='" & TextBox3.Text & "' where username = '" & TextBox1.Text & "' "
            cmd = New MySqlCommand(query, connect)
            connect.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Password updated successfully !", "Change Password",
     MessageBoxButtons.OK, MessageBoxIcon.Information)
            connect.Close()
            Form1.Show()
            Me.Hide()
        ElseIf TextBox3.Text <> TextBox4.Text Then
            MessageBox.Show("Password did not match, Please try again !", "ERROR",
     MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        Else
            MessageBox.Show("ERROR PLEASE TRY AGAIN !", "ERROR",
     MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub
End Class