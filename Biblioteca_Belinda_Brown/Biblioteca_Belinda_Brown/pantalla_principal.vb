Public Class pantalla_principal

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

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

    Private Sub DevolucionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolucionesToolStripMenuItem.Click
        Me.Hide()
        devoluciones.Show()

    End Sub

    Private Sub pantalla_principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error GoTo control
        Dim strconexion As String
        conexion = New ADODB.Connection
        strconexion = "Driver={MySQL ODBC 3.51 Driver};Server=localhost;" & "Database=B_D_Belinda_Bibliioteca_CLA;User=root;Password=labcla;port=3306"
        conexion.Open(strconexion)
        Exit Sub
control:
        MsgBox("No se realizo la conexion." & Err.Description)
    End Sub

    Private Sub pantalla_principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim cerrar As Integer
        cerrar = MsgBox("¿Esta seguro que desea salir?", MsgBoxStyle.OkCancel, "Pantalla principal")

        If cerrar = 2 Then
            e.Cancel = True
            Me.Show()
        ElseIf cerrar = 1 Then
            e.Cancel = False
        End If
    End Sub
End Class
