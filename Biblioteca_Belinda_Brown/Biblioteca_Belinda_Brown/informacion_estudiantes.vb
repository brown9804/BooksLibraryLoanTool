Public Class informacion_estudiantes

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        pantalla_principal.Show()
    End Sub


    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        On Error GoTo control
        Dim consulta As String
        If txtcedestu.Text = "" Then
            MsgBox("Debe digitar el numero de cedula del estudiante")
            Exit Sub

        ElseIf txtnomest.Text = "" Then
            MsgBox("Debe de digitar el nombre del estudiante")
            Exit Sub
        ElseIf txtapeestu.Text = "" Then
            MsgBox("Debe digitar los apellidos del estudiante")
            Exit Sub
        ElseIf txtgenero.Text = "" Then
            MsgBox("Debe de selecionar el sexo del estudiante")
            Exit Sub
        ElseIf txtteleest.Text = "" Then
            MsgBox("Debe de digitar el numero de telefono del estudiante")
            Exit Sub
        End If
        estudiantes = New ADODB.Recordset
        consulta = "Select * from B_D_Biblioteca_Alumno where ced_alum_B_D_Biblioteca_Alumnos = '" & txtcedestu.Text & "'"

        estudiantes.Open(consulta, conexion,
                                             ADODB.CursorTypeEnum.adOpenKeyset,
                                             ADODB.LockTypeEnum.adLockOptimistic)
        If estudiantes.RecordCount > 0 Then
            MsgBox("El alumno ya exite", 0 + 64, "Mantenimiento de Biblioteca")
            estudiantes.Close()
            Exit Sub
        End If
        estudiantes.AddNew()
        estudiantes.Fields("ced_alum_B_D_Biblioteca_Alumnos").Value() = txtcedestu.Text
        estudiantes.Fields("nom_alum_B_D_Biblioteca_Alumnos").Value() = txtnomest.Text
        estudiantes.Fields("ape_alum_B_D_Biblioteca_Alumnos").Value() = txtapeestu.Text
        estudiantes.Fields("telef_alum_B_D_Biblioteca_Alumnos").Value() = txtteleest.Text
        estudiantes.Fields("genero_alum_B_D_Biblioteca_Alumnos").Value() = txtgenero.Text
        estudiantes.Fields("dire_alum_B_D_Biblioteca_Alumnos").Value() = txtdireest.Text
        estudiantes.Fields("email_alum_B_D_Biblioteca_Alumnos").Value() = txtmailestu.Text
        estudiantes.Fields("obser_alum_B_D_Biblioteca_Alumnos").Value() = txtobsees.Text

        estudiantes.Update()
        estudiantes.Close()

        txtapeestu.Clear()
        txtcedestu.Clear()
        txtdireest.Clear()
        txtgenero.Clear()
        txtgenero.Clear()
        txtmailestu.Clear()
        txtnomest.Clear()
        txtobsees.Clear()
        txtteleest.Clear()
        txtcedestu.Focus()

        MsgBox("Los datos del estudiante han sido guardados")
        Exit Sub
control:
        MsgBox(Err.Number & " - " & Err.Description)
    End Sub





    

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtapeestu.Text = ""
        txtcedestu.Text = ""
        txtdireest.Text = ""
        txtmailestu.Text = ""
        txtnomest.Text = ""
        txtobsees.Text = ""
        txtteleest.Text = ""
        txtgenero.Text = ""
        txtcedestu.Focus()
    End Sub

    Private Sub txtcedestu_TextChanged(sender As Object, e As EventArgs) Handles txtcedestu.TextChanged

    End Sub

    Private Sub InformacionDeLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformacionDeLibrosToolStripMenuItem.Click
        Me.Hide()
        informacion_libros.Show()

    End Sub

    Private Sub PrestamosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrestamosToolStripMenuItem.Click
        Me.Hide()
        prestamos.Show()

    End Sub

    Private Sub DevolucionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolucionesToolStripMenuItem.Click
        Me.Hide()
        devoluciones.Show()

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        On Error GoTo Control
        Dim consulta As String
        If txtapeestu.Text = "" Then
            MsgBox("Debe digitar el apellido del alumno")
        ElseIf txtcedestu.Text = "" Then
            MsgBox("Debe digitar la cedula del alumno")
        ElseIf txtdireest.Text = "" Then
            MsgBox("Debe digitar la direccion del alumno")
        ElseIf txtmailestu.Text = "" Then
            MsgBox("Debe digitar el email del alumno")
        ElseIf txtgenero.Text = "" Then
            MsgBox("Debe digitar el genero del alumno")
        ElseIf txtnomest.Text = "" Then
            MsgBox("Debe digitar el nombre del alumno")
        ElseIf txtobsees.Text = "" Then
            MsgBox("Debe digitar las observaciones")
        ElseIf txtteleest.Text = "" Then
            MsgBox("Debe digitar el telefono")
        End If

        estudiantes = New ADODB.Recordset
        consulta = "Select * from B_D_Biblioteca_Alumno where ced_alum_B_D_Biblioteca_Alumnos = " & txtcedestu.Text

        estudiantes.Open(consulta, conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If estudiantes.RecordCount = 0 Then
            MsgBox("El alumno no existe", 0 + 64)
            estudiantes.Close()
            Exit Sub
        End If
        estudiantes.Fields("ced_alum_B_D_Biblioteca_Alumnos").Value() = txtcedestu.Text
        estudiantes.Fields("nom_alum_B_D_Biblioteca_Alumnos").Value() = txtnomest.Text
        estudiantes.Fields("ape_alum_B_D_Biblioteca_Alumnos").Value() = txtapeestu.Text
        estudiantes.Fields("telef_alum_B_D_Biblioteca_Alumnos").Value() = txtteleest.Text
        estudiantes.Fields("genero_alum_B_D_Biblioteca_Alumnos").Value() = txtgenero.Text
        estudiantes.Fields("dire_alum_B_D_Biblioteca_Alumnos").Value() = txtdireest.Text
        estudiantes.Fields("email_alum_B_D_Biblioteca_Alumnos").Value() = txtmailestu.Text
        estudiantes.Fields("obser_alum_B_D_Biblioteca_Alumnos").Value() = txtobsees

        estudiantes.Update()
        estudiantes.Close()
        txtapeestu.Clear()
        txtcedestu.Clear()
        txtmailestu.Clear()
        txtdireest.Clear()
        txtgenero.Clear()
        txtobsees.Clear()
        txtnomest.Clear()
        txtteleest.Clear()
        MsgBox("Los datos han sido modificados")
        Exit Sub
Control:
        MsgBox(Err.Number & " - " & Err.Description)
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        On Error GoTo Control
        Dim consulta As String

        If txtcedestu.Text = "" Then
            MsgBox("Debe digitar el codigo del libro")
            Exit Sub
        End If
        estudiantes = New ADODB.Recordset
        consulta = "Select * from B_D_Biblioteca_Alumnos where ced_alum_B_D_Biblioteca_Alumnos = " & txtcedestu.Text

        estudiantes.Open(consulta, conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If estudiantes.BOF And estudiantes.EOF Then
            MsgBox("El alumno no existe", 0 + 64)
            estudiantes.Close()
            txtcedestu.Clear()
            Exit Sub
        End If
        txtcedestu.Text = (estudiantes.Fields("ced_alum_B_D_Biblioteca_Alumnos")).Value
        txtnomest.Text = (estudiantes.Fields("nom_alum_B_D_Biblioteca_Alumnos")).Value
        txtapeestu.Text = (estudiantes.Fields("ape_alum_B_D_Biblioteca_Alumnos")).Value
        txtteleest.Text = (estudiantes.Fields("telef_alum_B_D_Biblioteca_Alumnos")).Value
        txtgenero.Text = (estudiantes.Fields("genero_alum_B_D_Biblioteca_Alumnos")).Value
        txtdireest.Text = (estudiantes.Fields("dire_alum_B_D_Biblioteca_Alumnos")).Value
        txtmailestu.Text = (estudiantes.Fields("email_alum_B_D_Biblioteca_Alumnos")).Value
        txtobsees.Text = (estudiantes.Fields("obser_alum_B_D_Biblioteca_Alumnos")).Value

        estudiantes.Close()
        MsgBox("Los datos han sido encontrados")
        Exit Sub
Control:
        MsgBox(Err.Number & "- " & Err.Description)

    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        On Error GoTo Control
        Dim valor As Integer
        Dim consulta As String
        If txtapeestu.Text = "" Then
            MsgBox("Debe digitar el apellido del alumno")
        ElseIf txtcedestu.Text = "" Then
            MsgBox("Debe digitar la cedula del alumno")
        ElseIf txtdireest.Text = "" Then
            MsgBox("Debe digitar la direccion del alumno")
        ElseIf txtmailestu.Text = "" Then
            MsgBox("Debe digitar el email del alumno")
        ElseIf txtgenero.Text = "" Then
            MsgBox("Debe digitar el genero del alumno")
        ElseIf txtnomest.Text = "" Then
            MsgBox("Debe digitar el nombre del alumno")
        ElseIf txtobsees.Text = "" Then
            MsgBox("Debe digitar las observaciones")
        ElseIf txtteleest.Text = "" Then
            MsgBox("Debe digitar el telefono")
        End If


        estudiantes = New ADODB.Recordset
        consulta = "Select * from B_D_Biblioteca_Alumnos where ced_alum_B_D_Biblioteca_Alumnos = " & txtcedestu.Text

        estudiantes.Open(consulta, conexion, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If estudiantes.RecordCount = 0 Then
            MsgBox("El alumno no existe", 0 + 64)
            estudiantes.Close()
            Exit Sub
        End If
        valor = MsgBox("Esta seguro que desea eliminar los datos del estudiante", 4 + 32 + 256, "Mantenimiento")
        If valor = 6 Then
            estudiantes.Delete()
            estudiantes.Close()
            txtapeestu.Clear()
            txtcedestu.Clear()
            txtmailestu.Clear()
            txtdireest.Clear()
            txtgenero.Clear()
            txtobsees.Clear()
            txtnomest.Clear()
            txtteleest.Clear()
            MsgBox("Los datos del estudiante han sido eliminados")
        ElseIf valor = 7 Then
            estudiantes.Close()
        End If
        Exit Sub
Control:
        MsgBox(Err.Description & " - " & Err.Number)

    End Sub

    Private Sub informacion_estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub informacion_estudiantes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim cerrar As Integer
        cerrar = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.OkCancel, "Estudiantes")

        If cerrar = 2 Then
            e.Cancel = True
            Me.Show()
        ElseIf cerrar = 1 Then
            e.Cancel = False
        End If
    End Sub
End Class