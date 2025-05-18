<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class create_acc
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(create_acc))
        Panel1 = New Panel()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        TextBox4 = New TextBox()
        Label5 = New Label()
        Button2 = New Button()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Button1 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(96), CByte(100), CByte(101))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(176, 127)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(583, 355)
        Panel1.TabIndex = 4
        Panel1.Tag = ""
        ' 
        ' CheckBox2
        ' 
        CheckBox2.Location = New Point(498, 214)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(68, 30)
        CheckBox2.TabIndex = 14
        CheckBox2.Text = "Show"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Location = New Point(498, 160)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(68, 30)
        CheckBox1.TabIndex = 13
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.FromArgb(CByte(150), CByte(149), CByte(160))
        TextBox4.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(193, 211)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.PasswordChar = "*"c
        TextBox4.Size = New Size(299, 33)
        TextBox4.TabIndex = 12
        TextBox4.UseSystemPasswordChar = True
        ' 
        ' Label5
        ' 
        Label5.FlatStyle = FlatStyle.Popup
        Label5.Font = New Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(33))
        Label5.Location = New Point(9, 205)
        Label5.Name = "Label5"
        Label5.Size = New Size(203, 41)
        Label5.TabIndex = 11
        Label5.Text = "Confirm Password:"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(150), CByte(149), CByte(160))
        Button2.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(375, 278)
        Button2.Name = "Button2"
        Button2.Size = New Size(117, 36)
        Button2.TabIndex = 10
        Button2.Text = "Cancel "
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(150), CByte(149), CByte(160))
        TextBox3.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(193, 155)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.PasswordChar = "*"c
        TextBox3.Size = New Size(299, 33)
        TextBox3.TabIndex = 9
        TextBox3.UseSystemPasswordChar = True
        ' 
        ' Label4
        ' 
        Label4.FlatStyle = FlatStyle.Popup
        Label4.Font = New Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(33))
        Label4.Location = New Point(71, 151)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 41)
        Label4.TabIndex = 8
        Label4.Text = "Password:"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(150), CByte(149), CByte(160))
        Button1.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(193, 278)
        Button1.Name = "Button1"
        Button1.Size = New Size(117, 36)
        Button1.TabIndex = 7
        Button1.Text = " Sign up "
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(150), CByte(149), CByte(160))
        TextBox2.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(193, 102)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(299, 33)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(150), CByte(149), CByte(160))
        TextBox1.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(193, 47)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(299, 33)
        TextBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(33))
        Label3.Location = New Point(65, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(192, 41)
        Label3.TabIndex = 2
        Label3.Text = "Email:"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Font = New Font("Agency FB", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(31), CByte(31), CByte(33))
        Label2.Location = New Point(83, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 41)
        Label2.TabIndex = 1
        Label2.Text = "Name:"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Font = New Font("Calibri", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.AppWorkspace
        Label1.Location = New Point(2, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(959, 53)
        Label1.TabIndex = 3
        Label1.Text = "Create Account "
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(928, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(20, 35)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(898, 7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(24, 40)
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' create_acc
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(31), CByte(31), CByte(33))
        ClientSize = New Size(960, 540)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "create_acc"
        StartPosition = FormStartPosition.CenterScreen
        Text = "create_acc"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
End Class
