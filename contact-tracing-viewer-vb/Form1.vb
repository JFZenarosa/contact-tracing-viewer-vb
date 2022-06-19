Imports System.IO

Public Class Form1
    Private Sub openBtn_Click(sender As Object, e As EventArgs) Handles openBtn.Click
        Dim form As StreamReader
        Dim ofd As New OpenFileDialog
        ofd.ShowDialog()

        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then

            form = New StreamReader(ofd.FileName)
            textReader.Text = form.ReadToEnd

            form.Close()

        End If
    End Sub
End Class
