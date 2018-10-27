' Abigail Bashore
' INFO 3100
Imports System.IO


Public Class frmOpenShifts

    Private Sub frmOpenShifts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadAllShifts()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        ' clear the login information and a selected shift if there was any shift stored in it
        logOut()
        clearSelectedShift()
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub btnTakeShift_Click(sender As Object, e As EventArgs) Handles btnTakeShift.Click
        storeSelectedShift(lstOpenShifts)

        ' cannot take your own shift
        Dim splitName() As String = selectedShift.Item(0).Split(" ")
        If splitName(0) = loggedOn(0) And splitName(1) = loggedOn(1) Then
            MsgBox("You cannot take your own shift", MsgBoxStyle.Exclamation)
        Else
            Me.Close()
            frmTakeShift.Show()
        End If
    End Sub

    Private Sub btnMyShifts_Click(sender As Object, e As EventArgs) Handles btnMyShifts.Click
        ' clear the selected shift if a shift was accidentally selected
        clearSelectedShift()
        Me.Close()
        frmMyShifts.Show()
    End Sub

    ' loadAllShifts
    ' takes all the open shifts and displays them in lstOpenShifts
    Private Sub loadAllShifts()
        If File.Exists("OpenShifts.txt") Then
            Dim shiftInfo() As String = File.ReadAllLines("OpenShifts.txt")
            For Each shift In shiftInfo
                ' Create a ListViewItem via String array
                Dim shiftProperties = shift.Split(",")
                Dim item As ListViewItem = New ListViewItem(shiftProperties)
                lstOpenShifts.Items.Add(item)

            Next
            ' resize name and date to size of header if list is empty
            If lstOpenShifts.Items.Count = 0 Then
                clmName.Width = -2
                clmDate.Width = -2
            Else
                ' resize to widest entry 
                clmName.Width = -1
                clmDate.Width = -1
            End If
        End If
    End Sub
End Class