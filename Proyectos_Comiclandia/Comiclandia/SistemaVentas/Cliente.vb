Public Class Cliente
    Dim dtcliente As New DataTable
    Private Sub Formcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
        btnguardar.Enabled = False
        btncancelar.Enabled = False
        btneliminar.Enabled = False
        btnmodificar.Enabled = False
        mostrar_clientes()
    End Sub
    Sub buscar_cliente()
        Dim fc As New FCliente
        dtcliente = fc.buscar_cliente(txtbuscar.Text)
        dgvcliente.DataSource = dtcliente
    End Sub
    Sub mostrar_clientes()
        Dim fc As New FCliente
        dtcliente = fc.mostrar_cliente()
        dgvcliente.DataSource = dtcliente
    End Sub
    Sub nuevo()
        btncancelar.Enabled = True
        btnguardar.Enabled = True
        limpiar()
        bloqueacajas(True)
    End Sub
    Sub limpiar()
        txtcodigo.Clear()
        txtnombre.Clear()
        txtapellidos.Clear()
        txtdireccion.Clear()
        txttelefono.Clear()
        txtdni.Clear()
        cbsexo.SelectedIndex = 0
    End Sub
    Sub cancelar()
        btnnuevo.Enabled = True
        btnguardar.Enabled = False
        btneliminar.Enabled = False
        btncancelar.Enabled = False
        btnmodificar.Enabled = False
        limpiar()
        bloqueacajas(False)
    End Sub

    Sub bloqueacajas(va As Boolean)
        txtnombre.Enabled = va
        txtapellidos.Enabled = va
        txtdireccion.Enabled = va
        txtdni.Enabled = va
        txttelefono.Enabled = va
        cbsexo.Enabled = va

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        btnguardar.Enabled = True
        btneliminar.Enabled = False
        bloqueacajas(True)
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        nuevo()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        cancelar()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        Dim fc As New FCliente
        If (txtnombre.Text <> String.Empty And txtapellidos.Text <> String.Empty And cbsexo.SelectedIndex <> 0) Then

            If (txtcodigo.Text <> String.Empty) Then
                If (fc.edita_cliente(txtcodigo.Text, txtnombre.Text, txtapellidos.Text, txtdni.Text, cbsexo.Text, txtdireccion.Text, txttelefono.Text) = True) Then
                    MessageBox.Show("Cliente editado Correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cancelar()
                    mostrar_clientes()
                Else
                    MessageBox.Show("Error al Modificar el cliente")
                End If
            Else


                If (fc.ingresa_cliente(txtcodigo.Text, txtnombre.Text, txtapellidos.Text, txtdni.Text, cbsexo.Text, txtdireccion.Text, txttelefono.Text) = True) Then
                    MessageBox.Show("Cliente registrado Correctamente", "Modificacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cancelar()
                    mostrar_clientes()
                Else
                    MessageBox.Show("Error al registrar el cliente")
                End If
            End If

        Else
            MessageBox.Show("Complete todos los datos")
        End If
    End Sub

    Private Sub dgvcliente_DoubleClick(sender As Object, e As EventArgs) Handles dgvcliente.DoubleClick
        txtcodigo.Text = dgvcliente.CurrentRow.Cells("CODIGO").Value
        txtnombre.Text = dgvcliente.CurrentRow.Cells("NOMBRES").Value
        txtapellidos.Text = dgvcliente.CurrentRow.Cells("APELLIDOS").Value
        txtdni.Text = dgvcliente.CurrentRow.Cells("CEDULA").Value
        cbsexo.Text = dgvcliente.CurrentRow.Cells("SEXO").Value
        txtdireccion.Text = dgvcliente.CurrentRow.Cells("DIRECCION").Value
        txttelefono.Text = dgvcliente.CurrentRow.Cells("TELEFONO").Value



        btnguardar.Enabled = False
        btnmodificar.Enabled = True
        btneliminar.Enabled = True
        btncancelar.Enabled = True
        btnnuevo.Enabled = True
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim c As New FCliente
        If (c.elimina_cliente(txtcodigo.Text) = True) Then
            MessageBox.Show("Cliente Eliminadaa Correctamente", "Elimacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cancelar()
            mostrar_clientes()
        Else
            MessageBox.Show("Error al eliminar el cliente")
        End If
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar_cliente()
    End Sub
End Class