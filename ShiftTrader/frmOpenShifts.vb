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

End Class