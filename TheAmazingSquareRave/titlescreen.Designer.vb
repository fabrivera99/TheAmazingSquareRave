<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class titlescreen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 40.425!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(378, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(516, 144)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The Amazing Square " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "             Rave"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 40.425!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(73, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 72)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Inicio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 40.425!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(-2, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(321, 72)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Instrucciones"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 40.425!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(85, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 72)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Salir"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(477, 234)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(299, 199)
        Me.Panel1.TabIndex = 4
        '
        'titlescreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BackgroundImage = Global.TheAmazingSquareRave.My.Resources.Resources.bg_wall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1210, 625)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "titlescreen"
        Me.ShowInTaskbar = False
        Me.Text = "titlescreen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
