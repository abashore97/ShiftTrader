' Main Module: contains any variables or functions needed for multiple forms
Imports System.IO

Module Main
    ' Stores the information of who is currently logged on
    Public loggedOn(4) As String

    ' Stores the selected shift in open shifts
    Public selectedShift(5) As String


    ' logOut
    ' clears out the loggedOn array for next login 
    Public Sub logOut()
        For i = 0 To 4
            loggedOn(i) = ""
        Next
    End Sub

    ' clearSelectedShift
    ' clears the contents of the selected shift array after taking shift
    Public Sub clearSelectedShift()
        For i = 0 To 5
            selectedShift(i) = ""
        Next
    End Sub

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
End Module
