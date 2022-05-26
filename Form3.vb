Public Class Form3

    Private Sub Panel1_MouseEnter(sender As Object, e As EventArgs)
        Panel1.Select()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Select()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs)
        Panel1.Select()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Panel1.Select()
        ElseIf TabControl1.SelectedIndex = 1 Then
            Panel2.Select()
        End If
    End Sub
End Class