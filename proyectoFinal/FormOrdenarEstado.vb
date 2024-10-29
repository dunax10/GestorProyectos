﻿Imports System.Windows.Forms.MonthCalendar

Public Class FormOrdenarEstado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ModificarBoton.Click
        Dim idSeleccionado As Integer = Datos.SelectedRows(0).Cells("ID").Value
        FormModificar.mostrarFormulario(idSeleccionado, Me)
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ModificarEstadoBoton.Click
        Dim idSeleccionado As Integer = Datos.SelectedRows(0).Cells("ID").Value
        FormCambiarEstado.mostrarFormulario(idSeleccionado, Me)
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles EliminarBoton.Click
        Dim idSeleccionado As Integer = Datos.SelectedRows(0).Cells("ID").Value
        proyecto.BorrarProyecto(idSeleccionado)
        Me.RefrescarForm()
    End Sub

    Private Sub ModificarFechaEntregaForm_Click(sender As Object, e As EventArgs) Handles ModificarFechaEntregaForm.Click
        Dim idSeleccionado As Integer = Datos.SelectedRows(0).Cells("ID").Value
        FormModificarFechaEntrega.mostrarFormulario(idSeleccionado, Me)
        Me.Hide()
    End Sub

    Private Sub RefrescarForm()
        If String.IsNullOrWhiteSpace(EstadoIngresado.Text) Then
            MsgBox("Debe seleccionar un estado")
            EstadoIngresado.Focus()
            Exit Sub
        End If

        Dim listaProyectos As List(Of proyecto)

        listaProyectos = proyecto.FiltrarPorEstado(EstadoIngresado.Text)

        Datos.Rows.Clear()

        ' Iterar sobre la lista de proyectos
        For Each proyecto In listaProyectos
            Datos.Rows.Add({proyecto.IdProyecto, proyecto.nombreProyecto, proyecto.nombreCliente, proyecto.nombreResponsable, proyecto.fechaInicio, proyecto.fechaEntrega, proyecto.estado})
        Next
    End Sub

    Private Sub EstadoIngresado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EstadoIngresado.SelectedIndexChanged
        Dim listaProyectos As List(Of proyecto)

        listaProyectos = proyecto.FiltrarPorEstado(EstadoIngresado.Text)

        Datos.Rows.Clear()

        ' Iterar sobre la lista de proyectos
        For Each proyecto In listaProyectos
            Datos.Rows.Add({proyecto.IdProyecto, proyecto.nombreProyecto, proyecto.nombreCliente, proyecto.nombreResponsable, proyecto.fechaInicio, proyecto.fechaEntrega, proyecto.estado})
        Next
    End Sub

    Private Sub volverBoton_Click(sender As Object, e As EventArgs) Handles volverBoton.Click
        PaginaPrincipal.Show()
        Me.Hide()
    End Sub
End Class