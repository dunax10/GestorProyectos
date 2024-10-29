Public Class FormModificar
    Dim proyectoModificar As proyecto
    Dim formOrigen As Form
    Public Sub mostrarFormulario(idTarea As Integer, formularioDeOrigen As Form)
        proyectoModificar = proyecto.TraerProyectoPorId(idTarea)
        formOrigen = formularioDeOrigen
        Me.Show()

        NombreIngresado.Text = proyectoModificar.nombreProyecto
        NombreClienteIngresado.Text = proyectoModificar.nombreCliente
        NombreResponsableIngresado.Text = proyectoModificar.nombreResponsable
        FechaInicioIngresada.Value = proyectoModificar.fechaInicio
        FechaEntregaIngresada.Value = proyectoModificar.fechaEntrega
        If (proyectoModificar.estado = "Terminado") Then
            EstadoIngresado.SelectedIndex = 0
        End If
        If (proyectoModificar.estado = "En proceso") Then
            EstadoIngresado.SelectedIndex = 1
        End If
        If (proyectoModificar.estado = "Pausado") Then
            EstadoIngresado.SelectedIndex = 2
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ModificarBoton.Click
        If String.IsNullOrWhiteSpace(NombreIngresado.Text) Then
            MsgBox("Debe ingresar un nombre de proyecto")
            NombreIngresado.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(NombreClienteIngresado.Text) Then
            MsgBox("Debe ingresar un nombre de cliente")
            NombreClienteIngresado.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(NombreResponsableIngresado.Text) Then
            MsgBox("Debe ingresar un nombre de responsable")
            NombreResponsableIngresado.Focus()
            Exit Sub
        End If
        If (FechaEntregaIngresada.Text < FechaInicioIngresada.Text) Then
            MsgBox("La fecha de inicio no puede ser mayor a la de entrega")
            FechaInicioIngresada.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(EstadoIngresado.Text) Then
            MsgBox("Debe seleccionar un estado")
            EstadoIngresado.Focus()
            Exit Sub
        End If

        Dim idProyecto As Integer = proyectoModificar.IdProyecto
        proyectoModificar.nombreProyecto = NombreIngresado.Text
        proyectoModificar.nombreProyecto = NombreIngresado.Text
        proyectoModificar.nombreProyecto = NombreIngresado.Text
        proyectoModificar.fechaInicio = FechaInicioIngresada.Value
        proyectoModificar.fechaEntrega = FechaEntregaIngresada.Value
        proyectoModificar.estado = EstadoIngresado.Text

        proyectoModificar.ModificarProyectoPorId(idProyecto)
        formOrigen.Show()
        Me.Hide()
    End Sub

    Private Sub volverBoton_Click(sender As Object, e As EventArgs) Handles volverBoton.Click
        PaginaPrincipal.Show()
        Me.Hide()
    End Sub

End Class