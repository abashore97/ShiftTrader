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
                deleteSelectedShift()
                lstMyShifts.Items.Clear()
                loadMyShifts()



            End If
        End If
        clearSelectedShift()
    End Sub

    Private Sub btnAddShift_Click(sender As Object, e As EventArgs) Handles btnAddShift.Click
        Me.Close()
        frmAddEditShift.Show()
    End Sub

    Private Sub btnEditShift_Click(sender As Object, e As EventArgs) Handles btnEditShift.Click
        storeSelectedShift(lstMyShifts)
        If selectedShift.Count = 0 Then
            MsgBox("Please select a shift to edit", MsgBoxStyle.Information)
        Else
            Me.Close()
            frmAddEditShift.Show()
        End If

    End Sub

    ' loadMyShifts
    ' Will update the list view provided with the latest OpenShifts.txt
    Public Sub loadMyShifts()
        Dim name As String = loggedOn(0) & " " & loggedOn(1)
        Dim myShifts() As String = findShifts(name)
        For Each shift In myShifts
            ' Create a ListViewItem via String array
            Dim shiftProperties = shift.Split(",")
            Dim item As ListViewItem = New ListViewItem(shiftProperties)
            lstMyShifts.Items.Add(item)

        Next
        ' resize name, date, and location to size of header if list is empty
        If lstMyShifts.Items.Count = 0 Then
            clmName.Width = -2
            clmDate.Width = -2
            clmLocation.Width = -2
        Else
            ' resize to widest entry 
            clmName.Width = -1
            clmDate.Width = -1
            clmLocation.Width = -1
        End If
    End Sub
End Class