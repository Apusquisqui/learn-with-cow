<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_editarper
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_editarper))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ptb_min = New System.Windows.Forms.PictureBox()
        Me.ptb_cer = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.ibtn_gen = New FontAwesome.Sharp.IconButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.lbl_app = New System.Windows.Forms.Label()
        Me.lbl_np = New System.Windows.Forms.Label()
        Me.lbl_dia = New System.Windows.Forms.Label()
        Me.lbl_mes = New System.Windows.Forms.Label()
        Me.lbl_anio = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ptb_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_cer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ptb_min)
        Me.Panel1.Controls.Add(Me.ptb_cer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(523, 44)
        Me.Panel1.TabIndex = 1
        '
        'ptb_min
        '
        Me.ptb_min.Image = CType(resources.GetObject("ptb_min.Image"), System.Drawing.Image)
        Me.ptb_min.Location = New System.Drawing.Point(475, 0)
        Me.ptb_min.Name = "ptb_min"
        Me.ptb_min.Size = New System.Drawing.Size(21, 20)
        Me.ptb_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_min.TabIndex = 8
        Me.ptb_min.TabStop = False
        '
        'ptb_cer
        '
        Me.ptb_cer.Image = CType(resources.GetObject("ptb_cer.Image"), System.Drawing.Image)
        Me.ptb_cer.Location = New System.Drawing.Point(498, 0)
        Me.ptb_cer.Name = "ptb_cer"
        Me.ptb_cer.Size = New System.Drawing.Size(21, 20)
        Me.ptb_cer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_cer.TabIndex = 7
        Me.ptb_cer.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel2.Controls.Add(Me.IconButton1)
        Me.Panel2.Controls.Add(Me.ibtn_gen)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 307)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(523, 44)
        Me.Panel2.TabIndex = 22
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Left
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft
        Me.IconButton1.IconColor = System.Drawing.Color.WhiteSmoke
        Me.IconButton1.IconSize = 32
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconButton1.Location = New System.Drawing.Point(0, 0)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(95, 44)
        Me.IconButton1.TabIndex = 17
        Me.IconButton1.Text = "Volver"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'ibtn_gen
        '
        Me.ibtn_gen.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ibtn_gen.Dock = System.Windows.Forms.DockStyle.Right
        Me.ibtn_gen.FlatAppearance.BorderSize = 0
        Me.ibtn_gen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ibtn_gen.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ibtn_gen.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ibtn_gen.IconChar = FontAwesome.Sharp.IconChar.Shapes
        Me.ibtn_gen.IconColor = System.Drawing.Color.WhiteSmoke
        Me.ibtn_gen.IconSize = 32
        Me.ibtn_gen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ibtn_gen.Location = New System.Drawing.Point(428, 0)
        Me.ibtn_gen.Name = "ibtn_gen"
        Me.ibtn_gen.Rotation = 0R
        Me.ibtn_gen.Size = New System.Drawing.Size(95, 44)
        Me.ibtn_gen.TabIndex = 14
        Me.ibtn_gen.Text = "Editar"
        Me.ibtn_gen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ibtn_gen.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(192, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 44)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Añadir Amigo(s)"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(365, 249)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 18)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Año:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(189, 249)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 18)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Mes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(31, 249)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Día:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(319, 64)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(11, 191)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nombre Público:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(31, 135)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Apellidos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(31, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre(s):"
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nom.ForeColor = System.Drawing.Color.Black
        Me.lbl_nom.Location = New System.Drawing.Point(173, 86)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(51, 18)
        Me.lbl_nom.TabIndex = 28
        Me.lbl_nom.Text = "Label7"
        '
        'lbl_app
        '
        Me.lbl_app.AutoSize = True
        Me.lbl_app.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_app.ForeColor = System.Drawing.Color.Black
        Me.lbl_app.Location = New System.Drawing.Point(173, 135)
        Me.lbl_app.Name = "lbl_app"
        Me.lbl_app.Size = New System.Drawing.Size(51, 18)
        Me.lbl_app.TabIndex = 29
        Me.lbl_app.Text = "Label7"
        '
        'lbl_np
        '
        Me.lbl_np.AutoSize = True
        Me.lbl_np.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_np.ForeColor = System.Drawing.Color.Black
        Me.lbl_np.Location = New System.Drawing.Point(173, 191)
        Me.lbl_np.Name = "lbl_np"
        Me.lbl_np.Size = New System.Drawing.Size(51, 18)
        Me.lbl_np.TabIndex = 30
        Me.lbl_np.Text = "Label7"
        '
        'lbl_dia
        '
        Me.lbl_dia.AutoSize = True
        Me.lbl_dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dia.ForeColor = System.Drawing.Color.Black
        Me.lbl_dia.Location = New System.Drawing.Point(79, 249)
        Me.lbl_dia.Name = "lbl_dia"
        Me.lbl_dia.Size = New System.Drawing.Size(51, 18)
        Me.lbl_dia.TabIndex = 31
        Me.lbl_dia.Text = "Label7"
        '
        'lbl_mes
        '
        Me.lbl_mes.AutoSize = True
        Me.lbl_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mes.ForeColor = System.Drawing.Color.Black
        Me.lbl_mes.Location = New System.Drawing.Point(258, 249)
        Me.lbl_mes.Name = "lbl_mes"
        Me.lbl_mes.Size = New System.Drawing.Size(51, 18)
        Me.lbl_mes.TabIndex = 32
        Me.lbl_mes.Text = "Label7"
        '
        'lbl_anio
        '
        Me.lbl_anio.AutoSize = True
        Me.lbl_anio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_anio.ForeColor = System.Drawing.Color.Black
        Me.lbl_anio.Location = New System.Drawing.Point(408, 249)
        Me.lbl_anio.Name = "lbl_anio"
        Me.lbl_anio.Size = New System.Drawing.Size(51, 18)
        Me.lbl_anio.TabIndex = 33
        Me.lbl_anio.Text = "Label7"
        '
        'frm_editarper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(523, 351)
        Me.Controls.Add(Me.lbl_anio)
        Me.Controls.Add(Me.lbl_mes)
        Me.Controls.Add(Me.lbl_dia)
        Me.Controls.Add(Me.lbl_np)
        Me.Controls.Add(Me.lbl_app)
        Me.Controls.Add(Me.lbl_nom)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_editarper"
        Me.Text = "Perfil"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ptb_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_cer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ptb_min As PictureBox
    Friend WithEvents ptb_cer As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents ibtn_gen As FontAwesome.Sharp.IconButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_nom As Label
    Friend WithEvents lbl_app As Label
    Friend WithEvents lbl_np As Label
    Friend WithEvents lbl_dia As Label
    Friend WithEvents lbl_mes As Label
    Friend WithEvents lbl_anio As Label
End Class
