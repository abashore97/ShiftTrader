Imports System.IO


Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim userName = txtUserName.Text
        Dim password = txtPassword.Text

        verifyLoginInfo(userName, password)


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblCreate_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblCreateAccount.LinkClicked
        frmCreateAccount.Show()
    End Sub

    Function verifyLoginInfo(userName As String, password As String) As Boolean
        If File.Exists("Accounts.txt") Then
            Dim reader As StreamReader = File.OpenText("Accounts.txt")
            Dim accountInfo As String
            Do Until reader.EndOfStream
                accountInfo = reader.ReadLine
                Dim accountProperties = accountInfo.Split(", ")
                Dim expectedUserName = accountProperties(3).Trim
                If expectedUserName = userName Then
                    Dim expectedPassword = accountProperties(4).Trim

                    If expectedPassword = password Then
                        reader.Close()
                        Return True
                    Else
                        MsgBox("The password you entered is incorrect! Please Try Again", MsgBoxStyle.Exclamation
                               )
                        Return False
                    End If
                End If
            Loop
            MsgBox("The username you entered does not exist! Please Try Again",
                   MsgBoxStyle.Exclamation)
            reader.Close()
        End If
        Return False
    End Function
End Class
