<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormIngresar
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NombreIngresado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NombreClienteIngresado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NombreResponsableIngresado = New System.Windows.Forms.TextBox()
        Me.InsertarBoton = New System.Windows.Forms.Button()
        Me.FechaInicioIngresada = New System.Windows.Forms.DateTimePicker()
        Me.FechaEntregaIngresada = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EstadoIngresado = New System.Windows.Forms.ComboBox()
        Me.volverBoton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre del proyecto:"
        '
        'NombreIngresado
        '
        Me.NombreIngresado.Location = New System.Drawing.Point(166, 106)
        Me.NombreIngresado.Name = "NombreIngresado"
        Me.NombreIngresado.Size = New System.Drawing.Size(100, 22)
        Me.NombreIngresado.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre del cliente:"
        '
        'NombreClienteIngresado
        '
        Me.NombreClienteIngresado.Location = New System.Drawing.Point(166, 157)
        Me.NombreClienteIngresado.Name = "NombreClienteIngresado"
        Me.NombreClienteIngresado.Size = New System.Drawing.Size(100, 22)
        Me.NombreClienteIngresado.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha de inicio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fecha de entrega:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 407)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Estado:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nombre del responsable:"
        '
        'NombreResponsableIngresado
        '
        Me.NombreResponsableIngresado.Location = New System.Drawing.Point(182, 216)
        Me.NombreResponsableIngresado.Name = "NombreResponsableIngresado"
        Me.NombreResponsableIngresado.Size = New System.Drawing.Size(100, 22)
        Me.NombreResponsableIngresado.TabIndex = 13
        '
        'InsertarBoton
        '
        Me.InsertarBoton.Location = New System.Drawing.Point(405, 393)
        Me.InsertarBoton.Name = "InsertarBoton"
        Me.InsertarBoton.Size = New System.Drawing.Size(75, 23)
        Me.InsertarBoton.TabIndex = 15
        Me.InsertarBoton.Text = "Insertar"
        Me.InsertarBoton.UseVisualStyleBackColor = True
        '
        'FechaInicioIngresada
        '
        Me.FechaInicioIngresada.Location = New System.Drawing.Point(148, 278)
        Me.FechaInicioIngresada.Name = "FechaInicioIngresada"
        Me.FechaInicioIngresada.Size = New System.Drawing.Size(266, 22)
        Me.FechaInicioIngresada.TabIndex = 17
        '
        'FechaEntregaIngresada
        '
        Me.FechaEntregaIngresada.Location = New System.Drawing.Point(148, 344)
        Me.FechaEntregaIngresada.Name = "FechaEntregaIngresada"
        Me.FechaEntregaIngresada.Size = New System.Drawing.Size(266, 22)
        Me.FechaEntregaIngresada.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(331, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Ingresar los proyectos"
        '
        'EstadoIngresado
        '
        Me.EstadoIngresado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadoIngresado.FormattingEnabled = True
        Me.EstadoIngresado.Items.AddRange(New Object() {"Terminado", "En proceso", "Pausado"})
        Me.EstadoIngresado.Location = New System.Drawing.Point(148, 399)
        Me.EstadoIngresado.Name = "EstadoIngresado"
        Me.EstadoIngresado.Size = New System.Drawing.Size(121, 24)
        Me.EstadoIngresado.TabIndex = 86
        '
        'volverBoton
        '
        Me.volverBoton.Location = New System.Drawing.Point(13, 17)
        Me.volverBoton.Name = "volverBoton"
        Me.volverBoton.Size = New System.Drawing.Size(126, 23)
        Me.volverBoton.TabIndex = 90
        Me.volverBoton.Text = "Volver al inicio"
        Me.volverBoton.UseVisualStyleBackColor = True
        '
        'FormIngresar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.volverBoton)
        Me.Controls.Add(Me.EstadoIngresado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FechaEntregaIngresada)
        Me.Controls.Add(Me.FechaInicioIngresada)
        Me.Controls.Add(Me.InsertarBoton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NombreResponsableIngresado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NombreClienteIngresado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NombreIngresado)
        Me.Name = "FormIngresar"
        Me.Text = "FormIngresar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents NombreIngresado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NombreClienteIngresado As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NombreResponsableIngresado As TextBox
    Friend WithEvents InsertarBoton As Button
    Friend WithEvents FechaInicioIngresada As DateTimePicker
    Friend WithEvents FechaEntregaIngresada As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents EstadoIngresado As ComboBox
    Friend WithEvents volverBoton As Button
End Class
