Imports System.Data.OleDb

Public Class FormIngresar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles InsertarBoton.Click
        'Validaciones
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


        Dim insertarProyecto As proyecto

        insertarProyecto = New proyecto
        insertarProyecto.nombreProyecto = NombreIngresado.Text
        insertarProyecto.nombreCliente = NombreClienteIngresado.Text
        insertarProyecto.nombreResponsable = NombreResponsableIngresado.Text
        insertarProyecto.fechaEntrega = FechaEntregaIngresada.Text
        insertarProyecto.fechaInicio = FechaInicioIngresada.Text
        insertarProyecto.estado = EstadoIngresado.Text
        insertarProyecto.InsertarProyecto()
        MsgBox("Proyecto insertado con éxito")
    End Sub

    Private Sub FormIngresar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstadoIngresado.SelectedIndex = 1
    End Sub

    Private Sub volverBoton_Click(sender As Object, e As EventArgs) Handles volverBoton.Click
        PaginaPrincipal.Show()
        Me.Hide()
    End Sub
End Class