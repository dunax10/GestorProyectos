Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormModificarFechaEntrega
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
        FechaEntregaIngresada.Value = proyectoModificar.fechaEntrega
        EstadoMostrar.Text = proyectoModificar.estado
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ModificarBoton.Click
        Dim fechaInicio As DateTime
        DateTime.TryParse(FechaInicioMostrar.Text, fechaInicio)
        If (FechaEntregaIngresada.Text < fechaInicio) Then
            MsgBox("La fecha de inicio no puede ser mayor a la de entrega")
            FechaEntregaIngresada.Focus()
            Exit Sub
        End If

        Dim idProyecto As Integer = proyectoModificar.IdProyecto
        proyectoModificar.fechaEntrega = FechaEntregaIngresada.Text

        proyectoModificar.ModificarProyectoPorId(idProyecto)
        formOrigen.Show()
        Me.Hide()
    End Sub

    Private Sub volverBoton_Click(sender As Object, e As EventArgs)
        PaginaPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub FechaEntregaIngresada_ValueChanged(sender As Object, e As EventArgs) Handles FechaEntregaIngresada.ValueChanged

    End Sub
End Class