<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvcliente = New System.Windows.Forms.DataGridView()
        Me.txtapellidos = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbsexo = New System.Windows.Forms.ComboBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(200, 162)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(189, 27)
        Me.txtnombre.TabIndex = 46
        '
        'txtcodigo
        '
        Me.txtcodigo.Enabled = False
        Me.txtcodigo.Location = New System.Drawing.Point(201, 123)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(189, 27)
        Me.txtcodigo.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 168)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 24)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Nombres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 128)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 24)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Codigo"
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(66, 395)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(100, 48)
        Me.btnguardar.TabIndex = 38
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(244, 395)
        Me.btncancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(100, 48)
        Me.btncancelar.TabIndex = 39
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(36, 51)
        Me.btnnuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(100, 48)
        Me.btnnuevo.TabIndex = 35
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(144, 50)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(100, 48)
        Me.btnmodificar.TabIndex = 36
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(256, 51)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(100, 48)
        Me.btneliminar.TabIndex = 37
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbuscar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dgvcliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(443, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(642, 378)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Clientes"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(118, 49)
        Me.txtbuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(257, 32)
        Me.txtbuscar.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 54)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 24)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Buscar :"
        '
        'dgvcliente
        '
        Me.dgvcliente.AllowUserToAddRows = False
        Me.dgvcliente.AllowUserToDeleteRows = False
        Me.dgvcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcliente.Location = New System.Drawing.Point(8, 111)
        Me.dgvcliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvcliente.Name = "dgvcliente"
        Me.dgvcliente.ReadOnly = True
        Me.dgvcliente.RowHeadersWidth = 62
        Me.dgvcliente.Size = New System.Drawing.Size(614, 246)
        Me.dgvcliente.TabIndex = 0
        '
        'txtapellidos
        '
        Me.txtapellidos.Enabled = False
        Me.txtapellidos.Location = New System.Drawing.Point(199, 199)
        Me.txtapellidos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtapellidos.Name = "txtapellidos"
        Me.txtapellidos.Size = New System.Drawing.Size(189, 27)
        Me.txtapellidos.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(29, 204)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 24)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 239)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 24)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Cedula"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 280)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 24)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Sexo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 317)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 24)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Direccion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 350)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 24)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Telefono"
        '
        'cbsexo
        '
        Me.cbsexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbsexo.Enabled = False
        Me.cbsexo.FormattingEnabled = True
        Me.cbsexo.Items.AddRange(New Object() {"Seleccione", "Masculino", "Femenino"})
        Me.cbsexo.Location = New System.Drawing.Point(198, 273)
        Me.cbsexo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbsexo.Name = "cbsexo"
        Me.cbsexo.Size = New System.Drawing.Size(192, 27)
        Me.cbsexo.TabIndex = 58
        '
        'txtdni
        '
        Me.txtdni.Enabled = False
        Me.txtdni.Location = New System.Drawing.Point(201, 236)
        Me.txtdni.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(189, 27)
        Me.txtdni.TabIndex = 59
        '
        'txtdireccion
        '
        Me.txtdireccion.Enabled = False
        Me.txtdireccion.Location = New System.Drawing.Point(198, 310)
        Me.txtdireccion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(189, 27)
        Me.txtdireccion.TabIndex = 60
        '
        'txttelefono
        '
        Me.txttelefono.Enabled = False
        Me.txttelefono.Location = New System.Drawing.Point(200, 347)
        Me.txttelefono.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(192, 27)
        Me.txttelefono.TabIndex = 61
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1097, 458)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.cbsexo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtapellidos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvcliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvcliente As DataGridView
    Friend WithEvents txtapellidos As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbsexo As ComboBox
    Friend WithEvents txtdni As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txttelefono As TextBox
End Class
