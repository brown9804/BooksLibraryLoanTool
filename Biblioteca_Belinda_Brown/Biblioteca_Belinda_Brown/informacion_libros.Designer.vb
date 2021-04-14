<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class informacion_libros
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
        Me.InformacionDeEstudiantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrestamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolucionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtcodigoli = New System.Windows.Forms.TextBox()
        Me.txttituloli = New System.Windows.Forms.TextBox()
        Me.txteditorialli = New System.Windows.Forms.TextBox()
        Me.txtcategoriali = New System.Windows.Forms.TextBox()
        Me.txtidiomali = New System.Windows.Forms.TextBox()
        Me.txtautorli = New System.Windows.Forms.TextBox()
        Me.txtcanli = New System.Windows.Forms.TextBox()
        Me.txtcostli = New System.Windows.Forms.TextBox()
        Me.txtobservali = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.txtañolibro = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtdesclib = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(516, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformacionDeEstudiantesToolStripMenuItem, Me.PrestamosToolStripMenuItem, Me.DevolucionesToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'InformacionDeEstudiantesToolStripMenuItem
        '
        Me.InformacionDeEstudiantesToolStripMenuItem.Name = "InformacionDeEstudiantesToolStripMenuItem"
        Me.InformacionDeEstudiantesToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.InformacionDeEstudiantesToolStripMenuItem.Text = "Informacion de Estudiantes"
        '
        'PrestamosToolStripMenuItem
        '
        Me.PrestamosToolStripMenuItem.Name = "PrestamosToolStripMenuItem"
        Me.PrestamosToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.PrestamosToolStripMenuItem.Text = "Prestamos"
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
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Titulo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Categoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Editorial"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Autor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Idioma"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Año"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 280)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Cantidad de libros"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 319)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Costo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 391)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Observaciones"
        '
        'txtcodigoli
        '
        Me.txtcodigoli.Location = New System.Drawing.Point(132, 41)
        Me.txtcodigoli.Name = "txtcodigoli"
        Me.txtcodigoli.Size = New System.Drawing.Size(281, 20)
        Me.txtcodigoli.TabIndex = 11
        '
        'txttituloli
        '
        Me.txttituloli.Location = New System.Drawing.Point(132, 77)
        Me.txttituloli.Name = "txttituloli"
        Me.txttituloli.Size = New System.Drawing.Size(281, 20)
        Me.txttituloli.TabIndex = 12
        '
        'txteditorialli
        '
        Me.txteditorialli.Location = New System.Drawing.Point(132, 146)
        Me.txteditorialli.Name = "txteditorialli"
        Me.txteditorialli.Size = New System.Drawing.Size(281, 20)
        Me.txteditorialli.TabIndex = 14
        '
        'txtcategoriali
        '
        Me.txtcategoriali.Location = New System.Drawing.Point(132, 110)
        Me.txtcategoriali.Name = "txtcategoriali"
        Me.txtcategoriali.Size = New System.Drawing.Size(281, 20)
        Me.txtcategoriali.TabIndex = 13
        '
        'txtidiomali
        '
        Me.txtidiomali.Location = New System.Drawing.Point(132, 211)
        Me.txtidiomali.Name = "txtidiomali"
        Me.txtidiomali.Size = New System.Drawing.Size(281, 20)
        Me.txtidiomali.TabIndex = 16
        '
        'txtautorli
        '
        Me.txtautorli.Location = New System.Drawing.Point(132, 175)
        Me.txtautorli.Name = "txtautorli"
        Me.txtautorli.Size = New System.Drawing.Size(281, 20)
        Me.txtautorli.TabIndex = 15
        '
        'txtcanli
        '
        Me.txtcanli.Location = New System.Drawing.Point(132, 280)
        Me.txtcanli.Name = "txtcanli"
        Me.txtcanli.Size = New System.Drawing.Size(100, 20)
        Me.txtcanli.TabIndex = 18
        '
        'txtcostli
        '
        Me.txtcostli.Location = New System.Drawing.Point(132, 316)
        Me.txtcostli.Name = "txtcostli"
        Me.txtcostli.Size = New System.Drawing.Size(100, 20)
        Me.txtcostli.TabIndex = 19
        '
        'txtobservali
        '
        Me.txtobservali.Location = New System.Drawing.Point(131, 383)
        Me.txtobservali.Name = "txtobservali"
        Me.txtobservali.Size = New System.Drawing.Size(281, 20)
        Me.txtobservali.TabIndex = 20
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(15, 426)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 21
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(132, 426)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(75, 23)
        Me.btnmodificar.TabIndex = 22
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(254, 426)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnbuscar.TabIndex = 23
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(363, 426)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 24
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(363, 298)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 25
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'txtañolibro
        '
        Me.txtañolibro.Location = New System.Drawing.Point(131, 245)
        Me.txtañolibro.Name = "txtañolibro"
        Me.txtañolibro.Size = New System.Drawing.Size(100, 20)
        Me.txtañolibro.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 352)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Descripcion"
        '
        'txtdesclib
        '
        Me.txtdesclib.Location = New System.Drawing.Point(131, 352)
        Me.txtdesclib.Name = "txtdesclib"
        Me.txtdesclib.Size = New System.Drawing.Size(281, 20)
        Me.txtdesclib.TabIndex = 28
        '
        'informacion_libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 461)
        Me.Controls.Add(Me.txtdesclib)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtañolibro)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txtobservali)
        Me.Controls.Add(Me.txtcostli)
        Me.Controls.Add(Me.txtcanli)
        Me.Controls.Add(Me.txtidiomali)
        Me.Controls.Add(Me.txtautorli)
        Me.Controls.Add(Me.txteditorialli)
        Me.Controls.Add(Me.txtcategoriali)
        Me.Controls.Add(Me.txttituloli)
        Me.Controls.Add(Me.txtcodigoli)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "informacion_libros"
        Me.Text = "Informacion de los libros"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtcodigoli As System.Windows.Forms.TextBox
    Friend WithEvents txttituloli As System.Windows.Forms.TextBox
    Friend WithEvents txteditorialli As System.Windows.Forms.TextBox
    Friend WithEvents txtcategoriali As System.Windows.Forms.TextBox
    Friend WithEvents txtidiomali As System.Windows.Forms.TextBox
    Friend WithEvents txtautorli As System.Windows.Forms.TextBox
    Friend WithEvents txtcanli As System.Windows.Forms.TextBox
    Friend WithEvents txtcostli As System.Windows.Forms.TextBox
    Friend WithEvents txtobservali As System.Windows.Forms.TextBox
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents btneliminar As System.Windows.Forms.Button
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Friend WithEvents txtañolibro As System.Windows.Forms.TextBox
    Friend WithEvents InformacionDeEstudiantesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrestamosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevolucionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtdesclib As System.Windows.Forms.TextBox
End Class
