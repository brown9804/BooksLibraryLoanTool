<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class devoluciones
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionDeLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionDeEstudiantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrestamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtcodlidevol = New System.Windows.Forms.TextBox()
        Me.txtnomalumdev = New System.Windows.Forms.TextBox()
        Me.txtmontocobrswv = New System.Windows.Forms.TextBox()
        Me.txtapealumdev = New System.Windows.Forms.TextBox()
        Me.txtcodigodev = New System.Windows.Forms.TextBox()
        Me.txtcedalumdev = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.txtfecdev = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbtipodedev = New System.Windows.Forms.ComboBox()
        Me.txtmontoconpagadev = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcambiodev = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbtipodecobdev = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(669, 24)
        Me.MenuStrip1.TabIndex = 52
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformacionDeLibrosToolStripMenuItem, Me.InformacionDeEstudiantesToolStripMenuItem, Me.PrestamosToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'InformacionDeLibrosToolStripMenuItem
        '
        Me.InformacionDeLibrosToolStripMenuItem.Name = "InformacionDeLibrosToolStripMenuItem"
        Me.InformacionDeLibrosToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.InformacionDeLibrosToolStripMenuItem.Text = "Informacion de libros"
        '
        'InformacionDeEstudiantesToolStripMenuItem
        '
        Me.InformacionDeEstudiantesToolStripMenuItem.Name = "InformacionDeEstudiantesToolStripMenuItem"
        Me.InformacionDeEstudiantesToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.InformacionDeEstudiantesToolStripMenuItem.Text = "Informacion de estudiantes"
        '
        'PrestamosToolStripMenuItem
        '
        Me.PrestamosToolStripMenuItem.Name = "PrestamosToolStripMenuItem"
        Me.PrestamosToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.PrestamosToolStripMenuItem.Text = "Prestamos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'txtcodlidevol
        '
        Me.txtcodlidevol.Location = New System.Drawing.Point(193, 66)
        Me.txtcodlidevol.Name = "txtcodlidevol"
        Me.txtcodlidevol.Size = New System.Drawing.Size(100, 20)
        Me.txtcodlidevol.TabIndex = 74
        '
        'txtnomalumdev
        '
        Me.txtnomalumdev.Location = New System.Drawing.Point(193, 132)
        Me.txtnomalumdev.Name = "txtnomalumdev"
        Me.txtnomalumdev.Size = New System.Drawing.Size(100, 20)
        Me.txtnomalumdev.TabIndex = 68
        '
        'txtmontocobrswv
        '
        Me.txtmontocobrswv.Location = New System.Drawing.Point(193, 239)
        Me.txtmontocobrswv.Name = "txtmontocobrswv"
        Me.txtmontocobrswv.Size = New System.Drawing.Size(199, 20)
        Me.txtmontocobrswv.TabIndex = 67
        '
        'txtapealumdev
        '
        Me.txtapealumdev.Location = New System.Drawing.Point(311, 132)
        Me.txtapealumdev.Name = "txtapealumdev"
        Me.txtapealumdev.Size = New System.Drawing.Size(281, 20)
        Me.txtapealumdev.TabIndex = 65
        '
        'txtcodigodev
        '
        Me.txtcodigodev.Location = New System.Drawing.Point(193, 40)
        Me.txtcodigodev.Name = "txtcodigodev"
        Me.txtcodigodev.Size = New System.Drawing.Size(399, 20)
        Me.txtcodigodev.TabIndex = 64
        '
        'txtcedalumdev
        '
        Me.txtcedalumdev.Location = New System.Drawing.Point(193, 97)
        Me.txtcedalumdev.Name = "txtcedalumdev"
        Me.txtcedalumdev.Size = New System.Drawing.Size(399, 20)
        Me.txtcedalumdev.TabIndex = 63
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Monto del cobro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Tipo de devolucion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Nombre y Apellido Alumno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Cedula del Alumno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Codigo Libro"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Codigo"
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(467, 243)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(91, 92)
        Me.btncalcular.TabIndex = 77
        Me.btncalcular.Text = "Calcular"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'txtfecdev
        '
        Me.txtfecdev.Location = New System.Drawing.Point(423, 70)
        Me.txtfecdev.Name = "txtfecdev"
        Me.txtfecdev.Size = New System.Drawing.Size(100, 20)
        Me.txtfecdev.TabIndex = 79
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(320, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Fecha"
        '
        'cbtipodedev
        '
        Me.cbtipodedev.FormattingEnabled = True
        Me.cbtipodedev.Items.AddRange(New Object() {"Normal", "Cobro"})
        Me.cbtipodedev.Location = New System.Drawing.Point(193, 159)
        Me.cbtipodedev.Name = "cbtipodedev"
        Me.cbtipodedev.Size = New System.Drawing.Size(100, 21)
        Me.cbtipodedev.TabIndex = 80
        '
        'txtmontoconpagadev
        '
        Me.txtmontoconpagadev.Location = New System.Drawing.Point(193, 278)
        Me.txtmontoconpagadev.Name = "txtmontoconpagadev"
        Me.txtmontoconpagadev.Size = New System.Drawing.Size(199, 20)
        Me.txtmontoconpagadev.TabIndex = 82
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "Monto con que paga"
        '
        'txtcambiodev
        '
        Me.txtcambiodev.Location = New System.Drawing.Point(193, 315)
        Me.txtcambiodev.Name = "txtcambiodev"
        Me.txtcambiodev.Size = New System.Drawing.Size(199, 20)
        Me.txtcambiodev.TabIndex = 84
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 315)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Cambio"
        '
        'cbtipodecobdev
        '
        Me.cbtipodecobdev.Enabled = False
        Me.cbtipodecobdev.FormattingEnabled = True
        Me.cbtipodecobdev.Items.AddRange(New Object() {"Atraso", "Reposicion"})
        Me.cbtipodecobdev.Location = New System.Drawing.Point(193, 194)
        Me.cbtipodecobdev.Name = "cbtipodecobdev"
        Me.cbtipodecobdev.Size = New System.Drawing.Size(100, 21)
        Me.cbtipodecobdev.TabIndex = 86
        Me.cbtipodecobdev.Text = "Ninguno"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 197)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "Tipo de cobro"
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(363, 360)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 90
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(254, 360)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 89
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(132, 360)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar.TabIndex = 88
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(15, 360)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 87
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'devoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 410)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.cbtipodecobdev)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtcambiodev)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtmontoconpagadev)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbtipodedev)
        Me.Controls.Add(Me.txtfecdev)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtcodlidevol)
        Me.Controls.Add(Me.txtnomalumdev)
        Me.Controls.Add(Me.txtmontocobrswv)
        Me.Controls.Add(Me.txtapealumdev)
        Me.Controls.Add(Me.txtcodigodev)
        Me.Controls.Add(Me.txtcedalumdev)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "devoluciones"
        Me.Text = "Devoluciones"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtcodlidevol As System.Windows.Forms.TextBox
    Friend WithEvents txtnomalumdev As System.Windows.Forms.TextBox
    Friend WithEvents txtmontocobrswv As System.Windows.Forms.TextBox
    Friend WithEvents txtapealumdev As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigodev As System.Windows.Forms.TextBox
    Friend WithEvents txtcedalumdev As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncalcular As System.Windows.Forms.Button
    Friend WithEvents txtfecdev As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbtipodedev As System.Windows.Forms.ComboBox
    Friend WithEvents txtmontoconpagadev As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtcambiodev As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents InformacionDeLibrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformacionDeEstudiantesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrestamosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbtipodecobdev As ComboBox
End Class
