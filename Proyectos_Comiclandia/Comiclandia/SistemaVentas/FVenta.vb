Imports System.Data.SqlClient
Public Class FVenta
    Inherits Conexion

    Public Function ingresa_venta(cod As String, feec As String, codcli As String, dni As String, tot As Decimal) As Boolean
        conectado()
        cmd = New SqlCommand("insertar_venta", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@num_documento", cod)
        'cmd.Parameters.AddWithValue("@fecha", feec)
        cmd.Parameters.AddWithValue("@cod_cliente", codcli)
        cmd.Parameters.AddWithValue("@dni_cliente", dni)
        cmd.Parameters.AddWithValue("@total", tot)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function ingresa_detalle(numdoc As String, codpro As String, cant As Int32, pre As Decimal) As Boolean
        conectado()
        cmd = New SqlCommand("ingresa_detalle", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@num_documento", numdoc)
        cmd.Parameters.AddWithValue("@cod_producto", codpro)
        cmd.Parameters.AddWithValue("@cantidad", cant)
        cmd.Parameters.AddWithValue("@precio", pre)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ver_ventas() As DataTable
        conectado()
        cmd = New SqlCommand("mostrar_ventas", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt

    End Function
    Public Function buscar_venta(txtbus As String) As DataTable
        conectado()
        cmd = New SqlCommand("buscar_venta", ccn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", txtbus)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

    Public Function total_ventas() As DataTable
        conectado()
        cmd = New SqlCommand("vertotal", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt

    End Function

End Class
