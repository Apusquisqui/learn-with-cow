<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Q5
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
        Me.panelAr = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelAr.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelAr
        '
        Me.panelAr.Controls.Add(Me.Button1)
        Me.panelAr.Controls.Add(Me.Button2)
        Me.panelAr.Controls.Add(Me.Button3)
        Me.panelAr.Controls.Add(Me.Button4)
        Me.panelAr.Controls.Add(Me.Label2)
        Me.panelAr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelAr.Location = New System.Drawing.Point(0, 0)
        Me.panelAr.Name = "panelAr"
        Me.panelAr.Size = New System.Drawing.Size(433, 173)
        Me.panelAr.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(238, 111)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 50)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "d) Hardware del sistema"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(238, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 43)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "c) Sistema operativo y utilidades"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Teal
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(25, 111)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(189, 50)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "b) Herramientas de desarrollo de software"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Teal
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(25, 62)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(189, 43)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "a) Programas de aplicación específicos"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(75, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(282, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "¿Qué es el software de sistema en un sistema informático?"
        '
        'frm_Q5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 173)
        Me.Controls.Add(Me.panelAr)
        Me.Name = "frm_Q5"
        Me.Text = "Form14"
        Me.panelAr.ResumeLayout(False)
        Me.panelAr.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelAr As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
End Class
