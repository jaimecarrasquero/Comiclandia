<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaVentas
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
        Me.Dgventas = New System.Windows.Forms.DataGridView()
        Me.txtbsucar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Dgventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dgventas
        '
        Me.Dgventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgventas.Location = New System.Drawing.Point(19, 62)
        Me.Dgventas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dgventas.Name = "Dgventas"
        Me.Dgventas.RowHeadersWidth = 62
        Me.Dgventas.Size = New System.Drawing.Size(840, 324)
        Me.Dgventas.TabIndex = 0
        '
        'txtbsucar
        '
        Me.txtbsucar.Location = New System.Drawing.Point(121, 25)
        Me.txtbsucar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbsucar.Name = "txtbsucar"
        Me.txtbsucar.Size = New System.Drawing.Size(408, 27)
        Me.txtbsucar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar :"
        '
        'ListaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(872, 415)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbsucar)
        Me.Controls.Add(Me.Dgventas)
        Me.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ListaVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas Realizadas"
        CType(Me.Dgventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Dgventas As DataGridView
    Friend WithEvents txtbsucar As TextBox
    Friend WithEvents Label1 As Label
End Class
