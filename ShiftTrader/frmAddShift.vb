Public Class frmAddShift
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmMyShifts.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

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
    End Sub

    Private Sub frmAddShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLoggedOn.Text = loggedOn(0) & " " & loggedOn(1)
    End Sub
End Class