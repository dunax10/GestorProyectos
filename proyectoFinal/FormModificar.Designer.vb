<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormModificar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NombreIngresado = New System.Windows.Forms.TextBox()
        Me.NombreClienteIngresado = New System.Windows.Forms.TextBox()
        Me.NombreResponsableIngresado = New System.Windows.Forms.TextBox()
        Me.FechaInicioIngresada = New System.Windows.Forms.DateTimePicker()
        Me.FechaEntregaIngresada = New System.Windows.Forms.DateTimePicker()
        Me.ModificarBoton = New System.Windows.Forms.Button()
        Me.EstadoIngresado = New System.Windows.Forms.ComboBox()
        Me.volverBoton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(309, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 16)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Cambiar los datos de un proyecto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 16)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Nombre del proyecto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Nombre de cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 16)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Nombre de responsable:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 16)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Fecha inicio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 16)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Fecha entrega:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 16)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Estado:"
        '
        'NombreIngresado
        '
        Me.NombreIngresado.Location = New System.Drawing.Point(220, 80)
        Me.NombreIngresado.Name = "NombreIngresado"
        Me.NombreIngresado.Size = New System.Drawing.Size(284, 22)
        Me.NombreIngresado.TabIndex = 55
        '
        'NombreClienteIngresado
        '
        Me.NombreClienteIngresado.Location = New System.Drawing.Point(220, 127)
        Me.NombreClienteIngresado.Name = "NombreClienteIngresado"
        Me.NombreClienteIngresado.Size = New System.Drawing.Size(284, 22)
        Me.NombreClienteIngresado.TabIndex = 56
        '
        'NombreResponsableIngresado
        '
        Me.NombreResponsableIngresado.Location = New System.Drawing.Point(220, 176)
        Me.NombreResponsableIngresado.Name = "NombreResponsableIngresado"
        Me.NombreResponsableIngresado.Size = New System.Drawing.Size(284, 22)
        Me.NombreResponsableIngresado.TabIndex = 57
        '
        'FechaInicioIngresada
        '
        Me.FechaInicioIngresada.Location = New System.Drawing.Point(220, 223)
        Me.FechaInicioIngresada.Name = "FechaInicioIngresada"
        Me.FechaInicioIngresada.Size = New System.Drawing.Size(297, 22)
        Me.FechaInicioIngresada.TabIndex = 61
        '
        'FechaEntregaIngresada
        '
        Me.FechaEntregaIngresada.Location = New System.Drawing.Point(220, 269)
        Me.FechaEntregaIngresada.Name = "FechaEntregaIngresada"
        Me.FechaEntregaIngresada.Size = New System.Drawing.Size(297, 22)
        Me.FechaEntregaIngresada.TabIndex = 62
        '
        'ModificarBoton
        '
        Me.ModificarBoton.Location = New System.Drawing.Point(699, 433)
        Me.ModificarBoton.Name = "ModificarBoton"
        Me.ModificarBoton.Size = New System.Drawing.Size(154, 49)
        Me.ModificarBoton.TabIndex = 63
        Me.ModificarBoton.Text = "Modificar"
        Me.ModificarBoton.UseVisualStyleBackColor = True
        '
        'EstadoIngresado
        '
        Me.EstadoIngresado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadoIngresado.FormattingEnabled = True
        Me.EstadoIngresado.Items.AddRange(New Object() {"Terminado", "En proceso", "Pausado"})
        Me.EstadoIngresado.Location = New System.Drawing.Point(220, 323)
        Me.EstadoIngresado.Name = "EstadoIngresado"
        Me.EstadoIngresado.Size = New System.Drawing.Size(186, 24)
        Me.EstadoIngresado.TabIndex = 85
        '
        'volverBoton
        '
        Me.volverBoton.Location = New System.Drawing.Point(12, 22)
        Me.volverBoton.Name = "volverBoton"
        Me.volverBoton.Size = New System.Drawing.Size(126, 23)
        Me.volverBoton.TabIndex = 91
        Me.volverBoton.Text = "Volver al inicio"
        Me.volverBoton.UseVisualStyleBackColor = True
        '
        'FormModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 534)
        Me.Controls.Add(Me.volverBoton)
        Me.Controls.Add(Me.EstadoIngresado)
        Me.Controls.Add(Me.ModificarBoton)
        Me.Controls.Add(Me.FechaEntregaIngresada)
        Me.Controls.Add(Me.FechaInicioIngresada)
        Me.Controls.Add(Me.NombreResponsableIngresado)
        Me.Controls.Add(Me.NombreClienteIngresado)
        Me.Controls.Add(Me.NombreIngresado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormModificar"
        Me.Text = "FormModificar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NombreIngresado As TextBox
    Friend WithEvents NombreClienteIngresado As TextBox
    Friend WithEvents NombreResponsableIngresado As TextBox
    Friend WithEvents FechaInicioIngresada As DateTimePicker
    Friend WithEvents FechaEntregaIngresada As DateTimePicker
    Friend WithEvents ModificarBoton As Button
    Friend WithEvents EstadoIngresado As ComboBox
    Friend WithEvents volverBoton As Button
End Class
