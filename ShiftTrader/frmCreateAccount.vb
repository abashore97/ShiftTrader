' Abigail Bashore
' INFO 3100

Imports System.IO
Imports System.Text.RegularExpressions

Public Class frmCreateAccount
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ' gather information from form
        Dim firstName = txtFirstName.Text
        Dim lastName = txtLastName.Text
        Dim email = txtEmail.Text
        Dim userName = txtUsername.Text
        Dim password = txtPassword.Text


        Dim duplicateAccount = findAccount(firstName, lastName)
        Dim duplicateUsername = findAccount(userName)


        If Not IsNothing(duplicateAccount) Then
            ' Make sure the account you are creating doesnt already exist
            MsgBox("An account with the associated name already exists!", MsgBoxStyle.Exclamation)
        ElseIf Not IsNothing(duplicateUsername) Then
            ' Make sure that the username entered does not already exist
            MsgBox("This username has already been taken!", MsgBoxStyle.Exclamation)
        Else
            ' This is a new account, go ahead and validate
            validateAccount(firstName, lastName, email, userName, password)
        End If
    End Sub

    ' the user decided to not create account. Close form without saving any information
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' validateAccount
    ' makes sure that the information entered is valid (e.g. the email entered is a valid email).
    Private Sub validateAccount(firstName As String, lastName As String, email As String, username As String, password As String)

        ' first and last names should start with a uppercase letter, followed by a sequence of lowercase letters
        Dim nameMatch As Regex = New Regex("[A-Z][a-z]+")

        ' emails can contain any sequence of letters and digits (with an optional dot) 
        ' followed by @ And a domain With .com, .org, .net, or .edu
        Dim emailMatch As Regex = New Regex("[A-Za-z0-9]+(\.)?[A-Za-z0-9]+\@[a-z]+\.(com|org|net|edu)")

        ' passwords should be 8 to 20 characters long
        Dim passwordMatch As Regex = New Regex("[A-Za-z0-9]{8,20}")

        ' if everything matches, then we have a valid account.
        If emailMatch.IsMatch(email) And nameMatch.IsMatch(firstName) And nameMatch.IsMatch(lastName) And passwordMatch.IsMatch(password) Then
            writeToFile("Accounts.txt", {firstName, lastName, email, username, password})
            Me.Close()
        Else
            MsgBox("Some of the information you entered may be invalid. Please Try Again.", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class