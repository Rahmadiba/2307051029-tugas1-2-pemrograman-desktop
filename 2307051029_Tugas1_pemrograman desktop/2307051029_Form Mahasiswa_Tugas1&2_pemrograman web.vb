Public Class Form1

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim gender As String = ""

        If rb1.Checked Then
            gender = rb1.Text
        ElseIf rb2.Checked Then
            gender = rb2.Text
        End If

        MessageBox.Show("Hai: " & txtnip.Text & vbCrLf &
                        "NIP: " & txtnama.Text & vbCrLf &
                        "Jenis Kelamin: " & gender & vbCrLf &
                        "Fakultas: " & cbofakultas.Text & vbCrLf &
                        "Jurusan: " & cbojurusan.Text,
                        "Hasil Pengisian",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

End Class
