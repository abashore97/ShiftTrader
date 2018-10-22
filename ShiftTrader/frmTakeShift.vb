Public Class frmTakeShift
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        txtEmail.Clear()
        txtEmailBody.Clear()
        clearSelectedShift()
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
            "Hello, " & vbCrLf & vbCrLf & "I am able to take your shift on" & selectedShift(1) & " from " & selectedShift(2) &
            " to " & selectedShift(3) & " at " & selectedShift(4) & "." & vbCrLf & vbCrLf & "Sincerely, " & vbCrLf & loggedOn(0) & " " & loggedOn(1)
        txtEmailBody.Text = message

    End Sub

    ' getEmail
    ' gets the email of the coworker you're taking the shift from
    Private Function getEmail() As String
        Dim splitName() As String = selectedShift(0).Split(" ")
        Dim accountInfo() As String = findAccount(splitName(0), splitName(1))
        Return accountInfo(2)
    End Function

End Class