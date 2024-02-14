' Irke Konzolo
' SCT211-0081/2022
' BSC Computer Science
' Design and Implementation of Computer Applications

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Image files (.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png | All files (.) | *."
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.ImageLocation = openFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ApplyFontStyle()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        ApplyFontStyle()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        ApplyFontStyle()
    End Sub

    Private Sub ApplyFontStyle()
        Dim style As FontStyle = FontStyle.Regular

        If ComboBox2.SelectedItem IsNot Nothing Then
            If ComboBox2.SelectedItem.ToString() = "Bold" Then
                style = style Or FontStyle.Bold
            ElseIf ComboBox2.SelectedItem.ToString() = "Italic" Then
                style = style Or FontStyle.Italic
            ElseIf ComboBox2.SelectedItem.ToString() = "Bold Italic" Then
                style = style Or FontStyle.Bold Or FontStyle.Italic
            End If
        End If

        Dim color As Color = Color.Black

        If ComboBox3.SelectedItem IsNot Nothing Then
            Select Case ComboBox3.SelectedItem.ToString()
                Case "Red"
                    color = Color.Red
                Case "Green"
                    color = Color.Green
                Case "Blue"
                    color = Color.Blue
            End Select
        End If

        TextBox1.Font = New Font(ComboBox1.SelectedItem.ToString(), 12, style)
        TextBox1.ForeColor = color
    End Sub
End Class