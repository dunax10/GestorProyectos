<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormModificarFechaEntrega
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
        Me.FechaInicioMostrar = New System.Windows.Forms.Label()
        Me.NombreResponsableMostrar = New System.Windows.Forms.Label()
        Me.NombreClienteMostrar = New System.Windows.Forms.Label()
        Me.NombreMostrar = New System.Windows.Forms.Label()
        Me.ModificarBoton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EstadoMostrar = New System.Windows.Forms.Label()
        Me.FechaEntregaIngresada = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'FechaInicioMostrar
        '
        Me.FechaInicioMostrar.AutoSize = True
        Me.FechaInicioMostrar.Location = New System.Drawing.Point(261, 253)
        Me.FechaInicioMostrar.Name = "FechaInicioMostrar"
        Me.FechaInicioMostrar.Size = New System.Drawing.Size(137, 16)
        Me.FechaInicioMostrar.TabIndex = 96
        Me.FechaInicioMostrar.Text = "Nombre del proyecto:"
        '
        'NombreResponsableMostrar
        '
        Me.NombreResponsableMostrar.AutoSize = True
        Me.NombreResponsableMostrar.Location = New System.Drawing.Point(261, 201)
        Me.NombreResponsableMostrar.Name = "NombreResponsableMostrar"
        Me.NombreResponsableMostrar.Size = New System.Drawing.Size(137, 16)
        Me.NombreResponsableMostrar.TabIndex = 95
        Me.NombreResponsableMostrar.Text = "Nombre del proyecto:"
        '
        'NombreClienteMostrar
        '
        Me.NombreClienteMostrar.AutoSize = True
        Me.NombreClienteMostrar.Location = New System.Drawing.Point(261, 142)
        Me.NombreClienteMostrar.Name = "NombreClienteMostrar"
        Me.NombreClienteMostrar.Size = New System.Drawing.Size(137, 16)
        Me.NombreClienteMostrar.TabIndex = 94
        Me.NombreClienteMostrar.Text = "Nombre del proyecto:"
        '
        'NombreMostrar
        '
        Me.NombreMostrar.AutoSize = True
        Me.NombreMostrar.Location = New System.Drawing.Point(261, 104)
        Me.NombreMostrar.Name = "NombreMostrar"
        Me.NombreMostrar.Size = New System.Drawing.Size(137, 16)
        Me.NombreMostrar.TabIndex = 93
        Me.NombreMostrar.Text = "Nombre del proyecto:"
        '
        'ModificarBoton
        '
        Me.ModificarBoton.Location = New System.Drawing.Point(570, 413)
        Me.ModificarBoton.Name = "ModificarBoton"
        Me.ModificarBoton.Size = New System.Drawing.Size(154, 49)
        Me.ModificarBoton.TabIndex = 92
        Me.ModificarBoton.Text = "Modificar"
        Me.ModificarBoton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 16)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Estado:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 16)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Fecha entrega:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Fecha inicio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 16)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Nombre de responsable:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Nombre de cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 16)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Nombre del proyecto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(327, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 16)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Cambiar la fecha de entrega"
        '
        'EstadoMostrar
        '
        Me.EstadoMostrar.AutoSize = True
        Me.EstadoMostrar.Location = New System.Drawing.Point(261, 344)
        Me.EstadoMostrar.Name = "EstadoMostrar"
        Me.EstadoMostrar.Size = New System.Drawing.Size(137, 16)
        Me.EstadoMostrar.TabIndex = 99
        Me.EstadoMostrar.Text = "Nombre del proyecto:"
        '
        'FechaEntregaIngresada
        '
        Me.FechaEntregaIngresada.Location = New System.Drawing.Point(264, 293)
        Me.FechaEntregaIngresada.Name = "FechaEntregaIngresada"
        Me.FechaEntregaIngresada.Size = New System.Drawing.Size(280, 22)
        Me.FechaEntregaIngresada.TabIndex = 100
        '
        'FormModificarFechaEntrega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 504)
        Me.Controls.Add(Me.FechaEntregaIngresada)
        Me.Controls.Add(Me.EstadoMostrar)
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
        Me.Name = "FormModificarFechaEntrega"
        Me.Text = "FormModificarFechaEntrega"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FechaInicioMostrar As Label
    Friend WithEvents NombreResponsableMostrar As Label
    Friend WithEvents NombreClienteMostrar As Label
    Friend WithEvents NombreMostrar As Label
    Friend WithEvents ModificarBoton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EstadoMostrar As Label
    Friend WithEvents FechaEntregaIngresada As DateTimePicker
End Class
