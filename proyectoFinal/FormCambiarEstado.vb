Public Class FormCambiarEstado
    Dim proyectoModificar As proyecto
    Dim formOrigen As Form
    Public Sub mostrarFormulario(idTarea As Integer, formularioDeOrigen As Form)
        proyectoModificar = proyecto.TraerProyectoPorId(idTarea)
        formOrigen = formularioDeOrigen
        Me.Show()

        NombreMostrar.Text = proyectoModificar.nombreProyecto
        NombreClienteMostrar.Text = proyectoModificar.nombreCliente
        NombreResponsableMostrar.Text = proyectoModificar.nombreResponsable
        FechaInicioMostrar.Text = proyectoModificar.fechaInicio
        FechaEntregaMostrar.Text = proyectoModificar.fechaEntrega
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
        Dim idProyecto As Integer = proyectoModificar.IdProyecto
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