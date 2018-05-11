Public Class Index
    Private Sub BTNoti_Click(sender As Object, e As EventArgs) Handles BTNoti.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Dim col = 0 ' variable para modificar el color del cerrar ventana

    Private Sub LClosed_MouseMove(sender As Object, e As MouseEventArgs) Handles LClosed.MouseMove
        If col = 0 Then

            LClosed.BackColor = Color.Red
            LClosed.ForeColor = Color.White
            col = 1

        End If

    End Sub

    Private Sub Panel4_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel4.MouseMove
        LClosed.BackColor = Color.White
        LClosed.ForeColor = Color.Black
        col = 0
    End Sub

    Private Sub LClosed_Click(sender As Object, e As EventArgs) Handles LClosed.Click

        End

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BTAlumnos_Click(sender As Object, e As EventArgs) Handles BTAlumnos.Click
        Form1.Show()

    End Sub
End Class
