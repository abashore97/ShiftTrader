Imports System.IO


Public Class frmOpenShifts
    ' loadData
    ' takes all the open shifts and displays them in lstOpenShifts
    Private Sub loadData()

        If File.Exists("OpenShifts.txt") Then
            Dim shiftInfo() As String = File.ReadAllLines("OpenShifts.txt")
            For Each shift In shiftInfo
                ' Create a ListViewItem via String array
                Dim shiftProperties = shift.Split(",")
                Dim item As ListViewItem = New ListViewItem(shiftProperties)
                lstOpenShifts.Items.Add(item)

            Next
            ' resize name and date columns to widest entry
            clmName.Width = -1
            clmDate.Width = -1
        End If
    End Sub

    Private Sub frmOpenShifts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        logOut()
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub btnTakeShift_Click(sender As Object, e As EventArgs) Handles btnTakeShift.Click
        Dim selected As ListView.SelectedListViewItemCollection = lstOpenShifts.SelectedItems
        If selected.Count = 0 Then
            MsgBox("Please select an item to take a shift", MsgBoxStyle.Information)
        Else
            For i = 0 To 5
                selectedShift(i) = selected.Item(0).SubItems(i).Text
            Next
            frmTakeShift.Show()
            Me.Hide()
        End If
    End Sub
End Class