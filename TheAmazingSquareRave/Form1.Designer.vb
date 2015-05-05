<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.player = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.collision = New System.Windows.Forms.Timer(Me.components)
        Me.moveBullet = New System.Windows.Forms.Timer(Me.components)
        Me.villian1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.villian2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.villian4 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.villian3 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Rand = New System.Windows.Forms.Timer(Me.components)
        Me.villianBorder = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.vida3 = New System.Windows.Forms.PictureBox()
        Me.vida2 = New System.Windows.Forms.PictureBox()
        Me.vida1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.doorTop = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.doorRight = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.doorLeft = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.doorBottom = New System.Windows.Forms.Panel()
        Me.player.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.villian1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.villian2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.villian4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.villian3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.vida3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vida2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vida1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'player
        '
        Me.player.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.player.Controls.Add(Me.PictureBox1)
        Me.player.Location = New System.Drawing.Point(250, 250)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(75, 75)
        Me.player.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.TheAmazingSquareRave.My.Resources.Resources.bg
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.TheAmazingSquareRave.My.Resources.Resources.V1fJDPq
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'collision
        '
        Me.collision.Enabled = True
        Me.collision.Interval = 1
        '
        'moveBullet
        '
        Me.moveBullet.Enabled = True
        Me.moveBullet.Interval = 10
        '
        'villian1
        '
        Me.villian1.BackColor = System.Drawing.Color.Transparent
        Me.villian1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.villian1.Controls.Add(Me.PictureBox2)
        Me.villian1.Location = New System.Drawing.Point(394, 94)
        Me.villian1.Name = "villian1"
        Me.villian1.Size = New System.Drawing.Size(75, 75)
        Me.villian1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'villian2
        '
        Me.villian2.BackColor = System.Drawing.Color.Transparent
        Me.villian2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.villian2.Controls.Add(Me.PictureBox3)
        Me.villian2.Location = New System.Drawing.Point(666, 122)
        Me.villian2.Name = "villian2"
        Me.villian2.Size = New System.Drawing.Size(75, 75)
        Me.villian2.TabIndex = 3
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'villian4
        '
        Me.villian4.BackColor = System.Drawing.Color.Transparent
        Me.villian4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.villian4.Controls.Add(Me.PictureBox5)
        Me.villian4.Location = New System.Drawing.Point(666, 439)
        Me.villian4.Name = "villian4"
        Me.villian4.Size = New System.Drawing.Size(75, 75)
        Me.villian4.TabIndex = 4
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'villian3
        '
        Me.villian3.BackColor = System.Drawing.Color.Transparent
        Me.villian3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.villian3.Controls.Add(Me.PictureBox4)
        Me.villian3.Location = New System.Drawing.Point(958, 247)
        Me.villian3.Name = "villian3"
        Me.villian3.Size = New System.Drawing.Size(75, 75)
        Me.villian3.TabIndex = 5
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'Rand
        '
        Me.Rand.Enabled = True
        '
        'villianBorder
        '
        Me.villianBorder.Enabled = True
        Me.villianBorder.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.TheAmazingSquareRave.My.Resources.Resources.bg_wall_u
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.vida3)
        Me.Panel1.Controls.Add(Me.vida2)
        Me.Panel1.Controls.Add(Me.vida1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.doorTop)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1210, 50)
        Me.Panel1.TabIndex = 6
        '
        'vida3
        '
        Me.vida3.BackColor = System.Drawing.Color.Transparent
        Me.vida3.Dock = System.Windows.Forms.DockStyle.Right
        Me.vida3.Image = Global.TheAmazingSquareRave.My.Resources.Resources.Hearts_64
        Me.vida3.Location = New System.Drawing.Point(1111, 0)
        Me.vida3.Name = "vida3"
        Me.vida3.Size = New System.Drawing.Size(33, 50)
        Me.vida3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.vida3.TabIndex = 7
        Me.vida3.TabStop = False
        '
        'vida2
        '
        Me.vida2.BackColor = System.Drawing.Color.Transparent
        Me.vida2.Dock = System.Windows.Forms.DockStyle.Right
        Me.vida2.Image = Global.TheAmazingSquareRave.My.Resources.Resources.Hearts_64
        Me.vida2.Location = New System.Drawing.Point(1144, 0)
        Me.vida2.Name = "vida2"
        Me.vida2.Size = New System.Drawing.Size(33, 50)
        Me.vida2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.vida2.TabIndex = 6
        Me.vida2.TabStop = False
        '
        'vida1
        '
        Me.vida1.BackColor = System.Drawing.Color.Transparent
        Me.vida1.Dock = System.Windows.Forms.DockStyle.Right
        Me.vida1.Image = Global.TheAmazingSquareRave.My.Resources.Resources.Hearts_64
        Me.vida1.Location = New System.Drawing.Point(1177, 0)
        Me.vida1.Name = "vida1"
        Me.vida1.Size = New System.Drawing.Size(33, 50)
        Me.vida1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.vida1.TabIndex = 5
        Me.vida1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Disparos disponibles: 150"
        Me.Label1.Visible = False
        '
        'doorTop
        '
        Me.doorTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.doorTop.Location = New System.Drawing.Point(497, 0)
        Me.doorTop.Name = "doorTop"
        Me.doorTop.Size = New System.Drawing.Size(216, 50)
        Me.doorTop.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel2.BackgroundImage = Global.TheAmazingSquareRave.My.Resources.Resources.bg_wall_r
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.doorRight)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1160, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(50, 575)
        Me.Panel2.TabIndex = 7
        '
        'doorRight
        '
        Me.doorRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.doorRight.Location = New System.Drawing.Point(0, 179)
        Me.doorRight.Name = "doorRight"
        Me.doorRight.Size = New System.Drawing.Size(50, 216)
        Me.doorRight.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel3.BackgroundImage = Global.TheAmazingSquareRave.My.Resources.Resources.bg_wall
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.doorLeft)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(50, 575)
        Me.Panel3.TabIndex = 8
        '
        'doorLeft
        '
        Me.doorLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.doorLeft.Location = New System.Drawing.Point(1, 165)
        Me.doorLeft.Name = "doorLeft"
        Me.doorLeft.Size = New System.Drawing.Size(50, 216)
        Me.doorLeft.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(92, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Panel4.BackgroundImage = Global.TheAmazingSquareRave.My.Resources.Resources.bg_wall_b
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Controls.Add(Me.doorBottom)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(50, 575)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1110, 50)
        Me.Panel4.TabIndex = 9
        '
        'doorBottom
        '
        Me.doorBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.doorBottom.Location = New System.Drawing.Point(447, 0)
        Me.doorBottom.Name = "doorBottom"
        Me.doorBottom.Size = New System.Drawing.Size(216, 50)
        Me.doorBottom.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.BackgroundImage = Global.TheAmazingSquareRave.My.Resources.Resources.bg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1210, 625)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.villian3)
        Me.Controls.Add(Me.villian4)
        Me.Controls.Add(Me.villian2)
        Me.Controls.Add(Me.villian1)
        Me.Controls.Add(Me.player)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.player.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.villian1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.villian2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.villian4.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.villian3.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.vida3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vida2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vida1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents player As System.Windows.Forms.Panel
    Friend WithEvents collision As System.Windows.Forms.Timer
    Friend WithEvents moveBullet As System.Windows.Forms.Timer
    Friend WithEvents villian1 As System.Windows.Forms.Panel
    Friend WithEvents villian2 As System.Windows.Forms.Panel
    Friend WithEvents villian4 As System.Windows.Forms.Panel
    Friend WithEvents villian3 As System.Windows.Forms.Panel
    Friend WithEvents Rand As System.Windows.Forms.Timer
    Friend WithEvents villianBorder As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents doorBottom As System.Windows.Forms.Panel
    Friend WithEvents doorTop As System.Windows.Forms.Panel
    Friend WithEvents doorRight As System.Windows.Forms.Panel
    Friend WithEvents doorLeft As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents vida3 As System.Windows.Forms.PictureBox
    Friend WithEvents vida2 As System.Windows.Forms.PictureBox
    Friend WithEvents vida1 As System.Windows.Forms.PictureBox

End Class
