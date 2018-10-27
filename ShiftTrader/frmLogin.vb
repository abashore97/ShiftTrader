' Abigail Bashore
' INFO 3100
Imports System.IO

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Access what the user put in the form 
        Dim userName = txtUserName.Text
        Dim password = txtPassword.Text

        ' In case the user doesn't enter one or both of the required fields
        If userName <> "" And password <> "" Then
            ' ensure that the username and password entered matches an account
            If verifyLoginInfo(userName, password) Then
                frmOpenShifts.Show()
                Me.Hide()
            End If
        Else
            MsgBox("Please enter a username and a password to continue", MsgBoxStyle.Information)
        End If

        txtUserName.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblCreate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCreateAccount.LinkClicked
        frmCreateAccount.Show()
    End Sub

    Private Sub lblForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblForgotPassword.LinkClicked
        frmForgotPassword.Show()
    End Sub

    ' saveLoginInfo
    ' On a successful login, the user's accountInfo will be saved in an array called loggedOn
    Private Sub saveLoginInfo(accountProperties() As String)
        For i = 0 To 4
            loggedOn(i) = accountProperties(i).Trim
        Next
    End Sub

    ' verifyLoginInfo
    ' takes in a username and password, returns whether or not the username and password are valid
    Private Function verifyLoginInfo(username As String, password As String) As Boolean
        Dim accountInfo() As String = findAccount(username)

        If IsNothing(accountInfo) Then
            MsgBox("The username you entered does not exist! Please Try Again",
                       MsgBoxStyle.Exclamation)
            Return False
        End If

        Dim expectedPassword = accountInfo(4)
        If expectedPassword = password Then
            saveLoginInfo(accountInfo)
            Return True
        Else
            ' we know the username that the username entered exists, but they typed their password wrong
            MsgBox("The password you entered is incorrect! Please Try Again", MsgBoxStyle.Exclamation)
            Return False
        End If
    End Function

    ' findAccount
    ' finds the account information by a given username
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
        Return Nothing
    End Function
End Class
