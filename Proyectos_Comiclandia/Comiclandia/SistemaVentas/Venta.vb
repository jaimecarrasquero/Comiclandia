Public Class Venta
    Dim dtcliente As New DataTable
    Dim dtproducto As New DataTable
    Dim dtventa As New DataTable
    Sub mostrar_cliente()
        Dim fc As New FCliente
        dtcliente = fc.mostrar_cliente()
        cbcliente.DataSource = dtcliente
        cbcliente.DisplayMember = "NOMBRES"
        cbcliente.ValueMember = "CODIGO"
    End Sub
    Sub mostrar_producto()
        Dim c As New FProducto
        dtproducto = c.mostrar_producto
        cbproducto.DataSource = dtproducto
        cbproducto.DisplayMember = "nombre"
        cbproducto.ValueMember = "cod_producto"
    End Sub

    Private Sub FormVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            mostrar_producto()
            mostrar_cliente()
            cbcliente.SelectedIndex = 0
            With dgvdetalles.ColumnHeadersDefaultCellStyle
                .BackColor = Color.Chartreuse
                .Font = New Font("Calibri", 8, FontStyle.Bold)
                .Alignment = DataGridViewContentAlignment.MiddleCenter
            End With

        Catch ex As Exception
            MessageBox.Show("Para Realizar Ventas Debe Tener Un Clientes Registrados y Productos")

        End Try

    End Sub

    Private Sub cbcliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcliente.SelectedIndexChanged
        Dim fila As Int32
        fila = cbcliente.SelectedIndex
        'txtnumdocu.Text = dtcliente.Rows(fila)("CODIGO")
        txtdnicli.Text = dtcliente.Rows(fila)("CEDULA")
    End Sub

    Private Sub btnegregar_Click(sender As Object, e As EventArgs) Handles btnegregar.Click
        If (cbproducto.Text <> String.Empty And txtcabtidad.Value > 0) Then
            Dim fila As Int32
            fila = cbproducto.SelectedIndex
            Dim ultima As Int32
            dgvdetalles.Rows.Add()
            ultima = dgvdetalles.Rows.Count - 1
            dgvdetalles.Item(0, ultima).Value = cbproducto.SelectedValue
            dgvdetalles.Item(1, ultima).Value = txtcabtidad.Value
            dgvdetalles.Item(2, ultima).Value = cbproducto.Text
            dgvdetalles.Item(3, ultima).Value = dtproducto.Rows(fila)("precio")
            dgvdetalles.Item(4, ultima).Value = dgvdetalles.Item(1, ultima).Value * dgvdetalles.Item(3, ultima).Value


            Dim razon As Int32
            razon = 0
            razon = Convert.ToInt32(dtproducto.Rows(fila)(3)) - Convert.ToInt32(dgvdetalles.Item(1, ultima).Value)
            If (razon < 0) Then
                MessageBox.Show("Usted solo cuenta con" + Convert.ToString(dtproducto.Rows(fila)("stock")) + "" + dgvdetalles.Item(2, ultima).Value)
                dgvdetalles.Rows.RemoveAt(ultima)
            Else

            End If

        Else
            MessageBox.Show("Seleccione un producto y/o cantidad")
        End If
        total()
    End Sub

    Private Sub dgvdetalles_DoubleClick(sender As Object, e As EventArgs) Handles dgvdetalles.DoubleClick
        Dim ex
        ex = MessageBox.Show("¿Seguro que desea eliminar el item seleccionado?", "Eliminar item", MessageBoxButtons.YesNo)
        If (ex = vbYes) Then
            dgvdetalles.Rows.Remove(dgvdetalles.CurrentRow)
            total()
        Else

        End If


    End Sub
    Sub total()
        Dim total As Decimal
        total = 0
        For i = 0 To dgvdetalles.Rows.Count - 1
            total = total + dgvdetalles.Item(4, i).Value
        Next
        txttotal.Text = total
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If (dgvdetalles.RowCount > 0 And cbcliente.Text <> String.Empty) Then
            Dim fv As New FVenta()
            If (fv.ingresa_venta(txtnumdocu.Text, txtfecha.Value, cbcliente.SelectedValue, txtdnicli.Text, txttotal.Text)) Then

                For i = 0 To dgvdetalles.Rows.Count - 1
                    If (fv.ingresa_detalle(txtnumdocu.Text, dgvdetalles.Item(0, i).Value, dgvdetalles.Item(1, i).Value, dgvdetalles.Item(4, i).Value) = False) Then
                        MessageBox.Show("Error al registrar el item dentro de la venta")
                    Else

                    End If
                Next
                MessageBox.Show("Venta registrada correctamente")
                btnguardar.Enabled = False
                txtcabtidad.Enabled = False
                cbcliente.Enabled = False
                cbproducto.Enabled = False
                cbcliente.SelectedIndex = 0
                txtnumdocu.Clear()
                txtcabtidad.Value = 0
                dgvdetalles.Rows.Clear()

                total()
            Else
                MessageBox.Show("Error al registrar la venta")
            End If
        Else
            MessageBox.Show("Ingrese items para poder realizar la venta")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fv As New FVenta
        dtventa = fv.ver_ventas()
        txtnumdocu.Text = "CPT-" & dtventa.Rows.Count + 1
        btnegregar.Enabled = True
        btnguardar.Enabled = True
        cbcliente.Enabled = True
        cbproducto.Enabled = True
        txtcabtidad.Enabled = True


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cliente.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListaVentas.Show()
    End Sub
End Class