<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrdenarEstado
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
        Me.EliminarBoton = New System.Windows.Forms.Button()
        Me.ModificarEstadoBoton = New System.Windows.Forms.Button()
        Me.ModificarBoton = New System.Windows.Forms.Button()
        Me.Datos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreProyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EstadoIngresado = New System.Windows.Forms.ComboBox()
        Me.ModificarFechaEntregaForm = New System.Windows.Forms.Button()
        Me.volverBoton = New System.Windows.Forms.Button()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EliminarBoton
        '
        Me.EliminarBoton.Location = New System.Drawing.Point(612, 444)
        Me.EliminarBoton.Name = "EliminarBoton"
        Me.EliminarBoton.Size = New System.Drawing.Size(95, 23)
        Me.EliminarBoton.TabIndex = 48
        Me.EliminarBoton.Text = "Eliminar"
        Me.EliminarBoton.UseVisualStyleBackColor = True
        '
        'ModificarEstadoBoton
        '
        Me.ModificarEstadoBoton.Location = New System.Drawing.Point(199, 444)
        Me.ModificarEstadoBoton.Name = "ModificarEstadoBoton"
        Me.ModificarEstadoBoton.Size = New System.Drawing.Size(158, 23)
        Me.ModificarEstadoBoton.TabIndex = 47
        Me.ModificarEstadoBoton.Text = "Modificar el estado"
        Me.ModificarEstadoBoton.UseVisualStyleBackColor = True
        '
        'ModificarBoton
        '
        Me.ModificarBoton.Location = New System.Drawing.Point(83, 444)
        Me.ModificarBoton.Name = "ModificarBoton"
        Me.ModificarBoton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarBoton.TabIndex = 46
        Me.ModificarBoton.Text = "Modificar"
        Me.ModificarBoton.UseVisualStyleBackColor = True
        '
        'Datos
        '
        Me.Datos.AllowUserToAddRows = False
        Me.Datos.AllowUserToDeleteRows = False
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.nombreProyecto, Me.nombreCliente, Me.nombreResponsable, Me.fechaInicio, Me.fechaEntrega, Me.estado})
        Me.Datos.Location = New System.Drawing.Point(65, 156)
        Me.Datos.MultiSelect = False
        Me.Datos.Name = "Datos"
        Me.Datos.ReadOnly = True
        Me.Datos.RowHeadersWidth = 51
        Me.Datos.RowTemplate.Height = 24
        Me.Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datos.Size = New System.Drawing.Size(776, 266)
        Me.Datos.TabIndex = 45
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
        Me.Label1.Location = New System.Drawing.Point(379, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 16)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Ordenar por estado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Listar por estado"
        '
        'EstadoIngresado
        '
        Me.EstadoIngresado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EstadoIngresado.FormattingEnabled = True
        Me.EstadoIngresado.Items.AddRange(New Object() {"Terminado", "En proceso", "Pausado"})
        Me.EstadoIngresado.Location = New System.Drawing.Point(176, 80)
        Me.EstadoIngresado.Name = "EstadoIngresado"
        Me.EstadoIngresado.Size = New System.Drawing.Size(121, 24)
        Me.EstadoIngresado.TabIndex = 85
        '
        'ModificarFechaEntregaForm
        '
        Me.ModificarFechaEntregaForm.Location = New System.Drawing.Point(382, 444)
        Me.ModificarFechaEntregaForm.Name = "ModificarFechaEntregaForm"
        Me.ModificarFechaEntregaForm.Size = New System.Drawing.Size(205, 23)
        Me.ModificarFechaEntregaForm.TabIndex = 86
        Me.ModificarFechaEntregaForm.Text = "Modificar la fecha de entrega"
        Me.ModificarFechaEntregaForm.UseVisualStyleBackColor = True
        '
        'volverBoton
        '
        Me.volverBoton.Location = New System.Drawing.Point(12, 12)
        Me.volverBoton.Name = "volverBoton"
        Me.volverBoton.Size = New System.Drawing.Size(126, 23)
        Me.volverBoton.TabIndex = 95
        Me.volverBoton.Text = "Volver al inicio"
        Me.volverBoton.UseVisualStyleBackColor = True
        '
        'FormOrdenarEstado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 514)
        Me.Controls.Add(Me.volverBoton)
        Me.Controls.Add(Me.ModificarFechaEntregaForm)
        Me.Controls.Add(Me.EstadoIngresado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EliminarBoton)
        Me.Controls.Add(Me.ModificarEstadoBoton)
        Me.Controls.Add(Me.ModificarBoton)
        Me.Controls.Add(Me.Datos)
        Me.Name = "FormOrdenarEstado"
        Me.Text = "FormOrdenarEstado"
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EliminarBoton As Button
    Friend WithEvents ModificarEstadoBoton As Button
    Friend WithEvents ModificarBoton As Button
    Friend WithEvents Datos As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents nombreProyecto As DataGridViewTextBoxColumn
    Friend WithEvents nombreCliente As DataGridViewTextBoxColumn
    Friend WithEvents nombreResponsable As DataGridViewTextBoxColumn
    Friend WithEvents fechaInicio As DataGridViewTextBoxColumn
    Friend WithEvents fechaEntrega As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EstadoIngresado As ComboBox
    Friend WithEvents ModificarFechaEntregaForm As Button
    Friend WithEvents volverBoton As Button
End Class
