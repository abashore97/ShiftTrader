Public Class frmMyShifts

    Private Sub btnOpenShifts_Click(sender As Object, e As EventArgs) Handles btnOpenShifts.Click
        clearSelectedShift()
        Me.Close()
        frmOpenShifts.Show()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        logOut()
        clearSelectedShift()
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub frmMyShifts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myShifts() As String = findShifts(loggedOn(0) & " " & loggedOn(1))
        For Each shift In myShifts
            ' Create a ListViewItem via String array
            Dim shiftProperties = shift.Split(",")
            Dim item As ListViewItem = New ListViewItem(shiftProperties)
            lstMyShifts.Items.Add(item)

        Next
        ' resize name and date columns to widest entry
        clmName.Width = -1
        clmDate.Width = -1
    End Sub
End Class