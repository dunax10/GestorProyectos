Imports System.Data.OleDb
Public Class GestorConexion
    Private Sub New()
    End Sub
    Private Shared _instancia As GestorConexion
    Public Shared ReadOnly Property Instancia As GestorConexion
        Get
            If _instancia Is Nothing Then
                _instancia = New GestorConexion()
            End If
            Return _instancia
        End Get
    End Property

    Private conexion As New OleDbConnection("PROVIDER=MICROSOFT.ACE.OLEDB.12.0; data source=Database2.mdb")
    Private comando As OleDbCommand
    Private adaptador As OleDbDataAdapter
    Private tabla As New DataTable()
    Public Function SentenciasSelect(sentencia As String, parametros As List(Of OleDbParameter)) As DataTable

        tabla.Clear()
        Try
            conexion.Open()
            comando = New OleDbCommand(sentencia, conexion)
            If Not parametros Is Nothing Then
                For Each parametro As OleDbParameter In parametros
                    comando.Parameters.Add(parametro)
                Next
            End If


            adaptador = New OleDbDataAdapter(comando)
            adaptador.Fill(tabla)
        Catch excepcion As Exception
            MsgBox(excepcion.Message)
        End Try
        conexion.Close()
        Return tabla.Copy
    End Function

    Public Sub SentenciasInsert(sentencia As String, parametros As List(Of OleDbParameter))
        Try
            conexion.Open()
            comando = New OleDbCommand(sentencia, conexion)
            If Not parametros Is Nothing Then
                For Each parametro As OleDbParameter In parametros
                    comando.Parameters.Add(parametro)
                Next
            End If
            comando.ExecuteNonQuery()
        Catch excepcion As Exception
            MsgBox(excepcion.Message)
        End Try
        conexion.Close()
    End Sub
End Class
