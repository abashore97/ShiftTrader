Imports System.IO

Public Class frmForgotPassword
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim username = txtUsername.Text
        Dim newPassword = txtNewPassword.Text
        Dim confirmPassword = txtConfirmPassword.Text

        If username <> "" Or newPassword <> "" Or confirmPassword <> "" Then
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

    Private Sub updatePassword(username As String, newPassword As String)
        If File.Exists("Accounts.txt") Then
            Dim reader As StreamReader = File.OpenText("Accounts.txt")
            Dim writer As StreamWriter = File.CreateText("Temp.txt")
            Dim accountInfo As String
            Do Until reader.EndOfStream
                accountInfo = reader.ReadLine
                Dim accountProperties = accountInfo.Split(",")

                Dim expectedUsername = accountProperties(3).Trim
                If expectedUsername = username Then
                    accountProperties(4) = newPassword
                    accountInfo = String.Join(", ", accountProperties)

                End If
                writer.WriteLine(accountInfo)
            Loop
            reader.Close()
            writer.Close()
            File.Move("Temp.txt", "Accounts.txt")

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class