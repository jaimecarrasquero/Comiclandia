Public Class ListaVentas
    Dim dtventas As New DataTable
    Private Sub FormlistaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ver_ventas()
    End Sub

    Sub ver_ventas()
        Dim fv As New FVenta
        dtventas = fv.ver_ventas()
        Dgventas.DataSource = dtventas
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbsucar.TextChanged
        buscar_ventas()
    End Sub
    Sub buscar_ventas()
        Dim fv As New FVenta
        dtventas = fv.buscar_venta(txtbsucar.Text)
        Dgventas.DataSource = dtventas
    End Sub
End Class