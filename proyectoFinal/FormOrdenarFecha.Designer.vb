<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrdenarFecha
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
        Me.Datos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreProyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ModificarBoton = New System.Windows.Forms.Button()
        Me.ModificarEstadoBoton = New System.Windows.Forms.Button()
        Me.EliminarBoton = New System.Windows.Forms.Button()
        Me.ModificarFechaEntregaForm = New System.Windows.Forms.Button()
        Me.NombreIngresado = New System.Windows.Forms.TextBox()
        Me.RecargarBoton = New System.Windows.Forms.Button()
        Me.EstadoIngresado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.volverBoton = New System.Windows.Forms.Button()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Datos
        '
        Me.Datos.AllowUserToAddRows = False
        Me.Datos.AllowUserToDeleteRows = False
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.nombreProyecto, Me.nombreCliente, Me.nombreResponsable, Me.fechaInicio, Me.fechaEntrega, Me.estado})
        Me.Datos.Location = New System.Drawing.Point(12, 117)
        Me.Datos.MultiSelect = False
        Me.Datos.Name = "Datos"
        Me.Datos.ReadOnly = True
        Me.Datos.RowHeadersWidth = 51
        Me.Datos.RowTemplate.Height = 24
        Me.Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datos.Size = New System.Drawing.Size(776, 266)
        Me.Datos.TabIndex = 40
        '
        'ID
        '
        Me.ID.HeaderText = "Id"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 125
        '
        'nombreProyecto
        '
        Me.nombreProyecto.HeaderText = "Nombre del proyecto"
        Me.nombreProyecto.MinimumWidth = 6
        Me.nombreProyecto.Name = "nombreProyecto"
        Me.nombreProyecto.ReadOnly = True
        Me.nombreProyecto.Width = 125
        '
        'nombreCliente
        '
        Me.nombreCliente.HeaderText = "Nombre del cliente"
        Me.nombreCliente.MinimumWidth = 6
        Me.nombreCliente.Name = "nombreCliente"
        Me.nombreCliente.ReadOnly = True
        Me.nombreCliente.Width = 125
        '
        'nombreResponsable
        '
        Me.nombreResponsable.HeaderText = "Nombre del responsable"
        Me.nombreResponsable.MinimumWidth = 6
        Me.nombreResponsable.Name = "nombreResponsable"
        Me.nombreResponsable.ReadOnly = True
        Me.nombreResponsable.Width = 125
        '
        'fechaInicio
        '
        Me.fechaInicio.HeaderText = "Fecha de inicio"
        Me.fechaInicio.MinimumWidth = 6
        Me.fechaInicio.Name = "fechaInicio"
        Me.fechaInicio.ReadOnly = True
        Me.fechaInicio.Width = 125
        '
        'fechaEntrega
        '
        Me.fechaEntrega.HeaderText = "Fecha de entrega"
        Me.fechaEntrega.MinimumWidth = 6
        Me.fechaEntrega.Name = "fechaEntrega"
        Me.fechaEntrega.ReadOnly = True
        Me.fechaEntrega.Width = 125
        '
        'estado
        '
        Me.estado.HeaderText = "Estado"
        Me.estado.MinimumWidth = 6
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Width = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Todos los proyectos por fecha"
        '
        'ModificarBoton
        '
        Me.ModificarBoton.Location = New System.Drawing.Point(30, 405)
        Me.ModificarBoton.Name = "ModificarBoton"
        Me.ModificarBoton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarBoton.TabIndex = 42
        Me.ModificarBoton.Text = "Modificar"
        Me.ModificarBoton.UseVisualStyleBackColor = True
        '
        'ModificarEstadoBoton
        '
        Me.ModificarEstadoBoton.Location = New System.Drawing.Point(146, 405)
        Me.ModificarEstadoBoton.Name = "ModificarEstadoBoton"
        Me.ModificarEstadoBoton.Size = New System.Drawing.Size(158, 23)
        Me.ModificarEstadoBoton.TabIndex = 43
        Me.ModificarEstadoBoton.Text = "Modificar el estado"
        Me.ModificarEstadoBoton.UseVisualStyleBackColor = True
        '
        'EliminarBoton
        '
        Me.EliminarBoton.Location = New System.Drawing.Point(560, 405)
        Me.EliminarBoton.Name = "EliminarBoton"
        Me.EliminarBoton.Size = New System.Drawing.Size(95, 23)
        Me.EliminarBoton.TabIndex = 44
        Me.EliminarBoton.Text = "Eliminar"
        Me.EliminarBoton.UseVisualStyleBackColor = True
        '
        'ModificarFechaEntregaForm
        '
        Me.ModificarFechaEntregaForm.Location = New System.Drawing.Point(330, 405)
        Me.ModificarFechaEntregaForm.Name = "ModificarFechaEntregaForm"
        Me.ModificarFechaEntregaForm.Size = New System.Drawing.Size(205, 23)
        Me.ModificarFechaEntregaForm.TabIndex = 52
        Me.ModificarFechaEntregaForm.Text = "Modificar la fecha de entrega"
        Me.ModificarFechaEntregaForm.UseVisualStyleBackColor = True
        '
        'NombreIngresado
        '
        Me.NombreIngresado.Location = New System.Drawing.Point(146, 61)
        Me.NombreIngresado.Name = "NombreIngresado"
        Me.NombreIngresado.Size = New System.Drawing.Size(100, 22)
        Me.NombreIngresado.TabIndex = 53
        '
        'RecargarBoton
        '
        Me.RecargarBoton.Location = New System.Drawing.Point(693, 405)
        Me.RecargarBoton.Name = "RecargarBoton"
        Me.RecargarBoton.Size = New System.Drawing.Size(95, 23)
        Me.RecargarBoton.TabIndex = 54
        Me.RecargarBoton.Text = "Recargar"
        Me.RecargarBoton.UseVisualStyleBackColor = True
        '
        'EstadoIngresado
        '
        Me.EstadoIngresado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadoIngresado.FormattingEnabled = True
        Me.EstadoIngresado.Items.AddRange(New Object() {"Terminado", "En proceso", "Pausado"})
        Me.EstadoIngresado.Location = New System.Drawing.Point(600, 67)
        Me.EstadoIngresado.Name = "EstadoIngresado"
        Me.EstadoIngresado.Size = New System.Drawing.Size(121, 24)
        Me.EstadoIngresado.TabIndex = 87
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(478, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Listar por estado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 16)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Listar por nombre"
        '
        'volverBoton
        '
        Me.volverBoton.Location = New System.Drawing.Point(12, 12)
        Me.volverBoton.Name = "volverBoton"
        Me.volverBoton.Size = New System.Drawing.Size(126, 23)
        Me.volverBoton.TabIndex = 89
        Me.volverBoton.Text = "Volver al inicio"
        Me.volverBoton.UseVisualStyleBackColor = True
        '
        'FormOrdenarFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.volverBoton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EstadoIngresado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RecargarBoton)
        Me.Controls.Add(Me.NombreIngresado)
        Me.Controls.Add(Me.ModificarFechaEntregaForm)
        Me.Controls.Add(Me.EliminarBoton)
        Me.Controls.Add(Me.ModificarEstadoBoton)
        Me.Controls.Add(Me.ModificarBoton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Datos)
        Me.Name = "FormOrdenarFecha"
        Me.Text = "FormOrdenarFecha"
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Datos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ModificarBoton As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents nombreProyecto As DataGridViewTextBoxColumn
    Friend WithEvents nombreCliente As DataGridViewTextBoxColumn
    Friend WithEvents nombreResponsable As DataGridViewTextBoxColumn
    Friend WithEvents fechaInicio As DataGridViewTextBoxColumn
    Friend WithEvents fechaEntrega As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents ModificarEstadoBoton As Button
    Friend WithEvents EliminarBoton As Button
    Friend WithEvents ModificarFechaEntregaForm As Button
    Friend WithEvents NombreIngresado As TextBox
    Friend WithEvents RecargarBoton As Button
    Friend WithEvents EstadoIngresado As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents volverBoton As Button
End Class
