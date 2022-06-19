Imports System.IO

Public Class Form1
    Private Sub openBtn_Click(sender As Object, e As EventArgs) Handles openBtn.Click
        Dim form As StreamReader
        Dim ofd As New OpenFileDialog
        ofd.ShowDialog()
        ofd.InitialDirectory = "C:\\Example"
        If ofd.ShowDialog = DialogResult.OK Then

            form = New StreamReader(ofd.FileName)
            textReader.Text = form.ReadToEnd

            form.Close()

        End If
    End Sub

    Private Sub clrBtn_Click(sender As Object, e As EventArgs) Handles clrBtn.Click
        textReader.Clear()

    End Sub
End Class
