
Public Class savedResolvedTickets


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FileString As String = ""
        Dim FileFinder As New OpenFileDialog
        If FileFinder.ShowDialog = Windows.Forms.DialogResult.OK Then
            If (FileFinder.FileName IsNot Nothing) Then
                FileFinder.OpenFile()
                My.Computer.FileSystem.ReadAllText(FileFinder.FileName)
            End If
        End If
    End Sub
End Class
