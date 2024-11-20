<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        TabControl1 = New TabControl()
        eventPage = New TabPage()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Panel5 = New Panel()
        Label7 = New Label()
        labelSeats = New Label()
        Panel4 = New Panel()
        Label5 = New Label()
        labelRegisters = New Label()
        Panel3 = New Panel()
        Label2 = New Label()
        labelEventsNum = New Label()
        Label3 = New Label()
        Panel2 = New Panel()
        managePage = New TabPage()
        panelSidebar = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        Label1 = New Label()
        Button3 = New Button()
        Label4 = New Label()
        Panel6 = New Panel()
        DataGridView2 = New DataGridView()
        Column6 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        TabControl1.SuspendLayout()
        eventPage.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        managePage.SuspendLayout()
        panelSidebar.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TabControl1)
        Panel1.Controls.Add(panelSidebar)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1422, 977)
        Panel1.TabIndex = 0
        ' 
        ' TabControl1
        ' 
        TabControl1.Appearance = TabAppearance.FlatButtons
        TabControl1.Controls.Add(eventPage)
        TabControl1.Controls.Add(managePage)
        TabControl1.ItemSize = New Size(0, 1)
        TabControl1.Location = New Point(360, -7)
        TabControl1.Margin = New Padding(0)
        TabControl1.Name = "TabControl1"
        TabControl1.Padding = New Point(0, 0)
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1062, 995)
        TabControl1.TabIndex = 0
        ' 
        ' eventPage
        ' 
        eventPage.Controls.Add(Button3)
        eventPage.Controls.Add(DataGridView1)
        eventPage.Controls.Add(Panel5)
        eventPage.Controls.Add(Panel4)
        eventPage.Controls.Add(Panel3)
        eventPage.Controls.Add(Label3)
        eventPage.Controls.Add(Panel2)
        eventPage.Location = New Point(4, 5)
        eventPage.Name = "eventPage"
        eventPage.Padding = New Padding(3)
        eventPage.Size = New Size(1054, 986)
        eventPage.TabIndex = 0
        eventPage.Text = "eventpage"
        eventPage.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Location = New Point(19, 380)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1021, 533)
        DataGridView1.TabIndex = 8
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "date"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "location"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "title"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "description"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "available"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 125
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(Label7)
        Panel5.Controls.Add(labelSeats)
        Panel5.Location = New Point(711, 135)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(325, 175)
        Panel5.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(20, 17)
        Label7.Name = "Label7"
        Label7.Size = New Size(194, 27)
        Label7.TabIndex = 0
        Label7.Text = "AVAILABLE SEATS"
        ' 
        ' labelSeats
        ' 
        labelSeats.AutoSize = True
        labelSeats.Font = New Font("Microsoft YaHei UI", 66F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelSeats.Location = New Point(40, 17)
        labelSeats.Name = "labelSeats"
        labelSeats.Size = New Size(266, 146)
        labelSeats.TabIndex = 1
        labelSeats.Text = "100"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(labelRegisters)
        Panel4.Location = New Point(365, 135)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(325, 175)
        Panel4.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(20, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(136, 27)
        Label5.TabIndex = 0
        Label5.Text = "REGISTERED"
        ' 
        ' labelRegisters
        ' 
        labelRegisters.AutoSize = True
        labelRegisters.Font = New Font("Microsoft YaHei UI", 66F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelRegisters.Location = New Point(77, 17)
        labelRegisters.Name = "labelRegisters"
        labelRegisters.Size = New Size(198, 146)
        labelRegisters.TabIndex = 1
        labelRegisters.Text = "24"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(labelEventsNum)
        Panel3.Location = New Point(19, 135)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(325, 175)
        Panel3.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(20, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 27)
        Label2.TabIndex = 0
        Label2.Text = "EVENTS"
        ' 
        ' labelEventsNum
        ' 
        labelEventsNum.AutoSize = True
        labelEventsNum.Font = New Font("Microsoft YaHei UI", 66F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelEventsNum.Location = New Point(73, 17)
        labelEventsNum.Name = "labelEventsNum"
        labelEventsNum.Size = New Size(198, 146)
        labelEventsNum.TabIndex = 1
        labelEventsNum.Text = "10"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label3.Location = New Point(62, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 52)
        Label3.TabIndex = 4
        Label3.Text = "Events"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(51, 34)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(5, 59)
        Panel2.TabIndex = 0
        ' 
        ' managePage
        ' 
        managePage.Controls.Add(DataGridView2)
        managePage.Controls.Add(Label4)
        managePage.Controls.Add(Panel6)
        managePage.Location = New Point(4, 5)
        managePage.Name = "managePage"
        managePage.Padding = New Padding(3)
        managePage.Size = New Size(1054, 986)
        managePage.TabIndex = 1
        managePage.Text = "TabPage2"
        managePage.UseVisualStyleBackColor = True
        ' 
        ' panelSidebar
        ' 
        panelSidebar.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        panelSidebar.Controls.Add(Button2)
        panelSidebar.Controls.Add(Button1)
        panelSidebar.Controls.Add(Label1)
        panelSidebar.Dock = DockStyle.Left
        panelSidebar.Location = New Point(0, 0)
        panelSidebar.Name = "panelSidebar"
        panelSidebar.Size = New Size(358, 977)
        panelSidebar.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Transparent
        Button2.Image = My.Resources.Resources.users__1_
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(-2, 416)
        Button2.Name = "Button2"
        Button2.Size = New Size(365, 110)
        Button2.TabIndex = 2
        Button2.Text = "Participants"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Image = My.Resources.Resources.calendar__1_
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(-2, 304)
        Button1.Name = "Button1"
        Button1.Size = New Size(365, 110)
        Button1.TabIndex = 1
        Button1.Text = "Events"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(209, 52)
        Label1.TabIndex = 0
        Label1.Text = "EventZen"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(939, 922)
        Button3.Name = "Button3"
        Button3.Size = New Size(101, 45)
        Button3.TabIndex = 9
        Button3.Text = "Save"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft YaHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(106), CByte(66), CByte(194))
        Label4.Location = New Point(62, 41)
        Label4.Name = "Label4"
        Label4.Size = New Size(362, 52)
        Label4.TabIndex = 6
        Label4.Text = "Registered Users"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Black
        Panel6.Location = New Point(51, 34)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(5, 59)
        Panel6.TabIndex = 5
        ' 
        ' DataGridView2
        ' 
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        DataGridView2.BackgroundColor = Color.White
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {Column6, DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4})
        DataGridView2.Location = New Point(17, 227)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(1021, 533)
        DataGridView2.TabIndex = 9
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "email"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 125
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "date"
        DataGridViewTextBoxColumn1.MinimumWidth = 6
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Width = 125
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "location"
        DataGridViewTextBoxColumn2.MinimumWidth = 6
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        DataGridViewTextBoxColumn2.Width = 125
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "title"
        DataGridViewTextBoxColumn3.MinimumWidth = 6
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        DataGridViewTextBoxColumn3.Width = 125
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.HeaderText = "description"
        DataGridViewTextBoxColumn4.MinimumWidth = 6
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.ReadOnly = True
        DataGridViewTextBoxColumn4.Width = 125
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(247), CByte(244))
        ClientSize = New Size(1422, 977)
        Controls.Add(Panel1)
        Name = "Admin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin"
        Panel1.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        eventPage.ResumeLayout(False)
        eventPage.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        managePage.ResumeLayout(False)
        managePage.PerformLayout()
        panelSidebar.ResumeLayout(False)
        panelSidebar.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents eventPage As TabPage
    Friend WithEvents managePage As TabPage
    Friend WithEvents panelSidebar As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents labelEventsNum As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents labelRegisters As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents labelSeats As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
