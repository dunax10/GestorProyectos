Public Class PaginaPrincipal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormIngresar.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormBuscarNombre.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormMostrarTodos.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormOrdenarFecha.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FormOrdenarEstado.Show()
        Me.Hide()
    End Sub

    Private Sub salirBoton_Click(sender As Object, e As EventArgs) Handles salirBoton.Click
        End
    End Sub
End Class