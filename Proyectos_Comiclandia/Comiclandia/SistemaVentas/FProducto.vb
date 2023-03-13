Imports System.Data.SqlClient
Public Class FProducto
    Inherits Conexion

    Public Function mostrar_producto() As DataTable
        conectado()
        cmd = New SqlCommand("mostrar_producto", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

    Public Function buscar_producto(txtbus As String) As DataTable
        conectado()
        cmd = New SqlCommand("buscar_producto", ccn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", txtbus)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function


End Class
