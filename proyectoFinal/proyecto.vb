Imports System.Data.OleDb
Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class proyecto
    Private id As Integer
    Public nombreProyecto As String
    Public nombreCliente As String
    Public fechaInicio As Date
    Public fechaEntrega As Date
    Public estado As String
    Public nombreResponsable As String

    Public ReadOnly Property IdProyecto As Integer
        Get
            Return id
        End Get
    End Property

    Public Sub New()
    End Sub

    Public Sub New(fila As DataRow)
        id = If(IsDBNull(fila("Id")), 0, fila("Id")) 'Es un if que pregunta por si es nulo, si lo es devuelve 0, sino devuelve la fila
        nombreProyecto = If(IsDBNull(fila("nombreProyecto")), 0, fila("nombreProyecto"))
        nombreCliente = If(IsDBNull(fila("nombreCliente")), 0, fila("nombreCliente"))
        fechaInicio = If(IsDBNull(fila("fechaInicio")), 0, fila("fechaInicio"))
        fechaEntrega = If(IsDBNull(fila("fechaEntrega")), 0, fila("fechaEntrega"))
        estado = If(IsDBNull(fila("estado")), 0, fila("estado"))
        nombreResponsable = If(IsDBNull(fila("nombreResponsable")), 0, fila("nombreResponsable"))
    End Sub

    Public Shared Function TraerProyectoPorId(idProyecto As Integer)
        Dim sentencia As String
        Dim parametros As New List(Of OleDbParameter)
        Dim tabla As DataTable

        parametros.Add(New OleDbParameter(“@id”, idProyecto))
        sentencia = "Select * from proyectos where Id = @id"
        tabla = GestorConexion.Instancia.SentenciasSelect(sentencia, parametros)

        If tabla IsNot Nothing Then
            Dim objetoProyecto As New proyecto(tabla.Rows(0))
            Return objetoProyecto
        End If
        Return "Se produjo un error"
    End Function
    Public Shared Function TraerProyectoPorNombre(nombre As String) As List(Of proyecto)
        Dim listaProyectos As New List(Of proyecto)
        Dim sentencia As String
        Dim parametros As New List(Of OleDbParameter)
        Dim tabla As DataTable

        parametros.Add(New OleDbParameter(“@nombre”, nombre))
        sentencia = "Select * from proyectos where nombreProyecto = @nombre"
        tabla = GestorConexion.Instancia.SentenciasSelect(sentencia, parametros)

        If tabla IsNot Nothing Then
            For Each fila As DataRow In tabla.Rows
                If fila IsNot Nothing Then
                    Dim objetoProyecto As New proyecto(fila)

                    listaProyectos.Add(objetoProyecto)
                End If
            Next
        End If

        Return listaProyectos
    End Function

    Public Shared Function TraerTodos() As List(Of proyecto)
        Dim listaProyectos As New List(Of proyecto)
        Dim sentencia As String
        Dim tabla As DataTable

        sentencia = "Select * from proyectos"
        tabla = GestorConexion.Instancia.SentenciasSelect(sentencia, Nothing)

        If tabla IsNot Nothing Then
            For Each fila As DataRow In tabla.Rows
                If fila IsNot Nothing Then
                    Dim objetoProyecto As New proyecto(fila)

                    listaProyectos.Add(objetoProyecto)
                End If
            Next
        End If

        Return listaProyectos
    End Function

    Public Shared Function TraerTodosPorFecha() As List(Of proyecto)
        Dim listaProyectos As New List(Of proyecto)
        Dim sentencia As String
        Dim tabla As DataTable

        sentencia = "Select * from proyectos order by fechaEntrega ASC"
        tabla = GestorConexion.Instancia.SentenciasSelect(sentencia, Nothing)

        If tabla IsNot Nothing Then
            For Each fila As DataRow In tabla.Rows
                If fila IsNot Nothing Then
                    Dim objetoProyecto As New proyecto(fila)

                    listaProyectos.Add(objetoProyecto)
                End If
            Next
        End If

        Return listaProyectos
    End Function

    Public Shared Function FiltrarPorEstado(estado As String) As List(Of proyecto)
        Dim listaProyectos As New List(Of proyecto)
        Dim sentencia As String
        Dim tabla As DataTable
        Dim parametro As New List(Of OleDbParameter)
        parametro.Add(New OleDbParameter(“@estado”, estado))

        sentencia = "Select * from proyectos where estado = @estado order by fechaEntrega ASC"
        tabla = GestorConexion.Instancia.SentenciasSelect(sentencia, parametro)

        If tabla IsNot Nothing Then
            For Each fila As DataRow In tabla.Rows
                If fila IsNot Nothing Then
                    Dim objetoProyecto As New proyecto(fila)

                    listaProyectos.Add(objetoProyecto)
                End If
            Next
        End If

        Return listaProyectos
    End Function

    Public Sub InsertarProyecto()
        Dim parametros As New List(Of OleDbParameter)

        parametros.Add(New OleDbParameter(“@nombreProyecto”, nombreProyecto))
        parametros.Add(New OleDbParameter(“@nombreCliente”, nombreCliente))
        parametros.Add(New OleDbParameter(“@fechaInicio”, fechaInicio))
        parametros.Add(New OleDbParameter(“@fechaEntrega”, fechaEntrega))
        parametros.Add(New OleDbParameter(“@estado”, estado))
        parametros.Add(New OleDbParameter(“@nombreResponsable”, nombreResponsable))


        Dim sentencia As String = "INSERT INTO proyectos (nombreProyecto, nombreCliente, fechaInicio, fechaEntrega, estado, nombreResponsable) VALUES (@nombreProyecto, @nombreCliente, @fechaInicio, @fechaEntrega, @estado, @nombreResponsable)"
        GestorConexion.Instancia.SentenciasInsert(sentencia, parametros)
    End Sub

    Public Sub ModificarProyectoPorId(id As Integer)
        Dim parametros As New List(Of OleDbParameter)

        parametros.Add(New OleDbParameter(“@nombreProyecto”, nombreProyecto))
        parametros.Add(New OleDbParameter(“@nombreCliente”, nombreCliente))
        parametros.Add(New OleDbParameter(“@fechaInicio”, fechaInicio))
        parametros.Add(New OleDbParameter(“@fechaEntrega”, fechaEntrega))
        parametros.Add(New OleDbParameter(“@estado”, estado))
        parametros.Add(New OleDbParameter(“@nombreResponsable”, nombreResponsable))
        parametros.Add(New OleDbParameter(“@id”, id))


        Dim sentencia As String = "UPDATE proyectos SET nombreProyecto = @nombreProyecto, nombreCliente = @nombreCliente, fechaInicio = @fechaInicio, fechaEntrega = @fechaEntrega, estado = @estado, nombreResponsable = @nombreResponsable WHERE ID = @id"
        GestorConexion.Instancia.SentenciasInsert(sentencia, parametros)
    End Sub

    Public Shared Sub BorrarProyecto(id As Integer)
        Dim parametro As New List(Of OleDbParameter)
        parametro.Add(New OleDbParameter(“@idProyecto”, id))

        Dim sentencia As String = "DELETE FROM proyectos WHERE Id = @idProyecto"
        GestorConexion.Instancia.SentenciasInsert(sentencia, parametro)
    End Sub
End Class
