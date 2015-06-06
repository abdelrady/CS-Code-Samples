Attribute VB_Name = "Main"
Public TEMPCONN As String

Public Sub Main()

TEMPCONN = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" & App.Path & "\DB\Contact Manager.mdb;Jet OLEDB:Database Password=;Admin"

Load Form1

End Sub

