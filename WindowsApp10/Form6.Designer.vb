<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Nl1_Q1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Nl1_Q1))
        Me.apppanel = New System.Windows.Forms.Panel()
        Me.pbox_n = New System.Windows.Forms.PictureBox()
        Me.pbox_max = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_mn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_F = New FontAwesome.Sharp.IconButton()
        Me.ap = New System.Windows.Forms.PictureBox()
        Me.btn_vol = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panel_Q = New System.Windows.Forms.Panel()
        Me.ptb_sig = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.apppanel.SuspendLayout()
        CType(Me.pbox_n, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_Q.SuspendLayout()
        CType(Me.ptb_sig, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'apppanel
        '
        Me.apppanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.apppanel.Controls.Add(Me.pbox_n)
        Me.apppanel.Controls.Add(Me.pbox_max)
        Me.apppanel.Controls.Add(Me.PictureBox10)
        Me.apppanel.Controls.Add(Me.PictureBox11)
        Me.apppanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.apppanel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.apppanel.Location = New System.Drawing.Point(0, 0)
        Me.apppanel.Name = "apppanel"
        Me.apppanel.Size = New System.Drawing.Size(809, 36)
        Me.apppanel.TabIndex = 0
        '
        'pbox_n
        '
        Me.pbox_n.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbox_n.Image = CType(resources.GetObject("pbox_n.Image"), System.Drawing.Image)
        Me.pbox_n.Location = New System.Drawing.Point(716, 1)
        Me.pbox_n.Name = "pbox_n"
        Me.pbox_n.Size = New System.Drawing.Size(31, 33)
        Me.pbox_n.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbox_n.TabIndex = 19
        Me.pbox_n.TabStop = False
        Me.pbox_n.Visible = False
        '
        'pbox_max
        '
        Me.pbox_max.Dock = System.Windows.Forms.DockStyle.Right
        Me.pbox_max.Image = CType(resources.GetObject("pbox_max.Image"), System.Drawing.Image)
        Me.pbox_max.Location = New System.Drawing.Point(716, 0)
        Me.pbox_max.Name = "pbox_max"
        Me.pbox_max.Size = New System.Drawing.Size(31, 36)
        Me.pbox_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbox_max.TabIndex = 18
        Me.pbox_max.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(747, 0)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(29, 36)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 17
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(776, 0)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(33, 36)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 16
        Me.PictureBox11.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 47)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_mn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(99, 47)
        Me.Panel2.TabIndex = 0
        '
        'btn_mn
        '
        Me.btn_mn.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btn_mn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_mn.FlatAppearance.BorderSize = 0
        Me.btn_mn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mn.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mn.ForeColor = System.Drawing.Color.White
        Me.btn_mn.Location = New System.Drawing.Point(0, 0)
        Me.btn_mn.Name = "btn_mn"
        Me.btn_mn.Size = New System.Drawing.Size(99, 47)
        Me.btn_mn.TabIndex = 1
        Me.btn_mn.Text = "__________" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "__________" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "__________" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_mn.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btn_F)
        Me.Panel3.Controls.Add(Me.ap)
        Me.Panel3.Controls.Add(Me.btn_vol)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 83)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(99, 366)
        Me.Panel3.TabIndex = 1
        Me.Panel3.Visible = False
        '
        'btn_F
        '
        Me.btn_F.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btn_F.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_F.FlatAppearance.BorderSize = 0
        Me.btn_F.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_F.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_F.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_F.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.btn_F.IconColor = System.Drawing.Color.WhiteSmoke
        Me.btn_F.IconSize = 20
        Me.btn_F.Location = New System.Drawing.Point(0, 285)
        Me.btn_F.Name = "btn_F"
        Me.btn_F.Rotation = 0R
        Me.btn_F.Size = New System.Drawing.Size(99, 37)
        Me.btn_F.TabIndex = 4
        Me.btn_F.Text = "Finalizar"
        Me.btn_F.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_F.UseVisualStyleBackColor = False
        '
        'ap
        '
        Me.ap.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ap.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.ap.Image = CType(resources.GetObject("ap.Image"), System.Drawing.Image)
        Me.ap.Location = New System.Drawing.Point(0, 322)
        Me.ap.Name = "ap"
        Me.ap.Size = New System.Drawing.Size(45, 44)
        Me.ap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ap.TabIndex = 16
        Me.ap.TabStop = False
        '
        'btn_vol
        '
        Me.btn_vol.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btn_vol.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_vol.FlatAppearance.BorderSize = 0
        Me.btn_vol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_vol.ForeColor = System.Drawing.Color.White
        Me.btn_vol.ImageKey = "(ninguno)"
        Me.btn_vol.Location = New System.Drawing.Point(0, 322)
        Me.btn_vol.Name = "btn_vol"
        Me.btn_vol.Size = New System.Drawing.Size(99, 44)
        Me.btn_vol.TabIndex = 17
        Me.btn_vol.Text = "Volver"
        Me.btn_vol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_vol.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(99, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(710, 366)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'panel_Q
        '
        Me.panel_Q.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panel_Q.Controls.Add(Me.ptb_sig)
        Me.panel_Q.Controls.Add(Me.Label2)
        Me.panel_Q.Controls.Add(Me.Label1)
        Me.panel_Q.Location = New System.Drawing.Point(238, 163)
        Me.panel_Q.Name = "panel_Q"
        Me.panel_Q.Size = New System.Drawing.Size(449, 212)
        Me.panel_Q.TabIndex = 3
        '
        'ptb_sig
        '
        Me.ptb_sig.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ptb_sig.BackColor = System.Drawing.SystemColors.Control
        Me.ptb_sig.Image = CType(resources.GetObject("ptb_sig.Image"), System.Drawing.Image)
        Me.ptb_sig.Location = New System.Drawing.Point(407, 186)
        Me.ptb_sig.Name = "ptb_sig"
        Me.ptb_sig.Size = New System.Drawing.Size(42, 33)
        Me.ptb_sig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ptb_sig.TabIndex = 18
        Me.ptb_sig.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(80, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(278, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Componentes de un Sistema Informático"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'frm_Nl1_Q1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 449)
        Me.Controls.Add(Me.panel_Q)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.apppanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Nl1_Q1"
        Me.Text = "Ejercicios"
        Me.apppanel.ResumeLayout(False)
        CType(Me.pbox_n, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_max, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.ap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_Q.ResumeLayout(False)
        Me.panel_Q.PerformLayout()
        CType(Me.ptb_sig, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents apppanel As Panel
    Friend WithEvents pbox_n As PictureBox
    Friend WithEvents pbox_max As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_mn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ap As PictureBox
    Friend WithEvents btn_vol As Button
    Friend WithEvents panel_Q As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ptb_sig As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_F As FontAwesome.Sharp.IconButton
End Class
