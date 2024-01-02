<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_error
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_error))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ap = New System.Windows.Forms.PictureBox()
        Me.panelAr = New System.Windows.Forms.Panel()
        CType(Me.ap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAr.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(117, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Respuesta Incorrecta!"
        '
        'ap
        '
        Me.ap.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ap.BackColor = System.Drawing.Color.Red
        Me.ap.Image = CType(resources.GetObject("ap.Image"), System.Drawing.Image)
        Me.ap.Location = New System.Drawing.Point(3, 127)
        Me.ap.Name = "ap"
        Me.ap.Size = New System.Drawing.Size(45, 44)
        Me.ap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ap.TabIndex = 17
        Me.ap.TabStop = False
        '
        'panelAr
        '
        Me.panelAr.Controls.Add(Me.Label1)
        Me.panelAr.Controls.Add(Me.ap)
        Me.panelAr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelAr.Location = New System.Drawing.Point(0, 0)
        Me.panelAr.Name = "panelAr"
        Me.panelAr.Size = New System.Drawing.Size(424, 223)
        Me.panelAr.TabIndex = 18
        '
        'frm_error
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(424, 223)
        Me.Controls.Add(Me.panelAr)
        Me.Name = "frm_error"
        Me.Text = "Form10"
        CType(Me.ap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAr.ResumeLayout(False)
        Me.panelAr.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ap As PictureBox
    Friend WithEvents panelAr As Panel
End Class
