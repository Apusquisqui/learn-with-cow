<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_amis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_amis))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pbox_n = New System.Windows.Forms.PictureBox()
        Me.pbox_max = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.Panel3.SuspendLayout()
        CType(Me.pbox_n, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbox_max, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel3.Size = New System.Drawing.Size(696, 33)
        Me.Panel3.TabIndex = 31
        '
        'pbox_n
        '
        Me.pbox_n.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbox_n.Image = CType(resources.GetObject("pbox_n.Image"), System.Drawing.Image)
        Me.pbox_n.Location = New System.Drawing.Point(603, 0)
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
        Me.pbox_max.Location = New System.Drawing.Point(603, 0)
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
        Me.PictureBox10.Location = New System.Drawing.Point(634, 0)
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
        Me.PictureBox11.Location = New System.Drawing.Point(663, 0)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 12
        Me.PictureBox11.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(180, 47)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(314, 20)
        Me.TextBox1.TabIndex = 32
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconPictureBox1.BackColor = System.Drawing.Color.White
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MapPin
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconSize = 20
        Me.IconPictureBox1.Location = New System.Drawing.Point(485, 47)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.IconPictureBox1.TabIndex = 33
        Me.IconPictureBox1.TabStop = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RichTextBox1.Location = New System.Drawing.Point(180, 73)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.RichTextBox1.Size = New System.Drawing.Size(325, 215)
        Me.RichTextBox1.TabIndex = 34
        Me.RichTextBox1.TabStop = False
        Me.RichTextBox1.Text = ""
        '
        'IconButton3
        '
        Me.IconButton3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.IconButton3.IconColor = System.Drawing.Color.Black
        Me.IconButton3.IconSize = 16
        Me.IconButton3.Location = New System.Drawing.Point(0, 298)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Rotation = 0R
        Me.IconButton3.Size = New System.Drawing.Size(76, 23)
        Me.IconButton3.TabIndex = 38
        Me.IconButton3.Text = "Volver"
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'frm_amis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(696, 322)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_amis"
        Me.Text = "Amigos"
        Me.Panel3.ResumeLayout(False)
        CType(Me.pbox_n, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbox_max, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents pbox_n As PictureBox
    Friend WithEvents pbox_max As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents DirectoryEntry1 As DirectoryServices.DirectoryEntry
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
End Class
