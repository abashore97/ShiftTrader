Imports System.IO

Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Access what the user put in the form 
        Dim userName = txtUserName.Text
        Dim password = txtPassword.Text

        ' In case the user doesn't enter one or both of the required fields
        If userName = "" Or password = "" Then
            MsgBox("Please enter a username and a password to continue", MsgBoxStyle.Information)
        End If

        verifyLoginInfo(userName, password)


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
    Private Function verifyLoginInfo(userName As String, password As String) As Boolean
        If File.Exists("Accounts.txt") Then
            Dim reader As StreamReader = File.OpenText("Accounts.txt")
            Dim accountInfo As String
            Do Until reader.EndOfStream
                accountInfo = reader.ReadLine ' grabs all the account information for one person
                Dim accountProperties = accountInfo.Split(", ") '  allows us to examine properties separately 

                ' the usernames are the 4th thing listed
                Dim expectedUserName = accountProperties(3).Trim
                ' finds a valid username first, then we examine the password
                If expectedUserName = userName Then
                    Dim expectedPassword = accountProperties(4).Trim

                    If expectedPassword = password Then
                        saveLoginInfo(accountProperties)
                        reader.Close()
                        Return True
                    Else
                        ' we know the username that the user entered exists, but they typed their password wrong
                        MsgBox("The password you entered is incorrect! Please Try Again", MsgBoxStyle.Exclamation
                               )
                        reader.Close()
                        Return False
                    End If
                End If
            Loop
            ' reaching the end of the file implies that we never found a user with the specified username
            MsgBox("The username you entered does not exist! Please Try Again",
                   MsgBoxStyle.Exclamation)
            reader.Close()
        End If
        Return False
    End Function


End Class
