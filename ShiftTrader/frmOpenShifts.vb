Imports System.IO


Public Class frmOpenShifts
    ' loadData
    ' takes all the open shifts and displays them in lstOpenShifts
    Private Sub loadData()
        If File.Exists("OpenShifts.txt") Then
            Dim shiftInfo() As String = File.ReadAllLines("OpenShifts.txt")
            lstOpenShifts.Items.AddRange(shiftInfo)
        End If
    End Sub

    Private Sub frmOpenShifts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub
End Class