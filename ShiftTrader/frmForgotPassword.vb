Imports System.IO

Public Class frmForgotPassword
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ' gather information from text boxes
        Dim username = txtUsername.Text
        Dim newPassword = txtNewPassword.Text
        Dim confirmPassword = txtConfirmPassword.Text

        ' any left empty? prompt user to enter the requitre information
        If username <> "" Or newPassword <> "" Or confirmPassword <> "" Then
            ' make sure that both password fields match
            If confirmPassword = newPassword Then
                updatePassword(username, newPassword)
            Else
                MsgBox("Passwords must match!", MsgBoxStyle.Exclamation)
            End If

        Else
            MsgBox("Please enter your username, and new password to continue", MsgBoxStyle.Information)
        End If

        Me.Close()
    End Sub

    ' the user decided to not change their password, so close the form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub updatePassword(username As String, newPassword As String)
        If File.Exists("Accounts.txt") Then
            Dim reader As StreamReader = File.OpenText("Accounts.txt")
            ' write contents to a temporary file, then move later
            Dim writer As StreamWriter = File.CreateText("Temp.txt")
            Dim accountInfo As String
            Do Until reader.EndOfStream
                accountInfo = reader.ReadLine
                Dim accountProperties = accountInfo.Split(",")

                Dim expectedUsername = accountProperties(3)
                ' find the username that the user is changing the password for
                If expectedUsername = username Then
                    accountProperties(4) = newPassword
                    ' create new account record with new password
                    accountInfo = String.Join(",", accountProperties)

                End If
                ' write account info over to the temporary file
                writer.WriteLine(accountInfo)
            Loop

            reader.Close()
            writer.Close()
            ' updates Account.txt with updated password
            File.Delete("Accounts.txt")
            File.Move("Temp.txt", "Accounts.txt")

        End If
    End Sub
End Class