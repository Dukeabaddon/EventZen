<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        TextBox3 = New TextBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label5.Cursor = Cursors.Hand
        Label5.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(164, 568)
        Label5.Name = "Label5"
        Label5.Size = New Size(51, 19)
        Label5.TabIndex = 27
        Label5.Text = "Login"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(28, 567)
        Label4.Name = "Label4"
        Label4.Size = New Size(139, 20)
        Label4.TabIndex = 26
        Label4.Text = "Already a Member?"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label3.Location = New Point(34, 316)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 25
        Label3.Text = "Password"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(248), CByte(245), CByte(246))
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(34, 345)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(309, 27)
        TextBox2.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label2.Location = New Point(34, 251)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 20)
        Label2.TabIndex = 23
        Label2.Text = "Email"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(248), CByte(245), CByte(246))
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(34, 280)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(309, 27)
        TextBox1.TabIndex = 22
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Button1.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(322, 534)
        Button1.Name = "Button1"
        Button1.Size = New Size(147, 49)
        Button1.TabIndex = 21
        Button1.Text = "Register"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label1.Location = New Point(25, 191)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 37)
        Label1.TabIndex = 20
        Label1.Text = "Register"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.TopBg
        PictureBox2.Location = New Point(-9, -3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(516, 426)
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox2.TabIndex = 19
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
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label6.Location = New Point(34, 393)
        Label6.Name = "Label6"
        Label6.Size = New Size(140, 20)
        Label6.TabIndex = 29
        Label6.Text = "Confirm Password"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(248), CByte(245), CByte(246))
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(34, 422)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(309, 27)
        TextBox3.TabIndex = 28
        ' 
        ' Register
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(498, 596)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
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
        Name = "Register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Register"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
