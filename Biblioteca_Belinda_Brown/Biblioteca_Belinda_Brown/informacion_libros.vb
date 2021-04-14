Public Class informacion_libros


    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        pantalla_principal.Show()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        On Error GoTo control
        Dim consulta As String
        If txtcodigoli.Text = "" Then
            MsgBox("Debe digitar el codigo del libro")
            Exit Sub

        ElseIf txttituloli.Text = "" Then
            MsgBox("Debe de digitar el titulo del libro")
            Exit Sub
        ElseIf txtcategoriali.Text = "" Then
            MsgBox("Debe digitar la categoria del libro")
            Exit Sub
        ElseIf txteditorialli.Text = "" Then
            MsgBox("Debe digitar la editorial del libro")
            Exit Sub
        ElseIf txtautorli.Text = "" Then
            MsgBox("Debe de digitar el autor del libro")
            Exit Sub
        ElseIf txtidiomali.Text = "" Then
            MsgBox("Debe de digitar el idioma del libro")
            Exit Sub
        End If
        libros = New ADODB.Recordset
        consulta = "Select * from B_D_Belinda_Bibliioteca_CLA where cod_lib_B_D_Biblioteca_CLA_Libros = " & txtcodigoli.Text

        libros.Open(consulta, conexion,
                                             ADODB.CursorTypeEnum.adOpenKeyset,
                                             ADODB.LockTypeEnum.adLockOptimistic)
        If libros.RecordCount > 0 Then
            MsgBox("El libro ya exite", 0 + 64, "Mantenimiento de Biblioteca")
            libros.Close()
            Exit Sub
        End If
        libros.AddNew()
        libros.Fields("cod_lib_B_D_Biblioteca_CLA_Libros").Value() = txtcodigoli.Text
        libros.Fields("tit_lib_B_D_Biblioteca_CLA_Libros").Value() = txttituloli.Text
        libros.Fields("descrip_libr_B_D_Biblioteca_CLA_Libros").Value() = txtdesclib.Text
        libros.Fields("categ_lib_B_D_Biblioteca_CLA_Libros").Value() = txtcategoriali.Text
        libros.Fields("categ_lib_B_D_Biblioteca_CLA_Libros").Value() = txtcategoriali.Text
        libros.Fields("autor_lib_B_D_Biblioteca_CLA_Libros").Value() = txtautorli.Text
        libros.Fields("idio_lib_B_D_Biblioteca_CLA_Libros").Value() = txtidiomali.Text
        libros.Fields("año_lib_B_D_Biblioteca_CLA_Libros").Value() = txtañolibro.Text
        libros.Fields("cant_lib_B_D_Biblioteca_CLA_Libros").Value() = txtcanli.Text
        libros.Fields("cost_lib_B_D_Biblioteca_CLA_Libros").Value() = txtcostli.Text
        libros.Fields("obser_lib_B_D_Biblioteca_CLA_Libros").Value() = txtobservali.Text
        libros.Update()
        libros.Close()


        MsgBox("Los datos del libro han sido guardados")
        Exit Sub
control:
        MsgBox(Err.Number & " - " & Err.Description)
    End Sub





    Private Sub informacion_libros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtañolibro.Text = ""
        txtautorli.Text = ""
        txtcanli.Text = ""
        txtcategoriali.Text = ""
        txtcodigoli.Text = ""
        txtcostli.Text = ""
        txtdesclib.Text = ""
        txteditorialli.Text = ""
        txtidiomali.Text = ""
        txtobservali.Text = ""
        txttituloli.Text = ""
        txtcodigoli.Focus()
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        On Error GoTo Control
        Dim consulta As String
        If txtcodigoli.Text = "" Then
            MsgBox("Debe digitar el codigo del libro")
        ElseIf txttituloli.Text = "" Then
            MsgBox("Debe digitar el titulo del libro")
        ElseIf txtcategoriali.Text = "" Then
            MsgBox("Debe digitar la editorial del libro")
        ElseIf txteditorialli.Text = "" Then
            MsgBox("Debe digitar el email del libro")
        ElseIf txtautorli.Text = "" Then
            MsgBox("Debe digitar el autor del libro")
        ElseIf txtidiomali.Text = "" Then
            MsgBox("Debe digitar el idioma del libro")
        ElseIf txtañolibro.Text = "" Then
            MsgBox("Debe digitar el año del libro")
        ElseIf txtcostli.Text = "" Then
            MsgBox("Debe digitar el costo del libro")
        ElseIf txtobservali.Text = "" Then
            MsgBox("Debe digitar las observaciones del libro")
        ElseIf txtcanli.Text = "" Then
            MsgBox("Debe digitar la cantidad de libros")
        End If

        libros = New ADODB.Recordset
        consulta = "Select * from B_D_Belinda_Bibliioteca_CLA where cod_lib_B_D_Biblioteca_CLA_Libros = " & txtcodigoli.Text

        libros.Open(consulta, conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If libros.RecordCount = 0 Then
            MsgBox("El libro no existe", 0 + 64)
            libros.Close()
            Exit Sub
        End If
        libros.Fields("cod_lib_B_D_Biblioteca_CLA_Libros").Value() = txtcodigoli.Text
        libros.Fields("tit_lib_B_D_Biblioteca_CLA_Libros").Value() = txttituloli.Text
        libros.Fields("descrip_libr_B_D_Biblioteca_CLA_Libros").Value() = txtdesclib.Text
        libros.Fields("categ_lib_B_D_Biblioteca_CLA_Libros").Value() = txtcategoriali.Text
        libros.Fields("categ_lib_B_D_Biblioteca_CLA_Libros").Value() = txtcategoriali.Text
        libros.Fields("autor_lib_B_D_Biblioteca_CLA_Libros").Value() = txtautorli.Text
        libros.Fields("idio_lib_B_D_Biblioteca_CLA_Libros").Value() = txtidiomali.Text
        libros.Fields("año_lib_B_D_Biblioteca_CLA_Libros").Value() = txtañolibro.Text
        libros.Fields("cant_lib_B_D_Biblioteca_CLA_Libros").Value() = txtcanli.Text
        libros.Fields("cost_lib_B_D_Biblioteca_CLA_Libros").Value() = txtcostli.Text
        libros.Fields("obser_lib_B_D_Biblioteca_CLA_Libros").Value() = txtobservali.Text

        libros.Update()
        libros.Close()

        txtañolibro.Clear()
        txtcanli.Clear()
        txtautorli.Clear()
        txtcategoriali.Clear()
        txtcostli.Clear()
        txtcodigoli.Clear()
        txtdesclib.Clear()
        txteditorialli.Clear()
        txtidiomali.Clear()
        txtidiomali.Clear()
        txtobservali.Clear()
        txttituloli.Clear()
        txtcodigoli.Focus()

        MsgBox("Los datos han sido modificados")
        Exit Sub
Control:
        MsgBox(Err.Number & " - " & Err.Description)
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        On Error GoTo Control
        Dim consulta As String

        If txtcodigoli.Text = "" Then
            MsgBox("Debe digitar el codigo del libro")
            Exit Sub
        End If
        libros = New ADODB.Recordset
        consulta = "Select * from B_D_Belinda_Bibliioteca_CLA where cod_lib_B_D_Biblioteca_CLA_Libros = " & txtcodigoli.Text
        libros.Open(consulta, conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If libros.BOF And libros.EOF Then
            MsgBox("El alumno no existe", 0 + 64)
            libros.Close()
            txtcodigoli.Clear()
            Exit Sub
        End If
        libros.Fields("cod_lib_B_D_Biblioteca_CLA_Libros").Value() = txtcodigoli.Text
        libros.Fields("tit_lib_B_D_Biblioteca_CLA_Libros").Value() = txttituloli.Text
        libros.Fields("descrip_libr_B_D_Biblioteca_CLA_Libros").Value() = txtdesclib.Text
        libros.Fields("categ_lib_B_D_Biblioteca_CLA_Libros").Value() = txtcategoriali.Text
        libros.Fields("categ_lib_B_D_Biblioteca_CLA_Libros").Value() = txtcategoriali.Text
        libros.Fields("autor_lib_B_D_Biblioteca_CLA_Libros").Value() = txtautorli.Text
        libros.Fields("idio_lib_B_D_Biblioteca_CLA_Libros").Value() = txtidiomali.Text
        libros.Fields("año_lib_B_D_Biblioteca_CLA_Libros").Value() = txtañolibro.Text
        libros.Fields("cant_lib_B_D_Biblioteca_CLA_Libros").Value() = txtcanli.Text
        libros.Fields("cost_lib_B_D_Biblioteca_CLA_Libros").Value() = txtcostli.Text
        libros.Fields("obser_lib_B_D_Biblioteca_CLA_Libros").Value() = txtobservali.Text

        libros.Close()
        MsgBox("Los datos han sido encontrados")
        Exit Sub
Control:
        MsgBox(Err.Number & "- " & Err.Description)

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        On Error GoTo Control
        Dim consulta As String
        Dim valor As String
        If txtcodigoli.Text = "" Then
            MsgBox("Debe digitar el codigo del libro")
            Exit Sub
        ElseIf txttituloli.Text = "" Then
            MsgBox("Debe digitar el titulo del libro")
            Exit Sub
        ElseIf txtcategoriali.Text = "" Then
            MsgBox("Debe digitar la categoria del libro")
            Exit Sub
        ElseIf txteditorialli.Text = "" Then
            MsgBox("Debe el nombre de la editorial")
            Exit Sub
        ElseIf txtautorli.Text = "" Then
            MsgBox("Debe digitar el nombre del autor")
            Exit Sub
        ElseIf txtidiomali.Text = "" Then
            MsgBox("Debe digitar el idioma del libro")
            Exit Sub
        ElseIf txtañolibro.Text = "" Then
            MsgBox("Debe seleccionar el año")
            Exit Sub
        ElseIf txtobservali.Text = "" Then
            MsgBox("Debe digitar observaciones")
            Exit Sub
        ElseIf txtcostli.Text = "" Then
            MsgBox("Debe digitar el costo del libro")
            Exit Sub
        ElseIf txtcanli.Text = "" Then
            MsgBox("Debe digitar la cantidad de libros")
            Exit Sub
        ElseIf txtdesclib.Text = "" Then
            MsgBox("Debe digitar una descripcion")
            Exit Sub
        End If

        libros = New ADODB.Recordset
        consulta = "Select * from B_D_Belinda_Bibliioteca_CLA where cod_lib_B_D_Biblioteca_CLA_Libros = " & txtcodigoli.Text
        libros.Open(consulta, conexion,
                ADODB.CursorTypeEnum.adOpenKeyset,
                ADODB.LockTypeEnum.adLockOptimistic)
        If libros.RecordCount = 0 Then
            MsgBox("El libro no existe", 0 + 64, "Libros")
            libros.Close()
        End If
        valor = MsgBox("Esta seguro que desea eliminar los datos del estudiante", 4 + 32 + 256, "Estudiantes")
        If valor = 6 Then
            libros.Delete()
            libros.Close()

            txtcodigoli.Text = ""
            txttituloli.Text = ""
            txtdesclib.Text = ""
            txtcategoriali.Text = ""
            txtañolibro.Text = ""
            txteditorialli.Text = ""
            txtcanli.Text = ""
            txtobservali.Text = ""
            txtcostli.Text = ""

            MsgBox("Los datos del libro han sido borrados")
        ElseIf valor = 7 Then
            libros.Close()
        End If
        Exit Sub
Control: MsgBox(Err.Number & " - " & Err.Description)
    End Sub

    Private Sub InformacionDeEstudiantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionDeEstudiantesToolStripMenuItem.Click
        Me.Hide()
        informacion_estudiantes.Show()

    End Sub

    Private Sub PrestamosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrestamosToolStripMenuItem.Click
        Me.Hide()
        prestamos.Show()
    End Sub

    Private Sub DevolucionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolucionesToolStripMenuItem.Click
        Me.Hide()
        devoluciones.Show()

    End Sub

    Private Sub informacion_libros_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim cerrar As Integer
        cerrar = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.OkCancel, "Libros")

        If cerrar = 2 Then
            e.Cancel = True
            Me.Show()
        ElseIf cerrar = 1 Then
            e.Cancel = False
        End If
    End Sub
End Class