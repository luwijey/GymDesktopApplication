Imports MySql.Data.MySqlClient
Public Class create_acc

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
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If TextBox3.Text = TextBox4.Text Then
            Try
                cm = New MySqlCommand("insert into login_table values('" & TextBox1.Text & "','" & TextBox3.Text & "')", constring)
                cm.ExecuteNonQuery()
                MessageBox.Show("Registered Successfully !", "Registration",
     MessageBoxButtons.OK, MessageBoxIcon.Information)
                Form1.Show()
                Me.Hide()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf TextBox3.Text <> TextBox4.Text Then
            MessageBox.Show("Password did not match, Please try again !", "ERROR",
     MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub create_acc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
    End Sub
End Class