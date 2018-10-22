' Main Module: contains any variables or functions needed for multiple forms
Module Main
    ' Stores the information of who is currently logged on
    Public loggedOn(4) As String

    ' Stores the selected shift in open shifts
    Public selectedShift(5) As String


    ' logOut
    ' clears out the loggedOn array for next login 
    Public Sub logOut()
        For i = 0 To 4
            loggedOn(i) = ""
        Next
    End Sub
End Module
