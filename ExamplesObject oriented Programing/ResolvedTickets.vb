Public Class ResolvedTickets

    Private Sub ResolvedTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each Item As Ticket In TicketManager.ResolvedTicketList
            lstResolvedtickets.Items.Add(Item)


        Next
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim FileFinder As New SaveFileDialog
        'Dim ticketManagerWindow As TicketManager = New TicketManager
        If FileFinder.ShowDialog = Windows.Forms.DialogResult.OK Then
            If (FileFinder.FileName IsNot Nothing) Then
                For Each Item As Ticket In TicketManager.ResolvedTicketList
                    My.Computer.FileSystem.WriteAllText(FileFinder.FileName, Item.ToString, True)


                    'My.Computer.FileSystem.WriteAllText("C:\Users\harry\Documents\Resolved Tickets.txt", Item.ToString, True)
                Next
                lstResolvedtickets.Items.Clear()
            End If
        End If
        'ticketManagerWindow.Show()



        'End If
        'For Each Item As Ticket In TicketManager.ResolvedTicketList
        '    My.Computer.FileSystem.WriteAllText("C:\Users\harry\Documents\Resolved Tickets.txt", Item.ToString, True)
        'Next



        'End

        'End Sub

        'Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

        'End Sub
    End Sub
End Class