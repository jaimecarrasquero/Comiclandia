<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Venta))
        Me.dgvdetalles = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Producto = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcabtidad = New System.Windows.Forms.NumericUpDown()
        Me.btnegregar = New System.Windows.Forms.Button()
        Me.cbproducto = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnumdocu = New System.Windows.Forms.TextBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtdnicli = New System.Windows.Forms.TextBox()
        Me.cbcliente = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgvdetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Producto.SuspendLayout()
        CType(Me.txtcabtidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvdetalles
        '
        Me.dgvdetalles.AllowUserToAddRows = False
        Me.dgvdetalles.AllowUserToDeleteRows = False
        Me.dgvdetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvdetalles.EnableHeadersVisualStyles = False
        Me.dgvdetalles.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvdetalles.Location = New System.Drawing.Point(20, 323)
        Me.dgvdetalles.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.dgvdetalles.Name = "dgvdetalles"
        Me.dgvdetalles.ReadOnly = True
        Me.dgvdetalles.RowHeadersWidth = 62
        Me.dgvdetalles.Size = New System.Drawing.Size(928, 236)
        Me.dgvdetalles.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cantidad"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Descripción"
        Me.Column3.MinimumWidth = 8
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "Precio"
        Me.Column4.MinimumWidth = 8
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "SubTotal"
        Me.Column5.MinimumWidth = 8
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(692, 571)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total"
        '
        'Producto
        '
        Me.Producto.Controls.Add(Me.Label3)
        Me.Producto.Controls.Add(Me.Label2)
        Me.Producto.Controls.Add(Me.txtcabtidad)
        Me.Producto.Controls.Add(Me.btnegregar)
        Me.Producto.Controls.Add(Me.cbproducto)
        Me.Producto.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Producto.Location = New System.Drawing.Point(238, 167)
        Me.Producto.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Producto.Name = "Producto"
        Me.Producto.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Producto.Size = New System.Drawing.Size(711, 145)
        Me.Producto.TabIndex = 2
        Me.Producto.TabStop = False
        Me.Producto.Text = "Seleccionar Productos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 29)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Producto"
        '
        'txtcabtidad
        '
        Me.txtcabtidad.Enabled = False
        Me.txtcabtidad.Location = New System.Drawing.Point(218, 92)
        Me.txtcabtidad.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtcabtidad.Name = "txtcabtidad"
        Me.txtcabtidad.Size = New System.Drawing.Size(238, 37)
        Me.txtcabtidad.TabIndex = 2
        '
        'btnegregar
        '
        Me.btnegregar.BackgroundImage = CType(resources.GetObject("btnegregar.BackgroundImage"), System.Drawing.Image)
        Me.btnegregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnegregar.Enabled = False
        Me.btnegregar.Location = New System.Drawing.Point(562, 24)
        Me.btnegregar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnegregar.Name = "btnegregar"
        Me.btnegregar.Size = New System.Drawing.Size(130, 109)
        Me.btnegregar.TabIndex = 1
        Me.btnegregar.UseVisualStyleBackColor = True
        '
        'cbproducto
        '
        Me.cbproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbproducto.Enabled = False
        Me.cbproducto.FormattingEnabled = True
        Me.cbproducto.Location = New System.Drawing.Point(218, 38)
        Me.cbproducto.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cbproducto.Name = "cbproducto"
        Me.cbproducto.Size = New System.Drawing.Size(235, 37)
        Me.cbproducto.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtnumdocu)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtdnicli)
        Me.GroupBox1.Controls.Add(Me.cbcliente)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(20, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(928, 134)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(677, 71)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(233, 51)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Crear Clientes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 37)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 29)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Numero"
        '
        'txtnumdocu
        '
        Me.txtnumdocu.Enabled = False
        Me.txtnumdocu.Location = New System.Drawing.Point(138, 35)
        Me.txtnumdocu.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtnumdocu.Name = "txtnumdocu"
        Me.txtnumdocu.Size = New System.Drawing.Size(164, 37)
        Me.txtnumdocu.TabIndex = 6
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(138, 80)
        Me.txtfecha.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(164, 37)
        Me.txtfecha.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 80)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 29)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Fecha"
        '
        'txtdnicli
        '
        Me.txtdnicli.Enabled = False
        Me.txtdnicli.Location = New System.Drawing.Point(501, 80)
        Me.txtdnicli.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtdnicli.Name = "txtdnicli"
        Me.txtdnicli.Size = New System.Drawing.Size(163, 37)
        Me.txtdnicli.TabIndex = 3
        '
        'cbcliente
        '
        Me.cbcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcliente.Enabled = False
        Me.cbcliente.FormattingEnabled = True
        Me.cbcliente.Location = New System.Drawing.Point(501, 28)
        Me.cbcliente.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.cbcliente.Name = "cbcliente"
        Me.cbcliente.Size = New System.Drawing.Size(409, 37)
        Me.cbcliente.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(332, 85)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 29)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Cedula Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(332, 35)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre Cliente"
        '
        'btnguardar
        '
        Me.btnguardar.Enabled = False
        Me.btnguardar.Location = New System.Drawing.Point(21, 244)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(208, 56)
        Me.btnguardar.TabIndex = 8
        Me.btnguardar.Text = "Guardar Venta"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(762, 571)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(186, 37)
        Me.txttotal.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 181)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(208, 51)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(20, 562)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(208, 56)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Ventas Realizadas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(968, 622)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Producto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvdetalles)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas Comiclandia"
        CType(Me.dgvdetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Producto.ResumeLayout(False)
        Me.Producto.PerformLayout()
        CType(Me.txtcabtidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvdetalles As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Producto As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcabtidad As NumericUpDown
    Friend WithEvents btnegregar As Button
    Friend WithEvents cbproducto As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtfecha As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtdnicli As TextBox
    Friend WithEvents cbcliente As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtnumdocu As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
