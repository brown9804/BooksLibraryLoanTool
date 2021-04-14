<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class prestamos
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
        Me.txtcodprestli = New System.Windows.Forms.TextBox()
        Me.txtobserpresta = New System.Windows.Forms.TextBox()
        Me.txtfechpre4sta = New System.Windows.Forms.TextBox()
        Me.txtnomlibprestamos = New System.Windows.Forms.TextBox()
        Me.txtcodpres = New System.Windows.Forms.TextBox()
        Me.txtapeprest = New System.Windows.Forms.TextBox()
        Me.txtcedpres = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionDeEstudiantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformacionDeLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolucionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtnomprest = New System.Windows.Forms.TextBox()
        Me.txtentregaprestamo = New System.Windows.Forms.TextBox()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtcodprestli
        '
        Me.txtcodprestli.Location = New System.Drawing.Point(193, 128)
        Me.txtcodprestli.Name = "txtcodprestli"
        Me.txtcodprestli.Size = New System.Drawing.Size(100, 20)
        Me.txtcodprestli.TabIndex = 45
        '
        'txtobserpresta
        '
        Me.txtobserpresta.Location = New System.Drawing.Point(193, 194)
        Me.txtobserpresta.Name = "txtobserpresta"
        Me.txtobserpresta.Size = New System.Drawing.Size(281, 20)
        Me.txtobserpresta.TabIndex = 42
        '
        'txtfechpre4sta
        '
        Me.txtfechpre4sta.Location = New System.Drawing.Point(193, 160)
        Me.txtfechpre4sta.Name = "txtfechpre4sta"
        Me.txtfechpre4sta.Size = New System.Drawing.Size(100, 20)
        Me.txtfechpre4sta.TabIndex = 41
        '
        'txtnomlibprestamos
        '
        Me.txtnomlibprestamos.Location = New System.Drawing.Point(311, 128)
        Me.txtnomlibprestamos.Name = "txtnomlibprestamos"
        Me.txtnomlibprestamos.Size = New System.Drawing.Size(281, 20)
        Me.txtnomlibprestamos.TabIndex = 40
        '
        'txtcodpres
        '
        Me.txtcodpres.Location = New System.Drawing.Point(193, 36)
        Me.txtcodpres.Name = "txtcodpres"
        Me.txtcodpres.Size = New System.Drawing.Size(399, 20)
        Me.txtcodpres.TabIndex = 39
        '
        'txtapeprest
        '
        Me.txtapeprest.Location = New System.Drawing.Point(311, 92)
        Me.txtapeprest.Name = "txtapeprest"
        Me.txtapeprest.Size = New System.Drawing.Size(281, 20)
        Me.txtapeprest.TabIndex = 38
        '
        'txtcedpres
        '
        Me.txtcedpres.Location = New System.Drawing.Point(193, 62)
        Me.txtcedpres.Name = "txtcedpres"
        Me.txtcedpres.Size = New System.Drawing.Size(399, 20)
        Me.txtcedpres.TabIndex = 37
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(341, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Fecha de entrega"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Observaciones"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Fecha de prestamo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Codigo y Nombre del libro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Nombre y Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Cedula"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Codigo "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.SalirToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(686, 24)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformacionDeEstudiantesToolStripMenuItem, Me.InformacionDeLibrosToolStripMenuItem, Me.DevolucionesToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'InformacionDeEstudiantesToolStripMenuItem
        '
        Me.InformacionDeEstudiantesToolStripMenuItem.Name = "InformacionDeEstudiantesToolStripMenuItem"
        Me.InformacionDeEstudiantesToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.InformacionDeEstudiantesToolStripMenuItem.Text = "Informacion de estudiantes"
        '
        'InformacionDeLibrosToolStripMenuItem
        '
        Me.InformacionDeLibrosToolStripMenuItem.Name = "InformacionDeLibrosToolStripMenuItem"
        Me.InformacionDeLibrosToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.InformacionDeLibrosToolStripMenuItem.Text = "Informacion de libros"
        '
        'DevolucionesToolStripMenuItem
        '
        Me.DevolucionesToolStripMenuItem.Name = "DevolucionesToolStripMenuItem"
        Me.DevolucionesToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.DevolucionesToolStripMenuItem.Text = "Devoluciones"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(22, 20)
        Me.SalirToolStripMenuItem.Text = " "
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'txtnomprest
        '
        Me.txtnomprest.Location = New System.Drawing.Point(193, 92)
        Me.txtnomprest.Name = "txtnomprest"
        Me.txtnomprest.Size = New System.Drawing.Size(100, 20)
        Me.txtnomprest.TabIndex = 53
        '
        'txtentregaprestamo
        '
        Me.txtentregaprestamo.Location = New System.Drawing.Point(492, 158)
        Me.txtentregaprestamo.Name = "txtentregaprestamo"
        Me.txtentregaprestamo.Size = New System.Drawing.Size(100, 20)
        Me.txtentregaprestamo.TabIndex = 54
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(363, 233)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 65
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(254, 233)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 64
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(132, 233)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar.TabIndex = 63
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(15, 233)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 62
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(492, 233)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 66
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'prestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 286)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txtentregaprestamo)
        Me.Controls.Add(Me.txtnomprest)
        Me.Controls.Add(Me.txtcodprestli)
        Me.Controls.Add(Me.txtobserpresta)
        Me.Controls.Add(Me.txtfechpre4sta)
        Me.Controls.Add(Me.txtnomlibprestamos)
        Me.Controls.Add(Me.txtcodpres)
        Me.Controls.Add(Me.txtapeprest)
        Me.Controls.Add(Me.txtcedpres)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "prestamos"
        Me.Text = "Prestamos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcodprestli As System.Windows.Forms.TextBox
    Friend WithEvents txtobserpresta As System.Windows.Forms.TextBox
    Friend WithEvents txtfechpre4sta As System.Windows.Forms.TextBox
    Friend WithEvents txtnomlibprestamos As System.Windows.Forms.TextBox
    Friend WithEvents txtcodpres As System.Windows.Forms.TextBox
    Friend WithEvents txtapeprest As System.Windows.Forms.TextBox
    Friend WithEvents txtcedpres As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtnomprest As System.Windows.Forms.TextBox
    Friend WithEvents txtentregaprestamo As System.Windows.Forms.TextBox
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents InformacionDeEstudiantesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformacionDeLibrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevolucionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
