' Main Module: contains any variables or functions needed for multiple forms
Module Main
    ' Stores the information of who is currently logged on
    Public loggedOn(4) As String

    ' logOut
    ' clears out the loggedOn array for next login 
    Public Sub logOut()
        For Each propertyLogged In loggedOn
            propertyLogged = " "
        Next
    End Sub
End Module
