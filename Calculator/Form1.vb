Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If RadioButton1.Checked = True Then
                NumericUpDown3.Value = NumericUpDown1.Value + NumericUpDown2.Value
            Else
                NumericUpDown3.Value = NumericUpDown1.Value - NumericUpDown2.Value
            End If
        Catch asklfjasjklfhaslkfjashglkahgasklfh As Exception
        End Try
    End Sub
End Class
