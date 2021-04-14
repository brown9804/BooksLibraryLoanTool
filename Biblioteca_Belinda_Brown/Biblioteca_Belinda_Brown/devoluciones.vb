Public Class devoluciones

    Private Sub devoluciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtapealumdev.TextChanged

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Hide()
        pantalla_principal.Show()
    End Sub

    Private Sub InformacionDeLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionDeLibrosToolStripMenuItem.Click
        Me.Hide()
        informacion_libros.Show()
    End Sub

    Private Sub InformacionDeEstudiantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionDeEstudiantesToolStripMenuItem.Click
        Me.Hide()
        informacion_estudiantes.Show()
    End Sub

    Private Sub PrestamosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrestamosToolStripMenuItem.Click
        Me.Hide()
        prestamos.Show()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        On Error GoTo Control
        Dim consulta As String

        If txtcedalumdev.Text = "" Then
            MsgBox("Debe digitar el codigo de devoluciones")
            Exit Sub
        ElseIf txtnomalumdev.Text = "" Then
            MsgBox("Debe digitar el nombre del estudiante")
            Exit Sub
        ElseIf txtapealumdev.Text = "" Then
            MsgBox("Debe digitar los apellidos del estudiante")
            Exit Sub
        ElseIf txtcodlidevol.Text = "" Then
            MsgBox("Debe digitar el codigo del libro")
            Exit Sub
        ElseIf txtcedalumdev.Text = "" Then
            MsgBox("Debe digitar la cedula del estudiante")
            Exit Sub
        ElseIf txtfecdev.Text = "" Then
            MsgBox("Debe digitar la fecha")
            Exit Sub
        ElseIf cbtipodecobdev.Text = "" Then
            MsgBox("Debe seleccionar el tipo de cobro")
            Exit Sub
        ElseIf cbtipodedev.Text = "" Then
            MsgBox("Debe seleccionar el tipo de devolucion")
            Exit Sub
        ElseIf txtmontocobrswv.Text = "" Then
            MsgBox("Debe digitar el monto de cobro")
            Exit Sub
        ElseIf txtmontoconpagadev.Text = "" Then
            MsgBox("Debe digitar el monto con que paga")
            Exit Sub
        ElseIf txtcambiodev.Text = "" Then
            MsgBox("Debe calcular el cambio")
            Exit Sub
        End If

        devolucionesbeli = New ADODB.Recordset
        consulta = "Select * from b_d_biblioteca_cla_devolucion where cod_dev_B_D_Biblioteca_CLA_Devolucion = '" & txtcodigodev.Text & "'"
        devolucionesbeli.Open(consulta, conexion,
                ADODB.CursorTypeEnum.adOpenKeyset,
                ADODB.LockTypeEnum.adLockOptimistic)
        If devolucionesbeli.RecordCount > 0 Then
            MsgBox("La devolucion ya existe", 0 + 64, "Devolucion")
            devolucionesbeli.Close()
            Exit Sub
        End If

        devolucionesbeli.AddNew()

        devolucionesbeli.Fields("cod_dev_B_D_Biblioteca_CLA_Devolucion").Value() = (txtcodigodev.Text)
        devolucionesbeli.Fields("cod_lib_B_D_Biblioteca_CLA_Devolucion").Value() = (txtcodlidevol.Text)
        devolucionesbeli.Fields("ced_alum_B_D_Biblioteca_CLA_Devolucion").Value() = (txtcedalumdev.Text)
        devolucionesbeli.Fields("nom_alum_B_D_Biblioteca_CLA_Devolucion").Value() = (txtnomalumdev.Text)
        devolucionesbeli.Fields("apell_alum_B_D_Biblioteca_CLA_Devolucion").Value() = (txtapealumdev.Text)
        devolucionesbeli.Fields("fech_prest_B_D_Biblioteca_CLA_Devolucion").Value() = (txtfecdev.Text)
        devolucionesbeli.Fields("tipo_dev_B_D_Biblioteca_CLA_Devolucion").Value() = (cbtipodedev.Text)
        devolucionesbeli.Fields("tipo_cob_B_D_Biblioteca_CLA_Devolucion").Value() = (cbtipodecobdev.Text)
        devolucionesbeli.Fields("monto_cob_B_D_Biblioteca_CLA_Devolucion").Value() = (txtmontocobrswv.Text)
        devolucionesbeli.Fields("monto_pag_B_D_Biblioteca_CLA_Devolucion").Value() = (txtmontoconpagadev.Text)
        devolucionesbeli.Fields("cambio_B_D_Biblioteca_CLA_Devolucion").Value() = (txtcambiodev.Text)

        devolucionesbeli.Update()
        devolucionesbeli.Close()



        txtcedalumdev.Text = ""
        txtnomalumdev.Text = ""
        txtcodlidevol.Text = ""
        txtcedalumdev.Text = ""
        txtapealumdev.Text = ""
        txtfecdev.Text = ""
        cbtipodedev.Text = ""
        cbtipodecobdev.Text = ""
        txtmontocobrswv.Text = ""
        txtmontoconpagadev.Text = ""
        txtcambiodev.Text = ""

        MsgBox("Los datos de la devolucion han sido guardados")
        Exit Sub
Control:
        MsgBox(Err.Number & " - " & Err.Description)

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        On Error GoTo Control
        Dim consulta As String
        If txtcedalumdev.Text = "" Then
            MsgBox("Debe digitar el codigo de devoluciones")
            Exit Sub
        ElseIf txtnomalumdev.Text = "" Then
            MsgBox("Debe digitar el nombre del estudiante")
            Exit Sub
        ElseIf txtapealumdev.Text = "" Then
            MsgBox("Debe digitar los apellidos del estudiante")
            Exit Sub
        ElseIf txtcodlidevol.Text = "" Then
            MsgBox("Debe digitar el codigo del libro")
            Exit Sub
        ElseIf txtcedalumdev.Text = "" Then
            MsgBox("Debe digitar la cedula del estudiante")
            Exit Sub
        ElseIf txtfecdev.Text = "" Then
            MsgBox("Debe digitar la fecha")
            Exit Sub
        ElseIf cbtipodecobdev.Text = "" Then
            MsgBox("Debe seleccionar el tipo de cobro")
            Exit Sub
        ElseIf cbtipodedev.Text = "" Then
            MsgBox("Debe seleccionar el tipo de devolucion")
            Exit Sub
        ElseIf txtmontocobrswv.Text = "" Then
            MsgBox("Debe digitar el monto de cobro")
            Exit Sub
        ElseIf txtmontoconpagadev.Text = "" Then
            MsgBox("Debe digitar el monto con que paga")
            Exit Sub
        ElseIf txtcambiodev.Text = "" Then
            MsgBox("Debe calcular el cambio")
            Exit Sub
        End If

        devolucionesbeli = New ADODB.Recordset
        consulta = "Select * from b_d_biblioteca_cla_devolucion where cod_dev_B_D_Biblioteca_CLA_Devolucion = '" & txtcodigodev.Text & "'"
        devolucionesbeli.Open(consulta, conexion,
                ADODB.CursorTypeEnum.adOpenKeyset,
                ADODB.LockTypeEnum.adLockOptimistic)
        If devolucionesbeli.RecordCount > 0 Then
            MsgBox("La devolucion ya existe", 0 + 64, "Devolucion")
            devolucionesbeli.Close()
            Exit Sub
        End If


        devolucionesbeli.Fields("cod_dev_B_D_Biblioteca_CLA_Devolucion").Value() = (txtcodigodev.Text)
        devolucionesbeli.Fields("cod_lib_B_D_Biblioteca_CLA_Devolucion").Value() = (txtcodlidevol.Text)
        devolucionesbeli.Fields("ced_alum_B_D_Biblioteca_CLA_Devolucion").Value() = (txtcedalumdev.Text)
        devolucionesbeli.Fields("nom_alum_B_D_Biblioteca_CLA_Devolucion").Value() = (txtnomalumdev.Text)
        devolucionesbeli.Fields("apell_alum_B_D_Biblioteca_CLA_Devolucion").Value() = (txtapealumdev.Text)
        devolucionesbeli.Fields("fech_prest_B_D_Biblioteca_CLA_Devolucion").Value() = (txtfecdev.Text)
        devolucionesbeli.Fields("tipo_dev_B_D_Biblioteca_CLA_Devolucion").Value() = (cbtipodedev.Text)
        devolucionesbeli.Fields("tipo_cob_B_D_Biblioteca_CLA_Devolucion").Value() = (cbtipodecobdev.Text)
        devolucionesbeli.Fields("monto_cob_B_D_Biblioteca_CLA_Devolucion").Value() = (txtmontocobrswv.Text)
        devolucionesbeli.Fields("monto_pag_B_D_Biblioteca_CLA_Devolucion").Value() = (txtmontoconpagadev.Text)
        devolucionesbeli.Fields("cambio_B_D_Biblioteca_CLA_Devolucion").Value() = (txtcambiodev.Text)

        devolucionesbeli.Update()
        devolucionesbeli.Close()

        txtcedalumdev.Text = ""
        txtnomalumdev.Text = ""
        txtcodlidevol.Text = ""
        txtcedalumdev.Text = ""
        txtapealumdev.Text = ""
        txtfecdev.Text = ""
        cbtipodedev.Text = ""
        cbtipodecobdev.Text = ""
        txtmontocobrswv.Text = ""
        txtmontoconpagadev.Text = ""
        txtcambiodev.Text = ""

        MsgBox("Los datos de la devolucion han sido modificados")
        Exit Sub
Control:
        MsgBox(Err.Number & " - " & Err.Description)
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        On Error GoTo Control
        Dim consulta As String

        If txtcedalumdev.Text = "" Then
            MsgBox("Debe digitar el codigo de devoluciones")
            Exit Sub
        ElseIf txtnomalumdev.Text = "" Then
            MsgBox("Debe digitar el nombre del estudiante")
            Exit Sub
        ElseIf txtapealumdev.Text = "" Then
            MsgBox("Debe digitar los apellidos del estudiante")
            Exit Sub
        ElseIf txtcodlidevol.Text = "" Then
            MsgBox("Debe digitar el codigo del libro")
            Exit Sub
        ElseIf txtcedalumdev.Text = "" Then
            MsgBox("Debe digitar la cedula del estudiante")
            Exit Sub
        ElseIf txtfecdev.Text = "" Then
            MsgBox("Debe digitar la fecha")
            Exit Sub
        ElseIf cbtipodecobdev.Text = "" Then
            MsgBox("Debe seleccionar el tipo de cobro")
            Exit Sub
        ElseIf cbtipodedev.Text = "" Then
            MsgBox("Debe seleccionar el tipo de devolucion")
            Exit Sub
        ElseIf txtmontocobrswv.Text = "" Then
            MsgBox("Debe digitar el monto de cobro")
            Exit Sub
        ElseIf txtmontoconpagadev.Text = "" Then
            MsgBox("Debe digitar el monto con que paga")
            Exit Sub
        ElseIf txtcambiodev.Text = "" Then
            MsgBox("Debe calcular el cambio")
            Exit Sub
        End If
        devolucionesbeli = New ADODB.Recordset
        consulta = "Select * from b_d_biblioteca_cla_devolucion where cod_dev_B_D_Biblioteca_CLA_Devolucion = '" & txtcodigodev.Text & "'"
        devolucionesbeli.Open(consulta, conexion,
                ADODB.CursorTypeEnum.adOpenKeyset,
                ADODB.LockTypeEnum.adLockOptimistic)


        

        If devolucionesbeli.BOF And devolucionesbeli.EOF Then
            MsgBox("La devolucion no existe", 0 + 64)
            devolucionesbeli.Close()
            txtcodigodev.Clear()
            Exit Sub
        End If

        txtcodigodev.Text = devolucionesbeli.Fields("cod_dev_B_D_Biblioteca_CLA_Devolucion").Value()
        txtcodlidevol.Text = devolucionesbeli.Fields("cod_lib_B_D_Biblioteca_CLA_Devolucion").Value()
        txtcedalumdev.Text = devolucionesbeli.Fields("ced_alum_B_D_Biblioteca_CLA_Devolucion").Value()
        txtnomalumdev.Text = devolucionesbeli.Fields("nom_alum_B_D_Biblioteca_CLA_Devolucion").Value()
        txtapealumdev.Text = devolucionesbeli.Fields("apell_alum_B_D_Biblioteca_CLA_Devolucion").Value()
        txtfecdev.Text = devolucionesbeli.Fields("fech_prest_B_D_Biblioteca_CLA_Devolucion").Value()
        cbtipodedev.Text = devolucionesbeli.Fields("tipo_dev_B_D_Biblioteca_CLA_Devolucion").Value()
        cbtipodecobdev.Text = devolucionesbeli.Fields("tipo_cob_B_D_Biblioteca_CLA_Devolucion").Value()
        txtmontocobrswv.Text = devolucionesbeli.Fields("monto_cob_B_D_Biblioteca_CLA_Devolucion").Value()
        txtmontoconpagadev.Text = devolucionesbeli.Fields("monto_pag_B_D_Biblioteca_CLA_Devolucion").Value()
        txtcambiodev.Text = devolucionesbeli.Fields("cambio_B_D_Biblioteca_CLA_Devolucion").Value()

       
        devolucionesbeli.Close()
        MsgBox("Los datos han sido encontrados")
        Exit Sub
Control:
        MsgBox(Err.Number & "- " & Err.Description)

    End Sub

    Private Sub devoluciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim cerrar As Integer
        cerrar = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.OkCancel, "Devoluciones")

        If cerrar = 2 Then
            e.Cancel = True
            Me.Show()
        ElseIf cerrar = 1 Then
            e.Cancel = False
        End If
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        Dim paga, cambio, cobro As Double
        paga = txtmontoconpagadev.Text
        cobro = txtmontocobrswv.Text
        If paga >= cobro Then
            cambio = paga - cobro
            txtcambiodev.Text = cambio
        Else
            MsgBox("No se puede realizar el pago porque no le alcanza", 0 + 64, "Devoluciones")
        End If

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        On Error GoTo Control
        Dim consulta, valor As String

        If txtcedalumdev.Text = "" Then
            MsgBox("Debe digitar el codigo de devoluciones")
            Exit Sub
        ElseIf txtnomalumdev.Text = "" Then
            MsgBox("Debe digitar el nombre del estudiante")
            Exit Sub
        ElseIf txtapealumdev.Text = "" Then
            MsgBox("Debe digitar los apellidos del estudiante")
            Exit Sub
        ElseIf txtcodlidevol.Text = "" Then
            MsgBox("Debe digitar el codigo del libro")
            Exit Sub
        ElseIf txtcedalumdev.Text = "" Then
            MsgBox("Debe digitar la cedula del estudiante")
            Exit Sub
        ElseIf txtfecdev.Text = "" Then
            MsgBox("Debe digitar la fecha")
            Exit Sub
        ElseIf cbtipodecobdev.Text = "" Then
            MsgBox("Debe seleccionar el tipo de cobro")
            Exit Sub
        ElseIf cbtipodedev.Text = "" Then
            MsgBox("Debe seleccionar el tipo de devolucion")
            Exit Sub
        ElseIf txtmontocobrswv.Text = "" Then
            MsgBox("Debe digitar el monto de cobro")
            Exit Sub
        ElseIf txtmontoconpagadev.Text = "" Then
            MsgBox("Debe digitar el monto con que paga")
            Exit Sub
        ElseIf txtcambiodev.Text = "" Then
            MsgBox("Debe calcular el cambio")
            Exit Sub
        End If
        devolucionesbeli = New ADODB.Recordset
        consulta = "Select * from b_d_biblioteca_cla_devolucion where cod_dev_B_D_Biblioteca_CLA_Devolucion = '" & txtcodigodev.Text & "'"
        devolucionesbeli.Open(consulta, conexion,
                ADODB.CursorTypeEnum.adOpenKeyset,
                ADODB.LockTypeEnum.adLockOptimistic)




        If devolucionesbeli.RecordCount = 0 Then
            MsgBox("La devolucion no existe", 0 + 64)
            devolucionesbeli.Close()
            txtcodigodev.Clear()
            Exit Sub
        End If
        valor = MsgBox("Esta seguro que desea eliminar los datos de la devolucion", 4 + 32 + 256, "Devoluciones")
        If valor = 6 Then
            devolucionesbeli.Delete()
            txtcedalumdev.Text = ""
            txtnomalumdev.Text = ""
            txtcodlidevol.Text = ""
            txtcedalumdev.Text = ""
            txtapealumdev.Text = ""
            txtfecdev.Text = ""
            cbtipodedev.Text = ""
            cbtipodecobdev.Text = ""
            txtmontocobrswv.Text = ""
            txtmontoconpagadev.Text = ""
            txtcambiodev.Text = ""


            MsgBox("Los datos de la devolucion han sido borrados", 0 + 64, "Devoluciones")
        ElseIf valor = 7 Then
            devolucionesbeli.Close()
        End If
        Exit Sub
Control: MsgBox(Err.Number & " - " & Err.Description)
    End Sub

    Private Sub cbtipodedev_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtipodedev.SelectedIndexChanged
        If cbtipodedev.Text = "Cobro" Then
            cbtipodecobdev.Enabled = True
        ElseIf cbtipodedev.Text = "Normal" Then
            txtcambiodev.Text = "000000000"
            txtmontocobrswv.Text = "000000000"
            txtmontoconpagadev.Text = "000000000"
        End If
    End Sub

    Private Sub cbtipodecobdev_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtipodecobdev.SelectedIndexChanged
        If cbtipodecobdev.Text = "Atraso" Then
            txtmontocobrswv.Text = 1250 + (1250 * 0.03) - (1250 * 0.07)
            txtmontoconpagadev.Text = ""
            txtcambiodev.Text = ""
        ElseIf cbtipodecobdev.Text = "Reposicion" Then
            txtmontocobrswv.Text = 20000 + (20000 * 0.13) - (20000 * 0.02)
        End If
    End Sub
End Class

