<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Button1 = New Button()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Button1.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(322, 534)
        Button1.Name = "Button1"
        Button1.Size = New Size(147, 49)
        Button1.TabIndex = 11
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label1.Location = New Point(25, 191)
        Label1.Name = "Label1"
        Label1.Size = New Size(95, 37)
        Label1.TabIndex = 8
        Label1.Text = "Login"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.TopBg
        PictureBox2.Location = New Point(-9, -3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(516, 426)
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.BottomBg
        PictureBox1.Location = New Point(-9, 443)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(516, 157)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(248), CByte(245), CByte(246))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(34, 287)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(309, 27)
        TextBox1.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label2.Location = New Point(34, 258)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 20)
        Label2.TabIndex = 13
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label3.Location = New Point(34, 323)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 15
        Label3.Text = "Password"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(248), CByte(245), CByte(246))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(34, 352)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(309, 27)
        TextBox2.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(28, 567)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 20)
        Label4.TabIndex = 16
        Label4.Text = "New Here?"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label5.Cursor = Cursors.Hand
        Label5.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(109, 568)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 19)
        Label5.TabIndex = 17
        Label5.Text = "Register"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(498, 596)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EventZen"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
