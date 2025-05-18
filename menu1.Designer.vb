<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(menu1))
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.DarkGray
        Label1.Font = New Font("Agency FB", 48F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(2, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(957, 100)
        Label1.TabIndex = 0
        Label1.Text = "   Welcome Back ! " & vbCrLf
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Agency FB", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(12, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(876, 294)
        Label2.TabIndex = 1
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' menu1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(96), CByte(100), CByte(101))
        ClientSize = New Size(960, 540)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "menu1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "menu1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
