Public Class Form1
    Function fibonacci(ByVal n As Integer) As Integer
        If n < 2 Then
            Return n
        Else
            Return fibonacci(n - 1) + fibonacci(n - 2)
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim deger As Integer
        deger = Val(TextBox1.Text)

        Try
            If TextBox1.Text <> " " Or TextBox1.Text <> 0 Then
                TextBox1.Text = fibonacci(deger)
            End If
        Catch ex As Exception
            MessageBox.Show("Lütfen boşluğu doldurunuz", "Değer Yok", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class
