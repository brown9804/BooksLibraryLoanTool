Public Class prestamos


    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        pantalla_principal.Show()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtapeprest.Clear()
        txtcedpres.Clear()
        txtcodpres.Clear()
        txtentregaprestamo.Clear()
        txtfechpre4sta.Clear()
        txtnomlibprestamos.Clear()
        txtnomprest.Clear()
        txtobserpresta.Clear()
        txtcodprestli.Clear()
        txtcodpres.Focus()


    End Sub



    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        On Error GoTo Control
        Dim consulta As String
        If txtcedpres.Text = "" Then
            MsgBox("Debe digitar la cedula")
            Exit Sub
        ElseIf txtnomprest.Text = "" Then
            MsgBox("Debe digitar el nombre del estudiante")
            Exit Sub
        ElseIf txtcodpres.Text = "" Then
            MsgBox("Debe digitar el codigo del prestamo")
            Exit Sub
        ElseIf txtapeprest.Text = "" Then
            MsgBox("Debe digitar el apellido del estudiante")
            Exit Sub
        ElseIf txtcodprestli.Text = "" Then
            MsgBox("Debe digitar el codigo del libro")
            Exit Sub
        ElseIf txtnomlibprestamos.Text = "" Then
            MsgBox("Debe digitar el nombre del libro")
            Exit Sub
        ElseIf txtfechpre4sta.Text = "" Then
            MsgBox("Debe digitar la fecha de prestamo")
            Exit Sub
        ElseIf txtobserpresta.Text = "" Then
            MsgBox("Debe digitar observaciones")
            Exit Sub
        ElseIf txtentregaprestamo.Text = "" Then
            MsgBox("Debe digitar la fecha de entrega")
        End If

        prestamosbeli = New ADODB.Recordset
        consulta = "Select * from B_D_Biblioteca_CLA_Prestamos where cod_pres_B_D_Biblioteca_CLA_Prestamos = " & txtcodpres.Text
        prestamosbeli.Open(consulta, conexion,
                ADODB.CursorTypeEnum.adOpenKeyset,
                ADODB.LockTypeEnum.adLockOptimistic)
        If estudiantes.RecordCount > 0 Then
            MsgBox("El prestamo ya existe", 0 + 64, "Prestamos")
            prestamosbeli.Close()
            Exit Sub
        End If

        prestamosbeli.AddNew()

        prestamosbeli.Fields("ced_alum_B_D_Biblioteca_CLA_Prestamos").Value() = (txtcedpres.Text)
        prestamosbeli.Fields("nom_alum_B_D_Biblioteca_CLA_Prestamos").Value() = (txtnomprest.Text)
        prestamosbeli.Fields("ape_alum_B_D_Biblioteca_CLA_Prestamos").Value() = (txtapeprest.Text)
        prestamosbeli.Fields("cod_pres_B_D_Biblioteca_CLA_Prestamos").Value() = (txtcodpres.Text)
        prestamosbeli.Fields("tit_lib_B_D_Biblioteca_CLA_Prestamos").Value() = (txtnomlibprestamos.Text)
        prestamosbeli.Fields("fech_pres_B_D_Biblioteca_CLA_Prestamos").Value() = (txtfechpre4sta.Text)
        prestamosbeli.Fields("fech_entr_B_D_Biblioteca_CLA_Prestamos").Value() = (txtentregaprestamo.Text)
        prestamosbeli.Fields("obser_B_D_Biblioteca_CLA_Prestamos").Value() = (txtobserpresta.Text)
        prestamosbeli.Fields("cod_lib_B_D_Biblioteca_CLA_Prestamos").Value() = (txtcodprestli.Text)
        prestamosbeli.Update()
        prestamosbeli.Close()

        txtcedpres.Text = ""
        txtnomlibprestamos.Text = ""
        txtapeprest.Text = ""
        txtcodpres.Text = ""
        txtnomprest.Text = ""
        txtfechpre4sta.Text = ""
        txtentregaprestamo.Text = ""
        txtobserpresta.Text = ""
        txtcodprestli.Text = ""
        MsgBox("Los datos del prestamo han sido guardados")
        Exit Sub
Control:
        MsgBox(Err.Number & " - " & Err.Description)
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        On Error GoTo control
        Dim consulta As String
        If txtcedpres.Text = "" Then
            MsgBox("Debe digitar la cedula")
            Exit Sub
        ElseIf txtnomprest.Text = "" Then
            MsgBox("Debe digitar el nombre del estudiante")
            Exit Sub
        ElseIf txtcodpres.Text = "" Then
            MsgBox("Debe digitar el codigo del prestamo")
            Exit Sub
        ElseIf txtapeprest.Text = "" Then
            MsgBox("Debe digitar el apellido del estudiante")
            Exit Sub
        ElseIf txtcodprestli.Text = "" Then
            MsgBox("Debe digitar el codigo del libro")
            Exit Sub
        ElseIf txtnomlibprestamos.Text = "" Then
            MsgBox("Debe digitar el nombre del libro")
            Exit Sub
        ElseIf txtfechpre4sta.Text = "" Then
            MsgBox("Debe digitar la fecha de prestamo")
            Exit Sub
        ElseIf txtobserpresta.Text = "" Then
            MsgBox("Debe digitar observaciones")
            Exit Sub
        ElseIf txtentregaprestamo.Text = "" Then
            MsgBox("Debe digitar la fecha de entrega")
        End If

        prestamosbeli = New ADODB.Recordset
        consulta = "Select * from B_D_Biblioteca_CLA_Prestamos where cod_pres_B_D_Biblioteca_CLA_Prestamos = " & txtcodpres.Text
        prestamosbeli.Open(consulta, conexion,
                ADODB.CursorTypeEnum.adOpenKeyset,
                ADODB.LockTypeEnum.adLockOptimistic)
        If estudiantes.RecordCount > 0 Then
            MsgBox("El prestamo ya existe", 0 + 64, "Prestamos")
            prestamosbeli.Close()
            Exit Sub
        End If
        prestamosbeli.Fields("ced_alum_B_D_Biblioteca_CLA_Prestamos").Value() = (txtcedpres.Text)
        prestamosbeli.Fields("nom_alum_B_D_Biblioteca_CLA_Prestamos").Value() = (txtnomprest.Text)
        prestamosbeli.Fields("ape_alum_B_D_Biblioteca_CLA_Prestamos").Value() = (txtapeprest.Text)
        prestamosbeli.Fields("cod_pres_B_D_Biblioteca_CLA_Prestamos").Value() = (txtcodpres.Text)
        prestamosbeli.Fields("tit_lib_B_D_Biblioteca_CLA_Prestamos").Value() = (txtnomlibprestamos.Text)
        prestamosbeli.Fields("fech_pres_B_D_Biblioteca_CLA_Prestamos").Value() = (txtfechpre4sta.Text)
        prestamosbeli.Fields("fech_entr_B_D_Biblioteca_CLA_Prestamos").Value() = (txtentregaprestamo.Text)
        prestamosbeli.Fields("obser_B_D_Biblioteca_CLA_Prestamos").Value() = (txtobserpresta.Text)
        prestamosbeli.Fields("cod_lib_B_D_Biblioteca_CLA_Prestamos").Value() = (txtcodprestli.Text)
        prestamosbeli.Update()
        prestamosbeli.Close()
        txtcedpres.Text = ""
        txtnomlibprestamos.Text = ""
        txtapeprest.Text = ""
        txtcodpres.Text = ""
        txtnomprest.Text = ""
        txtfechpre4sta.Text = ""
        txtentregaprestamo.Text = ""
        txtobserpresta.Text = ""
        txtcodprestli.Text = ""
        MsgBox("Los datos del prestamo han sido modificados")
        Exit Sub
Control:
        MsgBox(Err.Number & " - " & Err.Description)
    End Sub



    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        On Error GoTo Control
        Dim consulta As String

        If txtcodpres.Text = "" Then
            MsgBox("Debe digitar el codigo del prestamo")
            Exit Sub
        End If
        prestamosbeli = New ADODB.Recordset
        consulta = "Select * from B_D_Biblioteca_CLA_Prestamos where cod_pres_B_D_Biblioteca_CLA_Prestamos = " & txtcodpres.Text
        prestamosbeli.Open(consulta, conexion,
                ADODB.CursorTypeEnum.adOpenKeyset,
                ADODB.LockTypeEnum.adLockOptimistic)
        
        If prestamosbeli.BOF And prestamosbeli.EOF Then
            MsgBox("El prestamo no existe", 0 + 64)
            prestamosbeli.Close()
            txtcodpres.Clear()
            Exit Sub
        End If
        txtcedpres.Text = prestamosbeli.Fields("ced_alum_B_D_Biblioteca_CLA_Prestamos").Value()
        txtnomprest.Text = prestamosbeli.Fields("nom_alum_B_D_Biblioteca_CLA_Prestamos").Value()
        txtapeprest.Text =prestamosbeli.Fields("ape_alum_B_D_Biblioteca_CLA_Prestamos").Value()
        txtcodpres.Text = prestamosbeli.Fields("cod_pres_B_D_Biblioteca_CLA_Prestamos").Value()
        txtnomlibprestamos.Text = prestamosbeli.Fields("tit_lib_B_D_Biblioteca_CLA_Prestamos").Value()
        txtfechpre4sta.Text = prestamosbeli.Fields("fech_pres_B_D_Biblioteca_CLA_Prestamos").Value()
        txtentregaprestamo.Text = prestamosbeli.Fields("fech_entr_B_D_Biblioteca_CLA_Prestamos").Value()
        txtobserpresta.Text = prestamosbeli.Fields("obser_B_D_Biblioteca_CLA_Prestamos").Value()
        txtcodprestli.Text = prestamosbeli.Fields("cod_lib_B_D_Biblioteca_CLA_Prestamos").Value()
        prestamosbeli.Close()
        MsgBox("Los datos han sido encontrados")
        Exit Sub
Control:
        MsgBox(Err.Number & "- " & Err.Description)

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        On Error GoTo Control
        Dim valor As Integer
        Dim consulta As String

        If txtcedpres.Text = "" Then
            MsgBox("Debe digitar la cedula")
            Exit Sub
        ElseIf txtnomprest.Text = "" Then
            MsgBox("Debe digitar el nombre del estudiante")
            Exit Sub
        ElseIf txtcodpres.Text = "" Then
            MsgBox("Debe digitar el codigo del prestamo")
            Exit Sub
        ElseIf txtapeprest.Text = "" Then
            MsgBox("Debe digitar el apellido del estudiante")
            Exit Sub
        ElseIf txtcodprestli.Text = "" Then
            MsgBox("Debe digitar el codigo del libro")
            Exit Sub
        ElseIf txtnomlibprestamos.Text = "" Then
            MsgBox("Debe digitar el nombre del libro")
            Exit Sub
        ElseIf txtfechpre4sta.Text = "" Then
            MsgBox("Debe digitar la fecha de prestamo")
            Exit Sub
        ElseIf txtobserpresta.Text = "" Then
            MsgBox("Debe digitar observaciones")
            Exit Sub
        End If

        prestamosbeli = New ADODB.Recordset
        consulta = "Select * from B_D_Biblioteca_CLA_Prestamos where cod_pres_B_D_Biblioteca_CLA_Prestamos = " & txtcodpres.Text
        prestamosbeli.Open(consulta, conexion,
                ADODB.CursorTypeEnum.adOpenKeyset,
                ADODB.LockTypeEnum.adLockOptimistic)


        If prestamosbeli.RecordCount = 0 Then
            MsgBox("El prestamo no existe", 0 + 64)
            estudiantes.Close()
            Exit Sub
        End If
        valor = MsgBox("Esta seguro que desea eliminar los datos del prestamo", 4 + 32 + 256, "Prestamos")
        If valor = 6 Then
            prestamosbeli.Delete()
            prestamosbeli.Close()

            txtcedpres.Text = ""
            txtnomlibprestamos.Text = ""
            txtapeprest.Text = ""
            txtcodpres.Text = ""
            txtnomprest.Text = ""
            txtfechpre4sta.Text = ""
            txtentregaprestamo.Text = ""
            txtobserpresta.Text = ""
            txtcodprestli.Text = ""
            MsgBox("Los datos del prestamo han sido eliminados")
        ElseIf valor = 7 Then
            prestamosbeli.Close()
        End If
        Exit Sub
Control:
        MsgBox(Err.Description & " - " & Err.Number)

    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()

    End Sub

  
    Private Sub InformacionDeEstudiantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionDeEstudiantesToolStripMenuItem.Click
        Me.Hide()
        informacion_estudiantes.Show()

    End Sub

    Private Sub InformacionDeLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionDeLibrosToolStripMenuItem.Click
        Me.Hide()
        informacion_libros.Show()

    End Sub

    Private Sub DevolucionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolucionesToolStripMenuItem.Click
        Me.Hide()
        devoluciones.Show()
    End Sub

    Private Sub prestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub prestamos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim cerrar As Integer
        cerrar = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.OkCancel, "Prestamos")

        If cerrar = 2 Then
            e.Cancel = True
            Me.Show()
        ElseIf cerrar = 1 Then
            e.Cancel = False
        End If
    End Sub
End Class