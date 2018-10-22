Public Class frmTakeShift
    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
        frmOpenShifts.Show()
    End Sub
End Class