<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaginaPrincipal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.salirBoton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(328, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Escoge que quiere hacer"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(331, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 49)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Insertar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(24, 376)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 43)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Buscar por nombre"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(572, 198)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 81)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Ver todos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 207)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(216, 72)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Ordenar por fecha"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(191, 376)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(126, 43)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Buscar por estado"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'salirBoton
        '
        Me.salirBoton.Location = New System.Drawing.Point(663, 376)
        Me.salirBoton.Name = "salirBoton"
        Me.salirBoton.Size = New System.Drawing.Size(108, 46)
        Me.salirBoton.TabIndex = 6
        Me.salirBoton.Text = "Salir"
        Me.salirBoton.UseVisualStyleBackColor = True
        '
        'PaginaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.salirBoton)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PaginaPrincipal"
        Me.Text = "PaginaPrincipal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents salirBoton As Button
End Class
