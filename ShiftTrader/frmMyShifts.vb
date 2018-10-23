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
        loadMyShifts()
    End Sub

    Private Sub btnDeleteShift_Click(sender As Object, e As EventArgs) Handles btnDeleteShift.Click
        storeSelectedShift(lstMyShifts)
        If selectedShift.Count = 0 Then
            MsgBox("Please select a shift to delete", MsgBoxStyle.Information)
        Else
            Dim result As MsgBoxResult = MsgBox("Are you sure you want to delete this shift?", MsgBoxStyle.YesNo)
            If result = vbYes Then
                deleteShift(selectedShift)
                lstMyShifts.Items.Clear()
                loadMyShifts()
            End If
        End If
    End Sub

    Private Sub loadMyShifts()
        Dim name As String = loggedOn(0) & " " & loggedOn(1)
        Dim myShifts() As String = findShifts(name)
        For Each shift In myShifts
            ' Create a ListViewItem via String array
            Dim shiftProperties = shift.Split(",")
            Dim item As ListViewItem = New ListViewItem(shiftProperties)
            lstMyShifts.Items.Add(item)

        Next
        ' resize name and date to size of header if list is empty
        If lstMyShifts.Items.Count = 0 Then
            clmName.Width = -2
            clmDate.Width = -2
        Else
            ' resize to widest entry 
            clmName.Width = -1
            clmDate.Width = -1
        End If

    End Sub
End Class