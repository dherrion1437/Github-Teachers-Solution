Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstTeach.SelectedIndexChanged

        If LstTeach.SelectedIndex = 0 Then
            Picseiler.Image = My.Resources.seiler
        ElseIf LstTeach.SelectedIndex = 1 Then
            Picseiler.Image = My.Resources.green_lady_pic
        ElseIf LstTeach.SelectedIndex = 2 Then
            Picseiler.Image = My.Resources.kukay_pic
        ElseIf LstTeach.SelectedIndex = 3 Then
            Picseiler.Image = My.Resources.selimovis_pic
        ElseIf LstTeach.SelectedIndex = 4 Then
            Picseiler.Image = My.Resources.Image

        End If

    End Sub

    Private Sub Picseiler_Click(sender As Object, e As EventArgs) Handles Picseiler.Click

    End Sub
End Class
