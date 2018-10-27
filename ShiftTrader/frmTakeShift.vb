Imports System.IO

Public Class frmTakeShift
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        txtEmail.Clear()
        txtEmailBody.Clear()
        deleteSelectedShift()
        Me.Close()
        frmOpenShifts.Show()
    End Sub

    Private Sub frmTakeShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayEmail()
    End Sub

    ' displayEmail
    ' takes contents from selected shift and formats it into an email
    Private Sub displayEmail()
        txtEmail.Text = getEmail()
        Dim message As String =
            "Hello, " & vbCrLf & vbCrLf & "I am able to take your shift on" & selectedShift.Item(1) & " from " & selectedShift.Item(2) &
            " to " & selectedShift.Item(3) & " at " & selectedShift.Item(4) & "." & vbCrLf & vbCrLf & "Sincerely, " & vbCrLf & loggedOn(0) & " " & loggedOn(1)
        txtEmailBody.Text = message

    End Sub

    ' getEmail
    ' gets the email of the coworker you're taking the shift from
    Private Function getEmail() As String
        Dim splitName() As String = selectedShift.Item(0).Split(" ")
        Dim accountInfo() As String = findAccount(splitName(0), splitName(1))
        Return accountInfo(2)
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

End Class