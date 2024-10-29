<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCambiarEstado
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
        Me.ModificarBoton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NombreMostrar = New System.Windows.Forms.Label()
        Me.NombreClienteMostrar = New System.Windows.Forms.Label()
        Me.NombreResponsableMostrar = New System.Windows.Forms.Label()
        Me.FechaInicioMostrar = New System.Windows.Forms.Label()
        Me.FechaEntregaMostrar = New System.Windows.Forms.Label()
        Me.EstadoIngresado = New System.Windows.Forms.ComboBox()
        Me.volverBoton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ModificarBoton
        '
        Me.ModificarBoton.Location = New System.Drawing.Point(751, 457)
        Me.ModificarBoton.Name = "ModificarBoton"
        Me.ModificarBoton.Size = New System.Drawing.Size(154, 49)
        Me.ModificarBoton.TabIndex = 77
        Me.ModificarBoton.Text = "Modificar"
        Me.ModificarBoton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 350)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 16)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Estado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 16)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Fecha entrega:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "Fecha inicio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 16)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Nombre de responsable:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Nombre de cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 16)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Nombre del proyecto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(361, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 16)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Cambiar el estado de un proyecto"
        '
        'NombreMostrar
        '
        Me.NombreMostrar.AutoSize = True
        Me.NombreMostrar.Location = New System.Drawing.Point(287, 110)
        Me.NombreMostrar.Name = "NombreMostrar"
        Me.NombreMostrar.Size = New System.Drawing.Size(137, 16)
        Me.NombreMostrar.TabIndex = 78
        Me.NombreMostrar.Text = "Nombre del proyecto:"
        '
        'NombreClienteMostrar
        '
        Me.NombreClienteMostrar.AutoSize = True
        Me.NombreClienteMostrar.Location = New System.Drawing.Point(287, 148)
        Me.NombreClienteMostrar.Name = "NombreClienteMostrar"
        Me.NombreClienteMostrar.Size = New System.Drawing.Size(137, 16)
        Me.NombreClienteMostrar.TabIndex = 79
        Me.NombreClienteMostrar.Text = "Nombre del proyecto:"
        '
        'NombreResponsableMostrar
        '
        Me.NombreResponsableMostrar.AutoSize = True
        Me.NombreResponsableMostrar.Location = New System.Drawing.Point(287, 207)
        Me.NombreResponsableMostrar.Name = "NombreResponsableMostrar"
        Me.NombreResponsableMostrar.Size = New System.Drawing.Size(137, 16)
        Me.NombreResponsableMostrar.TabIndex = 80
        Me.NombreResponsableMostrar.Text = "Nombre del proyecto:"
        '
        'FechaInicioMostrar
        '
        Me.FechaInicioMostrar.AutoSize = True
        Me.FechaInicioMostrar.Location = New System.Drawing.Point(287, 259)
        Me.FechaInicioMostrar.Name = "FechaInicioMostrar"
        Me.FechaInicioMostrar.Size = New System.Drawing.Size(137, 16)
        Me.FechaInicioMostrar.TabIndex = 81
        Me.FechaInicioMostrar.Text = "Nombre del proyecto:"
        '
        'FechaEntregaMostrar
        '
        Me.FechaEntregaMostrar.AutoSize = True
        Me.FechaEntregaMostrar.Location = New System.Drawing.Point(287, 304)
        Me.FechaEntregaMostrar.Name = "FechaEntregaMostrar"
        Me.FechaEntregaMostrar.Size = New System.Drawing.Size(137, 16)
        Me.FechaEntregaMostrar.TabIndex = 82
        Me.FechaEntregaMostrar.Text = "Nombre del proyecto:"
        '
        'EstadoIngresado
        '
        Me.EstadoIngresado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadoIngresado.FormattingEnabled = True
        Me.EstadoIngresado.Items.AddRange(New Object() {"Terminado", "En proceso", "Pausado"})
        Me.EstadoIngresado.Location = New System.Drawing.Point(290, 342)
        Me.EstadoIngresado.Name = "EstadoIngresado"
        Me.EstadoIngresado.Size = New System.Drawing.Size(121, 24)
        Me.EstadoIngresado.TabIndex = 84
        '
        'volverBoton
        '
        Me.volverBoton.Location = New System.Drawing.Point(35, 27)
        Me.volverBoton.Name = "volverBoton"
        Me.volverBoton.Size = New System.Drawing.Size(126, 23)
        Me.volverBoton.TabIndex = 102
        Me.volverBoton.Text = "Volver al inicio"
        Me.volverBoton.UseVisualStyleBackColor = True
        '
        'FormCambiarEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 559)
        Me.Controls.Add(Me.volverBoton)
        Me.Controls.Add(Me.EstadoIngresado)
        Me.Controls.Add(Me.FechaEntregaMostrar)
        Me.Controls.Add(Me.FechaInicioMostrar)
        Me.Controls.Add(Me.NombreResponsableMostrar)
        Me.Controls.Add(Me.NombreClienteMostrar)
        Me.Controls.Add(Me.NombreMostrar)
        Me.Controls.Add(Me.ModificarBoton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormCambiarEstado"
        Me.Text = "FormCambiarEstado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ModificarBoton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NombreMostrar As Label
    Friend WithEvents NombreClienteMostrar As Label
    Friend WithEvents NombreResponsableMostrar As Label
    Friend WithEvents FechaInicioMostrar As Label
    Friend WithEvents FechaEntregaMostrar As Label
    Friend WithEvents EstadoIngresado As ComboBox
    Friend WithEvents volverBoton As Button
End Class
