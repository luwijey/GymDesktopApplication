<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        Button2 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.DarkGray
        Label1.Font = New Font("Agency FB", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(1, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(959, 61)
        Label1.TabIndex = 4
        Label1.Text = "SETTINGS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Silver
        Button1.FlatAppearance.BorderSize = 2
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(66, 117)
        Button1.Name = "Button1"
        Button1.Size = New Size(219, 51)
        Button1.TabIndex = 5
        Button1.Text = "Create Account"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(-1, 79)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(350, 464)
        Panel1.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Silver
        Button2.FlatAppearance.BorderSize = 2
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(66, 232)
        Button2.Name = "Button2"
        Button2.Size = New Size(219, 51)
        Button2.TabIndex = 6
        Button2.Text = "Change Password"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' menu5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(96), CByte(100), CByte(101))
        ClientSize = New Size(960, 540)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "menu5"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
End Class
