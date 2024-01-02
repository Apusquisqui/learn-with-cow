<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_QFN1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_QFN1))
        Me.apppanel = New System.Windows.Forms.Panel()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.panelAr = New System.Windows.Forms.Panel()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.apppanel.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAr.SuspendLayout()
        Me.SuspendLayout()
        '
        'apppanel
        '
        Me.apppanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.apppanel.Controls.Add(Me.PictureBox10)
        Me.apppanel.Controls.Add(Me.PictureBox11)
        Me.apppanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.apppanel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.apppanel.Location = New System.Drawing.Point(0, 0)
        Me.apppanel.Name = "apppanel"
        Me.apppanel.Size = New System.Drawing.Size(449, 36)
        Me.apppanel.TabIndex = 1
        '
        'PictureBox10
        '
        Me.PictureBox10.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(387, 0)
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
        Me.PictureBox11.Location = New System.Drawing.Point(416, 0)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(33, 36)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 16
        Me.PictureBox11.TabStop = False
        '
        'panelAr
        '
        Me.panelAr.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.panelAr.Controls.Add(Me.Label3)
        Me.panelAr.Controls.Add(Me.IconButton1)
        Me.panelAr.Controls.Add(Me.Label2)
        Me.panelAr.Controls.Add(Me.Label1)
        Me.panelAr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelAr.Location = New System.Drawing.Point(0, 36)
        Me.panelAr.Name = "panelAr"
        Me.panelAr.Size = New System.Drawing.Size(449, 176)
        Me.panelAr.TabIndex = 10
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconSize = 32
        Me.IconButton1.Location = New System.Drawing.Point(150, 180)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(159, 36)
        Me.IconButton1.TabIndex = 2
        Me.IconButton1.Text = "Continuar"
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(85, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(270, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Has completado el primer nivel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(159, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "¡Felicidades!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(103, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 60)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Revisa en el botón de opciones " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para regresar al menu Principal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y cierra esta v" &
    "entana." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frm_QFN1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 212)
        Me.Controls.Add(Me.panelAr)
        Me.Controls.Add(Me.apppanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_QFN1"
        Me.Text = "Form15"
        Me.apppanel.ResumeLayout(False)
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAr.ResumeLayout(False)
        Me.panelAr.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents apppanel As Panel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents panelAr As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Label3 As Label
End Class
