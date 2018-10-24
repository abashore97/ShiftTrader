Imports System.IO

Public Class frmCreateAccount
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim firstName = txtFirstName.Text
        Dim lastName = txtLastName.Text
        Dim email = txtEmail.Text
        Dim userName = txtUsername.Text
        Dim password = txtPassword.Text

        ' TODO: add verification of email via regex
        writeToFile("Accounts.txt", {firstName, lastName, email, userName, password})
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class