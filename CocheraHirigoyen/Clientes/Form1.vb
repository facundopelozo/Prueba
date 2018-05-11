Public Class Form1

    Dim idalum As Integer = 0
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListadeAlumnos(GridAlum)
        CargaComboBoxCursos(CBCurso)
        Lleg.Text = ""
        Lnom.Text = ""
        Ldni.Text = ""
    End Sub

    Private Sub GridAlum_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridAlum.CellContentClick

    End Sub

    Private Sub GridAlum_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridAlum.CellClick

        idalum = GridAlum.Item(0, GridAlum.CurrentRow.Index).Value.ToString
        '   Dim curso = GridAlum.Item(0, GridAlum.CurrentRow.Index).Value.ToString
        Dim nombre As String
        Dim apellido As String


        Lleg.Text = GridAlum.Item(1, GridAlum.CurrentRow.Index).Value.ToString
        Ldni.Text = GridAlum.Item(2, GridAlum.CurrentRow.Index).Value.ToString
        nombre = GridAlum.Item(3, GridAlum.CurrentRow.Index).Value.ToString
        apellido = GridAlum.Item(4, GridAlum.CurrentRow.Index).Value.ToString()
        Lnom.Text = apellido + " " + nombre
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim confir As MsgBoxResult
        confir = MsgBox("Confirma el Registro del Alumno?", 4 + 256 + 32, "Confirmacion")
        If confir = MsgBoxResult.Yes Then
            If Lleg.Text = "" Then
                MsgBox("Debe seleccionar un registro!!!", 0 + 0 + 16, "ERROR")

                'MVerificacion.LimpioAlumnos()


            Else
                Dim curso
                curso = CBCurso.SelectedValue

                Mfunciones.InsertAlumnos(idalum, curso)
                'PASO TODO A MAYUSCULA
                Lleg.Text = ""
                Lnom.Text = ""
                Ldni.Text = ""
                idalum = 0
                ListadeAlumnos(GridAlum)
                CargaComboBoxCursos(CBCurso)

            End If
        End If
    End Sub
End Class
