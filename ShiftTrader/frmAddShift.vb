Public Class frmAddShift
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmMyShifts.Show()
    End Sub
End Class