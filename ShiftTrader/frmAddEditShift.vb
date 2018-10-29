' Abigail Bashore
' INFO 3100
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

        writeToFile("OpenShifts.txt", {name, dateShift, startTime, endTime, location, permanent})

        ' reset form
        dtpDate.ResetText()
        cboStartTime.ResetText()
        cboEndTime.ResetText()
        cboLocation.ResetText()
        chkPermanent.CheckState = False

        ' if a shift was accidentally selected before clicking the add button, clear it from the list
        If selectedShift.Count <> 0 Then
            clearSelectedShift()
        End If


        Me.Close()
        frmMyShifts.Show()
    End Sub

End Class