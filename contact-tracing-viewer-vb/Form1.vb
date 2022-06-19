Imports System.IO

Public Class Form1
    Private Sub openBtn_Click(sender As Object, e As EventArgs) Handles openBtn.Click
        Dim form As StreamReader
        Dim ofd As New OpenFileDialog
        ofd.ShowDialog()

        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim contactForm As String = ofd.FileName
            Dim filetext As String = File.ReadAllLines(contactForm As String)


        End If
    End Sub
End Class
