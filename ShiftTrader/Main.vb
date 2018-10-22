﻿' Main Module: contains any variables or functions needed for multiple forms
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

    ' deleteShift
    ' delete a shift out when taken
    Public Sub deleteShift(name As String, dateShift As String, startTime As String, endTime As String, location As String, permanent As String)
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

                If shiftProperties(0) <> name Or
                   shiftProperties(1) <> dateShift Or
                   shiftProperties(2) <> startTime Or
                   shiftProperties(3) <> endTime Or
                   shiftProperties(4) <> location Or
                   shiftProperties(5) <> permanent Then

                    writer.WriteLine(shiftInfo)

                End If
            Loop
            reader.Close()
            writer.Close()
            File.Delete("OpenShifts.txt")
            File.Move("Temp.txt", "OpenShifts.txt")
        End If
    End Sub
    ' findShift
    ' find a shift in OpenShifts.txt
    Public Function findShift(name As String, dateShift As String, startTime As String, endTime As String, location As String, permanent As String)
        Dim reader As StreamReader
        If File.Exists("OpenShifts.txt") Then
            reader = File.OpenText("OpenShifts.txt")
            Dim shiftInfo As String
            Dim shiftProperties() As String
            Do Until reader.EndOfStream
                shiftInfo = reader.ReadLine
                shiftProperties = shiftInfo.Split(",")

                If shiftProperties(0) = name And
                   shiftProperties(1) = dateShift And
                   shiftProperties(2) = startTime And
                   shiftProperties(3) = endTime And
                   shiftProperties(4) = location And
                   shiftProperties(5) = permanent Then
                    reader.Close()
                    Return shiftProperties
                End If
            Loop
        End If
        reader.Close()
        Return {}
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
End Module
