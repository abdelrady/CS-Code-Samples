Module modMain
    Function CheckMultipleInstance() As Boolean
        Dim createdNew As Boolean
        Dim mutexGUID As String = "{EA7A33A4-613E-47e6-95AE-2DF66F5AAE47}"
        Dim mtx As New System.Threading.Mutex(False, mutexGUID, createdNew)
        If createdNew = True Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
