Module global_

    Public oQry As String
    Public oSched As String
    Public oCompany As SAPbobsCOM.Company
    Public Function oGetDate(oReturnVal As Integer) As String
        Dim myDate As DateTime = Now

        Select Case oReturnVal
            Case 1
                Return myDate.Year

            Case 2
                Return Format(Now, "MM")

            Case 3
                Return Format(Now, "dd")

            Case 4
                Dim MilliSec As DateTime = Now
                Return Format(Now, "HH") & Format(Now, "mm") & myDate.Millisecond 'Format(Now, "ssss")

            Case Else
                Return ""
        End Select
    End Function

End Module
