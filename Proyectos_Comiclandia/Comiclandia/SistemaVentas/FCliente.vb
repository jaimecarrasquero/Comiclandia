Imports System.Data.SqlClient
Public Class FCliente
    Inherits Conexion

    Public Function ingresa_cliente(cod As String, nom As String, ape As String, dn As String, sex As String, dir As String, tel As String) As Boolean
        conectado()
        cmd = New SqlCommand("insertar_cliente", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_cliente", cod)
        cmd.Parameters.AddWithValue("@nombres", nom)
        cmd.Parameters.AddWithValue("@apellidos", ape)
        cmd.Parameters.AddWithValue("@dni", dn)
        cmd.Parameters.AddWithValue("@sexo", sex)
        cmd.Parameters.AddWithValue("@direccion", dir)
        cmd.Parameters.AddWithValue("@telefeono", tel)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function edita_cliente(cod As String, nom As String, ape As String, dn As String, sex As String, dir As String, tel As String) As Boolean
        conectado()
        cmd = New SqlCommand("editar_cliente", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_cliente", cod)
        cmd.Parameters.AddWithValue("@nombres", nom)
        cmd.Parameters.AddWithValue("@apellidos", ape)
        cmd.Parameters.AddWithValue("@dni", dn)
        cmd.Parameters.AddWithValue("@sexo", sex)
        cmd.Parameters.AddWithValue("@direccion", dir)
        cmd.Parameters.AddWithValue("@telefeono", tel)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function elimina_cliente(cod As String) As Boolean
        conectado()
        cmd = New SqlCommand("eliminar_cliente", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@cod_cliente", cod)

        If (cmd.ExecuteNonQuery) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function mostrar_cliente() As DataTable
        conectado()
        cmd = New SqlCommand("mostrar_cliente", ccn)
        cmd.CommandType = CommandType.StoredProcedure

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

    Public Function buscar_cliente(txtbus As String) As DataTable
        conectado()
        cmd = New SqlCommand("buscar_cliente", ccn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@texto", txtbus)
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

End Class
