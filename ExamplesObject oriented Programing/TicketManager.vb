
Imports System.IO
Public Class TicketManager
    Private TicketQueue As New TicketQueue
    Public ResolvedTicketList As New ResolvedTicketsList
    'new array list as not tickque
    Private ClosedTicketList As New ArrayList
    Private Sub btnAddTicket_Click(sender As Object, e As EventArgs) Handles btnAddTicket.Click

        Dim newTicket As New Ticket
        newTicket.Issue = txtTicketIsssue.Text
        newTicket.Reporter = txtTicketReporter.Text
        newTicket.severity = CInt(numTicketSeverity.Value)
        newTicket.dateReported = Date.Now()
        'newTicket.ticketIDCounter
        'issues here
        TicketQueue.add(newTicket)
        lstTicketList.Items.Add(newTicket)

    End Sub

    Public Sub refreshTicketList()
        lstTicketList.Items.Clear()

        For Each t As Ticket In TicketQueue
            lstTicketList.Items.Add(t)

        Next
    End Sub
    Private Sub btnDeleteTicket_Click(sender As Object, e As EventArgs) Handles btnDeletTicket.Click

        'If nothing selected, then don't delete anything
        If lstTicketList.SelectedIndex = -1 Then
            MessageBox.Show("You must select a ticket to resolve")
        Else
            'Delete the selected ticket - show a dialog box to collect the
            'resolution description and resolution date
            ResolveTicket.Tag = lstTicketList.SelectedItem
            'write to new array and then populate to new form 

            If ResolveTicket.ShowDialog = DialogResult.OK Then

                TicketQueue.Remove(CType(lstTicketList.SelectedItem, Ticket))
                refreshTicketList()
                ResolvedTicketList.add(CType(ResolveTicket.Tag, Ticket))
                'For Each Ticket In ResolvedTicketList
                '    Ticket = Ticket.ToString & vbCrLf
                '    My.Computer.FileSystem.WriteAllText("C:\test folder\ImportantTicketList.txt", Ticket.ToString, True)
                'Next

            End If
            'we have some more work to do here- gett the information
            'The user enters

        End If
    End Sub


    'Item property to read or update


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'this is equivalent to the save button 


        'declare resovle tid
        Dim ResolveTicketWindow As ResolvedTickets = New ResolvedTickets

        ResolveTicketWindow.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim savedResolvedTicketWindow As savedResolvedTickets = New savedResolvedTickets
        savedResolvedTicketWindow.Show()

        'decltar resolve

        'Dim FileString As String = ""
        'Dim FileFinder As New OpenFileDialog
        'If FileFinder.ShowDialog = Windows.Forms.DialogResult.OK Then
        '    If (FileFinder.FileName IsNot Nothing) Then
        '        FileFinder.OpenFile()
        '        My.Computer.FileSystem.ReadAllText(FileFinder.FileName)


        '        'My.Computer.FileSystem.WriteAllText("C:\Users\harry\Documents\Resolved Tickets.txt", Item.ToString, True)
        '    End If
        'End If
    End Sub

    Private Function Int() As Integer
        Throw New NotImplementedException
    End Function

End Class
