<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_op
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_op))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pbox_n = New System.Windows.Forms.PictureBox()
        Me.pbox_max = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.Panel3.SuspendLayout()
        CType(Me.pbox_n, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel3.Controls.Add(Me.pbox_n)
        Me.Panel3.Controls.Add(Me.pbox_max)
        Me.Panel3.Controls.Add(Me.PictureBox10)
        Me.Panel3.Controls.Add(Me.PictureBox11)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(634, 33)
        Me.Panel3.TabIndex = 31
        '
        'pbox_n
        '
        Me.pbox_n.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbox_n.Image = CType(resources.GetObject("pbox_n.Image"), System.Drawing.Image)
        Me.pbox_n.Location = New System.Drawing.Point(541, 0)
        Me.pbox_n.Name = "pbox_n"
        Me.pbox_n.Size = New System.Drawing.Size(31, 33)
        Me.pbox_n.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbox_n.TabIndex = 15
        Me.pbox_n.TabStop = False
        Me.pbox_n.Visible = False
        '
        'pbox_max
        '
        Me.pbox_max.Dock = System.Windows.Forms.DockStyle.Right
        Me.pbox_max.Image = CType(resources.GetObject("pbox_max.Image"), System.Drawing.Image)
        Me.pbox_max.Location = New System.Drawing.Point(541, 0)
        Me.pbox_max.Name = "pbox_max"
        Me.pbox_max.Size = New System.Drawing.Size(31, 33)
        Me.pbox_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbox_max.TabIndex = 14
        Me.pbox_max.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(572, 0)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(29, 33)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 13
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(601, 0)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 12
        Me.PictureBox11.TabStop = False
        '
        'IconButton1
        '
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconSize = 16
        Me.IconButton1.Location = New System.Drawing.Point(85, 83)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(76, 23)
        Me.IconButton1.TabIndex = 32
        Me.IconButton1.Text = "Idioma:"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Español", "Ingles", "Aleman"})
        Me.ComboBox1.Location = New System.Drawing.Point(213, 83)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(143, 21)
        Me.ComboBox1.TabIndex = 33
        '
        'IconButton2
        '
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconSize = 16
        Me.IconButton2.Location = New System.Drawing.Point(85, 136)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0R
        Me.IconButton2.Size = New System.Drawing.Size(76, 23)
        Me.IconButton2.TabIndex = 34
        Me.IconButton2.Text = "Volumen"
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(167, 136)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(233, 45)
        Me.TrackBar1.TabIndex = 36
        '
        'IconButton3
        '
        Me.IconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.IconButton3.IconColor = System.Drawing.Color.Black
        Me.IconButton3.IconSize = 16
        Me.IconButton3.Location = New System.Drawing.Point(0, 284)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Rotation = 0R
        Me.IconButton3.Size = New System.Drawing.Size(76, 23)
        Me.IconButton3.TabIndex = 37
        Me.IconButton3.Text = "Volver"
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'IconButton4
        '
        Me.IconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton4.IconColor = System.Drawing.Color.Black
        Me.IconButton4.IconSize = 16
        Me.IconButton4.Location = New System.Drawing.Point(558, 284)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Rotation = 0R
        Me.IconButton4.Size = New System.Drawing.Size(76, 23)
        Me.IconButton4.TabIndex = 38
        Me.IconButton4.Text = "Aplicar"
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'IconButton5
        '
        Me.IconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton5.IconColor = System.Drawing.Color.Black
        Me.IconButton5.IconSize = 16
        Me.IconButton5.Location = New System.Drawing.Point(476, 284)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Rotation = 0R
        Me.IconButton5.Size = New System.Drawing.Size(76, 23)
        Me.IconButton5.TabIndex = 39
        Me.IconButton5.Text = "Aceptar"
        Me.IconButton5.UseVisualStyleBackColor = True
        '
        'frm_op
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(634, 308)
        Me.Controls.Add(Me.IconButton5)
        Me.Controls.Add(Me.IconButton4)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_op"
        Me.Text = "Opciones"
        Me.Panel3.ResumeLayout(False)
        CType(Me.pbox_n, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_max, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents pbox_n As PictureBox
    Friend WithEvents pbox_max As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
End Class
