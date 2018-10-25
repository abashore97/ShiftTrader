' Main Module: contains any variables or functions needed for multiple forms
Imports System.IO

Module Main
    ' Stores the information of who is currently logged on
    Public loggedOn(4) As String

    ' Stores the selected shift in open shifts or my shifts
    Public selectedShift As List(Of String) = New List(Of String)


    ' logOut
    ' clears out the loggedOn array for next login 
    Public Sub logOut()
        loggedOn = Nothing
    End Sub

    ' loadShifts
    ' Will update the list view provided with the latest OpenShifts.txt
    Public Sub loadShifts(lstView As ListView)
        Dim name As String = loggedOn(0) & " " & loggedOn(1)
        Dim myShifts() As String = findShifts(name)
        For Each shift In myShifts
            ' Create a ListViewItem via String array
            Dim shiftProperties = shift.Split(",")
            Dim item As ListViewItem = New ListViewItem(shiftProperties)
            lstView.Items.Add(item)

        Next
    End Sub

    ' storeSelectedShift
    ' takes in whatever list view we are selecting from and stores its contents into an array
    Public Sub storeSelectedShift(lstView As ListView)
        Dim selected As ListView.SelectedListViewItemCollection = lstView.SelectedItems
        If selected.Count = 0 Then
            MsgBox("Please select an item to take a shift", MsgBoxStyle.Information)
        Else
            For i = 0 To 5
                selectedShift.Add(selected.Item(0).SubItems(i).Text)
            Next
        End If
    End Sub

    ' deleteShift
    ' delete a shift out when taken
    Public Sub deleteSelectedShift()
        Dim reader As StreamReader
        Dim writer As StreamWriter
        If File.Exists("OpenShifts.txt") Then
            reader = File.OpenText("OpenShifts.txt")
            writer = File.CreateText("Temp.txt")
            Dim shiftInfo As String
            Dim shiftProperties() As String
            Do Until reader.EndOfStream
                shiftInfo = reader.ReadLine
                shiftProperties = shiftInfo.Split(",")

                If shiftProperties(0) <> selectedShift.Item(0) Or
                   shiftProperties(1) <> selectedShift.Item(1) Or
                   shiftProperties(2) <> selectedShift.Item(2) Or
                   shiftProperties(3) <> selectedShift.Item(3) Or
                   shiftProperties(4) <> selectedShift.Item(4) Or
                   shiftProperties(5) <> selectedShift.Item(5) Then

                    writer.WriteLine(shiftInfo)

                End If
            Loop
            reader.Close()
            writer.Close()
            File.Delete("OpenShifts.txt")
            File.Move("Temp.txt", "OpenShifts.txt")
        End If
        selectedShift.Clear()
    End Sub

    ' findShifts
    ' finds all shifts under one name
    Public Function findShifts(name As String) As String()
        Dim myShifts As List(Of String) = New List(Of String)
        Dim reader As StreamReader
        If File.Exists("OpenShifts.txt") Then
            reader = File.OpenText("OpenShifts.txt")
            Dim shiftInfo As String

            Dim shiftProperties() As String
            Do Until reader.EndOfStream
                shiftInfo = reader.ReadLine
                shiftProperties = shiftInfo.Split(",")

                'Add shift information to myShifts Array
                If shiftProperties(0) = name Then
                    myShifts.Add(shiftInfo)
                End If
            Loop
        End If
        reader.Close()
        Return myShifts.ToArray
    End Function

    ' findAccount 
    ' Searches for account holder by first and last name
    Public Function findAccount(firstName As String, lastName As String) As String()
        Dim reader As StreamReader
        If File.Exists("Accounts.txt") Then
            reader = File.OpenText("Accounts.txt")
            Dim accountInfo As String
            Dim accountProperties() As String
            Do Until reader.EndOfStream
                accountInfo = reader.ReadLine
                accountProperties = accountInfo.Split(",")

                If accountProperties(0) = firstName And accountProperties(1) = lastName Then
                    reader.Close()
                    Return accountProperties
                End If
            Loop
        End If
        reader.Close()
        Return {}
    End Function

    ' findAccount
    ' overload: finds account by username instead
    Public Function findAccount(username As String) As String()
        Dim reader As StreamReader
        If File.Exists("Accounts.txt") Then
            reader = File.OpenText("Accounts.txt")
            Dim accountInfo As String
            Dim accountProperties() As String
            Do Until reader.EndOfStream
                accountInfo = reader.ReadLine
                accountProperties = accountInfo.Split(",")

                If accountProperties(3) = username Then
                    reader.Close()
                    Return accountProperties
                End If
            Loop
        End If
        reader.Close()
        Return {}
    End Function

    ' writeToFile
    ' takes the contents and adds them to the specified file 
    Public Sub writeToFile(filename As String, contents As String())
        Dim writer As StreamWriter = File.AppendText(filename)
        Dim newRecord As String = ""
        ' construct line to be written
        For i = 0 To contents.Length - 2
            newRecord = newRecord & contents(i) & ","
        Next

        ' add last item without comma at the end
        newRecord = newRecord & contents.Last

        ' One account's records are stored on one line, seperated by comma
        writer.WriteLine(newRecord)
        writer.Close()
    End Sub
End Module
