Public Class frmAddShift
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmMyShifts.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim name As String = lblName.Text
        Dim dateShift As String = dtpDate.ToString()
        Dim startTime As String = cboStartTime.SelectedText
        Dim endTime As String = cboEndTime.SelectedText
        Dim location As String = cboLocation.SelectedText
        Dim permanent As String

        ' whether the shift needs to be covered for the rest of the quarter is stored as a Yes or No
        If chkPermanent.Checked Then
            permanent = "Yes"
        Else
            permanent = "No"
        End If

        writeToFile("OpenShifts.txt", {name, dateShift, startTime, endTime, location, permanent})
    End Sub

End Class