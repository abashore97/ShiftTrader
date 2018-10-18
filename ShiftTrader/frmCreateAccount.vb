Imports System.IO

Public Class frmCreateAccount
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim firstName = txtFirstName.Text
        Dim lastName = txtPassword.Text
        Dim email = txtUserName.Text
        Dim userName = txtEmail.Text
        Dim password = txtLastName.Text

        writeToFile(firstName, lastName, email, userName, password)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub writeToFile(firstName As String, lastName As String, email As String, userName As String, password As String)
        Dim writer As StreamWriter = File.AppendText("Accounts.txt")
        writer.WriteLine(firstName & ", " & lastName & ", " + email & ", " + userName & ", " & password)
        writer.Close()
    End Sub
End Class