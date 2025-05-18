<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        CheckBox1 = New CheckBox()
        Button1 = New Button()
        LinkLabel2 = New LinkLabel()
        LinkLabel1 = New LinkLabel()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(96), CByte(100), CByte(101))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(LinkLabel2)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(66, 76)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(420, 389)
        Panel1.TabIndex = 0
        Panel1.Tag = ""
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Font = New Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point)
        CheckBox1.Location = New Point(365, 202)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(67, 28)
        CheckBox1.TabIndex = 10
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(150), CByte(149), CByte(160))
        Button1.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(153, 285)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 36)
        Button1.TabIndex = 9
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel2
        ' 
        LinkLabel2.AutoSize = True
        LinkLabel2.LinkColor = Color.Black
        LinkLabel2.Location = New Point(181, 348)
        LinkLabel2.Name = "LinkLabel2"
        LinkLabel2.Size = New Size(63, 20)
        LinkLabel2.TabIndex = 8
        LinkLabel2.TabStop = True
        LinkLabel2.Text = "Register"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.LinkColor = Color.Black
        LinkLabel1.Location = New Point(241, 237)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(118, 20)
        LinkLabel1.TabIndex = 7
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forgot Password"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(150), CByte(149), CByte(160))
        TextBox2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(60, 198)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.PasswordChar = "*"c
        TextBox2.Size = New Size(299, 33)
        TextBox2.TabIndex = 6
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("Agency FB", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(53, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 26)
        Label3.TabIndex = 5
        Label3.Text = "Password"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(150), CByte(149), CByte(160))
        TextBox1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(60, 118)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(299, 33)
        TextBox1.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Font = New Font("Agency FB", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(53, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 30)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Calibri", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(0, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(420, 41)
        Label1.TabIndex = 0
        Label1.Text = "Login"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.f4901e6413b74c0284a513b7c9d89f4a
        PictureBox1.Location = New Point(505, 76)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(374, 389)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(928, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(20, 62)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(898, 7)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(26, 62)
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(33))
        ClientSize = New Size(960, 540)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
