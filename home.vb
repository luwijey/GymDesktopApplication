Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class home
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchPanel(menu1)
    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel(menu2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchPanel(menu3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        switchPanel(menu4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        switchPanel(menu5)

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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim logout As Integer
        logout = MessageBox.Show("Are you sure you want to logout ?", "Exit Application",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If logout = vbYes Then
            Application.ExitThread()

        End If
    End Sub


End Class