' Abigail Bashore
' INFO 3100

Imports System.IO

Public Class frmTakeShift
    Private Sub frmTakeShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayEmail()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        txtEmail.Clear()
        txtEmailBody.Clear()
        deleteSelectedShift()
        Me.Close()
        frmOpenShifts.Show()
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

End Class