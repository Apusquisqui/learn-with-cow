<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_perfil
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_perfil))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ptb_min = New System.Windows.Forms.PictureBox()
        Me.ptb_cer = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Apll = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nP = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmb_anio = New System.Windows.Forms.ComboBox()
        Me.cmb_dia = New System.Windows.Forms.ComboBox()
        Me.cmb_mes = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.ibtn_gen = New FontAwesome.Sharp.IconButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.ptb_min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_cer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(519, 44)
        Me.Panel1.TabIndex = 0
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(31, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre(s):"
        '
        'txt_nom
        '
        Me.txt_nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txt_nom.Location = New System.Drawing.Point(135, 67)
        Me.txt_nom.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(171, 24)
        Me.txt_nom.TabIndex = 2
        Me.txt_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(31, 119)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellidos:"
        '
        'txt_Apll
        '
        Me.txt_Apll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txt_Apll.Location = New System.Drawing.Point(135, 120)
        Me.txt_Apll.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Apll.Name = "txt_Apll"
        Me.txt_Apll.Size = New System.Drawing.Size(171, 24)
        Me.txt_Apll.TabIndex = 4
        Me.txt_Apll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(11, 175)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre Público:"
        '
        'txt_nP
        '
        Me.txt_nP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txt_nP.Location = New System.Drawing.Point(135, 176)
        Me.txt_nP.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nP.Name = "txt_nP"
        Me.txt_nP.Size = New System.Drawing.Size(171, 24)
        Me.txt_nP.TabIndex = 6
        Me.txt_nP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(319, 48)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(185, 161)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Presione sobre la imagen para cambiar")
        '
        'cmb_anio
        '
        Me.cmb_anio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.cmb_anio.FormattingEnabled = True
        Me.cmb_anio.Items.AddRange(New Object() {"1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023"})
        Me.cmb_anio.Location = New System.Drawing.Point(405, 231)
        Me.cmb_anio.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_anio.Name = "cmb_anio"
        Me.cmb_anio.Size = New System.Drawing.Size(76, 26)
        Me.cmb_anio.TabIndex = 8
        '
        'cmb_dia
        '
        Me.cmb_dia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.cmb_dia.FormattingEnabled = True
        Me.cmb_dia.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmb_dia.Location = New System.Drawing.Point(71, 231)
        Me.cmb_dia.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_dia.Name = "cmb_dia"
        Me.cmb_dia.Size = New System.Drawing.Size(76, 26)
        Me.cmb_dia.TabIndex = 9
        '
        'cmb_mes
        '
        Me.cmb_mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.cmb_mes.FormattingEnabled = True
        Me.cmb_mes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmb_mes.Location = New System.Drawing.Point(234, 231)
        Me.cmb_mes.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_mes.Name = "cmb_mes"
        Me.cmb_mes.Size = New System.Drawing.Size(76, 26)
        Me.cmb_mes.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(31, 233)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Día:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(189, 233)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Mes:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(365, 233)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Año:"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel2.Controls.Add(Me.IconButton1)
        Me.Panel2.Controls.Add(Me.ibtn_gen)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 310)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(519, 44)
        Me.Panel2.TabIndex = 9
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
        Me.ibtn_gen.IconChar = FontAwesome.Sharp.IconChar.LaptopCode
        Me.ibtn_gen.IconColor = System.Drawing.Color.WhiteSmoke
        Me.ibtn_gen.IconSize = 32
        Me.ibtn_gen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ibtn_gen.Location = New System.Drawing.Point(424, 0)
        Me.ibtn_gen.Name = "ibtn_gen"
        Me.ibtn_gen.Rotation = 0R
        Me.ibtn_gen.Size = New System.Drawing.Size(95, 44)
        Me.ibtn_gen.TabIndex = 14
        Me.ibtn_gen.Text = "Generar"
        Me.ibtn_gen.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.ibtn_gen.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(131, 278)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Contraseña:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(394, 275)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contraseña.Location = New System.Drawing.Point(225, 274)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contraseña.Size = New System.Drawing.Size(205, 27)
        Me.txt_contraseña.TabIndex = 19
        Me.txt_contraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frm_perfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(519, 354)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_mes)
        Me.Controls.Add(Me.cmb_dia)
        Me.Controls.Add(Me.cmb_anio)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_nP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_Apll)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm_perfil"
        Me.Text = "Perfil"
        Me.Panel1.ResumeLayout(False)
        CType(Me.ptb_min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_cer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Apll As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nP As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmb_anio As ComboBox
    Friend WithEvents cmb_dia As ComboBox
    Friend WithEvents cmb_mes As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ptb_min As PictureBox
    Friend WithEvents ptb_cer As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ibtn_gen As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_contraseña As TextBox
End Class
