' Irke Konzolo
' SCT211-0081/2022
' BSC Computer Science
' Design and Implementation of Computer Applications
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Main Form"
        Me.BackColor = Color.White
        Button1.Text = "Load Object Demo"
        Button1.Name = "btnLoadObjectDemo"
        ToolTip1.SetToolTip(Button1, "Click to load Object Demonstrations form")
        Button2.Text = "Exit"
        Button2.Name = "btnExit"
        Label1.Text = "Click anywhere on the form to maximize and change background color to RED"
        Label1.Name = "lblInstructions"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ObjectDemoForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub
End Class