<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscarNombre
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NombreIngresado = New System.Windows.Forms.TextBox()
        Me.Datos = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreProyecto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EliminarBoton = New System.Windows.Forms.Button()
        Me.ModificarEstadoBoton = New System.Windows.Forms.Button()
        Me.ModificarBoton = New System.Windows.Forms.Button()
        Me.ModificarFechaEntregaForm = New System.Windows.Forms.Button()
        Me.volverBoton = New System.Windows.Forms.Button()
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Buscar por nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nombre:"
        '
        'NombreIngresado
        '
        Me.NombreIngresado.Location = New System.Drawing.Point(82, 65)
        Me.NombreIngresado.Name = "NombreIngresado"
        Me.NombreIngresado.Size = New System.Drawing.Size(100, 22)
        Me.NombreIngresado.TabIndex = 22
        '
        'Datos
        '
        Me.Datos.AllowUserToAddRows = False
        Me.Datos.AllowUserToDeleteRows = False
        Me.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Datos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.nombreProyecto, Me.nombreCliente, Me.nombreResponsable, Me.fechaInicio, Me.fechaEntrega, Me.estado})
        Me.Datos.Location = New System.Drawing.Point(12, 136)
        Me.Datos.MultiSelect = False
        Me.Datos.Name = "Datos"
        Me.Datos.ReadOnly = True
        Me.Datos.RowHeadersWidth = 51
        Me.Datos.RowTemplate.Height = 24
        Me.Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datos.Size = New System.Drawing.Size(776, 266)
        Me.Datos.TabIndex = 38
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
        'EliminarBoton
        '
        Me.EliminarBoton.Location = New System.Drawing.Point(582, 415)
        Me.EliminarBoton.Name = "EliminarBoton"
        Me.EliminarBoton.Size = New System.Drawing.Size(95, 23)
        Me.EliminarBoton.TabIndex = 47
        Me.EliminarBoton.Text = "Eliminar"
        Me.EliminarBoton.UseVisualStyleBackColor = True
        '
        'ModificarEstadoBoton
        '
        Me.ModificarEstadoBoton.Location = New System.Drawing.Point(156, 415)
        Me.ModificarEstadoBoton.Name = "ModificarEstadoBoton"
        Me.ModificarEstadoBoton.Size = New System.Drawing.Size(158, 23)
        Me.ModificarEstadoBoton.TabIndex = 46
        Me.ModificarEstadoBoton.Text = "Modificar el estado"
        Me.ModificarEstadoBoton.UseVisualStyleBackColor = True
        '
        'ModificarBoton
        '
        Me.ModificarBoton.Location = New System.Drawing.Point(40, 415)
        Me.ModificarBoton.Name = "ModificarBoton"
        Me.ModificarBoton.Size = New System.Drawing.Size(75, 23)
        Me.ModificarBoton.TabIndex = 45
        Me.ModificarBoton.Text = "Modificar"
        Me.ModificarBoton.UseVisualStyleBackColor = True
        '
        'ModificarFechaEntregaForm
        '
        Me.ModificarFechaEntregaForm.Location = New System.Drawing.Point(345, 415)
        Me.ModificarFechaEntregaForm.Name = "ModificarFechaEntregaForm"
        Me.ModificarFechaEntregaForm.Size = New System.Drawing.Size(205, 33)
        Me.ModificarFechaEntregaForm.TabIndex = 48
        Me.ModificarFechaEntregaForm.Text = "Modificar la fecha de entrega"
        Me.ModificarFechaEntregaForm.UseVisualStyleBackColor = True
        '
        'volverBoton
        '
        Me.volverBoton.Location = New System.Drawing.Point(15, 11)
        Me.volverBoton.Name = "volverBoton"
        Me.volverBoton.Size = New System.Drawing.Size(126, 23)
        Me.volverBoton.TabIndex = 103
        Me.volverBoton.Text = "Volver al inicio"
        Me.volverBoton.UseVisualStyleBackColor = True
        '
        'FormBuscarNombre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.volverBoton)
        Me.Controls.Add(Me.ModificarFechaEntregaForm)
        Me.Controls.Add(Me.EliminarBoton)
        Me.Controls.Add(Me.ModificarEstadoBoton)
        Me.Controls.Add(Me.ModificarBoton)
        Me.Controls.Add(Me.Datos)
        Me.Controls.Add(Me.NombreIngresado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormBuscarNombre"
        Me.Text = "FormBuscarNombre"
        CType(Me.Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NombreIngresado As TextBox
    Friend WithEvents Datos As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents nombreProyecto As DataGridViewTextBoxColumn
    Friend WithEvents nombreCliente As DataGridViewTextBoxColumn
    Friend WithEvents nombreResponsable As DataGridViewTextBoxColumn
    Friend WithEvents fechaInicio As DataGridViewTextBoxColumn
    Friend WithEvents fechaEntrega As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents EliminarBoton As Button
    Friend WithEvents ModificarEstadoBoton As Button
    Friend WithEvents ModificarBoton As Button
    Friend WithEvents ModificarFechaEntregaForm As Button
    Friend WithEvents volverBoton As Button
End Class
