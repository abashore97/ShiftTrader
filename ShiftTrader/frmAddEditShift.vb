' Abigail Bashore
' INFO 3100

Imports System.IO

Public Class frmAddEditShift
    Private Sub frmAddEditShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblLoggedOn.Text = loggedOn(0) & " " & loggedOn(1)

        ' If a shift was selected, we preload the form with information in the selected shift
        If selectedShift.Count <> 0 Then

            dtpDate.Value = DateTime.Parse(selectedShift.Item(1))
            cboStartTime.Text = selectedShift.Item(2)
            cboEndTime.Text = selectedShift.Item(3)
            cboLocation.Text = selectedShift.Item(4)

            ' check the check box if it is indicated as a permanent trade
            If selectedShift.Item(5) = "Yes" Then
                chkPermanent.Checked = True
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' if there was a shift selected, clear that out of the array
        clearSelectedShift()
        Me.Close()
        frmMyShifts.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        ' gather information put into the form
        Dim name As String = lblLoggedOn.Text
        Dim dateShift As String = dtpDate.Value.Date
        Dim startTime As String = cboStartTime.SelectedItem.ToString()
        Dim endTime As String = cboEndTime.SelectedItem.ToString()
        Dim location As String = cboLocation.SelectedItem.ToString()
        Dim permanent As String

        ' whether the shift needs to be covered for the rest of the quarter is stored as a Yes or No
        If chkPermanent.Checked Then
            permanent = "Yes"
        Else
            permanent = "No"
        End If
        ' if we are editing a shift, we should update the file with the new shift
        If selectedShift.Count <> 0 Then
            updateShift({name, dateShift, startTime, endTime, location, permanent})
            clearSelectedShift()
        Else
            ' just add the shift to the bottom of the list
            writeToFile("OpenShifts.txt", {name, dateShift, startTime, endTime, location, permanent})
        End If



        ' reset form
        dtpDate.ResetText()
        cboStartTime.ResetText()
        cboEndTime.ResetText()
        cboLocation.ResetText()
        chkPermanent.CheckState = False


        Me.Close()
        frmMyShifts.Show()
    End Sub

    ' update shift
    ' when editing a shift, update the shift information
    Private Sub updateShift(newShift As String())
        If File.Exists("OpenShifts.txt") Then
            Dim reader As StreamReader = File.OpenText("OpenShifts.txt")
            ' write contents to a temporary file, then move later
            Dim writer As StreamWriter = File.CreateText("Temp.txt")
            Dim shiftInfo As String
            Do Until reader.EndOfStream
                ' grab shift information
                shiftInfo = reader.ReadLine
                Dim shiftProperties = shiftInfo.Split(",")

                ' if the line we read is the selected shift, then update properties and write
                If shiftProperties(0) = selectedShift.Item(0) And
                   shiftProperties(1) = selectedShift.Item(1) And
                   shiftProperties(2) = selectedShift.Item(2) And
                   shiftProperties(3) = selectedShift.Item(3) And
                   shiftProperties(4) = selectedShift.Item(4) And
                   shiftProperties(5) = selectedShift.Item(5) Then


                    shiftInfo = String.Join(",", newShift)
                End If
                ' write account info over to the temporary file
                writer.WriteLine(shiftInfo)
            Loop

            reader.Close()
            writer.Close()
            ' updates Account.txt with updated password
            File.Delete("OpenShifts.txt")
            File.Move("Temp.txt", "OpenShifts.txt")
        End If

    End Sub

End Class