<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Label3 = New Label()
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Button3 = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei UI", 48F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label3.Location = New Point(501, 55)
        Label3.Name = "Label3"
        Label3.Size = New Size(420, 106)
        Label3.TabIndex = 2
        Label3.Text = "EventZen"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1422, 977)
        Panel1.TabIndex = 3
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Location = New Point(167, 197)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1088, 661)
        DataGridView1.TabIndex = 3
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "date"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "location"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "title"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "description"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "available"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(1247, 885)
        Button3.Name = "Button3"
        Button3.Size = New Size(133, 59)
        Button3.TabIndex = 10
        Button3.Text = "Register"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' User
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(247), CByte(244))
        ClientSize = New Size(1422, 977)
        Controls.Add(Panel1)
        Name = "User"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
End Class
